using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkAllowLowercase.Checked = Properties.Settings.Default.AllowLowercase;
            chkRequireLowercase.Checked = Properties.Settings.Default.RequireLowercase;
            chkAllowUppercase.Checked = Properties.Settings.Default.AllowUppercase;
            chkRequireUppercase.Checked = Properties.Settings.Default.RequireUppercase;
            chkAllowNumber.Checked = Properties.Settings.Default.AllowNumber;
            chkRequireNumber.Checked = Properties.Settings.Default.RequireNumber;
            chkAllowSpecial.Checked = Properties.Settings.Default.AllowSpecial;
            chkRequireSpecial.Checked = Properties.Settings.Default.RequireSpecial;
            chkAllowUnderscore.Checked = Properties.Settings.Default.AllowUnderscore;
            chkRequireUnderscore.Checked = Properties.Settings.Default.RequireUnderscore;
            chkAllowSpace.Checked = Properties.Settings.Default.AllowSpace;
            chkRequireSpace.Checked = Properties.Settings.Default.RequireSpace;
            txtOther.Text = Properties.Settings.Default.Other;
            chkAllowOther.Checked = Properties.Settings.Default.AllowOther;
            chkRequireOther.Checked = Properties.Settings.Default.RequireOther;
            txtMinLength.Text = Properties.Settings.Default.MinLength.ToString();
            txtMaxLength.Text = Properties.Settings.Default.MaxLength.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                txtPassword.Text = RandomPassword();
                Clipboard.Clear();
                Clipboard.SetText(txtPassword.Text);
                txtPassword.Enabled = true;
                btnSave.Enabled = true;
                lblCopied.Text = "Kopyalandı...";
                tmrClearCopied.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtPassword.SelectAll();
            //txtPassword.Focus();
        }

        // Generate a password that meets the reuirements.
        private string RandomPassword()
        {
            const string LOWER = "abcdefghijklmnopqrstuvwxyz";
            const string UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string NUMBER = "0123456789";
            const string SPECIAL = @"~!@#$%^&*():;[]{}<>,.?/\|";
            string other = txtOther.Text;
            if (chkRequireOther.Checked && (other.Length < 1))
            {
                MessageBox.Show("Boş bir dizeden karakter talep edemezsiniz.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOther.Focus();
                return txtPassword.Text;
            }

            // Make a list of allowed characters.
            string allowed = "";
            if (chkAllowLowercase.Checked) allowed += LOWER;
            if (chkAllowUppercase.Checked) allowed += UPPER;
            if (chkAllowNumber.Checked) allowed += NUMBER;
            if (chkAllowSpecial.Checked) allowed += SPECIAL;
            if (chkAllowUnderscore.Checked) allowed += "_";
            if (chkAllowSpace.Checked) allowed += " ";
            if (chkAllowOther.Checked) allowed += other;

            // Pick the number of characters.
            int min_chars = int.Parse(txtMinLength.Text);
            int max_chars = int.Parse(txtMaxLength.Text);
            int num_chars = Crypto.RandomInteger(min_chars, max_chars);

            // Satisfy requirements.
            string password = "";
            if (chkRequireLowercase.Checked &&
                (password.IndexOfAny(LOWER.ToCharArray()) == -1))
                password += RandomChar(LOWER);
            if (chkRequireUppercase.Checked &&
                (password.IndexOfAny(UPPER.ToCharArray()) == -1))
                password += RandomChar(UPPER);
            if (chkRequireNumber.Checked &&
                (password.IndexOfAny(NUMBER.ToCharArray()) == -1))
                password += RandomChar(NUMBER);
            if (chkRequireSpecial.Checked &&
                (password.IndexOfAny(SPECIAL.ToCharArray()) == -1))
                password += RandomChar(SPECIAL);
            if (chkRequireUnderscore.Checked &&
                (password.IndexOfAny("_".ToCharArray()) == -1))
                password += "_";
            if (chkRequireSpace.Checked &&
                (password.IndexOfAny(" ".ToCharArray()) == -1))
                password += " ";
            if (chkRequireOther.Checked &&
                (password.IndexOfAny(other.ToCharArray()) == -1))
                password += RandomChar(other);

            // Add the remaining characters randomly.
            while (password.Length < num_chars)
                password += allowed.Substring(
                    Crypto.RandomInteger(0, allowed.Length - 1), 1);

            // Randomize (to mix up the required characters at the front).
            password = RandomizeString(password);

            return password;
        }

        // Return a random character from a string.
        private string RandomChar(string str)
        {
            return str.Substring(Crypto.RandomInteger(0, str.Length - 1), 1);
        }

        // Return a random permutation of a string.
        private string RandomizeString(string str)
        {
            string result = "";
            while (str.Length > 0)
            {
                // Pick a random character.
                int i = Crypto.RandomInteger(0, str.Length - 1);
                result += str.Substring(i, 1);
                str = str.Remove(i, 1);
            }
            return result;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.AllowLowercase = chkAllowLowercase.Checked;
            Properties.Settings.Default.RequireLowercase = chkRequireLowercase.Checked;
            Properties.Settings.Default.AllowUppercase = chkAllowUppercase.Checked;
            Properties.Settings.Default.RequireUppercase = chkRequireUppercase.Checked;
            Properties.Settings.Default.AllowNumber = chkAllowNumber.Checked;
            Properties.Settings.Default.RequireNumber = chkRequireNumber.Checked;
            Properties.Settings.Default.AllowSpecial = chkAllowSpecial.Checked;
            Properties.Settings.Default.RequireSpecial = chkRequireSpecial.Checked;
            Properties.Settings.Default.AllowUnderscore = chkAllowUnderscore.Checked;
            Properties.Settings.Default.RequireUnderscore = chkRequireUnderscore.Checked;
            Properties.Settings.Default.AllowSpace = chkAllowSpace.Checked;
            Properties.Settings.Default.RequireSpace = chkRequireSpace.Checked;
            Properties.Settings.Default.Other = txtOther.Text;
            Properties.Settings.Default.AllowOther = chkAllowOther.Checked;
            Properties.Settings.Default.RequireOther = chkRequireOther.Checked;

            int min_length, max_length;
            if (int.TryParse(txtMinLength.Text, out min_length))
            {
                Properties.Settings.Default.MinLength = min_length;
            }
            if (int.TryParse(txtMaxLength.Text, out max_length))
            {
                Properties.Settings.Default.MaxLength = max_length;
            }

            Properties.Settings.Default.Save();
        }

        private void tmrClearCopied_Tick(object sender, EventArgs e)
        {
            lblCopied.Text = "";
            tmrClearCopied.Enabled = false;
        }

        private void chkRequireLowercase_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRequireLowercase.Checked) chkAllowLowercase.Checked = true;
        }

        private void chkRequireUppercase_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRequireUppercase.Checked) chkAllowUppercase.Checked = true;
        }

        private void chkRequireNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRequireNumber.Checked) chkAllowNumber.Checked = true;
        }

        private void chkRequireSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRequireSpecial.Checked) chkAllowSpecial.Checked = true;
        }

        private void chkRequireUnderscore_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRequireUnderscore.Checked) chkAllowUnderscore.Checked = true;
        }

        private void chkRequireSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRequireSpace.Checked) chkAllowSpace.Checked = true;
        }

        private void chkRequireOther_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRequireOther.Checked) chkAllowOther.Checked = true;
        }

        // Not allowed implies not required.
        private void chkAllowLowercase_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAllowLowercase.Checked) chkRequireLowercase.Checked = false;
        }

        private void chkAllowUppercase_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAllowUppercase.Checked) chkRequireUppercase.Checked = false;
        }

        private void chkAllowNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAllowNumber.Checked) chkRequireNumber.Checked = false;
        }

        private void chkAllowSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAllowSpecial.Checked) chkRequireSpecial.Checked = false;
        }

        private void chkAllowUnderscore_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAllowUnderscore.Checked) chkRequireUnderscore.Checked = false;
        }

        private void chkAllowSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAllowSpace.Checked) chkRequireSpace.Checked = false;
        }

        private void chkAllowOther_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAllowOther.Checked) chkRequireOther.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ayarlar yeni = new Ayarlar();
            yeni.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string passwordToSave = txtPassword.Text;
            SavePasswordToFile(passwordToSave);
        }

        private void SavePasswordToFile(string password)
        {
            DialogResult result = MessageBox.Show("Şifreyi kaydetmek ister misiniz?", "Kaydet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "GeneratedPassword.txt");
                try
                {
                    File.WriteAllText(filePath, password);
                    MessageBox.Show("Şifre başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Şifre kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

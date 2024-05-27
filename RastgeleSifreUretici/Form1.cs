using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleSifreUretici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSifre.Text = "";
            string sifre = "";
            int rnd = 0;

            Random rnd_kh = new Random();
            Random rnd_bh = new Random();
            Random rnd_rk = new Random();

            for (int i = 0; i < Convert.ToInt16(numericBuyuk.Text); i++)
            {
                rnd = rnd_bh.Next(0, txtBuyukHarf.Text.Length - 1);
                txtSifre.Text += txtBuyukHarf.Text[rnd];
            }
            for (int i = 0; i < Convert.ToInt16(numericKucuk.Text); i++)
            {
                rnd = rnd_kh.Next(0, txtKucukHarf.Text.Length - 1);
                txtSifre.Text += txtKucukHarf.Text[rnd];
            }
            for (int i = 0; i < Convert.ToInt16(numericSayi.Text); i++)
            {
                rnd = rnd_rk.Next(0, txtSayilar.Text.Length - 1);
                txtSifre.Text += txtSayilar.Text[rnd];
            }

            Random rnd_karistir = new Random();
            sifre = txtSifre.Text;
            txtSifre.Text = new string(sifre.ToCharArray().OrderBy(s => (rnd_karistir.Next(2) % 2) == 0).ToArray());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

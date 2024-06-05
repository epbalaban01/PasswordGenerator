using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
            labelAppNameAndVersion.Text = "Password Generator - Sürüm: " + Program.GetCurrentVersionToString();
            labelAllRightReserved.Text = "Tüm telif hakları saklıdır. " + AssemblyCopyright;
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        private void RedirectLinkLabels(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string redirectCode = ((LinkLabel)sender).Tag.ToString();
            string redirectUrl = string.Empty;

            switch (redirectCode)
            {
                case "github_repo": redirectUrl = "https://github.com/epbalaban01/PasswordGenerator"; break;
                case "balaban_website": redirectUrl = "http://www.formula1turkey.epizy.com"; break;
                case "balaban_github_page": redirectUrl = "https://github.com/epbalaban01/"; break;
            }

            if (!string.IsNullOrEmpty(redirectUrl))
                System.Diagnostics.Process.Start(redirectUrl);
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {

        }
    }
}

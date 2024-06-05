using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    static class Program
    {
        /* VERSION PROPERTIES */
        /* DO NOT LEAVE THEM EMPTY */

        // Enter current version here
        internal readonly static float Major = 2;
        internal readonly static float Minor = 0;

        /* END OF VERSION PROPERTIES */

        internal static string GetCurrentVersionToString()
        {
            return Major.ToString() + "." + Minor.ToString();
        }

        internal static float GetCurrentVersion()
        {
            return float.Parse(GetCurrentVersionToString());
        }

        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

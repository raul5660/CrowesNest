using System;
using System.Windows.Forms;

namespace CrowesNest
{
    public static class Program
    {
        public static CrowesNest App;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            App = new CrowesNest();
            Application.Run(App);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KuaFu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool showSplash = false;

            if (showSplash)
            {
                ApplicationWithSplash _app = new ApplicationWithSplash();
                _app.Run(args);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }

            
        }
    }
}
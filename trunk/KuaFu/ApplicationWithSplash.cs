using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;

namespace KuaFu
{
    class ApplicationWithSplash : WindowsFormsApplicationBase
    {
        frmMain _main = new frmMain();
        frmSplash _splash = new frmSplash();
        
        public ApplicationWithSplash()
            : base(Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
        {
            this.IsSingleInstance = true;
            this.SplashScreen = _splash;
        }

        protected override void OnCreateMainForm()
        {
            this.MainForm = _main;
        }
    }
}
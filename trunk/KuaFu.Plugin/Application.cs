using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin
{
    public class Application : KuaFu.Plugin.IApplication
    {

        #region IApplication Members

        string IApplication.Name
        {
            get;
            set;
        }

        AxMap IApplication.Map
        {
            get;
            set;
        }

        public string Caption
        {
            get;
            set;
        }

        public string CurrentTool
        {
            get;
            set;
        }

        public System.Windows.Forms.Form MainForm
        {
            get;
            set;
        }

        public Recordset Selection
        {
            get;
            set;
        }

        #endregion

    }
}

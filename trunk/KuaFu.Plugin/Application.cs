using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin
{
    public class Application : KuaFu.Plugin.IApplication
    {
        string _name;
        AxMap _map;
        string _caption;
        string _currentTool;
        Form _mainForm;

        #region IApplication Members

        string IApplication.Name
        {
            get { return _name; }
            set { _name = value; }
        }

        AxMap IApplication.Map
        {
            get { return _map; }
            set { _map = value; }
        }

        public string Caption
        {
            get { return _caption; }
            set { _caption = value; }
        }

        public string CurrentTool
        {
            get { return _currentTool; }
            set { _currentTool = value; }
        }

        public System.Windows.Forms.Form MainForm
        {
            get { return _mainForm; }
            set { _mainForm = value; }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using ESRI.MapObjects2.Core;
using System.Threading;

namespace KuaFu.Plugin.Standard
{
    public class SymbolizationClass : KuaFu.Plugin.ICommand
    {
        IApplication _app;
        
        #region ICommand Members

        public string Name { get { return "Symbolization"; } }

        public string Caption { get { return "���Ż�"; } }

        public void OnClick()
        {
            
        }

        public void OnCreate(IApplication app)
        {
            _app = app;
        }

        public void AfterLayerDraw(object sender, AfterLayerDrawEventArgs e)
        {
        }

        #endregion
    }
}

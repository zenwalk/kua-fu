using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KuaFu.Plugin.Standard
{
    class ShowTableClass : ICommand
    {
        IApplication _app;

        #region ICommand Members

        public string Name
        {
            get { return "ShowTable"; }
        }

        public string Caption
        {
            get { return "属性"; }
        }

        public System.Drawing.Bitmap Bitmap
        {
            get { return null; }
        }

        private frmShowTable _frmShowTable;

        public void OnClick()
        {
            _frmShowTable = new frmShowTable(_app);
            _frmShowTable.ShowDialog(_app.MainForm);
        }

        public void OnCreate(IApplication app)
        {
            _app = app;
        }

        public void AfterLayerDraw(object sender, ESRI.MapObjects2.Core.AfterLayerDrawEventArgs e)
        {
            
        }

        #endregion
    }
}

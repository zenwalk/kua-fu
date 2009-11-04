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

        public void OnClick()
        {
            throw new NotImplementedException();
        }

        public void OnCreate(IApplication app)
        {
            _app = app;
        }

        public void AfterLayerDraw(object sender, ESRI.MapObjects2.Core.AfterLayerDrawEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

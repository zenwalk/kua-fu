using System;
using System.Collections.Generic;
using System.Text;
using ESRI.MapObjects2.Core;
using System.Drawing;

namespace KuaFu.Plugin.Tools
{
    public class FullExtent : ICommand
    {
        IApplication _app;

        #region ICommand 成员

        public void AfterLayerDraw(object sender, AfterLayerDrawEventArgs e)
        {
        }

        public string Name
        {
            get { return "FullExtent"; }
        }

        public string Caption
        {
            get { return "全屏"; }
        }

        public Bitmap Bitmap { get { return new Bitmap("sid.ico"); } }

        public void OnClick()
        {
            _app.Map.Extent = _app.Map.FullExtent;
        }

        public void OnCreate(IApplication app)
        {
            _app = app;
        }

        #endregion
    }
}

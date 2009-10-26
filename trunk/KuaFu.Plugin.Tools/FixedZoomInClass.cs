using System;
using System.Collections.Generic;
using System.Text;
using ESRI.MapObjects2.Core;
using System.Drawing;

namespace KuaFu.Plugin.Tools
{
    public class FixedZoomInClass : ICommand
    {
        IApplication _app;

        #region ICommand 成员

        public void AfterLayerDraw(object sender, AfterLayerDrawEventArgs e)
        {
        }

        public string Name
        {
            get { return "FixedZoomIn"; }
        }

        public string Caption { get { return "放大"; } }

        public Bitmap Bitmap { get { return new Bitmap("sid.ico"); } }

        public void OnClick()
        {
            ESRI.MapObjects2.Core.Rectangle rect = _app.Map.Extent;
            rect.ScaleRectangle(.75);
            _app.Map.Extent = rect;
        }

        public void OnCreate(IApplication app)
        {
            _app = app;
        }

        #endregion
    }
}

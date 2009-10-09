using System;
using System.Collections.Generic;
using System.Text;
using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin.Tools
{
    public class FixedZoomOutClass : ICommand
    {
        IApplication _app;

        #region ICommand 成员

        public void AfterLayerDraw(object sender, AfterLayerDrawEventArgs e)
        {
        }

        public string Name
        {
            get { return "FixedZoomOut"; }
        }

        public string Caption { get { return "缩小"; } }

        public void OnClick()
        {
            Rectangle rect = _app.Map.Extent;
            rect.ScaleRectangle(1.25);
            _app.Map.Extent = rect;
        }

        public void OnCreate(IApplication app)
        {
            _app = app;
        }

        #endregion
    }
}

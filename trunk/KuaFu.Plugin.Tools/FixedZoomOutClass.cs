using System;
using System.Collections.Generic;
using System.Text;
using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin.Tools
{
    public class FixedZoomOutClass : ICommand
    {
        AxMap _map;

        #region ICommand 成员

        public string Name
        {
            get { return "FixedZoomOut"; }
        }

        public string Caption { get { return "缩小"; } }

        public void OnClick()
        {
            Rectangle rect = _map.Extent;
            rect.ScaleRectangle(1.25);
            _map.Extent = rect;
        }

        public void OnCreate(ESRI.MapObjects2.Core.AxMap map)
        {
            _map = map;
        }

        #endregion
    }
}

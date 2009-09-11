using System;
using System.Collections.Generic;
using System.Text;
using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin.Standard
{
    public class ZoomInClass : ICommand
    {
        AxMap _map;

        #region ICommand 成员

        public string Name
        {
            get { return "ZoomIn"; }
        }

        public string Caption
        {
            get { return "放大"; }
        }

        public void OnClick()
        {
            Rectangle rect = _map.Extent;
            rect.ScaleRectangle(.5);
            _map.Extent = rect;
        }

        public void OnCreate(ESRI.MapObjects2.Core.AxMap map)
        {
            _map = map;
        }

        #endregion
    }
}

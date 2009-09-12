using System;
using System.Collections.Generic;
using System.Text;
using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin.Tools
{
    public class FullExtent : ICommand
    {
        AxMap _map;

        #region ICommand 成员

        public string Name
        {
            get { return "FullExtent"; }
        }

        public string Caption
        {
            get { return "全屏"; }
        }

        public void OnClick()
        {
            _map.Extent = _map.FullExtent;
        }

        public void OnCreate(ESRI.MapObjects2.Core.AxMap map)
        {
            _map = map;
        }

        #endregion
    }
}

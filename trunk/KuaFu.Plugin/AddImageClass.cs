using System;
using System.Collections.Generic;
using System.Text;
using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin
{
    public class AddImageClass : ICommand
    {
        AxMap _map;

        #region ICommand Members

        public string Name
        {
            get { return "AddImage"; }
        }

        public string Caption
        {
            get { return "����Ӱ��"; }
        }

        public void OnClick()
        {
            ESRI.MapObjects2.Core.ImageLayer lyr = new ImageLayerClass();
            lyr.File = @"D:\ESRI\AV_GIS30\AVTUTOR\IA_DATA\palmsprings_IRS-1C.img";
            _map.Layers.Add(lyr);
        }

        public void OnCreate(ESRI.MapObjects2.Core.AxMap map)
        {
            this._map = map;
        }

        #endregion
    }
}

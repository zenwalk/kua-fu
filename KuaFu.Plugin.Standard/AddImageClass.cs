using System;
using System.Collections.Generic;
using System.Text;
using ESRI.MapObjects2.Core;
using System.Drawing;

namespace KuaFu.Plugin.Standard
{
    public class AddImageClass : ICommand
    {
        IApplication _app;

        #region ICommand Members

        public string Name
        {
            get { return "AddImage"; }
        }

        public string Caption
        {
            get { return "Ìí¼ÓÓ°Ïñ"; }
        }

        public Bitmap Bitmap { get { return new Bitmap("sid.ico"); } }

        public void OnClick()
        {
            ESRI.MapObjects2.Core.ImageLayer lyr = new ImageLayerClass();
            lyr.File = @"D:\ESRI\AV_GIS30\AVTUTOR\IA_DATA\palmsprings_IRS-1C.img";
            _app.Map.Layers.Add(lyr);
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

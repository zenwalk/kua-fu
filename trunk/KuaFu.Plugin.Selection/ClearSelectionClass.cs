using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ESRI.MapObjects2.Core;
using System.Drawing;

namespace KuaFu.Plugin.Selection
{
    public class ClearSelectionClass : ICommand
    {
        IApplication _app;

        public string Name
        {
            get { return "ClearSelection"; }
        }

        public string Caption { get { return "清空选择"; } }

        public Bitmap Bitmap { get { return new Bitmap("sid.ico"); } }

        public void OnClick()
        {
            _app.Selection = null;
            _app.Map.TrackingLayer.Refresh(true, null);
        }

        public void OnCreate(IApplication app)
        {
            _app = app;
        }

        public void AfterLayerDraw(object sender, AfterLayerDrawEventArgs e)
        {
        }

    }
}

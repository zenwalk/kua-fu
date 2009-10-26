using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ESRI.MapObjects2.Core;
using System.Drawing;

namespace KuaFu.Plugin.Selection
{
    public class ShowSelectionCountClass : ICommand
    {
        IApplication _app;

        public void AfterLayerDraw(object sender, AfterLayerDrawEventArgs e)
        {
        }

        public string Name
        {
            get { return "ShowSelectionCount"; }
        }

        public string Caption { get { return "显示选择特征的数量"; } }

        public Bitmap Bitmap { get { return new Bitmap("sid.ico"); } }

        public void OnClick()
        {
            if (_app.Selection != null)
            {
                MessageBox.Show(_app.Selection.Count.ToString());
            }
            else
            {
                MessageBox.Show("没有选择");
            }
        }

        public void OnCreate(IApplication app)
        {
            _app = app;
        }

    }
}

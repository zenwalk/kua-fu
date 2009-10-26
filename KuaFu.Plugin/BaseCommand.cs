using System;
using System.Collections.Generic;
using System.Text;
using ESRI.MapObjects2.Core;
using System.Drawing;

namespace KuaFu.Plugin
{

    /// <summary>
    /// 这个类将是一个模板性质的类
    /// </summary>
    public class BaseCommand : ICommand
    {
        private IApplication _app;

        string _name = "name";
        string _caption = "caption";

        public Bitmap Bitmap { get { return new Bitmap("sid.ico"); } }

        public void OnClick()
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get { return _name; }
        }

        public string Caption
        {
            get { return _caption; }
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

using System;
using System.Collections.Generic;
using System.Text;

using ESRI.MapObjects2.Core;
using System.Drawing;

namespace KuaFu.Plugin
{
    public interface ICommand : IPlugin
    {
        string Name { get; }
        string Caption { get; }
        Bitmap Bitmap { get; }
        void OnClick();
        void OnCreate(IApplication app);
        void AfterLayerDraw(object sender, AfterLayerDrawEventArgs e);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin
{
    public interface ICommand : IPlugin
    {
        string Name { get; }
        string Caption { get; }
        void OnClick();
        void OnCreate(AxMap map);
    }
}

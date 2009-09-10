using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin
{
    public interface IApplication
    {
        string Name { get; set; }
        string Caption { get; set; }
        string CurrentTool { get; set; }
        Form MainForm { get; set; }
        AxMap Map { get; set; }
    }
}

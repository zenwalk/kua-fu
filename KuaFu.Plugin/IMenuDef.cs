using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KuaFu.Plugin
{
    public interface IMenuDef : IPlugin
    {
        string Caption { get; }
        string Name { get; }
        long ItemCount { get; }
        void GetItemInfo(int pos, IItemDef itemDef);
    }
}

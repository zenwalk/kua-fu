using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KuaFu.Plugin
{
    /// <summary>
    /// 代表一个工具条
    /// </summary>
    public interface IToolBarDef : IPlugin
    {
        /// <summary>
        /// 工具条标题
        /// </summary>
        string Caption { get; }
        /// <summary>
        /// 工具条名称
        /// </summary>
        string Name { get; }
        /// <summary>
        /// 工具条上携带的Item数量
        /// </summary>
        long ItemCount { get; }
        /// <summary>
        /// 访问工具条中的每个Item的方法
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="itemDef"></param>
        void GetItemInfo(int pos, IItemDef itemDef);
    }
}

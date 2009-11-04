using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KuaFu.Plugin.Standard
{
    public class StandardToolbar : IToolBarDef
    {
        #region IToolBarDef 成员

        public string Caption
        {
            get { return "StandardTools"; }
        }

        public string Name
        {
            get { return "StandardTools"; }
        }

        public long ItemCount
        {
            get { return 4; }
        }

        public void GetItemInfo(int pos, IItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "AddShape";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "AddImage";
                    itemDef.Group = false;
                    break;
                case 2:
                    itemDef.ID = "Symbolization";
                    itemDef.Group = false;
                    break;
                case 3:
                    itemDef.ID = "ShowTable";
                    itemDef.Group = false;
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}

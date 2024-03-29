﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KuaFu.Plugin.Selection
{
    public class SelectionToolbar : IToolBarDef
    {
        #region IToolBarDef 成员

        public string Caption
        {
            get { return "SelectionTools"; }
        }

        public string Name
        {
            get { return "SelectionTools"; }
        }

        public long ItemCount
        {
            get { return 5; }
        }

        public void GetItemInfo(int pos, IItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "ShowSelectionCount";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "ClearSelection";
                    itemDef.Group = false;
                    break;
                case 2:
                    itemDef.ID = "SelectFeature";
                    itemDef.Group = false;
                    break;
                case 3:
                    itemDef.ID = "ReverseSelection";
                    itemDef.Group = false;
                    break;
                case 4:
                    itemDef.ID = "ConvertToShapefile";
                    itemDef.Group = false;
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}

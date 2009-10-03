using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KuaFu.Plugin.Tools
{
    public class ToolToolbar : IToolBarDef
    {
        #region IToolBarDef 成员

        public string Caption
        {
            get { return "ToolTools"; }
        }

        public string Name
        {
            get { return "ToolTools"; }
        }

        public long ItemCount
        {
            get { return 7; }
        }

        public void GetItemInfo(int pos, IItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "FullExtent";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "Pan";
                    itemDef.Group = true;
                    break;
                case 2:
                    itemDef.ID = "ZoomIn";
                    itemDef.Group = false;
                    break;
                case 3:
                    itemDef.ID = "ZoomOut";
                    itemDef.Group = false;
                    break;
                case 4:
                    itemDef.ID = "FixedZoomIn";
                    itemDef.Group = true;
                    break;
                case 5:
                    itemDef.ID = "FixedZoomOut";
                    itemDef.Group = false;
                    break;
                case 6:
                    itemDef.ID = "Identify";
                    itemDef.Group = true;
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}

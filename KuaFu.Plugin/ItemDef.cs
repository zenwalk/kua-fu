using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KuaFu.Plugin
{
    public class ItemDef : IItemDef
    {

        bool _group;
        string _id;
        long _subType;

        #region IItemDef 成员

        public bool Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        public string ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public long Subtype
        {
            get { return _subType; }
            set { _subType = value; }
        }

        #endregion
    }
}

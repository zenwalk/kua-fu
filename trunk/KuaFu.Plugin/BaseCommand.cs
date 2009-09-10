using System;
using System.Collections.Generic;
using System.Text;
using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin
{
    public class BaseCommand : ICommand
    {
        private AxMap _map;

        string _name = "name";
        string _caption = "caption";

        public void OnClick()
        {
            throw new NotImplementedException();
        }

        #region

        public string Name
        {
            get { return _name; }
        }

        public string Caption
        {
            get { return _caption; }
        }

        public void OnCreate(ESRI.MapObjects2.Core.AxMap map)
        {
            _map = map;
        }

        #endregion
    }
}

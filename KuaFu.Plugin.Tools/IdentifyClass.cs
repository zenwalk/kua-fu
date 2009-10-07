using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin.Tools
{
    public class IdentifyClass : KuaFu.Plugin.ITool
    {
        AxMap _map;

        #region ITool 成员

        public System.Drawing.Bitmap Bitmap
        {
            get { return null; }
            /*get { return new System.Drawing.Bitmap(""); }*/
        }

        public string Caption { get { return "识别"; } }

        public string Category
        {
            get { return "工具"; }
        }

        public bool Checked
        {
            get { return true; }
        }

        public bool Enabled
        {
            get { return true; }
        }

        public int HelpContextId
        {
            get { return 0; }
        }

        public string HelpFile
        {
            get { return ""; }
        }

        public string Message
        {
            get { return ""; }
        }

        public string Name
        {
            get { return "Identify"; }
        }

        public void OnClick()
        {
            // nothing
        }

        public void OnCreate(AxMap map)
        {
            _map = map;
        }

        public string Tooltip
        {
            get { return ""; }
        }

        public int Cursor
        {
            get { throw new NotImplementedException(); }
        }

        public bool Deactivate()
        {
            throw new NotImplementedException();
        }

        public void OnDblClick()
        {
            throw new NotImplementedException();
        }

        public bool OnContextMenu(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void OnMouseMove(int button, int shift, int x, int y)
        {
            throw new NotImplementedException();
        }

        public void OnMouseDown(int button, int shift, int x, int y)
        {
            Point pt = _map.ToMapPoint(x, y);
            MapLayer lyr = _map.Layers.Item(0) as MapLayer;
            Recordset recset = lyr.SearchShape(pt, SearchMethodConstants.moAreaIntersect, "");
            MessageBox.Show(recset.Count.ToString());

        }

        public void OnMouseUp(int button, int shift, int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Refresh(int hDC)
        {
            throw new NotImplementedException();
        }

        public void OnKeyDown(int keyCode, int shift)
        {
            throw new NotImplementedException();
        }

        public void OnKeyUp(int keyCode, int shift)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}



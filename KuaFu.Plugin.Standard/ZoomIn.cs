using System;
using System.Collections.Generic;
using System.Text;
using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin
{
    public class ZoomIn : ITool
    {
        AxMap _map;

        #region ITool 成员

        public System.Drawing.Bitmap Bitmap
        {
            get { throw new NotImplementedException(); }
        }

        public string Caption
        {
            get { return "放大"; }
        }

        public string Category
        {
            get { throw new NotImplementedException(); }
        }

        public bool Checked
        {
            get { throw new NotImplementedException(); }
        }

        public bool Enabled
        {
            get { throw new NotImplementedException(); }
        }

        public int HelpContextId
        {
            get { throw new NotImplementedException(); }
        }

        public string HelpFile
        {
            get { throw new NotImplementedException(); }
        }

        public string Message
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get { return "ZoomIn"; }
        }

        public void OnClick()
        {
            
        }

        public string Tooltip
        {
            get { throw new NotImplementedException(); }
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
            Rectangle rect = _map.TrackRectangle();
            _map.Extent = rect;

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

        public void OnCreate(ESRI.MapObjects2.Core.AxMap map)
        {
            _map = map;
        }

        #endregion
    }
}

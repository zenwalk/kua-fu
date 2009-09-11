using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin.Standard
{
    public class PanClass : KuaFu.Plugin.ITool
    {
        AxMap _map;

        #region ITool ≥…‘±

        public System.Drawing.Bitmap Bitmap
        {
            get { throw new NotImplementedException(); }
        }

        public string Caption
        { get { return "“∆∂Ø"; } }

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
            get { return "Pan"; }
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
            _map.Pan();
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



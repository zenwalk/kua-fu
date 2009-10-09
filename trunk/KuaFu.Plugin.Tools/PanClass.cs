using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin.Tools
{
    public class PanClass : KuaFu.Plugin.ITool
    {
        IApplication _app;

        #region ITool 成员
        
        public void AfterTrackingLayerDraw(object sender, AfterTrackingLayerDrawEventArgs e)
        {
        }

        public System.Drawing.Bitmap Bitmap
        {
            get { return null; }
            /*get { return new System.Drawing.Bitmap(""); }*/
        }

        public string Caption { get { return "移动"; } }

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
            get { return "Pan"; }
        }

        public void OnClick()
        {
            // nothing
        }

        public void OnCreate(IApplication app)
        {
            _app = app;
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
            _app.Map.Pan();
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

        public void AfterLayerDraw(object sender, AfterLayerDrawEventArgs e)
        {
        }


        #endregion
    }
}



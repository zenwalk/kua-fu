using System;
using System.Collections.Generic;
using System.Text;
using ESRI.MapObjects2.Core;
using System.Drawing;

namespace KuaFu.Plugin.Tools
{
    public class ZoomOutClass : ITool
    {
        IApplication _app;

        #region ITool 成员

        public void AfterTrackingLayerDraw(object sender, AfterTrackingLayerDrawEventArgs e)
        {
        }

        public void AfterLayerDraw(object sender, AfterLayerDrawEventArgs e)
        {
        }

        public System.Drawing.Bitmap Bitmap
        {
            get { return new Bitmap("缩小.ico"); }
        }

        public string Caption
        {
            get { return "缩小"; }
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
            get { return "ZoomOut"; }
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
            ESRI.MapObjects2.Core.Rectangle rect = _app.Map.TrackRectangle();
            _app.Map.Extent = rect;

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

        public void OnCreate(IApplication app)
        {
            _app = app;
        }

        #endregion
    }
}

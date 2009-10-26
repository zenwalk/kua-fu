using System;
using ESRI.MapObjects2.Core;
using System.Drawing;

namespace KuaFu.Plugin.Selection
{
    public class SelectFeatureClass : KuaFu.Plugin.ITool
    {
        IApplication _app;

        public SelectFeatureClass()
        {
        }

        public System.Drawing.Bitmap Bitmap
        {
            get { return new Bitmap("选择.ico"); }
        }

        public string Caption { get { return "选择"; } }

        public string Category
        {
            get { return "选择"; }
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
            get { return "SelectFeature"; }
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
            
        }

        public void OnMouseDown(int button, int shift, int x, int y)
        {
            ESRI.MapObjects2.Core.Rectangle rect = _app.Map.TrackRectangle();
            _app.Selection = (_app.Map.Layers.Item(0) as MapLayer).SearchShape(rect, SearchMethodConstants.moAreaIntersect, "");
            //_app.Map.AfterTrackingLayerDraw += new AfterTrackingLayerDrawEventHandler(AfterTrackingLayerDraw);
            _app.Map.TrackingLayer.Refresh(true, null);
        }

        public void AfterTrackingLayerDraw(object sender, AfterTrackingLayerDrawEventArgs e)
        {   
            //selection.MoveFirst();

            //Field f = selection.Fields.Item("shape");
            //object o = f.Value;

            //Symbol sym = new SymbolClass();
            //sym.SymbolType = SymbolTypeConstants.moFillSymbol;
            //sym.Style = 0;
            //sym.Color = 0;

            //_app.Map.DrawShape(_app.Selection, sym);

        }

        public void AfterLayerDraw(object sender, AfterLayerDrawEventArgs e)
        {
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

    }
}



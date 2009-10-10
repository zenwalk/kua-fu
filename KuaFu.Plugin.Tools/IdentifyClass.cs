using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin.Tools
{
    public class IdentifyClass : KuaFu.Plugin.ITool
    {
        IApplication _app;
        private MapLayer lyr;


        public IdentifyClass()
        {
        }

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

        public void OnCreate(IApplication app)
        {
            //_map = map;
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

        private Recordset recs;

        frmIdentify _frmIdentify;

        public void OnMouseDown(int button, int shift, int x, int y)
        {
            Point pt = _app.Map.ToMapPoint(x, y);
            recs = (_app.Map.Layers.Item(0) as MapLayer).SearchShape(pt, SearchMethodConstants.moPointInPolygon, "");

            _app.Map.FlashShape(recs.Fields.Item("shape").Value, 1);

            _frmIdentify = frmIdentify.GetInstance(_app);
            _frmIdentify.Update(recs);
            _frmIdentify.Show();
            //_app.Map.AfterTrackingLayerDraw += new AfterTrackingLayerDrawEventHandler(AfterTrackingLayerDraw);
            
            //_app.Map.CtlRefresh();
        }

        public void AfterTrackingLayerDraw(object sender, AfterTrackingLayerDrawEventArgs e)
        {
            //Symbol sym = new SymbolClass();
            //sym.SymbolType = SymbolTypeConstants.moFillSymbol;
            //sym.Style = 0;
            //sym.Color = 0;

            //selection.MoveFirst();

            //Field f = selection.Fields.Item("shape");
            //object o = f.Value;

            //_app.Map.DrawShape(selection, sym);

        }


        public void AfterLayerDraw(object sender, AfterLayerDrawEventArgs e)
        {
            //Symbol sym = new SymbolClass();
            //sym.SymbolType = SymbolTypeConstants.moFillSymbol;
            //sym.Style = 0;
            //sym.Color = 2;

            //selection.MoveFirst();

            //Field f = selection.Fields.Item("shape");
            //object o = f.Value;

            //_app.Map.DrawShape(o, sym);

            //Polygon poly = fs.Item("shape").Value as Polygon;
            

            //if (selection != null)
            //{
            //    Point pt = new PointClass();
            //    pt.X = 0;
            //    pt.Y = 0;

            //    stdole.StdFont font = new stdole.StdFontClass();
            //    font.Name = "黑体";
            //    font.Size = 50;

            //    TextSymbol sym = new TextSymbolClass();
            //    sym.Font = font;

            //    _app.Map.DrawText("一剑霜寒十四州", pt, sym);

            //    //_app.Map.DrawShape(poly, sym);
            //}

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



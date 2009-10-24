using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin.Selection
{
    public class ConvertToShapefileClass : ICommand
    {
        IApplication _app;

        public void AfterLayerDraw(object sender, AfterLayerDrawEventArgs e)
        {
        }

        public string Name
        {
            get { return "ConvertToShapefile"; }
        }

        public string Caption { get { return "导出为shapefile"; } }

        public void OnClick()
        {
            //MapLayer lyr = _app.Map.Layers.Item(0) as MapLayer;
            //Recordset recs_all = lyr.Records;
            //Recordset selected = _app.Selection;

            //TableDesc tableDesc = selected.TableDesc;
            //MessageBox.Show(tableDesc.get_FieldName(0));

            //object o = selected.Fields.Item("shape").Value;
            //MessageBox.Show(o.GetHashCode().ToString());

            MapLayer lyr = new MapLayerClass();
            _app.Selection.Export("c:\\test.shp", null);
            
        }

        public void OnCreate(IApplication app)
        {
            _app = app;
        }

    }
}

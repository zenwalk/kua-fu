using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin.Standard
{
    public partial class frmShowTable : Form
    {
        IApplication _app;

        public frmShowTable(IApplication app)
        {
            InitializeComponent();
            _app = app;
        }

        private void frmShowTable_Load(object sender, EventArgs e)
        {
            MapLayer lyr = (MapLayer)_app.Map.Layers.Item(0);
            Recordset recs = lyr.Records;
            TableDesc tableDesc = recs.TableDesc;

            List<string> fieldNames = new List<string>();

            // 填充标题（表头）
            for (short i = 0; i < tableDesc.FieldCount; i++)
            {
                string fieldName = tableDesc.get_FieldName(i);
                fieldNames.Add(fieldName);
                dataGrid.Columns.Add(fieldName, fieldName);
            }

            recs.MoveFirst();

            while (!recs.EOF)
            {
                Fields fields = recs.Fields;

                foreach (var name in fieldNames)
                {
                    string val = fields.Item(name).ValueAsString;
                }

                object vals = from 

                dataGrid.Rows.Add();

                recs.MoveNext();
            }
            
        }
    }
}

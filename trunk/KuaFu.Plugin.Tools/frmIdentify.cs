using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin.Tools
{
    public partial class frmIdentify : Form
    {

        static frmIdentify _frmIdentify = null;
        IApplication _app;

        private frmIdentify(IApplication app)
        {
            InitializeComponent();
            _app = app;
        }

        public static frmIdentify GetInstance(IApplication app)
        {
            if (_frmIdentify == null)
            {
                _frmIdentify = new frmIdentify(app);
            }
            return _frmIdentify;
        }

        Recordset _recs;

        internal void Update(ESRI.MapObjects2.Core.Recordset recs)
        {
            _recs = recs;

            lsv_Identify.Items.Clear();

            recs.MoveFirst();

            Fields fs = recs.Fields;
            TableDesc tableDesc = recs.TableDesc;
            short cnt = tableDesc.FieldCount;
            for (short i = 0; i < cnt; i++)
            {
                ListViewItem item = new ListViewItem(tableDesc.get_FieldName(i));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, fs.Item(tableDesc.get_FieldName(i)).ValueAsString));
                lsv_Identify.Items.Add(item);
            }

            //foreach (Field f in recs.Fields)
            //{
            //    MessageBox.Show(f.Name);
            //}

        }

        private void lsv_Identify_SelectedIndexChanged(object sender, EventArgs e)
        {
            _recs.MoveFirst();
            _app.Map.FlashShape(_recs.Fields.Item("shape").Value, 1);
        }
    }
}

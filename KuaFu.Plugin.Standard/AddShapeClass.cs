using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using ESRI.MapObjects2.Core;
using System.Threading;

using KuaFu.Helper;
using System.Drawing;

namespace KuaFu.Plugin.Standard
{
    public class AddShapeClass : KuaFu.Plugin.ICommand
    {
        IApplication _app;
        ESRI.MapObjects2.Core.DataConnection dc;
        ESRI.MapObjects2.Core.MapLayer lyr;
        ESRI.MapObjects2.Core.GeoDataset gds;

        public AddShapeClass()
        {
            dc = new ESRI.MapObjects2.Core.DataConnectionClass();
            //lyr = new ESRI.MapObjects2.Core.MapLayerClass();
        }

        #region ICommand Members

        public string Name { get { return "AddShape"; } }

        public string Caption { get { return "添加Shapefile"; } }

        public Bitmap Bitmap { get { return new Bitmap("添加.ico"); } }

        public void OnClick()
        {
            try
            {
                string fname, fdir;

                //OpenFileDialog ofd = new OpenFileDialog();
                //ofd.InitialDirectory = "c:";
                //ofd.Filter = "Shapefile|*.shp";
                //ofd.RestoreDirectory = true;
                //ofd.FilterIndex = 1;

                //if (ofd.ShowDialog() == DialogResult.Cancel)
                //{
                //    return;
                //}

                //fname = ofd.FileName;

                Invoker invoker = new Invoker();
                if (invoker.Invoke() == DialogResult.Cancel)
                {
                    return;
                }
                fname = invoker.InvokeDialog.FileName;

                fdir = fname.Substring(0, fname.LastIndexOf('\\') + 1);
                fname = fname.Substring(fname.LastIndexOf('\\') + 1);
                
                dc.Database = fdir.Replace(@"\", @"\\");
                dc.Connect();

                gds = dc.FindGeoDataset(fname);

                if (gds == null)
                {
                    MessageBox.Show("ERR: 连接错误");
                    return;
                }
                
                gds.AllowSharing = true;
                if (gds != null)
                {
                    lyr = new ESRI.MapObjects2.Core.MapLayerClass();
                    lyr.GeoDataset = gds;
                    _app.Map.Layers.Add((object)lyr);
                    _app.Map.CtlRefresh();
                }
            }
            catch (System.Runtime.InteropServices.COMException comEx)
            {
                // First, check the check facility code of the ErrorCode to see if it 
                // came from a control. (Facility code = 10 or A in hexidecimal notation).
                if ((comEx.ErrorCode & 0xFFFF0000) == 0x800A0000)
                {
                    // Next extract the information code (lowest 16 bits of the 32-bit integer ErrorCode) 
                    // by removing the high part from the full error code number.
                    int trapCode = comEx.ErrorCode & 0xFFFF;
                    // Now you can identify individual MO error codes, for example, 5035 indicates that 
                    // you attempted to set AllowSharing on a data source which does not support that property.
                    if (trapCode == 5053)
                    {
                        MessageBox.Show("You cannot set AllowSharing on this data set");
                    }
                    MessageBox.Show("MO Code: " + trapCode.ToString() + System.Environment.NewLine +
                      comEx.Message, comEx.ErrorCode.ToString());
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, ".NET Error");
            }
        }

        public void OnCreate(IApplication app)
        {
            _app = app;
        }

        public void AfterLayerDraw(object sender, AfterLayerDrawEventArgs e)
        {
        }

        #endregion
    }
}

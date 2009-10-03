using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using ESRI.MapObjects2.Core;

namespace KuaFu.Plugin.Standard
{
    public class AddShapeClass : KuaFu.Plugin.ICommand
    {
        private AxMap _map = null;
        ESRI.MapObjects2.Core.DataConnection dc;
        ESRI.MapObjects2.Core.MapLayer lyr;
        ESRI.MapObjects2.Core.GeoDataset gds;

        public AddShapeClass()
        {
            dc = new ESRI.MapObjects2.Core.DataConnectionClass();
            lyr = new ESRI.MapObjects2.Core.MapLayerClass();
        }

        #region ICommand Members

        public string Name { get { return "AddShape"; } }

        public string Caption { get { return "Ìí¼ÓShapefile"; } }

        public void OnClick()
        {
            try
            {
                dc.Database = @"D:\ESRI\ESRIDATA\WORLD";
                dc.Connect();
                
                gds = dc.FindGeoDataset("CNTRY92.SHP");
                gds.AllowSharing = true;
                if (gds != null)
                {
                    lyr.GeoDataset = gds;
                    _map.Layers.Add((object)lyr);
                    _map.CtlRefresh();
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

        public void OnCreate(AxMap map)
        {
            _map = map;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ESRI.MapObjects2.Core;
using KuaFu.Plugin;
using KuaFu.Plugin;
using System.IO;
using System.Reflection;
using System.Threading;

namespace KuaFu
{
    public partial class frmMain : Form
    {
        IApplication _application = null;
        
        Dictionary<string, ICommand> cmds = new Dictionary<string, ICommand>();
        Dictionary<string, ITool> tools = new Dictionary<string, ITool>();

        ITool _tool; //当前使用的ITool

        /// <summary>
        /// Thread to show the splash
        /// </summary>
        private void ShowSplash()
        {
            frmSplash _form = null;
            try
            {
                _form = new frmSplash();
                _form.ShowDialog();
            }
            catch (ThreadAbortException)
            {
                //Thread was aborted normally
            }
            finally
            {
                _form = null;
            }
        }

        public frmMain()
        {
            //处理欢迎窗体
            //create thread to show splash
            Thread showSplashThread = new Thread(new ThreadStart(ShowSplash));
            showSplashThread.Start();

            //Time consumed here

            InitializeComponent();

            _application = new KuaFu.Plugin.Application();
            _application.Name = "Kua Fu";
            _application.Map = this.axMap1;

            // 以下的代码的灵感来自 Effective C# : 利用特性简化发射

            // Find all the assemblies in the Add-ins directory
            string AddInsDir = string.Format("{0}/Addins", System.Windows.Forms.Application.StartupPath);
            try
            {
                string[] assemblies = Directory.GetFiles(AddInsDir, "*.dll");
                foreach (string assemblyFile in assemblies)
                {
                    Assembly asm = Assembly.LoadFrom(assemblyFile);
                    // Find and install command handlers from the assembly

                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("不存在 Addins 文件夹！");
            }

            ICommand cmd;
            cmd = new KuaFu.Plugin.Standard.AddShapeClass();
            cmd.OnCreate(_application.Map);
            cmds.Add(cmd.Name, cmd);

            cmd = new KuaFu.Plugin.Standard.AddImageClass();
            cmd.OnCreate(_application.Map);
            cmds.Add(cmd.Name, cmd);

            cmd = new KuaFu.Plugin.Standard.FullExtent();
            cmd.OnCreate(_application.Map);
            cmds.Add(cmd.Name, cmd);

            ITool tool;
            tool = new KuaFu.Plugin.Standard.ZoomIn();
            tool.OnCreate(_application.Map);
            tools.Add(tool.Name, tool);

            tool = new KuaFu.Plugin.Standard.PanClass();
            tool.OnCreate(_application.Map);
            tools.Add(tool.Name, tool);

            //处理ICommand，实例化一个按钮并且绑定事件
            foreach (var pair in cmds)
            {
                //MessageBox.Show(string.Format("{0}, {1}", pair.Key, pair.Value));
                ToolStripItem button = new ToolStripButton(pair.Value.Caption);
                button.Name = pair.Value.Name;
                button.Click += new EventHandler(Command_Click);
                toolStrip1.Items.Add(button);
            }

            foreach (var pair in tools)
            {
                ToolStripItem button = new ToolStripButton(pair.Value.Caption);
                button.Name = pair.Value.Name;
                button.Click += new EventHandler(Tool_Click);
                toolStrip1.Items.Add(button);
            }


            showSplashThread.Abort();
            showSplashThread.Join();
            showSplashThread = null;

        }

        void Tool_Click(object sender, EventArgs e)
        {
            //string s = (sender as ToolStripItem).Name;

            ITool tool = tools[(sender as ToolStripItem).Name];
            this._tool = tool;
            Thread thread = new Thread(new ThreadStart(tool.OnClick));
            thread.Start();
        }

        void Command_Click(object sender, EventArgs e)
        {
            ICommand cmd = cmds[(sender as ToolStripItem).Name];
            Thread thread = new Thread(new ThreadStart(cmd.OnClick));
            thread.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void axMap1_MouseDownEvent(object sender, MouseDownEventArgs e)
        {
            //tool.OnMouseDown(e.button, e.shift, e.x, e.y);
            _tool.OnMouseDown(e.button, e.shift, e.x, e.y);
        }

    }

}
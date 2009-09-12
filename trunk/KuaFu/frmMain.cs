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
using Janus.Windows.UI.CommandBars;

namespace KuaFu
{
    public partial class frmMain : Form
    {
        IApplication _application = null;

        Dictionary<string, ICommand> cmds = new Dictionary<string, ICommand>();
        Dictionary<string, ITool> tools = new Dictionary<string, ITool>();
        Dictionary<string, IToolBarDef> toolbars = new Dictionary<string, IToolBarDef>();

        ITool _tool; //��ǰʹ�õ�ITool

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
            //����ӭ����
            //create thread to show splash
            Thread showSplashThread = new Thread(new ThreadStart(ShowSplash));
            showSplashThread.Start();

            //Time consumed here

            InitializeComponent();

            _application = new KuaFu.Plugin.Application();
            _application.Name = "Kua Fu";
            _application.Map = this.axMap1;

            // ���µĴ����������� Effective C# : �������Լ򻯷���

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
                MessageBox.Show("������ Addins �ļ��У�");
            }

            ICommand cmd;
            cmd = new KuaFu.Plugin.Standard.AddShapeClass();
            cmd.OnCreate(_application.Map);
            cmds.Add(cmd.Name, cmd);

            cmd = new KuaFu.Plugin.Standard.AddImageClass();
            cmd.OnCreate(_application.Map);
            cmds.Add(cmd.Name, cmd);

            cmd = new KuaFu.Plugin.Tools.FullExtent();
            cmd.OnCreate(_application.Map);
            cmds.Add(cmd.Name, cmd);

            ITool tool;
            tool = new KuaFu.Plugin.Tools.ZoomIn();
            tool.OnCreate(_application.Map);
            tools.Add(tool.Name, tool);

            tool = new KuaFu.Plugin.Tools.PanClass();
            tool.OnCreate(_application.Map);
            tools.Add(tool.Name, tool);

            //����ICommand��ʵ����һ����ť���Ұ��¼�
            foreach (var pair in cmds)
            {
                //MessageBox.Show(string.Format("{0}, {1}", pair.Key, pair.Value));
                ToolStripItem button = new ToolStripButton(pair.Value.Caption);
                button.Name = pair.Value.Name;
                button.Click += new EventHandler(Command_Click);
            }

            foreach (var pair in tools)
            {
                ToolStripItem button = new ToolStripButton(pair.Value.Caption);
                button.Name = pair.Value.Name;
                button.Click += new EventHandler(Tool_Click);
            }


            IToolBarDef standard = new KuaFu.Plugin.Standard.StandardToolbar();
            toolbars.Add(standard.Name, standard);

            CreateUICommand(cmds, tools);
            CreateToolbars(toolbars);


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

        private void CreateToolbars(Dictionary<string, IToolBarDef> toolbars)
        {
            foreach (var pair in toolbars)
            {
                IToolBarDef t = pair.Value;
                UICommandBar UIToolbar = new UICommandBar();
                UIToolbar.CommandManager = this.uiCommandManager;
                UIToolbar.CommandsStyle = CommandStyle.TextImage;
                UIToolbar.Name = t.Name;
                UIToolbar.Text = t.Caption;

                ItemDef itemDef = new ItemDef();
                for (int i = 0; i < t.ItemCount; i++)
                {
                    t.GetItemInfo(i, itemDef);
                    UICommand UICmd = null;
                    try
                    {
                        UICmd = this.uiCommandManager.Commands[itemDef.ID];
                    }
                    catch (Exception)
                    {
                    }
                    if (UICmd != null)
                    {
                        if (itemDef.Group)
                        {
                            UIToolbar.Commands.AddSeparator();
                        }
                        UIToolbar.Commands.Add(UICmd);
                    }
                }
            }
        }

        private void CreateUICommand(Dictionary<string, ICommand> cmds, Dictionary<string, ITool> tools)
        {
            foreach (var pair in cmds)
            {
                UICommand UICmd = new UICommand();
                UICmd.Text = pair.Value.Caption;
                UICmd.Key = pair.Value.Name;
                pair.Value.OnCreate(this._application.Map);
                UICmd.Click += new CommandEventHandler(UICommand_Click);
                this.uiCommandManager.Commands.Add(UICmd);
            }
        }

        void UICommand_Click(object sender, CommandEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using ESRI.MapObjects2.Core;
using KuaFu.Plugin;
using System.IO;
using System.Reflection;
using System.Threading;
using Janus.Windows.UI.CommandBars;

namespace KuaFu
{
    public partial class frmMain : Form
    {
        IApplication _application;

        Dictionary<string, ICommand> cmds = new Dictionary<string, ICommand>();
        Dictionary<string, ITool> tools = new Dictionary<string, ITool>();
        Dictionary<string, IToolBarDef> toolbars = new Dictionary<string, IToolBarDef>();

        ITool _tool; //��ǰʹ�õ�ITool

        Symbol sym_selected = new SymbolClass();

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


            //��ʱע�͵�����splash�Ĵ���
            //Thread showSplashThread = new Thread(new ThreadStart(ShowSplash));
            //showSplashThread.Start();
            
            //Time consumed here

            InitializeComponent();

            _application = new KuaFu.Plugin.Application();
            _application.Name = "Kua Fu";
            _application.Map = this.axMap;
            _application.Selection = null;

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



            /// ���µĴ�����Ϊ�˰����е� command �� tool ���浽 pool ��


            ICommand cmd;
            cmd = new KuaFu.Plugin.Standard.AddShapeClass();
            cmd.OnCreate(_application);
            cmds.Add(cmd.Name, cmd);

            cmd = new KuaFu.Plugin.Standard.AddImageClass();
            cmd.OnCreate(_application);
            cmds.Add(cmd.Name, cmd);

            cmd = new KuaFu.Plugin.Tools.FullExtent();
            cmd.OnCreate(_application);
            cmds.Add(cmd.Name, cmd);

            cmd = new KuaFu.Plugin.Tools.FixedZoomInClass();
            cmd.OnCreate(_application);
            cmds.Add(cmd.Name, cmd);

            cmd = new KuaFu.Plugin.Tools.FixedZoomOutClass();
            cmd.OnCreate(_application);
            cmds.Add(cmd.Name, cmd);

            cmd = new KuaFu.Plugin.Selection.ShowSelectionCountClass();
            cmd.OnCreate(_application);
            cmds.Add(cmd.Name, cmd);

            cmd = new KuaFu.Plugin.Selection.ClearSelectionClass();
            cmd.OnCreate(_application);
            cmds.Add(cmd.Name, cmd);


            ITool tool;
            tool = new KuaFu.Plugin.Tools.ZoomInClass();
            tool.OnCreate(_application);
            tools.Add(tool.Name, tool);

            tool = new KuaFu.Plugin.Tools.ZoomOutClass();
            tool.OnCreate(_application);
            tools.Add(tool.Name, tool);

            tool = new KuaFu.Plugin.Tools.PanClass();
            tool.OnCreate(_application);
            tools.Add(tool.Name, tool);

            tool = new KuaFu.Plugin.Tools.IdentifyClass();
            tool.OnCreate(_application);
            tools.Add(tool.Name, tool);

            tool = new KuaFu.Plugin.Selection.SelectFeatureClass();
            tool.OnCreate(_application);
            tools.Add(tool.Name, tool);

            //����ICommand��ʵ����һ����ť���Ұ��¼�
            foreach (var pair in cmds)
            {
                //MessageBox.Show(string.Format("{0}, {1}", pair.Key, pair.Value));
                ToolStripItem button = new ToolStripButton(pair.Value.Caption);
                button.Name = pair.Value.Name;
                //button.Click += new EventHandler(Command_Click);
            }

            foreach (var pair in tools)
            {
                ToolStripItem button = new ToolStripButton(pair.Value.Caption);
                button.Name = pair.Value.Name;
                //button.Click += new EventHandler(Tool_Click);
            }

            {
                IToolBarDef standard = new KuaFu.Plugin.Standard.StandardToolbar();
                toolbars.Add(standard.Name, standard);


                IToolBarDef _tool = new KuaFu.Plugin.Tools.ToolToolbar();
                toolbars.Add(_tool.Name, _tool);

                IToolBarDef selection = new KuaFu.Plugin.Selection.SelectionToolbar();
                toolbars.Add(selection.Name, selection);
            }

            CreateUICommand(cmds, tools);
            CreateToolbars(toolbars);

            UICommand menu_selection = new UICommand("selection", "ѡ��");

            UICommand uicmd = new UICommand("exit", "�˳�", CommandType.Command);
            uicmd.Click += new CommandEventHandler(test);

            menu_selection.Commands.Add(uicmd);

            MainMenu.Commands.Add(menu_selection);




            InitSymbols();

            //showSplashThread.Abort();
            //showSplashThread.Join();
            //showSplashThread = null;

        }

        void InitSymbols()
        {
            // ���ñ���ѡ��ķ���
            sym_selected.SymbolType = SymbolTypeConstants.moFillSymbol;
            sym_selected.Style = 0;
            sym_selected.Color = 0xffff;
        }

        void test(object sender, CommandEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //void Tool_Click(object sender, EventArgs e)
        //{
        //    //string s = (sender as ToolStripItem).Name;

        //    ITool tool = tools[(sender as ToolStripItem).Name];
        //    this._tool = tool;
        //    Thread thread = new Thread(new ThreadStart(tool.OnClick));
        //    thread.Start();
        //}

        //void Command_Click(object sender, EventArgs e)
        //{
        //    ICommand cmd = cmds[(sender as ToolStripItem).Name];
        //    Thread thread = new Thread(new ThreadStart(cmd.OnClick));
        //    thread.Start();
        //}

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void axMap_MouseDownEvent(object sender, MouseDownEventArgs e)
        {
            if (_tool != null)
            {
                _tool.OnMouseDown(e.button, e.shift, e.x, e.y);
            }
        }

        private void CreateToolbars(Dictionary<string, IToolBarDef> toolbars)
        {
            foreach (var pair in toolbars)
            {
                IToolBarDef t = pair.Value;
                UICommandBar UIToolbar = new UICommandBar();
                UIToolbar.CommandManager = this.uiCommandManager;
                UIToolbar.CommandsStyle = CommandStyle.TextImage;
                UIToolbar.CommandBarType = CommandBarType.ToolBar;
                UIToolbar.DockStyle = BarsDockStyle.Top;
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
                pair.Value.OnCreate(this._application);
                UICmd.Click += new CommandEventHandler(UICommand_Click);
                this.uiCommandManager.Commands.Add(UICmd);
            }
            foreach (var pair in tools)
            {
                UICommand UICmd = new UICommand();
                UICmd.Text = pair.Value.Caption;
                UICmd.Key = pair.Value.Name;
                pair.Value.OnCreate(this._application);
                UICmd.Click += new CommandEventHandler(UITool_Click);
                this.uiCommandManager.Commands.Add(UICmd);
            }
        }

        void UITool_Click(object sender, CommandEventArgs e)
        {
            ITool tool = tools[(sender as UICommand).Key];
            this._tool = tool;
            tool.OnClick();
        }

        void UICommand_Click(object sender, CommandEventArgs e)
        {
            ICommand cmd = cmds[(sender as UICommand).Key];
            Thread thread = new Thread(new ThreadStart(cmd.OnClick));
            thread.Start();
        }

        private void axMap_MouseMoveEvent(object sender, MouseMoveEventArgs e)
        {
            if (_tool != null)
            {
                _tool.OnMouseMove(e.button, e.shift, e.x, e.y);
            }
        }

        private void axMap_AfterLayerDraw(object sender, AfterLayerDrawEventArgs e)
        {
            if (_tool != null)
            {
                _tool.AfterLayerDraw(sender, e);
            }
        }

        private void axMap_AfterTrackingLayerDraw(object sender, AfterTrackingLayerDrawEventArgs e)
        {
            if (_tool != null)
            {
                _tool.AfterTrackingLayerDraw(sender, e);
            }
            if (_application.Selection != null)
            {
                DrawSelection();
            }
        }

        private void DrawSelection()
        {
            //MessageBox.Show("Test");
            this.axMap.DrawShape(_application.Selection, sym_selected);
        }
    }
}
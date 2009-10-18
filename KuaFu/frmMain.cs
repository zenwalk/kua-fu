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

        ITool _tool; //当前使用的ITool

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

        /// <summary>
        /// 这个函数太长了，需要分解
        /// </summary>
        /// <param name="cmds"></param>
        /// <param name="tools"></param>
        void GetPluginsFromDLL(Dictionary<string, ICommand> cmds, Dictionary<string, ITool> tools)
        {

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

                    if (asm != null)
                    {
                        Type[] _types = null;

                        try
                        {
                            _types = asm.GetTypes();
                        }
                        catch (ReflectionTypeLoadException)
                        {
                            throw;
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        finally
                        {
                            foreach (Type _t in _types)
                            {
                                Type[] _interfaces = _t.GetInterfaces();
                                foreach (var _interface in _interfaces)
                                {
                                    switch (_interface.FullName)
                                    {
                                        case "KuaFu.Plugin.ICommand":
                                            ICommand cmd = null;
                                            try
                                            {
                                                cmd = Activator.CreateInstance(_t) as ICommand;
                                            }
                                            catch (Exception)
                                            {
                                                throw;
                                            }
                                            finally
                                            {
                                                if (cmd != null)
                                                {
                                                    cmd.OnCreate(_application);
                                                    cmds.Add(cmd.Name, cmd);
                                                }
                                            }
                                            break;
                                        case "KuaFu.Plugin.ITool":
                                            ITool tool = null;
                                            try
                                            {
                                                tool = Activator.CreateInstance(_t) as ITool;
                                            }
                                            catch (Exception)
                                            {
                                                throw;
                                            }
                                            finally
                                            {
                                                if (tool != null)
                                                {
                                                    tool.OnCreate(_application);
                                                    tools.Add(tool.Name, tool);
                                                }
                                            }
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Directory.CreateDirectory(AddInsDir);
            }
        }

        public frmMain()
        {
            //处理欢迎窗体
            //create thread to show splash


            //暂时注释掉处理splash的代码
            //Thread showSplashThread = new Thread(new ThreadStart(ShowSplash));
            //showSplashThread.Start();
            
            //Time consumed here

            // 初始化组件
            InitializeComponent();

            // 支持用鼠标滚轮控制放大缩小
            MapContainer.MouseWheel += new MouseEventHandler(MapContainer_MouseWheel);

            // 初始化 application 对象
            _application = new KuaFu.Plugin.Application();
            _application.Name = "Kua Fu";
            _application.Map = this.axMap;
            _application.Selection = null;

            // 加载所有的 command 和 tool
            GetPluginsFromDLL(cmds, tools);


            /// 以下的代码是为了把所有的 command 和 tool 保存到 pool 中
            /// 

            //处理ICommand，实例化一个按钮并且绑定事件
            //foreach (var pair in cmds)
            //{
            //    //MessageBox.Show(string.Format("{0}, {1}", pair.Key, pair.Value));
            //    ToolStripItem button = new ToolStripButton(pair.Value.Caption);
            //    button.Name = pair.Value.Name;
            //}

            //foreach (var pair in tools)
            //{
            //    ToolStripItem button = new ToolStripButton(pair.Value.Caption);
            //    button.Name = pair.Value.Name;
            //}


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

            InitMainMenu(MainMenu);

            InitSymbols();

            //showSplashThread.Abort();
            //showSplashThread.Join();
            //showSplashThread = null;

            

        }

        void MapContainer_MouseWheel(object sender, MouseEventArgs e)
        {
            Rectangle rect = axMap.Extent;
            if (e.Delta > 0)
            {
                rect.ScaleRectangle(1.2);
            }
            else
            {
                rect.ScaleRectangle(0.8);
            }
            axMap.Extent = rect;
        }

        void InitMainMenu(UICommandBar MainMenu)
        {
            UICommand menu_selection = new UICommand("selection", "选择");

            UICommand uicmd = new UICommand("exit", "退出", CommandType.Command);
            uicmd.Click += new CommandEventHandler(test);

            menu_selection.Commands.Add(uicmd);

            MainMenu.Commands.Add(menu_selection);
        }

        void InitSymbols()
        {
            // 设置表征选择的符号
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

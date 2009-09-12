namespace KuaFu
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.uiCommandManager = new Janus.Windows.UI.CommandBars.UICommandManager(this.components);
            this.TopRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.LeftRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.RightRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.BottomRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.MainMenu = new Janus.Windows.UI.CommandBars.UICommandBar();
            this.uiStatusBar = new Janus.Windows.UI.StatusBar.UIStatusBar();
            this.uiPanelManager = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.TOCPanel = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.LayerPanel = new Janus.Windows.UI.Dock.UIPanel();
            this.LayerPanelContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.ProperPanel = new Janus.Windows.UI.Dock.UIPanel();
            this.ProperPanelContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.DataPanel = new Janus.Windows.UI.Dock.UIPanel();
            this.DataPanelContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uiPanelGroup1 = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.MapContainer = new Janus.Windows.UI.Dock.UIPanel();
            this.MapContainerContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.axMap1 = new ESRI.MapObjects2.Core.AxMap();
            ((System.ComponentModel.ISupportInitialize)(this.uiCommandManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).BeginInit();
            this.TopRebar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOCPanel)).BeginInit();
            this.TOCPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LayerPanel)).BeginInit();
            this.LayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProperPanel)).BeginInit();
            this.ProperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPanel)).BeginInit();
            this.DataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelGroup1)).BeginInit();
            this.uiPanelGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapContainer)).BeginInit();
            this.MapContainer.SuspendLayout();
            this.MapContainerContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiCommandManager
            // 
            this.uiCommandManager.BottomRebar = this.BottomRebar1;
            this.uiCommandManager.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.MainMenu});
            this.uiCommandManager.ContainerControl = this;
            this.uiCommandManager.Id = new System.Guid("009055e4-7406-4bea-aaef-f8d7435f269e");
            this.uiCommandManager.LeftRebar = this.LeftRebar1;
            this.uiCommandManager.RightRebar = this.RightRebar1;
            this.uiCommandManager.TopRebar = this.TopRebar1;
            // 
            // TopRebar1
            // 
            this.TopRebar1.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.MainMenu});
            this.TopRebar1.CommandManager = this.uiCommandManager;
            this.TopRebar1.Controls.Add(this.MainMenu);
            this.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopRebar1.Location = new System.Drawing.Point(0, 0);
            this.TopRebar1.Name = "TopRebar1";
            this.TopRebar1.Size = new System.Drawing.Size(896, 26);
            // 
            // LeftRebar1
            // 
            this.LeftRebar1.CommandManager = this.uiCommandManager;
            this.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftRebar1.Location = new System.Drawing.Point(0, 0);
            this.LeftRebar1.Name = "LeftRebar1";
            this.LeftRebar1.Size = new System.Drawing.Size(0, 460);
            // 
            // RightRebar1
            // 
            this.RightRebar1.CommandManager = this.uiCommandManager;
            this.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightRebar1.Location = new System.Drawing.Point(896, 0);
            this.RightRebar1.Name = "RightRebar1";
            this.RightRebar1.Size = new System.Drawing.Size(0, 460);
            // 
            // BottomRebar1
            // 
            this.BottomRebar1.CommandManager = this.uiCommandManager;
            this.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomRebar1.Location = new System.Drawing.Point(0, 460);
            this.BottomRebar1.Name = "BottomRebar1";
            this.BottomRebar1.Size = new System.Drawing.Size(896, 0);
            // 
            // MainMenu
            // 
            this.MainMenu.CommandBarType = Janus.Windows.UI.CommandBars.CommandBarType.Menu;
            this.MainMenu.CommandManager = this.uiCommandManager;
            this.MainMenu.Key = "CommandBar1";
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RowIndex = 0;
            this.MainMenu.Size = new System.Drawing.Size(896, 26);
            this.MainMenu.Text = "CommandBar1";
            // 
            // uiStatusBar
            // 
            this.uiStatusBar.Location = new System.Drawing.Point(0, 437);
            this.uiStatusBar.Name = "uiStatusBar";
            this.uiStatusBar.Size = new System.Drawing.Size(896, 23);
            this.uiStatusBar.TabIndex = 4;
            // 
            // uiPanelManager
            // 
            this.uiPanelManager.ContainerControl = this;
            this.uiPanelManager.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Standard;
            this.uiPanelGroup1.Id = new System.Guid("49db4403-ba40-4f69-ad60-2df5cc58336e");
            this.TOCPanel.Id = new System.Guid("346d1611-e846-4b3d-b492-1ac87ad87e8b");
            this.TOCPanel.StaticGroup = true;
            this.LayerPanel.Id = new System.Guid("27461a2b-8224-4215-b30a-520bb553616e");
            this.TOCPanel.Panels.Add(this.LayerPanel);
            this.ProperPanel.Id = new System.Guid("d6e840a7-1b13-47e5-a7cb-7c2ce8912614");
            this.TOCPanel.Panels.Add(this.ProperPanel);
            this.uiPanelGroup1.Panels.Add(this.TOCPanel);
            this.DataPanel.Id = new System.Guid("4787b434-5991-47fe-8d72-1dbcbec668fd");
            this.uiPanelGroup1.Panels.Add(this.DataPanel);
            this.uiPanelManager.Panels.Add(this.uiPanelGroup1);
            this.MapContainer.Id = new System.Guid("c5dc245e-27bb-4661-bac1-f43deda18e30");
            this.uiPanelManager.Panels.Add(this.MapContainer);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager.BeginPanelInfo();
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("49db4403-ba40-4f69-ad60-2df5cc58336e"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, Janus.Windows.UI.Dock.PanelDockStyle.Left, false, new System.Drawing.Size(200, 405), true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("346d1611-e846-4b3d-b492-1ac87ad87e8b"), new System.Guid("49db4403-ba40-4f69-ad60-2df5cc58336e"), Janus.Windows.UI.Dock.PanelGroupStyle.Tab, true, 202, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("27461a2b-8224-4215-b30a-520bb553616e"), new System.Guid("346d1611-e846-4b3d-b492-1ac87ad87e8b"), -1, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("d6e840a7-1b13-47e5-a7cb-7c2ce8912614"), new System.Guid("346d1611-e846-4b3d-b492-1ac87ad87e8b"), -1, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("4787b434-5991-47fe-8d72-1dbcbec668fd"), new System.Guid("49db4403-ba40-4f69-ad60-2df5cc58336e"), 202, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("c5dc245e-27bb-4661-bac1-f43deda18e30"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, new System.Drawing.Size(690, 405), true);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("4787b434-5991-47fe-8d72-1dbcbec668fd"), new System.Drawing.Point(70, 418), new System.Drawing.Size(200, 200), false);
            this.uiPanelManager.EndPanelInfo();
            // 
            // TOCPanel
            // 
            this.TOCPanel.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.Tab;
            this.TOCPanel.Location = new System.Drawing.Point(0, 0);
            this.TOCPanel.Name = "TOCPanel";
            this.TOCPanel.SelectedPanel = this.LayerPanel;
            this.TOCPanel.Size = new System.Drawing.Size(196, 201);
            this.TOCPanel.TabIndex = 4;
            this.TOCPanel.Text = "地图信息";
            // 
            // LayerPanel
            // 
            this.LayerPanel.InnerContainer = this.LayerPanelContainer;
            this.LayerPanel.Location = new System.Drawing.Point(0, 0);
            this.LayerPanel.Name = "LayerPanel";
            this.LayerPanel.Size = new System.Drawing.Size(196, 183);
            this.LayerPanel.TabIndex = 4;
            this.LayerPanel.Text = "图层";
            // 
            // LayerPanelContainer
            // 
            this.LayerPanelContainer.Location = new System.Drawing.Point(1, 24);
            this.LayerPanelContainer.Name = "LayerPanelContainer";
            this.LayerPanelContainer.Size = new System.Drawing.Size(194, 159);
            this.LayerPanelContainer.TabIndex = 0;
            // 
            // ProperPanel
            // 
            this.ProperPanel.InnerContainer = this.ProperPanelContainer;
            this.ProperPanel.Location = new System.Drawing.Point(0, 0);
            this.ProperPanel.Name = "ProperPanel";
            this.ProperPanel.Size = new System.Drawing.Size(196, 183);
            this.ProperPanel.TabIndex = 4;
            this.ProperPanel.Text = "属性";
            // 
            // ProperPanelContainer
            // 
            this.ProperPanelContainer.Location = new System.Drawing.Point(1, 24);
            this.ProperPanelContainer.Name = "ProperPanelContainer";
            this.ProperPanelContainer.Size = new System.Drawing.Size(194, 159);
            this.ProperPanelContainer.TabIndex = 0;
            // 
            // DataPanel
            // 
            this.DataPanel.FloatingLocation = new System.Drawing.Point(70, 418);
            this.DataPanel.InnerContainer = this.DataPanelContainer;
            this.DataPanel.Location = new System.Drawing.Point(0, 205);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(196, 200);
            this.DataPanel.TabIndex = 4;
            this.DataPanel.Text = "数据";
            // 
            // DataPanelContainer
            // 
            this.DataPanelContainer.Location = new System.Drawing.Point(1, 23);
            this.DataPanelContainer.Name = "DataPanelContainer";
            this.DataPanelContainer.Size = new System.Drawing.Size(194, 176);
            this.DataPanelContainer.TabIndex = 0;
            // 
            // uiPanelGroup1
            // 
            this.uiPanelGroup1.Location = new System.Drawing.Point(3, 29);
            this.uiPanelGroup1.Name = "uiPanelGroup1";
            this.uiPanelGroup1.Size = new System.Drawing.Size(200, 405);
            this.uiPanelGroup1.TabIndex = 9;
            // 
            // MapContainer
            // 
            this.MapContainer.CaptionVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.MapContainer.InnerContainer = this.MapContainerContainer;
            this.MapContainer.Location = new System.Drawing.Point(203, 29);
            this.MapContainer.Name = "MapContainer";
            this.MapContainer.Size = new System.Drawing.Size(690, 405);
            this.MapContainer.TabIndex = 4;
            this.MapContainer.Text = "地图容器";
            // 
            // MapContainerContainer
            // 
            this.MapContainerContainer.Controls.Add(this.axMap1);
            this.MapContainerContainer.Location = new System.Drawing.Point(1, 1);
            this.MapContainerContainer.Name = "MapContainerContainer";
            this.MapContainerContainer.Size = new System.Drawing.Size(688, 403);
            this.MapContainerContainer.TabIndex = 0;
            // 
            // axMap1
            // 
            this.axMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMap1.Location = new System.Drawing.Point(0, 0);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(688, 403);
            this.axMap1.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 460);
            this.Controls.Add(this.MapContainer);
            this.Controls.Add(this.uiPanelGroup1);
            this.Controls.Add(this.uiStatusBar);
            this.Controls.Add(this.TopRebar1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiCommandManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOCPanel)).EndInit();
            this.TOCPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LayerPanel)).EndInit();
            this.LayerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProperPanel)).EndInit();
            this.ProperPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataPanel)).EndInit();
            this.DataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelGroup1)).EndInit();
            this.uiPanelGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MapContainer)).EndInit();
            this.MapContainer.ResumeLayout(false);
            this.MapContainerContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.CommandBars.UICommandManager uiCommandManager;
        private Janus.Windows.UI.CommandBars.UIRebar BottomRebar1;
        private Janus.Windows.UI.CommandBars.UIRebar LeftRebar1;
        private Janus.Windows.UI.CommandBars.UIRebar RightRebar1;
        private Janus.Windows.UI.CommandBars.UIRebar TopRebar1;
        private Janus.Windows.UI.CommandBars.UICommandBar MainMenu;
        private Janus.Windows.UI.StatusBar.UIStatusBar uiStatusBar;
        private Janus.Windows.UI.Dock.UIPanelGroup TOCPanel;
        private Janus.Windows.UI.Dock.UIPanel LayerPanel;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer LayerPanelContainer;
        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager;
        private Janus.Windows.UI.Dock.UIPanel ProperPanel;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer ProperPanelContainer;
        private Janus.Windows.UI.Dock.UIPanel MapContainer;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer MapContainerContainer;
        private Janus.Windows.UI.Dock.UIPanelGroup uiPanelGroup1;
        private Janus.Windows.UI.Dock.UIPanel DataPanel;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer DataPanelContainer;
        private ESRI.MapObjects2.Core.AxMap axMap1;

    }
}


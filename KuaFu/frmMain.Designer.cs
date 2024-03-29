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
            this.BottomRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.MainMenu = new Janus.Windows.UI.CommandBars.UICommandBar();
            this.LeftRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.RightRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.TopRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.uiStatusBar = new Janus.Windows.UI.StatusBar.UIStatusBar();
            this.uiPanelManager = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanelGroup1 = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.TOCPanel = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.LayerPanel = new Janus.Windows.UI.Dock.UIPanel();
            this.LayerPanelContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.axlegend1 = new AxSampleLegendControl.Axlegend();
            this.ProperPanel = new Janus.Windows.UI.Dock.UIPanel();
            this.ProperPanelContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.SelectionPanel = new Janus.Windows.UI.Dock.UIPanel();
            this.SelectionPanelContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.DataPanel = new Janus.Windows.UI.Dock.UIPanel();
            this.DataPanelContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.MapContainer = new Janus.Windows.UI.Dock.UIPanel();
            this.MapContainerContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.axMap = new ESRI.MapObjects2.Core.AxMap();
            ((System.ComponentModel.ISupportInitialize)(this.uiCommandManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).BeginInit();
            this.TopRebar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelGroup1)).BeginInit();
            this.uiPanelGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TOCPanel)).BeginInit();
            this.TOCPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LayerPanel)).BeginInit();
            this.LayerPanel.SuspendLayout();
            this.LayerPanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axlegend1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProperPanel)).BeginInit();
            this.ProperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionPanel)).BeginInit();
            this.SelectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPanel)).BeginInit();
            this.DataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapContainer)).BeginInit();
            this.MapContainer.SuspendLayout();
            this.MapContainerContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap)).BeginInit();
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
            this.MainMenu.Key = "MainMenu";
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RowIndex = 0;
            this.MainMenu.Size = new System.Drawing.Size(896, 26);
            this.MainMenu.Text = "MainMenu";
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
            this.SelectionPanel.Id = new System.Guid("ff4dfa23-4470-4fd7-be17-64b8c2deb52b");
            this.TOCPanel.Panels.Add(this.SelectionPanel);
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
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("346d1611-e846-4b3d-b492-1ac87ad87e8b"), new System.Guid("49db4403-ba40-4f69-ad60-2df5cc58336e"), Janus.Windows.UI.Dock.PanelGroupStyle.Tab, true, 283, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("27461a2b-8224-4215-b30a-520bb553616e"), new System.Guid("346d1611-e846-4b3d-b492-1ac87ad87e8b"), -1, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("d6e840a7-1b13-47e5-a7cb-7c2ce8912614"), new System.Guid("346d1611-e846-4b3d-b492-1ac87ad87e8b"), -1, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("ff4dfa23-4470-4fd7-be17-64b8c2deb52b"), new System.Guid("346d1611-e846-4b3d-b492-1ac87ad87e8b"), -1, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("4787b434-5991-47fe-8d72-1dbcbec668fd"), new System.Guid("49db4403-ba40-4f69-ad60-2df5cc58336e"), 118, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("c5dc245e-27bb-4661-bac1-f43deda18e30"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, new System.Drawing.Size(690, 405), true);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("4787b434-5991-47fe-8d72-1dbcbec668fd"), new System.Drawing.Point(70, 418), new System.Drawing.Size(200, 200), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("346d1611-e846-4b3d-b492-1ac87ad87e8b"), Janus.Windows.UI.Dock.PanelGroupStyle.Tab, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("27461a2b-8224-4215-b30a-520bb553616e"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("d6e840a7-1b13-47e5-a7cb-7c2ce8912614"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("c5dc245e-27bb-4661-bac1-f43deda18e30"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("ff4dfa23-4470-4fd7-be17-64b8c2deb52b"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.EndPanelInfo();
            // 
            // uiPanelGroup1
            // 
            this.uiPanelGroup1.Location = new System.Drawing.Point(3, 29);
            this.uiPanelGroup1.Name = "uiPanelGroup1";
            this.uiPanelGroup1.Size = new System.Drawing.Size(200, 405);
            this.uiPanelGroup1.TabIndex = 9;
            // 
            // TOCPanel
            // 
            this.TOCPanel.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.Tab;
            this.TOCPanel.Location = new System.Drawing.Point(0, 0);
            this.TOCPanel.Name = "TOCPanel";
            this.TOCPanel.SelectedPanel = this.LayerPanel;
            this.TOCPanel.Size = new System.Drawing.Size(196, 283);
            this.TOCPanel.TabIndex = 4;
            this.TOCPanel.Text = "��ͼ��Ϣ";
            // 
            // LayerPanel
            // 
            this.LayerPanel.InnerContainer = this.LayerPanelContainer;
            this.LayerPanel.Location = new System.Drawing.Point(0, 0);
            this.LayerPanel.Name = "LayerPanel";
            this.LayerPanel.Size = new System.Drawing.Size(196, 265);
            this.LayerPanel.TabIndex = 4;
            this.LayerPanel.Text = "ͼ��";
            // 
            // LayerPanelContainer
            // 
            this.LayerPanelContainer.Controls.Add(this.axlegend1);
            this.LayerPanelContainer.Location = new System.Drawing.Point(1, 24);
            this.LayerPanelContainer.Name = "LayerPanelContainer";
            this.LayerPanelContainer.Size = new System.Drawing.Size(194, 241);
            this.LayerPanelContainer.TabIndex = 0;
            // 
            // axlegend1
            // 
            this.axlegend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axlegend1.Enabled = true;
            this.axlegend1.Location = new System.Drawing.Point(0, 0);
            this.axlegend1.Name = "axlegend1";
            this.axlegend1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axlegend1.OcxState")));
            this.axlegend1.Size = new System.Drawing.Size(194, 241);
            this.axlegend1.TabIndex = 0;
            // 
            // ProperPanel
            // 
            this.ProperPanel.InnerContainer = this.ProperPanelContainer;
            this.ProperPanel.Location = new System.Drawing.Point(0, 0);
            this.ProperPanel.Name = "ProperPanel";
            this.ProperPanel.Size = new System.Drawing.Size(196, 265);
            this.ProperPanel.TabIndex = 4;
            this.ProperPanel.Text = "����";
            // 
            // ProperPanelContainer
            // 
            this.ProperPanelContainer.Location = new System.Drawing.Point(1, 24);
            this.ProperPanelContainer.Name = "ProperPanelContainer";
            this.ProperPanelContainer.Size = new System.Drawing.Size(194, 241);
            this.ProperPanelContainer.TabIndex = 0;
            // 
            // SelectionPanel
            // 
            this.SelectionPanel.InnerContainer = this.SelectionPanelContainer;
            this.SelectionPanel.Location = new System.Drawing.Point(0, 0);
            this.SelectionPanel.Name = "SelectionPanel";
            this.SelectionPanel.Size = new System.Drawing.Size(196, 265);
            this.SelectionPanel.TabIndex = 4;
            this.SelectionPanel.Text = "ѡ��";
            // 
            // SelectionPanelContainer
            // 
            this.SelectionPanelContainer.Location = new System.Drawing.Point(1, 24);
            this.SelectionPanelContainer.Name = "SelectionPanelContainer";
            this.SelectionPanelContainer.Size = new System.Drawing.Size(194, 241);
            this.SelectionPanelContainer.TabIndex = 0;
            // 
            // DataPanel
            // 
            this.DataPanel.FloatingLocation = new System.Drawing.Point(70, 418);
            this.DataPanel.InnerContainer = this.DataPanelContainer;
            this.DataPanel.Location = new System.Drawing.Point(0, 287);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(196, 118);
            this.DataPanel.TabIndex = 4;
            this.DataPanel.Text = "����";
            // 
            // DataPanelContainer
            // 
            this.DataPanelContainer.Location = new System.Drawing.Point(1, 23);
            this.DataPanelContainer.Name = "DataPanelContainer";
            this.DataPanelContainer.Size = new System.Drawing.Size(194, 94);
            this.DataPanelContainer.TabIndex = 0;
            // 
            // MapContainer
            // 
            this.MapContainer.CaptionVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.MapContainer.InnerContainer = this.MapContainerContainer;
            this.MapContainer.Location = new System.Drawing.Point(203, 29);
            this.MapContainer.Name = "MapContainer";
            this.MapContainer.Size = new System.Drawing.Size(690, 405);
            this.MapContainer.TabIndex = 4;
            this.MapContainer.Text = "��ͼ����";
            // 
            // MapContainerContainer
            // 
            this.MapContainerContainer.Controls.Add(this.axMap);
            this.MapContainerContainer.Location = new System.Drawing.Point(1, 1);
            this.MapContainerContainer.Name = "MapContainerContainer";
            this.MapContainerContainer.Size = new System.Drawing.Size(688, 403);
            this.MapContainerContainer.TabIndex = 0;
            // 
            // axMap
            // 
            this.axMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMap.Location = new System.Drawing.Point(0, 0);
            this.axMap.Name = "axMap";
            this.axMap.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap.OcxState")));
            this.axMap.Size = new System.Drawing.Size(688, 403);
            this.axMap.TabIndex = 3;
            this.axMap.MouseDownEvent += new ESRI.MapObjects2.Core.MouseDownEventHandler(this.axMap_MouseDownEvent);
            this.axMap.MouseMoveEvent += new ESRI.MapObjects2.Core.MouseMoveEventHandler(this.axMap_MouseMoveEvent);
            this.axMap.AfterLayerDraw += new ESRI.MapObjects2.Core.AfterLayerDrawEventHandler(this.axMap_AfterLayerDraw);
            this.axMap.AfterTrackingLayerDraw += new ESRI.MapObjects2.Core.AfterTrackingLayerDrawEventHandler(this.axMap_AfterTrackingLayerDraw);
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
            this.Text = "�丸 GIS";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiCommandManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelGroup1)).EndInit();
            this.uiPanelGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TOCPanel)).EndInit();
            this.TOCPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LayerPanel)).EndInit();
            this.LayerPanel.ResumeLayout(false);
            this.LayerPanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axlegend1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProperPanel)).EndInit();
            this.ProperPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectionPanel)).EndInit();
            this.SelectionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataPanel)).EndInit();
            this.DataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MapContainer)).EndInit();
            this.MapContainer.ResumeLayout(false);
            this.MapContainerContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMap)).EndInit();
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
        private ESRI.MapObjects2.Core.AxMap axMap;
        private Janus.Windows.UI.Dock.UIPanel SelectionPanel;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer SelectionPanelContainer;
        private AxSampleLegendControl.Axlegend axlegend1;

    }
}


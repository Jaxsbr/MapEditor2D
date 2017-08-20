namespace MapEditor2D
{
    partial class DesignerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignerForm));
            this.DesignSplitContainer = new System.Windows.Forms.SplitContainer();
            this.TileRenderControl = new MapEditor2D.TileRenderControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.layersTabPage = new System.Windows.Forms.TabPage();
            this.TilesetsTabPage = new System.Windows.Forms.TabPage();
            this.TileSetControl = new MapEditor2D.TileSetControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SelectedTileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DesignSplitContainer)).BeginInit();
            this.DesignSplitContainer.Panel1.SuspendLayout();
            this.DesignSplitContainer.Panel2.SuspendLayout();
            this.DesignSplitContainer.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TilesetsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DesignSplitContainer
            // 
            this.DesignSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesignSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.DesignSplitContainer.Name = "DesignSplitContainer";
            // 
            // DesignSplitContainer.Panel1
            // 
            this.DesignSplitContainer.Panel1.Controls.Add(this.TileRenderControl);
            // 
            // DesignSplitContainer.Panel2
            // 
            this.DesignSplitContainer.Panel2.Controls.Add(this.tabControl1);
            this.DesignSplitContainer.Size = new System.Drawing.Size(900, 651);
            this.DesignSplitContainer.SplitterDistance = 653;
            this.DesignSplitContainer.SplitterWidth = 8;
            this.DesignSplitContainer.TabIndex = 0;
            // 
            // TileRenderControl
            // 
            this.TileRenderControl.AutoScroll = true;
            this.TileRenderControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TileRenderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TileRenderControl.Location = new System.Drawing.Point(0, 0);
            this.TileRenderControl.Name = "TileRenderControl";
            this.TileRenderControl.Size = new System.Drawing.Size(653, 651);
            this.TileRenderControl.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.layersTabPage);
            this.tabControl1.Controls.Add(this.TilesetsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(239, 651);
            this.tabControl1.TabIndex = 0;
            // 
            // layersTabPage
            // 
            this.layersTabPage.Location = new System.Drawing.Point(4, 22);
            this.layersTabPage.Name = "layersTabPage";
            this.layersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.layersTabPage.Size = new System.Drawing.Size(231, 625);
            this.layersTabPage.TabIndex = 0;
            this.layersTabPage.Text = "Layers";
            this.layersTabPage.UseVisualStyleBackColor = true;
            // 
            // TilesetsTabPage
            // 
            this.TilesetsTabPage.Controls.Add(this.splitContainer2);
            this.TilesetsTabPage.Location = new System.Drawing.Point(4, 22);
            this.TilesetsTabPage.Name = "TilesetsTabPage";
            this.TilesetsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TilesetsTabPage.Size = new System.Drawing.Size(231, 625);
            this.TilesetsTabPage.TabIndex = 1;
            this.TilesetsTabPage.Text = "Tilesets";
            this.TilesetsTabPage.UseVisualStyleBackColor = true;
            // 
            // TileSetControl
            // 
            this.TileSetControl.BackColor = System.Drawing.Color.Silver;
            this.TileSetControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TileSetControl.Location = new System.Drawing.Point(0, 0);
            this.TileSetControl.Name = "TileSetControl";
            this.TileSetControl.Size = new System.Drawing.Size(225, 581);
            this.TileSetControl.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DesignSplitContainer);
            this.splitContainer1.Size = new System.Drawing.Size(900, 680);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(900, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SelectedTileLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.TileSetControl);
            this.splitContainer2.Size = new System.Drawing.Size(225, 619);
            this.splitContainer2.SplitterDistance = 34;
            this.splitContainer2.TabIndex = 0;
            // 
            // SelectedTileLabel
            // 
            this.SelectedTileLabel.AutoSize = true;
            this.SelectedTileLabel.Location = new System.Drawing.Point(4, 4);
            this.SelectedTileLabel.Name = "SelectedTileLabel";
            this.SelectedTileLabel.Size = new System.Drawing.Size(72, 13);
            this.SelectedTileLabel.TabIndex = 0;
            this.SelectedTileLabel.Text = "Selected Tile:";
            // 
            // DesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 680);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DesignerForm";
            this.Text = "DesignerForm";
            this.DesignSplitContainer.Panel1.ResumeLayout(false);
            this.DesignSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DesignSplitContainer)).EndInit();
            this.DesignSplitContainer.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TilesetsTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer DesignSplitContainer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private TileRenderControl TileRenderControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage layersTabPage;
        private System.Windows.Forms.TabPage TilesetsTabPage;
        private TileSetControl TileSetControl;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label SelectedTileLabel;
    }
}
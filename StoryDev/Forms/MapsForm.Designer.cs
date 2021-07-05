
namespace StoryDev.Forms
{
    partial class MapsForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Points", 1, 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapsForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.spcProperties = new System.Windows.Forms.SplitContainer();
            this.pnlMainProperties = new System.Windows.Forms.Panel();
            this.clbMapFlags = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbScope = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMapper = new System.Windows.Forms.Panel();
            this.tvMapper = new System.Windows.Forms.TreeView();
            this.cmsMapperOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.mapsCanvas = new StoryDev.Components.MapsCanvas();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcProperties)).BeginInit();
            this.spcProperties.Panel1.SuspendLayout();
            this.spcProperties.Panel2.SuspendLayout();
            this.spcProperties.SuspendLayout();
            this.pnlMainProperties.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMapper.SuspendLayout();
            this.cmsMapperOptions.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1209, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointPropertiesToolStripMenuItem});
            this.viewToolStripMenuItem.Enabled = false;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // pointPropertiesToolStripMenuItem
            // 
            this.pointPropertiesToolStripMenuItem.CheckOnClick = true;
            this.pointPropertiesToolStripMenuItem.Name = "pointPropertiesToolStripMenuItem";
            this.pointPropertiesToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.pointPropertiesToolStripMenuItem.Text = "Point Properties";
            this.pointPropertiesToolStripMenuItem.Click += new System.EventHandler(this.pointPropertiesToolStripMenuItem_Click);
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 33);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.spcProperties);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.mapsCanvas);
            this.spcMain.Size = new System.Drawing.Size(1209, 1069);
            this.spcMain.SplitterDistance = 309;
            this.spcMain.TabIndex = 1;
            // 
            // spcProperties
            // 
            this.spcProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcProperties.Location = new System.Drawing.Point(0, 0);
            this.spcProperties.Name = "spcProperties";
            this.spcProperties.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcProperties.Panel1
            // 
            this.spcProperties.Panel1.Controls.Add(this.pnlMainProperties);
            // 
            // spcProperties.Panel2
            // 
            this.spcProperties.Panel2.Controls.Add(this.pnlMapper);
            this.spcProperties.Size = new System.Drawing.Size(309, 1069);
            this.spcProperties.SplitterDistance = 513;
            this.spcProperties.TabIndex = 0;
            // 
            // pnlMainProperties
            // 
            this.pnlMainProperties.Controls.Add(this.clbMapFlags);
            this.pnlMainProperties.Controls.Add(this.label5);
            this.pnlMainProperties.Controls.Add(this.cmbScope);
            this.pnlMainProperties.Controls.Add(this.label4);
            this.pnlMainProperties.Controls.Add(this.txtName);
            this.pnlMainProperties.Controls.Add(this.label3);
            this.pnlMainProperties.Controls.Add(this.btnChooseImage);
            this.pnlMainProperties.Controls.Add(this.panel1);
            this.pnlMainProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainProperties.Enabled = false;
            this.pnlMainProperties.Location = new System.Drawing.Point(0, 0);
            this.pnlMainProperties.Name = "pnlMainProperties";
            this.pnlMainProperties.Size = new System.Drawing.Size(309, 513);
            this.pnlMainProperties.TabIndex = 0;
            // 
            // clbMapFlags
            // 
            this.clbMapFlags.FormattingEnabled = true;
            this.clbMapFlags.Items.AddRange(new object[] {
            "Reset Temporary Data Always",
            "Allow Interactions",
            "Disable Interactions"});
            this.clbMapFlags.Location = new System.Drawing.Point(12, 221);
            this.clbMapFlags.Name = "clbMapFlags";
            this.clbMapFlags.Size = new System.Drawing.Size(286, 165);
            this.clbMapFlags.TabIndex = 7;
            this.clbMapFlags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbMapFlags_ItemCheck);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Flags:";
            // 
            // cmbScope
            // 
            this.cmbScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScope.FormattingEnabled = true;
            this.cmbScope.Items.AddRange(new object[] {
            "World",
            "Local",
            "Dungeon"});
            this.cmbScope.Location = new System.Drawing.Point(12, 167);
            this.cmbScope.Name = "cmbScope";
            this.cmbScope.Size = new System.Drawing.Size(286, 28);
            this.cmbScope.TabIndex = 5;
            this.cmbScope.SelectedIndexChanged += new System.EventHandler(this.cmbScope_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Scope:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 26);
            this.txtName.TabIndex = 3;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(12, 106);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(117, 35);
            this.btnChooseImage.TabIndex = 1;
            this.btnChooseImage.Text = "Image...";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Properties";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMapper
            // 
            this.pnlMapper.Controls.Add(this.tvMapper);
            this.pnlMapper.Controls.Add(this.panel3);
            this.pnlMapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMapper.Enabled = false;
            this.pnlMapper.Location = new System.Drawing.Point(0, 0);
            this.pnlMapper.Name = "pnlMapper";
            this.pnlMapper.Size = new System.Drawing.Size(309, 552);
            this.pnlMapper.TabIndex = 1;
            // 
            // tvMapper
            // 
            this.tvMapper.ContextMenuStrip = this.cmsMapperOptions;
            this.tvMapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMapper.Enabled = false;
            this.tvMapper.ImageIndex = 0;
            this.tvMapper.ImageList = this.imageList1;
            this.tvMapper.Location = new System.Drawing.Point(0, 35);
            this.tvMapper.Name = "tvMapper";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Node1";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Points";
            this.tvMapper.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvMapper.SelectedImageIndex = 0;
            this.tvMapper.Size = new System.Drawing.Size(309, 517);
            this.tvMapper.TabIndex = 1;
            this.tvMapper.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMapper_AfterSelect);
            // 
            // cmsMapperOptions
            // 
            this.cmsMapperOptions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsMapperOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsMapperOptions.Name = "cmsMapperOptions";
            this.cmsMapperOptions.Size = new System.Drawing.Size(160, 100);
            this.cmsMapperOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMapperOptions_Opening);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(159, 32);
            this.newToolStripMenuItem1.Text = "New...";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(159, 32);
            this.renameToolStripMenuItem.Text = "Rename...";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(159, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Regions.png");
            this.imageList1.Images.SetKeyName(1, "Points.png");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 35);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mapper";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mapsCanvas
            // 
            this.mapsCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapsCanvas.Enabled = false;
            this.mapsCanvas.ImagePath = null;
            this.mapsCanvas.Location = new System.Drawing.Point(0, 0);
            this.mapsCanvas.Name = "mapsCanvas";
            this.mapsCanvas.Size = new System.Drawing.Size(896, 1069);
            this.mapsCanvas.TabIndex = 0;
            this.mapsCanvas.MapPointMoved += new StoryDev.OnMapPointMoved(this.mapsCanvas_MapPointMoved);
            this.mapsCanvas.MapConnect += new StoryDev.OnMapConnect(this.mapsCanvas_MapConnect);
            this.mapsCanvas.MapDisconnect += new StoryDev.OnMapDisconnect(this.mapsCanvas_MapDisconnect);
            // 
            // MapsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 1102);
            this.Controls.Add(this.spcMain);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MapsForm";
            this.Text = "Maps";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MapsForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.spcProperties.Panel1.ResumeLayout(false);
            this.spcProperties.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcProperties)).EndInit();
            this.spcProperties.ResumeLayout(false);
            this.pnlMainProperties.ResumeLayout(false);
            this.pnlMainProperties.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlMapper.ResumeLayout(false);
            this.cmsMapperOptions.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.SplitContainer spcProperties;
        private System.Windows.Forms.Panel pnlMainProperties;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMapper;
        private System.Windows.Forms.TreeView tvMapper;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsMapperOptions;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Components.MapsCanvas mapsCanvas;
        private System.Windows.Forms.ComboBox cmbScope;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clbMapFlags;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem pointPropertiesToolStripMenuItem;
    }
}
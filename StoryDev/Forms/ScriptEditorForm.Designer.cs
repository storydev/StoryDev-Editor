namespace StoryDev.Forms
{
    partial class ScriptEditorForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Game Functions", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Data", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Scripts", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptEditorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvScriptFiles = new System.Windows.Forms.TreeView();
            this.cmsFolderOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlEditContainer = new System.Windows.Forms.Panel();
            this.tcMain = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cmsFolderOptions.SuspendLayout();
            this.pnlEditContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1407, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvScriptFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlEditContainer);
            this.splitContainer1.Size = new System.Drawing.Size(1407, 904);
            this.splitContainer1.SplitterDistance = 335;
            this.splitContainer1.TabIndex = 1;
            // 
            // tvScriptFiles
            // 
            this.tvScriptFiles.ContextMenuStrip = this.cmsFolderOptions;
            this.tvScriptFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvScriptFiles.ImageIndex = 0;
            this.tvScriptFiles.ImageList = this.imageList1;
            this.tvScriptFiles.Location = new System.Drawing.Point(0, 0);
            this.tvScriptFiles.Name = "tvScriptFiles";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Node1";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Game Functions";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Node2";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Data";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "Node0";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Scripts";
            this.tvScriptFiles.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tvScriptFiles.PathSeparator = "/";
            this.tvScriptFiles.SelectedImageIndex = 0;
            this.tvScriptFiles.Size = new System.Drawing.Size(335, 904);
            this.tvScriptFiles.TabIndex = 0;
            this.tvScriptFiles.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvScriptFiles_NodeMouseDoubleClick);
            // 
            // cmsFolderOptions
            // 
            this.cmsFolderOptions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsFolderOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.toolStripSeparator1,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsFolderOptions.Name = "contextMenuStrip1";
            this.cmsFolderOptions.Size = new System.Drawing.Size(241, 139);
            this.cmsFolderOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsFolderOptions_Opening);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.scriptToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Image = global::StoryDev.Properties.Resources.OpenFolder;
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.folderToolStripMenuItem.Text = "Folder";
            this.folderToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // scriptToolStripMenuItem
            // 
            this.scriptToolStripMenuItem.Image = global::StoryDev.Properties.Resources.File;
            this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            this.scriptToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.scriptToolStripMenuItem.Text = "Script";
            this.scriptToolStripMenuItem.Click += new System.EventHandler(this.scriptToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "File.png");
            this.imageList1.Images.SetKeyName(1, "OpenFolder.png");
            // 
            // pnlEditContainer
            // 
            this.pnlEditContainer.Controls.Add(this.tcMain);
            this.pnlEditContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlEditContainer.Name = "pnlEditContainer";
            this.pnlEditContainer.Size = new System.Drawing.Size(1068, 904);
            this.pnlEditContainer.TabIndex = 0;
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1068, 904);
            this.tcMain.TabIndex = 0;
            // 
            // ScriptEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 928);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ScriptEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Script Editor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cmsFolderOptions.ResumeLayout(false);
            this.pnlEditContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvScriptFiles;
        private System.Windows.Forms.Panel pnlEditContainer;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip cmsFolderOptions;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
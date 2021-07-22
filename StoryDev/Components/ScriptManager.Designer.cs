
namespace StoryDev.Components
{
    partial class ScriptManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Scripts");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Events");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Data Modules");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptManager));
            this.cmsRootOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.tvScripts = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.spcContent = new System.Windows.Forms.SplitContainer();
            this.pnlFileOptions = new System.Windows.Forms.Panel();
            this.editor = new StoryDev.Components.CodeEditor();
            this.cmsRootOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcContent)).BeginInit();
            this.spcContent.Panel1.SuspendLayout();
            this.spcContent.Panel2.SuspendLayout();
            this.spcContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editor)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsRootOptions
            // 
            this.cmsRootOptions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsRootOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.toolStripSeparator1,
            this.propertiesToolStripMenuItem});
            this.cmsRootOptions.Name = "cmsRootOptions";
            this.cmsRootOptions.Size = new System.Drawing.Size(177, 74);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.scriptFileToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(176, 32);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Image = global::StoryDev.Properties.Resources.Folder;
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.folderToolStripMenuItem.Text = "Folder";
            this.folderToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // scriptFileToolStripMenuItem
            // 
            this.scriptFileToolStripMenuItem.Image = global::StoryDev.Properties.Resources.HXS_File_Icon;
            this.scriptFileToolStripMenuItem.Name = "scriptFileToolStripMenuItem";
            this.scriptFileToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.scriptFileToolStripMenuItem.Text = "Script File";
            this.scriptFileToolStripMenuItem.Click += new System.EventHandler(this.scriptFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(176, 32);
            this.propertiesToolStripMenuItem.Text = "Properties...";
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 0);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.tvScripts);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.spcContent);
            this.spcMain.Size = new System.Drawing.Size(1172, 786);
            this.spcMain.SplitterDistance = 270;
            this.spcMain.TabIndex = 0;
            // 
            // tvScripts
            // 
            this.tvScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvScripts.ImageIndex = 0;
            this.tvScripts.ImageList = this.imageList1;
            this.tvScripts.Location = new System.Drawing.Point(0, 0);
            this.tvScripts.Name = "tvScripts";
            treeNode1.ContextMenuStrip = this.cmsRootOptions;
            treeNode1.Name = "Node0";
            treeNode1.Text = "Scripts";
            treeNode2.ContextMenuStrip = this.cmsRootOptions;
            treeNode2.Name = "Node1";
            treeNode2.Text = "Events";
            treeNode3.ContextMenuStrip = this.cmsRootOptions;
            treeNode3.Name = "Node2";
            treeNode3.Text = "Data Modules";
            this.tvScripts.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.tvScripts.SelectedImageIndex = 0;
            this.tvScripts.Size = new System.Drawing.Size(270, 786);
            this.tvScripts.TabIndex = 0;
            this.tvScripts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvScripts_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder.png");
            this.imageList1.Images.SetKeyName(1, "HXS File Icon.png");
            // 
            // spcContent
            // 
            this.spcContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcContent.Location = new System.Drawing.Point(0, 0);
            this.spcContent.Name = "spcContent";
            this.spcContent.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcContent.Panel1
            // 
            this.spcContent.Panel1.Controls.Add(this.editor);
            this.spcContent.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // spcContent.Panel2
            // 
            this.spcContent.Panel2.Controls.Add(this.pnlFileOptions);
            this.spcContent.Size = new System.Drawing.Size(898, 786);
            this.spcContent.SplitterDistance = 595;
            this.spcContent.TabIndex = 0;
            // 
            // pnlFileOptions
            // 
            this.pnlFileOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFileOptions.Enabled = false;
            this.pnlFileOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlFileOptions.Name = "pnlFileOptions";
            this.pnlFileOptions.Size = new System.Drawing.Size(898, 187);
            this.pnlFileOptions.TabIndex = 0;
            // 
            // editor
            // 
            this.editor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.editor.AutoScrollMinSize = new System.Drawing.Size(167, 22);
            this.editor.BackBrush = null;
            this.editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editor.CaretColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.editor.CharHeight = 22;
            this.editor.CharWidth = 12;
            this.editor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editor.DelayedTextChangedInterval = 170;
            this.editor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.Enabled = false;
            this.editor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.editor.IsReplaceMode = false;
            this.editor.Location = new System.Drawing.Point(0, 0);
            this.editor.Name = "editor";
            this.editor.Paddings = new System.Windows.Forms.Padding(0);
            this.editor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(239)))));
            this.editor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("editor.ServiceColors")));
            this.editor.Size = new System.Drawing.Size(898, 595);
            this.editor.TabIndex = 0;
            this.editor.Text = "codeEditor1";
            this.editor.Zoom = 100;
            // 
            // ScriptManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spcMain);
            this.Name = "ScriptManager";
            this.Size = new System.Drawing.Size(1172, 786);
            this.cmsRootOptions.ResumeLayout(false);
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.spcContent.Panel1.ResumeLayout(false);
            this.spcContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcContent)).EndInit();
            this.spcContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.TreeView tvScripts;
        private System.Windows.Forms.SplitContainer spcContent;
        private CodeEditor editor;
        private System.Windows.Forms.Panel pnlFileOptions;
        private System.Windows.Forms.ContextMenuStrip cmsRootOptions;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}

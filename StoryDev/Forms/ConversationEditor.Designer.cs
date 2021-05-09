
namespace StoryDev.Forms
{
    partial class ConversationEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversationEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConversationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlDesigner = new System.Windows.Forms.Panel();
            this.branchDesignerUI1 = new StoryDev.Components.BranchDesignerUI();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbSnapping = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.storyEditor = new StoryDev.Components.CodeEditor();
            this.pnlChoiceProperties = new System.Windows.Forms.Panel();
            this.pnlChoices = new System.Windows.Forms.Panel();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.cmbBranches = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlDesigner.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storyEditor)).BeginInit();
            this.pnlChoiceProperties.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1705, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveConversationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveConversationToolStripMenuItem
            // 
            this.saveConversationToolStripMenuItem.Enabled = false;
            this.saveConversationToolStripMenuItem.Name = "saveConversationToolStripMenuItem";
            this.saveConversationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveConversationToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.saveConversationToolStripMenuItem.Text = "Save Conversation";
            this.saveConversationToolStripMenuItem.Click += new System.EventHandler(this.saveConversationToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlDesigner);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1MinSize = 500;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.storyEditor);
            this.splitContainer1.Panel2.Controls.Add(this.pnlChoiceProperties);
            this.splitContainer1.Panel2.Controls.Add(this.pnlTools);
            this.splitContainer1.Size = new System.Drawing.Size(1705, 972);
            this.splitContainer1.SplitterDistance = 824;
            this.splitContainer1.TabIndex = 1;
            // 
            // pnlDesigner
            // 
            this.pnlDesigner.Controls.Add(this.branchDesignerUI1);
            this.pnlDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesigner.Location = new System.Drawing.Point(0, 43);
            this.pnlDesigner.Name = "pnlDesigner";
            this.pnlDesigner.Size = new System.Drawing.Size(824, 929);
            this.pnlDesigner.TabIndex = 0;
            // 
            // branchDesignerUI1
            // 
            this.branchDesignerUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.branchDesignerUI1.Enabled = false;
            this.branchDesignerUI1.Location = new System.Drawing.Point(0, 0);
            this.branchDesignerUI1.Name = "branchDesignerUI1";
            this.branchDesignerUI1.Size = new System.Drawing.Size(824, 929);
            this.branchDesignerUI1.Snapping = false;
            this.branchDesignerUI1.TabIndex = 0;
            this.branchDesignerUI1.View = StoryDev.Components.BranchView.Branch;
            this.branchDesignerUI1.BranchSelectedIndexChanged += new StoryDev.OnBranchSelectedIndexChanged(this.branchDesignerUI1_BranchSelectedIndexChanged);
            this.branchDesignerUI1.BranchAdded += new StoryDev.OnBranchAdded(this.branchDesignerUI1_BranchAdded);
            this.branchDesignerUI1.BranchRenamed += new StoryDev.OnBranchRenamed(this.branchDesignerUI1_BranchRenamed);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbSnapping);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 43);
            this.panel1.TabIndex = 0;
            // 
            // chbSnapping
            // 
            this.chbSnapping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbSnapping.AutoSize = true;
            this.chbSnapping.Location = new System.Drawing.Point(534, 10);
            this.chbSnapping.Name = "chbSnapping";
            this.chbSnapping.Size = new System.Drawing.Size(103, 24);
            this.chbSnapping.TabIndex = 3;
            this.chbSnapping.Text = "Snapping";
            this.chbSnapping.UseVisualStyleBackColor = true;
            this.chbSnapping.CheckedChanged += new System.EventHandler(this.chbSnapping_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "View:";
            // 
            // cmbView
            // 
            this.cmbView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "Branch",
            "List"});
            this.cmbView.Location = new System.Drawing.Point(700, 8);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(121, 28);
            this.cmbView.TabIndex = 1;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // storyEditor
            // 
            this.storyEditor.AutoCompleteBracketsList = new char[] {
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
            this.storyEditor.AutoScrollMinSize = new System.Drawing.Size(167, 22);
            this.storyEditor.BackBrush = null;
            this.storyEditor.CharHeight = 22;
            this.storyEditor.CharWidth = 12;
            this.storyEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.storyEditor.DelayedTextChangedInterval = 170;
            this.storyEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.storyEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storyEditor.Enabled = false;
            this.storyEditor.IsReplaceMode = false;
            this.storyEditor.Location = new System.Drawing.Point(0, 43);
            this.storyEditor.Name = "storyEditor";
            this.storyEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.storyEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.storyEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("storyEditor.ServiceColors")));
            this.storyEditor.Size = new System.Drawing.Size(877, 694);
            this.storyEditor.TabIndex = 2;
            this.storyEditor.Text = "codeEditor1";
            this.storyEditor.Zoom = 100;
            this.storyEditor.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.storyEditor_TextChanged);
            this.storyEditor.Load += new System.EventHandler(this.storyEditor_Load);
            this.storyEditor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.storyEditor_KeyUp);
            // 
            // pnlChoiceProperties
            // 
            this.pnlChoiceProperties.Controls.Add(this.pnlChoices);
            this.pnlChoiceProperties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChoiceProperties.Enabled = false;
            this.pnlChoiceProperties.Location = new System.Drawing.Point(0, 737);
            this.pnlChoiceProperties.Name = "pnlChoiceProperties";
            this.pnlChoiceProperties.Size = new System.Drawing.Size(877, 235);
            this.pnlChoiceProperties.TabIndex = 1;
            // 
            // pnlChoices
            // 
            this.pnlChoices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChoices.AutoScroll = true;
            this.pnlChoices.Location = new System.Drawing.Point(16, 6);
            this.pnlChoices.Name = "pnlChoices";
            this.pnlChoices.Size = new System.Drawing.Size(755, 226);
            this.pnlChoices.TabIndex = 0;
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.cmbBranches);
            this.pnlTools.Controls.Add(this.label1);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.Enabled = false;
            this.pnlTools.Location = new System.Drawing.Point(0, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(877, 43);
            this.pnlTools.TabIndex = 0;
            // 
            // cmbBranches
            // 
            this.cmbBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranches.FormattingEnabled = true;
            this.cmbBranches.Location = new System.Drawing.Point(149, 8);
            this.cmbBranches.Name = "cmbBranches";
            this.cmbBranches.Size = new System.Drawing.Size(247, 28);
            this.cmbBranches.TabIndex = 1;
            this.cmbBranches.SelectedIndexChanged += new System.EventHandler(this.cmbBranches_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dialogue Branch:";
            // 
            // ConversationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1705, 1005);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConversationEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversation Editor";
            this.Load += new System.EventHandler(this.ConversationEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlDesigner.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storyEditor)).EndInit();
            this.pnlChoiceProperties.ResumeLayout(false);
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConversationToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDesigner;
        private Components.CodeEditor storyEditor;
        private System.Windows.Forms.Panel pnlChoiceProperties;
        private System.Windows.Forms.Panel pnlChoices;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.ComboBox cmbBranches;
        private System.Windows.Forms.Label label1;
        private Components.BranchDesignerUI branchDesignerUI1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.CheckBox chbSnapping;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}
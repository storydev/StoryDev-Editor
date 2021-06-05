
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
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storyOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.customVariablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlDesigner = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbSnapping = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.pnlChoiceProperties = new System.Windows.Forms.Panel();
            this.pnlChoices = new System.Windows.Forms.Panel();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.cmbBranches = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.branchDesignerUI1 = new StoryDev.Components.BranchDesignerUI();
            this.storyEditor = new StoryDev.Components.CodeEditor();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlDesigner.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlChoiceProperties.SuspendLayout();
            this.pnlTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storyEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.simulationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 36);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
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
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storyOrderToolStripMenuItem,
            this.simulationsToolStripMenuItem,
            this.toolStripSeparator1,
            this.customVariablesToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(112, 32);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // storyOrderToolStripMenuItem
            // 
            this.storyOrderToolStripMenuItem.Name = "storyOrderToolStripMenuItem";
            this.storyOrderToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.storyOrderToolStripMenuItem.Text = "Story Order...";
            this.storyOrderToolStripMenuItem.Click += new System.EventHandler(this.storyOrderToolStripMenuItem_Click);
            // 
            // simulationsToolStripMenuItem
            // 
            this.simulationsToolStripMenuItem.CheckOnClick = true;
            this.simulationsToolStripMenuItem.Name = "simulationsToolStripMenuItem";
            this.simulationsToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.simulationsToolStripMenuItem.Text = "Simulations...";
            this.simulationsToolStripMenuItem.Click += new System.EventHandler(this.simulationsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(260, 6);
            // 
            // customVariablesToolStripMenuItem
            // 
            this.customVariablesToolStripMenuItem.Name = "customVariablesToolStripMenuItem";
            this.customVariablesToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.customVariablesToolStripMenuItem.Text = "Custom Variables...";
            this.customVariablesToolStripMenuItem.Click += new System.EventHandler(this.customVariablesToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.optionsToolStripMenuItem.Text = "Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
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
            this.splitContainer1.Size = new System.Drawing.Size(1370, 713);
            this.splitContainer1.SplitterDistance = 750;
            this.splitContainer1.TabIndex = 1;
            // 
            // pnlDesigner
            // 
            this.pnlDesigner.Controls.Add(this.branchDesignerUI1);
            this.pnlDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesigner.Location = new System.Drawing.Point(0, 43);
            this.pnlDesigner.Name = "pnlDesigner";
            this.pnlDesigner.Size = new System.Drawing.Size(750, 670);
            this.pnlDesigner.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbSnapping);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 43);
            this.panel1.TabIndex = 0;
            // 
            // chbSnapping
            // 
            this.chbSnapping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbSnapping.AutoSize = true;
            this.chbSnapping.Location = new System.Drawing.Point(459, 9);
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
            this.label2.Location = new System.Drawing.Point(570, 11);
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
            this.cmbView.Location = new System.Drawing.Point(627, 8);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(121, 28);
            this.cmbView.TabIndex = 1;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // pnlChoiceProperties
            // 
            this.pnlChoiceProperties.Controls.Add(this.pnlChoices);
            this.pnlChoiceProperties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChoiceProperties.Enabled = false;
            this.pnlChoiceProperties.Location = new System.Drawing.Point(0, 478);
            this.pnlChoiceProperties.Name = "pnlChoiceProperties";
            this.pnlChoiceProperties.Size = new System.Drawing.Size(616, 235);
            this.pnlChoiceProperties.TabIndex = 1;
            // 
            // pnlChoices
            // 
            this.pnlChoices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChoices.AutoScroll = true;
            this.pnlChoices.Location = new System.Drawing.Point(16, 6);
            this.pnlChoices.Name = "pnlChoices";
            this.pnlChoices.Size = new System.Drawing.Size(493, 226);
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
            this.pnlTools.Size = new System.Drawing.Size(616, 43);
            this.pnlTools.TabIndex = 0;
            // 
            // cmbBranches
            // 
            this.cmbBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranches.FormattingEnabled = true;
            this.cmbBranches.Location = new System.Drawing.Point(148, 8);
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
            // branchDesignerUI1
            // 
            this.branchDesignerUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.branchDesignerUI1.Enabled = false;
            this.branchDesignerUI1.Location = new System.Drawing.Point(0, 0);
            this.branchDesignerUI1.Margin = new System.Windows.Forms.Padding(2);
            this.branchDesignerUI1.Name = "branchDesignerUI1";
            this.branchDesignerUI1.Size = new System.Drawing.Size(750, 670);
            this.branchDesignerUI1.Snapping = false;
            this.branchDesignerUI1.TabIndex = 0;
            this.branchDesignerUI1.View = StoryDev.Components.BranchView.Branch;
            this.branchDesignerUI1.BranchSelectedIndexChanged += new StoryDev.OnBranchSelectedIndexChanged(this.branchDesignerUI1_BranchSelectedIndexChanged);
            this.branchDesignerUI1.BranchAdded += new StoryDev.OnBranchAdded(this.branchDesignerUI1_BranchAdded);
            this.branchDesignerUI1.BranchRenamed += new StoryDev.OnBranchRenamed(this.branchDesignerUI1_BranchRenamed);
            this.branchDesignerUI1.BranchDeleted += new StoryDev.OnBranchDeleted(this.branchDesignerUI1_BranchDeleted);
            this.branchDesignerUI1.BranchesLinked += new StoryDev.OnBranchesLinked(this.branchDesignerUI1_BranchesLinked);
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
            this.storyEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.storyEditor.CaretColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.storyEditor.CharHeight = 22;
            this.storyEditor.CharWidth = 12;
            this.storyEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.storyEditor.DelayedTextChangedInterval = 170;
            this.storyEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.storyEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storyEditor.Enabled = false;
            this.storyEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.storyEditor.IsReplaceMode = false;
            this.storyEditor.Location = new System.Drawing.Point(0, 43);
            this.storyEditor.Name = "storyEditor";
            this.storyEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.storyEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(239)))));
            this.storyEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("storyEditor.ServiceColors")));
            this.storyEditor.Size = new System.Drawing.Size(616, 435);
            this.storyEditor.TabIndex = 2;
            this.storyEditor.Text = "codeEditor1";
            this.storyEditor.Zoom = 100;
            this.storyEditor.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.storyEditor_TextChanged);
            this.storyEditor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.storyEditor_KeyUp);
            // 
            // ConversationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConversationEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversation Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConversationEditor_FormClosing);
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
            this.pnlChoiceProperties.ResumeLayout(false);
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storyEditor)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem storyOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customVariablesToolStripMenuItem;
        private Components.CodeEditor storyEditor;
    }
}
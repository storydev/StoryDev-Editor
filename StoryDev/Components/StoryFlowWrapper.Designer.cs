namespace StoryDev.Components
{
    partial class StoryFlowWrapper
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
            this.pnlTools = new System.Windows.Forms.Panel();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.pnlProperties = new System.Windows.Forms.Panel();
            this.storyFlow = new StoryDev.Components.StoryFlowUI();
            this.spbtnWrappers = new StoryDev.Components.SplitButton();
            this.cmsWrappers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spcbtnNewItem = new StoryDev.Components.SplitButton();
            this.cmsItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conversationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.cmsWrappers.SuspendLayout();
            this.cmsItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.spcbtnNewItem);
            this.pnlTools.Controls.Add(this.spbtnWrappers);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.Location = new System.Drawing.Point(0, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Padding = new System.Windows.Forms.Padding(4);
            this.pnlTools.Size = new System.Drawing.Size(1171, 52);
            this.pnlTools.TabIndex = 0;
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 52);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.storyFlow);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.pnlProperties);
            this.spcMain.Size = new System.Drawing.Size(1171, 631);
            this.spcMain.SplitterDistance = 791;
            this.spcMain.TabIndex = 1;
            // 
            // pnlProperties
            // 
            this.pnlProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProperties.Location = new System.Drawing.Point(0, 0);
            this.pnlProperties.Name = "pnlProperties";
            this.pnlProperties.Size = new System.Drawing.Size(376, 631);
            this.pnlProperties.TabIndex = 0;
            // 
            // storyFlow
            // 
            this.storyFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storyFlow.Location = new System.Drawing.Point(0, 0);
            this.storyFlow.Name = "storyFlow";
            this.storyFlow.Size = new System.Drawing.Size(791, 631);
            this.storyFlow.TabIndex = 0;
            // 
            // spbtnWrappers
            // 
            this.spbtnWrappers.Dock = System.Windows.Forms.DockStyle.Left;
            this.spbtnWrappers.Location = new System.Drawing.Point(4, 4);
            this.spbtnWrappers.Menu = this.cmsWrappers;
            this.spbtnWrappers.Name = "spbtnWrappers";
            this.spbtnWrappers.Size = new System.Drawing.Size(138, 44);
            this.spbtnWrappers.TabIndex = 0;
            this.spbtnWrappers.Text = "New";
            this.spbtnWrappers.UseVisualStyleBackColor = true;
            // 
            // cmsWrappers
            // 
            this.cmsWrappers.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsWrappers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripMenuItem,
            this.tagToolStripMenuItem});
            this.cmsWrappers.Name = "cmsWrappers";
            this.cmsWrappers.Size = new System.Drawing.Size(135, 68);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // tagToolStripMenuItem
            // 
            this.tagToolStripMenuItem.Name = "tagToolStripMenuItem";
            this.tagToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.tagToolStripMenuItem.Text = "Tag";
            // 
            // spcbtnNewItem
            // 
            this.spcbtnNewItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.spcbtnNewItem.Enabled = false;
            this.spcbtnNewItem.Location = new System.Drawing.Point(142, 4);
            this.spcbtnNewItem.Menu = this.cmsWrappers;
            this.spcbtnNewItem.Name = "spcbtnNewItem";
            this.spcbtnNewItem.Size = new System.Drawing.Size(138, 44);
            this.spcbtnNewItem.TabIndex = 1;
            this.spcbtnNewItem.Text = "New Item";
            this.spcbtnNewItem.UseVisualStyleBackColor = true;
            // 
            // cmsItems
            // 
            this.cmsItems.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conversationToolStripMenuItem,
            this.eventToolStripMenuItem,
            this.placesToolStripMenuItem,
            this.featuresToolStripMenuItem});
            this.cmsItems.Name = "cmsItems";
            this.cmsItems.Size = new System.Drawing.Size(201, 132);
            // 
            // conversationToolStripMenuItem
            // 
            this.conversationToolStripMenuItem.Name = "conversationToolStripMenuItem";
            this.conversationToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.conversationToolStripMenuItem.Text = "Conversation...";
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.eventToolStripMenuItem.Text = "Event...";
            // 
            // placesToolStripMenuItem
            // 
            this.placesToolStripMenuItem.Name = "placesToolStripMenuItem";
            this.placesToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.placesToolStripMenuItem.Text = "Places...";
            // 
            // featuresToolStripMenuItem
            // 
            this.featuresToolStripMenuItem.Name = "featuresToolStripMenuItem";
            this.featuresToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.featuresToolStripMenuItem.Text = "Features...";
            // 
            // StoryFlowWrapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spcMain);
            this.Controls.Add(this.pnlTools);
            this.Name = "StoryFlowWrapper";
            this.Size = new System.Drawing.Size(1171, 683);
            this.pnlTools.ResumeLayout(false);
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.cmsWrappers.ResumeLayout(false);
            this.cmsItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.Panel pnlProperties;
        private StoryFlowUI storyFlow;
        private SplitButton spbtnWrappers;
        private System.Windows.Forms.ContextMenuStrip cmsWrappers;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagToolStripMenuItem;
        private SplitButton spcbtnNewItem;
        private System.Windows.Forms.ContextMenuStrip cmsItems;
        private System.Windows.Forms.ToolStripMenuItem conversationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featuresToolStripMenuItem;
    }
}

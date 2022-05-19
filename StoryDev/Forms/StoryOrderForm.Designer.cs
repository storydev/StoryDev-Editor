namespace StoryDev.Forms
{
    partial class StoryOrderForm
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
            this.tscDesigner = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewTimeline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbConversation = new System.Windows.Forms.ToolStripButton();
            this.tsbDiscovery = new System.Windows.Forms.ToolStripButton();
            this.tsbEvent = new System.Windows.Forms.ToolStripButton();
            this.tsbExecute = new System.Windows.Forms.ToolStripButton();
            this.tscDesigner.TopToolStripPanel.SuspendLayout();
            this.tscDesigner.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscDesigner
            // 
            this.tscDesigner.BottomToolStripPanelVisible = false;
            // 
            // tscDesigner.ContentPanel
            // 
            this.tscDesigner.ContentPanel.Size = new System.Drawing.Size(1354, 788);
            this.tscDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscDesigner.LeftToolStripPanelVisible = false;
            this.tscDesigner.Location = new System.Drawing.Point(0, 0);
            this.tscDesigner.Name = "tscDesigner";
            this.tscDesigner.RightToolStripPanelVisible = false;
            this.tscDesigner.Size = new System.Drawing.Size(1354, 833);
            this.tscDesigner.TabIndex = 0;
            this.tscDesigner.Text = "toolStripContainer1";
            // 
            // tscDesigner.TopToolStripPanel
            // 
            this.tscDesigner.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewTimeline,
            this.toolStripSeparator1,
            this.tsbConversation,
            this.tsbDiscovery,
            this.tsbEvent,
            this.tsbExecute});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(270, 45);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbNewTimeline
            // 
            this.tsbNewTimeline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewTimeline.Image = global::StoryDev.Properties.Resources.NewTimeline;
            this.tsbNewTimeline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewTimeline.Name = "tsbNewTimeline";
            this.tsbNewTimeline.Size = new System.Drawing.Size(40, 40);
            this.tsbNewTimeline.Text = "New Timeline";
            this.tsbNewTimeline.Click += new System.EventHandler(this.tsbNewTimeline_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // tsbConversation
            // 
            this.tsbConversation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbConversation.Enabled = false;
            this.tsbConversation.Image = global::StoryDev.Properties.Resources.Conversation;
            this.tsbConversation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConversation.Name = "tsbConversation";
            this.tsbConversation.Size = new System.Drawing.Size(40, 40);
            this.tsbConversation.Text = "toolStripButton1";
            this.tsbConversation.Click += new System.EventHandler(this.tsbConversation_Click);
            // 
            // tsbDiscovery
            // 
            this.tsbDiscovery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDiscovery.Enabled = false;
            this.tsbDiscovery.Image = global::StoryDev.Properties.Resources.Discovery;
            this.tsbDiscovery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDiscovery.Name = "tsbDiscovery";
            this.tsbDiscovery.Size = new System.Drawing.Size(40, 40);
            this.tsbDiscovery.Text = "toolStripButton1";
            // 
            // tsbEvent
            // 
            this.tsbEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEvent.Enabled = false;
            this.tsbEvent.Image = global::StoryDev.Properties.Resources.Event;
            this.tsbEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEvent.Name = "tsbEvent";
            this.tsbEvent.Size = new System.Drawing.Size(40, 40);
            this.tsbEvent.Text = "toolStripButton1";
            // 
            // tsbExecute
            // 
            this.tsbExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExecute.Enabled = false;
            this.tsbExecute.Image = global::StoryDev.Properties.Resources.Execute;
            this.tsbExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExecute.Name = "tsbExecute";
            this.tsbExecute.Size = new System.Drawing.Size(40, 40);
            this.tsbExecute.Text = "toolStripButton1";
            // 
            // StoryOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 833);
            this.Controls.Add(this.tscDesigner);
            this.DoubleBuffered = true;
            this.Name = "StoryOrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Story Order";
            this.tscDesigner.TopToolStripPanel.ResumeLayout(false);
            this.tscDesigner.TopToolStripPanel.PerformLayout();
            this.tscDesigner.ResumeLayout(false);
            this.tscDesigner.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscDesigner;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbConversation;
        private System.Windows.Forms.ToolStripButton tsbDiscovery;
        private System.Windows.Forms.ToolStripButton tsbEvent;
        private System.Windows.Forms.ToolStripButton tsbExecute;
        private System.Windows.Forms.ToolStripButton tsbNewTimeline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
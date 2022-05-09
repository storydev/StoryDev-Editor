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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbConversation = new System.Windows.Forms.ToolStripButton();
            this.tsbDiscovery = new System.Windows.Forms.ToolStripButton();
            this.tsbEvent = new System.Windows.Forms.ToolStripButton();
            this.tsbExecute = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1354, 800);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1354, 833);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConversation,
            this.tsbDiscovery,
            this.tsbEvent,
            this.tsbExecute});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(154, 33);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbConversation
            // 
            this.tsbConversation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbConversation.Image = global::StoryDev.Properties.Resources.Conversation;
            this.tsbConversation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConversation.Name = "tsbConversation";
            this.tsbConversation.Size = new System.Drawing.Size(34, 28);
            this.tsbConversation.Text = "toolStripButton1";
            // 
            // tsbDiscovery
            // 
            this.tsbDiscovery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDiscovery.Image = global::StoryDev.Properties.Resources.Discovery;
            this.tsbDiscovery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDiscovery.Name = "tsbDiscovery";
            this.tsbDiscovery.Size = new System.Drawing.Size(34, 28);
            this.tsbDiscovery.Text = "toolStripButton1";
            // 
            // tsbEvent
            // 
            this.tsbEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEvent.Image = global::StoryDev.Properties.Resources.Event;
            this.tsbEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEvent.Name = "tsbEvent";
            this.tsbEvent.Size = new System.Drawing.Size(34, 28);
            this.tsbEvent.Text = "toolStripButton1";
            // 
            // tsbExecute
            // 
            this.tsbExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExecute.Image = global::StoryDev.Properties.Resources.Execute;
            this.tsbExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExecute.Name = "tsbExecute";
            this.tsbExecute.Size = new System.Drawing.Size(34, 28);
            this.tsbExecute.Text = "toolStripButton1";
            // 
            // StoryOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 833);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "StoryOrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Story Order";
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbConversation;
        private System.Windows.Forms.ToolStripButton tsbDiscovery;
        private System.Windows.Forms.ToolStripButton tsbEvent;
        private System.Windows.Forms.ToolStripButton tsbExecute;
    }
}
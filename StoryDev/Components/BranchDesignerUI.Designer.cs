
namespace StoryDev.Components
{
    partial class BranchDesignerUI
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
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.cmsBranchOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsBranchOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // hScrollBar
            // 
            this.hScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar.Location = new System.Drawing.Point(0, 684);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(934, 26);
            this.hScrollBar.TabIndex = 0;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar.Location = new System.Drawing.Point(908, 0);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(26, 684);
            this.vScrollBar.TabIndex = 1;
            // 
            // cmsBranchOptions
            // 
            this.cmsBranchOptions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsBranchOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBranchToolStripMenuItem,
            this.toolStripSeparator1,
            this.renameToolStripMenuItem});
            this.cmsBranchOptions.Name = "contextMenuStrip1";
            this.cmsBranchOptions.Size = new System.Drawing.Size(241, 107);
            // 
            // addBranchToolStripMenuItem
            // 
            this.addBranchToolStripMenuItem.Name = "addBranchToolStripMenuItem";
            this.addBranchToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.addBranchToolStripMenuItem.Text = "Add Branch...";
            this.addBranchToolStripMenuItem.Click += new System.EventHandler(this.addBranchToolStripMenuItem_Click);
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
            this.renameToolStripMenuItem.Text = "Rename...";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // BranchDesignerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.hScrollBar);
            this.Name = "BranchDesignerUI";
            this.Size = new System.Drawing.Size(934, 710);
            this.cmsBranchOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.ContextMenuStrip cmsBranchOptions;
        private System.Windows.Forms.ToolStripMenuItem addBranchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
    }
}

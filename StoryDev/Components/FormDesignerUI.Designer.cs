
namespace StoryDev.Components
{
    partial class FormDesignerUI
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
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowBeforeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowAfterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.insertComponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percentageWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtPercentageWidth = new System.Windows.Forms.ToolStripTextBox();
            this.fixedWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFixedWidth = new System.Windows.Forms.ToolStripTextBox();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsMain
            // 
            this.cmsMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addColumnToolStripMenuItem,
            this.addRowBeforeToolStripMenuItem,
            this.addRowAfterToolStripMenuItem,
            this.toolStripSeparator1,
            this.percentageWidthToolStripMenuItem,
            this.fixedWidthToolStripMenuItem,
            this.toolStripSeparator2,
            this.insertComponentToolStripMenuItem});
            this.cmsMain.Name = "contextMenuStrip1";
            this.cmsMain.Size = new System.Drawing.Size(241, 208);
            // 
            // addColumnToolStripMenuItem
            // 
            this.addColumnToolStripMenuItem.Name = "addColumnToolStripMenuItem";
            this.addColumnToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.addColumnToolStripMenuItem.Text = "Add Column";
            // 
            // addRowBeforeToolStripMenuItem
            // 
            this.addRowBeforeToolStripMenuItem.Name = "addRowBeforeToolStripMenuItem";
            this.addRowBeforeToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.addRowBeforeToolStripMenuItem.Text = "Add Row Before";
            // 
            // addRowAfterToolStripMenuItem
            // 
            this.addRowAfterToolStripMenuItem.Name = "addRowAfterToolStripMenuItem";
            this.addRowAfterToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.addRowAfterToolStripMenuItem.Text = "Add Row After";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // insertComponentToolStripMenuItem
            // 
            this.insertComponentToolStripMenuItem.Name = "insertComponentToolStripMenuItem";
            this.insertComponentToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.insertComponentToolStripMenuItem.Text = "Insert Component...";
            // 
            // percentageWidthToolStripMenuItem
            // 
            this.percentageWidthToolStripMenuItem.Checked = true;
            this.percentageWidthToolStripMenuItem.CheckOnClick = true;
            this.percentageWidthToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.percentageWidthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtPercentageWidth});
            this.percentageWidthToolStripMenuItem.Name = "percentageWidthToolStripMenuItem";
            this.percentageWidthToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.percentageWidthToolStripMenuItem.Text = "Percentage Width";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(237, 6);
            // 
            // txtPercentageWidth
            // 
            this.txtPercentageWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPercentageWidth.Name = "txtPercentageWidth";
            this.txtPercentageWidth.Size = new System.Drawing.Size(100, 31);
            // 
            // fixedWidthToolStripMenuItem
            // 
            this.fixedWidthToolStripMenuItem.CheckOnClick = true;
            this.fixedWidthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtFixedWidth});
            this.fixedWidthToolStripMenuItem.Name = "fixedWidthToolStripMenuItem";
            this.fixedWidthToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.fixedWidthToolStripMenuItem.Text = "Fixed Width";
            // 
            // txtFixedWidth
            // 
            this.txtFixedWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFixedWidth.Name = "txtFixedWidth";
            this.txtFixedWidth.Size = new System.Drawing.Size(100, 31);
            // 
            // FormDesignerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FormDesignerUI";
            this.Size = new System.Drawing.Size(485, 345);
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem addColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRowBeforeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRowAfterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem insertComponentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem percentageWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtPercentageWidth;
        private System.Windows.Forms.ToolStripMenuItem fixedWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtFixedWidth;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

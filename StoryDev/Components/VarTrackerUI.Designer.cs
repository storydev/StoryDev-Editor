
namespace StoryDev.Components
{
    partial class VarTrackerUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tvVariables = new System.Windows.Forms.TreeView();
            this.lblOutcomeName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOutcomeName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 24);
            this.panel1.TabIndex = 0;
            // 
            // tvVariables
            // 
            this.tvVariables.CheckBoxes = true;
            this.tvVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvVariables.FullRowSelect = true;
            this.tvVariables.Location = new System.Drawing.Point(0, 24);
            this.tvVariables.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvVariables.Name = "tvVariables";
            this.tvVariables.PathSeparator = ".";
            this.tvVariables.ShowNodeToolTips = true;
            this.tvVariables.Size = new System.Drawing.Size(325, 528);
            this.tvVariables.TabIndex = 1;
            // 
            // lblOutcomeName
            // 
            this.lblOutcomeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutcomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcomeName.Location = new System.Drawing.Point(0, 0);
            this.lblOutcomeName.Name = "lblOutcomeName";
            this.lblOutcomeName.Size = new System.Drawing.Size(325, 24);
            this.lblOutcomeName.TabIndex = 1;
            this.lblOutcomeName.Text = "Outcome";
            this.lblOutcomeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VarTrackerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tvVariables);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VarTrackerUI";
            this.Size = new System.Drawing.Size(325, 552);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VarTrackerUI_Paint);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvVariables;
        private System.Windows.Forms.Label lblOutcomeName;
    }
}


namespace StoryDev.Components
{
    partial class ChoiceUI
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
            this.lblGoingTo = new System.Windows.Forms.Label();
            this.nudPriority = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnConditions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScript = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGoingTo
            // 
            this.lblGoingTo.AutoSize = true;
            this.lblGoingTo.Location = new System.Drawing.Point(30, 18);
            this.lblGoingTo.Name = "lblGoingTo";
            this.lblGoingTo.Size = new System.Drawing.Size(78, 20);
            this.lblGoingTo.TabIndex = 0;
            this.lblGoingTo.Text = "Going To:";
            this.lblGoingTo.Click += new System.EventHandler(this.lblGoingTo_Click);
            // 
            // nudPriority
            // 
            this.nudPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPriority.Location = new System.Drawing.Point(358, 16);
            this.nudPriority.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPriority.Name = "nudPriority";
            this.nudPriority.Size = new System.Drawing.Size(120, 26);
            this.nudPriority.TabIndex = 1;
            this.toolTip1.SetToolTip(this.nudPriority, "Higher values are better outcomes.");
            this.nudPriority.ValueChanged += new System.EventHandler(this.nudPriority_ValueChanged);
            // 
            // btnConditions
            // 
            this.btnConditions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConditions.Location = new System.Drawing.Point(484, 16);
            this.btnConditions.Name = "btnConditions";
            this.btnConditions.Size = new System.Drawing.Size(126, 26);
            this.btnConditions.TabIndex = 2;
            this.btnConditions.Text = "Edit Condition";
            this.btnConditions.UseVisualStyleBackColor = true;
            this.btnConditions.Click += new System.EventHandler(this.btnConditions_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Priority:";
            // 
            // btnScript
            // 
            this.btnScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScript.Location = new System.Drawing.Point(616, 15);
            this.btnScript.Name = "btnScript";
            this.btnScript.Size = new System.Drawing.Size(126, 26);
            this.btnScript.TabIndex = 4;
            this.btnScript.Text = "Edit Script";
            this.btnScript.UseVisualStyleBackColor = true;
            this.btnScript.Click += new System.EventHandler(this.btnScript_Click);
            // 
            // ChoiceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnScript);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConditions);
            this.Controls.Add(this.nudPriority);
            this.Controls.Add(this.lblGoingTo);
            this.Name = "ChoiceUI";
            this.Size = new System.Drawing.Size(755, 57);
            ((System.ComponentModel.ISupportInitialize)(this.nudPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGoingTo;
        private System.Windows.Forms.NumericUpDown nudPriority;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnConditions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScript;
    }
}

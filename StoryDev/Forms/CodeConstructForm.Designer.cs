
namespace StoryDev.Forms
{
    partial class CodeConstructForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.sbtnExecute = new StoryDev.Components.SplitButton();
            this.sbtnConditions = new StoryDev.Components.SplitButton();
            this.btnChangeView = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.sbtnExecute);
            this.panel1.Controls.Add(this.sbtnConditions);
            this.panel1.Controls.Add(this.btnChangeView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 892);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(714, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(136, 31);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(856, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // sbtnExecute
            // 
            this.sbtnExecute.Location = new System.Drawing.Point(161, 6);
            this.sbtnExecute.Name = "sbtnExecute";
            this.sbtnExecute.Size = new System.Drawing.Size(143, 31);
            this.sbtnExecute.TabIndex = 2;
            this.sbtnExecute.Text = "Execute";
            this.sbtnExecute.UseVisualStyleBackColor = true;
            // 
            // sbtnConditions
            // 
            this.sbtnConditions.Location = new System.Drawing.Point(12, 6);
            this.sbtnConditions.Name = "sbtnConditions";
            this.sbtnConditions.Size = new System.Drawing.Size(143, 31);
            this.sbtnConditions.TabIndex = 1;
            this.sbtnConditions.Text = "Conditional";
            this.sbtnConditions.UseVisualStyleBackColor = true;
            // 
            // btnChangeView
            // 
            this.btnChangeView.Location = new System.Drawing.Point(310, 6);
            this.btnChangeView.Name = "btnChangeView";
            this.btnChangeView.Size = new System.Drawing.Size(136, 31);
            this.btnChangeView.TabIndex = 0;
            this.btnChangeView.Text = "Advanced >>";
            this.btnChangeView.UseVisualStyleBackColor = true;
            this.btnChangeView.Click += new System.EventHandler(this.btnChangeView_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1004, 892);
            this.pnlContent.TabIndex = 1;
            // 
            // CodeConstructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 937);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodeConstructForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Construct Code";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangeView;
        private System.Windows.Forms.Panel pnlContent;
        private Components.SplitButton sbtnConditions;
        private Components.SplitButton sbtnExecute;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}
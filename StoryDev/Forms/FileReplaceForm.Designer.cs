
namespace StoryDev.Forms
{
    partial class FileReplaceForm
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.rdbReplaceExisting = new System.Windows.Forms.RadioButton();
            this.rdbMakeNewCopy = new System.Windows.Forms.RadioButton();
            this.rdbSetNewName = new System.Windows.Forms.RadioButton();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(34, 23);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(559, 81);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Display Message";
            // 
            // rdbReplaceExisting
            // 
            this.rdbReplaceExisting.AutoSize = true;
            this.rdbReplaceExisting.Checked = true;
            this.rdbReplaceExisting.Location = new System.Drawing.Point(38, 126);
            this.rdbReplaceExisting.Name = "rdbReplaceExisting";
            this.rdbReplaceExisting.Size = new System.Drawing.Size(181, 24);
            this.rdbReplaceExisting.TabIndex = 1;
            this.rdbReplaceExisting.TabStop = true;
            this.rdbReplaceExisting.Text = "Replace Existing File";
            this.rdbReplaceExisting.UseVisualStyleBackColor = true;
            // 
            // rdbMakeNewCopy
            // 
            this.rdbMakeNewCopy.AutoSize = true;
            this.rdbMakeNewCopy.Location = new System.Drawing.Point(38, 156);
            this.rdbMakeNewCopy.Name = "rdbMakeNewCopy";
            this.rdbMakeNewCopy.Size = new System.Drawing.Size(148, 24);
            this.rdbMakeNewCopy.TabIndex = 2;
            this.rdbMakeNewCopy.Text = "Make New Copy";
            this.rdbMakeNewCopy.UseVisualStyleBackColor = true;
            // 
            // rdbSetNewName
            // 
            this.rdbSetNewName.AutoSize = true;
            this.rdbSetNewName.Location = new System.Drawing.Point(38, 186);
            this.rdbSetNewName.Name = "rdbSetNewName";
            this.rdbSetNewName.Size = new System.Drawing.Size(144, 24);
            this.rdbSetNewName.TabIndex = 3;
            this.rdbSetNewName.Text = "Set New Name:";
            this.rdbSetNewName.UseVisualStyleBackColor = true;
            // 
            // txtNewName
            // 
            this.txtNewName.Enabled = false;
            this.txtNewName.Location = new System.Drawing.Point(188, 185);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(240, 26);
            this.txtNewName.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(497, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(395, 240);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 32);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FileReplaceForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 284);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.rdbSetNewName);
            this.Controls.Add(this.rdbMakeNewCopy);
            this.Controls.Add(this.rdbReplaceExisting);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileReplaceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RadioButton rdbReplaceExisting;
        private System.Windows.Forms.RadioButton rdbMakeNewCopy;
        private System.Windows.Forms.RadioButton rdbSetNewName;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}
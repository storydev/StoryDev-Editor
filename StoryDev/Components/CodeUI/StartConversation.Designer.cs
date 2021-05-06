
namespace StoryDev.Components.CodeUI
{
    partial class StartConversation
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
            this.btnBrowseFiles = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbConvoFile = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowseFiles
            // 
            this.btnBrowseFiles.Location = new System.Drawing.Point(443, 50);
            this.btnBrowseFiles.Name = "btnBrowseFiles";
            this.btnBrowseFiles.Size = new System.Drawing.Size(39, 28);
            this.btnBrowseFiles.TabIndex = 22;
            this.btnBrowseFiles.Text = "...";
            this.btnBrowseFiles.UseVisualStyleBackColor = true;
            this.btnBrowseFiles.Click += new System.EventHandler(this.btnBrowseFiles_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(796, 45);
            this.label4.TabIndex = 21;
            this.label4.Text = "Starts a conversation";
            // 
            // cmbConvoFile
            // 
            this.cmbConvoFile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbConvoFile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbConvoFile.FormattingEnabled = true;
            this.cmbConvoFile.Location = new System.Drawing.Point(61, 50);
            this.cmbConvoFile.Name = "cmbConvoFile";
            this.cmbConvoFile.Size = new System.Drawing.Size(376, 28);
            this.cmbConvoFile.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "File:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "StartConversation(file)";
            // 
            // StartConversation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrowseFiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbConvoFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StartConversation";
            this.Size = new System.Drawing.Size(830, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseFiles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbConvoFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


namespace StoryDev.Components.Preferences
{
    partial class GeneralUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseKhaDir = new System.Windows.Forms.Button();
            this.txtKhaDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseKhaDir);
            this.groupBox1.Controls.Add(this.txtKhaDir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Haxe Environment";
            // 
            // btnBrowseKhaDir
            // 
            this.btnBrowseKhaDir.Location = new System.Drawing.Point(520, 104);
            this.btnBrowseKhaDir.Name = "btnBrowseKhaDir";
            this.btnBrowseKhaDir.Size = new System.Drawing.Size(112, 29);
            this.btnBrowseKhaDir.TabIndex = 6;
            this.btnBrowseKhaDir.Text = "Browse...";
            this.btnBrowseKhaDir.UseVisualStyleBackColor = true;
            this.btnBrowseKhaDir.Click += new System.EventHandler(this.btnBrowseKhaDir_Click);
            // 
            // txtKhaDir
            // 
            this.txtKhaDir.Location = new System.Drawing.Point(146, 105);
            this.txtKhaDir.Name = "txtKhaDir";
            this.txtKhaDir.Size = new System.Drawing.Size(368, 26);
            this.txtKhaDir.TabIndex = 5;
            this.txtKhaDir.TextChanged += new System.EventHandler(this.txtKhaDir_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kha Directory:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "To run and compile your games, we use Haxe and Kha to make this work. If you have" +
    " already installed Kha, you can locate this folder below.";
            // 
            // GeneralUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "GeneralUI";
            this.Size = new System.Drawing.Size(736, 802);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseKhaDir;
        private System.Windows.Forms.TextBox txtKhaDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

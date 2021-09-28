
namespace StoryDev.Forms
{
    partial class EnterCustomSourceForm
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
            this.rdbScript = new System.Windows.Forms.RadioButton();
            this.cmbScriptSources = new System.Windows.Forms.ComboBox();
            this.btnAddScript = new System.Windows.Forms.Button();
            this.btnDeleteScript = new System.Windows.Forms.Button();
            this.rdbManual = new System.Windows.Forms.RadioButton();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbScript
            // 
            this.rdbScript.AutoSize = true;
            this.rdbScript.Location = new System.Drawing.Point(22, 27);
            this.rdbScript.Name = "rdbScript";
            this.rdbScript.Size = new System.Drawing.Size(79, 24);
            this.rdbScript.TabIndex = 0;
            this.rdbScript.TabStop = true;
            this.rdbScript.Text = "Script:";
            this.rdbScript.UseVisualStyleBackColor = true;
            this.rdbScript.CheckedChanged += new System.EventHandler(this.rdbScript_CheckedChanged);
            // 
            // cmbScriptSources
            // 
            this.cmbScriptSources.FormattingEnabled = true;
            this.cmbScriptSources.Location = new System.Drawing.Point(107, 26);
            this.cmbScriptSources.Name = "cmbScriptSources";
            this.cmbScriptSources.Size = new System.Drawing.Size(284, 28);
            this.cmbScriptSources.TabIndex = 1;
            this.cmbScriptSources.SelectedIndexChanged += new System.EventHandler(this.cmbScriptSources_SelectedIndexChanged);
            // 
            // btnAddScript
            // 
            this.btnAddScript.Location = new System.Drawing.Point(397, 26);
            this.btnAddScript.Name = "btnAddScript";
            this.btnAddScript.Size = new System.Drawing.Size(75, 28);
            this.btnAddScript.TabIndex = 2;
            this.btnAddScript.Text = "Add";
            this.btnAddScript.UseVisualStyleBackColor = true;
            this.btnAddScript.Click += new System.EventHandler(this.btnAddScript_Click);
            // 
            // btnDeleteScript
            // 
            this.btnDeleteScript.Location = new System.Drawing.Point(478, 26);
            this.btnDeleteScript.Name = "btnDeleteScript";
            this.btnDeleteScript.Size = new System.Drawing.Size(82, 28);
            this.btnDeleteScript.TabIndex = 3;
            this.btnDeleteScript.Text = "Delete";
            this.btnDeleteScript.UseVisualStyleBackColor = true;
            this.btnDeleteScript.Click += new System.EventHandler(this.btnDeleteScript_Click);
            // 
            // rdbManual
            // 
            this.rdbManual.AutoSize = true;
            this.rdbManual.Location = new System.Drawing.Point(22, 71);
            this.rdbManual.Name = "rdbManual";
            this.rdbManual.Size = new System.Drawing.Size(90, 24);
            this.rdbManual.TabIndex = 4;
            this.rdbManual.TabStop = true;
            this.rdbManual.Text = "Manual:";
            this.rdbManual.UseVisualStyleBackColor = true;
            this.rdbManual.CheckedChanged += new System.EventHandler(this.rdbManual_CheckedChanged);
            // 
            // txtSource
            // 
            this.txtSource.Enabled = false;
            this.txtSource.Location = new System.Drawing.Point(107, 101);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSource.Size = new System.Drawing.Size(453, 385);
            this.txtSource.TabIndex = 5;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(478, 526);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(370, 526);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 32);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // EnterCustomSourceForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(597, 574);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.rdbManual);
            this.Controls.Add(this.btnDeleteScript);
            this.Controls.Add(this.btnAddScript);
            this.Controls.Add(this.cmbScriptSources);
            this.Controls.Add(this.rdbScript);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterCustomSourceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Custom Data Source";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbScript;
        private System.Windows.Forms.ComboBox cmbScriptSources;
        private System.Windows.Forms.Button btnAddScript;
        private System.Windows.Forms.Button btnDeleteScript;
        private System.Windows.Forms.RadioButton rdbManual;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}
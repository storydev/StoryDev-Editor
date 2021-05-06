
namespace StoryDev.Components.Data
{
    partial class FilterObject<T>
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cmbSelectItems = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBrowse);
            this.panel3.Controls.Add(this.cmbSelectItems);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(201, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 38);
            this.panel3.TabIndex = 14;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(317, 6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(39, 28);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cmbSelectItems
            // 
            this.cmbSelectItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSelectItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbSelectItems.FormattingEnabled = true;
            this.cmbSelectItems.Location = new System.Drawing.Point(6, 6);
            this.cmbSelectItems.Name = "cmbSelectItems";
            this.cmbSelectItems.Size = new System.Drawing.Size(305, 28);
            this.cmbSelectItems.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFieldName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 38);
            this.panel1.TabIndex = 12;
            // 
            // lblFieldName
            // 
            this.lblFieldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFieldName.Location = new System.Drawing.Point(0, 0);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblFieldName.Size = new System.Drawing.Size(201, 38);
            this.lblFieldName.TabIndex = 0;
            this.lblFieldName.Text = "Field Name";
            this.lblFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FilterObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FilterObject";
            this.Size = new System.Drawing.Size(600, 38);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbSelectItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Button btnBrowse;
    }
}

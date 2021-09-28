
namespace StoryDev.Components.ElementAdditionals
{
    partial class LinkedDetailedAdditional
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
            this.cmbRelationship = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbModuleReference = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditDisplayColumns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbRelationship
            // 
            this.cmbRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelationship.Enabled = false;
            this.cmbRelationship.FormattingEnabled = true;
            this.cmbRelationship.Location = new System.Drawing.Point(234, 51);
            this.cmbRelationship.Name = "cmbRelationship";
            this.cmbRelationship.Size = new System.Drawing.Size(241, 28);
            this.cmbRelationship.TabIndex = 11;
            this.cmbRelationship.SelectedIndexChanged += new System.EventHandler(this.cmbRelationship_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Relationship:";
            // 
            // cmbModuleReference
            // 
            this.cmbModuleReference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModuleReference.FormattingEnabled = true;
            this.cmbModuleReference.Location = new System.Drawing.Point(234, 17);
            this.cmbModuleReference.Name = "cmbModuleReference";
            this.cmbModuleReference.Size = new System.Drawing.Size(241, 28);
            this.cmbModuleReference.TabIndex = 7;
            this.cmbModuleReference.SelectedIndexChanged += new System.EventHandler(this.cmbModuleReference_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Module Reference:";
            // 
            // btnEditDisplayColumns
            // 
            this.btnEditDisplayColumns.Enabled = false;
            this.btnEditDisplayColumns.Location = new System.Drawing.Point(22, 100);
            this.btnEditDisplayColumns.Name = "btnEditDisplayColumns";
            this.btnEditDisplayColumns.Size = new System.Drawing.Size(188, 33);
            this.btnEditDisplayColumns.TabIndex = 12;
            this.btnEditDisplayColumns.Text = "Edit Display Columns";
            this.btnEditDisplayColumns.UseVisualStyleBackColor = true;
            this.btnEditDisplayColumns.Click += new System.EventHandler(this.btnEditDisplayColumns_Click);
            // 
            // LinkedDetailedAdditional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEditDisplayColumns);
            this.Controls.Add(this.cmbRelationship);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbModuleReference);
            this.Controls.Add(this.label1);
            this.Name = "LinkedDetailedAdditional";
            this.Size = new System.Drawing.Size(627, 228);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRelationship;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbModuleReference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditDisplayColumns;
    }
}

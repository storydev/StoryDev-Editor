
namespace StoryDev.Components.ElementAdditionals
{
    partial class ListBoxAdditional
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbModuleReference = new System.Windows.Forms.ComboBox();
            this.cmbDisplayField = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRelationship = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditModule = new System.Windows.Forms.Button();
            this.btnBrowseModules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Reference:";
            // 
            // cmbModuleReference
            // 
            this.cmbModuleReference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModuleReference.FormattingEnabled = true;
            this.cmbModuleReference.Location = new System.Drawing.Point(238, 19);
            this.cmbModuleReference.Name = "cmbModuleReference";
            this.cmbModuleReference.Size = new System.Drawing.Size(241, 28);
            this.cmbModuleReference.TabIndex = 1;
            // 
            // cmbDisplayField
            // 
            this.cmbDisplayField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisplayField.FormattingEnabled = true;
            this.cmbDisplayField.Location = new System.Drawing.Point(238, 53);
            this.cmbDisplayField.Name = "cmbDisplayField";
            this.cmbDisplayField.Size = new System.Drawing.Size(241, 28);
            this.cmbDisplayField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Display Field:";
            // 
            // cmbRelationship
            // 
            this.cmbRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelationship.FormattingEnabled = true;
            this.cmbRelationship.Location = new System.Drawing.Point(238, 87);
            this.cmbRelationship.Name = "cmbRelationship";
            this.cmbRelationship.Size = new System.Drawing.Size(241, 28);
            this.cmbRelationship.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Relationship:";
            // 
            // btnEditModule
            // 
            this.btnEditModule.Location = new System.Drawing.Point(485, 19);
            this.btnEditModule.Name = "btnEditModule";
            this.btnEditModule.Size = new System.Drawing.Size(55, 28);
            this.btnEditModule.TabIndex = 6;
            this.btnEditModule.Text = "Edit";
            this.btnEditModule.UseVisualStyleBackColor = true;
            // 
            // btnBrowseModules
            // 
            this.btnBrowseModules.Location = new System.Drawing.Point(546, 19);
            this.btnBrowseModules.Name = "btnBrowseModules";
            this.btnBrowseModules.Size = new System.Drawing.Size(40, 28);
            this.btnBrowseModules.TabIndex = 7;
            this.btnBrowseModules.Text = "...";
            this.btnBrowseModules.UseVisualStyleBackColor = true;
            // 
            // ListBoxAdditional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrowseModules);
            this.Controls.Add(this.btnEditModule);
            this.Controls.Add(this.cmbRelationship);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDisplayField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbModuleReference);
            this.Controls.Add(this.label1);
            this.Name = "ListBoxAdditional";
            this.Size = new System.Drawing.Size(627, 228);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbModuleReference;
        private System.Windows.Forms.ComboBox cmbDisplayField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRelationship;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditModule;
        private System.Windows.Forms.Button btnBrowseModules;
    }
}


namespace StoryDev.Components.CodeUI
{
    partial class IsItemAvailable
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCharacters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseCharacters = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVendorItems = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(796, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "Is the given item available to purchase from the given character.";
            // 
            // cmbCharacters
            // 
            this.cmbCharacters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCharacters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbCharacters.FormattingEnabled = true;
            this.cmbCharacters.Location = new System.Drawing.Point(106, 50);
            this.cmbCharacters.Name = "cmbCharacters";
            this.cmbCharacters.Size = new System.Drawing.Size(160, 28);
            this.cmbCharacters.TabIndex = 8;
            this.cmbCharacters.SelectedIndexChanged += new System.EventHandler(this.cmbCharacters_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Character:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "IsItemAvailable(char_id, vendor)";
            // 
            // btnBrowseCharacters
            // 
            this.btnBrowseCharacters.Location = new System.Drawing.Point(272, 50);
            this.btnBrowseCharacters.Name = "btnBrowseCharacters";
            this.btnBrowseCharacters.Size = new System.Drawing.Size(37, 28);
            this.btnBrowseCharacters.TabIndex = 12;
            this.btnBrowseCharacters.Text = "...";
            this.btnBrowseCharacters.UseVisualStyleBackColor = true;
            this.btnBrowseCharacters.Click += new System.EventHandler(this.btnBrowseCharacters_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Vendor Item:";
            // 
            // cmbVendorItems
            // 
            this.cmbVendorItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendorItems.FormattingEnabled = true;
            this.cmbVendorItems.Location = new System.Drawing.Point(422, 50);
            this.cmbVendorItems.Name = "cmbVendorItems";
            this.cmbVendorItems.Size = new System.Drawing.Size(146, 28);
            this.cmbVendorItems.TabIndex = 14;
            // 
            // IsItemAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbVendorItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseCharacters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCharacters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IsItemAvailable";
            this.Size = new System.Drawing.Size(830, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCharacters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseCharacters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVendorItems;
    }
}

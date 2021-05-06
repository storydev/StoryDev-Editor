
namespace StoryDev.Forms
{
    partial class VendorItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.btnBrowseItems = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlScript = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // cmbItem
            // 
            this.cmbItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(224, 41);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(246, 28);
            this.cmbItem.TabIndex = 1;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // btnBrowseItems
            // 
            this.btnBrowseItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBrowseItems.Location = new System.Drawing.Point(476, 40);
            this.btnBrowseItems.Name = "btnBrowseItems";
            this.btnBrowseItems.Size = new System.Drawing.Size(41, 29);
            this.btnBrowseItems.TabIndex = 2;
            this.btnBrowseItems.Text = "...";
            this.btnBrowseItems.UseVisualStyleBackColor = true;
            this.btnBrowseItems.Click += new System.EventHandler(this.btnBrowseItems_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudQuantity.Location = new System.Drawing.Point(355, 75);
            this.nudQuantity.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(115, 26);
            this.nudQuantity.TabIndex = 4;
            this.nudQuantity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Availability:";
            // 
            // pnlScript
            // 
            this.pnlScript.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlScript.Location = new System.Drawing.Point(119, 137);
            this.pnlScript.Name = "pnlScript";
            this.pnlScript.Size = new System.Drawing.Size(453, 217);
            this.pnlScript.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(581, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(478, 402);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 34);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // VendorItemForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(690, 448);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlScript);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseItems);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VendorItemForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendor Item";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Button btnBrowseItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlScript;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}
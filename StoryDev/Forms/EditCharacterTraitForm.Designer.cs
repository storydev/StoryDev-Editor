
namespace StoryDev.Forms
{
    partial class EditCharacterTraitForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudInitialValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMaxValue = new System.Windows.Forms.NumericUpDown();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(246, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(394, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(246, 76);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(394, 137);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // nudInitialValue
            // 
            this.nudInitialValue.Location = new System.Drawing.Point(246, 219);
            this.nudInitialValue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudInitialValue.Name = "nudInitialValue";
            this.nudInitialValue.Size = new System.Drawing.Size(120, 26);
            this.nudInitialValue.TabIndex = 4;
            this.nudInitialValue.ValueChanged += new System.EventHandler(this.nudInitialValue_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Initial Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max Value:";
            // 
            // nudMaxValue
            // 
            this.nudMaxValue.Location = new System.Drawing.Point(465, 219);
            this.nudMaxValue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMaxValue.Name = "nudMaxValue";
            this.nudMaxValue.Size = new System.Drawing.Size(120, 26);
            this.nudMaxValue.TabIndex = 6;
            this.nudMaxValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaxValue.ValueChanged += new System.EventHandler(this.nudMaxValue_ValueChanged);
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "Normal",
            "High",
            "Highest"});
            this.cmbPriority.Location = new System.Drawing.Point(246, 251);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(213, 28);
            this.cmbPriority.TabIndex = 8;
            this.cmbPriority.SelectedIndexChanged += new System.EventHandler(this.cmbPriority_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Priority:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(542, 333);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 36);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(660, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 36);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditCharacterTraitForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(788, 386);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudMaxValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudInitialValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCharacterTraitForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Character Trait";
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudInitialValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMaxValue;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
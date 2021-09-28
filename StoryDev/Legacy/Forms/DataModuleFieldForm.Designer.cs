
namespace StoryDev.Forms
{
    partial class DataModuleFieldForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudColumnWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chbHiddenInSearch = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbLabelPosition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlForeignKeyOptions = new System.Windows.Forms.Panel();
            this.btnEditColumns = new System.Windows.Forms.Button();
            this.chbResultIsList = new System.Windows.Forms.CheckBox();
            this.cmbDisplayField = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbRelationshipFields = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbRelationshipType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbForeignRelationship = new System.Windows.Forms.RadioButton();
            this.btnEnterSource = new System.Windows.Forms.Button();
            this.rdbCustomSource = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnWidth)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlForeignKeyOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // cmbTypes
            // 
            this.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Items.AddRange(new object[] {
            "BOOLEAN",
            "STRING",
            "INT8",
            "INT16",
            "INT32",
            "INT64",
            "UINT8",
            "UINT16",
            "UINT32",
            "UINT64",
            "FLOAT",
            "DOUBLE",
            "DECIMAL",
            "DATE",
            "DATETIME",
            "TIMESTAMP"});
            this.cmbTypes.Location = new System.Drawing.Point(411, 30);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(170, 28);
            this.cmbTypes.TabIndex = 3;
            this.cmbTypes.SelectedIndexChanged += new System.EventHandler(this.cmbTypes_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudColumnWidth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chbHiddenInSearch);
            this.groupBox1.Location = new System.Drawing.Point(43, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Searching";
            // 
            // nudColumnWidth
            // 
            this.nudColumnWidth.Location = new System.Drawing.Point(138, 76);
            this.nudColumnWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudColumnWidth.Name = "nudColumnWidth";
            this.nudColumnWidth.Size = new System.Drawing.Size(97, 26);
            this.nudColumnWidth.TabIndex = 2;
            this.nudColumnWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudColumnWidth.ValueChanged += new System.EventHandler(this.nudColumnWidth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Column Width:";
            // 
            // chbHiddenInSearch
            // 
            this.chbHiddenInSearch.AutoSize = true;
            this.chbHiddenInSearch.Location = new System.Drawing.Point(24, 35);
            this.chbHiddenInSearch.Name = "chbHiddenInSearch";
            this.chbHiddenInSearch.Size = new System.Drawing.Size(157, 24);
            this.chbHiddenInSearch.TabIndex = 0;
            this.chbHiddenInSearch.Text = "Hidden in Search";
            this.chbHiddenInSearch.UseVisualStyleBackColor = true;
            this.chbHiddenInSearch.CheckedChanged += new System.EventHandler(this.chbHiddenInSearch_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbLabelPosition);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbGroup);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(350, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 146);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appearance";
            // 
            // cmbLabelPosition
            // 
            this.cmbLabelPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLabelPosition.FormattingEnabled = true;
            this.cmbLabelPosition.Items.AddRange(new object[] {
            "Top",
            "Left",
            "Right",
            "Bottom"});
            this.cmbLabelPosition.Location = new System.Drawing.Point(135, 73);
            this.cmbLabelPosition.Name = "cmbLabelPosition";
            this.cmbLabelPosition.Size = new System.Drawing.Size(113, 28);
            this.cmbLabelPosition.TabIndex = 3;
            this.cmbLabelPosition.SelectedIndexChanged += new System.EventHandler(this.cmbLabelPosition_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Label Position:";
            // 
            // cmbGroup
            // 
            this.cmbGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(81, 31);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(167, 28);
            this.cmbGroup.TabIndex = 1;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            this.cmbGroup.TextChanged += new System.EventHandler(this.cmbGroup_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Group:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pnlForeignKeyOptions);
            this.groupBox3.Controls.Add(this.rdbForeignRelationship);
            this.groupBox3.Controls.Add(this.btnEnterSource);
            this.groupBox3.Controls.Add(this.rdbCustomSource);
            this.groupBox3.Location = new System.Drawing.Point(43, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(613, 317);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Relationship";
            // 
            // pnlForeignKeyOptions
            // 
            this.pnlForeignKeyOptions.Controls.Add(this.btnEditColumns);
            this.pnlForeignKeyOptions.Controls.Add(this.chbResultIsList);
            this.pnlForeignKeyOptions.Controls.Add(this.cmbDisplayField);
            this.pnlForeignKeyOptions.Controls.Add(this.label8);
            this.pnlForeignKeyOptions.Controls.Add(this.cmbRelationshipFields);
            this.pnlForeignKeyOptions.Controls.Add(this.label7);
            this.pnlForeignKeyOptions.Controls.Add(this.cmbRelationshipType);
            this.pnlForeignKeyOptions.Controls.Add(this.label6);
            this.pnlForeignKeyOptions.Location = new System.Drawing.Point(24, 111);
            this.pnlForeignKeyOptions.Name = "pnlForeignKeyOptions";
            this.pnlForeignKeyOptions.Size = new System.Drawing.Size(569, 177);
            this.pnlForeignKeyOptions.TabIndex = 4;
            // 
            // btnEditColumns
            // 
            this.btnEditColumns.Enabled = false;
            this.btnEditColumns.Location = new System.Drawing.Point(158, 116);
            this.btnEditColumns.Name = "btnEditColumns";
            this.btnEditColumns.Size = new System.Drawing.Size(155, 33);
            this.btnEditColumns.TabIndex = 7;
            this.btnEditColumns.Text = "Edit Columns";
            this.btnEditColumns.UseVisualStyleBackColor = true;
            this.btnEditColumns.Click += new System.EventHandler(this.btnEditColumns_Click);
            // 
            // chbResultIsList
            // 
            this.chbResultIsList.AutoSize = true;
            this.chbResultIsList.Location = new System.Drawing.Point(14, 121);
            this.chbResultIsList.Name = "chbResultIsList";
            this.chbResultIsList.Size = new System.Drawing.Size(138, 24);
            this.chbResultIsList.TabIndex = 6;
            this.chbResultIsList.Text = "Result is a List";
            this.chbResultIsList.UseVisualStyleBackColor = true;
            this.chbResultIsList.CheckedChanged += new System.EventHandler(this.chbResultIsList_CheckedChanged);
            // 
            // cmbDisplayField
            // 
            this.cmbDisplayField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisplayField.Enabled = false;
            this.cmbDisplayField.FormattingEnabled = true;
            this.cmbDisplayField.Location = new System.Drawing.Point(391, 54);
            this.cmbDisplayField.Name = "cmbDisplayField";
            this.cmbDisplayField.Size = new System.Drawing.Size(167, 28);
            this.cmbDisplayField.TabIndex = 5;
            this.cmbDisplayField.SelectedIndexChanged += new System.EventHandler(this.cmbDisplayField_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Display Field:";
            // 
            // cmbRelationshipFields
            // 
            this.cmbRelationshipFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelationshipFields.Enabled = false;
            this.cmbRelationshipFields.FormattingEnabled = true;
            this.cmbRelationshipFields.Location = new System.Drawing.Point(109, 54);
            this.cmbRelationshipFields.Name = "cmbRelationshipFields";
            this.cmbRelationshipFields.Size = new System.Drawing.Size(168, 28);
            this.cmbRelationshipFields.TabIndex = 3;
            this.cmbRelationshipFields.SelectedIndexChanged += new System.EventHandler(this.cmbRelationshipFields_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Field Name:";
            // 
            // cmbRelationshipType
            // 
            this.cmbRelationshipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelationshipType.FormattingEnabled = true;
            this.cmbRelationshipType.Location = new System.Drawing.Point(68, 20);
            this.cmbRelationshipType.Name = "cmbRelationshipType";
            this.cmbRelationshipType.Size = new System.Drawing.Size(209, 28);
            this.cmbRelationshipType.TabIndex = 1;
            this.cmbRelationshipType.SelectedIndexChanged += new System.EventHandler(this.cmbRelationshipType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Type:";
            // 
            // rdbForeignRelationship
            // 
            this.rdbForeignRelationship.AutoSize = true;
            this.rdbForeignRelationship.Location = new System.Drawing.Point(24, 81);
            this.rdbForeignRelationship.Name = "rdbForeignRelationship";
            this.rdbForeignRelationship.Size = new System.Drawing.Size(122, 24);
            this.rdbForeignRelationship.TabIndex = 3;
            this.rdbForeignRelationship.TabStop = true;
            this.rdbForeignRelationship.Text = "Foreign Key:";
            this.rdbForeignRelationship.UseVisualStyleBackColor = true;
            this.rdbForeignRelationship.CheckedChanged += new System.EventHandler(this.rdbForeignRelationship_CheckedChanged);
            // 
            // btnEnterSource
            // 
            this.btnEnterSource.Enabled = false;
            this.btnEnterSource.Location = new System.Drawing.Point(217, 35);
            this.btnEnterSource.Name = "btnEnterSource";
            this.btnEnterSource.Size = new System.Drawing.Size(129, 32);
            this.btnEnterSource.TabIndex = 1;
            this.btnEnterSource.Text = "Enter Source";
            this.btnEnterSource.UseVisualStyleBackColor = true;
            this.btnEnterSource.Click += new System.EventHandler(this.btnEnterSource_Click);
            // 
            // rdbCustomSource
            // 
            this.rdbCustomSource.AutoSize = true;
            this.rdbCustomSource.Location = new System.Drawing.Point(24, 39);
            this.rdbCustomSource.Name = "rdbCustomSource";
            this.rdbCustomSource.Size = new System.Drawing.Size(187, 24);
            this.rdbCustomSource.TabIndex = 0;
            this.rdbCustomSource.TabStop = true;
            this.rdbCustomSource.Text = "Custom Source Data:";
            this.rdbCustomSource.UseVisualStyleBackColor = true;
            this.rdbCustomSource.CheckedChanged += new System.EventHandler(this.rdbCustomSource_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(568, 568);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(460, 568);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 29);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // DataModuleFieldForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(682, 609);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataModuleFieldForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Field";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnWidth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlForeignKeyOptions.ResumeLayout(false);
            this.pnlForeignKeyOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudColumnWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbHiddenInSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLabelPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEnterSource;
        private System.Windows.Forms.RadioButton rdbCustomSource;
        private System.Windows.Forms.RadioButton rdbForeignRelationship;
        private System.Windows.Forms.Panel pnlForeignKeyOptions;
        private System.Windows.Forms.ComboBox cmbRelationshipType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRelationshipFields;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbDisplayField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditColumns;
        private System.Windows.Forms.CheckBox chbResultIsList;
    }
}
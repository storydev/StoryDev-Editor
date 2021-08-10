
namespace StoryDev.Forms
{
    partial class DataModuleFormPropertiesForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudBottomMargin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudRightMargin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudLeftMargin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTopMargin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAllMargins = new System.Windows.Forms.NumericUpDown();
            this.chbAllMargins = new System.Windows.Forms.CheckBox();
            this.chbAutoWidthFields = new System.Windows.Forms.CheckBox();
            this.cmbLabelPosition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPadding = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnApplyGlobally = new System.Windows.Forms.Button();
            this.lvComponentDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBottomMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRightMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeftMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAllMargins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPadding)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 742);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.chbAutoWidthFields);
            this.tabPage1.Controls.Add(this.cmbLabelPosition);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nudPadding);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(729, 709);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudBottomMargin);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudRightMargin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudLeftMargin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudTopMargin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudAllMargins);
            this.groupBox1.Controls.Add(this.chbAllMargins);
            this.groupBox1.Location = new System.Drawing.Point(39, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 141);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Margins";
            // 
            // nudBottomMargin
            // 
            this.nudBottomMargin.Enabled = false;
            this.nudBottomMargin.Location = new System.Drawing.Point(501, 80);
            this.nudBottomMargin.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudBottomMargin.Name = "nudBottomMargin";
            this.nudBottomMargin.Size = new System.Drawing.Size(77, 26);
            this.nudBottomMargin.TabIndex = 9;
            this.nudBottomMargin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBottomMargin.ValueChanged += new System.EventHandler(this.nudBottom_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bottom:";
            // 
            // nudRightMargin
            // 
            this.nudRightMargin.Enabled = false;
            this.nudRightMargin.Location = new System.Drawing.Point(347, 80);
            this.nudRightMargin.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudRightMargin.Name = "nudRightMargin";
            this.nudRightMargin.Size = new System.Drawing.Size(77, 26);
            this.nudRightMargin.TabIndex = 7;
            this.nudRightMargin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRightMargin.ValueChanged += new System.EventHandler(this.nudRightMargin_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Right:";
            // 
            // nudLeftMargin
            // 
            this.nudLeftMargin.Enabled = false;
            this.nudLeftMargin.Location = new System.Drawing.Point(206, 80);
            this.nudLeftMargin.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudLeftMargin.Name = "nudLeftMargin";
            this.nudLeftMargin.Size = new System.Drawing.Size(77, 26);
            this.nudLeftMargin.TabIndex = 5;
            this.nudLeftMargin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLeftMargin.ValueChanged += new System.EventHandler(this.nudLeftMargin_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Left:";
            // 
            // nudTopMargin
            // 
            this.nudTopMargin.Enabled = false;
            this.nudTopMargin.Location = new System.Drawing.Point(76, 80);
            this.nudTopMargin.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudTopMargin.Name = "nudTopMargin";
            this.nudTopMargin.Size = new System.Drawing.Size(77, 26);
            this.nudTopMargin.TabIndex = 3;
            this.nudTopMargin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTopMargin.ValueChanged += new System.EventHandler(this.nudTopMargin_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Top:";
            // 
            // nudAllMargins
            // 
            this.nudAllMargins.Location = new System.Drawing.Point(156, 35);
            this.nudAllMargins.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudAllMargins.Name = "nudAllMargins";
            this.nudAllMargins.Size = new System.Drawing.Size(77, 26);
            this.nudAllMargins.TabIndex = 1;
            this.nudAllMargins.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAllMargins.ValueChanged += new System.EventHandler(this.nudAllMargins_ValueChanged);
            // 
            // chbAllMargins
            // 
            this.chbAllMargins.AutoSize = true;
            this.chbAllMargins.Checked = true;
            this.chbAllMargins.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAllMargins.Location = new System.Drawing.Point(34, 36);
            this.chbAllMargins.Name = "chbAllMargins";
            this.chbAllMargins.Size = new System.Drawing.Size(116, 24);
            this.chbAllMargins.TabIndex = 0;
            this.chbAllMargins.Text = "All Margins:";
            this.chbAllMargins.UseVisualStyleBackColor = true;
            this.chbAllMargins.CheckedChanged += new System.EventHandler(this.chbAllMargins_CheckedChanged);
            // 
            // chbAutoWidthFields
            // 
            this.chbAutoWidthFields.AutoSize = true;
            this.chbAutoWidthFields.Checked = true;
            this.chbAutoWidthFields.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAutoWidthFields.Location = new System.Drawing.Point(39, 89);
            this.chbAutoWidthFields.Name = "chbAutoWidthFields";
            this.chbAutoWidthFields.Size = new System.Drawing.Size(248, 24);
            this.chbAutoWidthFields.TabIndex = 4;
            this.chbAutoWidthFields.Text = "Auto-Width Field Components";
            this.toolTip1.SetToolTip(this.chbAutoWidthFields, "Each field component will fill the width, minus padding, of its container.");
            this.chbAutoWidthFields.UseVisualStyleBackColor = true;
            this.chbAutoWidthFields.CheckedChanged += new System.EventHandler(this.chbAutoWidthFields_CheckedChanged);
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
            this.cmbLabelPosition.Location = new System.Drawing.Point(517, 36);
            this.cmbLabelPosition.Name = "cmbLabelPosition";
            this.cmbLabelPosition.Size = new System.Drawing.Size(148, 28);
            this.cmbLabelPosition.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmbLabelPosition, "The position of each field\'s label against the component.");
            this.cmbLabelPosition.SelectedIndexChanged += new System.EventHandler(this.cmbLabelPosition_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(329, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Field Label Position:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudPadding
            // 
            this.nudPadding.Location = new System.Drawing.Point(167, 37);
            this.nudPadding.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudPadding.Name = "nudPadding";
            this.nudPadding.Size = new System.Drawing.Size(156, 26);
            this.nudPadding.TabIndex = 1;
            this.toolTip1.SetToolTip(this.nudPadding, "Apply a globally accepted padding to each field in this form.");
            this.nudPadding.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPadding.ValueChanged += new System.EventHandler(this.nudPadding_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Global Padding:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnApplyGlobally);
            this.tabPage2.Controls.Add(this.lvComponentDetails);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(729, 709);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Components";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnApplyGlobally
            // 
            this.btnApplyGlobally.Location = new System.Drawing.Point(24, 638);
            this.btnApplyGlobally.Name = "btnApplyGlobally";
            this.btnApplyGlobally.Size = new System.Drawing.Size(208, 32);
            this.btnApplyGlobally.TabIndex = 1;
            this.btnApplyGlobally.Text = "Apply to Global Settings";
            this.toolTip1.SetToolTip(this.btnApplyGlobally, "Apply all of the above settings globally. This will overwrite any existing global" +
        "\r\nsettings.");
            this.btnApplyGlobally.UseVisualStyleBackColor = true;
            this.btnApplyGlobally.Click += new System.EventHandler(this.btnApplyGlobally_Click);
            // 
            // lvComponentDetails
            // 
            this.lvComponentDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvComponentDetails.FullRowSelect = true;
            this.lvComponentDetails.HideSelection = false;
            this.lvComponentDetails.Location = new System.Drawing.Point(24, 32);
            this.lvComponentDetails.MultiSelect = false;
            this.lvComponentDetails.Name = "lvComponentDetails";
            this.lvComponentDetails.Size = new System.Drawing.Size(674, 600);
            this.lvComponentDetails.TabIndex = 0;
            this.lvComponentDetails.UseCompatibleStateImageBehavior = false;
            this.lvComponentDetails.View = System.Windows.Forms.View.Details;
            this.lvComponentDetails.DoubleClick += new System.EventHandler(this.lvComponentDetails_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Component";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Default Width";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Default Height";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Label Position";
            this.columnHeader4.Width = 125;
            // 
            // DataModuleFormPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 742);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataModuleFormPropertiesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form Properties";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBottomMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRightMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeftMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAllMargins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPadding)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown nudPadding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chbAutoWidthFields;
        private System.Windows.Forms.ComboBox cmbLabelPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvComponentDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbAllMargins;
        private System.Windows.Forms.NumericUpDown nudBottomMargin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudRightMargin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudLeftMargin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTopMargin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAllMargins;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnApplyGlobally;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
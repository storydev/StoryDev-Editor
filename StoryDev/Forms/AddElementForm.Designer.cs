
namespace StoryDev.Forms
{
    partial class AddElementForm
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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Basic Components", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Advanced Components", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Input Single", 8);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Input Multiline", 7);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Input Code", 6);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("Button", 0);
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("Check Box", 1);
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("Check List", 2);
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("Combo Box", 3);
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("Numeric", 12);
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("List Box", 11);
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("Date Picker", 4);
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("Label", 9);
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem("Icon Selector", 5);
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem("Single Link", 13);
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem("Linked Detailed View", 10);
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem("Tab Control", 14);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddElementForm));
            this.lvElements = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.pnlFieldReference = new System.Windows.Forms.Panel();
            this.cmbReference = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditField = new System.Windows.Forms.Button();
            this.btnEditModuleFields = new System.Windows.Forms.Button();
            this.pnlAdditionalOptions = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlCustomDataSource = new System.Windows.Forms.Panel();
            this.chbCustomDataSource = new System.Windows.Forms.CheckBox();
            this.btnEnterManualDataSource = new System.Windows.Forms.Button();
            this.btnEnterScriptDataSource = new System.Windows.Forms.Button();
            this.pnlFieldReference.SuspendLayout();
            this.pnlCustomDataSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvElements
            // 
            listViewGroup3.Header = "Basic Components";
            listViewGroup3.Name = "listViewGroup1";
            listViewGroup4.Header = "Advanced Components";
            listViewGroup4.Name = "listViewGroup2";
            this.lvElements.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.lvElements.HideSelection = false;
            listViewItem16.Group = listViewGroup3;
            listViewItem16.Tag = "_InputSingle";
            listViewItem17.Group = listViewGroup3;
            listViewItem17.Tag = "_InputMultiline";
            listViewItem18.Group = listViewGroup3;
            listViewItem18.Tag = "_InputCode";
            listViewItem19.Group = listViewGroup3;
            listViewItem19.Tag = "_Button";
            listViewItem20.Group = listViewGroup3;
            listViewItem20.Tag = "_CheckBox";
            listViewItem21.Group = listViewGroup3;
            listViewItem21.Tag = "_CheckList";
            listViewItem22.Group = listViewGroup3;
            listViewItem22.Tag = "_ComboBox";
            listViewItem23.Group = listViewGroup3;
            listViewItem23.Tag = "_Numeric";
            listViewItem24.Group = listViewGroup4;
            listViewItem24.Tag = "_ListBox";
            listViewItem25.Group = listViewGroup3;
            listViewItem25.Tag = "_DatePicker";
            listViewItem26.Group = listViewGroup3;
            listViewItem26.Tag = "_Label";
            listViewItem27.Group = listViewGroup3;
            listViewItem27.Tag = "_IconSelector";
            listViewItem28.Group = listViewGroup4;
            listViewItem28.Tag = "_SingleLink";
            listViewItem29.Group = listViewGroup4;
            listViewItem29.Tag = "_LinkedDetailedView";
            listViewItem30.Group = listViewGroup4;
            listViewItem30.Tag = "_TabControl";
            this.lvElements.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26,
            listViewItem27,
            listViewItem28,
            listViewItem29,
            listViewItem30});
            this.lvElements.LargeImageList = this.imageList1;
            this.lvElements.Location = new System.Drawing.Point(33, 23);
            this.lvElements.Name = "lvElements";
            this.lvElements.Size = new System.Drawing.Size(1015, 571);
            this.lvElements.TabIndex = 0;
            this.lvElements.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Button.png");
            this.imageList1.Images.SetKeyName(1, "CheckBox.png");
            this.imageList1.Images.SetKeyName(2, "CheckList.png");
            this.imageList1.Images.SetKeyName(3, "ComboBox.png");
            this.imageList1.Images.SetKeyName(4, "DateTimePicker.png");
            this.imageList1.Images.SetKeyName(5, "IconSelector.png");
            this.imageList1.Images.SetKeyName(6, "InputCode.png");
            this.imageList1.Images.SetKeyName(7, "InputMultiline.png");
            this.imageList1.Images.SetKeyName(8, "InputSingle.png");
            this.imageList1.Images.SetKeyName(9, "Label.png");
            this.imageList1.Images.SetKeyName(10, "LinkedDetailedList.png");
            this.imageList1.Images.SetKeyName(11, "ListBox.png");
            this.imageList1.Images.SetKeyName(12, "Numeric.png");
            this.imageList1.Images.SetKeyName(13, "SingleLink.png");
            this.imageList1.Images.SetKeyName(14, "TabControl.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 611);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Field Name:";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(128, 608);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(287, 26);
            this.txtFieldName.TabIndex = 2;
            // 
            // pnlFieldReference
            // 
            this.pnlFieldReference.Controls.Add(this.btnEditModuleFields);
            this.pnlFieldReference.Controls.Add(this.btnEditField);
            this.pnlFieldReference.Controls.Add(this.cmbReference);
            this.pnlFieldReference.Controls.Add(this.label2);
            this.pnlFieldReference.Location = new System.Drawing.Point(33, 640);
            this.pnlFieldReference.Name = "pnlFieldReference";
            this.pnlFieldReference.Size = new System.Drawing.Size(382, 37);
            this.pnlFieldReference.TabIndex = 3;
            // 
            // cmbReference
            // 
            this.cmbReference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReference.FormattingEnabled = true;
            this.cmbReference.Location = new System.Drawing.Point(95, 3);
            this.cmbReference.Name = "cmbReference";
            this.cmbReference.Size = new System.Drawing.Size(181, 28);
            this.cmbReference.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reference:";
            // 
            // btnEditField
            // 
            this.btnEditField.Location = new System.Drawing.Point(282, 3);
            this.btnEditField.Name = "btnEditField";
            this.btnEditField.Size = new System.Drawing.Size(51, 28);
            this.btnEditField.TabIndex = 7;
            this.btnEditField.Text = "Edit";
            this.btnEditField.UseVisualStyleBackColor = true;
            // 
            // btnEditModuleFields
            // 
            this.btnEditModuleFields.Location = new System.Drawing.Point(339, 3);
            this.btnEditModuleFields.Name = "btnEditModuleFields";
            this.btnEditModuleFields.Size = new System.Drawing.Size(40, 28);
            this.btnEditModuleFields.TabIndex = 8;
            this.btnEditModuleFields.Text = "...";
            this.btnEditModuleFields.UseVisualStyleBackColor = true;
            // 
            // pnlAdditionalOptions
            // 
            this.pnlAdditionalOptions.Location = new System.Drawing.Point(421, 608);
            this.pnlAdditionalOptions.Name = "pnlAdditionalOptions";
            this.pnlAdditionalOptions.Size = new System.Drawing.Size(627, 228);
            this.pnlAdditionalOptions.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(33, 803);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(107, 33);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(146, 803);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 33);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pnlCustomDataSource
            // 
            this.pnlCustomDataSource.Controls.Add(this.btnEnterScriptDataSource);
            this.pnlCustomDataSource.Controls.Add(this.btnEnterManualDataSource);
            this.pnlCustomDataSource.Controls.Add(this.chbCustomDataSource);
            this.pnlCustomDataSource.Location = new System.Drawing.Point(33, 683);
            this.pnlCustomDataSource.Name = "pnlCustomDataSource";
            this.pnlCustomDataSource.Size = new System.Drawing.Size(382, 100);
            this.pnlCustomDataSource.TabIndex = 7;
            // 
            // chbCustomDataSource
            // 
            this.chbCustomDataSource.AutoSize = true;
            this.chbCustomDataSource.Location = new System.Drawing.Point(14, 13);
            this.chbCustomDataSource.Name = "chbCustomDataSource";
            this.chbCustomDataSource.Size = new System.Drawing.Size(217, 24);
            this.chbCustomDataSource.TabIndex = 0;
            this.chbCustomDataSource.Text = "Set Custom Data Source:\r\n";
            this.chbCustomDataSource.UseVisualStyleBackColor = true;
            // 
            // btnEnterManualDataSource
            // 
            this.btnEnterManualDataSource.Location = new System.Drawing.Point(14, 43);
            this.btnEnterManualDataSource.Name = "btnEnterManualDataSource";
            this.btnEnterManualDataSource.Size = new System.Drawing.Size(169, 31);
            this.btnEnterManualDataSource.TabIndex = 1;
            this.btnEnterManualDataSource.Text = "Manually Define";
            this.btnEnterManualDataSource.UseVisualStyleBackColor = true;
            // 
            // btnEnterScriptDataSource
            // 
            this.btnEnterScriptDataSource.Location = new System.Drawing.Point(189, 43);
            this.btnEnterScriptDataSource.Name = "btnEnterScriptDataSource";
            this.btnEnterScriptDataSource.Size = new System.Drawing.Size(169, 31);
            this.btnEnterScriptDataSource.TabIndex = 2;
            this.btnEnterScriptDataSource.Text = "Script Defined";
            this.btnEnterScriptDataSource.UseVisualStyleBackColor = true;
            // 
            // AddElementForm
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1079, 848);
            this.Controls.Add(this.pnlCustomDataSource);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pnlAdditionalOptions);
            this.Controls.Add(this.pnlFieldReference);
            this.Controls.Add(this.txtFieldName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvElements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddElementForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Element";
            this.pnlFieldReference.ResumeLayout(false);
            this.pnlFieldReference.PerformLayout();
            this.pnlCustomDataSource.ResumeLayout(false);
            this.pnlCustomDataSource.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvElements;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.Panel pnlFieldReference;
        private System.Windows.Forms.ComboBox cmbReference;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditModuleFields;
        private System.Windows.Forms.Button btnEditField;
        private System.Windows.Forms.Panel pnlAdditionalOptions;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlCustomDataSource;
        private System.Windows.Forms.Button btnEnterScriptDataSource;
        private System.Windows.Forms.Button btnEnterManualDataSource;
        private System.Windows.Forms.CheckBox chbCustomDataSource;
    }
}

namespace StoryDev.Components
{
    partial class AchievementsUI
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSub = new System.Windows.Forms.Panel();
            this.cmbSubCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlScript = new System.Windows.Forms.Panel();
            this.cmbScriptType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGameEvent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            this.pnlSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(17, 732);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 33);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1041, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 33);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Controls.Add(this.pnlSub);
            this.pnlContent.Controls.Add(this.cmbCategory);
            this.pnlContent.Controls.Add(this.label5);
            this.pnlContent.Controls.Add(this.pnlScript);
            this.pnlContent.Controls.Add(this.cmbScriptType);
            this.pnlContent.Controls.Add(this.label4);
            this.pnlContent.Controls.Add(this.cmbGameEvent);
            this.pnlContent.Controls.Add(this.label3);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.txtDescription);
            this.pnlContent.Controls.Add(this.txtName);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Enabled = false;
            this.pnlContent.Location = new System.Drawing.Point(295, 61);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(859, 704);
            this.pnlContent.TabIndex = 14;
            // 
            // pnlSub
            // 
            this.pnlSub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlSub.Controls.Add(this.cmbSubCategory);
            this.pnlSub.Controls.Add(this.label6);
            this.pnlSub.Location = new System.Drawing.Point(411, 250);
            this.pnlSub.Name = "pnlSub";
            this.pnlSub.Size = new System.Drawing.Size(305, 28);
            this.pnlSub.TabIndex = 24;
            this.pnlSub.Visible = false;
            // 
            // cmbSubCategory
            // 
            this.cmbSubCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSubCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbSubCategory.FormattingEnabled = true;
            this.cmbSubCategory.Location = new System.Drawing.Point(51, 0);
            this.cmbSubCategory.Name = "cmbSubCategory";
            this.cmbSubCategory.Size = new System.Drawing.Size(194, 28);
            this.cmbSubCategory.TabIndex = 25;
            this.cmbSubCategory.SelectedIndexChanged += new System.EventHandler(this.cmbSubCategory_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sub:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Story",
            "Artefacts",
            "Characters",
            "Activities",
            "Sections",
            "Special Feature",
            "Items"});
            this.cmbCategory.Location = new System.Drawing.Point(224, 250);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(181, 28);
            this.cmbCategory.TabIndex = 23;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Category:";
            // 
            // pnlScript
            // 
            this.pnlScript.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlScript.Location = new System.Drawing.Point(130, 363);
            this.pnlScript.Name = "pnlScript";
            this.pnlScript.Size = new System.Drawing.Size(586, 293);
            this.pnlScript.TabIndex = 21;
            // 
            // cmbScriptType
            // 
            this.cmbScriptType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbScriptType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScriptType.FormattingEnabled = true;
            this.cmbScriptType.Items.AddRange(new object[] {
            "Standard",
            "Return Value",
            "Function"});
            this.cmbScriptType.Location = new System.Drawing.Point(224, 318);
            this.cmbScriptType.Name = "cmbScriptType";
            this.cmbScriptType.Size = new System.Drawing.Size(181, 28);
            this.cmbScriptType.TabIndex = 20;
            this.cmbScriptType.SelectedIndexChanged += new System.EventHandler(this.cmbScriptType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Script Type:";
            // 
            // cmbGameEvent
            // 
            this.cmbGameEvent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbGameEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGameEvent.FormattingEnabled = true;
            this.cmbGameEvent.Location = new System.Drawing.Point(224, 284);
            this.cmbGameEvent.Name = "cmbGameEvent";
            this.cmbGameEvent.Size = new System.Drawing.Size(181, 28);
            this.cmbGameEvent.TabIndex = 18;
            this.cmbGameEvent.SelectedIndexChanged += new System.EventHandler(this.cmbGameEvent_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Game Event:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescription.Location = new System.Drawing.Point(224, 66);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(432, 178);
            this.txtDescription.TabIndex = 15;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Location = new System.Drawing.Point(224, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(432, 26);
            this.txtName.TabIndex = 14;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(20, 662);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 300);
            this.panel1.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(176, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 33);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbResults
            // 
            this.lbResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 20;
            this.lbResults.Location = new System.Drawing.Point(17, 61);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(272, 664);
            this.lbResults.TabIndex = 12;
            this.lbResults.SelectedIndexChanged += new System.EventHandler(this.lbResults_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(17, 22);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(113, 33);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // AchievementsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnCreate);
            this.Name = "AchievementsUI";
            this.Size = new System.Drawing.Size(1171, 786);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbGameEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlScript;
        private System.Windows.Forms.ComboBox cmbScriptType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlSub;
        private System.Windows.Forms.ComboBox cmbSubCategory;
        private System.Windows.Forms.Label label6;
    }
}

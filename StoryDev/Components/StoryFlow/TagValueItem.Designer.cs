namespace StoryDev.Components.StoryFlow
{
    partial class TagValueItem
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
            this.llDelete = new System.Windows.Forms.LinkLabel();
            this.cmbTagValueList = new System.Windows.Forms.ComboBox();
            this.lblTagName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llDelete
            // 
            this.llDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.llDelete.Location = new System.Drawing.Point(300, 4);
            this.llDelete.Name = "llDelete";
            this.llDelete.Size = new System.Drawing.Size(40, 33);
            this.llDelete.TabIndex = 0;
            this.llDelete.TabStop = true;
            this.llDelete.Text = "Del";
            this.llDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTagValueList
            // 
            this.cmbTagValueList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTagValueList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbTagValueList.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbTagValueList.FormattingEnabled = true;
            this.cmbTagValueList.Location = new System.Drawing.Point(179, 4);
            this.cmbTagValueList.Name = "cmbTagValueList";
            this.cmbTagValueList.Size = new System.Drawing.Size(121, 28);
            this.cmbTagValueList.TabIndex = 1;
            this.cmbTagValueList.Visible = false;
            // 
            // lblTagName
            // 
            this.lblTagName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTagName.Location = new System.Drawing.Point(4, 4);
            this.lblTagName.Name = "lblTagName";
            this.lblTagName.Size = new System.Drawing.Size(175, 33);
            this.lblTagName.TabIndex = 2;
            this.lblTagName.Text = "Tag Name";
            this.lblTagName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TagValueItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTagName);
            this.Controls.Add(this.cmbTagValueList);
            this.Controls.Add(this.llDelete);
            this.Name = "TagValueItem";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(344, 41);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel llDelete;
        private System.Windows.Forms.ComboBox cmbTagValueList;
        private System.Windows.Forms.Label lblTagName;
    }
}

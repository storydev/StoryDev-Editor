
namespace StoryDev.Components.CodeUI
{
    partial class GetCustomVariable
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
            this.cmbVariables = new System.Windows.Forms.ComboBox();
            this.cmbValue = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Variable Name:";
            // 
            // cmbVariables
            // 
            this.cmbVariables.FormattingEnabled = true;
            this.cmbVariables.Location = new System.Drawing.Point(153, 52);
            this.cmbVariables.Name = "cmbVariables";
            this.cmbVariables.Size = new System.Drawing.Size(248, 28);
            this.cmbVariables.TabIndex = 1;
            // 
            // cmbValue
            // 
            this.cmbValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValue.FormattingEnabled = true;
            this.cmbValue.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbValue.Location = new System.Drawing.Point(407, 52);
            this.cmbValue.Name = "cmbValue";
            this.cmbValue.Size = new System.Drawing.Size(121, 28);
            this.cmbValue.TabIndex = 2;
            // 
            // GetCustomVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbValue);
            this.Controls.Add(this.cmbVariables);
            this.Controls.Add(this.label1);
            this.Name = "GetCustomVariable";
            this.Size = new System.Drawing.Size(800, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVariables;
        private System.Windows.Forms.ComboBox cmbValue;
    }
}

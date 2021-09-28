
namespace StoryDev.Components.Scripting
{
    partial class ScriptFileProperties
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptFileProperties));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbInterpretation = new System.Windows.Forms.ComboBox();
            this.chbEnableLivePreview = new System.Windows.Forms.CheckBox();
            this.chbNotCompiled = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chbInitScript = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Script Interpretation:\r\n";
            // 
            // cmbInterpretation
            // 
            this.cmbInterpretation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterpretation.FormattingEnabled = true;
            this.cmbInterpretation.Items.AddRange(new object[] {
            "Standard",
            "Root is Class",
            "Return Function"});
            this.cmbInterpretation.Location = new System.Drawing.Point(187, 21);
            this.cmbInterpretation.Name = "cmbInterpretation";
            this.cmbInterpretation.Size = new System.Drawing.Size(210, 28);
            this.cmbInterpretation.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbInterpretation, resources.GetString("cmbInterpretation.ToolTip"));
            this.cmbInterpretation.SelectedIndexChanged += new System.EventHandler(this.cmbInterpretation_SelectedIndexChanged);
            // 
            // chbEnableLivePreview
            // 
            this.chbEnableLivePreview.AutoSize = true;
            this.chbEnableLivePreview.Location = new System.Drawing.Point(187, 64);
            this.chbEnableLivePreview.Name = "chbEnableLivePreview";
            this.chbEnableLivePreview.Size = new System.Drawing.Size(175, 24);
            this.chbEnableLivePreview.TabIndex = 0;
            this.chbEnableLivePreview.Text = "Enable Live Preview";
            this.toolTip1.SetToolTip(this.chbEnableLivePreview, "Add this script to the list of scripts that can be previewed using the Live Previ" +
        "ew feature.");
            this.chbEnableLivePreview.UseVisualStyleBackColor = true;
            this.chbEnableLivePreview.CheckedChanged += new System.EventHandler(this.chbEnableLivePreview_CheckedChanged);
            // 
            // chbNotCompiled
            // 
            this.chbNotCompiled.AutoSize = true;
            this.chbNotCompiled.Location = new System.Drawing.Point(31, 64);
            this.chbNotCompiled.Name = "chbNotCompiled";
            this.chbNotCompiled.Size = new System.Drawing.Size(130, 24);
            this.chbNotCompiled.TabIndex = 4;
            this.chbNotCompiled.Text = "Not Compiled";
            this.toolTip1.SetToolTip(this.chbNotCompiled, "If checked, this script will be copied into the project\'s resources and interpret" +
        "ed as a script,\r\nrather than generated into code before compilation.");
            this.chbNotCompiled.UseVisualStyleBackColor = true;
            this.chbNotCompiled.CheckedChanged += new System.EventHandler(this.chbNotCompiled_CheckedChanged);
            // 
            // chbInitScript
            // 
            this.chbInitScript.AutoSize = true;
            this.chbInitScript.Location = new System.Drawing.Point(31, 94);
            this.chbInitScript.Name = "chbInitScript";
            this.chbInitScript.Size = new System.Drawing.Size(119, 24);
            this.chbInitScript.TabIndex = 5;
            this.chbInitScript.Text = "Is Init Script";
            this.toolTip1.SetToolTip(this.chbInitScript, "Specifies this script as being part of initialisation and must be executed before" +
        " anything else.");
            this.chbInitScript.UseVisualStyleBackColor = true;
            this.chbInitScript.CheckedChanged += new System.EventHandler(this.chbInitScript_CheckedChanged);
            // 
            // ScriptFileProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chbInitScript);
            this.Controls.Add(this.chbEnableLivePreview);
            this.Controls.Add(this.chbNotCompiled);
            this.Controls.Add(this.cmbInterpretation);
            this.Controls.Add(this.label1);
            this.Name = "ScriptFileProperties";
            this.Size = new System.Drawing.Size(898, 187);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbInterpretation;
        private System.Windows.Forms.CheckBox chbEnableLivePreview;
        private System.Windows.Forms.CheckBox chbNotCompiled;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chbInitScript;
    }
}

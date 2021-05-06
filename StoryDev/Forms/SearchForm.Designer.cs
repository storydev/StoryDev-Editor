
namespace StoryDev.Forms
{
    partial class SearchForm<T>
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
            this.lvResults = new System.Windows.Forms.ListView();
            this.btnFilters = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvResults
            // 
            this.lvResults.FullRowSelect = true;
            this.lvResults.HideSelection = false;
            this.lvResults.Location = new System.Drawing.Point(12, 51);
            this.lvResults.MultiSelect = false;
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(1011, 504);
            this.lvResults.TabIndex = 0;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // btnFilters
            // 
            this.btnFilters.Location = new System.Drawing.Point(12, 12);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(96, 33);
            this.btnFilters.TabIndex = 1;
            this.btnFilters.Text = "Filters";
            this.btnFilters.UseVisualStyleBackColor = true;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(903, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(120, 33);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 571);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnFilters);
            this.Controls.Add(this.lvResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.Button btnSelect;
    }
}
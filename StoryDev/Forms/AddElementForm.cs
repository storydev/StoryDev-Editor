using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Components.ElementAdditionals;

namespace StoryDev.Forms
{
    partial class AddElementForm : Form
    {

        public AddElementForm()
        {
            InitializeComponent();
        }

        private void SelectElement(string tag)
        {
            var fieldRefVisible = true;
            var customDataVisible = false;
            var additionalVisible = false;

            pnlAdditionalOptions.Controls.Clear();

            switch (tag)
            {
                case "_Button":
                case "_Label":
                    fieldRefVisible = false;
                    break;
                case "_CheckList":
                case "_ComboBox":
                    customDataVisible = true;
                    break;
                case "_ListBox":
                    customDataVisible = true;
                    additionalVisible = true;
                    pnlAdditionalOptions.Controls.Add(new ListBoxAdditional() { Dock = DockStyle.Fill });
                    break;
                case "_SingleLink":
                    additionalVisible = true;
                    pnlAdditionalOptions.Controls.Add(new ListBoxAdditional() { Dock = DockStyle.Fill });
                    break;
                case "_LinkedDetailedView":
                    additionalVisible = true;
                    pnlAdditionalOptions.Controls.Add(new LinkedDetailedAdditional() { Dock = DockStyle.Fill });
                    break;
            }

            pnlFieldReference.Visible = fieldRefVisible;
            pnlCustomDataSource.Visible = customDataVisible;
            pnlAdditionalOptions.Visible = additionalVisible;
        }

        private void lvElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvElements.SelectedItems.Count > 0)
            {
                ListViewItem item = lvElements.SelectedItems[0];
                SelectElement((string)item.Tag);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}

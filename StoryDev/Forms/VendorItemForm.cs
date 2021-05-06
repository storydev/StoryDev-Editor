using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Data;
using StoryDev.Components;

namespace StoryDev.Forms
{
    partial class VendorItemForm : Form
    {

        private CodeEditor scriptEditor;
        private VendorItem vendor;

        public VendorItemForm(VendorItem vendor)
        {
            InitializeComponent();

            scriptEditor = new CodeEditor();
            scriptEditor.Dock = DockStyle.Fill;
            scriptEditor.TextChanged += ScriptEditor_TextChanged;

            pnlScript.Controls.Add(scriptEditor);

            this.vendor = vendor;

            foreach (var item in Globals.Items)
            {
                cmbItem.Items.Add(item.Name);
                cmbItem.AutoCompleteCustomSource.Add(item.Name);
            }

            PopulateFields();
        }

        private void ScriptEditor_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            vendor.ConditionScript = scriptEditor.Text;
        }

        private void PopulateFields()
        {
            cmbItem.SelectedIndex = Globals.Items.FindIndex((item) => item.ID == vendor.ItemID);
            nudQuantity.Value = vendor.Quantity;
            scriptEditor.Text = vendor.ConditionScript;
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbItem.SelectedIndex > -1)
            {
                vendor.ItemID = Globals.Items[cmbItem.SelectedIndex].ID;
            }
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            vendor.Quantity = (int)nudQuantity.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnBrowseItems_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Item>("Items");
            search.SearchSelected += (int index) => cmbItem.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

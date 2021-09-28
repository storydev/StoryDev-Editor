using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Forms
{
    [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
    partial class EnterCustomSourceForm : Form
    {

        private int selectedScript;

        public string CustomSourceData
        {
            get; private set;
        }

        public EnterCustomSourceForm()
        {
            InitializeComponent();

            PopulateSources();
        }

        private void PopulateSources()
        {
            cmbScriptSources.Items.Clear();
            cmbScriptSources.AutoCompleteCustomSource.Clear();
            foreach (var key in Globals.CustomSources.Keys)
            {
                cmbScriptSources.Items.Add(key);
                cmbScriptSources.AutoCompleteCustomSource.Add(key);
            }
        }

        private void btnAddScript_Click(object sender, EventArgs e)
        {
            var enterField = new SimpleEntryForm();
            enterField.NotEmpty = true;
            enterField.RegexPattern = "^[A-Za-z]+$";
            enterField.ErrorValue = "Script function name must not contain any symbols.";
            if (enterField.ShowDialog() == DialogResult.OK)
            {
                Globals.CustomSources.Add(enterField.Value, "");
                PopulateSources();
            }
        }

        private void cmbScriptSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbScriptSources.SelectedIndex > -1)
            {
                selectedScript = cmbScriptSources.SelectedIndex;

                var name = (string)cmbScriptSources.Items[selectedScript];
                txtSource.Enabled = true;
                txtSource.Text = Globals.CustomSources[name];
            }
        }

        private void btnDeleteScript_Click(object sender, EventArgs e)
        {
            if (selectedScript > -1)
            {
                var name = Globals.CustomSources.Keys.ElementAt(selectedScript);
                var response = MessageBox.Show("Are you sure you wish to delete '" + name + "'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes)
                {
                    selectedScript = -1;
                    Globals.CustomSources.Remove(name);
                    PopulateSources();
                }
            }
        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {
            if (selectedScript > -1)
            {
                var name = (string)cmbScriptSources.Items[selectedScript];
                Globals.CustomSources[name] = txtSource.Text;
            }
            else
            {
                CustomSourceData = txtSource.Text;
            }
        }

        private void rdbScript_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbScript.Checked)
            {
                if (cmbScriptSources.SelectedIndex > -1)
                {
                    selectedScript = cmbScriptSources.SelectedIndex;

                    var name = (string)cmbScriptSources.Items[selectedScript];
                    txtSource.Text = Globals.CustomSources[name];
                    txtSource.Enabled = true;
                }
                else
                {
                    txtSource.Text = "";
                    txtSource.Enabled = false;
                }
            }
        }

        private void rdbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbManual.Checked)
            {
                if (!txtSource.Enabled)
                    txtSource.Enabled = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdbScript.Checked && selectedScript > -1)
            {
                CustomSourceData = "fn:" + cmbScriptSources.Items[selectedScript];
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

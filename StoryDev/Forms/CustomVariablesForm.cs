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

namespace StoryDev.Forms
{
    partial class CustomVariablesForm : Form
    {

        private IEnumerable<Variable> results;

        public CustomVariablesForm()
        {
            InitializeComponent();

            cmbChapters.Items.Add("Any");
            foreach (var chapter in Globals.Chapters)
            {
                cmbChapters.Items.Add(chapter);
            }

            PopulateList();
        }

        private void PopulateList()
        {
            results = Globals.Variables.Where((v) =>
            {
                if (cmbChapters.SelectedIndex <= 0 && cmbVars.SelectedIndex <= 0)
                    return true;

                var result = true;
                if (cmbVars.SelectedIndex > 0)
                {
                    if (v.Type != cmbVars.SelectedIndex - 1)
                        return false;
                }

                if (cmbChapters.SelectedIndex > 0)
                {
                    if (v.DeclaredScope != (string)cmbChapters.SelectedItem)
                        return false;
                }

                return result;
            });

            lvResults.Items.Clear();

            foreach (var result in results)
            {
                var item = new ListViewItem();
                item.Text = result.Name;
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = ResolveType(result.Type)
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = result.DeclaredScope
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = result.DefaultValue.ToString()
                });

                lvResults.Items.Add(item);
            }
        }

        private string ResolveType(int type)
        {
            if (type == 0)
                return "Boolean";
            else if (type == 1)
                return "Number";
            else if (type == 2)
                return "String";

            return "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbVars_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void cmbChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void sbtnAddVar_Click(object sender, EventArgs e)
        {
            var variable = new Variable();
            variable.Name = "";

            var edit = new EditVarForm(variable);
            if (edit.ShowDialog() == DialogResult.OK)
            {
                Globals.Variables.Add(edit.Variable);
                Globals.SaveVariables();
                PopulateList();
            }
        }

        private void lvResults_DoubleClick(object sender, EventArgs e)
        {
            if (lvResults.SelectedIndices.Count > 0)
            {
                var selected = lvResults.SelectedIndices[0];
                var selResult = results.ElementAt(selected);
                var actualResult = Globals.Variables.FindIndex((v) => v.Name == selResult.Name);
                if (new EditVarForm(Globals.Variables[actualResult]).ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void copyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvResults.SelectedIndices.Count > 0)
            {
                var selected = lvResults.SelectedIndices[0];
                var selResult = results.ElementAt(selected);
                Clipboard.SetText(selResult.Name);
            }
        }

        private void cmsEditMenu_Opening(object sender, CancelEventArgs e)
        {
            copyNameToolStripMenuItem.Enabled = lvResults.SelectedItems.Count > 0;
        }
    }
}

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
using StoryDev.Scripting;
using StoryDev.Forms;

namespace StoryDev.Components.ElementAdditionals
{
    partial class LinkedDetailedAdditional : UserControl
    {

        private LinkedAdditionalData data;

        public LinkedDetailedAdditional()
        {
            InitializeComponent();

            data = new LinkedAdditionalData();

            PopulateModuleList();
        }

        private void PopulateModuleList()
        {
            cmbModuleReference.Items.Clear();
            cmbModuleReference.Items.Add("None");
            cmbModuleReference.Items.Add("----------");
            foreach (var module in ScriptEngine.Instance.DataModules)
            {
                cmbModuleReference.Items.Add(module.Name);
            }
        }

        private void cmbModuleReference_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModuleReference.SelectedIndex > -1)
            {
                var enabled = cmbModuleReference.SelectedIndex > 1;
                cmbRelationship.Enabled = btnEditDisplayColumns.Enabled = enabled;

                if (enabled)
                {
                    data.SelectedModule = (string)cmbModuleReference.Items[cmbModuleReference.SelectedIndex];
                    var fields = ScriptEngine.Instance.DataModules[cmbModuleReference.SelectedIndex - 2].Fields;
                    cmbRelationship.Items.Clear();
                    data.Columns.Clear();
                    foreach (var field in fields)
                    {
                        cmbRelationship.Items.Add(field.Name);

                        var column = new LinkedColumn();
                        column.FieldName = field.Name;
                        column.Visible = !field.Options.HiddenInSearch;
                        column.Width = 100;

                        data.Columns.Add(column);
                    }
                }
            }
        }

        private void cmbRelationship_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRelationship.SelectedIndex > -1)
            {
                data.Relationship = (string)cmbRelationship.Items[cmbRelationship.SelectedIndex];
            }
        }

        private void btnEditDisplayColumns_Click(object sender, EventArgs e)
        {
            if (data.Columns.Count > 0)
                new LinkedDataEditColumnsForm(data.Columns).ShowDialog();
        }
    }
}

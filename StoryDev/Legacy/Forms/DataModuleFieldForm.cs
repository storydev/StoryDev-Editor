using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Scripting;
using StoryDev.Scripting.Modules;

namespace StoryDev.Forms
{
    [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
    partial class DataModuleFieldForm : Form
    {

        private DataField field;
        private Module module;

        public DataModuleFieldForm(Module module, DataField field)
        {
            InitializeComponent();

            this.field = field;

            cmbGroup.Items.Clear();
            foreach (var f in module.Fields)
            {
                if (!string.IsNullOrEmpty(f.Options.Group))
                    AddAutoComplete(f.Options.Group);
            }

            cmbRelationshipType.Items.Clear();
            foreach (var m in ScriptEngine.Instance.DataModules)
            {
                if (module.Name != m.Name)
                    cmbRelationshipType.Items.Add(m.Name);
            }

            PopulateFields();
        }

        private void AddAutoComplete(string text)
        {
            var found = false;
            foreach (var item in cmbGroup.AutoCompleteCustomSource)
            {
                if (text == (string)item)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                cmbGroup.AutoCompleteCustomSource.Add(text);
            }
        }

        private void PopulateFields()
        {
            txtName.Text = field.Name;
            cmbTypes.SelectedIndex = (int)field.Type;
            chbHiddenInSearch.Checked = field.Options.HiddenInSearch;
            nudColumnWidth.Value = field.Options.ColumnWidth;
            cmbGroup.Text = field.Options.Group;
            cmbLabelPosition.SelectedIndex = (int)field.Options.LabelPosition;

            if (!string.IsNullOrEmpty(field.Options.CustomDataSource))
            {
                rdbCustomSource.Checked = true;
                btnEnterSource.Enabled = true;
            }
            else if (!string.IsNullOrEmpty(field.Options.RelationshipTypeName))
            {
                rdbForeignRelationship.Checked = true;

                for (int i = 0; i < cmbRelationshipType.Items.Count; i++)
                {
                    if ((string)cmbRelationshipType.Items[i] == field.Options.RelationshipTypeName)
                    {
                        cmbRelationshipType.SelectedIndex = i;
                        PopulateFieldNames();
                    }
                }

                if (!string.IsNullOrEmpty(field.Options.FieldName))
                {
                    for (int i = 0; i < cmbRelationshipFields.Items.Count; i++)
                    {
                        if ((string)cmbRelationshipFields.Items[i] == field.Options.FieldName)
                        {
                            cmbRelationshipFields.SelectedIndex = i;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(field.Options.DisplayField))
                {
                    for (int i = 0; i < cmbDisplayField.Items.Count; i++)
                    {
                        if ((string)cmbDisplayField.Items[i] == field.Options.DisplayField)
                        {
                            cmbDisplayField.SelectedIndex = i;
                        }
                    }
                }
            }

            chbResultIsList.Checked = field.Options.IsResultList;
            if (chbResultIsList.Checked)
                rdbForeignRelationship.Text = "Primary Key:";

            btnEditColumns.Enabled = chbResultIsList.Checked;
        }

        private void PopulateFieldNames()
        {
            if (cmbRelationshipType.SelectedIndex > -1)
            {
                var module = ScriptEngine.Instance.DataModules[cmbRelationshipType.SelectedIndex];
                cmbRelationshipFields.Items.Clear();
                cmbDisplayField.Items.Clear();
                foreach (var f in module.Fields)
                {
                    cmbRelationshipFields.Items.Add(f.Name);
                    cmbDisplayField.Items.Add(f.Name);
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            field.Name = txtName.Text;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            
        }

        private void cmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            field.Type = (DataType)cmbTypes.SelectedIndex;
        }

        private void chbHiddenInSearch_CheckedChanged(object sender, EventArgs e)
        {
            field.Options.HiddenInSearch = chbHiddenInSearch.Checked;
        }

        private void nudColumnWidth_ValueChanged(object sender, EventArgs e)
        {
            field.Options.ColumnWidth = (int)nudColumnWidth.Value;
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGroup_TextChanged(object sender, EventArgs e)
        {
            field.Options.Group = cmbGroup.Text;
        }

        private void cmbLabelPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            field.Options.LabelPosition = (LabelPosition)cmbLabelPosition.SelectedIndex;
        }

        private void rdbCustomSource_CheckedChanged(object sender, EventArgs e)
        {
            btnEnterSource.Enabled = rdbCustomSource.Checked;
        }

        private void rdbForeignRelationship_CheckedChanged(object sender, EventArgs e)
        {
            pnlForeignKeyOptions.Enabled = rdbForeignRelationship.Checked;
        }

        private void chbResultIsList_CheckedChanged(object sender, EventArgs e)
        {
            btnEditColumns.Enabled = field.Options.IsResultList = chbResultIsList.Checked;
            cmbDisplayField.Enabled = !chbResultIsList.Checked;
        }

        private void cmbRelationshipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRelationshipType.SelectedIndex > -1)
            {
                field.Options.RelationshipTypeName = (string)cmbRelationshipType.Items[cmbRelationshipType.SelectedIndex];

                PopulateFieldNames();
            }
        }

        private void btnEditColumns_Click(object sender, EventArgs e)
        {
            var columnsForm = new LinkedDataEditColumnsForm(field.Options.DisplayColumns);
            columnsForm.ShowDialog();
        }

        private void cmbRelationshipFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRelationshipFields.SelectedIndex > -1)
            {
                field.Options.FieldName = (string)cmbRelationshipFields.Items[cmbRelationshipFields.SelectedIndex];
            }
        }

        private void cmbDisplayField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDisplayField.SelectedIndex > -1)
            {
                field.Options.DisplayField = (string)cmbDisplayField.Items[cmbDisplayField.SelectedIndex];
            }
        }

        private void btnEnterSource_Click(object sender, EventArgs e)
        {
            var enter = new EnterCustomSourceForm();
            if (enter.ShowDialog() == DialogResult.OK)
            {
                field.Options.CustomDataSource = enter.CustomSourceData;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}

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

namespace StoryDev.Components.DataModule
{
    partial class DataModuleEditUI : UserControl
    {

        private Module module;

        public DataModuleEditUI(Module module)
        {
            InitializeComponent();

            this.module = module;

            PopulateFields();
        }

        private void PopulateFields()
        {
            txtName.Text = module.Name;
            txtTypeName.Text = module.TypeName;

            lvFields.Items.Clear();
            foreach (var field in module.Fields)
            {
                var item = new ListViewItem();
                item.Text = field.Name;
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = field.Type.ToString()
                });
                lvFields.Items.Add(item);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            module.Name = txtName.Text;
        }

        private void txtTypeName_TextChanged(object sender, EventArgs e)
        {
            module.TypeName = txtTypeName.Text;
        }

        public string ToCode()
        {
            var result = "";

            result += "var module = CreateDataModule('";
            result += txtName.Text + "', '";
            result += txtTypeName.Text + "');\r\n\r\n";

            foreach (var field in module.Fields)
            {
                var instanceName = field.Name + "_Field";
                result += "var " + instanceName + " = CreateField(";
                result += "module, ";
                result += "'" + field.Name + "', ";
                result += "TYPE_" + field.Type.ToString() + ");\r\n";

                if (field.Options.HiddenInSearch)
                {
                    result += instanceName + ".Options.HiddenInSearch = true;\r\n";
                }

                if (!string.IsNullOrEmpty(field.Options.CustomDataSource))
                {
                    result += instanceName + ".Options.CustomDataSource = '" + field.Options.CustomDataSource + "';\r\n";
                }

                if (field.Options.ColumnWidth != 100)
                {
                    result += instanceName + ".Options.ColumnWidth = " + field.Options.ColumnWidth + ";\r\n";
                }

                if (!string.IsNullOrEmpty(field.Options.RelationshipTypeName))
                {
                    result += instanceName + ".Options.RelationshipTypeName = '" + field.Options.RelationshipTypeName + "';\r\n";
                }

                if (!string.IsNullOrEmpty(field.Options.FieldName))
                {
                    result += instanceName + ".Options.FieldName = '" + field.Options.FieldName + "';\r\n";
                }

                if (!string.IsNullOrEmpty(field.Options.DisplayField))
                {
                    result += instanceName + ".Options.DisplayField = '" + field.Options.DisplayField + "';\r\n";
                }

                if (!string.IsNullOrEmpty(field.Options.SourceName))
                {
                    result += instanceName + ".Options.SourceName = '" + field.Options.SourceName + "';\r\n";
                }

                result += "\r\n";
            }

            return result;
        }
    }
}

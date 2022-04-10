using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.DBO.Scripting;

namespace StoryDev.Components.TestEnv.Results
{
    partial class DataStructureResults : UserControl
    {

        private IEnumerable<DataStruct> structures;

        public DataStructureResults()
        {
            InitializeComponent();

            structures = Scripting.Environment.TestEnv.Structures;
            foreach (var str in structures)
            {
                cmbStructures.Items.Add(str.Name);
            }
        }

        private void cmbStructures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStructures.SelectedIndex > -1)
            {
                var current = structures.ElementAt(cmbStructures.SelectedIndex);
                lvFields.Items.Clear();
                foreach (var field in current.Fields)
                {
                    var item = new ListViewItem();
                    item.Text = field.Name;
                    item.SubItems.Add(GetNameOfType(field.Type));
                    item.SubItems.Add(GetNameOfType(field.ArrayType));
                    if (!string.IsNullOrEmpty(field.StructReference))
                    {
                        item.SubItems.Add(field.StructReference);
                    }
                    else
                    {
                        item.SubItems.Add("");
                    }

                    if (!string.IsNullOrEmpty(field.DisplayReference))
                    {
                        item.SubItems.Add("Field Reference: " + field.FieldReference);
                    }
                    else if (!string.IsNullOrEmpty(field.CustomReferenceSource))
                    {
                        item.SubItems.Add("Custom Source: " + field.CustomReferenceSource);
                    }
                    else if (field.CustomDisplayReference != null)
                    {
                        item.SubItems.Add("Direct Array: Count(" + field.CustomReferenceSource.Length + ")");
                    }
                    else
                    {
                        item.SubItems.Add("");
                    }

                    lvFields.Items.Add(item);
                }
            }
        }

        private string GetNameOfType(DataFieldType type)
        {
            string result = "";

            if (type == DataFieldType.BOOLEAN)
                result = "Boolean";
            else if (type == DataFieldType.DATETIME)
                result = "Date & Time";
            else if (type == DataFieldType.FLOAT)
                result = "Float";
            else if (type == DataFieldType.INTEGER)
                result = "Integer";
            else if (type == DataFieldType.OFARRAY)
                result = "Array";
            else if (type == DataFieldType.STRING)
                result = "String";
            else if (type == DataFieldType.NONE)
                result = "N/A";

            return result;
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            if (cmbStructures.SelectedIndex > -1)
            {
                var structure = Scripting.Environment.TestEnv.Structures.ElementAt(cmbStructures.SelectedIndex);
                Scripting.Environment.TestEnv.ShowForm(structure.DefinedFormName);
            }
        }
    }
}

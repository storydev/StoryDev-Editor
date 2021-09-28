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
    [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
    partial class EditDataModuleComponentForm : Form
    {

        private FormComponent component;

        public EditDataModuleComponentForm(FormComponent component)
        {
            InitializeComponent();

            this.component = component;

            Text = "Edit " + Globals.GetFormFieldComponentName((ElementType)component.FieldType) + " Component";

            PopulateFields();
        }

        private void PopulateFields()
        {
            nudDefaultWidth.Value = component.DefaultWidth;
            nudDefaultHeight.Value = component.DefaultHeight;
            cmbLabelPosition.SelectedIndex = component.LabelPosition;
        }

        private void nudDefaultWidth_ValueChanged(object sender, EventArgs e)
        {
            component.DefaultWidth = (int)nudDefaultWidth.Value;
        }

        private void nudDefaultHeight_ValueChanged(object sender, EventArgs e)
        {
            component.DefaultHeight = (int)nudDefaultHeight.Value;
        }

        private void cmbLabelPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            component.LabelPosition = cmbLabelPosition.SelectedIndex;
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

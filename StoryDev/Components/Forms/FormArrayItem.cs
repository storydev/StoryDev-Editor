using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Forms;
using StoryDev.Scripting;

namespace StoryDev.Components.Forms
{
    partial class FormArrayItem : UserControl
    {

        private int index;
        private DataFieldType type;
        private FieldDisplay display;

        public string ItemValue
        {
            get => lblValue.Text;
            set => lblValue.Text = value;
        }

        public object RawValue;


        public FormArrayItem(int index, DataFieldType type, FieldDisplay display)
        {
            InitializeComponent();

            this.index = index;
            this.type = type;
            this.display = display;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormArrayItemDeleted?.Invoke(index);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var editForm = new EditArrayItemForm(type, display, RawValue);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                FormArrayItemEdited?.Invoke(index, editForm.NewValue);
                RawValue = editForm.NewValue;
                ItemValue = "" + (index + 1) + ": " + RawValue.ToString();
            }
        }

        public event OnFormArrayItemDeleted FormArrayItemDeleted;
        public event OnFormArrayItemEdited FormArrayItemEdited;
    }
}

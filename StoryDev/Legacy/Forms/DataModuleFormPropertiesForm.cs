using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Components;
using StoryDev.Data;

namespace StoryDev.Forms
{
    [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
    partial class DataModuleFormPropertiesForm : Form
    {

        private FormProperties properties;

        public DataModuleFormPropertiesForm(FormProperties properties)
        {
            InitializeComponent();

            this.properties = properties;

            PopulateFields();
        }

        private void PopulateFields()
        {
            nudPadding.Value = properties.GlobalPadding;
            cmbLabelPosition.SelectedIndex = properties.DefaultLabelPosition;
            chbAutoWidthFields.Checked = properties.AutoWidthFields;

            chbAllMargins.CheckedChanged -= chbAllMargins_CheckedChanged;
            chbAllMargins.Checked = properties.AllMargins;

            if (chbAllMargins.Checked)
            {
                nudAllMargins.Value = properties.Margin;

                nudTopMargin.Value = nudLeftMargin.Value =
                    nudRightMargin.Value = nudBottomMargin.Value = properties.Margin;
            }
            else
            {
                nudTopMargin.Value = properties.TopMargin;
                nudLeftMargin.Value = properties.LeftMargin;
                nudRightMargin.Value = properties.RightMargin;
                nudBottomMargin.Value = properties.BottomMargin;
            }

            chbAllMargins.CheckedChanged += chbAllMargins_CheckedChanged;

            PopulateComponentList();
        }

        private void PopulateComponentList()
        {
            lvComponentDetails.Items.Clear();
            foreach (var component in properties.FormComponents)
            {
                var item = new ListViewItem();
                item.Text = Globals.GetFormFieldComponentName((ElementType)component.FieldType);
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = "" + component.DefaultWidth
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = "" + component.DefaultHeight
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = GetPositionName(component.LabelPosition)
                });

                lvComponentDetails.Items.Add(item);
            }
        }

        private string GetPositionName(int position)
        {
            if (position == 0)
                return "Top";
            else if (position == 1)
                return "Left";
            else if (position == 2)
                return "Right";
            else if (position == 3)
                return "Bottom";

            return "";
        }

        private void chbAllMargins_CheckedChanged(object sender, EventArgs e)
        {
            nudTopMargin.Enabled = nudLeftMargin.Enabled =
                nudRightMargin.Enabled = nudBottomMargin.Enabled = !chbAllMargins.Checked;

            if (chbAllMargins.Checked)
            {
                nudTopMargin.Value = nudLeftMargin.Value =
                    nudRightMargin.Value = nudBottomMargin.Value = nudAllMargins.Value;
            }
            else
            {
                nudTopMargin.Value = properties.TopMargin;
                nudLeftMargin.Value = properties.LeftMargin;
                nudRightMargin.Value = properties.RightMargin;
                nudBottomMargin.Value = properties.BottomMargin;
            }

            properties.AllMargins = chbAllMargins.Checked;
        }

        private void nudPadding_ValueChanged(object sender, EventArgs e)
        {
            properties.GlobalPadding = (int)nudPadding.Value;
        }

        private void chbAutoWidthFields_CheckedChanged(object sender, EventArgs e)
        {
            properties.AutoWidthFields = chbAutoWidthFields.Checked;
        }

        private void cmbLabelPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            properties.DefaultLabelPosition = cmbLabelPosition.SelectedIndex;
        }

        private void nudAllMargins_ValueChanged(object sender, EventArgs e)
        {
            properties.Margin = (int)nudAllMargins.Value;
        }

        private void nudTopMargin_ValueChanged(object sender, EventArgs e)
        {
            properties.TopMargin = (int)nudTopMargin.Value;
        }

        private void nudLeftMargin_ValueChanged(object sender, EventArgs e)
        {
            properties.LeftMargin = (int)nudLeftMargin.Value;
        }

        private void nudRightMargin_ValueChanged(object sender, EventArgs e)
        {
            properties.RightMargin = (int)nudRightMargin.Value;
        }

        private void nudBottom_ValueChanged(object sender, EventArgs e)
        {
            properties.BottomMargin = (int)nudBottomMargin.Value;
        }

        private void btnApplyGlobally_Click(object sender, EventArgs e)
        {
            Globals.Settings.FormComponents.Clear();
            foreach (var comp in properties.FormComponents)
            {
                Globals.Settings.FormComponents.Add(comp);
            }

            Globals.SaveSettings();
        }

        private void lvComponentDetails_DoubleClick(object sender, EventArgs e)
        {
            if (lvComponentDetails.SelectedIndices.Count > 0)
            {
                var index = lvComponentDetails.SelectedIndices[0];
                var last = new FormComponent();
                var current = properties.FormComponents[index];
                last.DefaultHeight = current.DefaultHeight;
                last.DefaultWidth = current.DefaultWidth;
                last.FieldType = current.FieldType;
                last.LabelPosition = current.LabelPosition;

                if (new EditDataModuleComponentForm(current).ShowDialog() == DialogResult.OK)
                {
                    PopulateComponentList();
                }
                else
                {
                    properties.FormComponents[index] = last;
                }
            }
        }
    }
}

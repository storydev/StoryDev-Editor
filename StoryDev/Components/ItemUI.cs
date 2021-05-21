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
using StoryDev.Forms;

namespace StoryDev.Components
{
    partial class ItemUI : UserControl
    {

        private int selectedItem;

        public ItemUI()
        {
            InitializeComponent();
            btnIconIndex.IconSet = Globals.IconSetData.Items;
            btnIconIndex.Click += BtnIconIndex_Click;

            PopulateList();
        }

        private void BtnIconIndex_Click(object sender, EventArgs e)
        {
            var iconSelect = new IconSelectorForm(Globals.IconSetData.Items.FilePath, Globals.IconSetData.Items.IconSize);
            if (iconSelect.ShowDialog() == DialogResult.OK)
            {
                btnIconIndex.IconIndex = iconSelect.SelectedIndex;
                if (selectedItem > -1)
                {
                    Globals.Items[selectedItem].IconIndex = btnIconIndex.IconIndex;
                }
            }
        }

        private void PopulateList()
        {
            lbResults.SelectedIndexChanged -= lbResults_SelectedIndexChanged;

            var temp = lbResults.SelectedIndex;

            lbResults.Items.Clear();

            foreach (var item in Globals.Items)
            {
                lbResults.Items.Add(item.Name);
            }

            if (temp < lbResults.Items.Count - 1)
                lbResults.SelectedIndex = temp;


            lbResults.SelectedIndexChanged += lbResults_SelectedIndexChanged;
        }

        private void PopulateFields()
        {
            if (selectedItem > -1)
            {
                var item = Globals.Items[selectedItem];

                txtName.Text = item.Name;
                txtDescription.Text = item.Description;
                btnIconIndex.IconIndex = item.IconIndex;
                btnIconIndex.Invalidate();

                chbIsUnique.Checked = item.IsUnique;
                chbSpecial.Checked = item.IsSpecial;
                chbConsumed.Checked = item.ConsumeOnUse;
                cmbRarity.SelectedIndex = item.Rarity;
                nudBuyPrice.Value = (decimal)item.BuyPrice;
                nudSellPrice.Value = (decimal)item.SellPrice;
                cmbItemUseContext.SelectedIndex = item.UseContext;
                txtOnUseScript.Text = item.OnUseScript;
                nudUseCooldown.Value = item.UseCooldown;
            }
        }

        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbResults.SelectedIndex > -1)
            {
                selectedItem = lbResults.SelectedIndex;

                pnlContent.Enabled = true;
                PopulateFields();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var item = new Item();
            item.ID = ++Globals.GlobalIdentifiers.ItemID;
            Globals.SaveIdentifiers();
            Globals.Items.Add(item);
            PopulateList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbResults.SelectedIndex > -1)
            {
                var item = Globals.Items[selectedItem];
                var response = MessageBox.Show("Are you sure you wish to delete the item '" + item.Name + "'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes)
                {
                    var temp = lbResults.SelectedIndex;
                    Globals.Items.RemoveAt(temp);
                    selectedItem = lbResults.SelectedIndex = -1;
                    PopulateList();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Globals.SaveItems();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Item>("Items");
            search.SearchSelected += (int index) => lbResults.SelectedIndex = index;
            search.ShowDialog();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem > -1)
            {
                Globals.Items[selectedItem].Name = txtName.Text;
                lbResults.Items[selectedItem] = txtName.Text;
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem > -1)
            {
                Globals.Items[selectedItem].Description = txtDescription.Text;
            }
        }

        private void chbIsUnique_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedItem > -1)
            {
                Globals.Items[selectedItem].IsUnique = chbIsUnique.Checked;
            }
        }

        private void chbSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedItem > -1)
            {
                Globals.Items[selectedItem].IsSpecial = chbSpecial.Checked;
            }
        }

        private void cmbRarity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedItem > -1)
            {
                Globals.Items[selectedItem].Rarity = cmbRarity.SelectedIndex;
            }
        }

        private void nudBuyPrice_ValueChanged(object sender, EventArgs e)
        {
            if (selectedItem > -1)
            {
                Globals.Items[selectedItem].BuyPrice = (double)nudBuyPrice.Value;
            }
        }

        private void nudSellPrice_ValueChanged(object sender, EventArgs e)
        {
            if (selectedItem > -1)
            {
                Globals.Items[selectedItem].SellPrice = (double)nudSellPrice.Value;
            }
        }

        private void cmbItemUseContext_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedItem > -1)
            {
                Globals.Items[selectedItem].UseContext = cmbItemUseContext.SelectedIndex;
            }
        }

        private void txtOnUseScript_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem > -1)
            {
                Globals.Items[selectedItem].OnUseScript = txtOnUseScript.Text;
            }
        }

        private void nudUseCooldown_ValueChanged(object sender, EventArgs e)
        {
            if (selectedItem > -1)
            {
                Globals.Items[selectedItem].UseCooldown = (int)nudUseCooldown.Value;
            }
        }

        private void chbConsumed_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedItem > -1)
            {
                Globals.Items[selectedItem].ConsumeOnUse = chbConsumed.Checked;
            }
        }

        private void txtOnUseScript_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                var construct = new CodeConstructForm();
                construct.ConstructFromExisting(txtOnUseScript.Text);
                construct.Method = ConstructMethod.Advanced;
                construct.NoSwitching = true;

                if (construct.ShowDialog() == DialogResult.OK)
                {
                    txtOnUseScript.Text = construct.Code;
                }
            }
        }
    }
}

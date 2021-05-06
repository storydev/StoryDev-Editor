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

namespace StoryDev.Components.CodeUI
{
    partial class AdjustInventoryItem : UserControl, ICodeComponent
    {
        public AdjustInventoryItem()
        {
            InitializeComponent();

            foreach (var item in Globals.Items)
            {
                cmbItems.Items.Add(item.Name);
                cmbItems.AutoCompleteCustomSource.Add(item.Name);
            }
        }

        public bool IsConditional => false;

        public void FromCodeString(string code)
        {
            var result = code.Substring("AdjustInventoryItem(".Length, code.LastIndexOf(')') - "AdjustInventoryItem(".Length);
            var splitted = result.Split(',');
            if (splitted.Length == 2)
            {
                if (int.TryParse(splitted[0], out int itemID))
                {
                    cmbItems.SelectedIndex = Globals.Items.FindIndex((i) => i.ID == itemID);
                }

                if (int.TryParse(splitted[1], out int amount))
                {
                    nudAmount.Value = amount;
                }
            }
        }

        public UserControl GetControl()
        {
            return this;
        }

        public string GetErrorMessage()
        {
            if (cmbItems.SelectedIndex == -1)
                return "You must select an item.";

            if (nudAmount.Value == 0m)
                return "You must select an amount less or greater than zero.";

            return "";
        }

        public bool IsValid()
        {
            return cmbItems.SelectedIndex > -1 && (nudAmount.Value > 0m || nudAmount.Value < 0m);
        }

        public string ToCodeString()
        {
            return string.Format("AdjustInventoryItem({0}, {1})", Globals.Items[cmbItems.SelectedIndex].ID, nudAmount.Value);
        }

        private void btnBrowseItems_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Item>("Items");
            search.SearchSelected += (int index) => cmbItems.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

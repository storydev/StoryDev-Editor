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
    partial class HasItem : UserControl, ICodeComponent
    {
        public HasItem()
        {
            InitializeComponent();

            foreach (var item in Globals.Items)
            {
                cmbItems.Items.Add(item.Name);
                cmbItems.AutoCompleteCustomSource.Add(item.Name);
            }
        }

        public bool IsConditional => true;

        public void FromCodeString(string code)
        {
            var result = code.Substring("HasItem(".Length, code.LastIndexOf(')') - "HasItem(".Length);
            if (int.TryParse(result, out int itemID))
            {
                cmbItems.SelectedIndex = Globals.Items.FindIndex((i) => i.ID == itemID);
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

            return "";
        }

        public bool IsValid()
        {
            return cmbItems.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("HasItem({0})", Globals.Items[cmbItems.SelectedIndex].ID);
        }

        private void btnBrowseItems_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Item>("Items");
            search.SearchSelected += (int index) => cmbItems.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

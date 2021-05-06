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
    partial class IsItemAvailable : UserControl, ICodeComponent
    {

        private IEnumerable<Character> chars;

        public IsItemAvailable()
        {
            InitializeComponent();

            chars = Globals.Characters.Where((c) => !c.PlayerCharacter && c.IsVendor);
            foreach (var c in chars)
            {
                cmbCharacters.Items.Add(c.FirstName);
                cmbCharacters.AutoCompleteCustomSource.Add(c.FirstName);
            }
        }

        public bool IsConditional => true;

        public void FromCodeString(string code)
        {
            var result = code.Substring("IsItemAvailable(".Length, code.LastIndexOf(')') - "IsItemAvailable(".Length);
            var splitted = result.Split(',');
            if (splitted.Length == 2)
            {
                if (int.TryParse(splitted[0], out int charID))
                {
                    cmbCharacters.SelectedIndexChanged -= cmbCharacters_SelectedIndexChanged;

                    for (int i = 0; i < chars.Count(); i++)
                    {
                        if (chars.ElementAt(i).ID == charID)
                        {
                            cmbCharacters.SelectedIndex = i;
                            break;
                        }
                    }

                    var vendor = chars.ElementAt(cmbCharacters.SelectedIndex);
                    cmbVendorItems.Items.Clear();
                    foreach (var vi in vendor.VendorItems)
                    {
                        var i = Globals.Items.Find((it) => it.ID == vi.ItemID);
                        cmbVendorItems.Items.Add(i.Name);
                    }

                    cmbCharacters.SelectedIndexChanged -= cmbCharacters_SelectedIndexChanged;
                }

                if (int.TryParse(splitted[1], out int item))
                {
                    cmbVendorItems.SelectedIndex = item;
                }
            }
        }

        public UserControl GetControl()
        {
            return this;
        }

        public string GetErrorMessage()
        {
            if (cmbCharacters.SelectedIndex == -1)
                return "You must select a character.";

            if (cmbVendorItems.SelectedIndex == -1)
                return "You must select an item.";

            return "";
        }

        public bool IsValid()
        {
            return cmbCharacters.SelectedIndex > -1 && cmbVendorItems.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("IsItemAvailable({0}, {1})", chars.ElementAt(cmbCharacters.SelectedIndex).ID, cmbVendorItems.SelectedIndex);
        }

        private void cmbCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCharacters.SelectedIndex > -1)
            {
                var vendor = chars.ElementAt(cmbCharacters.SelectedIndex);
                cmbVendorItems.Items.Clear();
                foreach (var vi in vendor.VendorItems)
                {
                    var i = Globals.Items.Find((it) => it.ID == vi.ItemID);
                    cmbVendorItems.Items.Add(i.Name);
                }
            }
        }

        private void btnBrowseCharacters_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Character>("", chars.ToList());
            search.SearchSelected += (int index) => cmbCharacters.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

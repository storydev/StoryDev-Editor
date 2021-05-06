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
    partial class OpenVendor : UserControl, ICodeComponent
    {

        private IEnumerable<Character> chars;

        public OpenVendor()
        {
            InitializeComponent();

            chars = Globals.Characters.Where((c) => c.IsVendor);
            foreach (var character in chars)
            {
                cmbCharacters.Items.Add(character.FirstName);
                cmbCharacters.AutoCompleteCustomSource.Add(character.FirstName);
            }
        }

        public bool IsConditional => false;

        public void FromCodeString(string code)
        {
            var result = code.Substring("OpenVendor(".Length, code.LastIndexOf(')') - "OpenVendor(".Length);
            if (int.TryParse(result, out int charID))
            {
                for (int i = 0; i < chars.Count(); i++)
                {
                    if (chars.ElementAt(i).ID == charID)
                    {
                        cmbCharacters.SelectedIndex = i;
                        break;
                    }
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

            return "";
        }

        public bool IsValid()
        {
            return cmbCharacters.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("OpenVendor({0})", chars.ElementAt(cmbCharacters.SelectedIndex).ID);
        }

        private void btnBrowseCharacters_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Character>(custom: chars.ToList());
            search.SearchSelected += (int index) => cmbCharacters.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

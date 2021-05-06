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
    partial class HasFrequencyWithGroup : UserControl, ICodeComponent
    {

        private IEnumerable<Character> chars;

        public HasFrequencyWithGroup()
        {
            InitializeComponent();

            chars = Globals.Characters.Where((c) => !c.PlayerCharacter);
            foreach (var character in chars)
            {
                cmbCharacters.Items.Add(character.FirstName + " " + character.LastName);
                cmbCharacters.AutoCompleteCustomSource.Add(character.FirstName + " " + character.LastName);
            }


        }

        public bool IsConditional => true;

        public void FromCodeString(string code)
        {
            var result = code.Substring("HasFrequencyWithGroup(".Length, code.LastIndexOf(')') - "HasFrequencyWithGroup(".Length);
            var splitted = result.Split(',');
            if (splitted.Length == 2)
            {
                if (int.TryParse(splitted[0], out int charID))
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

                if (decimal.TryParse(splitted[1], out decimal frequency))
                {
                    nudFrequency.Value = frequency;
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
                return "You must select a character";

            if (nudFrequency.Value == 0.00m)
                return "You must choose a frequency value greater than zero.";

            return "";
        }

        public bool IsValid()
        {
            return cmbCharacters.SelectedIndex > -1 && nudFrequency.Value > 0.00m;
        }

        public string ToCodeString()
        {
            return string.Format("HasFrequencyWithGroup({0}, {1})", chars.ElementAt(cmbCharacters.SelectedIndex).ID, nudFrequency.Value);
        }

        private void btnBrowseCharacters_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Character>(string.Empty, chars.ToList());
            search.SearchSelected += (int index) => cmbCharacters.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

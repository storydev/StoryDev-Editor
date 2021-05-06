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

namespace StoryDev.Components.CodeUI
{
    partial class AdjustCharacterAttitude : UserControl, ICodeComponent
    {

        private IEnumerable<Character> chars;

        public AdjustCharacterAttitude()
        {
            InitializeComponent();

            chars = Globals.Characters.Where((c) => c.PlayerCharacter);
            foreach (var character in chars)
            {
                cmbCharacters.Items.Add(character.FirstName);
            }
        }

        public bool IsConditional => false;

        public void FromCodeString(string code)
        {
            var result = code.Substring("AdjustCharacterAttitude(".Length, code.LastIndexOf(')') - "AdjustCharacterAttitude(".Length);
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

                if (int.TryParse(splitted[1], out int attitude))
                {
                    nudValue.Value = attitude;
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

            if (nudValue.Value == 0.00m)
                return "You must enter a value less or greater than zero.";

            return "";
        }

        public bool IsValid()
        {
            return cmbCharacters.SelectedIndex > -1 && (nudValue.Value > 0.00m || nudValue.Value < 0.00m);
        }

        public string ToCodeString()
        {
            return string.Format("AdjustCharacterAttitude({0}, {1})", chars.ElementAt(cmbCharacters.SelectedIndex).ID, nudValue.Value);
        }
    }
}

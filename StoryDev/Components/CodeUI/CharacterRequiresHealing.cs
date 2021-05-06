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
    partial class CharacterRequiresHealing : UserControl, ICodeComponent
    {
        private IEnumerable<Character> chars;

        public CharacterRequiresHealing()
        {
            InitializeComponent();

            chars = Globals.Characters.Where((c) => c.PlayerCharacter);
            foreach (var ch in chars)
            {
                cmbCharacters.Items.Add(ch.FirstName);
            }
        }

        public bool IsConditional => true;

        public void FromCodeString(string code)
        {
            var result = code.Substring("CharacterRequiresHealing(".Length, code.LastIndexOf(')') - "CharacterRequiresHealing(".Length);
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
            return string.Format("CharacterRequiresHealing({0})", chars.ElementAt(cmbCharacters.SelectedIndex).ID);
        }
    }
}

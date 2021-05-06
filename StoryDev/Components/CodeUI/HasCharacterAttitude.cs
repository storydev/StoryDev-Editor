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
    partial class HasCharacterAttitude : UserControl, ICodeComponent
    {

        private IEnumerable<Character> chars;

        public HasCharacterAttitude()
        {
            InitializeComponent();

            chars = Globals.Characters.Where((c) => c.PlayerCharacter);
            foreach (var c in chars)
            {
                cmbCharacters.Items.Add(c.FirstName);
            }

            foreach (var attitude in Globals.Attitudes)
            {
                cmbAttitude.Items.Add(attitude);
            }
        }

        public bool IsConditional { get => true; }

        public void FromCodeString(string code)
        {
            var result = code.Substring("HasCharacterAttitude(".Length, code.LastIndexOf(')') - "HasCharacterAttitude(".Length);
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
                    cmbAttitude.SelectedIndex = Globals.GetAttitudeIndexByValue(attitude);
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

            if (cmbAttitude.SelectedIndex == -1)
                return "You must select an attitude";

            return "";
        }

        public bool IsValid()
        {
            return cmbAttitude.SelectedIndex > -1 && cmbCharacters.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("HasCharacterAttitude({0}, {1})", chars.ElementAt(cmbCharacters.SelectedIndex).ID, Globals.ResolveAttitudeIndex(cmbAttitude.SelectedIndex));
        }
    }
}

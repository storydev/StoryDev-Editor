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
    partial class SetCharacterAttitudeTowards : UserControl, ICodeComponent
    {
        private IEnumerable<Character> chars;

        public SetCharacterAttitudeTowards()
        {
            InitializeComponent();

            chars = Globals.Characters.Where((c) => c.PlayerCharacter);
            foreach (var character in chars)
            {
                cmbCharacters.Items.Add(character.FirstName);
                cmbTowards.Items.Add(character.FirstName);
            }

            foreach (var attitude in Globals.Attitudes)
            {
                cmbAttitude.Items.Add(attitude);
            }
        }

        public bool IsConditional => false;

        public void FromCodeString(string code)
        {
            var result = code.Substring("SetCharacterAttitudeTowards(".Length, code.LastIndexOf(')') - "SetCharacterAttitudeTowards(".Length);
            var splitted = result.Split(',');
            if (splitted.Length == 3)
            {
                int charID;
                bool allowChar;
                allowChar = int.TryParse(splitted[0], out charID);

                int towards;
                bool allowTowards;
                allowTowards = int.TryParse(splitted[1], out towards);


                for (int i = 0; i < chars.Count(); i++)
                {
                    if (chars.ElementAt(i).ID == charID)
                    {
                        if (allowChar)
                            cmbCharacters.SelectedIndex = i;
                    }

                    if (chars.ElementAt(i).ID == towards)
                    {
                        if (allowTowards)
                            cmbTowards.SelectedIndex = i;
                    }
                }

                if (int.TryParse(splitted[2], out int attitude))
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

            if (cmbTowards.SelectedIndex == -1)
                return "You must select a character towards.";

            if (cmbAttitude.SelectedIndex == -1)
                return "You must select an attitude";

            return "";
        }

        public bool IsValid()
        {
            return cmbCharacters.SelectedIndex > -1 && cmbTowards.SelectedIndex > -1 && cmbAttitude.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("SetCharacterAttitudeTowards({0}, {1}, {2})", chars.ElementAt(cmbCharacters.SelectedIndex).ID, chars.ElementAt(cmbTowards.SelectedIndex).ID, Globals.ResolveAttitudeIndex(cmbAttitude.SelectedIndex));
        }
    }
}

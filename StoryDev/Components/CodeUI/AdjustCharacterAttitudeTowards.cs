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
    partial class AdjustCharacterAttitudeTowards : UserControl, ICodeComponent
    {

        private IEnumerable<Character> chars;

        public AdjustCharacterAttitudeTowards()
        {
            InitializeComponent();

            chars = Globals.Characters.Where((c) => c.PlayerCharacter);
            foreach (var character in chars)
            {
                cmbCharacters.Items.Add(character.FirstName);
                cmbTowards.Items.Add(character.FirstName);
            }
        }

        public bool IsConditional => false;

        public void FromCodeString(string code)
        {
            var result = code.Substring("AdjustCharacterAttitudeTowards(".Length, code.LastIndexOf(')') - "AdjustCharacterAttitudeTowards(".Length);
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

                if (decimal.TryParse(splitted[2], out decimal attitude))
                {
                    nudAttitude.Value = attitude;
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

            return "";
        }

        public bool IsValid()
        {
            return cmbCharacters.SelectedIndex > -1 && cmbTowards.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("AdjustCharacterAttitudeTowards({0}, {1}, {2})", chars.ElementAt(cmbCharacters.SelectedIndex).ID, chars.ElementAt(cmbTowards.SelectedIndex).ID, nudAttitude.Value);
        }
    }
}

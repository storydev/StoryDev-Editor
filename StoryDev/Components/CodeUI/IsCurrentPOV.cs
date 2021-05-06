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
    partial class IsCurrentPOV : UserControl, ICodeComponent
    {

        private IEnumerable<Character> chars;

        public IsCurrentPOV()
        {
            InitializeComponent();

            chars = Globals.Characters.Where((c) => c.PlayerCharacter);
            foreach (var character in chars)
            {
                cmbCharacters.Items.Add(character.FirstName);
            }
        }

        public bool IsConditional => true;

        public void FromCodeString(string code)
        {
            var result = code.Substring("IsCurrentPOV(".Length, code.LastIndexOf(')') - "IsCurrentPOV(".Length);
            if (int.TryParse(result, out int id))
            {
                for (int i = 0; i < chars.Count(); i++)
                {
                    if (chars.ElementAt(i).ID == id)
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
            return string.Format("IsCurrentPOV({0})", chars.ElementAt(cmbCharacters.SelectedIndex).ID);
        }
    }
}

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
    partial class HasCharacterTraitProgress : UserControl, ICodeComponent
    {
        public HasCharacterTraitProgress()
        {
            InitializeComponent();

            foreach (var trait in Globals.Traits)
            {
                cmbTraits.Items.Add(trait.Name);
                cmbTraits.AutoCompleteCustomSource.Add(trait.Name);
            }
        }

        public bool IsConditional => true;

        public void FromCodeString(string code)
        {
            var result = code.Substring("HasCharacterTraitProgress(".Length, code.LastIndexOf(')') - "HasCharacterTraitProgress(".Length);
            var splitted = result.Split(',');
            if (splitted.Length == 2)
            {
                if (int.TryParse(splitted[0], out int traitID))
                {
                    cmbTraits.SelectedIndex = Globals.Traits.FindIndex((t) => t.ID == traitID);
                }

                if (decimal.TryParse(splitted[1], out decimal progress))
                {
                    nudValue.Value = progress;
                }
            }
        }

        public UserControl GetControl()
        {
            return this;
        }

        public string GetErrorMessage()
        {
            if (cmbTraits.SelectedIndex == -1)
                return "You must select a trait.";

            if (nudValue.Value == 0m)
                return "Progress value must be above zero.";

            return "";
        }

        public bool IsValid()
        {
            return cmbTraits.SelectedIndex > -1 && nudValue.Value > 0m;
        }

        public string ToCodeString()
        {
            return string.Format("HasCharacterTraitProgress({0}, {1})", Globals.Traits[cmbTraits.SelectedIndex].ID, nudValue.Value);
        }

        private void btnBrowseTraits_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<CharacterTrait>("Traits");
            search.SearchSelected += (int index) => cmbTraits.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

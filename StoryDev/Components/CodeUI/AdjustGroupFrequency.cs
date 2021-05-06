using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components.CodeUI
{
    partial class AdjustGroupFrequency : UserControl, ICodeComponent
    {
        public AdjustGroupFrequency()
        {
            InitializeComponent();

            foreach (var group in Globals.CharacterGroups)
            {
                cmbGroups.Items.Add(group.Name);
                cmbGroups.AutoCompleteCustomSource.Add(group.Name);
            }
        }

        public bool IsConditional => false;

        public void FromCodeString(string code)
        {
            var result = code.Substring("AdjustGroupFrequency(".Length, code.LastIndexOf(')') - "AdjustGroupFrequency(".Length);
            var splitted = result.Split(',');
            if (splitted.Length == 2)
            {
                if (int.TryParse(splitted[0], out int groupID))
                {
                    cmbGroups.SelectedIndex = Globals.CharacterGroups.FindIndex((g) => g.ID == groupID);
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
            if (cmbGroups.SelectedIndex == -1)
                return "You must select a group.";

            if (nudFrequency.Value == 0.00m)
                return "You must have a frequency value greater than zero.";

            return "";
        }

        public bool IsValid()
        {
            return cmbGroups.SelectedIndex > -1 && nudFrequency.Value > 0.00m;
        }

        public string ToCodeString()
        {
            return string.Format("AdjustGroupFrequency({0}, {1})", Globals.CharacterGroups[cmbGroups.SelectedIndex].ID, nudFrequency.Value);
        }
    }
}

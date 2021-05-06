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

namespace StoryDev.Components
{
    public partial class CharacterGroupUI : UserControl
    {

        private int selectedGroup;

        public CharacterGroupUI()
        {
            InitializeComponent();

            PopulateGroups();
        }

        private void PopulateGroups()
        {
            lbResults.SelectedIndexChanged -= lbResults_SelectedIndexChanged;

            var temp = lbResults.SelectedIndex;
            lbResults.Items.Clear();
            foreach (var group in Globals.CharacterGroups)
            {
                lbResults.Items.Add(group.Name);
            }

            if (temp < lbResults.Items.Count)
                selectedGroup = lbResults.SelectedIndex = temp;

            lbResults.SelectedIndexChanged += lbResults_SelectedIndexChanged;
        }
        
        private void PopulateFields()
        {
            if (selectedGroup > -1)
            {
                var group = Globals.CharacterGroups[selectedGroup];

                txtName.Text = group.Name;
                nudFrequencyRate.Value = (decimal)group.DefaultFrequencyRate;
                nudInitialFrequency.Value = (decimal)group.InitialFrequency;
            }
        }
        
        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbResults.SelectedIndex > -1)
            {
                selectedGroup = lbResults.SelectedIndex;
                pnlContent.Enabled = true;

                PopulateFields();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var grp = new CharacterGroup();
            grp.ID = ++Globals.GlobalIdentifiers.CharacterGroupID;
            Globals.SaveIdentifiers();
            Globals.CharacterGroups.Add(grp);

            PopulateGroups();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (selectedGroup > -1)
            {
                Globals.CharacterGroups[selectedGroup].Name = txtName.Text;
                lbResults.Items[selectedGroup] = txtName.Text;
            }
        }

        private void nudFrequencyRate_ValueChanged(object sender, EventArgs e)
        {
            if (selectedGroup > -1)
            {
                Globals.CharacterGroups[selectedGroup].DefaultFrequencyRate = (float)nudFrequencyRate.Value;
            }
        }

        private void nudInitialFrequency_ValueChanged(object sender, EventArgs e)
        {
            if (selectedGroup > -1)
            {
                Globals.CharacterGroups[selectedGroup].InitialFrequency = (float)nudInitialFrequency.Value;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Globals.SaveCharacterGroups();
        }
    }
}

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

namespace StoryDev.Forms
{
    partial class EditAttitudeForm : Form
    {

        private CharacterAttitude attitude;
        private int editingIndex;

        public CharacterAttitude Attitude
        {
            get { return attitude; }
        }

        public int IsEditing
        { 
            get { return editingIndex; }
        }

        public EditAttitudeForm(CharacterAttitude attitude = null, int editIndex = 0)
        {
            InitializeComponent();

            foreach (var character in Globals.Characters)
            {
                cmbTowardsCharacter.AutoCompleteCustomSource.Add(character.FirstName);
                cmbTowardsCharacter.Items.Add(character.FirstName);
            }

            if (attitude != null)
            {
                editingIndex = editIndex;
                this.attitude = attitude;
                PopulateFields();
            }
            else
            {
                this.attitude = new CharacterAttitude();
            }
        }

        private void PopulateFields()
        {
            cmbTowardsCharacter.SelectedIndexChanged -= cmbTowardsCharacter_SelectedIndexChanged;
            cmbInitialAttitude.SelectedIndexChanged -= cmbInitialAttitude_SelectedIndexChanged;
            cmbRealAttitude.SelectedIndexChanged -= cmbRealAttitude_SelectedIndexChanged;

            cmbTowardsCharacter.SelectedIndex = Globals.GetCharacterIndex(attitude.TowardsCharacter);
            cmbInitialAttitude.SelectedIndex = Globals.GetAttitudeIndexByValue(attitude.Attitude);
            cmbRealAttitude.SelectedIndex = Globals.GetAttitudeIndexByValue(attitude.RealAttitude);

            cmbTowardsCharacter.SelectedIndexChanged += cmbTowardsCharacter_SelectedIndexChanged;
            cmbInitialAttitude.SelectedIndexChanged += cmbInitialAttitude_SelectedIndexChanged;
            cmbRealAttitude.SelectedIndexChanged += cmbRealAttitude_SelectedIndexChanged;
        }

        private void cmbTowardsCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTowardsCharacter.SelectedIndex > -1)
            {
                attitude.TowardsCharacter = Globals.Characters[cmbTowardsCharacter.SelectedIndex].ID;
            }
        }

        private void cmbInitialAttitude_SelectedIndexChanged(object sender, EventArgs e)
        {
            attitude.Attitude = Globals.ResolveAttitudeIndex(cmbInitialAttitude.SelectedIndex);
        }

        private void cmbRealAttitude_SelectedIndexChanged(object sender, EventArgs e)
        {
            attitude.RealAttitude = Globals.ResolveAttitudeIndex(cmbRealAttitude.SelectedIndex);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

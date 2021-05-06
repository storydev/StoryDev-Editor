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
    partial class EditCharacterTraitForm : Form
    {

        private CharacterTrait trait;
        private int editingIndex;

        public CharacterTrait Trait
        {
            get { return trait; }
        }

        public int EditingIndex
        { 
            get { return editingIndex; }
        }

        public EditCharacterTraitForm(int characterId, CharacterTrait trait = null, int editingIndex = -1)
        {
            InitializeComponent();

            if (trait != null)
            {
                this.trait = trait;
                this.editingIndex = editingIndex;
                PopulateFields();
            }
            else
            {
                this.trait = new CharacterTrait();
                this.trait.ID = ++Globals.GlobalIdentifiers.CharacterTraitID;
                Globals.SaveIdentifiers();
                this.trait.CharacterID = characterId;
            }
        }

        private void PopulateFields()
        {
            txtName.Text = trait.Name;
            txtDescription.Text = trait.Description;
            nudInitialValue.Value = trait.InitialValue;
            nudMaxValue.Value = trait.MaxValue;
            cmbPriority.SelectedIndex = trait.CharacterPriority;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            trait.Name = txtName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            trait.Description = txtDescription.Text;
        }

        private void nudInitialValue_ValueChanged(object sender, EventArgs e)
        {
            trait.InitialValue = (int)nudInitialValue.Value;
        }

        private void nudMaxValue_ValueChanged(object sender, EventArgs e)
        {
            trait.MaxValue = (int)nudMaxValue.Value;
        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            trait.CharacterPriority = cmbPriority.SelectedIndex;
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

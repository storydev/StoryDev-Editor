using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cyotek.Windows.Forms;

using StoryDev.Data;
using StoryDev.Forms;

namespace StoryDev.Components
{
    partial class CharacterUI : UserControl
    {

        private List<CharacterTrait> traits;

        private int selectedCharacter;

        public CharacterUI()
        {
            InitializeComponent();
            
            foreach (var group in Globals.CharacterGroups)
            {
                cmbCharacterGroup.Items.Add(group.Name);
            }

            PopulateCharacters();
        }

        private void PopulateCharacters()
        {
            lbResults.SelectedIndexChanged -= lbResults_SelectedIndexChanged;

            var temp = lbResults.SelectedIndex;
            lbResults.Items.Clear();
            foreach (var character in Globals.Characters)
            {
                lbResults.Items.Add(character.FirstName);
            }

            if (temp < lbResults.Items.Count)
                selectedCharacter = lbResults.SelectedIndex = temp;

            lbResults.SelectedIndexChanged += lbResults_SelectedIndexChanged;
        }

        private void PopulateFields()
        {
            var character = Globals.Characters[selectedCharacter];

            txtFirstName.Text = character.FirstName;
            txtLastName.Text = character.LastName;

            btnDialogueColor.BackColor = Color.FromArgb(character.ColorRed, character.ColorGreen, character.ColorBlue);
            chbIsPlayerCharacter.Checked = character.PlayerCharacter;

            txtDescription.Text = character.Description;
            txtAppearance.Text = character.Appearance;

            cmbInitialAttitude.SelectedIndex = character.Attitude;
            cmbCharacterGroup.SelectedIndex = Globals.CharacterGroups.FindIndex((cg) => cg.ID == character.GroupID);

            chbIsVendor.Checked = character.IsVendor;

            PopulateAttitudes();
            PopulateTraits();
            PopulateVendorItems();
        }

        private void PopulateAttitudes()
        {
            var character = Globals.Characters[selectedCharacter];

            lvAttitudes.Items.Clear();
            foreach (var attitude in character.Attitudes)
            {
                var item = new ListViewItem();
                item.Text = Globals.GetCharacter(attitude.TowardsCharacter).FirstName;
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = Globals.GetAttitudeName(attitude.Attitude)
                });

                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = Globals.GetAttitudeName(attitude.RealAttitude)
                });

                lvAttitudes.Items.Add(item);
            }

        }
        
        private void PopulateTraits()
        {
            var character = Globals.Characters[selectedCharacter];

            traits = Globals.GetTraits(character.ID);

            lvTraits.Items.Clear();
            foreach (var trait in traits)
            {
                var item = new ListViewItem();
                item.Text = trait.Name;
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = "" + trait.InitialValue
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = "" + trait.MaxValue
                });

                lvTraits.Items.Add(item);
            }
        }

        private void PopulateVendorItems()
        {
            var character = Globals.Characters[selectedCharacter];

            lvItems.Items.Clear();
            foreach (var vendor in character.VendorItems)
            {
                var item = new ListViewItem();
                item.Text = Globals.GetItem(vendor.ItemID).Name;
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = "" + vendor.Quantity
                });

                lvItems.Items.Add(item);
            }
        }

        private void cmsListOptions_Opening(object sender, CancelEventArgs e)
        {
            var casted = (ListView)cmsListOptions.SourceControl;
            if (casted.SelectedIndices.Count > 0)
            {
                editToolStripMenuItem.Enabled = true;
                removeToolStripMenuItem.Enabled = true;
            }
            else
            {
                editToolStripMenuItem.Enabled = true;
                removeToolStripMenuItem.Enabled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var character = new Character();
            character.ID = ++Globals.GlobalIdentifiers.CharacterID;
            Globals.SaveIdentifiers();
            Globals.Characters.Add(character);

            PopulateCharacters();
        }

        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbResults.SelectedIndex > -1)
            {
                selectedCharacter = lbResults.SelectedIndex;
                pnlContent.Enabled = true;

                PopulateFields();
            }
        }

        private void chbIsPlayerCharacter_CheckedChanged(object sender, EventArgs e)
        {
            pnlNPCInfo.Visible = !chbIsPlayerCharacter.Checked;
            pnlPlayerData.Visible = chbIsPlayerCharacter.Checked;

            if (selectedCharacter > -1)
            {
                Globals.Characters[selectedCharacter].PlayerCharacter = chbIsPlayerCharacter.Checked;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Globals.SaveCharacters();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (selectedCharacter > -1)
            {
                Globals.Characters[selectedCharacter].FirstName = txtFirstName.Text;
                lbResults.Items[selectedCharacter] = txtFirstName.Text;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (selectedCharacter > -1)
            {
                Globals.Characters[selectedCharacter].LastName = txtLastName.Text;
            }
        }

        private void btnDialogueColor_Click(object sender, EventArgs e)
        {
            if (selectedCharacter > -1)
            {
                var character = Globals.Characters[selectedCharacter];

                var picker = new ColorPickerDialog();
                picker.Color = Color.FromArgb(character.ColorRed, character.ColorGreen, character.ColorBlue);
                if (picker.ShowDialog() == DialogResult.OK)
                {
                    character.ColorRed = picker.Color.R;
                    character.ColorGreen = picker.Color.G;
                    character.ColorBlue = picker.Color.B;

                    btnDialogueColor.BackColor = Color.FromArgb(character.ColorRed, character.ColorGreen, character.ColorBlue);
                }
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (selectedCharacter > -1)
            {
                Globals.Characters[selectedCharacter].Description = txtDescription.Text;
            }
        }

        private void txtAppearance_TextChanged(object sender, EventArgs e)
        {
            if (selectedCharacter > -1)
            {
                Globals.Characters[selectedCharacter].Appearance = txtAppearance.Text;
            }
        }

        private void cmbInitialAttitude_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedCharacter > -1)
            {
                Globals.Characters[selectedCharacter].Attitude = cmbInitialAttitude.SelectedIndex;
            }
        }

        private void cmbCharacterGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedCharacter > -1)
            {
                Globals.Characters[selectedCharacter].GroupID = Globals.CharacterGroups[cmbCharacterGroup.SelectedIndex].ID;
            }
        }

        private void chbIsVendor_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedCharacter > -1)
            {
                Globals.Characters[selectedCharacter].IsVendor = chbIsVendor.Checked;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedCharacter > -1)
            {
                var casted = (ListView)cmsListOptions.SourceControl;
                if (casted == lvAttitudes)
                {
                    var createAttitude = new EditAttitudeForm();
                    if (createAttitude.ShowDialog() == DialogResult.OK)
                    {
                        Globals.Characters[selectedCharacter].Attitudes.Add(createAttitude.Attitude);
                        PopulateAttitudes();
                    }
                }
                else if (casted == lvTraits)
                {
                    var createTrait = new EditCharacterTraitForm(Globals.Characters[selectedCharacter].ID);
                    if (createTrait.ShowDialog() == DialogResult.OK)
                    {
                        Globals.Characters[selectedCharacter].Traits.Add(createTrait.Trait.ID);
                        Globals.Traits.Add(createTrait.Trait);
                        Globals.SaveTraits();
                        PopulateTraits();
                    }
                }
                else if (casted == lvItems)
                {
                    var vendor = new VendorItem();
                    if (new VendorItemForm(vendor).ShowDialog() == DialogResult.OK)
                    {
                        Globals.Characters[selectedCharacter].VendorItems.Add(vendor);
                        Globals.SaveCharacters();
                        PopulateVendorItems();
                    }
                }    
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedCharacter > -1)
            {
                var casted = (ListView)cmsListOptions.SourceControl;
                if (casted == lvAttitudes)
                {
                    if (lvAttitudes.SelectedIndices.Count > 0)
                    {
                        var edit = lvAttitudes.SelectedIndices[0];
                        var attitude = Globals.Characters[selectedCharacter].Attitudes[edit];

                        var createAttitude = new EditAttitudeForm(attitude, edit);
                        if (createAttitude.ShowDialog() == DialogResult.OK)
                        {
                            Globals.Characters[selectedCharacter].Attitudes[edit] = createAttitude.Attitude;
                            PopulateAttitudes();
                        }
                    }
                }
                else if (casted == lvTraits)
                {
                    if (lvTraits.SelectedIndices.Count > 0)
                    {
                        var edit = lvTraits.SelectedIndices[0];
                        var trait = traits[edit];

                        var createTrait = new EditCharacterTraitForm(Globals.Characters[selectedCharacter].ID, trait, edit);
                        if (createTrait.ShowDialog() == DialogResult.OK)
                        {
                            Globals.Traits[Globals.GetTraitIndex(createTrait.Trait.ID)] = createTrait.Trait;
                            PopulateTraits();
                        }
                    }
                }
                else if (casted == lvItems)
                {
                    if (lvItems.SelectedIndices.Count > 0)
                    {
                        var edit = lvItems.SelectedIndices[0];
                        var vendor = Globals.Characters[selectedCharacter].VendorItems[edit];
                        if (new VendorItemForm(vendor).ShowDialog() == DialogResult.OK)
                        {
                            PopulateVendorItems();
                        }
                    }
                }
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedCharacter > -1)
            {
                var casted = (ListView)cmsListOptions.SourceControl;
                if (casted == lvAttitudes)
                {
                    if (lvAttitudes.SelectedIndices.Count > 0)
                    {
                        var removeIndex = lvAttitudes.SelectedIndices[0];
                        Globals.Characters[selectedCharacter].Attitudes.RemoveAt(removeIndex);
                        lvAttitudes.Items.RemoveAt(removeIndex);
                    }
                }
                else if (casted == lvTraits)
                {
                    if (lvTraits.SelectedIndices.Count > 0)
                    {
                        var removeIndex = lvAttitudes.SelectedIndices[0];
                        var trait = traits[removeIndex];
                        var t = Globals.GetTraitIndex(trait.ID);
                        Globals.Traits.RemoveAt(t);
                        traits.RemoveAt(removeIndex);
                    }
                }
                else if (casted == lvItems)
                {
                    if (lvItems.SelectedIndices.Count > 0)
                    {
                        var removeIndex = lvItems.SelectedIndices[0];
                        Globals.Characters[selectedCharacter].VendorItems.RemoveAt(removeIndex);
                        lvItems.Items.RemoveAt(removeIndex);
                    }
                }
            }
        }

        private void btnRefreshGroups_Click(object sender, EventArgs e)
        {
            cmbCharacterGroup.SelectedIndexChanged -= cmbCharacterGroup_SelectedIndexChanged;

            var temp = cmbCharacterGroup.SelectedIndex;

            cmbCharacterGroup.Items.Clear();

            foreach (var group in Globals.CharacterGroups)
            {
                cmbCharacterGroup.Items.Add(group.Name);
            }

            if (temp < Globals.CharacterGroups.Count)
                cmbCharacterGroup.SelectedIndex = temp;

            cmbCharacterGroup.SelectedIndexChanged += cmbCharacterGroup_SelectedIndexChanged;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Character>("Characters");
            search.SearchSelected += (int index) => lbResults.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

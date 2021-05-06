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
    partial class EditSectionForm : Form
    {

        private MapSection section;
        private IEnumerable<MapSection> placeSections;

        public EditSectionForm(MapSection section)
        {
            InitializeComponent();

            this.section = section;

            foreach (var place in Globals.Places)
            {
                cmbEnteredFromPlace.Items.Add(place.Name);
                cmbEnteredFromPlace.AutoCompleteCustomSource.Add(place.Name);
            }

            PopulateFields();
        }

        private void PopulateFields()
        {
            txtName.Text = section.Name;
            txtDescription.Text = section.Description;
            chbVisibleToPlayer.Checked = section.VisibleToPlayer;
            cmbConnectionAvailable.SelectedIndex = section.ConnectionAvailability;

            cmbEnteredFromPlace.SelectedIndexChanged -= cmbEnteredFromPlace_SelectedIndexChanged;

            if (section.PlaceID > -1)
            {
                cmbEnteredFromPlace.SelectedIndex = Globals.Places.FindIndex((p) => p.ID == section.PlaceID);

                var place = Globals.Places[cmbEnteredFromPlace.SelectedIndex].ID;
                placeSections = Globals.Sections.Where((s) => s.PlaceID == place);
                cmbEnteredFromSection.Items.Clear();
                foreach (var section in placeSections)
                {
                    cmbEnteredFromSection.Items.Add(section.Name);
                }

                section.EnteredFromPlace = place;

                for (int i = 0; i < placeSections.Count(); i++)
                {
                    if (placeSections.ElementAt(i).ID == section.EnteredFromSection)
                    {
                        cmbEnteredFromSection.SelectedIndex = i;
                        break;
                    }
                }
            }

            cmbEnteredFromPlace.SelectedIndexChanged += cmbEnteredFromPlace_SelectedIndexChanged;


            PopulateGossips();
        }

        private void PopulateGossips()
        {
            lvGossips.Items.Clear();
            foreach (var id in section.CharacterGossips)
            {
                var gossip = Globals.Gossips.Find((g) => g.ID == id);

                var item = new ListViewItem();
                item.Text = Globals.GetCharacter(gossip.CharacterID).FirstName;
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = "" + gossip.DisplayOption.Count
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = gossip.Visible.ToString()
                });

                lvGossips.Items.Add(item);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gossip = new CharacterGossip();
            gossip.ID = ++Globals.GlobalIdentifiers.CharacterGossipID;
            Globals.SaveIdentifiers();
            gossip.SectionID = section.ID;

            var editGossip = new EditGossipsForm(gossip);
            if (editGossip.ShowDialog() == DialogResult.OK)
            {
                var character = Globals.Characters.Find((c) => c.ID == gossip.CharacterID);
                gossip.Name = section.Name + ": " + character.FirstName;

                Globals.Gossips.Add(gossip);
                Globals.SaveGossips();
                section.CharacterGossips.Add(gossip.ID);

                PopulateGossips();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvGossips.SelectedIndices.Count > 0)
            {
                var index = lvGossips.SelectedIndices[0];
                var gIndex = section.CharacterGossips[index];
                var gossip = Globals.Gossips.Find((g) => g.ID == gIndex);
                var editGossip = new EditGossipsForm(gossip);
                if (editGossip.ShowDialog() == DialogResult.OK)
                {
                    var character = Globals.Characters.Find((c) => c.ID == gossip.CharacterID);
                    gossip.Name = section.Name + ": " + character.FirstName;

                    Globals.SaveGossips();
                    PopulateGossips();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvGossips.SelectedIndices.Count > 0)
            {
                var response = MessageBox.Show("Are you sure you wish to delete this Gossip Option?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes)
                {
                    var index = lvGossips.SelectedIndices[0];
                    var rIndex = Globals.Gossips.FindIndex((g) => g.ID == section.CharacterGossips[index]);

                    section.CharacterGossips.RemoveAt(index);
                    Globals.Gossips.RemoveAt(rIndex);
                    Globals.SaveGossips();

                    PopulateGossips();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            section.Name = txtName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            section.Description = txtDescription.Text;
        }

        private void chbVisibleToPlayer_CheckedChanged(object sender, EventArgs e)
        {
            section.VisibleToPlayer = chbVisibleToPlayer.Checked;
        }

        private void cmbConnectionAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            section.ConnectionAvailability = cmbConnectionAvailable.SelectedIndex;

            if (cmbConnectionAvailable.SelectedIndex == 0)
            {
                lblInfo.Text = "Connection is always available.";
            }
            else if (cmbConnectionAvailable.SelectedIndex == 1)
            {
                lblInfo.Text = "This section becomes available to select when the player has entered this place of interest.";
            }
            else if (cmbConnectionAvailable.SelectedIndex == 2)
            {
                lblInfo.Text = "This section becomes available once any and all sections marked as Always have had any scripted events fulfilled.";
            }
            else if (cmbConnectionAvailable.SelectedIndex == 3)
            {
                lblInfo.Text = "This section only becomes available when a script activates it.";
            }
        }

        private void cmbEnteredFromPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEnteredFromPlace.SelectedIndex > -1)
            {
                var place = Globals.Places[cmbEnteredFromPlace.SelectedIndex].ID;
                placeSections = Globals.Sections.Where((s) => s.PlaceID == place);
                cmbEnteredFromSection.Items.Clear();
                foreach (var section in placeSections)
                {
                    cmbEnteredFromSection.Items.Add(section.Name);
                }

                section.EnteredFromPlace = place;
            }
            else
            {
                cmbEnteredFromSection.Items.Clear();
                section.EnteredFromPlace = -1;
            }
        }

        private void btnBrowsePlaces_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Place>("Places");
            search.SearchSelected += (int index) => cmbEnteredFromPlace.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

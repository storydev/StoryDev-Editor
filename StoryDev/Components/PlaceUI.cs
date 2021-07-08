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

namespace StoryDev.Components
{
    partial class PlaceUI : UserControl
    {

        private int selectedPlace;
        private List<Activity> activities;
        private List<MapSection> sections;

        public PlaceUI()
        {
            InitializeComponent();

            PopulatePlaces();
        }

        private void PopulatePlaces()
        {
            lbResults.SelectedIndexChanged -= lbResults_SelectedIndexChanged;

            var temp = lbResults.SelectedIndex;
            lbResults.Items.Clear();
            foreach (var place in Globals.Places)
            {
                lbResults.Items.Add(place.Name);
            }

            lbResults.SelectedIndexChanged += lbResults_SelectedIndexChanged;
        }

        private void PopulateFields()
        {
            if (selectedPlace > -1)
            {
                var place = Globals.Places[selectedPlace];

                txtName.Text = place.Name;
                txtDescription.Text = place.Description;

                PopulateActivities();
                PopulateSections();
            }
        }

        private void PopulateActivities()
        {
            var place = Globals.Places[selectedPlace];

            activities = Globals.GetActivitiesByPlace(place.ID);

            lvActivities.Items.Clear();
            foreach (var activity in activities)
            {
                var item = new ListViewItem();
                item.Text = activity.Name;
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = Globals.Traits[Globals.GetTraitIndex(activity.CharacterTraitID)].Name
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = "" + activity.ProgressOnComplete
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = "" + activity.ProgressOnPart
                });

                lvActivities.Items.Add(item);
            }
        }

        private void PopulateSections()
        {
            var place = Globals.Places[selectedPlace];

            sections = Globals.GetSectionsByPlace(place.ID);

            lvSections.Items.Clear();
            foreach (var section in sections)
            {
                var item = new ListViewItem();
                item.Text = section.Name;
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = "" + section.CharacterGossips.Count
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = section.VisibleToPlayer.ToString()
                });

                lvSections.Items.Add(item);
            }
        }

        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPlace = lbResults.SelectedIndex;
            if (selectedPlace > -1)
            {
                pnlContent.Enabled = true;
                PopulateFields();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var place = new Place();
            place.ID = ++Globals.GlobalIdentifiers.PlaceID;
            Globals.SaveIdentifiers();

            Globals.Places.Add(place);
            PopulatePlaces();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbResults.SelectedIndex > -1)
            {
                var response = MessageBox.Show("Are you sure you wish to delete this place?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes)
                {
                    var temp = lbResults.SelectedIndex;
                    selectedPlace = lbResults.SelectedIndex = -1;
                    Globals.Places.RemoveAt(temp);
                    lbResults.Items.RemoveAt(temp);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Globals.SavePlaces();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedPlace > -1)
            {
                if (cmsEditItems.SourceControl == lvActivities)
                {
                    var activity = new Activity();
                    activity.ID = ++Globals.GlobalIdentifiers.ActivityID;
                    Globals.SaveIdentifiers();
                    activity.PlaceID = Globals.Places[selectedPlace].ID;

                    var editActivity = new EditActivityForm(activity);
                    if (editActivity.ShowDialog() == DialogResult.OK)
                    {
                        Globals.Activities.Add(activity);
                        Globals.SaveActivities();
                        Globals.Places[selectedPlace].Activities.Add(activity.ID);
                        Globals.SavePlaces();
                        PopulateActivities();
                    }
                }
                else if (cmsEditItems.SourceControl == lvSections)
                {
                    var section = new MapSection();
                    section.ID = ++Globals.GlobalIdentifiers.MapSectionID;
                    Globals.SaveIdentifiers();
                    section.PlaceID = Globals.Places[selectedPlace].ID;

                    var editSection = new EditSectionForm(section);
                    if (editSection.ShowDialog() == DialogResult.OK)
                    {
                        Globals.Sections.Add(section);
                        Globals.SaveSections();
                        Globals.Places[selectedPlace].Sections.Add(section.ID);
                        Globals.SavePlaces();
                        PopulateSections();
                    }
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedPlace > -1)
            {
                if (cmsEditItems.SourceControl == lvActivities)
                {
                    if (lvActivities.SelectedIndices.Count > 0)
                    {
                        var index = lvActivities.SelectedIndices[0];
                        var lActivity = activities[index];
                        var gActivity = Globals.Activities.Find(a => a.ID == lActivity.ID);
                        if (new EditActivityForm(gActivity).ShowDialog() == DialogResult.OK)
                        {
                            Globals.SaveActivities();
                            PopulateActivities();
                        }
                    }
                }
                else if (cmsEditItems.SourceControl == lvSections)
                {
                    if (lvSections.SelectedIndices.Count > 0)
                    {
                        var index = lvSections.SelectedIndices[0];
                        var lSection = sections[index];
                        var gSection = Globals.Sections.Find(s => s.ID == lSection.ID);
                        if (new EditSectionForm(gSection).ShowDialog() == DialogResult.OK)
                        {
                            Globals.SaveSections();
                            PopulateSections();
                        }
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmsEditItems.SourceControl == lvActivities)
            {
                if (lvActivities.SelectedIndices.Count > 0)
                {
                    var index = lvActivities.SelectedIndices[0];
                    var lActivity = activities[index];
                    var gIndex = Globals.Activities.FindIndex(a => a.ID == lActivity.ID);
                    Globals.Activities.RemoveAt(gIndex);
                    Globals.Places[selectedPlace].Activities.RemoveAt(index);
                    Globals.SaveActivities();
                    Globals.SavePlaces();
                    PopulateActivities();
                }
            }
            else if (cmsEditItems.SourceControl == lvSections)
            {
                if (lvSections.SelectedIndices.Count > 0)
                {
                    var index = lvSections.SelectedIndices[0];
                    var lSection = sections[index];
                    var gIndex = Globals.Sections.FindIndex(s => s.ID == lSection.ID);
                    Globals.Sections.RemoveAt(gIndex);
                    Globals.Places[selectedPlace].Sections.RemoveAt(index);
                    Globals.SaveSections();
                    Globals.SavePlaces();
                    PopulateSections();
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (selectedPlace > -1)
            {
                Globals.Places[selectedPlace].Name = txtName.Text;
                lbResults.Items[selectedPlace] = txtName.Text;
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (selectedPlace > -1)
            {
                Globals.Places[selectedPlace].Description = txtDescription.Text;
            }
        }

        private void lvActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvActivities.SelectedIndices.Count > 0)
            {
                editToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
        }

        private void lbResults_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Place>("Places");
            search.SearchSelected += (int index) => lbResults.SelectedIndex = index;
            search.ShowDialog();
        }

        private void lvSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSections.SelectedIndices.Count > 0)
            {
                editToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
        }
    }
}

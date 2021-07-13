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
    partial class MapPointPropertiesForm : Form
    {

        private int selectedMap = -1;
        private int selectedPoint = -1;

        private IEnumerable<MapSection> sections;
        private IEnumerable<ConvoMapLink> convoLinks;
        private IEnumerable<JournalMapLink> journalLinks;

        public MapPointPropertiesForm()
        {
            InitializeComponent();

            PopulatePlaces();
        }

        private void PopulatePlaces()
        {
            cmbPlaces.Items.Clear();
            foreach (var place in Globals.Places)
            {
                cmbPlaces.Items.Add(place.Name);
                cmbPlaces.AutoCompleteCustomSource.Add(place.Name);
            }
        }

        private void PopulateConversations()
        {
            convoLinks = Globals.ConvoMapLinks.Where((link) =>
            {
                var map = Globals.Maps[selectedMap];
                return map.ID == link.MapID && link.MapPoint == selectedPoint;
            });

            lbConversations.Items.Clear();
            foreach (var link in convoLinks)
            {
                var lastName = link.ConversationFile;
                lastName = lastName.Substring((Globals.CurrentProjectFolder + "\\Chapters\\").Length);
                lbConversations.Items.Add(lastName);
            }
        }

        private void PopulateJournals()
        {
            journalLinks = Globals.JournalMapLinks.Where((link) =>
            {
                var map = Globals.Maps[selectedMap];
                return link.MapID == map.ID && link.MapPoint == selectedPoint;
            });

            lbJournals.Items.Clear();
            foreach (var link in journalLinks)
            {
                var journals = Globals.Journals.Where((j) => j.ID == link.JournalID);
                if (journals.Count() > 0)
                {
                    var journal = journals.First();
                    lbJournals.Items.Add(journal.Name);
                }
            }
        }

        public void SetMapIndex(int index)
        {
            selectedMap = index;
        }

        public void SelectPoint(int index)
        {
            if (selectedMap > -1)
            {
                selectedPoint = index;

                var map = Globals.Maps[selectedMap];
                var point = map.Points[selectedPoint];
                Text = point.Name + " Properties";

                if (point.PlaceID > -1)
                    cmbPlaces.SelectedIndex = Globals.Places.FindIndex((p) => p.ID == point.PlaceID);
                else
                    cmbPlaces.SelectedIndex = -1;

                if (point.SectionID > -1)
                    cmbSections.SelectedIndex = Globals.Sections.FindIndex((s) => s.ID == point.SectionID);
                else
                    cmbSections.SelectedIndex = -1;

                PopulateConnections();
                PopulateConversations();
                PopulateJournals();

                pnlBasicProperties.Enabled = true;
                tcMain.Enabled = true;
            }
        }

        public void ChangePointPlaceIndex(int index)
        {
            PopulatePlaces();

            if (selectedMap > -1 && selectedPoint > -1)
            {
                cmbPlaces.SelectedIndex = index;
            }
        }

        public void Connect(int from, int to)
        {
            if (selectedMap > -1)
            {
                var map = Globals.Maps[selectedMap];
                var point = map.Points[from];
                point.Connections.Add(to);

                PopulateConnections();
            }
        }

        public void Disconnect(int from, int to)
        {
            if (selectedMap > -1)
            {
                var map = Globals.Maps[selectedMap];
                var point = map.Points[from];
                var index = -1;
                foreach (var con in point.Connections)
                {
                    index++;
                    if (con == to)
                    {
                        break;
                    }
                }

                point.Connections.RemoveAt(index);

                PopulateConnections();
            }
        }

        private void PopulateConnections()
        {
            if (selectedMap > -1 && selectedPoint > -1)
            {
                var map = Globals.Maps[selectedMap];
                var point = map.Points[selectedPoint];

                lbConnections.Items.Clear();
                foreach (var con in point.Connections)
                {
                    var connectPoint = map.Points[con];
                    lbConnections.Items.Add(connectPoint.Name);
                }
            }
        }

        private void cmbPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlaces.SelectedIndex > -1 && selectedPoint > -1 && selectedMap > -1)
            {
                var map = Globals.Maps[selectedMap];
                var point = map.Points[selectedPoint];
                point.PlaceID = Globals.Places[cmbPlaces.SelectedIndex].ID;

                sections = Globals.Sections.Where((s) => s.PlaceID == point.PlaceID);
                cmbSections.Items.Clear();
                cmbSections.AutoCompleteCustomSource.Clear();
                foreach (var section in sections)
                {
                    cmbSections.Items.Add(section.Name);
                    cmbSections.AutoCompleteCustomSource.Add(section.Name);
                }
            }
        }

        private void cmbSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlaces.SelectedIndex > -1 && cmbSections.SelectedIndex > -1 && selectedMap > -1 && selectedPoint > -1)
            {
                var map = Globals.Maps[selectedMap];
                var point = map.Points[selectedPoint];
                point.SectionID = sections.ElementAt(cmbSections.SelectedIndex).ID;
            }
        }

        private void btnSectionProperties_Click(object sender, EventArgs e)
        {
            if (selectedMap > -1 && selectedPoint > -1)
            {
                var map = Globals.Maps[selectedMap];
                var point = map.Points[selectedPoint];
                if (point.SectionID > -1)
                {
                    var section = Globals.Sections.Find((s) => s.ID == point.SectionID);
                    if (section == null)
                        return;

                    var sectionEdit = new EditSectionForm(section);
                    if (sectionEdit.ShowDialog() == DialogResult.OK)
                    {
                        Globals.SaveSections();
                    }
                }
            }
        }

        private void chbStartConnecting_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedPoint > -1)
                MapAllowConnections?.Invoke(selectedPoint);
        }

        public event OnMapAllowConnections MapAllowConnections;

        private void lbJournals_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveJournal.Enabled = lbJournals.SelectedIndex > -1;
        }

        private void btnRemoveJournal_Click(object sender, EventArgs e)
        {
            if (lbJournals.SelectedIndex > -1)
            {
                var link = journalLinks.ElementAt(lbJournals.SelectedIndex);
                var gIndex = Globals.JournalMapLinks.FindIndex((jl) => jl.JournalID == link.JournalID && jl.MapID == link.MapID && jl.MapPoint == link.MapPoint);
                Globals.JournalMapLinks.RemoveAt(gIndex);

                PopulateJournals();
            }
        }

        private void btnAddJournal_Click(object sender, EventArgs e)
        {
            if (selectedMap > -1 && selectedPoint > -1)
            {
                var search = new SearchForm<Journal>("Journals");
                search.SearchSelected += Search_SearchSelected;
                search.ShowDialog();
            }
        }

        private void Search_SearchSelected(int index)
        {
            var map = Globals.Maps[selectedMap];

            var existing = Globals.JournalMapLinks.Where((ml) => ml.MapID == map.ID && ml.MapPoint == selectedPoint && ml.JournalID == Globals.Journals[index].ID);
            if (existing.Count() == 0)
            {
                var journalLink = new JournalMapLink();
                journalLink.JournalID = Globals.Journals[index].ID;
                journalLink.MapID = map.ID;
                journalLink.MapPoint = selectedPoint;
                Globals.JournalMapLinks.Add(journalLink);
                Globals.SaveJournalMapLinks();
                PopulateJournals();
            }
        }

        private void lbConversations_DoubleClick(object sender, EventArgs e)
        {
            if (lbConversations.SelectedIndex > -1)
            {
                var convoLink = convoLinks.ElementAt(lbConversations.SelectedIndex);
                var editor = new ConversationEditor();
                editor.OpenFile(convoLink.ConversationFile);
                editor.Show();
            }
        }

        private void lbJournals_DoubleClick(object sender, EventArgs e)
        {
            if (lbJournals.SelectedIndex > -1)
            {
                foreach (var frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MainForm))
                    {
                        var casted = (MainForm)frm;
                        var journal = Globals.Journals.FindIndex((j) => journalLinks.ElementAt(lbJournals.SelectedIndex).JournalID == j.ID);
                        casted.SelectJournal(journal);
                        casted.BringToFront();
                    }
                }
            }
        }
    }
}

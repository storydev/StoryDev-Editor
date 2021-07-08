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
    }
}

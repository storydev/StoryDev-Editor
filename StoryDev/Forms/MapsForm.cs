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
    partial class MapsForm : Form
    {

        private int selectedMap;

        public MapsForm()
        {
            InitializeComponent();
        }

        private void PopulateFields()
        {
            if (selectedMap > -1)
            {
                var map = Globals.Maps[selectedMap];
                txtName.Text = map.Name;

                // Regions
                var regionsNode = tvMapper.Nodes[0];
                regionsNode.Nodes.Clear();
                foreach (var region in map.Regions)
                {
                    regionsNode.Nodes.Add(region.Name);
                }

                // Points
                var pointsNode = tvMapper.Nodes[1];
                pointsNode.Nodes.Clear();
                foreach (var point in map.Points)
                {
                    pointsNode.Nodes.Add(point.Name);
                }

                pnlMainProperties.Enabled = true;
                pnlMapper.Enabled = true;
                tvMapper.Enabled = true;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (selectedMap > -1)
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("You must enter a name for this map.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                }
                else
                {
                    Globals.Maps[selectedMap].Name = txtName.Text;
                }
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (selectedMap > -1)
            {
                var open = new OpenFileDialog();
                open.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.tif;*.tiff";
                open.InitialDirectory = Globals.CurrentProjectFolder;
                open.Multiselect = false;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Globals.Maps[selectedMap].ImagePath = open.FileName;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Map>("Maps");
            search.SearchSelected += (int index) =>
            {
                selectedMap = index;
                PopulateFields();
            };
            search.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.SaveMaps();
        }

        private void cmsMapperOptions_Opening(object sender, CancelEventArgs e)
        {
            newToolStripMenuItem1.Enabled = tvMapper.SelectedNode != null ? tvMapper.SelectedNode.Parent == null : false;
            renameToolStripMenuItem.Enabled = tvMapper.SelectedNode != null ? tvMapper.SelectedNode.Parent != null : false;
            deleteToolStripMenuItem.Enabled = tvMapper.SelectedNode != null ? tvMapper.SelectedNode.Parent != null : false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var entry = new SimpleEntryForm();
            entry.NotEmpty = true;
            entry.Text = "New Map";
            if (entry.ShowDialog() == DialogResult.OK)
            {
                var map = new Map();
                map.ID = ++Globals.GlobalIdentifiers.MapID;
                map.Name = entry.Value;
                Globals.Maps.Add(map);
                Globals.SaveIdentifiers();

                selectedMap = Globals.Maps.Count - 1;
                PopulateFields();
            }
        }

        private void MapsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globals.SaveMaps();
        }
    }
}

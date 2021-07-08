using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Data;
using SPoint = StoryDev.Data.Point;

namespace StoryDev.Forms
{
    partial class MapsForm : Form
    {

        private int selectedMap;
        private int selectedPoint;
        private MapPointPropertiesForm properties;

        public MapsForm()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            properties = new MapPointPropertiesForm();
            properties.MapAllowConnections += Properties_MapAllowConnections;
            properties.FormClosing += Properties_FormClosing;
        }

        private void Properties_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            properties.Hide();
            pointPropertiesToolStripMenuItem.Checked = false;
        }

        private void Properties_MapAllowConnections(int index)
        {
            mapsCanvas.StartConnections(index);
        }

        private void PopulateFields()
        {
            if (selectedMap > -1)
            {
                var map = Globals.Maps[selectedMap];
                txtName.Text = map.Name;
                mapsCanvas.ImagePath = map.ImagePath;
                cmbScope.SelectedIndex = map.Scope;

                for (int i = 0; i < clbMapFlags.Items.Count; i++)
                {
                    if ((map.Flags & (1 << i)) != 0)
                    {
                        clbMapFlags.SetItemChecked(i, true);
                    }
                }

                // Regions
                var pointsNode = tvMapper.Nodes[0];
                pointsNode.Nodes.Clear();
                foreach (var point in map.Points)
                {
                    pointsNode.Nodes.Add(point.Name);
                }

                pnlMainProperties.Enabled = true;
                pnlMapper.Enabled = true;
                tvMapper.Enabled = true;
                mapsCanvas.Enabled = true;

                viewToolStripMenuItem.Enabled = true;
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
                    var resourcePath = Globals.GetResourcesPath();
                    
                    var fileName = open.FileName.Substring(open.FileName.LastIndexOf('\\'));
                    if (!File.Exists(resourcePath + "\\" + fileName))
                    {
                        File.Copy(open.FileName, resourcePath + "\\" + fileName);
                        Globals.Maps[selectedMap].ImagePath = resourcePath + "\\" + fileName;
                        mapsCanvas.ImagePath = Globals.Maps[selectedMap].ImagePath;
                    }
                    else
                    {
                        var replace = new FileReplaceForm();
                        replace.FileToCopy = open.FileName;
                        if (replace.ShowDialog() == DialogResult.OK)
                        {
                            Globals.Maps[selectedMap].ImagePath = replace.ResultPath;
                            mapsCanvas.ImagePath = Globals.Maps[selectedMap].ImagePath;
                        }
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Map>("Maps");
            search.SearchSelected += (int index) =>
            {
                selectedMap = index;
                properties.SetMapIndex(selectedMap);
                mapsCanvas.SelectMap(index);
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
            createAssociatedPlaceToolStripMenuItem.Enabled = tvMapper.SelectedNode != null ? tvMapper.SelectedNode.Parent != null : false;
            createAssociatedSectionToolStripMenuItem.Enabled = tvMapper.SelectedNode != null ? tvMapper.SelectedNode.Parent != null : false;
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
            e.Cancel = false;

            Globals.SaveMaps();
            mapsCanvas.FreeResources();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (selectedMap == -1)
                return;

            var node = tvMapper.SelectedNode;
            if (tvMapper.Nodes[0] == node)
            {
                var entry = new SimpleEntryForm();
                entry.Text = "New Map Point";
                entry.NotEmpty = true;
                if (entry.ShowDialog() == DialogResult.OK)
                {
                    var mapPoint = new MapPoint();
                    mapPoint.Name = entry.Value;
                    mapPoint.Point = new SPoint();
                    mapPoint.Point.X = 0;
                    mapPoint.Point.Y = 0;

                    mapsCanvas.AddAndSelectPoint(mapPoint.Point.X, mapPoint.Point.Y);
                    var map = Globals.Maps[selectedMap];
                    map.Points.Add(mapPoint);

                    tvMapper.Nodes[0].Nodes.Add(entry.Value);
                }
            }
        }

        private void mapsCanvas_MapPointMoved(int index)
        {
            var point = mapsCanvas.GetPointByIndex(index);
            if (point != null && selectedMap > -1)
            {
                var map = Globals.Maps[selectedMap];
                var mapPoint = map.Points[index];
                mapPoint.Point.X = point.X;
                mapPoint.Point.Y = point.Y;
            }
        }

        private void tvMapper_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                var index = e.Node.Index;
                selectedPoint = index;
                mapsCanvas.SelectPoint(index);
                properties.SelectPoint(index);
            }
        }

        private void cmbScope_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedMap > -1)
            {
                Globals.Maps[selectedMap].Scope = cmbScope.SelectedIndex;
            }
        }

        private void clbMapFlags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)(
            () => {
                if (selectedMap > -1)
                {
                    var flags = 0;
                    for (int i = 0; i < clbMapFlags.Items.Count; i++)
                    {
                        if (clbMapFlags.GetItemChecked(i))
                        {
                            flags |= (1 << i);
                        }
                    }

                    Globals.Maps[selectedMap].Flags = flags;
                }
            }));
        }

        private void pointPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (properties.Visible)
            {
                properties.Hide();
            }
            else
            {
                properties.Show(this);
            }
        }

        private void mapsCanvas_MapConnect(int from, int to)
        {
            properties.Connect(from, to);
        }

        private void mapsCanvas_MapDisconnect(int from, int to)
        {
            properties.Disconnect(from, to);
        }

        private void createAssociatedPlaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var quickCreate = new QuickCreateForm<Place>();
            if (quickCreate.ShowDialog() == DialogResult.OK)
            {
                properties.ChangePointPlaceIndex(quickCreate.LastInsertedIndex);
            }
        }
    }
}

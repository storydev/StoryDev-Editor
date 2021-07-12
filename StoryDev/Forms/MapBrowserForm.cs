using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Forms
{
    partial class MapBrowserForm : Form
    {
        public MapBrowserForm()
        {
            InitializeComponent();

            mapsCanvas.BrowseOnly = true;

            foreach (var map in Globals.Maps)
            {
                cmbMaps.Items.Add(map.Name);
                cmbMaps.AutoCompleteCustomSource.Add(map.Name);
            }
        }

        private void cmbMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaps.SelectedIndex > -1)
            {
                mapsCanvas.SelectMap(cmbMaps.SelectedIndex);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mapsCanvas.ImagePath) && mapsCanvas.SelectedPoint > -1)
            {
                var map = Globals.Maps[cmbMaps.SelectedIndex];
                MapSelected?.Invoke(map.ID, mapsCanvas.SelectedPoint);
                Close();
            }
        }

        public event OnMapSelected MapSelected;
    }
}

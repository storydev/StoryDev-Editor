using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Components;

namespace StoryDev.Forms
{
    partial class IconSetsForm : Form
    {

        private IconsCanvas canvas;

        public IconSetsForm()
        {
            InitializeComponent();

            canvas = new IconsCanvas();
            canvas.IconSize = 32;
            canvas.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(canvas);
        }

        private void cmbIconSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIconSet.SelectedIndex == 0) // items
            {
                txtFilePath.Text = Globals.IconSetData.Items.FilePath;
                nudIconSize.Value = Globals.IconSetData.Items.IconSize;
            }
            else if (cmbIconSet.SelectedIndex == 1) // artefacts
            {
                txtFilePath.Text = Globals.IconSetData.Artefacts.FilePath;
                nudIconSize.Value = Globals.IconSetData.Artefacts.IconSize;
            }

            pnlProperties.Enabled = true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "PNG Files|*.png";
            open.Title = "Browse Image";
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = open.FileName;
            }
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {
            canvas.ImagePath = txtFilePath.Text;
            if (cmbIconSet.SelectedIndex == 0)
                Globals.IconSetData.Items.FilePath = txtFilePath.Text;
            else if (cmbIconSet.SelectedIndex == 1)
                Globals.IconSetData.Artefacts.FilePath = txtFilePath.Text;

        }

        private void nudIconSize_ValueChanged(object sender, EventArgs e)
        {
            canvas.IconSize = (int)nudIconSize.Value;
            if (cmbIconSet.SelectedIndex == 0)
                Globals.IconSetData.Items.IconSize = (int)nudIconSize.Value;
            else if (cmbIconSet.SelectedIndex == 1)
                Globals.IconSetData.Artefacts.IconSize = (int)nudIconSize.Value;
        }

        private void IconSetsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globals.SaveIconSetData();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ookii.Dialogs.WinForms;

namespace StoryDev.Components.Preferences
{
    partial class GeneralUI : UserControl
    {

        private StoryDev.Data.Preferences preferences;

        public GeneralUI(StoryDev.Data.Preferences preferences)
        {
            InitializeComponent();

            this.preferences = preferences;

            txtKhaDir.Text = preferences.KhaPath;
        }

        private void btnBrowseKhaDir_Click(object sender, EventArgs e)
        {
            var actualPath = preferences.KhaPath;
            if (actualPath.IndexOf(':') == -1)
            {
                actualPath = AppDomain.CurrentDomain.BaseDirectory + "/" + actualPath;
            }

            var select = new VistaFolderBrowserDialog();
            select.SelectedPath = actualPath;
            select.ShowNewFolderButton = false;
            var result = select.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtKhaDir.Text = preferences.KhaPath = select.SelectedPath;
            }
        }

        private void txtKhaDir_TextChanged(object sender, EventArgs e)
        {
            preferences.KhaPath = txtKhaDir.Text;
        }

    }
}

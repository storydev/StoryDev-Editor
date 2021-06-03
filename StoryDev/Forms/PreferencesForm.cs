using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Components.Preferences;

namespace StoryDev.Forms
{
    partial class PreferencesForm : Form
    {
        public PreferencesForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();

            if (lbPages.SelectedIndex == 0)
            {
                pnlContent.Controls.Add(new GeneralUI());
            }
            else if (lbPages.SelectedIndex == 1)
            {
                pnlContent.Controls.Add(new CodeEditorUI());
            }
        }

        private void PreferencesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globals.SavePreferences();
        }
    }
}

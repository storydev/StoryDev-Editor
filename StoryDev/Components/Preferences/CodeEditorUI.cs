using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components.Preferences
{
    partial class CodeEditorUI : UserControl
    {
        public CodeEditorUI()
        {
            InitializeComponent();

            PopulateFields();
        }

        private void PopulateFields()
        {
            chbWordWrap.Checked = Globals.Preferences.CodeSettings.WordWrap;
        }

        private void chbWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Preferences.CodeSettings.WordWrap = chbWordWrap.Checked;
        }
    }
}

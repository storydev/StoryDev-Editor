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
    partial class SetArtefactUseContextsForm : Form
    {
        public SetArtefactUseContextsForm()
        {
            InitializeComponent();

            var keys = Globals.Settings.ArtefactContextNames.Keys;
            foreach (var k in keys)
            {
                txtUseContexts.Text += k + "\r\n";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Globals.Settings.ArtefactContextNames.Clear();

            var lines = txtUseContexts.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                Globals.Settings.ArtefactContextNames.Add(line, (1 << i));
            }

            Globals.SaveSettings();
            DialogResult = DialogResult.OK;
        }
    }
}

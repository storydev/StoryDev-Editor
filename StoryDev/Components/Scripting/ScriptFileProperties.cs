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

namespace StoryDev.Components.Scripting
{
    partial class ScriptFileProperties : UserControl
    {

        private ScriptFileData data;

        public ScriptFileProperties(ScriptFileData data)
        {
            InitializeComponent();

            this.data = data;

            PopulateFields();
        }

        private void PopulateFields()
        {
            cmbInterpretation.SelectedIndex = data.Interpretation;
            chbEnableLivePreview.Checked = data.EnableLivePreview;
            chbInitScript.Checked = data.InitScript;
            chbNotCompiled.Checked = data.NotCompiled;
        }

        private void cmbInterpretation_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.Interpretation = cmbInterpretation.SelectedIndex;
        }

        private void chbNotCompiled_CheckedChanged(object sender, EventArgs e)
        {
            data.NotCompiled = chbNotCompiled.Checked;
        }

        private void chbEnableLivePreview_CheckedChanged(object sender, EventArgs e)
        {
            data.EnableLivePreview = chbEnableLivePreview.Checked;
        }

        private void chbInitScript_CheckedChanged(object sender, EventArgs e)
        {
            data.InitScript = chbInitScript.Checked;
        }
    }
}

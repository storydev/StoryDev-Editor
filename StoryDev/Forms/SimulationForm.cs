using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Simulation;

namespace StoryDev.Forms
{
    partial class SimulationForm : Form
    {

        private int selectedTemplate = -1;
        private bool isPlayingSimulation;

        public SimulationForm()
        {
            InitializeComponent();

            foreach (var templates in Globals.Simulation.Templates)
            {
                cmbTemplates.Items.Add(templates.Name);
            }
        }

        public void Interrupt()
        {
            if (isPlayingSimulation)
            {
                isPlayingSimulation = false;
                btnPlayStop.BackgroundImage = Properties.Resources.Play;
            }
        }

        public void UpdateAllMessages()
        {
            lvErrors.Items.Clear();
            lvMessages.Items.Clear();
            lvWarnings.Items.Clear();

            if (!Engine.Instance.Messages.ContainsKey(Engine.DEFAULT_MSG_VAR))
                return;

            var messages = Engine.Instance.Messages[Engine.DEFAULT_MSG_VAR];
            foreach (var msg in messages)
            {
                var item = new ListViewItem();
                item.Text = msg.OriginalFile;
                item.SubItems.Add("" + msg.Line);
                item.SubItems.Add(msg.Title);
                item.SubItems.Add(msg.Description);

                if (msg.Type == MessageType.Error)
                {
                    lvErrors.Items.Add(item);
                }
                else if (msg.Type == MessageType.Warning)
                {
                    lvWarnings.Items.Add(item);
                }
                else if (msg.Type == MessageType.Info)
                {
                    lvMessages.Items.Add(item);
                }
            }

            lvErrors.Enabled = true;
            lvMessages.Enabled = true;
            lvWarnings.Enabled = true;
        }

        private void btnPlayStop_Click(object sender, EventArgs e)
        {
            if (selectedTemplate > -1)
            {
                var outcomes = new List<int>();
                if (chbBestOutcome.Checked)
                    outcomes.Add(0);

                if (chbWorstOutcome.Checked)
                    outcomes.Add(1);

                if (!chbBestOutcome.Checked && !chbWorstOutcome.Checked)
                {
                    MessageBox.Show("You must select an outcome to track.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                isPlayingSimulation = !isPlayingSimulation;
                pnlOptions.Enabled = !isPlayingSimulation;

                if (isPlayingSimulation)
                {
                    btnPlayStop.BackgroundImage = Properties.Resources.Stop;

                    SimulationStarted?.Invoke(Globals.Simulation.Templates[selectedTemplate], outcomes);
                }
                else
                {
                    btnPlayStop.BackgroundImage = Properties.Resources.Play;
                    SimulationStopped?.Invoke();
                }
            }
        }

        private void cmbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTemplate = cmbTemplates.SelectedIndex;
        }

        public event OnSimulationStarted SimulationStarted;
        public event OnSimulationStopped SimulationStopped;

        private void chbAutoTrack_CheckedChanged(object sender, EventArgs e)
        {
            Engine.Instance.EnableCallstack = chbAutoTrack.Checked;
        }

        private void lvErrors_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}

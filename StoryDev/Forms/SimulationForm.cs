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

        private void btnPlayStop_Click(object sender, EventArgs e)
        {
            if (selectedTemplate > -1)
            {
                isPlayingSimulation = !isPlayingSimulation;
                pnlOptions.Enabled = !isPlayingSimulation;

                if (isPlayingSimulation)
                {
                    btnPlayStop.Image = Properties.Resources.Stop;
                }
                else
                {
                    btnPlayStop.Image = Properties.Resources.Play;
                }
            }
        }

        private void cmbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTemplate = cmbTemplates.SelectedIndex;
        }
    }
}

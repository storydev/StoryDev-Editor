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

namespace StoryDev.Forms
{
    partial class SimulationOptionsForm : Form
    {

        private int selectedTemplate = -1;
        private bool requireSave;

        public SimulationOptionsForm()
        {
            InitializeComponent();

            PopulateFields();
        }

        private void PopulateFields()
        {
            chbEnableSimulationsStartup.Checked = Globals.Simulation.EnableSimulationsStartup;
            chbResimulate.Checked = Globals.Simulation.Resimulate;
            nudBestOutcomePriority.Value = Globals.Simulation.BestOutcome;
            nudWorstOutcomePriority.Value = Globals.Simulation.WorstOutcome;
            txtStateRecordingsFolder.Text = Globals.Simulation.StateRecordingsFolder;
            chbStateRecording.Checked = Globals.Simulation.EnableStateRecording;

            PopulateTemplates();
        }

        private void PopulateTemplates()
        {
            cmbStateTemplates.SelectedIndexChanged -= cmbStateTemplates_SelectedIndexChanged;

            var temp = cmbStateTemplates.SelectedIndex;

            cmbStateTemplates.Items.Clear();
            foreach (var template in Globals.Simulation.Templates)
            {
                cmbStateTemplates.Items.Add(template.Name);
            }

            cmbStateTemplates.Items.Add("<New Template...>");

            if (temp < cmbStateTemplates.Items.Count - 2)
            {
                cmbStateTemplates.SelectedIndex = temp;
                if (temp > -1)
                {
                    pnlRecordOptions.Enabled = true;
                    pnlRecordDetails.Enabled = true;
                }
            }
            else
            {
                cmbStateTemplates.SelectedIndex = -1;
                pnlRecordOptions.Enabled = false;
                pnlRecordDetails.Enabled = false;
            }

            cmbStateTemplates.SelectedIndexChanged += cmbStateTemplates_SelectedIndexChanged;
        }

        private void PopulateTemplateFields()
        {
            if (selectedTemplate > -1)
            {
                var template = Globals.Simulation.Templates[selectedTemplate];
                chbSaveStateChange.Checked = template.SaveStatePerChange;

                tvRecordingDetails.AfterCheck -= tvRecordingDetails_AfterCheck;

                foreach (TreeNode node in tvRecordingDetails.Nodes)
                {
                    if (template.ActiveState.ContainsKey(node.FullPath))
                        node.Checked = template.ActiveState[node.FullPath];
                    else
                        template.ActiveState.Add(node.FullPath, node.Checked);

                    if (node.Nodes.Count > 0)
                        CheckNodes(node.Nodes);
                }

                tvRecordingDetails.AfterCheck += tvRecordingDetails_AfterCheck;
            }
        }

        private void CheckNodes(TreeNodeCollection nodes)
        {
            var template = Globals.Simulation.Templates[selectedTemplate];

            foreach (TreeNode node in nodes)
            {
                if (template.ActiveState.ContainsKey(node.FullPath))
                    node.Checked = template.ActiveState[node.FullPath];
                else
                    template.ActiveState.Add(node.FullPath, node.Checked);

                if (node.Nodes.Count > 0)
                    CheckNodes(node.Nodes);
            }
        }

        private void UncheckAll()
        {
            tvRecordingDetails.AfterCheck -= tvRecordingDetails_AfterCheck;

            foreach (TreeNode node in tvRecordingDetails.Nodes)
            {
                node.Checked = false;
                if (node.Nodes.Count > 0)
                    UncheckChildren(node.Nodes);
            }

            tvRecordingDetails.AfterCheck += tvRecordingDetails_AfterCheck;
        }

        private void UncheckChildren(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in tvRecordingDetails.Nodes)
            {
                node.Checked = false;
                if (node.Nodes.Count > 0)
                    UncheckChildren(node.Nodes);
            }
        }

        private void CreateTemplateStateVariables(ref Dictionary<string, bool> vars, TreeNodeCollection nodes = null)
        {
            var _nodes = tvRecordingDetails.Nodes;
            if (nodes != null)
                _nodes = nodes;

            foreach (TreeNode node in _nodes)
            {
                vars.Add(node.FullPath, node.Checked);
                if (node.Nodes.Count > 0)
                    CreateTemplateStateVariables(ref vars, node.Nodes);
            }
        }



        private void cmbStateTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStateTemplates.SelectedIndex > -1)
            {
                var isCreate = cmbStateTemplates.SelectedIndex == cmbStateTemplates.Items.Count - 1;
                if (isCreate)
                {
                    var entry = new SimpleEntryForm();
                    entry.Text = "New Template";
                    if (entry.ShowDialog() == DialogResult.OK)
                    {
                        var template = new StateTemplate();
                        template.Name = entry.Value;
                        UncheckAll();
                        CreateTemplateStateVariables(ref template.ActiveState);
                        Globals.Simulation.Templates.Add(template);
                        PopulateTemplates();

                        cmbStateTemplates.SelectedIndex = -1;

                        pnlRecordDetails.Enabled = false;
                        pnlRecordOptions.Enabled = false;
                    }
                }
                else
                {
                    selectedTemplate = cmbStateTemplates.SelectedIndex;

                    pnlRecordDetails.Enabled = true;
                    pnlRecordOptions.Enabled = true;

                    PopulateTemplateFields();
                }
            }
        }

        private void tvRecordingDetails_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (selectedTemplate > -1)
            {
                if (Globals.Simulation.Templates[selectedTemplate].ActiveState.ContainsKey(e.Node.FullPath))
                {
                    Globals.Simulation.Templates[selectedTemplate].ActiveState[e.Node.FullPath] = e.Node.Checked;
                    requireSave = true;
                }
            }
        }

        private void chbEnableSimulationsStartup_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Simulation.EnableSimulationsStartup = chbEnableSimulationsStartup.Checked;
            requireSave = true;
        }

        private void chbResimulate_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Simulation.Resimulate = chbResimulate.Checked;
            requireSave = true;
        }

        private void nudBestOutcomePriority_ValueChanged(object sender, EventArgs e)
        {
            Globals.Simulation.BestOutcome = (int)nudBestOutcomePriority.Value;
            requireSave = true;
        }

        private void nudWorstOutcomePriority_ValueChanged(object sender, EventArgs e)
        {
            Globals.Simulation.WorstOutcome = (int)nudWorstOutcomePriority.Value;
            requireSave = true;
        }

        private void txtStateRecordingsFolder_TextChanged(object sender, EventArgs e)
        {
            Globals.Simulation.StateRecordingsFolder = txtStateRecordingsFolder.Text;
            requireSave = true;
        }

        private void chbStateRecording_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Simulation.EnableStateRecording = chbStateRecording.Checked;
            requireSave = true;
        }

        private void chbSaveStateChange_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedTemplate > -1)
            {
                var template = Globals.Simulation.Templates[selectedTemplate];
                template.SaveStatePerChange = chbSaveStateChange.Checked;
                requireSave = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (requireSave)
            {
                Globals.SaveSimulationOptions();
                requireSave = false;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var open = new VistaFolderBrowserDialog();
            open.RootFolder = Environment.SpecialFolder.MyDocuments;
            open.ShowNewFolderButton = true;
            var result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtStateRecordingsFolder.Text = open.SelectedPath;
            }
        }
    }
}

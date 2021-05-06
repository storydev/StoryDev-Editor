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

namespace StoryDev.Components
{
    partial class SpecialFeatureUI : UserControl
    {

        private CodeEditor startScriptEditor;
        private CodeEditor endScriptEditor;

        private bool requireSave;

        private int selectedScenario = -1;

        public SpecialFeatureUI()
        {
            InitializeComponent();

            startScriptEditor = new CodeEditor();
            endScriptEditor = new CodeEditor();

            startScriptEditor.Dock = DockStyle.Fill;
            endScriptEditor.Dock = DockStyle.Fill;

            startScriptEditor.TextChanged += StartScriptEditor_TextChanged;
            endScriptEditor.TextChanged += EndScriptEditor_TextChanged;

            tpStart.Controls.Add(startScriptEditor);
            tpEnd.Controls.Add(endScriptEditor);

            PopulateProperties();
            PopulateScenarios();
        }

        private void EndScriptEditor_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (selectedScenario > -1)
            {
                Globals.Scenarios[selectedScenario].EndScript = endScriptEditor.Text;
            }
        }

        private void StartScriptEditor_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (selectedScenario > -1)
            {
                Globals.Scenarios[selectedScenario].StartScript = startScriptEditor.Text;
            }
        }

        private void PopulateProperties()
        {
            var feature = Globals.Feature;

            txtFeatureName.Text = feature.Name;
            chbHasDifficulty.Checked = feature.HasDifficulty;
            nudMinDifficulty.Value = feature.DifficultyMin;
            nudMaxDifficulty.Value = feature.DifficultyMax;
            chbRepeatable.Checked = feature.Repeatable;
            chbNewScore.Checked = feature.RepeatsNewScore;
            chbAllowFrequencyChanges.Checked = feature.AllowFrequencyChanges;

            nudDifficulty.Minimum = Globals.Feature.DifficultyMin;

            requireSave = false;
        }

        private void PopulateScenarios()
        {
            lbScenarios.SelectedIndexChanged -= lbScenarios_SelectedIndexChanged;

            var temp = lbScenarios.SelectedIndex;

            lbScenarios.Items.Clear();
            foreach (var scenario in Globals.Scenarios)
            {
                lbScenarios.Items.Add(scenario.Name);
            }

            if (temp < lbScenarios.Items.Count - 1)
                lbScenarios.SelectedIndex = temp;

            lbScenarios.SelectedIndexChanged += lbScenarios_SelectedIndexChanged;
        }

        private void PopulateFields()
        {
            if (selectedScenario > -1)
            {
                var scenario = Globals.Scenarios[selectedScenario];

                txtName.Text = scenario.Name;
                txtDescription.Text = scenario.Description;
                var val = scenario.Difficulty;
                if (val < nudDifficulty.Minimum)
                {
                    nudDifficulty.Value = nudDifficulty.Minimum;
                }
                else if (val > nudDifficulty.Maximum)
                {
                    nudDifficulty.Value = nudDifficulty.Maximum;
                }
                else
                {
                    nudDifficulty.Value = val;
                }

                startScriptEditor.Text = scenario.StartScript;
                endScriptEditor.Text = scenario.EndScript;
            }
        }


        private void tmSaveProperties_Tick(object sender, EventArgs e)
        {
            if (requireSave)
            {
                Globals.SaveFeature();
                requireSave = false;
            }
        }

        private void txtFeatureName_TextChanged(object sender, EventArgs e)
        {
            Globals.Feature.Name = txtFeatureName.Text;
            requireSave = true;
        }

        private void chbHasDifficulty_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Feature.HasDifficulty = chbHasDifficulty.Checked;
            nudMinDifficulty.Enabled = nudMaxDifficulty.Enabled = chbHasDifficulty.Checked;

            requireSave = true;
        }

        private void nudMinDifficulty_ValueChanged(object sender, EventArgs e)
        {
            Globals.Feature.DifficultyMin = (int)nudMinDifficulty.Value;
            nudDifficulty.Minimum = Globals.Feature.DifficultyMin;
            requireSave = true;
        }

        private void nudMaxDifficulty_ValueChanged(object sender, EventArgs e)
        {
            Globals.Feature.DifficultyMax = (int)nudMaxDifficulty.Value;
            nudDifficulty.Maximum = Globals.Feature.DifficultyMax;
            requireSave = true;
        }

        private void chbRepeatable_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Feature.Repeatable = chbRepeatable.Checked;
            requireSave = true;
        }

        private void chbNewScore_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Feature.RepeatsNewScore = chbNewScore.Checked;
            requireSave = true;
        }

        private void chbAllowFrequencyChanges_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Feature.AllowFrequencyChanges = chbAllowFrequencyChanges.Checked;
            requireSave = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var scenario = new SpecialScenario();
            scenario.ID = ++Globals.GlobalIdentifiers.ScenarioID;
            Globals.SaveIdentifiers();
            Globals.Scenarios.Add(scenario);

            PopulateScenarios();
        }

        private void lbScenarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbScenarios.SelectedIndex > -1)
            {
                selectedScenario = lbScenarios.SelectedIndex;

                pnlContent.Enabled = true;
                PopulateFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedScenario > -1)
            {
                var temp = lbScenarios.SelectedIndex;
                lbScenarios.Items.RemoveAt(temp);
                Globals.Scenarios.RemoveAt(temp);
                Globals.SaveScenarios();

                pnlContent.Enabled = false;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Globals.SaveFeature();
            requireSave = false;
            Globals.SaveScenarios();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (selectedScenario > -1)
            {
                Globals.Scenarios[selectedScenario].Name = txtName.Text;
                lbScenarios.Items[selectedScenario] = txtName.Text;
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (selectedScenario > -1)
            {
                Globals.Scenarios[selectedScenario].Description = txtDescription.Text;
            }
        }

        private void nudDifficulty_ValueChanged(object sender, EventArgs e)
        {
            if (selectedScenario > -1)
            {
                Globals.Scenarios[selectedScenario].Difficulty = (int)nudDifficulty.Value;
            }
        }
    }
}

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
using StoryDev.Forms;

namespace StoryDev.Components.CodeUI
{
    partial class UnlockScenario : UserControl, ICodeComponent
    {
        public UnlockScenario()
        {
            InitializeComponent();

            foreach (var scenario in Globals.Scenarios)
            {
                cmbScenarios.Items.Add(scenario.Name);
                cmbScenarios.AutoCompleteCustomSource.Add(scenario.Name);
            }
        }

        public bool IsConditional => false;

        public void FromCodeString(string code)
        {
            var result = code.Substring("UnlockScenario(".Length, code.LastIndexOf(')') - "UnlockScenario(".Length);
            if (int.TryParse(result, out int scenarioID))
            {
                cmbScenarios.SelectedIndex = Globals.Scenarios.FindIndex((s) => s.ID == scenarioID);
            }
        }

        public UserControl GetControl()
        {
            return this;
        }

        public string GetErrorMessage()
        {
            if (cmbScenarios.SelectedIndex == -1)
                return "You must select a scenario.";

            return "";
        }

        public bool IsValid()
        {
            return cmbScenarios.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("UnlockScenario({0})", Globals.Scenarios[cmbScenarios.SelectedIndex].ID);
        }

        private void btnBrowseScenarios_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<SpecialScenario>("Scenarios");
            search.SearchSelected += (int index) => cmbScenarios.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

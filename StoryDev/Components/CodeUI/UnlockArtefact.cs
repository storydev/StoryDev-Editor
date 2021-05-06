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
    partial class UnlockArtefact : UserControl, ICodeComponent
    {
        public UnlockArtefact()
        {
            InitializeComponent();

            foreach (var artefact in Globals.Artefacts)
            {
                cmbArtefacts.Items.Add(artefact.Name);
                cmbArtefacts.AutoCompleteCustomSource.Add(artefact.Name);
            }
        }

        public bool IsConditional => false;

        public void FromCodeString(string code)
        {
            var result = code.Substring("UnlockArtefact(".Length, code.LastIndexOf(')') - "UnlockArtefact(".Length);
            if (int.TryParse(result, out int artefactID))
            {
                cmbArtefacts.SelectedIndex = Globals.Artefacts.FindIndex((a) => a.ID == artefactID);
            }
        }

        public UserControl GetControl()
        {
            return this;
        }

        public string GetErrorMessage()
        {
            if (cmbArtefacts.SelectedIndex == -1)
                return "You must select an artefact.";

            return "";
        }

        public bool IsValid()
        {
            return cmbArtefacts.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("UnlockArtefact({0})", Globals.Artefacts[cmbArtefacts.SelectedIndex].ID);
        }

        private void btnBrowseArtefacts_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Artefact>("Artefacts");
            search.SearchSelected += (int index) => cmbArtefacts.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

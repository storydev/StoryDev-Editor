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
    partial class AcquireArtefactFragment : UserControl, ICodeComponent
    {
        public AcquireArtefactFragment()
        {
            InitializeComponent();

            foreach (var fragment in Globals.Fragments)
            {
                cmbFragments.Items.Add(fragment.Name);
                cmbFragments.AutoCompleteCustomSource.Add(fragment.Name);
            }
        }

        public bool IsConditional => false;

        public void FromCodeString(string code)
        {
            var result = code.Substring("AcquireArtefactFragment(".Length, code.LastIndexOf(')') - "AcquireArtefactFragment(".Length);
            if (int.TryParse(result, out int fragmentID))
            {
                cmbFragments.SelectedIndex = Globals.Fragments.FindIndex((f) => f.ID == fragmentID);
            }
        }

        public UserControl GetControl()
        {
            return this;
        }

        public string GetErrorMessage()
        {
            if (cmbFragments.SelectedIndex == -1)
                return "You must select a fragment.";

            return "";
        }

        public bool IsValid()
        {
            return cmbFragments.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("AcquireArtefactFragment({0})", Globals.Fragments[cmbFragments.SelectedIndex].ID);
        }

        private void cmbFragments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFragments.SelectedIndex > -1)
            {
                var fragment = Globals.Fragments[cmbFragments.SelectedIndex];
                var artefact = Globals.Artefacts.Find((a) => a.ID == fragment.ArtefactID);
                lblArtefact.Text = "Artefact: " + artefact.Name;
            }
        }

        private void btnFragments_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<ArtefactFragment>("Fragments");
            search.SearchSelected += (int index) => cmbFragments.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Forms;
using StoryDev.Data;

namespace StoryDev.Components.CodeUI
{
    partial class HasArtefactFragment : UserControl, ICodeComponent
    {

        public HasArtefactFragment()
        {
            InitializeComponent();

            foreach (var fragment in Globals.Fragments)
            {
                cmbFragments.Items.Add(fragment.Name);
                cmbFragments.AutoCompleteCustomSource.Add(fragment.Name);
            }
        }

        public bool IsConditional => true;

        public void FromCodeString(string code)
        {
            var result = code.Substring("HasArtefactFragment(".Length, code.LastIndexOf(')') - "HasArtefactFragment(".Length);
            var splitted = result.Split(',');
            if (splitted.Length == 2)
            {
                if (int.TryParse(splitted[0], out int fragmentID))
                {
                    cmbFragments.SelectedIndexChanged -= cmbArtefacts_SelectedIndexChanged;

                    cmbFragments.SelectedIndex = Globals.Fragments.FindIndex((f) => f.ID == fragmentID);

                    cmbFragments.SelectedIndexChanged += cmbArtefacts_SelectedIndexChanged;
                }
            }
        }

        public UserControl GetControl()
        {
            return this;
        }

        public string GetErrorMessage()
        {
            if (cmbFragments.SelectedIndex == -1)
                return "You must select an artefact fragment";

            return "";
        }

        public bool IsValid()
        {
            return cmbFragments.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("HasArtefactFragment({0})", Globals.Fragments[cmbFragments.SelectedIndex].ID);
        }

        private void cmbArtefacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFragments.SelectedIndex > -1)
            {
                var fragment = Globals.Fragments[cmbFragments.SelectedIndex];
                var artefact = Globals.Artefacts.Find((a) => a.ID == fragment.ArtefactID);
                lblArtefact.Text = "Artefact: " + artefact.Name;
            }
            else
            {
                lblArtefact.Text = "Artefact: ";
            }
        }

        private void btnBrowseArtefacts_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<ArtefactFragment>("Fragments");
            search.SearchSelected += (int index) => cmbFragments.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

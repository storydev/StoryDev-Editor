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

namespace StoryDev.Forms
{
    partial class EditActivityForm : Form
    {

        private Activity activity;
        private int selectedPart;

        public EditActivityForm(Activity activity)
        {
            InitializeComponent();

            

            foreach (var trait in Globals.Traits)
            {
                cmbTraits.AutoCompleteCustomSource.Add(trait.Name);
                cmbTraits.Items.Add(trait.Name);
            }

            foreach (var journal in Globals.Journals)
            {
                cmbStartJournal.AutoCompleteCustomSource.Add(journal.Name);
                cmbStartJournal.Items.Add(journal.Name);

                cmbEndingJournal.AutoCompleteCustomSource.Add(journal.Name);
                cmbEndingJournal.Items.Add(journal.Name);
            }

            this.activity = activity;
            PopulateFields();
        }

        private void PopulateFields()
        {
            txtName.Text = activity.Name;
            txtDescription.Text = activity.Description;
            cmbTraits.SelectedIndex = Globals.GetTraitIndex(activity.CharacterTraitID);
            nudProgressOnComplete.Value = activity.ProgressOnComplete;
            nudProgressOnPart.Value = activity.ProgressOnPart;
            chbHiddenUntilDiscovered.Checked = activity.HiddenUntilDiscovered;

            PopulateParts();
        }

        private void PopulateParts()
        {
            lbParts.SelectedIndexChanged -= lbParts_SelectedIndexChanged;

            var temp = lbParts.SelectedIndex;
            lbParts.Items.Clear();
            int index = 1;
            foreach (var part in activity.Parts)
            {
                lbParts.Items.Add("Part " + index++);
            }

            if (temp < lbParts.Items.Count - 1)
                lbParts.SelectedIndex = temp;

            lbParts.SelectedIndexChanged += lbParts_SelectedIndexChanged;
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            var part = new ActivityPart();
            activity.Parts.Add(part);
            PopulateParts();
        }

        private void lbParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbParts.SelectedIndex > -1)
            {
                pnlPartContent.Enabled = true;
                selectedPart = lbParts.SelectedIndex;

                var part = activity.Parts[selectedPart];
                cmbStartJournal.SelectedIndexChanged -= cmbStartJournal_SelectedIndexChanged;
                cmbEndingJournal.SelectedIndexChanged -= cmbEndingJournal_SelectedIndexChanged;

                cmbStartJournal.SelectedIndex = Globals.GetJournalIndex(part.StartJournalID);
                cmbEndingJournal.SelectedIndex = Globals.GetJournalIndex(part.EndJournalID);

                if (cmbStartJournal.SelectedIndex > -1)
                {
                    var startJournal = Globals.Journals[cmbStartJournal.SelectedIndex];
                    cmbStartPage.Items.Clear();
                    for (int i = 0; i < startJournal.Pages.Count; i++)
                    {
                        cmbStartPage.Items.Add("" + (i + 1));
                    }

                    cmbStartPage.SelectedIndex = part.StartJournalPage;
                }

                if (cmbEndingJournal.SelectedIndex > -1)
                {
                    var endJournal = Globals.Journals[cmbEndingJournal.SelectedIndex];
                    cmbEndPage.Items.Clear();
                    for (int i = 0; i < endJournal.Pages.Count; i++)
                    {
                        cmbEndPage.Items.Add("" + (i + 1));
                    }

                    cmbEndPage.SelectedIndex = part.EndJournalPage;
                }

                chbSameJournal.Checked = cmbStartJournal.SelectedIndex == cmbEndingJournal.SelectedIndex;

                cmbStartJournal.SelectedIndexChanged += cmbStartJournal_SelectedIndexChanged;
                cmbEndingJournal.SelectedIndexChanged += cmbEndingJournal_SelectedIndexChanged;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbParts.SelectedIndex > -1)
            {
                activity.Parts.RemoveAt(lbParts.SelectedIndex);
                PopulateParts();
            }
        }

        private void cmbStartJournal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStartJournal.SelectedIndex > -1 && selectedPart > -1)
            {
                var journal = Globals.Journals[cmbStartJournal.SelectedIndex];
                cmbStartPage.Items.Clear();
                for (int i = 0; i < journal.Pages.Count; i++)
                {
                    cmbStartPage.Items.Add("" + (i + 1));
                }

                activity.Parts[selectedPart].StartJournalID = journal.ID;
            }
        }

        private void chbSameJournal_CheckedChanged(object sender, EventArgs e)
        {
            cmbEndingJournal.Enabled = !chbSameJournal.Checked;
            if (chbSameJournal.Checked)
            {
                cmbEndingJournal.SelectedIndex = cmbStartJournal.SelectedIndex;
            }
        }

        private void cmbEndingJournal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEndingJournal.SelectedIndex > -1 && selectedPart > -1)
            {
                var journal = Globals.Journals[cmbEndingJournal.SelectedIndex];
                cmbEndPage.Items.Clear();
                for (int i = 0; i < journal.Pages.Count; i++)
                {
                    cmbEndPage.Items.Add("" + (i + 1));
                }

                activity.Parts[selectedPart].EndJournalID = journal.ID;
            }
        }

        private void cmbStartPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedPart > -1)
            {
                var part = activity.Parts[selectedPart];
                part.StartJournalPage = cmbStartPage.SelectedIndex;
                txtPreview.Text = Globals.Journals[Globals.GetJournalIndex(part.StartJournalID)].Pages[cmbStartPage.SelectedIndex];
            }
        }

        private void cmbEndPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedPart > -1)
            {
                var part = activity.Parts[selectedPart];
                part.EndJournalPage = cmbEndPage.SelectedIndex;
                txtPreview.Text = Globals.Journals[Globals.GetJournalIndex(part.EndJournalID)].Pages[cmbEndPage.SelectedIndex];
            }
        }

        private void cmbTraits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTraits.SelectedIndex > -1)
            {
                var trait = Globals.Traits[cmbTraits.SelectedIndex];
                activity.CharacterTraitID = trait.ID;

                var character = Globals.GetCharacter(trait.CharacterID);
                lblTraitInfo.Text = "Character: " + character.FirstName + ", Initial: " + trait.InitialValue + ", Max: " + trait.MaxValue;
            }
        }

        private void EditActivityForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            activity.Name = txtName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            activity.Description = txtDescription.Text;
        }

        private void nudProgressOnComplete_ValueChanged(object sender, EventArgs e)
        {
            activity.ProgressOnComplete = (int)nudProgressOnComplete.Value;
        }

        private void nudProgressOnPart_ValueChanged(object sender, EventArgs e)
        {
            activity.ProgressOnPart = (int)nudProgressOnPart.Value;
        }

        private void chbHiddenUntilDiscovered_CheckedChanged(object sender, EventArgs e)
        {
            activity.HiddenUntilDiscovered = chbHiddenUntilDiscovered.Checked;
        }

        private void cmbTraits_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnBrowseTraits_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<CharacterTrait>("Traits");
            search.SearchSelected += (int index) => cmbTraits.SelectedIndex = index;
            search.ShowDialog();
        }

        private void btnBrowseStartJournals_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Journal>("Journals");
            search.SearchSelected += (int index) => cmbStartJournal.SelectedIndex = index;
            search.ShowDialog();
        }

        private void btnBrowseEndJournals_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Journal>("Journals");
            search.SearchSelected += (int index) => cmbEndingJournal.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

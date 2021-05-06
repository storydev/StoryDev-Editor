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
    partial class HasJournalProgress : UserControl, ICodeComponent
    {
        public HasJournalProgress()
        {
            InitializeComponent();

            foreach (var journal in Globals.Journals)
            {
                cmbJournals.Items.Add(journal.Name);
                cmbJournals.AutoCompleteCustomSource.Add(journal.Name);
            }
        }

        public bool IsConditional => true;

        public void FromCodeString(string code)
        {
            var result = code.Substring("HasJournalProgress(".Length, code.LastIndexOf(')') - "HasJournalProgress(".Length);
            var splitted = result.Split(',');
            if (splitted.Length == 2)
            {
                if (int.TryParse(splitted[0], out int journalID))
                {
                    cmbJournals.SelectedIndexChanged -= cmbJournals_SelectedIndexChanged;

                    cmbJournals.SelectedIndex = Globals.Journals.FindIndex((j) => j.ID == journalID);

                    var journal = Globals.Journals[cmbJournals.SelectedIndex];
                    cmbPage.Items.Clear();
                    for (int i = 0; i < journal.Pages.Count; i++)
                    {
                        cmbPage.Items.Add("" + (i + 1));
                    }

                    cmbJournals.SelectedIndexChanged += cmbJournals_SelectedIndexChanged;
                }

                if (int.TryParse(splitted[1], out int page))
                {
                    cmbPage.SelectedIndex = page - 1;
                }
            }
        }

        public UserControl GetControl()
        {
            return this;
        }

        public string GetErrorMessage()
        {
            if (cmbJournals.SelectedIndex == -1)
                return "You must select a journal.";

            if (cmbPage.SelectedIndex == -1)
                return "You must select a page.";

            return "";
        }

        public bool IsValid()
        {
            return cmbJournals.SelectedIndex > -1 && cmbPage.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("HasJournalProgress({0}, {1})", Globals.Journals[cmbJournals.SelectedIndex].ID, cmbPage.SelectedIndex + 1);
        }

        private void cmbJournals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJournals.SelectedIndex > -1)
            {
                var journal = Globals.Journals[cmbJournals.SelectedIndex];
                cmbPage.Items.Clear();
                for (int i = 0; i < journal.Pages.Count; i++)
                {
                    cmbPage.Items.Add("" + (i + 1));
                }
            }
        }

        private void btnBrowseJournals_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Journal>("Journals");
            search.SearchSelected += (int index) => cmbJournals.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

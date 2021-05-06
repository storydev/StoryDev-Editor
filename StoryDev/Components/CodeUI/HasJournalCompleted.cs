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
    partial class HasJournalCompleted : UserControl, ICodeComponent
    {
        public HasJournalCompleted()
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
            var result = code.Substring("HasJournalCompleted(".Length, code.LastIndexOf(')') - "HasJournalCompleted(".Length);
            if (int.TryParse(result, out int journalID))
            {
                cmbJournals.SelectedIndex = Globals.Journals.FindIndex((j) => j.ID == journalID);
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

            return "";
        }

        public bool IsValid()
        {
            return cmbJournals.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("HasJournalCompleted({0})", Globals.Journals[cmbJournals.SelectedIndex].ID);
        }

        private void btnBrowseJournals_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Journal>("Journals");
            search.SearchSelected += (int index) => cmbJournals.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

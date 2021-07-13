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

namespace StoryDev.Components
{
    partial class JournalUI : UserControl
    {

        private int selectedJournal = -1;

        public JournalUI()
        {
            InitializeComponent();

            RefreshChapterLists();
            PopulateJournals();
        }

        public void SelectJournalIndex(int index)
        {
            lbResults.SelectedIndex = index;
        }

        private void PopulateJournals()
        {
            lbResults.SelectedIndexChanged -= lbResults_SelectedIndexChanged;

            var temp = lbResults.SelectedIndex;
            lbResults.Items.Clear();
            foreach (var journal in Globals.Journals)
            {
                lbResults.Items.Add(journal.Name);
            }

            if (temp < lbResults.Items.Count)
                selectedJournal = lbResults.SelectedIndex = temp;

            lbResults.SelectedIndexChanged += lbResults_SelectedIndexChanged;
        }

        private void PopulateFields()
        {
            var journal = Globals.Journals[selectedJournal];

            lbResults.SelectedIndexChanged -= lbResults_SelectedIndexChanged;
            cmbChapters.SelectedIndexChanged -= cmbChapters_SelectedIndexChanged;
            cmbAvailableUntilChapter.SelectedIndexChanged -= cmbAvailableUntilChapter_SelectedIndexChanged;

            txtName.Text = journal.Name;
            chbMainStory.Checked = journal.IsMainStory;
            chbAccessedViaScript.Checked = journal.AccessedViaScript;

            cmbChapters.SelectedIndex = -1;
            cmbAvailableUntilChapter.SelectedIndex = -1;
            for (int i = 0; i < Globals.Chapters.Count; i++)
            {
                if (Globals.Chapters[i] == journal.MainStoryChapter)
                {
                    cmbChapters.SelectedIndex = i;
                }

                if (Globals.Chapters[i] == journal.UntilStoryChapter)
                {
                    cmbAvailableUntilChapter.SelectedIndex = i;
                }
            }
            
            nudStoryProgress.Value = journal.MainStoryProgress;
            nudAvailableUntilProgress.Value = journal.UntilStoryProgress;

            PopulatePages();
            AdjustTabNames();

            lbResults.SelectedIndexChanged += lbResults_SelectedIndexChanged;
            cmbChapters.SelectedIndexChanged += cmbChapters_SelectedIndexChanged;
            cmbAvailableUntilChapter.SelectedIndexChanged += cmbAvailableUntilChapter_SelectedIndexChanged;
        }

        private void PopulatePages()
        {
            var journal = Globals.Journals[selectedJournal];

            tcJournalPages.TabPages.Clear();

            var index = 0;
            foreach (var pageText in journal.Pages)
            {
                var pageContent = new TextBox();
                pageContent.Multiline = true;
                pageContent.Dock = DockStyle.Fill;
                pageContent.ScrollBars = ScrollBars.Vertical;
                pageContent.Tag = "" + index;
                pageContent.Text = pageText;
                pageContent.KeyUp += PageContent_KeyUp;
                pageContent.TextChanged += (object pcSender, EventArgs pcE) =>
                {
                    var casted = (TextBox)pcSender;
                    string tagValue = (string)casted.Tag;
                    int tagInt = 0;
                    if (int.TryParse(tagValue, out tagInt))
                    {
                        Globals.Journals[selectedJournal].Pages[tagInt] = casted.Text;
                    }
                };

                var page = new TabPage();
                page.Controls.Add(pageContent);

                tcJournalPages.TabPages.Add(page);
                index++;
            }

            AdjustTabNames();
        }

        private void PageContent_KeyUp(object sender, KeyEventArgs e)
        {
            var editor = (TextBox)sender;

            if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                if (!IsCursorValid(editor))
                    return;

                var construct = new CodeConstructForm();

                var wrapped = GetWrappedCode(editor);
                if (!string.IsNullOrEmpty(wrapped.Code))
                    construct.ConstructFromExisting(wrapped.Code);

                if (!wrapped.AfterTicks)
                {
                    construct.OnlyConditionals = true;
                    construct.Method = ConstructMethod.Simple;
                    construct.NoSwitching = true;
                }

                if (construct.ShowDialog() == DialogResult.OK)
                {
                    var start = "";
                    var end = "";
                    for (int i = 0; i < wrapped.Start; i++)
                        start += editor.Text[i];

                    for (int i = wrapped.End; i < editor.Text.Length; i++)
                        end += editor.Text[i];

                    editor.Text = start + construct.Code + end;
                }
            }
        }

        private bool IsCursorValid(TextBox pageEntry)
        {
            var result = true;
            var cursor = pageEntry.SelectionStart;
            var cursorEnd = pageEntry.SelectionLength;

            if (cursor == pageEntry.TextLength)
                cursor -= 1;

            var hasTicks = false;
            var series = "\r\n```\r\n";
            for (int i = cursor; i > 0; i--)
            {
                if (pageEntry.Text[i] == '\n')
                {
                    if (MatchesSeries(series, pageEntry.Text, i))
                    {
                        hasTicks = true;
                        break;
                    }
                }
            }

            if (hasTicks)
                return true;

            var hasPipe = false;
            for (int i = cursor; i > 0; i--)
            {
                if (pageEntry.Text[i] == '|')
                {
                    hasPipe = true;
                    break;
                }
            }

            if (!hasPipe)
                return false;

            var hasEndScript = false;
            for (int i = cursorEnd; i < pageEntry.Text.Length; i++)
            {
                if (pageEntry.Text[i] == ']')
                {
                    hasEndScript = true;
                    break;
                }
            }

            if (!hasEndScript)
                return false;

            return result;
        }

        private bool MatchesSeries(string series, string text, int cursor)
        {
            var start = cursor - series.Length + 1;
            var value = "";
            for (int i = start; i < cursor + 1; i++)
            {
                value += text[i];
            }

            return value == series;
        }

        private WrappedCode GetWrappedCode(TextBox pageEntry)
        {
            var result = "";
            var cursor = pageEntry.SelectionStart;
            var cursorEnd = pageEntry.SelectionLength;

            if (cursor == pageEntry.TextLength)
                cursor -= 1;

            var hasTicks = false;
            var series = "\r\n```\r\n";
            var startCode = 0;
            for (int i = cursor; i > 0; i--)
            {
                if (pageEntry.Text[i] == '\n')
                {
                    if (MatchesSeries(series, pageEntry.Text, i))
                    {
                        hasTicks = true;
                        startCode = i + 1;
                        break;
                    }
                }
            }

            if (hasTicks)
            {
                var code = "";
                for (int i = startCode; i < pageEntry.Text.Length; i++)
                {
                    code += pageEntry.Text[i];
                }

                return new WrappedCode(code, startCode, pageEntry.Text.Length, true);
            }

            var pipe = -1;
            for (int i = cursor; i > 0; i--)
            {
                if (pageEntry.Text[i] == '|')
                {
                    pipe = i;
                    break;
                }
            }

            var end = -1;
            for (int i = cursorEnd; i < pageEntry.Text.Length; i++)
            {
                if (pageEntry.Text[i] == ']')
                {
                    end = i;
                    break;
                }
            }

            for (int i = pipe + 1; i < end; i++)
            {
                result += pageEntry.Text[i];
            }

            return new WrappedCode(result, pipe + 1, end);
        }

        private struct WrappedCode
        {

            public string Code;
            public int Start;
            public int End;
            public bool AfterTicks;

            public WrappedCode(string code, int start, int end)
            {
                Code = code;
                Start = start;
                End = end;
                AfterTicks = false;
            }

            public WrappedCode(string code, int start, int end, bool afterTicks)
            {
                Code = code;
                Start = start;
                End = end;
                AfterTicks = afterTicks;
            }

        }

        private void AdjustTabNames()
        {
            var pageNo = 1;
            foreach (TabPage page in tcJournalPages.TabPages)
            {
                page.Text = "" + (pageNo++);
            }

            btnDeletePage.Enabled = tcJournalPages.TabCount > 1;
        }

        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbResults.SelectedIndex > -1)
            {
                selectedJournal = lbResults.SelectedIndex;
                pnlContent.Enabled = true;

                PopulateFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbResults.SelectedIndex > -1)
            {
                var response = MessageBox.Show("Are you sure you wish to delete this Journal entry?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes)
                {
                    // Perform relational deletion of all related content
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Globals.SaveJournals();
        }

        private void chbMainStory_CheckedChanged(object sender, EventArgs e)
        {
            pnlAvailableUntil.Visible = !chbMainStory.Checked;
            chbAccessedViaScript.Enabled = chbMainStory.Checked;
            Globals.Journals[selectedJournal].IsMainStory = chbMainStory.Checked;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Globals.Journals[selectedJournal].Name = txtName.Text;
            lbResults.Items[selectedJournal] = txtName.Text;
        }

        private void chbAccessedViaScript_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Journals[selectedJournal].AccessedViaScript = chbAccessedViaScript.Checked;
        }

        private void cmbChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.Journals[selectedJournal].MainStoryChapter = (string)cmbChapters.SelectedItem;
        }

        private void nudStoryProgress_ValueChanged(object sender, EventArgs e)
        {
            Globals.Journals[selectedJournal].MainStoryProgress = (int)nudStoryProgress.Value;
        }

        private void cmbAvailableUntilChapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.Journals[selectedJournal].UntilStoryChapter = (string)cmbAvailableUntilChapter.SelectedItem;
        }

        private void nudAvailableUntilProgress_ValueChanged(object sender, EventArgs e)
        {
            Globals.Journals[selectedJournal].UntilStoryProgress = (int)nudAvailableUntilProgress.Value;
        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            Globals.Journals[selectedJournal].Pages.Add("");
            PopulatePages();
        }

        private void btnDeletePage_Click(object sender, EventArgs e)
        {
            Globals.Journals[selectedJournal].Pages.RemoveAt(tcJournalPages.SelectedIndex);
            tcJournalPages.TabPages.RemoveAt(tcJournalPages.SelectedIndex);
            AdjustTabNames();
        }

        private void RefreshChapterLists()
        {
            cmbChapters.Items.Clear();
            cmbAvailableUntilChapter.Items.Clear();
            foreach (var chapter in Globals.Chapters)
            {
                cmbChapters.Items.Add(chapter);
                cmbAvailableUntilChapter.Items.Add(chapter);
            }
        }

        private void btnRefreshChapterLists_Click(object sender, EventArgs e)
        {
            RefreshChapterLists();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var journal = new Journal();
            journal.ID = ++Globals.GlobalIdentifiers.JournalID;
            Globals.SaveIdentifiers();
            Globals.Journals.Add(journal);

            PopulateJournals();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Journal>("Journals");
            search.SearchSelected += (int index) => lbResults.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}

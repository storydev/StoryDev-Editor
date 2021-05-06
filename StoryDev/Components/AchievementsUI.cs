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
    partial class AchievementsUI : UserControl
    {

        private int selectedAchievement;
        private CodeEditor scriptEditor;
        private IEnumerable<Character> chars;

        public AchievementsUI()
        {
            InitializeComponent();

            scriptEditor = new CodeEditor();
            scriptEditor.Dock = DockStyle.Fill;
            scriptEditor.TextChanged += ScriptEditor_TextChanged;
            scriptEditor.KeyUp += ScriptEditor_KeyUp;

            pnlScript.Controls.Add(scriptEditor);

            cmbGameEvent.Items.AddRange(Globals.GameEvents);

            PopulateList();
        }

        private void ScriptEditor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                var construct = new CodeConstructForm();
                if (!string.IsNullOrEmpty(scriptEditor.Text))
                    construct.ConstructFromExisting(scriptEditor.Text);

                if (construct.ShowDialog() == DialogResult.OK)
                {
                    scriptEditor.Text = construct.Code;
                }
            }
        }

        private void ScriptEditor_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (selectedAchievement > -1)
            {
                Globals.Achievements[selectedAchievement].Script = scriptEditor.Text;
            }
        }

        private void PopulateList()
        {
            lbResults.SelectedIndexChanged -= lbResults_SelectedIndexChanged;

            var temp = lbResults.SelectedIndex;

            lbResults.Items.Clear();
            foreach (var ach in Globals.Achievements)
            {
                lbResults.Items.Add(ach.Name);
            }

            if (temp < lbResults.Items.Count - 1)
                temp = lbResults.SelectedIndex;

            lbResults.SelectedIndexChanged += lbResults_SelectedIndexChanged;
        }

        private void PopulateFields()
        {
            if (selectedAchievement > -1)
            {
                var ach = Globals.Achievements[selectedAchievement];

                txtName.Text = ach.Name;
                txtDescription.Text = ach.Description;
                cmbCategory.SelectedIndex = ach.Category;
                var sub = DetermineSubCategory(ach.Category, ach.SubCategory);
                pnlSub.Visible = sub > -1;
                if (sub > -1)
                {
                    PopulateSubCategory(ach.Category);
                    if (ach.Category == 2)
                    {
                        for (int i = 0; i < chars.Count(); i++)
                        {
                            if (chars.ElementAt(i).ID == sub)
                            {
                                cmbSubCategory.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                    else
                    {
                        cmbSubCategory.SelectedIndex = sub;
                    }
                }

                cmbGameEvent.SelectedIndex = ach.GameEvent;
                cmbScriptType.SelectedIndex = ach.ScriptType;
                scriptEditor.Text = ach.Script;
            }
        }

        private void PopulateSubCategory(int category)
        {
            cmbSubCategory.Items.Clear();
            if (category == 1)
            {
                cmbSubCategory.Items.AddRange(Globals.Settings.ArtefactContextNames.Keys.ToArray());
            }
            else if (category == 2)
            {
                chars = Globals.Characters.Where((c) => c.PlayerCharacter);
                foreach (var character in chars)
                {
                    cmbSubCategory.Items.Add(character.FirstName);
                    cmbSubCategory.AutoCompleteCustomSource.Add(character.FirstName);
                }
            }
        }

        private int DetermineSubCategory(int category, int sub)
        {
            var result = -1;

            if (category == 1 || category == 2)
            {
                return sub;
            }

            return result;
        }

        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbResults.SelectedIndex > -1)
            {
                selectedAchievement = lbResults.SelectedIndex;

                pnlContent.Enabled = true;
                PopulateFields();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Globals.SaveAchievements();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedAchievement > -1)
            {
                var temp = selectedAchievement;
                Globals.Achievements.RemoveAt(temp);
                lbResults.Items.RemoveAt(temp);

                lbResults.SelectedIndex = selectedAchievement = -1;

                pnlContent.Enabled = false;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Achievement>("Achievements");
            search.SearchSelected += (int index) => lbResults.SelectedIndex = index;
            search.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var achievement = new Achievement();
            achievement.ID = ++Globals.GlobalIdentifiers.AchievementID;
            Globals.SaveIdentifiers();

            Globals.Achievements.Add(achievement);

            PopulateList();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (selectedAchievement > -1)
            {
                Globals.Achievements[selectedAchievement].Name = txtName.Text;
                lbResults.Items[selectedAchievement] = txtName.Text;
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (selectedAchievement > -1)
            {
                Globals.Achievements[selectedAchievement].Description = txtDescription.Text;
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedAchievement > -1)
            {
                Globals.Achievements[selectedAchievement].Category = cmbCategory.SelectedIndex;
                if (cmbCategory.SelectedIndex == 1 || cmbCategory.SelectedIndex == 2)
                {
                    PopulateSubCategory(cmbCategory.SelectedIndex);
                    pnlSub.Visible = true;
                }
                else
                {
                    pnlSub.Visible = false;
                    Globals.Achievements[selectedAchievement].SubCategory = -1;
                }
            }
        }

        private void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedAchievement > -1)
            {
                var sub = DetermineSubCategory(cmbCategory.SelectedIndex, cmbSubCategory.SelectedIndex);
                if (sub > -1)
                {
                    if (cmbCategory.SelectedIndex == 2)
                    {
                        Globals.Achievements[selectedAchievement].SubCategory = chars.ElementAt(sub).ID;
                    }
                    else
                    {
                        Globals.Achievements[selectedAchievement].SubCategory = sub;
                    }
                }
                else
                {
                    Globals.Achievements[selectedAchievement].SubCategory = sub;
                }
            }
        }

        private void cmbGameEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedAchievement > -1)
            {
                Globals.Achievements[selectedAchievement].GameEvent = cmbGameEvent.SelectedIndex;
            }
        }

        private void cmbScriptType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedAchievement > -1)
            {
                Globals.Achievements[selectedAchievement].ScriptType = cmbScriptType.SelectedIndex;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FastColoredTextBoxNS;

using StoryDev.Data;
using StoryDev.Components;

namespace StoryDev.Forms
{
    partial class EditGossipsForm : Form
    {

        private int selectedOption;
        private CharacterGossip gossip;
        private CodeEditor editor;
        private CodeEditor conditionEditor;

        public EditGossipsForm(CharacterGossip gossip)
        {
            InitializeComponent();

            editor = new CodeEditor();
            editor.CurrentLanguage = Components.Language.HaxeScript;
            editor.Dock = DockStyle.Fill;
            editor.TextChanged += Editor_TextChanged;
            editor.Enabled = false;
            editor.KeyUp += Editor_KeyUp;
            pnlCodeContent.Controls.Add(editor);

            conditionEditor = new CodeEditor();
            conditionEditor.Dock = DockStyle.Fill;
            conditionEditor.Enabled = false;
            conditionEditor.TextChanged += ConditionEditor_TextChanged;
            conditionEditor.KeyUp += ConditionEditor_KeyUp;

            pnlCondition.Controls.Add(conditionEditor);

            foreach (var character in Globals.Characters)
            {
                cmbCharacter.AutoCompleteCustomSource.Add(character.FirstName);
                cmbCharacter.Items.Add(character.FirstName);
            }

            this.gossip = gossip;

            PopulateFields();
        }

        private void ConditionEditor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                var construct = new CodeConstructForm();
                if (!string.IsNullOrEmpty(conditionEditor.Text))
                    construct.ConstructFromExisting(editor.Text);

                if (construct.ShowDialog() == DialogResult.OK)
                {
                    conditionEditor.Text = construct.Code;
                }
            }
        }

        private void Editor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                var construct = new CodeConstructForm();
                if (!string.IsNullOrEmpty(editor.Text))
                    construct.ConstructFromExisting(editor.Text);

                if (construct.ShowDialog() == DialogResult.OK)
                {
                    editor.Text = construct.Code;
                }
            }
        }

        private void ConditionEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (selectedOption > -1)
            {
                gossip.GossipOptionCondition[selectedOption] = conditionEditor.Text;
            }
        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (selectedOption > -1)
            {
                gossip.Script[selectedOption] = editor.Text;
            }
        }

        private void PopulateFields()
        {
            cmbCharacter.SelectedIndex = Globals.GetCharacterIndex(gossip.CharacterID);
            chbVisible.Checked = gossip.Visible;

            lbGossipOptions.Items.Clear();
            foreach (var display in gossip.DisplayOption)
            {
                lbGossipOptions.Items.Add(display);
            }
        }

        private void PopulateOption()
        {
            if (selectedOption > -1)
            {
                conditionEditor.TextChanged -= ConditionEditor_TextChanged;
                editor.TextChanged -= Editor_TextChanged;

                conditionEditor.Text = gossip.GossipOptionCondition[selectedOption];
                editor.Text = gossip.Script[selectedOption];

                conditionEditor.TextChanged += ConditionEditor_TextChanged;
                editor.TextChanged += Editor_TextChanged;
            }
        }

        private void cmbCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCharacter.SelectedIndex > -1)
                gossip.CharacterID = Globals.Characters[cmbCharacter.SelectedIndex].ID;
        }

        private void txtCreate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtCreate.Text))
            {
                gossip.DisplayOption.Add(txtCreate.Text);
                gossip.GossipOptionCondition.Add("");
                gossip.Script.Add("");

                selectedOption = lbGossipOptions.SelectedIndex = -1;
                conditionEditor.Enabled = false;
                editor.Enabled = false;

                PopulateFields();

                conditionEditor.Text = "";
                editor.Text = "";
            }
        }

        private void lbGossipOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbGossipOptions.SelectedIndex > -1)
            {
                selectedOption = lbGossipOptions.SelectedIndex;

                conditionEditor.Enabled = true;
                editor.Enabled = true;

                PopulateOption();
            }
        }

        private void EditGossipsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void chbVisible_CheckedChanged(object sender, EventArgs e)
        {
            gossip.Visible = chbVisible.Checked;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using StoryDev.Components;
using StoryDev.Lib.StoryDev;

namespace StoryDev.Forms
{
    partial class ConversationEditor : Form
    {

        private string currentFile;
        private string fileShortName;
        private bool unsaved = false;

        private List<string> convoData;
        private List<ChoiceData> choices;

        private Parser sdParser;

        private SimulationForm simulation;
        private VarTrackerForm tracker;

        public ConversationEditor()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            simulation = new SimulationForm();
            simulation.FormClosing += Simulation_FormClosing;
            simulation.SimulationStarted += Simulation_SimulationStarted;
            simulation.SimulationStopped += Simulation_SimulationStopped;

            storyEditor.CurrentLanguage = Language.StoryScript;

            sdParser = new Parser();

            cmbView.SelectedIndex = 0;
            convoData = new List<string>();
            choices = new List<ChoiceData>();
        }

        private void Simulation_SimulationStopped()
        {
            tracker.Close();
            tracker = null;
        }

        private void Simulation_SimulationStarted(StateTemplate template)
        {
            if (tracker != null)
            {
                tracker.Dispose();
            }

            tracker = new VarTrackerForm(template);
            tracker.Show(this);
        }

        private void Simulation_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            simulation.Hide();
            simulationsToolStripMenuItem.Checked = false;
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbView.SelectedIndex == 0)
                branchDesignerUI1.View = Components.BranchView.Branch;
            else if (cmbView.SelectedIndex == 1)
                branchDesignerUI1.View = Components.BranchView.List;
        }

        private void chbSnapping_CheckedChanged(object sender, EventArgs e)
        {
            branchDesignerUI1.Snapping = chbSnapping.Checked;
        }

        private void PopulateChoices(int index)
        {
            pnlChoices.Controls.Clear();
            for (int i = 0; i < choices.Count; i++)
            {
                if (choices[i].CurrentIndex == index)
                {
                    var choiceUI = new ChoiceUI(choices[i]);
                    choiceUI.Dock = DockStyle.Top;
                    choiceUI.SetGoingToName(branchDesignerUI1.GetNameByIndex(choices[i].ChildIndex));

                    pnlChoices.Controls.Add(choiceUI);
                    pnlChoices.Controls.SetChildIndex(choiceUI, 0);
                }
            }
        }

        private void branchDesignerUI1_BranchSelectedIndexChanged(int index)
        {
            if (index == -1)
            {
                storyEditor.Text = "";
                storyEditor.Enabled = false;
                cmbBranches.SelectedIndex = -1;
                pnlChoiceProperties.Enabled = false;
                pnlChoices.Controls.Clear();
            }
            else if (index < cmbBranches.Items.Count)
            {
                MarkAsUnsaved();
                cmbBranches.SelectedIndex = index;
                pnlChoiceProperties.Enabled = true;

                PopulateChoices(index);
            }

            storyEditor.ClearUndo();
        }

        private void branchDesignerUI1_BranchRenamed(int index, string branchName)
        {
            if (index < cmbBranches.Items.Count)
            {
                MarkAsUnsaved();
                cmbBranches.Items[index] = branchName;
            }
        }

        private void branchDesignerUI1_BranchAdded(string branchName)
        {
            MarkAsUnsaved();

            var current = branchDesignerUI1.GetSelectedIndex();

            var choice = new ChoiceData();
            choice.ChildIndex = branchDesignerUI1.GetNameIndex(branchName);
            choice.CurrentIndex = current;
            choices.Add(choice);

            PopulateChoices(current);

            cmbBranches.Items.Add(branchName);
            convoData.Add("");
        }

        private void MarkAsUnsaved()
        {
            if (!string.IsNullOrEmpty(fileShortName))
            {
                unsaved = true;
                Text = "*Conversation Editor - " + fileShortName;
            }
        }

        private void ConversationEditor_Load(object sender, EventArgs e)
        {
            if (Globals.Simulation.EnableSimulationsStartup)
            {
                simulation.Show(this);
                simulationsToolStripMenuItem.Checked = true;
            }
        }

        private void SaveCurrent()
        {
            if (!string.IsNullOrEmpty(currentFile))
            {
                var branchData = branchDesignerUI1.ToFileData();
                File.WriteAllText(currentFile + ".sdd", branchData);

                var convo = "";
                for (int i = 0; i < convoData.Count; i++)
                {
                    convo += "convo " + cmbBranches.Items[i] + "\r\n";
                    convo += convoData[i] + "\r\n";
                    var _choices = choices.Where((c) => c.CurrentIndex == i);
                    foreach (var choice in _choices)
                    {
                        if (!string.IsNullOrEmpty(choice.Condition))
                            convo += "=! " + choice.Condition + "\r\n";

                        var _goto = branchDesignerUI1.GetNameByIndex(choice.ChildIndex);

                        convo += "> " + branchDesignerUI1.GetNameByIndex(choice.ChildIndex) + " -> goto(\"" + _goto + "\"); " + choice.Code;
                        convo += "\r\n";
                    }
                    convo += "\r\n";
                }

                sdParser.Clear();
                if (sdParser.Validate(convo, currentFile + ".sdc") > -1)
                {
                    File.WriteAllText(currentFile + ".sdc", convo);

                    unsaved = false;
                    Text = "Conversation Editor - " + fileShortName;
                }
            }
        }

        private void LoadCurrent()
        {
            var needsData = true;
            if (File.Exists(currentFile + ".sdd"))
            {
                var content = File.ReadAllText(currentFile + ".sdd");
                if (!string.IsNullOrEmpty(content))
                {
                    branchDesignerUI1.FromFileData(content);
                    needsData = false;
                }
            }

            if (needsData)
            {
                MessageBox.Show("The selected conversation is missing its branch data. You will have to recreate this conversation file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentFile = "";

                return;
            }

            if (File.Exists(currentFile + ".sdc"))
            {
                choices = new List<ChoiceData>();
                convoData = new List<string>();

                sdParser.Clear();
                if (sdParser.ParseFile(currentFile + ".sdc") > -1)
                {
                    var blocks = sdParser.GetBlocks();
                    var convo = "";
                    var choice = new ChoiceData();
                    for (int i = 0; i < blocks.Count; i++)
                    {
                        var b = blocks[i];
                        convo = "";

                        cmbBranches.Items.Add(b.Title);
                        choice.CurrentIndex = branchDesignerUI1.GetNameIndex(b.Title);

                        for (int j = 0; j < b.Commands.Count; j++)
                        {
                            var command = b.Commands[j];

                            switch (command.Type)
                            {
                                case (int)CommandType.Choices:
                                    {
                                        foreach (var ch in command.Data)
                                        {
                                            var split = ch.Split('|');
                                            choice.ChildIndex = branchDesignerUI1.GetNameIndex(split[0]);

                                            var gotol = ("goto(\"" + split[0] + "\");").Length;
                                            if (gotol < split[1].Length)
                                            {
                                                var extracted = split[1].Substring(gotol);
                                                choice.Code = extracted;
                                            }
                                            choices.Add(choice);

                                            var temp = choice.CurrentIndex;
                                            choice = new ChoiceData();
                                            choice.CurrentIndex = temp;
                                        }
                                    } break;
                                case (int)CommandType.CodeLine:
                                    {
                                        convo += "! " + command.Data[0] + "\r\n";
                                    } break;
                                case (int)CommandType.Narrative:
                                    {
                                        convo += ": " + command.Data[0] + "\r\n";
                                    } break;
                                case (int)CommandType.Dialogue:
                                    {
                                        convo += command.Data[0] + " : " + command.Data[1] + "\r\n";
                                    }
                                    break;
                                case (int)CommandType.OverlayTitle:
                                    {
                                        convo += "~ " + command.Data[0] + "\r\n";
                                    }
                                    break;
                                case (int)CommandType.OptionConditional:
                                    {
                                        if (j + 1 < b.Commands.Count)
                                        {
                                            var next = b.Commands[j + 1];
                                            if (next.Type == (int)CommandType.Choices)
                                            {
                                                choice.Condition = command.Data[0];
                                            }
                                            else
                                            {
                                                convo += "=! " + command.Data[0] + "\r\n";
                                            }
                                        }
                                    } break;
                            }
                        }

                        convoData.Add(convo);
                    }
                }
            }

            var file = currentFile.Substring(currentFile.LastIndexOf('\\') + 1);
            fileShortName = file;
            Text = "Conversation Editor - " + file;

            saveConversationToolStripMenuItem.Enabled = true;
            branchDesignerUI1.Enabled = true;
            pnlChoiceProperties.Enabled = true;
            pnlTools.Enabled = true;
            unsaved = false;
        }

        private void CloseCurrent()
        {
            branchDesignerUI1.Clear();
            cmbBranches.Items.Clear();
            storyEditor.Text = "";
            storyEditor.Enabled = false;
            pnlChoiceProperties.Enabled = false;
        }

        private void saveConversationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCurrent();
            
        }

        private void cmbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBranches.SelectedIndex > -1)
            {
                branchDesignerUI1.BranchSelectedIndexChanged -= branchDesignerUI1_BranchSelectedIndexChanged;
                branchDesignerUI1.SelectBranch(cmbBranches.SelectedIndex);

                storyEditor.Text = convoData[cmbBranches.SelectedIndex];
                storyEditor.Enabled = true;

                branchDesignerUI1.BranchSelectedIndexChanged += branchDesignerUI1_BranchSelectedIndexChanged;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unsaved)
            {
                var response = MessageBox.Show("Save changes?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes)
                {
                    SaveCurrent();
                    CloseCurrent();
                }
                else if (response == DialogResult.Cancel)
                {
                    return;
                }
            }

            var open = new OpenFileDialog();
            open.Filter = "StoryDev Conversations|*.sdd;*.sdc";
            open.Title = "Open Conversation";
            open.InitialDirectory = Globals.CurrentProjectFolder + "\\Chapters\\";
            open.Multiselect = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                currentFile = open.FileName.Substring(0, open.FileName.LastIndexOf('.'));

                LoadCurrent();
            }
        }

        private void storyEditor_Load(object sender, EventArgs e)
        {
            
        }

        private void storyEditor_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (cmbBranches.SelectedIndex > -1 && branchDesignerUI1.GetSelectedIndex() > -1)
            {
                convoData[cmbBranches.SelectedIndex] = storyEditor.Text;
                MarkAsUnsaved();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unsaved)
            {
                var response = MessageBox.Show("Save changes?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes)
                {
                    SaveCurrent();
                }
                else if (response == DialogResult.Cancel)
                {
                    return;
                }
            }

            var save = new SaveFileDialog();
            save.Filter = "StoryDev Conversations|*.sdd;*.sdc";
            save.Title = "Open Conversation";
            save.InitialDirectory = Globals.CurrentProjectFolder + "\\Chapters\\";
            if (save.ShowDialog() == DialogResult.OK)
            {
                currentFile = save.FileName.Substring(0, save.FileName.LastIndexOf('.'));

                var file = currentFile.Substring(currentFile.LastIndexOf('\\') + 1);
                fileShortName = file;
                Text = "Conversation Editor - " + file;

                MarkAsUnsaved();
                branchDesignerUI1.AddBranch(new PointF(50, 50), "Untitled");
                cmbBranches.Items.Add("Untitled");
                convoData.Add("");

                SaveCurrent();

                saveConversationToolStripMenuItem.Enabled = true;
                branchDesignerUI1.Enabled = true;
                pnlChoiceProperties.Enabled = true;
                pnlTools.Enabled = true;
                unsaved = false;
            }
        }

        private void storyEditor_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(storyEditor.SelectedText) && e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                var line = storyEditor.GetLineText(storyEditor.Selection.FromLine);
                var code = "";
                var isExecute = false;
                if (line.StartsWith("!"))
                {
                    isExecute = true;
                    code = line.Substring(2);
                }
                else if (line.StartsWith("=!"))
                    code = line.Substring(3);
                else
                    return;

                var construct = new CodeConstructForm();
                if (!string.IsNullOrEmpty(code))
                    construct.ConstructFromExisting(code);

                construct.OnlyConditionals = line.StartsWith("=!");
                construct.OnlyExecutables = line.StartsWith("!");
                construct.NoSwitching = true;
                construct.Method = ConstructMethod.Simple;
                if (construct.ShowDialog() == DialogResult.OK)
                {
                    var lineRange = storyEditor.GetLine(storyEditor.Selection.FromLine);
                    storyEditor.Selection.Start = lineRange.Start;
                    storyEditor.Selection.End = lineRange.End;
                    storyEditor.ClearSelected();

                    if (!isExecute)
                    {
                        storyEditor.InsertText("=! " + construct.Code);
                    }
                    else
                    {
                        storyEditor.InsertText("! " + construct.Code);
                    }
                }
            }
        }

        private void branchDesignerUI1_BranchDeleted(int index)
        {
            var startIndex = -1;
            for (int i = 0; i < choices.Count; i++)
            {
                if (choices[i].ChildIndex == index)
                    startIndex = i;

                if (startIndex > -1)
                {
                    if (i + 1 < choices.Count)
                    {
                        choices[i] = choices[i + 1];
                        if (choices[i].ChildIndex > -1)
                            choices[i].ChildIndex -= 1;
                        if (choices[i].CurrentIndex > -1)
                            choices[i].CurrentIndex -= 1;
                    }
                }
            }

            choices.RemoveAt(choices.Count - 1);

            storyEditor.TextChanged -= storyEditor_TextChanged;
            storyEditor.Text = "";
            storyEditor.TextChanged += storyEditor_TextChanged;

            storyEditor.Enabled = false;
            pnlChoiceProperties.Enabled = false;
            cmbBranches.Items.RemoveAt(index);
            convoData.RemoveAt(index);
        }

        private void branchDesignerUI1_BranchesLinked(int parent, int child)
        {
            var choice = new ChoiceData();
            choice.ChildIndex = child;
            choice.CurrentIndex = parent;

            choices.Add(choice);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SimulationOptionsForm().ShowDialog();
        }

        private void simulationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (simulationsToolStripMenuItem.Checked)
            {
                simulation.Show(this);
            }
            else
            {
                simulation.Hide();
            }
        }

        private void ConversationEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            simulation.Dispose();
            simulation = null;
        }
    }

    class ChoiceData
    {

        public int Priority;
        public int ChildIndex;
        public int CurrentIndex;
        public string Code;
        public string Condition;

        public ChoiceData()
        {

        }

    }
}

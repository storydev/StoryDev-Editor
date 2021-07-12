using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using StoryDev.Data;
using StoryDev.Simulation;
using StoryDev.Components;
using StoryDev.Lib.StoryDev;

namespace StoryDev.Forms
{
    partial class ConversationEditor : Form
    {

        private CancellationTokenSource simulationToken;
        private Task<bool> runningSimulation;

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

            simulationToken = new CancellationTokenSource();

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
            if (runningSimulation != null)
            {
                if (runningSimulation.Status == TaskStatus.Running)
                {
                    simulationToken.Cancel();
                }
            }
        }

        private async void Simulation_SimulationStarted(StateTemplate template, List<int> outcomes)
        {
            if (string.IsNullOrEmpty(currentFile))
            {
                MessageBox.Show("You must open a file to start the simulation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                simulation.Interrupt();
                return;
            }

            foreach (var outcome in outcomes)
            {
                if (outcome == 0)
                {
                    Engine.Instance.ProduceBestOutcome = true;
                }

                if (outcome == 1)
                {
                    Engine.Instance.ProduceWorstOutcome = true;
                }
            }
            
            Invoke((MethodInvoker)delegate { CreateTracker(template, outcomes); });

            var sdcFile = currentFile.Substring(Globals.CurrentProjectFolder.Length + 1) + ".sdc";
            if (await Engine.Instance.PlayAsync(sdcFile, simulationToken.Token))
            {
                
            }
            else
            {
                simulation.UpdateAllMessages();
            }
        }

        private void CreateTracker(StateTemplate template, List<int> outcomes)
        {
            var trackerOpen = false;
            if (tracker == null)
            {
                tracker = new VarTrackerForm(template, outcomes);
                tracker.FormClosing += Tracker_FormClosing;
            }
            else
                trackerOpen = true;

            Engine.Instance.CreateStates();

            if (Engine.Instance.ProduceBestOutcome && !trackerOpen)
            {
                tracker.AddState(Engine.Instance.GetBestState(), 0);
            }

            if (Engine.Instance.ProduceWorstOutcome && !trackerOpen)
            {
                tracker.AddState(Engine.Instance.GetWorstState(), 1);
            }

            if (!tracker.Visible)
                tracker.Show(this);
        }

        private void Tracker_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            tracker.Hide();
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
                branchDesignerUI1.View = BranchView.Branch;
            else if (cmbView.SelectedIndex == 1)
                branchDesignerUI1.View = BranchView.List;
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
                    var options = "";
                    foreach (var choice in _choices)
                    {
                        if (!string.IsNullOrEmpty(choice.Condition))
                            convo += "=! " + choice.Condition + "\r\n";

                        var _goto = branchDesignerUI1.GetNameByIndex(choice.ChildIndex);

                        options += "= PRIORITY " + choice.Priority + "\r\n";
                        var code = "";
                        if (!string.IsNullOrEmpty(choice.Code))
                            code = choice.Code;

                        convo += "> " + branchDesignerUI1.GetNameByIndex(choice.ChildIndex) + " -> goto(\"" + _goto + "\"); " + code;
                        convo += "\r\n";
                    }
                    convo += options;
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
                    var convoLink = Globals.ConvoMapLinks.Where((link) => link.ConversationFile == currentFile);
                    if (convoLink.Count() > 0)
                    {
                        var link = convoLink.First();
                        var actualMap = Globals.Maps.Find((m) => m.ID == link.MapID);
                        txtMapPointAssoc.Text = actualMap.Name + ": " + actualMap.Points[link.MapPoint].Name;
                    }
                    else
                    {
                        txtMapPointAssoc.Text = "";
                    }

                    cmbBranches.Items.Clear();

                    var blocks = sdParser.GetBlocks();
                    var convo = "";
                    var choice = new ChoiceData();
                    var choicePriorities = new List<int>();
                    var choiceConditionals = new List<string>();
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
                                        for (int k = 0; k < command.Data.Count; k++)
                                        {
                                            var ch = command.Data[k];
                                            var priority = 0;
                                            if (k < choicePriorities.Count)
                                               priority = choicePriorities[k];

                                            var split = ch.Split('|');
                                            choice.ChildIndex = branchDesignerUI1.GetNameIndex(split[0]);
                                            choice.Priority = priority;

                                            var gotol = ("goto(\"" + split[0] + "\");").Length;
                                            if (gotol < split[1].Length)
                                            {
                                                var extracted = split[1].Substring(gotol);
                                                choice.Code = extracted;
                                            }

                                            if (k < choiceConditionals.Count)
                                                choice.Condition = choiceConditionals[k];

                                            choices.Add(choice);

                                            var temp = choice.CurrentIndex;
                                            choice = new ChoiceData();
                                            choice.CurrentIndex = temp;
                                        }

                                        choiceConditionals.Clear();
                                        choicePriorities.Clear();
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
                                case (int)CommandType.FallThrough:
                                    {
                                        if (string.IsNullOrEmpty(command.Data[0]))
                                            convo += "|=>\r\n";
                                        else
                                            convo += "|= " + command.Data[0] + " >\r\n";
                                    } break;
                                case (int)CommandType.OptionConditional:
                                    {
                                        if (j + 1 < b.Commands.Count)
                                        {
                                            var found = false;
                                            for (int k = j + 1; k < b.Commands.Count; k++)
                                            {
                                                var next = b.Commands[k];
                                                if (next.Type == (int)CommandType.BlockStart || 
                                                    next.Type == (int)CommandType.Character ||
                                                    next.Type == (int)CommandType.CodeLine ||
                                                    next.Type == (int)CommandType.Dialogue ||
                                                    next.Type == (int)CommandType.DialogueBlock ||
                                                    next.Type == (int)CommandType.Goto ||
                                                    next.Type == (int)CommandType.InternalDialogue ||
                                                    next.Type == (int)CommandType.Narrative ||
                                                    next.Type == (int)CommandType.NewConvo ||
                                                    next.Type == (int)CommandType.OverlayTitle)
                                                {
                                                    found = true;
                                                    break;
                                                }
                                            }

                                            if (found)
                                            {
                                                convo += "=! " + command.Data[0] + "\r\n";
                                            }
                                            else
                                            {
                                                choiceConditionals.Add(command.Data[0]);
                                            }
                                        }
                                    } break;
                                case (int)CommandType.Option:
                                    {
                                        var text = command.Data[0];
                                        if (text.StartsWith("PRIORITY"))
                                        {
                                            var priorityText = text.Substring("PRIORITY ".Length);
                                            var priority = int.Parse(priorityText);
                                            choicePriorities.Add(priority);
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
                PopulateChoices(cmbBranches.SelectedIndex);

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

                convoData.Clear();
                choices.Clear();
                cmbBranches.Items.Clear();
                branchDesignerUI1.Clear();

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

            if (choices.Count > 0)
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

        private void storyOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StoryOrderForm().ShowDialog();
        }

        private void customVariablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomVariablesForm().Show(this);
        }

        private void btnBrowseMaps_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFile))
            {
                var browser = new MapBrowserForm();
                browser.MapSelected += Browser_MapSelected;
                browser.ShowDialog();
            }
        }

        private void Browser_MapSelected(int map, int point)
        {
            var convoLink = Globals.ConvoMapLinks.Where((link) => link.ConversationFile == currentFile);
            if (convoLink.Count() == 0)
            {
                var link = new ConvoMapLink();
                link.ConversationFile = currentFile;
                link.MapID = map;
                link.MapPoint = point;
                Globals.ConvoMapLinks.Add(link);
                Globals.SaveConvoMapLinks();

                var actualMap = Globals.Maps.Find((m) => m.ID == map);

                txtMapPointAssoc.Text = actualMap.Name + ": " + actualMap.Points[point].Name;
            }
        }
    }

    class ChoiceData : IComparable<ChoiceData>
    {

        public int Priority;
        public int ChildIndex;
        public int CurrentIndex;
        public string Code;
        public string Condition;

        public ChoiceData()
        {

        }

        public int CompareTo(ChoiceData other)
        {
            return other.Priority.CompareTo(this.Priority);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Jint;

using StoryDev.Forms;
using StoryDev.Lib.StoryDev;

namespace StoryDev.Simulation
{
    class Engine
    {

        private const int LAST_RECORDED = 0;
        private const int PREV_BEST = 1;
        private const int PREV_WORST = 2;
        private const int CURRENT_BEST = 3;
        private const int CURRENT_WORST = 4;

        private Jint.Engine jEngine;
        private List<PlayerState> states;
        private int bestOutcomeIndex;
        private int worstOutcomeIndex;
        private int currentIndex;

        private PlayerState currentState;
        private CallStack callStack;
        private Dictionary<string, List<Message>> messages;

        private string currentFile;
        private int currentLine;

        private List<string> conversations;
        private Parser sdParser;
        

        public bool EnableCallstack
        {
            get; set;
        }

        public CallStack CallStack
        {
            get { return callStack; }
        }

        public bool ProduceBestOutcome
        {
            get; set;
        }

        public bool ProduceWorstOutcome
        {
            get; set;
        }



        public Engine()
        {
            jEngine = new Jint.Engine();
            states = new List<PlayerState>();
            callStack = new CallStack();
            messages = new Dictionary<string, List<Message>>();
            sdParser = new Parser();

            InitScripts();
            RefreshVariableList();
        }

        public PlayerState GetBestState()
        {
            if (ProduceBestOutcome)
                return states[bestOutcomeIndex];

            return null;
        }

        public PlayerState GetWorstState()
        {
            if (ProduceWorstOutcome)
                return states[worstOutcomeIndex];

            return null;
        }

        public void RefreshVariableList()
        {
            foreach (var variable in Globals.Variables)
            {
                jEngine.SetValue(variable.Name, variable.DefaultValue);
            }
        }

        public async Task<bool> PlayAsync(string conversation, CancellationToken token)
        {
            conversations = new List<string>();
            states = new List<PlayerState>();
            currentIndex = 0;

            conversation = conversation.Replace('\\', '/');

            if (ProduceBestOutcome)
            {
                states.Add(new PlayerState());
                bestOutcomeIndex = currentIndex++;
            }

            if (ProduceWorstOutcome)
            {
                states.Add(new PlayerState());
                worstOutcomeIndex = currentIndex++;
            }

            var currentMainStoryIndex = 0;
            var reached = false;

            if (Globals.StoryOrder.IncludeJournals)
            {
                var parts = new List<int>();
                var partIndex = new List<int>();
                foreach (var part in Globals.StoryOrder.JournalsAfterPart)
                {
                    parts.Add(part.Value);
                    partIndex.Add(part.Key);
                }

                parts.Sort();
                partIndex.Join(parts, i => i, d => d, (i, d) => d);

                for (int i = 0; i < parts.Count; i++)
                {
                    if (parts[i] >= currentMainStoryIndex)
                    {
                        for (int j = 0; j < parts[i]; j++)
                        {
                            if (Globals.StoryOrder.MainStory[j] != conversation)
                            {
                                conversations.Add(Globals.StoryOrder.MainStory[j]);
                            }
                            else
                            {
                                reached = true;
                                break;
                            }
                        }

                        if (reached)
                            break;
                    }
                    else
                    {
                        var key = partIndex[i];
                        var list = Globals.StoryOrder.JournalStories[key];
                        foreach (var order in list)
                        {
                            if (order != conversation)
                            {
                                conversations.Add(order);
                            }
                            else
                            {
                                reached = true;
                                break;
                            }
                        }

                        if (reached)
                            break;
                    }
                }
            }
            else
            {
                foreach (var order in Globals.StoryOrder.MainStory)
                {
                    if (conversation != order)
                    {
                        conversations.Add(order);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return await Task.Run(ExecuteSimulation, token);
        }

        private bool ExecuteSimulation()
        {
            if (conversations.Count == 0)
                return false;

            var errorsProduced = false;

            for (int i = 0; i < states.Count; i++)
            {
                currentState = states[i];
                
                foreach (var convo in conversations)
                {
                    if (errorsProduced)
                        return false;

                    sdParser.Clear();
                    sdParser.ParseFile(Globals.CurrentProjectFolder + "\\" + convo);

                    var choices = new List<ChoiceData>();
                    var choicePriorities = new List<int>();
                    var choice = new ChoiceData();
                    var nextBlockIndex = -1;

                    for (int j = 0; j < sdParser.GetBlocks().Count; j++)
                    {
                        var block = sdParser.GetBlocks()[j];

                        if (nextBlockIndex > -1)
                        {
                            if (nextBlockIndex != j)
                                continue;
                        }

                        var line = 0;
                        var executeUpToNextConditional = -1;
                        var skipNext = false;
                        var codeText = "";
                        

                        for (int c = 0; c < block.Commands.Count; c++)
                        {
                            line++;
                            var command = block.Commands[c];

                            if (command.Type == (int)CommandType.OptionConditional && executeUpToNextConditional == -1)
                            {
                                var code = command.Data[0];
                                if (string.IsNullOrEmpty(code))
                                {
                                    skipNext = false;
                                    executeUpToNextConditional = c;
                                    continue;
                                }

                                var result = jEngine.Evaluate(code);
                                if (result.IsBoolean())
                                {
                                    if (result.AsBoolean())
                                    {
                                        executeUpToNextConditional = c;
                                        continue;
                                    }
                                    else
                                    {
                                        skipNext = true;
                                    }
                                }
                                else if (result.IsNull() || result.IsUndefined())
                                {
                                    SetMessage("", new Message("Invalid Eval",
                                        string.Format("Code at {0}:({1}):{2} produced a null or undefined value.", convo, block.Title, c),
                                        MessageType.Error, convo, line));
                                    errorsProduced = true;
                                    continue;
                                }
                            }
                            else
                            {
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
                                                choice.ChildIndex = sdParser.GetBlockIndexByTitle(split[0]);
                                                choice.Priority = priority;

                                                var gotol = ("goto(\"" + split[0] + "\");").Length;
                                                if (gotol < split[1].Length)
                                                {
                                                    var extracted = split[1].Substring(gotol);
                                                    choice.Code = extracted;
                                                }
                                                choices.Add(choice);

                                                choice = new ChoiceData();
                                            }

                                            choicePriorities.Clear();
                                        } break;
                                    case (int)CommandType.OptionConditional:
                                        {
                                            if (j + 1 < block.Commands.Count)
                                            {
                                                var found = false;
                                                for (int k = j + 1; k < block.Commands.Count; k++)
                                                {
                                                    var next = block.Commands[k];
                                                    if (next.Type == (int)CommandType.BlockStart ||
                                                        next.Type == (int)CommandType.Character ||
                                                        next.Type == (int)CommandType.CodeLine ||
                                                        next.Type == (int)CommandType.Dialogue ||
                                                        next.Type == (int)CommandType.DialogueBlock ||
                                                        next.Type == (int)CommandType.Goto ||
                                                        next.Type == (int)CommandType.InternalDialogue ||
                                                        next.Type == (int)CommandType.Narrative ||
                                                        next.Type == (int)CommandType.NewConvo ||
                                                        next.Type == (int)CommandType.OverlayTitle ||
                                                        next.Type == (int)CommandType.OptionConditional)
                                                    {
                                                        found = true;
                                                        break;
                                                    }
                                                }

                                                if (!found)
                                                {
                                                    choice.Condition = command.Data[0];
                                                }
                                                else
                                                {
                                                    var result = jEngine.Evaluate(command.Data[0]);
                                                    if (result.IsBoolean())
                                                    {
                                                        if (result.AsBoolean())
                                                        {
                                                            if (executeUpToNextConditional > -1)
                                                            {
                                                                skipNext = true;
                                                                continue;
                                                            }
                                                        }
                                                    }
                                                    else if (result.IsNull() || result.IsUndefined())
                                                    {
                                                        SetMessage("", new Message("Invalid Eval",
                                                            string.Format("Code at {0}:({1}):{2} produced a null or undefined value.", convo, block.Title, c),
                                                            MessageType.Error, convo, line));
                                                        errorsProduced = true;
                                                        continue;
                                                    }

                                                    
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
                                    case (int)CommandType.CodeLine:
                                        {
                                            if (!skipNext)
                                                codeText += command.Data[0];
                                        } break;
                                }
                            }

                            // end of block, execute choices/conditionals
                            if (c + 1 == block.Commands.Count)
                            {
                                jEngine.Execute(codeText);
                                choices.Sort();

                                if (i == bestOutcomeIndex)
                                {
                                    foreach (var ch in choices)
                                    {
                                        if (!string.IsNullOrEmpty(ch.Condition))
                                        {
                                            var result = jEngine.Evaluate(ch.Condition);
                                            if (result.IsBoolean())
                                            {
                                                if (result.AsBoolean())
                                                {
                                                    jEngine.Execute(ch.Code);
                                                    nextBlockIndex = ch.ChildIndex;
                                                    break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (!string.IsNullOrEmpty(ch.Code))
                                                jEngine.Execute(ch.Code);

                                            nextBlockIndex = ch.ChildIndex;
                                            break;
                                        }
                                    }
                                }
                                else if (i == worstOutcomeIndex)
                                {
                                    for (int k = choices.Count - 1; k > -1; k--)
                                    {
                                        var ch = choices[k];
                                        if (!string.IsNullOrEmpty(ch.Condition))
                                        {
                                            var result = jEngine.Evaluate(ch.Condition);
                                            if (result.IsBoolean())
                                            {
                                                if (result.AsBoolean())
                                                {
                                                    jEngine.Execute(ch.Code);
                                                    nextBlockIndex = ch.ChildIndex;
                                                    break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (!string.IsNullOrEmpty(ch.Code))
                                                jEngine.Execute(ch.Code);

                                            nextBlockIndex = ch.ChildIndex;
                                            break;
                                        }
                                    }
                                }

                                choices.Clear();
                            }
                        }
                    }
                }

                states[i] = currentState;
            }

            return true;
        }


        private void SetMessage(string variable, Message message)
        {
            if (messages.ContainsKey(variable))
            {
                var list = messages[variable];
                list.Add(message);
            }
            else
            {
                messages.Add(variable, new List<Message>());
                messages[variable].Add(message);
            }
        }

        private void InitScripts()
        {
            jEngine.SetValue("AdjustFrequency", new Action<float>(AdjustFrequency));
            jEngine.SetValue("AcquireArtefactFragment", new Action<int>(AcquireArtefactFragment));
            jEngine.SetValue("UnlockArtefact", new Action<int>(UnlockArtefact));
            jEngine.SetValue("AdjustCharacterAttitudeTowards", new Action<int, int, int>(AdjustCharacterAttitudeTowards));
            jEngine.SetValue("SetCharacterAttitudeTowards", new Action<int, int, int>(SetCharacterAttitudeTowards));
            jEngine.SetValue("AdjustGroupFrequency", new Action<int, float>(AdjustGroupFrequency));
            jEngine.SetValue("AdjustCharacterAttitude", new Action<int, int>(AdjustCharacterAttitude));
            jEngine.SetValue("SetCharacterAttitude", new Action<int, int>(SetCharacterAttitude));
            jEngine.SetValue("AdjustCharacterTrait", new Action<int, int>(AdjustCharacterTrait));
            jEngine.SetValue("AdjustInventoryItem", new Action<int, int>(AdjustInventoryItem));
            jEngine.SetValue("ConsumeItem", new Func<int, bool>(ConsumeItem));
            jEngine.SetValue("AdjustInventoryCash", new Action<float>(AdjustInventoryCash));
            jEngine.SetValue("UnlockPlace", new Action<int>(UnlockPlace));
            jEngine.SetValue("UnlockSection", new Action<int>(UnlockSection));
            jEngine.SetValue("AccessSection", new Action<int>(AccessSection));
            jEngine.SetValue("UnlockCharacterGossip", new Action<int>(UnlockCharacterGossip));
            jEngine.SetValue("HideCharacterGossip", new Action<int>(HideCharacterGossip));
            jEngine.SetValue("UnlockJournal", new Action<int>(UnlockJournal));
            jEngine.SetValue("AdvanceJournal", new Action<int>(AdvanceJournal));
            jEngine.SetValue("UnlockScenario", new Action<int>(UnlockScenario));
            jEngine.SetValue("CompleteCurrentScenario", new Action(CompleteCurrentScenario));
            jEngine.SetValue("StartConversation", new Action<string>(StartConversation));
            jEngine.SetValue("OpenVendor", new Action<int>(OpenVendor));
            jEngine.SetValue("HasCharacterAttitude", new Func<int, int, bool>(HasCharacterAttitude));
            jEngine.SetValue("HasCharacterAttitudeTowards", new Func<int, int, int, bool>(HasCharacterAttitudeTowards));
            jEngine.SetValue("HasFrequency", new Func<float, bool>(HasFrequency));
            jEngine.SetValue("HasFrequencyWithGroup", new Func<int, float, bool>(HasFrequencyWithGroup));
            jEngine.SetValue("IsCurrentPOV", new Func<int, bool>(IsCurrentPOV));
            jEngine.SetValue("HasArtefactFragment", new Func<int, bool>(HasArtefactFragment));
            jEngine.SetValue("HasArtefactCompleted", new Func<int, bool>(HasArtefactCompleted));
            jEngine.SetValue("HasArtefactActivated", new Func<int, bool>(HasArtefactActivated));
            jEngine.SetValue("HasUnlockedPlace", new Func<int, bool>(HasUnlockedPlace));
            jEngine.SetValue("HasActivityProgress", new Func<int, int, bool>(HasActivityProgress));
            jEngine.SetValue("HasActivityPartComplete", new Func<int, int, bool>(HasActivityPartComplete));
            jEngine.SetValue("HasActivityComplete", new Func<int, bool>(HasActivityComplete));
            jEngine.SetValue("HasCharacterTraitProgress", new Func<int, int, bool>(HasCharacterTraitProgress));
            jEngine.SetValue("HasJournalProgress", new Func<int, int, bool>(HasJournalProgress));
            jEngine.SetValue("HasJournalCompleted", new Func<int, bool>(HasJournalCompleted));
            jEngine.SetValue("HasItem", new Func<int, bool>(HasItem));
            jEngine.SetValue("HasItemNumber", new Func<int, int, bool>(HasItemNumber));
            jEngine.SetValue("IsItemAvailable", new Func<int, int, bool>(IsItemAvailable));
            jEngine.SetValue("HasScenarioCompleted", new Func<int, bool>(HasScenarioCompleted));
            jEngine.SetValue("HasUnlockedSection", new Func<int, bool>(HasUnlockedSection));
            jEngine.SetValue("IsSectionAvailable", new Func<int, bool>(IsSectionAvailable));
            jEngine.SetValue("IsWithinSection", new Func<int, bool>(IsWithinSection));
            jEngine.SetValue("HasSpokenWith", new Func<int, bool>(HasSpokenWith));
            jEngine.SetValue("HasGossipOptionChosen", new Func<int, int, bool>(HasGossipOptionChosen));
            jEngine.SetValue("IsCharacterNourished", new Func<int, bool>(IsCharacterNourished));
            jEngine.SetValue("CharacterRequiresHealing", new Func<int, bool>(CharacterRequiresHealing));
            // goto should do nothing, we don't have a system to implement this.
            jEngine.SetValue("goto", new Action<string>((value) => { }));
        }

        //
        // Scripts
        //

        private void AdjustFrequency(float frequency)
        {
            var temp = currentState.Frequency;
            currentState.Frequency += frequency;

            if (EnableCallstack)
            {
                callStack.Set("PlayerState.Frequency", currentFile, currentLine, temp, frequency);
            }
        }

        private void AcquireArtefactFragment(int id)
        {
            if (currentState.Artefacts.FragmentsDiscovered.FindIndex((i) => i == id) == -1)
            {
                var artefactID = Globals.Fragments.Find((f) => f.ID == id).ArtefactID;
                if (currentState.Artefacts.ArtefactsUnlocked.Contains(artefactID))
                {
                    currentState.Artefacts.FragmentsDiscovered.Add(id);

                    if (EnableCallstack)
                    {
                        callStack.Set("PlayerState.Artefacts.FragmentsDiscovered", currentFile, currentLine, null, id);
                    }
                }
                else
                {

                    SetMessage("PlayerState.Artefacts.FragmentsDiscovered", new Message("AcquireArtefactFragment",
                        string.Format("Artefact ID {0} has not been unlocked.", artefactID),
                        MessageType.Warning, currentFile, currentLine));
                }
            }
            else
            {
                SetMessage("PlayerState.Artefacts.FragmentsDiscovered", new Message("AcquireArtefactFragment",
                    string.Format("Fragment ID {0} has already been discovered.", id),
                    MessageType.Warning, currentFile, currentLine));
            }
        }

        private void UnlockArtefact(int id)
        {

        }

        private void AdjustCharacterAttitudeTowards(int character, int towards, int value)
        {

        }

        private void SetCharacterAttitudeTowards(int character, int towards, int value)
        {

        }

        private void AdjustGroupFrequency(int group, float frequency)
        {

        }

        private void AdjustCharacterAttitude(int character, int value)
        {

        }

        private void SetCharacterAttitude(int character, int attitude)
        {

        }

        private void AdjustCharacterTrait(int trait, int value)
        {

        }

        private void AdjustInventoryItem(int item, int amount)
        {

        }

        private bool ConsumeItem(int item)
        {
            return true;
        }

        private void AdjustInventoryCash(float amount)
        {

        }

        private void UnlockPlace(int place)
        {

        }

        private void UnlockSection(int section)
        {

        }

        private void AccessSection(int section)
        {

        }

        private void UnlockCharacterGossip(int gossip)
        {

        }

        private void HideCharacterGossip(int gossip)
        {

        }

        private void UnlockJournal(int journal)
        {

        }

        private void AdvanceJournal(int journal)
        {

        }

        private void UnlockScenario(int scenario)
        {

        }

        private void CompleteCurrentScenario()
        {

        }

        private void StartConversation(string file)
        {

        }

        private void OpenVendor(int vendor)
        {

        }

        //
        // Conditionals
        //

        private bool HasCharacterAttitude(int character, int attitude)
        {
            return true;
        }

        private bool HasCharacterAttitudeTowards(int character, int towards, int attitude)
        {
            return true;
        }

        private bool HasFrequency(float frequency)
        {
            return currentState.Frequency >= frequency;
        }

        private bool HasFrequencyWithGroup(int group, float frequency)
        {
            return true;
        }

        private bool IsCurrentPOV(int character)
        {
            return true;
        }

        private bool HasArtefactFragment(int fragment)
        {
            return true;
        }

        private bool HasArtefactCompleted(int artefact)
        {
            var ids = new List<int>();
            foreach (var fragment in Globals.Fragments)
                if (fragment.ArtefactID == artefact)
                    ids.Add(fragment.ID);

            int total = ids.Count;
            int found = 0;
            foreach (var discovered in currentState.Artefacts.FragmentsDiscovered)
            {
                foreach (var aID in ids)
                {
                    if (discovered == aID)
                    {
                        found++;
                        break;
                    }
                }
            }

            return total == found;
        }

        private bool HasArtefactActivated(int artefact)
        {
            return true;
        }

        private bool HasUnlockedPlace(int place)
        {
            return true;
        }

        private bool HasActivityProgress(int activity, int value)
        {
            return true;
        }

        private bool HasActivityPartComplete(int activity, int part)
        {
            return true;
        }

        private bool HasActivityComplete(int activity)
        {
            return true;
        }

        private bool HasCharacterTraitProgress(int trait, int progress)
        {
            return true;
        }

        private bool HasJournalProgress(int journal, int progress)
        {
            return true;
        }

        private bool HasJournalCompleted(int journal)
        {
            return true;
        }

        private bool HasItem(int item)
        {
            return true;
        }

        private bool HasItemNumber(int item, int quantity)
        {
            return true;
        }

        private bool IsItemAvailable(int character, int vendorItem)
        {
            return true;
        }

        private bool HasScenarioCompleted(int scenario)
        {
            return true;
        }

        private bool HasUnlockedSection(int section)
        {
            return true;
        }

        private bool IsSectionAvailable(int section)
        {
            return true;
        }

        private bool IsWithinSection(int section)
        {
            return true;
        }

        private bool HasSpokenWith(int gossip)
        {
            return true;
        }

        private bool HasGossipOptionChosen(int gossip, int option)
        {
            return true;
        }

        private bool IsCharacterNourished(int character)
        {
            return true;
        }

        private bool CharacterRequiresHealing(int character)
        {
            return true;
        }



        private static Engine _instance;
        public static Engine Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Engine();

                return _instance;
            }
        }
    }
}

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

        public static readonly string DEFAULT_MSG_VAR = "Default";

        private Jint.Engine jEngine;
        private List<PlayerState> states;
        private int bestOutcomeIndex;
        private int worstOutcomeIndex;
        private int currentIndex;

        private PlayerState currentState;
        private int currentOutcome;
        private CallStack callStack;
        private Dictionary<string, List<Message>> messages;

        private string currentFile;
        private string currentBlock;
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

        public Dictionary<string, List<Message>> Messages
        {
            get { return messages; }
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
        }

        public void CreateStates()
        {
            states.Clear();

            currentIndex = 0;

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

        public async Task<bool> PlayAsync(string conversation, CancellationToken token)
        {
            

            return await Task.Run(ExecuteSimulation, token);
        }

        public event OnCallAdded CallAdded;

        private bool ExecuteSimulation()
        {
            if (conversations.Count == 0)
                return false;

            var errorsProduced = false;

            for (int i = 0; i < states.Count; i++)
            {
                currentState = states[i];
                currentOutcome = i;
                
                foreach (var convo in conversations)
                {
                    if (errorsProduced)
                        return false;

                    sdParser.Clear();
                    sdParser.ParseFile(Globals.CurrentProjectFolder + "\\" + convo);
                    currentFile = convo;

                    var choices = new List<ChoiceData>();
                    var choicePriorities = new List<int>();
                    var choice = new ChoiceData();
                    var nextBlockIndex = -1;

                    for (int j = 0; j < sdParser.GetBlocks().Count; j++)
                    {
                        var block = sdParser.GetBlocks()[j];
                        currentBlock = block.Title;

                        if (nextBlockIndex > -1)
                        {
                            if (nextBlockIndex != j)
                                continue;
                        }

                        var line = 0;
                        var executeUpToNextConditional = -1;
                        var skipToFallThrough = -1;
                        var skipNext = false;
                        var codeText = "";

                        for (int c = 0; c < block.Commands.Count; c++)
                        {
                            line++;
                            currentLine = line;
                            
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
                                    SetMessage(DEFAULT_MSG_VAR, new Message("Invalid Eval",
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
                                            if (c + 1 < block.Commands.Count)
                                            {
                                                var found = false;
                                                for (int k = c + 1; k < block.Commands.Count; k++)
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
                                                        SetMessage(DEFAULT_MSG_VAR, new Message("Invalid Eval",
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
                                    case (int)CommandType.FallThrough:
                                        {
                                            var code = command.Data[0];
                                            if (!string.IsNullOrEmpty(code))
                                            {
                                                var result = jEngine.Evaluate(code);
                                                if (result.IsBoolean())
                                                {
                                                    if (result.AsBoolean())
                                                    {
                                                        skipNext = false;
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
                                                skipNext = false;
                                            }
                                        }
                                        break;
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
            
            // goto should do nothing, we don't have a system to implement this.
            jEngine.SetValue("goto", new Action<string>((value) => { }));
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

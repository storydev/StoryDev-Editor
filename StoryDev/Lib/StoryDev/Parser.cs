using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace StoryDev.Lib.StoryDev
{
    class Parser
    {

        private List<CommandBlock> _blocks;
        private List<Command> _commands;
        private bool isAChoice;
        private bool isDialogueBlock;
        private List<string> choices;
        private CommandBlock currentBlock;
        private List<string> addedResources;
        private int blocksAdded;

        public Parser()
        {
            Command.GLOBAL_ID = 0;

            _blocks = new List<CommandBlock>();
            _commands = new List<Command>();
            addedResources = new List<string>();
        }

        public List<CommandBlock> GetBlocks()
        {
            return _blocks;
        }

        public CommandBlock GetBlockByTitle(string title)
        {
            foreach (var block in _blocks)
            {
                if (block.Title == title)
                    return block;
            }
            return null;
        }

        public CommandBlock GetBlockByID(int id)
        {
            return _blocks.Find((b) => b.ID == id);
        }

        public int GetBlockIndexByTitle(string title)
        {
            return _blocks.FindIndex((b) => b.Title == title);
        }

        public void Clear()
        {
            _blocks = new List<CommandBlock>();
            _commands = new List<Command>();
        }

        public int ParseFile(string file)
        {
            var content = File.ReadAllText(file);

            blocksAdded = Validate(content, file);

            return blocksAdded;
        }

        public int Validate(string content, string file)
        {
            var lines = content.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            currentBlock = null;
            isAChoice = false;
            var blocks = 0;

            // setup the local variables
            // don't need tokenisation because we are simple.
            choices = new List<string>();
            Command lastCommand = null;
            var convo = false;
            var character = false;
            var overlay = false;
            var text = "";
            var narration = false;
            var dialogue = false;
            var isCode = false;
            var isGoto = false;
            var charName = "";
            var charColor = "";
            var choiceText = "";
            var choiceInstruction = "";
            var optionText = "";
            var option = false;
            var optionConditional = false;
            var codeText = "";

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];

                var data = GetNextWord(line);
                var word = data.Word;
                var first = true;
                var arrow = false;
                while (word != "")
                {
                    var escape = false;

                    switch (word)
                    {
                        case ">":
                            {
                                if (first)
                                {
                                    isAChoice = true;
                                }
                            }
                            break;
                        case "->":
                            {
                                if (isAChoice)
                                {
                                    arrow = true;
                                }
                            }
                            break;
                        case "=":
                            {
                                if (!isCode)
                                    option = true;
                            }
                            break;
                        case "=!":
                            {
                                if (!isCode)
                                    optionConditional = true;

                            } break;
                        case "convo":
                        case "#":
                            {
                                convo = true;
                            }
                            break;
                        case ":":
                            {
                                if (!isCode)
                                {
                                    if (!dialogue)
                                        narration = true;
                                    else
                                    {
                                        charName = text;
                                        text = "";
                                    }
                                }
                            }
                            break;
                        case "char":
                            {
                                if (first)
                                    character = true;
                                else if (dialogue || narration || overlay)
                                    text += word + " ";
                            }
                            break;
                        case "~":
                            {
                                if (first)
                                    overlay = true;
                            }
                            break;
                        case "!":
                            {
                                isCode = true;
                            }
                            break;
                        case "goto":
                            {
                                isGoto = true;
                            }
                            break;
                        default:
                            {
                                if (isGoto || optionConditional)
                                {
                                    text += word;
                                }
                                else if (narration || character || dialogue || overlay || convo || isCode || option)
                                {
                                    if (character && word.StartsWith("#"))
                                        charColor = word;
                                    else if (isCode)
                                    {
                                        escape = true;
                                        codeText += line;
                                        break;
                                    }
                                    else
                                    {
                                        text += word + " ";
                                    }
                                }
                                else if (first)
                                {
                                    text = word + " ";
                                    dialogue = true;
                                }
                                else if (isAChoice)
                                {
                                    if (arrow)
                                    {
                                        choiceInstruction += word + " ";
                                    }
                                    else
                                    {
                                        choiceText += word + " ";
                                    }
                                }
                            }
                            break;
                    }

                    if (escape)
                        break;

                    // set the value to the rest of the line and get the next word.
                    line = data.Line;
                    data = GetNextWord(line);
                    word = data.Word;
                    first = false;
                }

                // check what happened when we parsed the line and create
                // commands/blocks accordingly.
                if (convo)
                {
                    CheckChoices();

                    if (currentBlock != null)
                    {
                        _blocks.Add(currentBlock);
                        blocks++;
                        currentBlock = new CommandBlock();
                    }

                    if (currentBlock == null)
                        currentBlock = new CommandBlock();

                    currentBlock.ID = Command.GLOBAL_ID++;
                    currentBlock.Title = text.Substring(0, text.Length - 1);
                    currentBlock.ResourceOrigin = file;
                    text = "";
                    convo = false;
                }
                else if (narration)
                {
                    text = text.Substring(0, text.Length - 1);
                    lastCommand = Command.CreateNarrative(text);
                    currentBlock.Commands.Add(lastCommand);
                    text = "";
                    narration = false;
                }
                else if (character)
                {
                    text = text.Substring(0, text.Length - 1);
                    lastCommand = Command.CreateCharacterCommand(text, charColor);
                    _commands.Add(lastCommand);
                    text = "";
                    character = false;
                }
                else if (dialogue)
                {
                    text = text.Substring(0, text.Length - 1);
                    if (string.IsNullOrEmpty(charName))
                    {
                        PostError(string.Format("Invalid syntax on line {0}. Expected a dialogue.", i));
                        return -1;
                    }    

                    charName = charName.Substring(0, charName.Length - 1);
                    lastCommand = Command.CreateDialogue(charName, text);
                    currentBlock.Commands.Add(lastCommand);
                    charName = "";
                    dialogue = false;
                    text = "";
                }
                else if (overlay)
                {
                    text = text.Substring(0, text.Length - 1);
                    lastCommand = Command.CreateOverlayTitle(text);
                    currentBlock.Commands.Add(lastCommand);
                    text = "";
                    overlay = false;
                }
                else if (isCode)
                {
                    lastCommand = Command.CreateCodeLine(codeText);
                    currentBlock.Commands.Add(lastCommand);
                    codeText = "";
                    isCode = false;
                }
                else if (isGoto)
                {
                    lastCommand = Command.CreateGoto(text);
                    currentBlock.Commands.Add(lastCommand);
                    text = "";
                    isGoto = false;
                }
                else if (option)
                {
                    if (text == "EXCLUSIVE")
                    {
                        currentBlock.IsExclusive = true;
                    }
                    else if (text == "NO_CLEAR")
                    {
                        currentBlock.ClearCurrent = false;
                    }
                    else
                    {
                        if (lastCommand == null)
                            currentBlock.Options.Add(text);
                        else
                            currentBlock.Commands.Add(Command.CreateOption(text));
                    }

                    text = "";
                    option = false;
                }
                else if (optionConditional)
                {
                    currentBlock.Commands.Add(Command.CreateOptionConditional(text));
                    text = "";
                    optionConditional = false;
                }
                else if (isAChoice)
                {
                    if (!arrow)
                    {
                        PostError(string.Format("Line {0}: There must be an `->` arrow that indicates where to go in a choice.", i));
                        return -1;
                    }

                    if (isCode)
                        choiceInstruction = codeText;

                    if (!isCode)
                        choiceInstruction = choiceInstruction.Substring(0, choiceInstruction.Length - 1);

                    choiceText = choiceText.Substring(0, choiceText.Length - 1);
                    choices.Add(choiceText + "|" + choiceInstruction);
                    choiceText = "";
                    choiceInstruction = "";
                    codeText = "";
                }
                
                else
                {
                    PostError(string.Format("Invalid syntax at line {0}. What we're you trying to do?", i));
                    return -1;
                }

                if (i == lines.Length - 1)
                {
                    if (currentBlock != null)
                    {
                        CheckChoices();
                        _blocks.Add(currentBlock);
                        blocks++;
                    }
                }
            }

            return blocks;
        }

        private WordData GetNextWord(string value)
        {
            var word = "";
            var index = 0;
            for (int i = 0; i < value.Length; i++)
            {
                var ch = value[i];
                index++;
                if (ch == ' ')
                    break;
                else
                    word += ch;
            }

            value = value.Substring(index);
            return new WordData(word, value);
        }

        private bool CheckChoices()
        {
            var result = false;
            if (isAChoice && currentBlock != null)
            {
                currentBlock.Commands.Add(Command.CreateChoices(choices.ToArray()));
                isAChoice = false;
                choices = new List<string>();

                result = true;
            }

            return result;
        }

        private void PostError(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private struct WordData
        {
            public string Word;
            public string Line;

            public WordData(string word, string line)
            {
                Word = word;
                Line = line;
            }
        }
    }


}

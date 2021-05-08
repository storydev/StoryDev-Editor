using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Lib.StoryDev
{
    class Command
    {

        public static int GLOBAL_ID;

        public int ID;
        public int Type;
        public List<string> Data;

        public Command()
        {
            Data = new List<string>();
        }

        public static Command CreateCharacterCommand(string name, string color)
        {
            var command = new Command();
            command.ID = GLOBAL_ID++;
            command.Type = (int)CommandType.Character;
            command.Data.Add(name);
            command.Data.Add(color);
            return command;
        }

        public static Command CreateBlockTitle(string name)
        {
            var command = new Command();
            command.ID = GLOBAL_ID++;
            command.Type = (int)CommandType.BlockStart;
            command.Data.Add(name);
            return command;
        }

        public static Command CreateNarrative(string description)
        {
            var command = new Command();
            command.ID = GLOBAL_ID++;
            command.Type = (int)CommandType.Narrative;
            command.Data.Add(description);
            return command;
        }

        public static Command CreateDialogue(string character, string dialogue)
        {
            var command = new Command();
            command.ID = GLOBAL_ID++;
            command.Type = (int)CommandType.Dialogue;
            command.Data.Add(character);
            command.Data.Add(dialogue);
            return command;
        }

        public static Command CreateDialogueBlock(string character, params string[] states)
        {
            var command = new Command();
            command.ID = GLOBAL_ID++;
            command.Type = (int)CommandType.DialogueBlock;
            command.Data.Add(character);
            foreach (var state in states)
            {
                command.Data.Add(state);
            }
            return command;
        }

        public static Command CreateOverlayTitle(string title)
        {
            var command = new Command();
            command.ID = GLOBAL_ID++;
            command.Type = (int)CommandType.OverlayTitle;
            command.Data.Add(title);
            return command;
        }

        public static Command CreateCodeLine(string code)
        {
            var command = new Command();
            command.ID = GLOBAL_ID++;
            command.Type = (int)CommandType.CodeLine;
            command.Data.Add(code);
            return command;
        }

        public static Command CreateInternalDialogue(string ch, string text)
        {
            var command = new Command();
            command.ID = GLOBAL_ID++;
            command.Type = (int)CommandType.InternalDialogue;
            command.Data.Add(ch);
            command.Data.Add(text);
            return command;
        }

        public static Command CreateNewConvo(string title)
        {
            var command = new Command();
            command.ID = GLOBAL_ID++;
            command.Type = (int)CommandType.NewConvo;
            command.Data.Add(title);
            return command;
        }

        public static Command CreateChoices(params string[] choices)
        {
            var command = new Command();
            command.ID = GLOBAL_ID++;
            command.Type = (int)CommandType.Choices;
            foreach (var choice in choices)
            {
                command.Data.Add(choice);
            }
            return command;
        }

        public static Command CreateGoto(string title)
        {
            var command = new Command();
            command.ID = GLOBAL_ID++;
            command.Type = (int)CommandType.Goto;
            command.Data.Add(title);
            return command;
        }

        public static Command CreateOptionConditional(string conditional)
        {
            var command = new Command();
            command.ID = GLOBAL_ID++;
            command.Type = (int)CommandType.OptionConditional;
            command.Data.Add(conditional);
            return command;
        }

    }
}

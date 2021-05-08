using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Lib.StoryDev
{
    enum CommandType
    {
        Character,
        BlockStart,
        Narrative,
        Dialogue,
        OverlayTitle,
        CodeLine,
        InternalDialogue,
        NewConvo,
        Choices,
        DialogueBlock,
        Goto,
        OptionConditional
    }
}

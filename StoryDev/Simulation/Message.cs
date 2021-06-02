using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Simulation
{
    class Message
    {

        public string Title;
        public string Description;
        public string OriginalFile;
        public int Line;
        public MessageType Type;

        public Message(string title, string desc, MessageType type, string file, int line)
        {
            Title = title;
            Description = desc;
            Type = type;
            OriginalFile = file;
            Line = line;
        }

    }

    enum MessageType
    {
        Info,
        Warning,
        Error
    }
}

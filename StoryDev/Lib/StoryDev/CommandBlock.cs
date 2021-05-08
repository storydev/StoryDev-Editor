using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Lib.StoryDev
{
    class CommandBlock
    {

        public int ID;
        public string Title;
        public bool IsExclusive;
        public bool ClearCurrent;
        public string ResourceOrigin;
        public List<Command> Commands;
        public List<string> ExtraData;
        public List<string> Options;

        public CommandBlock()
        {
            Commands = new List<Command>();
            ExtraData = new List<string>();
            Options = new List<string>();
            IsExclusive = false;
            ClearCurrent = true;
            Title = "";
            ID = 0;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StoryDev.Scripting
{
    class ScriptError
    {

        public ErrorType Type;
        public string FilePath;
        public int Column;
        public int LineNumber;
        public string Message;
        public string Context;

        public ScriptError()
        {

        }

    }
}

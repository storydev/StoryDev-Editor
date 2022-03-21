using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StoryDev.Scripting
{
    internal class ScriptError
    {

        public string FilePath;
        public int Column;
        public int LineNumber;
        public string Message;

        public ScriptError()
        {

        }

    }
}

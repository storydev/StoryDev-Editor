using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Simulation
{
    class CallStack
    {

        public Dictionary<string, List<CallInfo>> Calls;

        public CallStack()
        {
            Calls = new Dictionary<string, List<CallInfo>>();
        }

        public void Set(string variable, string file, int line, object last, object value)
        {
            if (Calls.ContainsKey(variable))
            {
                Calls[variable].Add(new CallInfo(file, line, last, value));
            }
            else
            {
                Calls.Add(variable, new List<CallInfo>());
                Calls[variable].Add(new CallInfo(file, line, last, value));
            }
        }

    }

    class CallInfo
    {

        public string OriginalFile;
        public int Line;
        public object LastValue;
        public object NewValue;

        public CallInfo(string file, int line, object last, object value)
        {
            OriginalFile = file;
            Line = line;
            LastValue = last;
            NewValue = value;
        }

    }
}

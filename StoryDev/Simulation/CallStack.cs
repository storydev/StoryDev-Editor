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

        public void Set(string variable, CallInfo info)
        {
            if (Calls.ContainsKey(variable))
            {
                Calls[variable].Add(info);
            }
            else
            {
                Calls.Add(variable, new List<CallInfo>());
                Calls[variable].Add(info);
            }
        }

    }

    class CallInfo
    {

        public string OriginalFile;
        public int Line;
        public object LastValue;
        public object NewValue;
        public int ForOutcome;
        public string BlockName;

        public CallInfo()
        {

        }

    }
}

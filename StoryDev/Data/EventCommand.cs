using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    internal class EventCommand
    {

        public string Name { get; set; }
        public EventType Type { get; set; }
        public TriggerType TriggerType { get; set; }
        public AutoType AutoType { get; set; }
        public string Prototype { get; set; }
        public string Code { get; set; }

        public EventCommand()
        {

        }

    }
}

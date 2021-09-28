using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    class GlobalSettings
    {

        public Dictionary<string, int> ArtefactContextNames;
        [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
        public List<FormComponent> FormComponents;

        public GlobalSettings()
        {
            ArtefactContextNames = new Dictionary<string, int>();
        }

    }
}

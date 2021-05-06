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

        public GlobalSettings()
        {
            ArtefactContextNames = new Dictionary<string, int>();
        }

    }
}

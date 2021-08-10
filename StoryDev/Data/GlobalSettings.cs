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
        public List<FormComponent> FormComponents;

        public GlobalSettings()
        {
            ArtefactContextNames = new Dictionary<string, int>();
            FormComponents = new List<FormComponent>();
        }

    }
}

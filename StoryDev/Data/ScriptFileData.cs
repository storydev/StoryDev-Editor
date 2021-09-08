using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    class ScriptFileData
    {

        public int Interpretation;
        public bool NotCompiled;
        public bool EnableLivePreview;
        public bool InitScript;

        public ScriptFileData()
        {
            Interpretation = 0;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    class Preferences
    {

        public CodeSettings CodeSettings;
        public string KhaPath;

        public Preferences()
        {
            CodeSettings = new CodeSettings();

            KhaPath = "Tools/Kha/";
        }

    }

    class CodeSettings
    {

        public bool WordWrap;

        public CodeSettings()
        {
            WordWrap = true;
        }

    }
        
}

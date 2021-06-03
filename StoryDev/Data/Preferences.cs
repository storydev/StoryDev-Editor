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

        public Preferences()
        {
            CodeSettings = new CodeSettings();
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

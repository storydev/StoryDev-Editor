using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    [AttributeUsage(AttributeTargets.Class)]
    class MainSourceData : Attribute
    {

        public string SourceData;
        public string PrimaryDisplay;
        public string IdentifierID;

        public MainSourceData(string sourceData, string primaryDisplay)
        {
            SourceData = sourceData;
            PrimaryDisplay = primaryDisplay;
        }

    }
}

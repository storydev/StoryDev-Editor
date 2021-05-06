using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    [AttributeUsage(AttributeTargets.Field)]
    class SearchCustomDataSource : Attribute
    {

        public string SourceCaller;

        public SearchCustomDataSource(string sourceCaller)
        {
            SourceCaller = sourceCaller;
        }

    }
}

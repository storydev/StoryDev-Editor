using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StoryDev.DBO.Scripting;

namespace StoryDev.DBO
{
    public interface IInstanceManager
    {

        DataStruct StructReference { get; set; }

        Dictionary<string, string> SourcePath { get; }

        Dictionary<string, List<object>> Items { get; }

        IEnumerable<object> Search(string name, params DBFilter[] filters);

    }
}

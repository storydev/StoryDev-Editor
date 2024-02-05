using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    internal class Project
    {

        public StoryFlow Flow { get; set; }

        public Project()
        {
            Flow = new StoryFlow();
        }

    }
}

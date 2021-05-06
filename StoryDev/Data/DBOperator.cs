using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    enum DBOperator
    {
        None,
        Equals,
        LessThan,
        LessThanEquals,
        GreaterThan,
        GreaterThanEquals,
        Contains,
        Begins,
        Ends
    }
}

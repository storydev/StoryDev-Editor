using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.DBO
{
    public interface IDBObject
    {

        void Insert();
        void Update();
        bool Delete();

    }
}

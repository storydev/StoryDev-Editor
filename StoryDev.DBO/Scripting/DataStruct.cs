﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.DBO.Scripting
{
    public class DataStruct
    {

        public string Name;
        public List<DataField> Fields;
        public SourceOptions Source;
        public string DefinedFormName;

        public DataStruct()
        {
            Fields = new List<DataField>();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    class DBFilter
    {

        public string FieldName;
        public DBOperator Operator;
        public object Value;
        public string SpecialSourcePath;

        public DBFilter(string fieldName, DBOperator op, object value)
        {
            FieldName = fieldName;
            Operator = op;
            Value = value;
        }

    }
}

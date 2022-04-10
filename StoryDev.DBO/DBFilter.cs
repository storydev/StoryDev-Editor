using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.DBO
{
    public class DBFilter
    {

        public string FieldName;
        public DBOperator Operator;
        public object ConditionValue;
        public DBCondition NextCondition;

        public DBFilter()
        {
            NextCondition = DBCondition.None;
        }

    }

    public enum DBCondition
    {
        None,
        And,
        Or
    }

    public enum DBOperator
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
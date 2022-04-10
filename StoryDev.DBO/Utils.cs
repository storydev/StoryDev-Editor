using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.DBO
{
    public class Utils
    {

        public static bool GetResultOf(object value, DBOperator op, object match)
        {
            if (op == DBOperator.Begins)
            {
                return ((string)value).StartsWith((string)match);
            }
            else if (op == DBOperator.Ends)
            {
                return ((string)value).EndsWith((string)match);
            }
            else if (op == DBOperator.Contains)
            {
                return ((string)value).Contains((string)match);
            }
            else if (op == DBOperator.Equals)
            {
                if (value.GetType() == typeof(float))
                    return (float)value == (float)match;
                else if (value.GetType() == typeof(decimal))
                    return (decimal)value == (decimal)match;
                else if (value.GetType() == typeof(int))
                    return (int)value == (int)match;
                else
                    return value.Equals(match);
            }
            else if (op == DBOperator.GreaterThan)
            {
                if (value.GetType() == typeof(float))
                    return (float)value > (float)match;
                else if (value.GetType() == typeof(decimal))
                    return (decimal)value > (decimal)match;
                else if (value.GetType() == typeof(int))
                    return (int)value > (int)match;
            }
            else if (op == DBOperator.GreaterThanEquals)
            {
                if (value.GetType() == typeof(float))
                    return (float)value >= (float)match;
                else if (value.GetType() == typeof(decimal))
                    return (decimal)value >= (decimal)match;
                else if (value.GetType() == typeof(int))
                    return (int)value >= (int)match;
            }
            else if (op == DBOperator.LessThan)
            {
                if (value.GetType() == typeof(float))
                    return (float)value < (float)match;
                else if (value.GetType() == typeof(decimal))
                    return (decimal)value < (decimal)match;
                else if (value.GetType() == typeof(int))
                    return (int)value < (int)match;
            }
            else if (op == DBOperator.LessThanEquals)
            {
                if (value.GetType() == typeof(float))
                    return (float)value <= (float)match;
                else if (value.GetType() == typeof(decimal))
                    return (decimal)value <= (decimal)match;
                else if (value.GetType() == typeof(int))
                    return (int)value <= (int)match;
            }
            else
            {
                if (value.GetType() == typeof(bool))
                    return value == match;
                else
                    return false;
            }

            return false;
        }

    }
}

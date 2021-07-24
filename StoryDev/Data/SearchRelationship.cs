using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{

    [AttributeUsage(AttributeTargets.Field)]
    class SearchRelationship : Attribute
    {

        public Type Type;
        public string FieldName;
        public string DisplayField;
        public string SourceName;

        public SearchRelationship(Type type, string fieldName, string displayField, string sourceName = "")
        {
            Type = type;
            FieldName = fieldName;
            DisplayField = displayField;
            SourceName = sourceName;
        }

    }
}

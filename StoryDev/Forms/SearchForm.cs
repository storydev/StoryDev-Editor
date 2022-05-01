using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

using StoryDev.Data;
using StoryDev.DBO;

namespace StoryDev.Forms
{
    partial class SearchForm<T> : Form
    {

        private List<T> sourceData;
        private IEnumerable<T> results;
        private System.Type baseType;
        private FieldInfo[] fields;
        private Dictionary<int, SearchRelationship> relFields;
        private Dictionary<int, SearchOptions> optionFields;
        private Dictionary<int, SearchCustomDataSource> customSourceFields;
        private Dictionary<string, IEnumerable<object>> relationshipDataSources;
        private IEnumerable<DBFilter> filters;

        public SearchForm(string sourceDataField = "", List<T> custom = null)
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(sourceDataField))
            {
                var prop = typeof(Globals).GetProperty(sourceDataField, BindingFlags.Public | BindingFlags.Static);
                if (prop != null)
                {
                    sourceData = (List<T>)prop.GetValue(null);
                }
            }
            else if (custom != null)
            {
                sourceData = custom;
            }

            relFields = new Dictionary<int, SearchRelationship>();
            optionFields = new Dictionary<int, SearchOptions>();
            customSourceFields = new Dictionary<int, SearchCustomDataSource>();
            relationshipDataSources = new Dictionary<string, IEnumerable<object>>();
            baseType = typeof(T);
            PopulateColumns();
            Search();
        }

        private void PopulateColumns()
        {
            fields = baseType.GetFields(BindingFlags.Public | ~BindingFlags.Static);
            for (int i = 0; i < fields.Length; i++)
            {
                var field = fields[i];
                var width = 125;
                var hidden = false;

                var options = field.GetCustomAttributes(typeof(SearchOptions));
                if (options.Count() > 0)
                {
                    var option = (SearchOptions)options.First();
                    optionFields.Add(i, option);
                    width = option.Width;
                    hidden = option.Hidden;
                }

                if (hidden || !IsBasicType(field.FieldType))
                    continue;

                var relationships = field.GetCustomAttributes(typeof(SearchRelationship));
                if (relationships.Count() > 0)
                {
                    var relationship = (SearchRelationship)relationships.First();
                    relFields.Add(i, relationship);
                    if (!string.IsNullOrEmpty(relationship.SourceName))
                    {
                        var relSource = typeof(Globals).GetProperty(relationship.SourceName, BindingFlags.Public | BindingFlags.Static);
                        if (relSource != null)
                        {
                            var value = relSource.GetValue(null);
                            relationshipDataSources.Add(relationship.SourceName, (IEnumerable<object>)value);
                        }
                    }
                }

                var custom = field.GetCustomAttributes(typeof(SearchCustomDataSource));
                if (custom.Count() > 0)
                {
                    var customSource = (SearchCustomDataSource)custom.First();
                    customSourceFields.Add(i, customSource);
                }

                var column = new ColumnHeader();
                column.Text = field.Name;
                column.Width = width;

                lvResults.Columns.Add(column);
            }
        }

        private void Search()
        {
            IEnumerable<T> _results = sourceData;

            if (results != null)
                _results = results;

            lvResults.Items.Clear();
            foreach (T result in _results)
            {
                var item = new ListViewItem();
                var first = true;
                for (int i = 0; i < fields.Length; i++)
                {
                    if (optionFields.ContainsKey(i))
                    {
                        var options = optionFields[i];
                        if (options.Hidden)
                            continue;
                    }
                    
                    var value = fields[i].GetValue(result);
                    if (relFields.ContainsKey(i))
                    {
                        var relationship = relFields[i];
                        var relField = relationship.Type.GetField(relationship.DisplayField);
                        var idField = relationship.Type.GetField(relationship.FieldName);
                        if (relationshipDataSources.ContainsKey(relationship.SourceName))
                        {
                            foreach (object obj in relationshipDataSources[relationship.SourceName])
                            {
                                var idValue = (int)idField.GetValue(obj);
                                if (idValue == (int)value)
                                {
                                    if (first)
                                        item.Text = Convert.ToString(relField.GetValue(obj));
                                    else
                                        item.SubItems.Add(Convert.ToString(relField.GetValue(obj)));

                                    first = false;
                                    break;
                                }
                            }
                        }
                    }
                    else if (customSourceFields.ContainsKey(i))
                    {
                        var customSource = customSourceFields[i];
                        var f = typeof(Globals).GetField(customSource.SourceCaller, BindingFlags.Public | BindingFlags.Static);
                        PropertyInfo p = null;
                        if (f == null)
                            p = typeof(Globals).GetProperty(customSource.SourceCaller, BindingFlags.Public | BindingFlags.Static);

                        IEnumerable<string> customField = null;
                        if (f == null)
                            customField = (IEnumerable<string>)p.GetValue(null);
                        else
                            customField = (IEnumerable<string>)f.GetValue(null);

                        var display = "";
                        if (value.GetType() == typeof(string))
                            display = (string)value;
                        else
                            display = customField.ElementAt((int)value);

                        if (first)
                        {
                            item.Text = display;
                            first = false;
                        }
                        else
                            item.SubItems.Add(display);

                    }
                    else if (IsBasicType(value.GetType()))
                    {
                        if (first)
                        {
                            item.Text = Convert.ToString(value);
                            first = false;
                        }
                        else
                            item.SubItems.Add(Convert.ToString(value));
                    }
                }

                lvResults.Items.Add(item);
            }
        }

        private bool IsBasicType(System.Type type)
        {
            var result = (type == typeof(int) || type == typeof(uint) || type == typeof(short) || type == typeof(ushort) ||
                type == typeof(long) || type == typeof(ulong) || type == typeof(byte) || type == typeof(sbyte) ||
                type == typeof(float) || type == typeof(decimal) || type == typeof(double) || type == typeof(string));
            return result;
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            var filters = new SearchFiltersForm<T>();
            filters.FiltersApplied += Filters_FiltersApplied;
            filters.ShowDialog();
        }

        private void Filters_FiltersApplied(IEnumerable<DBFilter> filters)
        {
            Cursor = Cursors.WaitCursor;
            this.filters = filters;
            if (filters.Count() > 0)
            {
                results = sourceData.Where((T result) =>
                {
                    var show = false;

                    foreach (var filter in filters)
                    {
                        var value = result.GetType().GetField(filter.FieldName).GetValue(result);
                        if (!GetResultOf(value, filter.Operator, filter.ConditionValue))
                            return false;

                        show = true;
                    }

                    return show;
                });
            }
            else
            {
                results = sourceData;
            }

            Search();

            Cursor = Cursors.Default;
        }

        private bool GetResultOf(object value, DBOperator op, object match)
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lvResults.SelectedIndices.Count == 0)
                return;

            int selected = -1;

            if (results != null)
            {
                var result = results.ElementAt(lvResults.SelectedIndices[0]);
                var idField = typeof(T).GetField("ID");
                for (int i = 0; i < sourceData.Count; i++)
                {
                    var source = sourceData[i];
                    var sourceID = (int)idField.GetValue(source);
                    var currentID = (int)idField.GetValue(result);
                    if (sourceID == currentID)
                    {
                        selected = i;
                        break;
                    }
                }
            }
            else
            {
                selected = lvResults.SelectedIndices[0];
            }

            SearchSelected?.Invoke(selected);
            Close();
        }

        public event OnSearchSelect SearchSelected;
    }
}

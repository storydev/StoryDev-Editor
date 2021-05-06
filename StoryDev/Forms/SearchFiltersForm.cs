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

using StoryDev.Components.Data;
using StoryDev.Data;

namespace StoryDev.Forms
{
    partial class SearchFiltersForm<T> : Form
    {

        private System.Type type;

        public SearchFiltersForm()
        {
            InitializeComponent();

            type = typeof(T);
            var fields = type.GetFields(BindingFlags.Public | ~BindingFlags.Static);
            foreach (var field in fields)
            {
                var options = field.GetCustomAttributes(typeof(SearchOptions));
                if (options.Count() > 0)
                {
                    var option = (SearchOptions)options.First();
                    if (option.Hidden)
                        continue;
                }


                if (field.FieldType == typeof(bool))
                {
                    var filter = new FilterBool();
                    filter.FieldName = field.Name;
                    filter.Dock = DockStyle.Top;
                    pnlFilters.Controls.Add(filter);
                    pnlFilters.Controls.SetChildIndex(filter, 0);
                }
                else if (field.FieldType == typeof(string))
                {
                    var custom = field.GetCustomAttributes(typeof(SearchCustomDataSource));
                    if (custom.Count() > 0)
                    {
                        var source = (SearchCustomDataSource)custom.First();
                        var gField = typeof(Globals).GetProperty(source.SourceCaller, BindingFlags.Public | BindingFlags.Static);
                        var gValue = (IEnumerable<string>)gField.GetValue(null);

                        var filter = new FilterSelect();
                        filter.FieldName = field.Name;
                        filter.Dock = DockStyle.Top;
                        filter.Items.AddRange(gValue.ToArray());
                        filter.SpecialSourcePath = source.SourceCaller;
                        pnlFilters.Controls.Add(filter);
                        pnlFilters.Controls.SetChildIndex(filter, 0);
                    }
                    else
                    {
                        var filter = new FilterString();
                        filter.FieldName = field.Name;
                        filter.Dock = DockStyle.Top;
                        pnlFilters.Controls.Add(filter);
                        pnlFilters.Controls.SetChildIndex(filter, 0);
                    }
                }
                else if (field.FieldType == typeof(float))
                {
                    var filter = new FilterFloat();
                    filter.FieldName = field.Name;
                    filter.Dock = DockStyle.Top;
                    pnlFilters.Controls.Add(filter);
                    pnlFilters.Controls.SetChildIndex(filter, 0);
                }
                else if (field.FieldType == typeof(decimal))
                {
                    var filter = new FilterDecimal();
                    filter.FieldName = field.Name;
                    filter.Dock = DockStyle.Top;
                    pnlFilters.Controls.Add(filter);
                    pnlFilters.Controls.SetChildIndex(filter, 0);
                }
                else if (field.FieldType == typeof(int))
                {
                    var relationships = field.GetCustomAttributes(typeof(SearchRelationship));
                    if (relationships.Count() > 0)
                    {
                        var relationship = (SearchRelationship)relationships.First();
                        var sourceName = "";
                        var values = new List<string>();
                        if (!string.IsNullOrEmpty(relationship.SourceName))
                        {
                            var relSource = typeof(Globals).GetProperty(relationship.SourceName, BindingFlags.Public | BindingFlags.Static);
                            sourceName = relationship.SourceName;
                            if (relSource != null)
                            {
                                var value = (IEnumerable<DBObject>)relSource.GetValue(null);
                                foreach (var obj in value)
                                {
                                    var v = relationship.Type.GetField(relationship.DisplayField).GetValue(obj);
                                    if (v.GetType() == typeof(string))
                                    {
                                        values.Add((string)v);
                                    }
                                }
                            }
                        }

                        var filterInstance = Activator.CreateInstance(typeof(FilterObject<>).MakeGenericType(relationship.Type));
                        var filter = (UserControl)filterInstance;
                        filter.GetType().GetProperty("FieldName").SetValue(filter, field.Name);
                        filter.GetType().GetProperty("SpecialSourcePath").SetValue(filter, sourceName);


                        filter.Dock = DockStyle.Top;
                        pnlFilters.Controls.Add(filter);
                        pnlFilters.Controls.SetChildIndex(filter, 0);

                        continue;
                    }

                    var customSource = field.GetCustomAttributes(typeof(SearchCustomDataSource));
                    if (customSource.Count() > 0)
                    {
                        var custom = (SearchCustomDataSource)customSource.First();
                        var values = new List<string>();
                        if (!string.IsNullOrEmpty(custom.SourceCaller))
                        {
                            var sourceField = (IEnumerable<string>)typeof(Globals).GetField(custom.SourceCaller, BindingFlags.Public | BindingFlags.Static).GetValue(null);
                            foreach (var val in sourceField)
                            {
                                values.Add(val);
                            }
                        }

                        var filter = new FilterSelect();
                        filter.FieldName = field.Name;
                        filter.Dock = DockStyle.Top;

                        foreach (var val in values)
                        {
                            filter.Items.Add(val);
                        }
                        pnlFilters.Controls.Add(filter);
                        pnlFilters.Controls.SetChildIndex(filter, 0);

                        continue;
                    }

                    {
                        var filter = new FilterNumber();
                        filter.FieldName = field.Name;
                        filter.Dock = DockStyle.Top;
                        pnlFilters.Controls.Add(filter);
                        pnlFilters.Controls.SetChildIndex(filter, 0);
                    }
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (FiltersApplied == null)
                return;

            var filters = new List<DBFilter>();
            foreach (Control ctl in pnlFilters.Controls)
            {
                if (ctl.GetType() == typeof(FilterBool))
                {
                    var casted = (FilterBool)ctl;
                    if (casted.Value > -1)
                    {
                        var filter = new DBFilter(casted.FieldName, DBOperator.Equals, casted.Value == 1);
                        filters.Add(filter);
                    }
                }
                else if (ctl.GetType() == typeof(FilterDecimal))
                {
                    var casted = (FilterDecimal)ctl;
                    if (casted.Operator != DBOperator.None)
                    {
                        var filter = new DBFilter(casted.FieldName, casted.Operator, casted.Value);
                        filters.Add(filter);
                    }
                }
                else if (ctl.GetType() == typeof(FilterFloat))
                {
                    var casted = (FilterFloat)ctl;
                    if (casted.Operator != DBOperator.None)
                    {
                        var filter = new DBFilter(casted.FieldName, casted.Operator, casted.Value);
                        filters.Add(filter);
                    }
                }
                else if (ctl.GetType() == typeof(FilterNumber))
                {
                    var casted = (FilterNumber)ctl;
                    if (casted.Operator != DBOperator.None)
                    {
                        var filter = new DBFilter(casted.FieldName, casted.Operator, casted.Value);
                        filters.Add(filter);
                    }
                }
                else if (ctl.GetType() == typeof(FilterSelect))
                {
                    var casted = (FilterSelect)ctl;
                    if (casted.Operator != DBOperator.None)
                    {
                        int result = casted.SelectedIndex;
                        if (!string.IsNullOrEmpty(casted.SpecialSourcePath))
                        {
                            var gField = typeof(Globals).GetProperty(casted.SpecialSourcePath, BindingFlags.Public | BindingFlags.Static);
                            if (gField.PropertyType.IsGenericType && gField.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                            {
                                var genericTypeArg = gField.PropertyType.GetGenericArguments()[0];
                                if (genericTypeArg != typeof(string))
                                {
                                    var source = (IEnumerable<DBObject>)gField.GetValue(null);
                                    var sourceItem = source.ElementAt(casted.SelectedIndex);
                                    result = (int)genericTypeArg.GetField("ID").GetValue(sourceItem);
                                }
                                else
                                {
                                    var source = (IEnumerable<string>)gField.GetValue(null);
                                    var sourceItem = source.ElementAt(casted.SelectedIndex);
                                    var sFilter = new DBFilter(casted.FieldName, DBOperator.Equals, sourceItem);
                                    filters.Add(sFilter);
                                    continue;
                                }
                            }
                        }

                        var filter = new DBFilter(casted.FieldName, casted.Operator, result);
                        filters.Add(filter);
                    }
                }
                else if (ctl.GetType() == typeof(FilterString))
                {
                    var casted = (FilterString)ctl;
                    if (casted.Operator != DBOperator.None)
                    {
                        var filter = new DBFilter(casted.FieldName, casted.Operator, casted.Value);
                        filters.Add(filter);
                    }
                }
                else if (ctl.GetType().GetGenericTypeDefinition() == typeof(FilterObject<>))
                {
                    //var ctl_ = typeof(FilterObject<>).MakeGenericType(ctl.GetType().GetGenericArguments());
                    var t = ctl.GetType();
                    var fieldName = (string)t.GetProperty("FieldName").GetValue(ctl);
                    var selected = (int)t.GetProperty("SelectedIndex").GetValue(ctl);
                    var special = (string)t.GetProperty("SpecialSourcePath").GetValue(ctl);
                    var gProp = typeof(Globals).GetProperty(special, BindingFlags.Public | BindingFlags.Static);
                    var id = -1;
                    if (gProp.PropertyType.IsGenericType && gProp.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                    {
                        var genericTypeArg = gProp.PropertyType.GetGenericArguments()[0];
                        var source = (IEnumerable<DBObject>)gProp.GetValue(null);
                        if (selected > -1)
                        {
                            var sourceItem = source.ElementAt(selected);
                            id = (int)genericTypeArg.GetField("ID").GetValue(sourceItem);
                        }
                    }

                    if (id > -1)
                    {
                        var filter = new DBFilter(fieldName, DBOperator.Equals, id);
                        filters.Add(filter);
                    }
                }
            }

            FiltersApplied?.Invoke(filters);
            Close();
        }

        public event OnFiltersApplied FiltersApplied;
    }
}

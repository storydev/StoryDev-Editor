using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

using StoryDev.Data;
using StoryDev.Forms;

namespace StoryDev.Components.Data
{
    public partial class FilterObject<T> : UserControl
    {

        private System.Type type;

        public string FieldName
        {
            get { return lblFieldName.Text; }
            set { lblFieldName.Text = value; }
        }

        public int SelectedIndex => cmbSelectItems.SelectedIndex;

        public string SpecialSourcePath { get; set; }

        public FilterObject()
        {
            InitializeComponent();

            type = typeof(T);
            var mainSource = type.GetCustomAttributes(typeof(MainSourceData), false);
            if (mainSource.Count() > 0)
            {
                var source = (MainSourceData)mainSource.First();
                var prop = typeof(Globals).GetProperty(source.SourceData, BindingFlags.Public | BindingFlags.Static);
                if (prop != null)
                {
                    var data = (List<T>)prop.GetValue(null);
                    foreach (T instance in data)
                    {
                        var f = type.GetField(source.PrimaryDisplay).GetValue(instance);
                        cmbSelectItems.Items.Add(f.ToString());
                        cmbSelectItems.AutoCompleteCustomSource.Add(f.ToString());
                    }
                }
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var mainSource = type.GetCustomAttributes(typeof(MainSourceData), false);
            if (mainSource.Count() > 0)
            {
                var source = (MainSourceData)mainSource.First();
                var browse = typeof(SearchForm<>).MakeGenericType(type);
                var instance = (SearchForm<T>)Activator.CreateInstance(browse, new object[] { source.SourceData, null });
                instance.SearchSelected += SelectItem;
                instance.ShowDialog();
            }
        }

        private void SelectItem(int index)
        {
            cmbSelectItems.SelectedIndex = index;
        }
    }
}

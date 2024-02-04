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

namespace StoryDev.Forms
{
    partial class QuickCreateForm<T> : Form
    {

        private Type type;
        private FieldInfo idField;
        private MainSourceData data;

        public int LastInsertedID { get; private set; }

        public int LastInsertedIndex { get; private set; }

        public QuickCreateForm()
        {
            InitializeComponent();

            type = typeof(T);

            var sources = type.GetCustomAttributes(typeof(MainSourceData), false);
            if (sources.Length > 0)
            {
                data = (MainSourceData)sources[0];
            }

            var idFound = false;
            foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Instance))
            {
                if (field.Name == "ID")
                {
                    idFound = true;
                    idField = field;
                    break;
                }
            }

            if (!idFound)
            {
                throw new Exception("There is no ID field for the following data object.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var instance = (T)Activator.CreateInstance(type);
            type.GetField(data.PrimaryDisplay).SetValue(instance, txtName.Text);

            var list = (List<T>)typeof(Globals).GetProperty(data.SourceData, BindingFlags.Static | BindingFlags.Public).GetValue(null);
            list.Add(instance);
            LastInsertedIndex = list.Count - 1;

            Globals.SaveAll();
            DialogResult = DialogResult.OK;
        }
    }
}

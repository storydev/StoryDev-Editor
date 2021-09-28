using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components.Scripting
{
    [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
    partial class DataModuleFolderProperties : UserControl
    {
        public DataModuleFolderProperties()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RequestDataModuleRefresh?.Invoke();
        }

        public event OnRequestDataModuleRefresh RequestDataModuleRefresh;
    }
}

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
    partial class DataModuleFileProperties : UserControl
    {
        public DataModuleFileProperties()
        {
            InitializeComponent();
        }

        public event OnRequestDataModuleRefresh RequestDataModuleRefresh;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RequestDataModuleRefresh?.Invoke();
        }
    }
}

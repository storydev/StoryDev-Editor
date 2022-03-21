using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components.TestEnv
{
    partial class SectionResults : UserControl, IWizardPage
    {
        public SectionResults()
        {
            InitializeComponent();

            pnlResultContent.Controls.Add(new Results.DataStructureResults()
            {
                Dock = DockStyle.Fill
            });
        }

        public bool CanGoForwards
        {
            get => true;
        }
    }
}

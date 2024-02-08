using StoryDev.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components
{
    public partial class StoryFlowWrapper : UserControl
    {
        public StoryFlowWrapper()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            storyFlow.GroupSelected += StoryFlow_GroupSelected;
        }

        private void StoryFlow_GroupSelected(int index)
        {
            
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var group = new Group();
            group.Name = "Untitled";
            group.Position = new PointF(50, 50);
            Globals.CurrentProject.Flow.Groups.Add(group);
            storyFlow.SetGroupContext();
            storyFlow.SetHierarchyView();
            storyFlow.Invalidate();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Data;

namespace StoryDev.Forms
{
    partial class MapEditorForm : Form
    {

        private bool isEditing;
        private Map currentMap;

        public MapEditorForm(Map instance = null)
        {
            InitializeComponent();

            if (instance == null)
            {
                currentMap = new Map();
                isEditing = false;
            }
            else
            {
                currentMap = instance;
                isEditing = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            currentMap.Name = txtName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            currentMap.Description = txtDescription.Text;
        }
    }
}

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
    partial class LinkedDataEditColumnsForm : Form
    {

        private List<LinkedColumn> columns;

        public LinkedDataEditColumnsForm(List<LinkedColumn> columns)
        {
            InitializeComponent();

            this.columns = columns;

            PopulateColumns();
        }

        private void PopulateColumns()
        {
            foreach (var column in columns)
            {
                dgvColumns.Rows.Add(new object[] 
                {
                    column.Visible, column.FieldName, column.Width
                });
            }
        }

        private new bool Validate()
        {
            var result = true;

            foreach (DataGridViewRow row in dgvColumns.Rows)
            {
                if (!int.TryParse("" + row.Cells[2].Value, out int _))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LinkedDataEditColumnsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Validate())
            {
                MessageBox.Show("One or more cells contains invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}

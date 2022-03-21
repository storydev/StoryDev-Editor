using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Components;

namespace StoryDev.Forms
{
    partial class TestEnvironmentForm : Form
    {

        private List<UserControl> pages;
        private int currentPage;

        public TestEnvironmentForm()
        {
            InitializeComponent();

            pages = new List<UserControl>();
            pages.Add(new Components.TestEnv.SectionBasic()
            {
                Dock = DockStyle.Fill
            });
            pages.Add(new Components.TestEnv.SectionResults()
            {
                Dock = DockStyle.Fill
            });

            currentPage = 0;
            pnlContent.Controls.Add(pages[currentPage]);

            IWizardPage wizPage = (IWizardPage)pages[currentPage];
            btnNext.Enabled = wizPage.CanGoForwards;
        }

        private void NextPage()
        {
            if (currentPage + 1 <= pages.Count - 1)
            {
                currentPage += 1;
                if (currentPage == pages.Count - 1)
                {
                    btnNext.Text = "Finish";
                }
                else
                {
                    btnNext.Text = "Next >>";
                }
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(pages[currentPage]);

                IWizardPage wizPage = (IWizardPage)pages[currentPage];
                btnNext.Enabled = wizPage.CanGoForwards;

                if (currentPage > 0)
                {
                    btnPrevious.Enabled = true;
                }
            }
        }

        private void PreviousPage()
        {
            if (currentPage - 1 >= 0)
            {
                currentPage -= 1;
                btnPrevious.Enabled = currentPage > 0;

                if (currentPage == pages.Count - 1)
                {
                    btnNext.Text = "Finish";
                }
                else
                {
                    btnNext.Text = "Next >>";
                }
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(pages[currentPage]);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextPage();
        }
    }
}

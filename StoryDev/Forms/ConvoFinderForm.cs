using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Forms
{
    internal partial class ConvoFinderForm : Form
    {

        private int selectedFile;
        private int[] searchResultIndices;
        private Font primaryFont;
        private Font boldFont;

        public ConvoFinderForm()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            searchResultIndices = new int[0];
            primaryFont = new Font("Segoe UI", 13.0f);
            boldFont = new Font("Segoe UI", 13.0f, FontStyle.Bold);

            Invalidate();
        }

        private void txtSearchConvo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (selectedFile != -1)
                {
                    if (string.IsNullOrEmpty(txtSearchConvo.Text))
                    {
                        RequestOpenForm?.Invoke(FormType.Form_ConversationEditor, new string[] { Globals.FilePaths[selectedFile] });
                    }
                    else
                    {
                        RequestOpenForm?.Invoke(FormType.Form_ConversationEditor, new string[] { Globals.FilePaths[searchResultIndices[selectedFile]] });
                    }
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (selectedFile - 1 > -1)
                {
                    selectedFile -= 1;
                }

                Invalidate();
            }
            else if (e.KeyCode == Keys.Down)
            {
                int count = searchResultIndices.Length;
                if (searchResultIndices.Length == 0)
                {
                    count = Globals.Files.Length;
                }

                if (count == 0)
                {
                    return;
                }

                if (selectedFile + 1 < count)
                {
                    selectedFile += 1;
                }

                Invalidate();
            }
            else
            {
                selectedFile = -1;
                searchResultIndices = new int[0];

                if (!string.IsNullOrEmpty(txtSearchConvo.Text))
                {
                    int resultCount = 0;
                    bool[] searchFound = new bool[Globals.Files.Length];
                    for (int i = 0; i < Globals.Files.Length; i++)
                    {
                        string fileName = Globals.Files[i];
                        searchFound[i] = fileName.Contains(txtSearchConvo.Text);
                        if (searchFound[i])
                        {
                            resultCount += 1;
                        }
                    }
                    searchResultIndices = new int[resultCount];
                    if (resultCount > 0)
                        selectedFile = 0;

                    int startSearchResultIndex = 0;
                    for (int i = 0; i < Globals.Files.Length; i++)
                    {
                        if (searchFound[i])
                        {
                            searchResultIndices[startSearchResultIndex] = i;
                            startSearchResultIndex += 1;
                        }
                    }
                }

                Invalidate();
            }
        }

        private void ConvoFinderForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(Color.White);

            if (searchResultIndices.Length == 0 && string.IsNullOrEmpty(txtSearchConvo.Text)) // Just use Globals.Files directly
            {
                float startY = 44.0f;
                SizeF textSize = g.MeasureString("M", primaryFont);

                for (int i = 0; i < Globals.Files.Length; i++)
                {
                    string fileName = Globals.Files[i];
                    Color background = Color.FromArgb(255, 255, 255);
                    Color foreColor = Color.Black;
                    Font font = primaryFont;
                    if (selectedFile == i)
                    {
                        background = Color.FromArgb(15, 87, 170);
                        g.FillRectangle(new SolidBrush(background), 0, startY - 1, Width, textSize.Height + 2);
                        foreColor = Color.White;
                        font = boldFont;
                    }
                    
                    g.DrawString(fileName, font, new SolidBrush(foreColor), new PointF(12, startY));
                    startY += textSize.Height + 4.0f;
                }
            }
            else
            {
                float startY = 44.0f;
                SizeF textSize = g.MeasureString("M", primaryFont);

                for (int i = 0; i < searchResultIndices.Length; i++)
                {
                    string fileName = Globals.Files[searchResultIndices[i]];
                    Color background = Color.FromArgb(255, 255, 255);
                    Color foreColor = Color.Black;
                    Font font = primaryFont;
                    if (selectedFile == i)
                    {
                        background = Color.FromArgb(15, 87, 170);
                        g.FillRectangle(new SolidBrush(background), 0, startY - 1, Width, textSize.Height + 2);
                        foreColor = Color.White;
                        font = boldFont;
                    }

                    g.DrawString(fileName, font, new SolidBrush(foreColor), new PointF(12, startY));
                    startY += textSize.Height + 4.0f;
                }
            }
        }

        public event OnRequestOpenForm RequestOpenForm;
    }
}

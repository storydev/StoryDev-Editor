using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StoryDev.Forms
{
    partial class ArtManagerForm : Form
    {

        private TreeNode lastSelected;

        public ArtManagerForm()
        {
            InitializeComponent();

            if (!Directory.Exists(Globals.CurrentProjectFolder + "\\Resources\\Art\\"))
                Directory.CreateDirectory(Globals.CurrentProjectFolder + "\\Resources\\Art\\");

            PopulateFolder(Globals.CurrentProjectFolder + "\\Resources\\Art\\", tvArtFiles.Nodes[0]);
        }

        private void PopulateFolder(string folder, TreeNode parent)
        {
            parent.Nodes.Clear();

            foreach (var path in Directory.GetDirectories(folder))
            {
                var dirName = Globals.ShortenName(path);
                var node = new TreeNode();
                node.Text = dirName;
                node.ImageIndex = 0;
                node.SelectedImageIndex = 0;

                parent.Nodes.Add(node);

                PopulateFolder(folder + dirName + "\\", node);
            }

            foreach (var file in Directory.GetFiles(folder))
            {
                var fileName = Globals.ShortenName(file);
                if (fileName.EndsWith(".sdd"))
                    continue;

                var node = new TreeNode();
                node.Text = fileName;
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;

                parent.Nodes.Add(node);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (lastSelected != null)
            {
                var openFiles = new OpenFileDialog();
                openFiles.Multiselect = true;
                openFiles.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.tiff;*.hdr;*.gif";
                openFiles.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (openFiles.ShowDialog() == DialogResult.OK)
                {
                    var originalPaths = openFiles.FileNames;
                    var fullPath = tvArtFiles.SelectedNode.FullPath;
                    foreach (var path in originalPaths)
                    {
                        var fileName = path.Substring(path.LastIndexOf('\\') + 1);
                        if (!File.Exists(Globals.CurrentProjectFolder + "\\Resources\\" + fullPath + "\\" + fileName))
                        {
                            File.Copy(path, Globals.CurrentProjectFolder + "\\Resources\\" + fullPath + "/" + fileName);
                            File.WriteAllText(Globals.CurrentProjectFolder + "\\Resources\\" + fullPath + "/" + fileName + ".sdd", "");
                        }
                        else
                        {
                            var replace = new FileReplaceForm();
                            replace.FileToCopy = path;
                            if (replace.ShowDialog() == DialogResult.OK)
                            {
                                File.Copy(path, replace.ResultPath);
                                File.WriteAllText(replace.ResultPath + ".sdd", "");
                            }
                        }
                    }
                }

                PopulateFolder(Globals.CurrentProjectFolder + "\\Resources\\" + lastSelected.FullPath, lastSelected);
            }
        }

        private void tvArtFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvArtFiles.SelectedNode != null)
            {
                if (File.Exists(Globals.GetResourcesPath() + "\\" + tvArtFiles.SelectedNode.FullPath))
                {
                    artPreview.Image = Image.FromFile(Globals.GetResourcesPath() + "\\" + tvArtFiles.SelectedNode.FullPath);

                    var dataFile = Globals.GetResourcesPath() + "\\" + tvArtFiles.SelectedNode.FullPath + ".sdd";
                    if (File.Exists(dataFile))
                    {
                        var content = File.ReadAllLines(dataFile);
                        if (content.Length > 0)
                        {
                            for (int i = 0; i < content.Length; i++)
                            {
                                if (i == 0)
                                {
                                    if (int.TryParse(content[i], out int type))
                                    {
                                        cmbImageType.SelectedIndex = type;
                                        btnProperties.Enabled = cmbImageType.SelectedIndex > 0;
                                    }
                                }
                                else
                                {
                                    if (cmbImageType.SelectedIndex == 1)
                                    {

                                    }
                                }
                            }
                        }
                    }

                    pnlImageProperties.Enabled = true;
                }
            }

            lastSelected = tvArtFiles.SelectedNode;
        }
    }
}

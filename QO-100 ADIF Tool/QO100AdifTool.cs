using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QO_100_ADIF_Tool
{
    public partial class QO100AdifTool : Form
    {
        private string fileOutput = null;
        private string originalFile = null;
        public QO100AdifTool()
        {
            InitializeComponent();
        }

        private void buttonLoadLog_Click(object sender, EventArgs e)
        {
            ToggleCheckboxChecked(false);
            ToggleCheckboxEnabled(false);
            buttonProcess.Enabled = false;

            if (openFileDialogLogFile.ShowDialog() == DialogResult.OK)
            {
                originalFile = openFileDialogLogFile.FileName;
                var fileStream = openFileDialogLogFile.OpenFile();
                ToggleCheckboxEnabled(true);
                buttonProcess.Enabled = true;

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    var fileContent = reader.ReadToEnd();

                    if (fileContent.Contains("Contest Name: DX"))
                    {
                        checkBoxGridsquare.Checked = true;
                        fileContent = Regex.Replace(fileContent, "<COMMENT:", "<GRIDSQUARE:", RegexOptions.IgnoreCase);
                    }

                    fileOutput = Regex.Replace(fileContent, "<EOR>", "<PROP_MODE:3>SAT <SAT_NAME:6>" + textBoxSatName.Text + " <EOR>", RegexOptions.IgnoreCase);
                }
            }
        }

        private void ToggleCheckboxEnabled(bool status)
        {
            checkBoxGridsquare.Enabled = status;
            checkBoxName.Enabled = status;
        }

        private void ToggleCheckboxChecked(bool status)
        {
            checkBoxGridsquare.Checked = status;
            checkBoxName.Checked = status;
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (checkBoxName.Checked && checkBoxGridsquare.Checked)
            {
                MessageBox.Show("Cannot transform comment to gridsquare and name at the same time. Select only one option.");
                return;
            }

            string directory = Path.GetDirectoryName(originalFile);
            string originalFileName = Path.GetFileNameWithoutExtension(originalFile);
            string fileName = Path.Combine(directory, originalFileName + "Corrected.adi");
            File.WriteAllText(fileName, fileOutput);
            MessageBox.Show("New Log created: " + fileName);
        }
    }
}
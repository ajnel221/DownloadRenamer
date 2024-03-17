#region Using Statements
using System;
using System.Timers;
using System.IO;
using System.Threading;
#endregion

namespace Download_Renamer
{
    public partial class Form1 : Form
    {
        #region Variables
        public string folderPath = string.Empty;
        public int seasonValue = 0;
        public int fromEpisode = 0;
        #endregion

        #region Initialize Component
        public Form1()
        {
            InitializeComponent();

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 1;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();

            if (folderPath == String.Empty)
            {
                runBtn.Enabled = false;
                seasonValueInput.Enabled = false;
            }
            else
            {
                seasonValueInput.Enabled = true;
            }
        }
        #endregion

        #region Directory Button
        private void selectDirBtn_Click(object sender, EventArgs e)
        {
            if (folderPath != String.Empty)
            {
                seasonValueInput.Enabled = true;
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;
            }
        }
        #endregion

        #region Build Button
        private void runBtn_Click(object sender, EventArgs e)
        {
            seasonValue = (int)seasonValueInput.Value;

            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            FileInfo[] fileInfo = directoryInfo.GetFiles();

            if (createDirectoryCheckBox.Checked)
            {
                string newFolderName = $"Season {seasonValue}";
                string newDirectoryPath = Path.Combine(folderPath, newFolderName);
                Directory.CreateDirectory(newDirectoryPath);

                for (int i = 0; i < fileInfo.Length; i++)
                {
                    string extension = Path.GetExtension(fileInfo[i].FullName);

                    int episodeNumber = fromEpisode + i;
                    string episodeNumberFormatted = (episodeNumber < 10) ? "0" + episodeNumber : episodeNumber.ToString();
                    string newFileName = $"S{seasonValue.ToString("D2")}E{episodeNumberFormatted}{extension}";

                    string newFilePath = Path.Combine(newDirectoryPath, newFileName);

                    File.Move(fileInfo[i].FullName, newFilePath);
                }

                MessageBox.Show("Finished Renaming All Your Files!");
            }
            else
            {
                for (int i = 0; i < fileInfo.Length; i++)
                {
                    string extension = Path.GetExtension(fileInfo[i].FullName);

                    int episodeNumber = fromEpisode + i;
                    string episodeNumberFormatted = (episodeNumber < 10) ? "0" + episodeNumber : episodeNumber.ToString();
                    string newFileName = $"S{seasonValue.ToString("D2")}E{episodeNumberFormatted}{extension}";

                    string newFilePath = Path.Combine(fileInfo[i].DirectoryName, newFileName);

                    try
                    {
                        File.Move(fileInfo[i].FullName, newFilePath);
                    }
                    catch
                    {
                        MessageBox.Show("Name Already Exists, File Will Be Skipped!");
                        break;
                    }
                }

                MessageBox.Show("Finished Renaming All Your Files!");
            }
        }
        #endregion

        #region Numeric Up Down
        private void seasonValueInput_ValueChanged(object sender, EventArgs e)
        {
            seasonValue = (int)seasonValueInput.Value;

            if ((int)seasonValueInput.Value < 1)
            {
                runBtn.Enabled = true;
            }
        }
        #endregion

        #region Update Timer
        void timer_Tick(object sender, EventArgs e)
        {
            seasonValue = (int)seasonValueInput.Value;

            if (folderPath == String.Empty)
            {
                runBtn.Enabled = false;
                seasonValueInput.Enabled = false;
                createDirectoryCheckBox.Enabled = false;
                fromRangeInput.Enabled = false;
            }
            else
            {
                seasonValueInput.Enabled = true;
            }

            if (seasonValueInput.Value == 0)
            {
                runBtn.Enabled = false;
                createDirectoryCheckBox.Enabled = false;
                fromRangeInput.Enabled = false;
            }
            else
            {
                runBtn.Enabled = true;
                createDirectoryCheckBox.Enabled = true;
                fromRangeInput.Enabled = true;
            }
        }
        #endregion

        private void fromRangeInput_ValueChanged(object sender, EventArgs e)
        {
            fromEpisode = (int)fromRangeInput.Value;

            if ((int)fromRangeInput.Value < 1)
            {
                runBtn.Enabled = true;
            }
        }
    }
}
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
        public string extention = string.Empty;
        public int seasonValue = 0;
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
                button2.Enabled = false;
                numericUpDown1.Enabled = false;
            }
            else
            {
                numericUpDown1.Enabled = true;
            }
        }
        #endregion

        #region Directory Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderPath != String.Empty)
            {
                numericUpDown1.Enabled = true;
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;
            }
        }
        #endregion

        #region Build Button
        private void button2_Click(object sender, EventArgs e)
        {
            seasonValue = (int)numericUpDown1.Value;

            DirectoryInfo d = new DirectoryInfo(folderPath);
            FileInfo[] infos = d.GetFiles();

            for (int i = 0; i < infos.Length; i++)
            {
                extention = Path.GetExtension(infos[i].Extension);

                if (seasonValue < 9)
                {
                    if (i < 9)
                    {
                        string temp = "S0" + seasonValue.ToString() + "E0" + (i + 1) + extention;
                        File.Move(infos[i].FullName, infos[i].FullName.Replace(infos[i].Name, temp));
                    }
                    else
                    {
                        string temp = "S0" + seasonValue.ToString() + "E" + (i + 1) + extention;
                        File.Move(infos[i].FullName, infos[i].FullName.Replace(infos[i].Name, temp));
                    }
                }
                else
                {
                    if (i < 9)
                    {
                       string temp = "S" + seasonValue.ToString() + "E0" + (i + 1) + extention;
                       File.Move(infos[i].FullName, infos[i].FullName.Replace(infos[i].Name, temp));
                    }
                    else
                    {
                        string temp = "S" + seasonValue.ToString() + "E" + (i + 1) + extention;
                        File.Move(infos[i].FullName, infos[i].FullName.Replace(infos[i].Name, temp));
                    }
                }
            }
        }
        #endregion

        #region Numeric Up Down
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            seasonValue = (int)numericUpDown1.Value;

            if ((int)numericUpDown1.Value < 1)
            {
                button2.Enabled = true;
            }
        }
        #endregion

        #region Update Timer
        void timer_Tick(object sender, EventArgs e)
        {
            seasonValue = (int)numericUpDown1.Value;
            
            if (folderPath == String.Empty)
            {
                button2.Enabled = false;
                numericUpDown1.Enabled = false;
            }
            else
            {
                numericUpDown1.Enabled = true;
            }

            if (numericUpDown1.Value == 0)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }
        #endregion
    }
}
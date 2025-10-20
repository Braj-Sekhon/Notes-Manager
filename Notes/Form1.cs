using System;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Runtime.InteropServices;

namespace Notes
{
    public partial class Form1 : Form
    {
        private static string defaultFolder = "NOTES";
        private static string defaultFile = "default.txt";
        private string targetFolder = defaultFolder;
        private string targetFile = defaultFile;

        private DirectoryInfo targetDirectory;

        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\DATA");
            Directory.SetCurrentDirectory(Directory.GetCurrentDirectory() + "\\DATA");
            targetFolder = defaultFolder;
            folderBox.Text = targetFolder;
            origBackColor = encryptCode.BackColor;
        }

        private void updateTargetDir()
        {
            if (targetDirectory == null)
            {
                targetDirectory = Directory.CreateDirectory(targetFolder);
            }
            else if (targetFolder != targetDirectory.Name)
            {
                targetDirectory = Directory.CreateDirectory(targetFolder);
            }
        }

        string targetFilePath()
        {
            return targetDirectory.FullName + "\\" + targetFile;
        }

        private void clearText()
        {
            textBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            updateTargetDir();
            if (File.Exists(targetFilePath()))
            {
                DialogResult result = MessageBox.Show("File already exists: \"" + targetFile + "\" do you want to overwrite?", "Confirm this request.", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    File.WriteAllText(targetFilePath(), textBox.Text);
                    fcTimeBox.Text = File.GetCreationTime(targetFilePath()).ToLongDateString();
                }
            }
            else
            {
                File.WriteAllText(targetFilePath(), textBox.Text);
                fcTimeBox.Text = File.GetCreationTime(targetFilePath()).ToLongDateString();
            }
            clearText();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            updateTargetDir();
            if (File.Exists(targetFilePath()))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the file: \"" + targetFile + "\"?", "Confirm this request.", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    File.Delete(targetFilePath());
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            updateTargetDir();
            if (File.Exists(targetFilePath()))
            {
                textBox.Text = File.ReadAllText(targetFilePath());
                fcTimeBox.Text = File.GetCreationTime(targetFilePath()).ToLongDateString();
            }
            else
            {
                MessageBox.Show("That file doesn't exist.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void fileNameBox_TextChanged(object sender, EventArgs e)
        {
            if (fileNameBox.Text.Length > 0)
            {
                targetFile = fileNameBox.Text + ".txt";
            }
            else
            {
                targetFile = defaultFile;
            }
        }

        private void folderBox_TextChanged(object sender, EventArgs e)
        {
            if (folderBox.Text.Length > 0)
            {
                targetFolder = folderBox.Text;
            }
            else
            {
                targetFolder = defaultFolder;
            }
        }

        private void getFilesButton_Click(object sender, EventArgs e)
        {
            updateTargetDir();
            string msg = "";
            foreach (FileInfo file in targetDirectory.GetFiles())
            {
                msg += file.Name + "\n";
            }
            MessageBox.Show(msg);
        }

        void changeDirectoryBox(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            string FullDirPath = tsmi.Tag.ToString();
            string DirPath = FullDirPath.Substring(Directory.GetCurrentDirectory().Length + 1);
            folderBox.Text = DirPath;
        }

        void changeBothBox(object sender, EventArgs e)
        {
            ToolStripMenuItem tsb = (ToolStripMenuItem)sender;
            string FullDirPath = tsb.Tag.ToString();
            string DirPath = FullDirPath.Substring(Directory.GetCurrentDirectory().Length + 1);
            folderBox.Text = DirPath;
            string filePath = tsb.Text.Substring(0, tsb.Text.Length - 4);
            fileNameBox.Text = filePath;
        }

        private void LoopThroughDirectory(DirectoryInfo dir, ToolStripMenuItem tsmi)
        {
            foreach (DirectoryInfo directory in dir.GetDirectories())
            {
                ToolStripMenuItem ltsmi = new ToolStripMenuItem(directory.Name);
                if (tsmi == null)
                {
                    directoriesDropDown.DropDownItems.Add(ltsmi);
                }
                else
                {
                    tsmi.DropDownItems.Add(ltsmi);
                }
                ltsmi.BackColor = Color.FromArgb(0, 0, 102);
                ltsmi.ForeColor = Color.White;
                ltsmi.Tag = directory.FullName;
                ltsmi.Click += changeDirectoryBox;

                foreach (FileInfo file in directory.GetFiles())
                {
                    ToolStripItem tsb = ltsmi.DropDownItems.Add(file.Name);
                    tsb.AutoSize = true;
                    tsb.BackColor = Color.FromArgb(0, 255, 0);
                    tsb.Tag = directory.FullName;
                    tsb.Click += changeBothBox;
                }

                if (directory.GetDirectories().Length > 0)
                {
                    LoopThroughDirectory(directory, ltsmi);
                }
            }
        }

        private void directoriesDropDown_Click(object sender, EventArgs e)
        {
            directoriesDropDown.DropDownItems.Clear();
            DirectoryInfo currDir = new DirectoryInfo(Directory.GetCurrentDirectory());
            LoopThroughDirectory(currDir, null);
        }

        int getCodeOffset()
        {
            string code = encryptCode.Text;
            int offset = code.Length;
            int num = 0;
            foreach (char c in code)
            {
                num += 1;
                if (offset > 25 || offset < -25)
                {
                    offset = 0;
                }
                offset += (c / 10) - num;
            }
            // encryptCode.PlaceholderText = offset.ToString();
            return offset;
        }

        string encrypt(string s)
        {
            int offset = getCodeOffset();
            string fullCode = "";
            int curIndex = 1;
            foreach (char c in s)
            {
                fullCode += (char)(c + (offset * curIndex));
                curIndex += 1;
            }
            return fullCode;
        }
        string decrypt(string s)
        {
            int offset = getCodeOffset();
            string fullCode = "";
            int curIndex = 1;
            foreach (char c in s)
            {
                fullCode += (char)(c - (offset * curIndex));
                curIndex += 1;
            }
            return fullCode;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            textBox.Text = encrypt(textBox.Text);
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            textBox.Text = decrypt(textBox.Text);
        }


        private bool isMouseOnEncrypt = false;
        private Color origBackColor;

        private void refreshEncryptBox()
        {
            if(encryptCode.Text=="" || isMouseOnEncrypt==true)
            {
                encryptCode.BackColor = origBackColor;
            }
            else
            {
                encryptCode.BackColor = Color.Black;
            }
        }

        private void encryptCode_MouseHover(object sender, EventArgs e)
        {
            isMouseOnEncrypt = true;
            refreshEncryptBox();
        }

        private void encryptCode_MouseLeave(object sender, EventArgs e)
        {
            isMouseOnEncrypt = false;
            refreshEncryptBox();
        }

        private void encryptCode_TextChanged(object sender, EventArgs e)
        {
            refreshEncryptBox();
        }
    }
}

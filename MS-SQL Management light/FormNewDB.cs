using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_SQL_Management_light
{
    public partial class FormNewDB : Form
    {
        public delegate void OnNewDBErfolg();
        public OnNewDBErfolg ObjectExplorerRefresh;
        public void CallObjectExplorerRefresh()
        {
            if (null != this.ObjectExplorerRefresh)
            {
                this.ObjectExplorerRefresh();
            }
        }

        public FormNewDB(string dBName = "")
        {
            InitializeComponent();

            textBoxDBname.Enabled = dBName == "";
            textBoxDBname.Text = dBName;
        }
        private void FileDialogInit(bool isLog)
        {
                saveFileDialog.InitialDirectory =
                Path.GetFullPath(Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"C:\"));

            if (isLog)

                openFileDialog.Filter =
                saveFileDialog.Filter =
                "SQL DB-DATA-Datei (*.mdf)|*.mdf|" +
                "Alle Dateien (*.*)|*.*";
            else
                openFileDialog.Filter =
                saveFileDialog.Filter =
                "SQL DB-LOG-Datei (*.ldf)|*.ldf|" +
                "Alle Dateien (*.*)|*.*";

            saveFileDialog.FilterIndex = 1;
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            FileDialogInit(((sender as Button).Name == "buttonLogPath"));
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel) return;

            string path = folderBrowserDialog.SelectedPath;
            if (checkBoxSamePath.Checked)
            {
                textBoxLogFile.Text = path
                    + (path[path.Length-1] == '\\' ? "" : "\\") 
                    + textBoxDBname.Text + "_log.ldf";
                textBoxDataFile.Text = path
                    + (path[path.Length - 1] == '\\' ? "" : "\\")
                    + textBoxDBname.Text + ".mdf";
            }
            else if ((sender as Button).Name == "buttonLogPath")
                textBoxLogFile.Text = path
                    + (path[path.Length - 1] == '\\' ? "" : "\\")
                    + textBoxDBname.Text + "_log.ldf";
            else textBoxDataFile.Text = path
                    + (path[path.Length - 1] == '\\' ? "" : "\\")
                    + textBoxDBname.Text + ".mdf";
        }

        private void checkBoxSamePath_Click(object sender, EventArgs e)
        {
            labelLog.Enabled = textBoxLogFile.Enabled = buttonLogPath.Enabled = !checkBoxSamePath.Checked;
        }

        private void textBoxDBname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string path = Path.GetDirectoryName(textBoxDataFile.Text);
                if (Directory.Exists(path))
                {
                    textBoxDataFile.Text = path
                        + (path[path.Length - 1] == '\\' ? "" : "\\")
                        + textBoxDBname.Text + ".mdf";
                }
                else
                {
                    textBoxDataFile.Text = textBoxDBname.Text + ".mdf";
                }

                path = Path.GetDirectoryName(textBoxLogFile.Text);
                if (Directory.Exists(path))
                {
                    textBoxLogFile.Text = path
                     + (path[path.Length - 1] == '\\' ? "" : "\\")
                     + textBoxDBname.Text + "_log.ldf";
                }
                else
                {
                    textBoxLogFile.Text = textBoxDBname.Text + "_log.ldf";
                }
                   
            }
            catch (Exception)
            {

                textBoxDataFile.Text = textBoxDBname.Text + ".mdf";
                textBoxLogFile.Text =  textBoxDBname.Text + "_log.ldf";
            }

        }

        private void buttonAbbrechnen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string mess;
            if (DbAccess.CreateNewDB(textBoxDBname.Text, textBoxDataFile.Text, textBoxLogFile.Text, out mess))
            {
                MessageBox.Show("Datenbank ["+ textBoxDBname.Text + "] ist erfolfreich hergestellt", "Neue Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CallObjectExplorerRefresh();
                Close();
            }
            else MessageBox.Show(mess, "Neue Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }
    }

}

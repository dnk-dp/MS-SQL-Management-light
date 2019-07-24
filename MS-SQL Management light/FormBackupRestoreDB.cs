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
    public partial class FormBackupRestoreDB : Form
    {
        public delegate void OnBackupRestoreDBErfolg();
        public OnBackupRestoreDBErfolg ObjectExplorerRefresh;
        public void CallObjectExplorerRefresh()
        {
            if (null != this.ObjectExplorerRefresh)
            {
                this.ObjectExplorerRefresh();
            }
        }

        private bool isBackup;
        public FormBackupRestoreDB(bool isBackup, string dBName)
        {
            InitializeComponent();
            this.isBackup = isBackup;
            ComboBoxDBHinzufügen();
            FileDialogInit();
            if (isBackup) this.Text = "Backup...";
            else this.Text = "Wiederherstellung...";
            comboBoxDatenbankname.Text = dBName;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string mess;
            if (isBackup)
            { // BACKUP
                if (comboBoxDatenbankname.Items.IndexOf(comboBoxDatenbankname.Text) <0)
                {
                    MessageBox.Show("Datenbank [" + comboBoxDatenbankname.Text + "] existiert nicht!", "Backup Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    comboBoxDatenbankname.Focus();
                    return;
                }
                if (File.Exists(textBoxBackupdatai.Text))
                {
                    MessageBox.Show("Datei [" + textBoxBackupdatai.Text + "] existiert!\nWählen Sie neue Datei aus!", "Backup Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBoxBackupdatai.Focus();
                    return;
                }
                if (DbAccess.BackupDB(comboBoxDatenbankname.Text, textBoxBackupdatai.Text, out mess))
                {
                    MessageBox.Show("Datenbank [" + comboBoxDatenbankname.Text + "] ist erfolfreich gespeichert", "Backup Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else MessageBox.Show(mess, "Backup Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else // RESTORE
            {
                if (comboBoxDatenbankname.Text=="")
                {
                    MessageBox.Show("Datenbankname darf nicht leer sein", "Restore Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    comboBoxDatenbankname.Focus();
                    return;
                }
                bool isOldDB = true;
                if (comboBoxDatenbankname.Items.IndexOf(comboBoxDatenbankname.Text) < 0)
                {
                    if (MessageBox.Show("Datenbank [" + comboBoxDatenbankname.Text + "] nicht existiert\nWollen Sie neuen Datenbank erstellen?", 
                            "Restore Datenbank", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                        return;
                    FormNewDB formNewDB = new FormNewDB(comboBoxDatenbankname.Text);
                    formNewDB.ShowDialog();
                    isOldDB = false;
                }
                if (isOldDB && MessageBox.Show("Alle alte Daten in [" + comboBoxDatenbankname.Text + "] werden löschen!\n" +
                    "Wollen Sie es weiter machen?", "Restore Datenbank", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                if (DbAccess.RestoreDB(comboBoxDatenbankname.Text, textBoxBackupdatai.Text, out mess))
                {
                    MessageBox.Show("Datenbank [" + comboBoxDatenbankname.Text + "] ist erfolfreich wieder hergestellt", "Restore Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CallObjectExplorerRefresh();
                    Close();
                }
                else MessageBox.Show(mess, "Restore Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ComboBoxDBHinzufügen()
        {
            comboBoxDatenbankname.Items.Clear();
            DataTable dtDBName = DbAccess.GetDBNamen(false);
            foreach (DataRow row in dtDBName.Rows)
            {
                comboBoxDatenbankname.Items.Add(row[0].ToString());
            }
           
        }
        private void FileDialogInit()
        {
            openFileDialog.InitialDirectory =
            saveFileDialog.InitialDirectory =
            Path.GetFullPath(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"C:\"));

            openFileDialog.Filter =
            saveFileDialog.Filter =
            "SQL DB-Backup (*.bak)|*.bak|" +
            "Alle Dateien (*.*)|*.*";

            openFileDialog.FilterIndex = saveFileDialog.FilterIndex = 0;
        }

        private void buttonBackupdatai_Click(object sender, EventArgs e)
        {
            if (isBackup)
            {
                saveFileDialog.FileName = comboBoxDatenbankname.Text + String.Format("_{0:yyyyMMdd}", DateTime.Now);
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
                textBoxBackupdatai.Text = saveFileDialog.FileName;
            }
            else
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
                textBoxBackupdatai.Text = openFileDialog.FileName;
            }
        }
    }
}

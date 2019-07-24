using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MS_SQL_Management_light
{
    
    public partial class FormConnectionSettings : Form
    {
        private bool canClose = true;
        public FormConnectionSettings()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            LoadSettings();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (!canClose)
                e.Cancel = true;
            else saveSettings();

        }

        private void buttonVerbinden_Click(object sender, EventArgs e)
        {
            if (DbAccess.TestConnection(
                                    comboBoxAuthentifizierung.SelectedIndex,
                                    comboBoxServername.Text,
                                    "master",
                                    comboBoxBenutzername.Text,
                                    textBoxKennwort.Text))
                canClose = true;
            else
            {
                canClose = false;
                MessageBox.Show("Keine Verbindung!", "Verbindung", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void saveSettings()
        {

            StringBuilder sb = new StringBuilder();
            foreach (string item in comboBoxServername.Items)
            {
                if (item.Trim() != string.Empty)
                    sb.Append(item + ";");
            }
            Properties.Settings.Default.ServernameItems = sb.ToString();
            Properties.Settings.Default.ServernameText = comboBoxServername.Text;


            sb.Clear();

            foreach (string item in comboBoxBenutzername.Items)
            {
                if (item.Trim() != string.Empty)
                    sb.Append(item + ";");
            }
            Properties.Settings.Default.BenutzernameItems = sb.ToString();
            Properties.Settings.Default.BenutzernameText = comboBoxBenutzername.Text;

            Properties.Settings.Default.AuthentifizierungItemIndex = comboBoxAuthentifizierung.SelectedIndex;

            Properties.Settings.Default.Kennwort = checkBoxKennwortSpeichern.Checked ? textBoxKennwort.Text : string.Empty;

            Properties.Settings.Default.Save();
        }
        private void LoadSettings()
        {
            comboBoxServername.Items.AddRange(Properties.Settings.Default.ServernameItems.Split(';'));
            comboBoxServername.Text = Properties.Settings.Default.ServernameText;
            comboBoxBenutzername.Items.AddRange(Properties.Settings.Default.BenutzernameItems.Split(';'));
            comboBoxBenutzername.Text = Properties.Settings.Default.BenutzernameText;

            comboBoxAuthentifizierung.SelectedIndex = Properties.Settings.Default.AuthentifizierungItemIndex;

            textBoxKennwort.Text = Properties.Settings.Default.Kennwort;
            checkBoxKennwortSpeichern.Checked = textBoxKennwort.Text != string.Empty;

        }

        private void buttonbuttonVerbindungTesten_Click(object sender, EventArgs e)
        {
            if (comboBoxServername.Text == "") comboBoxServername.Text = "(local)";
            if (!comboBoxServername.Items.Contains(comboBoxServername.Text))
                comboBoxServername.Items.Add(comboBoxServername.Text);

            if (!comboBoxBenutzername.Items.Contains(comboBoxBenutzername.Text))
                comboBoxBenutzername.Items.Add(comboBoxBenutzername.Text);

            if (DbAccess.TestConnection(
                                    comboBoxAuthentifizierung.SelectedIndex,
                                    comboBoxServername.Text,
                                    "master",
                                    comboBoxBenutzername.Text,
                                    textBoxKennwort.Text))
                MessageBox.Show("Erfolgreiche Verbindung!", "Verbindung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else MessageBox.Show("Keine Verbindung!", "Verbindung", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void comboBoxAuthentifizierung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAuthentifizierung.SelectedIndex==0)
            {
                comboBoxBenutzername.Text = "";
                textBoxKennwort.Text = "";
            }
            comboBoxBenutzername.Enabled =
                textBoxKennwort.Enabled =
                checkBoxKennwortSpeichern.Checked =
                checkBoxKennwortSpeichern.Enabled =
                    comboBoxAuthentifizierung.SelectedIndex != 0;
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            canClose = true;
        }
    }
}

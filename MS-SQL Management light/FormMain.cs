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
    public partial class FormMain : Form
    {
        private bool activeVerbindung = false;
        private UserControlTree ucTree;
        private List<UserControlEditor> listEditor;
        public FormMain()
        {
            InitializeComponent();
            FileDialogsInit();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.F5):
                    toolStripButtonAusfuhren.PerformClick();
                    break;
                case (Keys.Control | Keys.N):
                    toolStripButtonNeueAbfrage.PerformClick();
                    break;
                case (Keys.Control | Keys.O):
                    toolStripButtonDataiOffnen.PerformClick();
                    break;
                case (Keys.Control | Keys.S):
                    toolStripButtonSpeichern.PerformClick();
                    break;
                case (Keys.Control | Keys.Shift | Keys.S):
                    toolStripButtonAllesSpeichern.PerformClick();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnLoad(EventArgs e)
        {
            loadSettings();
            objectExplorerToolStripMenuItem.Checked = !objectExplorerToolStripMenuItem.Checked;
            objectExplorerToolStripMenuItem.PerformClick();
            dBverbindenToolStripMenuItem.PerformClick();
            dBTrennenToolStripMenuItem.Enabled = activeVerbindung;
            dBverbindenToolStripMenuItem.Enabled = !activeVerbindung;
            BuildUserControlTree();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            bool saveQuestion = false;
            string queries ="";
            foreach (TabPage tp in tabControlMain.TabPages)
            {
                if (tp.Text[tp.Text.Trim().Length - 1] == '*')
                {
                    saveQuestion = true;
                    queries += tp.Text.Trim()+"\n";
                }
            }
            if (saveQuestion)
            {
                switch (MessageBox.Show("Es gibt ungespeicherte Abfragen:\n" + queries + "\nWollen Sie es speichern?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        toolStripButtonAllesSpeichern.PerformClick();
                        break;
                    default:
                        break;
                }
            }


            base.OnClosing(e);
            saveSettings();
        }


        private void BuildUserControlTree()
        {
            splitContainerMain.Panel1Collapsed = !activeVerbindung;
            if (activeVerbindung)
            {
                
                ucTree = new UserControlTree();
                this.splitContainerMain.Panel1.Controls.Add(this.ucTree);
                ucTree.Dock = DockStyle.Fill;
                ucTree.NeueAbfrage_Click = new UserControlTree.OnNeueAbfrage_Click(this.NeueAbfrage_Click);
                ucTree.SelectTop1000 = new UserControlTree.OnSelectTop1000(this.SelectTop1000);
                ucTree.Verbinden_Click = new UserControlTree.OnVerbinden_Click(this.FormConnectionOpen);
                listEditor = new List<UserControlEditor>();
            } 
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FileDialogsInit()
        {
            openFileDialog.InitialDirectory =
                saveFileDialog.InitialDirectory =
                Path.GetFullPath(Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"\Documents"));

            openFileDialog.Filter =
                saveFileDialog.Filter =
                "Textdateien (*.txt)|*.txt|" +
                "SQL Server-Dateien (*.sql)|*.sql|" +
                "Alle Dateien (*.*)|*.*";

            openFileDialog.FilterIndex =
                saveFileDialog.FilterIndex = 2;
        }

        private void FormConnectionOpen()
        {
            FormConnectionSettings fConnect = new FormConnectionSettings();
            activeVerbindung = fConnect.ShowDialog(this) == DialogResult.OK;
            if (activeVerbindung)
            ComboBoxDBHinzufügen();
        }

        private void dBverbindenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConnectionOpen();
        }

        private void ComboBoxDBHinzufügen()
        {
            toolStripComboBoxDB.Items.Clear();
            DataTable dtDBName = DbAccess.GetDBNamen(true);
            foreach (DataRow row in dtDBName.Rows)
            {
                toolStripComboBoxDB.Items.Add(row[0].ToString());
            }
            dtDBName = DbAccess.GetDBNamen(false);
            foreach (DataRow row in dtDBName.Rows)
            {
                toolStripComboBoxDB.Items.Add(row[0].ToString());
            }
        }

        private void dBTrennenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeVerbindung = false;
            dBTrennenToolStripMenuItem.Enabled = activeVerbindung;
            dBverbindenToolStripMenuItem.Enabled = !activeVerbindung;
        }

        private void objectExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainerMain.Panel1Collapsed = !objectExplorerToolStripMenuItem.Checked;
            saveSettings();
        }

        private void loadSettings()
        {
            objectExplorerToolStripMenuItem.Checked = Properties.Settings.Default.objectExplorerToolStripMenuItem;
        }
        private void saveSettings()
        {
            Properties.Settings.Default.objectExplorerToolStripMenuItem = objectExplorerToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }

        private void tabControlMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.tabControlMain.TabPages[e.Index];
                var tabRect = this.tabControlMain.GetTabRect(e.Index);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap(Properties.Resources.CloseBtn);
                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                    tabRect, tabPage.ForeColor, TextFormatFlags.Left);

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void tabControlMain_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < this.tabControlMain.TabPages.Count; i++)
            {
                var tabRect = this.tabControlMain.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap(Properties.Resources.CloseBtn);
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                TabPage tp = tabControlMain.TabPages[i];
                UserControlEditor ucE = tp.Controls["UserControlEditor"] as UserControlEditor;
                if (imageRect.Contains(e.Location))
                {

                    if (tp.Text[tp.Text.Trim().Length - 1] == '*')
                    {

                        switch (MessageBox.Show(
                                    String.Format("Sollen die Änderungen am folgenden Element: {0}  gespeichert werden!",
                                        tp.Text.Remove(tp.Text.Trim().Length - 1)),
                                    "Schließung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:
                                if (!SaveFile(tp)) break;
                                listEditor.Remove(ucE);
                                toolStripButtonAusfuhren.Enabled = listEditor.Count != 0;
                                tabControlMain.TabPages.RemoveAt(i);
                                break;
                            case DialogResult.No:
                                listEditor.Remove(ucE);
                                tabControlMain.TabPages.RemoveAt(i);
                                toolStripButtonAusfuhren.Enabled = listEditor.Count != 0;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        listEditor.Remove(ucE);
                        toolStripButtonAusfuhren.Enabled = listEditor.Count != 0;
                        tabControlMain.TabPages.RemoveAt(i);
                    }
                }
            }
        }
        private void NewQueryWindow(string fileName)
        {
            UserControlEditor ucEditor = new UserControlEditor(fileName);

            listEditor.Add(ucEditor);
            TabPage tp = new TabPage(Path.GetFileName(fileName) + "     ");
            tp.Controls.Add(ucEditor);

            ucEditor.Dock = DockStyle.Fill;
            tabControlMain.TabPages.Add(tp);
            tabControlMain.SelectedTab = tp;
            toolStripComboBoxDB.Text = ucTree.CurrentDBName;
            ucEditor.CurrentDBName = toolStripComboBoxDB.Text;
            toolStripButtonAusfuhren.Enabled = true;
            ucEditor.Focus();
        }

        private void toolStripButtonNeueAbfrage_Click(object sender, EventArgs e)
        {
            NewQueryWindow("SQLQuery" + (tabControlMain.TabCount + 1).ToString() + ".sql     ");
        }

        public void NeueAbfrage_Click()
        {
            toolStripButtonNeueAbfrage.PerformClick();
        }

        public void SelectTop1000(string tableName)
        {
            toolStripButtonNeueAbfrage.PerformClick();
            listEditor[listEditor.Count - 1].SelectTop1000(tableName);
        }

        private void toolStripButtonDataiOffnen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.Cancel) return;

            NewQueryWindow(openFileDialog.FileName);
        }


        private bool SaveFile(TabPage tp)
        {
            UserControlEditor ucE = tp.Controls["UserControlEditor"] as UserControlEditor;
            string fileName = ucE.FileName;

            if (tp.Text[tp.Text.Trim().Length - 1] == '*')
            {
                if (!File.Exists(fileName))
                {
                    saveFileDialog.FileName = tp.Text.Remove(tp.Text.Trim().Length - 1);
                    if (saveFileDialog.ShowDialog(this) == DialogResult.Cancel) return false;
                    fileName = saveFileDialog.FileName;
                }

                return ucE.SaveFile(fileName);
            }
            return false;
        }

        private void toolStripButtonSpeichern_Click(object sender, EventArgs e)
        {
            if (tabControlMain.TabPages.Count == 0) return;
            SaveFile(tabControlMain.SelectedTab);
        }

        private void toolStripButtonAllesSpeichern_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tabControlMain.TabCount; i++)
            {
                SaveFile(tabControlMain.TabPages[i]);
            }
        }

        private void toolStripButtonAusfuhren_Click(object sender, EventArgs e)
        {
            UserControlEditor ucE = tabControlMain.SelectedTab.Controls["UserControlEditor"] as UserControlEditor;
            ucE.ExecSQL();
        }

        private void toolStripButtonAusfuhren_EnabledChanged(object sender, EventArgs e)
        {
            tabControlMain.Visible = toolStripButtonAusfuhren.Enabled;
        }

        private void toolStripComboBoxDB_TextChanged(object sender, EventArgs e)
        {
            DbAccess.ChangeDBinConnectionString(toolStripComboBoxDB.Text);
            UserControlEditor ucE = tabControlMain.SelectedTab.Controls["UserControlEditor"] as UserControlEditor;
            ucE.CurrentDBName = toolStripComboBoxDB.Text;
        }

        private void toolStripButtonVerbindungAndern_Click(object sender, EventArgs e)
        {
            FormConnectionOpen();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo fi = new FormInfo();
            fi.ShowDialog(this);
        }
    }
}
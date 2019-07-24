using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

namespace MS_SQL_Management_light
{
    public partial class UserControlEditor : UserControl
    {
        private string[] splits = {
                ".", " ", ",", ":", ";", "<", ">", "!", "@", "#", "$", "%", "^", "&", "+", "-", "*", ")",
                "(", "{", "}", "[", "]", "\n", "\r", Environment.NewLine };

        private bool changesMade = false;
        private bool isOpenFile = false;

        private string currentDBName = "master";
        public string CurrentDBName
        {
            set
            {
                toolStripLabelDB.Text = currentDBName = value;
            }
            get { return currentDBName; }
        }

        private string fileName = "";
        public string FileName { get { return fileName; } }

        public UserControlEditor()
        {
            InitializeComponent();
            toolStripComboBoxSkalierung.SelectedIndex = Properties.Settings.Default.UserControlTreeSkalierung;
            splitContainerMain.Panel2Collapsed = true;
            richTextBoxMain.Focus();
        }

        public UserControlEditor(string file) :this()
        {
            fileName = file;
            OpenFile(file);
        }

        private void OpenFile(string file)
        {
            if (!File.Exists(file)) return;
            
            try
            {
                isOpenFile = true;
                richTextBoxMain.LoadFile(file, RichTextBoxStreamType.UnicodePlainText);
                
            }
            finally
            {
                isOpenFile = false;
            }
        }

        public bool SaveFile(string file)
        {
            try
            {

                richTextBoxMain.SaveFile(file, RichTextBoxStreamType.UnicodePlainText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Fehler beim Speichern der Datei '" + file +
                    "'\n\n" + ex.Message, "Speichern: " + ex.GetType().Name,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (changesMade)
            {
                string s = (this.Parent as TabPage).Text.Trim();
                if (s[s.Trim().Length-1] == '*')
                    (this.Parent as TabPage).Text = Path.GetFileName(file) + "     ";
            }
            changesMade = false;

            return true;
        }

        public void SelectTop1000(string tableName)
        {
            ExecSQL(DbAccess.BuldSelectTop1000Query(tableName));
        }
        public void ExecSQL(string sqlText = "")
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            string mess = "";
            DataTable dtTable;
            int count;
            if (richTextBoxMain.Text == String.Empty)
            {
                isOpenFile = true;
                richTextBoxMain.Text = sqlText;
                isOpenFile = false;
            }
            bool erfolgExec = DbAccess.ExecSQL(richTextBoxMain.Text, out dtTable, out mess, out count);
            Color color = erfolgExec ? Color.Black : Color.Red;
            splitContainerMain.Panel2.Controls.Clear();
            if (dtTable is null)
            {
                RichTextBox rtb = new RichTextBox();
                rtb.Text = mess;
                rtb.SelectAll();
                rtb.SelectionColor = color;
                rtb.ReadOnly = true;
                rtb.ZoomFactor = richTextBoxMain.ZoomFactor;
                splitContainerMain.Panel2.Controls.Add(rtb);
                rtb.Dock = DockStyle.Fill;
                splitContainerMain.Panel2Collapsed = false;
                
            }
            else
            {
                DataGridView dgv = new DataGridView();
                dgv.DataSource = dtTable;
                dgv.ReadOnly = true;
                dgv.BackgroundColor = SystemColors.Window;
                splitContainerMain.Panel2.Controls.Add(dgv);
                dgv.Dock = DockStyle.Fill;
                
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                splitContainerMain.Panel2Collapsed = false;
            }
            Bitmap bmp;
            if (erfolgExec)
            {
                toolStripLabelMessage.Text = "Die Abfrage wurde erfolgreich ausgeführt";
                bmp = new Bitmap(Properties.Resources.OK);
            }
            else
            {
                toolStripLabelMessage.Text = "Die Abfrage wurde mit Fehlern abgeschlossen";
                bmp = new Bitmap(Properties.Resources.Fehler);
            }
            toolStripLabelImage.Image = bmp;
            stopWatch.Stop();
            toolStripLabelRecords.Text = count.ToString() + " Zeilen";
            toolStripLabelZeit.Text = stopWatch.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private struct ColorElement
        {
            public int startPos;
            public int endPos;
            public Color color;
            public ColorElement(int startPos, int endPos, Color color)
            {
                this.startPos = startPos;
                this.endPos = endPos;
                this.color = color;
            }
        }

        private bool SerchArea(List<ColorElement> colorMap, string sighStart, string sighEnd, int serchPos, out int startPos, out int endPos)
        {
            bool firstSign = true, mustSkip = false;
            startPos = -1;
            endPos = -1;
            while (serchPos >= 0 && serchPos < richTextBoxMain.Text.Length)
            {
                if (firstSign) serchPos = richTextBoxMain.Find(sighStart, serchPos, RichTextBoxFinds.NoHighlight | RichTextBoxFinds.None);
                else
                {
                    if (sighEnd == Environment.NewLine)
                    {
                        int nextLine = richTextBoxMain.GetLineFromCharIndex(serchPos);
                        if (nextLine < richTextBoxMain.Lines.Length - 1)
                        {
                            nextLine++;
                            serchPos = richTextBoxMain.GetFirstCharIndexFromLine(nextLine) -2;
                        }

                    }
                    else serchPos = richTextBoxMain.Find(sighEnd, serchPos, RichTextBoxFinds.NoHighlight | RichTextBoxFinds.None);

                }
                foreach (ColorElement item in colorMap)
                {
                    if (serchPos>= item.startPos && serchPos <= item.endPos)
                    {
                        mustSkip = true;
                        break;
                    }
                }
                if (mustSkip)
                {
                    mustSkip = false;
                    serchPos += sighEnd.Length;
                    continue;
                }
                if (serchPos >= 0)
                {
                    if (firstSign)
                    {
                        startPos = serchPos;
                        serchPos += sighStart.Length;
                    }
                    else
                    {
                        endPos = serchPos + sighEnd.Length;
                        serchPos += sighEnd.Length;
                    }
                    firstSign = !firstSign;
                }
                if (startPos >= 0 && endPos >= 0)
                {
                    return true;
                }
            }
            if (!firstSign && startPos >= 0 && endPos == -1)
            {
                endPos = richTextBoxMain.Text.Length;
                return true;
            }

            return false;
        }
        private bool SerchWord(List<ColorElement> colorMap, string word, int serchPos, out int startPos, out int endPos)
        {
            bool mustSkip = false;
            startPos = -1;
            endPos = -1;
            while (serchPos >= 0 && serchPos < richTextBoxMain.Text.Length)
            {
                serchPos = richTextBoxMain.Find(word, serchPos, RichTextBoxFinds.NoHighlight|RichTextBoxFinds.WholeWord);

                foreach (ColorElement item in colorMap)
                {
                    if (serchPos >= item.startPos && serchPos <= item.endPos)
                    {
                        mustSkip = true;
                        break;
                    }
                }
                if (mustSkip)
                {
                    mustSkip = false;
                    serchPos += word.Length;
                    continue;
                }
                if (serchPos >= 0)
                {
                    startPos = serchPos;
                    endPos = startPos + word.Length;
                    serchPos = endPos;
                    return true;
                }
            }
            return false;
        }
        private void SelectCommandNew()
        {
            int selStart = richTextBoxMain.SelectionStart;

            List<ColorElement> colorMap = new List<ColorElement>();

            // Serch Comment
            string sighStart = "/*";
            string sighEnd = "*/";
            int serchPos = 0;
            int startPos, endPos;
            while (SerchArea(colorMap, sighStart, sighEnd, serchPos, out startPos, out endPos))
            {
                colorMap.Add(new ColorElement(startPos, endPos, Color.Green));
                serchPos = endPos;
            }
            sighStart = "--";
            sighEnd = Environment.NewLine;
            serchPos = 0;
            while (SerchArea(colorMap, sighStart, sighEnd, serchPos, out startPos, out endPos))
            {
                colorMap.Add(new ColorElement(startPos, endPos, Color.Green));
                serchPos = endPos;
            }
            //--------------

            // Serch string
            const string stringSign = "'";
            serchPos = 0;
            while (SerchArea(colorMap, stringSign, stringSign, serchPos, out startPos, out endPos))
            {
                colorMap.Add(new ColorElement(startPos, endPos, Color.Red));
                serchPos = endPos;
            }
            //-------------

            // Serch reserv Word
            foreach (var item in WortReserv.CommandMapping2)
            {
                serchPos = 0;
                while (SerchWord(colorMap, item.Word, serchPos, out startPos, out endPos))
                {
                    colorMap.Add(new ColorElement(startPos, endPos, item.Color));
                    serchPos = endPos;
                }
            }
            //------------------

            richTextBoxMain.SuspendLayout();
            richTextBoxMain.Select(0, richTextBoxMain.Text.Length);
            richTextBoxMain.SelectionColor = Color.Black;
            foreach (ColorElement item in colorMap)
            {
                richTextBoxMain.Select(item.startPos, item.endPos-item.startPos);
                richTextBoxMain.SelectionColor = item.color;
            }
            richTextBoxMain.Select(selStart, 0);
            richTextBoxMain.ResumeLayout();
        }

        private void richTextBoxMain_TextChanged(object sender, EventArgs e)
        {
            SelectCommandNew();

            if (isOpenFile) return;

            if (!changesMade) (this.Parent as TabPage).Text = (this.Parent as TabPage).Text.Trim() + "*     ";

            changesMade = true;
            if (changesMade && richTextBoxMain.Text =="")
            {
                changesMade = false;
                (this.Parent as TabPage).Text =(this.Parent as TabPage).Text.Replace('*', ' ');
            }
        }

        private void toolStripComboBoxSkalierung_SelectedIndexChanged(object sender, EventArgs e)
        {
            float zoomFactor = 1F;
            switch (toolStripComboBoxSkalierung.SelectedIndex)
            {
                case 0: zoomFactor = 0.2F;  break; //20% 
                case 1: zoomFactor = 0.5F;  break; //50%
                case 2: zoomFactor = 0.7F;  break; //70%
                case 4: zoomFactor = 1.5F;  break; //150%
                case 5: zoomFactor = 2F;    break; //200%
                case 6: zoomFactor = 4F;    break; //400%
            }
            richTextBoxMain.ZoomFactor = zoomFactor;
            richTextBoxMain.Focus();
            Properties.Settings.Default.UserControlTreeSkalierung = toolStripComboBoxSkalierung.SelectedIndex;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_SQL_Management_light
{

    public partial class UserControlTree : UserControl
    {
        enum NodeType { Server, Folder, DB, Table, Field, Empty }

        public delegate void OnNeueAbfrage_Click();
        public OnNeueAbfrage_Click NeueAbfrage_Click;
        public void CallNeueAbfrage_Click()
        {
            if (null != this.NeueAbfrage_Click)
            {
                this.NeueAbfrage_Click();
            }
        }

        

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.F5):
                    ObjectExplorerActualisieren();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public delegate void OnSelectTop1000(string table);
        public OnSelectTop1000 SelectTop1000;
        public void CallSelectTop1000(string table)
        {
            if (null != this.SelectTop1000)
            {
                this.SelectTop1000(table);
            }
        }
        public delegate void OnSelectTabGroes(string dbName);
        public OnSelectTabGroes SelectTabGroes;
        public void CallSelectTabGroes(string dbName)
        {
            if(null!=this.SelectTabGroes)
            {
                this.SelectTabGroes(dbName);
            }
        }

        public delegate void OnVerbinden_Click();
        public OnVerbinden_Click Verbinden_Click;
        public void CallVerbinden_Click()
        {
            if (null != this.Verbinden_Click)
            {
                this.Verbinden_Click();
            }

        }

        private string currentDBName = "master";
        private struct NodeCondition
        {
            public NodeType type;
            public bool isEmpty;

            public NodeCondition(NodeType type, bool isEmpty)
            {
                this.type = type;
                this.isEmpty = isEmpty;
            }
        }

        public UserControlTree()
        {
            InitializeComponent();
            BuildContextMenu();
            ObjectExplorerActualisieren();
        }

        public void ObjectExplorerTrennen()
        {
            treeViewStruct.Nodes.Clear();
            toolStripButtonAktualisieren.Enabled = false;
            toolStripButtonTrennen.Enabled = false;
        }

        public void ObjectExplorerActualisieren()
        {
           
            treeViewStruct.Nodes.Clear();
            TreeNode tnSRV = new TreeNode(Properties.Settings.Default.ServernameText, 0, 0);
            NodeCondition nc = new NodeCondition(NodeType.Server, false);
            
            treeViewStruct.Nodes.Add(tnSRV);
            
            tnSRV.Tag = nc;
            addServerGroup(tnSRV);
            toolStripButtonAktualisieren.Enabled = true;
            toolStripButtonTrennen.Enabled = true;
            tnSRV.Expand();


        }

        #region mein Methoden

        private void AddContextMenu(NodeType nt, string text, string name)
        {
            ToolStripMenuItem tsm;
            tsm = new ToolStripMenuItem(text, null, ToolStripMenuItem_Click, name);
            tsm.Tag = nt;
            contextMenuStrip.Items.Add(tsm);
        }
        private void BuildContextMenu()
        {
            AddContextMenu(NodeType.Folder, "Neue Datenbank", "toolStripMenuItemNewDB");
            AddContextMenu(NodeType.DB, "Neue Abfrage", "toolStripMenuItemNewQuery");
            AddContextMenu(NodeType.DB, "Größe der Tabellen", "toolStripMenuItemTabGroes");
            AddContextMenu(NodeType.DB, "Drop Datenbank", "toolStripMenuItemDropDB");
            AddContextMenu(NodeType.DB, "Backup Datenbank", "toolStripMenuItemBackupDB");
            AddContextMenu(NodeType.DB, "Wiederherstellung Datenbank", "toolStripMenuItemRestoreDB");
            AddContextMenu(NodeType.Table, "Erste 1000 Zeilen auswählen", "toolStripMenuItemSelect");
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if ((sender as ToolStripMenuItem).Name == "toolStripMenuItemNewQuery")
            {
                this.CallNeueAbfrage_Click();
            }
            else if ((sender as ToolStripMenuItem).Name == "toolStripMenuItemSelect")
            {
                this.CallSelectTop1000(treeViewStruct.SelectedNode.Text);
            }
            else if ((sender as ToolStripMenuItem).Name == "toolStripMenuItemNewDB")
            {
                CreateNewDB();
            }
            else if ((sender as ToolStripMenuItem).Name == "toolStripMenuItemDropDB")
            {
                DropDB(treeViewStruct.SelectedNode.Text);
            }
            else if ((sender as ToolStripMenuItem).Name == "toolStripMenuItemBackupDB")
            {
                backupRestoreDB(true);
            }
            else if ((sender as ToolStripMenuItem).Name == "toolStripMenuItemRestoreDB")
            {
                backupRestoreDB(false);
            }
            else if ((sender as ToolStripMenuItem).Name == "toolStripMenuItemTabGroes")
            {
                this.CallSelectTabGroes(treeViewStruct.SelectedNode.Text);
            }
        }

        private void CreateNewDB()
        {
            FormNewDB formNewDB = new FormNewDB();
            formNewDB.ObjectExplorerRefresh = new FormNewDB.OnNewDBErfolg(this.ObjectExplorerActualisieren);
            formNewDB.ShowDialog();     
        }

        private void DropDB(string db)
        {
            if (MessageBox.Show("Achtung!\nDatenbank ["+db+ "] wird unwiederherstellbar!\nSind Sie sicher?", "Drop Datenbank",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                string mess;
                if (!DbAccess.DropDB(db, out mess)) MessageBox.Show(mess, "Drop Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Datenbank [" + db + "] ist erfolgreich gelöscht", "Drop Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ObjectExplorerActualisieren();
                }
            }
        }

        private void backupRestoreDB(bool isBackup)
        {
            FormBackupRestoreDB formBackupRestoreDB = new FormBackupRestoreDB(isBackup, treeViewStruct.SelectedNode.Text);
            formBackupRestoreDB.ObjectExplorerRefresh = new FormBackupRestoreDB.OnBackupRestoreDBErfolg(this.ObjectExplorerActualisieren);
            formBackupRestoreDB.ShowDialog();
        }

        private void tabGroes()
        {
            //FormTabGroes formTabGroes = new FormTabGroes(treeViewStruct.SelectedNode.Text);

        }

        private void addServerGroup(TreeNode treeNode)
        {
            NodeCondition nc = new NodeCondition(NodeType.Folder, false);
            TreeNode tnDB = new TreeNode("Datenbanken", 1, 1);
            treeNode.Nodes.Add(tnDB);
            
            tnDB.Tag = nc;
            TreeNode tnSysDB = new TreeNode("Systemdatenbanken", 1, 1);
            tnDB.Nodes.Add(tnSysDB);
            tnSysDB.Tag = nc;
            addDB(tnSysDB, true);
            addDB(tnDB, false);
            tnDB.Expand();

        }
        private void addDB(TreeNode treeNode, bool isSystemDB)
        {
            DataTable dtDBName = DbAccess.GetDBNamen(isSystemDB);
            NodeCondition nc = new NodeCondition(NodeType.DB, true);
            foreach (DataRow row in dtDBName.Rows)
            {
                TreeNode tnDB = new TreeNode(row[0].ToString(), 2, 2);
                treeNode.Nodes.Add(tnDB);
                tnDB.Tag = nc;
                tnDB.Nodes.Add("<empty>");
                
            }
            
        }

        private void addTable(TreeNode treeNode)
        {
            NodeCondition nc = ((NodeCondition)treeNode.Tag);
            if (nc.isEmpty)
            {
                treeNode.Nodes.Clear();
                nc.isEmpty = false;   
            }
            else return;

            NodeCondition ncNew = new NodeCondition(NodeType.Table, true);
            DataTable dtTable = DbAccess.GetTables(treeNode.Text);
            foreach (DataRow row in dtTable.Rows)
            {
                TreeNode tnTable = new TreeNode(row[0].ToString(), 3, 3);
                treeNode.Nodes.Add(tnTable);
                tnTable.Tag = ncNew;
                tnTable.Nodes.Add("<empty>");
            }    
        }
        private string ColumnNameFormat(DataRow row)
        {
            StringBuilder sb = new StringBuilder();

            sb.Clear();
            sb.Append(row["ColumnName"].ToString() + " (");
            if ((bool)row["PrimaryKey"]) sb.Append("PS, ");
            string s = row["DataType"].ToString();
            sb.Append(s);

            if (s.IndexOf("char") >= 0)
            {
                sb.Append("(");
                if (row["MaxLength"].ToString() == "0") sb.Append("max");
                else sb.Append(row["MaxLength"].ToString());
                sb.Append(")");
            }

            if ((bool)row["is_nullable"]) sb.Append(", NULL)");
            else sb.Append(", Nicht NULL)");

            return sb.ToString();
        }
        private void addField(TreeNode treeNode)
        {
            NodeCondition nc = ((NodeCondition)treeNode.Tag);
            if (nc.isEmpty)
            {
                treeNode.Nodes.Clear();
                nc.isEmpty = false;
            }
            else return;
            string db = "";
            nc = ((NodeCondition)treeNode.Parent.Tag);
            if (nc.type == NodeType.DB) db = treeNode.Parent.Text;
            NodeCondition ncNew = new NodeCondition(NodeType.Field, true);
            DataTable dtTable = DbAccess.GetFields(db, treeNode.Text);
            foreach (DataRow row in dtTable.Rows)
            {
                int i = (bool)row["PrimaryKey"] ? 6 : 7;
                TreeNode tnTable = new TreeNode(ColumnNameFormat(row), i, i);
                treeNode.Nodes.Add(tnTable);
                tnTable.Tag = ncNew;
            }
        }


        private string GetCurrentDBName(TreeNode e)
        {
            NodeCondition nc = ((NodeCondition)e.Tag);
            switch (nc.type)
            {
                case NodeType.Server:
                case NodeType.Folder:
                    return "master";
                case NodeType.DB:
                    return e.Text;
                default: return currentDBName; 
            }
        }

        #endregion

        public string CurrentDBName {get {return currentDBName;}}

        private void treeViewStruct_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            NodeCondition nc = ((NodeCondition)e.Node.Tag);

            switch (nc.type)
            {
                case NodeType.DB:
                    addTable(e.Node);
                    break;
                case NodeType.Table:
                    addField(e.Node);
                    break;
            }
            currentDBName = GetCurrentDBName(e.Node);
        }

        private void treeViewStruct_AfterSelect(object sender, TreeViewEventArgs e)
        {
            currentDBName = GetCurrentDBName(e.Node);
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            foreach (ToolStripMenuItem item in contextMenuStrip.Items)
            {
                item.Visible = Equals(item.Tag, ((NodeCondition)treeViewStruct.SelectedNode.Tag).type);
            }
        }

        private void treeViewStruct_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeViewStruct.SelectedNode = e.Node;
        }

        private void toolStripButtonAktualisieren_Click(object sender, EventArgs e)
        {
            ObjectExplorerActualisieren();
        }

        private void toolStripButtonVerbinden_Click(object sender, EventArgs e)
        {
            CallVerbinden_Click();
            ObjectExplorerActualisieren();
        }

        private void toolStripButtonTrennen_Click(object sender, EventArgs e)
        {
            ObjectExplorerTrennen();
        }
    }
}

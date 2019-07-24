namespace MS_SQL_Management_light
{
    partial class UserControlTree
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTree));
            this.panelTree = new System.Windows.Forms.Panel();
            this.treeViewStruct = new System.Windows.Forms.TreeView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageListTree = new System.Windows.Forms.ImageList(this.components);
            this.toolStripOE = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonVerbinden = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTrennen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAktualisieren = new System.Windows.Forms.ToolStripButton();
            this.wwwwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTree.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.toolStripOE.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTree
            // 
            this.panelTree.Controls.Add(this.treeViewStruct);
            this.panelTree.Controls.Add(this.toolStripOE);
            this.panelTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTree.Location = new System.Drawing.Point(0, 0);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(334, 567);
            this.panelTree.TabIndex = 2;
            // 
            // treeViewStruct
            // 
            this.treeViewStruct.ContextMenuStrip = this.contextMenuStrip;
            this.treeViewStruct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewStruct.ImageIndex = 0;
            this.treeViewStruct.ImageList = this.imageListTree;
            this.treeViewStruct.Location = new System.Drawing.Point(0, 25);
            this.treeViewStruct.Name = "treeViewStruct";
            this.treeViewStruct.SelectedImageIndex = 0;
            this.treeViewStruct.Size = new System.Drawing.Size(334, 542);
            this.treeViewStruct.TabIndex = 0;
            this.treeViewStruct.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewStruct_BeforeExpand);
            this.treeViewStruct.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewStruct_AfterSelect);
            this.treeViewStruct.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewStruct_NodeMouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wwwwToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(111, 26);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // imageListTree
            // 
            this.imageListTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTree.ImageStream")));
            this.imageListTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTree.Images.SetKeyName(0, "Srv.png");
            this.imageListTree.Images.SetKeyName(1, "Folder.png");
            this.imageListTree.Images.SetKeyName(2, "DB.png");
            this.imageListTree.Images.SetKeyName(3, "Tab.png");
            this.imageListTree.Images.SetKeyName(4, "user.png");
            this.imageListTree.Images.SetKeyName(5, "userRole.png");
            this.imageListTree.Images.SetKeyName(6, "FieldKey.png");
            this.imageListTree.Images.SetKeyName(7, "FieldNorm.png");
            // 
            // toolStripOE
            // 
            this.toolStripOE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonVerbinden,
            this.toolStripButtonTrennen,
            this.toolStripSeparator1,
            this.toolStripButtonAktualisieren});
            this.toolStripOE.Location = new System.Drawing.Point(0, 0);
            this.toolStripOE.Name = "toolStripOE";
            this.toolStripOE.Size = new System.Drawing.Size(334, 25);
            this.toolStripOE.TabIndex = 1;
            this.toolStripOE.Text = "toolStrip1";
            // 
            // toolStripButtonVerbinden
            // 
            this.toolStripButtonVerbinden.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonVerbinden.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonVerbinden.Image")));
            this.toolStripButtonVerbinden.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonVerbinden.Name = "toolStripButtonVerbinden";
            this.toolStripButtonVerbinden.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonVerbinden.Text = "Object-Explorer verbinden";
            this.toolStripButtonVerbinden.Click += new System.EventHandler(this.toolStripButtonVerbinden_Click);
            // 
            // toolStripButtonTrennen
            // 
            this.toolStripButtonTrennen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTrennen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTrennen.Image")));
            this.toolStripButtonTrennen.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonTrennen.Name = "toolStripButtonTrennen";
            this.toolStripButtonTrennen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonTrennen.Text = "Trennen";
            this.toolStripButtonTrennen.Click += new System.EventHandler(this.toolStripButtonTrennen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAktualisieren
            // 
            this.toolStripButtonAktualisieren.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAktualisieren.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAktualisieren.Image")));
            this.toolStripButtonAktualisieren.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonAktualisieren.Name = "toolStripButtonAktualisieren";
            this.toolStripButtonAktualisieren.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAktualisieren.Text = "Aktualisieren";
            this.toolStripButtonAktualisieren.ToolTipText = "Aktualisieren (F5)";
            this.toolStripButtonAktualisieren.Click += new System.EventHandler(this.toolStripButtonAktualisieren_Click);
            // 
            // wwwwToolStripMenuItem
            // 
            this.wwwwToolStripMenuItem.Name = "wwwwToolStripMenuItem";
            this.wwwwToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.wwwwToolStripMenuItem.Text = "wwww";
            // 
            // UserControlTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTree);
            this.Name = "UserControlTree";
            this.Size = new System.Drawing.Size(334, 567);
            this.panelTree.ResumeLayout(false);
            this.panelTree.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.toolStripOE.ResumeLayout(false);
            this.toolStripOE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTree;
        private System.Windows.Forms.TreeView treeViewStruct;
        private System.Windows.Forms.ImageList imageListTree;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStrip toolStripOE;
        private System.Windows.Forms.ToolStripButton toolStripButtonVerbinden;
        private System.Windows.Forms.ToolStripButton toolStripButtonTrennen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAktualisieren;
        private System.Windows.Forms.ToolStripMenuItem wwwwToolStripMenuItem;
    }
}

namespace MS_SQL_Management_light
{
    partial class FormMain
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBverbindenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBTrennenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDataiOffnen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSpeichern = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAllesSpeichern = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonNeueAbfrage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonVerbinden = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonVerbindungAndern = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxDB = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAusfuhren = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.ansichtToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBverbindenToolStripMenuItem,
            this.dBTrennenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "&Datei";
            // 
            // dBverbindenToolStripMenuItem
            // 
            this.dBverbindenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dBverbindenToolStripMenuItem.Image")));
            this.dBverbindenToolStripMenuItem.Name = "dBverbindenToolStripMenuItem";
            this.dBverbindenToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.dBverbindenToolStripMenuItem.Text = "Object-Explorer &verbinden";
            this.dBverbindenToolStripMenuItem.Click += new System.EventHandler(this.dBverbindenToolStripMenuItem_Click);
            // 
            // dBTrennenToolStripMenuItem
            // 
            this.dBTrennenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dBTrennenToolStripMenuItem.Image")));
            this.dBTrennenToolStripMenuItem.Name = "dBTrennenToolStripMenuItem";
            this.dBTrennenToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.dBTrennenToolStripMenuItem.Text = "Object-Explorer &trennen";
            this.dBTrennenToolStripMenuItem.Click += new System.EventHandler(this.dBTrennenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(209, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("beendenToolStripMenuItem.Image")));
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.beendenToolStripMenuItem.Text = "&Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectExplorerToolStripMenuItem});
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // objectExplorerToolStripMenuItem
            // 
            this.objectExplorerToolStripMenuItem.CheckOnClick = true;
            this.objectExplorerToolStripMenuItem.Name = "objectExplorerToolStripMenuItem";
            this.objectExplorerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.objectExplorerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.objectExplorerToolStripMenuItem.Text = "Object-Explorer";
            this.objectExplorerToolStripMenuItem.Click += new System.EventHandler(this.objectExplorerToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "&Hilfe";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 49);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tabControlMain);
            this.splitContainerMain.Size = new System.Drawing.Size(800, 401);
            this.splitContainerMain.SplitterDistance = 136;
            this.splitContainerMain.TabIndex = 1;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlMain.ImageList = this.imageListMain;
            this.tabControlMain.ItemSize = new System.Drawing.Size(70, 19);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(660, 401);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.Visible = false;
            this.tabControlMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlMain_DrawItem);
            this.tabControlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControlMain_MouseDown);
            // 
            // imageListMain
            // 
            this.imageListMain.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListMain.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDataiOffnen,
            this.toolStripButtonSpeichern,
            this.toolStripButtonAllesSpeichern,
            this.toolStripSeparator4,
            this.toolStripButtonNeueAbfrage,
            this.toolStripSeparator3,
            this.toolStripButtonVerbinden,
            this.toolStripButtonVerbindungAndern,
            this.toolStripSeparator1,
            this.toolStripComboBoxDB,
            this.toolStripSeparator2,
            this.toolStripButtonAusfuhren});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(800, 25);
            this.toolStripMain.TabIndex = 2;
            // 
            // toolStripButtonDataiOffnen
            // 
            this.toolStripButtonDataiOffnen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDataiOffnen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDataiOffnen.Image")));
            this.toolStripButtonDataiOffnen.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonDataiOffnen.Name = "toolStripButtonDataiOffnen";
            this.toolStripButtonDataiOffnen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDataiOffnen.Text = "DataiOffnen";
            this.toolStripButtonDataiOffnen.ToolTipText = "Datai öffnen (Strg+O)";
            this.toolStripButtonDataiOffnen.Click += new System.EventHandler(this.toolStripButtonDataiOffnen_Click);
            // 
            // toolStripButtonSpeichern
            // 
            this.toolStripButtonSpeichern.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSpeichern.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSpeichern.Image")));
            this.toolStripButtonSpeichern.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonSpeichern.Name = "toolStripButtonSpeichern";
            this.toolStripButtonSpeichern.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSpeichern.Text = "Speichern";
            this.toolStripButtonSpeichern.ToolTipText = "speichern (Strg+S)";
            this.toolStripButtonSpeichern.Click += new System.EventHandler(this.toolStripButtonSpeichern_Click);
            // 
            // toolStripButtonAllesSpeichern
            // 
            this.toolStripButtonAllesSpeichern.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAllesSpeichern.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAllesSpeichern.Image")));
            this.toolStripButtonAllesSpeichern.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonAllesSpeichern.Name = "toolStripButtonAllesSpeichern";
            this.toolStripButtonAllesSpeichern.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAllesSpeichern.Text = "Alles speichern";
            this.toolStripButtonAllesSpeichern.ToolTipText = "Alles speichern (Strg+Umschalt+S)";
            this.toolStripButtonAllesSpeichern.Click += new System.EventHandler(this.toolStripButtonAllesSpeichern_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonNeueAbfrage
            // 
            this.toolStripButtonNeueAbfrage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNeueAbfrage.Image")));
            this.toolStripButtonNeueAbfrage.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonNeueAbfrage.Name = "toolStripButtonNeueAbfrage";
            this.toolStripButtonNeueAbfrage.Size = new System.Drawing.Size(100, 22);
            this.toolStripButtonNeueAbfrage.Text = "Neue Abfrage";
            this.toolStripButtonNeueAbfrage.ToolTipText = "Neue Abfrage (Strg+N)";
            this.toolStripButtonNeueAbfrage.Click += new System.EventHandler(this.toolStripButtonNeueAbfrage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonVerbinden
            // 
            this.toolStripButtonVerbinden.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonVerbinden.Enabled = false;
            this.toolStripButtonVerbinden.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonVerbinden.Image")));
            this.toolStripButtonVerbinden.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonVerbinden.Name = "toolStripButtonVerbinden";
            this.toolStripButtonVerbinden.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonVerbinden.Text = "toolStripButtonVerbinden";
            this.toolStripButtonVerbinden.ToolTipText = "Verbinden";
            // 
            // toolStripButtonVerbindungAndern
            // 
            this.toolStripButtonVerbindungAndern.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonVerbindungAndern.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonVerbindungAndern.Image")));
            this.toolStripButtonVerbindungAndern.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonVerbindungAndern.Name = "toolStripButtonVerbindungAndern";
            this.toolStripButtonVerbindungAndern.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonVerbindungAndern.Text = "Verbindung ändern";
            this.toolStripButtonVerbindungAndern.Click += new System.EventHandler(this.toolStripButtonVerbindungAndern_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBoxDB
            // 
            this.toolStripComboBoxDB.Name = "toolStripComboBoxDB";
            this.toolStripComboBoxDB.Size = new System.Drawing.Size(150, 25);
            this.toolStripComboBoxDB.Sorted = true;
            this.toolStripComboBoxDB.ToolTipText = "Verfügbare Datenbanken";
            this.toolStripComboBoxDB.TextChanged += new System.EventHandler(this.toolStripComboBoxDB_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAusfuhren
            // 
            this.toolStripButtonAusfuhren.Enabled = false;
            this.toolStripButtonAusfuhren.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAusfuhren.Image")));
            this.toolStripButtonAusfuhren.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonAusfuhren.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonAusfuhren.Name = "toolStripButtonAusfuhren";
            this.toolStripButtonAusfuhren.Size = new System.Drawing.Size(82, 22);
            this.toolStripButtonAusfuhren.Text = "Ausführen";
            this.toolStripButtonAusfuhren.ToolTipText = "Ausführen (F5)";
            this.toolStripButtonAusfuhren.Click += new System.EventHandler(this.toolStripButtonAusfuhren_Click);
            this.toolStripButtonAusfuhren.EnabledChanged += new System.EventHandler(this.toolStripButtonAusfuhren_EnabledChanged);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Info...";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MS SQL Management light";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBverbindenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBTrennenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ansichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectExplorerToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonVerbinden;
        private System.Windows.Forms.ImageList imageListMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonVerbindungAndern;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxDB;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonDataiOffnen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSpeichern;
        private System.Windows.Forms.ToolStripButton toolStripButtonAllesSpeichern;
        private System.Windows.Forms.ToolStripButton toolStripButtonNeueAbfrage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAusfuhren;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}


namespace MS_SQL_Management_light
{
    partial class UserControlEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlEditor));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.richTextBoxMain = new System.Windows.Forms.RichTextBox();
            this.toolStripRichTextBox = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxSkalierung = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripErgebnis = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelImage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelRecords = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelZeit = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelDB = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelMessage = new System.Windows.Forms.ToolStripLabel();
            this.imageListErgebnis = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.toolStripRichTextBox.SuspendLayout();
            this.toolStripErgebnis.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.richTextBoxMain);
            this.splitContainerMain.Panel1.Controls.Add(this.toolStripRichTextBox);
            this.splitContainerMain.Size = new System.Drawing.Size(697, 588);
            this.splitContainerMain.SplitterDistance = 391;
            this.splitContainerMain.TabIndex = 0;
            // 
            // richTextBoxMain
            // 
            this.richTextBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMain.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxMain.Name = "richTextBoxMain";
            this.richTextBoxMain.Size = new System.Drawing.Size(697, 366);
            this.richTextBoxMain.TabIndex = 3;
            this.richTextBoxMain.Text = "";
            this.richTextBoxMain.TextChanged += new System.EventHandler(this.richTextBoxMain_TextChanged);
            // 
            // toolStripRichTextBox
            // 
            this.toolStripRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripRichTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxSkalierung});
            this.toolStripRichTextBox.Location = new System.Drawing.Point(0, 366);
            this.toolStripRichTextBox.Name = "toolStripRichTextBox";
            this.toolStripRichTextBox.Size = new System.Drawing.Size(697, 25);
            this.toolStripRichTextBox.TabIndex = 2;
            this.toolStripRichTextBox.Text = "toolStrip1";
            // 
            // toolStripComboBoxSkalierung
            // 
            this.toolStripComboBoxSkalierung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxSkalierung.Items.AddRange(new object[] {
            "20%",
            "50%",
            "70%",
            "100%",
            "150%",
            "200%",
            "400%"});
            this.toolStripComboBoxSkalierung.Name = "toolStripComboBoxSkalierung";
            this.toolStripComboBoxSkalierung.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBoxSkalierung.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxSkalierung_SelectedIndexChanged);
            // 
            // toolStripErgebnis
            // 
            this.toolStripErgebnis.BackColor = System.Drawing.SystemColors.Info;
            this.toolStripErgebnis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripErgebnis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelImage,
            this.toolStripLabelRecords,
            this.toolStripSeparator1,
            this.toolStripLabelZeit,
            this.toolStripSeparator2,
            this.toolStripLabelDB,
            this.toolStripSeparator3,
            this.toolStripLabelMessage});
            this.toolStripErgebnis.Location = new System.Drawing.Point(0, 563);
            this.toolStripErgebnis.Name = "toolStripErgebnis";
            this.toolStripErgebnis.Size = new System.Drawing.Size(697, 25);
            this.toolStripErgebnis.TabIndex = 4;
            this.toolStripErgebnis.Text = "toolStrip2";
            // 
            // toolStripLabelImage
            // 
            this.toolStripLabelImage.Image = global::MS_SQL_Management_light.Properties.Resources.Connected;
            this.toolStripLabelImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabelImage.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripLabelImage.Name = "toolStripLabelImage";
            this.toolStripLabelImage.Size = new System.Drawing.Size(16, 22);
            // 
            // toolStripLabelRecords
            // 
            this.toolStripLabelRecords.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelRecords.Name = "toolStripLabelRecords";
            this.toolStripLabelRecords.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabelRecords.Text = "0 Zeilen";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelZeit
            // 
            this.toolStripLabelZeit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelZeit.Name = "toolStripLabelZeit";
            this.toolStripLabelZeit.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabelZeit.Text = "00:00:00";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelDB
            // 
            this.toolStripLabelDB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelDB.Name = "toolStripLabelDB";
            this.toolStripLabelDB.Size = new System.Drawing.Size(22, 22);
            this.toolStripLabelDB.Text = "DB";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelMessage
            // 
            this.toolStripLabelMessage.Name = "toolStripLabelMessage";
            this.toolStripLabelMessage.Size = new System.Drawing.Size(64, 22);
            this.toolStripLabelMessage.Text = "Verbunden";
            // 
            // imageListErgebnis
            // 
            this.imageListErgebnis.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListErgebnis.ImageStream")));
            this.imageListErgebnis.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListErgebnis.Images.SetKeyName(0, "Connected.png");
            this.imageListErgebnis.Images.SetKeyName(1, "Fehler.png");
            this.imageListErgebnis.Images.SetKeyName(2, "OK.png");
            // 
            // UserControlEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripErgebnis);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "UserControlEditor";
            this.Size = new System.Drawing.Size(697, 588);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.toolStripRichTextBox.ResumeLayout(false);
            this.toolStripRichTextBox.PerformLayout();
            this.toolStripErgebnis.ResumeLayout(false);
            this.toolStripErgebnis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ToolStrip toolStripRichTextBox;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSkalierung;
        private System.Windows.Forms.RichTextBox richTextBoxMain;
        private System.Windows.Forms.ToolStrip toolStripErgebnis;
        private System.Windows.Forms.ToolStripLabel toolStripLabelImage;
        private System.Windows.Forms.ToolStripLabel toolStripLabelRecords;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelZeit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelDB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabelMessage;
        private System.Windows.Forms.ImageList imageListErgebnis;
    }
}

namespace MS_SQL_Management_light
{
    partial class FormConnectionSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelServername = new System.Windows.Forms.Label();
            this.labelAuthentifizierung = new System.Windows.Forms.Label();
            this.labelBenutzername = new System.Windows.Forms.Label();
            this.labelKennwort = new System.Windows.Forms.Label();
            this.comboBoxServername = new System.Windows.Forms.ComboBox();
            this.comboBoxAuthentifizierung = new System.Windows.Forms.ComboBox();
            this.comboBoxBenutzername = new System.Windows.Forms.ComboBox();
            this.textBoxKennwort = new System.Windows.Forms.TextBox();
            this.checkBoxKennwortSpeichern = new System.Windows.Forms.CheckBox();
            this.buttonVerbinden = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonVerbindungTesten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(426, 80);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "SQL Server";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelServername
            // 
            this.labelServername.AutoSize = true;
            this.labelServername.Location = new System.Drawing.Point(41, 96);
            this.labelServername.Name = "labelServername";
            this.labelServername.Size = new System.Drawing.Size(67, 13);
            this.labelServername.TabIndex = 1;
            this.labelServername.Text = "Serverna&me:";
            // 
            // labelAuthentifizierung
            // 
            this.labelAuthentifizierung.AutoSize = true;
            this.labelAuthentifizierung.Location = new System.Drawing.Point(20, 122);
            this.labelAuthentifizierung.Name = "labelAuthentifizierung";
            this.labelAuthentifizierung.Size = new System.Drawing.Size(88, 13);
            this.labelAuthentifizierung.TabIndex = 2;
            this.labelAuthentifizierung.Text = "A&uthentifizierung:";
            // 
            // labelBenutzername
            // 
            this.labelBenutzername.AutoSize = true;
            this.labelBenutzername.Location = new System.Drawing.Point(30, 154);
            this.labelBenutzername.Name = "labelBenutzername";
            this.labelBenutzername.Size = new System.Drawing.Size(78, 13);
            this.labelBenutzername.TabIndex = 3;
            this.labelBenutzername.Text = "&Benutzername:";
            // 
            // labelKennwort
            // 
            this.labelKennwort.AutoSize = true;
            this.labelKennwort.Location = new System.Drawing.Point(53, 180);
            this.labelKennwort.Name = "labelKennwort";
            this.labelKennwort.Size = new System.Drawing.Size(55, 13);
            this.labelKennwort.TabIndex = 4;
            this.labelKennwort.Text = "&Kennwort:";
            // 
            // comboBoxServername
            // 
            this.comboBoxServername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxServername.FormattingEnabled = true;
            this.comboBoxServername.Location = new System.Drawing.Point(134, 93);
            this.comboBoxServername.Name = "comboBoxServername";
            this.comboBoxServername.Size = new System.Drawing.Size(280, 21);
            this.comboBoxServername.TabIndex = 5;
            // 
            // comboBoxAuthentifizierung
            // 
            this.comboBoxAuthentifizierung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAuthentifizierung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthentifizierung.FormattingEnabled = true;
            this.comboBoxAuthentifizierung.Items.AddRange(new object[] {
            "Windows-Authentifizierung",
            "SQL Server-Authentifizierung"});
            this.comboBoxAuthentifizierung.Location = new System.Drawing.Point(134, 119);
            this.comboBoxAuthentifizierung.Name = "comboBoxAuthentifizierung";
            this.comboBoxAuthentifizierung.Size = new System.Drawing.Size(280, 21);
            this.comboBoxAuthentifizierung.TabIndex = 6;
            this.comboBoxAuthentifizierung.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthentifizierung_SelectedIndexChanged);
            // 
            // comboBoxBenutzername
            // 
            this.comboBoxBenutzername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBenutzername.FormattingEnabled = true;
            this.comboBoxBenutzername.Location = new System.Drawing.Point(149, 151);
            this.comboBoxBenutzername.Name = "comboBoxBenutzername";
            this.comboBoxBenutzername.Size = new System.Drawing.Size(265, 21);
            this.comboBoxBenutzername.TabIndex = 7;
            // 
            // textBoxKennwort
            // 
            this.textBoxKennwort.Location = new System.Drawing.Point(149, 177);
            this.textBoxKennwort.Name = "textBoxKennwort";
            this.textBoxKennwort.PasswordChar = '*';
            this.textBoxKennwort.Size = new System.Drawing.Size(265, 20);
            this.textBoxKennwort.TabIndex = 8;
            // 
            // checkBoxKennwortSpeichern
            // 
            this.checkBoxKennwortSpeichern.AutoSize = true;
            this.checkBoxKennwortSpeichern.Location = new System.Drawing.Point(149, 204);
            this.checkBoxKennwortSpeichern.Name = "checkBoxKennwortSpeichern";
            this.checkBoxKennwortSpeichern.Size = new System.Drawing.Size(120, 17);
            this.checkBoxKennwortSpeichern.TabIndex = 9;
            this.checkBoxKennwortSpeichern.Text = "Ke&nnwort speichern";
            this.checkBoxKennwortSpeichern.UseVisualStyleBackColor = true;
            // 
            // buttonVerbinden
            // 
            this.buttonVerbinden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVerbinden.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonVerbinden.Location = new System.Drawing.Point(258, 251);
            this.buttonVerbinden.Name = "buttonVerbinden";
            this.buttonVerbinden.Size = new System.Drawing.Size(75, 23);
            this.buttonVerbinden.TabIndex = 10;
            this.buttonVerbinden.Text = "&Verbinden";
            this.buttonVerbinden.UseVisualStyleBackColor = true;
            this.buttonVerbinden.Click += new System.EventHandler(this.buttonVerbinden_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAbbrechen.Location = new System.Drawing.Point(339, 251);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechen.TabIndex = 11;
            this.buttonAbbrechen.Text = "&Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::MS_SQL_Management_light.Properties.Resources.ConnectionFormStrip;
            this.pictureBox1.Location = new System.Drawing.Point(0, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 4);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // buttonVerbindungTesten
            // 
            this.buttonVerbindungTesten.Location = new System.Drawing.Point(23, 250);
            this.buttonVerbindungTesten.Name = "buttonVerbindungTesten";
            this.buttonVerbindungTesten.Size = new System.Drawing.Size(103, 23);
            this.buttonVerbindungTesten.TabIndex = 13;
            this.buttonVerbindungTesten.Text = "Verbindung &testen";
            this.buttonVerbindungTesten.UseVisualStyleBackColor = true;
            this.buttonVerbindungTesten.Click += new System.EventHandler(this.buttonbuttonVerbindungTesten_Click);
            // 
            // FormConnectionSettings
            // 
            this.AcceptButton = this.buttonVerbinden;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 286);
            this.Controls.Add(this.buttonVerbindungTesten);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonVerbinden);
            this.Controls.Add(this.checkBoxKennwortSpeichern);
            this.Controls.Add(this.textBoxKennwort);
            this.Controls.Add(this.comboBoxBenutzername);
            this.Controls.Add(this.comboBoxAuthentifizierung);
            this.Controls.Add(this.comboBoxServername);
            this.Controls.Add(this.labelKennwort);
            this.Controls.Add(this.labelBenutzername);
            this.Controls.Add(this.labelAuthentifizierung);
            this.Controls.Add(this.labelServername);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormConnectionSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verbindung mit Server herstellen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelServername;
        private System.Windows.Forms.Label labelAuthentifizierung;
        private System.Windows.Forms.Label labelBenutzername;
        private System.Windows.Forms.Label labelKennwort;
        private System.Windows.Forms.ComboBox comboBoxServername;
        private System.Windows.Forms.ComboBox comboBoxAuthentifizierung;
        private System.Windows.Forms.ComboBox comboBoxBenutzername;
        private System.Windows.Forms.TextBox textBoxKennwort;
        private System.Windows.Forms.CheckBox checkBoxKennwortSpeichern;
        private System.Windows.Forms.Button buttonVerbinden;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonVerbindungTesten;
    }
}
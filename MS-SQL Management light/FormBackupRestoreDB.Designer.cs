namespace MS_SQL_Management_light
{
    partial class FormBackupRestoreDB
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
            this.comboBoxDatenbankname = new System.Windows.Forms.ComboBox();
            this.labelDatenbankname = new System.Windows.Forms.Label();
            this.textBoxBackupdatai = new System.Windows.Forms.TextBox();
            this.labelBackupdatai = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.buttonBackupdatai = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // comboBoxDatenbankname
            // 
            this.comboBoxDatenbankname.FormattingEnabled = true;
            this.comboBoxDatenbankname.Location = new System.Drawing.Point(108, 22);
            this.comboBoxDatenbankname.Name = "comboBoxDatenbankname";
            this.comboBoxDatenbankname.Size = new System.Drawing.Size(324, 21);
            this.comboBoxDatenbankname.TabIndex = 0;
            // 
            // labelDatenbankname
            // 
            this.labelDatenbankname.AutoSize = true;
            this.labelDatenbankname.Location = new System.Drawing.Point(13, 25);
            this.labelDatenbankname.Name = "labelDatenbankname";
            this.labelDatenbankname.Size = new System.Drawing.Size(89, 13);
            this.labelDatenbankname.TabIndex = 1;
            this.labelDatenbankname.Text = "Datenbank&name:";
            // 
            // textBoxBackupdatai
            // 
            this.textBoxBackupdatai.Location = new System.Drawing.Point(108, 55);
            this.textBoxBackupdatai.Name = "textBoxBackupdatai";
            this.textBoxBackupdatai.Size = new System.Drawing.Size(324, 20);
            this.textBoxBackupdatai.TabIndex = 2;
            // 
            // labelBackupdatai
            // 
            this.labelBackupdatai.AutoSize = true;
            this.labelBackupdatai.Location = new System.Drawing.Point(32, 58);
            this.labelBackupdatai.Name = "labelBackupdatai";
            this.labelBackupdatai.Size = new System.Drawing.Size(70, 13);
            this.labelBackupdatai.TabIndex = 3;
            this.labelBackupdatai.Text = "&Backupdatai:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(306, 94);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(387, 94);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechen.TabIndex = 5;
            this.buttonAbbrechen.Text = "&Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // buttonBackupdatai
            // 
            this.buttonBackupdatai.Location = new System.Drawing.Point(438, 53);
            this.buttonBackupdatai.Name = "buttonBackupdatai";
            this.buttonBackupdatai.Size = new System.Drawing.Size(24, 22);
            this.buttonBackupdatai.TabIndex = 6;
            this.buttonBackupdatai.Text = "...";
            this.buttonBackupdatai.UseVisualStyleBackColor = true;
            this.buttonBackupdatai.Click += new System.EventHandler(this.buttonBackupdatai_Click);
            // 
            // FormBackupRestoreDB
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 137);
            this.Controls.Add(this.buttonBackupdatai);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelBackupdatai);
            this.Controls.Add(this.textBoxBackupdatai);
            this.Controls.Add(this.labelDatenbankname);
            this.Controls.Add(this.comboBoxDatenbankname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBackupRestoreDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormBackupRestoreDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDatenbankname;
        private System.Windows.Forms.Label labelDatenbankname;
        private System.Windows.Forms.TextBox textBoxBackupdatai;
        private System.Windows.Forms.Label labelBackupdatai;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Button buttonBackupdatai;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
namespace MS_SQL_Management_light
{
    partial class FormNewDB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewDB));
            this.labelDBName = new System.Windows.Forms.Label();
            this.groupBoxDBFiles = new System.Windows.Forms.GroupBox();
            this.checkBoxSamePath = new System.Windows.Forms.CheckBox();
            this.buttonLogPath = new System.Windows.Forms.Button();
            this.buttonDataPath = new System.Windows.Forms.Button();
            this.labelLog = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxLogFile = new System.Windows.Forms.TextBox();
            this.textBoxDataFile = new System.Windows.Forms.TextBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAbbrechnen = new System.Windows.Forms.Button();
            this.textBoxDBname = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxDBFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDBName
            // 
            this.labelDBName.AutoSize = true;
            this.labelDBName.Location = new System.Drawing.Point(13, 13);
            this.labelDBName.Name = "labelDBName";
            this.labelDBName.Size = new System.Drawing.Size(89, 13);
            this.labelDBName.TabIndex = 0;
            this.labelDBName.Text = "Datenbank&name:";
            // 
            // groupBoxDBFiles
            // 
            this.groupBoxDBFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDBFiles.Controls.Add(this.checkBoxSamePath);
            this.groupBoxDBFiles.Controls.Add(this.buttonLogPath);
            this.groupBoxDBFiles.Controls.Add(this.buttonDataPath);
            this.groupBoxDBFiles.Controls.Add(this.labelLog);
            this.groupBoxDBFiles.Controls.Add(this.labelData);
            this.groupBoxDBFiles.Controls.Add(this.textBoxLogFile);
            this.groupBoxDBFiles.Controls.Add(this.textBoxDataFile);
            this.groupBoxDBFiles.Location = new System.Drawing.Point(16, 50);
            this.groupBoxDBFiles.Name = "groupBoxDBFiles";
            this.groupBoxDBFiles.Size = new System.Drawing.Size(380, 103);
            this.groupBoxDBFiles.TabIndex = 1;
            this.groupBoxDBFiles.TabStop = false;
            this.groupBoxDBFiles.Text = "Datenbankdataien";
            // 
            // checkBoxSamePath
            // 
            this.checkBoxSamePath.AutoSize = true;
            this.checkBoxSamePath.Checked = true;
            this.checkBoxSamePath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSamePath.Location = new System.Drawing.Point(51, 78);
            this.checkBoxSamePath.Name = "checkBoxSamePath";
            this.checkBoxSamePath.Size = new System.Drawing.Size(182, 17);
            this.checkBoxSamePath.TabIndex = 6;
            this.checkBoxSamePath.Text = "Data und Log im gleichen Ordner";
            this.checkBoxSamePath.UseVisualStyleBackColor = true;
            this.checkBoxSamePath.Click += new System.EventHandler(this.checkBoxSamePath_Click);
            // 
            // buttonLogPath
            // 
            this.buttonLogPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogPath.Enabled = false;
            this.buttonLogPath.Location = new System.Drawing.Point(349, 51);
            this.buttonLogPath.Name = "buttonLogPath";
            this.buttonLogPath.Size = new System.Drawing.Size(24, 21);
            this.buttonLogPath.TabIndex = 5;
            this.buttonLogPath.Text = "....";
            this.buttonLogPath.UseVisualStyleBackColor = true;
            this.buttonLogPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // buttonDataPath
            // 
            this.buttonDataPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDataPath.Location = new System.Drawing.Point(350, 25);
            this.buttonDataPath.Name = "buttonDataPath";
            this.buttonDataPath.Size = new System.Drawing.Size(24, 20);
            this.buttonDataPath.TabIndex = 4;
            this.buttonDataPath.Text = "...";
            this.buttonDataPath.UseVisualStyleBackColor = true;
            this.buttonDataPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Enabled = false;
            this.labelLog.Location = new System.Drawing.Point(12, 54);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(28, 13);
            this.labelLog.TabIndex = 3;
            this.labelLog.Text = "Log:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(12, 28);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Data:";
            // 
            // textBoxLogFile
            // 
            this.textBoxLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogFile.Enabled = false;
            this.textBoxLogFile.Location = new System.Drawing.Point(51, 51);
            this.textBoxLogFile.Name = "textBoxLogFile";
            this.textBoxLogFile.Size = new System.Drawing.Size(292, 20);
            this.textBoxLogFile.TabIndex = 1;
            // 
            // textBoxDataFile
            // 
            this.textBoxDataFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDataFile.Location = new System.Drawing.Point(51, 25);
            this.textBoxDataFile.Name = "textBoxDataFile";
            this.textBoxDataFile.Size = new System.Drawing.Size(292, 20);
            this.textBoxDataFile.TabIndex = 0;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.White;
            this.imageList.Images.SetKeyName(0, "Down.png");
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(240, 165);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAbbrechnen
            // 
            this.buttonAbbrechnen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbbrechnen.Location = new System.Drawing.Point(321, 165);
            this.buttonAbbrechnen.Name = "buttonAbbrechnen";
            this.buttonAbbrechnen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechnen.TabIndex = 3;
            this.buttonAbbrechnen.Text = "Abbrechnen";
            this.buttonAbbrechnen.UseVisualStyleBackColor = true;
            this.buttonAbbrechnen.Click += new System.EventHandler(this.buttonAbbrechnen_Click);
            // 
            // textBoxDBname
            // 
            this.textBoxDBname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDBname.Location = new System.Drawing.Point(138, 13);
            this.textBoxDBname.Name = "textBoxDBname";
            this.textBoxDBname.Size = new System.Drawing.Size(258, 20);
            this.textBoxDBname.TabIndex = 4;
            this.textBoxDBname.TextChanged += new System.EventHandler(this.textBoxDBname_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // FormNewDB
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 196);
            this.Controls.Add(this.textBoxDBname);
            this.Controls.Add(this.buttonAbbrechnen);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxDBFiles);
            this.Controls.Add(this.labelDBName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormNewDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Neue Datenbank";
            this.groupBoxDBFiles.ResumeLayout(false);
            this.groupBoxDBFiles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDBName;
        private System.Windows.Forms.GroupBox groupBoxDBFiles;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAbbrechnen;
        private System.Windows.Forms.Button buttonLogPath;
        private System.Windows.Forms.Button buttonDataPath;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxLogFile;
        private System.Windows.Forms.TextBox textBoxDataFile;
        private System.Windows.Forms.TextBox textBoxDBname;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.CheckBox checkBoxSamePath;
    }
}
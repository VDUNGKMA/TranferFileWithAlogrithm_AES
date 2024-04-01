namespace File_Transfer
{
    partial class txt_OutputFile
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
            this.onlinePCList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.changeSaveLocButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.sendFileButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fileNotificationLabel = new System.Windows.Forms.Label();
            this.savePathLabel = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notificationPanel = new System.Windows.Forms.Panel();
            this.notificationTempLabel = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.AES = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.IV = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.notificationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // onlinePCList
            // 
            this.onlinePCList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.onlinePCList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.onlinePCList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.onlinePCList.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlinePCList.FullRowSelect = true;
            this.onlinePCList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.onlinePCList.HideSelection = false;
            this.onlinePCList.HoverSelection = true;
            this.onlinePCList.Location = new System.Drawing.Point(14, 79);
            this.onlinePCList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.onlinePCList.MultiSelect = false;
            this.onlinePCList.Name = "onlinePCList";
            this.onlinePCList.Size = new System.Drawing.Size(809, 284);
            this.onlinePCList.TabIndex = 0;
            this.onlinePCList.UseCompatibleStateImageBehavior = false;
            this.onlinePCList.View = System.Windows.Forms.View.Details;
            this.onlinePCList.SelectedIndexChanged += new System.EventHandler(this.onlinePCList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP Address";
            this.columnHeader1.Width = 271;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Computer Name";
            this.columnHeader2.Width = 263;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Location = new System.Drawing.Point(8, -2);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(208, 55);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Find/Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.changeSaveLocButton);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 54);
            this.panel1.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(628, -2);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(208, 55);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // changeSaveLocButton
            // 
            this.changeSaveLocButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.changeSaveLocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSaveLocButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSaveLocButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeSaveLocButton.Location = new System.Drawing.Point(422, -2);
            this.changeSaveLocButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changeSaveLocButton.Name = "changeSaveLocButton";
            this.changeSaveLocButton.Size = new System.Drawing.Size(208, 55);
            this.changeSaveLocButton.TabIndex = 10;
            this.changeSaveLocButton.Text = "Change Save Location";
            this.changeSaveLocButton.UseVisualStyleBackColor = false;
            this.changeSaveLocButton.Click += new System.EventHandler(this.changeSaveLocButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stopButton.Location = new System.Drawing.Point(214, -2);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(208, 55);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop Application";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Location = new System.Drawing.Point(18, 60);
            this.notificationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(13, 20);
            this.notificationLabel.TabIndex = 3;
            this.notificationLabel.Text = ".";
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.browseButton.Location = new System.Drawing.Point(6, 512);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(164, 52);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.fileNameLabel.Location = new System.Drawing.Point(14, 474);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(13, 20);
            this.fileNameLabel.TabIndex = 3;
            this.fileNameLabel.Text = ".";
            // 
            // sendFileButton
            // 
            this.sendFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendFileButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sendFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendFileButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendFileButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sendFileButton.Location = new System.Drawing.Point(326, 512);
            this.sendFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendFileButton.Name = "sendFileButton";
            this.sendFileButton.Size = new System.Drawing.Size(329, 52);
            this.sendFileButton.TabIndex = 5;
            this.sendFileButton.Text = "Send File to Selected Computer";
            this.sendFileButton.UseVisualStyleBackColor = false;
            this.sendFileButton.Click += new System.EventHandler(this.sendFileButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(183, 62);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(13, 20);
            this.infoLabel.TabIndex = 7;
            this.infoLabel.Text = ".";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearButton.Location = new System.Drawing.Point(664, 512);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(164, 52);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fileNotificationLabel
            // 
            this.fileNotificationLabel.AutoSize = true;
            this.fileNotificationLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.fileNotificationLabel.Location = new System.Drawing.Point(14, 448);
            this.fileNotificationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileNotificationLabel.Name = "fileNotificationLabel";
            this.fileNotificationLabel.Size = new System.Drawing.Size(13, 20);
            this.fileNotificationLabel.TabIndex = 9;
            this.fileNotificationLabel.Text = ".";
            // 
            // savePathLabel
            // 
            this.savePathLabel.AutoSize = true;
            this.savePathLabel.Location = new System.Drawing.Point(453, 60);
            this.savePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(199, 20);
            this.savePathLabel.TabIndex = 10;
            this.savePathLabel.Text = "C:\\Users\\Public\\Downloads";
            this.savePathLabel.Click += new System.EventHandler(this.savePathLabel_Click);
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(171, 532);
            this.ipBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(148, 26);
            this.ipBox.TabIndex = 11;
            this.ipBox.TextChanged += new System.EventHandler(this.ipBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 509);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Insert receiver\'s IP";
            // 
            // notificationPanel
            // 
            this.notificationPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.notificationPanel.Controls.Add(this.notificationTempLabel);
            this.notificationPanel.Location = new System.Drawing.Point(22, 243);
            this.notificationPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(786, 93);
            this.notificationPanel.TabIndex = 13;
            this.notificationPanel.UseWaitCursor = true;
            this.notificationPanel.Visible = false;
            // 
            // notificationTempLabel
            // 
            this.notificationTempLabel.AutoSize = true;
            this.notificationTempLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationTempLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.notificationTempLabel.Location = new System.Drawing.Point(16, 31);
            this.notificationTempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notificationTempLabel.Name = "notificationTempLabel";
            this.notificationTempLabel.Size = new System.Drawing.Size(262, 28);
            this.notificationTempLabel.TabIndex = 2;
            this.notificationTempLabel.Text = "Please wait. File Sending to";
            this.notificationTempLabel.UseWaitCursor = true;
            this.notificationTempLabel.Click += new System.EventHandler(this.notificationTempLabel_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(59, 399);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(382, 26);
            this.txtKey.TabIndex = 14;
            this.txtKey.TextChanged += new System.EventHandler(this.keyBox_TextChanged);
            // 
            // AES
            // 
            this.AES.FormattingEnabled = true;
            this.AES.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.AES.Location = new System.Drawing.Point(501, 399);
            this.AES.Name = "AES";
            this.AES.Size = new System.Drawing.Size(90, 28);
            this.AES.TabIndex = 15;
            this.AES.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.AES.TextChanged += new System.EventHandler(this.aesLength);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "AES";
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Decrypt.Location = new System.Drawing.Point(654, 397);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(98, 36);
            this.btn_Decrypt.TabIndex = 18;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = false;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(59, 439);
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(152, 26);
            this.txtIV.TabIndex = 19;
            // 
            // IV
            // 
            this.IV.AutoSize = true;
            this.IV.Location = new System.Drawing.Point(18, 442);
            this.IV.Name = "IV";
            this.IV.Size = new System.Drawing.Size(29, 20);
            this.IV.TabIndex = 20;
            this.IV.Text = "IV:";
            // 
            // txt_OutputFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(834, 585);
            this.Controls.Add(this.IV);
            this.Controls.Add(this.txtIV);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AES);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.notificationPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.savePathLabel);
            this.Controls.Add(this.fileNotificationLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.sendFileButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.onlinePCList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "txt_OutputFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Transfer Application - Computer Networks Laboratory Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.notificationPanel.ResumeLayout(false);
            this.notificationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView onlinePCList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button sendFileButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label fileNotificationLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button changeSaveLocButton;
        private System.Windows.Forms.Label savePathLabel;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel notificationPanel;
        private System.Windows.Forms.Label notificationTempLabel;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.ComboBox AES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.Label IV;
    }
}


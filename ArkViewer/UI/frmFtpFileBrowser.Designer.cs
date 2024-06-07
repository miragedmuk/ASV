
namespace ARKViewer
{
    partial class frmFtpFileBrowser
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFtpFileBrowser));
            lvwFileBrowser = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            imagesFileBrowser = new System.Windows.Forms.ImageList(components);
            btnSelect = new System.Windows.Forms.Button();
            lblStatus = new System.Windows.Forms.Label();
            optFtpModeSftp = new System.Windows.Forms.RadioButton();
            optFtpModeFtp = new System.Windows.Forms.RadioButton();
            lblMode = new System.Windows.Forms.Label();
            chkPasswordVisibility = new System.Windows.Forms.CheckBox();
            udFTPPort = new System.Windows.Forms.NumericUpDown();
            txtFTPPassword = new System.Windows.Forms.TextBox();
            txtFTPUsername = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            txtFTPAddress = new System.Windows.Forms.TextBox();
            lblServerPort = new System.Windows.Forms.Label();
            lblServerAddress = new System.Windows.Forms.Label();
            btnConnect = new System.Windows.Forms.Button();
            txtServerName = new System.Windows.Forms.TextBox();
            lblServerName = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            grpFtpServer = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            lblFtpServerDetails = new System.Windows.Forms.Label();
            lblHeaderFtp = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tpgFtp = new System.Windows.Forms.TabPage();
            tpgRCON = new System.Windows.Forms.TabPage();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnTestRcon = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtRconServer = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            udRconPort = new System.Windows.Forms.NumericUpDown();
            txtRconPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)udFTPPort).BeginInit();
            grpFtpServer.SuspendLayout();
            tabControl1.SuspendLayout();
            tpgFtp.SuspendLayout();
            tpgRCON.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udRconPort).BeginInit();
            SuspendLayout();
            // 
            // lvwFileBrowser
            // 
            lvwFileBrowser.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwFileBrowser.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwFileBrowser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvwFileBrowser.Enabled = false;
            lvwFileBrowser.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwFileBrowser.FullRowSelect = true;
            lvwFileBrowser.LargeImageList = imagesFileBrowser;
            lvwFileBrowser.Location = new System.Drawing.Point(279, 66);
            lvwFileBrowser.Name = "lvwFileBrowser";
            lvwFileBrowser.Size = new System.Drawing.Size(467, 314);
            lvwFileBrowser.SmallImageList = imagesFileBrowser;
            lvwFileBrowser.TabIndex = 15;
            lvwFileBrowser.UseCompatibleStateImageBehavior = false;
            lvwFileBrowser.View = System.Windows.Forms.View.Details;
            lvwFileBrowser.SelectedIndexChanged += lvwFileBrowser_SelectedIndexChanged;
            lvwFileBrowser.DoubleClick += lvwFileBrowser_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date Modified";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Type";
            columnHeader3.Width = 75;
            // 
            // imagesFileBrowser
            // 
            imagesFileBrowser.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imagesFileBrowser.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imagesFileBrowser.ImageStream");
            imagesFileBrowser.TransparentColor = System.Drawing.Color.Transparent;
            imagesFileBrowser.Images.SetKeyName(0, "shell32_46.ico");
            imagesFileBrowser.Images.SetKeyName(1, "shell32_235.ico");
            imagesFileBrowser.Images.SetKeyName(2, "shell32_243.ico");
            // 
            // btnSelect
            // 
            btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSelect.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSelect.Enabled = false;
            btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            btnSelect.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnSelect.Location = new System.Drawing.Point(683, 501);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new System.Drawing.Size(71, 23);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Save";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            lblStatus.ForeColor = System.Drawing.Color.DimGray;
            lblStatus.Location = new System.Drawing.Point(21, 504);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(646, 20);
            lblStatus.TabIndex = 3;
            // 
            // optFtpModeSftp
            // 
            optFtpModeSftp.AutoSize = true;
            optFtpModeSftp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            optFtpModeSftp.Location = new System.Drawing.Point(78, 305);
            optFtpModeSftp.Name = "optFtpModeSftp";
            optFtpModeSftp.Size = new System.Drawing.Size(52, 17);
            optFtpModeSftp.TabIndex = 13;
            optFtpModeSftp.Text = "SFTP";
            optFtpModeSftp.UseVisualStyleBackColor = true;
            // 
            // optFtpModeFtp
            // 
            optFtpModeFtp.AutoSize = true;
            optFtpModeFtp.Checked = true;
            optFtpModeFtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            optFtpModeFtp.Location = new System.Drawing.Point(27, 305);
            optFtpModeFtp.Name = "optFtpModeFtp";
            optFtpModeFtp.Size = new System.Drawing.Size(45, 17);
            optFtpModeFtp.TabIndex = 12;
            optFtpModeFtp.TabStop = true;
            optFtpModeFtp.Text = "FTP";
            optFtpModeFtp.UseVisualStyleBackColor = true;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.BackColor = System.Drawing.Color.Transparent;
            lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lblMode.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblMode.Location = new System.Drawing.Point(21, 278);
            lblMode.Name = "lblMode";
            lblMode.Size = new System.Drawing.Size(34, 13);
            lblMode.TabIndex = 11;
            lblMode.Text = "Mode";
            lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkPasswordVisibility
            // 
            chkPasswordVisibility.Appearance = System.Windows.Forms.Appearance.Button;
            chkPasswordVisibility.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            chkPasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkPasswordVisibility.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            chkPasswordVisibility.Image = (System.Drawing.Image)resources.GetObject("chkPasswordVisibility.Image");
            chkPasswordVisibility.Location = new System.Drawing.Point(238, 251);
            chkPasswordVisibility.Name = "chkPasswordVisibility";
            chkPasswordVisibility.Size = new System.Drawing.Size(25, 21);
            chkPasswordVisibility.TabIndex = 10;
            chkPasswordVisibility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkPasswordVisibility.UseVisualStyleBackColor = false;
            chkPasswordVisibility.CheckedChanged += chkPasswordVisibility_CheckedChanged;
            // 
            // udFTPPort
            // 
            udFTPPort.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udFTPPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udFTPPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            udFTPPort.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udFTPPort.Location = new System.Drawing.Point(24, 156);
            udFTPPort.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            udFTPPort.Name = "udFTPPort";
            udFTPPort.Size = new System.Drawing.Size(60, 20);
            udFTPPort.TabIndex = 5;
            udFTPPort.Value = new decimal(new int[] { 21, 0, 0, 0 });
            // 
            // txtFTPPassword
            // 
            txtFTPPassword.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtFTPPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFTPPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            txtFTPPassword.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtFTPPassword.Location = new System.Drawing.Point(24, 253);
            txtFTPPassword.Name = "txtFTPPassword";
            txtFTPPassword.PasswordChar = '●';
            txtFTPPassword.Size = new System.Drawing.Size(214, 17);
            txtFTPPassword.TabIndex = 9;
            // 
            // txtFTPUsername
            // 
            txtFTPUsername.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtFTPUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFTPUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            txtFTPUsername.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtFTPUsername.Location = new System.Drawing.Point(24, 207);
            txtFTPUsername.Name = "txtFTPUsername";
            txtFTPUsername.Size = new System.Drawing.Size(214, 17);
            txtFTPUsername.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = System.Drawing.Color.Transparent;
            lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblPassword.Location = new System.Drawing.Point(21, 234);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(53, 13);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = System.Drawing.Color.Transparent;
            lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lblUsername.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblUsername.Location = new System.Drawing.Point(21, 181);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(55, 13);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFTPAddress
            // 
            txtFTPAddress.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtFTPAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFTPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            txtFTPAddress.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtFTPAddress.Location = new System.Drawing.Point(24, 112);
            txtFTPAddress.Name = "txtFTPAddress";
            txtFTPAddress.Size = new System.Drawing.Size(214, 17);
            txtFTPAddress.TabIndex = 3;
            txtFTPAddress.Validating += txtFTPAddress_Validating;
            // 
            // lblServerPort
            // 
            lblServerPort.AutoSize = true;
            lblServerPort.BackColor = System.Drawing.Color.Transparent;
            lblServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lblServerPort.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblServerPort.Location = new System.Drawing.Point(21, 134);
            lblServerPort.Name = "lblServerPort";
            lblServerPort.Size = new System.Drawing.Size(26, 13);
            lblServerPort.TabIndex = 4;
            lblServerPort.Text = "Port";
            // 
            // lblServerAddress
            // 
            lblServerAddress.BackColor = System.Drawing.Color.Transparent;
            lblServerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lblServerAddress.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblServerAddress.Location = new System.Drawing.Point(21, 89);
            lblServerAddress.Name = "lblServerAddress";
            lblServerAddress.Size = new System.Drawing.Size(217, 19);
            lblServerAddress.TabIndex = 2;
            lblServerAddress.Text = "Server Address                        ";
            lblServerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConnect.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnConnect.Location = new System.Drawing.Point(27, 352);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new System.Drawing.Size(211, 23);
            btnConnect.TabIndex = 14;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtServerName
            // 
            txtServerName.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtServerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            txtServerName.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtServerName.Location = new System.Drawing.Point(24, 67);
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new System.Drawing.Size(214, 17);
            txtServerName.TabIndex = 1;
            // 
            // lblServerName
            // 
            lblServerName.AutoSize = true;
            lblServerName.BackColor = System.Drawing.Color.Transparent;
            lblServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lblServerName.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblServerName.Location = new System.Drawing.Point(21, 47);
            lblServerName.Name = "lblServerName";
            lblServerName.Size = new System.Drawing.Size(69, 13);
            lblServerName.TabIndex = 0;
            lblServerName.Text = "Server Name";
            lblServerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnClose.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnClose.Location = new System.Drawing.Point(760, 501);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(71, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // grpFtpServer
            // 
            grpFtpServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpFtpServer.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpFtpServer.Controls.Add(label1);
            grpFtpServer.Controls.Add(lblFtpServerDetails);
            grpFtpServer.Controls.Add(lblHeaderFtp);
            grpFtpServer.Controls.Add(txtServerName);
            grpFtpServer.Controls.Add(lblServerName);
            grpFtpServer.Controls.Add(lvwFileBrowser);
            grpFtpServer.Controls.Add(btnConnect);
            grpFtpServer.Controls.Add(lblServerAddress);
            grpFtpServer.Controls.Add(optFtpModeSftp);
            grpFtpServer.Controls.Add(lblServerPort);
            grpFtpServer.Controls.Add(optFtpModeFtp);
            grpFtpServer.Controls.Add(txtFTPAddress);
            grpFtpServer.Controls.Add(lblMode);
            grpFtpServer.Controls.Add(lblUsername);
            grpFtpServer.Controls.Add(chkPasswordVisibility);
            grpFtpServer.Controls.Add(lblPassword);
            grpFtpServer.Controls.Add(udFTPPort);
            grpFtpServer.Controls.Add(txtFTPUsername);
            grpFtpServer.Controls.Add(txtFTPPassword);
            grpFtpServer.Location = new System.Drawing.Point(26, 28);
            grpFtpServer.Name = "grpFtpServer";
            grpFtpServer.Size = new System.Drawing.Size(767, 408);
            grpFtpServer.TabIndex = 0;
            grpFtpServer.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            label1.Location = new System.Drawing.Point(276, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 15);
            label1.TabIndex = 17;
            label1.Text = "File Browser";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFtpServerDetails
            // 
            lblFtpServerDetails.AutoSize = true;
            lblFtpServerDetails.BackColor = System.Drawing.Color.Transparent;
            lblFtpServerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblFtpServerDetails.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblFtpServerDetails.Location = new System.Drawing.Point(10, 14);
            lblFtpServerDetails.Name = "lblFtpServerDetails";
            lblFtpServerDetails.Size = new System.Drawing.Size(126, 15);
            lblFtpServerDetails.TabIndex = 1;
            lblFtpServerDetails.Text = "FTP Server Details";
            lblFtpServerDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderFtp
            // 
            lblHeaderFtp.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderFtp.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderFtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblHeaderFtp.Location = new System.Drawing.Point(0, 0);
            lblHeaderFtp.Name = "lblHeaderFtp";
            lblHeaderFtp.Size = new System.Drawing.Size(769, 6);
            lblHeaderFtp.TabIndex = 0;
            lblHeaderFtp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl1.Controls.Add(tpgFtp);
            tabControl1.Controls.Add(tpgRCON);
            tabControl1.Location = new System.Drawing.Point(7, 10);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(831, 485);
            tabControl1.TabIndex = 0;
            // 
            // tpgFtp
            // 
            tpgFtp.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgFtp.Controls.Add(grpFtpServer);
            tpgFtp.Location = new System.Drawing.Point(4, 22);
            tpgFtp.Name = "tpgFtp";
            tpgFtp.Padding = new System.Windows.Forms.Padding(3);
            tpgFtp.Size = new System.Drawing.Size(823, 459);
            tpgFtp.TabIndex = 0;
            tpgFtp.Text = "FTP Server";
            // 
            // tpgRCON
            // 
            tpgRCON.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            tpgRCON.Controls.Add(groupBox1);
            tpgRCON.Location = new System.Drawing.Point(4, 22);
            tpgRCON.Name = "tpgRCON";
            tpgRCON.Padding = new System.Windows.Forms.Padding(3);
            tpgRCON.Size = new System.Drawing.Size(823, 459);
            tpgRCON.TabIndex = 1;
            tpgRCON.Text = "RCON";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            groupBox1.Controls.Add(btnTestRcon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtRconServer);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(udRconPort);
            groupBox1.Controls.Add(txtRconPassword);
            groupBox1.Location = new System.Drawing.Point(26, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(775, 414);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnTestRcon
            // 
            btnTestRcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnTestRcon.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnTestRcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTestRcon.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnTestRcon.Location = new System.Drawing.Point(284, 267);
            btnTestRcon.Name = "btnTestRcon";
            btnTestRcon.Size = new System.Drawing.Size(212, 23);
            btnTestRcon.TabIndex = 8;
            btnTestRcon.Text = "Connect";
            btnTestRcon.UseVisualStyleBackColor = false;
            btnTestRcon.Click += btnTestRcon_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            label3.Location = new System.Drawing.Point(281, 66);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(171, 15);
            label3.TabIndex = 1;
            label3.Text = "RCON Connection Details";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(0, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(775, 12);
            label4.TabIndex = 0;
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label6.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            label6.Location = new System.Drawing.Point(281, 107);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(217, 19);
            label6.TabIndex = 2;
            label6.Text = "IP Address                        ";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label7.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            label7.Location = new System.Drawing.Point(281, 152);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(26, 13);
            label7.TabIndex = 4;
            label7.Text = "Port";
            // 
            // txtRconServer
            // 
            txtRconServer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            txtRconServer.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtRconServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtRconServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            txtRconServer.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtRconServer.Location = new System.Drawing.Point(284, 129);
            txtRconServer.Name = "txtRconServer";
            txtRconServer.Size = new System.Drawing.Size(214, 17);
            txtRconServer.TabIndex = 3;
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label10.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            label10.Location = new System.Drawing.Point(281, 210);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(53, 13);
            label10.TabIndex = 6;
            label10.Text = "Password";
            // 
            // udRconPort
            // 
            udRconPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            udRconPort.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udRconPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udRconPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            udRconPort.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udRconPort.Location = new System.Drawing.Point(284, 173);
            udRconPort.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            udRconPort.Name = "udRconPort";
            udRconPort.Size = new System.Drawing.Size(60, 18);
            udRconPort.TabIndex = 5;
            udRconPort.Value = new decimal(new int[] { 27020, 0, 0, 0 });
            // 
            // txtRconPassword
            // 
            txtRconPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            txtRconPassword.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtRconPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtRconPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            txtRconPassword.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtRconPassword.Location = new System.Drawing.Point(284, 228);
            txtRconPassword.Name = "txtRconPassword";
            txtRconPassword.PasswordChar = '●';
            txtRconPassword.Size = new System.Drawing.Size(214, 17);
            txtRconPassword.TabIndex = 7;
            // 
            // frmFtpFileBrowser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(844, 533);
            Controls.Add(tabControl1);
            Controls.Add(btnClose);
            Controls.Add(lblStatus);
            Controls.Add(btnSelect);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            MinimumSize = new System.Drawing.Size(530, 485);
            Name = "frmFtpFileBrowser";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FTP Server";
            FormClosed += frmFtpFileBrowser_FormClosed;
            ((System.ComponentModel.ISupportInitialize)udFTPPort).EndInit();
            grpFtpServer.ResumeLayout(false);
            grpFtpServer.PerformLayout();
            tabControl1.ResumeLayout(false);
            tpgFtp.ResumeLayout(false);
            tpgRCON.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)udRconPort).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView lvwFileBrowser;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imagesFileBrowser;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton optFtpModeSftp;
        private System.Windows.Forms.RadioButton optFtpModeFtp;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.CheckBox chkPasswordVisibility;
        private System.Windows.Forms.NumericUpDown udFTPPort;
        private System.Windows.Forms.TextBox txtFTPPassword;
        private System.Windows.Forms.TextBox txtFTPUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtFTPAddress;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.Label lblServerAddress;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpFtpServer;
        private System.Windows.Forms.Label lblFtpServerDetails;
        private System.Windows.Forms.Label lblHeaderFtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpgFtp;
        private System.Windows.Forms.TabPage tpgRCON;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRconServer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown udRconPort;
        private System.Windows.Forms.TextBox txtRconPassword;
        private System.Windows.Forms.Button btnTestRcon;
    }
}
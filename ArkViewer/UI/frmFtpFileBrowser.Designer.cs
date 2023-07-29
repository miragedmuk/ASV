
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFtpFileBrowser));
            this.lvwFileBrowser = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imagesFileBrowser = new System.Windows.Forms.ImageList(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.optFtpModeSftp = new System.Windows.Forms.RadioButton();
            this.optFtpModeFtp = new System.Windows.Forms.RadioButton();
            this.lblMode = new System.Windows.Forms.Label();
            this.chkPasswordVisibility = new System.Windows.Forms.CheckBox();
            this.udFTPPort = new System.Windows.Forms.NumericUpDown();
            this.txtFTPPassword = new System.Windows.Forms.TextBox();
            this.txtFTPUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtFTPAddress = new System.Windows.Forms.TextBox();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.lblServerAddress = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpFtpServer = new System.Windows.Forms.GroupBox();
            this.lblFileBrowser = new System.Windows.Forms.Label();
            this.lblFtpServerDetails = new System.Windows.Forms.Label();
            this.lblHeaderFtp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udFTPPort)).BeginInit();
            this.grpFtpServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwFileBrowser
            // 
            this.lvwFileBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwFileBrowser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwFileBrowser.Enabled = false;
            this.lvwFileBrowser.FullRowSelect = true;
            this.lvwFileBrowser.HideSelection = false;
            this.lvwFileBrowser.LargeImageList = this.imagesFileBrowser;
            this.lvwFileBrowser.Location = new System.Drawing.Point(279, 66);
            this.lvwFileBrowser.Name = "lvwFileBrowser";
            this.lvwFileBrowser.Size = new System.Drawing.Size(550, 306);
            this.lvwFileBrowser.SmallImageList = this.imagesFileBrowser;
            this.lvwFileBrowser.TabIndex = 15;
            this.lvwFileBrowser.UseCompatibleStateImageBehavior = false;
            this.lvwFileBrowser.View = System.Windows.Forms.View.Details;
            this.lvwFileBrowser.SelectedIndexChanged += new System.EventHandler(this.lvwFileBrowser_SelectedIndexChanged);
            this.lvwFileBrowser.DoubleClick += new System.EventHandler(this.lvwFileBrowser_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date Modified";
            this.columnHeader2.Width = 175;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 100;
            // 
            // imagesFileBrowser
            // 
            this.imagesFileBrowser.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesFileBrowser.ImageStream")));
            this.imagesFileBrowser.TransparentColor = System.Drawing.Color.Transparent;
            this.imagesFileBrowser.Images.SetKeyName(0, "shell32_46.ico");
            this.imagesFileBrowser.Images.SetKeyName(1, "shell32_235.ico");
            this.imagesFileBrowser.Images.SetKeyName(2, "shell32_243.ico");
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelect.Enabled = false;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(713, 414);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(71, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Save";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatus.Location = new System.Drawing.Point(21, 417);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(676, 20);
            this.lblStatus.TabIndex = 3;
            // 
            // optFtpModeSftp
            // 
            this.optFtpModeSftp.AutoSize = true;
            this.optFtpModeSftp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optFtpModeSftp.Location = new System.Drawing.Point(78, 305);
            this.optFtpModeSftp.Name = "optFtpModeSftp";
            this.optFtpModeSftp.Size = new System.Drawing.Size(52, 17);
            this.optFtpModeSftp.TabIndex = 13;
            this.optFtpModeSftp.Text = "SFTP";
            this.optFtpModeSftp.UseVisualStyleBackColor = true;
            // 
            // optFtpModeFtp
            // 
            this.optFtpModeFtp.AutoSize = true;
            this.optFtpModeFtp.Checked = true;
            this.optFtpModeFtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optFtpModeFtp.Location = new System.Drawing.Point(27, 305);
            this.optFtpModeFtp.Name = "optFtpModeFtp";
            this.optFtpModeFtp.Size = new System.Drawing.Size(45, 17);
            this.optFtpModeFtp.TabIndex = 12;
            this.optFtpModeFtp.TabStop = true;
            this.optFtpModeFtp.Text = "FTP";
            this.optFtpModeFtp.UseVisualStyleBackColor = true;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.BackColor = System.Drawing.SystemColors.Control;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(21, 278);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(34, 13);
            this.lblMode.TabIndex = 11;
            this.lblMode.Text = "Mode";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkPasswordVisibility
            // 
            this.chkPasswordVisibility.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPasswordVisibility.Image = ((System.Drawing.Image)(resources.GetObject("chkPasswordVisibility.Image")));
            this.chkPasswordVisibility.Location = new System.Drawing.Point(238, 252);
            this.chkPasswordVisibility.Name = "chkPasswordVisibility";
            this.chkPasswordVisibility.Size = new System.Drawing.Size(20, 20);
            this.chkPasswordVisibility.TabIndex = 10;
            this.chkPasswordVisibility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPasswordVisibility.UseVisualStyleBackColor = false;
            this.chkPasswordVisibility.CheckedChanged += new System.EventHandler(this.chkPasswordVisibility_CheckedChanged);
            // 
            // udFTPPort
            // 
            this.udFTPPort.Location = new System.Drawing.Point(24, 155);
            this.udFTPPort.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.udFTPPort.Name = "udFTPPort";
            this.udFTPPort.Size = new System.Drawing.Size(60, 20);
            this.udFTPPort.TabIndex = 5;
            this.udFTPPort.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // txtFTPPassword
            // 
            this.txtFTPPassword.Location = new System.Drawing.Point(24, 252);
            this.txtFTPPassword.Name = "txtFTPPassword";
            this.txtFTPPassword.PasswordChar = '●';
            this.txtFTPPassword.Size = new System.Drawing.Size(214, 20);
            this.txtFTPPassword.TabIndex = 9;
            // 
            // txtFTPUsername
            // 
            this.txtFTPUsername.Location = new System.Drawing.Point(24, 206);
            this.txtFTPUsername.Name = "txtFTPUsername";
            this.txtFTPUsername.Size = new System.Drawing.Size(214, 20);
            this.txtFTPUsername.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(21, 234);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(21, 181);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFTPAddress
            // 
            this.txtFTPAddress.Location = new System.Drawing.Point(24, 111);
            this.txtFTPAddress.Name = "txtFTPAddress";
            this.txtFTPAddress.Size = new System.Drawing.Size(214, 20);
            this.txtFTPAddress.TabIndex = 3;
            this.txtFTPAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtFTPAddress_Validating);
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.BackColor = System.Drawing.SystemColors.Control;
            this.lblServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerPort.Location = new System.Drawing.Point(21, 134);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(26, 13);
            this.lblServerPort.TabIndex = 4;
            this.lblServerPort.Text = "Port";
            // 
            // lblServerAddress
            // 
            this.lblServerAddress.BackColor = System.Drawing.SystemColors.Control;
            this.lblServerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerAddress.Location = new System.Drawing.Point(21, 89);
            this.lblServerAddress.Name = "lblServerAddress";
            this.lblServerAddress.Size = new System.Drawing.Size(217, 19);
            this.lblServerAddress.TabIndex = 2;
            this.lblServerAddress.Text = "Server Address                        ";
            this.lblServerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(27, 352);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(211, 23);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(24, 66);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(214, 20);
            this.txtServerName.TabIndex = 1;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.BackColor = System.Drawing.SystemColors.Control;
            this.lblServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.Location = new System.Drawing.Point(21, 47);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(69, 13);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Server Name";
            this.lblServerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(790, 414);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // grpFtpServer
            // 
            this.grpFtpServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFtpServer.Controls.Add(this.lblFileBrowser);
            this.grpFtpServer.Controls.Add(this.lblFtpServerDetails);
            this.grpFtpServer.Controls.Add(this.lblHeaderFtp);
            this.grpFtpServer.Controls.Add(this.txtServerName);
            this.grpFtpServer.Controls.Add(this.lblServerName);
            this.grpFtpServer.Controls.Add(this.lvwFileBrowser);
            this.grpFtpServer.Controls.Add(this.btnConnect);
            this.grpFtpServer.Controls.Add(this.lblServerAddress);
            this.grpFtpServer.Controls.Add(this.optFtpModeSftp);
            this.grpFtpServer.Controls.Add(this.lblServerPort);
            this.grpFtpServer.Controls.Add(this.optFtpModeFtp);
            this.grpFtpServer.Controls.Add(this.txtFTPAddress);
            this.grpFtpServer.Controls.Add(this.lblMode);
            this.grpFtpServer.Controls.Add(this.lblUsername);
            this.grpFtpServer.Controls.Add(this.chkPasswordVisibility);
            this.grpFtpServer.Controls.Add(this.lblPassword);
            this.grpFtpServer.Controls.Add(this.udFTPPort);
            this.grpFtpServer.Controls.Add(this.txtFTPUsername);
            this.grpFtpServer.Controls.Add(this.txtFTPPassword);
            this.grpFtpServer.Location = new System.Drawing.Point(12, 12);
            this.grpFtpServer.Name = "grpFtpServer";
            this.grpFtpServer.Size = new System.Drawing.Size(847, 389);
            this.grpFtpServer.TabIndex = 0;
            this.grpFtpServer.TabStop = false;
            // 
            // lblFileBrowser
            // 
            this.lblFileBrowser.AutoSize = true;
            this.lblFileBrowser.BackColor = System.Drawing.SystemColors.Control;
            this.lblFileBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileBrowser.Location = new System.Drawing.Point(276, 47);
            this.lblFileBrowser.Name = "lblFileBrowser";
            this.lblFileBrowser.Size = new System.Drawing.Size(64, 13);
            this.lblFileBrowser.TabIndex = 16;
            this.lblFileBrowser.Text = "File Browser";
            this.lblFileBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFtpServerDetails
            // 
            this.lblFtpServerDetails.AutoSize = true;
            this.lblFtpServerDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblFtpServerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFtpServerDetails.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblFtpServerDetails.Location = new System.Drawing.Point(10, 14);
            this.lblFtpServerDetails.Name = "lblFtpServerDetails";
            this.lblFtpServerDetails.Size = new System.Drawing.Size(126, 15);
            this.lblFtpServerDetails.TabIndex = 1;
            this.lblFtpServerDetails.Text = "FTP Server Details";
            this.lblFtpServerDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderFtp
            // 
            this.lblHeaderFtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderFtp.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderFtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderFtp.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderFtp.Name = "lblHeaderFtp";
            this.lblHeaderFtp.Size = new System.Drawing.Size(849, 6);
            this.lblHeaderFtp.TabIndex = 0;
            this.lblHeaderFtp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmFtpFileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(874, 446);
            this.Controls.Add(this.grpFtpServer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSelect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(530, 485);
            this.Name = "frmFtpFileBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFtpFileBrowser_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.udFTPPort)).EndInit();
            this.grpFtpServer.ResumeLayout(false);
            this.grpFtpServer.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblFileBrowser;
    }
}
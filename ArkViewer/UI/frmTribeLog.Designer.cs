namespace ARKViewer
{
    partial class frmTribeLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTribeLog));
            lblPlayerLevelLabel = new System.Windows.Forms.Label();
            lblPlayerLevel = new System.Windows.Forms.Label();
            lblTribeName = new System.Windows.Forms.Label();
            lblPlayerName = new System.Windows.Forms.Label();
            picPlayerGender = new System.Windows.Forms.PictureBox();
            pnlWrapper = new System.Windows.Forms.Panel();
            lvwLog = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            btnClose = new System.Windows.Forms.Button();
            btnSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)picPlayerGender).BeginInit();
            pnlWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // lblPlayerLevelLabel
            // 
            lblPlayerLevelLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblPlayerLevelLabel.AutoSize = true;
            lblPlayerLevelLabel.ForeColor = System.Drawing.Color.DarkGray;
            lblPlayerLevelLabel.Location = new System.Drawing.Point(890, 16);
            lblPlayerLevelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPlayerLevelLabel.Name = "lblPlayerLevelLabel";
            lblPlayerLevelLabel.Size = new System.Drawing.Size(69, 15);
            lblPlayerLevelLabel.TabIndex = 2;
            lblPlayerLevelLabel.Text = "Player Level";
            // 
            // lblPlayerLevel
            // 
            lblPlayerLevel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblPlayerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            lblPlayerLevel.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblPlayerLevel.Location = new System.Drawing.Point(891, 31);
            lblPlayerLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPlayerLevel.Name = "lblPlayerLevel";
            lblPlayerLevel.Size = new System.Drawing.Size(72, 36);
            lblPlayerLevel.TabIndex = 3;
            lblPlayerLevel.Text = "135";
            lblPlayerLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTribeName
            // 
            lblTribeName.AutoSize = true;
            lblTribeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblTribeName.ForeColor = System.Drawing.Color.DimGray;
            lblTribeName.Location = new System.Drawing.Point(86, 47);
            lblTribeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTribeName.Name = "lblTribeName";
            lblTribeName.Size = new System.Drawing.Size(89, 16);
            lblTribeName.TabIndex = 1;
            lblTribeName.Text = "Tribe Name";
            lblTribeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            lblPlayerName.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblPlayerName.Location = new System.Drawing.Point(84, 9);
            lblPlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new System.Drawing.Size(163, 29);
            lblPlayerName.TabIndex = 0;
            lblPlayerName.Text = "Player Name";
            lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picPlayerGender
            // 
            picPlayerGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picPlayerGender.Image = (System.Drawing.Image)resources.GetObject("picPlayerGender.Image");
            picPlayerGender.Location = new System.Drawing.Point(20, 9);
            picPlayerGender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            picPlayerGender.Name = "picPlayerGender";
            picPlayerGender.Size = new System.Drawing.Size(58, 57);
            picPlayerGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picPlayerGender.TabIndex = 11;
            picPlayerGender.TabStop = false;
            // 
            // pnlWrapper
            // 
            pnlWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlWrapper.BackColor = System.Drawing.Color.FromArgb(125, 125, 125);
            pnlWrapper.Controls.Add(lvwLog);
            pnlWrapper.Location = new System.Drawing.Point(14, 84);
            pnlWrapper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlWrapper.Name = "pnlWrapper";
            pnlWrapper.Size = new System.Drawing.Size(952, 367);
            pnlWrapper.TabIndex = 4;
            // 
            // lvwLog
            // 
            lvwLog.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwLog.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lvwLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader3 });
            lvwLog.ForeColor = System.Drawing.Color.WhiteSmoke;
            lvwLog.FullRowSelect = true;
            lvwLog.Location = new System.Drawing.Point(26, 23);
            lvwLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwLog.Name = "lvwLog";
            lvwLog.Size = new System.Drawing.Size(891, 318);
            lvwLog.TabIndex = 0;
            lvwLog.UseCompatibleStateImageBehavior = false;
            lvwLog.View = System.Windows.Forms.View.Details;
            lvwLog.ColumnClick += lvwLog_ColumnClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Date";
            columnHeader1.Width = 110;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Information";
            columnHeader3.Width = 630;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnClose.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnClose.Location = new System.Drawing.Point(878, 460);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(88, 27);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnSettings.Image = (System.Drawing.Image)resources.GetObject("btnSettings.Image");
            btnSettings.Location = new System.Drawing.Point(13, 456);
            btnSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new System.Drawing.Size(41, 40);
            btnSettings.TabIndex = 5;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // frmTribeLog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(980, 501);
            Controls.Add(btnSettings);
            Controls.Add(btnClose);
            Controls.Add(lblPlayerLevelLabel);
            Controls.Add(lblPlayerLevel);
            Controls.Add(lblTribeName);
            Controls.Add(lblPlayerName);
            Controls.Add(picPlayerGender);
            Controls.Add(pnlWrapper);
            ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(406, 398);
            Name = "frmTribeLog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Tribe Log Viewer";
            FormClosed += frmTribeLog_FormClosed;
            ((System.ComponentModel.ISupportInitialize)picPlayerGender).EndInit();
            pnlWrapper.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPlayerLevelLabel;
        private System.Windows.Forms.Label lblPlayerLevel;
        private System.Windows.Forms.Label lblTribeName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.PictureBox picPlayerGender;
        private System.Windows.Forms.Panel pnlWrapper;
        private System.Windows.Forms.ListView lvwLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSettings;
    }
}
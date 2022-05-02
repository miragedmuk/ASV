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
            this.lblPlayerLevelLabel = new System.Windows.Forms.Label();
            this.lblPlayerLevel = new System.Windows.Forms.Label();
            this.lblTribeName = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.picPlayerGender = new System.Windows.Forms.PictureBox();
            this.pnlWrapper = new System.Windows.Forms.Panel();
            this.lvwLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerGender)).BeginInit();
            this.pnlWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerLevelLabel
            // 
            this.lblPlayerLevelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayerLevelLabel.AutoSize = true;
            this.lblPlayerLevelLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPlayerLevelLabel.Location = new System.Drawing.Point(763, 14);
            this.lblPlayerLevelLabel.Name = "lblPlayerLevelLabel";
            this.lblPlayerLevelLabel.Size = new System.Drawing.Size(65, 13);
            this.lblPlayerLevelLabel.TabIndex = 2;
            this.lblPlayerLevelLabel.Text = "Player Level";
            // 
            // lblPlayerLevel
            // 
            this.lblPlayerLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerLevel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPlayerLevel.Location = new System.Drawing.Point(764, 27);
            this.lblPlayerLevel.Name = "lblPlayerLevel";
            this.lblPlayerLevel.Size = new System.Drawing.Size(62, 31);
            this.lblPlayerLevel.TabIndex = 3;
            this.lblPlayerLevel.Text = "135";
            this.lblPlayerLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTribeName
            // 
            this.lblTribeName.AutoSize = true;
            this.lblTribeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTribeName.ForeColor = System.Drawing.Color.DimGray;
            this.lblTribeName.Location = new System.Drawing.Point(74, 41);
            this.lblTribeName.Name = "lblTribeName";
            this.lblTribeName.Size = new System.Drawing.Size(90, 16);
            this.lblTribeName.TabIndex = 1;
            this.lblTribeName.Text = "Tribe Name";
            this.lblTribeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPlayerName.Location = new System.Drawing.Point(72, 8);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(163, 29);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player Name";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picPlayerGender
            // 
            this.picPlayerGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayerGender.Image = global::ARKViewer.Properties.Resources.marker_28;
            this.picPlayerGender.Location = new System.Drawing.Point(17, 8);
            this.picPlayerGender.Name = "picPlayerGender";
            this.picPlayerGender.Size = new System.Drawing.Size(50, 50);
            this.picPlayerGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerGender.TabIndex = 11;
            this.picPlayerGender.TabStop = false;
            // 
            // pnlWrapper
            // 
            this.pnlWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWrapper.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlWrapper.Controls.Add(this.lvwLog);
            this.pnlWrapper.Location = new System.Drawing.Point(12, 73);
            this.pnlWrapper.Name = "pnlWrapper";
            this.pnlWrapper.Size = new System.Drawing.Size(816, 318);
            this.pnlWrapper.TabIndex = 4;
            // 
            // lvwLog
            // 
            this.lvwLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lvwLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.lvwLog.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lvwLog.FullRowSelect = true;
            this.lvwLog.HideSelection = false;
            this.lvwLog.Location = new System.Drawing.Point(22, 20);
            this.lvwLog.Name = "lvwLog";
            this.lvwLog.Size = new System.Drawing.Size(764, 276);
            this.lvwLog.TabIndex = 0;
            this.lvwLog.UseCompatibleStateImageBehavior = false;
            this.lvwLog.View = System.Windows.Forms.View.Details;
            this.lvwLog.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwLog_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Information";
            this.columnHeader3.Width = 630;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.Location = new System.Drawing.Point(753, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(11, 395);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(35, 35);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // frmTribeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(840, 434);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPlayerLevelLabel);
            this.Controls.Add(this.lblPlayerLevel);
            this.Controls.Add(this.lblTribeName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.picPlayerGender);
            this.Controls.Add(this.pnlWrapper);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "frmTribeLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tribe Log Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTribeLog_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerGender)).EndInit();
            this.pnlWrapper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
namespace ARKViewer
{
    partial class frmErrorReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmErrorReport));
            lblTitle = new System.Windows.Forms.Label();
            picIcon = new System.Windows.Forms.PictureBox();
            rtbError = new System.Windows.Forms.RichTextBox();
            btnClose = new System.Windows.Forms.Button();
            grpReport = new System.Windows.Forms.GroupBox();
            lblErrorReport = new System.Windows.Forms.Label();
            lblHeaderReport = new System.Windows.Forms.Label();
            lblSubTitle = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblLogFilePath = new System.Windows.Forms.LinkLabel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            grpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblTitle.Location = new System.Drawing.Point(137, 9);
            lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(300, 29);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Something went wrong...";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picIcon
            // 
            picIcon.Image = (System.Drawing.Image)resources.GetObject("picIcon.Image");
            picIcon.Location = new System.Drawing.Point(82, 9);
            picIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            picIcon.Name = "picIcon";
            picIcon.Size = new System.Drawing.Size(47, 46);
            picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picIcon.TabIndex = 14;
            picIcon.TabStop = false;
            // 
            // rtbError
            // 
            rtbError.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            rtbError.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            rtbError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            rtbError.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            rtbError.Location = new System.Drawing.Point(12, 31);
            rtbError.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rtbError.Name = "rtbError";
            rtbError.ReadOnly = true;
            rtbError.Size = new System.Drawing.Size(570, 195);
            rtbError.TabIndex = 0;
            rtbError.Text = "";
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnClose.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnClose.Location = new System.Drawing.Point(520, 367);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(88, 27);
            btnClose.TabIndex = 16;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // grpReport
            // 
            grpReport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpReport.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpReport.Controls.Add(rtbError);
            grpReport.Controls.Add(lblErrorReport);
            grpReport.Controls.Add(lblHeaderReport);
            grpReport.Location = new System.Drawing.Point(10, 117);
            grpReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpReport.Name = "grpReport";
            grpReport.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpReport.Size = new System.Drawing.Size(597, 240);
            grpReport.TabIndex = 17;
            grpReport.TabStop = false;
            // 
            // lblErrorReport
            // 
            lblErrorReport.AutoSize = true;
            lblErrorReport.BackColor = System.Drawing.Color.Transparent;
            lblErrorReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            lblErrorReport.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblErrorReport.Location = new System.Drawing.Point(9, 10);
            lblErrorReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblErrorReport.Name = "lblErrorReport";
            lblErrorReport.Size = new System.Drawing.Size(74, 15);
            lblErrorReport.TabIndex = 13;
            lblErrorReport.Text = "Error Report";
            // 
            // lblHeaderReport
            // 
            lblHeaderReport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderReport.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblHeaderReport.Location = new System.Drawing.Point(-2, 1);
            lblHeaderReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderReport.Name = "lblHeaderReport";
            lblHeaderReport.Size = new System.Drawing.Size(601, 7);
            lblHeaderReport.TabIndex = 0;
            lblHeaderReport.Text = "   ";
            lblHeaderReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Location = new System.Drawing.Point(55, 94);
            lblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new System.Drawing.Size(464, 15);
            lblSubTitle.TabIndex = 18;
            lblSubTitle.Text = "For help investigating please report to @MirageUK on the forums of survivetheark.com";
            lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(196, 40);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(183, 15);
            label1.TabIndex = 19;
            label1.Text = "For more information see log file:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogFilePath
            // 
            lblLogFilePath.AutoSize = true;
            lblLogFilePath.LinkColor = System.Drawing.Color.White;
            lblLogFilePath.Location = new System.Drawing.Point(230, 66);
            lblLogFilePath.Name = "lblLogFilePath";
            lblLogFilePath.Size = new System.Drawing.Size(114, 15);
            lblLogFilePath.TabIndex = 21;
            lblLogFilePath.TabStop = true;
            lblLogFilePath.Text = "C:\\Example\\ASV.log";
            lblLogFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblLogFilePath.LinkClicked += lblLogFilePath_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(460, 9);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(47, 46);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // frmErrorReport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(623, 409);
            Controls.Add(pictureBox1);
            Controls.Add(lblLogFilePath);
            Controls.Add(label1);
            Controls.Add(lblSubTitle);
            Controls.Add(grpReport);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Controls.Add(picIcon);
            ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(639, 398);
            Name = "frmErrorReport";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Error Report";
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            grpReport.ResumeLayout(false);
            grpReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.RichTextBox rtbError;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Label lblErrorReport;
        private System.Windows.Forms.Label lblHeaderReport;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblLogFilePath;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.rtbError = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.lblErrorReport = new System.Windows.Forms.Label();
            this.lblHeaderReport = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(56, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 29);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Something went wrong...";
            // 
            // picIcon
            // 
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(9, 7);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(40, 40);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 14;
            this.picIcon.TabStop = false;
            // 
            // rtbError
            // 
            this.rtbError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbError.Location = new System.Drawing.Point(10, 27);
            this.rtbError.Name = "rtbError";
            this.rtbError.ReadOnly = true;
            this.rtbError.Size = new System.Drawing.Size(489, 152);
            this.rtbError.TabIndex = 0;
            this.rtbError.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.Location = new System.Drawing.Point(446, 275);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // grpReport
            // 
            this.grpReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReport.Controls.Add(this.rtbError);
            this.grpReport.Controls.Add(this.lblErrorReport);
            this.grpReport.Controls.Add(this.lblHeaderReport);
            this.grpReport.Location = new System.Drawing.Point(9, 75);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(512, 191);
            this.grpReport.TabIndex = 17;
            this.grpReport.TabStop = false;
            // 
            // lblErrorReport
            // 
            this.lblErrorReport.AutoSize = true;
            this.lblErrorReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorReport.ForeColor = System.Drawing.Color.DimGray;
            this.lblErrorReport.Location = new System.Drawing.Point(6, 7);
            this.lblErrorReport.Name = "lblErrorReport";
            this.lblErrorReport.Size = new System.Drawing.Size(74, 15);
            this.lblErrorReport.TabIndex = 13;
            this.lblErrorReport.Text = "Error Report";
            // 
            // lblHeaderReport
            // 
            this.lblHeaderReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderReport.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderReport.Location = new System.Drawing.Point(-2, 1);
            this.lblHeaderReport.Name = "lblHeaderReport";
            this.lblHeaderReport.Size = new System.Drawing.Size(515, 6);
            this.lblHeaderReport.TabIndex = 0;
            this.lblHeaderReport.Text = "   ";
            this.lblHeaderReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Location = new System.Drawing.Point(61, 46);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(459, 13);
            this.lblSubTitle.TabIndex = 18;
            this.lblSubTitle.Text = "If this problem persists please report to @MirageUK on www.survivetheark.com for " +
    "investigation.";
            // 
            // frmErrorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "frmErrorReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error Report";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.grpReport.ResumeLayout(false);
            this.grpReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
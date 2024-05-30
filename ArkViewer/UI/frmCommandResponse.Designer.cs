namespace ArkViewer.UI
{
    partial class frmCommandResponse
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
            grpReport = new System.Windows.Forms.GroupBox();
            rtbResponse = new System.Windows.Forms.RichTextBox();
            lblErrorReport = new System.Windows.Forms.Label();
            lblHeaderReport = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            grpReport.SuspendLayout();
            SuspendLayout();
            // 
            // grpReport
            // 
            grpReport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpReport.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpReport.Controls.Add(rtbResponse);
            grpReport.Controls.Add(lblErrorReport);
            grpReport.Controls.Add(lblHeaderReport);
            grpReport.Location = new System.Drawing.Point(13, 12);
            grpReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpReport.Name = "grpReport";
            grpReport.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpReport.Size = new System.Drawing.Size(438, 215);
            grpReport.TabIndex = 19;
            grpReport.TabStop = false;
            // 
            // rtbResponse
            // 
            rtbResponse.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            rtbResponse.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            rtbResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            rtbResponse.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            rtbResponse.Location = new System.Drawing.Point(13, 33);
            rtbResponse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rtbResponse.Name = "rtbResponse";
            rtbResponse.ReadOnly = true;
            rtbResponse.Size = new System.Drawing.Size(413, 163);
            rtbResponse.TabIndex = 0;
            rtbResponse.Text = "";
            // 
            // lblErrorReport
            // 
            lblErrorReport.AutoSize = true;
            lblErrorReport.BackColor = System.Drawing.Color.Transparent;
            lblErrorReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblErrorReport.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblErrorReport.Location = new System.Drawing.Point(10, 11);
            lblErrorReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblErrorReport.Name = "lblErrorReport";
            lblErrorReport.Size = new System.Drawing.Size(116, 15);
            lblErrorReport.TabIndex = 13;
            lblErrorReport.Text = "Server Response";
            // 
            // lblHeaderReport
            // 
            lblHeaderReport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderReport.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblHeaderReport.Location = new System.Drawing.Point(-1, 1);
            lblHeaderReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderReport.Name = "lblHeaderReport";
            lblHeaderReport.Size = new System.Drawing.Size(439, 9);
            lblHeaderReport.TabIndex = 0;
            lblHeaderReport.Text = "   ";
            lblHeaderReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnClose.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnClose.Location = new System.Drawing.Point(363, 239);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(88, 27);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // frmCommandResponse
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            ClientSize = new System.Drawing.Size(464, 278);
            Controls.Add(grpReport);
            Controls.Add(btnClose);
            ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            Name = "frmCommandResponse";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "RCON Server Response";
            grpReport.ResumeLayout(false);
            grpReport.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.RichTextBox rtbResponse;
        private System.Windows.Forms.Label lblErrorReport;
        private System.Windows.Forms.Label lblHeaderReport;
        private System.Windows.Forms.Button btnClose;
    }
}
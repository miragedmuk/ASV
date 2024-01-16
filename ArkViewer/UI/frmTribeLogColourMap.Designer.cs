
namespace ARKViewer
{
    partial class frmTribeLogColourMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTribeLogColourMap));
            lvwTextColours = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            btnSave = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            lblBackgroundColour = new System.Windows.Forms.Label();
            lblForegroundColour = new System.Windows.Forms.Label();
            pnlGameColour = new System.Windows.Forms.Panel();
            pnlCustomColour = new System.Windows.Forms.Panel();
            pnlBackground = new System.Windows.Forms.Panel();
            pnlForeground = new System.Windows.Forms.Panel();
            btnAddUpdate = new System.Windows.Forms.Button();
            lblTextColours = new System.Windows.Forms.Label();
            picIcon = new System.Windows.Forms.PictureBox();
            grpWrapper = new System.Windows.Forms.GroupBox();
            lblLogColourOptions = new System.Windows.Forms.Label();
            lblHeaderWrapper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            grpWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // lvwTextColours
            // 
            lvwTextColours.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwTextColours.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwTextColours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2 });
            lvwTextColours.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwTextColours.Location = new System.Drawing.Point(27, 233);
            lvwTextColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwTextColours.Name = "lvwTextColours";
            lvwTextColours.Size = new System.Drawing.Size(556, 287);
            lvwTextColours.TabIndex = 5;
            lvwTextColours.UseCompatibleStateImageBehavior = false;
            lvwTextColours.View = System.Windows.Forms.View.Details;
            lvwTextColours.SelectedIndexChanged += lvwTextColours_SelectedIndexChanged;
            lvwTextColours.Click += lvwTextColours_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Game Colour";
            columnHeader1.Width = 245;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Custom Colour";
            columnHeader2.Width = 205;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            btnSave.Location = new System.Drawing.Point(430, 600);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(88, 27);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            btnClose.Location = new System.Drawing.Point(525, 600);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(88, 27);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // lblBackgroundColour
            // 
            lblBackgroundColour.AutoSize = true;
            lblBackgroundColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblBackgroundColour.Location = new System.Drawing.Point(23, 62);
            lblBackgroundColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBackgroundColour.Name = "lblBackgroundColour";
            lblBackgroundColour.Size = new System.Drawing.Size(119, 13);
            lblBackgroundColour.TabIndex = 0;
            lblBackgroundColour.Text = "Background Colour:";
            // 
            // lblForegroundColour
            // 
            lblForegroundColour.AutoSize = true;
            lblForegroundColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblForegroundColour.Location = new System.Drawing.Point(23, 127);
            lblForegroundColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblForegroundColour.Name = "lblForegroundColour";
            lblForegroundColour.Size = new System.Drawing.Size(115, 13);
            lblForegroundColour.TabIndex = 2;
            lblForegroundColour.Text = "Foreground Colour:";
            // 
            // pnlGameColour
            // 
            pnlGameColour.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pnlGameColour.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            pnlGameColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlGameColour.Enabled = false;
            pnlGameColour.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            pnlGameColour.Location = new System.Drawing.Point(30, 526);
            pnlGameColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlGameColour.Name = "pnlGameColour";
            pnlGameColour.Size = new System.Drawing.Size(283, 34);
            pnlGameColour.TabIndex = 6;
            pnlGameColour.Click += pnlGameColour_Click;
            // 
            // pnlCustomColour
            // 
            pnlCustomColour.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlCustomColour.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            pnlCustomColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlCustomColour.Enabled = false;
            pnlCustomColour.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            pnlCustomColour.Location = new System.Drawing.Point(327, 526);
            pnlCustomColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlCustomColour.Name = "pnlCustomColour";
            pnlCustomColour.Size = new System.Drawing.Size(177, 34);
            pnlCustomColour.TabIndex = 7;
            pnlCustomColour.Click += pnlCustomColour_Click;
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = System.Drawing.Color.Black;
            pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlBackground.Location = new System.Drawing.Point(27, 83);
            pnlBackground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new System.Drawing.Size(292, 34);
            pnlBackground.TabIndex = 1;
            pnlBackground.Click += pnlBackground_Click;
            // 
            // pnlForeground
            // 
            pnlForeground.BackColor = System.Drawing.Color.Black;
            pnlForeground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlForeground.Location = new System.Drawing.Point(27, 149);
            pnlForeground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlForeground.Name = "pnlForeground";
            pnlForeground.Size = new System.Drawing.Size(292, 34);
            pnlForeground.TabIndex = 3;
            pnlForeground.Click += pnlForeground_Click;
            // 
            // btnAddUpdate
            // 
            btnAddUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnAddUpdate.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnAddUpdate.Enabled = false;
            btnAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddUpdate.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            btnAddUpdate.Location = new System.Drawing.Point(511, 526);
            btnAddUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddUpdate.Name = "btnAddUpdate";
            btnAddUpdate.Size = new System.Drawing.Size(70, 33);
            btnAddUpdate.TabIndex = 8;
            btnAddUpdate.Text = "UPDATE";
            btnAddUpdate.UseVisualStyleBackColor = false;
            btnAddUpdate.Click += btnAddUpdate_Click;
            // 
            // lblTextColours
            // 
            lblTextColours.AutoSize = true;
            lblTextColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTextColours.Location = new System.Drawing.Point(27, 215);
            lblTextColours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTextColours.Name = "lblTextColours";
            lblTextColours.Size = new System.Drawing.Size(78, 13);
            lblTextColours.TabIndex = 4;
            lblTextColours.Text = "Text Colours";
            // 
            // picIcon
            // 
            picIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            picIcon.Image = (System.Drawing.Image)resources.GetObject("picIcon.Image");
            picIcon.Location = new System.Drawing.Point(513, 21);
            picIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            picIcon.Name = "picIcon";
            picIcon.Size = new System.Drawing.Size(70, 57);
            picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picIcon.TabIndex = 37;
            picIcon.TabStop = false;
            // 
            // grpWrapper
            // 
            grpWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpWrapper.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            grpWrapper.Controls.Add(lblLogColourOptions);
            grpWrapper.Controls.Add(picIcon);
            grpWrapper.Controls.Add(lblHeaderWrapper);
            grpWrapper.Controls.Add(lblTextColours);
            grpWrapper.Controls.Add(lblBackgroundColour);
            grpWrapper.Controls.Add(btnAddUpdate);
            grpWrapper.Controls.Add(lvwTextColours);
            grpWrapper.Controls.Add(pnlForeground);
            grpWrapper.Controls.Add(lblForegroundColour);
            grpWrapper.Controls.Add(pnlBackground);
            grpWrapper.Controls.Add(pnlGameColour);
            grpWrapper.Controls.Add(pnlCustomColour);
            grpWrapper.Location = new System.Drawing.Point(13, 13);
            grpWrapper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpWrapper.Name = "grpWrapper";
            grpWrapper.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpWrapper.Size = new System.Drawing.Size(603, 579);
            grpWrapper.TabIndex = 0;
            grpWrapper.TabStop = false;
            // 
            // lblLogColourOptions
            // 
            lblLogColourOptions.AutoSize = true;
            lblLogColourOptions.BackColor = System.Drawing.Color.Transparent;
            lblLogColourOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblLogColourOptions.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblLogColourOptions.Location = new System.Drawing.Point(10, 14);
            lblLogColourOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLogColourOptions.Name = "lblLogColourOptions";
            lblLogColourOptions.Size = new System.Drawing.Size(130, 15);
            lblLogColourOptions.TabIndex = 1;
            lblLogColourOptions.Text = "Log Colour Options";
            lblLogColourOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderWrapper
            // 
            lblHeaderWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderWrapper.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderWrapper.Location = new System.Drawing.Point(0, 0);
            lblHeaderWrapper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderWrapper.Name = "lblHeaderWrapper";
            lblHeaderWrapper.Size = new System.Drawing.Size(606, 7);
            lblHeaderWrapper.TabIndex = 0;
            lblHeaderWrapper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmTribeLogColourMap
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(630, 640);
            Controls.Add(grpWrapper);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(604, 565);
            Name = "frmTribeLogColourMap";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Tribe Log Colour Options";
            FormClosed += frmTribeLogColourMap_FormClosed;
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            grpWrapper.ResumeLayout(false);
            grpWrapper.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView lvwTextColours;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBackgroundColour;
        private System.Windows.Forms.Label lblForegroundColour;
        private System.Windows.Forms.Panel pnlGameColour;
        private System.Windows.Forms.Panel pnlCustomColour;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlForeground;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Label lblTextColours;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.GroupBox grpWrapper;
        private System.Windows.Forms.Label lblLogColourOptions;
        private System.Windows.Forms.Label lblHeaderWrapper;
    }
}
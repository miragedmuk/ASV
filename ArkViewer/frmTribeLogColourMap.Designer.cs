
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
            this.lvwTextColours = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBackgroundColour = new System.Windows.Forms.Label();
            this.lblForegroundColour = new System.Windows.Forms.Label();
            this.pnlGameColour = new System.Windows.Forms.Panel();
            this.pnlCustomColour = new System.Windows.Forms.Panel();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlForeground = new System.Windows.Forms.Panel();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.lblTextColours = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.grpWrapper = new System.Windows.Forms.GroupBox();
            this.lblLogColourOptions = new System.Windows.Forms.Label();
            this.lblHeaderWrapper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.grpWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwTextColours
            // 
            this.lvwTextColours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwTextColours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwTextColours.HideSelection = false;
            this.lvwTextColours.Location = new System.Drawing.Point(23, 202);
            this.lvwTextColours.Name = "lvwTextColours";
            this.lvwTextColours.Size = new System.Drawing.Size(477, 249);
            this.lvwTextColours.TabIndex = 5;
            this.lvwTextColours.UseCompatibleStateImageBehavior = false;
            this.lvwTextColours.View = System.Windows.Forms.View.Details;
            this.lvwTextColours.SelectedIndexChanged += new System.EventHandler(this.lvwTextColours_SelectedIndexChanged);
            this.lvwTextColours.Click += new System.EventHandler(this.lvwTextColours_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Game Colour";
            this.columnHeader1.Width = 245;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Custom Colour";
            this.columnHeader2.Width = 205;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(369, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.Location = new System.Drawing.Point(450, 520);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblBackgroundColour
            // 
            this.lblBackgroundColour.AutoSize = true;
            this.lblBackgroundColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackgroundColour.Location = new System.Drawing.Point(20, 54);
            this.lblBackgroundColour.Name = "lblBackgroundColour";
            this.lblBackgroundColour.Size = new System.Drawing.Size(119, 13);
            this.lblBackgroundColour.TabIndex = 0;
            this.lblBackgroundColour.Text = "Background Colour:";
            // 
            // lblForegroundColour
            // 
            this.lblForegroundColour.AutoSize = true;
            this.lblForegroundColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForegroundColour.Location = new System.Drawing.Point(20, 110);
            this.lblForegroundColour.Name = "lblForegroundColour";
            this.lblForegroundColour.Size = new System.Drawing.Size(115, 13);
            this.lblForegroundColour.TabIndex = 2;
            this.lblForegroundColour.Text = "Foreground Colour:";
            // 
            // pnlGameColour
            // 
            this.pnlGameColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlGameColour.BackColor = System.Drawing.SystemColors.Control;
            this.pnlGameColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGameColour.Enabled = false;
            this.pnlGameColour.Location = new System.Drawing.Point(26, 456);
            this.pnlGameColour.Name = "pnlGameColour";
            this.pnlGameColour.Size = new System.Drawing.Size(243, 30);
            this.pnlGameColour.TabIndex = 6;
            this.pnlGameColour.Click += new System.EventHandler(this.pnlGameColour_Click);
            // 
            // pnlCustomColour
            // 
            this.pnlCustomColour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCustomColour.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCustomColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomColour.Enabled = false;
            this.pnlCustomColour.Location = new System.Drawing.Point(280, 456);
            this.pnlCustomColour.Name = "pnlCustomColour";
            this.pnlCustomColour.Size = new System.Drawing.Size(152, 30);
            this.pnlCustomColour.TabIndex = 7;
            this.pnlCustomColour.Click += new System.EventHandler(this.pnlCustomColour_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.Black;
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackground.Location = new System.Drawing.Point(23, 72);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(251, 30);
            this.pnlBackground.TabIndex = 1;
            this.pnlBackground.Click += new System.EventHandler(this.pnlBackground_Click);
            // 
            // pnlForeground
            // 
            this.pnlForeground.BackColor = System.Drawing.Color.Black;
            this.pnlForeground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForeground.Location = new System.Drawing.Point(23, 129);
            this.pnlForeground.Name = "pnlForeground";
            this.pnlForeground.Size = new System.Drawing.Size(251, 30);
            this.pnlForeground.TabIndex = 3;
            this.pnlForeground.Click += new System.EventHandler(this.pnlForeground_Click);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUpdate.Enabled = false;
            this.btnAddUpdate.Location = new System.Drawing.Point(438, 456);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(60, 29);
            this.btnAddUpdate.TabIndex = 8;
            this.btnAddUpdate.Text = "UPDATE";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // lblTextColours
            // 
            this.lblTextColours.AutoSize = true;
            this.lblTextColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextColours.Location = new System.Drawing.Point(23, 186);
            this.lblTextColours.Name = "lblTextColours";
            this.lblTextColours.Size = new System.Drawing.Size(78, 13);
            this.lblTextColours.TabIndex = 4;
            this.lblTextColours.Text = "Text Colours";
            // 
            // picIcon
            // 
            this.picIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(440, 18);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(60, 49);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 37;
            this.picIcon.TabStop = false;
            // 
            // grpWrapper
            // 
            this.grpWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpWrapper.Controls.Add(this.lblLogColourOptions);
            this.grpWrapper.Controls.Add(this.picIcon);
            this.grpWrapper.Controls.Add(this.lblHeaderWrapper);
            this.grpWrapper.Controls.Add(this.lblTextColours);
            this.grpWrapper.Controls.Add(this.lblBackgroundColour);
            this.grpWrapper.Controls.Add(this.btnAddUpdate);
            this.grpWrapper.Controls.Add(this.lvwTextColours);
            this.grpWrapper.Controls.Add(this.pnlForeground);
            this.grpWrapper.Controls.Add(this.lblForegroundColour);
            this.grpWrapper.Controls.Add(this.pnlBackground);
            this.grpWrapper.Controls.Add(this.pnlGameColour);
            this.grpWrapper.Controls.Add(this.pnlCustomColour);
            this.grpWrapper.Location = new System.Drawing.Point(11, 11);
            this.grpWrapper.Name = "grpWrapper";
            this.grpWrapper.Size = new System.Drawing.Size(517, 502);
            this.grpWrapper.TabIndex = 0;
            this.grpWrapper.TabStop = false;
            // 
            // lblLogColourOptions
            // 
            this.lblLogColourOptions.AutoSize = true;
            this.lblLogColourOptions.BackColor = System.Drawing.Color.Transparent;
            this.lblLogColourOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogColourOptions.Location = new System.Drawing.Point(9, 12);
            this.lblLogColourOptions.Name = "lblLogColourOptions";
            this.lblLogColourOptions.Size = new System.Drawing.Size(130, 15);
            this.lblLogColourOptions.TabIndex = 1;
            this.lblLogColourOptions.Text = "Log Colour Options";
            this.lblLogColourOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderWrapper
            // 
            this.lblHeaderWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderWrapper.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderWrapper.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderWrapper.Name = "lblHeaderWrapper";
            this.lblHeaderWrapper.Size = new System.Drawing.Size(519, 6);
            this.lblHeaderWrapper.TabIndex = 0;
            this.lblHeaderWrapper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmTribeLogColourMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(540, 555);
            this.Controls.Add(this.grpWrapper);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 495);
            this.Name = "frmTribeLogColourMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tribe Log Colour Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTribeLogColourMap_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.grpWrapper.ResumeLayout(false);
            this.grpWrapper.PerformLayout();
            this.ResumeLayout(false);

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
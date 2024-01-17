namespace ARKViewer
{
    partial class frmMarkerEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarkerEditor));
            picIcon = new System.Windows.Forms.PictureBox();
            lblName = new System.Windows.Forms.Label();
            lblBorderSize = new System.Windows.Forms.Label();
            lblBorderColour = new System.Windows.Forms.Label();
            lblBackgroundColour = new System.Windows.Forms.Label();
            lblIcon = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            udBorderSize = new System.Windows.Forms.NumericUpDown();
            udLat = new System.Windows.Forms.NumericUpDown();
            lblLat = new System.Windows.Forms.Label();
            udLon = new System.Windows.Forms.NumericUpDown();
            lblLon = new System.Windows.Forms.Label();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            btnSave = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            pnlBorderColour = new System.Windows.Forms.Panel();
            pnlBackgroundColour = new System.Windows.Forms.Panel();
            grpWrapper = new System.Windows.Forms.GroupBox();
            lblCategory = new System.Windows.Forms.Label();
            txtCategory = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            lblHeaderWrapper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udBorderSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udLat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udLon).BeginInit();
            grpWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // picIcon
            // 
            picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picIcon.Image = (System.Drawing.Image)resources.GetObject("picIcon.Image");
            picIcon.Location = new System.Drawing.Point(203, 351);
            picIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            picIcon.Name = "picIcon";
            picIcon.Size = new System.Drawing.Size(74, 74);
            picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picIcon.TabIndex = 2;
            picIcon.TabStop = false;
            picIcon.Click += picIcon_Click;
            // 
            // lblName
            // 
            lblName.BackColor = System.Drawing.SystemColors.Control;
            lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblName.ForeColor = System.Drawing.Color.DimGray;
            lblName.Location = new System.Drawing.Point(30, 105);
            lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(275, 17);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBorderSize
            // 
            lblBorderSize.BackColor = System.Drawing.SystemColors.Control;
            lblBorderSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblBorderSize.ForeColor = System.Drawing.Color.DimGray;
            lblBorderSize.Location = new System.Drawing.Point(34, 319);
            lblBorderSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBorderSize.Name = "lblBorderSize";
            lblBorderSize.Size = new System.Drawing.Size(129, 21);
            lblBorderSize.TabIndex = 14;
            lblBorderSize.Text = "Border Size";
            lblBorderSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBorderColour
            // 
            lblBorderColour.BackColor = System.Drawing.SystemColors.Control;
            lblBorderColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblBorderColour.ForeColor = System.Drawing.Color.DimGray;
            lblBorderColour.Location = new System.Drawing.Point(29, 174);
            lblBorderColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBorderColour.Name = "lblBorderColour";
            lblBorderColour.Size = new System.Drawing.Size(134, 21);
            lblBorderColour.TabIndex = 6;
            lblBorderColour.Text = "Border Colour";
            lblBorderColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBackgroundColour
            // 
            lblBackgroundColour.BackColor = System.Drawing.SystemColors.Control;
            lblBackgroundColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblBackgroundColour.ForeColor = System.Drawing.Color.DimGray;
            lblBackgroundColour.Location = new System.Drawing.Point(173, 174);
            lblBackgroundColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBackgroundColour.Name = "lblBackgroundColour";
            lblBackgroundColour.Size = new System.Drawing.Size(134, 21);
            lblBackgroundColour.TabIndex = 8;
            lblBackgroundColour.Text = "Background Colour";
            lblBackgroundColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIcon
            // 
            lblIcon.BackColor = System.Drawing.SystemColors.Control;
            lblIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblIcon.ForeColor = System.Drawing.Color.DimGray;
            lblIcon.Location = new System.Drawing.Point(203, 321);
            lblIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new System.Drawing.Size(74, 21);
            lblIcon.TabIndex = 16;
            lblIcon.Text = "Icon";
            lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            txtName.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtName.Location = new System.Drawing.Point(30, 128);
            txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(275, 17);
            txtName.TabIndex = 5;
            txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtName.Validating += txtName_Validating;
            // 
            // udBorderSize
            // 
            udBorderSize.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udBorderSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udBorderSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            udBorderSize.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udBorderSize.Location = new System.Drawing.Point(34, 347);
            udBorderSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udBorderSize.Name = "udBorderSize";
            udBorderSize.Size = new System.Drawing.Size(130, 18);
            udBorderSize.TabIndex = 15;
            udBorderSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // udLat
            // 
            udLat.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udLat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udLat.DecimalPlaces = 2;
            udLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            udLat.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udLat.Location = new System.Drawing.Point(34, 278);
            udLat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udLat.Name = "udLat";
            udLat.Size = new System.Drawing.Size(130, 18);
            udLat.TabIndex = 11;
            udLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            udLat.ValueChanged += udLat_ValueChanged;
            udLat.Enter += udLat_Enter;
            // 
            // lblLat
            // 
            lblLat.BackColor = System.Drawing.SystemColors.Control;
            lblLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblLat.ForeColor = System.Drawing.Color.DimGray;
            lblLat.Location = new System.Drawing.Point(30, 250);
            lblLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLat.Name = "lblLat";
            lblLat.Size = new System.Drawing.Size(133, 21);
            lblLat.TabIndex = 10;
            lblLat.Text = "Latitude";
            lblLat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // udLon
            // 
            udLon.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udLon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udLon.DecimalPlaces = 2;
            udLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            udLon.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udLon.Location = new System.Drawing.Point(176, 278);
            udLon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udLon.Name = "udLon";
            udLon.Size = new System.Drawing.Size(130, 18);
            udLon.TabIndex = 13;
            udLon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            udLon.Enter += udLon_Enter;
            // 
            // lblLon
            // 
            lblLon.BackColor = System.Drawing.SystemColors.Control;
            lblLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblLon.ForeColor = System.Drawing.Color.DimGray;
            lblLon.Location = new System.Drawing.Point(173, 250);
            lblLon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLon.Name = "lblLon";
            lblLon.Size = new System.Drawing.Size(133, 21);
            lblLon.TabIndex = 12;
            lblLon.Text = "Longitude";
            lblLon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnSave.Location = new System.Drawing.Point(169, 474);
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
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnClose.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnClose.Location = new System.Drawing.Point(264, 474);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(88, 27);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // pnlBorderColour
            // 
            pnlBorderColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlBorderColour.Location = new System.Drawing.Point(30, 203);
            pnlBorderColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlBorderColour.Name = "pnlBorderColour";
            pnlBorderColour.Size = new System.Drawing.Size(133, 31);
            pnlBorderColour.TabIndex = 7;
            pnlBorderColour.Click += pnlBorderColour_Click;
            // 
            // pnlBackgroundColour
            // 
            pnlBackgroundColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlBackgroundColour.Location = new System.Drawing.Point(173, 203);
            pnlBackgroundColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlBackgroundColour.Name = "pnlBackgroundColour";
            pnlBackgroundColour.Size = new System.Drawing.Size(134, 31);
            pnlBackgroundColour.TabIndex = 9;
            pnlBackgroundColour.Click += pnlBackgroundColour_Click;
            // 
            // grpWrapper
            // 
            grpWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpWrapper.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpWrapper.Controls.Add(lblCategory);
            grpWrapper.Controls.Add(txtCategory);
            grpWrapper.Controls.Add(label2);
            grpWrapper.Controls.Add(picIcon);
            grpWrapper.Controls.Add(pnlBackgroundColour);
            grpWrapper.Controls.Add(lblIcon);
            grpWrapper.Controls.Add(lblHeaderWrapper);
            grpWrapper.Controls.Add(pnlBorderColour);
            grpWrapper.Controls.Add(lblName);
            grpWrapper.Controls.Add(lblBorderSize);
            grpWrapper.Controls.Add(udLon);
            grpWrapper.Controls.Add(lblBorderColour);
            grpWrapper.Controls.Add(lblLon);
            grpWrapper.Controls.Add(lblBackgroundColour);
            grpWrapper.Controls.Add(udLat);
            grpWrapper.Controls.Add(lblLat);
            grpWrapper.Controls.Add(txtName);
            grpWrapper.Controls.Add(udBorderSize);
            grpWrapper.Location = new System.Drawing.Point(14, 14);
            grpWrapper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpWrapper.Name = "grpWrapper";
            grpWrapper.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpWrapper.Size = new System.Drawing.Size(335, 453);
            grpWrapper.TabIndex = 0;
            grpWrapper.TabStop = false;
            // 
            // lblCategory
            // 
            lblCategory.BackColor = System.Drawing.SystemColors.Control;
            lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCategory.ForeColor = System.Drawing.Color.DimGray;
            lblCategory.Location = new System.Drawing.Point(30, 54);
            lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(275, 17);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCategory
            // 
            txtCategory.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            txtCategory.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtCategory.Location = new System.Drawing.Point(30, 75);
            txtCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new System.Drawing.Size(275, 17);
            txtCategory.TabIndex = 3;
            txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(12, 14);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 15);
            label2.TabIndex = 1;
            label2.Text = "Custom Marker";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderWrapper
            // 
            lblHeaderWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderWrapper.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblHeaderWrapper.Location = new System.Drawing.Point(0, 0);
            lblHeaderWrapper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderWrapper.Name = "lblHeaderWrapper";
            lblHeaderWrapper.Size = new System.Drawing.Size(337, 7);
            lblHeaderWrapper.TabIndex = 0;
            lblHeaderWrapper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMarkerEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(366, 515);
            Controls.Add(grpWrapper);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmMarkerEditor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Marker Editor";
            FormClosed += frmMarkerEditor_FormClosed;
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)udBorderSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)udLat).EndInit();
            ((System.ComponentModel.ISupportInitialize)udLon).EndInit();
            grpWrapper.ResumeLayout(false);
            grpWrapper.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBorderSize;
        private System.Windows.Forms.Label lblBorderColour;
        private System.Windows.Forms.Label lblBackgroundColour;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown udBorderSize;
        private System.Windows.Forms.NumericUpDown udLat;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.NumericUpDown udLon;
        private System.Windows.Forms.Label lblLon;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlBorderColour;
        private System.Windows.Forms.Panel pnlBackgroundColour;
        private System.Windows.Forms.GroupBox grpWrapper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeaderWrapper;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
    }
}
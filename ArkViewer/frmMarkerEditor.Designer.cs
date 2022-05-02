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
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBorderSize = new System.Windows.Forms.Label();
            this.lblBorderColour = new System.Windows.Forms.Label();
            this.lblBackgroundColour = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.udBorderSize = new System.Windows.Forms.NumericUpDown();
            this.udLat = new System.Windows.Forms.NumericUpDown();
            this.lblLat = new System.Windows.Forms.Label();
            this.udLon = new System.Windows.Forms.NumericUpDown();
            this.lblLon = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBorderColour = new System.Windows.Forms.Panel();
            this.pnlBackgroundColour = new System.Windows.Forms.Panel();
            this.grpWrapper = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeaderWrapper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBorderSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLon)).BeginInit();
            this.grpWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIcon.Image = global::ARKViewer.Properties.Resources.marker_0;
            this.picIcon.Location = new System.Drawing.Point(174, 304);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(64, 64);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 2;
            this.picIcon.TabStop = false;
            this.picIcon.Click += new System.EventHandler(this.picIcon_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.Control;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DimGray;
            this.lblName.Location = new System.Drawing.Point(23, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(239, 23);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBorderSize
            // 
            this.lblBorderSize.BackColor = System.Drawing.SystemColors.Control;
            this.lblBorderSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorderSize.ForeColor = System.Drawing.Color.DimGray;
            this.lblBorderSize.Location = new System.Drawing.Point(26, 278);
            this.lblBorderSize.Name = "lblBorderSize";
            this.lblBorderSize.Size = new System.Drawing.Size(114, 23);
            this.lblBorderSize.TabIndex = 14;
            this.lblBorderSize.Text = "Border Size";
            this.lblBorderSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBorderColour
            // 
            this.lblBorderColour.BackColor = System.Drawing.SystemColors.Control;
            this.lblBorderColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorderColour.ForeColor = System.Drawing.Color.DimGray;
            this.lblBorderColour.Location = new System.Drawing.Point(25, 151);
            this.lblBorderColour.Name = "lblBorderColour";
            this.lblBorderColour.Size = new System.Drawing.Size(115, 23);
            this.lblBorderColour.TabIndex = 6;
            this.lblBorderColour.Text = "Border Colour";
            this.lblBorderColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBackgroundColour
            // 
            this.lblBackgroundColour.BackColor = System.Drawing.SystemColors.Control;
            this.lblBackgroundColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackgroundColour.ForeColor = System.Drawing.Color.DimGray;
            this.lblBackgroundColour.Location = new System.Drawing.Point(148, 151);
            this.lblBackgroundColour.Name = "lblBackgroundColour";
            this.lblBackgroundColour.Size = new System.Drawing.Size(115, 23);
            this.lblBackgroundColour.TabIndex = 8;
            this.lblBackgroundColour.Text = "Background Colour";
            this.lblBackgroundColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIcon
            // 
            this.lblIcon.BackColor = System.Drawing.SystemColors.Control;
            this.lblIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.DimGray;
            this.lblIcon.Location = new System.Drawing.Point(171, 278);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(67, 23);
            this.lblIcon.TabIndex = 16;
            this.lblIcon.Text = "Icon";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(26, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 22);
            this.txtName.TabIndex = 5;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // udBorderSize
            // 
            this.udBorderSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udBorderSize.Location = new System.Drawing.Point(29, 301);
            this.udBorderSize.Name = "udBorderSize";
            this.udBorderSize.Size = new System.Drawing.Size(111, 22);
            this.udBorderSize.TabIndex = 15;
            this.udBorderSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // udLat
            // 
            this.udLat.DecimalPlaces = 2;
            this.udLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udLat.Location = new System.Drawing.Point(29, 241);
            this.udLat.Name = "udLat";
            this.udLat.Size = new System.Drawing.Size(111, 22);
            this.udLat.TabIndex = 11;
            this.udLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udLat.ValueChanged += new System.EventHandler(this.udLat_ValueChanged);
            this.udLat.Enter += new System.EventHandler(this.udLat_Enter);
            // 
            // lblLat
            // 
            this.lblLat.BackColor = System.Drawing.SystemColors.Control;
            this.lblLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.ForeColor = System.Drawing.Color.DimGray;
            this.lblLat.Location = new System.Drawing.Point(26, 217);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(114, 23);
            this.lblLat.TabIndex = 10;
            this.lblLat.Text = "Latitude";
            this.lblLat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // udLon
            // 
            this.udLon.DecimalPlaces = 2;
            this.udLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udLon.Location = new System.Drawing.Point(151, 241);
            this.udLon.Name = "udLon";
            this.udLon.Size = new System.Drawing.Size(111, 22);
            this.udLon.TabIndex = 13;
            this.udLon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udLon.Enter += new System.EventHandler(this.udLon_Enter);
            // 
            // lblLon
            // 
            this.lblLon.BackColor = System.Drawing.SystemColors.Control;
            this.lblLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLon.ForeColor = System.Drawing.Color.DimGray;
            this.lblLon.Location = new System.Drawing.Point(148, 217);
            this.lblLon.Name = "lblLon";
            this.lblLon.Size = new System.Drawing.Size(114, 23);
            this.lblLon.TabIndex = 12;
            this.lblLon.Text = "Longitude";
            this.lblLon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(145, 411);
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
            this.btnClose.Location = new System.Drawing.Point(226, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pnlBorderColour
            // 
            this.pnlBorderColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorderColour.Location = new System.Drawing.Point(26, 176);
            this.pnlBorderColour.Name = "pnlBorderColour";
            this.pnlBorderColour.Size = new System.Drawing.Size(114, 27);
            this.pnlBorderColour.TabIndex = 7;
            this.pnlBorderColour.Click += new System.EventHandler(this.pnlBorderColour_Click);
            // 
            // pnlBackgroundColour
            // 
            this.pnlBackgroundColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackgroundColour.Location = new System.Drawing.Point(148, 176);
            this.pnlBackgroundColour.Name = "pnlBackgroundColour";
            this.pnlBackgroundColour.Size = new System.Drawing.Size(115, 27);
            this.pnlBackgroundColour.TabIndex = 9;
            this.pnlBackgroundColour.Click += new System.EventHandler(this.pnlBackgroundColour_Click);
            // 
            // grpWrapper
            // 
            this.grpWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpWrapper.Controls.Add(this.lblCategory);
            this.grpWrapper.Controls.Add(this.txtCategory);
            this.grpWrapper.Controls.Add(this.label2);
            this.grpWrapper.Controls.Add(this.picIcon);
            this.grpWrapper.Controls.Add(this.pnlBackgroundColour);
            this.grpWrapper.Controls.Add(this.lblIcon);
            this.grpWrapper.Controls.Add(this.lblHeaderWrapper);
            this.grpWrapper.Controls.Add(this.pnlBorderColour);
            this.grpWrapper.Controls.Add(this.lblName);
            this.grpWrapper.Controls.Add(this.lblBorderSize);
            this.grpWrapper.Controls.Add(this.udLon);
            this.grpWrapper.Controls.Add(this.lblBorderColour);
            this.grpWrapper.Controls.Add(this.lblLon);
            this.grpWrapper.Controls.Add(this.lblBackgroundColour);
            this.grpWrapper.Controls.Add(this.udLat);
            this.grpWrapper.Controls.Add(this.lblLat);
            this.grpWrapper.Controls.Add(this.txtName);
            this.grpWrapper.Controls.Add(this.udBorderSize);
            this.grpWrapper.Location = new System.Drawing.Point(12, 12);
            this.grpWrapper.Name = "grpWrapper";
            this.grpWrapper.Size = new System.Drawing.Size(287, 393);
            this.grpWrapper.TabIndex = 0;
            this.grpWrapper.TabStop = false;
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.SystemColors.Control;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategory.Location = new System.Drawing.Point(24, 40);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(239, 23);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(27, 65);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(236, 22);
            this.txtCategory.TabIndex = 3;
            this.txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Custom Marker";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderWrapper
            // 
            this.lblHeaderWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderWrapper.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderWrapper.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderWrapper.Name = "lblHeaderWrapper";
            this.lblHeaderWrapper.Size = new System.Drawing.Size(289, 6);
            this.lblHeaderWrapper.TabIndex = 0;
            this.lblHeaderWrapper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMarkerEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(314, 446);
            this.Controls.Add(this.grpWrapper);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMarkerEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marker Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMarkerEditor_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBorderSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLon)).EndInit();
            this.grpWrapper.ResumeLayout(false);
            this.grpWrapper.PerformLayout();
            this.ResumeLayout(false);

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
namespace ARKViewer
{
    partial class frmItemClassMap
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
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.btnCcancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.grpWrapper = new System.Windows.Forms.GroupBox();
            this.lblItemDisplayDetails = new System.Windows.Forms.Label();
            this.lblHeaderWrapper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.grpWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayName.Location = new System.Drawing.Point(15, 132);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(291, 22);
            this.txtDisplayName.TabIndex = 3;
            this.txtDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDisplayName.Validating += new System.ComponentModel.CancelEventHandler(this.txtDisplayName_Validating);
            // 
            // txtClassName
            // 
            this.txtClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.Location = new System.Drawing.Point(17, 73);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(291, 22);
            this.txtClassName.TabIndex = 1;
            this.txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplayName.BackColor = System.Drawing.SystemColors.Control;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.ForeColor = System.Drawing.Color.DimGray;
            this.lblDisplayName.Location = new System.Drawing.Point(15, 106);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(293, 23);
            this.lblDisplayName.TabIndex = 2;
            this.lblDisplayName.Text = "Display Name";
            this.lblDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClassName
            // 
            this.lblClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClassName.BackColor = System.Drawing.SystemColors.Control;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.DimGray;
            this.lblClassName.Location = new System.Drawing.Point(14, 44);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(294, 23);
            this.lblClassName.TabIndex = 0;
            this.lblClassName.Text = "Class Name";
            this.lblClassName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCcancel
            // 
            this.btnCcancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCcancel.Location = new System.Drawing.Point(266, 378);
            this.btnCcancel.Name = "btnCcancel";
            this.btnCcancel.Size = new System.Drawing.Size(75, 23);
            this.btnCcancel.TabIndex = 2;
            this.btnCcancel.Text = "Close";
            this.btnCcancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(185, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(15, 196);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(291, 22);
            this.txtCategory.TabIndex = 5;
            this.txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCategory.Validating += new System.ComponentModel.CancelEventHandler(this.txtCategory_Validating);
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.BackColor = System.Drawing.SystemColors.Control;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategory.Location = new System.Drawing.Point(15, 170);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(293, 23);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIcon
            // 
            this.lblIcon.BackColor = System.Drawing.SystemColors.Control;
            this.lblIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.DimGray;
            this.lblIcon.Location = new System.Drawing.Point(12, 233);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(294, 23);
            this.lblIcon.TabIndex = 6;
            this.lblIcon.Text = "Icon";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picIcon
            // 
            this.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIcon.Image = global::ARKViewer.Properties.Resources.marker_0;
            this.picIcon.Location = new System.Drawing.Point(129, 259);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(60, 60);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 14;
            this.picIcon.TabStop = false;
            this.picIcon.Click += new System.EventHandler(this.picIcon_Click);
            // 
            // grpWrapper
            // 
            this.grpWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpWrapper.Controls.Add(this.lblItemDisplayDetails);
            this.grpWrapper.Controls.Add(this.lblIcon);
            this.grpWrapper.Controls.Add(this.lblHeaderWrapper);
            this.grpWrapper.Controls.Add(this.picIcon);
            this.grpWrapper.Controls.Add(this.lblClassName);
            this.grpWrapper.Controls.Add(this.txtCategory);
            this.grpWrapper.Controls.Add(this.lblDisplayName);
            this.grpWrapper.Controls.Add(this.lblCategory);
            this.grpWrapper.Controls.Add(this.txtClassName);
            this.grpWrapper.Controls.Add(this.txtDisplayName);
            this.grpWrapper.Location = new System.Drawing.Point(14, 7);
            this.grpWrapper.Name = "grpWrapper";
            this.grpWrapper.Size = new System.Drawing.Size(326, 362);
            this.grpWrapper.TabIndex = 0;
            this.grpWrapper.TabStop = false;
            // 
            // lblItemDisplayDetails
            // 
            this.lblItemDisplayDetails.AutoSize = true;
            this.lblItemDisplayDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblItemDisplayDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDisplayDetails.Location = new System.Drawing.Point(9, 17);
            this.lblItemDisplayDetails.Name = "lblItemDisplayDetails";
            this.lblItemDisplayDetails.Size = new System.Drawing.Size(135, 15);
            this.lblItemDisplayDetails.TabIndex = 1;
            this.lblItemDisplayDetails.Text = "Item Display Details";
            this.lblItemDisplayDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderWrapper
            // 
            this.lblHeaderWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderWrapper.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderWrapper.Location = new System.Drawing.Point(0, 2);
            this.lblHeaderWrapper.Name = "lblHeaderWrapper";
            this.lblHeaderWrapper.Size = new System.Drawing.Size(328, 6);
            this.lblHeaderWrapper.TabIndex = 0;
            this.lblHeaderWrapper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmItemClassMap
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCcancel;
            this.ClientSize = new System.Drawing.Size(354, 413);
            this.Controls.Add(this.grpWrapper);
            this.Controls.Add(this.btnCcancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItemClassMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Class Map Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmItemClassMap_FormClosed);
            this.Shown += new System.EventHandler(this.frmItemClassMap_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.grpWrapper.ResumeLayout(false);
            this.grpWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Button btnCcancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.GroupBox grpWrapper;
        private System.Windows.Forms.Label lblItemDisplayDetails;
        private System.Windows.Forms.Label lblHeaderWrapper;
    }
}
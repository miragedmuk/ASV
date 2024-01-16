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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemClassMap));
            txtDisplayName = new System.Windows.Forms.TextBox();
            txtClassName = new System.Windows.Forms.TextBox();
            lblDisplayName = new System.Windows.Forms.Label();
            lblClassName = new System.Windows.Forms.Label();
            btnCcancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            txtCategory = new System.Windows.Forms.TextBox();
            lblCategory = new System.Windows.Forms.Label();
            lblIcon = new System.Windows.Forms.Label();
            picIcon = new System.Windows.Forms.PictureBox();
            grpWrapper = new System.Windows.Forms.GroupBox();
            lblItemDisplayDetails = new System.Windows.Forms.Label();
            lblHeaderWrapper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            grpWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // txtDisplayName
            // 
            txtDisplayName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDisplayName.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDisplayName.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtDisplayName.Location = new System.Drawing.Point(19, 146);
            txtDisplayName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new System.Drawing.Size(339, 17);
            txtDisplayName.TabIndex = 3;
            txtDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtDisplayName.Validating += txtDisplayName_Validating;
            // 
            // txtClassName
            // 
            txtClassName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtClassName.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtClassName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtClassName.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtClassName.Location = new System.Drawing.Point(19, 85);
            txtClassName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new System.Drawing.Size(339, 17);
            txtClassName.TabIndex = 1;
            txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDisplayName
            // 
            lblDisplayName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDisplayName.BackColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDisplayName.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            lblDisplayName.Location = new System.Drawing.Point(20, 122);
            lblDisplayName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new System.Drawing.Size(337, 20);
            lblDisplayName.TabIndex = 2;
            lblDisplayName.Text = "Display Name";
            lblDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClassName
            // 
            lblClassName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblClassName.BackColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblClassName.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            lblClassName.Location = new System.Drawing.Point(20, 61);
            lblClassName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new System.Drawing.Size(337, 20);
            lblClassName.TabIndex = 0;
            lblClassName.Text = "Class Name";
            lblClassName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCcancel
            // 
            btnCcancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCcancel.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnCcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCcancel.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnCcancel.Location = new System.Drawing.Point(310, 436);
            btnCcancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCcancel.Name = "btnCcancel";
            btnCcancel.Size = new System.Drawing.Size(88, 27);
            btnCcancel.TabIndex = 2;
            btnCcancel.Text = "Close";
            btnCcancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnSave.Location = new System.Drawing.Point(216, 436);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(88, 27);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtCategory
            // 
            txtCategory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCategory.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCategory.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtCategory.Location = new System.Drawing.Point(19, 220);
            txtCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new System.Drawing.Size(339, 17);
            txtCategory.TabIndex = 5;
            txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtCategory.Validating += txtCategory_Validating;
            // 
            // lblCategory
            // 
            lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCategory.BackColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCategory.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            lblCategory.Location = new System.Drawing.Point(20, 196);
            lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(337, 20);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category";
            lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIcon
            // 
            lblIcon.BackColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblIcon.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            lblIcon.Location = new System.Drawing.Point(20, 269);
            lblIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new System.Drawing.Size(337, 20);
            lblIcon.TabIndex = 6;
            lblIcon.Text = "Icon";
            lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picIcon
            // 
            picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picIcon.Image = (System.Drawing.Image)resources.GetObject("picIcon.Image");
            picIcon.Location = new System.Drawing.Point(150, 299);
            picIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            picIcon.Name = "picIcon";
            picIcon.Size = new System.Drawing.Size(70, 69);
            picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picIcon.TabIndex = 14;
            picIcon.TabStop = false;
            picIcon.Click += picIcon_Click;
            // 
            // grpWrapper
            // 
            grpWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpWrapper.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            grpWrapper.Controls.Add(lblItemDisplayDetails);
            grpWrapper.Controls.Add(lblIcon);
            grpWrapper.Controls.Add(lblHeaderWrapper);
            grpWrapper.Controls.Add(picIcon);
            grpWrapper.Controls.Add(lblClassName);
            grpWrapper.Controls.Add(txtCategory);
            grpWrapper.Controls.Add(lblDisplayName);
            grpWrapper.Controls.Add(lblCategory);
            grpWrapper.Controls.Add(txtClassName);
            grpWrapper.Controls.Add(txtDisplayName);
            grpWrapper.Location = new System.Drawing.Point(16, 8);
            grpWrapper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpWrapper.Name = "grpWrapper";
            grpWrapper.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpWrapper.Size = new System.Drawing.Size(380, 418);
            grpWrapper.TabIndex = 0;
            grpWrapper.TabStop = false;
            // 
            // lblItemDisplayDetails
            // 
            lblItemDisplayDetails.AutoSize = true;
            lblItemDisplayDetails.BackColor = System.Drawing.Color.Transparent;
            lblItemDisplayDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblItemDisplayDetails.Location = new System.Drawing.Point(10, 20);
            lblItemDisplayDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblItemDisplayDetails.Name = "lblItemDisplayDetails";
            lblItemDisplayDetails.Size = new System.Drawing.Size(135, 15);
            lblItemDisplayDetails.TabIndex = 1;
            lblItemDisplayDetails.Text = "Item Display Details";
            lblItemDisplayDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderWrapper
            // 
            lblHeaderWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderWrapper.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderWrapper.Location = new System.Drawing.Point(0, 2);
            lblHeaderWrapper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderWrapper.Name = "lblHeaderWrapper";
            lblHeaderWrapper.Size = new System.Drawing.Size(383, 7);
            lblHeaderWrapper.TabIndex = 0;
            lblHeaderWrapper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmItemClassMap
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            CancelButton = btnCcancel;
            ClientSize = new System.Drawing.Size(413, 477);
            Controls.Add(grpWrapper);
            Controls.Add(btnCcancel);
            Controls.Add(btnSave);
            ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmItemClassMap";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Item Class Map Editor";
            FormClosed += frmItemClassMap_FormClosed;
            Shown += frmItemClassMap_Shown;
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            grpWrapper.ResumeLayout(false);
            grpWrapper.PerformLayout();
            ResumeLayout(false);
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
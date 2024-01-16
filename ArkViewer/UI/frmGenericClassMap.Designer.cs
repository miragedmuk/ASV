namespace ARKViewer
{
    partial class frmGenericClassMap
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
            btnCcancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            txtClassName = new System.Windows.Forms.TextBox();
            lblDisplayName = new System.Windows.Forms.Label();
            lblClassName = new System.Windows.Forms.Label();
            txtDisplayName = new System.Windows.Forms.TextBox();
            grpWrapper = new System.Windows.Forms.GroupBox();
            lblClassDisplayName = new System.Windows.Forms.Label();
            lblHeaderWrapper = new System.Windows.Forms.Label();
            grpWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // btnCcancel
            // 
            btnCcancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCcancel.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnCcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCcancel.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnCcancel.Location = new System.Drawing.Point(302, 237);
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
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnSave.Location = new System.Drawing.Point(208, 237);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(88, 27);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtClassName
            // 
            txtClassName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtClassName.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtClassName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtClassName.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtClassName.Location = new System.Drawing.Point(28, 78);
            txtClassName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new System.Drawing.Size(320, 17);
            txtClassName.TabIndex = 1;
            txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtClassName.Validating += txtClassName_Validating;
            // 
            // lblDisplayName
            // 
            lblDisplayName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDisplayName.BackColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDisplayName.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            lblDisplayName.Location = new System.Drawing.Point(28, 119);
            lblDisplayName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new System.Drawing.Size(320, 27);
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
            lblClassName.Location = new System.Drawing.Point(28, 47);
            lblClassName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new System.Drawing.Size(320, 27);
            lblClassName.TabIndex = 0;
            lblClassName.Text = "Class Name";
            lblClassName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDisplayName
            // 
            txtDisplayName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDisplayName.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDisplayName.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtDisplayName.Location = new System.Drawing.Point(28, 149);
            txtDisplayName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new System.Drawing.Size(320, 17);
            txtDisplayName.TabIndex = 3;
            txtDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpWrapper
            // 
            grpWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpWrapper.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            grpWrapper.Controls.Add(lblClassDisplayName);
            grpWrapper.Controls.Add(txtDisplayName);
            grpWrapper.Controls.Add(lblHeaderWrapper);
            grpWrapper.Controls.Add(txtClassName);
            grpWrapper.Controls.Add(lblClassName);
            grpWrapper.Controls.Add(lblDisplayName);
            grpWrapper.Location = new System.Drawing.Point(12, 11);
            grpWrapper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpWrapper.Name = "grpWrapper";
            grpWrapper.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpWrapper.Size = new System.Drawing.Size(377, 217);
            grpWrapper.TabIndex = 0;
            grpWrapper.TabStop = false;
            // 
            // lblClassDisplayName
            // 
            lblClassDisplayName.AutoSize = true;
            lblClassDisplayName.BackColor = System.Drawing.Color.Transparent;
            lblClassDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblClassDisplayName.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblClassDisplayName.Location = new System.Drawing.Point(9, 18);
            lblClassDisplayName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblClassDisplayName.Name = "lblClassDisplayName";
            lblClassDisplayName.Size = new System.Drawing.Size(135, 15);
            lblClassDisplayName.TabIndex = 1;
            lblClassDisplayName.Text = "Class Display Name";
            lblClassDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderWrapper
            // 
            lblHeaderWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderWrapper.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderWrapper.Location = new System.Drawing.Point(0, 1);
            lblHeaderWrapper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderWrapper.Name = "lblHeaderWrapper";
            lblHeaderWrapper.Size = new System.Drawing.Size(379, 7);
            lblHeaderWrapper.TabIndex = 0;
            lblHeaderWrapper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmGenericClassMap
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            CancelButton = btnCcancel;
            ClientSize = new System.Drawing.Size(406, 277);
            Controls.Add(grpWrapper);
            Controls.Add(btnCcancel);
            Controls.Add(btnSave);
            ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(266, 300);
            Name = "frmGenericClassMap";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Display Name Editor";
            FormClosed += frmGenericClassMap_FormClosed;
            Load += frmGenericClassMap_Load;
            Shown += frmGenericClassMap_Shown;
            Enter += frmGenericClassMap_Enter;
            grpWrapper.ResumeLayout(false);
            grpWrapper.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCcancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.GroupBox grpWrapper;
        private System.Windows.Forms.Label lblClassDisplayName;
        private System.Windows.Forms.Label lblHeaderWrapper;
    }
}
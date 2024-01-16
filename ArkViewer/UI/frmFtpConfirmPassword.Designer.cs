
namespace ARKViewer
{
    partial class frmFtpConfirmPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFtpConfirmPassword));
            chkPasswordVisibility = new System.Windows.Forms.CheckBox();
            txtFTPPassword = new System.Windows.Forms.TextBox();
            btnConfirm = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            grpWrapper = new System.Windows.Forms.GroupBox();
            lblConfirmPassword = new System.Windows.Forms.Label();
            lblHeaderWrapper = new System.Windows.Forms.Label();
            grpWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // chkPasswordVisibility
            // 
            chkPasswordVisibility.Appearance = System.Windows.Forms.Appearance.Button;
            chkPasswordVisibility.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            chkPasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkPasswordVisibility.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            chkPasswordVisibility.Image = (System.Drawing.Image)resources.GetObject("chkPasswordVisibility.Image");
            chkPasswordVisibility.Location = new System.Drawing.Point(270, 53);
            chkPasswordVisibility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkPasswordVisibility.Name = "chkPasswordVisibility";
            chkPasswordVisibility.Size = new System.Drawing.Size(23, 23);
            chkPasswordVisibility.TabIndex = 2;
            chkPasswordVisibility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkPasswordVisibility.UseVisualStyleBackColor = false;
            chkPasswordVisibility.CheckedChanged += chkPasswordVisibility_CheckedChanged;
            // 
            // txtFTPPassword
            // 
            txtFTPPassword.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtFTPPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFTPPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFTPPassword.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtFTPPassword.Location = new System.Drawing.Point(20, 54);
            txtFTPPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFTPPassword.Name = "txtFTPPassword";
            txtFTPPassword.PasswordChar = '●';
            txtFTPPassword.Size = new System.Drawing.Size(249, 20);
            txtFTPPassword.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnConfirm.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnConfirm.Location = new System.Drawing.Point(144, 134);
            btnConfirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(88, 27);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnCancel.Location = new System.Drawing.Point(238, 134);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(88, 27);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // grpWrapper
            // 
            grpWrapper.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpWrapper.Controls.Add(lblConfirmPassword);
            grpWrapper.Controls.Add(lblHeaderWrapper);
            grpWrapper.Controls.Add(txtFTPPassword);
            grpWrapper.Controls.Add(chkPasswordVisibility);
            grpWrapper.Location = new System.Drawing.Point(14, 14);
            grpWrapper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpWrapper.Name = "grpWrapper";
            grpWrapper.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpWrapper.Size = new System.Drawing.Size(312, 113);
            grpWrapper.TabIndex = 0;
            grpWrapper.TabStop = false;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblConfirmPassword.Location = new System.Drawing.Point(16, 18);
            lblConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new System.Drawing.Size(123, 15);
            lblConfirmPassword.TabIndex = 0;
            lblConfirmPassword.Text = "Confirm Password";
            lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderWrapper
            // 
            lblHeaderWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderWrapper.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderWrapper.Location = new System.Drawing.Point(0, 0);
            lblHeaderWrapper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderWrapper.Name = "lblHeaderWrapper";
            lblHeaderWrapper.Size = new System.Drawing.Size(314, 8);
            lblHeaderWrapper.TabIndex = 0;
            lblHeaderWrapper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmFtpConfirmPassword
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(341, 175);
            Controls.Add(grpWrapper);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmFtpConfirmPassword";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Password Confirmation";
            grpWrapper.ResumeLayout(false);
            grpWrapper.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.CheckBox chkPasswordVisibility;
        private System.Windows.Forms.TextBox txtFTPPassword;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpWrapper;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblHeaderWrapper;
    }
}
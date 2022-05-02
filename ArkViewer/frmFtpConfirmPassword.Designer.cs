
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
            this.chkPasswordVisibility = new System.Windows.Forms.CheckBox();
            this.txtFTPPassword = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpWrapper = new System.Windows.Forms.GroupBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblHeaderWrapper = new System.Windows.Forms.Label();
            this.grpWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkPasswordVisibility
            // 
            this.chkPasswordVisibility.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPasswordVisibility.Image = ((System.Drawing.Image)(resources.GetObject("chkPasswordVisibility.Image")));
            this.chkPasswordVisibility.Location = new System.Drawing.Point(231, 46);
            this.chkPasswordVisibility.Name = "chkPasswordVisibility";
            this.chkPasswordVisibility.Size = new System.Drawing.Size(20, 20);
            this.chkPasswordVisibility.TabIndex = 2;
            this.chkPasswordVisibility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPasswordVisibility.UseVisualStyleBackColor = false;
            this.chkPasswordVisibility.CheckedChanged += new System.EventHandler(this.chkPasswordVisibility_CheckedChanged);
            // 
            // txtFTPPassword
            // 
            this.txtFTPPassword.Location = new System.Drawing.Point(17, 46);
            this.txtFTPPassword.Name = "txtFTPPassword";
            this.txtFTPPassword.PasswordChar = '●';
            this.txtFTPPassword.Size = new System.Drawing.Size(214, 20);
            this.txtFTPPassword.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(123, 116);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(204, 116);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpWrapper
            // 
            this.grpWrapper.Controls.Add(this.lblConfirmPassword);
            this.grpWrapper.Controls.Add(this.lblHeaderWrapper);
            this.grpWrapper.Controls.Add(this.txtFTPPassword);
            this.grpWrapper.Controls.Add(this.chkPasswordVisibility);
            this.grpWrapper.Location = new System.Drawing.Point(12, 12);
            this.grpWrapper.Name = "grpWrapper";
            this.grpWrapper.Size = new System.Drawing.Size(267, 98);
            this.grpWrapper.TabIndex = 0;
            this.grpWrapper.TabStop = false;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblConfirmPassword.Location = new System.Drawing.Point(14, 16);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(123, 15);
            this.lblConfirmPassword.TabIndex = 0;
            this.lblConfirmPassword.Text = "Confirm Password";
            this.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderWrapper
            // 
            this.lblHeaderWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderWrapper.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderWrapper.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderWrapper.Name = "lblHeaderWrapper";
            this.lblHeaderWrapper.Size = new System.Drawing.Size(269, 6);
            this.lblHeaderWrapper.TabIndex = 0;
            this.lblHeaderWrapper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmFtpConfirmPassword
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(292, 152);
            this.Controls.Add(this.grpWrapper);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFtpConfirmPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Confirmation";
            this.grpWrapper.ResumeLayout(false);
            this.grpWrapper.PerformLayout();
            this.ResumeLayout(false);

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
namespace ArkViewer.UI
{
    partial class frmCommandInput
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
            grpWrapper = new System.Windows.Forms.GroupBox();
            lblParamName = new System.Windows.Forms.Label();
            lblHeaderWrapper = new System.Windows.Forms.Label();
            txtEnteredValue = new System.Windows.Forms.TextBox();
            btnCancel = new System.Windows.Forms.Button();
            btnAccept = new System.Windows.Forms.Button();
            grpWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // grpWrapper
            // 
            grpWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpWrapper.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpWrapper.Controls.Add(lblParamName);
            grpWrapper.Controls.Add(lblHeaderWrapper);
            grpWrapper.Controls.Add(txtEnteredValue);
            grpWrapper.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            grpWrapper.Location = new System.Drawing.Point(9, 5);
            grpWrapper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpWrapper.Name = "grpWrapper";
            grpWrapper.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpWrapper.Size = new System.Drawing.Size(423, 109);
            grpWrapper.TabIndex = 3;
            grpWrapper.TabStop = false;
            // 
            // lblParamName
            // 
            lblParamName.AutoSize = true;
            lblParamName.BackColor = System.Drawing.Color.Transparent;
            lblParamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblParamName.Location = new System.Drawing.Point(25, 15);
            lblParamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblParamName.Name = "lblParamName";
            lblParamName.Size = new System.Drawing.Size(132, 15);
            lblParamName.TabIndex = 1;
            lblParamName.Text = "<Parameter Name>";
            lblParamName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderWrapper
            // 
            lblHeaderWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderWrapper.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblHeaderWrapper.Location = new System.Drawing.Point(-1, 2);
            lblHeaderWrapper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderWrapper.Name = "lblHeaderWrapper";
            lblHeaderWrapper.Size = new System.Drawing.Size(424, 7);
            lblHeaderWrapper.TabIndex = 0;
            lblHeaderWrapper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEnteredValue
            // 
            txtEnteredValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtEnteredValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            txtEnteredValue.Location = new System.Drawing.Point(26, 53);
            txtEnteredValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtEnteredValue.Name = "txtEnteredValue";
            txtEnteredValue.Size = new System.Drawing.Size(372, 22);
            txtEnteredValue.TabIndex = 1;
            txtEnteredValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCancel.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnCancel.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnCancel.Location = new System.Drawing.Point(344, 124);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(88, 27);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAccept
            // 
            btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnAccept.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            btnAccept.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnAccept.Location = new System.Drawing.Point(250, 124);
            btnAccept.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new System.Drawing.Size(88, 27);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnSave_Click;
            // 
            // frmCommandInput
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(441, 162);
            Controls.Add(grpWrapper);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCommandInput";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Command Option";
            grpWrapper.ResumeLayout(false);
            grpWrapper.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpWrapper;
        private System.Windows.Forms.Label lblParamName;
        private System.Windows.Forms.Label lblHeaderWrapper;
        private System.Windows.Forms.TextBox txtEnteredValue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
    }
}
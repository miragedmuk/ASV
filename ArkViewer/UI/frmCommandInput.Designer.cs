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
            lblParamDescription = new System.Windows.Forms.Label();
            lblParamName = new System.Windows.Forms.Label();
            lblHeaderWrapper = new System.Windows.Forms.Label();
            txtEnteredValue = new System.Windows.Forms.TextBox();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            grpWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // grpWrapper
            // 
            grpWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpWrapper.Controls.Add(lblParamDescription);
            grpWrapper.Controls.Add(lblParamName);
            grpWrapper.Controls.Add(lblHeaderWrapper);
            grpWrapper.Controls.Add(txtEnteredValue);
            grpWrapper.Location = new System.Drawing.Point(9, 5);
            grpWrapper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpWrapper.Name = "grpWrapper";
            grpWrapper.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpWrapper.Size = new System.Drawing.Size(316, 108);
            grpWrapper.TabIndex = 3;
            grpWrapper.TabStop = false;
            // 
            // lblParamDescription
            // 
            lblParamDescription.BackColor = System.Drawing.Color.Transparent;
            lblParamDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblParamDescription.Location = new System.Drawing.Point(25, 34);
            lblParamDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblParamDescription.Name = "lblParamDescription";
            lblParamDescription.Size = new System.Drawing.Size(266, 37);
            lblParamDescription.TabIndex = 2;
            lblParamDescription.Text = "<Parameter Description>";
            // 
            // lblParamName
            // 
            lblParamName.AutoSize = true;
            lblParamName.BackColor = System.Drawing.Color.Transparent;
            lblParamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            lblHeaderWrapper.BackColor = System.Drawing.Color.Aqua;
            lblHeaderWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderWrapper.Location = new System.Drawing.Point(1, 2);
            lblHeaderWrapper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderWrapper.Name = "lblHeaderWrapper";
            lblHeaderWrapper.Size = new System.Drawing.Size(497, 7);
            lblHeaderWrapper.TabIndex = 0;
            lblHeaderWrapper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEnteredValue
            // 
            txtEnteredValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtEnteredValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEnteredValue.Location = new System.Drawing.Point(26, 70);
            txtEnteredValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtEnteredValue.Name = "txtEnteredValue";
            txtEnteredValue.Size = new System.Drawing.Size(265, 22);
            txtEnteredValue.TabIndex = 1;
            txtEnteredValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(237, 123);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(88, 27);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.Location = new System.Drawing.Point(143, 123);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(88, 27);
            btnSave.TabIndex = 4;
            btnSave.Text = "Accept";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmCommandInput
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(334, 161);
            Controls.Add(grpWrapper);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "frmCommandInput";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Command Option";
            grpWrapper.ResumeLayout(false);
            grpWrapper.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpWrapper;
        private System.Windows.Forms.Label lblParamDescription;
        private System.Windows.Forms.Label lblParamName;
        private System.Windows.Forms.Label lblHeaderWrapper;
        private System.Windows.Forms.TextBox txtEnteredValue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
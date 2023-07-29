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
            this.btnCcancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.grpWrapper = new System.Windows.Forms.GroupBox();
            this.lblClassDisplayName = new System.Windows.Forms.Label();
            this.lblHeaderWrapper = new System.Windows.Forms.Label();
            this.grpWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCcancel
            // 
            this.btnCcancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCcancel.Location = new System.Drawing.Point(259, 205);
            this.btnCcancel.Name = "btnCcancel";
            this.btnCcancel.Size = new System.Drawing.Size(75, 23);
            this.btnCcancel.TabIndex = 2;
            this.btnCcancel.Text = "Close";
            this.btnCcancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(178, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.Location = new System.Drawing.Point(23, 70);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(274, 22);
            this.txtClassName.TabIndex = 1;
            this.txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClassName.Validating += new System.ComponentModel.CancelEventHandler(this.txtClassName_Validating);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplayName.BackColor = System.Drawing.SystemColors.Control;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.ForeColor = System.Drawing.Color.DimGray;
            this.lblDisplayName.Location = new System.Drawing.Point(21, 103);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(276, 23);
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
            this.lblClassName.Location = new System.Drawing.Point(20, 41);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(277, 23);
            this.lblClassName.TabIndex = 0;
            this.lblClassName.Text = "Class Name";
            this.lblClassName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayName.Location = new System.Drawing.Point(21, 129);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(274, 22);
            this.txtDisplayName.TabIndex = 3;
            this.txtDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpWrapper
            // 
            this.grpWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpWrapper.Controls.Add(this.lblClassDisplayName);
            this.grpWrapper.Controls.Add(this.txtDisplayName);
            this.grpWrapper.Controls.Add(this.lblHeaderWrapper);
            this.grpWrapper.Controls.Add(this.txtClassName);
            this.grpWrapper.Controls.Add(this.lblClassName);
            this.grpWrapper.Controls.Add(this.lblDisplayName);
            this.grpWrapper.Location = new System.Drawing.Point(10, 5);
            this.grpWrapper.Name = "grpWrapper";
            this.grpWrapper.Size = new System.Drawing.Size(323, 188);
            this.grpWrapper.TabIndex = 0;
            this.grpWrapper.TabStop = false;
            // 
            // lblClassDisplayName
            // 
            this.lblClassDisplayName.AutoSize = true;
            this.lblClassDisplayName.BackColor = System.Drawing.Color.Transparent;
            this.lblClassDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassDisplayName.Location = new System.Drawing.Point(8, 16);
            this.lblClassDisplayName.Name = "lblClassDisplayName";
            this.lblClassDisplayName.Size = new System.Drawing.Size(135, 15);
            this.lblClassDisplayName.TabIndex = 1;
            this.lblClassDisplayName.Text = "Class Display Name";
            this.lblClassDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderWrapper
            // 
            this.lblHeaderWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderWrapper.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderWrapper.Location = new System.Drawing.Point(0, 4);
            this.lblHeaderWrapper.Name = "lblHeaderWrapper";
            this.lblHeaderWrapper.Size = new System.Drawing.Size(325, 6);
            this.lblHeaderWrapper.TabIndex = 0;
            this.lblHeaderWrapper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmGenericClassMap
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCcancel;
            this.ClientSize = new System.Drawing.Size(348, 240);
            this.Controls.Add(this.grpWrapper);
            this.Controls.Add(this.btnCcancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(230, 265);
            this.Name = "frmGenericClassMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Name Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGenericClassMap_FormClosed);
            this.Load += new System.EventHandler(this.frmGenericClassMap_Load);
            this.Shown += new System.EventHandler(this.frmGenericClassMap_Shown);
            this.Enter += new System.EventHandler(this.frmGenericClassMap_Enter);
            this.grpWrapper.ResumeLayout(false);
            this.grpWrapper.PerformLayout();
            this.ResumeLayout(false);

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
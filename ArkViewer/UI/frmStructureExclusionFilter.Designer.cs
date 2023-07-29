namespace ARKViewer
{
    partial class frmStructureExclusionFilter
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlWrapper = new System.Windows.Forms.Panel();
            this.lstStructureFilter = new System.Windows.Forms.CheckedListBox();
            this.chkApplyFilter = new System.Windows.Forms.CheckBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblWindowTitle = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.pnlWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancel.Location = new System.Drawing.Point(317, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pnlWrapper
            // 
            this.pnlWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWrapper.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlWrapper.Controls.Add(this.lstStructureFilter);
            this.pnlWrapper.Controls.Add(this.chkApplyFilter);
            this.pnlWrapper.Controls.Add(this.lblFilter);
            this.pnlWrapper.Controls.Add(this.txtFilter);
            this.pnlWrapper.Location = new System.Drawing.Point(12, 46);
            this.pnlWrapper.Name = "pnlWrapper";
            this.pnlWrapper.Size = new System.Drawing.Size(380, 365);
            this.pnlWrapper.TabIndex = 0;
            // 
            // lstStructureFilter
            // 
            this.lstStructureFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstStructureFilter.FormattingEnabled = true;
            this.lstStructureFilter.Location = new System.Drawing.Point(18, 15);
            this.lstStructureFilter.Name = "lstStructureFilter";
            this.lstStructureFilter.Size = new System.Drawing.Size(342, 304);
            this.lstStructureFilter.TabIndex = 0;
            this.lstStructureFilter.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstStructureFilter_ItemCheck);
            // 
            // chkApplyFilter
            // 
            this.chkApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkApplyFilter.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkApplyFilter.Image = global::ARKViewer.Properties.Resources.button_filter;
            this.chkApplyFilter.Location = new System.Drawing.Point(325, 325);
            this.chkApplyFilter.Name = "chkApplyFilter";
            this.chkApplyFilter.Size = new System.Drawing.Size(35, 35);
            this.chkApplyFilter.TabIndex = 3;
            this.chkApplyFilter.UseVisualStyleBackColor = true;
            this.chkApplyFilter.CheckedChanged += new System.EventHandler(this.chkApplyFilter_CheckedChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(15, 336);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(29, 13);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(50, 333);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(271, 20);
            this.txtFilter.TabIndex = 2;
            // 
            // lblWindowTitle
            // 
            this.lblWindowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindowTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWindowTitle.Location = new System.Drawing.Point(12, 9);
            this.lblWindowTitle.Name = "lblWindowTitle";
            this.lblWindowTitle.Size = new System.Drawing.Size(301, 31);
            this.lblWindowTitle.TabIndex = 0;
            this.lblWindowTitle.Text = "Structure Exclusions";
            this.lblWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(236, 428);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Save";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // frmStructureExclusionFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(404, 463);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblWindowTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlWrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(265, 300);
            this.Name = "frmStructureExclusionFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Structure Exclusions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStructureExclusionFilter_FormClosed);
            this.pnlWrapper.ResumeLayout(false);
            this.pnlWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlWrapper;
        private System.Windows.Forms.CheckBox chkApplyFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblWindowTitle;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckedListBox lstStructureFilter;
    }
}
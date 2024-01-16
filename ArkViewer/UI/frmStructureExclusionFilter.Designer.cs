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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStructureExclusionFilter));
            btnCancel = new System.Windows.Forms.Button();
            pnlWrapper = new System.Windows.Forms.Panel();
            lstStructureFilter = new System.Windows.Forms.CheckedListBox();
            chkApplyFilter = new System.Windows.Forms.CheckBox();
            lblFilter = new System.Windows.Forms.Label();
            txtFilter = new System.Windows.Forms.TextBox();
            lblWindowTitle = new System.Windows.Forms.Label();
            btnApply = new System.Windows.Forms.Button();
            pnlWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCancel.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnCancel.Location = new System.Drawing.Point(370, 494);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(88, 27);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Close";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // pnlWrapper
            // 
            pnlWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlWrapper.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            pnlWrapper.Controls.Add(lstStructureFilter);
            pnlWrapper.Controls.Add(chkApplyFilter);
            pnlWrapper.Controls.Add(lblFilter);
            pnlWrapper.Controls.Add(txtFilter);
            pnlWrapper.Location = new System.Drawing.Point(14, 53);
            pnlWrapper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlWrapper.Name = "pnlWrapper";
            pnlWrapper.Size = new System.Drawing.Size(443, 421);
            pnlWrapper.TabIndex = 0;
            // 
            // lstStructureFilter
            // 
            lstStructureFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstStructureFilter.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lstStructureFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lstStructureFilter.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lstStructureFilter.FormattingEnabled = true;
            lstStructureFilter.Location = new System.Drawing.Point(21, 10);
            lstStructureFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lstStructureFilter.Name = "lstStructureFilter";
            lstStructureFilter.Size = new System.Drawing.Size(398, 360);
            lstStructureFilter.TabIndex = 0;
            lstStructureFilter.ItemCheck += lstStructureFilter_ItemCheck;
            // 
            // chkApplyFilter
            // 
            chkApplyFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            chkApplyFilter.Appearance = System.Windows.Forms.Appearance.Button;
            chkApplyFilter.Image = (System.Drawing.Image)resources.GetObject("chkApplyFilter.Image");
            chkApplyFilter.Location = new System.Drawing.Point(379, 375);
            chkApplyFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkApplyFilter.Name = "chkApplyFilter";
            chkApplyFilter.Size = new System.Drawing.Size(41, 40);
            chkApplyFilter.TabIndex = 3;
            chkApplyFilter.UseVisualStyleBackColor = true;
            chkApplyFilter.CheckedChanged += chkApplyFilter_CheckedChanged;
            // 
            // lblFilter
            // 
            lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblFilter.AutoSize = true;
            lblFilter.Location = new System.Drawing.Point(18, 388);
            lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new System.Drawing.Size(33, 15);
            lblFilter.TabIndex = 1;
            lblFilter.Text = "Filter";
            // 
            // txtFilter
            // 
            txtFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFilter.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFilter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFilter.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtFilter.Location = new System.Drawing.Point(58, 384);
            txtFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new System.Drawing.Size(316, 20);
            txtFilter.TabIndex = 2;
            // 
            // lblWindowTitle
            // 
            lblWindowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWindowTitle.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblWindowTitle.Location = new System.Drawing.Point(14, 10);
            lblWindowTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWindowTitle.Name = "lblWindowTitle";
            lblWindowTitle.Size = new System.Drawing.Size(351, 36);
            lblWindowTitle.TabIndex = 0;
            lblWindowTitle.Text = "Structure Exclusions";
            lblWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnApply
            // 
            btnApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnApply.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnApply.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnApply.Location = new System.Drawing.Point(275, 494);
            btnApply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnApply.Name = "btnApply";
            btnApply.Size = new System.Drawing.Size(88, 27);
            btnApply.TabIndex = 1;
            btnApply.Text = "Save";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // frmStructureExclusionFilter
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(471, 534);
            Controls.Add(btnApply);
            Controls.Add(lblWindowTitle);
            Controls.Add(btnCancel);
            Controls.Add(pnlWrapper);
            ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(306, 340);
            Name = "frmStructureExclusionFilter";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Structure Exclusions";
            FormClosed += frmStructureExclusionFilter_FormClosed;
            pnlWrapper.ResumeLayout(false);
            pnlWrapper.PerformLayout();
            ResumeLayout(false);
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
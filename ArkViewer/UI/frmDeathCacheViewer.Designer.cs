
namespace ARKViewer
{
    partial class frmDeathCacheViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeathCacheViewer));
            pnlBagInventory = new System.Windows.Forms.Panel();
            chkApplyFilter = new System.Windows.Forms.CheckBox();
            lblFilter = new System.Windows.Forms.Label();
            txtFilter = new System.Windows.Forms.TextBox();
            lvwInventory = new System.Windows.Forms.ListView();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader8 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader12 = new System.Windows.Forms.ColumnHeader();
            lblWindowTitle = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            lblPlayerName = new System.Windows.Forms.Label();
            pnlBagInventory.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBagInventory
            // 
            pnlBagInventory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlBagInventory.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            pnlBagInventory.Controls.Add(chkApplyFilter);
            pnlBagInventory.Controls.Add(lblFilter);
            pnlBagInventory.Controls.Add(txtFilter);
            pnlBagInventory.Controls.Add(lvwInventory);
            pnlBagInventory.Location = new System.Drawing.Point(14, 52);
            pnlBagInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlBagInventory.Name = "pnlBagInventory";
            pnlBagInventory.Size = new System.Drawing.Size(709, 350);
            pnlBagInventory.TabIndex = 2;
            // 
            // chkApplyFilter
            // 
            chkApplyFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            chkApplyFilter.Appearance = System.Windows.Forms.Appearance.Button;
            chkApplyFilter.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            chkApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkApplyFilter.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            chkApplyFilter.Image = (System.Drawing.Image)resources.GetObject("chkApplyFilter.Image");
            chkApplyFilter.Location = new System.Drawing.Point(648, 309);
            chkApplyFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkApplyFilter.Name = "chkApplyFilter";
            chkApplyFilter.Size = new System.Drawing.Size(38, 31);
            chkApplyFilter.TabIndex = 3;
            chkApplyFilter.UseVisualStyleBackColor = false;
            chkApplyFilter.CheckedChanged += chkApplyFilterDinos_CheckedChanged;
            // 
            // lblFilter
            // 
            lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblFilter.AutoSize = true;
            lblFilter.Location = new System.Drawing.Point(30, 316);
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
            txtFilter.Location = new System.Drawing.Point(84, 313);
            txtFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new System.Drawing.Size(557, 20);
            txtFilter.TabIndex = 2;
            // 
            // lvwInventory
            // 
            lvwInventory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwInventory.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader3, columnHeader1, columnHeader8, columnHeader2, columnHeader12 });
            lvwInventory.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwInventory.FullRowSelect = true;
            lvwInventory.Location = new System.Drawing.Point(28, 22);
            lvwInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwInventory.Name = "lvwInventory";
            lvwInventory.Size = new System.Drawing.Size(657, 280);
            lvwInventory.TabIndex = 0;
            lvwInventory.UseCompatibleStateImageBehavior = false;
            lvwInventory.View = System.Windows.Forms.View.Details;
            lvwInventory.ColumnClick += lvwInventory_ColumnClick;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Item";
            columnHeader3.Width = 180;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "BP";
            columnHeader1.Width = 50;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Category";
            columnHeader8.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Quality";
            columnHeader2.Width = 80;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Qty";
            columnHeader12.Width = 48;
            // 
            // lblWindowTitle
            // 
            lblWindowTitle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblWindowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWindowTitle.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblWindowTitle.Location = new System.Drawing.Point(516, 13);
            lblWindowTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWindowTitle.Name = "lblWindowTitle";
            lblWindowTitle.Size = new System.Drawing.Size(208, 25);
            lblWindowTitle.TabIndex = 1;
            lblWindowTitle.Text = "Death Cache";
            lblWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnClose.Location = new System.Drawing.Point(636, 415);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(88, 27);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPlayerName.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblPlayerName.Location = new System.Drawing.Point(14, 13);
            lblPlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new System.Drawing.Size(146, 25);
            lblPlayerName.TabIndex = 0;
            lblPlayerName.Text = "Player Name";
            lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmDeathCacheViewer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(737, 455);
            Controls.Add(pnlBagInventory);
            Controls.Add(lblWindowTitle);
            Controls.Add(btnClose);
            Controls.Add(lblPlayerName);
            ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(581, 398);
            Name = "frmDeathCacheViewer";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Death Cache Inventory";
            FormClosed += frmDeathCacheViewer_FormClosed;
            pnlBagInventory.ResumeLayout(false);
            pnlBagInventory.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlBagInventory;
        private System.Windows.Forms.CheckBox chkApplyFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ListView lvwInventory;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label lblWindowTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
namespace ARKViewer
{
    partial class frmStructureInventoryViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStructureInventoryViewer));
            pnlCreatureInventory = new System.Windows.Forms.Panel();
            chkApplyFilter = new System.Windows.Forms.CheckBox();
            lblFilter = new System.Windows.Forms.Label();
            txtFilter = new System.Windows.Forms.TextBox();
            lvwInventory = new System.Windows.Forms.ListView();
            lvwInventory_Item = new System.Windows.Forms.ColumnHeader();
            lvwInventory_Category = new System.Windows.Forms.ColumnHeader();
            lvwInventory_Quality = new System.Windows.Forms.ColumnHeader();
            lvwInventory_Rating = new System.Windows.Forms.ColumnHeader();
            lvwInventory_Qty = new System.Windows.Forms.ColumnHeader();
            lblWindowTitle = new System.Windows.Forms.Label();
            picWindowIcon = new System.Windows.Forms.PictureBox();
            btnClose = new System.Windows.Forms.Button();
            lblStructureName = new System.Windows.Forms.Label();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            pnlCreatureInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWindowIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlCreatureInventory
            // 
            pnlCreatureInventory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlCreatureInventory.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            pnlCreatureInventory.Controls.Add(chkApplyFilter);
            pnlCreatureInventory.Controls.Add(lblFilter);
            pnlCreatureInventory.Controls.Add(txtFilter);
            pnlCreatureInventory.Controls.Add(lvwInventory);
            pnlCreatureInventory.Location = new System.Drawing.Point(13, 65);
            pnlCreatureInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlCreatureInventory.Name = "pnlCreatureInventory";
            pnlCreatureInventory.Size = new System.Drawing.Size(712, 432);
            pnlCreatureInventory.TabIndex = 2;
            // 
            // chkApplyFilter
            // 
            chkApplyFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            chkApplyFilter.Appearance = System.Windows.Forms.Appearance.Button;
            chkApplyFilter.Image = (System.Drawing.Image)resources.GetObject("chkApplyFilter.Image");
            chkApplyFilter.Location = new System.Drawing.Point(656, 384);
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
            lblFilter.Location = new System.Drawing.Point(9, 398);
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
            txtFilter.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            txtFilter.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtFilter.Location = new System.Drawing.Point(50, 395);
            txtFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new System.Drawing.Size(598, 20);
            txtFilter.TabIndex = 2;
            // 
            // lvwInventory
            // 
            lvwInventory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwInventory.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvwInventory_Item, columnHeader1, lvwInventory_Category, lvwInventory_Quality, lvwInventory_Rating, lvwInventory_Qty });
            lvwInventory.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwInventory.FullRowSelect = true;
            lvwInventory.Location = new System.Drawing.Point(13, 15);
            lvwInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwInventory.Name = "lvwInventory";
            lvwInventory.Size = new System.Drawing.Size(683, 364);
            lvwInventory.TabIndex = 0;
            lvwInventory.UseCompatibleStateImageBehavior = false;
            lvwInventory.View = System.Windows.Forms.View.Details;
            lvwInventory.ColumnClick += lvwInventory_ColumnClick;
            // 
            // lvwInventory_Item
            // 
            lvwInventory_Item.Text = "Item";
            lvwInventory_Item.Width = 169;
            // 
            // lvwInventory_Category
            // 
            lvwInventory_Category.Text = "Category";
            lvwInventory_Category.Width = 160;
            // 
            // lvwInventory_Quality
            // 
            lvwInventory_Quality.Text = "Quality";
            lvwInventory_Quality.Width = 80;
            // 
            // lvwInventory_Rating
            // 
            lvwInventory_Rating.Text = "Rating";
            // 
            // lvwInventory_Qty
            // 
            lvwInventory_Qty.Text = "Qty";
            lvwInventory_Qty.Width = 50;
            // 
            // lblWindowTitle
            // 
            lblWindowTitle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblWindowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            lblWindowTitle.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblWindowTitle.Location = new System.Drawing.Point(471, 15);
            lblWindowTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWindowTitle.Name = "lblWindowTitle";
            lblWindowTitle.Size = new System.Drawing.Size(208, 36);
            lblWindowTitle.TabIndex = 1;
            lblWindowTitle.Text = "Inventory View";
            lblWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picWindowIcon
            // 
            picWindowIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            picWindowIcon.Image = (System.Drawing.Image)resources.GetObject("picWindowIcon.Image");
            picWindowIcon.Location = new System.Drawing.Point(686, 12);
            picWindowIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            picWindowIcon.Name = "picWindowIcon";
            picWindowIcon.Size = new System.Drawing.Size(41, 46);
            picWindowIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picWindowIcon.TabIndex = 17;
            picWindowIcon.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnClose.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            btnClose.Location = new System.Drawing.Point(637, 503);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(88, 27);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // lblStructureName
            // 
            lblStructureName.AutoSize = true;
            lblStructureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            lblStructureName.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblStructureName.Location = new System.Drawing.Point(14, 18);
            lblStructureName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStructureName.Name = "lblStructureName";
            lblStructureName.Size = new System.Drawing.Size(175, 25);
            lblStructureName.TabIndex = 0;
            lblStructureName.Text = "Structure Name";
            lblStructureName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Input";
            // 
            // frmStructureInventoryViewer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(740, 540);
            Controls.Add(pnlCreatureInventory);
            Controls.Add(lblWindowTitle);
            Controls.Add(picWindowIcon);
            Controls.Add(btnClose);
            Controls.Add(lblStructureName);
            ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(756, 340);
            Name = "frmStructureInventoryViewer";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Structure Inventory";
            FormClosed += frmStructureInventoryViewer_FormClosed;
            pnlCreatureInventory.ResumeLayout(false);
            pnlCreatureInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picWindowIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlCreatureInventory;
        private System.Windows.Forms.CheckBox chkApplyFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ListView lvwInventory;
        private System.Windows.Forms.ColumnHeader lvwInventory_Item;
        private System.Windows.Forms.ColumnHeader lvwInventory_Category;
        private System.Windows.Forms.ColumnHeader lvwInventory_Qty;
        private System.Windows.Forms.Label lblWindowTitle;
        private System.Windows.Forms.PictureBox picWindowIcon;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStructureName;
        private System.Windows.Forms.ColumnHeader lvwInventory_Quality;
        private System.Windows.Forms.ColumnHeader lvwInventory_Rating;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
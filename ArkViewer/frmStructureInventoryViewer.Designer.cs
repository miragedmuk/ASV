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
            this.pnlCreatureInventory = new System.Windows.Forms.Panel();
            this.chkApplyFilter = new System.Windows.Forms.CheckBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lvwInventory = new System.Windows.Forms.ListView();
            this.lvwInventory_Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwInventory_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwInventory_Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwInventory_Quality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblWindowTitle = new System.Windows.Forms.Label();
            this.picWindowIcon = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStructureName = new System.Windows.Forms.Label();
            this.lvwInventory_Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlCreatureInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWindowIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCreatureInventory
            // 
            this.pnlCreatureInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCreatureInventory.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlCreatureInventory.Controls.Add(this.chkApplyFilter);
            this.pnlCreatureInventory.Controls.Add(this.lblFilter);
            this.pnlCreatureInventory.Controls.Add(this.txtFilter);
            this.pnlCreatureInventory.Controls.Add(this.lvwInventory);
            this.pnlCreatureInventory.Location = new System.Drawing.Point(11, 56);
            this.pnlCreatureInventory.Name = "pnlCreatureInventory";
            this.pnlCreatureInventory.Size = new System.Drawing.Size(610, 374);
            this.pnlCreatureInventory.TabIndex = 2;
            // 
            // chkApplyFilter
            // 
            this.chkApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkApplyFilter.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkApplyFilter.Image = global::ARKViewer.Properties.Resources.button_filter;
            this.chkApplyFilter.Location = new System.Drawing.Point(562, 333);
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
            this.lblFilter.Location = new System.Drawing.Point(8, 345);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(29, 13);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(43, 342);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(513, 20);
            this.txtFilter.TabIndex = 2;
            // 
            // lvwInventory
            // 
            this.lvwInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwInventory_Item,
            this.lvwInventory_Category,
            this.lvwInventory_Quality,
            this.lvwInventory_Rating,
            this.lvwInventory_Qty});
            this.lvwInventory.FullRowSelect = true;
            this.lvwInventory.HideSelection = false;
            this.lvwInventory.Location = new System.Drawing.Point(11, 13);
            this.lvwInventory.Name = "lvwInventory";
            this.lvwInventory.Size = new System.Drawing.Size(586, 316);
            this.lvwInventory.TabIndex = 0;
            this.lvwInventory.UseCompatibleStateImageBehavior = false;
            this.lvwInventory.View = System.Windows.Forms.View.Details;
            this.lvwInventory.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwInventory_ColumnClick);
            // 
            // lvwInventory_Item
            // 
            this.lvwInventory_Item.Text = "Item";
            this.lvwInventory_Item.Width = 169;
            // 
            // lvwInventory_Category
            // 
            this.lvwInventory_Category.Text = "Category";
            this.lvwInventory_Category.Width = 160;
            // 
            // lvwInventory_Qty
            // 
            this.lvwInventory_Qty.Text = "Qty";
            this.lvwInventory_Qty.Width = 50;
            // 
            // lvwInventory_Quality
            // 
            this.lvwInventory_Quality.Text = "Quality";
            this.lvwInventory_Quality.Width = 80;
            // 
            // lblWindowTitle
            // 
            this.lblWindowTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWindowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindowTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWindowTitle.Location = new System.Drawing.Point(404, 13);
            this.lblWindowTitle.Name = "lblWindowTitle";
            this.lblWindowTitle.Size = new System.Drawing.Size(178, 31);
            this.lblWindowTitle.TabIndex = 1;
            this.lblWindowTitle.Text = "Inventory View";
            this.lblWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picWindowIcon
            // 
            this.picWindowIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picWindowIcon.Image = global::ARKViewer.Properties.Resources.button_file;
            this.picWindowIcon.Location = new System.Drawing.Point(588, 10);
            this.picWindowIcon.Name = "picWindowIcon";
            this.picWindowIcon.Size = new System.Drawing.Size(35, 40);
            this.picWindowIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWindowIcon.TabIndex = 17;
            this.picWindowIcon.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.Location = new System.Drawing.Point(546, 436);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblStructureName
            // 
            this.lblStructureName.AutoSize = true;
            this.lblStructureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStructureName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStructureName.Location = new System.Drawing.Point(12, 16);
            this.lblStructureName.Name = "lblStructureName";
            this.lblStructureName.Size = new System.Drawing.Size(175, 25);
            this.lblStructureName.TabIndex = 0;
            this.lblStructureName.Text = "Structure Name";
            this.lblStructureName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwInventory_Rating
            // 
            this.lvwInventory_Rating.Text = "Rating";
            // 
            // frmStructureInventoryViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(634, 468);
            this.Controls.Add(this.pnlCreatureInventory);
            this.Controls.Add(this.lblWindowTitle);
            this.Controls.Add(this.picWindowIcon);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStructureName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(650, 300);
            this.Name = "frmStructureInventoryViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Structure Inventory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStructureInventoryViewer_FormClosed);
            this.pnlCreatureInventory.ResumeLayout(false);
            this.pnlCreatureInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWindowIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
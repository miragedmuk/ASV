namespace ARKViewer
{
    partial class frmDinoInventoryViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDinoInventoryViewer));
            this.lblWindowTitle = new System.Windows.Forms.Label();
            this.picWindowIcon = new System.Windows.Forms.PictureBox();
            this.pnlCreatureInventory = new System.Windows.Forms.Panel();
            this.chkApplyFilterDinos = new System.Windows.Forms.CheckBox();
            this.lblCreatureFilter = new System.Windows.Forms.Label();
            this.txtCreatureFilter = new System.Windows.Forms.TextBox();
            this.lvwCreatureInventory = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLevelLabel = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblTribeName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.picWindowIcon)).BeginInit();
            this.pnlCreatureInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWindowTitle
            // 
            this.lblWindowTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWindowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindowTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWindowTitle.Location = new System.Drawing.Point(410, 10);
            this.lblWindowTitle.Name = "lblWindowTitle";
            this.lblWindowTitle.Size = new System.Drawing.Size(178, 31);
            this.lblWindowTitle.TabIndex = 4;
            this.lblWindowTitle.Text = "Inventory View";
            this.lblWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picWindowIcon
            // 
            this.picWindowIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picWindowIcon.Image = ((System.Drawing.Image)(resources.GetObject("picWindowIcon.Image")));
            this.picWindowIcon.Location = new System.Drawing.Point(594, 7);
            this.picWindowIcon.Name = "picWindowIcon";
            this.picWindowIcon.Size = new System.Drawing.Size(35, 40);
            this.picWindowIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWindowIcon.TabIndex = 9;
            this.picWindowIcon.TabStop = false;
            // 
            // pnlCreatureInventory
            // 
            this.pnlCreatureInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCreatureInventory.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlCreatureInventory.Controls.Add(this.chkApplyFilterDinos);
            this.pnlCreatureInventory.Controls.Add(this.lblCreatureFilter);
            this.pnlCreatureInventory.Controls.Add(this.txtCreatureFilter);
            this.pnlCreatureInventory.Controls.Add(this.lvwCreatureInventory);
            this.pnlCreatureInventory.Location = new System.Drawing.Point(12, 70);
            this.pnlCreatureInventory.Name = "pnlCreatureInventory";
            this.pnlCreatureInventory.Size = new System.Drawing.Size(615, 287);
            this.pnlCreatureInventory.TabIndex = 5;
            // 
            // chkApplyFilterDinos
            // 
            this.chkApplyFilterDinos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkApplyFilterDinos.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkApplyFilterDinos.Image = global::ARKViewer.Properties.Resources.button_filter;
            this.chkApplyFilterDinos.Location = new System.Drawing.Point(570, 247);
            this.chkApplyFilterDinos.Name = "chkApplyFilterDinos";
            this.chkApplyFilterDinos.Size = new System.Drawing.Size(35, 35);
            this.chkApplyFilterDinos.TabIndex = 3;
            this.chkApplyFilterDinos.UseVisualStyleBackColor = true;
            this.chkApplyFilterDinos.CheckedChanged += new System.EventHandler(this.chkApplyFilterDinos_CheckedChanged);
            // 
            // lblCreatureFilter
            // 
            this.lblCreatureFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCreatureFilter.AutoSize = true;
            this.lblCreatureFilter.Location = new System.Drawing.Point(10, 258);
            this.lblCreatureFilter.Name = "lblCreatureFilter";
            this.lblCreatureFilter.Size = new System.Drawing.Size(29, 13);
            this.lblCreatureFilter.TabIndex = 1;
            this.lblCreatureFilter.Text = "Filter";
            // 
            // txtCreatureFilter
            // 
            this.txtCreatureFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreatureFilter.Location = new System.Drawing.Point(45, 255);
            this.txtCreatureFilter.Name = "txtCreatureFilter";
            this.txtCreatureFilter.Size = new System.Drawing.Size(519, 20);
            this.txtCreatureFilter.TabIndex = 2;
            // 
            // lvwCreatureInventory
            // 
            this.lvwCreatureInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwCreatureInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader12});
            this.lvwCreatureInventory.FullRowSelect = true;
            this.lvwCreatureInventory.HideSelection = false;
            this.lvwCreatureInventory.Location = new System.Drawing.Point(13, 12);
            this.lvwCreatureInventory.Name = "lvwCreatureInventory";
            this.lvwCreatureInventory.Size = new System.Drawing.Size(592, 234);
            this.lvwCreatureInventory.TabIndex = 0;
            this.lvwCreatureInventory.UseCompatibleStateImageBehavior = false;
            this.lvwCreatureInventory.View = System.Windows.Forms.View.Details;
            this.lvwCreatureInventory.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwCreatureInventory_ColumnClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Item";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "BP";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Category";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quality";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Qty";
            this.columnHeader12.Width = 48;
            // 
            // lblLevelLabel
            // 
            this.lblLevelLabel.AutoSize = true;
            this.lblLevelLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.lblLevelLabel.Location = new System.Drawing.Point(12, 17);
            this.lblLevelLabel.Name = "lblLevelLabel";
            this.lblLevelLabel.Size = new System.Drawing.Size(70, 13);
            this.lblLevelLabel.TabIndex = 0;
            this.lblLevelLabel.Text = "Current Level";
            // 
            // lblLevel
            // 
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblLevel.Location = new System.Drawing.Point(13, 30);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(62, 19);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "135";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTribeName
            // 
            this.lblTribeName.AutoSize = true;
            this.lblTribeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTribeName.ForeColor = System.Drawing.Color.DimGray;
            this.lblTribeName.Location = new System.Drawing.Point(92, 39);
            this.lblTribeName.Name = "lblTribeName";
            this.lblTribeName.Size = new System.Drawing.Size(90, 16);
            this.lblTribeName.TabIndex = 3;
            this.lblTribeName.Text = "Tribe Name";
            this.lblTribeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblName.Location = new System.Drawing.Point(90, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(170, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Creature Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.Location = new System.Drawing.Point(552, 365);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rating";
            // 
            // frmDinoInventoryViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(639, 400);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblLevelLabel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblTribeName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlCreatureInventory);
            this.Controls.Add(this.lblWindowTitle);
            this.Controls.Add(this.picWindowIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(505, 315);
            this.Name = "frmDinoInventoryViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creature Inventory View";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDinoInventoryViewer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picWindowIcon)).EndInit();
            this.pnlCreatureInventory.ResumeLayout(false);
            this.pnlCreatureInventory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWindowTitle;
        private System.Windows.Forms.PictureBox picWindowIcon;
        private System.Windows.Forms.Panel pnlCreatureInventory;
        private System.Windows.Forms.Label lblCreatureFilter;
        private System.Windows.Forms.TextBox txtCreatureFilter;
        private System.Windows.Forms.ListView lvwCreatureInventory;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label lblLevelLabel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblTribeName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkApplyFilterDinos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
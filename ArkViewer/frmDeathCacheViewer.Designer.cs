
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
            this.pnlBagInventory = new System.Windows.Forms.Panel();
            this.chkApplyFilter = new System.Windows.Forms.CheckBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lvwInventory = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblWindowTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.pnlBagInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBagInventory
            // 
            this.pnlBagInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBagInventory.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlBagInventory.Controls.Add(this.chkApplyFilter);
            this.pnlBagInventory.Controls.Add(this.lblFilter);
            this.pnlBagInventory.Controls.Add(this.txtFilter);
            this.pnlBagInventory.Controls.Add(this.lvwInventory);
            this.pnlBagInventory.Location = new System.Drawing.Point(12, 45);
            this.pnlBagInventory.Name = "pnlBagInventory";
            this.pnlBagInventory.Size = new System.Drawing.Size(608, 303);
            this.pnlBagInventory.TabIndex = 2;
            // 
            // chkApplyFilter
            // 
            this.chkApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkApplyFilter.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkApplyFilter.Image = global::ARKViewer.Properties.Resources.button_filter;
            this.chkApplyFilter.Location = new System.Drawing.Point(555, 268);
            this.chkApplyFilter.Name = "chkApplyFilter";
            this.chkApplyFilter.Size = new System.Drawing.Size(33, 27);
            this.chkApplyFilter.TabIndex = 3;
            this.chkApplyFilter.UseVisualStyleBackColor = true;
            this.chkApplyFilter.CheckedChanged += new System.EventHandler(this.chkApplyFilterDinos_CheckedChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(26, 274);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(29, 13);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(72, 271);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(478, 20);
            this.txtFilter.TabIndex = 2;
            // 
            // lvwInventory
            // 
            this.lvwInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader12});
            this.lvwInventory.FullRowSelect = true;
            this.lvwInventory.HideSelection = false;
            this.lvwInventory.Location = new System.Drawing.Point(24, 19);
            this.lvwInventory.Name = "lvwInventory";
            this.lvwInventory.Size = new System.Drawing.Size(564, 243);
            this.lvwInventory.TabIndex = 0;
            this.lvwInventory.UseCompatibleStateImageBehavior = false;
            this.lvwInventory.View = System.Windows.Forms.View.Details;
            this.lvwInventory.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwInventory_ColumnClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Item";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "BP";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Category";
            this.columnHeader8.Width = 200;
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
            // lblWindowTitle
            // 
            this.lblWindowTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWindowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindowTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWindowTitle.Location = new System.Drawing.Point(442, 11);
            this.lblWindowTitle.Name = "lblWindowTitle";
            this.lblWindowTitle.Size = new System.Drawing.Size(178, 31);
            this.lblWindowTitle.TabIndex = 1;
            this.lblWindowTitle.Text = "Death Cache";
            this.lblWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.Location = new System.Drawing.Point(545, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPlayerName.Location = new System.Drawing.Point(12, 11);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(146, 25);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player Name";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmDeathCacheViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(632, 394);
            this.Controls.Add(this.pnlBagInventory);
            this.Controls.Add(this.lblWindowTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "frmDeathCacheViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Death Cache Inventory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDeathCacheViewer_FormClosed);
            this.pnlBagInventory.ResumeLayout(false);
            this.pnlBagInventory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
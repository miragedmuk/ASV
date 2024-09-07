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
            pnlCreatureInventory = new System.Windows.Forms.Panel();
            chkApplyFilterDinos = new System.Windows.Forms.CheckBox();
            lblCreatureFilter = new System.Windows.Forms.Label();
            txtCreatureFilter = new System.Windows.Forms.TextBox();
            lvwCreatureInventory = new System.Windows.Forms.ListView();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader8 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader12 = new System.Windows.Forms.ColumnHeader();
            lblLevelLabel = new System.Windows.Forms.Label();
            lblLevel = new System.Windows.Forms.Label();
            lblTribeName = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            tabControlCreature = new System.Windows.Forms.TabControl();
            tpgFtp = new System.Windows.Forms.TabPage();
            panel1 = new System.Windows.Forms.Panel();
            lvwTraits = new System.Windows.Forms.ListView();
            lvwTameDetail_Base = new System.Windows.Forms.ColumnHeader();
            tpgRCON = new System.Windows.Forms.TabPage();
            pnlCreatureInventory.SuspendLayout();
            tabControlCreature.SuspendLayout();
            tpgFtp.SuspendLayout();
            panel1.SuspendLayout();
            tpgRCON.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCreatureInventory
            // 
            pnlCreatureInventory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlCreatureInventory.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            pnlCreatureInventory.Controls.Add(chkApplyFilterDinos);
            pnlCreatureInventory.Controls.Add(lblCreatureFilter);
            pnlCreatureInventory.Controls.Add(txtCreatureFilter);
            pnlCreatureInventory.Controls.Add(lvwCreatureInventory);
            pnlCreatureInventory.Location = new System.Drawing.Point(7, 16);
            pnlCreatureInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlCreatureInventory.Name = "pnlCreatureInventory";
            pnlCreatureInventory.Size = new System.Drawing.Size(650, 331);
            pnlCreatureInventory.TabIndex = 5;
            // 
            // chkApplyFilterDinos
            // 
            chkApplyFilterDinos.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            chkApplyFilterDinos.Appearance = System.Windows.Forms.Appearance.Button;
            chkApplyFilterDinos.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            chkApplyFilterDinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkApplyFilterDinos.Image = (System.Drawing.Image)resources.GetObject("chkApplyFilterDinos.Image");
            chkApplyFilterDinos.Location = new System.Drawing.Point(597, 285);
            chkApplyFilterDinos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkApplyFilterDinos.Name = "chkApplyFilterDinos";
            chkApplyFilterDinos.Size = new System.Drawing.Size(41, 40);
            chkApplyFilterDinos.TabIndex = 3;
            chkApplyFilterDinos.UseVisualStyleBackColor = false;
            chkApplyFilterDinos.CheckedChanged += chkApplyFilterDinos_CheckedChanged;
            // 
            // lblCreatureFilter
            // 
            lblCreatureFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCreatureFilter.AutoSize = true;
            lblCreatureFilter.Location = new System.Drawing.Point(12, 298);
            lblCreatureFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCreatureFilter.Name = "lblCreatureFilter";
            lblCreatureFilter.Size = new System.Drawing.Size(33, 15);
            lblCreatureFilter.TabIndex = 1;
            lblCreatureFilter.Text = "Filter";
            // 
            // txtCreatureFilter
            // 
            txtCreatureFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCreatureFilter.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtCreatureFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtCreatureFilter.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            txtCreatureFilter.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtCreatureFilter.Location = new System.Drawing.Point(52, 294);
            txtCreatureFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCreatureFilter.Name = "txtCreatureFilter";
            txtCreatureFilter.Size = new System.Drawing.Size(537, 20);
            txtCreatureFilter.TabIndex = 2;
            // 
            // lvwCreatureInventory
            // 
            lvwCreatureInventory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwCreatureInventory.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwCreatureInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader3, columnHeader5, columnHeader1, columnHeader8, columnHeader2, columnHeader4, columnHeader12 });
            lvwCreatureInventory.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwCreatureInventory.FullRowSelect = true;
            lvwCreatureInventory.Location = new System.Drawing.Point(15, 14);
            lvwCreatureInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwCreatureInventory.Name = "lvwCreatureInventory";
            lvwCreatureInventory.Size = new System.Drawing.Size(622, 269);
            lvwCreatureInventory.TabIndex = 0;
            lvwCreatureInventory.UseCompatibleStateImageBehavior = false;
            lvwCreatureInventory.View = System.Windows.Forms.View.Details;
            lvwCreatureInventory.ColumnClick += lvwCreatureInventory_ColumnClick;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Item";
            columnHeader3.Width = 160;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Input";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "BP";
            columnHeader1.Width = 50;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Category";
            columnHeader8.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Quality";
            columnHeader2.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Rating";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Qty";
            columnHeader12.Width = 48;
            // 
            // lblLevelLabel
            // 
            lblLevelLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblLevelLabel.AutoSize = true;
            lblLevelLabel.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblLevelLabel.Location = new System.Drawing.Point(571, 23);
            lblLevelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLevelLabel.Name = "lblLevelLabel";
            lblLevelLabel.Size = new System.Drawing.Size(77, 15);
            lblLevelLabel.TabIndex = 0;
            lblLevelLabel.Text = "Current Level";
            // 
            // lblLevel
            // 
            lblLevel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            lblLevel.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblLevel.Location = new System.Drawing.Point(572, 38);
            lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new System.Drawing.Size(72, 22);
            lblLevel.TabIndex = 1;
            lblLevel.Text = "135";
            lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTribeName
            // 
            lblTribeName.AutoSize = true;
            lblTribeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblTribeName.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblTribeName.Location = new System.Drawing.Point(13, 45);
            lblTribeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTribeName.Name = "lblTribeName";
            lblTribeName.Size = new System.Drawing.Size(89, 16);
            lblTribeName.TabIndex = 3;
            lblTribeName.Text = "Tribe Name";
            lblTribeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            lblName.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblName.Location = new System.Drawing.Point(11, 17);
            lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(170, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Creature Name";
            lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnClose.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnClose.Location = new System.Drawing.Point(596, 399);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(88, 27);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // tabControlCreature
            // 
            tabControlCreature.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControlCreature.Controls.Add(tpgFtp);
            tabControlCreature.Controls.Add(tpgRCON);
            tabControlCreature.Location = new System.Drawing.Point(12, 12);
            tabControlCreature.Name = "tabControlCreature";
            tabControlCreature.SelectedIndex = 0;
            tabControlCreature.Size = new System.Drawing.Size(672, 381);
            tabControlCreature.TabIndex = 7;
            // 
            // tpgFtp
            // 
            tpgFtp.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgFtp.Controls.Add(panel1);
            tpgFtp.Controls.Add(lblName);
            tpgFtp.Controls.Add(lblTribeName);
            tpgFtp.Controls.Add(lblLevelLabel);
            tpgFtp.Controls.Add(lblLevel);
            tpgFtp.Location = new System.Drawing.Point(4, 24);
            tpgFtp.Name = "tpgFtp";
            tpgFtp.Padding = new System.Windows.Forms.Padding(3);
            tpgFtp.Size = new System.Drawing.Size(664, 353);
            tpgFtp.TabIndex = 0;
            tpgFtp.Text = "Creature";
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            panel1.Controls.Add(lvwTraits);
            panel1.Location = new System.Drawing.Point(11, 82);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(643, 260);
            panel1.TabIndex = 6;
            // 
            // lvwTraits
            // 
            lvwTraits.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwTraits.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwTraits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvwTraits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvwTameDetail_Base });
            lvwTraits.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwTraits.FullRowSelect = true;
            lvwTraits.Location = new System.Drawing.Point(9, 6);
            lvwTraits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwTraits.Name = "lvwTraits";
            lvwTraits.Size = new System.Drawing.Size(625, 242);
            lvwTraits.TabIndex = 8;
            lvwTraits.UseCompatibleStateImageBehavior = false;
            lvwTraits.View = System.Windows.Forms.View.Details;
            // 
            // lvwTameDetail_Base
            // 
            lvwTameDetail_Base.Text = "Traits";
            lvwTameDetail_Base.Width = 560;
            // 
            // tpgRCON
            // 
            tpgRCON.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            tpgRCON.Controls.Add(pnlCreatureInventory);
            tpgRCON.Location = new System.Drawing.Point(4, 24);
            tpgRCON.Name = "tpgRCON";
            tpgRCON.Padding = new System.Windows.Forms.Padding(3);
            tpgRCON.Size = new System.Drawing.Size(664, 353);
            tpgRCON.TabIndex = 1;
            tpgRCON.Text = "Inventory";
            // 
            // frmDinoInventoryViewer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(698, 440);
            Controls.Add(tabControlCreature);
            Controls.Add(btnClose);
            ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(586, 357);
            Name = "frmDinoInventoryViewer";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Creature Inventory View";
            FormClosed += frmDinoInventoryViewer_FormClosed;
            pnlCreatureInventory.ResumeLayout(false);
            pnlCreatureInventory.PerformLayout();
            tabControlCreature.ResumeLayout(false);
            tpgFtp.ResumeLayout(false);
            tpgFtp.PerformLayout();
            panel1.ResumeLayout(false);
            tpgRCON.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
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
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TabControl tabControlCreature;
        private System.Windows.Forms.TabPage tpgFtp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tpgRCON;
        private System.Windows.Forms.ListView lvwTraits;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Base;
    }
}
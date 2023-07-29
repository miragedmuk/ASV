
namespace ARKViewer
{
    partial class frmClientAccess
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
            this.grpWrapper = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblClientAccount = new System.Windows.Forms.Label();
            this.btnCopyAccessKey = new System.Windows.Forms.Button();
            this.txtAccessKey = new System.Windows.Forms.TextBox();
            this.lblAccessKey = new System.Windows.Forms.Label();
            this.chkAllowDroppedItems = new System.Windows.Forms.CheckBox();
            this.chkAllowMapInventories = new System.Windows.Forms.CheckBox();
            this.chkAllowMapStructures = new System.Windows.Forms.CheckBox();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.udRad = new System.Windows.Forms.NumericUpDown();
            this.udLon = new System.Windows.Forms.NumericUpDown();
            this.udLat = new System.Windows.Forms.NumericUpDown();
            this.lblRadius = new System.Windows.Forms.Label();
            this.cboSelectedForPlayerId = new System.Windows.Forms.ComboBox();
            this.cboSelectedForTribeId = new System.Windows.Forms.ComboBox();
            this.lblLon = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblTribe = new System.Windows.Forms.Label();
            this.lblRestrictions = new System.Windows.Forms.Label();
            this.chkAllowTribeStructures = new System.Windows.Forms.CheckBox();
            this.chkAllowTamed = new System.Windows.Forms.CheckBox();
            this.chkAllowWild = new System.Windows.Forms.CheckBox();
            this.lblHeaderWrapper = new System.Windows.Forms.Label();
            this.lblAccessRights = new System.Windows.Forms.Label();
            this.btnCcancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLat)).BeginInit();
            this.SuspendLayout();
            // 
            // grpWrapper
            // 
            this.grpWrapper.Controls.Add(this.txtName);
            this.grpWrapper.Controls.Add(this.lblAccountName);
            this.grpWrapper.Controls.Add(this.lblClientAccount);
            this.grpWrapper.Controls.Add(this.btnCopyAccessKey);
            this.grpWrapper.Controls.Add(this.txtAccessKey);
            this.grpWrapper.Controls.Add(this.lblAccessKey);
            this.grpWrapper.Controls.Add(this.chkAllowDroppedItems);
            this.grpWrapper.Controls.Add(this.chkAllowMapInventories);
            this.grpWrapper.Controls.Add(this.chkAllowMapStructures);
            this.grpWrapper.Controls.Add(this.btnGenerateKey);
            this.grpWrapper.Controls.Add(this.udRad);
            this.grpWrapper.Controls.Add(this.udLon);
            this.grpWrapper.Controls.Add(this.udLat);
            this.grpWrapper.Controls.Add(this.lblRadius);
            this.grpWrapper.Controls.Add(this.cboSelectedForPlayerId);
            this.grpWrapper.Controls.Add(this.cboSelectedForTribeId);
            this.grpWrapper.Controls.Add(this.lblLon);
            this.grpWrapper.Controls.Add(this.lblLat);
            this.grpWrapper.Controls.Add(this.lblPlayer);
            this.grpWrapper.Controls.Add(this.lblTribe);
            this.grpWrapper.Controls.Add(this.lblRestrictions);
            this.grpWrapper.Controls.Add(this.chkAllowTribeStructures);
            this.grpWrapper.Controls.Add(this.chkAllowTamed);
            this.grpWrapper.Controls.Add(this.chkAllowWild);
            this.grpWrapper.Controls.Add(this.lblHeaderWrapper);
            this.grpWrapper.Controls.Add(this.lblAccessRights);
            this.grpWrapper.Location = new System.Drawing.Point(12, 12);
            this.grpWrapper.Name = "grpWrapper";
            this.grpWrapper.Size = new System.Drawing.Size(461, 391);
            this.grpWrapper.TabIndex = 0;
            this.grpWrapper.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(32, 49);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(81, 13);
            this.lblAccountName.TabIndex = 2;
            this.lblAccountName.Text = "Account Name:";
            // 
            // lblClientAccount
            // 
            this.lblClientAccount.AutoSize = true;
            this.lblClientAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblClientAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAccount.Location = new System.Drawing.Point(14, 16);
            this.lblClientAccount.Name = "lblClientAccount";
            this.lblClientAccount.Size = new System.Drawing.Size(98, 15);
            this.lblClientAccount.TabIndex = 1;
            this.lblClientAccount.Text = "Client Account";
            this.lblClientAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCopyAccessKey
            // 
            this.btnCopyAccessKey.Image = global::ARKViewer.Properties.Resources.button_document;
            this.btnCopyAccessKey.Location = new System.Drawing.Point(404, 76);
            this.btnCopyAccessKey.Name = "btnCopyAccessKey";
            this.btnCopyAccessKey.Size = new System.Drawing.Size(35, 35);
            this.btnCopyAccessKey.TabIndex = 7;
            this.btnCopyAccessKey.UseVisualStyleBackColor = true;
            this.btnCopyAccessKey.Click += new System.EventHandler(this.btnCopyAccessKey_Click);
            // 
            // txtAccessKey
            // 
            this.txtAccessKey.Location = new System.Drawing.Point(122, 84);
            this.txtAccessKey.Name = "txtAccessKey";
            this.txtAccessKey.ReadOnly = true;
            this.txtAccessKey.Size = new System.Drawing.Size(237, 20);
            this.txtAccessKey.TabIndex = 5;
            // 
            // lblAccessKey
            // 
            this.lblAccessKey.AutoSize = true;
            this.lblAccessKey.Location = new System.Drawing.Point(31, 87);
            this.lblAccessKey.Name = "lblAccessKey";
            this.lblAccessKey.Size = new System.Drawing.Size(66, 13);
            this.lblAccessKey.TabIndex = 4;
            this.lblAccessKey.Text = "Access Key:";
            // 
            // chkAllowDroppedItems
            // 
            this.chkAllowDroppedItems.AutoSize = true;
            this.chkAllowDroppedItems.Location = new System.Drawing.Point(35, 206);
            this.chkAllowDroppedItems.Name = "chkAllowDroppedItems";
            this.chkAllowDroppedItems.Size = new System.Drawing.Size(95, 17);
            this.chkAllowDroppedItems.TabIndex = 11;
            this.chkAllowDroppedItems.Text = "Dropped Items";
            this.chkAllowDroppedItems.UseVisualStyleBackColor = true;
            // 
            // chkAllowMapInventories
            // 
            this.chkAllowMapInventories.AutoSize = true;
            this.chkAllowMapInventories.Location = new System.Drawing.Point(35, 183);
            this.chkAllowMapInventories.Name = "chkAllowMapInventories";
            this.chkAllowMapInventories.Size = new System.Drawing.Size(138, 17);
            this.chkAllowMapInventories.TabIndex = 10;
            this.chkAllowMapInventories.Text = "Map Structure Contents";
            this.chkAllowMapInventories.UseVisualStyleBackColor = true;
            // 
            // chkAllowMapStructures
            // 
            this.chkAllowMapStructures.AutoSize = true;
            this.chkAllowMapStructures.Checked = true;
            this.chkAllowMapStructures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowMapStructures.Location = new System.Drawing.Point(35, 160);
            this.chkAllowMapStructures.Name = "chkAllowMapStructures";
            this.chkAllowMapStructures.Size = new System.Drawing.Size(142, 17);
            this.chkAllowMapStructures.TabIndex = 9;
            this.chkAllowMapStructures.Text = "Map Structure Locations";
            this.chkAllowMapStructures.UseVisualStyleBackColor = true;
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Image = global::ARKViewer.Properties.Resources.button_refresh;
            this.btnGenerateKey.Location = new System.Drawing.Point(365, 76);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(35, 35);
            this.btnGenerateKey.TabIndex = 6;
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // udRad
            // 
            this.udRad.DecimalPlaces = 2;
            this.udRad.Location = new System.Drawing.Point(376, 346);
            this.udRad.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.udRad.Name = "udRad";
            this.udRad.Size = new System.Drawing.Size(64, 20);
            this.udRad.TabIndex = 25;
            this.udRad.Value = new decimal(new int[] {
            10000,
            0,
            0,
            131072});
            // 
            // udLon
            // 
            this.udLon.DecimalPlaces = 2;
            this.udLon.Location = new System.Drawing.Point(235, 346);
            this.udLon.Name = "udLon";
            this.udLon.Size = new System.Drawing.Size(64, 20);
            this.udLon.TabIndex = 23;
            this.udLon.Value = new decimal(new int[] {
            5000,
            0,
            0,
            131072});
            // 
            // udLat
            // 
            this.udLat.DecimalPlaces = 2;
            this.udLat.Location = new System.Drawing.Point(84, 346);
            this.udLat.Name = "udLat";
            this.udLat.Size = new System.Drawing.Size(64, 20);
            this.udLat.TabIndex = 21;
            this.udLat.Value = new decimal(new int[] {
            5000,
            0,
            0,
            131072});
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(330, 350);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(43, 13);
            this.lblRadius.TabIndex = 24;
            this.lblRadius.Text = "Radius:";
            // 
            // cboSelectedForPlayerId
            // 
            this.cboSelectedForPlayerId.FormattingEnabled = true;
            this.cboSelectedForPlayerId.Location = new System.Drawing.Point(84, 312);
            this.cboSelectedForPlayerId.Name = "cboSelectedForPlayerId";
            this.cboSelectedForPlayerId.Size = new System.Drawing.Size(355, 21);
            this.cboSelectedForPlayerId.TabIndex = 19;
            // 
            // cboSelectedForTribeId
            // 
            this.cboSelectedForTribeId.FormattingEnabled = true;
            this.cboSelectedForTribeId.Location = new System.Drawing.Point(84, 281);
            this.cboSelectedForTribeId.Name = "cboSelectedForTribeId";
            this.cboSelectedForTribeId.Size = new System.Drawing.Size(355, 21);
            this.cboSelectedForTribeId.TabIndex = 17;
            this.cboSelectedForTribeId.SelectedIndexChanged += new System.EventHandler(this.cboSelectedForTribeId_SelectedIndexChanged);
            // 
            // lblLon
            // 
            this.lblLon.AutoSize = true;
            this.lblLon.Location = new System.Drawing.Point(174, 350);
            this.lblLon.Name = "lblLon";
            this.lblLon.Size = new System.Drawing.Size(57, 13);
            this.lblLon.TabIndex = 22;
            this.lblLon.Text = "Longitude:";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Location = new System.Drawing.Point(31, 350);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(48, 13);
            this.lblLat.TabIndex = 20;
            this.lblLat.Text = "Latitude:";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(31, 315);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(39, 13);
            this.lblPlayer.TabIndex = 18;
            this.lblPlayer.Text = "Player:";
            // 
            // lblTribe
            // 
            this.lblTribe.AutoSize = true;
            this.lblTribe.Location = new System.Drawing.Point(31, 281);
            this.lblTribe.Name = "lblTribe";
            this.lblTribe.Size = new System.Drawing.Size(34, 13);
            this.lblTribe.TabIndex = 16;
            this.lblTribe.Text = "Tribe:";
            // 
            // lblRestrictions
            // 
            this.lblRestrictions.AutoSize = true;
            this.lblRestrictions.BackColor = System.Drawing.Color.Transparent;
            this.lblRestrictions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestrictions.Location = new System.Drawing.Point(14, 250);
            this.lblRestrictions.Name = "lblRestrictions";
            this.lblRestrictions.Size = new System.Drawing.Size(131, 15);
            this.lblRestrictions.TabIndex = 15;
            this.lblRestrictions.Text = "Access Restrictions";
            this.lblRestrictions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkAllowTribeStructures
            // 
            this.chkAllowTribeStructures.AutoSize = true;
            this.chkAllowTribeStructures.Checked = true;
            this.chkAllowTribeStructures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowTribeStructures.Location = new System.Drawing.Point(305, 206);
            this.chkAllowTribeStructures.Name = "chkAllowTribeStructures";
            this.chkAllowTribeStructures.Size = new System.Drawing.Size(106, 17);
            this.chkAllowTribeStructures.TabIndex = 14;
            this.chkAllowTribeStructures.Text = "Player Structures";
            this.chkAllowTribeStructures.UseVisualStyleBackColor = true;
            // 
            // chkAllowTamed
            // 
            this.chkAllowTamed.AutoSize = true;
            this.chkAllowTamed.Checked = true;
            this.chkAllowTamed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowTamed.Location = new System.Drawing.Point(305, 160);
            this.chkAllowTamed.Name = "chkAllowTamed";
            this.chkAllowTamed.Size = new System.Drawing.Size(107, 17);
            this.chkAllowTamed.TabIndex = 12;
            this.chkAllowTamed.Text = "Tamed Creatures";
            this.chkAllowTamed.UseVisualStyleBackColor = true;
            // 
            // chkAllowWild
            // 
            this.chkAllowWild.AutoSize = true;
            this.chkAllowWild.Location = new System.Drawing.Point(305, 183);
            this.chkAllowWild.Name = "chkAllowWild";
            this.chkAllowWild.Size = new System.Drawing.Size(95, 17);
            this.chkAllowWild.TabIndex = 13;
            this.chkAllowWild.Text = "Wild Creatures";
            this.chkAllowWild.UseVisualStyleBackColor = true;
            // 
            // lblHeaderWrapper
            // 
            this.lblHeaderWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderWrapper.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderWrapper.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderWrapper.Name = "lblHeaderWrapper";
            this.lblHeaderWrapper.Size = new System.Drawing.Size(463, 6);
            this.lblHeaderWrapper.TabIndex = 0;
            this.lblHeaderWrapper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccessRights
            // 
            this.lblAccessRights.AutoSize = true;
            this.lblAccessRights.BackColor = System.Drawing.Color.Transparent;
            this.lblAccessRights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessRights.Location = new System.Drawing.Point(15, 133);
            this.lblAccessRights.Name = "lblAccessRights";
            this.lblAccessRights.Size = new System.Drawing.Size(96, 15);
            this.lblAccessRights.TabIndex = 8;
            this.lblAccessRights.Text = "Access Rights";
            this.lblAccessRights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCcancel
            // 
            this.btnCcancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCcancel.Location = new System.Drawing.Point(400, 411);
            this.btnCcancel.Name = "btnCcancel";
            this.btnCcancel.Size = new System.Drawing.Size(75, 23);
            this.btnCcancel.TabIndex = 2;
            this.btnCcancel.Text = "Close";
            this.btnCcancel.UseVisualStyleBackColor = true;
            this.btnCcancel.Click += new System.EventHandler(this.btnCcancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(319, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmClientAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCcancel;
            this.ClientSize = new System.Drawing.Size(486, 446);
            this.Controls.Add(this.btnCcancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpWrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Access  Settings";
            this.grpWrapper.ResumeLayout(false);
            this.grpWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWrapper;
        private System.Windows.Forms.CheckBox chkAllowDroppedItems;
        private System.Windows.Forms.CheckBox chkAllowMapInventories;
        private System.Windows.Forms.CheckBox chkAllowMapStructures;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.NumericUpDown udRad;
        private System.Windows.Forms.NumericUpDown udLon;
        private System.Windows.Forms.NumericUpDown udLat;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.ComboBox cboSelectedForPlayerId;
        private System.Windows.Forms.ComboBox cboSelectedForTribeId;
        private System.Windows.Forms.Label lblLon;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblTribe;
        private System.Windows.Forms.Label lblRestrictions;
        private System.Windows.Forms.CheckBox chkAllowTribeStructures;
        private System.Windows.Forms.CheckBox chkAllowTamed;
        private System.Windows.Forms.CheckBox chkAllowWild;
        private System.Windows.Forms.Label lblHeaderWrapper;
        private System.Windows.Forms.Label lblAccessRights;
        private System.Windows.Forms.Label lblAccessKey;
        private System.Windows.Forms.TextBox txtAccessKey;
        private System.Windows.Forms.Button btnCcancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCopyAccessKey;
        private System.Windows.Forms.Label lblClientAccount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAccountName;
    }
}
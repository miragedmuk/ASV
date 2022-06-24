namespace ArkViewer
{
    partial class ElevationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElevationControl));
            this.btnSave = new System.Windows.Forms.Button();
            this.trackZoom = new System.Windows.Forms.TrackBar();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.cboView = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(559, 545);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 32);
            this.btnSave.TabIndex = 56;
            this.btnSave.TabStop = false;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // trackZoom
            // 
            this.trackZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackZoom.AutoSize = false;
            this.trackZoom.Location = new System.Drawing.Point(4, 553);
            this.trackZoom.Maximum = 100;
            this.trackZoom.Name = "trackZoom";
            this.trackZoom.Size = new System.Drawing.Size(545, 20);
            this.trackZoom.TabIndex = 55;
            this.trackZoom.TickFrequency = 25;
            // 
            // picMap
            // 
            this.picMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMap.BackColor = System.Drawing.Color.Gainsboro;
            this.picMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMap.Location = new System.Drawing.Point(3, 32);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(592, 511);
            this.picMap.TabIndex = 54;
            this.picMap.TabStop = false;
            // 
            // cboView
            // 
            this.cboView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboView.FormattingEnabled = true;
            this.cboView.Items.AddRange(new object[] {
            "Wild Creatures",
            "Tamed Creatures",
            "Item Search",
            "Dropped Items",
            "Player Structures",
            "Tribes",
            "Players"});
            this.cboView.Location = new System.Drawing.Point(4, 4);
            this.cboView.Name = "cboView";
            this.cboView.Size = new System.Drawing.Size(590, 23);
            this.cboView.TabIndex = 53;
            // 
            // ElevationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.trackZoom);
            this.Controls.Add(this.picMap);
            this.Controls.Add(this.cboView);
            this.Name = "ElevationControl";
            this.Size = new System.Drawing.Size(598, 581);
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TrackBar trackZoom;
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.ComboBox cboView;
    }
}

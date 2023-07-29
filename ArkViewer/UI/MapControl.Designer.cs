namespace ArkViewer
{
    partial class MapControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapControl));
            this.cboView = new System.Windows.Forms.ComboBox();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.trackZoom = new System.Windows.Forms.TrackBar();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).BeginInit();
            this.SuspendLayout();
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
            this.cboView.Size = new System.Drawing.Size(651, 23);
            this.cboView.TabIndex = 0;
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
            this.picMap.Size = new System.Drawing.Size(653, 511);
            this.picMap.TabIndex = 1;
            this.picMap.TabStop = false;
            // 
            // trackZoom
            // 
            this.trackZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackZoom.AutoSize = false;
            this.trackZoom.Location = new System.Drawing.Point(4, 553);
            this.trackZoom.Maximum = 100;
            this.trackZoom.Name = "trackZoom";
            this.trackZoom.Size = new System.Drawing.Size(606, 20);
            this.trackZoom.TabIndex = 2;
            this.trackZoom.TickFrequency = 25;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(620, 545);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 32);
            this.btnSave.TabIndex = 52;
            this.btnSave.TabStop = false;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // MapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.trackZoom);
            this.Controls.Add(this.picMap);
            this.Controls.Add(this.cboView);
            this.Name = "MapControl";
            this.Size = new System.Drawing.Size(659, 581);
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboView;
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.TrackBar trackZoom;
        private System.Windows.Forms.Button btnSave;
    }
}

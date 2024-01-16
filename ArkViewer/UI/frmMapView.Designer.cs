
namespace ARKViewer
{
    partial class frmMapView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapView));
            pnlZoom = new System.Windows.Forms.Panel();
            trackZoom = new System.Windows.Forms.TrackBar();
            pnlMap = new System.Windows.Forms.Panel();
            picMap = new System.Windows.Forms.PictureBox();
            btnMapMarkers = new System.Windows.Forms.Button();
            btnMapStructures = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            picIcon = new System.Windows.Forms.PictureBox();
            btnSave = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            toolTip2 = new System.Windows.Forms.ToolTip(components);
            pnlZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackZoom).BeginInit();
            pnlMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlZoom
            // 
            pnlZoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlZoom.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            pnlZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlZoom.Controls.Add(trackZoom);
            pnlZoom.Location = new System.Drawing.Point(5, 648);
            pnlZoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlZoom.Name = "pnlZoom";
            pnlZoom.Size = new System.Drawing.Size(642, 30);
            pnlZoom.TabIndex = 46;
            // 
            // trackZoom
            // 
            trackZoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            trackZoom.AutoSize = false;
            trackZoom.LargeChange = 10;
            trackZoom.Location = new System.Drawing.Point(12, 1);
            trackZoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            trackZoom.Maximum = 200;
            trackZoom.Minimum = 1;
            trackZoom.Name = "trackZoom";
            trackZoom.Size = new System.Drawing.Size(625, 27);
            trackZoom.TabIndex = 3;
            trackZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            trackZoom.Value = 5;
            trackZoom.Scroll += trackZoom_Scroll;
            trackZoom.ValueChanged += trackZoom_ValueChanged;
            // 
            // pnlMap
            // 
            pnlMap.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlMap.AutoScroll = true;
            pnlMap.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            pnlMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMap.Controls.Add(picMap);
            pnlMap.Location = new System.Drawing.Point(5, 74);
            pnlMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlMap.Name = "pnlMap";
            pnlMap.Size = new System.Drawing.Size(642, 571);
            pnlMap.TabIndex = 42;
            // 
            // picMap
            // 
            picMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picMap.Location = new System.Drawing.Point(2, 2);
            picMap.Margin = new System.Windows.Forms.Padding(0);
            picMap.Name = "picMap";
            picMap.Size = new System.Drawing.Size(298, 295);
            picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picMap.TabIndex = 1;
            picMap.TabStop = false;
            picMap.MouseClick += picMap_MouseClick;
            picMap.MouseDown += picMap_MouseDown;
            picMap.MouseHover += picMap_MouseHover;
            picMap.MouseMove += picMap_MouseMove;
            // 
            // btnMapMarkers
            // 
            btnMapMarkers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnMapMarkers.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnMapMarkers.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMapMarkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMapMarkers.Image = (System.Drawing.Image)resources.GetObject("btnMapMarkers.Image");
            btnMapMarkers.Location = new System.Drawing.Point(524, 9);
            btnMapMarkers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMapMarkers.Name = "btnMapMarkers";
            btnMapMarkers.Size = new System.Drawing.Size(58, 58);
            btnMapMarkers.TabIndex = 48;
            btnMapMarkers.TabStop = false;
            toolTip1.SetToolTip(btnMapMarkers, "Show custom map markers.");
            btnMapMarkers.UseVisualStyleBackColor = false;
            btnMapMarkers.Click += btnMapMarkers_Click;
            // 
            // btnMapStructures
            // 
            btnMapStructures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnMapStructures.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnMapStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMapStructures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMapStructures.Image = (System.Drawing.Image)resources.GetObject("btnMapStructures.Image");
            btnMapStructures.Location = new System.Drawing.Point(458, 9);
            btnMapStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMapStructures.Name = "btnMapStructures";
            btnMapStructures.Size = new System.Drawing.Size(58, 58);
            btnMapStructures.TabIndex = 47;
            btnMapStructures.TabStop = false;
            toolTip1.SetToolTip(btnMapStructures, "Show map structures options.");
            btnMapStructures.UseVisualStyleBackColor = false;
            btnMapStructures.Click += btnMapStructures_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblTitle.Location = new System.Drawing.Point(66, 14);
            lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(140, 31);
            lblTitle.TabIndex = 49;
            lblTitle.Text = "Map View";
            // 
            // picIcon
            // 
            picIcon.Image = (System.Drawing.Image)resources.GetObject("picIcon.Image");
            picIcon.Location = new System.Drawing.Point(5, 9);
            picIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            picIcon.Name = "picIcon";
            picIcon.Size = new System.Drawing.Size(58, 58);
            picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picIcon.TabIndex = 50;
            picIcon.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSave.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.Enabled = false;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Image = (System.Drawing.Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new System.Drawing.Point(589, 9);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(58, 58);
            btnSave.TabIndex = 51;
            btnSave.TabStop = false;
            toolTip1.SetToolTip(btnSave, "Save map image.");
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // toolTip1
            // 
            toolTip1.StripAmpersands = true;
            // 
            // toolTip2
            // 
            toolTip2.StripAmpersands = true;
            // 
            // frmMapView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            ClientSize = new System.Drawing.Size(653, 685);
            Controls.Add(btnSave);
            Controls.Add(picIcon);
            Controls.Add(lblTitle);
            Controls.Add(btnMapMarkers);
            Controls.Add(btnMapStructures);
            Controls.Add(pnlMap);
            Controls.Add(pnlZoom);
            ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(464, 456);
            Name = "frmMapView";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Map View";
            FormClosed += frmMapView_FormClosed;
            pnlZoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackZoom).EndInit();
            pnlMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.Panel pnlZoom;
        private System.Windows.Forms.TrackBar trackZoom;
        private System.Windows.Forms.Button btnMapMarkers;
        private System.Windows.Forms.Button btnMapStructures;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}
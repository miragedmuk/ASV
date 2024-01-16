
namespace ARKViewer
{
    partial class frmMapToolboxMarkers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapToolboxMarkers));
            lvwMapMarkers = new System.Windows.Forms.ListView();
            lvwMapMarkers_Name = new System.Windows.Forms.ColumnHeader();
            lvwMapMarkers_Lat = new System.Windows.Forms.ColumnHeader();
            lvwMapMarkers_Lon = new System.Windows.Forms.ColumnHeader();
            btnRemoveMarker = new System.Windows.Forms.Button();
            chkApplyFilterMarkers = new System.Windows.Forms.CheckBox();
            btnAddMarker = new System.Windows.Forms.Button();
            btnEditMarker = new System.Windows.Forms.Button();
            txtMarkerFilter = new System.Windows.Forms.TextBox();
            cboCategory = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lvwMapMarkers
            // 
            lvwMapMarkers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwMapMarkers.BackColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lvwMapMarkers.CheckBoxes = true;
            lvwMapMarkers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvwMapMarkers_Name, lvwMapMarkers_Lat, lvwMapMarkers_Lon });
            lvwMapMarkers.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwMapMarkers.FullRowSelect = true;
            lvwMapMarkers.Location = new System.Drawing.Point(7, 52);
            lvwMapMarkers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwMapMarkers.Name = "lvwMapMarkers";
            lvwMapMarkers.Size = new System.Drawing.Size(350, 440);
            lvwMapMarkers.TabIndex = 0;
            lvwMapMarkers.UseCompatibleStateImageBehavior = false;
            lvwMapMarkers.View = System.Windows.Forms.View.Details;
            lvwMapMarkers.ColumnClick += lvwMapMarkers_ColumnClick;
            lvwMapMarkers.ItemChecked += lvwMapMarkers_ItemChecked;
            lvwMapMarkers.SelectedIndexChanged += lvwMapMarkers_SelectedIndexChanged;
            // 
            // lvwMapMarkers_Name
            // 
            lvwMapMarkers_Name.Text = "Name";
            lvwMapMarkers_Name.Width = 167;
            // 
            // lvwMapMarkers_Lat
            // 
            lvwMapMarkers_Lat.Text = "Lat";
            // 
            // lvwMapMarkers_Lon
            // 
            lvwMapMarkers_Lon.Text = "Lon";
            // 
            // btnRemoveMarker
            // 
            btnRemoveMarker.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRemoveMarker.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRemoveMarker.Enabled = false;
            btnRemoveMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveMarker.Image = (System.Drawing.Image)resources.GetObject("btnRemoveMarker.Image");
            btnRemoveMarker.Location = new System.Drawing.Point(49, 504);
            btnRemoveMarker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveMarker.Name = "btnRemoveMarker";
            btnRemoveMarker.Size = new System.Drawing.Size(35, 35);
            btnRemoveMarker.TabIndex = 2;
            btnRemoveMarker.UseVisualStyleBackColor = false;
            btnRemoveMarker.Click += btnRemoveMarker_Click;
            // 
            // chkApplyFilterMarkers
            // 
            chkApplyFilterMarkers.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            chkApplyFilterMarkers.Appearance = System.Windows.Forms.Appearance.Button;
            chkApplyFilterMarkers.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            chkApplyFilterMarkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkApplyFilterMarkers.Image = (System.Drawing.Image)resources.GetObject("chkApplyFilterMarkers.Image");
            chkApplyFilterMarkers.Location = new System.Drawing.Point(279, 504);
            chkApplyFilterMarkers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkApplyFilterMarkers.Name = "chkApplyFilterMarkers";
            chkApplyFilterMarkers.Size = new System.Drawing.Size(35, 35);
            chkApplyFilterMarkers.TabIndex = 4;
            chkApplyFilterMarkers.UseVisualStyleBackColor = false;
            chkApplyFilterMarkers.CheckedChanged += chkApplyFilterMarkers_CheckedChanged;
            // 
            // btnAddMarker
            // 
            btnAddMarker.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAddMarker.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnAddMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddMarker.Image = (System.Drawing.Image)resources.GetObject("btnAddMarker.Image");
            btnAddMarker.Location = new System.Drawing.Point(7, 504);
            btnAddMarker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddMarker.Name = "btnAddMarker";
            btnAddMarker.Size = new System.Drawing.Size(35, 35);
            btnAddMarker.TabIndex = 1;
            btnAddMarker.UseVisualStyleBackColor = false;
            btnAddMarker.Click += btnAddMarker_Click;
            // 
            // btnEditMarker
            // 
            btnEditMarker.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnEditMarker.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnEditMarker.Enabled = false;
            btnEditMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditMarker.Image = (System.Drawing.Image)resources.GetObject("btnEditMarker.Image");
            btnEditMarker.Location = new System.Drawing.Point(323, 504);
            btnEditMarker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditMarker.Name = "btnEditMarker";
            btnEditMarker.Size = new System.Drawing.Size(35, 35);
            btnEditMarker.TabIndex = 5;
            btnEditMarker.UseVisualStyleBackColor = false;
            btnEditMarker.Click += btnEditMarker_Click;
            // 
            // txtMarkerFilter
            // 
            txtMarkerFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMarkerFilter.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtMarkerFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtMarkerFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMarkerFilter.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtMarkerFilter.Location = new System.Drawing.Point(94, 509);
            txtMarkerFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMarkerFilter.Multiline = true;
            txtMarkerFilter.Name = "txtMarkerFilter";
            txtMarkerFilter.Size = new System.Drawing.Size(177, 23);
            txtMarkerFilter.TabIndex = 3;
            // 
            // cboCategory
            // 
            cboCategory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboCategory.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboCategory.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new System.Drawing.Point(88, 15);
            cboCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new System.Drawing.Size(270, 23);
            cboCategory.TabIndex = 6;
            cboCategory.DrawItem += ownerDrawCombo_DrawItem;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            label1.Location = new System.Drawing.Point(13, 18);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 13);
            label1.TabIndex = 7;
            label1.Text = "Category:";
            // 
            // frmMapToolboxMarkers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            ClientSize = new System.Drawing.Size(366, 546);
            Controls.Add(label1);
            Controls.Add(cboCategory);
            Controls.Add(lvwMapMarkers);
            Controls.Add(btnRemoveMarker);
            Controls.Add(chkApplyFilterMarkers);
            Controls.Add(btnAddMarker);
            Controls.Add(btnEditMarker);
            Controls.Add(txtMarkerFilter);
            ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(382, 225);
            Name = "frmMapToolboxMarkers";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Custom Map Markers";
            FormClosed += frmMapToolboxMarkers_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView lvwMapMarkers;
        private System.Windows.Forms.ColumnHeader lvwMapMarkers_Name;
        private System.Windows.Forms.ColumnHeader lvwMapMarkers_Lat;
        private System.Windows.Forms.ColumnHeader lvwMapMarkers_Lon;
        private System.Windows.Forms.Button btnRemoveMarker;
        private System.Windows.Forms.CheckBox chkApplyFilterMarkers;
        private System.Windows.Forms.Button btnAddMarker;
        private System.Windows.Forms.Button btnEditMarker;
        private System.Windows.Forms.TextBox txtMarkerFilter;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label1;
    }
}
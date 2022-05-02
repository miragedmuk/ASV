
namespace ARKViewer
{
    partial class frmColourPicker
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
            this.grpColours = new System.Windows.Forms.GroupBox();
            this.lblKnownColours = new System.Windows.Forms.Label();
            this.chkApplyFilterColours = new System.Windows.Forms.CheckBox();
            this.lblHeaderColours = new System.Windows.Forms.Label();
            this.txtFilterColour = new System.Windows.Forms.TextBox();
            this.lvwColours = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpColours.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpColours
            // 
            this.grpColours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpColours.Controls.Add(this.lblKnownColours);
            this.grpColours.Controls.Add(this.chkApplyFilterColours);
            this.grpColours.Controls.Add(this.lblHeaderColours);
            this.grpColours.Controls.Add(this.txtFilterColour);
            this.grpColours.Controls.Add(this.lvwColours);
            this.grpColours.Location = new System.Drawing.Point(9, 6);
            this.grpColours.Name = "grpColours";
            this.grpColours.Size = new System.Drawing.Size(315, 332);
            this.grpColours.TabIndex = 1;
            this.grpColours.TabStop = false;
            // 
            // lblKnownColours
            // 
            this.lblKnownColours.BackColor = System.Drawing.Color.Transparent;
            this.lblKnownColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKnownColours.Location = new System.Drawing.Point(10, 16);
            this.lblKnownColours.Name = "lblKnownColours";
            this.lblKnownColours.Size = new System.Drawing.Size(198, 22);
            this.lblKnownColours.TabIndex = 0;
            this.lblKnownColours.Text = "Known Colours";
            this.lblKnownColours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkApplyFilterColours
            // 
            this.chkApplyFilterColours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkApplyFilterColours.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkApplyFilterColours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkApplyFilterColours.Image = global::ARKViewer.Properties.Resources.button_filter;
            this.chkApplyFilterColours.Location = new System.Drawing.Point(270, 287);
            this.chkApplyFilterColours.Name = "chkApplyFilterColours";
            this.chkApplyFilterColours.Size = new System.Drawing.Size(35, 35);
            this.chkApplyFilterColours.TabIndex = 5;
            this.chkApplyFilterColours.UseVisualStyleBackColor = true;
            this.chkApplyFilterColours.CheckedChanged += new System.EventHandler(this.chkApplyFilterColours_CheckedChanged);
            // 
            // lblHeaderColours
            // 
            this.lblHeaderColours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderColours.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderColours.Location = new System.Drawing.Point(-2, 3);
            this.lblHeaderColours.Name = "lblHeaderColours";
            this.lblHeaderColours.Size = new System.Drawing.Size(318, 6);
            this.lblHeaderColours.TabIndex = 0;
            this.lblHeaderColours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFilterColour
            // 
            this.txtFilterColour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterColour.Location = new System.Drawing.Point(13, 294);
            this.txtFilterColour.Name = "txtFilterColour";
            this.txtFilterColour.Size = new System.Drawing.Size(251, 20);
            this.txtFilterColour.TabIndex = 4;
            // 
            // lvwColours
            // 
            this.lvwColours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwColours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader7,
            this.columnHeader8});
            this.lvwColours.FullRowSelect = true;
            this.lvwColours.HideSelection = false;
            this.lvwColours.Location = new System.Drawing.Point(13, 45);
            this.lvwColours.Name = "lvwColours";
            this.lvwColours.Size = new System.Drawing.Size(292, 236);
            this.lvwColours.TabIndex = 1;
            this.lvwColours.UseCompatibleStateImageBehavior = false;
            this.lvwColours.View = System.Windows.Forms.View.Details;
            this.lvwColours.SelectedIndexChanged += new System.EventHandler(this.lvwColours_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Hex";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Colour";
            this.columnHeader8.Width = 100;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(169, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Select";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.Location = new System.Drawing.Point(250, 347);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmColourPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 384);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpColours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmColourPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colour Picker";
            this.grpColours.ResumeLayout(false);
            this.grpColours.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpColours;
        private System.Windows.Forms.Label lblKnownColours;
        private System.Windows.Forms.CheckBox chkApplyFilterColours;
        private System.Windows.Forms.Label lblHeaderColours;
        private System.Windows.Forms.TextBox txtFilterColour;
        private System.Windows.Forms.ListView lvwColours;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColourPicker));
            grpColours = new System.Windows.Forms.GroupBox();
            lblKnownColours = new System.Windows.Forms.Label();
            chkApplyFilterColours = new System.Windows.Forms.CheckBox();
            lblHeaderColours = new System.Windows.Forms.Label();
            txtFilterColour = new System.Windows.Forms.TextBox();
            lvwColours = new System.Windows.Forms.ListView();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            columnHeader8 = new System.Windows.Forms.ColumnHeader();
            btnSave = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            grpColours.SuspendLayout();
            SuspendLayout();
            // 
            // grpColours
            // 
            grpColours.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpColours.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpColours.Controls.Add(lblKnownColours);
            grpColours.Controls.Add(chkApplyFilterColours);
            grpColours.Controls.Add(lblHeaderColours);
            grpColours.Controls.Add(txtFilterColour);
            grpColours.Controls.Add(lvwColours);
            grpColours.Location = new System.Drawing.Point(10, 7);
            grpColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpColours.Name = "grpColours";
            grpColours.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpColours.Size = new System.Drawing.Size(368, 383);
            grpColours.TabIndex = 1;
            grpColours.TabStop = false;
            // 
            // lblKnownColours
            // 
            lblKnownColours.BackColor = System.Drawing.Color.Transparent;
            lblKnownColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblKnownColours.Location = new System.Drawing.Point(12, 18);
            lblKnownColours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblKnownColours.Name = "lblKnownColours";
            lblKnownColours.Size = new System.Drawing.Size(231, 25);
            lblKnownColours.TabIndex = 0;
            lblKnownColours.Text = "Known Colours";
            lblKnownColours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkApplyFilterColours
            // 
            chkApplyFilterColours.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            chkApplyFilterColours.Appearance = System.Windows.Forms.Appearance.Button;
            chkApplyFilterColours.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            chkApplyFilterColours.Cursor = System.Windows.Forms.Cursors.Hand;
            chkApplyFilterColours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkApplyFilterColours.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            chkApplyFilterColours.Image = (System.Drawing.Image)resources.GetObject("chkApplyFilterColours.Image");
            chkApplyFilterColours.Location = new System.Drawing.Point(315, 331);
            chkApplyFilterColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkApplyFilterColours.Name = "chkApplyFilterColours";
            chkApplyFilterColours.Size = new System.Drawing.Size(41, 40);
            chkApplyFilterColours.TabIndex = 5;
            chkApplyFilterColours.UseVisualStyleBackColor = false;
            chkApplyFilterColours.CheckedChanged += chkApplyFilterColours_CheckedChanged;
            // 
            // lblHeaderColours
            // 
            lblHeaderColours.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderColours.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderColours.Location = new System.Drawing.Point(-2, 1);
            lblHeaderColours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderColours.Name = "lblHeaderColours";
            lblHeaderColours.Size = new System.Drawing.Size(371, 7);
            lblHeaderColours.TabIndex = 0;
            lblHeaderColours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFilterColour
            // 
            txtFilterColour.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFilterColour.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtFilterColour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFilterColour.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFilterColour.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtFilterColour.Location = new System.Drawing.Point(15, 339);
            txtFilterColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilterColour.Name = "txtFilterColour";
            txtFilterColour.Size = new System.Drawing.Size(292, 20);
            txtFilterColour.TabIndex = 4;
            // 
            // lvwColours
            // 
            lvwColours.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwColours.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwColours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader4, columnHeader7, columnHeader8 });
            lvwColours.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwColours.FullRowSelect = true;
            lvwColours.Location = new System.Drawing.Point(15, 52);
            lvwColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwColours.Name = "lvwColours";
            lvwColours.Size = new System.Drawing.Size(340, 272);
            lvwColours.TabIndex = 1;
            lvwColours.UseCompatibleStateImageBehavior = false;
            lvwColours.View = System.Windows.Forms.View.Details;
            lvwColours.SelectedIndexChanged += lvwColours_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Id";
            columnHeader4.Width = 50;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Hex";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Colour";
            columnHeader8.Width = 100;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnSave.Enabled = false;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnSave.Location = new System.Drawing.Point(197, 400);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(88, 27);
            btnSave.TabIndex = 3;
            btnSave.Text = "Select";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnClose.Location = new System.Drawing.Point(292, 400);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(88, 27);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // frmColourPicker
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            ClientSize = new System.Drawing.Size(391, 443);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(grpColours);
            ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmColourPicker";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Colour Picker";
            grpColours.ResumeLayout(false);
            grpColours.PerformLayout();
            ResumeLayout(false);
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
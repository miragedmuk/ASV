
namespace ARKViewer
{
    partial class frmColourEditor
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
            lblRGB = new System.Windows.Forms.Label();
            lblColourId = new System.Windows.Forms.Label();
            btnCcancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            udId = new System.Windows.Forms.NumericUpDown();
            lblColour = new System.Windows.Forms.Label();
            pnlColour = new System.Windows.Forms.Panel();
            udR = new System.Windows.Forms.NumericUpDown();
            udG = new System.Windows.Forms.NumericUpDown();
            udB = new System.Windows.Forms.NumericUpDown();
            grpWrapper = new System.Windows.Forms.GroupBox();
            lblColourDetails = new System.Windows.Forms.Label();
            lblHeaderWrapper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)udId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udB).BeginInit();
            grpWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // lblRGB
            // 
            lblRGB.BackColor = System.Drawing.SystemColors.Control;
            lblRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRGB.ForeColor = System.Drawing.Color.DimGray;
            lblRGB.Location = new System.Drawing.Point(28, 110);
            lblRGB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRGB.Name = "lblRGB";
            lblRGB.Size = new System.Drawing.Size(341, 27);
            lblRGB.TabIndex = 2;
            lblRGB.Text = "RGB";
            lblRGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColourId
            // 
            lblColourId.BackColor = System.Drawing.SystemColors.Control;
            lblColourId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblColourId.ForeColor = System.Drawing.Color.DimGray;
            lblColourId.Location = new System.Drawing.Point(28, 50);
            lblColourId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblColourId.Name = "lblColourId";
            lblColourId.Size = new System.Drawing.Size(341, 27);
            lblColourId.TabIndex = 0;
            lblColourId.Text = "Id";
            lblColourId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCcancel
            // 
            btnCcancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCcancel.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnCcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCcancel.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnCcancel.Location = new System.Drawing.Point(327, 294);
            btnCcancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCcancel.Name = "btnCcancel";
            btnCcancel.Size = new System.Drawing.Size(88, 27);
            btnCcancel.TabIndex = 2;
            btnCcancel.Text = "Close";
            btnCcancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnSave.Location = new System.Drawing.Point(230, 294);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(88, 27);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // udId
            // 
            udId.Location = new System.Drawing.Point(28, 81);
            udId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udId.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            udId.Name = "udId";
            udId.Size = new System.Drawing.Size(341, 23);
            udId.TabIndex = 1;
            udId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            udId.ValueChanged += udId_ValueChanged;
            // 
            // lblColour
            // 
            lblColour.BackColor = System.Drawing.SystemColors.Control;
            lblColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblColour.ForeColor = System.Drawing.Color.DimGray;
            lblColour.Location = new System.Drawing.Point(28, 174);
            lblColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblColour.Name = "lblColour";
            lblColour.Size = new System.Drawing.Size(341, 27);
            lblColour.TabIndex = 6;
            lblColour.Text = "Colour";
            lblColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlColour
            // 
            pnlColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlColour.Location = new System.Drawing.Point(28, 205);
            pnlColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlColour.Name = "pnlColour";
            pnlColour.Size = new System.Drawing.Size(341, 29);
            pnlColour.TabIndex = 7;
            pnlColour.Click += pnlColour_Click;
            pnlColour.Paint += pnlColour_Paint;
            // 
            // udR
            // 
            udR.Location = new System.Drawing.Point(31, 143);
            udR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udR.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            udR.Name = "udR";
            udR.Size = new System.Drawing.Size(107, 23);
            udR.TabIndex = 3;
            udR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            udR.ValueChanged += udR_ValueChanged;
            // 
            // udG
            // 
            udG.Location = new System.Drawing.Point(145, 143);
            udG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udG.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            udG.Name = "udG";
            udG.Size = new System.Drawing.Size(107, 23);
            udG.TabIndex = 4;
            udG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            udG.ValueChanged += udG_ValueChanged;
            // 
            // udB
            // 
            udB.Location = new System.Drawing.Point(259, 143);
            udB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udB.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            udB.Name = "udB";
            udB.Size = new System.Drawing.Size(107, 23);
            udB.TabIndex = 5;
            udB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            udB.ValueChanged += udB_ValueChanged;
            // 
            // grpWrapper
            // 
            grpWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpWrapper.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpWrapper.Controls.Add(lblColourDetails);
            grpWrapper.Controls.Add(udB);
            grpWrapper.Controls.Add(lblHeaderWrapper);
            grpWrapper.Controls.Add(udG);
            grpWrapper.Controls.Add(lblColourId);
            grpWrapper.Controls.Add(udR);
            grpWrapper.Controls.Add(lblRGB);
            grpWrapper.Controls.Add(pnlColour);
            grpWrapper.Controls.Add(udId);
            grpWrapper.Controls.Add(lblColour);
            grpWrapper.Location = new System.Drawing.Point(14, 14);
            grpWrapper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpWrapper.Name = "grpWrapper";
            grpWrapper.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpWrapper.Size = new System.Drawing.Size(398, 261);
            grpWrapper.TabIndex = 0;
            grpWrapper.TabStop = false;
            // 
            // lblColourDetails
            // 
            lblColourDetails.AutoSize = true;
            lblColourDetails.BackColor = System.Drawing.Color.Transparent;
            lblColourDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblColourDetails.Location = new System.Drawing.Point(13, 20);
            lblColourDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblColourDetails.Name = "lblColourDetails";
            lblColourDetails.Size = new System.Drawing.Size(98, 15);
            lblColourDetails.TabIndex = 1;
            lblColourDetails.Text = "Colour Details";
            lblColourDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderWrapper
            // 
            lblHeaderWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderWrapper.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderWrapper.Location = new System.Drawing.Point(0, 1);
            lblHeaderWrapper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderWrapper.Name = "lblHeaderWrapper";
            lblHeaderWrapper.Size = new System.Drawing.Size(400, 8);
            lblHeaderWrapper.TabIndex = 0;
            lblHeaderWrapper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmColourEditor
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            CancelButton = btnCcancel;
            ClientSize = new System.Drawing.Size(429, 335);
            Controls.Add(grpWrapper);
            Controls.Add(btnCcancel);
            Controls.Add(btnSave);
            ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmColourEditor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Colour Editor";
            FormClosed += frmColourEditor_FormClosed;
            ((System.ComponentModel.ISupportInitialize)udId).EndInit();
            ((System.ComponentModel.ISupportInitialize)udR).EndInit();
            ((System.ComponentModel.ISupportInitialize)udG).EndInit();
            ((System.ComponentModel.ISupportInitialize)udB).EndInit();
            grpWrapper.ResumeLayout(false);
            grpWrapper.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label lblRGB;
        private System.Windows.Forms.Label lblColourId;
        private System.Windows.Forms.Button btnCcancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown udId;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Panel pnlColour;
        private System.Windows.Forms.NumericUpDown udR;
        private System.Windows.Forms.NumericUpDown udG;
        private System.Windows.Forms.NumericUpDown udB;
        private System.Windows.Forms.GroupBox grpWrapper;
        private System.Windows.Forms.Label lblColourDetails;
        private System.Windows.Forms.Label lblHeaderWrapper;
    }
}
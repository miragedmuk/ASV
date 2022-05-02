
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
            this.lblRGB = new System.Windows.Forms.Label();
            this.lblColourId = new System.Windows.Forms.Label();
            this.btnCcancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.udId = new System.Windows.Forms.NumericUpDown();
            this.lblColour = new System.Windows.Forms.Label();
            this.pnlColour = new System.Windows.Forms.Panel();
            this.udR = new System.Windows.Forms.NumericUpDown();
            this.udG = new System.Windows.Forms.NumericUpDown();
            this.udB = new System.Windows.Forms.NumericUpDown();
            this.grpWrapper = new System.Windows.Forms.GroupBox();
            this.lblColourDetails = new System.Windows.Forms.Label();
            this.lblHeaderWrapper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udB)).BeginInit();
            this.grpWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRGB
            // 
            this.lblRGB.BackColor = System.Drawing.SystemColors.Control;
            this.lblRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGB.ForeColor = System.Drawing.Color.DimGray;
            this.lblRGB.Location = new System.Drawing.Point(24, 95);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(292, 23);
            this.lblRGB.TabIndex = 2;
            this.lblRGB.Text = "RGB";
            this.lblRGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColourId
            // 
            this.lblColourId.BackColor = System.Drawing.SystemColors.Control;
            this.lblColourId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourId.ForeColor = System.Drawing.Color.DimGray;
            this.lblColourId.Location = new System.Drawing.Point(23, 43);
            this.lblColourId.Name = "lblColourId";
            this.lblColourId.Size = new System.Drawing.Size(278, 23);
            this.lblColourId.TabIndex = 0;
            this.lblColourId.Text = "Id";
            this.lblColourId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCcancel
            // 
            this.btnCcancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCcancel.Location = new System.Drawing.Point(280, 255);
            this.btnCcancel.Name = "btnCcancel";
            this.btnCcancel.Size = new System.Drawing.Size(75, 23);
            this.btnCcancel.TabIndex = 2;
            this.btnCcancel.Text = "Close";
            this.btnCcancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(197, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // udId
            // 
            this.udId.Location = new System.Drawing.Point(24, 70);
            this.udId.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.udId.Name = "udId";
            this.udId.Size = new System.Drawing.Size(290, 20);
            this.udId.TabIndex = 1;
            this.udId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udId.ValueChanged += new System.EventHandler(this.udId_ValueChanged);
            // 
            // lblColour
            // 
            this.lblColour.BackColor = System.Drawing.SystemColors.Control;
            this.lblColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.ForeColor = System.Drawing.Color.DimGray;
            this.lblColour.Location = new System.Drawing.Point(24, 151);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(292, 23);
            this.lblColour.TabIndex = 6;
            this.lblColour.Text = "Colour";
            this.lblColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlColour
            // 
            this.pnlColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColour.Location = new System.Drawing.Point(24, 178);
            this.pnlColour.Name = "pnlColour";
            this.pnlColour.Size = new System.Drawing.Size(290, 25);
            this.pnlColour.TabIndex = 7;
            this.pnlColour.Click += new System.EventHandler(this.pnlColour_Click);
            // 
            // udR
            // 
            this.udR.Location = new System.Drawing.Point(27, 121);
            this.udR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udR.Name = "udR";
            this.udR.Size = new System.Drawing.Size(92, 20);
            this.udR.TabIndex = 3;
            this.udR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udR.ValueChanged += new System.EventHandler(this.udR_ValueChanged);
            // 
            // udG
            // 
            this.udG.Location = new System.Drawing.Point(124, 121);
            this.udG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udG.Name = "udG";
            this.udG.Size = new System.Drawing.Size(92, 20);
            this.udG.TabIndex = 4;
            this.udG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udG.ValueChanged += new System.EventHandler(this.udG_ValueChanged);
            // 
            // udB
            // 
            this.udB.Location = new System.Drawing.Point(222, 121);
            this.udB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udB.Name = "udB";
            this.udB.Size = new System.Drawing.Size(92, 20);
            this.udB.TabIndex = 5;
            this.udB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udB.ValueChanged += new System.EventHandler(this.udB_ValueChanged);
            // 
            // grpWrapper
            // 
            this.grpWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpWrapper.Controls.Add(this.lblColourDetails);
            this.grpWrapper.Controls.Add(this.udB);
            this.grpWrapper.Controls.Add(this.lblHeaderWrapper);
            this.grpWrapper.Controls.Add(this.udG);
            this.grpWrapper.Controls.Add(this.lblColourId);
            this.grpWrapper.Controls.Add(this.udR);
            this.grpWrapper.Controls.Add(this.lblRGB);
            this.grpWrapper.Controls.Add(this.pnlColour);
            this.grpWrapper.Controls.Add(this.udId);
            this.grpWrapper.Controls.Add(this.lblColour);
            this.grpWrapper.Location = new System.Drawing.Point(12, 12);
            this.grpWrapper.Name = "grpWrapper";
            this.grpWrapper.Size = new System.Drawing.Size(341, 226);
            this.grpWrapper.TabIndex = 0;
            this.grpWrapper.TabStop = false;
            // 
            // lblColourDetails
            // 
            this.lblColourDetails.AutoSize = true;
            this.lblColourDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblColourDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourDetails.Location = new System.Drawing.Point(11, 17);
            this.lblColourDetails.Name = "lblColourDetails";
            this.lblColourDetails.Size = new System.Drawing.Size(98, 15);
            this.lblColourDetails.TabIndex = 1;
            this.lblColourDetails.Text = "Colour Details";
            this.lblColourDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderWrapper
            // 
            this.lblHeaderWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderWrapper.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderWrapper.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderWrapper.Name = "lblHeaderWrapper";
            this.lblHeaderWrapper.Size = new System.Drawing.Size(343, 6);
            this.lblHeaderWrapper.TabIndex = 0;
            this.lblHeaderWrapper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmColourEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCcancel;
            this.ClientSize = new System.Drawing.Size(368, 290);
            this.Controls.Add(this.grpWrapper);
            this.Controls.Add(this.btnCcancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmColourEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colour Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmColourEditor_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.udId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udB)).EndInit();
            this.grpWrapper.ResumeLayout(false);
            this.grpWrapper.PerformLayout();
            this.ResumeLayout(false);

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
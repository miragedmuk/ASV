
namespace ARKViewer
{
    partial class frmAddLocalARK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLocalARK));
            this.grpWrapper = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClusterFolder = new System.Windows.Forms.Button();
            this.txtClusterFolder = new System.Windows.Forms.TextBox();
            this.lblOfflineName = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddARK = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWrapper
            // 
            this.grpWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpWrapper.Controls.Add(this.label1);
            this.grpWrapper.Controls.Add(this.btnClusterFolder);
            this.grpWrapper.Controls.Add(this.txtClusterFolder);
            this.grpWrapper.Controls.Add(this.lblOfflineName);
            this.grpWrapper.Controls.Add(this.lblFilename);
            this.grpWrapper.Controls.Add(this.txtName);
            this.grpWrapper.Controls.Add(this.btnAddARK);
            this.grpWrapper.Controls.Add(this.txtFilename);
            this.grpWrapper.Controls.Add(this.lblHeader);
            this.grpWrapper.Location = new System.Drawing.Point(14, 10);
            this.grpWrapper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpWrapper.Name = "grpWrapper";
            this.grpWrapper.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpWrapper.Size = new System.Drawing.Size(478, 217);
            this.grpWrapper.TabIndex = 6;
            this.grpWrapper.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cluster Folder";
            // 
            // btnClusterFolder
            // 
            this.btnClusterFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClusterFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClusterFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnClusterFolder.Image")));
            this.btnClusterFolder.Location = new System.Drawing.Point(415, 104);
            this.btnClusterFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClusterFolder.Name = "btnClusterFolder";
            this.btnClusterFolder.Size = new System.Drawing.Size(41, 40);
            this.btnClusterFolder.TabIndex = 7;
            this.btnClusterFolder.UseVisualStyleBackColor = true;
            this.btnClusterFolder.Click += new System.EventHandler(this.btnClusterFolder_Click);
            // 
            // txtClusterFolder
            // 
            this.txtClusterFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClusterFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClusterFolder.Location = new System.Drawing.Point(23, 111);
            this.txtClusterFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClusterFolder.Name = "txtClusterFolder";
            this.txtClusterFolder.ReadOnly = true;
            this.txtClusterFolder.Size = new System.Drawing.Size(384, 22);
            this.txtClusterFolder.TabIndex = 6;
            // 
            // lblOfflineName
            // 
            this.lblOfflineName.AutoSize = true;
            this.lblOfflineName.Location = new System.Drawing.Point(21, 154);
            this.lblOfflineName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOfflineName.Name = "lblOfflineName";
            this.lblOfflineName.Size = new System.Drawing.Size(78, 15);
            this.lblOfflineName.TabIndex = 5;
            this.lblOfflineName.Text = "Offline Name";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(21, 30);
            this.lblFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(55, 15);
            this.lblFilename.TabIndex = 4;
            this.lblFilename.Text = "Filename";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(21, 174);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(384, 23);
            this.txtName.TabIndex = 3;
            // 
            // btnAddARK
            // 
            this.btnAddARK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddARK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddARK.Image = ((System.Drawing.Image)(resources.GetObject("btnAddARK.Image")));
            this.btnAddARK.Location = new System.Drawing.Point(413, 45);
            this.btnAddARK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddARK.Name = "btnAddARK";
            this.btnAddARK.Size = new System.Drawing.Size(41, 40);
            this.btnAddARK.TabIndex = 2;
            this.btnAddARK.UseVisualStyleBackColor = true;
            this.btnAddARK.Click += new System.EventHandler(this.btnAddARK_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFilename.Location = new System.Drawing.Point(21, 52);
            this.txtFilename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(384, 22);
            this.txtFilename.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.BackColor = System.Drawing.Color.Aqua;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(-2, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(482, 7);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "   ";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(406, 244);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 27);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(312, 244);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddLocalARK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(506, 285);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpWrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(522, 400);
            this.MinimumSize = new System.Drawing.Size(522, 324);
            this.Name = "frmAddLocalARK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add ARK Save File";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddLocalARK_FormClosed);
            this.grpWrapper.ResumeLayout(false);
            this.grpWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWrapper;
        private System.Windows.Forms.Button btnAddARK;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOfflineName;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClusterFolder;
        private System.Windows.Forms.TextBox txtClusterFolder;
    }
}
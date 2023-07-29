namespace ArkViewer
{
    partial class ChartControl
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
            this.SuspendLayout();
            // 
            // ChartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.DoubleBuffered = true;
            this.Name = "ChartControl";
            this.Size = new System.Drawing.Size(195, 179);
            this.SizeChanged += new System.EventHandler(this.ChartControl_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ChartControl_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChartControl_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

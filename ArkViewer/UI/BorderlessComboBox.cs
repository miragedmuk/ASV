using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkViewer.UI
{
    public partial class BorderlessComboBox : ComboBox
    {
        public BorderlessComboBox()
        {
            InitializeComponent();
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DrawItem += ownerDrawCombo_DrawItem;
        }



        private const int WM_NCPAINT = 0x0085;
        private const int WM_PAINT = 0xF;
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        Color borderColor = Color.Transparent;

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }


        private void ownerDrawCombo_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;

            e.DrawBackground();

            Rectangle r1 = e.Bounds;
            r1.Width = r1.Width;

            using (SolidBrush sb = new SolidBrush(comboBox.ForeColor))
            {
                string drawText = comboBox.Items[e.Index].ToString();
                e.Graphics.DrawString(drawText, e.Font, sb, r1);
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if ((m.Msg == WM_PAINT || m.Msg == WM_NCPAINT) && DropDownStyle != ComboBoxStyle.Simple)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {
                    using (var p = new Pen(BorderColor))
                    {
                        p.Width = 2;
                        g.DrawRectangle(p, 0 + (p.Width/2), 0 + (p.Width/2), Width - (p.Width/2), Height - (p.Width/2));

                    }
                }
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            //base.OnLeave(e);
            this.Invalidate();
        }
        protected override void OnEnter(EventArgs e)
        {
            //base.OnEnter(e);
            this.Invalidate();
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            //base.OnMouseEnter(e);
            this.Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            //base.OnMouseLeave(e);
            this.Invalidate();
        }
    }
}

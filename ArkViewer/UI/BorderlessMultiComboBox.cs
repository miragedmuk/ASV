using ARKViewer;
using ARKViewer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static Microsoft.IO.RecyclableMemoryStreamManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ArkViewer.UI
{
    public partial class BorderlessMultiComboBox : ComboBox
    {
        public BorderlessMultiComboBox()
        {
            InitializeComponent();
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DrawItem += ownerDrawCombo_DrawItem;
            this.SelectedIndexChanged += BorderlessMultiComboBox_SelectedIndexChanged;
        }

        private void BorderlessMultiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BorderlessMultiComboBox item = (BorderlessMultiComboBox)SelectedItem;
            item.CheckState = !item.CheckState;
            if (CheckStateChanged != null)
                CheckStateChanged(item, e);
        }

        private const int WM_NCPAINT = 0x0085;
        private const int WM_PAINT = 0xF;
        private const int CHECKBOX_WIDTH = 18;
        private const int CHECKBOX_MARGINS = 2;
        private const int CHECKBOX_PADDING_RIGHT = 2;

        private bool _checkState = false;
        public bool CheckState
        {
            get { return _checkState; }
            set { _checkState = value; Invalidate(); }
        }

        private ASVComboValue _comboValue = new ASVComboValue("", "");
        public ASVComboValue ComboValue
        {
            get { return _comboValue; }
            set { _comboValue = value; Invalidate(); }
        }

        private Color _borderColor = Color.Transparent;
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }

        private float _tickSize = 11.0f;
        public float TickSize
        {
            get { return _tickSize; }
            set { _tickSize = value; Invalidate(); }
        }

        private float _tickLeftPosition = 0.0f;
        public float TickLeftPosition
        {
            get { return _tickLeftPosition; }
            set { _tickLeftPosition = value; Invalidate(); }
        }

        private float _tickTopPosition = 2.0f;
        public float TickTopPosition
        {
            get { return _tickTopPosition; }
            set { _tickTopPosition = value; Invalidate(); }
        }

        /// <summary>
        /// Fired when the user clicks a check box item in the drop-down list
        /// </summary>
        public event EventHandler CheckStateChanged;

        private void ownerDrawCombo_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            Rectangle r1 = e.Bounds;
            Rectangle checkBoxRect = new Rectangle(r1.X + (CHECKBOX_MARGINS / 2), r1.Y + (CHECKBOX_MARGINS / 2), CHECKBOX_WIDTH - CHECKBOX_MARGINS, r1.Height - CHECKBOX_MARGINS);
            Rectangle textRect = new Rectangle(r1.X + (CHECKBOX_WIDTH + CHECKBOX_PADDING_RIGHT), r1.Y, r1.Width - (CHECKBOX_WIDTH + CHECKBOX_PADDING_RIGHT), r1.Height);

            // Draw background.
            e.DrawBackground();
            // If item is a BorderlessMultiComboBox.
            if (Items != null && Items.Count > e.Index && Items[e.Index] is BorderlessMultiComboBox)
            {
                BorderlessMultiComboBox checkBox = (BorderlessMultiComboBox)Items[e.Index];
                // Draw checkbox background color.
                using (SolidBrush brushBackColor = new SolidBrush(checkBox.BackColor))
                {
                    e.Graphics.FillRectangle(brushBackColor, checkBoxRect);
                }
                // Draw checkbox border color.
                /*
                using (Pen penBoxColor = new Pen(Color.Black))
                {
                    e.Graphics.DrawRectangle(penBoxColor, checkBoxRect);
                }
                */
                // If checkbox is checked.
                if (checkBox.CheckState)
                {
                    // Draw check mark.
                    using (SolidBrush brush = new SolidBrush(Color.Black))
                    {
                        using (Font wing = new Font("Wingdings", _tickSize))
                        {
                            e.Graphics.DrawString("ü", wing, brush, checkBoxRect.X + _tickLeftPosition, checkBoxRect.Y + _tickTopPosition);
                        }
                    }
                }
                // Draw text.
                using (SolidBrush sb = new SolidBrush(checkBox.ForeColor))
                {
                    e.Graphics.DrawString(checkBox.ComboValue.Value, e.Font, sb, textRect);
                }
            }
            else // Fallback to standard ComboBox item.
            {
                System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
                if (comboBox != null && comboBox.Items != null && comboBox.Items.Count > e.Index)
                {
                    // Draw text.
                    using (SolidBrush sb = new SolidBrush(comboBox.ForeColor))
                    {
                        string drawText = comboBox.Items[e.Index].ToString();
                        e.Graphics.DrawString(drawText, e.Font, sb, textRect);
                    }
                }
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

using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkViewer.UI
{
    public class ChartElement
    {
        public string Title { get; set; } = string.Empty;
        public float Value { get; set; } = 0;
        public Color FillColor { get; set; } = Color.Black;
        public Color TextColor { get; set; } = Color.Black;
        public bool IsSelected { get; set; } = false;
        public GraphicsPath PiePath { get; set; } = new GraphicsPath();
        public GraphicsPath LegendPath { get; set; } = new GraphicsPath();

        public bool IsOver(float x, float y)
        {
            return PiePath != null && PiePath.IsVisible(x, y) || LegendPath != null && LegendPath.IsVisible(x, y);
        }
        public bool IsOverLegend(float x, float y)
        {
            return LegendPath.IsVisible(x, y);
        }

        public bool IsOverPie(float x, float y)
        {
            return PiePath.IsVisible(x, y);
        }
    }
}

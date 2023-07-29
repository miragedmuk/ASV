using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArkViewer.UI;

namespace ArkViewer
{
    public partial class ChartControl : UserControl
    {
        ToolTip chartTooltip = new ToolTip();

        public List<ChartElement> Elements { get; set; } = new List<ChartElement>();
        public string Title { get; set; } = "Title";
        public string SubTitle { get; set; } = string.Empty;

        GraphicsPath punchOutPath = new GraphicsPath();

        public ChartControl()
        {
            InitializeComponent();
        }

        public bool IsPunchOut(int x, int y)
        {
            return punchOutPath.IsVisible(x, y);
        }

        public void AddElement(string title, float value)
        {
            var newElement = new ChartElement()
            {
                FillColor = ColorTranslator.FromHtml(getRandomColor()),
                Title = title,
                Value = value
            };

            while (Elements.Exists(e => e.FillColor == newElement.FillColor))
            {
                newElement.FillColor = ColorTranslator.FromHtml(getRandomColor());
            }
            newElement.TextColor = IdealTextColor(newElement.FillColor);

            Elements.Add(newElement);
            Invalidate();
        }

        public void ClearElements()
        {
            Elements.Clear();
            Invalidate();
        }

        public void DrawChart(Graphics g, int imageWidth, int imageHeight)
        {
            try
            {
                Font labelFont = new Font(FontFamily.GenericSansSerif, 9);
                var textHeight = g.MeasureString("A", labelFont).Height;



                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                g.Clear(Color.WhiteSmoke);

                if (Elements == null || Elements.Count == 0) return;


                int chartMargin = 5;
                int minChartWidth = chartMargin + 32 + chartMargin;


                //Draw titles                
                var titleHeight = (2 * chartMargin) + textHeight;
                if (SubTitle.Length > 0) titleHeight += textHeight;

                g.DrawString(Title, new Font(labelFont, FontStyle.Bold), new SolidBrush(Color.Black), new PointF(chartMargin, chartMargin));
                if (SubTitle.Length > 0)
                {
                    g.DrawString(SubTitle, labelFont, new SolidBrush(Color.DarkGray), new PointF(chartMargin, chartMargin + textHeight));
                }

                //.Draw legend
                string longestValue = $"-- {Elements.OrderByDescending(s => s.Value.ToString().Length).First().Value.ToString()} --";
                var legendValueLabelSize = g.MeasureString(longestValue, labelFont);

                var longestTitle = $"-- {Elements.OrderByDescending(x => x.Title.Length).First().Title} --";
                var legendTextSize = g.MeasureString(longestTitle, labelFont);

                var legendColWidthSingle = chartMargin + legendValueLabelSize.Width + chartMargin + legendTextSize.Width + chartMargin;
                var legendColsMax = Math.Floor((imageWidth - minChartWidth) / legendColWidthSingle);
                var legendRowHeight = legendTextSize.Height + (2 * chartMargin);
                var legendRowsMax = Math.Floor(((imageHeight - titleHeight - (2 * chartMargin)) / legendRowHeight) - 0.4);
                var legendColsRequired = Math.Ceiling(Elements.Count / legendRowsMax);
                var legendColsVisible = legendColsMax > legendColsRequired ? legendColsRequired : legendColsMax;
                var legendWidth = legendColsVisible * legendColWidthSingle;
                var legendHeight = imageHeight - (2 * chartMargin);
                var legendLocation = new Point((int)(imageWidth - legendWidth), (int)(chartMargin));
                var legendRect = new Rectangle(legendLocation, new Size((int)legendWidth - chartMargin, (int)legendHeight));


                //.Draw legend background
                g.FillRectangle(new SolidBrush(Color.AliceBlue), legendRect);

                //.Draw legend border
                g.DrawRectangle(new Pen(new SolidBrush(Color.CadetBlue)), legendRect);

                //.Draw legend title
                g.DrawString("Legend", new Font(labelFont, FontStyle.Bold), new SolidBrush(Color.CornflowerBlue), new PointF(legendLocation.X + chartMargin, legendLocation.Y + chartMargin));

                //.Draw legend items


                Point legendListLocation = new Point(legendLocation.X, legendLocation.Y + (chartMargin * 2));

                int currentItem = 1;
                int currentCol = 1;
                int currentRow = 1;

                Elements.ForEach(x => x.LegendPath = new GraphicsPath());

                foreach (ChartElement chartElement in Elements.OrderByDescending(x => x.Value))
                {

                    var textLeft = legendListLocation.X + (2 * chartMargin);
                    if (currentCol > 1)
                    {
                        textLeft = textLeft + (int)(legendColWidthSingle * (currentCol - 1));
                    }

                    var legendItemLocation = new Point(textLeft, (int)(legendListLocation.Y + (currentRow * (textHeight + (2 * chartMargin)))));
                    var legendItemRect = new Rectangle(legendItemLocation, new Size((int)legendColWidthSingle - (4 * chartMargin), (int)textHeight + (chartMargin)));

                    chartElement.LegendPath = new GraphicsPath();
                    chartElement.LegendPath.StartFigure();
                    chartElement.LegendPath.AddRectangle(legendItemRect);
                    chartElement.LegendPath.CloseFigure();



                    //draw key value
                    var keyRect = new Rectangle(legendItemRect.Left, legendItemRect.Top, (int)legendValueLabelSize.Width, legendItemRect.Height);
                    var keyColor = chartElement.IsSelected ? SystemColors.Highlight : chartElement.FillColor;
                    var keyTextColor = chartElement.IsSelected ? SystemColors.HighlightText : chartElement.TextColor;
                    g.FillRectangle(new SolidBrush(keyColor), keyRect);
                    g.DrawString(chartElement.Value.ToString(), labelFont, new SolidBrush(keyTextColor), new Point(keyRect.X, keyRect.Y));

                    var textRect = new Rectangle((int)(legendItemRect.X + keyRect.Width + chartMargin), legendItemRect.Y, legendItemRect.Width - keyRect.Width - (2 * chartMargin), legendItemRect.Height);
                    g.DrawString(chartElement.Title, labelFont, new SolidBrush(Color.Black), new PointF(textRect.X, textRect.Y));


                    if (chartElement.IsSelected)
                    {
                        //highlight
                        g.DrawRectangle(new Pen(new SolidBrush(SystemColors.Highlight), 1), legendItemRect);
                    }


                    currentRow++;
                    if (currentRow > legendRowsMax)
                    {
                        if (currentCol < legendColsVisible)
                        {
                            currentCol++;
                        }
                        else
                        {
                            break;
                        }
                        currentRow = 1;
                    }

                    currentItem++;

                }

                //Draw chart
                var chartHeightAvailable = imageHeight - titleHeight - (2 * chartMargin);
                var chartWidthAvailable = imageWidth - legendWidth - (2 * chartMargin);
                var chartSize = chartHeightAvailable < chartWidthAvailable ? chartHeightAvailable : chartWidthAvailable;
                var chartLocation = new Point(chartMargin, (int)titleHeight + chartMargin);
                var chartRect = new Rectangle(chartLocation, new Size((int)chartSize, (int)chartSize));

                //g.DrawRectangle(new Pen(new SolidBrush(Color.Red), 1), chartRect);

                float startAdjustment = -90;
                float previousAngle = startAdjustment;
                var totalValue = Elements.Sum(x => x.Value);
                foreach (var chartElement in Elements.OrderByDescending(x => x.Value))
                {
                    var elementPercent = chartElement.Value / totalValue;
                    float startAngle = previousAngle;
                    float sweepAngle = elementPercent * 360;

                    Color pieColor = chartElement.IsSelected ? SystemColors.Highlight : chartElement.FillColor;

                    g.FillPie(new SolidBrush(pieColor), chartRect, startAngle, sweepAngle);
                    chartElement.PiePath = new System.Drawing.Drawing2D.GraphicsPath();
                    chartElement.PiePath.StartFigure();
                    chartElement.PiePath.AddPie(chartRect, startAngle, sweepAngle);
                    chartElement.PiePath.CloseFigure();

                    previousAngle = startAngle + sweepAngle;
                }


                //draw selected outline
                foreach (var chartElement in Elements)
                {
                    if (chartElement.IsSelected)
                    {
                        g.DrawPath(new Pen(new SolidBrush(Color.WhiteSmoke), 5), chartElement.PiePath);
                    }

                }

                //draw center punchout
                int punchSize = (int)(chartSize / 1.75);
                var punchOutRect = new Rectangle((int)(chartLocation.X + (chartSize / 2) - (punchSize / 2)), (int)(chartLocation.Y + (chartSize / 2) - (punchSize / 2)), punchSize, punchSize);

                g.FillEllipse(new SolidBrush(Color.WhiteSmoke), punchOutRect);

                //save punch out path to determine if mouse over element or center
                punchOutPath = new GraphicsPath();
                punchOutPath.StartFigure();
                punchOutPath.AddEllipse(punchOutRect);
                punchOutPath.CloseFigure();





            }
            catch
            {

            }
        }

        public void SaveChart(string fileName, int imageWidth, int imageHeight)
        {


            using (Bitmap bmp = new Bitmap(imageWidth, imageHeight))
            {
                var g = Graphics.FromImage(bmp);
                DrawChart(g, imageWidth, imageHeight);

                try
                {
                    bmp.Save(fileName, ImageFormat.Png);
                }
                catch
                {
                    throw;
                }
            }




        }

        private string getRandomColor()
        {
            Random rndNew = new Random();

            var letters = "0123456789ABCDEF".ToCharArray();
            var color = "#";
            for (var i = 0; i < 6; i++)
            {


                long r = (long)Math.Floor((rndNew.NextDouble() * 16));
                color += letters[r];
            }
            return color;
        }

        private Color IdealTextColor(Color bg)
        {
            int nThreshold = 105;
            int bgDelta = Convert.ToInt32((bg.R * 0.299) + (bg.G * 0.587) +
                                          (bg.B * 0.114));

            Color foreColor = (255 - bgDelta < nThreshold) ? Color.Black : Color.White;
            return foreColor;
        }

        private void ChartControl_MouseMove(object sender, MouseEventArgs e)
        {
            bool pieTipVisible = true;

            if (Elements != null && Elements.Count > 0)
            {


                var chartElement = Elements.FirstOrDefault(f => f.IsOver(e.X, e.Y));

                if (chartElement == null || IsPunchOut(e.X, e.Y))
                {
                    chartTooltip.RemoveAll();
                    if (Elements.Any(x => x.IsSelected))
                    {
                        Elements.Where(x => x.IsSelected).ToList().ForEach(x => x.IsSelected = false);
                        Invalidate();
                    }
                }
                else
                {

                    chartTooltip.ToolTipTitle = chartElement.Title;
                    chartTooltip.AutoPopDelay = 30000;




                    if (!chartElement.IsSelected)
                    {
                        if (chartElement.IsOver(e.X, e.Y) && pieTipVisible)
                        {
                            chartTooltip.Show($"Value: {chartElement.Value}", this, new Point((int)chartElement.PiePath.PathPoints.First().X - 25, (int)chartElement.PiePath.PathPoints.First().Y - 25));
                        }

                        Elements.Where(x => x.IsSelected).ToList().ForEach(x => x.IsSelected = false);
                        chartElement.IsSelected = true;
                        Invalidate();

                    }

                }



            }
        }

        private void ChartControl_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void ChartControl_Paint(object sender, PaintEventArgs e)
        {
            DrawChart(e.Graphics, this.Width, this.Height);


        }
    }
}

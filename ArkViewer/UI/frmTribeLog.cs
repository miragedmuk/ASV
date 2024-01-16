using ARKViewer.Models;
using ASVPack.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ARKViewer
{
    public partial class frmTribeLog : Form
    {

        private ColumnHeader SortingColumn_Markers = null;
        private string[] logData = null;


        private void LoadWindowSettings()
        {
            var savedWindow = ARKViewer.Program.ProgramConfig.Windows.FirstOrDefault(w => w.Name == this.Name);

            if (savedWindow != null)
            {
                var targetScreen = Screen.FromPoint(new Point(savedWindow.Left, savedWindow.Top));
                if (targetScreen == null) return;

                if (targetScreen.DeviceName == null || targetScreen.DeviceName == savedWindow.Monitor)
                {
                    this.StartPosition = FormStartPosition.Manual;
                    this.Left = savedWindow.Left;
                    this.Top = savedWindow.Top;
                    this.Width = savedWindow.Width;
                    this.Height = savedWindow.Height;
                }
            }
        }

        private void UpdateWindowSettings()
        {
            //only save location if normal window, do not save location/size if minimized/maximized
            if (this.WindowState == FormWindowState.Normal)
            {
                var savedWindow = ARKViewer.Program.ProgramConfig.Windows.FirstOrDefault(w => w.Name == this.Name);
                if (savedWindow == null)
                {
                    savedWindow = new ViewerWindow();
                    savedWindow.Name = this.Name;
                    ARKViewer.Program.ProgramConfig.Windows.Add(savedWindow);
                }

                if (savedWindow != null)
                {
                    var restoreScreen = Screen.FromHandle(this.Handle);

                    savedWindow.Left = this.Left;
                    savedWindow.Top = this.Top;
                    savedWindow.Width = this.Width;
                    savedWindow.Height = this.Height;
                    savedWindow.Monitor = restoreScreen.DeviceName;

                }
            }
        }



        public frmTribeLog(ContentTribe tribe)
        {
            InitializeComponent();
            LoadWindowSettings();

            Color standardBackColour = Color.FromArgb(64, 64, 64);
            Color overrideBackColour = standardBackColour;
            lvwLog.BackColor = overrideBackColour;

            lblPlayerName.Text = tribe.TribeName;
            lblPlayerLevelLabel.Visible = false;
            lblPlayerLevel.Text = "";
            lblTribeName.Text = "";
            picPlayerGender.Image = ARKViewer.Properties.Resources.marker_28;

            lvwLog.Items.Clear();
            if (tribe.Logs.Count() > 0)
            {
                logData = tribe.Logs;
                LoadLog();
            }
        }
        public frmTribeLog(ContentTribe tribe, ContentPlayer player)
        {
            InitializeComponent();
            LoadWindowSettings();
            Color standardBackColour = Color.FromArgb(64, 64, 64);
            Color overrideBackColour = standardBackColour;
            lvwLog.BackColor = overrideBackColour;

            Color standardTimestampColour = Color.WhiteSmoke;
            Color overrideTimestampColour = standardTimestampColour;
            lvwLog.ForeColor = overrideTimestampColour;

            lblPlayerName.Text = player.CharacterName;
            lblPlayerLevel.Text = player.Level.ToString();
            lblPlayerLevelLabel.Visible = true;

            lblTribeName.Text = tribe.TribeName;
            picPlayerGender.Image = player.Gender == "Male" ? ARKViewer.Properties.Resources.marker_28 : ARKViewer.Properties.Resources.marker_29;

            lvwLog.Items.Clear();
            if (tribe != null && tribe.Logs.Count() > 0)
            {
                logData = tribe.Logs;
                LoadLog();
            }


        }

        private void LoadLog()
        {
            var logFile = logData;
            lvwLog.Items.Clear();

            lvwLog.BackColor = Color.FromArgb(Program.ProgramConfig.TribeLogColours.BackgroundColour);
            lvwLog.ForeColor = Color.FromArgb(Program.ProgramConfig.TribeLogColours.ForegroundColour);

            foreach (string logEntry in logFile.Reverse())
            {

                Color standardTextColour = Color.WhiteSmoke;

                int daySeperatorPos = logEntry.IndexOf(",");
                int infoSeperatorPos = daySeperatorPos + 11;
                string dayNumberText = logEntry.Substring(0, daySeperatorPos);
                string timeNumberText = logEntry.Substring(daySeperatorPos + 2, 8);

                int colorSeperatorStart = logEntry.IndexOf("<RichColor");
                int colorSeperatorEnd = 0;
                if (colorSeperatorStart >= 0)
                {
                    string colorTag = "";

                    colorSeperatorEnd = logEntry.IndexOf(">", colorSeperatorStart + 1) + 1;
                    colorTag = logEntry.Substring(colorSeperatorStart, colorSeperatorEnd - colorSeperatorStart);
                    int colorTagValueStart = colorTag.IndexOf("\"");
                    int colorTagValueEnd = colorTag.LastIndexOf("\"");
                    string colorTagValue = colorTag.Substring(colorTagValueStart + 1, colorTagValueEnd - (colorTagValueStart + 1));
                    infoSeperatorPos = colorSeperatorEnd;

                    string[] colorValuesText = colorTagValue.Split(',');
                    if (colorValuesText.Count() == 4)
                    {
                        double.TryParse(colorValuesText[0], out double redValue);
                        double.TryParse(colorValuesText[1], out double greenValue);
                        double.TryParse(colorValuesText[2], out double blueValue);
                        double.TryParse(colorValuesText[3], out double alphaValue);

                        int alphaColorValue = (int)(alphaValue * 255);
                        int redColorValue = (int)(redValue * 255);
                        int greenColorValue = (int)(greenValue * 255);
                        int blueColorValue = (int)(blueValue * 255);


                        if (alphaColorValue < 0) alphaColorValue = 0;
                        if (redValue < 0) redValue = 0;
                        if (greenValue < 0) greenValue = 0;
                        if (blueValue < 0) blueValue = 0;


                        if (alphaColorValue > 255) alphaColorValue = 255;
                        if (redValue > 255) redValue = 255;
                        if (greenValue > 255) greenValue = 255;
                        if (blueValue > 255) blueValue = 255;
                        try
                        {
                            standardTextColour = Color.FromArgb(alphaColorValue, redColorValue, greenColorValue, blueColorValue);
                        }
                        catch
                        {
                            standardTextColour = Color.WhiteSmoke;
                        }


                    }

                }


                string logText = logEntry.Substring(infoSeperatorPos).Replace("</>", "").Trim();

                ListViewItem newItem = lvwLog.Items.Add(dayNumberText + " - " + timeNumberText);
                newItem.UseItemStyleForSubItems = false;

                newItem.SubItems.Add(logText);
                newItem.SubItems[1].Tag = standardTextColour;

                int overrideTextColour = standardTextColour.ToArgb();
                if (Program.ProgramConfig.TribeLogColours.TextColourMap.Any(c => c.gc == standardTextColour.ToArgb()))
                {
                    overrideTextColour = Program.ProgramConfig.TribeLogColours.TextColourMap.First(c => c.gc == standardTextColour.ToArgb()).cc;
                }

                newItem.SubItems[1].ForeColor = Color.FromArgb(overrideTextColour);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvwLog_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwLog.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_Markers == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_Markers)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_Markers.Text.StartsWith("> "))
                    {
                        sort_order = SortOrder.Descending;
                    }
                    else
                    {
                        sort_order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // New column. Sort ascending.
                    sort_order = SortOrder.Ascending;
                }

                // Remove the old sort indicator.
                SortingColumn_Markers.Text = SortingColumn_Markers.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_Markers = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_Markers.Text = "> " + SortingColumn_Markers.Text;
            }
            else
            {
                SortingColumn_Markers.Text = "< " + SortingColumn_Markers.Text;
            }

            // Create a comparer.
            lvwLog.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwLog.Sort();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmTribeLogColourMap colourEditor = null;

            //colour settings
            if (lvwLog.SelectedItems.Count != 0)
            {
                ListViewItem selectedItem = lvwLog.SelectedItems[0];
                Color standardColor = (Color)selectedItem.SubItems[1].Tag;
                Color overrideColor = selectedItem.SubItems[1].ForeColor;
                colourEditor = new frmTribeLogColourMap(lvwLog.BackColor, lvwLog.ForeColor, standardColor, overrideColor);

            }
            else
            {
                colourEditor = new frmTribeLogColourMap(lvwLog.BackColor, lvwLog.ForeColor);
            }
            colourEditor.Owner = this;

            if (colourEditor.ShowDialog() == DialogResult.OK)
            {
                LoadLog();
            }

        }

        private void frmTribeLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateWindowSettings();
        }
    }
}

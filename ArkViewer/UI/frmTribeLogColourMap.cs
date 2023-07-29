using ARKViewer.Models;
using ARKViewer.Models.NameMap;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ARKViewer
{
    public partial class frmTribeLogColourMap : Form
    {


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




        private void PopulateMap()
        {
            lvwTextColours.Items.Clear();
            if (Program.ProgramConfig.TribeLogColours != null)
            {
                foreach (var colourMap in Program.ProgramConfig.TribeLogColours.TextColourMap)
                {
                    ListViewItem newItem = lvwTextColours.Items.Add(new string(' ', 100));
                    newItem.SubItems.Add("");
                    newItem.UseItemStyleForSubItems = false;


                    newItem.SubItems[0].BackColor = Color.FromArgb(colourMap.gc);
                    newItem.SubItems[1].BackColor = Color.FromArgb(colourMap.cc);
                }

            }
        }

        public frmTribeLogColourMap(Color backColour, Color foreColour)
        {
            InitializeComponent();
            LoadWindowSettings();
            PopulateMap();
            pnlBackground.BackColor = backColour;
            pnlForeground.BackColor = foreColour;
            btnAddUpdate.Text = "UPDATE";
        }

        public frmTribeLogColourMap(Color backColour, Color foreColour, Color standardColour, Color newColour)
        {
            InitializeComponent();
            LoadWindowSettings();
            PopulateMap();



            pnlBackground.BackColor = backColour;
            pnlForeground.BackColor = foreColour;

            pnlGameColour.BackColor = standardColour;
            pnlCustomColour.BackColor = newColour;
            btnAddUpdate.Text = "ADD";

            foreach (ListViewItem item in lvwTextColours.Items)
            {
                if (item.SubItems[0].BackColor.Equals(standardColour))
                {
                    item.Selected = true;
                    btnAddUpdate.Text = "UPDATE";
                }
            }

            btnAddUpdate.Enabled = true;
            pnlGameColour.Enabled = true;
            pnlCustomColour.Enabled = true;

        }




        private void lvwTextColours_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwTextColours.SelectedItems.Count == 0) return;
            ListViewItem selectedItem = lvwTextColours.SelectedItems[0];
            pnlGameColour.BackColor = selectedItem.SubItems[0].BackColor;
            pnlCustomColour.BackColor = selectedItem.SubItems[1].BackColor;
            btnAddUpdate.Enabled = true;
            pnlGameColour.Enabled = true;
            pnlCustomColour.Enabled = true;

        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (btnAddUpdate.Text.ToLower() == "add")
            {
                ListViewItem newItem = lvwTextColours.Items.Add(new string(' ', 100));
                newItem.UseItemStyleForSubItems = false;

                newItem.SubItems.Add("");
                newItem.SubItems[0].BackColor = pnlGameColour.BackColor;
                newItem.SubItems[1].BackColor = pnlCustomColour.BackColor;
            }
            else
            {
                if (lvwTextColours.SelectedItems.Count == 0) return;
                ListViewItem selectedItem = lvwTextColours.SelectedItems[0];
                selectedItem.SubItems[0].BackColor = pnlGameColour.BackColor;
                selectedItem.SubItems[1].BackColor = pnlCustomColour.BackColor;
            }

            btnAddUpdate.Text = "UPDATE";
            btnAddUpdate.Enabled = false;
            pnlGameColour.Enabled = false;
            pnlCustomColour.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LogColourMap logColours = new LogColourMap()
            {
                BackgroundColour = pnlBackground.BackColor.ToArgb(),
                ForegroundColour = pnlForeground.BackColor.ToArgb()
            };

            logColours.TextColourMap = new List<LogTextColourMap>();
            foreach (ListViewItem item in lvwTextColours.Items)
            {
                logColours.TextColourMap.Add(new LogTextColourMap(item.SubItems[0].BackColor.ToArgb(), item.SubItems[1].BackColor.ToArgb()));
            }

            Program.ProgramConfig.TribeLogColours = logColours;
        }

        private void pnlBackground_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorPicker = new ColorDialog())
            {
                if (colorPicker.ShowDialog() == DialogResult.OK)
                {
                    pnlBackground.BackColor = colorPicker.Color;
                }
            }
        }

        private void pnlForeground_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorPicker = new ColorDialog())
            {
                if (colorPicker.ShowDialog() == DialogResult.OK)
                {
                    pnlForeground.BackColor = colorPicker.Color;
                }
            }
        }

        private void pnlGameColour_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorPicker = new ColorDialog())
            {
                if (colorPicker.ShowDialog() == DialogResult.OK)
                {
                    pnlGameColour.BackColor = colorPicker.Color;
                }
            }
        }

        private void pnlCustomColour_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorPicker = new ColorDialog())
            {
                if (colorPicker.ShowDialog() == DialogResult.OK)
                {
                    pnlCustomColour.BackColor = colorPicker.Color;
                }
            }
        }

        private void pnlCustomColour_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvwTextColours_Click(object sender, EventArgs e)
        {
            if (lvwTextColours.SelectedItems.Count == 0) return;
            ListViewItem selectedItem = lvwTextColours.SelectedItems[0];
            pnlGameColour.BackColor = selectedItem.SubItems[0].BackColor;
            pnlCustomColour.BackColor = selectedItem.SubItems[1].BackColor;
            btnAddUpdate.Enabled = true;
            pnlGameColour.Enabled = true;
            pnlCustomColour.Enabled = true;
        }

        private void frmTribeLogColourMap_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateWindowSettings();
        }
    }
}

using ARKViewer.Models;
using ARKViewer.Models.NameMap;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ARKViewer
{
    public partial class frmColourEditor : Form
    {
        public ColourMap SelectedMap { get; set; } = new ColourMap();
        bool isLoading = false;

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



        public frmColourEditor()
        {
            InitializeComponent();
            LoadWindowSettings();
            isLoading = true;

            udId.Minimum = 0;
            udId.Value = 0;
            udId.Maximum = int.MaxValue;

            isLoading = false;

        }
        public frmColourEditor(int newColourId)
        {
            InitializeComponent();
            LoadWindowSettings();

            isLoading = true;
            udId.Enabled = false;
            udId.Maximum = int.MaxValue;
            udId.Value = newColourId;
            isLoading = false;

        }

        public frmColourEditor(ColourMap selectedMap)
        {
            InitializeComponent();
            LoadWindowSettings();

            SelectedMap = selectedMap;

            isLoading = true;
            udId.Value = selectedMap.Id;
            udId.Maximum = int.MaxValue;
            udId.Enabled = false;

            udR.Value = selectedMap.Color.R;
            udG.Value = selectedMap.Color.G;
            udB.Value = selectedMap.Color.B;

            pnlColour.BackColor = selectedMap.Color;
            isLoading = false;

        }

        private void pnlColour_Click(object sender, EventArgs e)
        {

        }

        private void udR_ValueChanged(object sender, EventArgs e)
        {
            UpdateColourPanel();
        }

        private void udG_ValueChanged(object sender, EventArgs e)
        {
            UpdateColourPanel();
        }

        private void udB_ValueChanged(object sender, EventArgs e)
        {
            UpdateColourPanel();
        }

        private void UpdateColourPanel()
        {
            if (isLoading) return;

            Color color = Color.FromArgb((int)udR.Value, (int)udG.Value, (int)udB.Value);
            pnlColour.BackColor = color;
            SelectedMap.Hex = System.Drawing.ColorTranslator.ToHtml(color);
        }

        private void udId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void frmColourEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateWindowSettings();
        }
    }
}

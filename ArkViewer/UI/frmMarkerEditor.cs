using ARKViewer.Models;
using ASVPack.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ARKViewer
{
    public partial class frmMarkerEditor : Form
    {
        private string selectedMap = "TheIsland.ark";
        public ContentMarker EditingMarker { get; set; } = new ContentMarker();
        private List<ContentMarker> markerList = new List<ContentMarker>();
        string imageFolder = "";

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


        public frmMarkerEditor(string currentMapFile, List<ContentMarker> currentMarkers, string selectedMarkerName)
        {
            InitializeComponent();
            LoadWindowSettings();

            imageFolder = Path.Combine(AppContext.BaseDirectory, @"images\");
            if (!Directory.Exists(imageFolder)) Directory.CreateDirectory(imageFolder);

            markerList = currentMarkers;
            selectedMap = currentMapFile;

            if (selectedMarkerName.Length > 0)
            {
                //attempt to find and load it
                ContentMarker selectedMarker = currentMarkers.Where(m => m.Map.ToLower() == currentMapFile.ToLower() && m.Name == selectedMarkerName).FirstOrDefault();
                EditingMarker = selectedMarker;
            }

            txtName.Enabled = selectedMarkerName.Length == 0;

            UpdateDisplay();

        }

        private void UpdateDisplay()
        {
            txtCategory.Text = "";
            txtName.Text = "";
            pnlBackgroundColour.BackColor = Color.White;
            pnlBorderColour.BackColor = Color.Black;
            udBorderSize.Value = 0;
            udLat.Value = 0;
            udLon.Value = 0;
            picIcon.Image = new Bitmap(100, 100);

            if (EditingMarker != null)
            {
                txtCategory.Text = EditingMarker.Category;
                txtName.Text = EditingMarker.Name;
                pnlBackgroundColour.BackColor = Color.FromArgb(EditingMarker.Colour);
                pnlBorderColour.BackColor = Color.FromArgb(EditingMarker.BorderColour);
                udBorderSize.Value = EditingMarker.BorderWidth;
                udLat.Value = (decimal)EditingMarker.Lat;
                udLon.Value = (decimal)EditingMarker.Lon;
                UpdateImage();
            }

        }

        private void UpdateImage()
        {
            picIcon.Tag = string.Empty;

            if (EditingMarker.Image.Length > 0)
            {
                string imageFilename = Path.Combine(imageFolder, EditingMarker.Image);
                if (File.Exists(imageFilename))
                {
                    Image markerImage = Image.FromFile(imageFilename);
                    picIcon.Image = markerImage;
                    picIcon.Tag = Path.GetFileName(imageFilename);
                }
            }
        }


        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            bool nameExists = markerList.Count(m => m.Map == selectedMap && m.Name.ToLower() == txtName.Text.ToLower()) > 0;

            if (nameExists)
            {
                if (EditingMarker != null)
                {
                    nameExists = EditingMarker?.Name.ToLower() != txtName.Text;

                }

            }

            if (nameExists)
            {
                MessageBox.Show("Marker name is already in use for this map.\n\nPlease use a different marker name.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            e.Cancel = nameExists;

        }

        private void pnlBorderColour_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnlBorderColour.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnlBorderColour.BackColor = colorDialog1.Color;
            }
        }

        private void pnlBackgroundColour_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnlBackgroundColour.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnlBackgroundColour.BackColor = colorDialog1.Color;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EditingMarker.Map = selectedMap;
            EditingMarker.Category = txtCategory.Text;
            EditingMarker.Name = txtName.Text;
            EditingMarker.Colour = pnlBackgroundColour.BackColor.ToArgb();
            EditingMarker.BorderColour = pnlBorderColour.BackColor.ToArgb();
            EditingMarker.BorderWidth = (int)udBorderSize.Value;
            EditingMarker.Lat = (double)udLat.Value;
            EditingMarker.Lon = (double)udLon.Value;

            EditingMarker.Image = picIcon.Tag.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void picIcon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                string imageFolder = Path.Combine(AppContext.BaseDirectory, @"images\");
                if (!Directory.Exists(imageFolder)) Directory.CreateDirectory(imageFolder);


                dialog.Filter = "All Supported Images|*.ico;*.png;*.jpg;*.bmp";
                dialog.Title = "Select Marker Icon";
                dialog.InitialDirectory = imageFolder;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (Image img = Image.FromFile(dialog.FileName))
                    {
                        string fileName = dialog.FileName;
                        var mapIcon = img.GetThumbnailImage(100, 100, () => { return true; }, IntPtr.Zero);
                        picIcon.Image = mapIcon;

                        if (Path.GetDirectoryName(fileName) != Path.GetDirectoryName(imageFolder))
                        {
                            //not already in image folder, save for future use
                            var newFilename = Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + ".png";
                            fileName = Path.Combine(imageFolder, newFilename);
                            mapIcon.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        }

                        var fileNameOnly = Path.GetFileName(fileName);
                        picIcon.Tag = fileNameOnly;

                    }


                }

            }
        }

        private void udLat_Enter(object sender, EventArgs e)
        {
            udLat.Select(0, int.MaxValue);
        }

        private void udLon_Enter(object sender, EventArgs e)
        {
            udLon.Select(0, int.MaxValue);
        }


        private void frmMarkerEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateWindowSettings();
        }

        private void udLat_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

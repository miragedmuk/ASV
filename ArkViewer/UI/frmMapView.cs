using ARKViewer.Models;
using ASVPack.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ARKViewer
{
    public partial class frmMapView : Form
    {


        private static frmMapView inst;
        public static frmMapView GetForm(ASVDataManager manager)
        {
            cm = manager;
            if (inst == null || inst.IsDisposed)
            {
                inst = new frmMapView(manager);
            }

            return inst;
        }

        public string GetMapFileName()
        {
            if (cm == null) return "";

            return cm.MapFilename;
        }

        private static ASVDataManager cm;
        private Image currentMapImage = null;
        private int mapMouseDownX;
        private int mapMouseDownY;
        private int mapMouseDownZoom;

        public delegate void MapClickedEventHandler(decimal latitutde, decimal longitude);
        public event MapClickedEventHandler OnMapClicked;

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




        public void DrawMapImageTribes(long tribeId, bool showStructures, bool showPlayers, bool showTames, List<Tuple<float, float>> selectedLocations)
        {
            var c = Program.ProgramConfig;
            ASVStructureOptions mapOptions = new ASVStructureOptions()
            {
                Terminals = c.Obelisks,
                Glitches = c.Glitches,
                ChargeNodes = c.ChargeNodes,
                BeaverDams = c.BeaverDams,
                DeinoNests = c.DeinoNests,
                WyvernNests = c.WyvernNests,
                DrakeNests = c.DrakeNests,
                MagmaNests = c.MagmaNests,
                Artifacts = c.Artifacts,
                GasVeins = c.GasVeins,
                OilVeins = c.OilVeins,
                WaterVeins = c.WaterVeins,
                BeeHives = c.BeeHives
            };


            DrawMapImage(cm.GetMapImageTribes(tribeId, showStructures, showPlayers, showTames, selectedLocations, mapOptions, CustomMarkers));
        }
        public void DrawMapImageItems(long tribeId, string className, List<Tuple<float, float>> selectedLocations, string selectedRealm)
        {
            var c = Program.ProgramConfig;

            ASVStructureOptions mapOptions = new ASVStructureOptions()
            {
                Terminals = c.Obelisks,
                Glitches = c.Glitches,
                ChargeNodes = c.ChargeNodes,
                BeaverDams = c.BeaverDams,
                DeinoNests = c.DeinoNests,
                WyvernNests = c.WyvernNests,
                DrakeNests = c.DrakeNests,
                MagmaNests = c.MagmaNests,
                Artifacts = c.Artifacts,
                GasVeins = c.GasVeins,
                OilVeins = c.OilVeins,
                WaterVeins = c.WaterVeins,
                BeeHives = c.BeeHives
            };


            DrawMapImage(cm.GetMapImageItems(tribeId, className, selectedLocations, mapOptions, CustomMarkers, selectedRealm));
        }


        public void DrawMapImageWild(string className, string productionClassName, int minLevel, int maxLevel, float filterLat, float filterLon, float filterRadius, List<Tuple<float, float>> selectedLocations, string selectedRealm)
        {
            var c = Program.ProgramConfig;
            ASVStructureOptions mapOptions = new ASVStructureOptions()
            {
                Terminals = c.Obelisks,
                Glitches = c.Glitches,
                ChargeNodes = c.ChargeNodes,
                BeaverDams = c.BeaverDams,
                DeinoNests = c.DeinoNests,
                WyvernNests = c.WyvernNests,
                DrakeNests = c.DrakeNests,
                MagmaNests = c.MagmaNests,
                Artifacts = c.Artifacts,
                GasVeins = c.GasVeins,
                OilVeins = c.OilVeins,
                WaterVeins = c.WaterVeins,
                BeeHives = c.BeeHives
            };


            DrawMapImage(cm.GetMapImageWild(className, productionClassName, minLevel, maxLevel, filterLat, filterLon, filterRadius, selectedLocations, mapOptions, CustomMarkers, selectedRealm));
        }
        public void DrawMapImageTamed(string className, string productionClassName, int filterType, long tribeId, long playerId, List<Tuple<float, float>> selectedLocations, string selectedRealm, float fromLat = 50, float fromLon = 50, float fromRadius = 100)
        {
            var c = Program.ProgramConfig;
            ASVStructureOptions mapOptions = new ASVStructureOptions()
            {
                Terminals = c.Obelisks,
                Glitches = c.Glitches,
                ChargeNodes = c.ChargeNodes,
                BeaverDams = c.BeaverDams,
                DeinoNests = c.DeinoNests,
                WyvernNests = c.WyvernNests,
                DrakeNests = c.DrakeNests,
                MagmaNests = c.MagmaNests,
                Artifacts = c.Artifacts,
                GasVeins = c.GasVeins,
                OilVeins = c.OilVeins,
                WaterVeins = c.WaterVeins,
                BeeHives = c.BeeHives
            };


            DrawMapImage(cm.GetMapImageTamed(className, productionClassName, filterType, tribeId, playerId, selectedLocations, mapOptions, CustomMarkers, selectedRealm, fromLat,fromLon,fromRadius));

        }
        public void DrawMapImageDroppedItems(long droppedPlayerId, string droppedClass, List<Tuple<float, float>> selectedLocations, string selectedRealm)
        {
            var c = Program.ProgramConfig;
            ASVStructureOptions mapOptions = new ASVStructureOptions()
            {
                Terminals = c.Obelisks,
                Glitches = c.Glitches,
                ChargeNodes = c.ChargeNodes,
                BeaverDams = c.BeaverDams,
                DeinoNests = c.DeinoNests,
                WyvernNests = c.WyvernNests,
                DrakeNests = c.DrakeNests,
                MagmaNests = c.MagmaNests,
                Artifacts = c.Artifacts,
                GasVeins = c.GasVeins,
                OilVeins = c.OilVeins,
                WaterVeins = c.WaterVeins,
                BeeHives = c.BeeHives
            };


            DrawMapImage(cm.GetMapImageDroppedItems(droppedPlayerId, droppedClass, selectedLocations, mapOptions, CustomMarkers, selectedRealm));

        }
        public void DrawMapImageDropBags(long droppedPlayerId, List<Tuple<float, float>> selectedLocations, string selectedRealm)
        {
            var c = Program.ProgramConfig;
            ASVStructureOptions mapOptions = new ASVStructureOptions()
            {
                Terminals = c.Obelisks,
                Glitches = c.Glitches,
                ChargeNodes = c.ChargeNodes,
                BeaverDams = c.BeaverDams,
                DeinoNests = c.DeinoNests,
                WyvernNests = c.WyvernNests,
                DrakeNests = c.DrakeNests,
                MagmaNests = c.MagmaNests,
                Artifacts = c.Artifacts,
                GasVeins = c.GasVeins,
                OilVeins = c.OilVeins,
                WaterVeins = c.WaterVeins,
                BeeHives = c.BeeHives
            };

            DrawMapImage(cm.GetMapImageDropBags(droppedPlayerId, selectedLocations, mapOptions, CustomMarkers, selectedRealm));
        }
        public void DrawMapImagePlayerStructures(string className, long tribeId, long playerId, List<Tuple<float, float>> selectedLocations, string selectedRealm, float fromLat = 50, float fromLon = 50, float fromRadius = 100)
        {
            var c = Program.ProgramConfig;
            ASVStructureOptions mapOptions = new ASVStructureOptions()
            {
                Terminals = c.Obelisks,
                Glitches = c.Glitches,
                ChargeNodes = c.ChargeNodes,
                BeaverDams = c.BeaverDams,
                DeinoNests = c.DeinoNests,
                WyvernNests = c.WyvernNests,
                DrakeNests = c.DrakeNests,
                MagmaNests = c.MagmaNests,
                Artifacts = c.Artifacts,
                GasVeins = c.GasVeins,
                OilVeins = c.OilVeins,
                WaterVeins = c.WaterVeins,
                BeeHives = c.BeeHives
            };


            DrawMapImage(cm.GetMapImagePlayerStructures(className, tribeId, playerId, selectedLocations, mapOptions, CustomMarkers, selectedRealm, fromLat,fromLon,fromRadius));

        }
        public void DrawMapImagePlayers(long tribeId, long playerId, List<Tuple<float, float>> selectedLocations, string selectedRealm)
        {
            var c = Program.ProgramConfig;
            ASVStructureOptions mapOptions = new ASVStructureOptions()
            {
                Terminals = c.Obelisks,
                Glitches = c.Glitches,
                ChargeNodes = c.ChargeNodes,
                BeaverDams = c.BeaverDams,
                DeinoNests = c.DeinoNests,
                WyvernNests = c.WyvernNests,
                DrakeNests = c.DrakeNests,
                MagmaNests = c.MagmaNests,
                Artifacts = c.Artifacts,
                GasVeins = c.GasVeins,
                OilVeins = c.OilVeins,
                WaterVeins = c.WaterVeins,
                BeeHives = c.BeeHives
            };


            DrawMapImage(cm.GetMapImagePlayers(tribeId, playerId, selectedLocations, mapOptions, CustomMarkers, selectedRealm));
        }

        private void DrawMapImage(Image map)
        {
            picMap.Image = map;
            currentMapImage = map;
            btnSave.Enabled = true;
        }

        public List<ContentMarker> CustomMarkers { get; set; } = new List<ContentMarker>();

        private frmMapView(ASVDataManager manager)
        {
            InitializeComponent();
            LoadWindowSettings();

            cm = manager;

            if (ARKViewer.Program.ProgramConfig.Zoom > 0)
            {
                trackZoom.Value = ARKViewer.Program.ProgramConfig.Zoom;
            }
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (frmMapToolboxStructures mapSettings = frmMapToolboxStructures.GetForm(this, cm))
            {
                mapSettings.Owner = this;
                mapSettings.ShowDialog();
                DrawTestMap(new List<Tuple<float, float>>());

            }
        }

        private void UpdateZoomLevel()
        {
            var newSize = 1024 * ((double)trackZoom.Value / 100.0);
            picMap.Width = (int)newSize;
            picMap.Height = (int)newSize;




            Program.ProgramConfig.Zoom = trackZoom.Value;
        }

        public void DrawTestMap(List<Tuple<float, float>> selectedLocations)
        {
            picMap.Image = cm.GetMapImageMapStructures(CustomMarkers, selectedLocations);
        }

        private void trackZoom_Scroll(object sender, EventArgs e)
        {
            UpdateZoomLevel();
        }


        private void picMap_MouseDown(object sender, MouseEventArgs e)
        {
            mapMouseDownX = e.X;
            mapMouseDownY = e.Y;
            mapMouseDownZoom = trackZoom.Value;
        }

        private void picMap_MouseMove(object sender, MouseEventArgs e)
        {
            int movementY = e.Y - mapMouseDownY;
            int movementX = e.X - mapMouseDownX;



            if (e.Button == MouseButtons.Left)
            {
                picMap.Left = picMap.Left + movementX;
                picMap.Top = picMap.Top + movementY;
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (movementY > 0)
                {
                    if ((mapMouseDownZoom + movementY) <= trackZoom.Maximum)
                    {
                        trackZoom.Value = mapMouseDownZoom + movementY;
                    }
                }
                else if (movementY < 0)
                {
                    if ((mapMouseDownZoom + movementY) >= trackZoom.Minimum)
                    {
                        trackZoom.Value = mapMouseDownZoom + movementY;
                    }
                }
            }

            if (e.Button == MouseButtons.None)
            {
                if (picMap.Image == null) return;

                double zoomLevel = (double)picMap.Height / (double)picMap.Image.Height;
                double clickY = e.Y / (zoomLevel);
                double clickX = e.X / (zoomLevel);

                var customMarker = cm.CustomMarkerRegions.Find(x =>
                    clickY >= x.Item1.Top
                    && clickY <= x.Item1.Top + x.Item1.Height
                    && clickX >= x.Item1.Left
                    && clickX <= x.Item1.Left + x.Item1.Width
                );

                if (customMarker != null)
                {
                    toolTip2.SetToolTip(picMap, customMarker.Item2);
                }
                else
                {
                    toolTip2.RemoveAll();
                }
            }


        }

        private void picMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (picMap.Image == null) return;

            double zoomLevel = (double)picMap.Height / (double)picMap.Image.Height;
            double clickY = e.Location.Y / (zoomLevel);
            double clickX = e.Location.X / (zoomLevel);

            double latitude = clickY / 10.25;
            double longitude = clickX / 10.25;
            if (e.Button == MouseButtons.Left) OnMapClicked?.Invoke((decimal)latitude, (decimal)longitude);
        }

        private void trackZoom_ValueChanged(object sender, EventArgs e)
        {
            UpdateZoomLevel();
        }



        private void frmMapView_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateWindowSettings();
            try
            {
                Application.OpenForms["frmViewer"].BringToFront();
            }
            catch
            {

            }

        }

        private void btnMapStructures_Click(object sender, EventArgs e)
        {
            ShowMapStructures();
        }

        private void btnMapMarkers_Click(object sender, EventArgs e)
        {
            ShowMapMarkers();
        }

        private void ShowMapStructures()
        {
            frmMapToolboxStructures mapSettings = frmMapToolboxStructures.GetForm(this, cm);
            {
                mapSettings.Show();
                //mapSettings.BringToFront();
                DrawTestMap(new List<Tuple<float, float>>());
            }
        }
        private void ShowMapMarkers()
        {
            frmMapToolboxMarkers mapSettings = frmMapToolboxMarkers.GetForm(this);
            {
                mapSettings.Show();
                //mapSettings.BringToFront();
                DrawTestMap(new List<Tuple<float, float>>());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentMapImage == null) return;

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                string exportFolder = Path.Combine(AppContext.BaseDirectory, @"Export\");
                if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);

                dialog.DefaultExt = "jpg";
                dialog.Filter = "Jpeg (*.jpg, *.jpeg)|*.jpg;*.jpeg";
                dialog.InitialDirectory = exportFolder;
                dialog.DefaultExt = ".jpg";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string fileFolder = Path.GetDirectoryName(dialog.FileName);
                    if (!Directory.Exists(fileFolder)) Directory.CreateDirectory(fileFolder);
                    currentMapImage.Save(dialog.FileName, ImageFormat.Jpeg);


                    MessageBox.Show("Map image saved.", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void picMap_MouseHover(object sender, EventArgs e)
        {

        }
    }
}

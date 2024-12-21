using ArkViewer;
using ArkViewer.Configuration;
using ArkViewer.UI;
using ARKViewer.Configuration;
using ARKViewer.Models;
using ARKViewer.Models.NameMap;
using ASVPack.Models;
using CoreRCON;
using FluentFTP;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json.Linq;
using Renci.SshNet;
using SkiaSharp.Views.Desktop;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Timer = System.Windows.Forms.Timer;

namespace ARKViewer
{
    public partial class frmViewer : Form
    {
        Timer saveCheckTimer = new Timer();
        frmMapView MapViewer = null;

        private bool isLoading = false;

        private ColumnHeader SortingColumn_DetailTame = null;
        private ColumnHeader SortingColumn_DetailWild = null;
        private ColumnHeader SortingColumn_Players = null;
        private ColumnHeader SortingColumn_Structures = null;
        private ColumnHeader SortingColumn_Tribes = null;
        private ColumnHeader SortingColumn_Drops = null;
        private ColumnHeader SortingColumn_ItemList = null;
        private ColumnHeader SortingColumn_Paintings = null;


        private ColumnHeader SortingColumn_UploadedChar = null;
        private ColumnHeader SortingColumn_UploadedTame = null;
        private ColumnHeader SortingColumn_UploadedItem = null;
        private ColumnHeader SortingColumn_LeaderboardSummary = null;
        private ColumnHeader SortingColumn_LeaderboardDetail = null;

        private string savePath = Path.GetDirectoryName(Application.ExecutablePath);
        private bool isRconConnected = false;

        private List<string> traitList = new List<string>() { "AberrantCarrier", "Aggressive", "Angry", "Athletic", "CarcassCarrier", "Carefree", "Cold", "Cowardly", "Distracting", "Diurnal", "Excitable", "ExoticCarrier", "FastLearner", "Fatty", "FoodFrail", "FoodMutable", "FoodRobust", "Frenetic", "Giantslaying", "HealthFrail", "HealthMutable", "HealthRobust", "HeavyHitting", "Kingslaying", "MeatCarrier", "MeleeFrail", "MeleeMutable", "MeleeRobust", "MineralCarrier", "Nocturnal", "Numb", "OxygenFrail", "OxygenMutable", "OxygenRobust", "PlantCarrier", "Protective", "QuickHitting", "ScorchedCarrier", "SlowMetabolism", "Sprinter", "StaminaFrail", "StaminaMutable", "StaminaRobust", "Swimmer", "Tenacious", "Vampiric", "Warm", "WeightFrail", "WeightMutable", "WeightRobust" };


        Random rndChartColor = new Random();

        //wrapper for the information we need from ARK save data
        ASVDataManager cm = null;
        RCON rconClient = null;

        private void LoadWindowSettings()
        {

            var savedWindow = ARKViewer.Program.ProgramConfig.Windows.Find(w => w.Name == this.Name);

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
                var savedWindow = ARKViewer.Program.ProgramConfig.Windows.Find(w => w.Name == this.Name);
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

        private async Task<string> ExecuteRCONCommand(string command)
        {
            if (rconClient == null) return await Task.FromResult("RCON not configured.\n\nTo use RCON commands, please configure your RCON connection in Settings.");
            if (!isRconConnected)
            {
                try
                {
                    await rconClient.ConnectAsync();
                    isRconConnected = true;
                }
                catch
                {
                    isRconConnected = false;
                    return await Task.FromResult("RCON not connected. Connection failed.");
                }

            }

            command = command.Replace("admincheat ", "");
            command = command.Replace("cheat ", "");

            string rconResponse = await rconClient.SendCommandAsync(command);

            return rconResponse;
        }

        private void InitializeDefaults()
        {
            isLoading = true;


            LoadWindowSettings();
            chkTameable.Checked = Program.ProgramConfig.HideNoTames;
            lblVersion.Text = $"{Application.ProductVersion}";

            if (Program.TabCommands.Count > 0)
            {
                //populate copy/rcon command lists
                var wildCommands = Program.TabCommands.Find(t => t.TabName.ToLower() == "wild");
                if (wildCommands != null && wildCommands.Commands.Count > 0)
                {
                    cboConsoleCommandsWild.Items.Clear();
                    cboConsoleCommandsWild.Items.AddRange(wildCommands.Commands.ToArray());
                }

                var tamedCommands = Program.TabCommands.Find(t => t.TabName.ToLower() == "tamed");
                if (tamedCommands != null && tamedCommands.Commands.Count > 0)
                {
                    cboConsoleCommandsTamed.Items.Clear();
                    cboConsoleCommandsTamed.Items.AddRange(tamedCommands.Commands.ToArray());

                }

                var structureCommands = Program.TabCommands.Find(t => t.TabName.ToLower() == "structures");
                if (structureCommands != null && structureCommands.Commands.Count > 0)
                {
                    cboConsoleCommandsStructure.Items.Clear();
                    cboConsoleCommandsStructure.Items.AddRange(structureCommands.Commands.ToArray());
                }


                var tribeCommands = Program.TabCommands.Find(t => t.TabName.ToLower() == "tribes");
                if (tribeCommands != null && tribeCommands.Commands.Count > 0)
                {
                    cboConsoleCommandsTribe.Items.Clear();
                    cboConsoleCommandsTribe.Items.AddRange(tribeCommands.Commands.ToArray());
                }


                var playerCommands = Program.TabCommands.Find(t => t.TabName.ToLower() == "players");
                if (playerCommands != null && playerCommands.Commands.Count > 0)
                {
                    cboConsoleCommandsPlayer.Items.Clear();
                    cboConsoleCommandsPlayer.Items.AddRange(playerCommands.Commands.ToArray());
                }


                var droppedCommands = Program.TabCommands.Find(t => t.TabName.ToLower() == "droppeditems");
                if (droppedCommands != null && droppedCommands.Commands.Count > 0)
                {
                    cboConsoleCommandDropped.Items.Clear();
                    cboConsoleCommandDropped.Items.AddRange(droppedCommands.Commands.ToArray());
                }



                var searchCommands = Program.TabCommands.Find(t => t.TabName.ToLower() == "itemsearch");
                if (searchCommands != null && searchCommands.Commands.Count > 0)
                {
                    cboConsoleCommandSearch.Items.Clear();
                    cboConsoleCommandSearch.Items.AddRange(searchCommands.Commands.ToArray());
                }


                var paintingCommands = Program.TabCommands.Find(t => t.TabName.ToLower() == "paintings");
                if (paintingCommands != null && paintingCommands.Commands.Count > 0)
                {

                    cboConsoleCommandPainting.Items.Clear();
                    cboConsoleCommandPainting.Items.AddRange(paintingCommands.Commands.ToArray());
                }


            }

            Application.DoEvents();

            isLoading = false;
        }

        private void RconClient_OnDisconnected()
        {
            isRconConnected = false;
        }

        public void UpdateProgress(string newProgress)
        {
            lblStatus.Text = newProgress;
            lblStatus.Refresh();
        }

        private async void StartRCON()
        {

            btnRconCommandPlayers.Visible = Program.ProgramConfig.Mode == ViewerModes.Mode_Ftp || Program.ProgramConfig.Mode == ViewerModes.Mode_Offline;
            btnRconCommandStructures.Visible = Program.ProgramConfig.Mode == ViewerModes.Mode_Ftp || Program.ProgramConfig.Mode == ViewerModes.Mode_Offline;
            btnRconCommandTamed.Visible = Program.ProgramConfig.Mode == ViewerModes.Mode_Ftp || Program.ProgramConfig.Mode == ViewerModes.Mode_Offline;
            btnRconCommandTribes.Visible = Program.ProgramConfig.Mode == ViewerModes.Mode_Ftp || Program.ProgramConfig.Mode == ViewerModes.Mode_Offline;
            btnRconCommandWild.Visible = Program.ProgramConfig.Mode == ViewerModes.Mode_Ftp || Program.ProgramConfig.Mode == ViewerModes.Mode_Offline;

            string rconServerAddress = string.Empty;
            string rconServerPassword = string.Empty;
            int rconServerPort = 27020;

            switch (Program.ProgramConfig.Mode)
            {
                case ViewerModes.Mode_Ftp:
                    foreach (var i in Program.ProgramConfig.ServerList)
                    {
                        string localFilename = Path.Combine(AppContext.BaseDirectory, $@"{i.Name}\", i.Map);

                        if (localFilename.ToLower() == Program.ProgramConfig.SelectedFile.ToLower())
                        {
                            rconServerAddress = i.RCONServerIP;
                            rconServerPassword = i.RCONPassword;
                            rconServerPort = i.RCONPort;
                            break;
                        }
                    }
                    break;
                case ViewerModes.Mode_Offline:
                    foreach (var i in Program.ProgramConfig.OfflineList)
                    {
                        if (i != null && i.Name != null)
                        {
                            if (i.Filename.ToLower() == Program.ProgramConfig.SelectedFile.ToLower())
                            {
                                rconServerAddress = i.RCONServerIP;
                                rconServerPassword = i.RCONPassword;
                                rconServerPort = i.RCONPort;
                                break;

                            }
                        }
                    }
                    break;
                default:


                    break;
            }


            if (!string.IsNullOrEmpty(rconServerAddress))
            {


                rconClient = new RCON(IPAddress.Parse(rconServerAddress), (ushort)rconServerPort, rconServerPassword);
                rconClient.OnDisconnected += RconClient_OnDisconnected;
                try
                {
                    await rconClient.ConnectAsync();
                    isRconConnected = true;
                }
                catch
                {
                    isRconConnected = false;
                }

            }
        }

        public void LoadContent(string fileName, bool doUserDownload)
        {
            Program.LogWriter.Trace("BEGIN LoadContent()");

            this.Cursor = Cursors.WaitCursor;

            InitializeDefaults();

            if (Program.ProgramConfig.Mode == ViewerModes.Mode_Ftp)
            {
                long downloadStartTicks = DateTime.Now.Ticks;
                if (Program.ProgramConfig.FtpLoadMode == 1 || doUserDownload || !File.Exists(fileName))
                {
                    UpdateProgress("Checking FTP server for new content.");

                    var currentMode = Program.ProgramConfig.FtpDownloadMode;
                    if (!doUserDownload) Program.ProgramConfig.FtpDownloadMode = 1; //set to sychronise only if user hasn't opted for refresh.

                    var downloadedFile = Download();
                    long downloadEndTicks = DateTime.Now.Ticks;
                    if (File.Exists(downloadedFile))
                    {
                        fileName = downloadedFile;
                        Program.LogWriter.Debug($"File downloaded to: {downloadedFile}");
                        Program.ProgramConfig.SelectedFile = downloadedFile;
                    }

                    UpdateProgress($"Downloaded from server in {TimeSpan.FromTicks(downloadEndTicks - downloadStartTicks).ToString(@"mm\:ss")}.");

                    Program.ProgramConfig.FtpDownloadMode = currentMode; //reset to user prefererence

                }


            }

            cm = null;
            lblMapDate.Text = "No Map Loaded";
            lblMapTypeName.Text = "Unknown Data";

            UpdateProgress("Loading ARK save data.");

            long startLoadTicks = DateTime.Now.Ticks;

            //remove in-game markers, will re-load if Local Profile contains any
            Program.ProgramConfig.MapMarkerList.RemoveAll(x => x.InGameMarker == true);

            try
            {
                //determine if it's json or binary
                if (fileName.EndsWith(".asv"))
                {
                    //asv pack (compressed)
                    ContentPack pack = new ContentPack(File.ReadAllBytes(fileName));


                    cm = new ASVDataManager(pack);
                    Program.ProgramConfig.GlitchMarkers.Where(m => m.Map == cm.LoadedMap.MapName).ToList().ForEach(x =>
                    {
                        pack.GlitchMarkers.Add(new ContentStructure()
                        {
                            ClassName = "ASV_Glitch",
                            HasDecayTimeReset = false,
                            X = x.X,
                            Y = x.Y,
                            Z = x.Z,
                            Latitude = (float)x.Lat,
                            Longitude = (float)x.Lon
                        });

                    });
                }
                else
                {
                    //assume .ark
                    ContentContainer container = new ContentContainer();
                    container.OnUpdateProgress += Container_OnUpdateProgress;



                    string localProfileFilename = "";
                    string steamFolder = Program.GetSteamFolder();
                    if (steamFolder != "")
                    {
                        localProfileFilename = Path.Combine(steamFolder, @"LocalProfiles\PlayerLocalData.arkprofile");
                    }

                    container.LoadSaveGame(fileName, localProfileFilename, Program.ProgramConfig.ClusterFolder ?? "", Program.ProgramConfig.ProfileDayLimit);

                    UpdateProgress("Analyzing loaded data to populate UI.");

                    //glitches
                    Program.ProgramConfig.GlitchMarkers.ForEach(x =>
                    {
                        if (x.Map.ToLower().StartsWith(container.MapName.ToLower()))
                        {
                            container.MapStructures.Add(new ContentStructure()
                            {
                                ClassName = "ASV_Glitch",
                                HasDecayTimeReset = false,
                                X = x.X,
                                Y = x.Y,
                                Z = x.Z,
                                Latitude = (float)x.Lat,
                                Longitude = (float)x.Lon
                            });
                        }

                    });




                    if (container != null && container.LocalProfile != null)
                    {
                        //add in-game map markers
                        if (container.LocalProfile.MapMarkers != null)
                        {
                            Program.ProgramConfig.MapMarkerList.AddRange(container.LocalProfile.MapMarkers);
                        }
                    }

                    cm = new ASVDataManager(container);

                    container.OnUpdateProgress -= Container_OnUpdateProgress;

                }

                try
                {
                    if (MapViewer != null) MapViewer.OnMapClicked -= MapViewer_OnMapClicked;
                }
                catch
                {
                }
                MapViewer = frmMapView.GetForm(cm);



                MapViewer.OnMapClicked += MapViewer_OnMapClicked;

                string mapFileDateString = (cm.ContentDate.Equals(new DateTime()) ? "n/a" : cm.ContentDate.GetValueOrDefault(DateTime.Now).ToString("dd MMM yyyy HH:mm"));

                if (cm.MapDay > 0)
                {
                    lblMapDate.Text = $"{cm.MapName} (Day: {cm.MapDay} - {cm.MapTime.ToString("HH:mm")}): {mapFileDateString}";
                }
                else
                {
                    lblMapDate.Text = $"{cm.MapName}: {mapFileDateString}";
                }

                switch (Program.ProgramConfig.Mode)
                {
                    case ViewerModes.Mode_SinglePlayer:
                        lblMapTypeName.Text = $"Single Player";
                        break;
                    case ViewerModes.Mode_Offline:
                        lblMapTypeName.Text = $"Offline: {Program.ProgramConfig.SelectedFile}";
                        break;
                    case ViewerModes.Mode_ContentPack:
                        lblMapTypeName.Text = $"ASV: {Program.ProgramConfig.SelectedFile}";

                        break;
                    case ViewerModes.Mode_Ftp:
                        lblMapTypeName.Text = $"FTP: {Program.ProgramConfig.SelectedServer}";

                        break;
                    default:
                        lblMapTypeName.Text = "";
                        break;
                }


                var timeLoaded = TimeSpan.FromTicks(DateTime.Now.Ticks - startLoadTicks);
                UpdateProgress($"Content pack loaded in {timeLoaded.ToString(@"mm\:ss")}.");



                if (cm.ContentDate == null || cm.ContentDate.Equals(new DateTime()))
                {
                    //no map loaded
                    UpdateProgress("Content failed to load.  Please check settings or refresh download to try again.");
                }

            }
            catch (Exception ex)
            {
                frmErrorReport errorReport = new frmErrorReport(ex.Message, ex.StackTrace);

                //failed to load save game
                UpdateProgress("Content failed to load.  Please check settings or refresh download to try again.");
            }

            isLoading = true;
            cboSelectedMap.Items.Clear();
            switch (Program.ProgramConfig.Mode)
            {
                case ViewerModes.Mode_Ftp:
                    foreach (var i in Program.ProgramConfig.ServerList)
                    {
                        string localFilename = Path.Combine(AppContext.BaseDirectory, $@"{i.Name}\", i.Map);

                        int newIndex = cboSelectedMap.Items.Add(new ASVComboValue(localFilename, i.Name));
                    }
                    break;
                case ViewerModes.Mode_Offline:
                    foreach (var i in Program.ProgramConfig.OfflineList)
                    {
                        if (i != null && i.Name != null)
                        {
                            int newIndex = cboSelectedMap.Items.Add(i);
                            if (i.Filename.ToLower() == Program.ProgramConfig.SelectedFile.ToLower()) cboSelectedMap.SelectedIndex = newIndex;
                        }
                    }
                    break;
                case ViewerModes.Mode_SinglePlayer:

                    PopulateSinglePlayerGames();


                    break;
                default:

                    break;
            }
            cboSelectedMap.Sorted = true;

            if (cboSelectedMap.Items.Count > 0)
            {
                for (int i = 0; i < cboSelectedMap.Items.Count; i++)
                {
                    ASVComboValue itemValue = cboSelectedMap.Items[i] as ASVComboValue;
                    if (itemValue != null && itemValue.Key.ToLower() == Program.ProgramConfig.SelectedFile.ToLower())
                    {
                        cboSelectedMap.SelectedIndex = i;
                        break;
                    }
                }
            }

            if (cm != null)
            {
                RefreshRealms();
                RefreshTamedTraits();
                RefreshWildTraits();

                var allWilds = cm.GetWildCreatures(0, int.MaxValue, 50, 50, float.MaxValue, "", "");
                if (allWilds.Count > 0)
                {
                    int maxLevel = allWilds.Max(w => w.BaseLevel);
                    udWildMax.Maximum = maxLevel;
                    udWildMin.Maximum = maxLevel;
                    udWildMax.Value = maxLevel;
                }



                RefreshWildSummary();

                RefreshTamedProductionResources();
                RefreshTamedSummary();
                RefreshTribeSummary();
                RefreshPlayerTribes();
                RefreshTamedTribes();
                RefreshStructureTribes();
                RefreshItemListTribes();
                RefreshStructureSummary();
                RefreshDroppedPlayers();
                RefreshLeaderboardTribes();
                RefreshLeaderboardMissions();
                RefreshPaintingTribes();
                RefreshPaintingStructures();
                RefreshFilters();


                LoadUploadedCharacters();
                LoadUploadedItems();
                LoadUploadedTames();



                DrawMap(0, 0);
            }




            isLoading = false;

            StartRCON();

            this.Cursor = Cursors.Default;
            Program.LogWriter.Trace("END LoadContent()");
        }

        private void RefreshFilters()
        {
            cboItemListFilter.Items.Clear();
            cboItemListFilter.Items.Add("All");
            cboItemListFilter.Items.Add("Normal");
            cboItemListFilter.Items.Add("Blueprint");
            cboItemListFilter.Items.Add("Uploaded");
            cboItemListFilter.SelectedIndex = 0;

            cboTameFilter.Items.Clear();
            cboTameFilter.Items.Add("All");
            cboTameFilter.Items.Add("Normal");
            cboTameFilter.Items.Add("Stored");
            cboTameFilter.Items.Add("Uploaded");
            cboTameFilter.SelectedIndex = 0;
        }

        private void Container_OnUpdateProgress(string message)
        {
            if (lblStatus.InvokeRequired)
            {
                Action safeWrite = delegate { Container_OnUpdateProgress($"{message}"); };
                lblStatus.Invoke(safeWrite);
            }
            else
            {
                lblStatus.Text = message;
                lblStatus.Refresh();
            }
        }

        private void RefreshRealms()
        {
            if (cm == null) return;

            cboWildRealm.Items.Clear();
            cboWildRealm.Items.Add(new ASVComboValue("", "All Realms"));

            if (cm.LoadedMap != null && cm.LoadedMap.Regions != null && cm.LoadedMap.Regions.Count > 0)
            {
                foreach (var realmRegion in cm.LoadedMap.Regions)
                {
                    cboWildRealm.Items.Add(new ASVComboValue(realmRegion.RegionName, realmRegion.RegionName));
                }

            }
            cboWildRealm.SelectedIndex = 0;

            cboTameRealm.Items.Clear();
            cboTameRealm.Items.Add(new ASVComboValue("", "All Realms"));
            if (cm.LoadedMap != null && cm.LoadedMap.Regions != null && cm.LoadedMap.Regions.Count > 0)
            {
                foreach (var realmRegion in cm.LoadedMap.Regions)
                {
                    cboTameRealm.Items.Add(new ASVComboValue(realmRegion.RegionName, realmRegion.RegionName));
                }

            }
            cboTameRealm.SelectedIndex = 0;

            cboStructureRealm.Items.Clear();
            cboStructureRealm.Items.Add(new ASVComboValue("", "All Realms"));
            if (cm.LoadedMap != null && cm.LoadedMap.Regions != null && cm.LoadedMap.Regions.Count > 0)
            {
                foreach (var realmRegion in cm.LoadedMap.Regions)
                {
                    cboStructureRealm.Items.Add(new ASVComboValue(realmRegion.RegionName, realmRegion.RegionName));
                }

            }
            cboStructureRealm.SelectedIndex = 0;

            cboPlayerRealm.Items.Clear();
            cboPlayerRealm.Items.Add(new ASVComboValue("", "All Realms"));
            if (cm.LoadedMap != null && cm.LoadedMap.Regions != null && cm.LoadedMap.Regions.Count > 0)
            {
                foreach (var realmRegion in cm.LoadedMap.Regions)
                {
                    cboPlayerRealm.Items.Add(new ASVComboValue(realmRegion.RegionName, realmRegion.RegionName));
                }

            }
            cboPlayerRealm.SelectedIndex = 0;


            cboDroppedItemRealm.Items.Clear();
            cboDroppedItemRealm.Items.Add(new ASVComboValue("", "All Realms"));
            if (cm.LoadedMap != null && cm.LoadedMap.Regions != null && cm.LoadedMap.Regions.Count > 0)
            {
                foreach (var realmRegion in cm.LoadedMap.Regions)
                {
                    cboDroppedItemRealm.Items.Add(new ASVComboValue(realmRegion.RegionName, realmRegion.RegionName));
                }

            }
            cboDroppedItemRealm.SelectedIndex = 0;


        }


        //********* Constructor **********/
        public frmViewer()
        {
            InitializeComponent();
            InitializeDefaults();
        }


        /********* UI event handlers ***********/
        private void LvwWildDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            btnCopyCommandWild.Enabled = lvwWildDetail.SelectedItems.Count > 0 || !cboConsoleCommandsWild.Text.ToLowerInvariant().Contains("<");
            btnRconCommandWild.Enabled = lvwWildDetail.SelectedItems.Count > 0 || !cboConsoleCommandsWild.Text.ToLowerInvariant().Contains("<");

            if (lvwWildDetail.SelectedItems.Count > 0)
            {

                var selectedItem = lvwWildDetail.SelectedItems[0];
                float.TryParse(selectedItem.SubItems[5].Text, out float selectedX);
                float.TryParse(selectedItem.SubItems[4].Text, out float selectedY);


                DrawMap(selectedX, selectedY);





            }
            this.Cursor = Cursors.Default;
        }

        private void CboWildClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboWildClass.SelectedIndex != 1 && cboWildResource.SelectedIndex > 0) cboWildResource.SelectedIndex = 0;
            LoadWildDetail();
        }

        private void lvwWildDetail_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwWildDetail.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_DetailWild == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_DetailWild)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_DetailWild.Text.StartsWith("> "))
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
                SortingColumn_DetailWild.Text = SortingColumn_DetailWild.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_DetailWild = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_DetailWild.Text = "> " + SortingColumn_DetailWild.Text;
            }
            else
            {
                SortingColumn_DetailWild.Text = "< " + SortingColumn_DetailWild.Text;
            }

            // Create a comparer.
            lvwWildDetail.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwWildDetail.Sort();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

            frmSettings settings = new frmSettings(cm);
            settings.Owner = this;
            while (settings.ShowDialog() == DialogResult.OK)
            {
                settings.SavedConfig.Save();
                ARKViewer.Program.ProgramConfig = settings.SavedConfig;


                if (!File.Exists(settings.SavedConfig.SelectedFile))
                {
                    if (settings.SavedConfig.Mode == ViewerModes.Mode_Ftp)
                    {
                        this.Cursor = Cursors.WaitCursor;

                        settings.SavedConfig.SelectedFile = Download();

                        this.Cursor = Cursors.Default;

                    }
                }

                if (File.Exists(settings.SavedConfig.SelectedFile))
                {
                    this.Cursor = Cursors.WaitCursor;

                    UpdateProgress("Loading content pack..");

                    LoadContent(settings.SavedConfig.SelectedFile, false);

                    this.Cursor = Cursors.Default;

                    break;
                }
            }

        }

        private void ownerDrawTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            TabPage tabPage = tabControl.TabPages[tabControl.SelectedIndex];

            // Set Border header  
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(45, 45, 45)), e.Bounds);
            Rectangle paddedBounds = e.Bounds;
            paddedBounds.Inflate(-2, -2);
            paddedBounds.Offset(1, 1);
            e.Graphics.DrawString(tabControl.TabPages[e.Index].Text, this.Font, SystemBrushes.HighlightText, paddedBounds);

            //set  Tabcontrol border  
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.FromArgb(45, 45, 45), 2);
            g.DrawRectangle(p, tabPage.Bounds);
        }



        //private void ownerDrawCombo_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    if (e.Index < 0) return;

        //    System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;

        //    e.DrawBackground();

        //    Rectangle r1 = e.Bounds;
        //    r1.Width = r1.Width;

        //    using (SolidBrush sb = new SolidBrush(comboBox.ForeColor))
        //    {
        //        string drawText = comboBox.Items[e.Index].ToString();
        //        e.Graphics.DrawString(drawText, e.Font, sb, r1);
        //    }
        //}

        private void cboSelected_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            ASVCreatureSummary dinoSummary = (ASVCreatureSummary)cboWildClass.Items[e.Index];
            string dinoName = dinoSummary.Name;
            string dinoCount = $"Count: {dinoSummary.Count}";
            string minLevel = $"Min: {dinoSummary.MinLevel}";
            string maxLevel = $"Max: {dinoSummary.MaxLevel}";

            Rectangle r1 = e.Bounds;
            r1.Width = r1.Width;

            using (SolidBrush sb = new SolidBrush(cboWildClass.ForeColor))
            {
                e.Graphics.DrawString(dinoName, e.Font, sb, r1);
            }

            // Using p As New Pen(Color.AliceBlue)
            // e.Graphics.DrawLine(p, r1.Right, 0, r1.Right, r1.Bottom)
            // End Using

            Rectangle r2 = e.Bounds;
            r2.X = e.Bounds.Width - 200;
            r2.Width = r2.Width / 4;

            using (SolidBrush sb = new SolidBrush(cboWildClass.ForeColor))
            {
                e.Graphics.DrawString(dinoCount, e.Font, sb, r2);
            }

            // Using p As New Pen(Color.AliceBlue)
            // e.Graphics.DrawLine(p, r2.Right, 0, r2.Right, r2.Bottom)
            // End Using

            Rectangle r3 = e.Bounds;
            r3.X = e.Bounds.Width - 120;
            r3.Width = r3.Width / 4;

            using (SolidBrush sb = new SolidBrush(cboWildClass.ForeColor))
            {
                e.Graphics.DrawString(minLevel, e.Font, sb, r3);
            }

            // Using p As New Pen(Color.AliceBlue)
            // e.Graphics.DrawLine(p, r3.Right, 0, r3.Right, r3.Bottom)
            // End Using

            Rectangle r4 = e.Bounds;
            r4.X = (int)(e.Bounds.Width - 65);
            r4.Width = r4.Width / 4;

            using (SolidBrush sb = new SolidBrush(cboWildClass.ForeColor))
            {
                e.Graphics.DrawString(maxLevel, e.Font, sb, r4);
            }
        }

        private void frmViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateWindowSettings();
            ARKViewer.Program.ProgramConfig.Save();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            RefreshMap(true);
            btnRefresh.Enabled = true;
        }

        private void cboTribes_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPlayerList();
            LoadPlayerDetail();
        }

        private void cboPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPlayers.SelectedItem == null) return;

            //select tribe
            ASVComboValue comboValue = (ASVComboValue)cboPlayers.SelectedItem;
            long playerId = long.Parse(comboValue.Key);
            if (playerId == 0) return;

            var playerTribe = cm.GetPlayerTribe(playerId);
            if (playerTribe != null)
            {
                var foundTribe = cboTribes.Items.Cast<ASVComboValue>().First(x => x.Key == playerTribe.TribeId.ToString());
                cboTribes.SelectedIndex = cboTribes.Items.IndexOf(foundTribe);
            }
        }

        private void lvwPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            float selectedX = 0;
            float selectedY = 0;


            btnCopyCommandPlayer.Enabled = lvwPlayers.SelectedItems.Count > 0 || !cboConsoleCommandsPlayer.Text.Contains("<");
            btnRconCommandPlayers.Enabled = lvwPlayers.SelectedItems.Count > 0 || !cboConsoleCommandsPlayer.Text.Contains("<");

            if (lvwPlayers.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwPlayers.SelectedItems[0];
                ContentPlayer selectedPlayer = (ContentPlayer)selectedItem.Tag;
                selectedX = (float)selectedPlayer.Longitude.GetValueOrDefault(0);
                selectedY = (float)selectedPlayer.Latitude.GetValueOrDefault(0);
            }

            DrawMap(selectedX, selectedY);


        }

        private void lvwPlayers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwPlayers.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_Players == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_Players)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_Players.Text.StartsWith("> "))
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
                SortingColumn_Players.Text = SortingColumn_Players.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_Players = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_Players.Text = "> " + SortingColumn_Players.Text;
            }
            else
            {
                SortingColumn_Players.Text = "< " + SortingColumn_Players.Text;
            }

            // Create a comparer.
            lvwPlayers.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwPlayers.Sort();
        }

        private void btnPlayerInventory_Click(object sender, EventArgs e)
        {
            if (lvwPlayers.SelectedItems.Count == 0) return;


            ContentPlayer selectedPlayer = (ContentPlayer)lvwPlayers.SelectedItems[0].Tag;

            frmPlayerInventoryViewer playerViewer = new frmPlayerInventoryViewer(cm, selectedPlayer);
            playerViewer.Owner = this;
            playerViewer.ShowDialog();

        }

        private void btnDinoAncestors_Click(object sender, EventArgs e)
        {
            if (lvwTameDetail.SelectedItems.Count == 0) return;

            //MessageBox.Show("Dino ancestor explorer coming soon.", "Coming Soon!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListViewItem selectedItem = lvwTameDetail.SelectedItems[0];
            ContentTamedCreature selectedTame = (ContentTamedCreature)selectedItem.Tag;
            using (frmBreedingLines ancestors = new frmBreedingLines(selectedTame, cm))
            {
                ancestors.ShowDialog();
            }

        }

        private void btnDinoInventory_Click(object sender, EventArgs e)
        {
            if (lvwTameDetail.SelectedItems.Count == 0) return;

            ContentTamedCreature selectedCreature = (ContentTamedCreature)lvwTameDetail.SelectedItems[0].Tag;
            var tribe = cm.GetTribes(selectedCreature.TargetingTeam).First();
            frmDinoInventoryViewer inventoryViewer = new frmDinoInventoryViewer(selectedCreature, selectedCreature.Inventory.Items);
            inventoryViewer.Owner = this;
            inventoryViewer.ShowDialog();
        }

        private void btnPlayerTribeLog_Click(object sender, EventArgs e)
        {

            if (lvwPlayers.SelectedItems.Count == 0) return;

            ContentPlayer selectedPlayer = (ContentPlayer)lvwPlayers.SelectedItems[0].Tag;
            var tribe = cm.GetPlayerTribe(selectedPlayer.Id);
            frmTribeLog logViewer = new frmTribeLog(tribe);
            logViewer.Owner = this;
            logViewer.ShowDialog();
        }

        private void cboStructureTribe_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlayerStructureDetail();
            RefreshStructurePlayerList();
        }

        private void cboStructurePlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStructurePlayer.SelectedItem == null) return;

            //select tribe
            ASVComboValue comboValue = (ASVComboValue)cboStructurePlayer.SelectedItem;
            long playerId = long.Parse(comboValue.Key);
            if (playerId == 0) return;

            var playerTribe = cm.GetPlayerTribe(playerId);
            if (playerTribe != null)
            {
                var foundTribe = cboStructureTribe.Items.Cast<ASVComboValue>().First(x => x.Key == playerTribe.TribeId.ToString());
                cboStructureTribe.SelectedIndex = cboStructureTribe.Items.IndexOf(foundTribe);
            }
        }

        private void lvwStructureLocations_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwStructureLocations.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_Structures == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_Structures)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_Structures.Text.StartsWith("> "))
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
                SortingColumn_Structures.Text = SortingColumn_Structures.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_Structures = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_Structures.Text = "> " + SortingColumn_Structures.Text;
            }
            else
            {
                SortingColumn_Structures.Text = "< " + SortingColumn_Structures.Text;
            }

            // Create a comparer.
            lvwStructureLocations.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwStructureLocations.Sort();
        }

        private void tabFeatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;



            //tabFeatures.Refresh();
            this.Cursor = Cursors.WaitCursor;
            switch (tabFeatures.SelectedTab.Name)
            {
                case "tpgWild":
                    if (lvwWildDetail.Items.Count == 0) LoadWildDetail();
                    break;
                case "tpgTamed":
                    if (lvwTameDetail.Items.Count == 0) LoadTameDetail();
                    break;
                case "tpgStructures":
                    if (lvwStructureLocations.Items.Count == 0) LoadPlayerStructureDetail();
                    break;
                case "tpgTribes":
                    if (lvwTribes.Items.Count == 0) RefreshTribeSummary();
                    break;
                case "tpgPlayers":
                    if (lvwPlayers.Items.Count == 0) LoadPlayerDetail();
                    break;
                case "tpgDroppedItems":
                    if (lvwDroppedItems.Items.Count == 0) LoadDroppedItemDetail();
                    break;
                case "tpgItemList":
                    if (lvwItemList.Items.Count == 0) LoadItemListDetail();
                    break;
                case "tpgLeaderboard":
                    if (lvwLeaderboardSummary.Items.Count == 0) LoadLeaderboardPlayers();
                    break;

                default:

                    break;
            }



            DrawMap(0, 0);
            this.Cursor = Cursors.Default;
        }

        private void lvwStructureLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            btnCopyCommandStructure.Enabled = lvwStructureLocations.SelectedItems.Count > 0 || !cboConsoleCommandsStructure.Text.Contains("<");
            btnRconCommandStructures.Enabled = lvwStructureLocations.SelectedItems.Count > 0 || !cboConsoleCommandsStructure.Text.Contains("<");


            btnStructureInventory.Enabled = false;


            if (lvwStructureLocations.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwStructureLocations.SelectedItems[0];
                ContentStructure selectedStructure = (ContentStructure)selectedItem.Tag;

                DrawMap((float)selectedStructure.Longitude.GetValueOrDefault(0), (float)selectedStructure.Latitude.GetValueOrDefault(0));

                //var inventory = cm.GetInventory(selectedStructure.InventoryId.GetValueOrDefault(0));
                btnStructureInventory.Enabled = selectedStructure.Inventory.Items.Count > 0;

            }

        }

        private void cboStructureStructure_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadPlayerStructureDetail();
        }

        private void btnStructureExclusionFilter_Click(object sender, EventArgs e)
        {
            if (cm == null) return;

            var structureList = cm.GetPlayerStructures(0, 0, "", true, "");
            if (structureList != null && structureList.Count > 0)
            {
                frmStructureExclusionFilter exclusionEditor = new frmStructureExclusionFilter(structureList);
                exclusionEditor.Owner = this;
                if (exclusionEditor.ShowDialog() == DialogResult.OK)
                {
                    RefreshStructureSummary();
                }

            }
            else
            {
                MessageBox.Show("Structure exclusions can only be set when a map with structures has been loaded.", "No Structures", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

        }

        private void btnCopyCommandPlayer_Click(object sender, EventArgs e)
        {
            string commandText = GetPlayerCommandText();
            if (commandText.Length > 0)
            {
                try
                {
                    Clipboard.Clear();
                    Clipboard.SetText(commandText);

                    lblStatus.Text = $"Command copied:  {commandText}";
                    lblStatus.Refresh();
                }
                catch
                {
                    lblStatus.Text = "Unable to copy command. Please try again.";
                    lblStatus.Refresh();
                }


            }
            else
            {
                lblStatus.Text = "Unable to parse selected copy command.";
                lblStatus.Refresh();
            }
        }

        private void btnCopyCommandStructure_Click(object sender, EventArgs e)
        {
            string commandText = GetStructureCommandText();
            if (commandText.Length > 0)
            {
                try
                {
                    Clipboard.Clear();
                    Clipboard.SetText(commandText);

                    lblStatus.Text = $"Command copied:  {commandText}";
                    lblStatus.Refresh();
                }
                catch
                {
                    lblStatus.Text = "Unable to copy command. Please try again.";
                    lblStatus.Refresh();
                }


            }
            else
            {
                lblStatus.Text = "Unable to parse selected copy command.";
                lblStatus.Refresh();
            }
        }

        private string GetStructureCommandText()
        {

            if (cboConsoleCommandsStructure.SelectedItem == null) return string.Empty;

            RCONCommand command = cboConsoleCommandsStructure.SelectedItem as RCONCommand;

            List<string> allCommands = new List<string>();
            string commandTemplate = command.GetTemplate();

            if (command.UserInputs.Count > 0)
            {
                foreach (var inputRequest in command.UserInputs)
                {
                    using (frmCommandInput inputForm = new frmCommandInput(inputRequest.Key))
                    {
                        if (inputForm.ShowDialog() == DialogResult.OK)
                        {
                            commandTemplate = commandTemplate.Replace($"<{inputRequest.Key}>", $"{inputForm.EnteredValue}");
                        }
                        else
                        {
                            //user cancelled, exit command builder
                            return string.Empty;
                        }
                    }
                }
            }

            if (command.Parameters.Count == 0 || lvwStructureLocations.SelectedItems.Count == 0)
            {
                allCommands.Add(commandTemplate);
            }

            if (lvwStructureLocations.SelectedItems.Count > 0 && command.Parameters.Count > 0)
            {
                foreach (var defaultParam in command.Parameters.Where(p => !string.IsNullOrEmpty(p.Default)))
                {
                    commandTemplate = commandTemplate.Replace($"<{defaultParam.Key}>", $"{defaultParam.Default}");
                }

                foreach (ListViewItem selectedItem in lvwStructureLocations.SelectedItems)
                {
                    ContentStructure selectedStructure = (ContentStructure)selectedItem.Tag;

                    string commandText = commandTemplate;

                    commandText = commandText.Replace("<TribeID>", selectedStructure.TargetingTeam.ToString("f0"));

                    commandText = commandText.Replace("<x>", System.FormattableString.Invariant($"{selectedStructure.X:0.00}"));
                    commandText = commandText.Replace("<y>", System.FormattableString.Invariant($"{selectedStructure.Y:0.00}"));
                    commandText = commandText.Replace("<z>", System.FormattableString.Invariant($"{selectedStructure.Z + 250:0.00}"));



                    switch (Program.ProgramConfig.CommandPrefix)
                    {
                        case 1:
                            commandText = $"admincheat {commandText}";

                            break;
                        case 2:
                            commandText = $"cheat {commandText}";
                            break;
                    }

                    commandText = commandText.Trim();

                    if (!allCommands.Contains(commandText)) allCommands.Add(commandText);

                }
            }


            return string.Join('|', allCommands.ToArray());
        }

        private void cboConsoleCommandsStructure_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnCopyCommandStructure.Enabled = lvwStructureLocations.SelectedItems.Count > 0 || !cboConsoleCommandsStructure.Text.Contains("<");
            btnRconCommandStructures.Enabled = lvwStructureLocations.SelectedItems.Count > 0 || !cboConsoleCommandsStructure.Text.Contains("<");

        }

        private void cboTameTribes_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTamePlayerList();
            LoadTameDetail();
        }

        private void cboTamePlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTamePlayers.SelectedItem == null) return;

            //select tribe
            ASVComboValue comboValue = (ASVComboValue)cboTamePlayers.SelectedItem;
            long playerId = long.Parse(comboValue.Key);
            if (playerId == 0) return;

            var playerTribe = cm.GetPlayerTribe(playerId);
            if (playerTribe != null)
            {
                var foundTribe = cboTameTribes.Items.Cast<ASVComboValue>().First(x => x.Key == playerTribe.TribeId.ToString());
                cboTameTribes.SelectedIndex = cboTameTribes.Items.IndexOf(foundTribe);
            }

        }

        private void cboTameClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTameClass.SelectedIndex != 1 && cboTamedResource.SelectedIndex > 0) cboTamedResource.SelectedIndex = 0;

            LoadTameDetail();
        }

        private void lvwTameDetail_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwTameDetail.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_DetailTame == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_DetailTame)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_DetailTame.Text.StartsWith("> "))
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
                SortingColumn_DetailTame.Text = SortingColumn_DetailTame.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_DetailTame = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_DetailTame.Text = "> " + SortingColumn_DetailTame.Text;
            }
            else
            {
                SortingColumn_DetailTame.Text = "< " + SortingColumn_DetailTame.Text;
            }

            // Create a comparer.
            lvwTameDetail.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwTameDetail.Sort();
        }

        private void optStatsBase_CheckedChanged(object sender, EventArgs e)
        {
            if (optStatsBase.Checked)
            {
                LoadTameDetail();
            }
        }

        private void lvwTameDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            btnCopyCommandTamed.Enabled = lvwTameDetail.SelectedItems.Count > 0 || !cboConsoleCommandsTamed.Text.Contains("<");
            btnRconCommandTamed.Enabled = lvwTameDetail.SelectedItems.Count > 0 || !cboConsoleCommandsTamed.Text.Contains("<");
            btnDinoInventory.Enabled = lvwTameDetail.SelectedItems.Count > 0;
            btnDinoAncestors.Enabled = lvwTameDetail.SelectedItems.Count > 0;

            if (lvwTameDetail.SelectedItems.Count > 0)
            {

                var selectedItem = lvwTameDetail.SelectedItems[0];
                ContentTamedCreature selectedTame = (ContentTamedCreature)selectedItem.Tag;
                DrawMap(selectedTame.Longitude.GetValueOrDefault(0), selectedTame.Latitude.GetValueOrDefault(0));

            }
            this.Cursor = Cursors.Default;
        }

        private void picMap_MouseClick(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            PictureBox clickedPic = (PictureBox)sender;

            double zoomLevel = (double)clickedPic.Height / (double)clickedPic.Image.Height;


            double clickY = e.Location.Y / (zoomLevel);
            double clickX = e.Location.X / (zoomLevel);

            double latitude = clickY / 10.25;
            double longitude = clickX / 10.25;

            switch (tabFeatures.SelectedTab.Name)
            {
                case "tpgWild":

                    if (lvwWildDetail.Items.Count > 0)
                    {
                        //get nearest 
                        foreach (ListViewItem item in lvwWildDetail.Items)
                        {
                            if (item.SubItems[4].Text != "n/a")
                            {
                                double itemLat = Convert.ToDouble(item.SubItems[4].Text);
                                double itemLon = Convert.ToDouble(item.SubItems[5].Text);

                                double latDistance = Math.Abs(itemLat - latitude);
                                double lonDistance = Math.Abs(itemLon - longitude);


                                if (latDistance <= 0.5 && lonDistance <= 0.5)
                                {
                                    lvwWildDetail.SelectedItems.Clear();
                                    item.Selected = true;
                                    item.EnsureVisible();
                                    break;
                                }
                            }



                        }


                    }


                    break;
                case "tpgTamed":

                    if (lvwTameDetail.Items.Count > 0)
                    {
                        //get nearest 
                        foreach (ListViewItem item in lvwTameDetail.Items)
                        {
                            if (item.SubItems[5].Text != "n/a")
                            {
                                double itemLat = Convert.ToDouble(item.SubItems[5].Text);
                                double itemLon = Convert.ToDouble(item.SubItems[6].Text);

                                double latDistance = itemLat - latitude;
                                double lonDistance = itemLon - longitude;


                                if ((latDistance >= 0 && latDistance <= 0.5) && (lonDistance >= 0 && lonDistance <= 0.5))
                                {
                                    lvwTameDetail.SelectedItems.Clear();
                                    item.Selected = true;
                                    item.EnsureVisible();
                                    break;
                                }
                            }



                        }


                    }

                    break;
                case "tpgStructures":
                    if (lvwStructureLocations.Items.Count > 0)
                    {
                        //get nearest 
                        foreach (ListViewItem item in lvwStructureLocations.Items)
                        {
                            if (item.SubItems[3].Text != "n/a")
                            {
                                double itemLat = Convert.ToDouble(item.SubItems[3].Text);
                                double itemLon = Convert.ToDouble(item.SubItems[4].Text);

                                double latDistance = itemLat - latitude;
                                double lonDistance = itemLon - longitude;


                                if ((latDistance >= 0 && latDistance <= 0.5) && (lonDistance >= 0 && lonDistance <= 0.5))
                                {
                                    lvwStructureLocations.SelectedItems.Clear();
                                    item.Selected = true;
                                    item.EnsureVisible();
                                    break;
                                }
                            }



                        }


                    }


                    break;
                case "tpgPlayers":
                    if (lvwPlayers.Items.Count > 0)
                    {

                        //get nearest 
                        foreach (ListViewItem item in lvwPlayers.Items)
                        {
                            if (item.SubItems[4].Text != "n/a")
                            {
                                double itemLat = Convert.ToDouble(item.SubItems[4].Text);
                                double itemLon = Convert.ToDouble(item.SubItems[5].Text);

                                double latDistance = Math.Abs(itemLat - latitude);
                                double lonDistance = Math.Abs(itemLon - longitude);

                                if (latDistance <= 0.75 && lonDistance <= 0.75)
                                {
                                    lvwPlayers.SelectedItems.Clear();
                                    item.Selected = true;
                                    item.EnsureVisible();
                                    break;
                                }
                            }

                        }
                    }

                    break;

                default:
                    break;
            }


            this.Cursor = Cursors.Default;
        }

        private void btnCopyCommandWild_Click(object sender, EventArgs e)
        {

            string commandText = GetWildCommandText();
            if (commandText.Length > 0)
            {
                try
                {
                    Clipboard.Clear();
                    Clipboard.SetText(commandText);

                    lblStatus.Text = $"Command copied:  {commandText}";
                    lblStatus.Refresh();
                }
                catch
                {
                    lblStatus.Text = "Unable to copy command. Please try again.";
                    lblStatus.Refresh();
                }


            }
            else
            {
                lblStatus.Text = "Unable to parse selected copy command.";
                lblStatus.Refresh();
            }
        }

        private string GetItemSearchCommandText()
        {
            if (cboConsoleCommandSearch.SelectedItem == null) return string.Empty;


            RCONCommand command = cboConsoleCommandSearch.SelectedItem as RCONCommand;

            List<string> allCommands = new List<string>();
            string commandTemplate = command.GetTemplate();

            if (command.UserInputs.Count > 0)
            {
                foreach (var inputRequest in command.UserInputs)
                {
                    using (frmCommandInput inputForm = new frmCommandInput(inputRequest.Key))
                    {
                        if (inputForm.ShowDialog() == DialogResult.OK)
                        {

                            commandTemplate = commandTemplate.Replace($"<{inputRequest.Key}>", $"{inputForm.EnteredValue}");
                        }
                        else
                        {
                            //user cancelled, exit command builder
                            return string.Empty;
                        }
                    }
                }
            }

            if (command.Parameters.Count == 0 || lvwItemList.SelectedItems.Count == 0)
            {
                allCommands.Add(commandTemplate);
            }



            if (command.Parameters.Count > 0 && lvwItemList.SelectedItems.Count > 0)
            {

                foreach (var defaultParam in command.Parameters.Where(p => !string.IsNullOrEmpty(p.Default)))
                {

                    commandTemplate = commandTemplate.Replace($"<{defaultParam.Key}>", $"{defaultParam.Default}");
                }

                foreach (ListViewItem selectedItem in lvwItemList.SelectedItems)
                {
                    ASVFoundItem foundItem = (ASVFoundItem)selectedItem.Tag;
                    string commandText = commandTemplate;

                    commandText = commandText.Replace("<x>", System.FormattableString.Invariant($"{foundItem.X:0.00}"));
                    commandText = commandText.Replace("<y>", System.FormattableString.Invariant($"{foundItem.Y:0.00}"));
                    commandText = commandText.Replace("<z>", System.FormattableString.Invariant($"{foundItem.Z + 100:0.00}"));

                    switch (Program.ProgramConfig.CommandPrefix)
                    {
                        case 1:
                            commandText = $"admincheat {commandText}";

                            break;
                        case 2:
                            commandText = $"cheat {commandText}";
                            break;
                    }

                    commandText = commandText.Trim();

                    if (!allCommands.Contains(commandText)) allCommands.Add(commandText);

                }
            }

            return string.Join('|', allCommands.ToArray());
        }

        private string GetPlayerCommandText()
        {

            if (cboConsoleCommandsPlayer.SelectedItem == null) return string.Empty;

            RCONCommand command = cboConsoleCommandsPlayer.SelectedItem as RCONCommand;

            List<string> allCommands = new List<string>();
            string commandTemplate = command.GetTemplate();

            if (command.UserInputs.Count > 0)
            {
                foreach (var inputRequest in command.UserInputs)
                {
                    using (frmCommandInput inputForm = new frmCommandInput(inputRequest.Key))
                    {
                        if (inputForm.ShowDialog() == DialogResult.OK)
                        {
                            commandTemplate = commandTemplate.Replace($"<{inputRequest.Key}>", $"{inputForm.EnteredValue}");
                        }
                        else
                        {
                            //user cancelled, exit command builder
                            return string.Empty;
                        }
                    }
                }
            }

            if (command.Parameters.Count == 0 || lvwPlayers.SelectedItems.Count == 0)
            {
                allCommands.Add(commandTemplate);
            }
            if (command.Parameters.Count > 0 && lvwPlayers.SelectedItems.Count > 0)
            {
                foreach (var defaultParam in command.Parameters.Where(p => !string.IsNullOrEmpty(p.Default)))
                {
                    commandTemplate = commandTemplate.Replace($"<{defaultParam.Key}>", $"{defaultParam.Default}");
                }

                if (commandTemplate.Contains("<FileCsvList>"))
                {
                    string fileList = "";
                    string commandList = commandTemplate;

                    foreach (ListViewItem selectedItem in lvwTribes.SelectedItems)
                    {
                        ContentTribe selectedTribe = (ContentTribe)selectedItem.Tag;
                        if (fileList.Length > 0)
                        {
                            fileList = fileList + " ";
                        }
                        fileList = fileList + selectedTribe.TribeId.ToString() + ".arktribe";
                    }

                    commandList = commandList.Replace("<FileCsvList>", fileList);
                    allCommands.Add(commandList);
                }
                else
                {
                    foreach (ListViewItem selectedItem in lvwPlayers.SelectedItems)
                    {
                        ContentPlayer selectedPlayer = (ContentPlayer)selectedItem.Tag;
                        string commandText = commandTemplate;

                        long selectedPlayerId = selectedPlayer.Id;
                        string selectedSteamId = selectedPlayer.NetworkId;

                        var tribe = cm.GetPlayerTribe(selectedPlayer.Id);
                        long selectedTribeId = selectedPlayer.TargetingTeam;

                        commandText = commandText.Replace("<PlayerID>", selectedPlayerId.ToString("f0"));
                        commandText = commandText.Replace("<TribeID>", selectedTribeId.ToString("f0"));
                        commandText = commandText.Replace("<SteamID>", selectedSteamId);
                        commandText = commandText.Replace("<PlayerName>", selectedPlayer.Name);
                        commandText = commandText.Replace("<CharacterName>", selectedPlayer.CharacterName);
                        commandText = commandText.Replace("<XP>", selectedPlayer.ExperiencePoints.ToString("f0"));

                        if (tribe != null)
                        {
                            commandText = commandText.Replace("<TribeName>", tribe.TribeName);
                        }

                        commandText = commandText.Replace("<x>", System.FormattableString.Invariant($"{selectedPlayer.X:0.00}"));
                        commandText = commandText.Replace("<y>", System.FormattableString.Invariant($"{selectedPlayer.Y:0.00}"));
                        commandText = commandText.Replace("<z>", System.FormattableString.Invariant($"{selectedPlayer.Z + 250:0.00}"));

                        switch (Program.ProgramConfig.CommandPrefix)
                        {
                            case 1:
                                commandText = $"admincheat {commandText}";

                                break;
                            case 2:
                                commandText = $"cheat {commandText}";
                                break;
                        }

                        commandText = commandText.Trim();

                        if (!allCommands.Contains(commandText)) allCommands.Add(commandText);
                    }

                }



            }



            return string.Join('|', allCommands.ToArray());

        }


        private string GetWildCommandText()
        {
            if (cboConsoleCommandsWild.SelectedItem == null) return string.Empty;
            RCONCommand command = cboConsoleCommandsWild.SelectedItem as RCONCommand;

            List<string> allCommands = new List<string>();
            string commandTemplate = command.GetTemplate();

            if (command.UserInputs.Count > 0)
            {
                foreach (var inputRequest in command.UserInputs)
                {
                    using (frmCommandInput inputForm = new frmCommandInput(inputRequest.Key))
                    {
                        inputForm.Owner = this;
                        if (inputForm.ShowDialog() == DialogResult.OK)
                        {
                            commandTemplate = commandTemplate.Replace($"<{inputRequest.Key}>", $"{inputForm.EnteredValue}");
                        }
                        else
                        {
                            //user cancelled, exit command builder
                            return string.Empty;
                        }
                    }
                }
            }

            if (command.Parameters.Count == 0 || lvwWildDetail.SelectedItems.Count == 0)
            {
                allCommands.Add(commandTemplate);
            }

            if (command.Parameters.Count > 0 && lvwWildDetail.SelectedItems.Count > 0)
            {
                foreach (var defaultParam in command.Parameters.Where(p => p.Default != null))
                {
                    commandTemplate = commandTemplate.Replace($"<{defaultParam.Key}>", $"{defaultParam.Default}");
                }

                foreach (ListViewItem selectedItem in lvwWildDetail.SelectedItems)
                {
                    ContentWildCreature selectedCreature = (ContentWildCreature)selectedItem.Tag;
                    string commandText = commandTemplate;

                    commandText = commandText.Replace("<ClassName>", selectedCreature.ClassName);
                    commandText = commandText.Replace("<Level>", selectedCreature.BaseLevel.ToString("f0"));
                    commandText = commandText.Replace("<x>", System.FormattableString.Invariant($"{selectedCreature.X:0.00}"));
                    commandText = commandText.Replace("<y>", System.FormattableString.Invariant($"{selectedCreature.Y:0.00}"));
                    commandText = commandText.Replace("<z>", System.FormattableString.Invariant($"{selectedCreature.Z + 250:0.00}"));
                    commandText = commandText.Replace("<DinoId>", selectedCreature.DinoId.ToString());


                    if (commandText.Contains("<BlueprintPath>"))
                    {
                        var dinoMap = Program.ProgramConfig.DinoMap.Find(x => x.ClassName.Equals(selectedCreature.ClassName, StringComparison.InvariantCultureIgnoreCase));
                        if (dinoMap != null)
                        {
                            commandText = commandText.Replace("<BlueprintPath>", dinoMap.BlueprintPath?.Replace("\"", ""));
                        }


                    }
                    commandText = commandText.Replace("<BaseLevel>", selectedCreature.BaseLevel.ToString());
                    commandText = commandText = commandText.Replace("<AddedLevels>", "0");
                    commandText = commandText.Replace("<hp-w>", selectedCreature.BaseStats[0].ToString());
                    commandText = commandText.Replace("<stam-w>", selectedCreature.BaseStats[1].ToString());
                    commandText = commandText.Replace("<oxy-w>", selectedCreature.BaseStats[3].ToString());
                    commandText = commandText.Replace("<food-w>", selectedCreature.BaseStats[4].ToString());
                    commandText = commandText.Replace("<weight-w>", selectedCreature.BaseStats[7].ToString());
                    commandText = commandText.Replace("<melee-w>", selectedCreature.BaseStats[8].ToString());
                    commandText = commandText.Replace("<craft-w>", selectedCreature.BaseStats[11].ToString());
                    commandText = commandText.Replace("<speed-w>", selectedCreature.BaseStats[11].ToString());


                    commandText = commandText.Replace("<hp-t>", "0");
                    commandText = commandText.Replace("<stam-t>", "0");
                    commandText = commandText.Replace("<oxy-t>", "0");
                    commandText = commandText.Replace("<food-t>", "0");
                    commandText = commandText.Replace("<weight-t>", "0");
                    commandText = commandText.Replace("<melee-t>", "0");
                    commandText = commandText.Replace("<craft-t>", "0");
                    commandText = commandText.Replace("<speed-t>", "0");

                    commandText = commandText.Replace("<c0>", selectedCreature.Colors[0].ToString());
                    commandText = commandText.Replace("<c1>", selectedCreature.Colors[1].ToString());
                    commandText = commandText.Replace("<c2>", selectedCreature.Colors[2].ToString());
                    commandText = commandText.Replace("<c3>", selectedCreature.Colors[3].ToString());
                    commandText = commandText.Replace("<c4>", selectedCreature.Colors[4].ToString());
                    commandText = commandText.Replace("<c5>", selectedCreature.Colors[5].ToString());

                    commandText = commandText.Replace("<ImprintedName>", "");
                    commandText = commandText.Replace("<ImprintedPlayerId>", "0");
                    commandText = commandText.Replace("<ImprintQuality>", "0");

                    switch (Program.ProgramConfig.CommandPrefix)
                    {
                        case 1:
                            commandText = $"admincheat {commandText}";

                            break;
                        case 2:
                            commandText = $"cheat {commandText}";
                            break;
                    }

                    commandText = commandText.Trim();

                    if (!allCommands.Contains(commandText)) allCommands.Add(commandText);

                }

            }


            return string.Join('|', allCommands.ToArray());
        }


        private void btnCopyCommandTamed_Click(object sender, EventArgs e)
        {
            string commandText = GetTamedCommandText();
            if (commandText.Length > 0)
            {
                try
                {
                    Clipboard.Clear();
                    Clipboard.SetText(commandText);

                    lblStatus.Text = $"Command copied:  {commandText}";
                    lblStatus.Refresh();
                }
                catch
                {
                    lblStatus.Text = "Unable to copy command. Please try again.";
                    lblStatus.Refresh();
                }

            }
            else
            {
                lblStatus.Text = "Unable to parse selected copy command.";
                lblStatus.Refresh();
            }
        }

        private string GetTamedCommandText()
        {

            if (cboConsoleCommandsTamed.SelectedItem == null) return string.Empty;


            RCONCommand command = cboConsoleCommandsTamed.SelectedItem as RCONCommand;

            List<string> allCommands = new List<string>();
            string commandTemplate = command.GetTemplate();

            if (command.UserInputs.Count > 0)
            {
                foreach (var inputRequest in command.UserInputs)
                {
                    using (frmCommandInput inputForm = new frmCommandInput(inputRequest.Key))
                    {
                        if (inputForm.ShowDialog() == DialogResult.OK)
                        {
                            commandTemplate = commandTemplate.Replace($"<{inputRequest.Key}>", $"{inputForm.EnteredValue}");
                        }
                        else
                        {
                            //user cancelled, exit command builder
                            return string.Empty;
                        }
                    }
                }
            }

            if (commandTemplate.Contains("AddMutations"))
            {
                //only first selected item - but one command per mutation
                ContentTamedCreature selectedCreature = (ContentTamedCreature)lvwTameDetail.SelectedItems[0].Tag;

                bool hasMutations = false;
                List<string> mutationCommands = new List<string>();

                for (int statId = 0; statId < selectedCreature.TamedMutations.Length; statId++)
                {

                    int statValue = selectedCreature.TamedMutations[statId];
                    if (statValue != 0)
                    {
                        hasMutations = true;

                        string mutationText = $"AddMutations {statId} {statValue}";

                        switch (Program.ProgramConfig.CommandPrefix)
                        {
                            case 1:
                                mutationText = $"admincheat {mutationText}";

                                break;
                            case 2:
                                mutationText = $"cheat {mutationText}";
                                break;
                        }
                        mutationText = mutationText.Trim();
                        mutationCommands.Add(mutationText);
                    }
                }

                if (hasMutations)
                {
                    return string.Join('|', mutationCommands.ToArray());
                }
                else
                {
                    return string.Empty;
                }
            }

            if (command.Parameters.Count == 0 || lvwTameDetail.SelectedItems.Count == 0)
            {
                allCommands.Add(commandTemplate);
            }


            if (command.Parameters.Count > 0 && lvwTameDetail.SelectedItems.Count > 0)
            {
                foreach (var defaultParam in command.Parameters.Where(p => p.Default != null))
                {
                    commandTemplate = commandTemplate.Replace($"<{defaultParam.Key}>", defaultParam.Default);
                }




                foreach (ListViewItem selectedItem in lvwTameDetail.SelectedItems)
                {
                    string commandText = commandTemplate;

                    ContentTamedCreature selectedCreature = (ContentTamedCreature)selectedItem.Tag;
                    commandText = commandText.Replace("<ClassName>", selectedCreature.ClassName);
                    commandText = commandText.Replace("<Level>", (selectedCreature.BaseLevel / 1.5).ToString("f0"));
                    commandText = commandText.Replace("<TribeID>", selectedCreature.TargetingTeam.ToString("f0"));
                    commandText = commandText.Replace("<DinoId>", selectedCreature.DinoId.ToString());

                    if (commandText.Contains("<BlueprintPath>"))
                    {
                        var dinoMap = Program.ProgramConfig.DinoMap.Find(x => x.ClassName.Equals(selectedCreature.ClassName, StringComparison.InvariantCultureIgnoreCase));
                        if (dinoMap != null)
                        {
                            commandText = commandText.Replace("<BlueprintPath>", dinoMap.BlueprintPath?.Replace("\"", ""));
                        }
                        else
                        {
                            lblStatus.Text = $"Command failed: No blueprint path can be found for the selected creature.";
                            lblStatus.Refresh();
                            return string.Empty;
                        }
                    }

                    commandText = commandText.Replace("<BaseLevel>", selectedCreature.BaseLevel.ToString());
                    commandText = commandText.Replace("<AddedLevels>", (selectedCreature.Level - selectedCreature.BaseLevel).ToString());
                    commandText = commandText.Replace("<hp-w>", selectedCreature.BaseStats[0].ToString());
                    commandText = commandText.Replace("<stam-w>", selectedCreature.BaseStats[1].ToString());
                    commandText = commandText.Replace("<oxy-w>", selectedCreature.BaseStats[3].ToString());
                    commandText = commandText.Replace("<food-w>", selectedCreature.BaseStats[4].ToString());
                    commandText = commandText.Replace("<weight-w>", selectedCreature.BaseStats[7].ToString());
                    commandText = commandText.Replace("<melee-w>", selectedCreature.BaseStats[8].ToString());
                    commandText = commandText.Replace("<craft-w>", selectedCreature.BaseStats[11].ToString());
                    commandText = commandText.Replace("<speed-w>", selectedCreature.BaseStats[9].ToString());


                    commandText = commandText.Replace("<hp-t>", selectedCreature.TamedStats[0].ToString());
                    commandText = commandText.Replace("<stam-t>", selectedCreature.TamedStats[1].ToString());
                    commandText = commandText.Replace("<oxy-t>", selectedCreature.TamedStats[3].ToString());
                    commandText = commandText.Replace("<food-t>", selectedCreature.TamedStats[4].ToString());
                    commandText = commandText.Replace("<weight-t>", selectedCreature.TamedStats[7].ToString());
                    commandText = commandText.Replace("<melee-t>", selectedCreature.TamedStats[8].ToString());
                    commandText = commandText.Replace("<craft-t>", selectedCreature.TamedStats[11].ToString());
                    commandText = commandText.Replace("<speed-t>", selectedCreature.TamedStats[9].ToString());


                    commandText = commandText.Replace("<c0>", selectedCreature.Colors[0].ToString());
                    commandText = commandText.Replace("<c1>", selectedCreature.Colors[1].ToString());
                    commandText = commandText.Replace("<c2>", selectedCreature.Colors[2].ToString());
                    commandText = commandText.Replace("<c3>", selectedCreature.Colors[3].ToString());
                    commandText = commandText.Replace("<c4>", selectedCreature.Colors[4].ToString());
                    commandText = commandText.Replace("<c5>", selectedCreature.Colors[5].ToString());

                    commandText = commandText.Replace("<ImprintedName>", selectedCreature.ImprinterName);
                    commandText = commandText.Replace("<ImprintedPlayerId>", selectedCreature.ImprintedPlayerId.ToString());
                    commandText = commandText.Replace("<ImprintQuality>", selectedCreature.ImprintQuality.ToString());
                    commandText = commandText.Replace("<Name>", selectedCreature.Name);
                    commandText = commandText.Replace("<ServerName>", selectedCreature.TamedOnServerName ?? "");
                    commandText = commandText.Replace("<TamedDate>", selectedCreature.TamedAtDateTime?.ToString("yyyy-mm-dd"));
                    commandText = commandText.Replace("<CreatureXP>", selectedCreature.Experience.ToString("f4"));

                    commandText = commandText.Replace("<x>", System.FormattableString.Invariant($"{selectedCreature.X:0.00}"));
                    commandText = commandText.Replace("<y>", System.FormattableString.Invariant($"{selectedCreature.Y:0.00}"));
                    commandText = commandText.Replace("<z>", System.FormattableString.Invariant($"{selectedCreature.Z + 250:0.00}"));

                    switch (Program.ProgramConfig.CommandPrefix)
                    {
                        case 1:
                            commandText = commandText.Replace("<DoTame>", "admincheat DoTame");
                            commandText = $"admincheat {commandText}";

                            break;
                        case 2:
                            commandText = commandText.Replace("<DoTame>", "cheat DoTame");
                            commandText = $"cheat {commandText}";
                            break;
                    }

                    commandText = commandText.Trim();

                    if (!allCommands.Contains(commandText)) allCommands.Add(commandText);


                }
            }


            return string.Join('|', allCommands.ToArray());
        }

        private void lvwPlayers_Click(object sender, EventArgs e)
        {

        }

        private void lvwPlayers_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mnuContext_PlayerId.Visible = true;
                mnuContext_ProfileFilename.Visible = true;
                mnuContext_SteamId.Visible = true;
                mnuContext_TribeId.Visible = false;
                mnuContext_Structures.Visible = true;
                mnuContext_Tames.Visible = true;
                mnuContext_Players.Visible = false;
                mnuContext_DinoId.Visible = false;

            }
            else
            {
                if (isLoading) return;

                //picMap.Image = DrawMap(lastSelectedX, lastSelectedY);
                btnPlayerInventory.Enabled = lvwPlayers.SelectedItems.Count == 1;
                btnPlayerTribeLog.Enabled = lvwPlayers.SelectedItems.Count == 1;
                btnCopyCommandPlayer.Enabled = lvwPlayers.SelectedItems.Count > 0 && cboConsoleCommandsPlayer.SelectedIndex >= 0;
                btnRconCommandPlayers.Enabled = lvwPlayers.SelectedItems.Count > 0 && cboConsoleCommandsPlayer.SelectedIndex >= 0;

                btnDeletePlayer.Enabled = lvwPlayers.SelectedItems.Count == 1;
            }
        }

        private void lvwStructureLocations_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mnuContext_PlayerId.Visible = false;
                mnuContext_ProfileFilename.Visible = false;
                mnuContext_SteamId.Visible = false;
                mnuContext_TribeId.Visible = true;
                mnuContext_Structures.Visible = false;
                mnuContext_Tames.Visible = true;
                mnuContext_Players.Visible = true;
                mnuContext_DinoId.Visible = false;

            }
        }

        private void mnuContext_PlayerId_Click(object sender, EventArgs e)
        {
            switch (tabFeatures.SelectedTab.Name)
            {
                case "tpgWild":

                    break;
                case "tpgTamed":

                    break;

                case "tpgStructures":

                    break;
                case "tpgPlayers":
                    if (lvwPlayers.SelectedItems.Count > 0)
                    {
                        ContentPlayer player = (ContentPlayer)lvwPlayers.SelectedItems[0].Tag;
                        try
                        {
                            Clipboard.SetText(player.Id.ToString("f0"));
                            MessageBox.Show("Player ID copied to the clipboard!", "Copy Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch
                        {

                            MessageBox.Show("Failed to copy command.\n\nPlease try again.", "Copy Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    break;
            }
        }

        private void mnuContext_SteamId_Click(object sender, EventArgs e)
        {
            switch (tabFeatures.SelectedTab.Name)
            {
                case "tpgWild":

                    break;
                case "tpgTamed":

                    break;

                case "tpgStructures":

                    break;
                case "tpgPlayers":
                    if (lvwPlayers.SelectedItems.Count > 0)
                    {

                        ContentPlayer player = (ContentPlayer)lvwPlayers.SelectedItems[0].Tag;
                        try
                        {
                            Clipboard.SetText(player.NetworkId.ToString());
                            MessageBox.Show("Steam ID copied to the clipboard!", "Copy Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {

                            MessageBox.Show("Failed to copy command.\n\nPlease try again.", "Copy Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    break;
            }
        }

        private void mnuContext_TribeId_Click(object sender, EventArgs e)
        {
            switch (tabFeatures.SelectedTab.Name)
            {
                case "tpgWild":

                    break;
                case "tpgTamed":
                    if (lvwTameDetail.SelectedItems.Count > 0)
                    {
                        ContentTamedCreature creature = (ContentTamedCreature)lvwTameDetail.SelectedItems[0].Tag;
                        try
                        {
                            Clipboard.SetText(creature.TargetingTeam.ToString("f0"));
                            MessageBox.Show("Tribe ID copied to the clipboard!", "Copy Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {

                            MessageBox.Show("Failed to copy command.\n\nPlease try again.", "Copy Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    break;

                case "tpgStructures":
                    if (lvwStructureLocations.SelectedItems.Count > 0)
                    {
                        ContentStructure structure = (ContentStructure)lvwStructureLocations.SelectedItems[0].Tag;
                        try
                        {
                            Clipboard.SetText(structure.TargetingTeam.ToString("f0"));
                            MessageBox.Show("Tribe ID copied to the clipboard!", "Copy Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {

                            MessageBox.Show("Failed to copy command.\n\nPlease try again.", "Copy Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    break;
                case "tpgTribes":
                    if (lvwTribes.SelectedItems.Count > 0)
                    {
                        ContentTribe selectedTribe = (ContentTribe)lvwTribes.SelectedItems[0].Tag;

                        try
                        {
                            Clipboard.SetText(selectedTribe.TribeId.ToString("f0"));
                            MessageBox.Show("Tribe ID copied to the clipboard!", "Copy Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {

                            MessageBox.Show("Failed to copy command.\n\nPlease try again.", "Copy Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    break;
                case "tpgPlayers":

                    break;
            }
        }

        private void cboDroppedPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDroppedItems();
        }

        private void cboDroppedItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDroppedItemDetail();
        }

        private void lvwDroppedItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCopyCommandDropped.Enabled = !cboConsoleCommandDropped.Text.Contains("<") || lvwDroppedItems.SelectedItems.Count > 0;

            if (lvwDroppedItems.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwDroppedItems.SelectedItems[0];

                float selectedX = 0;
                float selectedY = 0;

                ContentDroppedItem droppedItem = (ContentDroppedItem)selectedItem.Tag;

                selectedX = droppedItem.Longitude.GetValueOrDefault(0);
                selectedY = droppedItem.Latitude.GetValueOrDefault(0);

                btnDropInventory.Enabled = droppedItem.Inventory.Items.Count > 0;

                DrawMap(selectedX, selectedY);
            }

        }

        private string GetDroppedItemCommandText()
        {

            if (cboConsoleCommandDropped.SelectedItem == null) return string.Empty;

            RCONCommand command = cboConsoleCommandDropped.SelectedItem as RCONCommand;

            List<string> allCommands = new List<string>();
            string commandTemplate = command.GetTemplate();

            if (command.UserInputs.Count > 0)
            {
                foreach (var inputRequest in command.UserInputs)
                {
                    using (frmCommandInput inputForm = new frmCommandInput(inputRequest.Key))
                    {
                        if (inputForm.ShowDialog() == DialogResult.OK)
                        {

                            commandTemplate = commandTemplate.Replace($"<{inputRequest.Key}>", $"{inputForm.EnteredValue}");
                        }
                        else
                        {
                            //user cancelled, exit command builder
                            return string.Empty;
                        }
                    }
                }
            }

            if (command.Parameters.Count == 0 || lvwDroppedItems.SelectedItems.Count == 0)
            {
                allCommands.Add(commandTemplate);
            }

            if (command.Parameters.Count > 0 && lvwDroppedItems.SelectedItems.Count > 0)
            {
                foreach (var defaultParam in command.Parameters.Where(p => !string.IsNullOrEmpty(p.Default)))
                {

                    commandTemplate = commandTemplate.Replace($"<{defaultParam.Key}>", $"{defaultParam.Default}");
                }

                foreach (ListViewItem selectedItem in lvwDroppedItems.SelectedItems)
                {
                    ContentDroppedItem droppedItem = (ContentDroppedItem)selectedItem.Tag;
                    string commandText = commandTemplate;

                    commandText = commandText.Replace("<x>", System.FormattableString.Invariant($"{droppedItem.X:0.00}"));
                    commandText = commandText.Replace("<y>", System.FormattableString.Invariant($"{droppedItem.Y:0.00}"));
                    commandText = commandText.Replace("<z>", System.FormattableString.Invariant($"{droppedItem.Z + 100:0.00}"));

                    switch (Program.ProgramConfig.CommandPrefix)
                    {
                        case 1:
                            commandText = $"admincheat {commandText}";

                            break;
                        case 2:
                            commandText = $"cheat {commandText}";
                            break;
                    }

                    commandText = commandText.Trim();
                    if (!allCommands.Contains(commandText)) allCommands.Add(commandText);

                }
            }

            return string.Join('|', allCommands.ToArray());
        }

        private void btnCopyCommandDropped_Click(object sender, EventArgs e)
        {
            string commandText = GetDroppedItemCommandText();
            if (commandText.Length > 0)
            {
                try
                {
                    Clipboard.Clear();
                    Clipboard.SetText(commandText);

                    lblStatus.Text = $"Command copied:  {commandText}";
                    lblStatus.Refresh();
                }
                catch
                {

                    lblStatus.Text = "Failed to copy command.  Please try again.";
                    lblStatus.Refresh();
                }


            }
            else
            {
                lblStatus.Text = "Unable to parse selected copy command.";
                lblStatus.Refresh();
            }
        }

        private void udWildMax_ValueChanged(object sender, EventArgs e)
        {
            if (udWildMin.Value > udWildMax.Value) udWildMin.Value = udWildMax.Value;
            udWildMin.Maximum = udWildMax.Value;
            RefreshWildSummary();
        }

        private void udWildMin_ValueChanged(object sender, EventArgs e)
        {
            if (udWildMax.Value < udWildMin.Value) udWildMax.Value = udWildMin.Value;
            udWildMax.Minimum = udWildMin.Value;
            RefreshWildSummary();

        }

        private void lvwTribes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTribeCopyCommand.Enabled = lvwTribes.SelectedItems.Count > 0 || !cboConsoleCommandsPlayer.Text.Contains("<");
            btnRconCommandTribes.Enabled = lvwTribes.SelectedItems.Count > 0 || !cboConsoleCommandsPlayer.Text.Contains("<");

            DrawMap(0, 0);

        }

        private void btnTribeLog_Click(object sender, EventArgs e)
        {
            if (cm == null) return;
            if (lvwTribes.SelectedItems.Count == 0) return;
            ContentTribe selectedTribe = (ContentTribe)lvwTribes.SelectedItems[0].Tag;

            var tribe = cm.GetTribes(selectedTribe.TribeId).FirstOrDefault<ContentTribe>();
            if (tribe != null)
            {
                frmTribeLog logViewer = new frmTribeLog(tribe);
                logViewer.Owner = this;
                logViewer.ShowDialog();

            }
        }

        private void lvwTribes_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwTribes.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_Tribes == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_Tribes)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_Tribes.Text.StartsWith("> "))
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
                SortingColumn_Tribes.Text = SortingColumn_Tribes.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_Tribes = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_Tribes.Text = "> " + SortingColumn_Tribes.Text;
            }
            else
            {
                SortingColumn_Tribes.Text = "< " + SortingColumn_Tribes.Text;
            }

            // Create a comparer.
            lvwTribes.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwTribes.Sort();
        }

        private void chkTribePlayers_CheckedChanged(object sender, EventArgs e)
        {
            if (cm == null) return;

            if (tabFeatures.SelectedTab.Name == "tpgTribes")
            {

                DrawMap(0, 0);
            }
        }

        private void chkTribeTames_CheckedChanged(object sender, EventArgs e)
        {
            if (cm == null) return;

            if (tabFeatures.SelectedTab.Name == "tpgTribes")
            {

                DrawMap(0, 0);
            }
        }

        private void chkTribeStructures_CheckedChanged(object sender, EventArgs e)
        {
            if (cm == null) return;

            if (tabFeatures.SelectedTab.Name == "tpgTribes")
            {

                DrawMap(0, 0);
            }
        }

        private void btnTribeCopyCommand_Click(object sender, EventArgs e)
        {
            string commandText = GetTribeCommandText();
            if (commandText.Length > 0)
            {
                try
                {
                    Clipboard.Clear();
                    Clipboard.SetText(commandText);

                    lblStatus.Text = $"Command copied:  {commandText}";
                    lblStatus.Refresh();
                }
                catch
                {

                    lblStatus.Text = "Failed to copy command.  Please try again.";
                    lblStatus.Refresh();
                }

            }
            else
            {
                lblStatus.Text = "Unable to parse selected copy command.";
                lblStatus.Refresh();
            }
        }


        private string GetTribeCommandText()
        {

            if (cboConsoleCommandsTribe.SelectedItem == null) return string.Empty;
            RCONCommand command = cboConsoleCommandsTribe.SelectedItem as RCONCommand;

            List<string> allCommands = new List<string>();
            string commandTemplate = command.GetTemplate();

            if (command.UserInputs.Count > 0)
            {
                foreach (var inputRequest in command.UserInputs)
                {
                    using (frmCommandInput inputForm = new frmCommandInput(inputRequest.Key))
                    {
                        inputForm.Owner = this;
                        if (inputForm.ShowDialog() == DialogResult.OK)
                        {
                            commandTemplate = commandTemplate.Replace($"<{inputRequest.Key}>", $"{inputForm.EnteredValue}");
                        }
                        else
                        {
                            //user cancelled, exit command builder
                            return string.Empty;
                        }
                    }
                }
            }

            if (command.Parameters.Count == 0 || lvwTribes.SelectedItems.Count == 0)
            {
                allCommands.Add(commandTemplate);
            }

            if (commandTemplate.Contains("<FileCsvList>"))
            {
                string commandList = commandTemplate;
                string fileList = "";

                foreach (ListViewItem selectedItem in lvwTribes.SelectedItems)
                {
                    ContentTribe selectedTribe = (ContentTribe)selectedItem.Tag;
                    if (fileList.Length > 0)
                    {
                        fileList = fileList + " ";
                    }
                    fileList = fileList + selectedTribe.TribeId.ToString() + ".arktribe";
                }

                commandList = commandList.Replace("<FileCsvList>", fileList);
                allCommands.Add(commandList);

                return string.Join('|', allCommands);
            }


            if (command.Parameters.Count > 0 && lvwTribes.SelectedItems.Count > 0)
            {
                foreach (var defaultParam in command.Parameters.Where(p => !string.IsNullOrEmpty(p.Default)))
                {
                    commandTemplate = commandTemplate.Replace($"<{defaultParam.Key}>", $"{defaultParam.Default}");
                }

                foreach (ListViewItem selectedItem in lvwTribes.SelectedItems)
                {
                    ContentTribe selectedTribe = (ContentTribe)selectedItem.Tag;

                    string commandText = commandTemplate;
                    commandText = commandText.Replace("<TribeID>", selectedTribe.TribeId.ToString("f0"));
                    commandText = commandText.Replace("<TribeName>", selectedTribe.TribeName);

                    switch (Program.ProgramConfig.CommandPrefix)
                    {
                        case 1:
                            commandText = $"admincheat {commandText}";

                            break;
                        case 2:
                            commandText = $"cheat {commandText}";
                            break;
                    }

                    commandText = commandText.Trim();

                    if (!allCommands.Contains(commandText)) allCommands.Add(commandText);
                }
            }


            return string.Join('|', allCommands.ToArray());
        }

        private void lvwTribes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mnuContext_PlayerId.Visible = false;
                mnuContext_ProfileFilename.Visible = false;
                mnuContext_SteamId.Visible = false;
                mnuContext_TribeId.Visible = true;
                mnuContext_Structures.Visible = true;
                mnuContext_Tames.Visible = true;
                mnuContext_Players.Visible = true;
                mnuContext_DinoId.Visible = false;

            }
            else
            {
                if (cm == null) return;

                btnTribeLog.Enabled = false;
                btnTribeCopyCommand.Enabled = lvwTribes.SelectedItems.Count > 0;


                if (lvwTribes.SelectedItems.Count != 1) return;

                ContentTribe selectedTribe = (ContentTribe)lvwTribes.SelectedItems[0].Tag;
                btnTribeLog.Enabled = selectedTribe.Logs.Length > 0;


            }
        }

        private void udWildLat_ValueChanged(object sender, EventArgs e)
        {
            RefreshWildSummary();
        }

        private void udWildLon_ValueChanged(object sender, EventArgs e)
        {
            RefreshWildSummary();
        }

        private void udWildRadius_ValueChanged(object sender, EventArgs e)
        {
            RefreshWildSummary();
        }

        private void btnStructureInventory_Click(object sender, EventArgs e)
        {
            if (lvwStructureLocations.SelectedItems.Count == 0) return;


            ContentStructure selectedStructure = (ContentStructure)lvwStructureLocations.SelectedItems[0].Tag;

            frmStructureInventoryViewer inventoryViewer = new frmStructureInventoryViewer(selectedStructure, selectedStructure.Inventory.Items);
            inventoryViewer.Owner = this;
            inventoryViewer.ShowDialog();
        }

        private void mnuContext_ExportData_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "JavaScript Object Notation|*.json|Comma Seperated Values|*.csv";
            saveDialog.Title = "Export Data";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string saveFilename = saveDialog.FileName;

                switch (tabFeatures.SelectedTab.Name)
                {
                    case "tpgWild":

                        switch (saveDialog.FilterIndex)
                        {
                            case 1:
                                if (lvwWildDetail.Items.Count > 0)
                                {
                                    JArray jsonItems = new JArray();

                                    foreach (ListViewItem item in lvwWildDetail.Items)
                                    {
                                        JObject jsonItem = new JObject();

                                        //row > columns 
                                        foreach (ColumnHeader header in lvwWildDetail.Columns)
                                        {

                                            string headerText = header.Text;
                                            headerText = headerText.Replace("< ", "");
                                            headerText = headerText.Replace("> ", "");


                                            if (long.TryParse(item.SubItems[header.Index].Text, out _))
                                            {
                                                if (item.SubItems[header.Index].Text.Contains("."))
                                                {
                                                    decimal.TryParse(item.SubItems[header.Index].Text, out decimal decValue);

                                                    jsonItem.Add(new JProperty(headerText, decValue));
                                                }
                                                else
                                                {
                                                    long.TryParse(item.SubItems[header.Index].Text, out long intValue);

                                                    jsonItem.Add(new JProperty(headerText, intValue));
                                                }
                                            }
                                            else
                                            {
                                                jsonItem.Add(new JProperty(headerText, item.SubItems[header.Index].Text));
                                            }

                                        }

                                        jsonItems.Add(jsonItem);

                                    }
                                    File.WriteAllText(saveDialog.FileName, jsonItems.ToString());

                                    MessageBox.Show("Export complete.", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No data to export.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                //JSON
                                break;

                            case 2:
                                //CSV
                                if (lvwWildDetail.Items.Count > 0)
                                {
                                    StringBuilder csvBuilder = new StringBuilder();
                                    for (int colIndex = 0; colIndex < lvwWildDetail.Columns.Count; colIndex++)
                                    {

                                        ColumnHeader header = lvwWildDetail.Columns[colIndex];
                                        string headerText = header.Text;
                                        headerText = headerText.Replace("< ", "");
                                        headerText = headerText.Replace("> ", "");

                                        csvBuilder.Append("\"" + headerText + "\"");
                                        if (colIndex < lvwWildDetail.Columns.Count - 1)
                                        {
                                            csvBuilder.Append(",");
                                        }

                                    }
                                    csvBuilder.Append("\n");

                                    foreach (ListViewItem item in lvwWildDetail.Items)
                                    {
                                        //rows
                                        for (int colIndex = 0; colIndex < lvwWildDetail.Columns.Count; colIndex++)
                                        {

                                            if (double.TryParse(item.SubItems[colIndex].Text, out double parsedValue))
                                            {
                                                csvBuilder.Append(System.FormattableString.Invariant($"{parsedValue:0.00}"));
                                            }
                                            else
                                            {
                                                csvBuilder.Append("\"" + item.SubItems[colIndex].Text + "\"");
                                            }

                                            if (colIndex < lvwWildDetail.Columns.Count - 1)
                                            {
                                                csvBuilder.Append(",");
                                            }

                                        }

                                        csvBuilder.Append("\n");
                                    }
                                    File.WriteAllText(saveDialog.FileName, csvBuilder.ToString());

                                    MessageBox.Show("Export complete.", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No data to export.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                        }

                        break;
                    case "tpgTamed":
                        switch (saveDialog.FilterIndex)
                        {
                            case 1:
                                if (lvwTameDetail.Items.Count > 0)
                                {
                                    JArray jsonItems = new JArray();
                                    foreach (ListViewItem item in lvwTameDetail.Items)
                                    {
                                        //row > columns 
                                        JObject jsonField = new JObject();
                                        foreach (ColumnHeader header in lvwTameDetail.Columns)
                                        {

                                            string headerText = header.Text;
                                            headerText = headerText.Replace("< ", "");
                                            headerText = headerText.Replace("> ", "");


                                            if (long.TryParse(item.SubItems[header.Index].Text, out _))
                                            {
                                                if (item.SubItems[header.Index].Text.Contains("."))
                                                {
                                                    decimal.TryParse(item.SubItems[header.Index].Text, out decimal decValue);

                                                    jsonField.Add(new JProperty(headerText, decValue));
                                                }
                                                else
                                                {
                                                    long.TryParse(item.SubItems[header.Index].Text, out long intValue);

                                                    jsonField.Add(new JProperty(headerText, intValue));
                                                }
                                            }
                                            else
                                            {
                                                jsonField.Add(new JProperty(headerText, item.SubItems[header.Index].Text));
                                            }


                                        }
                                        jsonItems.Add(jsonField);

                                    }
                                    File.WriteAllText(saveDialog.FileName, jsonItems.ToString());

                                    MessageBox.Show("Export complete.", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No data to export.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                //JSON
                                break;

                            case 2:
                                //CSV
                                if (lvwTameDetail.Items.Count > 0)
                                {
                                    StringBuilder csvBuilder = new StringBuilder();
                                    for (int colIndex = 0; colIndex < lvwTameDetail.Columns.Count; colIndex++)
                                    {

                                        ColumnHeader header = lvwTameDetail.Columns[colIndex];
                                        string headerText = header.Text;
                                        headerText = headerText.Replace("< ", "");
                                        headerText = headerText.Replace("> ", "");

                                        csvBuilder.Append("\"" + headerText + "\"");
                                        if (colIndex < lvwTameDetail.Columns.Count - 1)
                                        {
                                            csvBuilder.Append(",");
                                        }

                                    }
                                    csvBuilder.Append("\n");

                                    foreach (ListViewItem item in lvwTameDetail.Items)
                                    {
                                        //rows
                                        for (int colIndex = 0; colIndex < lvwTameDetail.Columns.Count; colIndex++)
                                        {

                                            if (double.TryParse(item.SubItems[colIndex].Text, out double parsedValue))
                                            {
                                                csvBuilder.Append(System.FormattableString.Invariant($"{parsedValue:0.00}"));
                                            }
                                            else
                                            {
                                                csvBuilder.Append("\"" + item.SubItems[colIndex].Text + "\"");
                                            }

                                            if (colIndex < lvwTameDetail.Columns.Count - 1)
                                            {
                                                csvBuilder.Append(",");
                                            }

                                        }

                                        csvBuilder.Append("\n");
                                    }
                                    File.WriteAllText(saveDialog.FileName, csvBuilder.ToString());

                                    MessageBox.Show("Export complete.", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No data to export.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                        }

                        break;

                    case "tpgStructures":
                        switch (saveDialog.FilterIndex)
                        {
                            case 1:
                                if (lvwStructureLocations.Items.Count > 0)
                                {
                                    JArray jsonItems = new JArray();
                                    foreach (ListViewItem item in lvwStructureLocations.Items)
                                    {
                                        //row > columns 
                                        JObject jsonField = new JObject();
                                        foreach (ColumnHeader header in lvwStructureLocations.Columns)
                                        {

                                            string headerText = header.Text;
                                            headerText = headerText.Replace("< ", "");
                                            headerText = headerText.Replace("> ", "");



                                            if (double.TryParse(item.SubItems[header.Index].Text, out _))
                                            {
                                                if (item.SubItems[header.Index].Text.Contains("."))
                                                {
                                                    decimal.TryParse(item.SubItems[header.Index].Text, out decimal decValue);

                                                    jsonField.Add(new JProperty(headerText, decValue));
                                                }
                                                else
                                                {
                                                    int.TryParse(item.SubItems[header.Index].Text, out int intValue);

                                                    jsonField.Add(new JProperty(headerText, intValue));
                                                }
                                            }
                                            else
                                            {
                                                jsonField.Add(new JProperty(headerText, item.SubItems[header.Index].Text));
                                            }


                                        }
                                        jsonItems.Add(jsonField);

                                    }
                                    File.WriteAllText(saveDialog.FileName, jsonItems.ToString());

                                    MessageBox.Show("Export complete.", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No data to export.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                //JSON
                                break;

                            case 2:
                                //CSV
                                if (lvwStructureLocations.Items.Count > 0)
                                {
                                    StringBuilder csvBuilder = new StringBuilder();
                                    for (int colIndex = 0; colIndex < lvwStructureLocations.Columns.Count; colIndex++)
                                    {

                                        ColumnHeader header = lvwStructureLocations.Columns[colIndex];
                                        string headerText = header.Text;
                                        headerText = headerText.Replace("< ", "");
                                        headerText = headerText.Replace("> ", "");

                                        csvBuilder.Append("\"" + headerText + "\"");
                                        if (colIndex < lvwStructureLocations.Columns.Count - 1)
                                        {
                                            csvBuilder.Append(",");
                                        }

                                    }
                                    csvBuilder.Append("\n");

                                    foreach (ListViewItem item in lvwStructureLocations.Items)
                                    {
                                        //rows
                                        for (int colIndex = 0; colIndex < lvwStructureLocations.Columns.Count; colIndex++)
                                        {

                                            if (double.TryParse(item.SubItems[colIndex].Text, out double parsedValue))
                                            {
                                                csvBuilder.Append(System.FormattableString.Invariant($"{parsedValue:0.00}"));
                                            }
                                            else
                                            {
                                                csvBuilder.Append("\"" + item.SubItems[colIndex].Text + "\"");
                                            }

                                            if (colIndex < lvwTameDetail.Columns.Count - 1)
                                            {
                                                csvBuilder.Append(",");
                                            }

                                        }

                                        csvBuilder.Append("\n");
                                    }
                                    File.WriteAllText(saveDialog.FileName, csvBuilder.ToString());

                                    MessageBox.Show("Export complete.", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No data to export.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                        }

                        break;
                    case "tpgTribes":
                        switch (saveDialog.FilterIndex)
                        {
                            case 1:
                                if (lvwStructureLocations.Items.Count > 0)
                                {
                                    JArray jsonItems = new JArray();
                                    foreach (ListViewItem item in lvwStructureLocations.Items)
                                    {
                                        //row > columns 
                                        JObject jsonField = new JObject();
                                        foreach (ColumnHeader header in lvwStructureLocations.Columns)
                                        {

                                            string headerText = header.Text;
                                            headerText = headerText.Replace("< ", "");
                                            headerText = headerText.Replace("> ", "");



                                            if (double.TryParse(item.SubItems[header.Index].Text, out _))
                                            {
                                                if (item.SubItems[header.Index].Text.Contains("."))
                                                {
                                                    decimal.TryParse(item.SubItems[header.Index].Text, out decimal decValue);

                                                    jsonField.Add(new JProperty(headerText, decValue));
                                                }
                                                else
                                                {
                                                    int.TryParse(item.SubItems[header.Index].Text, out int intValue);

                                                    jsonField.Add(new JProperty(headerText, intValue));
                                                }
                                            }
                                            else
                                            {
                                                jsonField.Add(new JProperty(headerText, item.SubItems[header.Index].Text));
                                            }


                                        }
                                        jsonItems.Add(jsonField);

                                    }
                                    File.WriteAllText(saveDialog.FileName, jsonItems.ToString());

                                    MessageBox.Show("Export complete.", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No data to export.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                //JSON
                                break;

                            case 2:
                                //CSV
                                if (lvwTribes.Items.Count > 0)
                                {
                                    StringBuilder csvBuilder = new StringBuilder();
                                    for (int colIndex = 0; colIndex < lvwTribes.Columns.Count; colIndex++)
                                    {

                                        ColumnHeader header = lvwTribes.Columns[colIndex];
                                        string headerText = header.Text;
                                        headerText = headerText.Replace("< ", "");
                                        headerText = headerText.Replace("> ", "");

                                        csvBuilder.Append("\"" + headerText + "\"");
                                        if (colIndex < lvwTribes.Columns.Count - 1)
                                        {
                                            csvBuilder.Append(",");
                                        }

                                    }
                                    csvBuilder.Append("\n");

                                    foreach (ListViewItem item in lvwTribes.Items)
                                    {
                                        //rows
                                        for (int colIndex = 0; colIndex < lvwTribes.Columns.Count; colIndex++)
                                        {

                                            if (double.TryParse(item.SubItems[colIndex].Text, out double parsedValue))
                                            {
                                                csvBuilder.Append(System.FormattableString.Invariant($"{parsedValue:0.00}"));
                                            }
                                            else
                                            {
                                                csvBuilder.Append("\"" + item.SubItems[colIndex].Text + "\"");
                                            }

                                            if (colIndex < lvwTameDetail.Columns.Count - 1)
                                            {
                                                csvBuilder.Append(",");
                                            }

                                        }

                                        csvBuilder.Append("\n");
                                    }
                                    File.WriteAllText(saveDialog.FileName, csvBuilder.ToString());

                                    MessageBox.Show("Export complete.", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No data to export.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                        }

                        break;

                    case "tpgPlayers":
                        switch (saveDialog.FilterIndex)
                        {
                            case 1:
                                if (lvwPlayers.Items.Count > 0)
                                {
                                    JArray jsonItems = new JArray();
                                    foreach (ListViewItem item in lvwPlayers.Items)
                                    {
                                        //row > columns 
                                        JObject jsonField = new JObject();
                                        foreach (ColumnHeader header in lvwPlayers.Columns)
                                        {

                                            string headerText = header.Text;
                                            headerText = headerText.Replace("< ", "");
                                            headerText = headerText.Replace("> ", "");



                                            if (double.TryParse(item.SubItems[header.Index].Text, out _))
                                            {
                                                if (item.SubItems[header.Index].Text.Contains("."))
                                                {
                                                    decimal.TryParse(item.SubItems[header.Index].Text, out decimal decValue);

                                                    jsonField.Add(new JProperty(headerText, decValue));
                                                }
                                                else
                                                {
                                                    long.TryParse(item.SubItems[header.Index].Text, out long intValue);

                                                    jsonField.Add(new JProperty(headerText, intValue));
                                                }
                                            }
                                            else
                                            {
                                                jsonField.Add(new JProperty(headerText, item.SubItems[header.Index].Text));
                                            }


                                        }
                                        jsonItems.Add(jsonField);

                                    }
                                    File.WriteAllText(saveDialog.FileName, jsonItems.ToString());

                                    MessageBox.Show("Export complete.", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No data to export.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                //JSON
                                break;

                            case 2:
                                //CSV
                                if (lvwTribes.Items.Count > 0)
                                {
                                    StringBuilder csvBuilder = new StringBuilder();
                                    for (int colIndex = 0; colIndex < lvwPlayers.Columns.Count; colIndex++)
                                    {

                                        ColumnHeader header = lvwPlayers.Columns[colIndex];
                                        string headerText = header.Text;
                                        headerText = headerText.Replace("< ", "");
                                        headerText = headerText.Replace("> ", "");

                                        csvBuilder.Append("\"" + headerText + "\"");
                                        if (colIndex < lvwPlayers.Columns.Count - 1)
                                        {
                                            csvBuilder.Append(",");
                                        }

                                    }
                                    csvBuilder.Append("\n");

                                    foreach (ListViewItem item in lvwPlayers.Items)
                                    {
                                        //rows
                                        for (int colIndex = 0; colIndex < lvwPlayers.Columns.Count; colIndex++)
                                        {

                                            if (double.TryParse(item.SubItems[colIndex].Text, out double parsedValue))
                                            {
                                                csvBuilder.Append(System.FormattableString.Invariant($"{parsedValue:0.00}"));
                                            }
                                            else
                                            {
                                                csvBuilder.Append("\"" + item.SubItems[colIndex].Text + "\"");
                                            }

                                            if (colIndex < lvwTameDetail.Columns.Count - 1)
                                            {
                                                csvBuilder.Append(",");
                                            }

                                        }

                                        csvBuilder.Append("\n");
                                    }
                                    File.WriteAllText(saveDialog.FileName, csvBuilder.ToString());

                                    MessageBox.Show("Export complete.", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No data to export.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                        }

                        break;
                    case "tpdDroppedItems":
                        switch (saveDialog.FilterIndex)
                        {
                            case 1:
                                if (lvwDroppedItems.Items.Count > 0)
                                {
                                    JArray jsonItems = new JArray();
                                    foreach (ListViewItem item in lvwDroppedItems.Items)
                                    {
                                        //row > columns 
                                        JObject jsonField = new JObject();
                                        foreach (ColumnHeader header in lvwDroppedItems.Columns)
                                        {

                                            string headerText = header.Text;
                                            headerText = headerText.Replace("< ", "");
                                            headerText = headerText.Replace("> ", "");



                                            if (double.TryParse(item.SubItems[header.Index].Text, out _))
                                            {
                                                if (item.SubItems[header.Index].Text.Contains("."))
                                                {
                                                    decimal.TryParse(item.SubItems[header.Index].Text, out decimal decValue);

                                                    jsonField.Add(new JProperty(headerText, decValue));
                                                }
                                                else
                                                {
                                                    int.TryParse(item.SubItems[header.Index].Text, out int intValue);

                                                    jsonField.Add(new JProperty(headerText, intValue));
                                                }
                                            }
                                            else
                                            {
                                                jsonField.Add(new JProperty(headerText, item.SubItems[header.Index].Text));
                                            }


                                        }
                                        jsonItems.Add(jsonField);

                                    }
                                    File.WriteAllText(saveDialog.FileName, jsonItems.ToString());

                                    MessageBox.Show("Export complete.", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No data to export.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                //JSON
                                break;

                            case 2:
                                //CSV
                                if (lvwDroppedItems.Items.Count > 0)
                                {
                                    StringBuilder csvBuilder = new StringBuilder();
                                    for (int colIndex = 0; colIndex < lvwDroppedItems.Columns.Count; colIndex++)
                                    {

                                        ColumnHeader header = lvwDroppedItems.Columns[colIndex];
                                        string headerText = header.Text;
                                        headerText = headerText.Replace("< ", "");
                                        headerText = headerText.Replace("> ", "");

                                        csvBuilder.Append("\"" + headerText + "\"");
                                        if (colIndex < lvwDroppedItems.Columns.Count - 1)
                                        {
                                            csvBuilder.Append(",");
                                        }

                                    }
                                    csvBuilder.Append("\n");

                                    foreach (ListViewItem item in lvwDroppedItems.Items)
                                    {
                                        //rows
                                        for (int colIndex = 0; colIndex < lvwDroppedItems.Columns.Count; colIndex++)
                                        {

                                            if (double.TryParse(item.SubItems[colIndex].Text, out double parsedValue))
                                            {
                                                csvBuilder.Append(System.FormattableString.Invariant($"{parsedValue:0.00}"));
                                            }
                                            else
                                            {
                                                csvBuilder.Append("\"" + item.SubItems[colIndex].Text + "\"");
                                            }

                                            if (colIndex < lvwTameDetail.Columns.Count - 1)
                                            {
                                                csvBuilder.Append(",");
                                            }

                                        }

                                        csvBuilder.Append("\n");
                                    }
                                    File.WriteAllText(saveDialog.FileName, csvBuilder.ToString());

                                    MessageBox.Show("Export complete.", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No data to export.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                        }

                        break;
                }

            }


        }

        private void lvwWildDetail_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mnuContext_PlayerId.Visible = false;
                mnuContext_ProfileFilename.Visible = false;
                mnuContext_SteamId.Visible = false;
                mnuContext_TribeId.Visible = false;
                mnuContext_Structures.Visible = false;
                mnuContext_Tames.Visible = false;
                mnuContext_Players.Visible = false;
                mnuContext_DinoId.Visible = true;

            }
        }

        private void lvwTameDetail_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mnuContext_PlayerId.Visible = false;
                mnuContext_ProfileFilename.Visible = false;
                mnuContext_SteamId.Visible = false;
                mnuContext_TribeId.Visible = true;
                mnuContext_Structures.Visible = true;
                mnuContext_Tames.Visible = false;
                mnuContext_Players.Visible = true;
                mnuContext_DinoId.Visible = true;

            }
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            if (lvwPlayers.SelectedItems.Count == 0) return;

            ContentPlayer selectedPlayer = (ContentPlayer)lvwPlayers.SelectedItems[0].Tag;

            bool shouldRemove = true;

            if (selectedPlayer.LastActiveDateTime.HasValue & !selectedPlayer.LastActiveDateTime.Equals(new DateTime()))
            {
                if (((TimeSpan)(DateTime.Today - selectedPlayer.LastActiveDateTime)).TotalDays <= 14)
                {
                    if (MessageBox.Show("The selected player has been active in the last 14 days.\n\nAre you sure you want to remove their .arkprofile?", "Remove Player?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        shouldRemove = false;
                    }
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to remove the selected player profile?", "Remove Player Profile?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        shouldRemove = false;
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to remove the selected player?", "Remove Player?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    shouldRemove = false;
                }
            }


            //remove local
            if (shouldRemove)
            {
                string profilePathLocal = Path.GetDirectoryName(Program.ProgramConfig.SelectedFile);

                if (Program.ProgramConfig.Mode == ViewerModes.Mode_Ftp)
                {
                    profilePathLocal = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), ARKViewer.Program.ProgramConfig.SelectedServer);

                    //also remove from server if it still exists
                    DeletePlayerFtp(selectedPlayer);
                }

                string profileFileName = Directory.GetFiles(profilePathLocal, $"{selectedPlayer.NetworkId}.arkprofile").FirstOrDefault();
                if (profileFileName != null)
                {
                    try
                    {
                        File.Delete(profileFileName);
                        if (MessageBox.Show("Player profile data removed.\n\nPress OK to reload save data.", "Player Removed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            LoadPlayerDetail();
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Failed to remove player profile data.", "Removal Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }

        }

        private void btnDropInventory_Click(object sender, EventArgs e)
        {
            if (lvwDroppedItems.SelectedItems.Count == 0) return;
            switch (lvwDroppedItems.SelectedItems[0].Tag)
            {
                case ContentDroppedItem droppedItem:
                    if (droppedItem.IsDeathCache)
                    {
                        frmDeathCacheViewer inventoryView = new frmDeathCacheViewer(droppedItem, droppedItem.Inventory.Items);
                        inventoryView.Owner = this;
                        inventoryView.ShowDialog();
                    }

                    break;
                default:

                    break;
            }
        }

        private void lvwDroppedItems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwDroppedItems.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_Drops == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_Drops)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_Drops.Text.StartsWith("> "))
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
                SortingColumn_Drops.Text = SortingColumn_Drops.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_Drops = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_Drops.Text = "> " + SortingColumn_Drops.Text;
            }
            else
            {
                SortingColumn_Drops.Text = "< " + SortingColumn_Drops.Text;
            }

            // Create a comparer.
            lvwDroppedItems.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwDroppedItems.Sort();
        }

        private void btnViewMap_Click(object sender, EventArgs e)
        {
            ShowMapViewer();
        }

        private void frmViewer_Enter(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void frmViewer_LocationChanged(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void udWildMin_Enter(object sender, EventArgs e)
        {
            udWildMin.Select(0, udWildMin.Value.ToString().Length);
        }

        private void udWildMax_Enter(object sender, EventArgs e)
        {
            udWildMax.Select(0, udWildMax.Value.ToString().Length);
        }

        private void udWildLat_Enter(object sender, EventArgs e)
        {
            udWildLat.Select(0, udWildLat.Value.ToString().Length);
        }

        private void udWildLon_Enter(object sender, EventArgs e)
        {
            udWildLon.Select(0, udWildLon.Value.ToString().Length);
        }

        private void udWildRadius_Enter(object sender, EventArgs e)
        {
            udWildRadius.Select(0, udWildRadius.Value.ToString().Length);
        }

        private void udWildRadius_MouseClick(object sender, MouseEventArgs e)
        {
            udWildRadius.Select(0, udWildRadius.Value.ToString().Length);
        }

        private void udWildMin_MouseClick(object sender, MouseEventArgs e)
        {
            udWildMin.Select(0, udWildMin.Value.ToString().Length);
        }

        private void udWildMax_MouseClick(object sender, MouseEventArgs e)
        {
            udWildMax.Select(0, udWildMax.Value.ToString().Length);
        }

        private void udWildLat_MouseClick(object sender, MouseEventArgs e)
        {
            udWildLat.Select(0, udWildLat.Value.ToString().Length);
        }

        private void udWildLon_MouseClick(object sender, MouseEventArgs e)
        {
            udWildLon.Select(0, udWildLon.Value.ToString().Length);
        }

        private void cboWildResource_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboWildClass.Items.Count > 1 && cboWildResource.SelectedIndex > 0)
            {
                if (cboWildClass.SelectedIndex != 1)
                {
                    cboWildClass.SelectedIndex = 1;
                }
                else
                {
                    LoadWildDetail();
                }
            }
            else
            {
                LoadWildDetail();
            }
        }

        private void cboItemListTribe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshItemListPlayers();
            LoadItemListDetail();
        }

        private void RefreshItemListPlayers()
        {

            if (cm == null) return;
            if (cboItemListTribe.SelectedItem == null) return;

            ASVComboValue comboValue = (ASVComboValue)cboItemListTribe.SelectedItem;
            int.TryParse(comboValue.Key, out int selectedTribeId);


            long selectedPlayerId = 0;
            if (cboItemListPlayers.SelectedIndex > 0)
            {
                comboValue = (ASVComboValue)cboItemListPlayers.SelectedItem;
                long.TryParse(comboValue.Key, out selectedPlayerId);
            }

            cboItemListPlayers.Items.Clear();
            cboItemListPlayers.Items.Add(new ASVComboValue("0", "[All Players]"));

            List<ASVComboValue> newItems = new List<ASVComboValue>();

            if (selectedTribeId == -1) selectedTribeId = 0;
            var tribes = cm.GetTribes(selectedTribeId);
            foreach (var tribe in tribes)
            {

                foreach (var player in tribe.Players)
                {
                    bool addItem = true;

                    if (Program.ProgramConfig.HideNoBody && addItem)
                    {
                        addItem = !(player.Latitude.GetValueOrDefault(0) == 0 && player.Longitude.GetValueOrDefault(0) == 0);
                    }

                    if (addItem)
                    {
                        float fromLat = (float)udLatTamed.Value;
                        float fromLon = (float)udLonTamed.Value;
                        float fromRadius = (float)udRadiusTamed.Value;


                        addItem = tribe.Structures.LongCount(w => (
                                        (Math.Abs(w.Latitude.GetValueOrDefault(0) - fromLat) <= fromRadius)
                                        && (Math.Abs(w.Longitude.GetValueOrDefault(0) - fromLon) <= fromRadius)
                                    )) > 0;
                    }


                    if (addItem)
                    {

                        ASVComboValue valuePair = new ASVComboValue(player.Id.ToString(), player.CharacterName);
                        newItems.Add(valuePair);

                    }
                }

            }

            var selectedPlayerIndex = 0;

            if (newItems.Count > 0)
            {


                cboItemListPlayers.BeginUpdate();
                foreach (var newItem in newItems.OrderBy(o => o.Value))
                {
                    var newIndex = cboItemListPlayers.Items.Add(newItem);
                    if (selectedPlayerId != 0)
                    {
                        long.TryParse(newItem.Key, out long listPlayerId);
                        if (selectedPlayerId.Equals(listPlayerId))
                        {
                            selectedPlayerIndex = newIndex;
                        }
                    }

                }
                cboItemListPlayers.EndUpdate();

            }

            cboItemListPlayers.SelectedIndex = selectedPlayerIndex;


        }

        private void cboItemListItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItemListDetail();
        }

        private void lvwItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCopyItemListCommand.Enabled = !cboConsoleCommandSearch.Text.Contains("<") || lvwItemList.SelectedItems.Count > 0;

            if (lvwItemList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwItemList.SelectedItems[0];

                float selectedX = 0;
                float selectedY = 0;

                ASVFoundItem foundItem = (ASVFoundItem)selectedItem.Tag;

                selectedX = (float)foundItem.Longitude;
                selectedY = (float)foundItem.Latitude;

                DrawMap(selectedX, selectedY);
            }
        }

        private void btnItemListCommand_Click(object sender, EventArgs e)
        {
            string commandText = GetItemSearchCommandText();
            if (commandText.Length > 0)
            {
                try
                {
                    Clipboard.Clear();
                    Clipboard.SetText(commandText);

                    lblStatus.Text = $"Command copied:  {commandText}";
                    lblStatus.Refresh();
                }
                catch
                {

                    lblStatus.Text = "Failed to copy command.  Please try again.";
                    lblStatus.Refresh();
                }
            }
            else
            {
                lblStatus.Text = "Unable to parse selected copy command.";
                lblStatus.Refresh();
            }


        }

        private void cboSelectedMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;

            if (cboSelectedMap.SelectedItem == null) return;

            cboSelectedMap.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            switch (cboSelectedMap.SelectedItem)
            {
                case ASVComboValue comboValue:
                    Program.ProgramConfig.SelectedFile = comboValue.Key;
                    if (Program.ProgramConfig.Mode == ViewerModes.Mode_Ftp)
                    {
                        Program.ProgramConfig.SelectedServer = comboValue.Value;
                    }


                    break;
                case OfflineFileConfiguration fileConfig:
                    Program.ProgramConfig.SelectedFile = fileConfig.Filename;
                    Program.ProgramConfig.ClusterFolder = fileConfig.ClusterFolder;

                    break;
                default:

                    break;
            }


            RefreshMap();

            cboSelectedMap.Enabled = true;
            this.Cursor = Cursors.Default;

        }




        private void PopulateSinglePlayerGames()
        {

            //get registry path for steam apps 
            cboSelectedMap.Items.Clear();
            cboSelectedMap.Sorted = true;
            string directoryCheck = Program.GetSteamFolder();

            if (Directory.Exists(directoryCheck))
            {

                var saveFiles = Directory.GetFiles(directoryCheck, "*.ark", SearchOption.AllDirectories);
                foreach (string saveFilename in saveFiles)
                {
                    string fileName = Path.GetFileName(saveFilename);
                    if (Program.MapPack.SupportedMaps.Any(m => m.Filename.ToLower() == fileName.ToLower()))
                    {
                        ContentMap selectedMap = Program.MapPack.SupportedMaps.First(m => m.Filename.ToLower() == fileName.ToLower());

                        string knownMapName = selectedMap.MapName;
                        if (knownMapName.Length > 0)
                        {
                            ASVComboValue comboValue = new ASVComboValue(saveFilename, knownMapName);
                            int newIndex = cboSelectedMap.Items.Add(comboValue);

                        }

                    }

                }

            }

            for (int x = 0; x < cboSelectedMap.Items.Count; x++)
            {
                ASVComboValue itemValue = (ASVComboValue)cboSelectedMap.Items[x];
                if (itemValue.Key == Program.ProgramConfig.SelectedFile)
                {
                    cboSelectedMap.SelectedIndex = x;
                    break;
                }
            }

        }





        /**** FTP Servers ****/
        public string Download()
        {
            Program.LogWriter.Trace("BEGIN Download()");


            ServerConfiguration selectedServer = ARKViewer.Program.ProgramConfig.ServerList.Where(s => s.Name == ARKViewer.Program.ProgramConfig.SelectedServer).FirstOrDefault();
            if (selectedServer == null) return "";

            switch (selectedServer.Mode)
            {
                case 0:
                    //ftp
                    return DownloadFtp();

                case 1:
                    //sftp
                    return DownloadSFtp();

            }

            Program.LogWriter.Trace("END Download()");
            return "";
        }

        private string DownloadSFtp()
        {
            Program.LogWriter.Trace("BEGIN DownloadSFtp()");

            string downloadFilename = "";
            ServerConfiguration selectedServer = ARKViewer.Program.ProgramConfig.ServerList.Where(s => s.Name == ARKViewer.Program.ProgramConfig.SelectedServer).FirstOrDefault();
            if (selectedServer == null)
            {
                Program.LogWriter.Debug("No sFTP server selected in config.json");
                return downloadFilename;
            }

            string ftpServerUrl = $"{selectedServer.Address}";
            string serverUsername = selectedServer.Username;
            string serverPassword = selectedServer.Password;
            string downloadPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), selectedServer.Name);
            if (!Directory.Exists(downloadPath))
            {
                Directory.CreateDirectory(downloadPath);
            }

            if (Program.ProgramConfig.FtpDownloadMode == 1)
            {
                Program.LogWriter.Info($"Removing local files for a clean download.");

                //clear any previous .arktribe, .arkprofile files
                var profileFiles = Directory.GetFiles(downloadPath, "*.arkprofile");
                foreach (var profileFile in profileFiles)
                {
                    Program.LogWriter.Debug($"Removing local file for a clean download: {profileFile}");
                    File.Delete(profileFile);
                }

                var tribeFiles = Directory.GetFiles(downloadPath, "*.arktribe");
                foreach (var tribeFile in tribeFiles)
                {
                    Program.LogWriter.Debug($"Removing local file for a clean download: {tribeFile}");
                    File.Delete(tribeFile);
                }

            }

            string mapFilename = ARKViewer.Program.ProgramConfig.SelectedFile;

            try
            {
                Program.LogWriter.Info($"Attempting to connect to sftp server: {selectedServer.Address}");

                using (var sftp = new SftpClient(selectedServer.Address, selectedServer.Port, selectedServer.Username, selectedServer.Password))
                {
                    sftp.ErrorOccurred += Sftp_ErrorOccurred;
                    sftp.Connect();


                    Program.LogWriter.Debug($"Retrieving FTP server files in: {selectedServer.SaveGamePath}");
                    var files = sftp.ListDirectory(selectedServer.SaveGamePath);

                    Program.LogWriter.Debug($"{files.ToList().Count} entries found.");

                    foreach (var serverFile in files)
                    {
                        Program.LogWriter.Debug($"Found: {serverFile}");

                        if (Path.GetExtension(serverFile.Name).StartsWith(".ark"))
                        {

                            string localFilename = Path.Combine(downloadPath, serverFile.Name);


                            if (File.Exists(localFilename) && Program.ProgramConfig.FtpDownloadMode == 1)
                            {
                                Program.LogWriter.Debug($"Removing local file for a clean download: {localFilename}");
                                File.Delete(localFilename);
                            }

                            bool shouldDownload = true;

                            if (serverFile.Name.EndsWith(".ark"))
                            {
                                downloadFilename = localFilename;

                                if (!selectedServer.Map.ToLower().StartsWith(serverFile.Name.ToLower()))
                                {
                                    shouldDownload = false;
                                }
                                else
                                {
                                    if (File.Exists(localFilename) && Program.ProgramConfig.FtpDownloadMode == 0 && File.GetLastWriteTimeUtc(localFilename) >= serverFile.LastAccessTimeUtc)
                                    {
                                        shouldDownload = false;
                                    }
                                }
                            }
                            else
                            {
                                if (File.Exists(localFilename) && Program.ProgramConfig.FtpDownloadMode == 0 && File.GetLastWriteTimeUtc(localFilename) >= serverFile.LastAccessTimeUtc)
                                {
                                    shouldDownload = false;
                                }
                            }

                            if (shouldDownload)
                            {
                                string serverFilename = serverFile.FullName;

                                if (serverFile.Name.EndsWith(".ark"))
                                {
                                    //check for newer .tmp
                                    var tmpFilename = files.FirstOrDefault(x => x.Name == serverFile.Name.Replace(".ark", ".tmp"));
                                    if (tmpFilename != null)
                                    {
                                        if (tmpFilename.LastWriteTimeUtc > serverFile.LastWriteTimeUtc)
                                        {
                                            //tmp is newer, use that instead
                                            serverFilename = tmpFilename.FullName;
                                        }
                                    }

                                }

                                Program.LogWriter.Debug($"Downloading: {serverFilename} as {localFilename}");

                                //delete local if any
                                if (File.Exists(localFilename))
                                {
                                    File.Delete(localFilename);
                                }

                                using (FileStream outputStream = new FileStream(localFilename, FileMode.CreateNew))
                                {
                                    sftp.DownloadFile(serverFilename, outputStream);
                                    outputStream.Flush();
                                }
                                DateTime saveTime = serverFile.LastWriteTimeUtc;
                                File.SetLastWriteTimeUtc(localFilename, saveTime);

                            }
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                Program.LogWriter.Error(ex, "Unable to download latest game data");
                MessageBox.Show($"Unable to download latest game data.\n\n{ex.Message.ToString()}", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            Program.LogWriter.Trace("BEGIN DownloadSFtp()");
            return downloadFilename;
        }

        private void Sftp_ErrorOccurred(object sender, Renci.SshNet.Common.ExceptionEventArgs e)
        {

        }

        private string DownloadFtp()
        {
            Program.LogWriter.Trace("BEGIN DownloadFtp()");
            string downloadedFilename = "";
            ServerConfiguration selectedServer = ARKViewer.Program.ProgramConfig.ServerList.Where(s => s.Name == ARKViewer.Program.ProgramConfig.SelectedServer).FirstOrDefault();
            if (selectedServer == null)
            {
                Program.LogWriter.Debug("No FTP server selected in config.json");
                return downloadedFilename;
            }

            selectedServer.Address = selectedServer.Address.Trim();
            selectedServer.SaveGamePath = selectedServer.SaveGamePath.Trim();
            if (!selectedServer.SaveGamePath.EndsWith("/"))
            {
                selectedServer.SaveGamePath = selectedServer.SaveGamePath.Trim() + "/";
            }

            Program.LogWriter.Info($"Attempting to connect to ftp server: {selectedServer.Address}");
            using (FtpClient ftpClient = new FtpClient(selectedServer.Address))
            {


                string downloadPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), selectedServer.Name);
                if (!Directory.Exists(downloadPath))
                {
                    Directory.CreateDirectory(downloadPath);
                }


                // try remove existing local copies                

                if (Program.ProgramConfig.FtpDownloadMode == 1)
                {
                    Program.LogWriter.Info($"Removing local files for a clean download.");
                    //clean download
                    // ... arkprofile(s)
                    var profileFiles = Directory.EnumerateFiles(downloadPath, "*.arkprofile");
                    foreach (var profileFilename in profileFiles)
                    {
                        try
                        {
                            Program.LogWriter.Debug($"Removing local file for a clean download: {profileFilename}");
                            File.Delete(profileFilename);
                        }
                        catch
                        {
                            Program.LogWriter.Debug($"Failed to remove local file for a clean download: {profileFilename}");
                        }
                        finally
                        {
                            //ignore, issue deleting the file but not concerned.
                        }
                    }

                    // ... arktribe(s)
                    var tribeFiles = Directory.EnumerateFiles(downloadPath, "*.arktribe");
                    foreach (var tribeFilename in tribeFiles)
                    {
                        try
                        {
                            Program.LogWriter.Debug($"Removing local file for a clean download: {tribeFilename}");

                            File.Delete(tribeFilename);
                        }
                        catch
                        {
                            Program.LogWriter.Debug($"Failed to remove local file for a clean download: {tribeFilename}");
                        }

                        finally
                        {
                            //ignore, issue deleting the file but not concerned.
                        }
                    }
                }

                //try catch

                try
                {

                    ftpClient.Credentials.UserName = selectedServer.Username;
                    ftpClient.Credentials.Password = selectedServer.Password;
                    ftpClient.Port = selectedServer.Port;
                    ftpClient.ValidateCertificate += FtpClient_ValidateCertificate; ;

                    try
                    {
                        Program.LogWriter.Debug($"Attempting secure connection (explicit)");
                        ftpClient.AutoConnect();


                        Program.LogWriter.Debug($"Retrieving FTP server files in: {selectedServer.SaveGamePath}");
                        var serverFiles = ftpClient.GetListing(selectedServer.SaveGamePath);
                        Program.LogWriter.Debug($"{serverFiles.Length - 1} entries found.");

                        string localFilename = "";

                        //get correct casing for the selected map file
                        var serverSaveFile = serverFiles.Where(f => f.Name.ToLower() == selectedServer.Map.ToLower()).FirstOrDefault();
                        if (serverSaveFile != null)
                        {
                            Program.LogWriter.Debug($"Found: {serverSaveFile}");

                            string serverGameFilename = serverSaveFile.Name;

                            //check for .tmp file
                            var serverTempFile = serverFiles.Where(f => f.Name.ToLower() == selectedServer.Map.ToLower().Replace(".ark", ".tmp")).FirstOrDefault();
                            if (serverTempFile != null)
                            {
                                if (serverTempFile.Modified.ToUniversalTime() > serverSaveFile.Modified.ToUniversalTime())
                                {
                                    //tmp is newer, use that instead
                                    serverGameFilename = serverTempFile.Name;
                                }
                            }


                            localFilename = Path.Combine(downloadPath, serverGameFilename);
                            downloadedFilename = localFilename;
                            bool shouldDownload = true;


                            if (File.Exists(localFilename) && serverSaveFile.Modified.ToUniversalTime() <= File.GetLastWriteTimeUtc(localFilename))
                            {
                                if (Program.ProgramConfig.FtpDownloadMode == 0)
                                {
                                    Program.LogWriter.Debug($"Local file already newer. Ignoring: {serverSaveFile}");

                                    shouldDownload = false;
                                }

                            }

                            if (shouldDownload)
                            {
                                Program.LogWriter.Debug($"Downloading: {serverSaveFile} as {localFilename}");

                                ftpClient.DownloadFile(localFilename, serverSaveFile.FullName, FtpLocalExists.Overwrite, FtpVerify.None, null);
                                /*
                                using (FileStream outputStream = new FileStream(localFilename, FileMode.Create))
                                {
                                    Program.LogWriter.Debug($"Downloading: {serverSaveFile} as {localFilename}");
                                    ftpClient.DownloadStream(outputStream, serverSaveFile.FullName);
                                    outputStream.Flush();
                                }
                                */
                                File.SetLastWriteTime(localFilename, serverSaveFile.Modified.ToLocalTime());
                            }



                            //get .arktribe files
                            var serverTribeFiles = serverFiles.Where(f => f.Name.EndsWith(".arktribe"));
                            if (serverTribeFiles != null && serverTribeFiles.Count() > 0)
                            {
                                foreach (var serverTribeFile in serverTribeFiles)
                                {
                                    Program.LogWriter.Debug($"Found: {serverTribeFile}");

                                    localFilename = Path.Combine(downloadPath, serverTribeFile.Name);
                                    shouldDownload = true;


                                    if (File.Exists(localFilename) && serverTribeFile.Modified.ToUniversalTime() <= File.GetLastWriteTimeUtc(localFilename))
                                    {
                                        if (Program.ProgramConfig.FtpDownloadMode == 0)
                                        {
                                            Program.LogWriter.Debug($"Local file already newer. Ignoring: {serverTribeFile}");
                                            shouldDownload = false;
                                        }

                                    }


                                    if (shouldDownload)
                                    {
                                        Program.LogWriter.Debug($"Downloading: {serverTribeFile} as {localFilename}");
                                        try
                                        {
                                            ftpClient.DownloadFile(localFilename, serverTribeFile.FullName, FtpLocalExists.Overwrite, FtpVerify.None, null);
                                            File.SetLastWriteTimeUtc(localFilename, serverTribeFile.Modified.ToUniversalTime());

                                        }
                                        catch { }
                                    }

                                }

                            }


                            //get .arkprofile files
                            var serverProfileFiles = serverFiles.Where(f => f.Name.EndsWith(".arkprofile"));
                            if (serverProfileFiles != null && serverProfileFiles.Count() > 0)
                            {
                                foreach (var serverProfileFile in serverProfileFiles)
                                {
                                    Program.LogWriter.Debug($"Found: {serverProfileFile}");

                                    localFilename = Path.Combine(downloadPath, serverProfileFile.Name);
                                    shouldDownload = true;
                                    if (File.Exists(localFilename) && serverProfileFile.Modified.ToUniversalTime() <= File.GetLastWriteTimeUtc(localFilename))
                                    {
                                        if (Program.ProgramConfig.FtpDownloadMode == 0)
                                        {
                                            Program.LogWriter.Debug($"Local file already newer. Ignoring: {serverProfileFile}");
                                            shouldDownload = false;
                                        }

                                    }
                                    if (shouldDownload)
                                    {
                                        Program.LogWriter.Debug($"Downloading: {serverProfileFile} as {localFilename}");

                                        ftpClient.DownloadFile(localFilename, serverProfileFile.FullName, FtpLocalExists.Overwrite, FtpVerify.None, null);
                                        File.SetLastWriteTimeUtc(localFilename, serverProfileFile.Modified.ToUniversalTime());
                                    }
                                }

                            }
                        }

                    }
                    catch (Exception exFtp)
                    {
                        //try implicit
                        Program.LogWriter.Debug($"Ftp connection failed: {exFtp.Message.ToString()}");
                    }


                }
                catch (Exception ex)
                {
                    Program.LogWriter.Error(ex, "Unable to download latest game data");
                    MessageBox.Show($"Unable to download latest game data.\n\n{ex.Message.ToString()}", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            Program.LogWriter.Trace("END DownloadFtp()");
            return downloadedFilename;

        }

        private void FtpClient_ValidateCertificate(FluentFTP.Client.BaseClient.BaseFtpClient control, FtpSslValidationEventArgs e)
        {
            e.Accept = true;
        }

        private bool DeletePlayerFtp(ContentPlayer player)
        {
            Program.LogWriter.Trace("BEGIN DeletePlayerFtp()");
            ServerConfiguration selectedServer = ARKViewer.Program.ProgramConfig.ServerList.Where(s => s.Name == ARKViewer.Program.ProgramConfig.SelectedServer).FirstOrDefault();
            if (selectedServer == null) return false;

            this.Cursor = Cursors.WaitCursor;
            bool returnVal = true;


            string profilePath = selectedServer.SaveGamePath.Substring(0, selectedServer.SaveGamePath.LastIndexOf("/"));
            string playerProfileFilename = $"{player.NetworkId}.arkprofile";
            string ftpFilePath = $"{profilePath}/{playerProfileFilename}";
            string serverUsername = selectedServer.Username;
            string serverPassword = selectedServer.Password;

            switch (selectedServer.Mode)
            {
                case 0:
                    //ftp
                    FtpClient ftpClient = new FtpClient(selectedServer.Address);

                    try
                    {
                        ftpClient.Credentials.UserName = selectedServer.Username;
                        ftpClient.Credentials.Password = selectedServer.Password;
                        ftpClient.Port = selectedServer.Port;
                        ftpClient.ValidateCertificate += FtpClient_ValidateCertificate1; ;

                        ftpClient.Connect();
                        ftpClient.DeleteFile(ftpFilePath);

                    }
                    catch
                    {
                        returnVal = false;
                    }
                    finally
                    {
                        ftpClient = null;
                    }


                    break;
                case 1:
                    //sftp
                    SftpClient sftpClient = new SftpClient(selectedServer.Address, selectedServer.Port, serverUsername, serverPassword);
                    try
                    {
                        sftpClient.Connect();

                        sftpClient.DeleteFile(ftpFilePath);

                    }
                    catch
                    {
                        returnVal = false;
                    }
                    finally
                    {
                        sftpClient.Dispose();
                    }

                    break;
            }


            Program.LogWriter.Trace("END DeletePlayerFtp()");
            return returnVal;
        }

        private void FtpClient_ValidateCertificate1(FluentFTP.Client.BaseClient.BaseFtpClient control, FtpSslValidationEventArgs e)
        {
            throw new NotImplementedException();
        }




        /***** Drawn Maps ******/
        private void RefreshMap(bool downloadData = false)
        {
            //if (!Program.ProgramConfig.LoadSaveOnStartup) return;

            Program.LogWriter.Trace("BEGIN RefreshMap()");

            this.Cursor = Cursors.WaitCursor;

            long startContentTicks = DateTime.Now.Ticks;

            UpdateProgress("Loading content pack. Please wait.");
            LoadContent(Program.ProgramConfig.SelectedFile, downloadData);
            long endContentTicks = DateTime.Now.Ticks;

            if (cm == null || cm.ContentDate == null || cm.ContentDate.Equals(new DateTime()))
            {
                //unable to load pack
                UpdateProgress("Content failed to load.  Please check settings or refresh download to try again.");
            }
            else
            {
                UpdateProgress($"Content loaded and refreshed in {TimeSpan.FromTicks(endContentTicks - startContentTicks).ToString(@"mm\:ss")}.");


            }




            this.Cursor = Cursors.Default;

            Program.LogWriter.Trace("END RefreshMap()");
        }

        private void ShowMapViewer()
        {
            if (cm == null) return;

            if (MapViewer == null || MapViewer.IsDisposed)
            {
                MapViewer = frmMapView.GetForm(cm);
                MapViewer.OnMapClicked += MapViewer_OnMapClicked;
            }

            MapViewer.CustomMarkers = Program.ProgramConfig.MapMarkerList.Where(x => x.Map.ToLower().StartsWith(cm.MapFilename.ToLower())).ToList();
            DrawMap(0, 0);

            MapViewer.Show();
            MapViewer.BringToFront();
        }

        private void DrawMap(float selectedX, float selectedY)
        {
            if (cm == null || MapViewer == null || MapViewer.IsDisposed)
            {
                return;
            }

            lblStatus.Text = "Updating selections...";
            lblStatus.Refresh();

            switch (tabFeatures.SelectedTab.Name)
            {
                case "tpgWild":
                    string wildClass = "";
                    string wildProduction = "";
                    if (cboWildClass.SelectedItem != null)
                    {
                        ASVCreatureSummary selectedValue = (ASVCreatureSummary)cboWildClass.SelectedItem;
                        wildClass = selectedValue.ClassName;
                    }

                    if (cboWildResource.SelectedItem != null)
                    {
                        ASVComboValue selectedValue = (ASVComboValue)cboWildResource.SelectedItem;
                        wildProduction = selectedValue.Key;
                    }

                    List<Tuple<float, float>> selectedLocations = new List<Tuple<float, float>>();
                    foreach (ListViewItem item in lvwWildDetail.SelectedItems)
                    {
                        ContentWildCreature wildCreature = (ContentWildCreature)item.Tag;
                        selectedLocations.Add(new Tuple<float, float>(wildCreature.Latitude.GetValueOrDefault(0), wildCreature.Longitude.GetValueOrDefault(0)));
                    }
                    MapViewer.DrawMapImageWild(wildClass, wildProduction, (int)udWildMin.Value, (int)udWildMax.Value, (float)udWildLat.Value, (float)udWildLon.Value, (float)udWildRadius.Value, selectedLocations, (cboWildRealm.SelectedItem as ASVComboValue).Key);

                    break;
                case "tpgTamed":

                    string tameClass = "";
                    string tameProduction = "";
                    if (cboTameClass.SelectedItem != null)
                    {
                        ASVCreatureSummary selectedValue = (ASVCreatureSummary)cboTameClass.SelectedItem;
                        tameClass = selectedValue.ClassName;
                    }
                    if (cboTamedResource.SelectedItem != null)
                    {
                        ASVComboValue selectedValue = (ASVComboValue)cboTamedResource.SelectedItem;
                        tameProduction = selectedValue.Key;
                    }


                    long tribeId = 0;
                    if (cboTameTribes.SelectedItem != null)
                    {
                        ASVComboValue selectedTribe = (ASVComboValue)cboTameTribes.SelectedItem;
                        long.TryParse(selectedTribe.Key, out tribeId);
                    }

                    long playerId = 0;
                    if (cboTamePlayers.SelectedItem != null)
                    {
                        ASVComboValue selectedPlayer = (ASVComboValue)cboTamePlayers.SelectedItem;
                        long.TryParse(selectedPlayer.Key, out playerId);
                    }


                    List<Tuple<float, float>> selectedTameLocations = new List<Tuple<float, float>>();

                    foreach (ListViewItem item in lvwTameDetail.SelectedItems)
                    {
                        ContentTamedCreature selectedTame = (ContentTamedCreature)item.Tag;
                        selectedTameLocations.Add(new Tuple<float, float>(selectedTame.Latitude.GetValueOrDefault(0), selectedTame.Longitude.GetValueOrDefault(0)));
                    }


                    var fromLatTamed = (float)udLatTamed.Value;
                    var fromLonTamed = (float)udLonTamed.Value;
                    var fromRadiusTamed = (float)udRadiusTamed.Value;

                    MapViewer.DrawMapImageTamed(tameClass, tameProduction, cboTameFilter.SelectedIndex, tribeId, playerId, selectedTameLocations, (cboTameRealm.SelectedItem as ASVComboValue).Key, fromLatTamed, fromLonTamed, fromRadiusTamed);


                    break;
                case "tpgStructures":
                    //map out player structures
                    string structureClass = "";
                    if (cboStructureStructure.SelectedItem != null)
                    {
                        ASVComboValue selectedStructure = (ASVComboValue)cboStructureStructure.SelectedItem;
                        structureClass = selectedStructure.Key;
                    }
                    long structureTribe = 0;
                    if (cboStructureTribe.SelectedItem != null)
                    {
                        ASVComboValue selectedTribe = (ASVComboValue)cboStructureTribe.SelectedItem;
                        long.TryParse(selectedTribe.Key, out structureTribe);
                    }

                    long structurePlayer = 0;
                    if (cboStructurePlayer.SelectedItem != null)
                    {
                        ASVComboValue selectedPlayer = (ASVComboValue)cboStructurePlayer.SelectedItem;
                        long.TryParse(selectedPlayer.Key, out tribeId);
                    }

                    List<Tuple<float, float>> selectedStructLocations = new List<Tuple<float, float>>();

                    foreach (ListViewItem item in lvwStructureLocations.SelectedItems)
                    {
                        ContentStructure selectedStructure = (ContentStructure)item.Tag;
                        selectedStructLocations.Add(new Tuple<float, float>(selectedStructure.Latitude.GetValueOrDefault(0), selectedStructure.Longitude.GetValueOrDefault(0)));
                    }



                    var fromLatStructures = (float)udLatStructures.Value;
                    var fromLonStructures = (float)udLonStructures.Value;
                    var fromRadStructures = (float)udRadiusStructures.Value;

                    MapViewer.DrawMapImagePlayerStructures(structureClass, structureTribe, structurePlayer, selectedStructLocations, (cboStructureRealm.SelectedItem as ASVComboValue).Key, fromLatStructures, fromLonStructures, fromRadStructures);

                    break;
                case "tpgPlayers":
                    //players
                    long playerTribe = 0;
                    if (cboTribes.SelectedItem != null)
                    {
                        ASVComboValue selectedTribe = (ASVComboValue)cboTribes.SelectedItem;
                        long.TryParse(selectedTribe.Key, out playerTribe);
                    }

                    long currentId = 0;
                    if (cboPlayers.SelectedItem != null)
                    {
                        ASVComboValue selectedPlayer = (ASVComboValue)cboPlayers.SelectedItem;
                        long.TryParse(selectedPlayer.Key, out currentId);
                    }

                    List<Tuple<float, float>> selectedPlayerLocations = new List<Tuple<float, float>>();

                    foreach (ListViewItem item in lvwPlayers.SelectedItems)
                    {
                        ContentPlayer selectedPlayerLocation = (ContentPlayer)item.Tag;
                        selectedPlayerLocations.Add(new Tuple<float, float>(selectedPlayerLocation.Latitude.GetValueOrDefault(0), selectedPlayerLocation.Longitude.GetValueOrDefault(0)));
                    }


                    MapViewer.DrawMapImagePlayers(playerTribe, currentId, selectedPlayerLocations, (cboPlayerRealm.SelectedItem as ASVComboValue).Key);

                    break;
                case "tpgDroppedItems":

                    long droppedPlayerId = 0;
                    if (cboDroppedPlayer.SelectedItem != null)
                    {
                        ASVComboValue selectedPlayer = (ASVComboValue)cboDroppedPlayer.SelectedItem;
                        long.TryParse(selectedPlayer.Key, out droppedPlayerId);
                    }
                    string droppedClass = "";
                    if (cboDroppedItem.SelectedItem != null)
                    {
                        ASVComboValue droppedValue = (ASVComboValue)cboDroppedItem.SelectedItem;
                        droppedClass = droppedValue.Key;
                    }


                    List<Tuple<float, float>> selectedDropLocations = new List<Tuple<float, float>>();

                    foreach (ListViewItem item in lvwDroppedItems.SelectedItems)
                    {
                        ContentDroppedItem droppedItem = (ContentDroppedItem)item.Tag;
                        selectedDropLocations.Add(new Tuple<float, float>(droppedItem.Latitude.GetValueOrDefault(0), droppedItem.Longitude.GetValueOrDefault(0)));
                    }
                    if (droppedClass == "-1")
                    {

                        MapViewer.DrawMapImageDropBags(droppedPlayerId, selectedDropLocations, (cboDroppedItemRealm.SelectedItem as ASVComboValue).Key);
                    }
                    else
                    {
                        if (droppedClass == "0") droppedClass = "";

                        MapViewer.DrawMapImageDroppedItems(droppedPlayerId, droppedClass, selectedDropLocations, (cboDroppedItemRealm.SelectedItem as ASVComboValue).Key);
                    }


                    break;
                case "tpgTribes":
                    long summaryTribeId = 0;

                    if (lvwTribes.SelectedItems.Count > 0)
                    {
                        ListViewItem selectedItem = lvwTribes.SelectedItems[0];
                        ContentTribe selectedTribe = (ContentTribe)selectedItem.Tag;
                        summaryTribeId = selectedTribe.TribeId;
                    }

                    MapViewer.DrawMapImageTribes(summaryTribeId, chkTribeStructures.Checked, chkTribePlayers.Checked, chkTribeTames.Checked, new List<Tuple<float, float>>());

                    break;
                case "tpgItemList":

                    long itemTribeId = 0;
                    if (cboItemListTribe.SelectedItem != null)
                    {
                        ASVComboValue selectedTribe = (ASVComboValue)cboItemListTribe.SelectedItem;
                        long.TryParse(selectedTribe.Key, out itemTribeId);
                    }

                    string itemClass = "";
                    if (cboItemListItem.SelectedItem != null)
                    {
                        ASVComboValue itemValue = (ASVComboValue)cboItemListItem.SelectedItem;
                        itemClass = itemValue.Key;
                    }



                    //ASVFoundItem
                    List<Tuple<float, float>> selectedFoundLocations = new List<Tuple<float, float>>();

                    foreach (ListViewItem item in lvwItemList.SelectedItems)
                    {
                        ASVFoundItem foundItem = (ASVFoundItem)item.Tag;
                        selectedFoundLocations.Add(new Tuple<float, float>(foundItem.Latitude, foundItem.Longitude));
                    }

                    MapViewer.DrawMapImageItems(itemTribeId, itemClass, selectedFoundLocations, "");

                    break;

                default:

                    break;
            }

            lblStatus.Text = "Map display updated.";
            lblStatus.Refresh();

        }

        private void MapViewer_OnMapClicked(decimal latitutde, decimal longitude)
        {
            AttemptReverseMapSelection(latitutde, longitude);
        }

        private void AttemptReverseMapSelection(decimal latitude, decimal longitude)
        {

            switch (tabFeatures.SelectedTab.Name)
            {
                case "tpgWild":

                    if (lvwWildDetail.Items.Count > 0)
                    {
                        //get nearest 
                        foreach (ListViewItem item in lvwWildDetail.Items)
                        {
                            ContentWildCreature wild = (ContentWildCreature)item.Tag;

                            decimal latDistance = Math.Abs((decimal)wild.Latitude.GetValueOrDefault(0) - latitude);
                            decimal lonDistance = Math.Abs((decimal)wild.Longitude.GetValueOrDefault(0) - longitude);

                            if (latDistance <= (decimal)0.5 && lonDistance <= (decimal)0.5)
                            {
                                lvwWildDetail.SelectedItems.Clear();
                                item.Selected = true;
                                item.EnsureVisible();
                                this.BringToFront();
                                break;
                            }

                        }

                    }


                    break;
                case "tpgTamed":

                    if (lvwTameDetail.Items.Count > 0)
                    {
                        //get nearest 
                        foreach (ListViewItem item in lvwTameDetail.Items)
                        {
                            ContentTamedCreature tame = (ContentTamedCreature)item.Tag;

                            decimal latDistance = Math.Abs((decimal)tame.Latitude.GetValueOrDefault(0) - latitude);
                            decimal lonDistance = Math.Abs((decimal)tame.Longitude.GetValueOrDefault(0) - longitude);

                            if (latDistance <= (decimal)0.5 && lonDistance <= (decimal)0.5)
                            {
                                lvwTameDetail.SelectedItems.Clear();
                                item.Selected = true;
                                item.EnsureVisible();
                                this.BringToFront();
                                break;
                            }
                        }
                    }

                    break;
                case "tpgStructures":
                    if (lvwStructureLocations.Items.Count > 0)
                    {
                        //get nearest 
                        foreach (ListViewItem item in lvwStructureLocations.Items)
                        {
                            ContentStructure structure = (ContentStructure)item.Tag;

                            decimal latDistance = Math.Abs((decimal)structure.Latitude.GetValueOrDefault(0) - latitude);
                            decimal lonDistance = Math.Abs((decimal)structure.Longitude.GetValueOrDefault(0) - longitude);

                            if (latDistance <= (decimal)0.5 && lonDistance <= (decimal)0.5)
                            {
                                lvwStructureLocations.SelectedItems.Clear();
                                item.Selected = true;
                                item.EnsureVisible();
                                this.BringToFront();
                                break;
                            }

                        }


                    }


                    break;
                case "tpgPlayers":
                    if (lvwPlayers.Items.Count > 0)
                    {

                        //get nearest 
                        foreach (ListViewItem item in lvwPlayers.Items)
                        {
                            ContentPlayer player = (ContentPlayer)item.Tag;

                            decimal latDistance = Math.Abs((decimal)player.Latitude.GetValueOrDefault(0) - latitude);
                            decimal lonDistance = Math.Abs((decimal)player.Longitude.GetValueOrDefault(0) - longitude);

                            if (latDistance <= (decimal)0.5 && lonDistance <= (decimal)0.5)
                            {
                                lvwStructureLocations.SelectedItems.Clear();
                                item.Selected = true;
                                item.EnsureVisible();
                                this.BringToFront();
                                break;
                            }

                        }
                    }

                    break;
                case "tpgItemList":

                    if (lvwItemList.Items.Count > 0)
                    {

                        //get nearest 
                        foreach (ListViewItem item in lvwItemList.Items)
                        {
                            ASVFoundItem foundItem = (ASVFoundItem)item.Tag;

                            decimal latDistance = Math.Abs((decimal)foundItem.Latitude - latitude);
                            decimal lonDistance = Math.Abs((decimal)foundItem.Longitude - longitude);

                            if (latDistance <= (decimal)0.5 && lonDistance <= (decimal)0.5)
                            {
                                lvwItemList.SelectedItems.Clear();
                                item.Selected = true;
                                item.EnsureVisible();
                                this.BringToFront();
                                break;
                            }

                        }
                    }

                    break;
                default:
                    break;
            }


        }



        /******** Summaries **********/
        private void RefreshTamedTraits()
        {
            cboTamedTrait.Items.Clear();

            cboTamedTrait.Items.Add(new ASVComboValue("", "[All Traits]"));
            cboTamedTrait.SelectedIndex = 0;
            foreach (var trait in traitList)
            {
                cboTamedTrait.Items.Add(new ASVComboValue(trait, trait));
            }
        }

        private void RefreshWildTraits()
        {
            cboWildTrait.Items.Clear();

            cboWildTrait.Items.Add(new ASVComboValue("", "[All Traits]"));
            cboWildTrait.SelectedIndex = 0;
            foreach (var trait in traitList)
            {
                cboWildTrait.Items.Add(new ASVComboValue(trait, trait));
            }
        }

        private void RefreshTamedProductionResources()
        {
            cboTamedResource.Items.Clear();

            cboTamedResource.Items.Add(new ASVComboValue("", "[Any Resource]"));
            cboTamedResource.SelectedIndex = 0;

            List<ASVComboValue> productionComboValues = new List<ASVComboValue>();

            var tameDinos = cm.GetTamedCreatures("", 0, 0, 0, "");

            var productionResources = tameDinos.Where(x => x.ProductionResources != null).SelectMany(d => d.ProductionResources).Distinct().ToList();
            if (productionResources != null && productionResources.Count > 0)
            {
                foreach (var resourceClass in productionResources)
                {
                    string displayName = resourceClass;
                    var itemMap = Program.ProgramConfig.ItemMap.Find(i => i.ClassName == resourceClass);
                    if (itemMap != null && itemMap.DisplayName.Length > 0) displayName = itemMap.DisplayName;

                    productionComboValues.Add(new ASVComboValue(resourceClass, displayName));
                }
            }

            if (productionComboValues != null && productionComboValues.Count > 0)
            {
                cboTamedResource.Items.AddRange(productionComboValues.OrderBy(o => o.Value).ToArray());
            }
        }

        private void RefreshStructureSummary()
        {
            if (cm == null) return;
            if (cboStructureTribe.SelectedItem == null) return;


            string selectedClass = "NONE";
            if (cboStructureStructure.SelectedItem != null)
            {
                ASVComboValue selectedValue = (ASVComboValue)cboStructureStructure.SelectedItem;
                selectedClass = selectedValue.Key;
            }

            cboStructureStructure.Items.Clear();
            cboStructureStructure.Items.Add(new ASVComboValue() { Key = "NONE", Value = "[None]" });
            cboStructureStructure.Items.Add(new ASVComboValue() { Key = "", Value = "[All Structures]" });

            //tribe
            ASVComboValue comboValue = (ASVComboValue)cboStructureTribe.SelectedItem;
            int.TryParse(comboValue.Key, out int selectedTribeId);

            //player
            comboValue = (ASVComboValue)cboStructurePlayer.SelectedItem;
            int.TryParse(comboValue.Key, out int selectedPlayerId);

            float fromLat = (float)udLatStructures.Value;
            float fromLon = (float)udLonStructures.Value;
            float fromRadius = (float)udRadiusStructures.Value;


            var playerStructureTypes = cm.GetPlayerStructures(selectedTribeId, selectedPlayerId, "", false, (cboStructureRealm.SelectedItem as ASVComboValue).Key, fromLat, fromLon, fromRadius)
                                                        .Where(s =>
                                                            Program.ProgramConfig.StructureExclusions == null
                                                            || (Program.ProgramConfig.StructureExclusions != null & !Program.ProgramConfig.StructureExclusions.Contains(s.ClassName))
                                                        ).GroupBy(g => g.ClassName)
                                                       .Select(s => s.Key);

            List<ASVComboValue> newItems = new List<ASVComboValue>();


            if (playerStructureTypes != null && playerStructureTypes.Count() > 0)
            {

                foreach (var className in playerStructureTypes)
                {
                    var structureName = className;
                    var itemMap = Program.ProgramConfig.StructureMap.Where(i => i.ClassName == className).FirstOrDefault();

                    ASVComboValue classNameItem = new ASVComboValue(className, "");

                    if (itemMap != null && itemMap.FriendlyName.Length > 0)
                    {
                        structureName = itemMap.FriendlyName;
                        classNameItem.Value = structureName;

                    }


                    if (structureName == null || structureName.Length == 0) structureName = className;

                    newItems.Add(new ASVComboValue() { Key = className, Value = structureName });
                }


            }


            int selectedIndex = 0;
            if (newItems.Count > 0)
            {
                cboStructureStructure.BeginUpdate();
                foreach (var newItem in newItems.OrderBy(o => o.Value))
                {
                    int newIndex = cboStructureStructure.Items.Add(newItem);
                    if (newItem.Key == selectedClass)
                    {
                        selectedIndex = newIndex;
                    }
                }
                cboStructureStructure.EndUpdate();

            }

            if (tabFeatures.SelectedTab.Name == "tpgStructures")
            {
                cboStructureStructure.SelectedIndex = selectedIndex;
            }
            else
            {
                cboStructureStructure.SelectedIndex = 0;
            }


        }

        private void RefreshPaintingStructures()
        {
            if (cm == null) return;
            if (cboPaintingTribe.SelectedItem == null) return;


            string selectedClass = "NONE";
            if (cboPaintingStructure.SelectedItem != null)
            {
                ASVComboValue selectedValue = (ASVComboValue)cboPaintingStructure.SelectedItem;
                selectedClass = selectedValue.Key;
            }

            cboPaintingStructure.Items.Clear();
            cboPaintingStructure.Items.Add(new ASVComboValue() { Key = "NONE", Value = "[None]" });
            cboPaintingStructure.Items.Add(new ASVComboValue() { Key = "", Value = "[All Structures]" });

            //tribe
            ASVComboValue comboValue = (ASVComboValue)cboPaintingTribe.SelectedItem;
            int.TryParse(comboValue.Key, out int selectedTribeId);


            var playerStructureTypes = cm.GetPlayerStructures(selectedTribeId, 0, "", false, string.Empty)
                                                        .Where(s =>
                                                            (Program.ProgramConfig.StructureExclusions == null
                                                            || (Program.ProgramConfig.StructureExclusions != null & !Program.ProgramConfig.StructureExclusions.Contains(s.ClassName)))
                                                            && s.UniquePaintingId != 0
                                                        ).GroupBy(g => g.ClassName)
                                                       .Select(s => s.Key);

            List<ASVComboValue> newItems = new List<ASVComboValue>();


            if (playerStructureTypes != null && playerStructureTypes.Count() > 0)
            {

                foreach (var className in playerStructureTypes)
                {
                    var structureName = className;
                    var itemMap = Program.ProgramConfig.StructureMap.Where(i => i.ClassName == className).FirstOrDefault();

                    ASVComboValue classNameItem = new ASVComboValue(className, "");

                    if (itemMap != null && itemMap.FriendlyName.Length > 0)
                    {
                        structureName = itemMap.FriendlyName;
                        classNameItem.Value = structureName;

                    }


                    if (structureName == null || structureName.Length == 0) structureName = className;

                    newItems.Add(new ASVComboValue() { Key = className, Value = structureName });
                }


            }


            int selectedIndex = 1;
            if (newItems.Count > 0)
            {
                cboPaintingStructure.BeginUpdate();
                foreach (var newItem in newItems.OrderBy(o => o.Value))
                {
                    int newIndex = cboPaintingStructure.Items.Add(newItem);
                    if (newItem.Key == selectedClass)
                    {
                        selectedIndex = newIndex;
                    }
                }
                cboPaintingStructure.EndUpdate();

            }

            if (tabFeatures.SelectedTab.Name == "tpgPaintings")
            {
                cboPaintingStructure.SelectedIndex = selectedIndex;
            }
            else
            {
                cboPaintingStructure.SelectedIndex = 0;
            }

        }

        private void RefreshTribeSummary()
        {
            if (cm == null) return;

            if (tabFeatures.SelectedTab.Name != "tpgTribes") return;


            lvwTribes.Items.Clear();
            var allTribes = cm.GetTribes(0);
            if (allTribes != null && allTribes.Count > 0)
            {
                //tribe id, tribe name, players, tames, structures, last active
                foreach (var tribe in allTribes)
                {
                    ListViewItem newItem = lvwTribes.Items.Add(tribe.TribeId.ToString());
                    newItem.Tag = tribe;
                    newItem.SubItems.Add(tribe.TribeName);
                    newItem.SubItems.Add(tribe.Players.Count.ToString());
                    newItem.SubItems.Add(tribe.Tames.Count.ToString());
                    newItem.SubItems.Add(tribe.Structures.Count.ToString());
                    newItem.SubItems.Add(tribe.LastActive.Equals(new DateTime()) ? "" : tribe.LastActive.ToString());
                }
            }



            //if (allTribes.Count < udChartTopTames.Maximum) udChartTopTames.Value = allTribes.Count;
            //udChartTopTames.Maximum = allTribes.Count;

            //if (allTribes.Count < udChartTopStructures.Maximum) udChartTopStructures.Value = allTribes.Count;
            //udChartTopPlayers.Maximum = allTribes.Count;

            //if (allTribes.Count < udChartTopStructures.Maximum) udChartTopStructures.Value = allTribes.Count;
            //udChartTopStructures.Maximum = allTribes.Count;

            if (cboChartType.SelectedIndex < 0) cboChartType.SelectedIndex = 0;
            DrawTribeCharts();


        }

        private void DrawTribeCharts()
        {

            switch (cboChartType.SelectedIndex)
            {
                case 1:
                    DrawTribeChartTames();

                    break;

                case 2:
                    DrawTribeChartStructures();

                    break;

                default:
                    DrawTribeChartPlayers();

                    break;
            }



        }

        private void DrawTribeChartPlayers()
        {

            chartTribes.ClearElements();
            chartTribes.SubTitle = $"Top {(int)udChartTop.Value} by player count.";

            var allTribes = cm.GetTribes(0).Where(x => x.Players != null);
            if (allTribes == null) return;
            if (allTribes.Sum(t => t.Players?.Count ?? 0) == 0) return;

            var topTribes = allTribes.OrderByDescending(x => x.Players.Count).Take((int)udChartTop.Value).ToList();

            if (topTribes != null && topTribes.Count > 0)
            {
                foreach (var t in topTribes.OrderByDescending(x => x.Players.Count))
                {
                    chartTribes.AddElement($"{t.TribeName}", t.Players.Count);

                };

            }


        }

        private void DrawTribeChartStructures()
        {
            chartTribes.ClearElements();
            chartTribes.SubTitle = $"Top {(int)udChartTop.Value} by structure count.";

            var allTribes = cm.GetTribes(0).Where(x => x.Structures != null);
            if (allTribes == null) return;


            var topTribes = allTribes.OrderByDescending(x => x.Structures.Count).Take((int)udChartTop.Value).ToList();

            if (topTribes != null && topTribes.Count > 0)
            {
                foreach (var t in topTribes.OrderByDescending(x => x.Structures.Count))
                {
                    chartTribes.AddElement($"{t.TribeName}", t.Structures.Count);

                };

            }


        }

        private string getRandomColor()
        {

            var letters = "0123456789ABCDEF".ToCharArray();
            var color = "#";
            for (var i = 0; i < 6; i++)
            {
                int nextRand = rndChartColor.Next();
                Random rndNew = new Random(nextRand);


                long r = (long)Math.Floor((rndNew.NextDouble() * 16));
                color += letters[r];
            }
            return color;
        }

        private void DrawTribeChartTames()
        {
            chartTribes.ClearElements();
            chartTribes.SubTitle = $"Top {(int)udChartTop.Value} by tame count.";
            var allTribes = cm.GetTribes(0).Where(x => x.Tames != null);
            if (allTribes == null) return;


            var topTribes = allTribes.OrderByDescending(x => x.Tames.Count).Take((int)udChartTop.Value).ToList();
            if (topTribes != null && topTribes.Count > 0)
            {
                foreach (var t in topTribes.OrderByDescending(x => x.Tames.Count))
                {
                    chartTribes.AddElement($"{t.TribeName}", t.Tames.Count);

                };

            }
        }

        private void RefreshTamedSummary()
        {

            if (cm == null)
            {
                return;
            }


            lblStatus.Text = "Populating tamed creature summary...";
            lblStatus.Refresh();




            int classIndex = 0;
            string selectedClass = "";
            if (cboTameClass.SelectedItem != null)
            {
                ASVCreatureSummary selectedDino = (ASVCreatureSummary)cboTameClass.SelectedItem;
                selectedClass = selectedDino.ClassName;
            }


            List<int> playerRestrictions = new List<int>();
            List<string> tribeRestrictions = new List<string>();

            if (ARKViewer.Program.ProgramConfig.Mode == ViewerModes.Mode_Ftp)
            {
                //check for server restritions
                ServerConfiguration currentConfig = ARKViewer.Program.ProgramConfig.ServerList.Where(s => s.Name == ARKViewer.Program.ProgramConfig.SelectedServer).FirstOrDefault<ServerConfiguration>();
                if (currentConfig != null)
                {
                    if (currentConfig.RestrictedTribes != null)
                    {
                        tribeRestrictions.AddRange(currentConfig.RestrictedTribes);
                    }

                    if (currentConfig.RestrictedPlayers != null)
                    {
                        playerRestrictions.AddRange(currentConfig.RestrictedPlayers);
                    }
                }
            }


            optStatsMutated.Enabled = cm.GetPack().Tribes.Any(t => t.Tames.Any(x => x.TamedMutations != null));
            if (!optStatsMutated.Enabled && optStatsMutated.Checked) optStatsBase.Checked = true;


            //MessageBox.Show("Listing tamed creatures.");
            var tamedSummary = cm.GetTamedCreatures("", 0, 0, 0, "", (float)udLatTamed.Value, (float)udLonTamed.Value, (float)udRadiusTamed.Value)
                                .Where(t => !(t.ClassName == "MotorRaft_BP_C" || t.ClassName == "Raft_BP_C"))
                                .GroupBy(c => c.ClassName)
                                .Select(g => new { ClassName = g.Key, Name = ARKViewer.Program.ProgramConfig.DinoMap.Count(d => d.ClassName == g.Key) == 0 ? g.Key : ARKViewer.Program.ProgramConfig.DinoMap.Where(d => d.ClassName == g.Key).FirstOrDefault().FriendlyName, Count = g.Count(), Min = g.Min(l => l.Level), Max = g.Max(l => l.Level) })
                                .OrderBy(o => o.Name);

            cboTameClass.Items.Clear();
            cboTameClass.Items.Add(new ASVCreatureSummary() { ClassName = "-1", Name = "[Please Select]", Count = 0 });

            if (tamedSummary != null && tamedSummary.Count() > 0)
            {
                ((ASVCreatureSummary)cboTameClass.Items[0]).Count = tamedSummary.Sum(s => s.Count);
                cboTameClass.Items.Add(new ASVCreatureSummary() { ClassName = "", Name = "[All Creatures]", Count = tamedSummary.Sum(s => s.Count) });

                foreach (var summary in tamedSummary)
                {
                    ASVCreatureSummary newSummary = new ASVCreatureSummary()
                    {
                        ClassName = summary.ClassName,
                        Name = summary.Name,
                        Count = summary.Count,
                        MinLevel = summary.Min,
                        MaxLevel = summary.Max,
                        MaxLength = 100
                    };
                    int newIndex = cboTameClass.Items.Add(newSummary);
                    if (selectedClass == summary.ClassName)
                    {
                        classIndex = newIndex;
                    }
                }

            }
            else
            {
                cboTameClass.Items.Add(new ASVCreatureSummary() { ClassName = "", Name = "[All Creatures]", Count = 0 });
            }


            lblTameTotal.Text = "Count: 0";

            if (cboTameClass.Items.Count > 0) cboTameClass.SelectedIndex = classIndex;

            lblStatus.Text = "Tamed creatures populated.";
            lblStatus.Refresh();

        }

        private void RefreshWildSummary()
        {

            if (cm == null)
            {
                return;
            }

            lblStatus.Text = "Populating wild creature summary...";
            lblStatus.Refresh();




            int classIndex = 0;
            string selectedClass = "";
            if (cboWildClass.SelectedItem != null)
            {
                ASVCreatureSummary selectedDino = (ASVCreatureSummary)cboWildClass.SelectedItem;
                selectedClass = selectedDino.ClassName;
            }


            //wild side
            int minLevel = (int)udWildMin.Value;
            int maxLevel = (int)udWildMax.Value;
            float selectedLat = (float)udWildLat.Value;
            float selectedLon = (float)udWildLon.Value;
            float selectedRad = (float)udWildRadius.Value;

            var wildDinos = cm.GetWildCreatures(minLevel, maxLevel, selectedLat, selectedLon, selectedRad, "", (cboWildRealm.SelectedItem as ASVComboValue).Key);

            //remove untamable if not selected
            if (chkTameable.Checked)
            {
                wildDinos.RemoveAll(d => !d.IsTameable);
            }


            cboWildClass.Items.Clear();
            int newIndex = 0;

            //add NONE
            ASVCreatureSummary noneSummary = new ASVCreatureSummary()
            {
                ClassName = "-1",
                Name = "[Please Select]",
                Count = 0,
                MinLevel = 0,
                MaxLevel = 0,
                MaxLength = 100
            };

            cboWildResource.Items.Clear();
            cboWildResource.Items.Add(new ASVComboValue("", "[Any Resource]"));
            cboWildResource.SelectedIndex = 0;

            if (wildDinos != null)
            {

                List<ASVComboValue> productionComboValues = new List<ASVComboValue>();

                var productionResources = wildDinos.Where(x => x.ProductionResources != null).SelectMany(d => d.ProductionResources).Distinct().ToList();
                if (productionResources != null && productionResources.Count > 0)
                {
                    foreach (var resourceClass in productionResources)
                    {
                        string displayName = resourceClass;
                        var itemMap = Program.ProgramConfig.ItemMap.Find(i => i.ClassName == resourceClass);
                        if (itemMap != null && itemMap.DisplayName.Length > 0) displayName = itemMap.DisplayName;

                        productionComboValues.Add(new ASVComboValue(resourceClass, displayName));
                    }
                }

                if (productionComboValues != null && productionComboValues.Count > 0)
                {
                    cboWildResource.Items.AddRange(productionComboValues.OrderBy(o => o.Value).ToArray());
                }

                int summaryCount = 0;
                int summaryMin = 0;
                int summaryMax = 150;

                var wildSummary = wildDinos
                                .GroupBy(c => c.ClassName)
                                .Select(g => new { ClassName = g.Key, Name = ARKViewer.Program.ProgramConfig.DinoMap.Count(d => d.ClassName == g.Key) == 0 ? g.Key : ARKViewer.Program.ProgramConfig.DinoMap.Where(d => d.ClassName == g.Key).FirstOrDefault().FriendlyName, Count = g.Count(), Min = g.Min(l => l.BaseLevel), Max = g.Max(l => l.BaseLevel) })
                                .OrderBy(o => o.Name);

                if (wildSummary != null && wildSummary.LongCount() > 0)
                {
                    summaryCount = wildSummary.Sum(s => s.Count);
                    summaryMin = wildSummary.Min(s => s.Min);
                    summaryMax = wildSummary.Max(s => s.Max);
                }

                noneSummary.Count = summaryCount;
                noneSummary.MinLevel = summaryMin;
                noneSummary.MaxLevel = summaryMax;
                newIndex = cboWildClass.Items.Add(noneSummary);

                //add "All" summary
                int minLevelDefault = summaryMin;
                int maxLevelDefault = summaryMax;

                ASVCreatureSummary allSummary = new ASVCreatureSummary()
                {
                    ClassName = "",
                    Name = "[All Creatures]",
                    Count = wildSummary.Sum(s => s.Count),
                    MinLevel = minLevelDefault,
                    MaxLevel = maxLevelDefault,
                    MaxLength = 100
                };

                newIndex = cboWildClass.Items.Add(allSummary);


                foreach (var summary in wildSummary.OrderBy(o => o.Name))
                {

                    ASVCreatureSummary newSummary = new ASVCreatureSummary()
                    {
                        ClassName = summary.ClassName,
                        Name = summary.Name,
                        Count = summary.Count,
                        MinLevel = summary.Min,
                        MaxLevel = summary.Max,
                        MaxLength = 100
                    };


                    newIndex = cboWildClass.Items.Add(newSummary);
                    if (selectedClass == summary.ClassName)
                    {
                        classIndex = newIndex;
                    }
                }

                lblWildTotal.Text = "Total: " + wildSummary.Sum(w => w.Count).ToString();
            }


            lblStatus.Text = "Wild creatures populated.";
            lblStatus.Refresh();


            if (cboWildClass.Items.Count > 0) cboWildClass.SelectedIndex = classIndex;

        }



        /********* User Selections *********/
        private void RefreshPlayerTribes()
        {
            if (cm == null) return;

            cboTribes.Items.Clear();
            cboTribes.Items.Add(new ASVComboValue("0", "[All Tribes]"));

            List<ASVComboValue> newItems = new List<ASVComboValue>();

            var tribes = cm.GetTribes(0);

            if (tribes.Count() > 0)
            {
                foreach (var tribe in tribes)
                {
                    bool addTribe = true;
                    if (Program.ProgramConfig.HideNoBody)
                    {

                        addTribe = tribe.Players.Count > 0 && !tribe.Players.All(p => (p.Latitude.GetValueOrDefault(0) == 0 && p.Longitude.GetValueOrDefault(0) == 0));
                    }

                    if (addTribe)
                    {
                        ASVComboValue valuePair = new ASVComboValue(tribe.TribeId.ToString(), tribe.TribeName);
                        newItems.Add(valuePair);
                    }
                }
            }
            if (newItems.Count > 0)
            {
                cboTribes.BeginUpdate();
                foreach (var newItem in newItems.OrderBy(o => o.Value))
                {
                    cboTribes.Items.Add(newItem);
                }

                cboTribes.EndUpdate();
            }

            cboTribes.SelectedIndex = 0;
        }


        private void RefreshLeaderboardTribes()
        {
            if (cm == null) return;

            cboLeaderboardTribe.Items.Clear();
            cboLeaderboardTribe.Items.Add(new ASVComboValue("0", "[All Tribes]"));

            List<ASVComboValue> newItems = new List<ASVComboValue>();

            var allTribes = cm.GetTribes(0);
            if (allTribes != null && allTribes.Count() > 0)
            {
                foreach (var tribe in allTribes)
                {
                    bool addItem = tribe.TribeId > 0 && tribe.TribeId != 2_000_000_000;

                    if (addItem)
                    {
                        if (tribe.TribeName == null || tribe.TribeName.Length == 0) tribe.TribeName = "[N/A]";
                        ASVComboValue valuePair = new ASVComboValue(tribe.TribeId.ToString(), tribe.TribeName);
                        newItems.Add(valuePair);
                    }
                }
            }


            if (newItems.Count > 0)
            {
                cboLeaderboardTribe.BeginUpdate();

                foreach (var newItem in newItems.OrderBy(o => o.Value))
                {
                    cboLeaderboardTribe.Items.Add(newItem);
                }

                cboLeaderboardTribe.EndUpdate();
            }
            cboLeaderboardTribe.SelectedIndex = 0;
        }



        private void RefreshLeaderboardMissions()
        {
            if (cm == null) return;

            cboLeaderboardMission.Items.Clear();

            cboLeaderboardMission.Items.Add(new ASVComboValue("", "[All Missions]"));

            var leaderboards = cm.GetLeaderboards();
            if (leaderboards != null && leaderboards.Count > 0)
            {

                leaderboards.OrderBy(x => x.MissionTag).ToList().ForEach(x =>
                {
                    cboLeaderboardMission.Items.Add(new ASVComboValue(x.FullTag, x.MissionTag));
                });

                if (cboLeaderboardMission.Items.Count > 0) cboLeaderboardMission.SelectedIndex = 0;
            }
        }


        private void RefreshItemListTribes()
        {
            if (cm == null) return;

            cboItemListTribe.Items.Clear();
            cboItemListTribe.Items.Add(new ASVComboValue("0", "[All Tribes]"));

            cboItemListItem.Items.Clear();
            cboItemListItem.Items.Add(new ASVComboValue("-1", "[Please Select]"));
            cboItemListItem.Items.Add(new ASVComboValue("", "[All Items]"));
            cboItemListItem.SelectedIndex = 0;

            List<ASVComboValue> newItems = new List<ASVComboValue>();

            var tribes = cm.GetTribes(0);

            if (tribes.Count() > 0)
            {

                List<string> playerItems = new List<string>();

                foreach (var tribe in tribes)
                {
                    bool addTribe = true;
                    if (Program.ProgramConfig.HideNoBody)
                    {

                        addTribe = tribe.Players.Count > 0 && !tribe.Players.All(p => (p.Latitude == 0 && p.Longitude == 0));
                    }

                    if (addTribe)
                    {
                        ASVComboValue valuePair = new ASVComboValue(tribe.TribeId.ToString(), tribe.TribeName);
                        newItems.Add(valuePair);
                    }

                    //add items regardless, different search type and want to see them all in this case

                    if (tribe.Structures != null && tribe.Structures.Count > 0)
                    {
                        tribe.Structures.ToList().ForEach(s =>
                        {
                            if (s.Inventory.Items.Count > 0)
                            {
                                var matchedItems = s.Inventory.Items.Where(i => !playerItems.Contains(i.ClassName)).Select(c => c.ClassName).Distinct().ToList();
                                if (matchedItems != null && matchedItems.Count > 0) playerItems.AddRange(matchedItems);
                            }
                        });
                    }

                    if (tribe.Tames != null && tribe.Tames.Count > 0)
                    {
                        tribe.Tames.ToList().ForEach(s =>
                        {
                            if (s.Inventory.Items.Count > 0)
                            {
                                var matchedItems = s.Inventory.Items.Where(i => !playerItems.Contains(i.ClassName)).Select(c => c.ClassName).Distinct().ToList();

                                if (matchedItems != null && matchedItems.Count > 0) playerItems.AddRange(matchedItems);
                            }

                        });
                    }

                    if (tribe.Players != null && tribe.Players.Count > 0)
                    {
                        tribe.Players.ToList().ForEach(s =>
                        {
                            if (s.Inventory.Items.Count > 0)
                            {
                                var matchedItems = s.Inventory.Items.Where(i => !playerItems.Contains(i.ClassName)).Select(c => c.ClassName).Distinct().ToList();

                                if (matchedItems != null && matchedItems.Count > 0) playerItems.AddRange(matchedItems);
                            }

                        });
                    }

                }

                if (playerItems != null && playerItems.Count > 0)
                {
                    List<ASVComboValue> comboItems = new List<ASVComboValue>();
                    playerItems.ForEach(i =>
                    {
                        string displayName = i;

                        var itemMap = Program.ProgramConfig.ItemMap.Find(m => m.ClassName == i);
                        if (itemMap != null) displayName = itemMap.DisplayName;
                        comboItems.Add(new ASVComboValue(i, displayName));

                    });

                    cboItemListItem.Items.AddRange(comboItems.OrderBy(o => o.Value).ToArray());
                }

            }

            if (newItems.Count > 0)
            {
                cboItemListTribe.BeginUpdate();
                foreach (var newItem in newItems.OrderBy(o => o.Value))
                {
                    cboItemListTribe.Items.Add(newItem);
                }

                cboItemListTribe.EndUpdate();
            }

            cboItemListTribe.SelectedIndex = 0;






        }

        private void RefreshTamedTribes()
        {
            if (cm == null) return;

            cboTameTribes.Items.Clear();
            cboTameTribes.Items.Add(new ASVComboValue("0", "[All Tribes]"));

            List<ASVComboValue> newItems = new List<ASVComboValue>();

            var allTribes = cm.GetTribes(0);
            if (allTribes != null && allTribes.Count() > 0)
            {
                foreach (var tribe in allTribes)
                {
                    bool addItem = true;

                    if (Program.ProgramConfig.HideNoTames)
                    {
                        addItem = (
                                    tribe.Tames != null && tribe.Tames.Count > 0
                                  );
                    }

                    if (addItem)
                    {
                        float fromLat = (float)udLatTamed.Value;
                        float fromLon = (float)udLonTamed.Value;
                        float fromRadius = (float)udRadiusTamed.Value;


                        addItem = tribe.Tames.LongCount(w => (
                                        (Math.Abs(w.Latitude.GetValueOrDefault(0) - fromLat) <= fromRadius)
                                        && (Math.Abs(w.Longitude.GetValueOrDefault(0) - fromLon) <= fromRadius)
                                    )) > 0;
                    }

                    if (addItem)
                    {
                        if (tribe.TribeName == null || tribe.TribeName.Length == 0) tribe.TribeName = "[N/A]";
                        ASVComboValue valuePair = new ASVComboValue(tribe.TribeId.ToString(), tribe.TribeName);
                        newItems.Add(valuePair);
                    }
                }
            }


            if (newItems.Count > 0)
            {
                cboTameTribes.BeginUpdate();

                foreach (var newItem in newItems.OrderBy(o => o.Value))
                {
                    cboTameTribes.Items.Add(newItem);
                }

                cboTameTribes.EndUpdate();
            }
            cboTameTribes.SelectedIndex = 0;
        }

        private void RefreshStructureTribes()
        {
            if (cm == null) return;

            cboStructureTribe.Items.Clear();
            cboStructureTribe.Items.Add(new ASVComboValue("0", "[All Tribes]"));

            List<ASVComboValue> newItems = new List<ASVComboValue>();

            var allTribes = cm.GetTribes(0);
            if (allTribes.Count() > 0)
            {
                foreach (var tribe in allTribes)
                {
                    bool addItem = true;
                    if (Program.ProgramConfig.HideNoStructures)
                    {

                        addItem = (
                                    (tribe.Structures != null && tribe.Structures.Count > 0)
                                    ||
                                    (tribe.Tames != null && tribe.Tames.LongCount(w => (w.ClassName == "MotorRaft_BP_C" || w.ClassName == "Raft_BP_C")) > 0)
                                );

                    }

                    if (addItem)
                    {
                        float fromLat = (float)udLatStructures.Value;
                        float fromLon = (float)udLonStructures.Value;
                        float fromRadius = (float)udRadiusStructures.Value;

                        addItem = tribe.Structures.LongCount(w => (
                                        (Math.Abs(w.Latitude.GetValueOrDefault(0) - fromLat) <= fromRadius)
                                        && (Math.Abs(w.Longitude.GetValueOrDefault(0) - fromLon) <= fromRadius)
                                    )) > 0;
                    }


                    if (addItem)
                    {
                        if (tribe.TribeName == null || tribe.TribeName.Length == 0) tribe.TribeName = "[N/A]";
                        ASVComboValue valuePair = new ASVComboValue(tribe.TribeId.ToString(), tribe.TribeName);
                        newItems.Add(valuePair);
                    }
                }
            }
            if (newItems.Count > 0)
            {
                cboStructureTribe.BeginUpdate();

                foreach (var newItem in newItems.OrderBy(o => o.Value))
                {
                    cboStructureTribe.Items.Add(newItem);
                }

                cboStructureTribe.EndUpdate();
            }
            cboStructureTribe.SelectedIndex = 0;
        }

        private void RefreshPaintingTribes()
        {
            if (cm == null) return;

            cboPaintingTribe.Items.Clear();
            cboPaintingTribe.Items.Add(new ASVComboValue("0", "[All Tribes]"));

            List<ASVComboValue> newItems = new List<ASVComboValue>();

            var allTribes = cm.GetTribes(0);
            if (allTribes.Count() > 0)
            {
                foreach (var tribe in allTribes)
                {
                    bool addItem = true;
                    if (Program.ProgramConfig.HideNoStructures)
                    {

                        addItem = (
                                    (tribe.Structures != null && tribe.Structures.Count > 0)
                                    ||
                                    (tribe.Tames != null && tribe.Tames.LongCount(w => (w.ClassName == "MotorRaft_BP_C" || w.ClassName == "Raft_BP_C")) > 0)
                                );

                    }

                    if (addItem)
                    {
                        if (tribe.Structures.Any(s => s.UniquePaintingId != 0))
                        {
                            if (tribe.TribeName == null || tribe.TribeName.Length == 0) tribe.TribeName = "[N/A]";
                            ASVComboValue valuePair = new ASVComboValue(tribe.TribeId.ToString(), tribe.TribeName);
                            newItems.Add(valuePair);

                        }

                    }
                }
            }
            if (newItems.Count > 0)
            {
                cboPaintingTribe.BeginUpdate();

                foreach (var newItem in newItems.OrderBy(o => o.Value))
                {
                    cboPaintingTribe.Items.Add(newItem);
                }

                cboPaintingTribe.EndUpdate();
            }
            cboPaintingTribe.SelectedIndex = 0;
        }

        private void RefreshDroppedPlayers()
        {
            if (cm == null) return;

            cboDroppedPlayer.Items.Clear();
            cboDroppedPlayer.Items.Add(new ASVComboValue("-1", "[None Player]"));
            cboDroppedPlayer.Items.Add(new ASVComboValue("0", "[All Players]"));

            List<ASVComboValue> newItems = new List<ASVComboValue>();

            var allPlayers = cm.GetPlayers(0, 0, "");
            if (allPlayers.Count() > 0)
            {
                foreach (var player in allPlayers)
                {
                    bool addPlayer = true;
                    if (Program.ProgramConfig.HideNoBody)
                    {
                        addPlayer = !(player.Latitude.GetValueOrDefault(0) == 0 && player.Longitude.GetValueOrDefault(0) == 0);
                    }

                    if (addPlayer)
                    {
                        ASVComboValue valuePair = new ASVComboValue(player.Id.ToString(), player.CharacterName != null && player.CharacterName.Length > 0 ? player.CharacterName : player.Name);
                        newItems.Add(valuePair);

                    }
                }
            }

            if (newItems.Count > 0)
            {
                cboDroppedPlayer.BeginUpdate();

                foreach (var newItem in newItems.OrderBy(o => o.Value))
                {
                    cboDroppedPlayer.Items.Add(newItem);
                }

                cboDroppedPlayer.EndUpdate();
            }
            cboDroppedPlayer.SelectedIndex = 0;
        }

        public void RefreshDroppedItems()
        {
            if (cm == null) return;

            cboDroppedItem.Items.Clear();

            List<ASVComboValue> newItems = new List<ASVComboValue>();
            cboDroppedItem.Items.Add(new ASVComboValue() { Key = "0", Value = "[Dropped Items]" });
            cboDroppedItem.Items.Add(new ASVComboValue() { Key = "-1", Value = "[Death Cache]" });

            long playerId = 0;
            if (cboDroppedPlayer.SelectedItem != null)
            {
                var selectedValue = (ASVComboValue)cboDroppedPlayer.SelectedItem;
                long.TryParse(selectedValue.Key, out playerId);
            }

            var droppedItems = cm.GetDroppedItems(playerId, "", (cboDroppedItemRealm.SelectedItem as ASVComboValue)?.Key);
            if (droppedItems != null && droppedItems.Count() > 0)
            {
                //player
                ASVComboValue comboValue = (ASVComboValue)cboDroppedPlayer.SelectedItem;
                int.TryParse(comboValue.Key, out int selectedPlayerId);


                var droppedItemTypes = droppedItems.GroupBy(g => g.ClassName)
                                                         .Select(s => s.Key);


                if (droppedItemTypes != null && droppedItemTypes.Count() > 0)
                {

                    foreach (var className in droppedItemTypes)
                    {
                        var itemName = className;
                        var itemMap = Program.ProgramConfig.ItemMap.Where(i => i.ClassName == className).FirstOrDefault();

                        ASVComboValue classNameItem = new ASVComboValue(className, "");

                        if (itemMap != null && itemMap.DisplayName.Length > 0)
                        {
                            itemName = itemMap.DisplayName;
                            classNameItem.Value = itemName;

                        }

                        if (itemName == null || itemName.Length == 0) itemName = className;

                        newItems.Add(new ASVComboValue() { Key = className, Value = itemName });
                    }


                }



            }

            if (newItems.Count > 0)
            {
                cboDroppedItem.BeginUpdate();
                cboDroppedItem.Items.AddRange(newItems.OrderBy(x => x.Value).ToArray());
                cboDroppedItem.EndUpdate();
            }
            cboDroppedItem.SelectedIndex = 0;
        }

        private void RefreshPlayerList()
        {
            if (cm == null) return;
            if (cboTribes.SelectedItem == null) return;

            btnCopyCommandPlayer.Enabled = false;
            btnRconCommandPlayers.Enabled = false;

            ASVComboValue comboValue = (ASVComboValue)cboTribes.SelectedItem;
            int.TryParse(comboValue.Key, out int selectedTribeId);

            cboPlayers.Items.Clear();
            cboPlayers.Items.Add(new ASVComboValue("0", "[All Players]"));

            List<ASVComboValue> newItems = new List<ASVComboValue>();

            var tribes = cm.GetTribes(selectedTribeId);

            foreach (var tribe in tribes)
            {
                foreach (var player in tribe.Players)
                {
                    bool addPlayer = true;
                    if (Program.ProgramConfig.HideNoBody)
                    {
                        addPlayer = !(player.Latitude.GetValueOrDefault(0) == 0 && player.Longitude.GetValueOrDefault(0) == 0);
                    }

                    if (addPlayer)
                    {
                        ASVComboValue valuePair = new ASVComboValue(player.Id.ToString(), player.CharacterName != null && player.CharacterName.Length > 0 ? player.CharacterName : player.Name);
                        newItems.Add(valuePair);
                    }
                }
            }

            if (newItems.Count > 0)
            {
                cboPlayers.BeginUpdate();
                foreach (var newItem in newItems.OrderBy(o => o.Value))
                {
                    cboPlayers.Items.Add(newItem);
                }
                cboPlayers.EndUpdate();


            }
            cboPlayers.SelectedIndex = 0;
        }

        private void RefreshTamePlayerList()
        {
            if (cm == null) return;
            if (cboTameTribes.SelectedItem == null) return;

            ASVComboValue comboValue = (ASVComboValue)cboTameTribes.SelectedItem;
            int.TryParse(comboValue.Key, out int selectedTribeId);

            cboTamePlayers.Items.Clear();
            cboTamePlayers.Items.Add(new ASVComboValue("0", "[All Players]"));

            List<ASVComboValue> newItems = new List<ASVComboValue>();

            if (selectedTribeId == -1) selectedTribeId = 0;
            var tribes = cm.GetTribes(selectedTribeId);
            foreach (var tribe in tribes)
            {
                foreach (var player in tribe.Players)
                {

                    bool addItem = true;

                    if (Program.ProgramConfig.HideNoTames)
                    {
                        addItem = tribe.Tames != null && tribe.Tames.Count > 0;
                    }

                    float fromLat = (float)udLatTamed.Value;
                    float fromLon = (float)udLonTamed.Value;
                    float fromRadius = (float)udRadiusTamed.Value;


                    if (addItem)
                    {

                        addItem = tribe.Tames.LongCount(w => (
                                        (Math.Abs(w.Latitude.GetValueOrDefault(0) - fromLat) <= fromRadius)
                                        && (Math.Abs(w.Longitude.GetValueOrDefault(0) - fromLon) <= fromRadius)
                                    )) > 0;
                    }


                    if (Program.ProgramConfig.HideNoBody && addItem)
                    {
                        addItem = !(player.Latitude.GetValueOrDefault(0) == 0 && player.Longitude.GetValueOrDefault(0) == 0);
                    }

                    if (addItem)
                    {
                        ASVComboValue valuePair = new ASVComboValue(player.Id.ToString(), player.CharacterName);

                        if (player.CharacterName == null)
                        {

                        }
                        newItems.Add(valuePair);

                    }
                }
            }



            if (newItems.Count > 0)
            {
                cboTamePlayers.BeginUpdate();
                foreach (var newItem in newItems.OrderBy(o => o.Value))
                {
                    cboTamePlayers.Items.Add(newItem);
                }
                cboTamePlayers.EndUpdate();

            }

            if (cboTamePlayers.Items.Count > 0)
            {
                cboTamePlayers.SelectedIndex = 0;
            }


        }

        private void RefreshStructurePlayerList()
        {
            if (cm == null) return;
            if (cboStructureTribe.SelectedItem == null) return;

            ASVComboValue comboValue = (ASVComboValue)cboStructureTribe.SelectedItem;
            int.TryParse(comboValue.Key, out int selectedTribeId);

            cboStructurePlayer.Items.Clear();
            cboStructurePlayer.Items.Add(new ASVComboValue("0", "[All Players]"));

            List<ASVComboValue> newItems = new List<ASVComboValue>();

            if (selectedTribeId == -1) selectedTribeId = 0;
            var tribes = cm.GetTribes(selectedTribeId);
            foreach (var tribe in tribes)
            {

                foreach (var player in tribe.Players)
                {
                    bool addItem = true;

                    if (Program.ProgramConfig.HideNoStructures)
                    {
                        addItem = (
                                    (tribe.Structures != null && tribe.Structures.Count > 0)
                                    ||
                                    (
                                        tribe.Tames != null
                                        && tribe.Tames.LongCount(w => (w.ClassName == "MotorRaft_BP_C" || w.ClassName == "Raft_BP_C")) > 0
                                    )

                                   );
                    }

                    if (Program.ProgramConfig.HideNoBody && addItem)
                    {
                        addItem = !(player.Latitude.GetValueOrDefault(0) == 0 && player.Longitude.GetValueOrDefault(0) == 0);
                    }

                    if (addItem)
                    {
                        float fromLat = (float)udLatTamed.Value;
                        float fromLon = (float)udLonTamed.Value;
                        float fromRadius = (float)udRadiusTamed.Value;


                        addItem = tribe.Structures.LongCount(w => (
                                        (Math.Abs(w.Latitude.GetValueOrDefault(0) - fromLat) <= fromRadius)
                                        && (Math.Abs(w.Longitude.GetValueOrDefault(0) - fromLon) <= fromRadius)
                                    )) > 0;
                    }


                    if (addItem)
                    {




                        ASVComboValue valuePair = new ASVComboValue(player.Id.ToString(), player.CharacterName);
                        newItems.Add(valuePair);

                    }
                }

            }




            if (newItems.Count > 0)
            {
                cboStructurePlayer.BeginUpdate();
                foreach (var newItem in newItems.OrderBy(o => o.Value))
                {
                    cboStructurePlayer.Items.Add(newItem);
                }
                cboStructurePlayer.EndUpdate();

            }

            cboStructurePlayer.SelectedIndex = 0;

        }


        /******** Detail Grids ***********/
        private void LoadPlayerStructureDetail()
        {

            if (cm == null) return;
            if (tabFeatures.SelectedTab.Name != "tpgStructures") return;


            if (cboStructureTribe.SelectedItem == null) return;
            if (cboStructurePlayer.SelectedItem == null) return;

            this.Cursor = Cursors.WaitCursor;

            btnStructureInventory.Enabled = false;
            btnCopyCommandStructure.Enabled = false;
            btnRconCommandStructures.Enabled = false;

            lblStatus.Text = "Updating player structure selection.";
            lblStatus.Refresh();

            //tribe
            long selectedTribeId = 0;
            ASVComboValue comboValue = (ASVComboValue)cboStructureTribe.SelectedItem;
            if (comboValue != null) long.TryParse(comboValue.Key, out selectedTribeId);

            //player
            long selectedPlayerId = 0;
            comboValue = (ASVComboValue)cboStructurePlayer.SelectedItem;
            if (comboValue != null) long.TryParse(comboValue.Key, out selectedPlayerId);

            if (selectedPlayerId > 0 && selectedTribeId == 0)
            {
                var tribe = cm.GetPlayerTribe(selectedPlayerId);
                if (tribe != null) selectedTribeId = tribe.TribeId;
            }

            //structure
            string selectedClass = "NONE";
            comboValue = (ASVComboValue)cboStructureStructure.SelectedItem;
            if (comboValue != null) selectedClass = comboValue.Key;

            float fromLat = (float)udLatStructures.Value;
            float fromLon = (float)udLonStructures.Value;
            float fromRad = (float)udRadiusStructures.Value;


            var playerStructures = cm.GetPlayerStructures(selectedTribeId, selectedPlayerId, selectedClass, false, (cboStructureRealm.SelectedItem as ASVComboValue).Key, fromLat, fromLon, fromRad)
                .Where(s => !Program.ProgramConfig.StructureExclusions.Contains(s.ClassName)).ToList();

            lblStructureTotal.Text = $"Count: {playerStructures.Count()}";
            lblStructureTotal.Refresh();

            lvwStructureLocations.Items.Clear();
            lvwStructureLocations.Refresh();
            lvwStructureLocations.BeginUpdate();

            ConcurrentBag<ListViewItem> listItems = new ConcurrentBag<ListViewItem>();

            string selectedRealm = (cboStructureRealm.SelectedItem as ASVComboValue).Key;

            var tribes = cm.GetTribes(selectedTribeId);
            foreach (var tribe in tribes)
            {
                var filterStructures = tribe.Structures.Where(s =>
                    (s.ClassName == selectedClass || selectedClass == "")
                    &&
                    (
                        (Math.Abs(s.Latitude.GetValueOrDefault(0) - fromLat) <= fromRad)
                        &&
                        (Math.Abs(s.Longitude.GetValueOrDefault(0) - fromLon) <= fromRad)
                    )
                    );
                Parallel.ForEach(filterStructures, playerStructure =>
                {

                    if (!(playerStructure.Latitude.GetValueOrDefault(0) == 0 && playerStructure.Longitude.GetValueOrDefault(0) == 0))
                    {

                        bool addItem = true;

                        if (playerStructure.Longitude.HasValue)
                        {
                            //check realm

                            if (!string.IsNullOrEmpty(selectedRealm))
                            {
                                if (cm.LoadedMap.Regions != null && cm.LoadedMap.Regions.Count > 0)
                                {
                                    var selectedRegion = cm.LoadedMap.Regions.Find(r => r.RegionName == selectedRealm);
                                    addItem = playerStructure.Z >= selectedRegion.ZStart
                                                && playerStructure.Z <= selectedRegion.ZEnd
                                                && playerStructure.Latitude >= selectedRegion.LatitudeStart
                                                && playerStructure.Latitude <= selectedRegion.LatitudeEnd
                                                && playerStructure.Longitude >= selectedRegion.LongitudeStart
                                                && playerStructure.Longitude <= selectedRegion.LongitudeEnd;


                                }

                            }


                        }

                        if (addItem)
                        {
                            var tribeName = tribe.TribeName;

                            var itemName = playerStructure.ClassName;
                            var itemMap = ARKViewer.Program.ProgramConfig.StructureMap.Where(i => i.ClassName == playerStructure.ClassName).FirstOrDefault();
                            if (itemMap != null && itemMap.FriendlyName.Length > 0)
                            {
                                itemName = itemMap.FriendlyName;
                            }

                            ListViewItem newItem = new ListViewItem(tribeName);
                            newItem.SubItems.Add(itemName);


                            newItem.SubItems.Add(playerStructure.Latitude.Value.ToString("0.00"));
                            newItem.SubItems.Add(playerStructure.Longitude.Value.ToString("0.00"));
                            newItem.SubItems.Add(playerStructure.DisplayName == playerStructure.ClassName ? "" : playerStructure.DisplayName);

                            if (playerStructure.IsLocked.HasValue)
                            {
                                newItem.SubItems.Add(playerStructure.IsLocked.Value ? "Yes" : "No");
                            }
                            else
                            {
                                newItem.SubItems.Add("");
                            }


                            if (playerStructure.IsSwitchedOn.HasValue)
                            {
                                newItem.SubItems.Add(playerStructure.IsSwitchedOn.Value ? "Yes" : "No");
                            }
                            else
                            {
                                newItem.SubItems.Add("");
                            }
                            newItem.SubItems.Add(playerStructure.CreatedDateTime?.ToString("dd MMM yyyy HH:mm"));
                            newItem.SubItems.Add(playerStructure.LastAllyInRangeTime?.ToString("dd MMM yyyy HH:mm"));
                            newItem.SubItems.Add(playerStructure.HasDecayTimeReset ? "Yes" : "No");
                            newItem.SubItems.Add($"{playerStructure.X} {playerStructure.Y} {playerStructure.Z}");
                            newItem.Tag = playerStructure;

                            listItems.Add(newItem);
                        }

                    }


                });

            }

            lvwStructureLocations.Items.AddRange(listItems.ToArray());

            if (SortingColumn_Structures != null)
            {
                lvwStructureLocations.ListViewItemSorter =
                    new ListViewComparer(SortingColumn_Structures.Index, SortingColumn_Structures.Text.Contains(">") ? SortOrder.Ascending : SortOrder.Descending);

                // Sort.
                lvwStructureLocations.Sort();
            }

            lvwStructureLocations.EndUpdate();
            lblStatus.Text = "Player structure selection updated.";
            lblStatus.Refresh();

            DrawMap(0, 0);

            this.Cursor = Cursors.Default;
        }


        private void LoadUploadedCharacters()
        {
            lvwUploadedCharacters.BeginUpdate();
            lvwUploadedCharacters.Items.Clear();


            //Name, Sex, Lvl, Hp, Stam, Melee, Weight, Speed, Food, Water, Oxygen, Crafting, Fortitude

            ConcurrentBag<ListViewItem> listItems = new ConcurrentBag<ListViewItem>();

            foreach (var player in cm.GetUploadedCharacters())
            {

                ListViewItem newItem = new ListViewItem(player.CharacterName);
                newItem.SubItems.Add(player.Gender.ToString());
                newItem.SubItems.Add(player.Level.ToString());


                //0=health
                //1=stamina
                //2=torpor
                //3=oxygen
                //4=food
                //5=water
                //6=temperature
                //7=weight
                //8=melee damage
                //9=movement speed
                //10=fortitude
                //11=crafting speed

                newItem.SubItems.Add(player.Stats.GetValue(0).ToString()); //hp
                newItem.SubItems.Add(player.Stats.GetValue(1).ToString()); //stam
                newItem.SubItems.Add(player.Stats.GetValue(8).ToString()); //melee
                newItem.SubItems.Add(player.Stats.GetValue(7).ToString()); //weight
                newItem.SubItems.Add(player.Stats.GetValue(9).ToString()); //speed
                newItem.SubItems.Add(player.Stats.GetValue(4).ToString()); //food
                newItem.SubItems.Add(player.Stats.GetValue(5).ToString()); //water
                newItem.SubItems.Add(player.Stats.GetValue(3).ToString()); //oxygen
                newItem.SubItems.Add(player.Stats.GetValue(11).ToString());//crafting
                newItem.SubItems.Add(player.Stats.GetValue(10).ToString());//fortitude
                newItem.Tag = player;

                listItems.Add(newItem);

            }




            lvwUploadedCharacters.Items.AddRange(listItems.ToArray());
            lvwUploadedCharacters.EndUpdate();

            lblUploadedCountCharacters.Text = $"Count: {listItems.Count}";

        }
        private void LoadUploadedTames()
        {
            lvwUploadedTames.BeginUpdate();
            lvwUploadedTames.Items.Clear();


            //Creature, Name, Sex, Base, Lvl, Hp, Stam, Melee, Weight, Speed, Food, Oxygen, Craft, Imprinter, Imprint, C0, C1, C2, C3, C4, C5, Muf (F), Mut (M), Rig1, Rig2

            ConcurrentBag<ListViewItem> listItems = new ConcurrentBag<ListViewItem>();

            foreach (var detail in cm.GetUploadedTames())
            {

                var dinoMap = ARKViewer.Program.ProgramConfig.DinoMap.Where(dino => dino.ClassName == detail.ClassName).FirstOrDefault();

                string creatureClassName = dinoMap == null ? detail.ClassName : dinoMap.FriendlyName;
                string creatureName = dinoMap == null ? detail.ClassName : dinoMap.FriendlyName;

                if (detail.Name != null)
                {
                    creatureName = detail.Name;
                }

                if (creatureName.ToLower().Contains("queen"))
                {
                    detail.Gender = "Female";
                }

                ListViewItem item = new ListViewItem(creatureClassName);
                item.Tag = detail;
                item.UseItemStyleForSubItems = false;

                item.SubItems.Add(creatureName);
                item.SubItems.Add(detail.Gender.ToString());
                item.SubItems.Add(detail.BaseLevel.ToString());
                item.SubItems.Add(detail.Level.ToString());

                if (optUploadedStatsTamed.Checked)
                {
                    item.SubItems.Add(detail.TamedStats[0].ToString());
                    item.SubItems.Add(detail.TamedStats[1].ToString());
                    item.SubItems.Add(detail.TamedStats[8].ToString());
                    item.SubItems.Add(detail.TamedStats[7].ToString());
                    item.SubItems.Add(detail.TamedStats[9].ToString());
                    item.SubItems.Add(detail.TamedStats[4].ToString());
                    item.SubItems.Add(detail.TamedStats[3].ToString());
                    item.SubItems.Add(detail.TamedStats[11].ToString());

                }
                else
                {
                    item.SubItems.Add(detail.BaseStats[0].ToString());
                    item.SubItems.Add(detail.BaseStats[1].ToString());
                    item.SubItems.Add(detail.BaseStats[8].ToString());
                    item.SubItems.Add(detail.BaseStats[7].ToString());
                    item.SubItems.Add(detail.BaseStats[9].ToString());
                    item.SubItems.Add(detail.BaseStats[4].ToString());
                    item.SubItems.Add(detail.BaseStats[3].ToString());
                    item.SubItems.Add(detail.BaseStats[11].ToString());
                }
                item.SubItems.Add(detail.ImprinterName);
                item.SubItems.Add((detail.ImprintQuality * 100).ToString("f0"));

                //Colours
                int colourCheck = (int)detail.Colors[0];
                item.SubItems.Add(colourCheck == 0 ? "n/a" : detail.Colors[0].ToString()); //14
                ColourMap selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[0]).FirstOrDefault();
                if (selectedColor != null && selectedColor.Hex.Length > 0)
                {
                    item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                    item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                }

                colourCheck = (int)detail.Colors[1];
                item.SubItems.Add(colourCheck == 0 ? "n/a" : detail.Colors[1].ToString()); //15
                selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[1]).FirstOrDefault();
                if (selectedColor != null && selectedColor.Hex.Length > 0)
                {
                    item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                    item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                }

                colourCheck = (int)detail.Colors[2];
                item.SubItems.Add(colourCheck == 0 ? "n/a" : detail.Colors[2].ToString()); //16
                selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[2]).FirstOrDefault();
                if (selectedColor != null && selectedColor.Hex.Length > 0)
                {
                    item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                    item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                }

                colourCheck = (int)detail.Colors[3];
                item.SubItems.Add(colourCheck == 0 ? "n/a" : detail.Colors[3].ToString()); //17
                selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[3]).FirstOrDefault();
                if (selectedColor != null && selectedColor.Hex.Length > 0)
                {
                    item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                    item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                }

                colourCheck = (int)detail.Colors[4];
                item.SubItems.Add(colourCheck == 0 ? "n/a" : detail.Colors[4].ToString()); //18
                selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[4]).FirstOrDefault();
                if (selectedColor != null && selectedColor.Hex.Length > 0)
                {
                    item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                    item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                }

                colourCheck = (int)detail.Colors[5];
                item.SubItems.Add(colourCheck == 0 ? "n/a" : detail.Colors[5].ToString()); //19
                selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[5]).FirstOrDefault();
                if (selectedColor != null && selectedColor.Hex.Length > 0)
                {
                    item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                    item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                }


                //mutations
                item.SubItems.Add(detail.RandomMutationsFemale.ToString());
                item.SubItems.Add(detail.RandomMutationsMale.ToString());

                string rig1Name = Program.ProgramConfig.ItemMap.Find(x => x.ClassName == detail.Rig1)?.DisplayName ?? detail.Rig1;
                string rig2Name = Program.ProgramConfig.ItemMap.Find(x => x.ClassName == detail.Rig2)?.DisplayName ?? detail.Rig2;
                item.SubItems.Add(rig1Name);
                item.SubItems.Add(rig2Name);

                listItems.Add(item);

            }




            lvwUploadedTames.Items.AddRange(listItems.ToArray());



            lvwUploadedTames.EndUpdate();

            lblUploadedCountTames.Text = $"Count: {listItems.Count}";
        }
        private void LoadUploadedItems()
        {

        }

        private void LoadItemListDetail()
        {
            if (cm == null) return;

            if (tabFeatures.SelectedTab.Name != "tpgItemList") return;


            if (cboItemListTribe.SelectedItem == null) return;
            if (cboItemListItem.SelectedItem == null) return;


            this.Cursor = Cursors.WaitCursor;
            lblStatus.Text = "Searching inventories....";
            lblStatus.Refresh();

            lvwItemList.BeginUpdate();
            lvwItemList.Items.Clear();

            int.TryParse(((ASVComboValue)cboItemListTribe.SelectedItem).Key, out int selectedTribeId);
            string selectedItemClass = ((ASVComboValue)cboItemListItem.SelectedItem).Key;

            List<ListViewItem> newItems = new List<ListViewItem>();
            var foundItems = cm.GetItems(selectedTribeId, selectedItemClass, "", txtItemListItemId.Text.Trim());

            if (cboItemListFilter.SelectedIndex != 0)
            {
                switch (cboItemListFilter.SelectedIndex)
                {
                    case 1:
                        //normal
                        foundItems.RemoveAll(x => x.IsBlueprint || x.UploadedTime.HasValue);
                        break;
                    case 2:
                        //blueprint
                        foundItems.RemoveAll(x => !x.IsBlueprint);
                        break;
                    case 3:
                        //uploaded
                        foundItems.RemoveAll(x => !x.UploadedTime.HasValue);
                        break;
                }
            }

            if (cboItemListPlayers.SelectedIndex > 0)
            {
                ASVComboValue selectedPlayer = cboItemListPlayers.SelectedItem as ASVComboValue;
                foundItems.RemoveAll(r => r.PlayerId.ToString() != selectedPlayer.Key);
            }

            if (foundItems != null && foundItems.Count > 0)
            {
                foreach (var foundItem in foundItems)
                {
                    //if (chkItemSearchBlueprints.Checked || !chkItemSearchBlueprints.Checked & !foundItem.IsBlueprint)
                    {
                        string qualityName = "";
                        Color backColor = lvwItemList.BackColor;
                        Color foreColor = lvwItemList.ForeColor;
                        if (foundItem.Rating.HasValue)
                        {
                            var itemQuality = Program.GetQualityByRating(foundItem.Rating.Value);
                            qualityName = itemQuality.QualityName;
                            backColor = itemQuality.QualityColor;
                            foreColor = Program.IdealTextColor(backColor);
                        }

                        ListViewItem newItem = new ListViewItem(foundItem.TribeName);

                        newItem.BackColor = backColor;
                        newItem.ForeColor = foreColor;

                        newItem.SubItems.Add(foundItem.ContainerName);
                        newItem.SubItems.Add(foundItem.PlayerName);
                        newItem.SubItems.Add(foundItem.DisplayName);
                        newItem.SubItems.Add(qualityName);
                        newItem.SubItems.Add(foundItem.Rating.HasValue ? foundItem.Rating.Value.ToString() : "");
                        newItem.SubItems.Add(foundItem.IsBlueprint ? "Yes" : "No");
                        newItem.SubItems.Add(foundItem.Quantity.ToString());
                        newItem.SubItems.Add(foundItem.Latitude.ToString("f2"));
                        newItem.SubItems.Add(foundItem.Longitude.ToString("f2"));
                        newItem.SubItems.Add($"{foundItem?.X} {foundItem?.Y} {foundItem?.Z}");
                        if (foundItem.UploadedTime.HasValue)
                        {
                            newItem.SubItems.Add($"{foundItem.UploadedTime.Value.ToString("dd MMM yyyy HH:mm")}");
                        }
                        else
                        {
                            newItem.SubItems.Add($"");
                        }

                        newItem.SubItems.Add(foundItem.ItemId.ToString());
                        newItem.Tag = foundItem;
                        newItems.Add(newItem);

                    }
                }
            }

            if (newItems.Count > 0) lvwItemList.Items.AddRange(newItems.ToArray());

            lvwItemList.EndUpdate();


            lblStatus.Text = "Search results populated.";
            lblStatus.Refresh();

            lblItemListCount.Text = $"Count: {lvwItemList.Items.Count}";

            if (tabFeatures.SelectedTab.Name == "tpgItemList")
            {
                DrawMap(0, 0);
            }

            if (SortingColumn_ItemList != null)
            {
                lvwItemList.ListViewItemSorter =
                    new ListViewComparer(SortingColumn_ItemList.Index, SortingColumn_ItemList.Text.Contains(">") ? SortOrder.Ascending : SortOrder.Descending);

                // Sort.
                lvwItemList.Sort();
            }

            this.Cursor = Cursors.Default;


        }

        private void LoadPlayerDetail()
        {
            if (cm == null) return;

            if (tabFeatures.SelectedTab.Name != "tpgPlayers") return;


            if (cboTribes.SelectedItem == null) return;
            if (cboPlayers.SelectedItem == null) return;


            btnPlayerInventory.Enabled = false;

            //tribe
            ASVComboValue comboValue = (ASVComboValue)cboTribes.SelectedItem;
            int.TryParse(comboValue.Key, out int selectedTribeId);

            //player
            comboValue = (ASVComboValue)cboPlayers.SelectedItem;
            int.TryParse(comboValue.Key, out int selectedPlayerId);

            lvwPlayers.Items.Clear();
            lvwPlayers.Refresh();
            lvwPlayers.BeginUpdate();

            //Name, sex, lvl, lat, lon, hp, stam, melee, weight, speed, food,water, oxy, last on
            ConcurrentBag<ListViewItem> listItems = new ConcurrentBag<ListViewItem>();
            var tribes = cm.GetTribes(selectedTribeId);

            foreach (var tribe in tribes)
            {
                var tribePlayers = tribe.Players.Where(p => p.Id == selectedPlayerId || selectedPlayerId == 0).ToList();

                foreach (var player in tribePlayers)
                {
                    bool addPlayer = true;
                    if (Program.ProgramConfig.HideNoBody)
                    {
                        addPlayer = !(player.Longitude.GetValueOrDefault(0) == 0 && player.Latitude.GetValueOrDefault(0) == 0);
                    }


                    if (player.Longitude.HasValue)
                    {
                        //check realm
                        string selectedRealm = (cboPlayerRealm.SelectedItem as ASVComboValue).Key;
                        if (!string.IsNullOrEmpty(selectedRealm))
                        {
                            if (cm.LoadedMap.Regions != null && cm.LoadedMap.Regions.Count > 0)
                            {
                                var selectedRegion = cm.LoadedMap.Regions.Find(r => r.RegionName == selectedRealm);
                                addPlayer = player.Z >= selectedRegion.ZStart
                                            && player.Z <= selectedRegion.ZEnd
                                            && player.Latitude >= selectedRegion.LatitudeStart
                                            && player.Latitude <= selectedRegion.LatitudeEnd
                                            && player.Longitude >= selectedRegion.LongitudeStart
                                            && player.Longitude <= selectedRegion.LongitudeEnd;


                            }

                        }


                    }

                    if (addPlayer)
                    {
                        ListViewItem newItem = new ListViewItem(player.Id.ToString());
                        newItem.SubItems.Add(player.CharacterName);
                        newItem.SubItems.Add(tribe.TribeName);

                        newItem.SubItems.Add(player.Gender.ToString());
                        newItem.SubItems.Add(player.Level.ToString());

                        if (!(player.Longitude == 0 && player.Latitude == 0))
                        {
                            newItem.SubItems.Add(player?.Latitude.GetValueOrDefault(0).ToString("0.00"));
                            newItem.SubItems.Add(player?.Longitude.GetValueOrDefault(0).ToString("0.00"));

                        }
                        else
                        {
                            newItem.SubItems.Add("n/a");
                            newItem.SubItems.Add("n/a");
                        }

                        //0=health
                        //1=stamina
                        //2=torpor
                        //3=oxygen
                        //4=food
                        //5=water
                        //6=temperature
                        //7=weight
                        //8=melee damage
                        //9=movement speed
                        //10=fortitude
                        //11=crafting speed

                        newItem.SubItems.Add(player.Stats.GetValue(0).ToString()); //hp
                        newItem.SubItems.Add(player.Stats.GetValue(1).ToString()); //stam
                        newItem.SubItems.Add(player.Stats.GetValue(8).ToString()); //melee
                        newItem.SubItems.Add(player.Stats.GetValue(7).ToString()); //weight
                        newItem.SubItems.Add(player.Stats.GetValue(9).ToString()); //speed
                        newItem.SubItems.Add(player.Stats.GetValue(4).ToString()); //food
                        newItem.SubItems.Add(player.Stats.GetValue(5).ToString()); //water
                        newItem.SubItems.Add(player.Stats.GetValue(3).ToString()); //oxygen
                        newItem.SubItems.Add(player.Stats.GetValue(11).ToString());//crafting
                        newItem.SubItems.Add(player.Stats.GetValue(10).ToString());//fortitude


                        newItem.SubItems.Add((!player.LastActiveDateTime.HasValue || player.LastActiveDateTime.Value == DateTime.MinValue) ? "n/a" : player.LastActiveDateTime.Value.ToString("dd MMM yy HH:mm:ss"));
                        newItem.SubItems.Add(player.Name);
                        newItem.SubItems.Add(player.NetworkId);
                        newItem.SubItems.Add($"{player?.X} {player?.Y} {player?.Z}");
                        newItem.Tag = player;


                        listItems.Add(newItem);
                    }
                }

            }


            lvwPlayers.Items.AddRange(listItems.ToArray());

            if (SortingColumn_Players != null)
            {
                lvwPlayers.ListViewItemSorter =
                    new ListViewComparer(SortingColumn_Players.Index, SortingColumn_Players.Text.Contains(">") ? SortOrder.Ascending : SortOrder.Descending);

                // Sort.
                lvwPlayers.Sort();
            }

            lvwPlayers.EndUpdate();
            lblPlayerTotal.Text = $"Count: {lvwPlayers.Items.Count}";
            DrawMap(0, 0);

        }

        private void LoadDroppedItemDetail()
        {
            if (cm == null)
            {
                return;
            }

            if (tabFeatures.SelectedTab.Name != "tpgDroppedItems") return;

            this.Cursor = Cursors.WaitCursor;
            lblStatus.Text = "Populating dropped item data.";
            lblStatus.Refresh();

            lvwDroppedItems.BeginUpdate();
            lvwDroppedItems.Items.Clear();

            //player
            ASVComboValue comboValue = (ASVComboValue)cboDroppedPlayer.SelectedItem;
            int.TryParse(comboValue.Key, out int selectedPlayerId);

            string selectedClass = "NONE";
            comboValue = (ASVComboValue)cboDroppedItem.SelectedItem;
            selectedClass = comboValue.Key;

            ConcurrentBag<ListViewItem> listItems = new ConcurrentBag<ListViewItem>();


            //tribe name
            string tribeName = "n/a";
            string playerName = "n/a";
            if (selectedPlayerId > 0)
            {
                var tribe = cm.GetPlayerTribe(selectedPlayerId);
                tribeName = tribe.TribeName;
                playerName = tribe.Players.First(p => p.Id == selectedPlayerId).CharacterName;
            }

            if (selectedClass == "DeathItemCache_PlayerDeath_C" || selectedClass == "-1")
            {

                var deadBags = cm.GetDeathCacheBags(selectedPlayerId);
                Parallel.ForEach(deadBags, playerCache =>
                {
                    string itemName = "Player Cache";

                    //get tribe/player
                    var playerTribe = cm.GetPlayerTribe(playerCache.DroppedByPlayerId);
                    if (playerTribe != null)
                    {
                        var player = playerTribe.Players.First(p => p.Id == playerCache.DroppedByPlayerId);
                        tribeName = playerTribe.TribeName;
                        playerName = player.CharacterName;
                    }

                    ListViewItem newItem = new ListViewItem(itemName);
                    newItem.Tag = playerCache;
                    newItem.SubItems.Add("No");
                    newItem.SubItems.Add(playerCache.DroppedByName);
                    newItem.SubItems.Add((playerCache.Latitude.GetValueOrDefault(0) == 0 && playerCache.Longitude.GetValueOrDefault(0) == 0) ? "n/a" : playerCache.Latitude.Value.ToString("0.00"));
                    newItem.SubItems.Add((playerCache.Latitude.GetValueOrDefault(0) == 0 && playerCache.Longitude.GetValueOrDefault(0) == 0) ? "n/a" : playerCache.Longitude.Value.ToString("0.00"));
                    newItem.SubItems.Add(tribeName);
                    newItem.SubItems.Add(playerName);
                    newItem.SubItems.Add($"{playerCache?.X} {playerCache?.Y} {playerCache?.Z}");


                    listItems.Add(newItem);

                });

            }
            else
            {

                var droppedItems = cm.GetDroppedItems(selectedPlayerId, selectedClass == "0" ? "" : selectedClass, (cboDroppedItemRealm.SelectedItem as ASVComboValue).Key).ToList();

                if (droppedItems != null)
                {

                    Parallel.ForEach(droppedItems, droppedItem =>
                    {
                        if (chkDroppedBlueprints.Checked || !chkDroppedBlueprints.Checked & !droppedItem.IsBlueprint)
                        {
                            string itemName = droppedItem.ClassName;
                            ItemClassMap itemMap = Program.ProgramConfig.ItemMap.Where(m => m.ClassName == droppedItem.ClassName).FirstOrDefault();
                            if (itemMap != null)
                            {
                                itemName = itemMap.DisplayName;
                            }

                            //get tribe/player
                            var playerTribe = cm.GetPlayerTribe(droppedItem.DroppedByPlayerId);
                            if (playerTribe != null)
                            {
                                var player = playerTribe.Players.First(p => p.Id == droppedItem.DroppedByPlayerId);
                                tribeName = playerTribe.TribeName;
                                playerName = player.CharacterName;
                            }

                            ListViewItem newItem = new ListViewItem(itemName);
                            newItem.Tag = droppedItem;
                            newItem.SubItems.Add(droppedItem.IsBlueprint ? "Yes" : "No");
                            newItem.SubItems.Add(droppedItem.DroppedByName);
                            newItem.SubItems.Add((droppedItem.Latitude.GetValueOrDefault(0) == 0 && droppedItem.Longitude.GetValueOrDefault(0) == 0) ? "n/a" : droppedItem.Latitude.Value.ToString("0.00"));
                            newItem.SubItems.Add((droppedItem.Latitude.GetValueOrDefault(0) == 0 && droppedItem.Longitude.GetValueOrDefault(0) == 0) ? "n/a" : droppedItem.Longitude.Value.ToString("0.00"));
                            newItem.SubItems.Add(tribeName);
                            newItem.SubItems.Add(playerName);
                            listItems.Add(newItem);
                        }

                    });
                }
            }

            lvwDroppedItems.Items.AddRange(listItems.ToArray());


            if (SortingColumn_Drops != null)
            {
                lvwDroppedItems.ListViewItemSorter =
                    new ListViewComparer(SortingColumn_Drops.Index, SortingColumn_Drops.Text.Contains(">") ? SortOrder.Ascending : SortOrder.Descending);

                // Sort.
                lvwDroppedItems.Sort();
            }

            lvwDroppedItems.EndUpdate();
            lblStatus.Text = "Dropped item data populated.";
            lblStatus.Refresh();

            lblCountDropped.Text = $"Count: {lvwDroppedItems.Items.Count}";

            if (tabFeatures.SelectedTab.Name == "tpgDroppedItems")
            {
                DrawMap(0, 0);
            }


            this.Cursor = Cursors.Default;
        }

        private void LoadTameDetail()
        {
            if (cm == null)
            {
                return;
            }

            if (tabFeatures.SelectedTab.Name != "tpgTamed") return;

            this.Cursor = Cursors.WaitCursor;
            lblStatus.Text = "Populating tame data.";
            lblStatus.Refresh();

            float selectedX = 0;
            float selectedY = 0;

            if (cboTameClass.SelectedItem != null)
            {
                ASVCreatureSummary selectedSummary = (ASVCreatureSummary)cboTameClass.SelectedItem;

                long selectedId = 0;
                if (lvwTameDetail.SelectedItems.Count > 0)
                {
                    long.TryParse(lvwTameDetail.SelectedItems[0].Tag.ToString(), out selectedId);
                }
                lvwTameDetail.BeginUpdate();
                lvwTameDetail.Items.Clear();

                string className = selectedSummary.ClassName;

                //tribe
                int selectedTribeId = 0;
                int selectedPlayerId = 0;

                if (cboTameTribes.SelectedItem != null)
                {
                    ASVComboValue comboValue = (ASVComboValue)cboTameTribes.SelectedItem;
                    int.TryParse(comboValue.Key, out selectedTribeId);

                }

                //player
                if (cboTamePlayers.SelectedItem != null)
                {
                    ASVComboValue comboValue = (ASVComboValue)cboTamePlayers.SelectedItem;
                    int.TryParse(comboValue.Key, out selectedPlayerId);
                }

                float fromLat = (float)udLatTamed.Value;
                float fromLon = (float)udLonTamed.Value;
                float fromRadius = (float)udRadiusTamed.Value;

                var tribes = cm.GetTribes(selectedTribeId);
                var detailList = tribes.SelectMany(t => t.Tames
                    .Where(x =>
                        (x.ClassName == className || className == "")
                        & !(x.ClassName == "MotorRaft_BP_C" || x.ClassName == "Raft_BP_C")
                        && (x.TargetingTeam == selectedTribeId || x.TargetingTeam > 0 && x.TargetingTeam < 2000000000 && selectedTribeId == 0)
                        &&
                        (
                            (Math.Abs(x.Latitude.GetValueOrDefault(0) - fromLat) <= fromRadius)
                            &&
                            (Math.Abs(x.Longitude.GetValueOrDefault(0) - fromLon) <= fromRadius)
                        )
                    )).DistinctBy(u => new { u.DinoId, u.Latitude, u.Longitude, u.Name, u.Level }).ToList();

                if(cboTameFilter.SelectedIndex > 0)
                {
                    switch (cboTameFilter.SelectedIndex)
                    {
                        case 1:
                            //only normal
                            detailList.RemoveAll(d => d.UploadedTime.HasValue || d.IsCryo || d.IsVivarium);

                            break;

                        case 2:
                            //only stored
                            detailList.RemoveAll(d => !(d.IsCryo || d.IsVivarium));

                            break;

                        case 3:
                            //only uploads
                            detailList.RemoveAll(d => !d.UploadedTime.HasValue );

                            break;
                    }
                }

                if (cboTamedResource.SelectedIndex > 0)
                {
                    //limit by resource production
                    ASVComboValue selectedResourceValue = (ASVComboValue)cboTamedResource.SelectedItem;
                    string selectedResourceClass = selectedResourceValue.Key;
                    detailList.RemoveAll(d => d.ProductionResources == null || !d.ProductionResources.Any(r => r == selectedResourceClass));
                }


                if (cboTamedTrait.SelectedIndex != 0)
                {
                    //limit by resource production
                    ASVComboValue selectedTraitValue = (ASVComboValue)cboTamedTrait.SelectedItem;
                    detailList.RemoveAll(d => d.Traits.Count == 0 || !d.Traits.Any(r => r.StartsWith(selectedTraitValue.Key)));
                }



                string selectedRealm = (cboTameRealm.SelectedItem as ASVComboValue).Key;


                //change into a strongly typed list for use in parallel
                ConcurrentBag<ListViewItem> listItems = new ConcurrentBag<ListViewItem>();
                //Parallel.ForEach(detailList, detail =>
                foreach (var detail in detailList)
                {
                    var dinoMap = ARKViewer.Program.ProgramConfig.DinoMap.Where(dino => dino.ClassName == detail.ClassName).FirstOrDefault();

                    string creatureClassName = dinoMap == null ? detail.ClassName : dinoMap.FriendlyName;
                    string creatureName = dinoMap == null ? detail.ClassName : dinoMap.FriendlyName;

                    if (detail.Name != null)
                    {
                        creatureName = detail.Name;
                    }

                    if (creatureName.ToLower().Contains("queen"))
                    {
                        detail.Gender = "Female";
                    }


                    bool addItem = true;

                    if (detail.Longitude.HasValue)
                    {
                        //check realm

                        if (!string.IsNullOrEmpty(selectedRealm))
                        {
                            if (cm.LoadedMap.Regions != null && cm.LoadedMap.Regions.Count > 0)
                            {
                                var selectedRegion = cm.LoadedMap.Regions.Find(r => r.RegionName == selectedRealm);
                                addItem = detail.Z >= selectedRegion.ZStart
                                            && detail.Z <= selectedRegion.ZEnd
                                            && detail.Latitude >= selectedRegion.LatitudeStart
                                            && detail.Latitude <= selectedRegion.LatitudeEnd
                                            && detail.Longitude >= selectedRegion.LongitudeStart
                                            && detail.Longitude <= selectedRegion.LongitudeEnd;


                            }

                        }


                    }

                    if (addItem)
                    {
                        string tribeName = detail.TribeName ?? "";
                        if (tribeName.Length == 0)
                        {
                            var matchedTribe = tribes.Find(t => t.TribeId == detail.TargetingTeam);
                            if (matchedTribe != null)
                            {
                                tribeName = matchedTribe.TribeName;
                            }
                        }


                        ListViewItem item = new ListViewItem(tribeName);
                        item.Tag = detail;
                        item.UseItemStyleForSubItems = false;

                        item.SubItems.Add(creatureClassName);
                        item.SubItems.Add(creatureName);


                        item.SubItems.Add(detail.Gender.ToString());
                        item.SubItems.Add(detail.Maturation.ToString("f1"));
                        item.SubItems.Add(detail.BaseLevel.ToString());
                        item.SubItems.Add(detail.Level.ToString());
                        item.SubItems.Add(((decimal)(detail.Latitude.GetValueOrDefault(0))).ToString("0.00"));
                        item.SubItems.Add(((decimal)(detail.Longitude.GetValueOrDefault(0))).ToString("0.00"));

                        if (optStatsMutated.Checked)
                        {
                            if (detail.TamedMutations != null)
                            {
                                item.SubItems.Add(detail.TamedMutations[0].ToString());
                                item.SubItems.Add(detail.TamedMutations[1].ToString());
                                item.SubItems.Add(detail.TamedMutations[8].ToString());
                                item.SubItems.Add(detail.TamedMutations[7].ToString());
                                item.SubItems.Add(detail.TamedMutations[9].ToString());
                                item.SubItems.Add(detail.TamedMutations[4].ToString());
                                item.SubItems.Add(detail.TamedMutations[3].ToString());
                                item.SubItems.Add(detail.TamedMutations[11].ToString());

                            }
                            else
                            {
                                item.SubItems.Add("0");
                                item.SubItems.Add("0");
                                item.SubItems.Add("0");
                                item.SubItems.Add("0");
                                item.SubItems.Add("0");
                                item.SubItems.Add("0");
                                item.SubItems.Add("0");
                                item.SubItems.Add("0");
                                item.SubItems.Add("0");

                            }

                        }
                        else if (optStatsTamed.Checked)
                        {
                            item.SubItems.Add(detail.TamedStats[0].ToString());
                            item.SubItems.Add(detail.TamedStats[1].ToString());
                            item.SubItems.Add(detail.TamedStats[8].ToString());
                            item.SubItems.Add(detail.TamedStats[7].ToString());
                            item.SubItems.Add(detail.TamedStats[9].ToString());
                            item.SubItems.Add(detail.TamedStats[4].ToString());
                            item.SubItems.Add(detail.TamedStats[3].ToString());
                            item.SubItems.Add(detail.TamedStats[11].ToString());

                        }
                        else if (optStatsBase.Checked)
                        {
                            item.SubItems.Add(detail.BaseStats[0].ToString());
                            item.SubItems.Add(detail.BaseStats[1].ToString());
                            item.SubItems.Add(detail.BaseStats[8].ToString());
                            item.SubItems.Add(detail.BaseStats[7].ToString());
                            item.SubItems.Add(detail.BaseStats[9].ToString());
                            item.SubItems.Add(detail.BaseStats[4].ToString());
                            item.SubItems.Add(detail.BaseStats[3].ToString());
                            item.SubItems.Add(detail.BaseStats[11].ToString());

                        }

                        item.SubItems.Add(detail.TamedOnServerName);

                        string tamerName = detail.TamerName != null ? detail.TamerName : "";
                        string imprinterName = detail.ImprinterName;
                        if (tamerName.Length == 0)
                        {
                            if (detail.ImprintedPlayerId != 0)
                            {
                                //var tamer = cm.GetPlayers(0, detail.ImprintedPlayerId).FirstOrDefault<ContentPlayer>();
                                //if(tamer!=null) tamerName = tamer.CharacterName;
                            }
                            else
                            {
                                tamerName = detail.TribeName;
                            }
                        }



                        item.SubItems.Add(tamerName);
                        item.SubItems.Add(detail.ImprinterName);
                        item.SubItems.Add((detail.ImprintQuality * 100).ToString("f0"));



                        item.SubItems.Add(detail.IsMating ? "Yes" : "No");
                        item.SubItems.Add(detail.IsWandering ? "Yes" : "No");
                        item.SubItems.Add(detail.IsNeutered ? "Yes" : "No");


                        bool isStored = detail.IsCryo | detail.IsVivarium;

                        item.SubItems.Add(isStored ? "Yes" : "No");
                        item.SubItems.Add(detail.IsClone ? "Yes" : "No");

                        if (detail.IsCryo)
                        {

                            item.BackColor = Color.FromArgb(Program.ProgramConfig.HighlightColorCryopod);
                            item.ForeColor = Program.IdealTextColor(item.BackColor);
                            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                            {
                                subItem.BackColor = Color.FromArgb(Program.ProgramConfig.HighlightColorCryopod);
                                subItem.ForeColor = Program.IdealTextColor(subItem.BackColor);

                            }
                        }

                        if (detail.IsVivarium)
                        {

                            item.BackColor = Color.FromArgb(Program.ProgramConfig.HighlightColorVivarium);
                            item.ForeColor = Program.IdealTextColor(item.BackColor);
                            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                            {
                                subItem.BackColor = Color.FromArgb(Program.ProgramConfig.HighlightColorVivarium);
                                subItem.ForeColor = Program.IdealTextColor(subItem.BackColor);

                            }
                        }

                        if (detail.UploadedTime.HasValue)
                        {
                            item.BackColor = Color.FromArgb(Program.ProgramConfig.HighlightColorUploaded);
                            item.ForeColor = Program.IdealTextColor(item.BackColor);
                            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                            {
                                subItem.BackColor = Color.FromArgb(Program.ProgramConfig.HighlightColorUploaded);
                                subItem.ForeColor = Program.IdealTextColor(subItem.BackColor);
                            }
                        }

                        //Colours
                        int colourCheck = (int)detail.Colors[0];
                        item.SubItems.Add(colourCheck == 0 ? "n/a" : detail.Colors[0].ToString()); //14
                        ColourMap selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[0]).FirstOrDefault();
                        if (selectedColor != null && selectedColor.Hex.Length > 0)
                        {
                            item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                            item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                        }

                        colourCheck = (int)detail.Colors[1];
                        item.SubItems.Add(colourCheck == 0 ? "n/a" : detail.Colors[1].ToString()); //15
                        selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[1]).FirstOrDefault();
                        if (selectedColor != null && selectedColor.Hex.Length > 0)
                        {
                            item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                            item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                        }

                        colourCheck = (int)detail.Colors[2];
                        item.SubItems.Add(colourCheck == 0 ? "n/a" : detail.Colors[2].ToString()); //16
                        selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[2]).FirstOrDefault();
                        if (selectedColor != null && selectedColor.Hex.Length > 0)
                        {
                            item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                            item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                        }

                        colourCheck = (int)detail.Colors[3];
                        item.SubItems.Add(colourCheck == 0 ? "n/a" : detail.Colors[3].ToString()); //17
                        selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[3]).FirstOrDefault();
                        if (selectedColor != null && selectedColor.Hex.Length > 0)
                        {
                            item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                            item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                        }

                        colourCheck = (int)detail.Colors[4];
                        item.SubItems.Add(colourCheck == 0 ? "n/a" : detail.Colors[4].ToString()); //18
                        selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[4]).FirstOrDefault();
                        if (selectedColor != null && selectedColor.Hex.Length > 0)
                        {
                            item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                            item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                        }

                        colourCheck = (int)detail.Colors[5];
                        item.SubItems.Add(colourCheck == 0 ? "n/a" : detail.Colors[5].ToString()); //19
                        selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[5]).FirstOrDefault();
                        if (selectedColor != null && selectedColor.Hex.Length > 0)
                        {
                            item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                            item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                        }


                        //mutations
                        item.SubItems.Add(detail.RandomMutationsFemale.ToString());
                        item.SubItems.Add(detail.RandomMutationsMale.ToString());

                        item.SubItems.Add(detail.Id.ToString());
                        item.SubItems.Add(Math.Round(detail.WildScale, 1).ToString("f1"));
                        item.SubItems.Add(detail?.Traits.Count.ToString() ?? "");

                        string rig1Name = Program.ProgramConfig.ItemMap.Find(x => x.ClassName == detail.Rig1)?.DisplayName ?? detail.Rig1;
                        string rig2Name = Program.ProgramConfig.ItemMap.Find(x => x.ClassName == detail.Rig2)?.DisplayName ?? detail.Rig2;
                        item.SubItems.Add(rig1Name);
                        item.SubItems.Add(rig2Name);
                        item.SubItems.Add(detail.LastAllyInRangeTime.HasValue ? detail.LastAllyInRangeTime.Value.ToString("dd MMM yyyy HH:mm") : "");
                        if (detail.UploadedTime.HasValue)
                        {
                            item.SubItems.Add($"{detail.UploadedTime.Value.ToString("dd MMM yyyy HH:mm")}");
                        }
                        else
                        {
                            item.SubItems.Add($"");
                        }
                        item.SubItems.Add(detail.DinoId);


                        item.SubItems.Add($"{detail.X} {detail.Y} {detail.Z}");



                        if (detail.Id == selectedId)
                        {

                            item.Selected = true;
                            selectedX = (float)detail.Longitude;
                            selectedY = (float)detail.Latitude;
                        }

                        listItems.Add(item);
                    }

                }
                //);

                lvwTameDetail.Items.AddRange(listItems.ToArray());

                if (SortingColumn_DetailTame != null)
                {
                    lvwTameDetail.ListViewItemSorter =
                        new ListViewComparer(SortingColumn_DetailTame.Index, SortingColumn_DetailTame.Text.Contains(">") ? SortOrder.Ascending : SortOrder.Descending);

                    // Sort.
                    lvwTameDetail.Sort();
                }
                else
                {

                    SortingColumn_DetailTame = lvwTameDetail.Columns[0]; ;
                    SortingColumn_DetailTame.Text = "> " + SortingColumn_DetailTame.Text;

                    lvwTameDetail.ListViewItemSorter =
                        new ListViewComparer(0, SortOrder.Ascending);

                    // Sort.
                    lvwTameDetail.Sort();
                }


                lvwTameDetail.EndUpdate();

                lblStatus.Text = "Tame data populated.";
                lblStatus.Refresh();
                lblTameTotal.Text = $"Count: {lvwTameDetail.Items.Count}";


                if (tabFeatures.SelectedTab.Name == "tpgTamed")
                {
                    DrawMap(selectedX, selectedY);
                }


            }



            this.Cursor = Cursors.Default;

        }


        private void LoadWildDetail()
        {
            if (cm == null)
            {
                return;
            }

            if (tabFeatures.SelectedTab.Name != "tpgWild") return;

            this.Cursor = Cursors.WaitCursor;
            lblStatus.Text = "Populating creature data.";
            lblStatus.Refresh();

            float selectedX = 0;
            float selectedY = 0;

            if (cboWildClass.SelectedItem != null)
            {
                ASVCreatureSummary selectedSummary = (ASVCreatureSummary)cboWildClass.SelectedItem;

                long selectedId = 0;
                if (lvwWildDetail.SelectedItems.Count > 0)
                {
                    long.TryParse(lvwWildDetail.SelectedItems[0].Tag.ToString(), out selectedId);
                }
                lvwWildDetail.BeginUpdate();
                lvwWildDetail.Items.Clear();

                string className = selectedSummary.ClassName;

                int minLevel = (int)udWildMin.Value;
                int maxLevel = (int)udWildMax.Value;
                float selectedLat = (float)udWildLat.Value;
                float selectedLon = (float)udWildLon.Value;
                float selectedRad = (float)udWildRadius.Value;

                var detailList = cm.GetWildCreatures(minLevel, maxLevel, selectedLat, selectedLon, selectedRad, className, (cboWildRealm.SelectedItem as ASVComboValue).Key).OrderByDescending(c => c.BaseLevel).ToList();
                if (cboWildResource.SelectedIndex != 0)
                {
                    //limit by resource production
                    ASVComboValue selectedResourceValue = (ASVComboValue)cboWildResource.SelectedItem;
                    string selectedResourceClass = selectedResourceValue.Key;
                    detailList.RemoveAll(d => d.ProductionResources == null || !d.ProductionResources.Any(r => r == selectedResourceClass));
                }

                if (cboWildTrait.SelectedIndex != 0)
                {
                    //limit by resource production
                    ASVComboValue selectedTraitValue = (ASVComboValue)cboWildTrait.SelectedItem;
                    detailList.RemoveAll(d => d.Traits.Count == 0 || !d.Traits.Any(r => r.StartsWith(selectedTraitValue.Key)));
                }

                ConcurrentBag<ListViewItem> listItems = new ConcurrentBag<ListViewItem>();

                Parallel.ForEach(detailList, detail =>
                //foreach(var detail in CollectionsMarshal.AsSpan(detailList)) 
                {
                    var dinoMap = ARKViewer.Program.ProgramConfig.DinoMap.Where(dino => dino.ClassName == detail.ClassName).FirstOrDefault();
                    string creatureName = dinoMap == null ? detail.ClassName : dinoMap.FriendlyName;



                    ListViewItem item = new ListViewItem(creatureName);//lvwWildDetail.Items.Add(creatureName);
                    item.Tag = detail;
                    item.UseItemStyleForSubItems = false;

                    if (creatureName.ToLower().Contains("queen"))
                    {
                        detail.Gender = "Female";
                    }


                    item.SubItems.Add(detail.Gender.ToString());
                    item.SubItems.Add(detail.Maturation.ToString("f1"));

                    item.SubItems.Add(detail.BaseLevel.ToString());
                    item.SubItems.Add(detail.BaseLevel.ToString());
                    item.SubItems.Add(((decimal)detail.Latitude).ToString("0.00"));
                    item.SubItems.Add(((decimal)detail.Longitude).ToString("0.00"));

                    item.SubItems.Add(detail.BaseStats[0].ToString());
                    item.SubItems.Add(detail.BaseStats[1].ToString());
                    item.SubItems.Add(detail.BaseStats[8].ToString());
                    item.SubItems.Add(detail.BaseStats[7].ToString());
                    item.SubItems.Add(detail.BaseStats[9].ToString());
                    item.SubItems.Add(detail.BaseStats[4].ToString());
                    item.SubItems.Add(detail.BaseStats[3].ToString());
                    item.SubItems.Add(detail.BaseStats[11].ToString());



                    int colourCheck = (int)detail.Colors[0];
                    item.SubItems.Add(colourCheck == 0 ? "N/A" : detail.Colors[0].ToString()); //14
                    ColourMap selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[0]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                        item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                    }

                    colourCheck = (int)detail.Colors[1];
                    item.SubItems.Add(colourCheck == 0 ? "N/A" : detail.Colors[1].ToString()); //15
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[1]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                        item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                    }

                    colourCheck = (int)detail.Colors[2];
                    item.SubItems.Add(colourCheck == 0 ? "N/A" : detail.Colors[2].ToString()); //16
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[2]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                        item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                    }

                    colourCheck = (int)detail.Colors[3];
                    item.SubItems.Add(colourCheck == 0 ? "N/A" : detail.Colors[3].ToString()); //17
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[3]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                        item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                    }

                    colourCheck = (int)detail.Colors[4];
                    item.SubItems.Add(colourCheck == 0 ? "N/A" : detail.Colors[4].ToString()); //18
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[4]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                        item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                    }

                    colourCheck = (int)detail.Colors[5];
                    item.SubItems.Add(colourCheck == 0 ? "N/A" : detail.Colors[5].ToString()); //19
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)detail.Colors[5]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        item.SubItems[item.SubItems.Count - 1].BackColor = selectedColor.Color;
                        item.SubItems[item.SubItems.Count - 1].ForeColor = Program.IdealTextColor(selectedColor.Color);
                    }

                    item.SubItems.Add(detail.Id.ToString());
                    item.SubItems.Add(Math.Round(detail.WildScale, 1).ToString("f1"));
                    item.SubItems.Add(detail.Traits.FirstOrDefault() ?? "");

                    string rig1Name = Program.ProgramConfig.ItemMap.Find(x => x.ClassName == detail.Rig1)?.DisplayName ?? detail.Rig1;
                    string rig2Name = Program.ProgramConfig.ItemMap.Find(x => x.ClassName == detail.Rig2)?.DisplayName ?? detail.Rig2;
                    item.SubItems.Add(rig1Name);
                    item.SubItems.Add(rig2Name);
                    item.SubItems.Add(detail.DinoId);

                    item.SubItems.Add($"{detail.X} {detail.Y} {detail.Z}");

                    if (detail.Id == selectedId)
                    {

                        item.Selected = true;
                        selectedX = (float)Math.Round(detail.Longitude.Value, 2);
                        selectedY = (float)Math.Round(detail.Latitude.Value, 2);
                    }

                    if ((chkTameable.Checked && detail.IsTameable) || !chkTameable.Checked)
                    {
                        listItems.Add(item);
                    }

                }
                );

                lvwWildDetail.Items.AddRange(listItems.ToArray());

                // Create a comparer.
                if (SortingColumn_DetailWild != null)
                {
                    lvwWildDetail.ListViewItemSorter =
                        new ListViewComparer(SortingColumn_DetailWild.Index, SortingColumn_DetailWild.Text.Contains(">") ? SortOrder.Ascending : SortOrder.Descending);

                    // Sort.
                    lvwWildDetail.Sort();
                }
                else
                {

                    SortingColumn_DetailWild = lvwWildDetail.Columns[3]; ;
                    SortingColumn_DetailWild.Text = "< " + SortingColumn_DetailWild.Text;

                    lvwWildDetail.ListViewItemSorter =
                        new ListViewComparer(3, SortOrder.Descending);

                    // Sort.
                    lvwWildDetail.Sort();

                }

                lvwWildDetail.EndUpdate();

                lblSelectedWildTotal.Text = "Count: " + lvwWildDetail.Items.Count.ToString();

                lblStatus.Text = "Creature data populated.";
                lblStatus.Refresh();

                if (tabFeatures.SelectedTab.Name == "tpgWild")
                {
                    DrawMap(selectedX, selectedY);

                }


            }

            this.Cursor = Cursors.Default;

        }

        private void btmMissionScoreboard_Click(object sender, EventArgs e)
        {

        }

        private void chkItemSearchBlueprints_CheckedChanged(object sender, EventArgs e)
        {
            //chkItemSearchBlueprints.BackgroundImage = chkItemSearchBlueprints.Checked ? Properties.Resources.blueprints : Properties.Resources.blueprints_unchecked;
            LoadItemListDetail();
        }

        private void chkDroppedBlueprints_CheckedChanged(object sender, EventArgs e)
        {
            chkDroppedBlueprints.BackgroundImage = chkDroppedBlueprints.Checked ? Properties.Resources.blueprints : Properties.Resources.blueprints_unchecked;
            LoadDroppedItemDetail();
        }

        private void lvwItemList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwItemList.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_ItemList == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_ItemList)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_ItemList.Text.StartsWith("> "))
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
                SortingColumn_ItemList.Text = SortingColumn_ItemList.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_ItemList = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_ItemList.Text = "> " + SortingColumn_ItemList.Text;
            }
            else
            {
                SortingColumn_ItemList.Text = "< " + SortingColumn_ItemList.Text;
            }

            // Create a comparer.
            lvwItemList.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwItemList.Sort();
        }

        private void cboTamedResource_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboTameClass.Items.Count > 1 && cboTamedResource.SelectedIndex > 0)
            {
                if (cboTameClass.SelectedIndex != 1)
                {
                    cboTameClass.SelectedIndex = 1;
                }
                else
                {
                    LoadTameDetail();
                }
            }
            else
            {
                LoadTameDetail();
            }
        }

        private void udChartTopPlayers_ValueChanged(object sender, EventArgs e)
        {
            DrawTribeChartPlayers();
        }

        private void udChartTopStructures_ValueChanged(object sender, EventArgs e)
        {
            DrawTribeChartStructures();
        }

        private void udChartTopTames_ValueChanged(object sender, EventArgs e)
        {
            DrawTribeChartTames();
        }

        private void btnSaveChartPlayers_Click(object sender, EventArgs e)
        {




            //btnSaveChartPlayers.Enabled = false;
            //this.Cursor = Cursors.WaitCursor;

            //using(SaveFileDialog dialog = new SaveFileDialog())
            //{
            //    dialog.Filter = "PNG Image File (*.png)|*.png";
            //    dialog.AddExtension = true;
            //    dialog.Title = "Save chart image";
            //    if(dialog.ShowDialog() == DialogResult.OK)
            //    {
            //        string imageFilename = dialog.FileName;
            //        string imageFolder = Path.GetDirectoryName(imageFilename);
            //        if (!Directory.Exists(imageFolder)) Directory.CreateDirectory(imageFolder);
            //        chartTribePlayers.SaveChart(dialog.FileName, 1024, 1024);

            //        MessageBox.Show("Chart image saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}

            //this.Cursor = Cursors.Default;
            //btnSaveChartPlayers.Enabled = true;
        }

        private void btnSaveChartStructures_Click(object sender, EventArgs e)
        {

            //var chart = chartTribeStructures;
            //btnSaveChartStructures.Enabled = false;
            //this.Cursor = Cursors.WaitCursor;

            //using (SaveFileDialog dialog = new SaveFileDialog())
            //{
            //    dialog.Filter = "PNG Image File (*.png)|*.png";
            //    dialog.AddExtension = true;
            //    dialog.Title = "Save chart image";
            //    if (dialog.ShowDialog() == DialogResult.OK)
            //    {
            //        //ensure directory exists
            //        string imageFilename = dialog.FileName;
            //        string imageFolder = Path.GetDirectoryName(imageFilename);
            //        if (!Directory.Exists(imageFolder)) Directory.CreateDirectory(imageFolder);
            //        chartTribeStructures.SaveChart(dialog.FileName, 1024, 1024);


            //        MessageBox.Show("Chart image saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}

            //this.Cursor = Cursors.Default;

            //btnSaveChartStructures.Enabled = true;


        }

        private void btnSaveChartTames_Click(object sender, EventArgs e)
        {

            //var chart = chartTribeTames;
            //btnSaveChartTames.Enabled = false;
            //this.Cursor = Cursors.WaitCursor;

            //using (SaveFileDialog dialog = new SaveFileDialog())
            //{
            //    dialog.Filter = "PNG Image File (*.png)|*.png";
            //    dialog.AddExtension = true;
            //    dialog.Title = "Save chart image";
            //    if (dialog.ShowDialog() == DialogResult.OK)
            //    {
            //        string imageFilename = dialog.FileName;
            //        string imageFolder = Path.GetDirectoryName(imageFilename);
            //        if (!Directory.Exists(imageFolder)) Directory.CreateDirectory(imageFolder);
            //        chartTribePlayers.SaveChart(dialog.FileName, 1024, 1024);

            //        MessageBox.Show("Chart image saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}

            //this.Cursor = Cursors.Default;
            //btnSaveChartTames.Enabled = true;

        }

        private void FindNextWild()
        {
            string searchString = txtFilterWild.Text.Trim().ToLower();
            int currentItemIndex = -1;
            int maxItemIndex = lvwWildDetail.Items.Count - 1;
            if (lvwWildDetail.SelectedItems.Count > 0) currentItemIndex = lvwWildDetail.SelectedItems[0].Index;

            for (int nextIndex = currentItemIndex + 1; nextIndex <= maxItemIndex; nextIndex++)
            {
                bool searchFound = lvwWildDetail.Items[nextIndex].SubItems.Cast<ListViewItem.ListViewSubItem>().Any(x => x.Text.ToLower().Contains(searchString));

                var wildCreature = lvwWildDetail.Items[nextIndex].Tag as ContentWildCreature;
                if (wildCreature.DinoId == searchString) searchFound = true;

                if (searchFound)
                {
                    lvwWildDetail.SelectedItems.Clear();
                    lvwWildDetail.Items[nextIndex].Selected = true;
                    lvwWildDetail.EnsureVisible(nextIndex);
                    break;
                }
            }

        }

        private void FindNextTamed()
        {
            string searchString = txtFilterTamed.Text.Trim().ToLower();
            int currentItemIndex = -1;
            int maxItemIndex = lvwTameDetail.Items.Count - 1;

            if (lvwTameDetail.SelectedItems.Count > 0) currentItemIndex = lvwTameDetail.SelectedItems[0].Index;


            for (int nextIndex = currentItemIndex + 1; nextIndex <= maxItemIndex; nextIndex++)
            {
                bool searchFound = lvwTameDetail.Items[nextIndex].SubItems.Cast<ListViewItem.ListViewSubItem>().Any(x => x.Text.ToLower().Contains(searchString));

                var tamedDino = lvwTameDetail.Items[nextIndex].Tag as ContentTamedCreature;
                if (tamedDino.DinoId == searchString) searchFound = true;


                if (searchFound)
                {
                    lvwTameDetail.SelectedItems.Clear();
                    lvwTameDetail.Items[nextIndex].Selected = true;
                    lvwTameDetail.EnsureVisible(nextIndex);
                    break;
                }
            }

        }

        private void FindNextStructure()
        {
            string searchString = txtFilterStructures.Text.Trim().ToLower();
            int currentItemIndex = 0;
            int maxItemIndex = lvwStructureLocations.Items.Count - 1;
            if (lvwStructureLocations.SelectedItems.Count > 0) currentItemIndex = lvwStructureLocations.SelectedItems[0].Index;

            for (int nextIndex = currentItemIndex + 1; nextIndex <= maxItemIndex; nextIndex++)
            {
                bool searchFound = lvwStructureLocations.Items[nextIndex].SubItems.Cast<ListViewItem.ListViewSubItem>().Any(x => x.Text.ToLower().Contains(searchString));
                if (searchFound)
                {
                    lvwStructureLocations.SelectedItems.Clear();
                    lvwStructureLocations.Items[nextIndex].Selected = true;
                    lvwStructureLocations.EnsureVisible(nextIndex);
                    break;
                }
            }

        }

        private void FindNextDropped()
        {
            string searchString = txtFilterDropped.Text.Trim().ToLower();
            int currentItemIndex = 0;
            int maxItemIndex = lvwDroppedItems.Items.Count - 1;
            if (lvwDroppedItems.SelectedItems.Count > 0) currentItemIndex = lvwDroppedItems.SelectedItems[0].Index;

            for (int nextIndex = currentItemIndex + 1; nextIndex <= maxItemIndex; nextIndex++)
            {
                bool searchFound = lvwDroppedItems.Items[nextIndex].SubItems.Cast<ListViewItem.ListViewSubItem>().Any(x => x.Text.ToLower().Contains(searchString));
                if (searchFound)
                {
                    lvwDroppedItems.SelectedItems.Clear();
                    lvwDroppedItems.Items[nextIndex].Selected = true;
                    lvwDroppedItems.EnsureVisible(nextIndex);
                    break;
                }
            }

        }

        private void FindNextSearched()
        {
            string searchString = txtFilterSearch.Text.Trim().ToLower();
            int currentItemIndex = 0;
            int maxItemIndex = lvwItemList.Items.Count - 1;
            if (lvwItemList.SelectedItems.Count > 0) currentItemIndex = lvwItemList.SelectedItems[0].Index;

            for (int nextIndex = currentItemIndex + 1; nextIndex <= maxItemIndex; nextIndex++)
            {
                bool searchFound = lvwItemList.Items[nextIndex].SubItems.Cast<ListViewItem.ListViewSubItem>().Any(x => x.Text.ToLower().Contains(searchString));
                if (searchFound)
                {
                    lvwItemList.SelectedItems.Clear();
                    lvwItemList.Items[nextIndex].Selected = true;
                    lvwItemList.EnsureVisible(nextIndex);
                    break;
                }
            }

        }

        private void FindNextPlayer()
        {
            string searchString = txtFilterPlayer.Text.Trim().ToLower();
            int currentItemIndex = 0;
            int maxItemIndex = lvwPlayers.Items.Count - 1;
            if (lvwPlayers.SelectedItems.Count > 0) currentItemIndex = lvwPlayers.SelectedItems[0].Index;

            for (int nextIndex = currentItemIndex + 1; nextIndex <= maxItemIndex; nextIndex++)
            {
                bool searchFound = lvwPlayers.Items[nextIndex].SubItems.Cast<ListViewItem.ListViewSubItem>().Any(x => x.Text.ToLower().Contains(searchString));
                if (searchFound)
                {
                    lvwPlayers.SelectedItems.Clear();
                    lvwPlayers.Items[nextIndex].Selected = true;
                    lvwPlayers.EnsureVisible(nextIndex);
                    break;
                }
            }

        }

        private void FindNextTribe()
        {
            string searchString = txtFilterTribe.Text.Trim().ToLower();
            int currentItemIndex = 0;
            int maxItemIndex = lvwTribes.Items.Count - 1;
            if (lvwTribes.SelectedItems.Count > 0) currentItemIndex = lvwTribes.SelectedItems[0].Index;

            for (int nextIndex = currentItemIndex + 1; nextIndex <= maxItemIndex; nextIndex++)
            {
                bool searchFound = lvwTribes.Items[nextIndex].SubItems.Cast<ListViewItem.ListViewSubItem>().Any(x => x.Text.ToLower().Contains(searchString));
                if (searchFound)
                {
                    lvwTribes.SelectedItems.Clear();
                    lvwTribes.Items[nextIndex].Selected = true;
                    lvwTribes.EnsureVisible(nextIndex);
                    break;
                }
            }

        }

        private void txtFilterWild_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Return)
            {
                FindNextWild();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void txtFilterTamed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Return)
            {
                FindNextTamed();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void txtFilterStructures_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Return)
            {
                FindNextStructure();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void txtFilterDropped_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Return)
            {
                FindNextDropped();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void txtFilterSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Return)
            {
                FindNextSearched();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnFindTamed_Click(object sender, EventArgs e)
        {
            FindNextTamed();
        }

        private void btnFindStructures_Click(object sender, EventArgs e)
        {
            FindNextStructure();
        }

        private void btnFindDropped_Click(object sender, EventArgs e)
        {
            FindNextDropped();
        }

        private void btnFindSearched_Click(object sender, EventArgs e)
        {
            FindNextSearched();
        }

        private void btnFilterPlayer_Click(object sender, EventArgs e)
        {
            FindNextPlayer();
        }

        private void txtFilterPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Return)
            {
                FindNextPlayer();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void mnuContext_Structures_Click(object sender, EventArgs e)
        {
            long selectedTribeId = 0;


            switch (tabFeatures.SelectedTab.Name)
            {
                case "tpgTribes":
                    if (lvwTribes.SelectedItems.Count > 0)
                    {
                        ContentTribe selectedTribe = (ContentTribe)lvwTribes.SelectedItems[0].Tag;
                        selectedTribeId = selectedTribe.TribeId;
                    }
                    break;
                case "tpgTamed":
                    if (lvwTameDetail.SelectedItems.Count > 0)
                    {
                        ContentTamedCreature selectedTame = (ContentTamedCreature)lvwTameDetail.SelectedItems[0].Tag;
                        selectedTribeId = selectedTame.TargetingTeam;
                    }
                    break;
                case "tpgPlayers":
                    if (lvwPlayers.SelectedItems.Count > 0)
                    {
                        ContentPlayer selectedPlayer = (ContentPlayer)lvwPlayers.SelectedItems[0].Tag;
                        selectedTribeId = selectedPlayer.TargetingTeam;
                    }
                    break;
            }

            if (selectedTribeId != 0)
            {
                tabFeatures.SelectTab("tpgStructures");
                var foundTribe = cboStructureTribe.Items.Cast<ASVComboValue>().ToList().Find(x => x.Key == selectedTribeId.ToString());
                if (foundTribe != null) cboStructureTribe.SelectedItem = foundTribe;
            }

        }

        private void mnuContext_Tames_Click(object sender, EventArgs e)
        {
            long selectedTribeId = 0;


            switch (tabFeatures.SelectedTab.Name)
            {
                case "tpgTribes":
                    if (lvwTribes.SelectedItems.Count > 0)
                    {
                        ContentTribe selectedTribe = (ContentTribe)lvwTribes.SelectedItems[0].Tag;
                        selectedTribeId = selectedTribe.TribeId;
                    }
                    break;
                case "tpgStructures":
                    if (lvwStructureLocations.SelectedItems.Count > 0)
                    {
                        ContentStructure selectedTame = (ContentStructure)lvwStructureLocations.SelectedItems[0].Tag;
                        selectedTribeId = selectedTame.TargetingTeam;
                    }
                    break;
                case "tpgPlayers":
                    if (lvwPlayers.SelectedItems.Count > 0)
                    {
                        ContentPlayer selectedPlayer = (ContentPlayer)lvwPlayers.SelectedItems[0].Tag;
                        selectedTribeId = selectedPlayer.TargetingTeam;
                    }
                    break;
            }

            if (selectedTribeId != 0)
            {
                tabFeatures.SelectTab("tpgTamed");
                var foundTribe = cboTameTribes.Items.Cast<ASVComboValue>().FirstOrDefault(x => x.Key == selectedTribeId.ToString());
                if (foundTribe != null) cboTameTribes.SelectedItem = foundTribe;
            }
        }

        private void mnuContext_Players_Click(object sender, EventArgs e)
        {
            long selectedTribeId = 0;


            switch (tabFeatures.SelectedTab.Name)
            {
                case "tpgTribes":
                    if (lvwTribes.SelectedItems.Count > 0)
                    {
                        ContentTribe selectedTribe = (ContentTribe)lvwTribes.SelectedItems[0].Tag;
                        selectedTribeId = selectedTribe.TribeId;
                    }
                    break;
                case "tpgStructures":
                    if (lvwStructureLocations.SelectedItems.Count > 0)
                    {
                        ContentStructure selectedStructure = (ContentStructure)lvwStructureLocations.SelectedItems[0].Tag;
                        selectedTribeId = selectedStructure.TargetingTeam;
                    }
                    break;
                case "tpgTamed":
                    if (lvwTameDetail.SelectedItems.Count > 0)
                    {
                        ContentTamedCreature selectedTame = (ContentTamedCreature)lvwTameDetail.SelectedItems[0].Tag;
                        selectedTribeId = selectedTame.TargetingTeam;
                    }
                    break;
            }

            if (selectedTribeId != 0)
            {
                tabFeatures.SelectTab("tpgPlayers");
                var foundTribe = cboTribes.Items.Cast<ASVComboValue>().FirstOrDefault(x => x.Key == selectedTribeId.ToString());
                if (foundTribe != null) cboTribes.SelectedItem = foundTribe;
            }
        }

        private void btnFilterTribe_Click(object sender, EventArgs e)
        {
            FindNextTribe();
        }

        private void txtFilterTribe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Return)
            {
                FindNextTribe();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnMyData_Click(object sender, EventArgs e)
        {




        }

        private void optStatsTamed_CheckedChanged(object sender, EventArgs e)
        {
            if (optStatsTamed.Checked)
            {
                LoadTameDetail();
            }
        }

        private void optUploadedStatsBase_CheckedChanged(object sender, EventArgs e)
        {
            LoadUploadedTames();
        }

        private void cboLeaderboardTribe_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLeaderboardPlayers();
        }


        private void LoadLeaderboardPlayers()
        {
            if (tabFeatures.SelectedTab.Name != "tpgLeaderboard") return;
            if (cm == null) return;

            int selectedTribeId = 0;
            if (cboLeaderboardTribe.SelectedIndex > 0)
            {
                ASVComboValue selectedValue = (ASVComboValue)cboLeaderboardTribe.SelectedItem;
                int.TryParse(selectedValue.Key, out selectedTribeId);
            }

            lvwLeaderboardSummary.Items.Clear();
            cboLeaderboardPlayer.Items.Clear();
            cboLeaderboardPlayer.Items.Add("[All Tribe Players]");

            //tribe, player, mission count
            var leaderboards = cm.GetLeaderboards();
            if (leaderboards != null && leaderboards.Count > 0)
            {
                var playerSummary = leaderboards
                .SelectMany(x => x.Scores)
                .Where(x => x.TargetingTeam > 0 && (x.TargetingTeam == selectedTribeId || selectedTribeId == 0))
                .GroupBy(x => new { TribeId = x.TargetingTeam, x.NetworkId, x.PlayerName })
                .Select(x => new
                {
                    x.Key.TribeId,
                    x.Key.PlayerName,
                    MissionCount = x.ToList().Count
                }).ToList();

                if (playerSummary != null && playerSummary.Count > 0)
                {
                    foreach (var player in playerSummary)
                    {
                        string tribeName = "";
                        var tribe = cm.GetTribes(player.TribeId).FirstOrDefault();
                        if (tribe != null)
                        {
                            tribeName = tribe.TribeName;
                        }

                        ListViewItem newItem = new ListViewItem(tribeName);
                        newItem.SubItems.Add(player.PlayerName);
                        newItem.SubItems.Add(player.MissionCount.ToString());
                        lvwLeaderboardSummary.Items.Add(newItem);

                        cboLeaderboardPlayer.Items.Add(player.PlayerName);
                    }
                }
            }


            cboLeaderboardPlayer.SelectedIndex = 0;



        }

        private void LoadLeaderboardScores()
        {
            if (tabFeatures.SelectedTab.Name != "tpgLeaderboard") return;

            //mission, tribe, player, score
            int selectedTribeId = 0;
            string selectedMission = "";
            string selectedPlayer = "";

            if (cboLeaderboardPlayer.SelectedIndex > 0) selectedPlayer = cboLeaderboardPlayer.SelectedItem.ToString();

            if (cboLeaderboardTribe.SelectedIndex > 0)
            {
                ASVComboValue selectedValue = (ASVComboValue)cboLeaderboardTribe.SelectedItem;
                int.TryParse(selectedValue.Key, out selectedTribeId);
            }
            if (cboLeaderboardMission.SelectedIndex > 0)
            {
                ASVComboValue selectedValue = (ASVComboValue)cboLeaderboardMission.SelectedItem;
                selectedMission = selectedValue.Key;
            }

            lvwLeaderboard.Items.Clear();

            //mission, tribe, player, score
            var leaderboards = cm.GetLeaderboards()
                .Where(x => x.FullTag == selectedMission || selectedMission == "")
                .Where(x => x.Scores.Any(y => y.TargetingTeam == selectedTribeId || selectedTribeId == 0))
                .SelectMany(x => x.Scores)
                .Where(x => x.TargetingTeam > 0)
                .ToList();

            if (leaderboards != null)
            {
                foreach (var leaderboard in leaderboards)
                {
                    if (selectedPlayer == "" || selectedPlayer.ToLower() == leaderboard.PlayerName.ToLower())
                    {
                        string tribeName = "";
                        var tribe = cm.GetTribes(leaderboard.TargetingTeam).FirstOrDefault();
                        if (tribe != null)
                        {
                            tribeName = tribe.TribeName;
                        }
                        ListViewItem newItem = new ListViewItem(leaderboard.MissionTag);
                        newItem.SubItems.Add(tribeName);
                        newItem.SubItems.Add(leaderboard.PlayerName);
                        newItem.SubItems.Add(leaderboard.HighScore.ToString());
                        lvwLeaderboard.Items.Add(newItem);
                    }
                }
            }

        }

        private void cboLeaderboardMission_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLeaderboardScores();
        }

        private void lvwUploadedCharacters_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwUploadedCharacters.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_UploadedChar == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_UploadedChar)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_UploadedChar.Text.StartsWith("> "))
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
                SortingColumn_UploadedChar.Text = SortingColumn_UploadedChar.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_UploadedChar = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_UploadedChar.Text = "> " + SortingColumn_UploadedChar.Text;
            }
            else
            {
                SortingColumn_UploadedChar.Text = "< " + SortingColumn_UploadedChar.Text;
            }

            // Create a comparer.
            lvwUploadedCharacters.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwUploadedCharacters.Sort();
        }

        private void lvwUploadedTames_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwUploadedTames.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_UploadedTame == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_UploadedTame)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_UploadedTame.Text.StartsWith("> "))
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
                SortingColumn_UploadedTame.Text = SortingColumn_UploadedTame.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_UploadedTame = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_UploadedTame.Text = "> " + SortingColumn_UploadedTame.Text;
            }
            else
            {
                SortingColumn_UploadedTame.Text = "< " + SortingColumn_UploadedTame.Text;
            }

            // Create a comparer.
            lvwUploadedTames.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwUploadedTames.Sort();
        }

        private void lvwUploadedItems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwUploadedItems.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_UploadedItem == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_UploadedItem)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_UploadedItem.Text.StartsWith("> "))
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
                SortingColumn_UploadedItem.Text = SortingColumn_UploadedItem.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_UploadedItem = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_UploadedItem.Text = "> " + SortingColumn_UploadedItem.Text;
            }
            else
            {
                SortingColumn_UploadedItem.Text = "< " + SortingColumn_UploadedItem.Text;
            }

            // Create a comparer.
            lvwUploadedItems.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwUploadedItems.Sort();
        }

        private void lvwLeaderboardSummary_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwLeaderboardSummary.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_LeaderboardSummary == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_LeaderboardSummary)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_LeaderboardSummary.Text.StartsWith("> "))
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
                SortingColumn_LeaderboardSummary.Text = SortingColumn_LeaderboardSummary.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_LeaderboardSummary = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_LeaderboardSummary.Text = "> " + SortingColumn_LeaderboardSummary.Text;
            }
            else
            {
                SortingColumn_LeaderboardSummary.Text = "< " + SortingColumn_LeaderboardSummary.Text;
            }

            // Create a comparer.
            lvwLeaderboardSummary.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwLeaderboardSummary.Sort();
        }

        private void lvwLeaderboard_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwLeaderboard.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_LeaderboardDetail == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_LeaderboardDetail)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_LeaderboardDetail.Text.StartsWith("> "))
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
                SortingColumn_LeaderboardDetail.Text = SortingColumn_LeaderboardDetail.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_LeaderboardDetail = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_LeaderboardDetail.Text = "> " + SortingColumn_LeaderboardDetail.Text;
            }
            else
            {
                SortingColumn_LeaderboardDetail.Text = "< " + SortingColumn_LeaderboardDetail.Text;
            }

            // Create a comparer.
            lvwLeaderboard.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwLeaderboard.Sort();
        }

        private void cboLeaderboardPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLeaderboardScores();
        }

        private void btnFindWild_Click(object sender, EventArgs e)
        {
            FindNextWild();
        }

        private void mnuContext_DinoId_Click(object sender, EventArgs e)
        {
            switch (tabFeatures.SelectedTab.Name)
            {
                case "tpgWild":
                    if (lvwWildDetail.SelectedItems.Count > 0)
                    {
                        var wildDino = lvwWildDetail.SelectedItems[0].Tag as ContentWildCreature;
                        try
                        {
                            Clipboard.SetText(wildDino.DinoId);
                        }
                        catch
                        {
                            MessageBox.Show("Unable to copy command to clipboard.\n\nPlease try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show("No creature selected.", "Please Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;
                case "tpgTamed":
                    if (lvwTameDetail.SelectedItems.Count > 0)
                    {
                        var tamedDino = lvwTameDetail.SelectedItems[0].Tag as ContentTamedCreature;
                        try
                        {
                            Clipboard.SetText(tamedDino.DinoId);
                        }
                        catch
                        {
                            MessageBox.Show("Unable to copy command to clipboard.\n\nPlease try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show("No creature selected.", "Please Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

            }

        }




        private Bitmap ResizeImage(Image image, int width, int height)
        {
            if (image == null) return null;

            var destRect = new Rectangle(0, 0, width, height);
            Bitmap destImage = new(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void cboChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawTribeCharts();
        }

        private void btnSaveChart_Click(object sender, EventArgs e)
        {
            var chart = chartTribes;
            btnSaveChartImage.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "PNG Image File (*.png)|*.png";
                dialog.AddExtension = true;
                dialog.Title = "Save chart image";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //ensure directory exists
                    string imageFilename = dialog.FileName;
                    string imageFolder = Path.GetDirectoryName(imageFilename);
                    if (!Directory.Exists(imageFolder)) Directory.CreateDirectory(imageFolder);
                    chartTribes.SaveChart(dialog.FileName, 1024, 1024);


                    MessageBox.Show("Chart image saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.Cursor = Cursors.Default;

            btnSaveChartImage.Enabled = true;
        }

        private void udChartTop_ValueChanged(object sender, EventArgs e)
        {
            DrawTribeCharts();
        }

        private void frmViewer_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void frmViewer_Resize(object sender, EventArgs e)
        {
            if (MapViewer != null)
            {
                switch (WindowState)
                {
                    case FormWindowState.Normal:
                    case FormWindowState.Maximized:
                        MapViewer.WindowState = FormWindowState.Normal;

                        break;

                    case FormWindowState.Minimized:
                        MapViewer.WindowState = FormWindowState.Minimized;
                        break;
                }
            }
        }

        private void cboWildRealm_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshWildSummary();
        }

        private void cboTameRealm_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTamedSummary();
        }

        private void cboStructureRealm_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshStructureSummary();
        }

        private void cboPlayerRealm_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPlayerTribes();
        }

        private void cboDroppedItemRealm_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDroppedPlayers();
        }

        private void cboTameStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItemListDetail();
        }

        private void chkItemSearchUploads_CheckedChanged(object sender, EventArgs e)
        {
            LoadItemListDetail();
        }

        private void chkTameUploads_CheckedChanged(object sender, EventArgs e)
        {
            LoadTameDetail();
        }

        private void chkTameable_CheckedChanged(object sender, EventArgs e)
        {
            Program.ProgramConfig.HideNoTames = chkTameable.Checked;

            RefreshWildSummary();
            LoadWildDetail();
        }

        private void mnuContext_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void lblTameTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblMapDate_Click(object sender, EventArgs e)
        {
        }

        private void cboConsoleCommandsWild_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox thisCombo = (System.Windows.Forms.ComboBox)sender;
            if (thisCombo.SelectedIndex < 0) return;
            RCONCommand selectedCommand = thisCombo.SelectedItem as RCONCommand;

            btnRconCommandWild.Enabled = lvwWildDetail.SelectedItems.Count > 0 || selectedCommand.Parameters.Count == 0;
            btnCopyCommandWild.Enabled = lvwWildDetail.SelectedItems.Count > 0 || selectedCommand.Parameters.Count == 0;
        }

        private async void btnRconCommandWild_Click(object sender, EventArgs e)
        {
            btnRconCommandWild.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            string commandText = GetWildCommandText();
            if (commandText.Length > 0)
            {
                lblStatus.Text = "Attempting to send RCON command.";
                lblStatus.Refresh();

                string rconResponse = await ExecuteRCONCommand(commandText);
                using (frmCommandResponse response = new frmCommandResponse(rconResponse))
                {
                    response.Owner = this;
                    response.ShowDialog();
                }

                lblStatus.Text = "";
                lblStatus.Refresh();

            }
            else
            {
                lblStatus.Text = "Unable to parse selected command.";
                lblStatus.Refresh();

            }
            btnRconCommandWild.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private async void btnRconCommandTamed_Click(object sender, EventArgs e)
        {
            btnRconCommandTamed.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            string commandText = GetTamedCommandText();
            if (commandText.Length > 0)
            {
                lblStatus.Text = "Attempting to send RCON command.";
                lblStatus.Refresh();

                string rconResponse = await ExecuteRCONCommand(commandText);
                using (frmCommandResponse response = new frmCommandResponse(rconResponse))
                {
                    response.Owner = this;
                    response.ShowDialog();
                }

                lblStatus.Text = "";
                lblStatus.Refresh();

            }
            else
            {
                lblStatus.Text = "Unable to parse selected command.";
                lblStatus.Refresh();
            }

            btnRconCommandTamed.Enabled = true;
            this.Cursor = Cursors.Default;

        }

        private async void btnRconCommandStructures_Click(object sender, EventArgs e)
        {
            btnRconCommandStructures.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            string commandText = GetStructureCommandText();
            if (commandText.Length > 0)
            {
                lblStatus.Text = "Attempting to send RCON command.";
                lblStatus.Refresh();

                string rconResponse = await ExecuteRCONCommand(commandText);
                using (frmCommandResponse response = new frmCommandResponse(rconResponse))
                {
                    response.Owner = this;
                    response.ShowDialog();
                }

                lblStatus.Text = "";
                lblStatus.Refresh();

            }
            else
            {
                lblStatus.Text = "Unable to parse selected command.";
                lblStatus.Refresh();
            }

            btnRconCommandStructures.Enabled = true;
            this.Cursor = Cursors.Default;

        }

        private async void btnRconCommandTribes_Click(object sender, EventArgs e)
        {
            btnRconCommandTribes.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            string commandText = GetTribeCommandText();
            if (commandText.Length > 0)
            {
                lblStatus.Text = "Attempting to send RCON command.";
                lblStatus.Refresh();

                string rconResponse = await ExecuteRCONCommand(commandText);
                using (frmCommandResponse response = new frmCommandResponse(rconResponse))
                {
                    response.Owner = this;
                    response.ShowDialog();
                }

                lblStatus.Text = "";
                lblStatus.Refresh();

            }
            else
            {
                lblStatus.Text = "Unable to parse selected command.";
                lblStatus.Refresh();
            }

            btnRconCommandTribes.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private async void btnRconCommandPlayers_Click(object sender, EventArgs e)
        {
            btnRconCommandPlayers.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            string commandText = GetPlayerCommandText();
            if (commandText.Length > 0)
            {
                lblStatus.Text = "Attempting to send RCON command.";
                lblStatus.Refresh();

                string rconResponse = await ExecuteRCONCommand(commandText);
                using (frmCommandResponse response = new frmCommandResponse(rconResponse))
                {
                    response.Owner = this;
                    response.ShowDialog();
                }

                lblStatus.Text = "";
                lblStatus.Refresh();

            }
            else
            {
                lblStatus.Text = "Unable to parse selected command.";
                lblStatus.Refresh();
            }

            btnRconCommandPlayers.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void cboConsoleCommandsTamed_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox thisCombo = (System.Windows.Forms.ComboBox)sender;
            if (thisCombo.SelectedIndex < 0) return;
            RCONCommand selectedCommand = thisCombo.SelectedItem as RCONCommand;


            btnCopyCommandTamed.Enabled = lvwTameDetail.SelectedItems.Count > 0 || selectedCommand.Parameters.Count == 0;
            btnRconCommandTamed.Enabled = lvwTameDetail.SelectedItems.Count > 0 || selectedCommand.Parameters.Count == 0;
        }

        private void cboTribeCopyCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox thisCombo = (System.Windows.Forms.ComboBox)sender;
            if (thisCombo.SelectedIndex < 0) return;
            RCONCommand selectedCommand = thisCombo.SelectedItem as RCONCommand;


            btnTribeCopyCommand.Enabled = lvwTribes.SelectedItems.Count > 0 || selectedCommand.Parameters.Count == 0;
            btnRconCommandTribes.Enabled = lvwTribes.SelectedItems.Count > 0 || selectedCommand.Parameters.Count == 0;

        }

        private void cboCopyCommandDropped_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox thisCombo = (System.Windows.Forms.ComboBox)sender;
            if (thisCombo.SelectedIndex < 0) return;
            RCONCommand selectedCommand = thisCombo.SelectedItem as RCONCommand;

            btnCopyCommandDropped.Enabled = lvwDroppedItems.SelectedItems.Count > 0 || selectedCommand.Parameters.Count == 0;
        }

        private void cboItemListCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox thisCombo = (System.Windows.Forms.ComboBox)sender;
            if (thisCombo.SelectedIndex < 0) return;
            RCONCommand selectedCommand = thisCombo.SelectedItem as RCONCommand;

            btnCopyItemListCommand.Enabled = lvwItemList.SelectedItems.Count > 0 || selectedCommand.Parameters.Count == 0;
        }

        private void mnuContext_ProfileFilename_Click(object sender, EventArgs e)
        {
            switch (tabFeatures.SelectedTab.Name)
            {
                case "tpgWild":

                    break;
                case "tpgTamed":

                    break;

                case "tpgStructures":

                    break;
                case "tpgPlayers":
                    if (lvwPlayers.SelectedItems.Count > 0)
                    {
                        ContentPlayer player = (ContentPlayer)lvwPlayers.SelectedItems[0].Tag;
                        if (!string.IsNullOrEmpty(player.PlayerFilename))
                        {
                            try
                            {
                                Clipboard.SetText(player?.PlayerFilename);
                                MessageBox.Show("Player filename copied to the clipboard!", "Copy Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                MessageBox.Show("Unable to copy command to clipboard.\n\nPlease try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }


                    }
                    break;
            }
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboPaintingTribe_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPaintingStructureDetails();
            RefreshPaintingStructures();
        }

        private void LoadPaintingStructureDetails()
        {
            if (cm == null) return;
            if (tabFeatures.SelectedTab.Name != "tpgPaintings") return;


            if (cboPaintingStructure.SelectedItem == null) return;
            if (cboPaintingTribe.SelectedItem == null) return;

            this.Cursor = Cursors.WaitCursor;


            lblStatus.Text = "Updating painting structure selection.";
            lblStatus.Refresh();

            //tribe
            long selectedTribeId = 0;
            ASVComboValue comboValue = (ASVComboValue)cboPaintingTribe.SelectedItem;
            if (comboValue != null) long.TryParse(comboValue.Key, out selectedTribeId);


            //structure
            string selectedClass = "NONE";
            comboValue = (ASVComboValue)cboPaintingStructure.SelectedItem;
            if (comboValue != null) selectedClass = comboValue.Key;


            var playerStructures = cm.GetPlayerStructures(selectedTribeId, 0, selectedClass, false, string.Empty)
                .Where(s => (!Program.ProgramConfig.StructureExclusions.Contains(s.ClassName)) && s.UniquePaintingId != 0).ToList();

            lblPaintingsCount.Text = $"Count: {playerStructures.Count()}";
            lblPaintingsCount.Refresh();

            lvwPlayerPaintings.Items.Clear();
            lvwPlayerPaintings.Refresh();
            lvwPlayerPaintings.BeginUpdate();

            ConcurrentBag<ListViewItem> listItems = new ConcurrentBag<ListViewItem>();

            string selectedRealm = string.Empty;

            var tribes = cm.GetTribes(selectedTribeId);
            foreach (var tribe in tribes)
            {
                var filterStructures = tribe.Structures.Where(s => (s.ClassName == selectedClass || selectedClass == "") && s.UniquePaintingId != 0);
                Parallel.ForEach(filterStructures, playerStructure =>
                {

                    if (!(playerStructure.Latitude.GetValueOrDefault(0) == 0 && playerStructure.Longitude.GetValueOrDefault(0) == 0))
                    {

                        bool addItem = true;


                        if (addItem)
                        {
                            var tribeName = tribe.TribeName;

                            var itemName = playerStructure.ClassName;
                            var itemMap = ARKViewer.Program.ProgramConfig.StructureMap.Where(i => i.ClassName == playerStructure.ClassName).FirstOrDefault();
                            if (itemMap != null && itemMap.FriendlyName.Length > 0)
                            {
                                itemName = itemMap.FriendlyName;
                            }

                            ListViewItem newItem = new ListViewItem(tribeName);
                            newItem.SubItems.Add(itemName);


                            newItem.SubItems.Add(playerStructure.Latitude.Value.ToString("0.00"));
                            newItem.SubItems.Add(playerStructure.Longitude.Value.ToString("0.00"));
                            newItem.SubItems.Add(string.Concat(playerStructure.UniquePaintingId.ToString(), ".pnt"));
                            newItem.Tag = playerStructure;

                            listItems.Add(newItem);
                        }

                    }


                });

            }

            lvwPlayerPaintings.Items.AddRange(listItems.ToArray());

            if (SortingColumn_Paintings != null)
            {
                lvwPlayerPaintings.ListViewItemSorter =
                    new ListViewComparer(SortingColumn_Paintings.Index, SortingColumn_Paintings.Text.Contains(">") ? SortOrder.Ascending : SortOrder.Descending);

                // Sort.
                lvwPlayerPaintings.Sort();
            }

            lvwPlayerPaintings.EndUpdate();

            lblStatus.Text = "Painting selection updated.";
            lblStatus.Refresh();

            DrawMap(0, 0);

            this.Cursor = Cursors.Default;

        }

        private void cboPaintingStructure_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPaintingStructureDetails();
        }

        private void lvwPlayerPaintings_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPaintingDetails();
            btnConsoleCommandPainting.Enabled = cboConsoleCommandPainting.SelectedItem != null && (!cboConsoleCommandPainting.Text.Contains("<") || lvwPlayerPaintings.SelectedItems.Count > 0);

        }


        private void LoadPaintingDetails()
        {
            if (cm == null) return;
            if (lvwPlayerPaintings.SelectedItems.Count == 0)
            {
                picPainting.Image = null;
                return;
            }

            string loadedFilePath = Path.GetDirectoryName(cm.LoadedFilename);
            var selectedStructure = lvwPlayerPaintings.SelectedItems[0].Tag as ContentStructure;
            var paintingFilename = string.Concat(selectedStructure.UniquePaintingId.ToString(), ".pnt");
            var matchingFiles = Directory.EnumerateFiles(loadedFilePath, paintingFilename, SearchOption.AllDirectories);
            if (matchingFiles.Any())
            {
                ContentPainting painting = new ContentPainting(matchingFiles.First());
                picPainting.Image = new Bitmap(painting.GenerateBitmap().ToBitmap(), new Size(picPainting.Width, picPainting.Height));
                painting = null;
            }
            else
            {
                ContentPainting painting = new ContentPainting("");
                picPainting.Image = new Bitmap(painting.GenerateBitmap().ToBitmap(), new Size(picPainting.Width, picPainting.Height));
                painting = null;

            }
        }

        private void picPainting_Click(object sender, EventArgs e)
        {


        }

        private void btnDeletePaintings_Click(object sender, EventArgs e)
        {
            if (cm == null) return;

            if (MessageBox.Show("This action will attempt to identify and .pnt files not referenced in the game save.\n\nIt will then move these files into a sub-folder named 'Removed' for you to delete yourself.", "Please Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                btnDeletePaintings.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                lblStatus.Text = "Identifying un-used .pnt files...";
                lblStatus.Refresh();

                var allPaintingFilenames = cm.GetPlayerStructures(0, 0, "", false, string.Empty)
                                                            .Where(s =>
                                                                (Program.ProgramConfig.StructureExclusions == null
                                                                || (Program.ProgramConfig.StructureExclusions != null & !Program.ProgramConfig.StructureExclusions.Contains(s.ClassName)))
                                                                && s.UniquePaintingId != 0
                                                            ).GroupBy(g => g.UniquePaintingId)
                                                           .Select(s => string.Concat(s.Key.ToString(), ".pnt"));



                var paintingCacheFolder = Path.Combine(Path.GetDirectoryName(cm.LoadedFilename), @$"ServerPaintingsCache\{cm.MapName.Replace(" ", "")}\"); //attempt to find map specific cache sub folder
                if (!Directory.Exists(paintingCacheFolder))
                {
                    var firstPntFile = Directory.EnumerateFiles(Path.GetDirectoryName(cm.LoadedFilename), "*.pnt", SearchOption.AllDirectories).FirstOrDefault(); //attempt to find first pnt file from any location under save folder
                    if (firstPntFile != null)
                    {
                        paintingCacheFolder = Path.GetDirectoryName(firstPntFile); //use folder of first found .pnt file.
                    }
                    else
                    {
                        paintingCacheFolder = Path.GetDirectoryName(cm.LoadedFilename); //fallback to using the .ark save folder
                    }
                }

                var paintingBackupFolder = Path.Combine(paintingCacheFolder, @"Removed\");

                if (!Directory.Exists(paintingBackupFolder))
                {
                    Directory.CreateDirectory(paintingBackupFolder);
                }

                var diskPaintingFiles = Directory.EnumerateFiles(paintingCacheFolder, "*.pnt", SearchOption.AllDirectories);
                lblStatus.Text = "Moving un-used .pnt files please wait...";
                lblStatus.Refresh();

                var unusedPaintingFiles = diskPaintingFiles.Where(d => !allPaintingFilenames.Any(p => d.EndsWith(string.Concat(@"\", p))));
                foreach (var paintingFilename in unusedPaintingFiles)
                {
                    var filenameOnly = Path.GetFileName(paintingFilename);
                    File.Move(paintingFilename, Path.Combine(paintingBackupFolder, filenameOnly));
                }

                this.Cursor = Cursors.Default;

                MessageBox.Show($"{unusedPaintingFiles.Count()} .pnt files moved to Removed folder.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblStatus.Text = "";
                lblStatus.Refresh();

                btnDeletePaintings.Enabled = true;
            }

        }

        private void btnConsoleCommandPainting_Click(object sender, EventArgs e)
        {
            string commandText = GetPaintingCommandText();
            if (commandText.Length > 0)
            {
                try
                {
                    Clipboard.Clear();
                    Clipboard.SetText(commandText);

                    lblStatus.Text = $"Command copied:  {commandText}";
                    lblStatus.Refresh();
                }
                catch
                {
                    lblStatus.Text = "Unable to copy command. Please try again.";
                    lblStatus.Refresh();
                }

            }
            else
            {
                lblStatus.Text = "Unable to parse selected copy command.";
                lblStatus.Refresh();
            }
        }

        private void cboConsoleCommandPainting_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConsoleCommandPainting.Enabled = cboConsoleCommandPainting.SelectedItem != null && (!cboConsoleCommandPainting.Text.Contains("<") || lvwPlayerPaintings.SelectedItems.Count > 0);
        }

        private string GetPaintingCommandText()
        {


            if (cboConsoleCommandPainting.SelectedItem == null) return string.Empty;

            RCONCommand command = cboConsoleCommandPainting.SelectedItem as RCONCommand;

            List<string> allCommands = new List<string>();
            string commandTemplate = command.GetTemplate();

            if (command.UserInputs.Count > 0)
            {
                foreach (var inputRequest in command.UserInputs)
                {
                    using (frmCommandInput inputForm = new frmCommandInput(inputRequest.Key))
                    {
                        if (inputForm.ShowDialog() == DialogResult.OK)
                        {
                            commandTemplate = commandTemplate.Replace($"<{inputRequest.Key}>", $"{inputForm.EnteredValue}");
                        }
                        else
                        {
                            //user cancelled, exit command builder
                            return string.Empty;
                        }
                    }
                }
            }

            if (command.Parameters.Count == 0 || lvwPlayerPaintings.SelectedItems.Count == 0)
            {
                allCommands.Add(commandTemplate);
            }



            if (command.Parameters.Count > 0 && lvwPlayerPaintings.SelectedItems.Count > 0)
            {
                foreach (var defaultParam in command.Parameters.Where(p => !string.IsNullOrEmpty(p.Default)))
                {
                    commandTemplate = commandTemplate.Replace($"<{defaultParam.Key}>", $"{defaultParam.Default}");
                }

                if (commandTemplate.Contains("<FileCsvList>"))
                {
                    string fileList = "";
                    string commandList = commandTemplate;

                    foreach (ListViewItem selectedItem in lvwPlayerPaintings.SelectedItems)
                    {
                        ContentStructure selectedTribe = (ContentStructure)selectedItem.Tag;
                        if (fileList.Length > 0)
                        {
                            fileList = fileList + " ";
                        }
                        fileList = fileList + selectedTribe.TargetingTeam.ToString() + ".arktribe";
                    }

                    commandList = commandList.Replace("<FileCsvList>", fileList);
                    allCommands.Add(commandList);
                }
                else
                {
                    foreach (ListViewItem selectedItem in lvwPlayerPaintings.SelectedItems)
                    {
                        ContentStructure selectedPaintingStructure = (ContentStructure)selectedItem.Tag;
                        string commandText = commandTemplate;
                        long selectedTribeId = selectedPaintingStructure.TargetingTeam;

                        commandText = cboConsoleCommandPainting.SelectedItem.ToString();

                        commandText = commandText.Replace("<TribeID>", selectedTribeId.ToString("f0"));

                        commandText = commandText.Replace("<x>", System.FormattableString.Invariant($"{selectedPaintingStructure.X:0.00}"));
                        commandText = commandText.Replace("<y>", System.FormattableString.Invariant($"{selectedPaintingStructure.Y:0.00}"));
                        commandText = commandText.Replace("<z>", System.FormattableString.Invariant($"{selectedPaintingStructure.Z + 250:0.00}"));

                        switch (Program.ProgramConfig.CommandPrefix)
                        {
                            case 1:
                                commandText = $"admincheat {commandText}";

                                break;
                            case 2:
                                commandText = $"cheat {commandText}";
                                break;
                        }

                        commandText = commandText.Trim();

                        if (!allCommands.Contains(commandText)) allCommands.Add(commandText);
                    }

                }



            }

            return string.Join('|', allCommands.ToArray());

        }

        private void optStatsMutated_CheckedChanged(object sender, EventArgs e)
        {
            if (optStatsMutated.Checked)
            {
                LoadTameDetail();
            }
        }

        private void tabFeatures_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;
            Brush _bgBrush;

            TabPage _tabPage = tabFeatures.TabPages[e.Index];


            //tab page
            Rectangle pageBounds = _tabPage.Bounds;
            pageBounds.Inflate(4, 4);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(45, 45, 45)), pageBounds);



            Rectangle paddedBounds = tabFeatures.GetTabRect(e.Index);//  e.Bounds;
            paddedBounds.Inflate(0, 2);


            Rectangle textBounds = paddedBounds;
            if (e.Index == tabFeatures.TabPages.Count - 1)
            {
                Rectangle b = tabFeatures.GetTabRect(e.Index);
                b.Inflate(0, 2);
                var newWidth = tabFeatures.Width - b.Left;
                b.Width = newWidth;
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), b);
            }
            else
            {

                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), paddedBounds);
            }




            Font _textFont = tabFeatures.Font;


            //tab text
            if (e.State == DrawItemState.Selected)
            {
                _textFont = new Font(_textFont, FontStyle.Bold);
                _textBrush = new SolidBrush(Color.FromArgb(200, 200, 200));

            }
            else
            {
                _textBrush = new SolidBrush(Color.FromArgb(150, 150, 150));
            }


            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            textBounds.Offset(1, yOffset);

            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _textFont, _textBrush, textBounds, new StringFormat(_stringFlags));

        }

        private void FilterTamedLocations(object sender, EventArgs e)
        {
            RefreshTamedTribes();
            RefreshTamePlayerList();
            RefreshTamedSummary();
        }

        private void FilterStructureLocations(object sender, EventArgs e)
        {
            RefreshStructureTribes();
            RefreshStructurePlayerList();
            RefreshStructureSummary();
        }

        private void cboConsoleCommandsPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCopyCommandPlayer.Enabled = lvwPlayers.SelectedItems.Count > 0 || !cboConsoleCommandsPlayer.Text.Contains("<");
            btnRconCommandPlayers.Enabled = lvwPlayers.SelectedItems.Count > 0 || !cboConsoleCommandsPlayer.Text.Contains("<");

        }

        private void cboItemListPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboItemListPlayers.SelectedItem == null) return;

            //select tribe
            ASVComboValue comboValue = (ASVComboValue)cboItemListPlayers.SelectedItem;
            long playerId = long.Parse(comboValue.Key);
            if (playerId == 0) return;

            var playerTribe = cm.GetPlayerTribe(playerId);
            if (playerTribe != null)
            {
                var foundTribe = cboItemListTribe.Items.Cast<ASVComboValue>().First(x => x.Key == playerTribe.TribeId.ToString());
                var selectedTribeIndex = cboItemListTribe.SelectedIndex;
                var foundIndex = cboItemListTribe.Items.IndexOf(foundTribe);
                if (selectedTribeIndex != foundIndex)
                {
                    cboItemListTribe.SelectedIndex = foundIndex;
                }
                else
                {
                    LoadItemListDetail();
                }
            }

        }

        private void txtItemListItemId_TextChanged(object sender, EventArgs e)
        {
            LoadItemListDetail();
        }

        private void cboTamedTrait_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTameDetail();
        }

        private void cboWildTrait_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadWildDetail();
        }

        private void cboItemListFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItemListDetail();
        }

        private void cboTameFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTameDetail();
        }
    }
}

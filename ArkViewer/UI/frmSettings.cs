using ArkViewer.Configuration;
using ARKViewer.Configuration;
using ARKViewer.Models;
using ARKViewer.Models.NameMap;
using ASVPack.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARKViewer
{
    public partial class frmSettings : Form
    {
        private ColumnHeader SortingColumn_DinoMap = null;
        private ColumnHeader SortingColumn_ItemMap = null;
        private ColumnHeader SortingColumn_StructureMap = null;
        string imageFolder = "";
        ASVDataManager cm = null;



        public ViewerConfiguration SavedConfig { get; set; }
        public frmSettings()
        {
            InitializeComponent();


            cm = null;

            btnExportContentPack.Enabled = cm != null;
            btnJsonExportAll.Enabled = cm != null;
            btnJsonExportPlayers.Enabled = cm != null;
            btnJsonExportTamed.Enabled = cm != null;
            btnJsonExportWild.Enabled = cm != null;

            lvwItemMap.LargeImageList = Program.ItemImageList;
            lvwItemMap.SmallImageList = Program.ItemImageList;

            imageFolder = Path.Combine(AppContext.BaseDirectory, @"images\icons\");
            if (!Directory.Exists(imageFolder))
            {
                Directory.CreateDirectory(imageFolder);
            }

            PopulateExportTribes();

            SavedConfig = Program.ProgramConfig;
        }
        public frmSettings(ASVDataManager manager) : this()
        {

            cm = manager;

            btnExportContentPack.Enabled = cm != null;
            btnJsonExportAll.Enabled = cm != null;
            btnJsonExportPlayers.Enabled = cm != null;
            btnJsonExportTamed.Enabled = cm != null;
            btnJsonExportWild.Enabled = cm != null;

            lvwItemMap.LargeImageList = Program.ItemImageList;
            lvwItemMap.SmallImageList = Program.ItemImageList;

            imageFolder = Path.Combine(AppContext.BaseDirectory, @"images\icons\");
            if (!Directory.Exists(imageFolder))
            {
                Directory.CreateDirectory(imageFolder);
            }

            PopulateExportTribes();

            SavedConfig = Program.ProgramConfig;

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

        private void PopulateExportTribes()
        {
            if (cm == null) return;
            this.Cursor = Cursors.WaitCursor;

            cboExportTribe.Items.Clear();
            cboExportTribe.Items.Add(new ASVComboValue("0", "[All Tribes]"));

            ConcurrentBag<ASVComboValue> tribeBag = new ConcurrentBag<ASVComboValue>();
            var tribes = cm.GetTribes(0);
            Parallel.ForEach(tribes, tribe =>
            {
                bool shouldAdd = true;
                if (Program.ProgramConfig.HideNoStructures && tribe.Structures.Count == 0) shouldAdd = false;
                if (Program.ProgramConfig.HideNoBody && tribe.Players.All(p => p.Longitude.GetValueOrDefault(0) == 0 && p.Latitude.GetValueOrDefault(0) == 0)) shouldAdd = false;

                if (shouldAdd) tribeBag.Add(new ASVComboValue(tribe.TribeId.ToString(), tribe.TribeName));
            });

            if (tribeBag != null & !tribeBag.IsEmpty)
            {
                cboExportTribe.Items.AddRange(tribeBag.ToArray());
            }

            this.Cursor = Cursors.Default;
            cboExportTribe.SelectedIndex = 0;

        }

        private void PopulateExportPlayers(long tribeId)
        {
            this.Cursor = Cursors.WaitCursor;
            cboExportPlayer.Items.Clear();
            cboExportPlayer.Items.Add(new ASVComboValue("0", "[All Players]"));

            ConcurrentBag<ASVComboValue> playerBag = new ConcurrentBag<ASVComboValue>();
            var tribes = cm.GetTribes(tribeId);
            Parallel.ForEach(tribes, tribe =>
            {
                bool shouldAdd = true;
                if (Program.ProgramConfig.HideNoStructures && tribe.Structures.Count == 0) shouldAdd = false;
                if (shouldAdd)
                {
                    var players = tribe.Players.Where(p => !(Program.ProgramConfig.HideNoBody && (p.Latitude.GetValueOrDefault(0) == 0 && p.Longitude.GetValueOrDefault(0) == 0))).ToList();
                    if (players != null && players.Count > 0)
                    {
                        foreach (var player in players)
                        {
                            playerBag.Add(new ASVComboValue(player.Id.ToString(), player.CharacterName));
                        }
                    }
                }



            });

            if (playerBag != null & !playerBag.IsEmpty)
            {
                cboExportPlayer.Items.AddRange(playerBag.ToArray());
            }

            cboExportPlayer.SelectedIndex = 0;

            this.Cursor = Cursors.Default;
        }

        private void PopulateColours()
        {
            this.Cursor = Cursors.WaitCursor;

            //populate class map
            lvwColours.Items.Clear();
            lvwColours.Refresh();
            lvwColours.BeginUpdate();
            if (SavedConfig.ColourMap.Count > 0)
            {
                foreach (var colourMap in SavedConfig.ColourMap.OrderBy(d => d.Id))
                {
                    ListViewItem newItem = lvwColours.Items.Add(colourMap.Id.ToString());
                    newItem.UseItemStyleForSubItems = false;
                    newItem.SubItems.Add(colourMap.Hex);
                    newItem.SubItems.Add("");
                    newItem.SubItems[2].BackColor = colourMap.Color;
                    newItem.Tag = colourMap;
                }

            }




            lvwColours.EndUpdate();

            this.Cursor = Cursors.Default;
        }

        private void RefreshUnknownColours()
        {
            if (cm != null && cm.MapFilename.Length > 0)
            {
                btnColoursNotMatchedAdd.Enabled = false;
                lvwColoursNotMapped.BeginUpdate();
                lvwColoursNotMapped.Items.Clear();

                //map loaded
                var wilds = cm.GetWildCreatures(0, int.MaxValue, 50, 50, 250, "", "");
                if (wilds != null && wilds.Count > 0)
                {
                    var knownMap = SavedConfig.ColourMap.ToList();
                    var unknownMap = new List<int>();
                    for (int i = 0; i < 6; i++)
                    {
                        var unmappedColours = wilds.Select(c => (int)c.Colors[i]).Where(x => x != 0
                                                                                            & !knownMap.Any(c => c.Id == x)
                                                                                            & !unknownMap.Any(c => c == x)
                                                                                       ).Distinct()
                                                                                       .OrderBy(o => o)
                                                                                       .ToList();

                        if (unmappedColours != null && unmappedColours.Count > 0) unknownMap.AddRange(unmappedColours);

                    }

                    if (unknownMap != null && unknownMap.Count() > 0)
                    {
                        foreach (var unmappedColour in unknownMap)
                        {
                            ListViewItem newItem = new ListViewItem(unmappedColour.ToString());
                            newItem.Tag = unmappedColour;
                            lvwColoursNotMapped.Items.Add(newItem);
                        }
                    }
                }

                lvwColoursNotMapped.EndUpdate();
            }
        }

        private void PopulateDinoClassMap(string selectedClass)
        {
            this.Cursor = Cursors.WaitCursor;

            btnEditDinoClass.Enabled = false;
            btnRemoveDinoClass.Enabled = false;

            //populate class map
            lvwDinoClasses.Items.Clear();
            lvwDinoClasses.Refresh();
            lvwDinoClasses.BeginUpdate();
            if (SavedConfig.DinoMap.Count > 0)
            {
                foreach (var dino in SavedConfig.DinoMap.OrderBy(d => d.FriendlyName))
                {
                    if (dino.ClassName.ToLower().Contains(txtCreatureFilter.Text.ToLower()) || dino.FriendlyName.ToLower().Contains(txtCreatureFilter.Text.ToLower()))
                    {
                        ListViewItem newItem = lvwDinoClasses.Items.Add(dino.ClassName);
                        newItem.SubItems.Add(dino.FriendlyName);
                        newItem.Tag = dino;


                        if (selectedClass.Length > 0)
                        {
                            if (dino.ClassName.ToLower() == selectedClass.ToLower())
                            {
                                newItem.Selected = true;
                                lvwDinoClasses.EnsureVisible(newItem.Index);
                            }
                        }

                    }

                }
            }

            lvwDinoClasses.EndUpdate();





            this.Cursor = Cursors.Default;
        }

        private void RefreshUnknownCreatures()
        {
            if (cm != null && cm.MapFilename.Length > 0)
            {
                lvwCreaturesNotMapped.BeginUpdate();
                lvwCreaturesNotMapped.Items.Clear();

                //map loaded
                var wilds = cm.GetWildCreatures(0, int.MaxValue, 50, 50, 250, "", "");
                if (wilds != null && wilds.Count > 0)
                {
                    var knownMap = SavedConfig.DinoMap.ToList();
                    var unknownMap = new List<string>();

                    var unmappedClasses = wilds.Where(w => !knownMap.Any(m => m.ClassName == w.ClassName)).GroupBy(x => x.ClassName).Select(s => s.First().ClassName).Distinct().OrderBy(s => s).ToList();
                    if (unmappedClasses != null && unmappedClasses.Count > 0) unknownMap.AddRange(unmappedClasses);

                    if (unknownMap != null && unknownMap.Count() > 0)
                    {
                        foreach (var unmappedClass in unknownMap)
                        {
                            ListViewItem newItem = new ListViewItem(unmappedClass.ToString());
                            newItem.Tag = unmappedClass;
                            lvwCreaturesNotMapped.Items.Add(newItem);
                        }
                    }
                }

                lvwCreaturesNotMapped.EndUpdate();
            }
        }

        private void PopulateItemClassMap(string selectedClass)
        {
            this.Cursor = Cursors.WaitCursor;

            btnEditDinoClass.Enabled = false;
            btnRemoveDinoClass.Enabled = false;

            //populate class map
            lvwItemMap.Items.Clear();
            lvwItemMap.Refresh();
            lvwItemMap.BeginUpdate();


            if (SavedConfig.ItemMap.Count > 0)
            {
                string filterText = txtItemFilter.Text;

                foreach (var item in SavedConfig.ItemMap.OrderBy(d => d.DisplayName))
                {

                    ListViewItem newItem = lvwItemMap.Items.Add(item.Category);
                    newItem.SubItems.Add(item.ClassName);
                    newItem.SubItems.Add(item.DisplayName);

                    int imageIndex = Program.GetItemImageIndex(item.Image);
                    newItem.ImageIndex = imageIndex - 1;

                    newItem.Tag = item;

                    if (selectedClass.Length > 0)
                    {
                        if (item.ClassName.ToLower() == selectedClass.ToLower())
                        {
                            newItem.Selected = true;
                            lvwItemMap.EnsureVisible(newItem.Index);
                        }
                    }

                }

            }
            lvwItemMap.EndUpdate();




            this.Cursor = Cursors.Default;
        }

        private void RefreshUnknownItems()
        {
            if (cm != null && cm.MapFilename.Length > 0)
            {
                lvwItemsNotMatched.BeginUpdate();
                lvwItemsNotMatched.Items.Clear();

                //map loaded
                var allItems = cm.GetInventories().Where(x => x != null && x.Items != null).ToList();
                if (allItems != null && allItems.Count > 0)
                {
                    var knownMap = SavedConfig.ItemMap.ToList();
                    var unknownMap = new List<string>();

                    var unmappedClasses = allItems.SelectMany(x =>
                                                                    x.Items.Where(w =>
                                                                        !knownMap.Any(m => m.ClassName == w.ClassName)
                                                                    )
                                                             ).GroupBy(x => x.ClassName).Select(x => x.First()).ToList();

                    if (unmappedClasses != null && unmappedClasses.Count > 0)
                    {
                        var distinctClassNames = unmappedClasses.Select(s => s.ClassName).Distinct().OrderBy(s => s).ToList();
                        if (distinctClassNames != null && distinctClassNames.Count > 0) unknownMap.AddRange(distinctClassNames);
                    }

                    if (unknownMap != null && unknownMap.Count() > 0)
                    {
                        foreach (var unmappedClass in unknownMap)
                        {
                            ListViewItem newItem = new ListViewItem(unmappedClass.ToString());
                            newItem.Tag = unmappedClass;
                            lvwItemsNotMatched.Items.Add(newItem);
                        }
                    }
                    lvwItemsNotMatched.EndUpdate();
                }

            }
        }



        private void PopulateStructureClassMap(string selectedClass)
        {
            this.Cursor = Cursors.WaitCursor;

            btnEditStructure.Enabled = false;
            btnRemoveStructure.Enabled = false;

            //populate class map
            lvwStructureMap.Items.Clear();
            lvwStructureMap.Refresh();
            lvwStructureMap.BeginUpdate();


            if (SavedConfig.StructureMap.Count > 0)
            {
                string filterText = txtStructureFilter.Text;

                foreach (var item in SavedConfig.StructureMap.Where(x => !x.ClassName.StartsWith("ASV_")).OrderBy(d => d.FriendlyName))
                {
                    ListViewItem newItem = lvwStructureMap.Items.Add(item.FriendlyName);
                    newItem.SubItems.Add(item.ClassName);
                    newItem.Tag = item;

                    if (selectedClass.Length > 0)
                    {
                        if (item.ClassName.ToLower() == selectedClass.ToLower())
                        {
                            newItem.Selected = true;
                            lvwStructureMap.EnsureVisible(newItem.Index);
                        }
                    }

                }

            }
            lvwStructureMap.EndUpdate();

            this.Cursor = Cursors.Default;
        }

        private void RefreshUnknownStructures()
        {
            if (cm != null && cm.MapFilename.Length > 0)
            {
                lvwStructuresNotMapped.BeginUpdate();
                lvwStructuresNotMapped.Items.Clear();

                //map loaded
                var structures = cm.GetPlayerStructures(0, 0, "", false, "");

                if (structures != null && structures.Count > 0)
                {
                    var knownMap = SavedConfig.StructureMap.ToList();
                    var unknownMap = new List<string>();

                    var unmappedClasses = structures.GroupBy(x => x.ClassName).Where(w => !knownMap.Any(m => m.ClassName == w.Key)).Select(s => s.First().ClassName).OrderBy(s => s).ToList();
                    if (unmappedClasses != null && unmappedClasses.Count > 0) unknownMap.AddRange(unmappedClasses);

                    if (unknownMap != null && unknownMap.Count() > 0)
                    {
                        foreach (var unmappedClass in unknownMap)
                        {
                            ListViewItem newItem = new ListViewItem(unmappedClass.ToString());
                            newItem.Tag = unmappedClass;
                            lvwStructuresNotMapped.Items.Add(newItem);
                        }
                    }
                }

                lvwStructuresNotMapped.EndUpdate();
            }
        }

        private void PopulateSinglePlayerGames()
        {

            //get registry path for steam apps 
            cboMapSinglePlayer.Items.Clear();


            string directoryCheck = Program.ProgramConfig.ArkSavedGameFolder;
            if (directoryCheck.Length == 0) directoryCheck = Program.GetSteamFolder();

            if (Directory.Exists(directoryCheck))
            {
                cboMapSinglePlayer.Sorted = true;

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
                            int newIndex = cboMapSinglePlayer.Items.Add(comboValue);
                        }

                    }

                }


                for (int x = 0; x < cboMapSinglePlayer.Items.Count; x++)
                {
                    ASVComboValue itemValue = (ASVComboValue)cboMapSinglePlayer.Items[x];
                    if (itemValue.Key == Program.ProgramConfig.SelectedFile)
                    {
                        cboMapSinglePlayer.SelectedIndex = x;
                        break;
                    }
                }

            }

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            PopulateColours();
            PopulateDinoClassMap("");
            PopulateStructureClassMap("");
            PopulateItemClassMap("");

            lblCryopodHighlight.BackColor = Color.FromArgb(SavedConfig.HighlightColorCryopod);
            lblCryopodHighlight.ForeColor = Program.IdealTextColor(lblCryopodHighlight.BackColor);

            lblVivariumHighlight.BackColor = Color.FromArgb(SavedConfig.HighlightColorVivarium);
            lblVivariumHighlight.ForeColor = Program.IdealTextColor(lblVivariumHighlight.BackColor);

            lblUploadedHighlight.BackColor = Color.FromArgb(SavedConfig.HighlightColorUploaded);
            lblUploadedHighlight.ForeColor = Program.IdealTextColor(lblUploadedHighlight.BackColor);


            chkUpdateNotificationSingle.Checked = SavedConfig.UpdateNotificationSingle;


            optPlayerStructureHide.Checked = SavedConfig.HideNoStructures;
            optPlayerStructureShow.Checked = !SavedConfig.HideNoStructures;

            if(SavedConfig.MaxCores <=0) SavedConfig.MaxCores = (int)(Environment.ProcessorCount * 0.75);
            if (SavedConfig.MaxCores <= 0) SavedConfig.MaxCores = 1;
            udMaxCores.Value = SavedConfig.MaxCores;
            udMaxCores.Maximum = Environment.ProcessorCount;

            optPlayerTameHide.Checked = SavedConfig.HideNoTames;
            optPlayerTameShow.Checked = !SavedConfig.HideNoTames;

            optPlayerBodyHide.Checked = SavedConfig.HideNoBody;
            optPlayerBodyShow.Checked = !SavedConfig.HideNoBody;
            optFTPSync.Checked = SavedConfig.FtpDownloadMode == 0;
            optFTPClean.Checked = SavedConfig.FtpDownloadMode == 1;
            optDownloadAuto.Checked = SavedConfig.FtpLoadMode == 1;
            optDownloadManual.Checked = SavedConfig.FtpLoadMode == 0;

            optExportNoSort.Checked = !SavedConfig.SortCommandLineExport;
            optExportSort.Checked = SavedConfig.SortCommandLineExport;
            optStartupAuto.Checked = SavedConfig.LoadSaveOnStartup;
            optStartupManual.Checked = !SavedConfig.LoadSaveOnStartup;

            switch (SavedConfig.CommandPrefix)
            {
                case 0:
                    optPlayerCommandsPrefixNone.Checked = true;
                    break;
                case 1:
                    optPlayerCommandsPrefixAdmincheat.Checked = true;
                    break;
                case 2:
                    optPlayerCommandsPrefixCheat.Checked = true;
                    break;
                default:

                    break;
            }

            switch (SavedConfig.Mode)
            {
                case ViewerModes.Mode_SinglePlayer:

                    optSinglePlayer.Checked = true;
                    break;
                case ViewerModes.Mode_Offline:
                    optOffline.Checked = true;

                    break;
                case ViewerModes.Mode_ContentPack:
                    optContentPack.Checked = true;

                    break;
                case ViewerModes.Mode_Ftp:
                    optServer.Checked = true;

                    break;
                default:
                    break;

            }


            //offline mode?
            if (SavedConfig.Mode == ViewerModes.Mode_Offline)
            {
                if (cboLocalARK.Items.Count == 0)
                {
                    var config = new OfflineFileConfiguration()
                    {
                        Filename = SavedConfig.SelectedFile,
                        Name = "Offline File 1",
                        ClusterFolder = ""
                    };
                    cboLocalARK.Items.Add(config);
                }

                int localSelectedIndex = -1;
                if (cboLocalARK.Items.Count > 0)
                {
                    for (int itemIndex = 0; cboLocalARK.Items.Count > itemIndex; itemIndex++)
                    {
                        var item = cboLocalARK.Items[itemIndex] as OfflineFileConfiguration;
                        if (item.Filename == SavedConfig.SelectedFile)
                        {
                            localSelectedIndex = itemIndex;
                            SavedConfig.ClusterFolder = item.ClusterFolder;

                            break;
                        }

                    }
                    cboLocalARK.SelectedIndex = localSelectedIndex;
                }

            }
            if (SavedConfig.Mode == ViewerModes.Mode_ContentPack)
            {
                txtContentPackFilename.Text = SavedConfig.SelectedFile;
            }

            cboFtpMap.Items.Clear();

            foreach (var knownMap in Program.MapPack.SupportedMaps.OrderBy(o => o.MapName))
            {
                ASVComboValue comboValue = new ASVComboValue(knownMap.Filename, knownMap.MapName);
                int newIndex = cboFtpMap.Items.Add(comboValue);
            }

            //ftp servers?
            if (SavedConfig.ServerList.Count() > 0)
            {
                cboFTPServer.Items.Clear();

                foreach (var serverConfig in SavedConfig.ServerList)
                {
                    int newIndex = cboFTPServer.Items.Add(serverConfig);

                    if (serverConfig.Name == SavedConfig.SelectedServer)
                    {
                        cboFTPServer.SelectedIndex = newIndex;
                    }
                }
            }

            if (SavedConfig.OfflineList.Count > 0)
            {
                cboLocalARK.Items.Clear();
                int selectedOfflineIndex = -1;
                foreach (var kv in SavedConfig.OfflineList)
                {
                    if (kv.Name != null)
                    {
                        int newIndex = cboLocalARK.Items.Add(kv);
                        if (kv.Filename == SavedConfig.SelectedFile)
                        {
                            selectedOfflineIndex = newIndex;
                        }

                    }

                }
                cboLocalARK.Sorted = true;
                cboLocalARK.SelectedIndex = selectedOfflineIndex;

            }

            UpdateDisplay();

        }

        private void optSinglePlayer_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {

            if (optSinglePlayer.Checked && cboMapSinglePlayer.Items.Count == 0)
            {
                PopulateSinglePlayerGames();
            }

            DisplayServerSettings();

            lblSelectedMapSP.BackColor = optSinglePlayer.Checked ? Color.FromArgb(225, 225, 225) : Color.FromArgb(125, 125, 125);
            lblOfflineSave.BackColor = optOffline.Checked ? Color.FromArgb(225, 225, 225) : Color.FromArgb(125, 125, 125);
            lblFTPServer.BackColor = optServer.Checked ? Color.FromArgb(225, 225, 225) : Color.FromArgb(125, 125, 125);
            lblSelectedMapContentPack.BackColor = optContentPack.Checked ? Color.FromArgb(225, 225, 225) : Color.FromArgb(125, 125, 125);

            chkUpdateNotificationSingle.Enabled = optSinglePlayer.Checked;

            cboMapSinglePlayer.Enabled = optSinglePlayer.Checked;
            btnSelectFolder.Enabled = optSinglePlayer.Checked;

            if (optSinglePlayer.Checked)
            {
                if (cboMapSinglePlayer.SelectedIndex < 0 && cboMapSinglePlayer.Items.Count > 0) cboMapSinglePlayer.SelectedIndex = 0;
            }

            cboLocalARK.Enabled = optOffline.Checked;
            btnAddARK.Enabled = optOffline.Checked;
            btnRemoveARK.Enabled = optOffline.Checked && cboLocalARK.SelectedIndex >= 0; ;

            txtContentPackFilename.Enabled = optContentPack.Checked;
            btnLoadContentPack.Enabled = optContentPack.Checked;


            cboFTPServer.Enabled = optServer.Checked;
            btnAddServer.Enabled = optServer.Checked;
            btnRemoveServer.Enabled = optServer.Checked;

        }

        private void optOffline_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void optServer_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void lblFTPHost_Click(object sender, EventArgs e)
        {

        }

        private void cboFTPServer_SelectedIndexChanged(object sender, EventArgs e)
        {

            DisplayServerSettings();
        }

        private void DisplayServerSettings()
        {

            if (cboFTPServer.SelectedItem == null)
            {
                return;
            }


            ServerConfiguration selectedServer = (ServerConfiguration)cboFTPServer.SelectedItem;
            ASVComboValue selectedMapItem = cboFtpMap.Items.Cast<ASVComboValue>().FirstOrDefault(i => i.Key.ToLower() == selectedServer.Map.ToLower());
            if (selectedMapItem != null)
            {
                cboFtpMap.SelectedItem = selectedMapItem;
            }
            cboFtpMap.Enabled = cboFTPServer.Visible == false;

            btnEditServer.Enabled = true;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Program.ApiConfig != null)
            {
                Program.ApiConfig.Save();
            }

            if (optPlayerCommandsPrefixNone.Checked)
            {
                SavedConfig.CommandPrefix = 0;
            }
            else if (optPlayerCommandsPrefixAdmincheat.Checked)
            {
                SavedConfig.CommandPrefix = 1;
            }
            else
            {
                SavedConfig.CommandPrefix = 2;
            }


            SavedConfig.HideNoTames = optPlayerTameHide.Checked;
            SavedConfig.HideNoStructures = optPlayerStructureHide.Checked;
            SavedConfig.MaxCores = (int)udMaxCores.Value;
            SavedConfig.HideNoBody = optPlayerBodyHide.Checked;
            SavedConfig.FtpDownloadMode = optFTPSync.Checked ? 0 : 1;
            SavedConfig.FtpLoadMode = optDownloadAuto.Checked ? 1 : 0;

            SavedConfig.SortCommandLineExport = optExportSort.Checked;
            SavedConfig.UpdateNotificationSingle = chkUpdateNotificationSingle.Checked;
            SavedConfig.LoadSaveOnStartup = optStartupAuto.Checked;

            //update server list
            if (optSinglePlayer.Checked)
            {
                if (cboMapSinglePlayer.SelectedItem != null)
                {
                    SavedConfig.Mode = ViewerModes.Mode_SinglePlayer;
                    ASVComboValue selectedMapPair = (ASVComboValue)cboMapSinglePlayer.SelectedItem;
                    SavedConfig.SelectedFile = selectedMapPair.Key;

                }
            }

            if (optOffline.Checked)
            {
                if (cboLocalARK.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a file for offline mode.", "Offline Mode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }

                OfflineFileConfiguration selectedItem = (OfflineFileConfiguration)cboLocalARK.SelectedItem;

                if (!File.Exists(selectedItem.Filename))
                {

                    MessageBox.Show("Unable to find the selected file.\n\nPlease check the file exists and try again.", "Offline Mode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }


                SavedConfig.Mode = ViewerModes.Mode_Offline;
                SavedConfig.SelectedFile = selectedItem.Filename;
                SavedConfig.ClusterFolder = selectedItem.ClusterFolder;
            }

            if (optContentPack.Checked)
            {
                SavedConfig.Mode = ViewerModes.Mode_ContentPack;
                SavedConfig.SelectedFile = txtContentPackFilename.Text.Trim();
            }

            if (optServer.Checked)
            {

                SavedConfig.Mode = ViewerModes.Mode_Ftp;

                if (cboFTPServer.SelectedItem != null)
                {
                    ServerConfiguration selectedConfig = (ServerConfiguration)cboFTPServer.SelectedItem;
                    SavedConfig.SelectedServer = selectedConfig.Name;

                    string localFilename = Path.Combine(AppContext.BaseDirectory, $@"{selectedConfig.Name}\{selectedConfig.Map}");
                    SavedConfig.SelectedFile = localFilename;

                    cboFTPServer.Items[cboFTPServer.SelectedIndex] = selectedConfig;

                }
            }

            SavedConfig.ServerList.Clear();
            foreach (var item in cboFTPServer.Items)
            {
                if (item is ServerConfiguration)
                {
                    ServerConfiguration serverConfig = (ServerConfiguration)item;
                    SavedConfig.ServerList.Add(serverConfig);
                }
            }

            SavedConfig.OfflineList.Clear();
            foreach (var item in cboLocalARK.Items)
            {
                var i = (OfflineFileConfiguration)item;
                SavedConfig.OfflineList.Add(i);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnRemoveServer_Click(object sender, EventArgs e)
        {

            if (cboFTPServer.SelectedItem != null)
            {
                var selectedItem = cboFTPServer.SelectedItem;
                if (MessageBox.Show("Are you sure you want to remove this server?", "Remove Server?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cboFTPServer.Items.Remove(selectedItem);
                    if (cboFTPServer.Items.Count > 0)
                    {
                        cboFTPServer.SelectedIndex = 0;
                    }
                }
            }

            DisplayServerSettings();

        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {

            using (frmFtpFileBrowser serverSetup = new frmFtpFileBrowser())
            {
                if (serverSetup.ShowDialog() == DialogResult.OK)
                {
                    //commit changes to combo tag
                    int newIndex = cboFTPServer.Items.Add(serverSetup.SelectedServer);
                    Program.ProgramConfig.SelectedServer = serverSetup.Name;
                    cboFTPServer.SelectedIndex = newIndex;
                }
            }

        }
        private void UpdateFtpServer()
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server admin provided imports coming soon.", "Coming Soon!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lvwDinoClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveDinoClass.Enabled = lvwDinoClasses.SelectedItems.Count > 0;
            btnEditDinoClass.Enabled = lvwDinoClasses.SelectedItems.Count > 0;
        }

        private void btnAddDinoClass_Click(object sender, EventArgs e)
        {
            frmGenericClassMap mapEditor = new frmGenericClassMap(new DinoClassMap());
            mapEditor.Owner = this;
            if (mapEditor.ShowDialog() == DialogResult.OK)
            {
                //if line already exist for this class update the friendly name.
                DinoClassMap existingMap = SavedConfig.DinoMap.Where(d => d.ClassName.ToLower() == mapEditor.ClassMap.ClassName.ToLower()).FirstOrDefault<DinoClassMap>();
                if (existingMap != null && existingMap.ClassName.Length != 0)
                {
                    //found it, update
                    existingMap.FriendlyName = mapEditor.ClassMap.FriendlyName;
                }
                else
                {
                    //not found, add new
                    SavedConfig.DinoMap.Add((DinoClassMap)mapEditor.ClassMap);
                }

                PopulateDinoClassMap(mapEditor.ClassMap.ClassName);

            }
        }

        private void btnEditDinoClass_Click(object sender, EventArgs e)
        {
            DinoClassMap selectedDinoMap = (DinoClassMap)lvwDinoClasses.SelectedItems[0].Tag;

            frmGenericClassMap mapEditor = new frmGenericClassMap(selectedDinoMap);
            mapEditor.Owner = this;
            if (mapEditor.ShowDialog() == DialogResult.OK)
            {
                //if line already exist for this class update the friendly name.
                DinoClassMap existingMap = SavedConfig.DinoMap.Where(d => d.ClassName.ToLower() == mapEditor.ClassMap.ClassName.ToLower()).FirstOrDefault<DinoClassMap>();
                if (existingMap != null && existingMap.ClassName.Length != 0)
                {
                    //found it, update
                    existingMap.FriendlyName = mapEditor.ClassMap.FriendlyName;
                }
                else
                {
                    //not found, add new
                    SavedConfig.DinoMap.Add((DinoClassMap)mapEditor.ClassMap);
                }

                PopulateDinoClassMap(mapEditor.ClassMap.ClassName);

            }
        }

        private void lvwDinoClasses_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwDinoClasses.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_DinoMap == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_DinoMap)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_DinoMap.Text.StartsWith("> "))
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
                SortingColumn_DinoMap.Text = SortingColumn_DinoMap.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_DinoMap = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_DinoMap.Text = "> " + SortingColumn_DinoMap.Text;
            }
            else
            {
                SortingColumn_DinoMap.Text = "< " + SortingColumn_DinoMap.Text;
            }

            // Create a comparer.
            lvwDinoClasses.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwDinoClasses.Sort();
        }

        private void btnRemoveDinoClass_Click(object sender, EventArgs e)
        {
            if (lvwDinoClasses.SelectedItems.Count == 0) return;

            DinoClassMap selectedClassMap = (DinoClassMap)lvwDinoClasses.SelectedItems[0].Tag;
            if (MessageBox.Show($"Are you sure you want to remove the display name for '{selectedClassMap.ClassName}'?", "Remove Name?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SavedConfig.DinoMap.Remove(selectedClassMap);
                PopulateDinoClassMap("");
            }
        }

        private void btnServerExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server admin exports coming soon.", "Coming Soon!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lvwItemMap_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwItemMap.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_ItemMap == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_ItemMap)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_ItemMap.Text.StartsWith("> "))
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
                SortingColumn_ItemMap.Text = SortingColumn_ItemMap.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_ItemMap = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_ItemMap.Text = "> " + SortingColumn_ItemMap.Text;
            }
            else
            {
                SortingColumn_ItemMap.Text = "< " + SortingColumn_ItemMap.Text;
            }

            // Create a comparer.
            lvwItemMap.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwItemMap.Sort();
        }

        private void txtCreatureFilter_TextChanged(object sender, EventArgs e)
        {
            //PopulateDinoClassMap("");
        }

        private void txtItemFilter_TextChanged(object sender, EventArgs e)
        {
            //PopulateItemClassMap("");
        }

        private void txtCreatureFilter_Validating(object sender, CancelEventArgs e)
        {
            //PopulateDinoClassMap("");
        }

        private void txtItemFilter_Validating(object sender, CancelEventArgs e)
        {
            //PopulateItemClassMap("");
        }

        private void chkApplyFilterDinos_CheckedChanged(object sender, EventArgs e)
        {
            txtCreatureFilter.Enabled = !chkApplyFilterDinos.Checked;
            if (!chkApplyFilterDinos.Checked)
            {
                txtCreatureFilter.Text = string.Empty;
                PopulateDinoClassMap("");
                txtCreatureFilter.Focus();
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;

                lvwDinoClasses.BeginUpdate();
                int lastIndex = lvwDinoClasses.Items.Count - 1;
                for (int currentIndex = lastIndex; currentIndex >= 0; currentIndex--)
                {
                    ListViewItem item = lvwDinoClasses.Items[currentIndex];
                    if (!(item.SubItems[0].Text.ToLower().Contains(txtCreatureFilter.Text.ToLower()) | item.SubItems[1].Text.ToLower().Contains(txtCreatureFilter.Text.ToLower())))
                    {
                        lvwDinoClasses.Items.Remove(item);
                    }
                }
                lvwDinoClasses.EndUpdate();

                this.Cursor = Cursors.Default;
            }


        }

        private void chkApplyFilterItems_CheckedChanged(object sender, EventArgs e)
        {
            txtItemFilter.Enabled = !chkApplyFilterItems.Checked;
            if (!chkApplyFilterItems.Checked)
            {
                txtItemFilter.Text = string.Empty;
                PopulateItemClassMap("");
                txtItemFilter.Focus();
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;

                lvwItemMap.BeginUpdate();
                int lastIndex = lvwItemMap.Items.Count - 1;
                for (int currentIndex = lastIndex; currentIndex >= 0; currentIndex--)
                {
                    ListViewItem item = lvwItemMap.Items[currentIndex];
                    bool shouldKeep = false;

                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        if (subItem.Text.ToLower().Contains(txtItemFilter.Text.ToLower()))
                        {
                            shouldKeep = true;
                            break;
                        }
                    }

                    if (!shouldKeep)
                    {
                        lvwItemMap.Items.Remove(item);
                    }
                }
                lvwItemMap.EndUpdate();

                this.Cursor = Cursors.Default;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            frmItemClassMap mapEditor = new frmItemClassMap();
            mapEditor.Owner = this;
            if (mapEditor.ShowDialog() == DialogResult.OK)
            {
                //if line already exist for this class update the friendly name.
                ItemClassMap existingMap = SavedConfig.ItemMap.Where(i => i.ClassName.ToLower() == mapEditor.ClassMap.ClassName.ToLower()).FirstOrDefault<ItemClassMap>();
                SavedConfig.ItemMap.Add(mapEditor.ClassMap);

                PopulateItemClassMap(mapEditor.ClassMap.ClassName);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lvwItemMap.SelectedItems.Count == 0) return;
            ListViewItem selectedItem = lvwItemMap.SelectedItems[0];
            ItemClassMap selectedClassMap = (ItemClassMap)selectedItem.Tag;

            if (MessageBox.Show($"Are you sure you want to remove the details name for '{selectedClassMap.ClassName}'?", "Remove Mapping?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SavedConfig.ItemMap.Remove(selectedClassMap);
                PopulateItemClassMap("");
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (lvwItemMap.SelectedItems.Count == 0) return;
            ListViewItem selectedItem = lvwItemMap.SelectedItems[0];
            ItemClassMap itemMap = (ItemClassMap)selectedItem.Tag;

            frmItemClassMap mapEditor = new frmItemClassMap(itemMap);
            mapEditor.Owner = this;
            if (mapEditor.ShowDialog() == DialogResult.OK)
            {

                //if line already exist for this class update the friendly name.
                ItemClassMap existingMap = SavedConfig.ItemMap.Where(i => i.ClassName.ToLower() == mapEditor.ClassMap.ClassName.ToLower()).FirstOrDefault<ItemClassMap>();
                if (existingMap != null && existingMap.ClassName.Length != 0)
                {
                    //found it, update
                    existingMap.DisplayName = mapEditor.ClassMap.DisplayName;
                    existingMap.Category = mapEditor.ClassMap.Category;
                    existingMap.Image = mapEditor.ClassMap.Image;
                }
                else
                {
                    //not found, add new
                    SavedConfig.ItemMap.Add(mapEditor.ClassMap);
                }

                PopulateItemClassMap(mapEditor.ClassMap.ClassName);

                /*
                selectedItem.Text = mapEditor.ClassMap.Category;
                selectedItem.SubItems[1].Text = mapEditor.ClassMap.FriendlyName;
                selectedItem.SubItems[2].Text = mapEditor.ClassMap.ClassName;
                
                if(mapEditor.ClassMap.Image.Length > 0)
                {
                    if (Program.GetItemImageIndex(mapEditor.ClassMap.Image) ==0)
                    {
                        Program.AddItemImageMap(mapEditor.ClassMap.Image);
                    }
                }

                int imageIndex = Program.GetItemImageIndex(mapEditor.ClassMap.Image);
                selectedItem.ImageIndex = imageIndex-1;

                lvwItemMap.Refresh();
                */

            }
        }

        private void lvwItemMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveItem.Enabled = lvwItemMap.SelectedItems.Count > 0;
            btnEditItem.Enabled = lvwItemMap.SelectedItems.Count > 0;
        }

        private void txtServerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tpgPlayers_Click(object sender, EventArgs e)
        {

        }

        private void optPlayerStructureHide_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlayerOptions();
        }

        private void optPlayerStructureShow_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlayerOptions();
        }

        private void optPlayerTameHide_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlayerOptions();
        }

        private void optPlayerTameShow_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlayerOptions();
        }

        private void optPlayerBodyHide_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlayerOptions();
        }

        private void optPlayerBodyShow_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlayerOptions();
        }

        private void UpdatePlayerOptions()
        {

        }

        private void optPlayerCommandsPrefixAdmincheat_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlayerOptions();
        }

        private void optPlayerCommandsPrefixNone_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlayerOptions();
        }

        private void optPlayerCommandsPrefixCheat_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlayerOptions();
        }

        private void btnRemoveStructure_Click(object sender, EventArgs e)
        {
            if (lvwStructureMap.SelectedItems.Count == 0) return;

            StructureClassMap selectedClassMap = (StructureClassMap)lvwStructureMap.SelectedItems[0].Tag;
            if (MessageBox.Show($"Are you sure you want to remove the display name for '{selectedClassMap.ClassName}'?", "Remove Name?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SavedConfig.StructureMap.Remove(selectedClassMap);
                PopulateStructureClassMap("");
            }
        }

        private void lvwStructureMap_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwStructureMap.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_StructureMap == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_StructureMap)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_StructureMap.Text.StartsWith("> "))
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
                SortingColumn_StructureMap.Text = SortingColumn_StructureMap.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_StructureMap = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_StructureMap.Text = "> " + SortingColumn_StructureMap.Text;
            }
            else
            {
                SortingColumn_StructureMap.Text = "< " + SortingColumn_StructureMap.Text;
            }

            // Create a comparer.
            lvwStructureMap.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwStructureMap.Sort();
        }

        private void cboFtpMap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMapSinglePlayer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditColour_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = lvwColours.SelectedItems[0];
            ColourMap selectedMap = (ColourMap)selectedItem.Tag;
            using (frmColourEditor colourEditor = new frmColourEditor(selectedMap))
            {
                colourEditor.Owner = this;
                if (colourEditor.ShowDialog() == DialogResult.OK)
                {
                    ColourMap existingMap = Program.ProgramConfig.ColourMap.FirstOrDefault(m => m.Id == colourEditor.SelectedMap.Id);
                    if (existingMap != null)
                    {
                        //update existing
                        existingMap.Hex = colourEditor.SelectedMap.Hex;
                    }
                    else
                    {
                        //add new
                        Program.ProgramConfig.ColourMap.Add(colourEditor.SelectedMap);
                    }

                    PopulateColours();
                }
            }
        }

        private void btnEditStructure_Click(object sender, EventArgs e)
        {
            StructureClassMap selectedStructureMap = (StructureClassMap)lvwStructureMap.SelectedItems[0].Tag;

            frmGenericClassMap mapEditor = new frmGenericClassMap(selectedStructureMap);
            mapEditor.Owner = this;
            if (mapEditor.ShowDialog() == DialogResult.OK)
            {
                //if line already exist for this class update the friendly name.
                StructureClassMap existingMap = SavedConfig.StructureMap.Where(d => d.ClassName.ToLower() == mapEditor.ClassMap.ClassName.ToLower()).FirstOrDefault<StructureClassMap>();
                if (existingMap != null && existingMap.ClassName.Length != 0)
                {
                    //found it, update
                    existingMap.FriendlyName = mapEditor.ClassMap.FriendlyName;
                }
                else
                {
                    //not found, add new
                    SavedConfig.StructureMap.Add((StructureClassMap)mapEditor.ClassMap);
                }

                PopulateStructureClassMap(mapEditor.ClassMap.ClassName);
            }
        }

        private void chkApplyFilterStructures_CheckedChanged(object sender, EventArgs e)
        {
            txtStructureFilter.Enabled = !chkApplyFilterStructures.Checked;
            if (!chkApplyFilterStructures.Checked)
            {
                txtStructureFilter.Text = string.Empty;
                PopulateStructureClassMap("");
                txtStructureFilter.Focus();
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;

                string filterText = txtStructureFilter.Text.ToLower();
                ListView selectedListview = lvwStructureMap;

                selectedListview.BeginUpdate();
                int lastIndex = lvwStructureMap.Items.Count - 1;
                for (int currentIndex = lastIndex; currentIndex >= 0; currentIndex--)
                {
                    ListViewItem item = selectedListview.Items[currentIndex];
                    if (!(item.SubItems[0].Text.ToLower().Contains(filterText) | item.SubItems[1].Text.ToLower().Contains(filterText)))
                    {
                        selectedListview.Items.Remove(item);
                    }
                }
                selectedListview.EndUpdate();

                this.Cursor = Cursors.Default;
            }
        }

        private void btnAddStructure_Click(object sender, EventArgs e)
        {
            frmGenericClassMap mapEditor = new frmGenericClassMap(new StructureClassMap());
            mapEditor.Owner = this;
            if (mapEditor.ShowDialog() == DialogResult.OK)
            {
                //if line already exist for this class update the friendly name.
                StructureClassMap existingMap = SavedConfig.StructureMap.Where(d => d.ClassName.ToLower() == mapEditor.ClassMap.ClassName.ToLower()).FirstOrDefault<StructureClassMap>();
                if (existingMap != null && existingMap.ClassName.Length != 0)
                {
                    //found it, update
                    existingMap.FriendlyName = mapEditor.ClassMap.FriendlyName;
                }
                else
                {
                    //not found, add new
                    SavedConfig.StructureMap.Add((StructureClassMap)mapEditor.ClassMap);
                }

                PopulateStructureClassMap(mapEditor.ClassMap.ClassName);
            }
        }

        private void chkApplyFilterColours_CheckedChanged(object sender, EventArgs e)
        {
            ListView selectedListview = lvwColours;
            TextBox selectedTextbox = txtFilterColour;
            CheckBox selectedCheckbox = chkApplyFilterColours;

            selectedTextbox.Enabled = !selectedCheckbox.Checked;
            if (!selectedCheckbox.Checked)
            {
                selectedTextbox.Text = string.Empty;
                PopulateColours();
                selectedTextbox.Focus();
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;

                string filterText = selectedTextbox.Text.ToLower();


                selectedListview.BeginUpdate();
                int lastIndex = selectedListview.Items.Count - 1;
                for (int currentIndex = lastIndex; currentIndex >= 0; currentIndex--)
                {
                    ListViewItem item = selectedListview.Items[currentIndex];
                    bool shouldKeep = false;

                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        if (subItem.Text.ToLower().Contains(filterText))
                        {
                            shouldKeep = true;
                            break;
                        }
                    }

                    if (!shouldKeep)
                    {
                        selectedListview.Items.Remove(item);
                    }

                }
                selectedListview.EndUpdate();

                this.Cursor = Cursors.Default;
            }
        }

        private void btnRemoveColour_Click(object sender, EventArgs e)
        {
            if (lvwColours.SelectedItems.Count == 0) return;

            ColourMap selectedClassMap = (ColourMap)lvwColours.SelectedItems[0].Tag;
            if (MessageBox.Show($"Are you sure you want to remove colour for index '{selectedClassMap.Id}'?", "Remove Colour?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SavedConfig.ColourMap.Remove(selectedClassMap);
                PopulateColours();
            }
        }

        private void btnNewColour_Click(object sender, EventArgs e)
        {
            using (frmColourEditor colourEditor = new frmColourEditor())
            {
                colourEditor.Owner = this;
                if (colourEditor.ShowDialog() == DialogResult.OK)
                {
                    ColourMap existingMap = Program.ProgramConfig.ColourMap.FirstOrDefault(m => m.Id == colourEditor.SelectedMap.Id);
                    if (existingMap != null)
                    {
                        //update existing
                        existingMap.Hex = colourEditor.SelectedMap.Hex;
                    }
                    else
                    {
                        //add new
                        Program.ProgramConfig.ColourMap.Add(colourEditor.SelectedMap);
                    }

                    PopulateColours();
                }
            }
        }

        private void lvwColours_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveColour.Enabled = lvwColours.SelectedItems.Count == 1;
            btnEditColour.Enabled = lvwColours.SelectedItems.Count == 1;
        }

        private void lvwStructureMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditStructure.Enabled = lvwStructureMap.SelectedItems.Count > 0;
            btnRemoveStructure.Enabled = lvwStructureMap.SelectedItems.Count > 0;
        }

        private void lvwColours_Click(object sender, EventArgs e)
        {
            btnRemoveColour.Enabled = lvwColours.SelectedItems.Count == 1;
            btnEditColour.Enabled = lvwColours.SelectedItems.Count == 1;
        }

        private void btnLoadContentPack_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "ASV Content Packs (*.asv)|*.asv";
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtContentPackFilename.Text = dialog.FileName;
                }
            }
        }

        private void tabSettings_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Name == "tpgExport")
            {
                if (!File.Exists(SavedConfig.SelectedFile))
                {
                    MessageBox.Show("Export options only available for .ARK save files.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    e.Cancel = true;
                    return;
                }
                if (Path.GetExtension(SavedConfig.SelectedFile).ToLower() != ".ark")
                {
                    MessageBox.Show("Export options only available for .ARK save files.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    e.Cancel = true;
                    return;
                }

            }

        }

        private void cboExportTribe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboExportTribe.SelectedItem == null) return;
            ASVComboValue selectedValue = (ASVComboValue)cboExportTribe.SelectedItem;
            int.TryParse(selectedValue.Key, out int tribeId);
            PopulateExportPlayers(tribeId);
        }

        private void btnExportContentPack_Click(object sender, EventArgs e)
        {
            if (cm == null) return;

            btnExportContentPack.Enabled = false;

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Save ASV Content Pack";
                dialog.Filter = "ASV Content Pack (*.asv)|*.asv";
                dialog.InitialDirectory = AppContext.BaseDirectory;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    string fileFolder = Path.GetDirectoryName(dialog.FileName);
                    if (!Directory.Exists(fileFolder)) Directory.CreateDirectory(fileFolder);

                    //re-load game data save
                    var contentFile = Program.ProgramConfig.SelectedFile;
                    if (File.Exists(contentFile))
                    {

                        long tribeId = 0;
                        if (cboExportTribe.SelectedItem == null)
                        {
                            ASVComboValue selectedValue = (ASVComboValue)cboExportTribe.SelectedItem;
                            long.TryParse(selectedValue.Key, out tribeId);
                        }

                        long playerId = 0;
                        if (cboExportPlayer.SelectedItem == null)
                        {
                            ASVComboValue selectedValue = (ASVComboValue)cboExportPlayer.SelectedItem;
                            long.TryParse(selectedValue.Key, out playerId);
                        }


                        bool includeGameStructures = chkStructureLocations.Checked;
                        bool includeGameStructureContent = chkStructureContents.Checked;
                        bool includeTribesPlayers = true;
                        bool includeTamed = chkTamedCreatures.Checked;
                        bool includeWild = chkWildCreatures.Checked;
                        bool includePlayerStructures = chkPlayerStructures.Checked;



                        try
                        {

                            //ContentContainer exportContainer = new ContentContainer();
                            //exportContainer.LoadSaveGame(contentFile);
                            ContentPack contentPack = new ContentPack(cm.GetPack(), tribeId, playerId, udExportLat.Value, udExportLon.Value, udExportRadius.Value, includeGameStructures, includeGameStructureContent, includeTribesPlayers, includeTamed, includeWild, includePlayerStructures, includeGameStructureContent);
                            ASVDataManager exportManager = new ASVDataManager(contentPack);
                            exportManager.ExportContentPack(dialog.FileName);
                            MessageBox.Show("Content pack exported successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                    this.Cursor = Cursors.Default;

                }
            }
            btnExportContentPack.Enabled = true;
        }

        private void btnJsonExportAll_Click(object sender, EventArgs e)
        {
            btnJsonExportAll.Enabled = false;

            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.SelectedPath = AppContext.BaseDirectory;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    if (!Directory.Exists(dialog.SelectedPath)) Directory.CreateDirectory(dialog.SelectedPath);
                    cm.ExportAll(dialog.SelectedPath);
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("All data exported successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            btnJsonExportAll.Enabled = true;
        }

        private void btnJsonExportWild_Click(object sender, EventArgs e)
        {
            btnJsonExportWild.Enabled = false;
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Export Wild";
                dialog.Filter = "JSON text file(*.json)|*.json";
                dialog.InitialDirectory = AppContext.BaseDirectory;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    if (!Directory.Exists(Path.GetDirectoryName(dialog.FileName))) Directory.CreateDirectory(Path.GetDirectoryName(dialog.FileName));
                    cm.ExportWild(dialog.FileName);
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Wild data exported successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            btnJsonExportWild.Enabled = true;
        }

        private void btnJsonExportTamed_Click(object sender, EventArgs e)
        {
            btnJsonExportTamed.Enabled = false;
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Export Tamed";
                dialog.Filter = "JSON text file(*.json)|*.json";
                dialog.InitialDirectory = AppContext.BaseDirectory;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    if (!Directory.Exists(Path.GetDirectoryName(dialog.FileName))) Directory.CreateDirectory(Path.GetDirectoryName(dialog.FileName));
                    cm.ExportTamed(dialog.FileName);
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Tamed data exported successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            btnJsonExportTamed.Enabled = true;
        }

        private void btnJsonExportTribes_Click(object sender, EventArgs e)
        {
            btnJsonExportTribes.Enabled = false;

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Exporting Tribes";
                dialog.Filter = "JSON text file(*.json)|*.json";
                dialog.InitialDirectory = AppContext.BaseDirectory;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    if (!Directory.Exists(Path.GetDirectoryName(dialog.FileName))) Directory.CreateDirectory(Path.GetDirectoryName(dialog.FileName));
                    cm.ExportPlayerTribes(dialog.FileName);
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Tribe data exported successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Exporting Tribe Logs";
                dialog.Filter = "JSON text file(*.json)|*.json";
                dialog.InitialDirectory = AppContext.BaseDirectory;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    if (!Directory.Exists(Path.GetDirectoryName(dialog.FileName))) Directory.CreateDirectory(Path.GetDirectoryName(dialog.FileName));
                    cm.ExportPlayerTribeLogs(dialog.FileName);
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Tribe log data exported successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            btnJsonExportTribes.Enabled = true;
        }

        private void btnJsonExportPlayers_Click(object sender, EventArgs e)
        {
            btnJsonExportPlayers.Enabled = false;

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Export Players";
                dialog.Filter = "JSON text file(*.json)|*.json";
                dialog.InitialDirectory = AppContext.BaseDirectory;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    if (!Directory.Exists(Path.GetDirectoryName(dialog.FileName))) Directory.CreateDirectory(Path.GetDirectoryName(dialog.FileName));
                    cm.ExportPlayers(dialog.FileName);
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Player data exported successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            btnJsonExportPlayers.Enabled = true;

        }

        private void btnJsonExportPlayerStructures_Click(object sender, EventArgs e)
        {
            btnJsonExportPlayerStructures.Enabled = false;

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Export Structures";
                dialog.Filter = "JSON text file(*.json)|*.json";
                dialog.InitialDirectory = AppContext.BaseDirectory;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    if (!Directory.Exists(Path.GetDirectoryName(dialog.FileName))) Directory.CreateDirectory(Path.GetDirectoryName(dialog.FileName));
                    cm.ExportPlayerStructures(dialog.FileName);
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Structure data exported successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            btnJsonExportPlayerStructures.Enabled = true;

        }

        private void optContentPack_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void btnEditServer_Click(object sender, EventArgs e)
        {
            if (cboFTPServer.SelectedItem == null) return;
            ServerConfiguration selectedServer = (ServerConfiguration)cboFTPServer.SelectedItem;


            using (frmFtpConfirmPassword passConfirmation = new frmFtpConfirmPassword())
            {
                if (passConfirmation.ShowDialog() == DialogResult.OK)
                {
                    if (passConfirmation.ConfirmedPassword != selectedServer.Password)
                    {
                        MessageBox.Show("Password confirmation failed.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            using (frmFtpFileBrowser serverSetup = new frmFtpFileBrowser(selectedServer))
            {
                if (serverSetup.ShowDialog() == DialogResult.OK)
                {
                    //commit changes to combo tag
                    cboFTPServer.Items[cboFTPServer.SelectedIndex] = serverSetup.SelectedServer;
                    DisplayServerSettings();
                }

            }
        }

        private void btnColoursNotMatchedAdd_Click(object sender, EventArgs e)
        {
            if (lvwColoursNotMapped.SelectedItems.Count == 0) return;
            ListViewItem selectedItem = lvwColoursNotMapped.SelectedItems[0];
            int selectedColourId = (int)selectedItem.Tag;

            using (frmColourEditor colourEditor = new frmColourEditor(selectedColourId))
            {
                colourEditor.Owner = this;
                if (colourEditor.ShowDialog() == DialogResult.OK)
                {
                    ColourMap existingMap = Program.ProgramConfig.ColourMap.FirstOrDefault(m => m.Id == colourEditor.SelectedMap.Id);
                    if (existingMap != null)
                    {
                        //update existing
                        existingMap.Hex = colourEditor.SelectedMap.Hex;
                    }
                    else
                    {
                        //add new
                        Program.ProgramConfig.ColourMap.Add(colourEditor.SelectedMap);
                    }

                    PopulateColours();
                    lvwColoursNotMapped.Items.Remove(selectedItem);
                }
            }
        }

        private void lvwColoursNotMapped_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnColoursNotMatchedAdd.Enabled = lvwColoursNotMapped.SelectedItems.Count > 0;
        }

        private void btnCreaturesNotMappedAdd_Click(object sender, EventArgs e)
        {
            if (lvwCreaturesNotMapped.SelectedItems.Count == 0) return;
            var selectedItem = lvwCreaturesNotMapped.SelectedItems[0];
            string selectedClass = selectedItem.Tag.ToString();

            frmGenericClassMap mapEditor = new frmGenericClassMap(new DinoClassMap() { ClassName = selectedClass });
            mapEditor.Owner = this;
            if (mapEditor.ShowDialog() == DialogResult.OK)
            {
                //if line already exist for this class update the friendly name.
                DinoClassMap existingMap = SavedConfig.DinoMap.Where(d => d.ClassName.ToLower() == mapEditor.ClassMap.ClassName.ToLower()).FirstOrDefault<DinoClassMap>();
                if (existingMap != null && existingMap.ClassName.Length != 0)
                {
                    //found it, update
                    existingMap.FriendlyName = mapEditor.ClassMap.FriendlyName;
                }
                else
                {
                    //not found, add new
                    SavedConfig.DinoMap.Add((DinoClassMap)mapEditor.ClassMap);
                }

                PopulateDinoClassMap(mapEditor.ClassMap.ClassName);
                lvwCreaturesNotMapped.Items.Remove(selectedItem);

            }
        }

        private void lvwCreaturesNotMapped_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreaturesNotMappedAdd.Enabled = lvwCreaturesNotMapped.SelectedItems.Count > 0;
        }

        private void btnItemsNotMatchedAdd_Click(object sender, EventArgs e)
        {
            if (lvwItemsNotMatched.SelectedItems.Count == 0) return;
            string selectedClass = lvwItemsNotMatched.SelectedItems[0].Tag.ToString();
            frmItemClassMap mapEditor = new frmItemClassMap(new ItemClassMap() { ClassName = selectedClass });
            mapEditor.Owner = this;
            if (mapEditor.ShowDialog() == DialogResult.OK)
            {
                //if line already exist for this class update the friendly name.
                ItemClassMap existingMap = SavedConfig.ItemMap.Where(i => i.ClassName.ToLower() == mapEditor.ClassMap.ClassName.ToLower()).FirstOrDefault<ItemClassMap>();
                SavedConfig.ItemMap.Add(mapEditor.ClassMap);

                PopulateItemClassMap(mapEditor.ClassMap.ClassName);
                lvwItemsNotMatched.Items.Remove(lvwItemsNotMatched.SelectedItems[0]);
            }
        }

        private void lvwItemsNotMatched_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnItemsNotMatchedAdd.Enabled = lvwItemsNotMatched.SelectedItems.Count > 0;
        }

        private void lvwStructuresNotMapped_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStructuresNotMappedAdd.Enabled = lvwStructuresNotMapped.SelectedItems.Count > 0;
        }

        private void btnStructuresNotMappedAdd_Click(object sender, EventArgs e)
        {
            if (lvwStructuresNotMapped.SelectedItems.Count == 0) return;
            string selectedClass = lvwStructuresNotMapped.SelectedItems[0].Tag.ToString();

            frmGenericClassMap mapEditor = new frmGenericClassMap(new StructureClassMap() { ClassName = selectedClass });
            mapEditor.Owner = this;
            if (mapEditor.ShowDialog() == DialogResult.OK)
            {
                //if line already exist for this class update the friendly name.
                StructureClassMap existingMap = SavedConfig.StructureMap.Where(d => d.ClassName.ToLower() == mapEditor.ClassMap.ClassName.ToLower()).FirstOrDefault<StructureClassMap>();
                if (existingMap != null && existingMap.ClassName.Length != 0)
                {
                    //found it, update
                    existingMap.FriendlyName = mapEditor.ClassMap.FriendlyName;
                }
                else
                {
                    //not found, add new
                    SavedConfig.StructureMap.Add((StructureClassMap)mapEditor.ClassMap);
                }

                PopulateStructureClassMap("");
                lvwStructuresNotMapped.Items.Remove(lvwStructuresNotMapped.SelectedItems[0]);
            }
        }


        private void lvwColours_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void lvwColoursNotMapped_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void lvwCreaturesNotMapped_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void lvwStructuresNotMapped_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void lvwItemsNotMatched_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }


        private void btnAddARK_Click(object sender, EventArgs e)
        {
            using (frmAddLocalARK selectFile = new frmAddLocalARK())
            {
                if (selectFile.ShowDialog() == DialogResult.OK)
                {
                    //commit changes to combo tag
                    OfflineFileConfiguration config = new OfflineFileConfiguration()
                    {
                        Name = selectFile.OfflineName,
                        Filename = selectFile.Filename,
                        ClusterFolder = selectFile.ClusterFolder,
                        RCONServerIP = selectFile.RCONServer,
                        RCONPassword = selectFile.RCONPassword,
                        RCONPort = selectFile.RCONPort
                    };

                    int newIndex = cboLocalARK.Items.Add(config);
                    cboLocalARK.SelectedIndex = newIndex;
                }
            }
        }

        private void cboLocalARK_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveARK.Enabled = cboLocalARK.SelectedItem != null;
            btnEditARK.Enabled = cboLocalARK.SelectedItem != null;
        }

        private void btnRemoveARK_Click(object sender, EventArgs e)
        {
            cboLocalARK.Items.RemoveAt(cboLocalARK.SelectedIndex);
        }

        private void btnRefreshUnknownItems_Click(object sender, EventArgs e)
        {
            btnRefreshUnknownItems.Enabled = false;

            RefreshUnknownItems();

            btnRefreshUnknownItems.Enabled = true;

        }

        private void btnRefreshUnknownStructures_Click(object sender, EventArgs e)
        {
            btnRefreshUnknownStructures.Enabled = false;

            RefreshUnknownStructures();

            btnRefreshUnknownStructures.Enabled = true;
        }

        private void btnRefreshUnknownCreatures_Click(object sender, EventArgs e)
        {
            btnRefreshUnknownCreatures.Enabled = false;

            RefreshUnknownCreatures();

            btnRefreshUnknownCreatures.Enabled = true;

        }

        private void btnRefreshUnknownColours_Click(object sender, EventArgs e)
        {
            btnRefreshUnknownColours.Enabled = false;

            RefreshUnknownColours();

            btnRefreshUnknownColours.Enabled = true;
        }

        private void btnEditARK_Click(object sender, EventArgs e)
        {
            if (cboLocalARK.SelectedIndex < 0) return;
            int selectedIndex = cboLocalARK.SelectedIndex;
            OfflineFileConfiguration selectedValue = (OfflineFileConfiguration)cboLocalARK.SelectedItem;

            using (frmAddLocalARK selectFile = new frmAddLocalARK(selectedValue))
            {
                if (selectFile.ShowDialog() == DialogResult.OK)
                {
                    //commit changes to combo tag
                    var config = new OfflineFileConfiguration()
                    {
                        Filename = selectFile.Filename,
                        Name = selectFile.OfflineName,
                        ClusterFolder = selectFile.ClusterFolder,
                        RCONServerIP = selectFile.RCONServer,
                        RCONPassword = selectFile.RCONPassword,
                        RCONPort = selectFile.RCONPort
                    };
                    cboLocalARK.Items[selectedIndex] = config;
                }
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = @"Please select location of 'ARK\ShooterGame\Saved'";
                if (Program.ProgramConfig.ArkSavedGameFolder.Length > 0) dialog.SelectedPath = Program.ProgramConfig.ArkSavedGameFolder;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string folderCheck = dialog.SelectedPath;
                    string savedLocal = Path.Combine(folderCheck, @"SavedArksLocal\");
                    if (!Directory.Exists(savedLocal))
                    {

                        return;
                    }

                    Program.ProgramConfig.ArkSavedGameFolder = folderCheck;
                    PopulateSinglePlayerGames();
                }
            }
        }

        private void optFTPSync_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnJsonExportMapStructures_Click(object sender, EventArgs e)
        {
            btnJsonExportMapStructures.Enabled = false;

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Export Map Structures";
                dialog.Filter = "JSON text file(*.json)|*.json";
                dialog.InitialDirectory = AppContext.BaseDirectory;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    if (!Directory.Exists(Path.GetDirectoryName(dialog.FileName))) Directory.CreateDirectory(Path.GetDirectoryName(dialog.FileName));
                    cm.ExportMapStructures(dialog.FileName);
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Map structure data exported successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            btnJsonExportMapStructures.Enabled = true;
        }

        private void lblVivariumHighlight_Click(object sender, EventArgs e)
        {
            ColourMap map = new ColourMap();
            map.Id = int.MaxValue;
            map.Hex = ColorTranslator.ToHtml(lblVivariumHighlight.BackColor);


            frmColourEditor picker = new frmColourEditor(map);
            if (picker.ShowDialog() == DialogResult.OK)
            {
                lblVivariumHighlight.BackColor = ColorTranslator.FromHtml(picker.SelectedMap.Hex);
                lblVivariumHighlight.ForeColor = Program.IdealTextColor(lblVivariumHighlight.BackColor);
                Program.ProgramConfig.HighlightColorVivarium = lblVivariumHighlight.BackColor.ToArgb();

            }


        }

        private void lblCryopodHighlight_Click(object sender, EventArgs e)
        {
            ColourMap map = new ColourMap();
            map.Id = int.MaxValue;
            map.Hex = ColorTranslator.ToHtml(lblCryopodHighlight.BackColor);


            frmColourEditor picker = new frmColourEditor(map);
            if (picker.ShowDialog() == DialogResult.OK)
            {
                lblCryopodHighlight.BackColor = ColorTranslator.FromHtml(picker.SelectedMap.Hex);
                lblCryopodHighlight.ForeColor = Program.IdealTextColor(lblCryopodHighlight.BackColor);
                Program.ProgramConfig.HighlightColorCryopod = lblCryopodHighlight.BackColor.ToArgb();
            }
        }

        private void lblUploadedHighlight_Click(object sender, EventArgs e)
        {
            ColourMap map = new ColourMap();
            map.Id = int.MaxValue;
            map.Hex = ColorTranslator.ToHtml(lblUploadedHighlight.BackColor);


            frmColourEditor picker = new frmColourEditor(map);
            if (picker.ShowDialog() == DialogResult.OK)
            {
                lblUploadedHighlight.BackColor = ColorTranslator.FromHtml(picker.SelectedMap.Hex);
                lblUploadedHighlight.ForeColor = Program.IdealTextColor(lblUploadedHighlight.BackColor);
                Program.ProgramConfig.HighlightColorUploaded = lblUploadedHighlight.BackColor.ToArgb();
            }
        }
    }
}

using ARKViewer.Models;
using ARKViewer.Models.NameMap;
using ASVPack.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARKViewer
{
    public delegate EventHandler InventoryHighlightEvent(float x, float y);


    public partial class frmPlayerInventoryViewer : Form
    {
        public event InventoryHighlightEvent HighlightInventoryEvent;

        private ColumnHeader SortingColumn_Player = null;
        private ColumnHeader SortingColumn_Creature = null;
        private ColumnHeader SortingColumn_Storage = null;
        private ColumnHeader SortingColumn_Scores = null;
        private ColumnHeader SortingColumn_Engrams = null;

        ASVDataManager cm = null;
        ContentPlayer currentPlayer = null;
        List<ContentItem> playerInventory = new List<ContentItem>();
        ContentTribe playerTribe = new ContentTribe();



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



        private void PopulatePlayerExplorerNotes()
        {
            lvwExplorerNotes.BeginUpdate();
            lvwExplorerNotes.Items.Clear();

            if (currentPlayer.ExplorerNotes != null)
            {
                foreach (var noteDescription in currentPlayer.ExplorerNotes)
                {
                    ListViewItem item = lvwExplorerNotes.Items.Add(noteDescription);
                }
            }

            lvwExplorerNotes.ListViewItemSorter = new ListViewComparer(0, SortOrder.Ascending);
            lvwExplorerNotes.Sort();
            lvwExplorerNotes.EndUpdate();
        }
        private void PopulatePlayerAchievements()
        {
            lvwAchievements.BeginUpdate();
            lvwAchievements.Items.Clear();

            if (currentPlayer.Achievments != null)
            {
                foreach (var achievement in currentPlayer.Achievments)
                {
                    ListViewItem item = lvwAchievements.Items.Add(achievement.Description);
                    item.SubItems.Add(achievement.Level);
                }
            }

            lvwAchievements.ListViewItemSorter = new ListViewComparer(0, SortOrder.Ascending);
            lvwAchievements.Sort();
            lvwAchievements.EndUpdate();
        }

        private void PopulatePlayerEngrams()
        {
            lvwEngrams.BeginUpdate();
            lvwEngrams.Items.Clear();

            if (currentPlayer.Engrams != null)
            {

                //var playerItems = selectedPlayer.Creatures;

                ConcurrentBag<ListViewItem> listItems = new ConcurrentBag<ListViewItem>();

                var playerEngrams = currentPlayer.Engrams.Items.GroupBy(g => new
                {
                    g.ClassName,
                    g.CraftedByTribe,
                    g.CraftedByPlayer,
                    g.CustomName,
                    g.IsBlueprint,
                    g.IsEngram,
                    g.Rating
                }).Select(s => new ContentItem
                {
                    ClassName = s.Key.ClassName
                }).ToList();


                Parallel.ForEach(playerEngrams, invItem =>
                {
                    string itemName = invItem.ClassName;
                    string categoryName = "Misc.";
                    int itemIcon = 0;
                    var itemMap = Program.ProgramConfig.ItemMap.Where(i => i.ClassName == invItem.ClassName).FirstOrDefault<ItemClassMap>();
                    if (itemMap != null && itemMap.ClassName != "")
                    {
                        itemName = itemMap.DisplayName;
                        categoryName = itemMap.Category;
                        itemIcon = Program.GetItemImageIndex(itemMap.Image);
                    }


                    ListViewItem newItem = new ListViewItem(itemName);
                    newItem.SubItems.Add(categoryName);
                    newItem.ImageIndex = itemIcon - 1;

                    listItems.Add(newItem);

                });

                lvwEngrams.Items.AddRange(listItems.ToArray());
            }

            lvwEngrams.ListViewItemSorter = new ListViewComparer(0, SortOrder.Ascending);
            lvwEngrams.Sort();
            lvwEngrams.EndUpdate();


            lvwHairstyles.BeginUpdate();
            lvwHairstyles.Items.Clear();

            if (currentPlayer.Hairstyles != null)
            {
                ConcurrentBag<ListViewItem> listItems = new ConcurrentBag<ListViewItem>();

                var playerHairstyles = currentPlayer.Hairstyles.Items.GroupBy(g => new
                {
                    g.ClassName
                }).Select(s => new ContentItem
                {
                    ClassName = s.Key.ClassName
                }).ToList();


                Parallel.ForEach(playerHairstyles, invItem =>
                {
                    string itemName = invItem.ClassName;

                    int itemIcon = 0;
                    var itemMap = Program.ProgramConfig.ItemMap.Where(i => i.ClassName == invItem.ClassName).FirstOrDefault<ItemClassMap>();
                    if (itemMap != null && itemMap.ClassName != "")
                    {
                        itemName = itemMap.DisplayName;
                        itemIcon = Program.GetItemImageIndex(itemMap.Image);
                    }


                    ListViewItem newItem = new ListViewItem(itemName);
                    newItem.ImageIndex = itemIcon - 1;

                    listItems.Add(newItem);

                });

                lvwHairstyles.Items.AddRange(listItems.ToArray());
            }
            if (currentPlayer.FacialStyles != null)
            {
                //var playerItems = selectedPlayer.Creatures;

                ConcurrentBag<ListViewItem> listItems = new ConcurrentBag<ListViewItem>();

                var playerFaceStyles = currentPlayer.FacialStyles.Items.GroupBy(g => new
                {
                    g.ClassName
                }).Select(s => new ContentItem
                {
                    ClassName = s.Key.ClassName
                }).ToList();


                Parallel.ForEach(playerFaceStyles, invItem =>
                {
                    string itemName = invItem.ClassName;

                    int itemIcon = 0;
                    var itemMap = Program.ProgramConfig.ItemMap.Where(i => i.ClassName == invItem.ClassName).FirstOrDefault<ItemClassMap>();
                    if (itemMap != null && itemMap.ClassName != "")
                    {
                        itemName = itemMap.DisplayName;
                        itemIcon = Program.GetItemImageIndex(itemMap.Image);
                    }

                    ListViewItem newItem = new ListViewItem(itemName);
                    newItem.ImageIndex = itemIcon - 1;

                    listItems.Add(newItem);

                });

                lvwHairstyles.Items.AddRange(listItems.ToArray());
            }

            lvwHairstyles.ListViewItemSorter = new ListViewComparer(0, SortOrder.Ascending);
            lvwHairstyles.Sort();
            lvwHairstyles.EndUpdate();


            lvwEmotes.BeginUpdate();
            lvwEmotes.Items.Clear();

            if (currentPlayer.Emotes != null)
            {
                ConcurrentBag<ListViewItem> listItems = new ConcurrentBag<ListViewItem>();

                var playerHairstyles = currentPlayer.Emotes.Items.GroupBy(g => new
                {
                    g.ClassName
                }).Select(s => new ContentItem
                {
                    ClassName = s.Key.ClassName
                }).ToList();


                Parallel.ForEach(playerHairstyles, invItem =>
                {
                    string itemName = invItem.ClassName;

                    int itemIcon = 0;
                    var itemMap = Program.ProgramConfig.ItemMap.Where(i => i.ClassName == invItem.ClassName).FirstOrDefault<ItemClassMap>();
                    if (itemMap != null && itemMap.ClassName != "")
                    {
                        itemName = itemMap.DisplayName;
                        itemIcon = Program.GetItemImageIndex(itemMap.Image);
                    }


                    ListViewItem newItem = new ListViewItem(itemName);
                    newItem.ImageIndex = itemIcon - 1;

                    listItems.Add(newItem);

                });

                lvwEmotes.Items.AddRange(listItems.ToArray());
            }

            lvwEmotes.ListViewItemSorter = new ListViewComparer(0, SortOrder.Ascending);
            lvwEmotes.Sort();
            lvwEmotes.EndUpdate();

        }


        private void PopulatePersonalInventory()
        {
            //populate personal inventory list
            lvwPlayerInventory.BeginUpdate();
            lvwPlayerInventory.Items.Clear();

            if (playerInventory != null)
            {
                //var playerItems = selectedPlayer.Creatures;

                ConcurrentBag<ListViewItem> listItems = new ConcurrentBag<ListViewItem>();

                Parallel.ForEach(playerInventory, invItem =>
                {
                    string itemName = invItem.ClassName;
                    string categoryName = "Misc.";
                    int itemIcon = 0;
                    var itemMap = Program.ProgramConfig.ItemMap.Where(i => i.ClassName == invItem.ClassName).FirstOrDefault<ItemClassMap>();
                    if (itemMap != null && itemMap.ClassName != "")
                    {
                        itemName = itemMap.DisplayName;
                        categoryName = itemMap.Category;
                        itemIcon = Program.GetItemImageIndex(itemMap.Image);
                    }


                    if (itemName.ToLower().Contains(txtPlayerFilter.Text.ToLower()) || categoryName.ToLower().Contains(txtPlayerFilter.Text.ToLower()))
                    {
                        if (!invItem.IsEngram)
                        {
                            string qualityName = "";
                            Color backColor = lvwPlayerInventory.BackColor;
                            Color foreColor = lvwPlayerInventory.ForeColor;
                            if (invItem.Rating.HasValue)
                            {
                                var itemQuality = Program.GetQualityByRating(invItem.Rating.Value);
                                qualityName = itemQuality.QualityName;
                                backColor = itemQuality.QualityColor;
                                foreColor = Program.IdealTextColor(backColor);
                            }

                            string craftedBy = "";
                            if (invItem.CraftedByPlayer != null && invItem.CraftedByPlayer.Length > 0)
                            {
                                craftedBy = $"{invItem.CraftedByPlayer} ({invItem.CraftedByTribe})";
                            }

                            ListViewItem newItem = new ListViewItem(itemName);
                            newItem.ForeColor = foreColor;
                            newItem.BackColor = backColor;
                            newItem.SubItems.Add(invItem.IsBlueprint ? "Yes" : "No");
                            newItem.SubItems.Add(categoryName);
                            newItem.SubItems.Add(qualityName);
                            newItem.SubItems.Add(invItem.Rating.HasValue ? invItem.Rating.Value.ToString() : "");
                            newItem.SubItems.Add(craftedBy);
                            newItem.SubItems.Add(invItem.Quantity.ToString());
                            if (invItem.UploadedTimeInGame != 0)
                            {
                                newItem.SubItems.Add(invItem.UploadedTime.Value.ToString("dd MMM yyyy HH:mm"));
                            }
                            else
                            {
                                newItem.SubItems.Add("");
                            }
                            newItem.ImageIndex = itemIcon - 1;

                            listItems.Add(newItem);
                        }
                    }
                });

                lvwPlayerInventory.Items.AddRange(listItems.ToArray());
            }
            lvwPlayerInventory.EndUpdate();
        }

        private void PopulateMissionScores()
        {
            lvwPlayerScores.Items.Clear();
            foreach (var score in currentPlayer.MissionScores)
            {
                ListViewItem item = lvwPlayerScores.Items.Add(score.MissionTag);
                item.SubItems.Add(score.HighScore.ToString("f2"));
            }
        }

        private void PopulateCreatureInventory()
        {

            //item, category, name, lat, lon, qty
            lvwCreatureInventory.Items.Clear();
            ASVComboValue selectedItem = (ASVComboValue)cboCreatureType.SelectedItem;
            string selectedClass = selectedItem.Key;
            var selectedCreatures = playerTribe.Tames.Where(t => t.ClassName == selectedClass || selectedClass.Length == 0);

            ConcurrentBag<ListViewItem> listItems = new ConcurrentBag<ListViewItem>();

            Parallel.ForEach(selectedCreatures, creature =>
            {
                var inventItems = creature.Inventory.Items.GroupBy(g => new
                {
                    g.ClassName,
                    g.CraftedByTribe,
                    g.CraftedByPlayer,
                    g.CustomName,
                    g.IsBlueprint,
                    g.IsEngram,
                    g.Rating
                }).Select(s => new ContentItem
                {
                    ClassName = s.Key.ClassName,
                    CraftedByTribe = s.Key.CraftedByTribe,
                    CraftedByPlayer = s.Key.CraftedByPlayer,
                    CustomName = s.Key.CustomName,
                    IsBlueprint = s.Key.IsBlueprint,
                    IsEngram = s.Key.IsEngram,
                    Rating = s.Key.Rating,
                    Quantity = s.Sum(i => i.Quantity)
                }).ToList();

                foreach (var invItem in inventItems)
                {


                    string itemName = invItem.ClassName;
                    string categoryName = "Misc.";
                    string creatureName = creature.ClassName;

                    if (creature.Name == null)
                    {
                        var classMap = ARKViewer.Program.ProgramConfig.DinoMap.FirstOrDefault<DinoClassMap>(d => d.ClassName == creature.ClassName);
                        if (classMap != null)
                        {
                            creatureName = classMap.FriendlyName;
                        }
                    }
                    else
                    {
                        creatureName = creature.Name;
                    }

                    int itemIcon = 0;

                    if (ARKViewer.Program.ProgramConfig.ItemMap != null)
                    {
                        var itemMap = ARKViewer.Program.ProgramConfig.ItemMap.Where(i => i.ClassName == invItem.ClassName).FirstOrDefault<ItemClassMap>();
                        if (itemMap != null && itemMap.DisplayName != null)
                        {
                            itemName = itemMap.DisplayName;
                            categoryName = itemMap.Category;
                        }
                    }

                    if (itemName.ToLower().Contains(txtCreatureFilter.Text.ToLower()) || creatureName.ToLower().Contains(txtCreatureFilter.Text.ToLower()))
                    {
                        if (!invItem.IsEngram)
                        {

                            string qualityName = "";
                            Color backColor = lvwCreatureInventory.BackColor;
                            Color foreColor = lvwCreatureInventory.ForeColor;
                            if (invItem.Rating.HasValue)
                            {
                                var itemQuality = Program.GetQualityByRating(invItem.Rating.Value);
                                qualityName = itemQuality.QualityName;
                                backColor = itemQuality.QualityColor;
                                foreColor = Program.IdealTextColor(backColor);
                            }

                            string craftedBy = "";
                            if (invItem.CraftedByPlayer != null && invItem.CraftedByPlayer.Length > 0)
                            {
                                craftedBy = $"{invItem.CraftedByPlayer} ({invItem.CraftedByTribe})";
                            }

                            ListViewItem newItem = new ListViewItem(itemName);
                            newItem.BackColor = backColor;
                            newItem.ForeColor = foreColor;
                            newItem.SubItems.Add(invItem.IsBlueprint ? "Yes" : "No");
                            newItem.SubItems.Add(categoryName);
                            newItem.SubItems.Add(qualityName);
                            newItem.SubItems.Add(invItem.Rating.HasValue ? invItem.Rating.Value.ToString() : "");
                            newItem.SubItems.Add(craftedBy);

                            newItem.SubItems.Add(creatureName);
                            newItem.SubItems.Add(creature.Latitude.GetValueOrDefault(0).ToString("0.00"));
                            newItem.SubItems.Add(creature.Longitude.GetValueOrDefault(0).ToString("0.00"));
                            newItem.SubItems.Add(invItem.Quantity.ToString());
                            newItem.ImageIndex = itemIcon - 1;
                            newItem.Tag = invItem;

                            listItems.Add(newItem);
                        }
                    }


                }

            });

            lvwCreatureInventory.Items.AddRange(listItems.ToArray());
        }

        private void PopulateStructureInventory()
        {
            //item, category, container, lat, lon, qty
            lvwStorageInventory.BeginUpdate();
            lvwStorageInventory.Items.Clear();
            ASVComboValue selectedItem = (ASVComboValue)cboStorageType.SelectedItem;
            string selectedClass = selectedItem.Key;
            var selectedContainers = playerTribe.Structures.Where(t => t.ClassName == selectedClass || selectedClass.Length == 0).Distinct();

            List<string> unmappedItemClassList = new List<string>();

            ConcurrentBag<ListViewItem> listItems = new ConcurrentBag<ListViewItem>();
            Parallel.ForEach(selectedContainers, container =>
            {
                var inventItems = container.Inventory.Items.GroupBy(g => new
                {
                    g.ClassName,
                    g.CraftedByTribe,
                    g.CraftedByPlayer,
                    g.CustomName,
                    g.IsBlueprint,
                    g.IsEngram,
                    g.IsInput,
                    g.Rating
                }).Select(s => new ContentItem
                {
                    ClassName = s.Key.ClassName,
                    CraftedByTribe = s.Key.CraftedByTribe,
                    CraftedByPlayer = s.Key.CraftedByPlayer,
                    CustomName = s.Key.CustomName,
                    IsBlueprint = s.Key.IsBlueprint,
                    IsEngram = s.Key.IsEngram,
                    Rating = s.Key.Rating,
                    IsInput = s.Key.IsInput,
                    Quantity = s.Sum(i => i.Quantity)
                }).ToList();


                Parallel.ForEach(inventItems, invItem =>
                {
                    string itemName = invItem.ClassName;
                    string categoryName = "Misc.";
                    string containerName = container.ClassName;

                    var classMap = ARKViewer.Program.ProgramConfig.StructureMap.FirstOrDefault<StructureClassMap>(d => d.ClassName == container.ClassName);
                    if (classMap != null)
                    {
                        containerName = classMap.FriendlyName;
                    }

                    int itemIcon = 0;

                    if (ARKViewer.Program.ProgramConfig.ItemMap != null)
                    {
                        var itemMap = ARKViewer.Program.ProgramConfig.ItemMap.Where(i => i.ClassName == invItem.ClassName).FirstOrDefault<ItemClassMap>();
                        if (itemMap != null && itemMap.DisplayName != null)
                        {
                            itemName = itemMap.DisplayName;
                            categoryName = itemMap.Category??"Misc.";
                        }
                    }


                    if (categoryName.ToLower().Contains(txtStorageFilter.Text.ToLower()) || itemName.ToLower().Contains(txtStorageFilter.Text.ToLower()))
                    {
                        if (!invItem.IsEngram)
                        {
                            string qualityName = "";
                            Color backColor = lvwStorageInventory.BackColor;
                            Color foreColor = lvwStorageInventory.ForeColor;
                            if (invItem.Rating.HasValue)
                            {
                                var itemQuality = Program.GetQualityByRating(invItem.Rating.Value);
                                qualityName = itemQuality.QualityName;
                                backColor = itemQuality.QualityColor;
                                foreColor = Program.IdealTextColor(backColor);
                            }

                            string craftedBy = "";
                            if (invItem.CraftedByPlayer != null && invItem.CraftedByPlayer.Length > 0)
                            {
                                craftedBy = $"{invItem.CraftedByPlayer} ({invItem.CraftedByTribe})";
                            }


                            ListViewItem newItem = new ListViewItem(itemName);
                            newItem.BackColor = backColor;
                            newItem.ForeColor = foreColor;

                            newItem.SubItems.Add(invItem.IsInput ? "Yes" : "No");
                            newItem.SubItems.Add(invItem.IsBlueprint ? "Yes" : "No");
                            newItem.SubItems.Add(categoryName);
                            newItem.SubItems.Add(qualityName);
                            newItem.SubItems.Add(invItem.Rating.HasValue ? invItem.Rating.Value.ToString() : "");
                            newItem.SubItems.Add(craftedBy);
                            newItem.SubItems.Add(containerName);
                            newItem.SubItems.Add(container.Latitude.GetValueOrDefault(0).ToString("0.00"));
                            newItem.SubItems.Add(container.Longitude.GetValueOrDefault(0).ToString("0.00"));
                            newItem.SubItems.Add(invItem.Quantity.ToString());
                            newItem.ImageIndex = itemIcon - 1;
                            newItem.Tag = invItem;

                            listItems.Add(newItem);
                        }
                    }

                });

            });

            lvwStorageInventory.Items.AddRange(listItems.ToArray());
            lvwStorageInventory.EndUpdate();

        }
        public frmPlayerInventoryViewer(ASVDataManager manager, ContentPlayer selectedPlayer)
        {
            InitializeComponent();
            LoadWindowSettings();

            cm = manager;
            currentPlayer = selectedPlayer;
            playerTribe = cm.GetPlayerTribe(currentPlayer.Id);
            playerInventory = selectedPlayer.Inventory.Items.GroupBy(g => new
            {
                g.ClassName,
                g.CraftedByTribe,
                g.CraftedByPlayer,
                g.CustomName,
                g.IsBlueprint,
                g.IsEngram,
                g.Rating
            }).Select(s => new ContentItem
            {
                ClassName = s.Key.ClassName,
                CraftedByTribe = s.Key.CraftedByTribe,
                CraftedByPlayer = s.Key.CraftedByPlayer,
                CustomName = s.Key.CustomName,
                IsBlueprint = s.Key.IsBlueprint,
                IsEngram = s.Key.IsEngram,
                Rating = s.Key.Rating,
                Quantity = s.Sum(i => i.Quantity)
            }).ToList();

            lvwCreatureInventory.SmallImageList = Program.ItemImageList;
            lvwCreatureInventory.LargeImageList = Program.ItemImageList;
            lvwPlayerInventory.SmallImageList = Program.ItemImageList;
            lvwPlayerInventory.LargeImageList = Program.ItemImageList;
            lvwStorageInventory.LargeImageList = Program.ItemImageList;
            lvwStorageInventory.SmallImageList = Program.ItemImageList;

            currentPlayer = selectedPlayer;
            lblPlayerName.Text = selectedPlayer.CharacterName;
            lblPlayerLevel.Text = selectedPlayer.Level.ToString();

            var tribe = cm.GetPlayerTribe(currentPlayer.Id);
            lblTribeName.Text = tribe.TribeName;
            picPlayerGender.Image = selectedPlayer.Gender == "Male" ? ARKViewer.Properties.Resources.marker_28 : ARKViewer.Properties.Resources.marker_29;

            lblPlayerId.Text = $"Player Id: {selectedPlayer.Id.ToString()}";

            PopulateMissionScores();

            PopulatePersonalInventory();
            PopulatePlayerEngrams();
            PopulatePlayerAchievements();
            PopulatePlayerExplorerNotes();


            //get list of tamed dino types
            cboCreatureType.Items.Clear();
            cboCreatureType.Items.Add(new ASVComboValue("", "[All]"));
            var tamedCreatureTypes = playerTribe.Tames.GroupBy(t => t.ClassName)
                                                        .Select(g => new ASVComboValue() { Key = g.Key, Value = (ARKViewer.Program.ProgramConfig.DinoMap.FirstOrDefault(d => d.ClassName == g.Key) == null ? g.Key : ARKViewer.Program.ProgramConfig.DinoMap.First(d => d.ClassName == g.Key).FriendlyName) })
                                                        .OrderBy(o => o.Value);

            cboCreatureType.Items.AddRange(tamedCreatureTypes.ToArray());

            cboCreatureType.SelectedIndex = 0;


            //get list of inventory containers
            List<ContentStructure> tribeStructures = new List<ContentStructure>();
            var playerStructures = playerTribe.Structures.Where(s => s.Inventory.Items.Count > 0);
            if (playerStructures != null && playerStructures.Count() > 0)
            {
                tribeStructures.AddRange(playerStructures);
            }


            var containerTypes = tribeStructures.GroupBy(s => s.ClassName)
                                    .Select(g => new ASVComboValue() { Key = g.Key, Value = (ARKViewer.Program.ProgramConfig.StructureMap.FirstOrDefault(d => d.ClassName == g.Key) == null ? g.Key : ARKViewer.Program.ProgramConfig.StructureMap.First(d => d.ClassName == g.Key).FriendlyName) })
                                    .OrderBy(o => o.Value);

            cboStorageType.Items.Clear();
            cboStorageType.Items.Add(new ASVComboValue("", "[All]"));
            cboStorageType.Items.AddRange(containerTypes.ToArray());
            cboStorageType.SelectedIndex = 0;

        }

        private void lvwPlayerInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lvwCreatureInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwCreatureInventory.SelectedItems.Count == 0)
            {
                return;
            }


            float lat = 0f;
            float lon = 0f;

            ListViewItem item = lvwCreatureInventory.SelectedItems[0];
            float.TryParse(item.SubItems[3].Text, out lat);
            float.TryParse(item.SubItems[4].Text, out lon);

            HighlightInventoryEvent?.Invoke(lat, lon);


        }

        private void lvwStorageInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwStorageInventory.SelectedItems.Count == 0)
            {
                return;
            }

            float lat = 0f;
            float lon = 0f;

            ListViewItem item = lvwStorageInventory.SelectedItems[0];
            float.TryParse(item.SubItems[3].Text, out lat);
            float.TryParse(item.SubItems[4].Text, out lon);

            HighlightInventoryEvent?.Invoke(lat, lon);


        }



        private void cboCreatureType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCreatureFilter.Text = string.Empty;
            PopulateCreatureInventory();
        }



        private void cboStorageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStorageFilter.Text = string.Empty;
            PopulateStructureInventory();
        }

        private void lvwPlayerInventory_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwPlayerInventory.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_Player == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_Player)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_Player.Text.StartsWith("> "))
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
                SortingColumn_Player.Text = SortingColumn_Player.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_Player = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_Player.Text = "> " + SortingColumn_Player.Text;
            }
            else
            {
                SortingColumn_Player.Text = "< " + SortingColumn_Player.Text;
            }

            // Create a comparer.
            lvwPlayerInventory.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwPlayerInventory.Sort();
        }

        private void lvwCreatureInventory_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwCreatureInventory.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_Creature == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_Creature)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_Creature.Text.StartsWith("> "))
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
                SortingColumn_Creature.Text = SortingColumn_Creature.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_Creature = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_Creature.Text = "> " + SortingColumn_Creature.Text;
            }
            else
            {
                SortingColumn_Creature.Text = "< " + SortingColumn_Creature.Text;
            }

            // Create a comparer.
            lvwCreatureInventory.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwCreatureInventory.Sort();
        }

        private void lvwStorageInventory_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwStorageInventory.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_Storage == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_Storage)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_Storage.Text.StartsWith("> "))
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
                SortingColumn_Storage.Text = SortingColumn_Storage.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_Storage = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_Storage.Text = "> " + SortingColumn_Storage.Text;
            }
            else
            {
                SortingColumn_Storage.Text = "< " + SortingColumn_Storage.Text;
            }

            // Create a comparer.
            lvwStorageInventory.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwStorageInventory.Sort();
        }

        private void txtPlayerFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCreatureFilter_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtStorageFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkFilterStorage_CheckedChanged(object sender, EventArgs e)
        {

            txtStorageFilter.Enabled = !chkApplyFilterStorage.Checked;
            if (chkApplyFilterStorage.Checked)
            {
                txtStorageFilter.Enabled = false;
            }
            else
            {
                txtStorageFilter.Enabled = true;
                txtStorageFilter.Text = string.Empty;
                txtStorageFilter.Focus();

            }
            PopulateStructureInventory();
        }

        private void chkApplyFilterPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApplyFilterPlayer.Checked)
            {
                txtPlayerFilter.Enabled = false;
            }
            else
            {
                txtPlayerFilter.Text = string.Empty;
                txtPlayerFilter.Enabled = true;
                txtPlayerFilter.Focus();
            }

            PopulatePersonalInventory();
        }

        private void chkApplyFilterCreature_CheckedChanged(object sender, EventArgs e)
        {
            txtCreatureFilter.Enabled = !chkApplyFilterCreature.Checked;
            if (chkApplyFilterCreature.Checked)
            {
                txtCreatureFilter.Enabled = false;
            }
            else
            {
                txtCreatureFilter.Enabled = true;
                txtCreatureFilter.Text = string.Empty;
                txtCreatureFilter.Focus();
            }
            PopulateCreatureInventory();
        }

        private void lvwPlayerScores_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwPlayerScores.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_Scores == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_Scores)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_Scores.Text.StartsWith("> "))
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
                SortingColumn_Scores.Text = SortingColumn_Scores.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_Scores = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_Scores.Text = "> " + SortingColumn_Scores.Text;
            }
            else
            {
                SortingColumn_Scores.Text = "< " + SortingColumn_Scores.Text;
            }

            // Create a comparer.
            lvwPlayerScores.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwPlayerScores.Sort();
        }

        private void frmPlayerInventoryViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateWindowSettings();
        }

        private void lvwEngrams_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwEngrams.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_Engrams == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_Engrams)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_Engrams.Text.StartsWith("> "))
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
                SortingColumn_Engrams.Text = SortingColumn_Engrams.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_Engrams = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_Engrams.Text = "> " + SortingColumn_Engrams.Text;
            }
            else
            {
                SortingColumn_Engrams.Text = "< " + SortingColumn_Engrams.Text;
            }

            // Create a comparer.
            lvwEngrams.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwEngrams.Sort();
        }

        private void lblPlayerId_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblPlayerId.Text.Replace("Player Id:", ""));
            MessageBox.Show("Player Id copied to clipboard.", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkApplyFilterStorage_CheckedChanged(object sender, EventArgs e)
        {
            txtStorageFilter.Enabled = !chkApplyFilterStorage.Checked;
            if (chkApplyFilterStorage.Checked)
            {
                txtStorageFilter.Enabled = false;
            }
            else
            {
                txtStorageFilter.Enabled = true;
                txtStorageFilter.Text = string.Empty;
                txtStorageFilter.Focus();
            }
            PopulateStructureInventory();
        }
    }
}

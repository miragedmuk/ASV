using ARKViewer.Models;
using ARKViewer.Models.NameMap;
using ASVPack.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARKViewer
{
    public partial class frmDeathCacheViewer : Form
    {
        ContentDroppedItem droppedItem = null;
        List<ContentItem> droppedInventory = new List<ContentItem>();
        ColumnHeader SortingColumn_Inventory = null;


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


        public frmDeathCacheViewer(ContentDroppedItem dropItem, List<ContentItem> contentItems)
        {
            InitializeComponent();
            LoadWindowSettings();

            droppedItem = dropItem;
            droppedInventory = contentItems;

            string droppedBy = dropItem.DroppedByName;
            lblPlayerName.Text = droppedBy;

            PopulateDeathCacheInventory();


        }

        private void PopulateDeathCacheInventory()
        {

            lvwInventory.Items.Clear();


            if (droppedInventory != null && droppedInventory.Count > 0)
            {
                var inventItems = droppedInventory.GroupBy(g => new
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


                ConcurrentBag<ListViewItem> listItems = new ConcurrentBag<ListViewItem>();
                Parallel.ForEach(inventItems, invItem =>
                {
                    string itemName = invItem.ClassName;
                    string categoryName = "Misc.";
                    int itemIcon = 0;
                    var itemMap = Program.ProgramConfig.ItemMap.Where(i => i.ClassName == invItem.ClassName).FirstOrDefault<ItemClassMap>();
                    if (itemMap != null && itemMap.ClassName != "")
                    {
                        itemName = itemMap.DisplayName;
                        itemIcon = Program.GetItemImageIndex(itemMap.Image);
                        categoryName = itemMap.Category;
                    }



                    if (itemName.ToLower().Contains(txtFilter.Text.ToLower()) || categoryName.ToLower().Contains(txtFilter.Text.ToLower()))
                    {
                        if (!invItem.IsEngram)
                        {

                            string qualityName = "";
                            Color backColor = lvwInventory.BackColor;
                            Color foreColor = lvwInventory.ForeColor;
                            if (invItem.Rating.HasValue)
                            {
                                var itemQuality = Program.GetQualityByRating(invItem.Rating.Value);
                                qualityName = itemQuality.QualityName;
                                backColor = itemQuality.QualityColor;
                                foreColor = Program.IdealTextColor(backColor);
                            }


                            ListViewItem newItem = new ListViewItem(itemName);
                            newItem.BackColor = backColor;
                            newItem.ForeColor = foreColor;
                            newItem.SubItems.Add(invItem.IsBlueprint ? "Yes" : "No");
                            newItem.SubItems.Add(categoryName);
                            newItem.SubItems.Add(qualityName);
                            newItem.SubItems.Add(invItem.Quantity.ToString());
                            newItem.ImageIndex = itemIcon - 1;

                            listItems.Add(newItem);
                        }
                    }

                });

                lvwInventory.Items.AddRange(listItems.ToArray());

            }

        }

        private void chkApplyFilterDinos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmDeathCacheViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateWindowSettings();
        }

        private void lvwInventory_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwInventory.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_Inventory == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_Inventory)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_Inventory.Text.StartsWith("> "))
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
                SortingColumn_Inventory.Text = SortingColumn_Inventory.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_Inventory = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_Inventory.Text = "> " + SortingColumn_Inventory.Text;
            }
            else
            {
                SortingColumn_Inventory.Text = "< " + SortingColumn_Inventory.Text;
            }

            // Create a comparer.
            lvwInventory.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwInventory.Sort();
        }
    }
}

using ARKViewer.Models;
using ASVPack.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ARKViewer
{
    public partial class frmMapToolboxMarkers : Form
    {
        private bool isLoading = false;
        private frmMapView MapViewer = null;

        private ColumnHeader SortingColumn_Markers = null;

        private static frmMapToolboxMarkers inst;
        public static frmMapToolboxMarkers GetForm(frmMapView viewer)
        {
            if (inst == null || inst.IsDisposed)
            {
                inst = new frmMapToolboxMarkers(viewer);
                inst.Owner = viewer;
            }

            return inst;
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



        private frmMapToolboxMarkers(frmMapView viewer)
        {
            InitializeComponent();
            LoadWindowSettings();
            MapViewer = viewer;
            PopulateCategories();
        }

        private void frmMapToolboxMarkers_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateWindowSettings();
        }


        private void PopulateCategories()
        {
            cboCategory.Items.Clear();
            cboCategory.Items.Add(new ASVComboValue("", "[All]"));
            var groupedMarkers = MapViewer.CustomMarkers.GroupBy(x => x.Category).ToList().Select(x => x.Key).ToList();
            if (groupedMarkers != null && groupedMarkers.Count > 0)
            {
                groupedMarkers.OrderBy(x => x).ToList().ForEach(x =>
                {
                    if (x.Length > 0) cboCategory.Items.Add(new ASVComboValue(x, x));
                });
            }
            cboCategory.SelectedIndex = 0;

        }
        private void PopulateCustomMarkers()
        {

            lvwMapMarkers.ItemChecked -= lvwMapMarkers_ItemChecked;

            isLoading = true;
            string selectedCategory = "";
            if (cboCategory.SelectedItem != null) selectedCategory = ((ASVComboValue)cboCategory.SelectedItem).Key;

            lvwMapMarkers.SmallImageList = Program.MarkerImageList;
            lvwMapMarkers.LargeImageList = Program.MarkerImageList;
            lvwMapMarkers.Items.Clear();
            lvwMapMarkers.Refresh();
            lvwMapMarkers.BeginUpdate();

            List<ListViewItem> newItems = new List<ListViewItem>();

            foreach (var marker in MapViewer.CustomMarkers.OrderBy(o => o.Name))
            {
                if (txtMarkerFilter.TextLength == 0 || marker.Name.ToLower().Contains(txtMarkerFilter.Text.ToLower()))
                {

                    if (selectedCategory == "" || marker.Category == selectedCategory)
                    {
                        ListViewItem newItem = new ListViewItem(marker.Name);
                        newItem.ImageIndex = Program.GetMarkerImageIndex(marker.Image) - 1;
                        newItem.SubItems.Add(marker.Lat.ToString("0.00"));
                        newItem.SubItems.Add(marker.Lon.ToString("0.00"));
                        newItem.Tag = marker;

                        if (marker.Displayed)
                        {
                            newItem.Checked = true;
                        }

                        newItems.Add(newItem);
                    }

                }
            }

            lvwMapMarkers.Items.AddRange(newItems.ToArray());
            lvwMapMarkers.EndUpdate();

            lvwMapMarkers.ItemChecked += lvwMapMarkers_ItemChecked;

            isLoading = false;
        }

        private void lvwMapMarkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwMapMarkers.Items.Count == 0) return;

            float selectedX = 0;
            float selectedY = 0;
            ContentMarker selectedMarker = null;

            List<Tuple<float, float>> selectedLocations = new List<Tuple<float, float>>();

            if (lvwMapMarkers.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvwMapMarkers.SelectedItems)
                {
                    selectedMarker = (ContentMarker)item.Tag;
                    selectedX = (float)selectedMarker.Lon;
                    selectedY = (float)selectedMarker.Lat;

                    selectedLocations.Add(new Tuple<float, float>(selectedY, selectedX));
                }

            }
            MapViewer.DrawTestMap(selectedLocations);

            btnEditMarker.Enabled = selectedMarker != null && selectedMarker.InGameMarker == false;
            btnRemoveMarker.Enabled = selectedMarker != null && selectedMarker.InGameMarker == false;
        }

        private void lvwMapMarkers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvwMapMarkers.Items.Count == 0 || isLoading) return;


            List<Tuple<float, float>> selectedLocations = new List<Tuple<float, float>>();

            float selectedX = 0;
            float selectedY = 0;

            if (lvwMapMarkers.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvwMapMarkers.SelectedItems)
                {
                    ContentMarker selectedMarker = (ContentMarker)item.Tag;
                    selectedX = (float)selectedMarker.Lon;
                    selectedY = (float)selectedMarker.Lat;

                    selectedLocations.Add(new Tuple<float, float>(selectedY, selectedX));
                }
            }

            ContentMarker checkMarker = (ContentMarker)e.Item.Tag;
            if (checkMarker != null)
            {
                checkMarker.Displayed = e.Item.Checked;

                var mapViewMarker = MapViewer.CustomMarkers.Find(x => x.Map == checkMarker.Map && x.Name == checkMarker.Name);
                mapViewMarker.Displayed = checkMarker.Displayed;

                var configMarker = Program.ProgramConfig.MapMarkerList.Find(x => x.Map == checkMarker.Map && x.Name == checkMarker.Name);
                mapViewMarker.Displayed = checkMarker.Displayed;

                MapViewer.DrawTestMap(selectedLocations);
            }

        }

        private void UpdateSavedMarkers()
        {
            if (isLoading) return;
            MapViewer.CustomMarkers = new List<ContentMarker>();

            foreach (ListViewItem checkedItem in lvwMapMarkers.Items)
            {
                ContentMarker itemMarker = (ContentMarker)checkedItem.Tag;
                itemMarker.Displayed = checkedItem.Checked;
                MapViewer.CustomMarkers.Add(itemMarker);
            }
        }

        private void lvwMapMarkers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwMapMarkers.Columns[e.Column];

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
            lvwMapMarkers.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwMapMarkers.Sort();
        }

        private void btnAddMarker_Click(object sender, EventArgs e)
        {
            frmMarkerEditor markerEditor = new frmMarkerEditor(MapViewer.GetMapFileName(), ARKViewer.Program.ProgramConfig.MapMarkerList, "");
            markerEditor.Owner = this;
            if (markerEditor.ShowDialog() == DialogResult.OK)
            {
                ListViewItem newItem = lvwMapMarkers.Items.Add(markerEditor.EditingMarker.Name);
                newItem.Tag = markerEditor.EditingMarker;

                newItem.ImageIndex = Program.GetMarkerImageIndex(markerEditor.EditingMarker.Image) - 1;
                newItem.SubItems.Add(markerEditor.EditingMarker.Lat.ToString("0.00"));
                newItem.SubItems.Add(markerEditor.EditingMarker.Lon.ToString("0.00"));

                MapViewer.CustomMarkers.Add(markerEditor.EditingMarker);
                Program.ProgramConfig.MapMarkerList.Add(markerEditor.EditingMarker);
                MapViewer.DrawTestMap(new List<Tuple<float, float>>());
            }
        }

        private void btnRemoveMarker_Click(object sender, EventArgs e)
        {
            if (lvwMapMarkers.SelectedItems.Count == 0) return;

            ListViewItem selectedItem = lvwMapMarkers.SelectedItems[0];
            ContentMarker selectedMarker = (ContentMarker)selectedItem.Tag;
            if (MessageBox.Show($"Are you sure you want to remove your marker for '{selectedMarker.Name}'?", "Remove Marker?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lvwMapMarkers.Items.Remove(selectedItem);


                var mapViewMarker = MapViewer.CustomMarkers.Find(x => x.Map == selectedMarker.Map && x.Name == selectedMarker.Name);
                if (mapViewMarker != null) MapViewer.CustomMarkers.Remove(mapViewMarker);

                var configMarker = Program.ProgramConfig.MapMarkerList.Find(x => x.Map == selectedMarker.Map && x.Name == selectedMarker.Name);
                if (configMarker != null) Program.ProgramConfig.MapMarkerList.Remove(configMarker);

                MapViewer.DrawTestMap(new List<Tuple<float, float>>());
            }
        }

        private void chkApplyFilterMarkers_CheckedChanged(object sender, EventArgs e)
        {
            txtMarkerFilter.Enabled = !chkApplyFilterMarkers.Checked;
            if (!chkApplyFilterMarkers.Checked)
            {
                txtMarkerFilter.Text = string.Empty;
                txtMarkerFilter.Focus();
            }

            PopulateCustomMarkers();
        }

        private void btnEditMarker_Click(object sender, EventArgs e)
        {
            if (lvwMapMarkers.SelectedItems.Count == 0) return;

            ListViewItem selectedItem = lvwMapMarkers.SelectedItems[0];
            ContentMarker selectedMarker = (ContentMarker)selectedItem.Tag;

            frmMarkerEditor markerEditor = new frmMarkerEditor(MapViewer.GetMapFileName(), Program.ProgramConfig.MapMarkerList, selectedMarker.Name);
            markerEditor.Owner = this;
            if (markerEditor.ShowDialog() == DialogResult.OK)
            {
                selectedItem.Text = markerEditor.EditingMarker.Name;
                //selectedItem.ImageKey = $"marker_{markerEditor.EditingMarker.Image}";
                selectedItem.SubItems[1].Text = markerEditor.EditingMarker.Lat.ToString("0.00");
                selectedItem.SubItems[2].Text = markerEditor.EditingMarker.Lon.ToString("0.00");
                selectedItem.Tag = markerEditor.EditingMarker;

                var mapViewMarker = MapViewer.CustomMarkers.Find(x => x.Map == selectedMarker.Map && x.Name == selectedMarker.Name);
                if (mapViewMarker != null) MapViewer.CustomMarkers.Remove(mapViewMarker);
                MapViewer.CustomMarkers.Add(markerEditor.EditingMarker);

                var configMarker = Program.ProgramConfig.MapMarkerList.Find(x => x.Map == selectedMarker.Map && x.Name == selectedMarker.Name);
                if (configMarker != null) Program.ProgramConfig.MapMarkerList.Remove(configMarker);
                Program.ProgramConfig.MapMarkerList.Add(markerEditor.EditingMarker);


                PopulateCategories();

                MapViewer.DrawTestMap(new List<Tuple<float, float>>());

            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCustomMarkers();
        }
    }
}

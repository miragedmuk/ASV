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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ARKViewer
{
    public partial class frmBreedingLines : Form
    {

        ColumnHeader SortingColumn_Ancestors = null;
        ColumnHeader SortingColumn_Tamed = null;
        ColumnHeader SortingColumn_Wild = null;

        ContentTamedCreature tame = null;
        ASVDataManager cm = null;
        bool isLoading = false;


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



        private void PopulateWildLovers()
        {

            var searchRankCriteria = Program.ProgramConfig.BreedingSearchOptions.Find(x => x.ClassName == tame.ClassName & !x.Tamed);
            if (searchRankCriteria == null) searchRankCriteria = new ASVBreedingSearch()
            {
                ClassName = tame.ClassName,
                Tamed = false
            };
            var wildMatches = cm.GetWildCreatures(0, int.MaxValue, 50, 50, 250, tame.ClassName, "").Where(w => w.Gender != tame.Gender).ToList();
            lvwWildLovers.BeginUpdate();
            lvwWildLovers.Items.Clear();

            if (wildMatches != null && wildMatches.Count > 0)
            {
                ConcurrentBag<ListViewItem> wildBag = new ConcurrentBag<ListViewItem>();

                Parallel.ForEach(wildMatches, wild =>
                {

                    ASVBreedingResult rankedResult = new ASVBreedingResult(tame, wild, searchRankCriteria);
                    decimal percentRank = (rankedResult.RankCombined / rankedResult.MaxRank) * 100;

                    //Rank, Lvl, Lat, Lon, HP, Stam, Melee, Weight, Speed, Food, Oxygen, Craft, c0, c1, c2, c3, c4, c5
                    ListViewItem newItem = new ListViewItem(percentRank.ToString("f2"));
                    newItem.UseItemStyleForSubItems = false;

                    newItem.SubItems.Add(wild.BaseLevel.ToString());
                    newItem.SubItems.Add(wild.Latitude.GetValueOrDefault(0).ToString("f2"));
                    newItem.SubItems.Add(wild.Longitude.GetValueOrDefault(0).ToString("f2"));

                    newItem.SubItems.Add(wild.BaseStats[0].ToString());
                    newItem.SubItems.Add(wild.BaseStats[1].ToString());
                    newItem.SubItems.Add(wild.BaseStats[8].ToString());
                    newItem.SubItems.Add(wild.BaseStats[7].ToString());
                    newItem.SubItems.Add(wild.BaseStats[9].ToString());
                    newItem.SubItems.Add(wild.BaseStats[4].ToString());
                    newItem.SubItems.Add(wild.BaseStats[3].ToString());
                    newItem.SubItems.Add(wild.BaseStats[11].ToString());

                    int colourCheck = (int)wild.Colors[0];
                    newItem.SubItems.Add(colourCheck == 0 ? "N/A" : wild.Colors[0].ToString()); //14
                    ColourMap selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)wild.Colors[0]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        newItem.SubItems[newItem.SubItems.Count - 1].BackColor = selectedColor.Color;
                        newItem.SubItems[newItem.SubItems.Count - 1].ForeColor = selectedColor.Color;
                    }

                    colourCheck = (int)wild.Colors[1];
                    newItem.SubItems.Add(colourCheck == 0 ? "N/A" : wild.Colors[1].ToString()); //15
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)wild.Colors[1]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        newItem.SubItems[newItem.SubItems.Count - 1].BackColor = selectedColor.Color;
                        newItem.SubItems[newItem.SubItems.Count - 1].ForeColor = selectedColor.Color;
                    }

                    colourCheck = (int)wild.Colors[2];
                    newItem.SubItems.Add(colourCheck == 0 ? "N/A" : wild.Colors[2].ToString()); //16
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)wild.Colors[2]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        newItem.SubItems[newItem.SubItems.Count - 1].BackColor = selectedColor.Color;
                        newItem.SubItems[newItem.SubItems.Count - 1].ForeColor = selectedColor.Color;
                    }

                    colourCheck = (int)wild.Colors[3];
                    newItem.SubItems.Add(colourCheck == 0 ? "N/A" : wild.Colors[3].ToString()); //17
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)wild.Colors[3]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        newItem.SubItems[newItem.SubItems.Count - 1].BackColor = selectedColor.Color;
                        newItem.SubItems[newItem.SubItems.Count - 1].ForeColor = selectedColor.Color;
                    }

                    colourCheck = (int)wild.Colors[4];
                    newItem.SubItems.Add(colourCheck == 0 ? "N/A" : wild.Colors[4].ToString()); //18
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)wild.Colors[4]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        newItem.SubItems[newItem.SubItems.Count - 1].BackColor = selectedColor.Color;
                        newItem.SubItems[newItem.SubItems.Count - 1].ForeColor = selectedColor.Color;
                    }

                    colourCheck = (int)wild.Colors[5];
                    newItem.SubItems.Add(colourCheck == 0 ? "N/A" : wild.Colors[5].ToString()); //19
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)wild.Colors[5]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        newItem.SubItems[newItem.SubItems.Count - 1].BackColor = selectedColor.Color;
                        newItem.SubItems[newItem.SubItems.Count - 1].ForeColor = selectedColor.Color;
                    }


                    newItem.Tag = wild;

                    wildBag.Add(newItem);
                });

                if (wildBag != null && wildBag.Count > 0)
                {
                    lvwWildLovers.Items.AddRange(wildBag.OrderByDescending(o => ((ContentWildCreature)o.Tag).BaseLevel).ToArray());
                }
            }

            lvwWildLovers.EndUpdate();

        }

        private void PopulateTamedLovers()
        {


            ASVBreedingSearch searchRankCriteria = Program.ProgramConfig.BreedingSearchOptions.Find(x => x.ClassName == tame.ClassName && x.Tamed);
            if (searchRankCriteria == null) searchRankCriteria = new ASVBreedingSearch() { ClassName = tame.ClassName, Tamed = true };


            var tameMatches = cm.GetTamedCreatures(tame.ClassName, chkAllTribes.Checked ? 0 : tame.TargetingTeam, 0, 0, "")
                                .Where(t => t.Gender != tame.Gender)
                                .OrderByDescending(o => o.BaseLevel)
                                .ToList();

            lvwTameLovers.BeginUpdate();
            lvwTameLovers.Items.Clear();

            if (tameMatches != null && tameMatches.Count > 0)
            {
                ConcurrentBag<ListViewItem> tameBag = new ConcurrentBag<ListViewItem>();

                Parallel.ForEach(tameMatches, tamedCreature =>
                {
                    var dinoMap = ARKViewer.Program.ProgramConfig.DinoMap.Where(dino => dino.ClassName == tamedCreature.ClassName).FirstOrDefault();

                    string creatureClassName = dinoMap == null ? tamedCreature.ClassName : dinoMap.FriendlyName;
                    string creatureName = dinoMap == null ? tamedCreature.ClassName : dinoMap.FriendlyName;

                    if (tamedCreature.Name != null)
                    {
                        creatureName = tamedCreature.Name;
                    }


                    ASVBreedingResult rankedResult = new ASVBreedingResult(tame, tamedCreature, searchRankCriteria);
                    decimal percentRank = (rankedResult.RankCombined / rankedResult.MaxRank) * 100;

                    //Rank, Lvl, Lat, Lon, HP, Stam, Melee, Weight, Speed, Food, Oxygen, Craft, c0, c1, c2, c3, c4, c5
                    ListViewItem newItem = new ListViewItem(percentRank.ToString("f2"));
                    newItem.UseItemStyleForSubItems = false;
                    newItem.SubItems.Add(tamedCreature.TribeName);
                    newItem.SubItems.Add(creatureName);
                    newItem.SubItems.Add(tamedCreature.BaseLevel.ToString());
                    newItem.SubItems.Add(tamedCreature.Level.ToString());


                    newItem.SubItems.Add(tamedCreature.Latitude.GetValueOrDefault(0).ToString("f2"));
                    newItem.SubItems.Add(tamedCreature.Longitude.GetValueOrDefault(0).ToString("f2"));
                    if (optStatsBase.Checked)
                    {

                        newItem.SubItems.Add(tamedCreature.BaseStats[0].ToString());
                        newItem.SubItems.Add(tamedCreature.BaseStats[1].ToString());
                        newItem.SubItems.Add(tamedCreature.BaseStats[8].ToString());
                        newItem.SubItems.Add(tamedCreature.BaseStats[7].ToString());
                        newItem.SubItems.Add(tamedCreature.BaseStats[9].ToString());
                        newItem.SubItems.Add(tamedCreature.BaseStats[4].ToString());
                        newItem.SubItems.Add(tamedCreature.BaseStats[3].ToString());
                        newItem.SubItems.Add(tamedCreature.BaseStats[11].ToString());
                    }
                    else
                    {
                        newItem.SubItems.Add(tamedCreature.TamedStats[0].ToString());
                        newItem.SubItems.Add(tamedCreature.TamedStats[1].ToString());
                        newItem.SubItems.Add(tamedCreature.TamedStats[8].ToString());
                        newItem.SubItems.Add(tamedCreature.TamedStats[7].ToString());
                        newItem.SubItems.Add(tamedCreature.TamedStats[9].ToString());
                        newItem.SubItems.Add(tamedCreature.TamedStats[4].ToString());
                        newItem.SubItems.Add(tamedCreature.TamedStats[3].ToString());
                        newItem.SubItems.Add(tamedCreature.TamedStats[11].ToString());

                    }

                    newItem.SubItems.Add(tamedCreature.TamedOnServerName);
                    string tamerName = tamedCreature.TamerName != null ? tamedCreature.TamerName : "";
                    string imprinterName = tamedCreature.ImprinterName;
                    if (tamerName.Length == 0)
                    {
                        if (tamedCreature.ImprintedPlayerId != 0)
                        {
                            var tamer = cm.GetPlayers(0, tamedCreature.ImprintedPlayerId, "").FirstOrDefault<ContentPlayer>();
                            if (tamer != null) tamerName = tamer.CharacterName;
                        }
                    }

                    newItem.SubItems.Add(tamerName);
                    newItem.SubItems.Add(tamedCreature.ImprinterName);
                    newItem.SubItems.Add((tamedCreature.ImprintQuality * 100).ToString("f0"));

                    bool isStored = tamedCreature.IsCryo | tamedCreature.IsVivarium;

                    newItem.SubItems.Add(isStored.ToString());

                    if (tamedCreature.IsCryo)
                    {
                        newItem.BackColor = Color.LightSkyBlue;
                        foreach (ListViewItem.ListViewSubItem subItem in newItem.SubItems)
                        {
                            subItem.BackColor = Color.LightSkyBlue;
                        }
                    }
                    else if (tamedCreature.IsVivarium)
                    {
                        newItem.BackColor = Color.LightGreen;
                        foreach (ListViewItem.ListViewSubItem subItem in newItem.SubItems)
                        {
                            subItem.BackColor = Color.LightGreen;
                        }
                    }

                    int colourCheck = (int)tamedCreature.Colors[0];
                    newItem.SubItems.Add(colourCheck == 0 ? "N/A" : tamedCreature.Colors[0].ToString()); //14
                    ColourMap selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tamedCreature.Colors[0]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        newItem.SubItems[newItem.SubItems.Count - 1].BackColor = selectedColor.Color;
                        newItem.SubItems[newItem.SubItems.Count - 1].ForeColor = selectedColor.Color;
                    }

                    colourCheck = (int)tamedCreature.Colors[1];
                    newItem.SubItems.Add(colourCheck == 0 ? "N/A" : tamedCreature.Colors[1].ToString()); //15
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tamedCreature.Colors[1]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        newItem.SubItems[newItem.SubItems.Count - 1].BackColor = selectedColor.Color;
                        newItem.SubItems[newItem.SubItems.Count - 1].ForeColor = selectedColor.Color;
                    }

                    colourCheck = (int)tamedCreature.Colors[2];
                    newItem.SubItems.Add(colourCheck == 0 ? "N/A" : tamedCreature.Colors[2].ToString()); //16
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tamedCreature.Colors[2]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        newItem.SubItems[newItem.SubItems.Count - 1].BackColor = selectedColor.Color;
                        newItem.SubItems[newItem.SubItems.Count - 1].ForeColor = selectedColor.Color;
                    }

                    colourCheck = (int)tamedCreature.Colors[3];
                    newItem.SubItems.Add(colourCheck == 0 ? "N/A" : tamedCreature.Colors[3].ToString()); //17
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tamedCreature.Colors[3]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        newItem.SubItems[newItem.SubItems.Count - 1].BackColor = selectedColor.Color;
                        newItem.SubItems[newItem.SubItems.Count - 1].ForeColor = selectedColor.Color;
                    }

                    colourCheck = (int)tamedCreature.Colors[4];
                    newItem.SubItems.Add(colourCheck == 0 ? "N/A" : tamedCreature.Colors[4].ToString()); //18
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tamedCreature.Colors[4]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        newItem.SubItems[newItem.SubItems.Count - 1].BackColor = selectedColor.Color;
                        newItem.SubItems[newItem.SubItems.Count - 1].ForeColor = selectedColor.Color;
                    }

                    colourCheck = (int)tamedCreature.Colors[5];
                    newItem.SubItems.Add(colourCheck == 0 ? "N/A" : tamedCreature.Colors[5].ToString()); //19
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tamedCreature.Colors[5]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        newItem.SubItems[newItem.SubItems.Count - 1].BackColor = selectedColor.Color;
                        newItem.SubItems[newItem.SubItems.Count - 1].ForeColor = selectedColor.Color;
                    }


                    newItem.Tag = tamedCreature;

                    tameBag.Add(newItem);
                });

                if (tameBag != null && tameBag.Count > 0)
                {
                    lvwTameLovers.Items.AddRange(tameBag.OrderByDescending(o => ((ContentTamedCreature)o.Tag).BaseLevel).ToArray());
                }
            }

            lvwTameLovers.EndUpdate();


        }


        public frmBreedingLines(ContentTamedCreature selectedTame, ASVDataManager manager)
        {
            InitializeComponent();
            LoadWindowSettings();
            tame = selectedTame;
            cm = manager;

            string friendlyName = selectedTame.ClassName;
            var dinoMap = Program.ProgramConfig.DinoMap.FirstOrDefault(d => d.ClassName == selectedTame.ClassName);
            if (dinoMap != null) friendlyName = dinoMap.FriendlyName;
            if (selectedTame.Name != null && selectedTame.Name.Length > 0) friendlyName = selectedTame.Name;

            string tribeName = "";
            var tribe = cm.GetTribes(selectedTame.TargetingTeam).FirstOrDefault();
            if (tribe != null)
            {
                tribeName = tribe.TribeName;
            }

            lblLevel.Text = selectedTame.Level.ToString();
            lblName.Text = friendlyName;
            lblTribeName.Text = tribeName;

            PopulateTameDetails();
            PopulateAncestorLevels();
            PopulateWildLovers();
            PopulateTamedLovers();
        }

        private void PopulateTameDetails()
        {
            var tameDetail = tame;
            ListViewItem item = new ListViewItem(tameDetail.Gender);
            item.Tag = tameDetail;
            item.UseItemStyleForSubItems = false;

            item.SubItems.Add(tameDetail.BaseLevel.ToString());
            item.SubItems.Add(tameDetail.Level.ToString());
            if (tameDetail.Longitude != null && tameDetail.Latitude != null)
            {
                item.SubItems.Add(((decimal)tameDetail.Latitude).ToString("0.00"));
                item.SubItems.Add(((decimal)tameDetail.Longitude).ToString("0.00"));

            }
            else
            {
                item.SubItems.Add("n/a");
                item.SubItems.Add("n/a");
            }

            if (tameDetail.BaseStats != null && tameDetail.BaseStats.Length > 0)
            {
                if (optStatsTamed.Checked)
                {
                    //7
                    item.SubItems.Add(tameDetail.TamedStats[0].ToString());
                    item.SubItems.Add(tameDetail.TamedStats[1].ToString());
                    item.SubItems.Add(tameDetail.TamedStats[8].ToString());
                    item.SubItems.Add(tameDetail.TamedStats[7].ToString());
                    item.SubItems.Add(tameDetail.TamedStats[9].ToString());
                    item.SubItems.Add(tameDetail.TamedStats[4].ToString());
                    item.SubItems.Add(tameDetail.TamedStats[3].ToString());
                    item.SubItems.Add(tameDetail.TamedStats[11].ToString());

                }
                else
                {
                    item.SubItems.Add(tameDetail.BaseStats[0].ToString());
                    item.SubItems.Add(tameDetail.BaseStats[1].ToString());
                    item.SubItems.Add(tameDetail.BaseStats[8].ToString());
                    item.SubItems.Add(tameDetail.BaseStats[7].ToString());
                    item.SubItems.Add(tameDetail.BaseStats[9].ToString());
                    item.SubItems.Add(tameDetail.BaseStats[4].ToString());
                    item.SubItems.Add(tameDetail.BaseStats[3].ToString());
                    item.SubItems.Add(tameDetail.BaseStats[11].ToString());
                }
            }
            else
            {
                item.SubItems.Add("n/a");
                item.SubItems.Add("n/a");
                item.SubItems.Add("n/a");
                item.SubItems.Add("n/a");
                item.SubItems.Add("n/a");
                item.SubItems.Add("n/a");
                item.SubItems.Add("n/a");
                item.SubItems.Add("n/a");
            }


            item.SubItems.Add(tameDetail.TamedOnServerName);

            string tamerName = tameDetail.TamerName != null ? tameDetail.TamerName : "";
            string imprinterName = tameDetail.ImprinterName;
            if (tamerName.Length == 0)
            {
                if (tameDetail.ImprintedPlayerId != 0)
                {
                    var tamer = cm.GetPlayers(0, tameDetail.ImprintedPlayerId, "").FirstOrDefault();
                    if (tamer != null) tamerName = tamer.CharacterName;
                }
            }



            item.SubItems.Add(tamerName);
            item.SubItems.Add(tameDetail.ImprinterName);
            item.SubItems.Add((tameDetail.ImprintQuality * 100).ToString("f0"));

            bool isStored = tameDetail.IsCryo | tameDetail.IsVivarium;

            item.SubItems.Add(isStored.ToString());
            if (tameDetail.IsCryo)
            {
                item.BackColor = Color.LightSkyBlue;
                item.SubItems[1].BackColor = Color.LightSkyBlue;
                item.SubItems[2].BackColor = Color.LightSkyBlue;
                item.SubItems[3].BackColor = Color.LightSkyBlue;
                item.SubItems[4].BackColor = Color.LightSkyBlue;
                item.SubItems[5].BackColor = Color.LightSkyBlue;
                item.SubItems[6].BackColor = Color.LightSkyBlue;
                item.SubItems[7].BackColor = Color.LightSkyBlue;
                item.SubItems[8].BackColor = Color.LightSkyBlue;
                item.SubItems[9].BackColor = Color.LightSkyBlue;
                item.SubItems[10].BackColor = Color.LightSkyBlue;
                item.SubItems[11].BackColor = Color.LightSkyBlue;
                item.SubItems[12].BackColor = Color.LightSkyBlue;
                item.SubItems[13].BackColor = Color.LightSkyBlue;
                item.SubItems[14].BackColor = Color.LightSkyBlue;
                item.SubItems[15].BackColor = Color.LightSkyBlue;
                item.SubItems[16].BackColor = Color.LightSkyBlue;
            }
            if (tameDetail.IsVivarium)
            {
                item.BackColor = Color.LightGreen;
                item.SubItems[1].BackColor = Color.LightGreen;
                item.SubItems[2].BackColor = Color.LightGreen;
                item.SubItems[3].BackColor = Color.LightGreen;
                item.SubItems[4].BackColor = Color.LightGreen;
                item.SubItems[5].BackColor = Color.LightGreen;
                item.SubItems[6].BackColor = Color.LightGreen;
                item.SubItems[7].BackColor = Color.LightGreen;
                item.SubItems[8].BackColor = Color.LightGreen;
                item.SubItems[9].BackColor = Color.LightGreen;
                item.SubItems[10].BackColor = Color.LightGreen;
                item.SubItems[11].BackColor = Color.LightGreen;
                item.SubItems[12].BackColor = Color.LightGreen;
                item.SubItems[13].BackColor = Color.LightGreen;
                item.SubItems[14].BackColor = Color.LightGreen;
                item.SubItems[15].BackColor = Color.LightGreen;
                item.SubItems[16].BackColor = Color.LightGreen;
            }
            if (tameDetail.BaseStats == null) //fake tame, used for ancestry only as unable to identify living parent
            {
                item.BackColor = Color.LightPink;
                item.SubItems[1].BackColor = Color.LightPink;
                item.SubItems[2].BackColor = Color.LightPink;
                item.SubItems[3].BackColor = Color.LightPink;
                item.SubItems[4].BackColor = Color.LightPink;
                item.SubItems[5].BackColor = Color.LightPink;
                item.SubItems[6].BackColor = Color.LightPink;
                item.SubItems[7].BackColor = Color.LightPink;
                item.SubItems[8].BackColor = Color.LightPink;
                item.SubItems[9].BackColor = Color.LightPink;
                item.SubItems[10].BackColor = Color.LightPink;
                item.SubItems[11].BackColor = Color.LightPink;
                item.SubItems[12].BackColor = Color.LightPink;
                item.SubItems[13].BackColor = Color.LightPink;
                item.SubItems[14].BackColor = Color.LightPink;
                item.SubItems[15].BackColor = Color.LightPink;
                item.SubItems[16].BackColor = Color.LightPink;
                item.SubItems[17].BackColor = Color.LightPink;
                item.SubItems[18].BackColor = Color.LightPink;
            }

            //Colours
            if (tameDetail.Colors != null)
            {
                int colourCheck = (int)tameDetail.Colors[0];
                item.SubItems.Add(colourCheck == 0 ? "n/a" : tameDetail.Colors[0].ToString()); //14
                ColourMap selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tameDetail.Colors[0]).FirstOrDefault();
                if (selectedColor != null && selectedColor.Hex.Length > 0)
                {
                    item.SubItems[18].BackColor = selectedColor.Color;
                    item.SubItems[18].ForeColor = selectedColor.Color;
                }

                colourCheck = (int)tameDetail.Colors[1];
                item.SubItems.Add(colourCheck == 0 ? "n/a" : tameDetail.Colors[1].ToString()); //15
                selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tameDetail.Colors[1]).FirstOrDefault();
                if (selectedColor != null && selectedColor.Hex.Length > 0)
                {
                    item.SubItems[19].BackColor = selectedColor.Color;
                    item.SubItems[19].ForeColor = selectedColor.Color;
                }

                colourCheck = (int)tameDetail.Colors[2];
                item.SubItems.Add(colourCheck == 0 ? "n/a" : tameDetail.Colors[2].ToString()); //16
                selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tameDetail.Colors[2]).FirstOrDefault();
                if (selectedColor != null && selectedColor.Hex.Length > 0)
                {
                    item.SubItems[20].BackColor = selectedColor.Color;
                    item.SubItems[20].ForeColor = selectedColor.Color;
                }

                colourCheck = (int)tameDetail.Colors[3];
                item.SubItems.Add(colourCheck == 0 ? "n/a" : tameDetail.Colors[3].ToString()); //17
                selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tameDetail.Colors[3]).FirstOrDefault();
                if (selectedColor != null && selectedColor.Hex.Length > 0)
                {
                    item.SubItems[21].BackColor = selectedColor.Color;
                    item.SubItems[21].ForeColor = selectedColor.Color;
                }

                colourCheck = (int)tameDetail.Colors[4];
                item.SubItems.Add(colourCheck == 0 ? "n/a" : tameDetail.Colors[4].ToString()); //18
                selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tameDetail.Colors[4]).FirstOrDefault();
                if (selectedColor != null && selectedColor.Hex.Length > 0)
                {
                    item.SubItems[22].BackColor = selectedColor.Color;
                    item.SubItems[22].ForeColor = selectedColor.Color;
                }
                colourCheck = (int)tameDetail.Colors[5];
                item.SubItems.Add(colourCheck == 0 ? "n/a" : tameDetail.Colors[5].ToString()); //19
                selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tameDetail.Colors[5]).FirstOrDefault();
                if (selectedColor != null && selectedColor.Hex.Length > 0)
                {
                    item.SubItems[23].BackColor = selectedColor.Color;
                    item.SubItems[23].ForeColor = selectedColor.Color;
                }

            }
            else
            {
                item.SubItems.Add("n/a");
                item.SubItems.Add("n/a");
                item.SubItems.Add("n/a");
                item.SubItems.Add("n/a");
                item.SubItems.Add("n/a");
                item.SubItems.Add("n/a");
            }


            //mutations
            item.SubItems.Add(tameDetail.RandomMutationsFemale.ToString());
            item.SubItems.Add(tameDetail.RandomMutationsMale.ToString());
            item.SubItems.Add(tameDetail.Id.ToString());

            lvwTame.Items.Clear();
            lvwTame.Items.Add(item);
        }

        private void PopulateAncestorLevels()
        {
            if (tame == null) return;

            //determine ancestry line
            var currentTame = tame;
            if (tame.FatherId.GetValueOrDefault(0) == 0 || tame.MotherId.GetValueOrDefault(0) == 0) return;


            lblStatus.Text = "Finding available generations...";
            lblStatus.Refresh();


            cboGeneration.Items.Clear();
            cboGeneration.Items.Add(new ContentAncestor(0, 0, "All", "", 0));

            var ancestors = GetAncestors(1, tame).GroupBy(x => x.Generation).Select(g => new ContentAncestor(g.Key, 0, "", "", 0)).OrderBy(o => o.Generation).ToList();
            ancestors.ForEach(a =>
            {
                cboGeneration.Items.Add(a);

            });

            lblStatus.Text = "";
            lblStatus.Refresh();
            cboGeneration.SelectedIndex = 0;
        }

        private void PopulateAncestors()
        {

            lvwTameDetail.BeginUpdate();
            lvwTameDetail.Items.Clear();
            if (cboGeneration.SelectedItem == null) return;

            lblStatus.Text = "Finding ancestor details...";
            lblStatus.Refresh();

            ContentAncestor ancestorGroup = (ContentAncestor)cboGeneration.SelectedItem;

            var ancestors = GetAncestors(1, tame);
            var filteredAncestors = ancestors.Where(a => a.Generation > 0 && (ancestorGroup.Generation == 0 || a.Generation == ancestorGroup.Generation)).ToList();
            foreach (var ancestor in filteredAncestors)
            {
                ContentTamedCreature tameAncestor = cm.GetTamedCreature(ancestor.Id);
                if (tameAncestor == null)
                {
                    //parse out level, name and gender
                    tameAncestor = new ContentTamedCreature()
                    {
                        Gender = ancestor.Gender,
                        BaseLevel = ancestor.Level,
                        Level = ancestor.Level,
                        Name = ancestor.Name,
                        ClassName = tame.ClassName
                    };
                }

                string creatureName = tameAncestor.ClassName;
                var dinoMap = Program.ProgramConfig.DinoMap.FirstOrDefault(d => d.ClassName == tameAncestor.ClassName);
                if (dinoMap != null)
                {
                    creatureName = dinoMap.FriendlyName;
                }
                if (tameAncestor.Name != null) creatureName = tameAncestor.Name;


                ListViewItem item = new ListViewItem(ancestor.Generation.ToString());
                item.Tag = tameAncestor;
                item.UseItemStyleForSubItems = false;

                item.SubItems.Add(creatureName);
                item.SubItems.Add(tameAncestor.Gender.ToString());
                item.SubItems.Add(tameAncestor.BaseLevel.ToString());
                item.SubItems.Add(tameAncestor.Level.ToString());
                if (tameAncestor.Longitude != null && tameAncestor.Latitude != null)
                {
                    item.SubItems.Add(((decimal)tameAncestor.Latitude).ToString("0.00"));
                    item.SubItems.Add(((decimal)tameAncestor.Longitude).ToString("0.00"));

                }
                else
                {
                    item.SubItems.Add("n/a");
                    item.SubItems.Add("n/a");
                }

                if (tameAncestor.BaseStats != null && tameAncestor.BaseStats.Length > 0)
                {
                    if (optStatsTamed.Checked)
                    {
                        //7
                        item.SubItems.Add(tameAncestor.TamedStats[0].ToString());
                        item.SubItems.Add(tameAncestor.TamedStats[1].ToString());
                        item.SubItems.Add(tameAncestor.TamedStats[8].ToString());
                        item.SubItems.Add(tameAncestor.TamedStats[7].ToString());
                        item.SubItems.Add(tameAncestor.TamedStats[9].ToString());
                        item.SubItems.Add(tameAncestor.TamedStats[4].ToString());
                        item.SubItems.Add(tameAncestor.TamedStats[3].ToString());
                        item.SubItems.Add(tameAncestor.TamedStats[11].ToString());

                    }
                    else
                    {
                        item.SubItems.Add(tameAncestor.BaseStats[0].ToString());
                        item.SubItems.Add(tameAncestor.BaseStats[1].ToString());
                        item.SubItems.Add(tameAncestor.BaseStats[8].ToString());
                        item.SubItems.Add(tameAncestor.BaseStats[7].ToString());
                        item.SubItems.Add(tameAncestor.BaseStats[9].ToString());
                        item.SubItems.Add(tameAncestor.BaseStats[4].ToString());
                        item.SubItems.Add(tameAncestor.BaseStats[3].ToString());
                        item.SubItems.Add(tameAncestor.BaseStats[11].ToString());
                    }
                }
                else
                {
                    item.SubItems.Add("n/a");
                    item.SubItems.Add("n/a");
                    item.SubItems.Add("n/a");
                    item.SubItems.Add("n/a");
                    item.SubItems.Add("n/a");
                    item.SubItems.Add("n/a");
                    item.SubItems.Add("n/a");
                    item.SubItems.Add("n/a");
                }


                item.SubItems.Add(tameAncestor.TamedOnServerName);

                string tamerName = tameAncestor.TamerName != null ? tameAncestor.TamerName : "";
                string imprinterName = tameAncestor.ImprinterName;
                if (tamerName.Length == 0)
                {
                    if (tameAncestor.ImprintedPlayerId != 0)
                    {
                        var tamer = cm.GetPlayers(0, tameAncestor.ImprintedPlayerId, "").FirstOrDefault();
                        if (tamer != null) tamerName = tamer.CharacterName;
                    }
                }



                item.SubItems.Add(tamerName);
                item.SubItems.Add(tameAncestor.ImprinterName);
                item.SubItems.Add((tameAncestor.ImprintQuality * 100).ToString("f0"));

                bool isStored = tameAncestor.IsCryo | tameAncestor.IsVivarium;

                item.SubItems.Add(isStored.ToString());
                if (tameAncestor.IsCryo)
                {
                    item.BackColor = Color.FromArgb(Program.ProgramConfig.HighlightColorCryopod);

                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        subItem.BackColor = Color.FromArgb(Program.ProgramConfig.HighlightColorCryopod);
                        subItem.ForeColor = Program.IdealTextColor(subItem.BackColor);
                    }
                }
                if (tameAncestor.IsVivarium)
                {
                    item.BackColor = Color.FromArgb(Program.ProgramConfig.HighlightColorVivarium);
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        subItem.BackColor = Color.FromArgb(Program.ProgramConfig.HighlightColorVivarium);
                        subItem.ForeColor = Program.IdealTextColor(subItem.BackColor);
                    }

                }
                if (tameAncestor.BaseStats.Sum(s=>s) == 0) //fake tame, used for ancestry only as unable to identify living parent
                {
                    item.BackColor = Color.LightPink;
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        subItem.BackColor = Color.LightPink;
                        subItem.ForeColor = Program.IdealTextColor(subItem.BackColor);
                    }

                }

                //Colours
                if (tameAncestor.Colors != null)
                {
                    int colourCheck = (int)tameAncestor.Colors[0];
                    item.SubItems.Add(colourCheck == 0 ? "n/a" : tameAncestor.Colors[0].ToString()); //14
                    ColourMap selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tameAncestor.Colors[0]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        item.SubItems[20].BackColor = selectedColor.Color;
                        item.SubItems[20].ForeColor = Program.IdealTextColor(selectedColor.Color);
                    }

                    colourCheck = (int)tameAncestor.Colors[1];
                    item.SubItems.Add(colourCheck == 0 ? "n/a" : tameAncestor.Colors[1].ToString()); //15
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tameAncestor.Colors[1]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        item.SubItems[21].BackColor = selectedColor.Color;
                        item.SubItems[21].ForeColor = Program.IdealTextColor(selectedColor.Color);
                    }

                    colourCheck = (int)tameAncestor.Colors[2];
                    item.SubItems.Add(colourCheck == 0 ? "n/a" : tameAncestor.Colors[2].ToString()); //16
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tameAncestor.Colors[2]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        item.SubItems[22].BackColor = selectedColor.Color;
                        item.SubItems[22].ForeColor = Program.IdealTextColor(selectedColor.Color);
                    }

                    colourCheck = (int)tameAncestor.Colors[3];
                    item.SubItems.Add(colourCheck == 0 ? "n/a" : tameAncestor.Colors[3].ToString()); //17
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tameAncestor.Colors[3]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        item.SubItems[23].BackColor = selectedColor.Color;
                        item.SubItems[23].ForeColor = Program.IdealTextColor(selectedColor.Color);
                    }

                    colourCheck = (int)tameAncestor.Colors[4];
                    item.SubItems.Add(colourCheck == 0 ? "n/a" : tameAncestor.Colors[4].ToString()); //18
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tameAncestor.Colors[4]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        item.SubItems[24].BackColor = selectedColor.Color;
                        item.SubItems[24].ForeColor = Program.IdealTextColor(selectedColor.Color);
                    }
                    colourCheck = (int)tameAncestor.Colors[5];
                    item.SubItems.Add(colourCheck == 0 ? "n/a" : tameAncestor.Colors[5].ToString()); //19
                    selectedColor = Program.ProgramConfig.ColourMap.Where(c => c.Id == (int)tameAncestor.Colors[5]).FirstOrDefault();
                    if (selectedColor != null && selectedColor.Hex.Length > 0)
                    {
                        item.SubItems[25].BackColor = selectedColor.Color;
                        item.SubItems[25].ForeColor = Program.IdealTextColor(selectedColor.Color);
                    }

                }
                else
                {
                    item.SubItems.Add("n/a");
                    item.SubItems.Add("n/a");
                    item.SubItems.Add("n/a");
                    item.SubItems.Add("n/a");
                    item.SubItems.Add("n/a");
                    item.SubItems.Add("n/a");
                }


                //mutations
                item.SubItems.Add(tameAncestor.RandomMutationsFemale.ToString());
                item.SubItems.Add(tameAncestor.RandomMutationsMale.ToString());
                item.SubItems.Add(tameAncestor.Id.ToString());

                lvwTameDetail.Items.Add(item);
            }


            if (SortingColumn_Ancestors != null)
            {
                lvwTameDetail.ListViewItemSorter =
                    new ListViewComparer(SortingColumn_Ancestors.Index, SortingColumn_Ancestors.Text.Contains(">") ? SortOrder.Ascending : SortOrder.Descending);

                // Sort.
                lvwTameDetail.Sort();
            }
            else
            {

                SortingColumn_Ancestors = lvwTameDetail.Columns[0]; ;
                SortingColumn_Ancestors.Text = "> " + SortingColumn_Ancestors.Text;

                lvwTameDetail.ListViewItemSorter =
                    new ListViewComparer(0, SortOrder.Ascending);

                // Sort.
                lvwTameDetail.Sort();
            }

            lvwTameDetail.EndUpdate();

            lblStatus.Text = "";
            lblStatus.Refresh();
        }

        private List<ContentAncestor> GetAncestors(long gen, ContentTamedCreature tame)
        {
            List<ContentAncestor> currentAncestors = new List<ContentAncestor>();
            if (tame.FatherId.GetValueOrDefault(0) != 0)
            {

                ContentTamedCreature father = cm.GetTamedCreature(tame.FatherId.Value);
                string fatherName = tame.FatherName;
                int fatherLevel = 0;

                if (father != null)
                {
                    fatherLevel = father.Level;
                    currentAncestors.AddRange(GetAncestors(gen + 1, father));
                }
                else
                {
                    if (fatherName.Contains("- Lvl"))
                    {
                        int.TryParse(fatherName.Substring(fatherName.LastIndexOf("l") + 1), out fatherLevel);
                        fatherName = fatherName.Substring(0, fatherName.LastIndexOf("-") - 1).Trim();
                    }
                }
                currentAncestors.Add(new ContentAncestor(gen, (long)tame.FatherId.GetValueOrDefault(0), fatherName, "Male", fatherLevel));

            }
            if (tame.MotherId.GetValueOrDefault(0) != 0)
            {
                ContentTamedCreature mother = cm.GetTamedCreature(tame.MotherId.Value);
                string motherName = tame.MotherName;
                int motherLevel = 0;

                if (mother != null)
                {
                    motherLevel = mother.Level;
                    currentAncestors.AddRange(GetAncestors(gen + 1, mother));
                }
                else
                {
                    if (motherName.Contains("- Lvl"))
                    {
                        int.TryParse(motherName.Substring(motherName.LastIndexOf("l") + 1), out motherLevel);
                        motherName = motherName.Substring(0, motherName.LastIndexOf("-") - 1).Trim();
                    }
                }
                currentAncestors.Add(new ContentAncestor(gen, (long)tame.MotherId.GetValueOrDefault(0), motherName, "Female", motherLevel));

            }

            return currentAncestors;
        }

        private void btnCopyCommandTamed_Click(object sender, EventArgs e)
        {
            if (cboConsoleCommandsTamed.SelectedItem == null) return;
            if (lvwTameDetail.SelectedItems.Count <= 0) return;

            ListViewItem selectedItem = lvwTameDetail.SelectedItems[0];

            var commandText = cboConsoleCommandsTamed.SelectedItem.ToString();
            if (commandText != null)
            {

                ContentTamedCreature selectedCreature = (ContentTamedCreature)selectedItem.Tag;
                commandText = commandText.Replace("<ClassName>", selectedCreature.ClassName);
                commandText = commandText.Replace("<Level>", (selectedCreature.BaseLevel / 1.5).ToString("f0"));
                commandText = commandText.Replace("<TribeID>", selectedCreature.TargetingTeam.ToString("f0"));

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

                Clipboard.SetText(commandText);

                lblStatus.Text = $"Command copied to clipboard: {commandText}";
                lblStatus.Refresh();
            }
        }

        private void frmAncestorView_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateWindowSettings();
        }

        private void cboGeneration_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboGeneration.Enabled = false;
            PopulateAncestors();
            cboGeneration.Enabled = true;
        }

        private void optStatsBase_CheckedChanged(object sender, EventArgs e)
        {
            SwitchStats();
        }

        private void optStatsTamed_CheckedChanged(object sender, EventArgs e)
        {

            SwitchStats();
        }

        private void SwitchStats()
        {
            if (isLoading) return;
            isLoading = true;

            //switch tame stat view
            if (tame.BaseStats != null && tame.BaseStats.Length > 0)
            {
                ListViewItem item = lvwTame.Items[0];

                if (optStatsTamed.Checked)
                {
                    item.SubItems[5].Text = tame.TamedStats[0].ToString();
                    item.SubItems[6].Text = tame.TamedStats[1].ToString();
                    item.SubItems[7].Text = tame.TamedStats[8].ToString();
                    item.SubItems[8].Text = tame.TamedStats[7].ToString();
                    item.SubItems[9].Text = tame.TamedStats[9].ToString();
                    item.SubItems[10].Text = tame.TamedStats[4].ToString();
                    item.SubItems[11].Text = tame.TamedStats[3].ToString();
                    item.SubItems[12].Text = tame.TamedStats[11].ToString();

                }
                else
                {
                    item.SubItems[5].Text = tame.BaseStats[0].ToString();
                    item.SubItems[6].Text = tame.BaseStats[1].ToString();
                    item.SubItems[7].Text = tame.BaseStats[8].ToString();
                    item.SubItems[8].Text = tame.BaseStats[7].ToString();
                    item.SubItems[9].Text = tame.BaseStats[9].ToString();
                    item.SubItems[10].Text = tame.BaseStats[4].ToString();
                    item.SubItems[11].Text = tame.BaseStats[3].ToString();
                    item.SubItems[12].Text = tame.BaseStats[11].ToString();
                }
            }



            if (lvwTameLovers.Items.Count > 0)
            {
                foreach (ListViewItem item in lvwTameLovers.Items)
                {
                    ContentTamedCreature tame = (ContentTamedCreature)item.Tag;
                    if (tame.BaseStats != null && tame.BaseStats.Length > 0)
                    {
                        if (optStatsTamed.Checked)
                        {
                            //7
                            item.SubItems[7].Text = tame.TamedStats[0].ToString();
                            item.SubItems[8].Text = tame.TamedStats[1].ToString();
                            item.SubItems[9].Text = tame.TamedStats[8].ToString();
                            item.SubItems[10].Text = tame.TamedStats[7].ToString();
                            item.SubItems[11].Text = tame.TamedStats[9].ToString();
                            item.SubItems[12].Text = tame.TamedStats[4].ToString();
                            item.SubItems[13].Text = tame.TamedStats[3].ToString();
                            item.SubItems[14].Text = tame.TamedStats[11].ToString();

                        }
                        else
                        {
                            item.SubItems[7].Text = tame.BaseStats[0].ToString();
                            item.SubItems[8].Text = tame.BaseStats[1].ToString();
                            item.SubItems[9].Text = tame.BaseStats[8].ToString();
                            item.SubItems[10].Text = tame.BaseStats[7].ToString();
                            item.SubItems[11].Text = tame.BaseStats[9].ToString();
                            item.SubItems[12].Text = tame.BaseStats[4].ToString();
                            item.SubItems[13].Text = tame.BaseStats[3].ToString();
                            item.SubItems[14].Text = tame.BaseStats[11].ToString();
                        }
                    }

                }
            }

            isLoading = false;
        }

        private void lvwTameDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCopyCommandTamed.Enabled = lvwTameDetail.SelectedItems.Count == 1;
        }

        private void lvwTameDetail_Click(object sender, EventArgs e)
        {
            btnCopyCommandTamed.Enabled = lvwTameDetail.SelectedItems.Count == 1;
        }

        private void lvwTameLovers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTameCopyCommand.Enabled = lvwTameLovers.SelectedItems.Count == 1;
        }

        private void lvwWildDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnWildCopyCommand.Enabled = lvwWildLovers.SelectedItems.Count == 1;
        }

        private void btnTameCopyCommand_Click(object sender, EventArgs e)
        {
            if (cboTameCommand.SelectedItem == null) return;
            if (lvwTameLovers.SelectedItems.Count <= 0) return;

            ListViewItem selectedItem = lvwTameLovers.SelectedItems[0];

            var commandText = cboTameCommand.SelectedItem.ToString();
            if (commandText != null)
            {
                ContentTamedCreature selectedCreature = (ContentTamedCreature)selectedItem.Tag;
                commandText = commandText.Replace("<ClassName>", selectedCreature.ClassName);
                commandText = commandText.Replace("<Level>", (selectedCreature.BaseLevel / 1.5).ToString("f0"));
                commandText = commandText.Replace("<TribeID>", selectedCreature.TargetingTeam.ToString("f0"));

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

                Clipboard.SetText(commandText);

                lblStatus.Text = $"Command copied to clipboard: {commandText}";
                lblStatus.Refresh();
            }
        }

        private void btnWildCopyCommand_Click(object sender, EventArgs e)
        {
            if (cboWildCommand.SelectedItem == null) return;
            if (lvwWildLovers.SelectedItems.Count <= 0) return;

            ListViewItem selectedItem = lvwWildLovers.SelectedItems[0];

            var commandText = cboWildCommand.SelectedItem.ToString();
            if (commandText != null)
            {
                ContentWildCreature selectedCreature = (ContentWildCreature)selectedItem.Tag;
                commandText = commandText.Replace("<ClassName>", selectedCreature.ClassName);
                commandText = commandText.Replace("<Level>", (selectedCreature.BaseLevel / 1.5).ToString("f0"));

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

                Clipboard.SetText(commandText);

                lblStatus.Text = $"Command copied to clipboard: {commandText}";
                lblStatus.Refresh();
            }
        }

        private void chkAllTribes_CheckedChanged(object sender, EventArgs e)
        {
            PopulateTamedLovers();
        }
        private void lvwTameDetail_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwTameDetail.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_Ancestors == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_Ancestors)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_Ancestors.Text.StartsWith("> "))
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
                SortingColumn_Ancestors.Text = SortingColumn_Ancestors.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_Ancestors = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_Ancestors.Text = "> " + SortingColumn_Ancestors.Text;
            }
            else
            {
                SortingColumn_Ancestors.Text = "< " + SortingColumn_Ancestors.Text;
            }

            // Create a comparer.
            lvwTameDetail.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwTameDetail.Sort();
        }

        private void lvwTameLovers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwTameLovers.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_Tamed == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_Tamed)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_Tamed.Text.StartsWith("> "))
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
                SortingColumn_Tamed.Text = SortingColumn_Tamed.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_Tamed = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_Tamed.Text = "> " + SortingColumn_Tamed.Text;
            }
            else
            {
                SortingColumn_Tamed.Text = "< " + SortingColumn_Tamed.Text;
            }

            // Create a comparer.
            lvwTameLovers.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwTameLovers.Sort();
        }

        private void lvwWildLovers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lvwWildLovers.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn_Wild == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn_Wild)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn_Wild.Text.StartsWith("> "))
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
                SortingColumn_Wild.Text = SortingColumn_Wild.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn_Wild = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn_Wild.Text = "> " + SortingColumn_Wild.Text;
            }
            else
            {
                SortingColumn_Wild.Text = "< " + SortingColumn_Wild.Text;
            }

            // Create a comparer.
            lvwWildLovers.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lvwWildLovers.Sort();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTameSettings_Click(object sender, EventArgs e)
        {

            using (frmBreedingFindOptions options = new frmBreedingFindOptions(tame))
            {
                options.Owner = this;
                if (options.ShowDialog() == DialogResult.OK)
                {
                    var selectedOptions = options.SearchOptions;

                    var configOption = Program.ProgramConfig.BreedingSearchOptions.Find(x => x.ClassName == selectedOptions.ClassName && x.Tamed == true);
                    if (configOption == null)
                    {
                        configOption = selectedOptions;
                        configOption.Tamed = true;
                        Program.ProgramConfig.BreedingSearchOptions.Add(configOption);
                    }
                    else
                    {
                        configOption.ColoursRegion0 = selectedOptions.ColoursRegion0;
                        configOption.ColoursRegion1 = selectedOptions.ColoursRegion1;
                        configOption.ColoursRegion2 = selectedOptions.ColoursRegion2;
                        configOption.ColoursRegion3 = selectedOptions.ColoursRegion3;
                        configOption.ColoursRegion4 = selectedOptions.ColoursRegion4;
                        configOption.ColoursRegion5 = selectedOptions.ColoursRegion5;
                        configOption.RangeCrafting = selectedOptions.RangeCrafting;
                        configOption.RangeFood = selectedOptions.RangeFood;
                        configOption.RangeHp = selectedOptions.RangeHp;
                        configOption.RangeMelee = selectedOptions.RangeMelee;
                        configOption.RangeOxygen = selectedOptions.RangeOxygen;
                        configOption.RangeSpeed = selectedOptions.RangeSpeed;
                        configOption.RangeStamina = selectedOptions.RangeStamina;
                        configOption.RangeWeight = selectedOptions.RangeWeight;
                    }

                    PopulateTamedLovers();
                }
            }
        }

        private void btnWildSettings_Click(object sender, EventArgs e)
        {

            using (frmBreedingFindOptions options = new frmBreedingFindOptions(tame))
            {
                options.Owner = this;
                if (options.ShowDialog() == DialogResult.OK)
                {
                    options.Owner = this;
                    if (options.ShowDialog() == DialogResult.OK)
                    {
                        var selectedOptions = options.SearchOptions;

                        var configOption = Program.ProgramConfig.BreedingSearchOptions.Find(x => x.ClassName == selectedOptions.ClassName && x.Tamed == false);
                        if (configOption == null)
                        {
                            configOption = selectedOptions;
                            configOption.Tamed = false;
                            Program.ProgramConfig.BreedingSearchOptions.Add(configOption);
                        }
                        else
                        {
                            configOption.ColoursRegion0 = selectedOptions.ColoursRegion0;
                            configOption.ColoursRegion1 = selectedOptions.ColoursRegion1;
                            configOption.ColoursRegion2 = selectedOptions.ColoursRegion2;
                            configOption.ColoursRegion3 = selectedOptions.ColoursRegion3;
                            configOption.ColoursRegion4 = selectedOptions.ColoursRegion4;
                            configOption.ColoursRegion5 = selectedOptions.ColoursRegion5;
                            configOption.RangeCrafting = selectedOptions.RangeCrafting;
                            configOption.RangeFood = selectedOptions.RangeFood;
                            configOption.RangeHp = selectedOptions.RangeHp;
                            configOption.RangeMelee = selectedOptions.RangeMelee;
                            configOption.RangeOxygen = selectedOptions.RangeOxygen;
                            configOption.RangeSpeed = selectedOptions.RangeSpeed;
                            configOption.RangeStamina = selectedOptions.RangeStamina;
                            configOption.RangeWeight = selectedOptions.RangeWeight;
                        }

                        PopulateWildLovers();
                    }
                }
            }
        }
    }
}

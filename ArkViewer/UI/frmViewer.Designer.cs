using System.Data.SqlClient;

namespace ARKViewer
{


    partial class frmViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewer));
            mnuContext = new System.Windows.Forms.ContextMenuStrip(components);
            mnuContext_PlayerId = new System.Windows.Forms.ToolStripMenuItem();
            mnuContext_SteamId = new System.Windows.Forms.ToolStripMenuItem();
            mnuContext_TribeId = new System.Windows.Forms.ToolStripMenuItem();
            mnuContext_DinoId = new System.Windows.Forms.ToolStripMenuItem();
            mnuContext_Export = new System.Windows.Forms.ToolStripMenuItem();
            mnuContext_Structures = new System.Windows.Forms.ToolStripMenuItem();
            mnuContext_Tames = new System.Windows.Forms.ToolStripMenuItem();
            mnuContext_Players = new System.Windows.Forms.ToolStripMenuItem();
            mnuContext_ProfileFilename = new System.Windows.Forms.ToolStripMenuItem();
            lblMapDate = new System.Windows.Forms.Label();
            btnRefresh = new System.Windows.Forms.Button();
            btnSettings = new System.Windows.Forms.Button();
            btnViewMap = new System.Windows.Forms.Button();
            lblStatus = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblSubTitle = new System.Windows.Forms.Label();
            lblMapTypeName = new System.Windows.Forms.Label();
            lblVersion = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            btnConsoleCommandPainting = new System.Windows.Forms.Button();
            btnDeletePaintings = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            btnFindSearched = new System.Windows.Forms.Button();
            btnCopyCommandDropped = new System.Windows.Forms.Button();
            btnDropInventory = new System.Windows.Forms.Button();
            chkDroppedBlueprints = new System.Windows.Forms.CheckBox();
            btnFindDropped = new System.Windows.Forms.Button();
            btnPlayerInventory = new System.Windows.Forms.Button();
            btnPlayerTribeLog = new System.Windows.Forms.Button();
            btnCopyCommandPlayer = new System.Windows.Forms.Button();
            btnDeletePlayer = new System.Windows.Forms.Button();
            btnFilterPlayer = new System.Windows.Forms.Button();
            btnRconCommandPlayers = new System.Windows.Forms.Button();
            btnTribeLog = new System.Windows.Forms.Button();
            btnTribeCopyCommand = new System.Windows.Forms.Button();
            chkTribePlayers = new System.Windows.Forms.CheckBox();
            chkTribeTames = new System.Windows.Forms.CheckBox();
            chkTribeStructures = new System.Windows.Forms.CheckBox();
            btnSaveChartImage = new System.Windows.Forms.Button();
            btnFilterTribe = new System.Windows.Forms.Button();
            btnRconCommandTribes = new System.Windows.Forms.Button();
            btnStructureExclusionFilter = new System.Windows.Forms.Button();
            btnCopyCommandStructure = new System.Windows.Forms.Button();
            btnStructureInventory = new System.Windows.Forms.Button();
            btnFindStructures = new System.Windows.Forms.Button();
            btnRconCommandStructures = new System.Windows.Forms.Button();
            btnDinoInventory = new System.Windows.Forms.Button();
            btnDinoAncestors = new System.Windows.Forms.Button();
            btnCopyCommandTamed = new System.Windows.Forms.Button();
            btnFindTamed = new System.Windows.Forms.Button();
            btnRconCommandTamed = new System.Windows.Forms.Button();
            btnCopyCommandWild = new System.Windows.Forms.Button();
            btnFindWild = new System.Windows.Forms.Button();
            btnRconCommandWild = new System.Windows.Forms.Button();
            lblMap = new System.Windows.Forms.Label();
            cboSelectedMap = new ArkViewer.UI.BorderlessComboBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            tpgLeaderboard = new System.Windows.Forms.TabPage();
            cboLeaderboardPlayer = new ArkViewer.UI.BorderlessComboBox();
            lblMissionPlayer = new System.Windows.Forms.Label();
            lvwLeaderboardSummary = new System.Windows.Forms.ListView();
            columnHeader32 = new System.Windows.Forms.ColumnHeader();
            columnHeader35 = new System.Windows.Forms.ColumnHeader();
            columnHeader36 = new System.Windows.Forms.ColumnHeader();
            lvwLeaderboard = new System.Windows.Forms.ListView();
            lvwLeaderboard_Mission = new System.Windows.Forms.ColumnHeader();
            lvwLeaderboard_Tribe = new System.Windows.Forms.ColumnHeader();
            lvwLeaderboard_Player = new System.Windows.Forms.ColumnHeader();
            lvwLeaderboard_Score = new System.Windows.Forms.ColumnHeader();
            cboLeaderboardMission = new ArkViewer.UI.BorderlessComboBox();
            lblLeaderboardMission = new System.Windows.Forms.Label();
            cboLeaderboardTribe = new ArkViewer.UI.BorderlessComboBox();
            lblLeaderboardTribe = new System.Windows.Forms.Label();
            tpgLocalProfile = new System.Windows.Forms.TabPage();
            pnlUploadedStats = new System.Windows.Forms.Panel();
            lblUploadedStats = new System.Windows.Forms.Label();
            optUploadedStatsTamed = new System.Windows.Forms.RadioButton();
            optUploadedStatsBase = new System.Windows.Forms.RadioButton();
            lblUploadedCountItems = new System.Windows.Forms.Label();
            lblUploadedCountTames = new System.Windows.Forms.Label();
            lblUploadedCountCharacters = new System.Windows.Forms.Label();
            lblUploadedItems = new System.Windows.Forms.Label();
            lvwUploadedItems = new System.Windows.Forms.ListView();
            columnHeader8 = new System.Windows.Forms.ColumnHeader();
            columnHeader9 = new System.Windows.Forms.ColumnHeader();
            columnHeader18 = new System.Windows.Forms.ColumnHeader();
            columnHeader19 = new System.Windows.Forms.ColumnHeader();
            columnHeader22 = new System.Windows.Forms.ColumnHeader();
            lblUploadedTames = new System.Windows.Forms.Label();
            lblUploadedCharacters = new System.Windows.Forms.Label();
            lvwUploadedCharacters = new System.Windows.Forms.ListView();
            columnHeader37 = new System.Windows.Forms.ColumnHeader();
            columnHeader39 = new System.Windows.Forms.ColumnHeader();
            columnHeader40 = new System.Windows.Forms.ColumnHeader();
            columnHeader43 = new System.Windows.Forms.ColumnHeader();
            columnHeader44 = new System.Windows.Forms.ColumnHeader();
            columnHeader45 = new System.Windows.Forms.ColumnHeader();
            columnHeader46 = new System.Windows.Forms.ColumnHeader();
            columnHeader47 = new System.Windows.Forms.ColumnHeader();
            columnHeader48 = new System.Windows.Forms.ColumnHeader();
            columnHeader49 = new System.Windows.Forms.ColumnHeader();
            columnHeader50 = new System.Windows.Forms.ColumnHeader();
            columnHeader51 = new System.Windows.Forms.ColumnHeader();
            columnHeader52 = new System.Windows.Forms.ColumnHeader();
            lvwUploadedTames = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            columnHeader10 = new System.Windows.Forms.ColumnHeader();
            columnHeader11 = new System.Windows.Forms.ColumnHeader();
            columnHeader12 = new System.Windows.Forms.ColumnHeader();
            columnHeader13 = new System.Windows.Forms.ColumnHeader();
            columnHeader14 = new System.Windows.Forms.ColumnHeader();
            columnHeader15 = new System.Windows.Forms.ColumnHeader();
            columnHeader16 = new System.Windows.Forms.ColumnHeader();
            columnHeader17 = new System.Windows.Forms.ColumnHeader();
            columnHeader20 = new System.Windows.Forms.ColumnHeader();
            columnHeader21 = new System.Windows.Forms.ColumnHeader();
            columnHeader23 = new System.Windows.Forms.ColumnHeader();
            columnHeader24 = new System.Windows.Forms.ColumnHeader();
            columnHeader25 = new System.Windows.Forms.ColumnHeader();
            columnHeader26 = new System.Windows.Forms.ColumnHeader();
            columnHeader27 = new System.Windows.Forms.ColumnHeader();
            columnHeader28 = new System.Windows.Forms.ColumnHeader();
            columnHeader29 = new System.Windows.Forms.ColumnHeader();
            columnHeader30 = new System.Windows.Forms.ColumnHeader();
            columnHeader33 = new System.Windows.Forms.ColumnHeader();
            columnHeader34 = new System.Windows.Forms.ColumnHeader();
            tpgPaintings = new System.Windows.Forms.TabPage();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            lblPaintingsCount = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            textBox1 = new System.Windows.Forms.TextBox();
            lblPaintingTribe = new System.Windows.Forms.Label();
            lvwPlayerPaintings = new System.Windows.Forms.ListView();
            lvwPlayerPaintings_Tribe = new System.Windows.Forms.ColumnHeader();
            lvwPlayerPaintings_Structure = new System.Windows.Forms.ColumnHeader();
            lvwPlayerPaintings_Lat = new System.Windows.Forms.ColumnHeader();
            lvwPlayerPaintings_Lon = new System.Windows.Forms.ColumnHeader();
            lvwPlayerPaintings_PaintingId = new System.Windows.Forms.ColumnHeader();
            cboPaintingTribe = new ArkViewer.UI.BorderlessComboBox();
            lblStructurePainting = new System.Windows.Forms.Label();
            cboConsoleCommandPainting = new ArkViewer.UI.BorderlessComboBox();
            cboPaintingStructure = new ArkViewer.UI.BorderlessComboBox();
            lblCopyCommandPaintings = new System.Windows.Forms.Label();
            picPainting = new System.Windows.Forms.PictureBox();
            tpgItemList = new System.Windows.Forms.TabPage();
            cboItemListFilter = new ArkViewer.UI.BorderlessComboBox();
            lblItemListFilter = new System.Windows.Forms.Label();
            txtItemListItemId = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cboItemListPlayers = new ArkViewer.UI.BorderlessComboBox();
            pnlFilterSearch = new System.Windows.Forms.Panel();
            txtFilterSearch = new System.Windows.Forms.TextBox();
            cboItemListItem = new ArkViewer.UI.BorderlessComboBox();
            lblItemListTribe = new System.Windows.Forms.Label();
            cboItemListTribe = new ArkViewer.UI.BorderlessComboBox();
            btnCopyItemListCommand = new System.Windows.Forms.Button();
            lblItemListCommand = new System.Windows.Forms.Label();
            cboConsoleCommandSearch = new ArkViewer.UI.BorderlessComboBox();
            lblItemListCount = new System.Windows.Forms.Label();
            lblItemListItem = new System.Windows.Forms.Label();
            lvwItemList = new System.Windows.Forms.ListView();
            lvwItemList_Tribe = new System.Windows.Forms.ColumnHeader();
            lvwItemList_Container = new System.Windows.Forms.ColumnHeader();
            lvwItemList_Player = new System.Windows.Forms.ColumnHeader();
            lvwItemList_Item = new System.Windows.Forms.ColumnHeader();
            lvwItemList_Quality = new System.Windows.Forms.ColumnHeader();
            lvwItemList_Rating = new System.Windows.Forms.ColumnHeader();
            lvwItemList_BP = new System.Windows.Forms.ColumnHeader();
            lvwItemList_Quantity = new System.Windows.Forms.ColumnHeader();
            lvwItemList_Lat = new System.Windows.Forms.ColumnHeader();
            lvwItemList_Lon = new System.Windows.Forms.ColumnHeader();
            lvwItemList_CCC = new System.Windows.Forms.ColumnHeader();
            lvwItemList_UploadTime = new System.Windows.Forms.ColumnHeader();
            lvwItemList_ItemId = new System.Windows.Forms.ColumnHeader();
            tpgDroppedItems = new System.Windows.Forms.TabPage();
            cboDroppedItemRealm = new ArkViewer.UI.BorderlessComboBox();
            lblDroppedItemRealm = new System.Windows.Forms.Label();
            pnlFilterDropped = new System.Windows.Forms.Panel();
            txtFilterDropped = new System.Windows.Forms.TextBox();
            cboDroppedItem = new ArkViewer.UI.BorderlessComboBox();
            lblDroppedPlayer = new System.Windows.Forms.Label();
            cboDroppedPlayer = new ArkViewer.UI.BorderlessComboBox();
            lblCopyCommandDropped = new System.Windows.Forms.Label();
            cboConsoleCommandDropped = new ArkViewer.UI.BorderlessComboBox();
            lblCountDropped = new System.Windows.Forms.Label();
            lblDroppedItem = new System.Windows.Forms.Label();
            lvwDroppedItems = new System.Windows.Forms.ListView();
            lvwDroppedItems_Item = new System.Windows.Forms.ColumnHeader();
            lvwDroppedItems_Bp = new System.Windows.Forms.ColumnHeader();
            lvwDroppedItems_DroppedBy = new System.Windows.Forms.ColumnHeader();
            lvwDroppedItems_Lat = new System.Windows.Forms.ColumnHeader();
            lvwDroppedItems_Lon = new System.Windows.Forms.ColumnHeader();
            lvwDroppedItems_Tribe = new System.Windows.Forms.ColumnHeader();
            lvwDroppedItems_Player = new System.Windows.Forms.ColumnHeader();
            lvwDroppedItems_CCC = new System.Windows.Forms.ColumnHeader();
            tpgPlayers = new System.Windows.Forms.TabPage();
            cboPlayerRealm = new ArkViewer.UI.BorderlessComboBox();
            lblPlayerRealm = new System.Windows.Forms.Label();
            pnlFilterPlayers = new System.Windows.Forms.Panel();
            txtFilterPlayer = new System.Windows.Forms.TextBox();
            lblPlayerTotal = new System.Windows.Forms.Label();
            lblCommandPlayer = new System.Windows.Forms.Label();
            cboConsoleCommandsPlayer = new ArkViewer.UI.BorderlessComboBox();
            lblPlayersPlayer = new System.Windows.Forms.Label();
            lblPlayersTribe = new System.Windows.Forms.Label();
            cboTribes = new ArkViewer.UI.BorderlessComboBox();
            cboPlayers = new ArkViewer.UI.BorderlessComboBox();
            lvwPlayers = new System.Windows.Forms.ListView();
            lvwPlayers_PlayerId = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_Name = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_Tribe = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_Sex = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_Level = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_Lat = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_Lon = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_Hp = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_Stam = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_Melee = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_Weight = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_Speed = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_Food = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_Water = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_Oxygen = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_Crafting = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_Fortitude = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_LastOnline = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_SteamName = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_SteamId = new System.Windows.Forms.ColumnHeader();
            lvwPlayers_CCC = new System.Windows.Forms.ColumnHeader();
            tpgTribes = new System.Windows.Forms.TabPage();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            lvwTribes = new System.Windows.Forms.ListView();
            lvwTribes_Id = new System.Windows.Forms.ColumnHeader();
            lvwTribes_Name = new System.Windows.Forms.ColumnHeader();
            lvwTribes_Players = new System.Windows.Forms.ColumnHeader();
            lvwTribes_Tames = new System.Windows.Forms.ColumnHeader();
            lvwTribes_Structures = new System.Windows.Forms.ColumnHeader();
            lvwTribes_Active = new System.Windows.Forms.ColumnHeader();
            pnlFilterTribes = new System.Windows.Forms.Panel();
            txtFilterTribe = new System.Windows.Forms.TextBox();
            chartTribes = new ArkViewer.ChartControl();
            lblChartTop = new System.Windows.Forms.Label();
            udChartTop = new System.Windows.Forms.NumericUpDown();
            lblChart = new System.Windows.Forms.Label();
            cboChartType = new ArkViewer.UI.BorderlessComboBox();
            lblTribeCopyCommand = new System.Windows.Forms.Label();
            cboConsoleCommandsTribe = new ArkViewer.UI.BorderlessComboBox();
            tpgStructures = new System.Windows.Forms.TabPage();
            lblStructureRad = new System.Windows.Forms.Label();
            udRadiusStructures = new System.Windows.Forms.NumericUpDown();
            lblStructureLon = new System.Windows.Forms.Label();
            udLonStructures = new System.Windows.Forms.NumericUpDown();
            lblStructureLat = new System.Windows.Forms.Label();
            udLatStructures = new System.Windows.Forms.NumericUpDown();
            cboStructureRealm = new ArkViewer.UI.BorderlessComboBox();
            lblStructureRealm = new System.Windows.Forms.Label();
            pnlFilterStructures = new System.Windows.Forms.Panel();
            txtFilterStructures = new System.Windows.Forms.TextBox();
            lblStructureTotal = new System.Windows.Forms.Label();
            lblCommandStructure = new System.Windows.Forms.Label();
            cboConsoleCommandsStructure = new ArkViewer.UI.BorderlessComboBox();
            lblStructureStructure = new System.Windows.Forms.Label();
            cboStructureStructure = new ArkViewer.UI.BorderlessComboBox();
            lblStructurePlayer = new System.Windows.Forms.Label();
            lblStructureTribe = new System.Windows.Forms.Label();
            cboStructureTribe = new ArkViewer.UI.BorderlessComboBox();
            cboStructurePlayer = new ArkViewer.UI.BorderlessComboBox();
            lvwStructureLocations = new System.Windows.Forms.ListView();
            lvwStructureLocations_Tribe = new System.Windows.Forms.ColumnHeader();
            lvwStructureLocations_Structure = new System.Windows.Forms.ColumnHeader();
            lvwStructureLocations_Lat = new System.Windows.Forms.ColumnHeader();
            lvwStructureLocations_Lon = new System.Windows.Forms.ColumnHeader();
            lvwStructureLocations_Name = new System.Windows.Forms.ColumnHeader();
            lvwStructureLocations_Locked = new System.Windows.Forms.ColumnHeader();
            lvwStructureLocations_Powered = new System.Windows.Forms.ColumnHeader();
            lvwStructureLocations_Created = new System.Windows.Forms.ColumnHeader();
            lvwStructureLocations_LastTime = new System.Windows.Forms.ColumnHeader();
            lvwStructureLocations_DecayReset = new System.Windows.Forms.ColumnHeader();
            lvwStructureLocations_CCC = new System.Windows.Forms.ColumnHeader();
            tpgTamed = new System.Windows.Forms.TabPage();
            cboTameFilter = new ArkViewer.UI.BorderlessComboBox();
            lblTameFilter = new System.Windows.Forms.Label();
            cboTamedTrait = new ArkViewer.UI.BorderlessComboBox();
            label4 = new System.Windows.Forms.Label();
            lblTameRad = new System.Windows.Forms.Label();
            udRadiusTamed = new System.Windows.Forms.NumericUpDown();
            lblTameLon = new System.Windows.Forms.Label();
            udLonTamed = new System.Windows.Forms.NumericUpDown();
            lblTameLat = new System.Windows.Forms.Label();
            udLatTamed = new System.Windows.Forms.NumericUpDown();
            cboTameRealm = new ArkViewer.UI.BorderlessComboBox();
            lblTameRealm = new System.Windows.Forms.Label();
            pnlFilterTamed = new System.Windows.Forms.Panel();
            txtFilterTamed = new System.Windows.Forms.TextBox();
            cboTamedResource = new ArkViewer.UI.BorderlessComboBox();
            lblTameResource = new System.Windows.Forms.Label();
            lblTamedCommand = new System.Windows.Forms.Label();
            cboConsoleCommandsTamed = new ArkViewer.UI.BorderlessComboBox();
            cboTameTribes = new ArkViewer.UI.BorderlessComboBox();
            cboTamePlayers = new ArkViewer.UI.BorderlessComboBox();
            lblTameCreature = new System.Windows.Forms.Label();
            lblTamePlayer = new System.Windows.Forms.Label();
            lblTameTribe = new System.Windows.Forms.Label();
            lvwTameDetail = new System.Windows.Forms.ListView();
            lvwTameDetail_Tribe = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Creature = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Name = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Sex = new System.Windows.Forms.ColumnHeader();
            colTameDetail_Maturation = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Base = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Level = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Lat = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Lon = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_HP = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Stam = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Melee = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Weight = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Speed = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Food = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Oxygen = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Craft = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Server = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Tamer = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Imprinter = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Imprint = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Mating = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Wandering = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Neutered = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Cryo = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Clone = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Colour1 = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Colour2 = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Colour3 = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Colour4 = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Colour5 = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Colour6 = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_MutationsFemale = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_MutationsMale = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Id = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Scale = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Traits = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Rig1 = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_Rig2 = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_TribeInRange = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_UploadTime = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_DinoId = new System.Windows.Forms.ColumnHeader();
            lvwTameDetail_CCC = new System.Windows.Forms.ColumnHeader();
            lblTameTotal = new System.Windows.Forms.Label();
            pnlTameStatTypes = new System.Windows.Forms.Panel();
            optStatsMutated = new System.Windows.Forms.RadioButton();
            lblStats = new System.Windows.Forms.Label();
            optStatsTamed = new System.Windows.Forms.RadioButton();
            optStatsBase = new System.Windows.Forms.RadioButton();
            cboTameClass = new ArkViewer.UI.BorderlessComboBox();
            tpgWild = new System.Windows.Forms.TabPage();
            cboWildTrait = new ArkViewer.UI.BorderlessComboBox();
            label3 = new System.Windows.Forms.Label();
            chkTameable = new System.Windows.Forms.CheckBox();
            cboWildRealm = new ArkViewer.UI.BorderlessComboBox();
            lblWildRealm = new System.Windows.Forms.Label();
            pnlFilterWilds = new System.Windows.Forms.Panel();
            txtFilterWild = new System.Windows.Forms.TextBox();
            cboWildResource = new ArkViewer.UI.BorderlessComboBox();
            lblResource = new System.Windows.Forms.Label();
            lblWildRadius = new System.Windows.Forms.Label();
            udWildRadius = new System.Windows.Forms.NumericUpDown();
            lblWildLon = new System.Windows.Forms.Label();
            udWildLon = new System.Windows.Forms.NumericUpDown();
            lblWildLat = new System.Windows.Forms.Label();
            udWildLat = new System.Windows.Forms.NumericUpDown();
            lblWildMin = new System.Windows.Forms.Label();
            lblWildMax = new System.Windows.Forms.Label();
            udWildMin = new System.Windows.Forms.NumericUpDown();
            udWildMax = new System.Windows.Forms.NumericUpDown();
            lblWildCommand = new System.Windows.Forms.Label();
            cboConsoleCommandsWild = new ArkViewer.UI.BorderlessComboBox();
            lblSelectedWildTotal = new System.Windows.Forms.Label();
            lblWildClass = new System.Windows.Forms.Label();
            lvwWildDetail = new System.Windows.Forms.ListView();
            lvwWildDetail_Name = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Sex = new System.Windows.Forms.ColumnHeader();
            colWildDetail_Mature = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Base = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Level = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Lat = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Lon = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_HP = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Stam = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Melee = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Weight = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Speed = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Food = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Oxygen = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Craft = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Colour1 = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Colour2 = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Colour3 = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Colour4 = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Colour5 = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Colour6 = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Id = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Scale = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Trait = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Rig1 = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_Rig2 = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_DinoId = new System.Windows.Forms.ColumnHeader();
            lvwWildDetail_CCC = new System.Windows.Forms.ColumnHeader();
            lblWildTotal = new System.Windows.Forms.Label();
            cboWildClass = new ArkViewer.UI.BorderlessComboBox();
            tabFeatures = new System.Windows.Forms.TabControl();
            mnuContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tpgLeaderboard.SuspendLayout();
            tpgLocalProfile.SuspendLayout();
            pnlUploadedStats.SuspendLayout();
            tpgPaintings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPainting).BeginInit();
            tpgItemList.SuspendLayout();
            pnlFilterSearch.SuspendLayout();
            tpgDroppedItems.SuspendLayout();
            pnlFilterDropped.SuspendLayout();
            tpgPlayers.SuspendLayout();
            pnlFilterPlayers.SuspendLayout();
            tpgTribes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            pnlFilterTribes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udChartTop).BeginInit();
            tpgStructures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udRadiusStructures).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udLonStructures).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udLatStructures).BeginInit();
            pnlFilterStructures.SuspendLayout();
            tpgTamed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udRadiusTamed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udLonTamed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udLatTamed).BeginInit();
            pnlFilterTamed.SuspendLayout();
            pnlTameStatTypes.SuspendLayout();
            tpgWild.SuspendLayout();
            pnlFilterWilds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udWildRadius).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udWildLon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udWildLat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udWildMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udWildMax).BeginInit();
            tabFeatures.SuspendLayout();
            SuspendLayout();
            // 
            // mnuContext
            // 
            mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuContext_PlayerId, mnuContext_SteamId, mnuContext_TribeId, mnuContext_DinoId, mnuContext_Export, mnuContext_Structures, mnuContext_Tames, mnuContext_Players, mnuContext_ProfileFilename });
            mnuContext.Name = "mnuContext";
            mnuContext.Size = new System.Drawing.Size(208, 202);
            mnuContext.Opening += mnuContext_Opening;
            // 
            // mnuContext_PlayerId
            // 
            mnuContext_PlayerId.Name = "mnuContext_PlayerId";
            mnuContext_PlayerId.Size = new System.Drawing.Size(207, 22);
            mnuContext_PlayerId.Text = "Copy Player ID";
            mnuContext_PlayerId.Click += mnuContext_PlayerId_Click;
            // 
            // mnuContext_SteamId
            // 
            mnuContext_SteamId.Name = "mnuContext_SteamId";
            mnuContext_SteamId.Size = new System.Drawing.Size(207, 22);
            mnuContext_SteamId.Text = "Copy Steam ID";
            mnuContext_SteamId.Click += mnuContext_SteamId_Click;
            // 
            // mnuContext_TribeId
            // 
            mnuContext_TribeId.Name = "mnuContext_TribeId";
            mnuContext_TribeId.Size = new System.Drawing.Size(207, 22);
            mnuContext_TribeId.Text = "Copy Tribe ID";
            mnuContext_TribeId.Click += mnuContext_TribeId_Click;
            // 
            // mnuContext_DinoId
            // 
            mnuContext_DinoId.Name = "mnuContext_DinoId";
            mnuContext_DinoId.Size = new System.Drawing.Size(207, 22);
            mnuContext_DinoId.Text = "Copy DinoId";
            mnuContext_DinoId.Click += mnuContext_DinoId_Click;
            // 
            // mnuContext_Export
            // 
            mnuContext_Export.Name = "mnuContext_Export";
            mnuContext_Export.Size = new System.Drawing.Size(207, 22);
            mnuContext_Export.Text = "Export Data";
            mnuContext_Export.Click += mnuContext_ExportData_Click;
            // 
            // mnuContext_Structures
            // 
            mnuContext_Structures.Name = "mnuContext_Structures";
            mnuContext_Structures.Size = new System.Drawing.Size(207, 22);
            mnuContext_Structures.Text = "View Structures";
            mnuContext_Structures.Visible = false;
            mnuContext_Structures.Click += mnuContext_Structures_Click;
            // 
            // mnuContext_Tames
            // 
            mnuContext_Tames.Name = "mnuContext_Tames";
            mnuContext_Tames.Size = new System.Drawing.Size(207, 22);
            mnuContext_Tames.Text = "View Tames";
            mnuContext_Tames.Visible = false;
            mnuContext_Tames.Click += mnuContext_Tames_Click;
            // 
            // mnuContext_Players
            // 
            mnuContext_Players.Name = "mnuContext_Players";
            mnuContext_Players.Size = new System.Drawing.Size(207, 22);
            mnuContext_Players.Text = "View Players";
            mnuContext_Players.Visible = false;
            mnuContext_Players.Click += mnuContext_Players_Click;
            // 
            // mnuContext_ProfileFilename
            // 
            mnuContext_ProfileFilename.Name = "mnuContext_ProfileFilename";
            mnuContext_ProfileFilename.Size = new System.Drawing.Size(207, 22);
            mnuContext_ProfileFilename.Text = "Copy .arkprofile filename";
            mnuContext_ProfileFilename.Click += mnuContext_ProfileFilename_Click;
            // 
            // lblMapDate
            // 
            lblMapDate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblMapDate.BackColor = System.Drawing.Color.Transparent;
            lblMapDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMapDate.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            lblMapDate.Location = new System.Drawing.Point(597, 1);
            lblMapDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMapDate.Name = "lblMapDate";
            lblMapDate.Size = new System.Drawing.Size(523, 21);
            lblMapDate.TabIndex = 3;
            lblMapDate.Text = "No Map Loaded";
            lblMapDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblMapDate.Click += lblMapDate_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Image = (System.Drawing.Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new System.Drawing.Point(931, 645);
            btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(58, 58);
            btnRefresh.TabIndex = 2;
            btnRefresh.TabStop = false;
            toolTip1.SetToolTip(btnRefresh, "Refresh loaded map.");
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSettings.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSettings.Image = (System.Drawing.Image)resources.GetObject("btnSettings.Image");
            btnSettings.Location = new System.Drawing.Point(1062, 645);
            btnSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new System.Drawing.Size(58, 58);
            btnSettings.TabIndex = 4;
            btnSettings.TabStop = false;
            toolTip1.SetToolTip(btnSettings, "Show available settings.");
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnViewMap
            // 
            btnViewMap.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnViewMap.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnViewMap.Cursor = System.Windows.Forms.Cursors.Hand;
            btnViewMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnViewMap.Image = (System.Drawing.Image)resources.GetObject("btnViewMap.Image");
            btnViewMap.Location = new System.Drawing.Point(996, 645);
            btnViewMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnViewMap.Name = "btnViewMap";
            btnViewMap.Size = new System.Drawing.Size(58, 58);
            btnViewMap.TabIndex = 3;
            btnViewMap.TabStop = false;
            toolTip1.SetToolTip(btnViewMap, "Show map image view.");
            btnViewMap.UseVisualStyleBackColor = false;
            btnViewMap.Click += btnViewMap_Click;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblStatus.AutoEllipsis = true;
            lblStatus.BackColor = System.Drawing.Color.Transparent;
            lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblStatus.Location = new System.Drawing.Point(19, 645);
            lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(908, 58);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Use settings page to select a save game or press refresh to reload data.";
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblTitle.Location = new System.Drawing.Point(96, 7);
            lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(71, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ASV";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(175, 175, 175);
            lblSubTitle.Location = new System.Drawing.Point(100, 39);
            lblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new System.Drawing.Size(189, 16);
            lblSubTitle.TabIndex = 2;
            lblSubTitle.Text = "ARK Savegame Visualiser";
            // 
            // lblMapTypeName
            // 
            lblMapTypeName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblMapTypeName.BackColor = System.Drawing.Color.Transparent;
            lblMapTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMapTypeName.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblMapTypeName.Location = new System.Drawing.Point(532, 21);
            lblMapTypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMapTypeName.Name = "lblMapTypeName";
            lblMapTypeName.Size = new System.Drawing.Size(588, 21);
            lblMapTypeName.TabIndex = 4;
            lblMapTypeName.Text = "Unknown Data";
            lblMapTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.BackColor = System.Drawing.Color.Transparent;
            lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblVersion.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblVersion.Location = new System.Drawing.Point(102, 58);
            lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(31, 16);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "v0.0";
            // 
            // btnConsoleCommandPainting
            // 
            btnConsoleCommandPainting.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnConsoleCommandPainting.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnConsoleCommandPainting.Cursor = System.Windows.Forms.Cursors.Hand;
            btnConsoleCommandPainting.Enabled = false;
            btnConsoleCommandPainting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConsoleCommandPainting.Image = (System.Drawing.Image)resources.GetObject("btnConsoleCommandPainting.Image");
            btnConsoleCommandPainting.Location = new System.Drawing.Point(404, 462);
            btnConsoleCommandPainting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnConsoleCommandPainting.Name = "btnConsoleCommandPainting";
            btnConsoleCommandPainting.Size = new System.Drawing.Size(47, 46);
            btnConsoleCommandPainting.TabIndex = 28;
            toolTip1.SetToolTip(btnConsoleCommandPainting, "Copy command to clipboard.");
            btnConsoleCommandPainting.UseVisualStyleBackColor = false;
            btnConsoleCommandPainting.Click += btnConsoleCommandPainting_Click;
            // 
            // btnDeletePaintings
            // 
            btnDeletePaintings.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnDeletePaintings.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnDeletePaintings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnDeletePaintings.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDeletePaintings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeletePaintings.Image = (System.Drawing.Image)resources.GetObject("btnDeletePaintings.Image");
            btnDeletePaintings.Location = new System.Drawing.Point(459, 462);
            btnDeletePaintings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeletePaintings.Name = "btnDeletePaintings";
            btnDeletePaintings.Size = new System.Drawing.Size(47, 46);
            btnDeletePaintings.TabIndex = 36;
            toolTip1.SetToolTip(btnDeletePaintings, "Delete unused .pnt files");
            btnDeletePaintings.UseVisualStyleBackColor = false;
            btnDeletePaintings.Click += btnDeletePaintings_Click;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.Location = new System.Drawing.Point(1841, -1);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(35, 33);
            button1.TabIndex = 9;
            toolTip1.SetToolTip(button1, "Find next");
            button1.UseVisualStyleBackColor = true;
            // 
            // btnFindSearched
            // 
            btnFindSearched.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnFindSearched.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            btnFindSearched.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFindSearched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFindSearched.Image = (System.Drawing.Image)resources.GetObject("btnFindSearched.Image");
            btnFindSearched.Location = new System.Drawing.Point(1037, -1);
            btnFindSearched.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFindSearched.Name = "btnFindSearched";
            btnFindSearched.Size = new System.Drawing.Size(35, 33);
            btnFindSearched.TabIndex = 9;
            toolTip1.SetToolTip(btnFindSearched, "Find next");
            btnFindSearched.UseVisualStyleBackColor = false;
            btnFindSearched.Click += btnFindSearched_Click;
            // 
            // btnCopyCommandDropped
            // 
            btnCopyCommandDropped.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCopyCommandDropped.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnCopyCommandDropped.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCopyCommandDropped.Enabled = false;
            btnCopyCommandDropped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCopyCommandDropped.Image = (System.Drawing.Image)resources.GetObject("btnCopyCommandDropped.Image");
            btnCopyCommandDropped.Location = new System.Drawing.Point(408, 466);
            btnCopyCommandDropped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCopyCommandDropped.Name = "btnCopyCommandDropped";
            btnCopyCommandDropped.Size = new System.Drawing.Size(47, 46);
            btnCopyCommandDropped.TabIndex = 7;
            toolTip1.SetToolTip(btnCopyCommandDropped, "Copy command to clipboard.");
            btnCopyCommandDropped.UseVisualStyleBackColor = false;
            btnCopyCommandDropped.Click += btnCopyCommandDropped_Click;
            // 
            // btnDropInventory
            // 
            btnDropInventory.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnDropInventory.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnDropInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDropInventory.Enabled = false;
            btnDropInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDropInventory.Image = (System.Drawing.Image)resources.GetObject("btnDropInventory.Image");
            btnDropInventory.Location = new System.Drawing.Point(460, 466);
            btnDropInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDropInventory.Name = "btnDropInventory";
            btnDropInventory.Size = new System.Drawing.Size(47, 46);
            btnDropInventory.TabIndex = 8;
            toolTip1.SetToolTip(btnDropInventory, "View inventory.");
            btnDropInventory.UseVisualStyleBackColor = false;
            btnDropInventory.Click += btnDropInventory_Click;
            // 
            // chkDroppedBlueprints
            // 
            chkDroppedBlueprints.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            chkDroppedBlueprints.Appearance = System.Windows.Forms.Appearance.Button;
            chkDroppedBlueprints.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            chkDroppedBlueprints.BackgroundImage = (System.Drawing.Image)resources.GetObject("chkDroppedBlueprints.BackgroundImage");
            chkDroppedBlueprints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            chkDroppedBlueprints.Cursor = System.Windows.Forms.Cursors.Hand;
            chkDroppedBlueprints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkDroppedBlueprints.Location = new System.Drawing.Point(1053, 12);
            chkDroppedBlueprints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkDroppedBlueprints.Name = "chkDroppedBlueprints";
            chkDroppedBlueprints.Size = new System.Drawing.Size(35, 33);
            chkDroppedBlueprints.TabIndex = 10;
            toolTip1.SetToolTip(chkDroppedBlueprints, "Show / hide blueprints.");
            chkDroppedBlueprints.UseVisualStyleBackColor = false;
            chkDroppedBlueprints.CheckedChanged += chkDroppedBlueprints_CheckedChanged;
            // 
            // btnFindDropped
            // 
            btnFindDropped.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnFindDropped.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            btnFindDropped.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFindDropped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFindDropped.Image = (System.Drawing.Image)resources.GetObject("btnFindDropped.Image");
            btnFindDropped.Location = new System.Drawing.Point(1040, -1);
            btnFindDropped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFindDropped.Name = "btnFindDropped";
            btnFindDropped.Size = new System.Drawing.Size(35, 33);
            btnFindDropped.TabIndex = 9;
            toolTip1.SetToolTip(btnFindDropped, "Find next");
            btnFindDropped.UseVisualStyleBackColor = false;
            btnFindDropped.Click += btnFindDropped_Click;
            // 
            // btnPlayerInventory
            // 
            btnPlayerInventory.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnPlayerInventory.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnPlayerInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPlayerInventory.Enabled = false;
            btnPlayerInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPlayerInventory.Image = (System.Drawing.Image)resources.GetObject("btnPlayerInventory.Image");
            btnPlayerInventory.Location = new System.Drawing.Point(563, 463);
            btnPlayerInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPlayerInventory.Name = "btnPlayerInventory";
            btnPlayerInventory.Size = new System.Drawing.Size(47, 46);
            btnPlayerInventory.TabIndex = 9;
            toolTip1.SetToolTip(btnPlayerInventory, "Show player explorer.");
            btnPlayerInventory.UseVisualStyleBackColor = false;
            btnPlayerInventory.Click += btnPlayerInventory_Click;
            // 
            // btnPlayerTribeLog
            // 
            btnPlayerTribeLog.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnPlayerTribeLog.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnPlayerTribeLog.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPlayerTribeLog.Enabled = false;
            btnPlayerTribeLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPlayerTribeLog.Image = (System.Drawing.Image)resources.GetObject("btnPlayerTribeLog.Image");
            btnPlayerTribeLog.Location = new System.Drawing.Point(512, 463);
            btnPlayerTribeLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPlayerTribeLog.Name = "btnPlayerTribeLog";
            btnPlayerTribeLog.Size = new System.Drawing.Size(47, 46);
            btnPlayerTribeLog.TabIndex = 8;
            toolTip1.SetToolTip(btnPlayerTribeLog, "View tribe log.");
            btnPlayerTribeLog.UseVisualStyleBackColor = false;
            btnPlayerTribeLog.Click += btnPlayerTribeLog_Click;
            // 
            // btnCopyCommandPlayer
            // 
            btnCopyCommandPlayer.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCopyCommandPlayer.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnCopyCommandPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCopyCommandPlayer.Enabled = false;
            btnCopyCommandPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCopyCommandPlayer.Image = (System.Drawing.Image)resources.GetObject("btnCopyCommandPlayer.Image");
            btnCopyCommandPlayer.Location = new System.Drawing.Point(408, 463);
            btnCopyCommandPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCopyCommandPlayer.Name = "btnCopyCommandPlayer";
            btnCopyCommandPlayer.Size = new System.Drawing.Size(47, 46);
            btnCopyCommandPlayer.TabIndex = 7;
            toolTip1.SetToolTip(btnCopyCommandPlayer, "Copy command to clipboard.");
            btnCopyCommandPlayer.UseVisualStyleBackColor = false;
            btnCopyCommandPlayer.Click += btnCopyCommandPlayer_Click;
            // 
            // btnDeletePlayer
            // 
            btnDeletePlayer.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnDeletePlayer.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnDeletePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDeletePlayer.Enabled = false;
            btnDeletePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeletePlayer.Image = (System.Drawing.Image)resources.GetObject("btnDeletePlayer.Image");
            btnDeletePlayer.Location = new System.Drawing.Point(613, 463);
            btnDeletePlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeletePlayer.Name = "btnDeletePlayer";
            btnDeletePlayer.Size = new System.Drawing.Size(47, 46);
            btnDeletePlayer.TabIndex = 10;
            toolTip1.SetToolTip(btnDeletePlayer, "Remove player.");
            btnDeletePlayer.UseVisualStyleBackColor = false;
            btnDeletePlayer.Click += btnDeletePlayer_Click;
            // 
            // btnFilterPlayer
            // 
            btnFilterPlayer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnFilterPlayer.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            btnFilterPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFilterPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFilterPlayer.Image = (System.Drawing.Image)resources.GetObject("btnFilterPlayer.Image");
            btnFilterPlayer.Location = new System.Drawing.Point(1036, -1);
            btnFilterPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFilterPlayer.Name = "btnFilterPlayer";
            btnFilterPlayer.Size = new System.Drawing.Size(35, 33);
            btnFilterPlayer.TabIndex = 9;
            toolTip1.SetToolTip(btnFilterPlayer, "Find next");
            btnFilterPlayer.UseVisualStyleBackColor = false;
            btnFilterPlayer.Click += btnFilterPlayer_Click;
            // 
            // btnRconCommandPlayers
            // 
            btnRconCommandPlayers.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRconCommandPlayers.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRconCommandPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRconCommandPlayers.Enabled = false;
            btnRconCommandPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRconCommandPlayers.Image = (System.Drawing.Image)resources.GetObject("btnRconCommandPlayers.Image");
            btnRconCommandPlayers.Location = new System.Drawing.Point(459, 463);
            btnRconCommandPlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRconCommandPlayers.Name = "btnRconCommandPlayers";
            btnRconCommandPlayers.Size = new System.Drawing.Size(47, 46);
            btnRconCommandPlayers.TabIndex = 26;
            toolTip1.SetToolTip(btnRconCommandPlayers, "Send command to server using RCON.");
            btnRconCommandPlayers.UseVisualStyleBackColor = false;
            btnRconCommandPlayers.Visible = false;
            btnRconCommandPlayers.Click += btnRconCommandPlayers_Click;
            // 
            // btnTribeLog
            // 
            btnTribeLog.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnTribeLog.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnTribeLog.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTribeLog.Enabled = false;
            btnTribeLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTribeLog.Image = (System.Drawing.Image)resources.GetObject("btnTribeLog.Image");
            btnTribeLog.Location = new System.Drawing.Point(516, 464);
            btnTribeLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnTribeLog.Name = "btnTribeLog";
            btnTribeLog.Size = new System.Drawing.Size(47, 46);
            btnTribeLog.TabIndex = 4;
            toolTip1.SetToolTip(btnTribeLog, "View tribe log.");
            btnTribeLog.UseVisualStyleBackColor = false;
            btnTribeLog.Click += btnTribeLog_Click;
            // 
            // btnTribeCopyCommand
            // 
            btnTribeCopyCommand.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnTribeCopyCommand.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnTribeCopyCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTribeCopyCommand.Enabled = false;
            btnTribeCopyCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTribeCopyCommand.Image = (System.Drawing.Image)resources.GetObject("btnTribeCopyCommand.Image");
            btnTribeCopyCommand.Location = new System.Drawing.Point(408, 464);
            btnTribeCopyCommand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnTribeCopyCommand.Name = "btnTribeCopyCommand";
            btnTribeCopyCommand.Size = new System.Drawing.Size(47, 46);
            btnTribeCopyCommand.TabIndex = 3;
            toolTip1.SetToolTip(btnTribeCopyCommand, "Copy command to clipboard.");
            btnTribeCopyCommand.UseVisualStyleBackColor = false;
            btnTribeCopyCommand.Click += btnTribeCopyCommand_Click;
            // 
            // chkTribePlayers
            // 
            chkTribePlayers.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            chkTribePlayers.BackColor = System.Drawing.Color.CornflowerBlue;
            chkTribePlayers.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            chkTribePlayers.Checked = true;
            chkTribePlayers.CheckState = System.Windows.Forms.CheckState.Checked;
            chkTribePlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            chkTribePlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkTribePlayers.ForeColor = System.Drawing.Color.LightCyan;
            chkTribePlayers.Location = new System.Drawing.Point(676, 467);
            chkTribePlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkTribePlayers.Name = "chkTribePlayers";
            chkTribePlayers.Size = new System.Drawing.Size(133, 40);
            chkTribePlayers.TabIndex = 5;
            chkTribePlayers.Text = "Player Markers";
            chkTribePlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(chkTribePlayers, "Show player markers.");
            chkTribePlayers.UseVisualStyleBackColor = false;
            chkTribePlayers.CheckedChanged += chkTribePlayers_CheckedChanged;
            // 
            // chkTribeTames
            // 
            chkTribeTames.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            chkTribeTames.BackColor = System.Drawing.Color.Gold;
            chkTribeTames.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            chkTribeTames.Cursor = System.Windows.Forms.Cursors.Hand;
            chkTribeTames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkTribeTames.ForeColor = System.Drawing.Color.Chocolate;
            chkTribeTames.Location = new System.Drawing.Point(816, 467);
            chkTribeTames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkTribeTames.Name = "chkTribeTames";
            chkTribeTames.Size = new System.Drawing.Size(122, 40);
            chkTribeTames.TabIndex = 6;
            chkTribeTames.Text = "Tame Markers";
            chkTribeTames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(chkTribeTames, "Show tame markers.");
            chkTribeTames.UseVisualStyleBackColor = false;
            chkTribeTames.CheckedChanged += chkTribeTames_CheckedChanged;
            // 
            // chkTribeStructures
            // 
            chkTribeStructures.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            chkTribeStructures.BackColor = System.Drawing.Color.PaleGreen;
            chkTribeStructures.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            chkTribeStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            chkTribeStructures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkTribeStructures.ForeColor = System.Drawing.Color.ForestGreen;
            chkTribeStructures.Location = new System.Drawing.Point(945, 467);
            chkTribeStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkTribeStructures.Name = "chkTribeStructures";
            chkTribeStructures.Size = new System.Drawing.Size(141, 40);
            chkTribeStructures.TabIndex = 7;
            chkTribeStructures.Text = "Structure Markers";
            chkTribeStructures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(chkTribeStructures, "Show structure markers.");
            chkTribeStructures.UseVisualStyleBackColor = false;
            chkTribeStructures.CheckedChanged += chkTribeStructures_CheckedChanged;
            // 
            // btnSaveChartImage
            // 
            btnSaveChartImage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSaveChartImage.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnSaveChartImage.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSaveChartImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveChartImage.Image = (System.Drawing.Image)resources.GetObject("btnSaveChartImage.Image");
            btnSaveChartImage.Location = new System.Drawing.Point(304, 40);
            btnSaveChartImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSaveChartImage.Name = "btnSaveChartImage";
            btnSaveChartImage.Size = new System.Drawing.Size(38, 35);
            btnSaveChartImage.TabIndex = 52;
            btnSaveChartImage.TabStop = false;
            toolTip1.SetToolTip(btnSaveChartImage, "Save chart image.");
            btnSaveChartImage.UseVisualStyleBackColor = false;
            btnSaveChartImage.Click += btnSaveChart_Click;
            // 
            // btnFilterTribe
            // 
            btnFilterTribe.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnFilterTribe.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            btnFilterTribe.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFilterTribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFilterTribe.Image = (System.Drawing.Image)resources.GetObject("btnFilterTribe.Image");
            btnFilterTribe.Location = new System.Drawing.Point(674, -1);
            btnFilterTribe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFilterTribe.Name = "btnFilterTribe";
            btnFilterTribe.Size = new System.Drawing.Size(35, 33);
            btnFilterTribe.TabIndex = 9;
            toolTip1.SetToolTip(btnFilterTribe, "Find next");
            btnFilterTribe.UseVisualStyleBackColor = false;
            btnFilterTribe.Click += btnFilterTribe_Click;
            // 
            // btnRconCommandTribes
            // 
            btnRconCommandTribes.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRconCommandTribes.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRconCommandTribes.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRconCommandTribes.Enabled = false;
            btnRconCommandTribes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRconCommandTribes.Image = (System.Drawing.Image)resources.GetObject("btnRconCommandTribes.Image");
            btnRconCommandTribes.Location = new System.Drawing.Point(463, 464);
            btnRconCommandTribes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRconCommandTribes.Name = "btnRconCommandTribes";
            btnRconCommandTribes.Size = new System.Drawing.Size(47, 46);
            btnRconCommandTribes.TabIndex = 25;
            toolTip1.SetToolTip(btnRconCommandTribes, "Send command to server using RCON.");
            btnRconCommandTribes.UseVisualStyleBackColor = false;
            btnRconCommandTribes.Visible = false;
            btnRconCommandTribes.Click += btnRconCommandTribes_Click;
            // 
            // btnStructureExclusionFilter
            // 
            btnStructureExclusionFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnStructureExclusionFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            btnStructureExclusionFilter.Image = (System.Drawing.Image)resources.GetObject("btnStructureExclusionFilter.Image");
            btnStructureExclusionFilter.Location = new System.Drawing.Point(1054, 10);
            btnStructureExclusionFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStructureExclusionFilter.Name = "btnStructureExclusionFilter";
            btnStructureExclusionFilter.Size = new System.Drawing.Size(33, 34);
            btnStructureExclusionFilter.TabIndex = 6;
            toolTip1.SetToolTip(btnStructureExclusionFilter, "Structure exclusion list");
            btnStructureExclusionFilter.UseVisualStyleBackColor = true;
            btnStructureExclusionFilter.Click += btnStructureExclusionFilter_Click;
            // 
            // btnCopyCommandStructure
            // 
            btnCopyCommandStructure.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCopyCommandStructure.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnCopyCommandStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCopyCommandStructure.Enabled = false;
            btnCopyCommandStructure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCopyCommandStructure.Image = (System.Drawing.Image)resources.GetObject("btnCopyCommandStructure.Image");
            btnCopyCommandStructure.Location = new System.Drawing.Point(402, 466);
            btnCopyCommandStructure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCopyCommandStructure.Name = "btnCopyCommandStructure";
            btnCopyCommandStructure.Size = new System.Drawing.Size(47, 46);
            btnCopyCommandStructure.TabIndex = 10;
            toolTip1.SetToolTip(btnCopyCommandStructure, "Copy command to clipboard.");
            btnCopyCommandStructure.UseVisualStyleBackColor = false;
            btnCopyCommandStructure.Click += btnCopyCommandStructure_Click;
            // 
            // btnStructureInventory
            // 
            btnStructureInventory.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnStructureInventory.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnStructureInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            btnStructureInventory.Enabled = false;
            btnStructureInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStructureInventory.Image = (System.Drawing.Image)resources.GetObject("btnStructureInventory.Image");
            btnStructureInventory.Location = new System.Drawing.Point(509, 466);
            btnStructureInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStructureInventory.Name = "btnStructureInventory";
            btnStructureInventory.Size = new System.Drawing.Size(47, 46);
            btnStructureInventory.TabIndex = 11;
            toolTip1.SetToolTip(btnStructureInventory, "View inventory.");
            btnStructureInventory.UseVisualStyleBackColor = false;
            btnStructureInventory.Click += btnStructureInventory_Click;
            // 
            // btnFindStructures
            // 
            btnFindStructures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnFindStructures.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            btnFindStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFindStructures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFindStructures.Image = (System.Drawing.Image)resources.GetObject("btnFindStructures.Image");
            btnFindStructures.Location = new System.Drawing.Point(1037, -1);
            btnFindStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFindStructures.Name = "btnFindStructures";
            btnFindStructures.Size = new System.Drawing.Size(35, 33);
            btnFindStructures.TabIndex = 9;
            toolTip1.SetToolTip(btnFindStructures, "Find next");
            btnFindStructures.UseVisualStyleBackColor = false;
            btnFindStructures.Click += btnFindStructures_Click;
            // 
            // btnRconCommandStructures
            // 
            btnRconCommandStructures.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRconCommandStructures.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRconCommandStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRconCommandStructures.Enabled = false;
            btnRconCommandStructures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRconCommandStructures.Image = (System.Drawing.Image)resources.GetObject("btnRconCommandStructures.Image");
            btnRconCommandStructures.Location = new System.Drawing.Point(456, 466);
            btnRconCommandStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRconCommandStructures.Name = "btnRconCommandStructures";
            btnRconCommandStructures.Size = new System.Drawing.Size(47, 46);
            btnRconCommandStructures.TabIndex = 25;
            toolTip1.SetToolTip(btnRconCommandStructures, "Copy command to clipboard.");
            btnRconCommandStructures.UseVisualStyleBackColor = false;
            btnRconCommandStructures.Visible = false;
            btnRconCommandStructures.Click += btnRconCommandStructures_Click;
            // 
            // btnDinoInventory
            // 
            btnDinoInventory.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnDinoInventory.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnDinoInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDinoInventory.Enabled = false;
            btnDinoInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDinoInventory.Image = (System.Drawing.Image)resources.GetObject("btnDinoInventory.Image");
            btnDinoInventory.Location = new System.Drawing.Point(861, 465);
            btnDinoInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDinoInventory.Name = "btnDinoInventory";
            btnDinoInventory.Size = new System.Drawing.Size(47, 46);
            btnDinoInventory.TabIndex = 13;
            toolTip1.SetToolTip(btnDinoInventory, "View inventory.");
            btnDinoInventory.UseVisualStyleBackColor = false;
            btnDinoInventory.Click += btnDinoInventory_Click;
            // 
            // btnDinoAncestors
            // 
            btnDinoAncestors.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnDinoAncestors.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnDinoAncestors.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDinoAncestors.Enabled = false;
            btnDinoAncestors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDinoAncestors.Image = (System.Drawing.Image)resources.GetObject("btnDinoAncestors.Image");
            btnDinoAncestors.Location = new System.Drawing.Point(810, 465);
            btnDinoAncestors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDinoAncestors.Name = "btnDinoAncestors";
            btnDinoAncestors.Size = new System.Drawing.Size(47, 46);
            btnDinoAncestors.TabIndex = 12;
            toolTip1.SetToolTip(btnDinoAncestors, "View breeding lines.");
            btnDinoAncestors.UseVisualStyleBackColor = false;
            btnDinoAncestors.Click += btnDinoAncestors_Click;
            // 
            // btnCopyCommandTamed
            // 
            btnCopyCommandTamed.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCopyCommandTamed.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnCopyCommandTamed.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCopyCommandTamed.Enabled = false;
            btnCopyCommandTamed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCopyCommandTamed.Image = (System.Drawing.Image)resources.GetObject("btnCopyCommandTamed.Image");
            btnCopyCommandTamed.Location = new System.Drawing.Point(707, 465);
            btnCopyCommandTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCopyCommandTamed.Name = "btnCopyCommandTamed";
            btnCopyCommandTamed.Size = new System.Drawing.Size(47, 46);
            btnCopyCommandTamed.TabIndex = 11;
            toolTip1.SetToolTip(btnCopyCommandTamed, "Copy command to clipboard.");
            btnCopyCommandTamed.UseVisualStyleBackColor = false;
            btnCopyCommandTamed.Click += btnCopyCommandTamed_Click;
            // 
            // btnFindTamed
            // 
            btnFindTamed.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnFindTamed.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            btnFindTamed.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFindTamed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFindTamed.Image = (System.Drawing.Image)resources.GetObject("btnFindTamed.Image");
            btnFindTamed.Location = new System.Drawing.Point(1037, -1);
            btnFindTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFindTamed.Name = "btnFindTamed";
            btnFindTamed.Size = new System.Drawing.Size(35, 33);
            btnFindTamed.TabIndex = 9;
            toolTip1.SetToolTip(btnFindTamed, "Find next");
            btnFindTamed.UseVisualStyleBackColor = false;
            btnFindTamed.Click += btnFindTamed_Click;
            // 
            // btnRconCommandTamed
            // 
            btnRconCommandTamed.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRconCommandTamed.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRconCommandTamed.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRconCommandTamed.Enabled = false;
            btnRconCommandTamed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRconCommandTamed.Image = (System.Drawing.Image)resources.GetObject("btnRconCommandTamed.Image");
            btnRconCommandTamed.Location = new System.Drawing.Point(759, 465);
            btnRconCommandTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRconCommandTamed.Name = "btnRconCommandTamed";
            btnRconCommandTamed.Size = new System.Drawing.Size(47, 46);
            btnRconCommandTamed.TabIndex = 26;
            toolTip1.SetToolTip(btnRconCommandTamed, "Send command to server using RCON.");
            btnRconCommandTamed.UseVisualStyleBackColor = false;
            btnRconCommandTamed.Visible = false;
            btnRconCommandTamed.Click += btnRconCommandTamed_Click;
            // 
            // btnCopyCommandWild
            // 
            btnCopyCommandWild.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCopyCommandWild.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnCopyCommandWild.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCopyCommandWild.Enabled = false;
            btnCopyCommandWild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCopyCommandWild.Image = (System.Drawing.Image)resources.GetObject("btnCopyCommandWild.Image");
            btnCopyCommandWild.Location = new System.Drawing.Point(408, 460);
            btnCopyCommandWild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCopyCommandWild.Name = "btnCopyCommandWild";
            btnCopyCommandWild.Size = new System.Drawing.Size(47, 46);
            btnCopyCommandWild.TabIndex = 17;
            toolTip1.SetToolTip(btnCopyCommandWild, "Copy command to clipboard.");
            btnCopyCommandWild.UseVisualStyleBackColor = false;
            btnCopyCommandWild.Click += btnCopyCommandWild_Click;
            // 
            // btnFindWild
            // 
            btnFindWild.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnFindWild.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            btnFindWild.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFindWild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFindWild.Image = (System.Drawing.Image)resources.GetObject("btnFindWild.Image");
            btnFindWild.Location = new System.Drawing.Point(1037, -1);
            btnFindWild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFindWild.Name = "btnFindWild";
            btnFindWild.Size = new System.Drawing.Size(35, 33);
            btnFindWild.TabIndex = 8;
            toolTip1.SetToolTip(btnFindWild, "Find next");
            btnFindWild.UseVisualStyleBackColor = false;
            btnFindWild.Click += btnFindWild_Click;
            // 
            // btnRconCommandWild
            // 
            btnRconCommandWild.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRconCommandWild.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRconCommandWild.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRconCommandWild.Enabled = false;
            btnRconCommandWild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRconCommandWild.Image = (System.Drawing.Image)resources.GetObject("btnRconCommandWild.Image");
            btnRconCommandWild.Location = new System.Drawing.Point(463, 460);
            btnRconCommandWild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRconCommandWild.Name = "btnRconCommandWild";
            btnRconCommandWild.Size = new System.Drawing.Size(47, 46);
            btnRconCommandWild.TabIndex = 24;
            toolTip1.SetToolTip(btnRconCommandWild, "Send command to server using RCON.");
            btnRconCommandWild.UseVisualStyleBackColor = false;
            btnRconCommandWild.Visible = false;
            btnRconCommandWild.Click += btnRconCommandWild_Click;
            // 
            // lblMap
            // 
            lblMap.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblMap.AutoSize = true;
            lblMap.BackColor = System.Drawing.Color.Transparent;
            lblMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMap.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblMap.Location = new System.Drawing.Point(786, 55);
            lblMap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMap.Name = "lblMap";
            lblMap.Size = new System.Drawing.Size(89, 13);
            lblMap.TabIndex = 25;
            lblMap.Text = "Selected Map:";
            lblMap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSelectedMap
            // 
            cboSelectedMap.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cboSelectedMap.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            cboSelectedMap.BorderColor = System.Drawing.Color.FromArgb(50, 50, 50);
            cboSelectedMap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboSelectedMap.DropDownHeight = 100;
            cboSelectedMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboSelectedMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboSelectedMap.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboSelectedMap.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboSelectedMap.FormattingEnabled = true;
            cboSelectedMap.IntegralHeight = false;
            cboSelectedMap.ItemHeight = 14;
            cboSelectedMap.Location = new System.Drawing.Point(882, 51);
            cboSelectedMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboSelectedMap.Name = "cboSelectedMap";
            cboSelectedMap.Size = new System.Drawing.Size(241, 20);
            cboSelectedMap.TabIndex = 26;
            cboSelectedMap.TabStop = false;
            cboSelectedMap.SelectedIndexChanged += cboSelectedMap_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(25, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(64, 64);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(1037, 82);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(0, 15);
            linkLabel1.TabIndex = 28;
            // 
            // tpgLeaderboard
            // 
            tpgLeaderboard.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgLeaderboard.Controls.Add(cboLeaderboardPlayer);
            tpgLeaderboard.Controls.Add(lblMissionPlayer);
            tpgLeaderboard.Controls.Add(lvwLeaderboardSummary);
            tpgLeaderboard.Controls.Add(lvwLeaderboard);
            tpgLeaderboard.Controls.Add(cboLeaderboardMission);
            tpgLeaderboard.Controls.Add(lblLeaderboardMission);
            tpgLeaderboard.Controls.Add(cboLeaderboardTribe);
            tpgLeaderboard.Controls.Add(lblLeaderboardTribe);
            tpgLeaderboard.Location = new System.Drawing.Point(4, 29);
            tpgLeaderboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgLeaderboard.Name = "tpgLeaderboard";
            tpgLeaderboard.Size = new System.Drawing.Size(1104, 525);
            tpgLeaderboard.TabIndex = 8;
            tpgLeaderboard.Text = "Leaderboard";
            // 
            // cboLeaderboardPlayer
            // 
            cboLeaderboardPlayer.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboLeaderboardPlayer.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboLeaderboardPlayer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboLeaderboardPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboLeaderboardPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboLeaderboardPlayer.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboLeaderboardPlayer.FormattingEnabled = true;
            cboLeaderboardPlayer.Location = new System.Drawing.Point(469, 243);
            cboLeaderboardPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboLeaderboardPlayer.Name = "cboLeaderboardPlayer";
            cboLeaderboardPlayer.Size = new System.Drawing.Size(279, 24);
            cboLeaderboardPlayer.TabIndex = 18;
            cboLeaderboardPlayer.SelectedIndexChanged += cboLeaderboardPlayer_SelectedIndexChanged;
            // 
            // lblMissionPlayer
            // 
            lblMissionPlayer.AutoSize = true;
            lblMissionPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMissionPlayer.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblMissionPlayer.Location = new System.Drawing.Point(401, 248);
            lblMissionPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMissionPlayer.Name = "lblMissionPlayer";
            lblMissionPlayer.Size = new System.Drawing.Size(46, 13);
            lblMissionPlayer.TabIndex = 17;
            lblMissionPlayer.Text = "Player:";
            lblMissionPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwLeaderboardSummary
            // 
            lvwLeaderboardSummary.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwLeaderboardSummary.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwLeaderboardSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvwLeaderboardSummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader32, columnHeader35, columnHeader36 });
            lvwLeaderboardSummary.ContextMenuStrip = mnuContext;
            lvwLeaderboardSummary.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwLeaderboardSummary.FullRowSelect = true;
            lvwLeaderboardSummary.Location = new System.Drawing.Point(14, 67);
            lvwLeaderboardSummary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwLeaderboardSummary.MultiSelect = false;
            lvwLeaderboardSummary.Name = "lvwLeaderboardSummary";
            lvwLeaderboardSummary.Size = new System.Drawing.Size(1073, 164);
            lvwLeaderboardSummary.TabIndex = 16;
            lvwLeaderboardSummary.UseCompatibleStateImageBehavior = false;
            lvwLeaderboardSummary.View = System.Windows.Forms.View.Details;
            lvwLeaderboardSummary.ColumnClick += lvwLeaderboardSummary_ColumnClick;
            // 
            // columnHeader32
            // 
            columnHeader32.Text = "Tribe";
            columnHeader32.Width = 170;
            // 
            // columnHeader35
            // 
            columnHeader35.Text = "Player";
            columnHeader35.Width = 179;
            // 
            // columnHeader36
            // 
            columnHeader36.Text = "Mission Count";
            columnHeader36.Width = 113;
            // 
            // lvwLeaderboard
            // 
            lvwLeaderboard.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwLeaderboard.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvwLeaderboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvwLeaderboard_Mission, lvwLeaderboard_Tribe, lvwLeaderboard_Player, lvwLeaderboard_Score });
            lvwLeaderboard.ContextMenuStrip = mnuContext;
            lvwLeaderboard.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwLeaderboard.FullRowSelect = true;
            lvwLeaderboard.Location = new System.Drawing.Point(14, 276);
            lvwLeaderboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwLeaderboard.MultiSelect = false;
            lvwLeaderboard.Name = "lvwLeaderboard";
            lvwLeaderboard.Size = new System.Drawing.Size(1073, 221);
            lvwLeaderboard.TabIndex = 15;
            lvwLeaderboard.UseCompatibleStateImageBehavior = false;
            lvwLeaderboard.View = System.Windows.Forms.View.Details;
            lvwLeaderboard.ColumnClick += lvwLeaderboard_ColumnClick;
            // 
            // lvwLeaderboard_Mission
            // 
            lvwLeaderboard_Mission.Text = "Mission";
            lvwLeaderboard_Mission.Width = 350;
            // 
            // lvwLeaderboard_Tribe
            // 
            lvwLeaderboard_Tribe.Text = "Tribe";
            lvwLeaderboard_Tribe.Width = 170;
            // 
            // lvwLeaderboard_Player
            // 
            lvwLeaderboard_Player.Text = "Player";
            lvwLeaderboard_Player.Width = 179;
            // 
            // lvwLeaderboard_Score
            // 
            lvwLeaderboard_Score.Text = "Score";
            lvwLeaderboard_Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            lvwLeaderboard_Score.Width = 77;
            // 
            // cboLeaderboardMission
            // 
            cboLeaderboardMission.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboLeaderboardMission.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboLeaderboardMission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboLeaderboardMission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboLeaderboardMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboLeaderboardMission.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboLeaderboardMission.FormattingEnabled = true;
            cboLeaderboardMission.Location = new System.Drawing.Point(80, 243);
            cboLeaderboardMission.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboLeaderboardMission.Name = "cboLeaderboardMission";
            cboLeaderboardMission.Size = new System.Drawing.Size(279, 24);
            cboLeaderboardMission.TabIndex = 9;
            cboLeaderboardMission.SelectedIndexChanged += cboLeaderboardMission_SelectedIndexChanged;
            // 
            // lblLeaderboardMission
            // 
            lblLeaderboardMission.AutoSize = true;
            lblLeaderboardMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblLeaderboardMission.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblLeaderboardMission.Location = new System.Drawing.Point(13, 248);
            lblLeaderboardMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLeaderboardMission.Name = "lblLeaderboardMission";
            lblLeaderboardMission.Size = new System.Drawing.Size(53, 13);
            lblLeaderboardMission.TabIndex = 8;
            lblLeaderboardMission.Text = "Mission:";
            lblLeaderboardMission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboLeaderboardTribe
            // 
            cboLeaderboardTribe.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboLeaderboardTribe.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboLeaderboardTribe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboLeaderboardTribe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboLeaderboardTribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboLeaderboardTribe.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboLeaderboardTribe.FormattingEnabled = true;
            cboLeaderboardTribe.Location = new System.Drawing.Point(80, 31);
            cboLeaderboardTribe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboLeaderboardTribe.Name = "cboLeaderboardTribe";
            cboLeaderboardTribe.Size = new System.Drawing.Size(279, 24);
            cboLeaderboardTribe.TabIndex = 5;
            cboLeaderboardTribe.SelectedIndexChanged += cboLeaderboardTribe_SelectedIndexChanged;
            // 
            // lblLeaderboardTribe
            // 
            lblLeaderboardTribe.AutoSize = true;
            lblLeaderboardTribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblLeaderboardTribe.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblLeaderboardTribe.Location = new System.Drawing.Point(13, 36);
            lblLeaderboardTribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLeaderboardTribe.Name = "lblLeaderboardTribe";
            lblLeaderboardTribe.Size = new System.Drawing.Size(40, 13);
            lblLeaderboardTribe.TabIndex = 4;
            lblLeaderboardTribe.Text = "Tribe:";
            lblLeaderboardTribe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tpgLocalProfile
            // 
            tpgLocalProfile.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgLocalProfile.CausesValidation = false;
            tpgLocalProfile.Controls.Add(pnlUploadedStats);
            tpgLocalProfile.Controls.Add(lblUploadedCountItems);
            tpgLocalProfile.Controls.Add(lblUploadedCountTames);
            tpgLocalProfile.Controls.Add(lblUploadedCountCharacters);
            tpgLocalProfile.Controls.Add(lblUploadedItems);
            tpgLocalProfile.Controls.Add(lvwUploadedItems);
            tpgLocalProfile.Controls.Add(lblUploadedTames);
            tpgLocalProfile.Controls.Add(lblUploadedCharacters);
            tpgLocalProfile.Controls.Add(lvwUploadedCharacters);
            tpgLocalProfile.Controls.Add(lvwUploadedTames);
            tpgLocalProfile.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            tpgLocalProfile.Location = new System.Drawing.Point(4, 29);
            tpgLocalProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgLocalProfile.Name = "tpgLocalProfile";
            tpgLocalProfile.Size = new System.Drawing.Size(1104, 525);
            tpgLocalProfile.TabIndex = 7;
            tpgLocalProfile.Text = "Local Profile";
            // 
            // pnlUploadedStats
            // 
            pnlUploadedStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlUploadedStats.Controls.Add(lblUploadedStats);
            pnlUploadedStats.Controls.Add(optUploadedStatsTamed);
            pnlUploadedStats.Controls.Add(optUploadedStatsBase);
            pnlUploadedStats.Location = new System.Drawing.Point(15, 316);
            pnlUploadedStats.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlUploadedStats.Name = "pnlUploadedStats";
            pnlUploadedStats.Size = new System.Drawing.Size(204, 39);
            pnlUploadedStats.TabIndex = 17;
            // 
            // lblUploadedStats
            // 
            lblUploadedStats.AutoSize = true;
            lblUploadedStats.Location = new System.Drawing.Point(2, 12);
            lblUploadedStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUploadedStats.Name = "lblUploadedStats";
            lblUploadedStats.Size = new System.Drawing.Size(35, 15);
            lblUploadedStats.TabIndex = 0;
            lblUploadedStats.Text = "Stats:";
            // 
            // optUploadedStatsTamed
            // 
            optUploadedStatsTamed.AutoSize = true;
            optUploadedStatsTamed.Location = new System.Drawing.Point(113, 9);
            optUploadedStatsTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optUploadedStatsTamed.Name = "optUploadedStatsTamed";
            optUploadedStatsTamed.Size = new System.Drawing.Size(60, 19);
            optUploadedStatsTamed.TabIndex = 2;
            optUploadedStatsTamed.Text = "Tamed";
            optUploadedStatsTamed.UseVisualStyleBackColor = true;
            // 
            // optUploadedStatsBase
            // 
            optUploadedStatsBase.AutoSize = true;
            optUploadedStatsBase.Checked = true;
            optUploadedStatsBase.Location = new System.Drawing.Point(49, 9);
            optUploadedStatsBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optUploadedStatsBase.Name = "optUploadedStatsBase";
            optUploadedStatsBase.Size = new System.Drawing.Size(49, 19);
            optUploadedStatsBase.TabIndex = 1;
            optUploadedStatsBase.TabStop = true;
            optUploadedStatsBase.Text = "Base";
            optUploadedStatsBase.UseVisualStyleBackColor = true;
            optUploadedStatsBase.CheckedChanged += optUploadedStatsBase_CheckedChanged;
            // 
            // lblUploadedCountItems
            // 
            lblUploadedCountItems.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblUploadedCountItems.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            lblUploadedCountItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblUploadedCountItems.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblUploadedCountItems.Location = new System.Drawing.Point(961, 486);
            lblUploadedCountItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUploadedCountItems.Name = "lblUploadedCountItems";
            lblUploadedCountItems.Size = new System.Drawing.Size(126, 24);
            lblUploadedCountItems.TabIndex = 16;
            lblUploadedCountItems.Text = "Count: 0";
            lblUploadedCountItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUploadedCountTames
            // 
            lblUploadedCountTames.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblUploadedCountTames.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            lblUploadedCountTames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblUploadedCountTames.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblUploadedCountTames.Location = new System.Drawing.Point(961, 313);
            lblUploadedCountTames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUploadedCountTames.Name = "lblUploadedCountTames";
            lblUploadedCountTames.Size = new System.Drawing.Size(126, 24);
            lblUploadedCountTames.TabIndex = 15;
            lblUploadedCountTames.Text = "Count: 0";
            lblUploadedCountTames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUploadedCountCharacters
            // 
            lblUploadedCountCharacters.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblUploadedCountCharacters.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            lblUploadedCountCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblUploadedCountCharacters.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblUploadedCountCharacters.Location = new System.Drawing.Point(961, 145);
            lblUploadedCountCharacters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUploadedCountCharacters.Name = "lblUploadedCountCharacters";
            lblUploadedCountCharacters.Size = new System.Drawing.Size(126, 24);
            lblUploadedCountCharacters.TabIndex = 14;
            lblUploadedCountCharacters.Text = "Count: 0";
            lblUploadedCountCharacters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUploadedItems
            // 
            lblUploadedItems.AutoSize = true;
            lblUploadedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblUploadedItems.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblUploadedItems.Location = new System.Drawing.Point(12, 359);
            lblUploadedItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUploadedItems.Name = "lblUploadedItems";
            lblUploadedItems.Size = new System.Drawing.Size(78, 13);
            lblUploadedItems.TabIndex = 13;
            lblUploadedItems.Text = "Stored Items";
            // 
            // lvwUploadedItems
            // 
            lvwUploadedItems.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwUploadedItems.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwUploadedItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvwUploadedItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader8, columnHeader9, columnHeader18, columnHeader19, columnHeader22 });
            lvwUploadedItems.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwUploadedItems.FullRowSelect = true;
            lvwUploadedItems.Location = new System.Drawing.Point(15, 377);
            lvwUploadedItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwUploadedItems.MultiSelect = false;
            lvwUploadedItems.Name = "lvwUploadedItems";
            lvwUploadedItems.Size = new System.Drawing.Size(1073, 104);
            lvwUploadedItems.TabIndex = 12;
            lvwUploadedItems.UseCompatibleStateImageBehavior = false;
            lvwUploadedItems.View = System.Windows.Forms.View.Details;
            lvwUploadedItems.ColumnClick += lvwUploadedItems_ColumnClick;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Item";
            columnHeader8.Width = 175;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Quality";
            columnHeader9.Width = 80;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Rating";
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "BP";
            columnHeader19.Width = 40;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Qty";
            // 
            // lblUploadedTames
            // 
            lblUploadedTames.AutoSize = true;
            lblUploadedTames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblUploadedTames.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblUploadedTames.Location = new System.Drawing.Point(12, 153);
            lblUploadedTames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUploadedTames.Name = "lblUploadedTames";
            lblUploadedTames.Size = new System.Drawing.Size(102, 13);
            lblUploadedTames.TabIndex = 11;
            lblUploadedTames.Text = "Uploaded Tames";
            // 
            // lblUploadedCharacters
            // 
            lblUploadedCharacters.AutoSize = true;
            lblUploadedCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblUploadedCharacters.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblUploadedCharacters.Location = new System.Drawing.Point(12, 18);
            lblUploadedCharacters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUploadedCharacters.Name = "lblUploadedCharacters";
            lblUploadedCharacters.Size = new System.Drawing.Size(126, 13);
            lblUploadedCharacters.TabIndex = 10;
            lblUploadedCharacters.Text = "Uploaded Characters";
            // 
            // lvwUploadedCharacters
            // 
            lvwUploadedCharacters.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwUploadedCharacters.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwUploadedCharacters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvwUploadedCharacters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader37, columnHeader39, columnHeader40, columnHeader43, columnHeader44, columnHeader45, columnHeader46, columnHeader47, columnHeader48, columnHeader49, columnHeader50, columnHeader51, columnHeader52 });
            lvwUploadedCharacters.ContextMenuStrip = mnuContext;
            lvwUploadedCharacters.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwUploadedCharacters.FullRowSelect = true;
            lvwUploadedCharacters.Location = new System.Drawing.Point(15, 42);
            lvwUploadedCharacters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwUploadedCharacters.Name = "lvwUploadedCharacters";
            lvwUploadedCharacters.Size = new System.Drawing.Size(1072, 100);
            lvwUploadedCharacters.TabIndex = 9;
            lvwUploadedCharacters.UseCompatibleStateImageBehavior = false;
            lvwUploadedCharacters.View = System.Windows.Forms.View.Details;
            lvwUploadedCharacters.ColumnClick += lvwUploadedCharacters_ColumnClick;
            // 
            // columnHeader37
            // 
            columnHeader37.Text = "Name";
            columnHeader37.Width = 90;
            // 
            // columnHeader39
            // 
            columnHeader39.Text = "Sex";
            columnHeader39.Width = 55;
            // 
            // columnHeader40
            // 
            columnHeader40.Text = "Lvl";
            columnHeader40.Width = 35;
            // 
            // columnHeader43
            // 
            columnHeader43.Text = "HP";
            columnHeader43.Width = 45;
            // 
            // columnHeader44
            // 
            columnHeader44.Text = "Stam";
            columnHeader44.Width = 45;
            // 
            // columnHeader45
            // 
            columnHeader45.Text = "Melee";
            columnHeader45.Width = 48;
            // 
            // columnHeader46
            // 
            columnHeader46.Text = "Weight";
            columnHeader46.Width = 55;
            // 
            // columnHeader47
            // 
            columnHeader47.Text = "Speed";
            columnHeader47.Width = 50;
            // 
            // columnHeader48
            // 
            columnHeader48.Text = "Food";
            columnHeader48.Width = 47;
            // 
            // columnHeader49
            // 
            columnHeader49.Text = "Water";
            // 
            // columnHeader50
            // 
            columnHeader50.Text = "Oxygen";
            columnHeader50.Width = 53;
            // 
            // columnHeader51
            // 
            columnHeader51.Text = "Crafting";
            // 
            // columnHeader52
            // 
            columnHeader52.Text = "Fortitude";
            // 
            // lvwUploadedTames
            // 
            lvwUploadedTames.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwUploadedTames.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwUploadedTames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvwUploadedTames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader5, columnHeader6, columnHeader7, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16, columnHeader17, columnHeader20, columnHeader21, columnHeader23, columnHeader24, columnHeader25, columnHeader26, columnHeader27, columnHeader28, columnHeader29, columnHeader30, columnHeader33, columnHeader34 });
            lvwUploadedTames.ContextMenuStrip = mnuContext;
            lvwUploadedTames.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwUploadedTames.FullRowSelect = true;
            lvwUploadedTames.Location = new System.Drawing.Point(15, 175);
            lvwUploadedTames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwUploadedTames.MultiSelect = false;
            lvwUploadedTames.Name = "lvwUploadedTames";
            lvwUploadedTames.Size = new System.Drawing.Size(1072, 133);
            lvwUploadedTames.TabIndex = 8;
            lvwUploadedTames.UseCompatibleStateImageBehavior = false;
            lvwUploadedTames.View = System.Windows.Forms.View.Details;
            lvwUploadedTames.ColumnClick += lvwUploadedTames_ColumnClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Creature";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Sex";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Base";
            columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Lvl";
            columnHeader7.Width = 41;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "HP";
            columnHeader10.Width = 45;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Stam";
            columnHeader11.Width = 45;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Melee";
            columnHeader12.Width = 48;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Weight";
            columnHeader13.Width = 55;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Speed";
            columnHeader14.Width = 50;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Food";
            columnHeader15.Width = 47;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Oxygen";
            columnHeader16.Width = 53;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Craft";
            columnHeader17.Width = 50;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Imprinter";
            columnHeader20.Width = 105;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Imprint";
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "C0";
            columnHeader23.Width = 35;
            // 
            // columnHeader24
            // 
            columnHeader24.Text = "C1";
            columnHeader24.Width = 35;
            // 
            // columnHeader25
            // 
            columnHeader25.Text = "C2";
            columnHeader25.Width = 35;
            // 
            // columnHeader26
            // 
            columnHeader26.Text = "C3";
            columnHeader26.Width = 35;
            // 
            // columnHeader27
            // 
            columnHeader27.Text = "C4";
            columnHeader27.Width = 35;
            // 
            // columnHeader28
            // 
            columnHeader28.Text = "C5";
            columnHeader28.Width = 35;
            // 
            // columnHeader29
            // 
            columnHeader29.Text = "Mut (F)";
            // 
            // columnHeader30
            // 
            columnHeader30.Text = "Mut (M)";
            // 
            // columnHeader33
            // 
            columnHeader33.Text = "Rig1";
            columnHeader33.Width = 100;
            // 
            // columnHeader34
            // 
            columnHeader34.Text = "Rig2";
            columnHeader34.Width = 100;
            // 
            // tpgPaintings
            // 
            tpgPaintings.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgPaintings.Controls.Add(splitContainer2);
            tpgPaintings.Location = new System.Drawing.Point(4, 29);
            tpgPaintings.Name = "tpgPaintings";
            tpgPaintings.Padding = new System.Windows.Forms.Padding(3);
            tpgPaintings.Size = new System.Drawing.Size(1104, 525);
            tpgPaintings.TabIndex = 9;
            tpgPaintings.Text = "Paintings";
            // 
            // splitContainer2
            // 
            splitContainer2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            splitContainer2.Location = new System.Drawing.Point(6, 6);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            splitContainer2.Panel1.Controls.Add(lblPaintingsCount);
            splitContainer2.Panel1.Controls.Add(panel1);
            splitContainer2.Panel1.Controls.Add(btnDeletePaintings);
            splitContainer2.Panel1.Controls.Add(lblPaintingTribe);
            splitContainer2.Panel1.Controls.Add(lvwPlayerPaintings);
            splitContainer2.Panel1.Controls.Add(cboPaintingTribe);
            splitContainer2.Panel1.Controls.Add(lblStructurePainting);
            splitContainer2.Panel1.Controls.Add(cboConsoleCommandPainting);
            splitContainer2.Panel1.Controls.Add(cboPaintingStructure);
            splitContainer2.Panel1.Controls.Add(lblCopyCommandPaintings);
            splitContainer2.Panel1.Controls.Add(btnConsoleCommandPainting);
            splitContainer2.Panel1.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            splitContainer2.Panel1.Paint += splitContainer2_Panel1_Paint;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(125, 125, 125);
            splitContainer2.Panel2.Controls.Add(picPainting);
            splitContainer2.Size = new System.Drawing.Size(1092, 518);
            splitContainer2.SplitterDistance = 709;
            splitContainer2.TabIndex = 37;
            // 
            // lblPaintingsCount
            // 
            lblPaintingsCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblPaintingsCount.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            lblPaintingsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPaintingsCount.Location = new System.Drawing.Point(568, 468);
            lblPaintingsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPaintingsCount.Name = "lblPaintingsCount";
            lblPaintingsCount.Size = new System.Drawing.Size(126, 35);
            lblPaintingsCount.TabIndex = 37;
            lblPaintingsCount.Text = "Count: 0";
            lblPaintingsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new System.Drawing.Point(5, 745);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1369, 33);
            panel1.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox1.Location = new System.Drawing.Point(12, 3);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(1817, 23);
            textBox1.TabIndex = 6;
            // 
            // lblPaintingTribe
            // 
            lblPaintingTribe.AutoSize = true;
            lblPaintingTribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPaintingTribe.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblPaintingTribe.Location = new System.Drawing.Point(18, 22);
            lblPaintingTribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPaintingTribe.Name = "lblPaintingTribe";
            lblPaintingTribe.Size = new System.Drawing.Size(40, 13);
            lblPaintingTribe.TabIndex = 23;
            lblPaintingTribe.Text = "Tribe:";
            lblPaintingTribe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwPlayerPaintings
            // 
            lvwPlayerPaintings.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lvwPlayerPaintings.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwPlayerPaintings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvwPlayerPaintings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvwPlayerPaintings_Tribe, lvwPlayerPaintings_Structure, lvwPlayerPaintings_Lat, lvwPlayerPaintings_Lon, lvwPlayerPaintings_PaintingId });
            lvwPlayerPaintings.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwPlayerPaintings.FullRowSelect = true;
            lvwPlayerPaintings.Location = new System.Drawing.Point(10, 51);
            lvwPlayerPaintings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwPlayerPaintings.MultiSelect = false;
            lvwPlayerPaintings.Name = "lvwPlayerPaintings";
            lvwPlayerPaintings.Size = new System.Drawing.Size(686, 405);
            lvwPlayerPaintings.TabIndex = 31;
            lvwPlayerPaintings.UseCompatibleStateImageBehavior = false;
            lvwPlayerPaintings.View = System.Windows.Forms.View.Details;
            lvwPlayerPaintings.SelectedIndexChanged += lvwPlayerPaintings_SelectedIndexChanged;
            // 
            // lvwPlayerPaintings_Tribe
            // 
            lvwPlayerPaintings_Tribe.Text = "Tribe";
            lvwPlayerPaintings_Tribe.Width = 200;
            // 
            // lvwPlayerPaintings_Structure
            // 
            lvwPlayerPaintings_Structure.Text = "Structure";
            lvwPlayerPaintings_Structure.Width = 200;
            // 
            // lvwPlayerPaintings_Lat
            // 
            lvwPlayerPaintings_Lat.Text = "Lat";
            // 
            // lvwPlayerPaintings_Lon
            // 
            lvwPlayerPaintings_Lon.Text = "Lon";
            // 
            // lvwPlayerPaintings_PaintingId
            // 
            lvwPlayerPaintings_PaintingId.Text = "Painting Id";
            lvwPlayerPaintings_PaintingId.Width = 150;
            // 
            // cboPaintingTribe
            // 
            cboPaintingTribe.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboPaintingTribe.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboPaintingTribe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboPaintingTribe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboPaintingTribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboPaintingTribe.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboPaintingTribe.FormattingEnabled = true;
            cboPaintingTribe.Location = new System.Drawing.Point(68, 17);
            cboPaintingTribe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboPaintingTribe.Name = "cboPaintingTribe";
            cboPaintingTribe.Size = new System.Drawing.Size(237, 24);
            cboPaintingTribe.TabIndex = 24;
            cboPaintingTribe.SelectedIndexChanged += cboPaintingTribe_SelectedIndexChanged;
            // 
            // lblStructurePainting
            // 
            lblStructurePainting.AutoSize = true;
            lblStructurePainting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStructurePainting.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblStructurePainting.Location = new System.Drawing.Point(373, 22);
            lblStructurePainting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStructurePainting.Name = "lblStructurePainting";
            lblStructurePainting.Size = new System.Drawing.Size(63, 13);
            lblStructurePainting.TabIndex = 29;
            lblStructurePainting.Text = "Structure:";
            lblStructurePainting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboConsoleCommandPainting
            // 
            cboConsoleCommandPainting.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboConsoleCommandPainting.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboConsoleCommandPainting.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboConsoleCommandPainting.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboConsoleCommandPainting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboConsoleCommandPainting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboConsoleCommandPainting.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboConsoleCommandPainting.FormattingEnabled = true;
            cboConsoleCommandPainting.Items.AddRange(new object[] { "DestroyTribeId <TribeID> ", "DestroyTribeIdDinos <TribeID>", "DestroyTribeIdPlayers <TribeID>", "DestroyTribeIdStructures <TribeID>", "SaveWorld", "SetPlayerPos  <x> <y> <z>" });
            cboConsoleCommandPainting.Location = new System.Drawing.Point(92, 471);
            cboConsoleCommandPainting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboConsoleCommandPainting.Name = "cboConsoleCommandPainting";
            cboConsoleCommandPainting.Size = new System.Drawing.Size(305, 24);
            cboConsoleCommandPainting.Sorted = true;
            cboConsoleCommandPainting.TabIndex = 27;
            cboConsoleCommandPainting.SelectedIndexChanged += cboConsoleCommandPainting_SelectedIndexChanged;
            // 
            // cboPaintingStructure
            // 
            cboPaintingStructure.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboPaintingStructure.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboPaintingStructure.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboPaintingStructure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboPaintingStructure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboPaintingStructure.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboPaintingStructure.FormattingEnabled = true;
            cboPaintingStructure.Location = new System.Drawing.Point(454, 17);
            cboPaintingStructure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboPaintingStructure.Name = "cboPaintingStructure";
            cboPaintingStructure.Size = new System.Drawing.Size(237, 24);
            cboPaintingStructure.TabIndex = 30;
            cboPaintingStructure.SelectedIndexChanged += cboPaintingStructure_SelectedIndexChanged;
            // 
            // lblCopyCommandPaintings
            // 
            lblCopyCommandPaintings.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCopyCommandPaintings.AutoSize = true;
            lblCopyCommandPaintings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCopyCommandPaintings.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblCopyCommandPaintings.Location = new System.Drawing.Point(12, 475);
            lblCopyCommandPaintings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCopyCommandPaintings.Name = "lblCopyCommandPaintings";
            lblCopyCommandPaintings.Size = new System.Drawing.Size(65, 13);
            lblCopyCommandPaintings.TabIndex = 26;
            lblCopyCommandPaintings.Text = "Command:";
            // 
            // picPainting
            // 
            picPainting.Anchor = System.Windows.Forms.AnchorStyles.None;
            picPainting.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            picPainting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picPainting.Location = new System.Drawing.Point(14, 84);
            picPainting.Name = "picPainting";
            picPainting.Size = new System.Drawing.Size(350, 350);
            picPainting.TabIndex = 1;
            picPainting.TabStop = false;
            picPainting.Click += picPainting_Click;
            // 
            // tpgItemList
            // 
            tpgItemList.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgItemList.Controls.Add(cboItemListFilter);
            tpgItemList.Controls.Add(lblItemListFilter);
            tpgItemList.Controls.Add(txtItemListItemId);
            tpgItemList.Controls.Add(label2);
            tpgItemList.Controls.Add(label1);
            tpgItemList.Controls.Add(cboItemListPlayers);
            tpgItemList.Controls.Add(pnlFilterSearch);
            tpgItemList.Controls.Add(cboItemListItem);
            tpgItemList.Controls.Add(lblItemListTribe);
            tpgItemList.Controls.Add(cboItemListTribe);
            tpgItemList.Controls.Add(btnCopyItemListCommand);
            tpgItemList.Controls.Add(lblItemListCommand);
            tpgItemList.Controls.Add(cboConsoleCommandSearch);
            tpgItemList.Controls.Add(lblItemListCount);
            tpgItemList.Controls.Add(lblItemListItem);
            tpgItemList.Controls.Add(lvwItemList);
            tpgItemList.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            tpgItemList.Location = new System.Drawing.Point(4, 29);
            tpgItemList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgItemList.Name = "tpgItemList";
            tpgItemList.Size = new System.Drawing.Size(1104, 525);
            tpgItemList.TabIndex = 6;
            tpgItemList.Text = "Item Search";
            // 
            // cboItemListFilter
            // 
            cboItemListFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboItemListFilter.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboItemListFilter.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboItemListFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboItemListFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboItemListFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboItemListFilter.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboItemListFilter.FormattingEnabled = true;
            cboItemListFilter.Location = new System.Drawing.Point(790, 17);
            cboItemListFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboItemListFilter.Name = "cboItemListFilter";
            cboItemListFilter.Size = new System.Drawing.Size(296, 24);
            cboItemListFilter.TabIndex = 38;
            cboItemListFilter.SelectedIndexChanged += cboItemListFilter_SelectedIndexChanged;
            // 
            // lblItemListFilter
            // 
            lblItemListFilter.AutoSize = true;
            lblItemListFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblItemListFilter.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblItemListFilter.Location = new System.Drawing.Point(745, 21);
            lblItemListFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblItemListFilter.Name = "lblItemListFilter";
            lblItemListFilter.Size = new System.Drawing.Size(39, 13);
            lblItemListFilter.TabIndex = 37;
            lblItemListFilter.Text = "Filter:";
            lblItemListFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemListItemId
            // 
            txtItemListItemId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtItemListItemId.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtItemListItemId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtItemListItemId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtItemListItemId.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtItemListItemId.Location = new System.Drawing.Point(464, 51);
            txtItemListItemId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtItemListItemId.MaxLength = 100;
            txtItemListItemId.Multiline = true;
            txtItemListItemId.Name = "txtItemListItemId";
            txtItemListItemId.Size = new System.Drawing.Size(251, 23);
            txtItemListItemId.TabIndex = 27;
            txtItemListItemId.TextChanged += txtItemListItemId_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            label2.Location = new System.Drawing.Point(401, 55);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 13);
            label2.TabIndex = 26;
            label2.Text = "Item Id:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            label1.Location = new System.Drawing.Point(20, 51);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 13);
            label1.TabIndex = 24;
            label1.Text = "Player:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboItemListPlayers
            // 
            cboItemListPlayers.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboItemListPlayers.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboItemListPlayers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboItemListPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboItemListPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboItemListPlayers.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboItemListPlayers.FormattingEnabled = true;
            cboItemListPlayers.Location = new System.Drawing.Point(80, 48);
            cboItemListPlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboItemListPlayers.Name = "cboItemListPlayers";
            cboItemListPlayers.Size = new System.Drawing.Size(254, 24);
            cboItemListPlayers.TabIndex = 25;
            cboItemListPlayers.SelectedIndexChanged += cboItemListPlayers_SelectedIndexChanged;
            // 
            // pnlFilterSearch
            // 
            pnlFilterSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlFilterSearch.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            pnlFilterSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlFilterSearch.Controls.Add(btnFindSearched);
            pnlFilterSearch.Controls.Add(txtFilterSearch);
            pnlFilterSearch.Location = new System.Drawing.Point(13, 428);
            pnlFilterSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlFilterSearch.Name = "pnlFilterSearch";
            pnlFilterSearch.Size = new System.Drawing.Size(1073, 33);
            pnlFilterSearch.TabIndex = 22;
            // 
            // txtFilterSearch
            // 
            txtFilterSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFilterSearch.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtFilterSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFilterSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFilterSearch.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtFilterSearch.Location = new System.Drawing.Point(12, 5);
            txtFilterSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilterSearch.Name = "txtFilterSearch";
            txtFilterSearch.Size = new System.Drawing.Size(1013, 20);
            txtFilterSearch.TabIndex = 6;
            txtFilterSearch.KeyDown += txtFilterSearch_KeyDown;
            // 
            // cboItemListItem
            // 
            cboItemListItem.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboItemListItem.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboItemListItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboItemListItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboItemListItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboItemListItem.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboItemListItem.FormattingEnabled = true;
            cboItemListItem.Location = new System.Drawing.Point(464, 17);
            cboItemListItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboItemListItem.Name = "cboItemListItem";
            cboItemListItem.Size = new System.Drawing.Size(251, 24);
            cboItemListItem.TabIndex = 3;
            cboItemListItem.SelectedIndexChanged += cboItemListItem_SelectedIndexChanged;
            // 
            // lblItemListTribe
            // 
            lblItemListTribe.AutoSize = true;
            lblItemListTribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblItemListTribe.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblItemListTribe.Location = new System.Drawing.Point(20, 21);
            lblItemListTribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblItemListTribe.Name = "lblItemListTribe";
            lblItemListTribe.Size = new System.Drawing.Size(40, 13);
            lblItemListTribe.TabIndex = 0;
            lblItemListTribe.Text = "Tribe:";
            lblItemListTribe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboItemListTribe
            // 
            cboItemListTribe.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboItemListTribe.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboItemListTribe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboItemListTribe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboItemListTribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboItemListTribe.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboItemListTribe.FormattingEnabled = true;
            cboItemListTribe.Location = new System.Drawing.Point(80, 18);
            cboItemListTribe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboItemListTribe.Name = "cboItemListTribe";
            cboItemListTribe.Size = new System.Drawing.Size(254, 24);
            cboItemListTribe.TabIndex = 1;
            cboItemListTribe.SelectedIndexChanged += cboItemListTribe_SelectedIndexChanged;
            // 
            // btnCopyItemListCommand
            // 
            btnCopyItemListCommand.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCopyItemListCommand.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnCopyItemListCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCopyItemListCommand.Enabled = false;
            btnCopyItemListCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCopyItemListCommand.Image = (System.Drawing.Image)resources.GetObject("btnCopyItemListCommand.Image");
            btnCopyItemListCommand.Location = new System.Drawing.Point(408, 466);
            btnCopyItemListCommand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCopyItemListCommand.Name = "btnCopyItemListCommand";
            btnCopyItemListCommand.Size = new System.Drawing.Size(47, 46);
            btnCopyItemListCommand.TabIndex = 7;
            btnCopyItemListCommand.UseVisualStyleBackColor = false;
            btnCopyItemListCommand.Click += btnItemListCommand_Click;
            // 
            // lblItemListCommand
            // 
            lblItemListCommand.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblItemListCommand.AutoSize = true;
            lblItemListCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblItemListCommand.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblItemListCommand.Location = new System.Drawing.Point(16, 481);
            lblItemListCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblItemListCommand.Name = "lblItemListCommand";
            lblItemListCommand.Size = new System.Drawing.Size(65, 13);
            lblItemListCommand.TabIndex = 5;
            lblItemListCommand.Text = "Command:";
            // 
            // cboConsoleCommandSearch
            // 
            cboConsoleCommandSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboConsoleCommandSearch.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboConsoleCommandSearch.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboConsoleCommandSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboConsoleCommandSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboConsoleCommandSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboConsoleCommandSearch.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboConsoleCommandSearch.FormattingEnabled = true;
            cboConsoleCommandSearch.Items.AddRange(new object[] { "SaveWorld", "SetPlayerPos  <x> <y> <z>" });
            cboConsoleCommandSearch.Location = new System.Drawing.Point(96, 478);
            cboConsoleCommandSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboConsoleCommandSearch.Name = "cboConsoleCommandSearch";
            cboConsoleCommandSearch.Size = new System.Drawing.Size(305, 24);
            cboConsoleCommandSearch.Sorted = true;
            cboConsoleCommandSearch.TabIndex = 6;
            cboConsoleCommandSearch.SelectedIndexChanged += cboItemListCommand_SelectedIndexChanged;
            // 
            // lblItemListCount
            // 
            lblItemListCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblItemListCount.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            lblItemListCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblItemListCount.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblItemListCount.Location = new System.Drawing.Point(943, 472);
            lblItemListCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblItemListCount.Name = "lblItemListCount";
            lblItemListCount.Size = new System.Drawing.Size(144, 35);
            lblItemListCount.TabIndex = 8;
            lblItemListCount.Text = "Count: 0";
            lblItemListCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemListItem
            // 
            lblItemListItem.AutoSize = true;
            lblItemListItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblItemListItem.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblItemListItem.Location = new System.Drawing.Point(416, 22);
            lblItemListItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblItemListItem.Name = "lblItemListItem";
            lblItemListItem.Size = new System.Drawing.Size(35, 13);
            lblItemListItem.TabIndex = 2;
            lblItemListItem.Text = "Item:";
            lblItemListItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwItemList
            // 
            lvwItemList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwItemList.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvwItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvwItemList_Tribe, lvwItemList_Container, lvwItemList_Player, lvwItemList_Item, lvwItemList_Quality, lvwItemList_Rating, lvwItemList_BP, lvwItemList_Quantity, lvwItemList_Lat, lvwItemList_Lon, lvwItemList_CCC, lvwItemList_UploadTime, lvwItemList_ItemId });
            lvwItemList.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwItemList.FullRowSelect = true;
            lvwItemList.Location = new System.Drawing.Point(13, 95);
            lvwItemList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwItemList.Name = "lvwItemList";
            lvwItemList.Size = new System.Drawing.Size(1073, 334);
            lvwItemList.TabIndex = 4;
            lvwItemList.UseCompatibleStateImageBehavior = false;
            lvwItemList.View = System.Windows.Forms.View.Details;
            lvwItemList.ColumnClick += lvwItemList_ColumnClick;
            lvwItemList.SelectedIndexChanged += lvwItemList_SelectedIndexChanged;
            // 
            // lvwItemList_Tribe
            // 
            lvwItemList_Tribe.Text = "Tribe";
            lvwItemList_Tribe.Width = 150;
            // 
            // lvwItemList_Container
            // 
            lvwItemList_Container.Text = "Container";
            lvwItemList_Container.Width = 160;
            // 
            // lvwItemList_Player
            // 
            lvwItemList_Player.Text = "Player";
            lvwItemList_Player.Width = 150;
            // 
            // lvwItemList_Item
            // 
            lvwItemList_Item.Text = "Item";
            lvwItemList_Item.Width = 175;
            // 
            // lvwItemList_Quality
            // 
            lvwItemList_Quality.Text = "Quality";
            lvwItemList_Quality.Width = 80;
            // 
            // lvwItemList_Rating
            // 
            lvwItemList_Rating.Text = "Rating";
            lvwItemList_Rating.Width = 50;
            // 
            // lvwItemList_BP
            // 
            lvwItemList_BP.Text = "BP";
            lvwItemList_BP.Width = 40;
            // 
            // lvwItemList_Quantity
            // 
            lvwItemList_Quantity.Text = "Qty";
            lvwItemList_Quantity.Width = 50;
            // 
            // lvwItemList_Lat
            // 
            lvwItemList_Lat.Text = "Lat";
            // 
            // lvwItemList_Lon
            // 
            lvwItemList_Lon.Text = "Lon";
            // 
            // lvwItemList_CCC
            // 
            lvwItemList_CCC.Text = "CCC";
            lvwItemList_CCC.Width = 0;
            // 
            // lvwItemList_UploadTime
            // 
            lvwItemList_UploadTime.Text = "Uploaded";
            lvwItemList_UploadTime.Width = 120;
            // 
            // lvwItemList_ItemId
            // 
            lvwItemList_ItemId.Text = "Id";
            lvwItemList_ItemId.Width = 150;
            // 
            // tpgDroppedItems
            // 
            tpgDroppedItems.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgDroppedItems.Controls.Add(cboDroppedItemRealm);
            tpgDroppedItems.Controls.Add(lblDroppedItemRealm);
            tpgDroppedItems.Controls.Add(pnlFilterDropped);
            tpgDroppedItems.Controls.Add(chkDroppedBlueprints);
            tpgDroppedItems.Controls.Add(btnDropInventory);
            tpgDroppedItems.Controls.Add(cboDroppedItem);
            tpgDroppedItems.Controls.Add(lblDroppedPlayer);
            tpgDroppedItems.Controls.Add(cboDroppedPlayer);
            tpgDroppedItems.Controls.Add(btnCopyCommandDropped);
            tpgDroppedItems.Controls.Add(lblCopyCommandDropped);
            tpgDroppedItems.Controls.Add(cboConsoleCommandDropped);
            tpgDroppedItems.Controls.Add(lblCountDropped);
            tpgDroppedItems.Controls.Add(lblDroppedItem);
            tpgDroppedItems.Controls.Add(lvwDroppedItems);
            tpgDroppedItems.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            tpgDroppedItems.Location = new System.Drawing.Point(4, 29);
            tpgDroppedItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgDroppedItems.Name = "tpgDroppedItems";
            tpgDroppedItems.Size = new System.Drawing.Size(1104, 525);
            tpgDroppedItems.TabIndex = 4;
            tpgDroppedItems.Text = "Dropped Items";
            // 
            // cboDroppedItemRealm
            // 
            cboDroppedItemRealm.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboDroppedItemRealm.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboDroppedItemRealm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboDroppedItemRealm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboDroppedItemRealm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboDroppedItemRealm.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboDroppedItemRealm.FormattingEnabled = true;
            cboDroppedItemRealm.Location = new System.Drawing.Point(736, 17);
            cboDroppedItemRealm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboDroppedItemRealm.Name = "cboDroppedItemRealm";
            cboDroppedItemRealm.Size = new System.Drawing.Size(222, 24);
            cboDroppedItemRealm.TabIndex = 24;
            cboDroppedItemRealm.SelectedIndexChanged += cboDroppedItemRealm_SelectedIndexChanged;
            // 
            // lblDroppedItemRealm
            // 
            lblDroppedItemRealm.AutoSize = true;
            lblDroppedItemRealm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDroppedItemRealm.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblDroppedItemRealm.Location = new System.Drawing.Point(662, 22);
            lblDroppedItemRealm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDroppedItemRealm.Name = "lblDroppedItemRealm";
            lblDroppedItemRealm.Size = new System.Drawing.Size(46, 13);
            lblDroppedItemRealm.TabIndex = 23;
            lblDroppedItemRealm.Text = "Realm:";
            // 
            // pnlFilterDropped
            // 
            pnlFilterDropped.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlFilterDropped.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            pnlFilterDropped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlFilterDropped.Controls.Add(btnFindDropped);
            pnlFilterDropped.Controls.Add(txtFilterDropped);
            pnlFilterDropped.Location = new System.Drawing.Point(13, 428);
            pnlFilterDropped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlFilterDropped.Name = "pnlFilterDropped";
            pnlFilterDropped.Size = new System.Drawing.Size(1075, 33);
            pnlFilterDropped.TabIndex = 22;
            // 
            // txtFilterDropped
            // 
            txtFilterDropped.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFilterDropped.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtFilterDropped.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFilterDropped.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFilterDropped.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtFilterDropped.Location = new System.Drawing.Point(12, 5);
            txtFilterDropped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilterDropped.Name = "txtFilterDropped";
            txtFilterDropped.Size = new System.Drawing.Size(1015, 20);
            txtFilterDropped.TabIndex = 6;
            txtFilterDropped.KeyDown += txtFilterDropped_KeyDown;
            // 
            // cboDroppedItem
            // 
            cboDroppedItem.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboDroppedItem.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboDroppedItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboDroppedItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboDroppedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboDroppedItem.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboDroppedItem.FormattingEnabled = true;
            cboDroppedItem.Location = new System.Drawing.Point(390, 17);
            cboDroppedItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboDroppedItem.Name = "cboDroppedItem";
            cboDroppedItem.Size = new System.Drawing.Size(248, 24);
            cboDroppedItem.TabIndex = 3;
            cboDroppedItem.SelectedIndexChanged += cboDroppedItem_SelectedIndexChanged;
            // 
            // lblDroppedPlayer
            // 
            lblDroppedPlayer.AutoSize = true;
            lblDroppedPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDroppedPlayer.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblDroppedPlayer.Location = new System.Drawing.Point(20, 21);
            lblDroppedPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDroppedPlayer.Name = "lblDroppedPlayer";
            lblDroppedPlayer.Size = new System.Drawing.Size(46, 13);
            lblDroppedPlayer.TabIndex = 0;
            lblDroppedPlayer.Text = "Player:";
            // 
            // cboDroppedPlayer
            // 
            cboDroppedPlayer.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboDroppedPlayer.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboDroppedPlayer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboDroppedPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboDroppedPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboDroppedPlayer.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboDroppedPlayer.FormattingEnabled = true;
            cboDroppedPlayer.Location = new System.Drawing.Point(80, 18);
            cboDroppedPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboDroppedPlayer.Name = "cboDroppedPlayer";
            cboDroppedPlayer.Size = new System.Drawing.Size(254, 24);
            cboDroppedPlayer.TabIndex = 1;
            cboDroppedPlayer.SelectedIndexChanged += cboDroppedPlayer_SelectedIndexChanged;
            // 
            // lblCopyCommandDropped
            // 
            lblCopyCommandDropped.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCopyCommandDropped.AutoSize = true;
            lblCopyCommandDropped.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCopyCommandDropped.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblCopyCommandDropped.Location = new System.Drawing.Point(16, 481);
            lblCopyCommandDropped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCopyCommandDropped.Name = "lblCopyCommandDropped";
            lblCopyCommandDropped.Size = new System.Drawing.Size(65, 13);
            lblCopyCommandDropped.TabIndex = 5;
            lblCopyCommandDropped.Text = "Command:";
            // 
            // cboConsoleCommandDropped
            // 
            cboConsoleCommandDropped.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboConsoleCommandDropped.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboConsoleCommandDropped.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboConsoleCommandDropped.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboConsoleCommandDropped.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboConsoleCommandDropped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboConsoleCommandDropped.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboConsoleCommandDropped.FormattingEnabled = true;
            cboConsoleCommandDropped.Items.AddRange(new object[] { "SaveWorld", "SetPlayerPos  <x> <y> <z>" });
            cboConsoleCommandDropped.Location = new System.Drawing.Point(96, 478);
            cboConsoleCommandDropped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboConsoleCommandDropped.Name = "cboConsoleCommandDropped";
            cboConsoleCommandDropped.Size = new System.Drawing.Size(305, 24);
            cboConsoleCommandDropped.Sorted = true;
            cboConsoleCommandDropped.TabIndex = 6;
            cboConsoleCommandDropped.SelectedIndexChanged += cboCopyCommandDropped_SelectedIndexChanged;
            // 
            // lblCountDropped
            // 
            lblCountDropped.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblCountDropped.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            lblCountDropped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCountDropped.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblCountDropped.Location = new System.Drawing.Point(945, 472);
            lblCountDropped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCountDropped.Name = "lblCountDropped";
            lblCountDropped.Size = new System.Drawing.Size(144, 35);
            lblCountDropped.TabIndex = 9;
            lblCountDropped.Text = "Count: 0";
            lblCountDropped.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDroppedItem
            // 
            lblDroppedItem.AutoSize = true;
            lblDroppedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDroppedItem.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblDroppedItem.Location = new System.Drawing.Point(342, 22);
            lblDroppedItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDroppedItem.Name = "lblDroppedItem";
            lblDroppedItem.Size = new System.Drawing.Size(35, 13);
            lblDroppedItem.TabIndex = 2;
            lblDroppedItem.Text = "Item:";
            // 
            // lvwDroppedItems
            // 
            lvwDroppedItems.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwDroppedItems.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwDroppedItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvwDroppedItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvwDroppedItems_Item, lvwDroppedItems_Bp, lvwDroppedItems_DroppedBy, lvwDroppedItems_Lat, lvwDroppedItems_Lon, lvwDroppedItems_Tribe, lvwDroppedItems_Player, lvwDroppedItems_CCC });
            lvwDroppedItems.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwDroppedItems.FullRowSelect = true;
            lvwDroppedItems.Location = new System.Drawing.Point(13, 60);
            lvwDroppedItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwDroppedItems.Name = "lvwDroppedItems";
            lvwDroppedItems.Size = new System.Drawing.Size(1075, 369);
            lvwDroppedItems.TabIndex = 4;
            lvwDroppedItems.UseCompatibleStateImageBehavior = false;
            lvwDroppedItems.View = System.Windows.Forms.View.Details;
            lvwDroppedItems.ColumnClick += lvwDroppedItems_ColumnClick;
            lvwDroppedItems.SelectedIndexChanged += lvwDroppedItems_SelectedIndexChanged;
            // 
            // lvwDroppedItems_Item
            // 
            lvwDroppedItems_Item.Text = "Item";
            lvwDroppedItems_Item.Width = 180;
            // 
            // lvwDroppedItems_Bp
            // 
            lvwDroppedItems_Bp.Text = "BP";
            // 
            // lvwDroppedItems_DroppedBy
            // 
            lvwDroppedItems_DroppedBy.Text = "Dropped By";
            lvwDroppedItems_DroppedBy.Width = 169;
            // 
            // lvwDroppedItems_Lat
            // 
            lvwDroppedItems_Lat.Text = "Lat";
            // 
            // lvwDroppedItems_Lon
            // 
            lvwDroppedItems_Lon.Text = "Lon";
            // 
            // lvwDroppedItems_Tribe
            // 
            lvwDroppedItems_Tribe.Text = "Tribe";
            lvwDroppedItems_Tribe.Width = 105;
            // 
            // lvwDroppedItems_Player
            // 
            lvwDroppedItems_Player.Text = "Player";
            lvwDroppedItems_Player.Width = 109;
            // 
            // lvwDroppedItems_CCC
            // 
            lvwDroppedItems_CCC.Text = "CCC";
            lvwDroppedItems_CCC.Width = 0;
            // 
            // tpgPlayers
            // 
            tpgPlayers.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgPlayers.Controls.Add(btnRconCommandPlayers);
            tpgPlayers.Controls.Add(cboPlayerRealm);
            tpgPlayers.Controls.Add(lblPlayerRealm);
            tpgPlayers.Controls.Add(pnlFilterPlayers);
            tpgPlayers.Controls.Add(btnDeletePlayer);
            tpgPlayers.Controls.Add(lblPlayerTotal);
            tpgPlayers.Controls.Add(btnCopyCommandPlayer);
            tpgPlayers.Controls.Add(lblCommandPlayer);
            tpgPlayers.Controls.Add(cboConsoleCommandsPlayer);
            tpgPlayers.Controls.Add(btnPlayerTribeLog);
            tpgPlayers.Controls.Add(btnPlayerInventory);
            tpgPlayers.Controls.Add(lblPlayersPlayer);
            tpgPlayers.Controls.Add(lblPlayersTribe);
            tpgPlayers.Controls.Add(cboTribes);
            tpgPlayers.Controls.Add(cboPlayers);
            tpgPlayers.Controls.Add(lvwPlayers);
            tpgPlayers.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            tpgPlayers.Location = new System.Drawing.Point(4, 29);
            tpgPlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgPlayers.Name = "tpgPlayers";
            tpgPlayers.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgPlayers.Size = new System.Drawing.Size(1104, 525);
            tpgPlayers.TabIndex = 1;
            tpgPlayers.Text = "Players";
            // 
            // cboPlayerRealm
            // 
            cboPlayerRealm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cboPlayerRealm.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboPlayerRealm.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboPlayerRealm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboPlayerRealm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboPlayerRealm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboPlayerRealm.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboPlayerRealm.FormattingEnabled = true;
            cboPlayerRealm.Location = new System.Drawing.Point(865, 17);
            cboPlayerRealm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboPlayerRealm.Name = "cboPlayerRealm";
            cboPlayerRealm.Size = new System.Drawing.Size(222, 24);
            cboPlayerRealm.TabIndex = 25;
            cboPlayerRealm.SelectedIndexChanged += cboPlayerRealm_SelectedIndexChanged;
            // 
            // lblPlayerRealm
            // 
            lblPlayerRealm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblPlayerRealm.AutoSize = true;
            lblPlayerRealm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPlayerRealm.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblPlayerRealm.Location = new System.Drawing.Point(802, 22);
            lblPlayerRealm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPlayerRealm.Name = "lblPlayerRealm";
            lblPlayerRealm.Size = new System.Drawing.Size(46, 13);
            lblPlayerRealm.TabIndex = 24;
            lblPlayerRealm.Text = "Realm:";
            lblPlayerRealm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlFilterPlayers
            // 
            pnlFilterPlayers.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlFilterPlayers.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            pnlFilterPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlFilterPlayers.Controls.Add(btnFilterPlayer);
            pnlFilterPlayers.Controls.Add(txtFilterPlayer);
            pnlFilterPlayers.Location = new System.Drawing.Point(14, 420);
            pnlFilterPlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlFilterPlayers.Name = "pnlFilterPlayers";
            pnlFilterPlayers.Size = new System.Drawing.Size(1072, 33);
            pnlFilterPlayers.TabIndex = 23;
            // 
            // txtFilterPlayer
            // 
            txtFilterPlayer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFilterPlayer.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtFilterPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFilterPlayer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFilterPlayer.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtFilterPlayer.Location = new System.Drawing.Point(12, 5);
            txtFilterPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilterPlayer.Name = "txtFilterPlayer";
            txtFilterPlayer.Size = new System.Drawing.Size(1012, 20);
            txtFilterPlayer.TabIndex = 6;
            txtFilterPlayer.KeyDown += txtFilterPlayer_KeyDown;
            // 
            // lblPlayerTotal
            // 
            lblPlayerTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblPlayerTotal.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            lblPlayerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPlayerTotal.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblPlayerTotal.Location = new System.Drawing.Point(943, 468);
            lblPlayerTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPlayerTotal.Name = "lblPlayerTotal";
            lblPlayerTotal.Size = new System.Drawing.Size(144, 35);
            lblPlayerTotal.TabIndex = 11;
            lblPlayerTotal.Text = "Total: 0";
            lblPlayerTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCommandPlayer
            // 
            lblCommandPlayer.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCommandPlayer.AutoSize = true;
            lblCommandPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCommandPlayer.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblCommandPlayer.Location = new System.Drawing.Point(16, 475);
            lblCommandPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCommandPlayer.Name = "lblCommandPlayer";
            lblCommandPlayer.Size = new System.Drawing.Size(65, 13);
            lblCommandPlayer.TabIndex = 5;
            lblCommandPlayer.Text = "Command:";
            // 
            // cboConsoleCommandsPlayer
            // 
            cboConsoleCommandsPlayer.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboConsoleCommandsPlayer.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboConsoleCommandsPlayer.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboConsoleCommandsPlayer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboConsoleCommandsPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboConsoleCommandsPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboConsoleCommandsPlayer.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboConsoleCommandsPlayer.FormattingEnabled = true;
            cboConsoleCommandsPlayer.Items.AddRange(new object[] { "AddChibiExpToPlayer <PlayerID> <HowMuch>", "AllowPlayerToJoinNoCheck <SteamID>", "BanPlayer <SteamID>", "ClearPlayerInventory <PlayerID> true true true", "DefeatAllBosses <PlayerID> ", "DEL <FileCsvList>", "DestroyTribeId <TribeID> ", "DestroyTribeIdDinos <TribeID>", "DestroyTribeIdPlayers <TribeID>", "DestroyTribeIdStructures <TribeID>", "DisallowPlayerToJoinNoCheck <SteamID> ", "GetPlayerIDForSteamID <SteamID> ", "GetSteamIDForPlayerID <PlayerID> ", "GiveCreativeModeToPlayer <PlayerID> ", "GiveExpToPlayer <PlayerID> <XP> false true", "GiveItemToPlayer <PlayerID> <BlueprintPath> <Quantity> <Quality> <ForceBlueprint>", "GiveTekengramsTo <PlayerID> tek", "KickPlayer <SteamID> ", "KillPlayer <PlayerID>", "MaxAscend <PlayerID>  ", "RenamePlayer \"<CharacterName>\" <NewName>", "RenameTribe \"<TribeName>\" <NewName>", "RM <FileCsvList>", "SaveWorld", "ServerChatToPlayer <PlayerName>", "SetImprintedPlayer \"<CharacterName>\" <PlayerID>", "SetPlayerPos  <x> <y> <z>", "TakeTribe <TribeID>", "TeleportPlayerIDToMe <PlayerID>", "TeleportPlayerNameToMe <CharacterName>", "TeleportToPlayer <PlayerID>", "TeleportToPlayerName <CharacterName>", "TribeDinoAudit  <TribeID>", "TribeStructureAudit <TribeID>", "UnbanPlayer <SteamID>" });
            cboConsoleCommandsPlayer.Location = new System.Drawing.Point(96, 472);
            cboConsoleCommandsPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboConsoleCommandsPlayer.Name = "cboConsoleCommandsPlayer";
            cboConsoleCommandsPlayer.Size = new System.Drawing.Size(305, 24);
            cboConsoleCommandsPlayer.Sorted = true;
            cboConsoleCommandsPlayer.TabIndex = 6;
            cboConsoleCommandsPlayer.SelectedIndexChanged += cboConsoleCommandsPlayer_SelectedIndexChanged;
            // 
            // lblPlayersPlayer
            // 
            lblPlayersPlayer.AutoSize = true;
            lblPlayersPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPlayersPlayer.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblPlayersPlayer.Location = new System.Drawing.Point(405, 22);
            lblPlayersPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPlayersPlayer.Name = "lblPlayersPlayer";
            lblPlayersPlayer.Size = new System.Drawing.Size(46, 13);
            lblPlayersPlayer.TabIndex = 2;
            lblPlayersPlayer.Text = "Player:";
            lblPlayersPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayersTribe
            // 
            lblPlayersTribe.AutoSize = true;
            lblPlayersTribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPlayersTribe.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblPlayersTribe.Location = new System.Drawing.Point(16, 22);
            lblPlayersTribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPlayersTribe.Name = "lblPlayersTribe";
            lblPlayersTribe.Size = new System.Drawing.Size(40, 13);
            lblPlayersTribe.TabIndex = 0;
            lblPlayersTribe.Text = "Tribe:";
            lblPlayersTribe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboTribes
            // 
            cboTribes.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboTribes.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboTribes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboTribes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTribes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboTribes.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboTribes.FormattingEnabled = true;
            cboTribes.Location = new System.Drawing.Point(70, 17);
            cboTribes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboTribes.Name = "cboTribes";
            cboTribes.Size = new System.Drawing.Size(313, 24);
            cboTribes.TabIndex = 1;
            cboTribes.SelectedIndexChanged += cboTribes_SelectedIndexChanged;
            // 
            // cboPlayers
            // 
            cboPlayers.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboPlayers.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboPlayers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboPlayers.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboPlayers.FormattingEnabled = true;
            cboPlayers.Location = new System.Drawing.Point(465, 17);
            cboPlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboPlayers.Name = "cboPlayers";
            cboPlayers.Size = new System.Drawing.Size(232, 24);
            cboPlayers.TabIndex = 3;
            cboPlayers.SelectedIndexChanged += cboPlayers_SelectedIndexChanged;
            // 
            // lvwPlayers
            // 
            lvwPlayers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwPlayers.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvwPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvwPlayers_PlayerId, lvwPlayers_Name, lvwPlayers_Tribe, lvwPlayers_Sex, lvwPlayers_Level, lvwPlayers_Lat, lvwPlayers_Lon, lvwPlayers_Hp, lvwPlayers_Stam, lvwPlayers_Melee, lvwPlayers_Weight, lvwPlayers_Speed, lvwPlayers_Food, lvwPlayers_Water, lvwPlayers_Oxygen, lvwPlayers_Crafting, lvwPlayers_Fortitude, lvwPlayers_LastOnline, lvwPlayers_SteamName, lvwPlayers_SteamId, lvwPlayers_CCC });
            lvwPlayers.ContextMenuStrip = mnuContext;
            lvwPlayers.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwPlayers.FullRowSelect = true;
            lvwPlayers.Location = new System.Drawing.Point(14, 60);
            lvwPlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwPlayers.Name = "lvwPlayers";
            lvwPlayers.Size = new System.Drawing.Size(1072, 361);
            lvwPlayers.TabIndex = 4;
            lvwPlayers.UseCompatibleStateImageBehavior = false;
            lvwPlayers.View = System.Windows.Forms.View.Details;
            lvwPlayers.ColumnClick += lvwPlayers_ColumnClick;
            lvwPlayers.SelectedIndexChanged += lvwPlayers_SelectedIndexChanged;
            lvwPlayers.Click += lvwPlayers_Click;
            lvwPlayers.MouseClick += lvwPlayers_MouseClick;
            // 
            // lvwPlayers_PlayerId
            // 
            lvwPlayers_PlayerId.Text = "Id";
            lvwPlayers_PlayerId.Width = 100;
            // 
            // lvwPlayers_Name
            // 
            lvwPlayers_Name.Text = "Name";
            lvwPlayers_Name.Width = 90;
            // 
            // lvwPlayers_Tribe
            // 
            lvwPlayers_Tribe.Text = "Tribe";
            lvwPlayers_Tribe.Width = 90;
            // 
            // lvwPlayers_Sex
            // 
            lvwPlayers_Sex.Text = "Sex";
            lvwPlayers_Sex.Width = 55;
            // 
            // lvwPlayers_Level
            // 
            lvwPlayers_Level.Text = "Lvl";
            lvwPlayers_Level.Width = 35;
            // 
            // lvwPlayers_Lat
            // 
            lvwPlayers_Lat.Text = "Lat";
            lvwPlayers_Lat.Width = 45;
            // 
            // lvwPlayers_Lon
            // 
            lvwPlayers_Lon.Text = "Lon";
            lvwPlayers_Lon.Width = 45;
            // 
            // lvwPlayers_Hp
            // 
            lvwPlayers_Hp.Text = "HP";
            lvwPlayers_Hp.Width = 45;
            // 
            // lvwPlayers_Stam
            // 
            lvwPlayers_Stam.Text = "Stam";
            lvwPlayers_Stam.Width = 45;
            // 
            // lvwPlayers_Melee
            // 
            lvwPlayers_Melee.Text = "Melee";
            lvwPlayers_Melee.Width = 48;
            // 
            // lvwPlayers_Weight
            // 
            lvwPlayers_Weight.Text = "Weight";
            lvwPlayers_Weight.Width = 55;
            // 
            // lvwPlayers_Speed
            // 
            lvwPlayers_Speed.Text = "Speed";
            lvwPlayers_Speed.Width = 50;
            // 
            // lvwPlayers_Food
            // 
            lvwPlayers_Food.Text = "Food";
            lvwPlayers_Food.Width = 47;
            // 
            // lvwPlayers_Water
            // 
            lvwPlayers_Water.Text = "Water";
            // 
            // lvwPlayers_Oxygen
            // 
            lvwPlayers_Oxygen.Text = "Oxygen";
            lvwPlayers_Oxygen.Width = 53;
            // 
            // lvwPlayers_Crafting
            // 
            lvwPlayers_Crafting.Text = "Crafting";
            // 
            // lvwPlayers_Fortitude
            // 
            lvwPlayers_Fortitude.Text = "Fortitude";
            // 
            // lvwPlayers_LastOnline
            // 
            lvwPlayers_LastOnline.Text = "Last Online";
            lvwPlayers_LastOnline.Width = 140;
            // 
            // lvwPlayers_SteamName
            // 
            lvwPlayers_SteamName.Text = "Steam Name";
            lvwPlayers_SteamName.Width = 150;
            // 
            // lvwPlayers_SteamId
            // 
            lvwPlayers_SteamId.Text = "Steam Id";
            lvwPlayers_SteamId.Width = 0;
            // 
            // lvwPlayers_CCC
            // 
            lvwPlayers_CCC.Text = "CCC";
            lvwPlayers_CCC.Width = 0;
            // 
            // tpgTribes
            // 
            tpgTribes.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgTribes.Controls.Add(btnRconCommandTribes);
            tpgTribes.Controls.Add(splitContainer1);
            tpgTribes.Controls.Add(chkTribeStructures);
            tpgTribes.Controls.Add(chkTribeTames);
            tpgTribes.Controls.Add(chkTribePlayers);
            tpgTribes.Controls.Add(btnTribeCopyCommand);
            tpgTribes.Controls.Add(lblTribeCopyCommand);
            tpgTribes.Controls.Add(cboConsoleCommandsTribe);
            tpgTribes.Controls.Add(btnTribeLog);
            tpgTribes.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            tpgTribes.Location = new System.Drawing.Point(4, 29);
            tpgTribes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgTribes.Name = "tpgTribes";
            tpgTribes.Size = new System.Drawing.Size(1104, 525);
            tpgTribes.TabIndex = 5;
            tpgTribes.Text = "Tribes";
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            splitContainer1.Location = new System.Drawing.Point(11, 20);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lvwTribes);
            splitContainer1.Panel1.Controls.Add(pnlFilterTribes);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            splitContainer1.Panel2.Controls.Add(chartTribes);
            splitContainer1.Panel2.Controls.Add(btnSaveChartImage);
            splitContainer1.Panel2.Controls.Add(lblChartTop);
            splitContainer1.Panel2.Controls.Add(udChartTop);
            splitContainer1.Panel2.Controls.Add(lblChart);
            splitContainer1.Panel2.Controls.Add(cboChartType);
            splitContainer1.Size = new System.Drawing.Size(1075, 438);
            splitContainer1.SplitterDistance = 716;
            splitContainer1.TabIndex = 24;
            // 
            // lvwTribes
            // 
            lvwTribes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwTribes.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwTribes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvwTribes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvwTribes_Id, lvwTribes_Name, lvwTribes_Players, lvwTribes_Tames, lvwTribes_Structures, lvwTribes_Active });
            lvwTribes.ContextMenuStrip = mnuContext;
            lvwTribes.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwTribes.FullRowSelect = true;
            lvwTribes.Location = new System.Drawing.Point(5, 3);
            lvwTribes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwTribes.Name = "lvwTribes";
            lvwTribes.Size = new System.Drawing.Size(707, 395);
            lvwTribes.TabIndex = 0;
            lvwTribes.UseCompatibleStateImageBehavior = false;
            lvwTribes.View = System.Windows.Forms.View.Details;
            lvwTribes.ColumnClick += lvwTribes_ColumnClick;
            lvwTribes.SelectedIndexChanged += lvwTribes_SelectedIndexChanged;
            lvwTribes.MouseClick += lvwTribes_MouseClick;
            // 
            // lvwTribes_Id
            // 
            lvwTribes_Id.Text = "Id";
            lvwTribes_Id.Width = 150;
            // 
            // lvwTribes_Name
            // 
            lvwTribes_Name.Text = "Name";
            lvwTribes_Name.Width = 200;
            // 
            // lvwTribes_Players
            // 
            lvwTribes_Players.Text = "Players";
            lvwTribes_Players.Width = 75;
            // 
            // lvwTribes_Tames
            // 
            lvwTribes_Tames.Text = "Tames";
            lvwTribes_Tames.Width = 75;
            // 
            // lvwTribes_Structures
            // 
            lvwTribes_Structures.Text = "Structures";
            lvwTribes_Structures.Width = 75;
            // 
            // lvwTribes_Active
            // 
            lvwTribes_Active.Text = "Last Active";
            lvwTribes_Active.Width = 127;
            // 
            // pnlFilterTribes
            // 
            pnlFilterTribes.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlFilterTribes.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            pnlFilterTribes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlFilterTribes.Controls.Add(btnFilterTribe);
            pnlFilterTribes.Controls.Add(txtFilterTribe);
            pnlFilterTribes.Location = new System.Drawing.Point(5, 400);
            pnlFilterTribes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlFilterTribes.Name = "pnlFilterTribes";
            pnlFilterTribes.Size = new System.Drawing.Size(710, 33);
            pnlFilterTribes.TabIndex = 23;
            // 
            // txtFilterTribe
            // 
            txtFilterTribe.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFilterTribe.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtFilterTribe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFilterTribe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFilterTribe.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtFilterTribe.Location = new System.Drawing.Point(12, 5);
            txtFilterTribe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilterTribe.Name = "txtFilterTribe";
            txtFilterTribe.Size = new System.Drawing.Size(650, 20);
            txtFilterTribe.TabIndex = 6;
            txtFilterTribe.KeyDown += txtFilterTribe_KeyDown;
            // 
            // chartTribes
            // 
            chartTribes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            chartTribes.CausesValidation = false;
            chartTribes.Location = new System.Drawing.Point(12, 81);
            chartTribes.Name = "chartTribes";
            chartTribes.Size = new System.Drawing.Size(330, 346);
            chartTribes.SubTitle = "";
            chartTribes.TabIndex = 53;
            chartTribes.Title = "Title";
            // 
            // lblChartTop
            // 
            lblChartTop.AutoSize = true;
            lblChartTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblChartTop.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblChartTop.Location = new System.Drawing.Point(20, 46);
            lblChartTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblChartTop.Name = "lblChartTop";
            lblChartTop.Size = new System.Drawing.Size(33, 13);
            lblChartTop.TabIndex = 7;
            lblChartTop.Text = "Top:";
            lblChartTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // udChartTop
            // 
            udChartTop.BackColor = System.Drawing.Color.FromArgb(125, 125, 125);
            udChartTop.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udChartTop.Location = new System.Drawing.Point(72, 43);
            udChartTop.Name = "udChartTop";
            udChartTop.Size = new System.Drawing.Size(63, 23);
            udChartTop.TabIndex = 6;
            udChartTop.Value = new decimal(new int[] { 10, 0, 0, 0 });
            udChartTop.ValueChanged += udChartTop_ValueChanged;
            // 
            // lblChart
            // 
            lblChart.AutoSize = true;
            lblChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblChart.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblChart.Location = new System.Drawing.Point(12, 17);
            lblChart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblChart.Name = "lblChart";
            lblChart.Size = new System.Drawing.Size(41, 13);
            lblChart.TabIndex = 4;
            lblChart.Text = "Chart:";
            lblChart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboChartType
            // 
            cboChartType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboChartType.BackColor = System.Drawing.Color.FromArgb(125, 125, 125);
            cboChartType.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboChartType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboChartType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboChartType.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboChartType.FormattingEnabled = true;
            cboChartType.Items.AddRange(new object[] { "Tribes by No. Players", "Tribes by No. Tames", "Tribes by No. Structures" });
            cboChartType.Location = new System.Drawing.Point(72, 13);
            cboChartType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboChartType.Name = "cboChartType";
            cboChartType.Size = new System.Drawing.Size(270, 24);
            cboChartType.TabIndex = 5;
            cboChartType.SelectedIndexChanged += cboChartType_SelectedIndexChanged;
            // 
            // lblTribeCopyCommand
            // 
            lblTribeCopyCommand.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblTribeCopyCommand.AutoSize = true;
            lblTribeCopyCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTribeCopyCommand.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblTribeCopyCommand.Location = new System.Drawing.Point(16, 478);
            lblTribeCopyCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTribeCopyCommand.Name = "lblTribeCopyCommand";
            lblTribeCopyCommand.Size = new System.Drawing.Size(65, 13);
            lblTribeCopyCommand.TabIndex = 1;
            lblTribeCopyCommand.Text = "Command:";
            // 
            // cboConsoleCommandsTribe
            // 
            cboConsoleCommandsTribe.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboConsoleCommandsTribe.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboConsoleCommandsTribe.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboConsoleCommandsTribe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboConsoleCommandsTribe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboConsoleCommandsTribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboConsoleCommandsTribe.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboConsoleCommandsTribe.FormattingEnabled = true;
            cboConsoleCommandsTribe.Items.AddRange(new object[] { "DEL <FileCsvList>", "DestroyTribeId <TribeID> ", "DestroyTribeIdDinos <TribeID>", "DestroyTribeIdPlayers <TribeID>", "DestroyTribeIdStructures <TribeID>", "RenameTribe \"<TribeName>\" ", "RM <FileCsvList>", "SaveWorld", "TakeTribe <TribeID>", "TribeDinoAudit  <TribeID>", "TribeStructureAudit <TribeID>" });
            cboConsoleCommandsTribe.Location = new System.Drawing.Point(96, 474);
            cboConsoleCommandsTribe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboConsoleCommandsTribe.Name = "cboConsoleCommandsTribe";
            cboConsoleCommandsTribe.Size = new System.Drawing.Size(305, 24);
            cboConsoleCommandsTribe.Sorted = true;
            cboConsoleCommandsTribe.TabIndex = 2;
            cboConsoleCommandsTribe.SelectedIndexChanged += cboTribeCopyCommand_SelectedIndexChanged;
            // 
            // tpgStructures
            // 
            tpgStructures.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgStructures.Controls.Add(lblStructureRad);
            tpgStructures.Controls.Add(udRadiusStructures);
            tpgStructures.Controls.Add(lblStructureLon);
            tpgStructures.Controls.Add(udLonStructures);
            tpgStructures.Controls.Add(lblStructureLat);
            tpgStructures.Controls.Add(udLatStructures);
            tpgStructures.Controls.Add(btnRconCommandStructures);
            tpgStructures.Controls.Add(cboStructureRealm);
            tpgStructures.Controls.Add(lblStructureRealm);
            tpgStructures.Controls.Add(pnlFilterStructures);
            tpgStructures.Controls.Add(btnStructureInventory);
            tpgStructures.Controls.Add(lblStructureTotal);
            tpgStructures.Controls.Add(btnCopyCommandStructure);
            tpgStructures.Controls.Add(lblCommandStructure);
            tpgStructures.Controls.Add(cboConsoleCommandsStructure);
            tpgStructures.Controls.Add(btnStructureExclusionFilter);
            tpgStructures.Controls.Add(lblStructureStructure);
            tpgStructures.Controls.Add(cboStructureStructure);
            tpgStructures.Controls.Add(lblStructurePlayer);
            tpgStructures.Controls.Add(lblStructureTribe);
            tpgStructures.Controls.Add(cboStructureTribe);
            tpgStructures.Controls.Add(cboStructurePlayer);
            tpgStructures.Controls.Add(lvwStructureLocations);
            tpgStructures.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            tpgStructures.Location = new System.Drawing.Point(4, 29);
            tpgStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgStructures.Name = "tpgStructures";
            tpgStructures.Size = new System.Drawing.Size(1104, 525);
            tpgStructures.TabIndex = 2;
            tpgStructures.Text = "Player Structures";
            // 
            // lblStructureRad
            // 
            lblStructureRad.AutoSize = true;
            lblStructureRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStructureRad.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblStructureRad.Location = new System.Drawing.Point(281, 14);
            lblStructureRad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStructureRad.Name = "lblStructureRad";
            lblStructureRad.Size = new System.Drawing.Size(50, 13);
            lblStructureRad.TabIndex = 37;
            lblStructureRad.Text = "Radius:";
            lblStructureRad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // udRadiusStructures
            // 
            udRadiusStructures.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udRadiusStructures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udRadiusStructures.DecimalPlaces = 2;
            udRadiusStructures.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udRadiusStructures.Location = new System.Drawing.Point(337, 14);
            udRadiusStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udRadiusStructures.Name = "udRadiusStructures";
            udRadiusStructures.Size = new System.Drawing.Size(62, 19);
            udRadiusStructures.TabIndex = 38;
            udRadiusStructures.Value = new decimal(new int[] { 10000, 0, 0, 131072 });
            udRadiusStructures.ValueChanged += FilterStructureLocations;
            // 
            // lblStructureLon
            // 
            lblStructureLon.AutoSize = true;
            lblStructureLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStructureLon.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblStructureLon.Location = new System.Drawing.Point(162, 14);
            lblStructureLon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStructureLon.Name = "lblStructureLon";
            lblStructureLon.Size = new System.Drawing.Size(32, 13);
            lblStructureLon.TabIndex = 35;
            lblStructureLon.Text = "Lon:";
            lblStructureLon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // udLonStructures
            // 
            udLonStructures.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udLonStructures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udLonStructures.DecimalPlaces = 2;
            udLonStructures.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udLonStructures.Location = new System.Drawing.Point(197, 14);
            udLonStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udLonStructures.Name = "udLonStructures";
            udLonStructures.Size = new System.Drawing.Size(62, 19);
            udLonStructures.TabIndex = 36;
            udLonStructures.Value = new decimal(new int[] { 5000, 0, 0, 131072 });
            udLonStructures.ValueChanged += FilterStructureLocations;
            // 
            // lblStructureLat
            // 
            lblStructureLat.AutoSize = true;
            lblStructureLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStructureLat.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblStructureLat.Location = new System.Drawing.Point(47, 14);
            lblStructureLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStructureLat.Name = "lblStructureLat";
            lblStructureLat.Size = new System.Drawing.Size(29, 13);
            lblStructureLat.TabIndex = 33;
            lblStructureLat.Text = "Lat:";
            lblStructureLat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // udLatStructures
            // 
            udLatStructures.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udLatStructures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udLatStructures.DecimalPlaces = 2;
            udLatStructures.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udLatStructures.Location = new System.Drawing.Point(84, 14);
            udLatStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udLatStructures.Name = "udLatStructures";
            udLatStructures.Size = new System.Drawing.Size(62, 19);
            udLatStructures.TabIndex = 34;
            udLatStructures.Value = new decimal(new int[] { 5000, 0, 0, 131072 });
            udLatStructures.ValueChanged += FilterStructureLocations;
            // 
            // cboStructureRealm
            // 
            cboStructureRealm.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboStructureRealm.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboStructureRealm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboStructureRealm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboStructureRealm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboStructureRealm.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboStructureRealm.FormattingEnabled = true;
            cboStructureRealm.Location = new System.Drawing.Point(495, 10);
            cboStructureRealm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboStructureRealm.Name = "cboStructureRealm";
            cboStructureRealm.Size = new System.Drawing.Size(224, 24);
            cboStructureRealm.TabIndex = 24;
            cboStructureRealm.SelectedIndexChanged += cboStructureRealm_SelectedIndexChanged;
            // 
            // lblStructureRealm
            // 
            lblStructureRealm.AutoSize = true;
            lblStructureRealm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStructureRealm.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblStructureRealm.Location = new System.Drawing.Point(439, 15);
            lblStructureRealm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStructureRealm.Name = "lblStructureRealm";
            lblStructureRealm.Size = new System.Drawing.Size(46, 13);
            lblStructureRealm.TabIndex = 23;
            lblStructureRealm.Text = "Realm:";
            lblStructureRealm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlFilterStructures
            // 
            pnlFilterStructures.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlFilterStructures.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            pnlFilterStructures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlFilterStructures.Controls.Add(btnFindStructures);
            pnlFilterStructures.Controls.Add(txtFilterStructures);
            pnlFilterStructures.Location = new System.Drawing.Point(13, 430);
            pnlFilterStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlFilterStructures.Name = "pnlFilterStructures";
            pnlFilterStructures.Size = new System.Drawing.Size(1073, 33);
            pnlFilterStructures.TabIndex = 22;
            // 
            // txtFilterStructures
            // 
            txtFilterStructures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFilterStructures.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtFilterStructures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFilterStructures.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFilterStructures.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtFilterStructures.Location = new System.Drawing.Point(12, 5);
            txtFilterStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilterStructures.Name = "txtFilterStructures";
            txtFilterStructures.Size = new System.Drawing.Size(1013, 20);
            txtFilterStructures.TabIndex = 6;
            txtFilterStructures.KeyDown += txtFilterStructures_KeyDown;
            // 
            // lblStructureTotal
            // 
            lblStructureTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblStructureTotal.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            lblStructureTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblStructureTotal.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblStructureTotal.Location = new System.Drawing.Point(943, 474);
            lblStructureTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStructureTotal.Name = "lblStructureTotal";
            lblStructureTotal.Size = new System.Drawing.Size(144, 35);
            lblStructureTotal.TabIndex = 12;
            lblStructureTotal.Text = "Total: 0";
            lblStructureTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCommandStructure
            // 
            lblCommandStructure.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCommandStructure.AutoSize = true;
            lblCommandStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCommandStructure.Location = new System.Drawing.Point(10, 479);
            lblCommandStructure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCommandStructure.Name = "lblCommandStructure";
            lblCommandStructure.Size = new System.Drawing.Size(65, 13);
            lblCommandStructure.TabIndex = 8;
            lblCommandStructure.Text = "Command:";
            // 
            // cboConsoleCommandsStructure
            // 
            cboConsoleCommandsStructure.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboConsoleCommandsStructure.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboConsoleCommandsStructure.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboConsoleCommandsStructure.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboConsoleCommandsStructure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboConsoleCommandsStructure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboConsoleCommandsStructure.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboConsoleCommandsStructure.FormattingEnabled = true;
            cboConsoleCommandsStructure.Items.AddRange(new object[] { "DestroyTribeId <TribeID> ", "DestroyTribeIdDinos <TribeID>", "DestroyTribeIdPlayers <TribeID>", "DestroyTribeIdStructures <TribeID>", "SaveWorld", "SetPlayerPos  <x> <y> <z>", "TakeTribe <TribeID>" });
            cboConsoleCommandsStructure.Location = new System.Drawing.Point(90, 475);
            cboConsoleCommandsStructure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboConsoleCommandsStructure.Name = "cboConsoleCommandsStructure";
            cboConsoleCommandsStructure.Size = new System.Drawing.Size(305, 24);
            cboConsoleCommandsStructure.Sorted = true;
            cboConsoleCommandsStructure.TabIndex = 9;
            cboConsoleCommandsStructure.SelectedIndexChanged += cboConsoleCommandsStructure_SelectedIndexChanged;
            // 
            // lblStructureStructure
            // 
            lblStructureStructure.AutoSize = true;
            lblStructureStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStructureStructure.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblStructureStructure.Location = new System.Drawing.Point(13, 78);
            lblStructureStructure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStructureStructure.Name = "lblStructureStructure";
            lblStructureStructure.Size = new System.Drawing.Size(63, 13);
            lblStructureStructure.TabIndex = 4;
            lblStructureStructure.Text = "Structure:";
            lblStructureStructure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboStructureStructure
            // 
            cboStructureStructure.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboStructureStructure.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboStructureStructure.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboStructureStructure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboStructureStructure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboStructureStructure.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboStructureStructure.FormattingEnabled = true;
            cboStructureStructure.Location = new System.Drawing.Point(85, 74);
            cboStructureStructure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboStructureStructure.Name = "cboStructureStructure";
            cboStructureStructure.Size = new System.Drawing.Size(634, 24);
            cboStructureStructure.TabIndex = 5;
            cboStructureStructure.SelectedIndexChanged += cboStructureStructure_SelectedIndexChanged;
            // 
            // lblStructurePlayer
            // 
            lblStructurePlayer.AutoSize = true;
            lblStructurePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStructurePlayer.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblStructurePlayer.Location = new System.Drawing.Point(439, 45);
            lblStructurePlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStructurePlayer.Name = "lblStructurePlayer";
            lblStructurePlayer.Size = new System.Drawing.Size(46, 13);
            lblStructurePlayer.TabIndex = 2;
            lblStructurePlayer.Text = "Player:";
            lblStructurePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStructureTribe
            // 
            lblStructureTribe.AutoSize = true;
            lblStructureTribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStructureTribe.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblStructureTribe.Location = new System.Drawing.Point(36, 45);
            lblStructureTribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStructureTribe.Name = "lblStructureTribe";
            lblStructureTribe.Size = new System.Drawing.Size(40, 13);
            lblStructureTribe.TabIndex = 0;
            lblStructureTribe.Text = "Tribe:";
            lblStructureTribe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboStructureTribe
            // 
            cboStructureTribe.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboStructureTribe.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboStructureTribe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboStructureTribe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboStructureTribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboStructureTribe.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboStructureTribe.FormattingEnabled = true;
            cboStructureTribe.Location = new System.Drawing.Point(84, 42);
            cboStructureTribe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboStructureTribe.Name = "cboStructureTribe";
            cboStructureTribe.Size = new System.Drawing.Size(315, 24);
            cboStructureTribe.TabIndex = 1;
            cboStructureTribe.SelectedIndexChanged += cboStructureTribe_SelectedIndexChanged;
            // 
            // cboStructurePlayer
            // 
            cboStructurePlayer.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboStructurePlayer.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboStructurePlayer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboStructurePlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboStructurePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboStructurePlayer.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboStructurePlayer.FormattingEnabled = true;
            cboStructurePlayer.Location = new System.Drawing.Point(495, 42);
            cboStructurePlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboStructurePlayer.Name = "cboStructurePlayer";
            cboStructurePlayer.Size = new System.Drawing.Size(224, 24);
            cboStructurePlayer.TabIndex = 3;
            cboStructurePlayer.SelectedIndexChanged += cboStructurePlayer_SelectedIndexChanged;
            // 
            // lvwStructureLocations
            // 
            lvwStructureLocations.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwStructureLocations.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwStructureLocations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvwStructureLocations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvwStructureLocations_Tribe, lvwStructureLocations_Structure, lvwStructureLocations_Lat, lvwStructureLocations_Lon, lvwStructureLocations_Name, lvwStructureLocations_Locked, lvwStructureLocations_Powered, lvwStructureLocations_Created, lvwStructureLocations_LastTime, lvwStructureLocations_DecayReset, lvwStructureLocations_CCC });
            lvwStructureLocations.ContextMenuStrip = mnuContext;
            lvwStructureLocations.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwStructureLocations.FullRowSelect = true;
            lvwStructureLocations.Location = new System.Drawing.Point(13, 110);
            lvwStructureLocations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwStructureLocations.Name = "lvwStructureLocations";
            lvwStructureLocations.Size = new System.Drawing.Size(1073, 321);
            lvwStructureLocations.TabIndex = 7;
            lvwStructureLocations.UseCompatibleStateImageBehavior = false;
            lvwStructureLocations.View = System.Windows.Forms.View.Details;
            lvwStructureLocations.ColumnClick += lvwStructureLocations_ColumnClick;
            lvwStructureLocations.SelectedIndexChanged += lvwStructureLocations_SelectedIndexChanged;
            lvwStructureLocations.MouseClick += lvwStructureLocations_MouseClick;
            // 
            // lvwStructureLocations_Tribe
            // 
            lvwStructureLocations_Tribe.Text = "Tribe";
            lvwStructureLocations_Tribe.Width = 200;
            // 
            // lvwStructureLocations_Structure
            // 
            lvwStructureLocations_Structure.Text = "Structure";
            lvwStructureLocations_Structure.Width = 200;
            // 
            // lvwStructureLocations_Lat
            // 
            lvwStructureLocations_Lat.Text = "Lat";
            lvwStructureLocations_Lat.Width = 79;
            // 
            // lvwStructureLocations_Lon
            // 
            lvwStructureLocations_Lon.Text = "Lon";
            lvwStructureLocations_Lon.Width = 71;
            // 
            // lvwStructureLocations_Name
            // 
            lvwStructureLocations_Name.Text = "Name";
            lvwStructureLocations_Name.Width = 180;
            // 
            // lvwStructureLocations_Locked
            // 
            lvwStructureLocations_Locked.Text = "Locked";
            // 
            // lvwStructureLocations_Powered
            // 
            lvwStructureLocations_Powered.Text = "Power On";
            lvwStructureLocations_Powered.Width = 70;
            // 
            // lvwStructureLocations_Created
            // 
            lvwStructureLocations_Created.Text = "Created";
            lvwStructureLocations_Created.Width = 120;
            // 
            // lvwStructureLocations_LastTime
            // 
            lvwStructureLocations_LastTime.Text = "Ally In Range";
            lvwStructureLocations_LastTime.Width = 120;
            // 
            // lvwStructureLocations_DecayReset
            // 
            lvwStructureLocations_DecayReset.Text = "Decay Reset";
            lvwStructureLocations_DecayReset.Width = 80;
            // 
            // lvwStructureLocations_CCC
            // 
            lvwStructureLocations_CCC.Text = "CCC";
            lvwStructureLocations_CCC.Width = 0;
            // 
            // tpgTamed
            // 
            tpgTamed.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgTamed.Controls.Add(cboTameFilter);
            tpgTamed.Controls.Add(lblTameFilter);
            tpgTamed.Controls.Add(cboTamedTrait);
            tpgTamed.Controls.Add(label4);
            tpgTamed.Controls.Add(lblTameRad);
            tpgTamed.Controls.Add(udRadiusTamed);
            tpgTamed.Controls.Add(lblTameLon);
            tpgTamed.Controls.Add(udLonTamed);
            tpgTamed.Controls.Add(lblTameLat);
            tpgTamed.Controls.Add(udLatTamed);
            tpgTamed.Controls.Add(btnRconCommandTamed);
            tpgTamed.Controls.Add(cboTameRealm);
            tpgTamed.Controls.Add(lblTameRealm);
            tpgTamed.Controls.Add(pnlFilterTamed);
            tpgTamed.Controls.Add(cboTamedResource);
            tpgTamed.Controls.Add(lblTameResource);
            tpgTamed.Controls.Add(btnCopyCommandTamed);
            tpgTamed.Controls.Add(lblTamedCommand);
            tpgTamed.Controls.Add(cboConsoleCommandsTamed);
            tpgTamed.Controls.Add(cboTameTribes);
            tpgTamed.Controls.Add(cboTamePlayers);
            tpgTamed.Controls.Add(lblTameCreature);
            tpgTamed.Controls.Add(lblTamePlayer);
            tpgTamed.Controls.Add(lblTameTribe);
            tpgTamed.Controls.Add(btnDinoAncestors);
            tpgTamed.Controls.Add(btnDinoInventory);
            tpgTamed.Controls.Add(lvwTameDetail);
            tpgTamed.Controls.Add(lblTameTotal);
            tpgTamed.Controls.Add(pnlTameStatTypes);
            tpgTamed.Controls.Add(cboTameClass);
            tpgTamed.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            tpgTamed.Location = new System.Drawing.Point(4, 29);
            tpgTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgTamed.Name = "tpgTamed";
            tpgTamed.Size = new System.Drawing.Size(1104, 525);
            tpgTamed.TabIndex = 3;
            tpgTamed.Text = "Tamed Creatures";
            // 
            // cboTameFilter
            // 
            cboTameFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboTameFilter.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboTameFilter.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboTameFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboTameFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTameFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboTameFilter.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboTameFilter.FormattingEnabled = true;
            cboTameFilter.Location = new System.Drawing.Point(489, 43);
            cboTameFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboTameFilter.Name = "cboTameFilter";
            cboTameFilter.Size = new System.Drawing.Size(296, 24);
            cboTameFilter.TabIndex = 36;
            cboTameFilter.SelectedIndexChanged += cboTameFilter_SelectedIndexChanged;
            // 
            // lblTameFilter
            // 
            lblTameFilter.AutoSize = true;
            lblTameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTameFilter.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblTameFilter.Location = new System.Drawing.Point(444, 47);
            lblTameFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTameFilter.Name = "lblTameFilter";
            lblTameFilter.Size = new System.Drawing.Size(39, 13);
            lblTameFilter.TabIndex = 35;
            lblTameFilter.Text = "Filter:";
            lblTameFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboTamedTrait
            // 
            cboTamedTrait.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cboTamedTrait.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboTamedTrait.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboTamedTrait.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboTamedTrait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTamedTrait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboTamedTrait.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboTamedTrait.FormattingEnabled = true;
            cboTamedTrait.Location = new System.Drawing.Point(886, 76);
            cboTamedTrait.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboTamedTrait.Name = "cboTamedTrait";
            cboTamedTrait.Size = new System.Drawing.Size(201, 24);
            cboTamedTrait.TabIndex = 34;
            cboTamedTrait.SelectedIndexChanged += cboTamedTrait_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            label4.Location = new System.Drawing.Point(841, 80);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(37, 13);
            label4.TabIndex = 33;
            label4.Text = "Trait:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTameRad
            // 
            lblTameRad.AutoSize = true;
            lblTameRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTameRad.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblTameRad.Location = new System.Drawing.Point(281, 14);
            lblTameRad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTameRad.Name = "lblTameRad";
            lblTameRad.Size = new System.Drawing.Size(50, 13);
            lblTameRad.TabIndex = 31;
            lblTameRad.Text = "Radius:";
            lblTameRad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // udRadiusTamed
            // 
            udRadiusTamed.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udRadiusTamed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udRadiusTamed.DecimalPlaces = 2;
            udRadiusTamed.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udRadiusTamed.Location = new System.Drawing.Point(337, 14);
            udRadiusTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udRadiusTamed.Name = "udRadiusTamed";
            udRadiusTamed.Size = new System.Drawing.Size(62, 19);
            udRadiusTamed.TabIndex = 32;
            udRadiusTamed.Value = new decimal(new int[] { 10000, 0, 0, 131072 });
            udRadiusTamed.ValueChanged += FilterTamedLocations;
            // 
            // lblTameLon
            // 
            lblTameLon.AutoSize = true;
            lblTameLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTameLon.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblTameLon.Location = new System.Drawing.Point(162, 14);
            lblTameLon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTameLon.Name = "lblTameLon";
            lblTameLon.Size = new System.Drawing.Size(32, 13);
            lblTameLon.TabIndex = 29;
            lblTameLon.Text = "Lon:";
            lblTameLon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // udLonTamed
            // 
            udLonTamed.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udLonTamed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udLonTamed.DecimalPlaces = 2;
            udLonTamed.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udLonTamed.Location = new System.Drawing.Point(197, 14);
            udLonTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udLonTamed.Name = "udLonTamed";
            udLonTamed.Size = new System.Drawing.Size(62, 19);
            udLonTamed.TabIndex = 30;
            udLonTamed.Value = new decimal(new int[] { 5000, 0, 0, 131072 });
            udLonTamed.ValueChanged += FilterTamedLocations;
            // 
            // lblTameLat
            // 
            lblTameLat.AutoSize = true;
            lblTameLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTameLat.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblTameLat.Location = new System.Drawing.Point(47, 14);
            lblTameLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTameLat.Name = "lblTameLat";
            lblTameLat.Size = new System.Drawing.Size(29, 13);
            lblTameLat.TabIndex = 27;
            lblTameLat.Text = "Lat:";
            lblTameLat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // udLatTamed
            // 
            udLatTamed.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udLatTamed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udLatTamed.DecimalPlaces = 2;
            udLatTamed.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udLatTamed.Location = new System.Drawing.Point(84, 14);
            udLatTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udLatTamed.Name = "udLatTamed";
            udLatTamed.Size = new System.Drawing.Size(62, 19);
            udLatTamed.TabIndex = 28;
            udLatTamed.Value = new decimal(new int[] { 5000, 0, 0, 131072 });
            udLatTamed.ValueChanged += FilterTamedLocations;
            // 
            // cboTameRealm
            // 
            cboTameRealm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cboTameRealm.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboTameRealm.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboTameRealm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboTameRealm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTameRealm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboTameRealm.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboTameRealm.FormattingEnabled = true;
            cboTameRealm.Location = new System.Drawing.Point(886, 14);
            cboTameRealm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboTameRealm.Name = "cboTameRealm";
            cboTameRealm.Size = new System.Drawing.Size(201, 24);
            cboTameRealm.TabIndex = 24;
            cboTameRealm.SelectedIndexChanged += cboTameRealm_SelectedIndexChanged;
            // 
            // lblTameRealm
            // 
            lblTameRealm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblTameRealm.AutoSize = true;
            lblTameRealm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTameRealm.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblTameRealm.Location = new System.Drawing.Point(832, 19);
            lblTameRealm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTameRealm.Name = "lblTameRealm";
            lblTameRealm.Size = new System.Drawing.Size(46, 13);
            lblTameRealm.TabIndex = 23;
            lblTameRealm.Text = "Realm:";
            lblTameRealm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlFilterTamed
            // 
            pnlFilterTamed.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlFilterTamed.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            pnlFilterTamed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlFilterTamed.Controls.Add(btnFindTamed);
            pnlFilterTamed.Controls.Add(txtFilterTamed);
            pnlFilterTamed.Location = new System.Drawing.Point(13, 423);
            pnlFilterTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlFilterTamed.Name = "pnlFilterTamed";
            pnlFilterTamed.Size = new System.Drawing.Size(1073, 33);
            pnlFilterTamed.TabIndex = 21;
            // 
            // txtFilterTamed
            // 
            txtFilterTamed.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFilterTamed.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtFilterTamed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFilterTamed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFilterTamed.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtFilterTamed.Location = new System.Drawing.Point(12, 5);
            txtFilterTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilterTamed.Name = "txtFilterTamed";
            txtFilterTamed.Size = new System.Drawing.Size(1013, 20);
            txtFilterTamed.TabIndex = 6;
            txtFilterTamed.KeyDown += txtFilterTamed_KeyDown;
            // 
            // cboTamedResource
            // 
            cboTamedResource.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cboTamedResource.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboTamedResource.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboTamedResource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboTamedResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTamedResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboTamedResource.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboTamedResource.FormattingEnabled = true;
            cboTamedResource.Location = new System.Drawing.Point(886, 44);
            cboTamedResource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboTamedResource.Name = "cboTamedResource";
            cboTamedResource.Size = new System.Drawing.Size(201, 24);
            cboTamedResource.TabIndex = 16;
            cboTamedResource.SelectedIndexChanged += cboTamedResource_SelectedIndexChanged;
            // 
            // lblTameResource
            // 
            lblTameResource.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblTameResource.AutoSize = true;
            lblTameResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTameResource.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblTameResource.Location = new System.Drawing.Point(813, 48);
            lblTameResource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTameResource.Name = "lblTameResource";
            lblTameResource.Size = new System.Drawing.Size(65, 13);
            lblTameResource.TabIndex = 15;
            lblTameResource.Text = "Resource:";
            lblTameResource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTamedCommand
            // 
            lblTamedCommand.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblTamedCommand.AutoSize = true;
            lblTamedCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTamedCommand.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblTamedCommand.Location = new System.Drawing.Point(327, 479);
            lblTamedCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTamedCommand.Name = "lblTamedCommand";
            lblTamedCommand.Size = new System.Drawing.Size(65, 13);
            lblTamedCommand.TabIndex = 9;
            lblTamedCommand.Text = "Command:";
            // 
            // cboConsoleCommandsTamed
            // 
            cboConsoleCommandsTamed.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboConsoleCommandsTamed.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboConsoleCommandsTamed.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboConsoleCommandsTamed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboConsoleCommandsTamed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboConsoleCommandsTamed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboConsoleCommandsTamed.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboConsoleCommandsTamed.FormattingEnabled = true;
            cboConsoleCommandsTamed.Items.AddRange(new object[] { "AddMutations", "Cryo <DinoId>", "DestroyTribeIdDinos <TribeID>", "GMSummon \"<ClassName>\"  <Level>", "GMSummon \"<ClassName>\"  <Level> | <DoTame>", "SaveWorld", "SetPlayerPos  <x> <y> <z>", resources.GetString("cboConsoleCommandsTamed.Items"), "TakeTribe <TribeID>", "TeleportCreatureToMe <DinoId>", "TeleportToCreature <DinoId>" });
            cboConsoleCommandsTamed.Location = new System.Drawing.Point(406, 475);
            cboConsoleCommandsTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboConsoleCommandsTamed.Name = "cboConsoleCommandsTamed";
            cboConsoleCommandsTamed.Size = new System.Drawing.Size(289, 24);
            cboConsoleCommandsTamed.Sorted = true;
            cboConsoleCommandsTamed.TabIndex = 10;
            cboConsoleCommandsTamed.SelectedIndexChanged += cboConsoleCommandsTamed_SelectedIndexChanged;
            // 
            // cboTameTribes
            // 
            cboTameTribes.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboTameTribes.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboTameTribes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboTameTribes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTameTribes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboTameTribes.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboTameTribes.FormattingEnabled = true;
            cboTameTribes.Location = new System.Drawing.Point(84, 44);
            cboTameTribes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboTameTribes.Name = "cboTameTribes";
            cboTameTribes.Size = new System.Drawing.Size(315, 24);
            cboTameTribes.TabIndex = 1;
            cboTameTribes.SelectedIndexChanged += cboTameTribes_SelectedIndexChanged;
            // 
            // cboTamePlayers
            // 
            cboTamePlayers.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboTamePlayers.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboTamePlayers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboTamePlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTamePlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboTamePlayers.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboTamePlayers.FormattingEnabled = true;
            cboTamePlayers.Location = new System.Drawing.Point(84, 78);
            cboTamePlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboTamePlayers.Name = "cboTamePlayers";
            cboTamePlayers.Size = new System.Drawing.Size(315, 24);
            cboTamePlayers.TabIndex = 3;
            cboTamePlayers.SelectedIndexChanged += cboTamePlayers_SelectedIndexChanged;
            // 
            // lblTameCreature
            // 
            lblTameCreature.AutoSize = true;
            lblTameCreature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTameCreature.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblTameCreature.Location = new System.Drawing.Point(417, 80);
            lblTameCreature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTameCreature.Name = "lblTameCreature";
            lblTameCreature.Size = new System.Drawing.Size(59, 13);
            lblTameCreature.TabIndex = 4;
            lblTameCreature.Text = "Creature:";
            lblTameCreature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTamePlayer
            // 
            lblTamePlayer.AutoSize = true;
            lblTamePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTamePlayer.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblTamePlayer.Location = new System.Drawing.Point(30, 80);
            lblTamePlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTamePlayer.Name = "lblTamePlayer";
            lblTamePlayer.Size = new System.Drawing.Size(46, 13);
            lblTamePlayer.TabIndex = 2;
            lblTamePlayer.Text = "Player:";
            lblTamePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTameTribe
            // 
            lblTameTribe.AutoSize = true;
            lblTameTribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTameTribe.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblTameTribe.Location = new System.Drawing.Point(37, 47);
            lblTameTribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTameTribe.Name = "lblTameTribe";
            lblTameTribe.Size = new System.Drawing.Size(40, 13);
            lblTameTribe.TabIndex = 0;
            lblTameTribe.Text = "Tribe:";
            lblTameTribe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwTameDetail
            // 
            lvwTameDetail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwTameDetail.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwTameDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvwTameDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvwTameDetail_Tribe, lvwTameDetail_Creature, lvwTameDetail_Name, lvwTameDetail_Sex, colTameDetail_Maturation, lvwTameDetail_Base, lvwTameDetail_Level, lvwTameDetail_Lat, lvwTameDetail_Lon, lvwTameDetail_HP, lvwTameDetail_Stam, lvwTameDetail_Melee, lvwTameDetail_Weight, lvwTameDetail_Speed, lvwTameDetail_Food, lvwTameDetail_Oxygen, lvwTameDetail_Craft, lvwTameDetail_Server, lvwTameDetail_Tamer, lvwTameDetail_Imprinter, lvwTameDetail_Imprint, lvwTameDetail_Mating, lvwTameDetail_Wandering, lvwTameDetail_Neutered, lvwTameDetail_Cryo, lvwTameDetail_Clone, lvwTameDetail_Colour1, lvwTameDetail_Colour2, lvwTameDetail_Colour3, lvwTameDetail_Colour4, lvwTameDetail_Colour5, lvwTameDetail_Colour6, lvwTameDetail_MutationsFemale, lvwTameDetail_MutationsMale, lvwTameDetail_Id, lvwTameDetail_Scale, lvwTameDetail_Traits, lvwTameDetail_Rig1, lvwTameDetail_Rig2, lvwTameDetail_TribeInRange, lvwTameDetail_UploadTime, lvwTameDetail_DinoId, lvwTameDetail_CCC });
            lvwTameDetail.ContextMenuStrip = mnuContext;
            lvwTameDetail.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwTameDetail.FullRowSelect = true;
            lvwTameDetail.Location = new System.Drawing.Point(13, 112);
            lvwTameDetail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwTameDetail.Name = "lvwTameDetail";
            lvwTameDetail.Size = new System.Drawing.Size(1073, 312);
            lvwTameDetail.TabIndex = 7;
            lvwTameDetail.UseCompatibleStateImageBehavior = false;
            lvwTameDetail.View = System.Windows.Forms.View.Details;
            lvwTameDetail.ColumnClick += lvwTameDetail_ColumnClick;
            lvwTameDetail.SelectedIndexChanged += lvwTameDetail_SelectedIndexChanged;
            lvwTameDetail.MouseClick += lvwTameDetail_MouseClick;
            // 
            // lvwTameDetail_Tribe
            // 
            lvwTameDetail_Tribe.Text = "Tribe";
            lvwTameDetail_Tribe.Width = 200;
            // 
            // lvwTameDetail_Creature
            // 
            lvwTameDetail_Creature.Text = "Creature";
            lvwTameDetail_Creature.Width = 140;
            // 
            // lvwTameDetail_Name
            // 
            lvwTameDetail_Name.Text = "Name";
            lvwTameDetail_Name.Width = 150;
            // 
            // lvwTameDetail_Sex
            // 
            lvwTameDetail_Sex.Text = "Sex";
            // 
            // colTameDetail_Maturation
            // 
            colTameDetail_Maturation.Text = "Mature";
            // 
            // lvwTameDetail_Base
            // 
            lvwTameDetail_Base.Text = "Base";
            lvwTameDetail_Base.Width = 50;
            // 
            // lvwTameDetail_Level
            // 
            lvwTameDetail_Level.Text = "Lvl";
            lvwTameDetail_Level.Width = 41;
            // 
            // lvwTameDetail_Lat
            // 
            lvwTameDetail_Lat.Text = "Lat";
            lvwTameDetail_Lat.Width = 58;
            // 
            // lvwTameDetail_Lon
            // 
            lvwTameDetail_Lon.Text = "Lon";
            lvwTameDetail_Lon.Width = 57;
            // 
            // lvwTameDetail_HP
            // 
            lvwTameDetail_HP.Text = "HP";
            lvwTameDetail_HP.Width = 45;
            // 
            // lvwTameDetail_Stam
            // 
            lvwTameDetail_Stam.Text = "Stam";
            lvwTameDetail_Stam.Width = 45;
            // 
            // lvwTameDetail_Melee
            // 
            lvwTameDetail_Melee.Text = "Melee";
            lvwTameDetail_Melee.Width = 48;
            // 
            // lvwTameDetail_Weight
            // 
            lvwTameDetail_Weight.Text = "Weight";
            lvwTameDetail_Weight.Width = 55;
            // 
            // lvwTameDetail_Speed
            // 
            lvwTameDetail_Speed.Text = "Speed";
            lvwTameDetail_Speed.Width = 50;
            // 
            // lvwTameDetail_Food
            // 
            lvwTameDetail_Food.Text = "Food";
            lvwTameDetail_Food.Width = 47;
            // 
            // lvwTameDetail_Oxygen
            // 
            lvwTameDetail_Oxygen.Text = "Oxygen";
            lvwTameDetail_Oxygen.Width = 53;
            // 
            // lvwTameDetail_Craft
            // 
            lvwTameDetail_Craft.Text = "Craft";
            lvwTameDetail_Craft.Width = 50;
            // 
            // lvwTameDetail_Server
            // 
            lvwTameDetail_Server.Text = "Server";
            lvwTameDetail_Server.Width = 150;
            // 
            // lvwTameDetail_Tamer
            // 
            lvwTameDetail_Tamer.Text = "Tamer";
            lvwTameDetail_Tamer.Width = 105;
            // 
            // lvwTameDetail_Imprinter
            // 
            lvwTameDetail_Imprinter.Text = "Imprinter";
            lvwTameDetail_Imprinter.Width = 105;
            // 
            // lvwTameDetail_Imprint
            // 
            lvwTameDetail_Imprint.Text = "Imprint";
            // 
            // lvwTameDetail_Mating
            // 
            lvwTameDetail_Mating.Text = "Mating";
            // 
            // lvwTameDetail_Wandering
            // 
            lvwTameDetail_Wandering.Text = "Wandering";
            lvwTameDetail_Wandering.Width = 70;
            // 
            // lvwTameDetail_Neutered
            // 
            lvwTameDetail_Neutered.Text = "Neutered";
            lvwTameDetail_Neutered.Width = 65;
            // 
            // lvwTameDetail_Cryo
            // 
            lvwTameDetail_Cryo.Text = "Stored";
            // 
            // lvwTameDetail_Clone
            // 
            lvwTameDetail_Clone.Text = "Clone";
            // 
            // lvwTameDetail_Colour1
            // 
            lvwTameDetail_Colour1.Text = "C0";
            lvwTameDetail_Colour1.Width = 35;
            // 
            // lvwTameDetail_Colour2
            // 
            lvwTameDetail_Colour2.Text = "C1";
            lvwTameDetail_Colour2.Width = 35;
            // 
            // lvwTameDetail_Colour3
            // 
            lvwTameDetail_Colour3.Text = "C2";
            lvwTameDetail_Colour3.Width = 35;
            // 
            // lvwTameDetail_Colour4
            // 
            lvwTameDetail_Colour4.Text = "C3";
            lvwTameDetail_Colour4.Width = 35;
            // 
            // lvwTameDetail_Colour5
            // 
            lvwTameDetail_Colour5.Text = "C4";
            lvwTameDetail_Colour5.Width = 35;
            // 
            // lvwTameDetail_Colour6
            // 
            lvwTameDetail_Colour6.Text = "C5";
            lvwTameDetail_Colour6.Width = 35;
            // 
            // lvwTameDetail_MutationsFemale
            // 
            lvwTameDetail_MutationsFemale.Text = "Mut (F)";
            // 
            // lvwTameDetail_MutationsMale
            // 
            lvwTameDetail_MutationsMale.Text = "Mut (M)";
            // 
            // lvwTameDetail_Id
            // 
            lvwTameDetail_Id.Text = "Id";
            lvwTameDetail_Id.Width = 0;
            // 
            // lvwTameDetail_Scale
            // 
            lvwTameDetail_Scale.Text = "Scale";
            // 
            // lvwTameDetail_Traits
            // 
            lvwTameDetail_Traits.Text = "Traits";
            lvwTameDetail_Traits.Width = 40;
            // 
            // lvwTameDetail_Rig1
            // 
            lvwTameDetail_Rig1.Text = "Rig1";
            lvwTameDetail_Rig1.Width = 100;
            // 
            // lvwTameDetail_Rig2
            // 
            lvwTameDetail_Rig2.Text = "Rig2";
            lvwTameDetail_Rig2.Width = 100;
            // 
            // lvwTameDetail_TribeInRange
            // 
            lvwTameDetail_TribeInRange.Text = "Tribe In Range";
            lvwTameDetail_TribeInRange.Width = 120;
            // 
            // lvwTameDetail_UploadTime
            // 
            lvwTameDetail_UploadTime.Text = "Uploaded";
            lvwTameDetail_UploadTime.Width = 120;
            // 
            // lvwTameDetail_DinoId
            // 
            lvwTameDetail_DinoId.Text = "Creature Id";
            lvwTameDetail_DinoId.Width = 150;
            // 
            // lvwTameDetail_CCC
            // 
            lvwTameDetail_CCC.Text = "CCC";
            lvwTameDetail_CCC.Width = 0;
            // 
            // lblTameTotal
            // 
            lblTameTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblTameTotal.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            lblTameTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTameTotal.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblTameTotal.Location = new System.Drawing.Point(943, 471);
            lblTameTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTameTotal.Name = "lblTameTotal";
            lblTameTotal.Size = new System.Drawing.Size(144, 35);
            lblTameTotal.TabIndex = 14;
            lblTameTotal.Text = "Count: 0";
            lblTameTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTameTotal.Click += lblTameTotal_Click;
            // 
            // pnlTameStatTypes
            // 
            pnlTameStatTypes.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pnlTameStatTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlTameStatTypes.Controls.Add(optStatsMutated);
            pnlTameStatTypes.Controls.Add(lblStats);
            pnlTameStatTypes.Controls.Add(optStatsTamed);
            pnlTameStatTypes.Controls.Add(optStatsBase);
            pnlTameStatTypes.Location = new System.Drawing.Point(13, 466);
            pnlTameStatTypes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlTameStatTypes.Name = "pnlTameStatTypes";
            pnlTameStatTypes.Size = new System.Drawing.Size(285, 39);
            pnlTameStatTypes.TabIndex = 8;
            // 
            // optStatsMutated
            // 
            optStatsMutated.AutoSize = true;
            optStatsMutated.Location = new System.Drawing.Point(185, 10);
            optStatsMutated.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optStatsMutated.Name = "optStatsMutated";
            optStatsMutated.Size = new System.Drawing.Size(79, 19);
            optStatsMutated.TabIndex = 3;
            optStatsMutated.Text = "Mutations";
            optStatsMutated.UseVisualStyleBackColor = true;
            optStatsMutated.CheckedChanged += optStatsMutated_CheckedChanged;
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Location = new System.Drawing.Point(2, 12);
            lblStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStats.Name = "lblStats";
            lblStats.Size = new System.Drawing.Size(35, 15);
            lblStats.TabIndex = 0;
            lblStats.Text = "Stats:";
            // 
            // optStatsTamed
            // 
            optStatsTamed.AutoSize = true;
            optStatsTamed.Location = new System.Drawing.Point(113, 9);
            optStatsTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optStatsTamed.Name = "optStatsTamed";
            optStatsTamed.Size = new System.Drawing.Size(60, 19);
            optStatsTamed.TabIndex = 2;
            optStatsTamed.Text = "Tamed";
            optStatsTamed.UseVisualStyleBackColor = true;
            optStatsTamed.CheckedChanged += optStatsTamed_CheckedChanged;
            // 
            // optStatsBase
            // 
            optStatsBase.AutoSize = true;
            optStatsBase.Checked = true;
            optStatsBase.Location = new System.Drawing.Point(49, 9);
            optStatsBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optStatsBase.Name = "optStatsBase";
            optStatsBase.Size = new System.Drawing.Size(49, 19);
            optStatsBase.TabIndex = 1;
            optStatsBase.TabStop = true;
            optStatsBase.Text = "Base";
            optStatsBase.UseVisualStyleBackColor = true;
            optStatsBase.CheckedChanged += optStatsBase_CheckedChanged;
            // 
            // cboTameClass
            // 
            cboTameClass.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboTameClass.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboTameClass.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboTameClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboTameClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTameClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboTameClass.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboTameClass.FormattingEnabled = true;
            cboTameClass.Location = new System.Drawing.Point(489, 76);
            cboTameClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboTameClass.Name = "cboTameClass";
            cboTameClass.Size = new System.Drawing.Size(296, 24);
            cboTameClass.TabIndex = 5;
            cboTameClass.SelectedIndexChanged += cboTameClass_SelectedIndexChanged;
            // 
            // tpgWild
            // 
            tpgWild.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgWild.Controls.Add(cboWildTrait);
            tpgWild.Controls.Add(label3);
            tpgWild.Controls.Add(btnRconCommandWild);
            tpgWild.Controls.Add(chkTameable);
            tpgWild.Controls.Add(cboWildRealm);
            tpgWild.Controls.Add(lblWildRealm);
            tpgWild.Controls.Add(pnlFilterWilds);
            tpgWild.Controls.Add(cboWildResource);
            tpgWild.Controls.Add(lblResource);
            tpgWild.Controls.Add(lblWildRadius);
            tpgWild.Controls.Add(udWildRadius);
            tpgWild.Controls.Add(lblWildLon);
            tpgWild.Controls.Add(udWildLon);
            tpgWild.Controls.Add(lblWildLat);
            tpgWild.Controls.Add(udWildLat);
            tpgWild.Controls.Add(lblWildMin);
            tpgWild.Controls.Add(lblWildMax);
            tpgWild.Controls.Add(udWildMin);
            tpgWild.Controls.Add(udWildMax);
            tpgWild.Controls.Add(btnCopyCommandWild);
            tpgWild.Controls.Add(lblWildCommand);
            tpgWild.Controls.Add(cboConsoleCommandsWild);
            tpgWild.Controls.Add(lblSelectedWildTotal);
            tpgWild.Controls.Add(lblWildClass);
            tpgWild.Controls.Add(lvwWildDetail);
            tpgWild.Controls.Add(lblWildTotal);
            tpgWild.Controls.Add(cboWildClass);
            tpgWild.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            tpgWild.Location = new System.Drawing.Point(4, 29);
            tpgWild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgWild.Name = "tpgWild";
            tpgWild.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgWild.Size = new System.Drawing.Size(1104, 525);
            tpgWild.TabIndex = 0;
            tpgWild.Text = "Wild Creatures";
            // 
            // cboWildTrait
            // 
            cboWildTrait.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cboWildTrait.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboWildTrait.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboWildTrait.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboWildTrait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboWildTrait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboWildTrait.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboWildTrait.FormattingEnabled = true;
            cboWildTrait.Location = new System.Drawing.Point(864, 71);
            cboWildTrait.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboWildTrait.Name = "cboWildTrait";
            cboWildTrait.Size = new System.Drawing.Size(222, 24);
            cboWildTrait.TabIndex = 26;
            cboWildTrait.SelectedIndexChanged += cboWildTrait_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            label3.Location = new System.Drawing.Point(795, 74);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 13);
            label3.TabIndex = 25;
            label3.Text = "Trait:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkTameable
            // 
            chkTameable.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            chkTameable.AutoSize = true;
            chkTameable.Checked = true;
            chkTameable.CheckState = System.Windows.Forms.CheckState.Checked;
            chkTameable.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            chkTameable.Location = new System.Drawing.Point(647, 76);
            chkTameable.Name = "chkTameable";
            chkTameable.Size = new System.Drawing.Size(76, 19);
            chkTameable.TabIndex = 23;
            chkTameable.Text = "Tameable";
            chkTameable.UseVisualStyleBackColor = true;
            chkTameable.CheckedChanged += chkTameable_CheckedChanged;
            // 
            // cboWildRealm
            // 
            cboWildRealm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cboWildRealm.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboWildRealm.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboWildRealm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboWildRealm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboWildRealm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboWildRealm.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboWildRealm.FormattingEnabled = true;
            cboWildRealm.Location = new System.Drawing.Point(864, 8);
            cboWildRealm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboWildRealm.Name = "cboWildRealm";
            cboWildRealm.Size = new System.Drawing.Size(222, 24);
            cboWildRealm.TabIndex = 22;
            cboWildRealm.SelectedIndexChanged += cboWildRealm_SelectedIndexChanged;
            // 
            // lblWildRealm
            // 
            lblWildRealm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblWildRealm.AutoSize = true;
            lblWildRealm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWildRealm.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblWildRealm.Location = new System.Drawing.Point(795, 12);
            lblWildRealm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWildRealm.Name = "lblWildRealm";
            lblWildRealm.Size = new System.Drawing.Size(46, 13);
            lblWildRealm.TabIndex = 21;
            lblWildRealm.Text = "Realm:";
            lblWildRealm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlFilterWilds
            // 
            pnlFilterWilds.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlFilterWilds.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            pnlFilterWilds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlFilterWilds.Controls.Add(btnFindWild);
            pnlFilterWilds.Controls.Add(txtFilterWild);
            pnlFilterWilds.Location = new System.Drawing.Point(13, 416);
            pnlFilterWilds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlFilterWilds.Name = "pnlFilterWilds";
            pnlFilterWilds.Size = new System.Drawing.Size(1073, 33);
            pnlFilterWilds.TabIndex = 20;
            // 
            // txtFilterWild
            // 
            txtFilterWild.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFilterWild.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtFilterWild.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFilterWild.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFilterWild.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtFilterWild.Location = new System.Drawing.Point(12, 5);
            txtFilterWild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilterWild.Name = "txtFilterWild";
            txtFilterWild.Size = new System.Drawing.Size(1013, 20);
            txtFilterWild.TabIndex = 6;
            txtFilterWild.KeyDown += txtFilterWild_KeyDown;
            // 
            // cboWildResource
            // 
            cboWildResource.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cboWildResource.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboWildResource.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboWildResource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboWildResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboWildResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboWildResource.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboWildResource.FormattingEnabled = true;
            cboWildResource.Location = new System.Drawing.Point(864, 40);
            cboWildResource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboWildResource.Name = "cboWildResource";
            cboWildResource.Size = new System.Drawing.Size(222, 24);
            cboWildResource.TabIndex = 11;
            cboWildResource.SelectedIndexChanged += cboWildResource_SelectedIndexChanged;
            // 
            // lblResource
            // 
            lblResource.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblResource.AutoSize = true;
            lblResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblResource.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblResource.Location = new System.Drawing.Point(795, 43);
            lblResource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblResource.Name = "lblResource";
            lblResource.Size = new System.Drawing.Size(65, 13);
            lblResource.TabIndex = 10;
            lblResource.Text = "Resource:";
            lblResource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWildRadius
            // 
            lblWildRadius.AutoSize = true;
            lblWildRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWildRadius.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblWildRadius.Location = new System.Drawing.Point(491, 12);
            lblWildRadius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWildRadius.Name = "lblWildRadius";
            lblWildRadius.Size = new System.Drawing.Size(50, 13);
            lblWildRadius.TabIndex = 8;
            lblWildRadius.Text = "Radius:";
            lblWildRadius.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // udWildRadius
            // 
            udWildRadius.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udWildRadius.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udWildRadius.DecimalPlaces = 2;
            udWildRadius.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udWildRadius.Location = new System.Drawing.Point(554, 12);
            udWildRadius.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udWildRadius.Name = "udWildRadius";
            udWildRadius.Size = new System.Drawing.Size(75, 19);
            udWildRadius.TabIndex = 9;
            udWildRadius.Value = new decimal(new int[] { 10000, 0, 0, 131072 });
            udWildRadius.ValueChanged += udWildRadius_ValueChanged;
            udWildRadius.Enter += udWildRadius_Enter;
            udWildRadius.MouseClick += udWildRadius_MouseClick;
            // 
            // lblWildLon
            // 
            lblWildLon.AutoSize = true;
            lblWildLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWildLon.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblWildLon.Location = new System.Drawing.Point(369, 12);
            lblWildLon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWildLon.Name = "lblWildLon";
            lblWildLon.Size = new System.Drawing.Size(32, 13);
            lblWildLon.TabIndex = 6;
            lblWildLon.Text = "Lon:";
            lblWildLon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // udWildLon
            // 
            udWildLon.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udWildLon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udWildLon.DecimalPlaces = 2;
            udWildLon.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udWildLon.Location = new System.Drawing.Point(409, 12);
            udWildLon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udWildLon.Name = "udWildLon";
            udWildLon.Size = new System.Drawing.Size(69, 19);
            udWildLon.TabIndex = 7;
            udWildLon.Value = new decimal(new int[] { 5000, 0, 0, 131072 });
            udWildLon.ValueChanged += udWildLon_ValueChanged;
            udWildLon.Enter += udWildLon_Enter;
            udWildLon.MouseClick += udWildLon_MouseClick;
            // 
            // lblWildLat
            // 
            lblWildLat.AutoSize = true;
            lblWildLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWildLat.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblWildLat.Location = new System.Drawing.Point(252, 12);
            lblWildLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWildLat.Name = "lblWildLat";
            lblWildLat.Size = new System.Drawing.Size(29, 13);
            lblWildLat.TabIndex = 4;
            lblWildLat.Text = "Lat:";
            lblWildLat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // udWildLat
            // 
            udWildLat.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udWildLat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udWildLat.DecimalPlaces = 2;
            udWildLat.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udWildLat.Location = new System.Drawing.Point(287, 12);
            udWildLat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udWildLat.Name = "udWildLat";
            udWildLat.Size = new System.Drawing.Size(70, 19);
            udWildLat.TabIndex = 5;
            udWildLat.Value = new decimal(new int[] { 5000, 0, 0, 131072 });
            udWildLat.ValueChanged += udWildLat_ValueChanged;
            udWildLat.Enter += udWildLat_Enter;
            udWildLat.MouseClick += udWildLat_MouseClick;
            // 
            // lblWildMin
            // 
            lblWildMin.AutoSize = true;
            lblWildMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWildMin.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblWildMin.Location = new System.Drawing.Point(50, 12);
            lblWildMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWildMin.Name = "lblWildMin";
            lblWildMin.Size = new System.Drawing.Size(31, 13);
            lblWildMin.TabIndex = 0;
            lblWildMin.Text = "Min:";
            lblWildMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWildMax
            // 
            lblWildMax.AutoSize = true;
            lblWildMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWildMax.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblWildMax.Location = new System.Drawing.Point(146, 12);
            lblWildMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWildMax.Name = "lblWildMax";
            lblWildMax.Size = new System.Drawing.Size(34, 13);
            lblWildMax.TabIndex = 2;
            lblWildMax.Text = "Max:";
            lblWildMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // udWildMin
            // 
            udWildMin.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udWildMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udWildMin.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udWildMin.Location = new System.Drawing.Point(89, 12);
            udWildMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udWildMin.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            udWildMin.Name = "udWildMin";
            udWildMin.Size = new System.Drawing.Size(44, 19);
            udWildMin.TabIndex = 1;
            udWildMin.ValueChanged += udWildMin_ValueChanged;
            udWildMin.Enter += udWildMin_Enter;
            udWildMin.MouseClick += udWildMin_MouseClick;
            // 
            // udWildMax
            // 
            udWildMax.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udWildMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udWildMax.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udWildMax.Location = new System.Drawing.Point(192, 12);
            udWildMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udWildMax.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            udWildMax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            udWildMax.Name = "udWildMax";
            udWildMax.Size = new System.Drawing.Size(56, 19);
            udWildMax.TabIndex = 3;
            udWildMax.Value = new decimal(new int[] { 190, 0, 0, 0 });
            udWildMax.ValueChanged += udWildMax_ValueChanged;
            udWildMax.Enter += udWildMax_Enter;
            udWildMax.MouseClick += udWildMax_MouseClick;
            // 
            // lblWildCommand
            // 
            lblWildCommand.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblWildCommand.AutoSize = true;
            lblWildCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWildCommand.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblWildCommand.Location = new System.Drawing.Point(16, 474);
            lblWildCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWildCommand.Name = "lblWildCommand";
            lblWildCommand.Size = new System.Drawing.Size(65, 13);
            lblWildCommand.TabIndex = 15;
            lblWildCommand.Text = "Command:";
            // 
            // cboConsoleCommandsWild
            // 
            cboConsoleCommandsWild.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboConsoleCommandsWild.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboConsoleCommandsWild.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboConsoleCommandsWild.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboConsoleCommandsWild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboConsoleCommandsWild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboConsoleCommandsWild.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboConsoleCommandsWild.FormattingEnabled = true;
            cboConsoleCommandsWild.Items.AddRange(new object[] { "DestroyWildDinoClasses <ClassName> 1 ", "DestroyWildDinos", "GMSummon \"<ClassName>\" <Level> ", "SaveWorld", "SetPlayerPos  <x> <y> <z>", resources.GetString("cboConsoleCommandsWild.Items") });
            cboConsoleCommandsWild.Location = new System.Drawing.Point(96, 470);
            cboConsoleCommandsWild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboConsoleCommandsWild.Name = "cboConsoleCommandsWild";
            cboConsoleCommandsWild.Size = new System.Drawing.Size(305, 24);
            cboConsoleCommandsWild.Sorted = true;
            cboConsoleCommandsWild.TabIndex = 16;
            cboConsoleCommandsWild.SelectedIndexChanged += cboConsoleCommandsWild_SelectedIndexChanged;
            // 
            // lblSelectedWildTotal
            // 
            lblSelectedWildTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblSelectedWildTotal.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            lblSelectedWildTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSelectedWildTotal.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblSelectedWildTotal.Location = new System.Drawing.Point(788, 466);
            lblSelectedWildTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSelectedWildTotal.Name = "lblSelectedWildTotal";
            lblSelectedWildTotal.Size = new System.Drawing.Size(144, 35);
            lblSelectedWildTotal.TabIndex = 18;
            lblSelectedWildTotal.Text = "Count: 0";
            lblSelectedWildTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWildClass
            // 
            lblWildClass.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblWildClass.AutoSize = true;
            lblWildClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWildClass.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblWildClass.Location = new System.Drawing.Point(15, 77);
            lblWildClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWildClass.Name = "lblWildClass";
            lblWildClass.Size = new System.Drawing.Size(59, 13);
            lblWildClass.TabIndex = 12;
            lblWildClass.Text = "Creature:";
            lblWildClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwWildDetail
            // 
            lvwWildDetail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwWildDetail.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwWildDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvwWildDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvwWildDetail_Name, lvwWildDetail_Sex, colWildDetail_Mature, lvwWildDetail_Base, lvwWildDetail_Level, lvwWildDetail_Lat, lvwWildDetail_Lon, lvwWildDetail_HP, lvwWildDetail_Stam, lvwWildDetail_Melee, lvwWildDetail_Weight, lvwWildDetail_Speed, lvwWildDetail_Food, lvwWildDetail_Oxygen, lvwWildDetail_Craft, lvwWildDetail_Colour1, lvwWildDetail_Colour2, lvwWildDetail_Colour3, lvwWildDetail_Colour4, lvwWildDetail_Colour5, lvwWildDetail_Colour6, lvwWildDetail_Id, lvwWildDetail_Scale, lvwWildDetail_Trait, lvwWildDetail_Rig1, lvwWildDetail_Rig2, lvwWildDetail_DinoId, lvwWildDetail_CCC });
            lvwWildDetail.ContextMenuStrip = mnuContext;
            lvwWildDetail.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwWildDetail.FullRowSelect = true;
            lvwWildDetail.Location = new System.Drawing.Point(13, 112);
            lvwWildDetail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwWildDetail.Name = "lvwWildDetail";
            lvwWildDetail.Size = new System.Drawing.Size(1073, 305);
            lvwWildDetail.TabIndex = 14;
            lvwWildDetail.UseCompatibleStateImageBehavior = false;
            lvwWildDetail.View = System.Windows.Forms.View.Details;
            lvwWildDetail.ColumnClick += lvwWildDetail_ColumnClick;
            lvwWildDetail.SelectedIndexChanged += LvwWildDetail_SelectedIndexChanged;
            lvwWildDetail.MouseClick += lvwWildDetail_MouseClick;
            // 
            // lvwWildDetail_Name
            // 
            lvwWildDetail_Name.Text = "Creature";
            lvwWildDetail_Name.Width = 142;
            // 
            // lvwWildDetail_Sex
            // 
            lvwWildDetail_Sex.Text = "Sex";
            lvwWildDetail_Sex.Width = 52;
            // 
            // colWildDetail_Mature
            // 
            colWildDetail_Mature.Text = "Mature";
            colWildDetail_Mature.Width = 52;
            // 
            // lvwWildDetail_Base
            // 
            lvwWildDetail_Base.Text = "Base";
            lvwWildDetail_Base.Width = 0;
            // 
            // lvwWildDetail_Level
            // 
            lvwWildDetail_Level.Text = "Lvl";
            lvwWildDetail_Level.Width = 40;
            // 
            // lvwWildDetail_Lat
            // 
            lvwWildDetail_Lat.Text = "Lat";
            lvwWildDetail_Lat.Width = 51;
            // 
            // lvwWildDetail_Lon
            // 
            lvwWildDetail_Lon.Text = "Lon";
            lvwWildDetail_Lon.Width = 40;
            // 
            // lvwWildDetail_HP
            // 
            lvwWildDetail_HP.Text = "HP";
            lvwWildDetail_HP.Width = 45;
            // 
            // lvwWildDetail_Stam
            // 
            lvwWildDetail_Stam.Text = "Stam";
            lvwWildDetail_Stam.Width = 45;
            // 
            // lvwWildDetail_Melee
            // 
            lvwWildDetail_Melee.Text = "Melee";
            lvwWildDetail_Melee.Width = 48;
            // 
            // lvwWildDetail_Weight
            // 
            lvwWildDetail_Weight.Text = "Weight";
            lvwWildDetail_Weight.Width = 55;
            // 
            // lvwWildDetail_Speed
            // 
            lvwWildDetail_Speed.Text = "Speed";
            lvwWildDetail_Speed.Width = 50;
            // 
            // lvwWildDetail_Food
            // 
            lvwWildDetail_Food.Text = "Food";
            lvwWildDetail_Food.Width = 47;
            // 
            // lvwWildDetail_Oxygen
            // 
            lvwWildDetail_Oxygen.Text = "Oxygen";
            lvwWildDetail_Oxygen.Width = 53;
            // 
            // lvwWildDetail_Craft
            // 
            lvwWildDetail_Craft.Text = "Craft";
            lvwWildDetail_Craft.Width = 50;
            // 
            // lvwWildDetail_Colour1
            // 
            lvwWildDetail_Colour1.Text = "C0";
            lvwWildDetail_Colour1.Width = 35;
            // 
            // lvwWildDetail_Colour2
            // 
            lvwWildDetail_Colour2.Text = "C1";
            lvwWildDetail_Colour2.Width = 35;
            // 
            // lvwWildDetail_Colour3
            // 
            lvwWildDetail_Colour3.Text = "C2";
            lvwWildDetail_Colour3.Width = 35;
            // 
            // lvwWildDetail_Colour4
            // 
            lvwWildDetail_Colour4.Text = "C3";
            lvwWildDetail_Colour4.Width = 35;
            // 
            // lvwWildDetail_Colour5
            // 
            lvwWildDetail_Colour5.Text = "C4";
            lvwWildDetail_Colour5.Width = 35;
            // 
            // lvwWildDetail_Colour6
            // 
            lvwWildDetail_Colour6.Text = "C5";
            lvwWildDetail_Colour6.Width = 35;
            // 
            // lvwWildDetail_Id
            // 
            lvwWildDetail_Id.Text = "Id";
            lvwWildDetail_Id.Width = 0;
            // 
            // lvwWildDetail_Scale
            // 
            lvwWildDetail_Scale.Text = "Scale";
            // 
            // lvwWildDetail_Trait
            // 
            lvwWildDetail_Trait.Text = "Trait";
            lvwWildDetail_Trait.Width = 150;
            // 
            // lvwWildDetail_Rig1
            // 
            lvwWildDetail_Rig1.Text = "Rig 1";
            lvwWildDetail_Rig1.Width = 100;
            // 
            // lvwWildDetail_Rig2
            // 
            lvwWildDetail_Rig2.Text = "Rig 2";
            lvwWildDetail_Rig2.Width = 100;
            // 
            // lvwWildDetail_DinoId
            // 
            lvwWildDetail_DinoId.Text = "DinoId";
            lvwWildDetail_DinoId.Width = 0;
            // 
            // lvwWildDetail_CCC
            // 
            lvwWildDetail_CCC.Text = "CCC";
            lvwWildDetail_CCC.Width = 0;
            // 
            // lblWildTotal
            // 
            lblWildTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblWildTotal.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            lblWildTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblWildTotal.ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblWildTotal.Location = new System.Drawing.Point(936, 466);
            lblWildTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWildTotal.Name = "lblWildTotal";
            lblWildTotal.Size = new System.Drawing.Size(152, 35);
            lblWildTotal.TabIndex = 19;
            lblWildTotal.Text = "Total: 0";
            lblWildTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboWildClass
            // 
            cboWildClass.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboWildClass.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboWildClass.BorderColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboWildClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboWildClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboWildClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboWildClass.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboWildClass.FormattingEnabled = true;
            cboWildClass.Location = new System.Drawing.Point(87, 74);
            cboWildClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboWildClass.MaxDropDownItems = 20;
            cboWildClass.Name = "cboWildClass";
            cboWildClass.Size = new System.Drawing.Size(540, 24);
            cboWildClass.TabIndex = 13;
            cboWildClass.DrawItem += cboSelected_DrawItem;
            cboWildClass.SelectedIndexChanged += CboWildClass_SelectedIndexChanged;
            // 
            // tabFeatures
            // 
            tabFeatures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabFeatures.Controls.Add(tpgWild);
            tabFeatures.Controls.Add(tpgTamed);
            tabFeatures.Controls.Add(tpgStructures);
            tabFeatures.Controls.Add(tpgTribes);
            tabFeatures.Controls.Add(tpgPlayers);
            tabFeatures.Controls.Add(tpgDroppedItems);
            tabFeatures.Controls.Add(tpgItemList);
            tabFeatures.Controls.Add(tpgPaintings);
            tabFeatures.Controls.Add(tpgLocalProfile);
            tabFeatures.Controls.Add(tpgLeaderboard);
            tabFeatures.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            tabFeatures.HotTrack = true;
            tabFeatures.ItemSize = new System.Drawing.Size(110, 25);
            tabFeatures.Location = new System.Drawing.Point(8, 81);
            tabFeatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabFeatures.Name = "tabFeatures";
            tabFeatures.Padding = new System.Drawing.Point(0, 0);
            tabFeatures.SelectedIndex = 0;
            tabFeatures.Size = new System.Drawing.Size(1112, 558);
            tabFeatures.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tabFeatures.TabIndex = 0;
            tabFeatures.DrawItem += tabFeatures_DrawItem;
            tabFeatures.SelectedIndexChanged += tabFeatures_SelectedIndexChanged;
            // 
            // frmViewer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ClientSize = new System.Drawing.Size(1136, 715);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblVersion);
            Controls.Add(lblSubTitle);
            Controls.Add(lblTitle);
            Controls.Add(lblMap);
            Controls.Add(cboSelectedMap);
            Controls.Add(lblMapTypeName);
            Controls.Add(lblMapDate);
            Controls.Add(btnViewMap);
            Controls.Add(btnRefresh);
            Controls.Add(btnSettings);
            Controls.Add(lblStatus);
            Controls.Add(tabFeatures);
            ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(1152, 605);
            Name = "frmViewer";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ARK Savegame Visualiser";
            FormClosed += frmViewer_FormClosed;
            ResizeEnd += frmViewer_ResizeEnd;
            LocationChanged += frmViewer_LocationChanged;
            Enter += frmViewer_Enter;
            Resize += frmViewer_Resize;
            mnuContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tpgLeaderboard.ResumeLayout(false);
            tpgLeaderboard.PerformLayout();
            tpgLocalProfile.ResumeLayout(false);
            tpgLocalProfile.PerformLayout();
            pnlUploadedStats.ResumeLayout(false);
            pnlUploadedStats.PerformLayout();
            tpgPaintings.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPainting).EndInit();
            tpgItemList.ResumeLayout(false);
            tpgItemList.PerformLayout();
            pnlFilterSearch.ResumeLayout(false);
            pnlFilterSearch.PerformLayout();
            tpgDroppedItems.ResumeLayout(false);
            tpgDroppedItems.PerformLayout();
            pnlFilterDropped.ResumeLayout(false);
            pnlFilterDropped.PerformLayout();
            tpgPlayers.ResumeLayout(false);
            tpgPlayers.PerformLayout();
            pnlFilterPlayers.ResumeLayout(false);
            pnlFilterPlayers.PerformLayout();
            tpgTribes.ResumeLayout(false);
            tpgTribes.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pnlFilterTribes.ResumeLayout(false);
            pnlFilterTribes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)udChartTop).EndInit();
            tpgStructures.ResumeLayout(false);
            tpgStructures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)udRadiusStructures).EndInit();
            ((System.ComponentModel.ISupportInitialize)udLonStructures).EndInit();
            ((System.ComponentModel.ISupportInitialize)udLatStructures).EndInit();
            pnlFilterStructures.ResumeLayout(false);
            pnlFilterStructures.PerformLayout();
            tpgTamed.ResumeLayout(false);
            tpgTamed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)udRadiusTamed).EndInit();
            ((System.ComponentModel.ISupportInitialize)udLonTamed).EndInit();
            ((System.ComponentModel.ISupportInitialize)udLatTamed).EndInit();
            pnlFilterTamed.ResumeLayout(false);
            pnlFilterTamed.PerformLayout();
            pnlTameStatTypes.ResumeLayout(false);
            pnlTameStatTypes.PerformLayout();
            tpgWild.ResumeLayout(false);
            tpgWild.PerformLayout();
            pnlFilterWilds.ResumeLayout(false);
            pnlFilterWilds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)udWildRadius).EndInit();
            ((System.ComponentModel.ISupportInitialize)udWildLon).EndInit();
            ((System.ComponentModel.ISupportInitialize)udWildLat).EndInit();
            ((System.ComponentModel.ISupportInitialize)udWildMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)udWildMax).EndInit();
            tabFeatures.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblMapDate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ContextMenuStrip mnuContext;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_PlayerId;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_SteamId;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_TribeId;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_Export;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Button btnViewMap;
        private System.Windows.Forms.Label lblMapTypeName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblMap;
        private ArkViewer.UI.BorderlessComboBox cboSelectedMap;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_Structures;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_Tames;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_Players;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_DinoId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_ProfileFilename;
        private System.Windows.Forms.Button btnCopyFilenames;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabPage tpgLeaderboard;
        private ArkViewer.UI.BorderlessComboBox cboLeaderboardPlayer;
        private System.Windows.Forms.Label lblMissionPlayer;
        private System.Windows.Forms.ListView lvwLeaderboardSummary;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.ColumnHeader columnHeader36;
        private System.Windows.Forms.ListView lvwLeaderboard;
        private System.Windows.Forms.ColumnHeader lvwLeaderboard_Mission;
        private System.Windows.Forms.ColumnHeader lvwLeaderboard_Tribe;
        private System.Windows.Forms.ColumnHeader lvwLeaderboard_Player;
        private System.Windows.Forms.ColumnHeader lvwLeaderboard_Score;
        private ArkViewer.UI.BorderlessComboBox cboLeaderboardMission;
        private System.Windows.Forms.Label lblLeaderboardMission;
        private ArkViewer.UI.BorderlessComboBox cboLeaderboardTribe;
        private System.Windows.Forms.Label lblLeaderboardTribe;
        private System.Windows.Forms.TabPage tpgLocalProfile;
        private System.Windows.Forms.Panel pnlUploadedStats;
        private System.Windows.Forms.Label lblUploadedStats;
        private System.Windows.Forms.RadioButton optUploadedStatsTamed;
        private System.Windows.Forms.RadioButton optUploadedStatsBase;
        private System.Windows.Forms.Label lblUploadedCountItems;
        private System.Windows.Forms.Label lblUploadedCountTames;
        private System.Windows.Forms.Label lblUploadedCountCharacters;
        private System.Windows.Forms.Label lblUploadedItems;
        private System.Windows.Forms.ListView lvwUploadedItems;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.Label lblUploadedTames;
        private System.Windows.Forms.Label lblUploadedCharacters;
        private System.Windows.Forms.ListView lvwUploadedCharacters;
        private System.Windows.Forms.ColumnHeader columnHeader37;
        private System.Windows.Forms.ColumnHeader columnHeader39;
        private System.Windows.Forms.ColumnHeader columnHeader40;
        private System.Windows.Forms.ColumnHeader columnHeader43;
        private System.Windows.Forms.ColumnHeader columnHeader44;
        private System.Windows.Forms.ColumnHeader columnHeader45;
        private System.Windows.Forms.ColumnHeader columnHeader46;
        private System.Windows.Forms.ColumnHeader columnHeader47;
        private System.Windows.Forms.ColumnHeader columnHeader48;
        private System.Windows.Forms.ColumnHeader columnHeader49;
        private System.Windows.Forms.ColumnHeader columnHeader50;
        private System.Windows.Forms.ColumnHeader columnHeader51;
        private System.Windows.Forms.ColumnHeader columnHeader52;
        private System.Windows.Forms.ListView lvwUploadedTames;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ColumnHeader columnHeader33;
        private System.Windows.Forms.ColumnHeader columnHeader34;
        private System.Windows.Forms.TabPage tpgPaintings;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblPaintingsCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDeletePaintings;
        private System.Windows.Forms.Label lblPaintingTribe;
        private System.Windows.Forms.ListView lvwPlayerPaintings;
        private System.Windows.Forms.ColumnHeader lvwPlayerPaintings_Tribe;
        private System.Windows.Forms.ColumnHeader lvwPlayerPaintings_Structure;
        private System.Windows.Forms.ColumnHeader lvwPlayerPaintings_Lat;
        private System.Windows.Forms.ColumnHeader lvwPlayerPaintings_Lon;
        private System.Windows.Forms.ColumnHeader lvwPlayerPaintings_PaintingId;
        private ArkViewer.UI.BorderlessComboBox cboPaintingTribe;
        private System.Windows.Forms.Label lblStructurePainting;
        private ArkViewer.UI.BorderlessComboBox cboConsoleCommandPainting;
        private ArkViewer.UI.BorderlessComboBox cboPaintingStructure;
        private System.Windows.Forms.Label lblCopyCommandPaintings;
        private System.Windows.Forms.Button btnConsoleCommandPainting;
        private System.Windows.Forms.PictureBox picPainting;
        private System.Windows.Forms.TabPage tpgItemList;
        private System.Windows.Forms.Panel pnlFilterSearch;
        private System.Windows.Forms.Button btnFindSearched;
        private System.Windows.Forms.TextBox txtFilterSearch;
        private ArkViewer.UI.BorderlessComboBox cboItemListItem;
        private System.Windows.Forms.Label lblItemListTribe;
        private ArkViewer.UI.BorderlessComboBox cboItemListTribe;
        private System.Windows.Forms.Button btnCopyItemListCommand;
        private System.Windows.Forms.Label lblItemListCommand;
        private ArkViewer.UI.BorderlessComboBox cboConsoleCommandSearch;
        private System.Windows.Forms.Label lblItemListCount;
        private System.Windows.Forms.Label lblItemListItem;
        private System.Windows.Forms.ListView lvwItemList;
        private System.Windows.Forms.ColumnHeader lvwItemList_Tribe;
        private System.Windows.Forms.ColumnHeader lvwItemList_Container;
        private System.Windows.Forms.ColumnHeader lvwItemList_Player;
        private System.Windows.Forms.ColumnHeader lvwItemList_Item;
        private System.Windows.Forms.ColumnHeader lvwItemList_Quality;
        private System.Windows.Forms.ColumnHeader lvwItemList_Rating;
        private System.Windows.Forms.ColumnHeader lvwItemList_BP;
        private System.Windows.Forms.ColumnHeader lvwItemList_Quantity;
        private System.Windows.Forms.ColumnHeader lvwItemList_Lat;
        private System.Windows.Forms.ColumnHeader lvwItemList_Lon;
        private System.Windows.Forms.ColumnHeader lvwItemList_CCC;
        private System.Windows.Forms.ColumnHeader lvwItemList_UploadTime;
        private System.Windows.Forms.TabPage tpgDroppedItems;
        private ArkViewer.UI.BorderlessComboBox cboDroppedItemRealm;
        private System.Windows.Forms.Label lblDroppedItemRealm;
        private System.Windows.Forms.Panel pnlFilterDropped;
        private System.Windows.Forms.Button btnFindDropped;
        private System.Windows.Forms.TextBox txtFilterDropped;
        private System.Windows.Forms.CheckBox chkDroppedBlueprints;
        private System.Windows.Forms.Button btnDropInventory;
        private ArkViewer.UI.BorderlessComboBox cboDroppedItem;
        private System.Windows.Forms.Label lblDroppedPlayer;
        private ArkViewer.UI.BorderlessComboBox cboDroppedPlayer;
        private System.Windows.Forms.Button btnCopyCommandDropped;
        private System.Windows.Forms.Label lblCopyCommandDropped;
        private ArkViewer.UI.BorderlessComboBox cboConsoleCommandDropped;
        private System.Windows.Forms.Label lblCountDropped;
        private System.Windows.Forms.Label lblDroppedItem;
        private System.Windows.Forms.ListView lvwDroppedItems;
        private System.Windows.Forms.ColumnHeader lvwDroppedItems_Item;
        private System.Windows.Forms.ColumnHeader lvwDroppedItems_Bp;
        private System.Windows.Forms.ColumnHeader lvwDroppedItems_DroppedBy;
        private System.Windows.Forms.ColumnHeader lvwDroppedItems_Lat;
        private System.Windows.Forms.ColumnHeader lvwDroppedItems_Lon;
        private System.Windows.Forms.ColumnHeader lvwDroppedItems_Tribe;
        private System.Windows.Forms.ColumnHeader lvwDroppedItems_Player;
        private System.Windows.Forms.ColumnHeader lvwDroppedItems_CCC;
        private System.Windows.Forms.TabPage tpgPlayers;
        private System.Windows.Forms.Button btnRconCommandPlayers;
        private ArkViewer.UI.BorderlessComboBox cboPlayerRealm;
        private System.Windows.Forms.Label lblPlayerRealm;
        private System.Windows.Forms.Panel pnlFilterPlayers;
        private System.Windows.Forms.Button btnFilterPlayer;
        private System.Windows.Forms.TextBox txtFilterPlayer;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.Label lblPlayerTotal;
        private System.Windows.Forms.Button btnCopyCommandPlayer;
        private System.Windows.Forms.Label lblCommandPlayer;
        private ArkViewer.UI.BorderlessComboBox cboConsoleCommandsPlayer;
        private System.Windows.Forms.Button btnPlayerTribeLog;
        private System.Windows.Forms.Button btnPlayerInventory;
        private System.Windows.Forms.Label lblPlayersPlayer;
        private System.Windows.Forms.Label lblPlayersTribe;
        private ArkViewer.UI.BorderlessComboBox cboTribes;
        private ArkViewer.UI.BorderlessComboBox cboPlayers;
        private System.Windows.Forms.ListView lvwPlayers;
        private System.Windows.Forms.ColumnHeader lvwPlayers_PlayerId;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Name;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Tribe;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Sex;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Level;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Lat;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Lon;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Hp;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Stam;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Melee;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Weight;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Speed;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Food;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Water;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Oxygen;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Crafting;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Fortitude;
        private System.Windows.Forms.ColumnHeader lvwPlayers_LastOnline;
        private System.Windows.Forms.ColumnHeader lvwPlayers_SteamName;
        private System.Windows.Forms.ColumnHeader lvwPlayers_SteamId;
        private System.Windows.Forms.ColumnHeader lvwPlayers_CCC;
        private System.Windows.Forms.TabPage tpgTribes;
        private System.Windows.Forms.Button btnRconCommandTribes;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvwTribes;
        private System.Windows.Forms.ColumnHeader lvwTribes_Id;
        private System.Windows.Forms.ColumnHeader lvwTribes_Name;
        private System.Windows.Forms.ColumnHeader lvwTribes_Players;
        private System.Windows.Forms.ColumnHeader lvwTribes_Tames;
        private System.Windows.Forms.ColumnHeader lvwTribes_Structures;
        private System.Windows.Forms.ColumnHeader lvwTribes_Active;
        private System.Windows.Forms.Panel pnlFilterTribes;
        private System.Windows.Forms.Button btnFilterTribe;
        private System.Windows.Forms.TextBox txtFilterTribe;
        private System.Windows.Forms.Button btnSaveChartImage;
        private System.Windows.Forms.Label lblChartTop;
        private System.Windows.Forms.NumericUpDown udChartTop;
        private System.Windows.Forms.Label lblChart;
        private ArkViewer.UI.BorderlessComboBox cboChartType;
        private System.Windows.Forms.CheckBox chkTribeStructures;
        private System.Windows.Forms.CheckBox chkTribeTames;
        private System.Windows.Forms.CheckBox chkTribePlayers;
        private System.Windows.Forms.Button btnTribeCopyCommand;
        private System.Windows.Forms.Label lblTribeCopyCommand;
        private ArkViewer.UI.BorderlessComboBox cboConsoleCommandsTribe;
        private System.Windows.Forms.Button btnTribeLog;
        private System.Windows.Forms.TabPage tpgStructures;
        private System.Windows.Forms.Button btnRconCommandStructures;
        private ArkViewer.UI.BorderlessComboBox cboStructureRealm;
        private System.Windows.Forms.Label lblStructureRealm;
        private System.Windows.Forms.Panel pnlFilterStructures;
        private System.Windows.Forms.Button btnFindStructures;
        private System.Windows.Forms.TextBox txtFilterStructures;
        private System.Windows.Forms.Button btnStructureInventory;
        private System.Windows.Forms.Label lblStructureTotal;
        private System.Windows.Forms.Button btnCopyCommandStructure;
        private System.Windows.Forms.Label lblCommandStructure;
        private ArkViewer.UI.BorderlessComboBox cboConsoleCommandsStructure;
        private System.Windows.Forms.Button btnStructureExclusionFilter;
        private System.Windows.Forms.Label lblStructureStructure;
        private ArkViewer.UI.BorderlessComboBox cboStructureStructure;
        private System.Windows.Forms.Label lblStructurePlayer;
        private System.Windows.Forms.Label lblStructureTribe;
        private ArkViewer.UI.BorderlessComboBox cboStructureTribe;
        private ArkViewer.UI.BorderlessComboBox cboStructurePlayer;
        private System.Windows.Forms.ListView lvwStructureLocations;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_Tribe;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_Structure;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_Lat;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_Lon;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_Name;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_Locked;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_Powered;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_LastTime;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_DecayReset;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_CCC;
        private System.Windows.Forms.TabPage tpgTamed;
        private System.Windows.Forms.Button btnRconCommandTamed;
        private ArkViewer.UI.BorderlessComboBox cboTameRealm;
        private System.Windows.Forms.Label lblTameRealm;
        private System.Windows.Forms.Panel pnlFilterTamed;
        private System.Windows.Forms.Button btnFindTamed;
        private System.Windows.Forms.TextBox txtFilterTamed;
        private ArkViewer.UI.BorderlessComboBox cboTamedResource;
        private System.Windows.Forms.Label lblTameResource;
        private System.Windows.Forms.Button btnCopyCommandTamed;
        private System.Windows.Forms.Label lblTamedCommand;
        private ArkViewer.UI.BorderlessComboBox cboConsoleCommandsTamed;
        private ArkViewer.UI.BorderlessComboBox cboTameTribes;
        private ArkViewer.UI.BorderlessComboBox cboTamePlayers;
        private System.Windows.Forms.Label lblTameCreature;
        private System.Windows.Forms.Label lblTamePlayer;
        private System.Windows.Forms.Label lblTameTribe;
        private System.Windows.Forms.Button btnDinoAncestors;
        private System.Windows.Forms.Button btnDinoInventory;
        private System.Windows.Forms.ListView lvwTameDetail;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Tribe;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Creature;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Name;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Sex;
        private System.Windows.Forms.ColumnHeader colTameDetail_Maturation;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Base;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Level;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Lat;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Lon;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_HP;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Stam;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Melee;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Weight;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Speed;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Food;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Oxygen;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Craft;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Server;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Tamer;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Imprinter;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Imprint;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Mating;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Wandering;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Neutered;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Cryo;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Clone;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Colour1;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Colour2;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Colour3;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Colour4;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Colour5;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Colour6;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_MutationsFemale;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_MutationsMale;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Id;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Scale;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Rig1;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Rig2;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_TribeInRange;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_UploadTime;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_DinoId;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_CCC;
        private System.Windows.Forms.Label lblTameTotal;
        private System.Windows.Forms.Panel pnlTameStatTypes;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.RadioButton optStatsTamed;
        private System.Windows.Forms.RadioButton optStatsBase;
        private ArkViewer.UI.BorderlessComboBox cboTameClass;
        private System.Windows.Forms.TabPage tpgWild;
        private System.Windows.Forms.Button btnRconCommandWild;
        private System.Windows.Forms.CheckBox chkTameable;
        private ArkViewer.UI.BorderlessComboBox cboWildRealm;
        private System.Windows.Forms.Label lblWildRealm;
        private System.Windows.Forms.Panel pnlFilterWilds;
        private System.Windows.Forms.Button btnFindWild;
        private System.Windows.Forms.TextBox txtFilterWild;
        private ArkViewer.UI.BorderlessComboBox cboWildResource;
        private System.Windows.Forms.Label lblResource;
        private System.Windows.Forms.Label lblWildRadius;
        private System.Windows.Forms.NumericUpDown udWildRadius;
        private System.Windows.Forms.Label lblWildLon;
        private System.Windows.Forms.NumericUpDown udWildLon;
        private System.Windows.Forms.Label lblWildLat;
        private System.Windows.Forms.NumericUpDown udWildLat;
        private System.Windows.Forms.Label lblWildMin;
        private System.Windows.Forms.Label lblWildMax;
        private System.Windows.Forms.NumericUpDown udWildMin;
        private System.Windows.Forms.NumericUpDown udWildMax;
        private System.Windows.Forms.Button btnCopyCommandWild;
        private System.Windows.Forms.Label lblWildCommand;
        private ArkViewer.UI.BorderlessComboBox cboConsoleCommandsWild;
        private System.Windows.Forms.Label lblSelectedWildTotal;
        private System.Windows.Forms.Label lblWildClass;
        private System.Windows.Forms.ListView lvwWildDetail;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Name;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Sex;
        private System.Windows.Forms.ColumnHeader colWildDetail_Mature;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Base;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Level;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Lat;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Lon;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_HP;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Stam;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Melee;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Weight;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Speed;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Food;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Oxygen;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Craft;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Colour1;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Colour2;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Colour3;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Colour4;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Colour5;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Colour6;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Id;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Scale;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Rig1;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Rig2;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_DinoId;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_CCC;
        private System.Windows.Forms.Label lblWildTotal;
        private ArkViewer.UI.BorderlessComboBox cboWildClass;
        private System.Windows.Forms.TabControl tabFeatures;
        private ArkViewer.ChartControl chartTribes;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_Created;
        private System.Windows.Forms.RadioButton optStatsMutated;
        private System.Windows.Forms.Label lblTameRad;
        private System.Windows.Forms.NumericUpDown udRadiusTamed;
        private System.Windows.Forms.Label lblTameLon;
        private System.Windows.Forms.NumericUpDown udLonTamed;
        private System.Windows.Forms.Label lblTameLat;
        private System.Windows.Forms.NumericUpDown udLatTamed;
        private System.Windows.Forms.Label lblStructureRad;
        private System.Windows.Forms.NumericUpDown udRadiusStructures;
        private System.Windows.Forms.Label lblStructureLon;
        private System.Windows.Forms.NumericUpDown udLonStructures;
        private System.Windows.Forms.Label lblStructureLat;
        private System.Windows.Forms.NumericUpDown udLatStructures;
        private System.Windows.Forms.Label label1;
        private ArkViewer.UI.BorderlessComboBox cboItemListPlayers;
        private System.Windows.Forms.ColumnHeader lvwItemList_ItemId;
        private System.Windows.Forms.TextBox txtItemListItemId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Trait;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Traits;
        private ArkViewer.UI.BorderlessComboBox cboWildTrait;
        private System.Windows.Forms.Label label3;
        private ArkViewer.UI.BorderlessComboBox cboTamedTrait;
        private System.Windows.Forms.Label label4;
        private ArkViewer.UI.BorderlessComboBox cboItemListFilter;
        private System.Windows.Forms.Label lblItemListFilter;
        private ArkViewer.UI.BorderlessComboBox cboTameFilter;
        private System.Windows.Forms.Label lblTameFilter;
    }
}


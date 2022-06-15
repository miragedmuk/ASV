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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewer));
            this.lvwWildDetail = new System.Windows.Forms.ListView();
            this.lvwWildDetail_Name = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Sex = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Base = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Level = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Lat = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Lon = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_HP = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Stam = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Melee = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Weight = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Speed = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Food = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Oxygen = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Craft = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Colour1 = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Colour2 = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Colour3 = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Colour4 = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Colour5 = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Colour6 = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Id = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Scale = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Rig1 = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_Rig2 = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_DinoId = new System.Windows.Forms.ColumnHeader();
            this.lvwWildDetail_CCC = new System.Windows.Forms.ColumnHeader();
            this.mnuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuContext_PlayerId = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContext_SteamId = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContext_TribeId = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContext_DinoId = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContext_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContext_Structures = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContext_Tames = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContext_Players = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWildTotal = new System.Windows.Forms.Label();
            this.lblMapDate = new System.Windows.Forms.Label();
            this.cboWildClass = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnPlayerInventory = new System.Windows.Forms.Button();
            this.btnPlayerTribeLog = new System.Windows.Forms.Button();
            this.btnStructureExclusionFilter = new System.Windows.Forms.Button();
            this.btnCopyCommandPlayer = new System.Windows.Forms.Button();
            this.btnCopyCommandStructure = new System.Windows.Forms.Button();
            this.btnDinoAncestors = new System.Windows.Forms.Button();
            this.btnDinoInventory = new System.Windows.Forms.Button();
            this.btnCopyCommandWild = new System.Windows.Forms.Button();
            this.btnCopyCommandTamed = new System.Windows.Forms.Button();
            this.chkCryo = new System.Windows.Forms.CheckBox();
            this.btnCopyCommandDropped = new System.Windows.Forms.Button();
            this.btnTribeCopyCommand = new System.Windows.Forms.Button();
            this.btnTribeLog = new System.Windows.Forms.Button();
            this.btnStructureInventory = new System.Windows.Forms.Button();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.btnDropInventory = new System.Windows.Forms.Button();
            this.btnViewMap = new System.Windows.Forms.Button();
            this.tabFeatures = new System.Windows.Forms.TabControl();
            this.tpgWild = new System.Windows.Forms.TabPage();
            this.pnlFilterWilds = new System.Windows.Forms.Panel();
            this.btnFindWild = new System.Windows.Forms.Button();
            this.txtFilterWild = new System.Windows.Forms.TextBox();
            this.cboWildResource = new System.Windows.Forms.ComboBox();
            this.lblResource = new System.Windows.Forms.Label();
            this.lblWildRadius = new System.Windows.Forms.Label();
            this.udWildRadius = new System.Windows.Forms.NumericUpDown();
            this.lblWildLon = new System.Windows.Forms.Label();
            this.udWildLon = new System.Windows.Forms.NumericUpDown();
            this.lblWildLat = new System.Windows.Forms.Label();
            this.udWildLat = new System.Windows.Forms.NumericUpDown();
            this.lblWildMin = new System.Windows.Forms.Label();
            this.lblWildMax = new System.Windows.Forms.Label();
            this.udWildMin = new System.Windows.Forms.NumericUpDown();
            this.udWildMax = new System.Windows.Forms.NumericUpDown();
            this.lblWildCommand = new System.Windows.Forms.Label();
            this.cboConsoleCommandsWild = new System.Windows.Forms.ComboBox();
            this.lblSelectedWildTotal = new System.Windows.Forms.Label();
            this.lblWildClass = new System.Windows.Forms.Label();
            this.tpgTamed = new System.Windows.Forms.TabPage();
            this.pnlFilterTamed = new System.Windows.Forms.Panel();
            this.btnFindTamed = new System.Windows.Forms.Button();
            this.txtFilterTamed = new System.Windows.Forms.TextBox();
            this.cboTamedResource = new System.Windows.Forms.ComboBox();
            this.lblTameResource = new System.Windows.Forms.Label();
            this.lblTamedCommand = new System.Windows.Forms.Label();
            this.cboConsoleCommandsTamed = new System.Windows.Forms.ComboBox();
            this.cboTameTribes = new System.Windows.Forms.ComboBox();
            this.cboTamePlayers = new System.Windows.Forms.ComboBox();
            this.lblTameCreature = new System.Windows.Forms.Label();
            this.lblTamePlayer = new System.Windows.Forms.Label();
            this.lblTameTribe = new System.Windows.Forms.Label();
            this.lvwTameDetail = new System.Windows.Forms.ListView();
            this.lvwTameDetail_Creature = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Name = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Wandering = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Mating = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Sex = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Base = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Level = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Lat = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Lon = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_HP = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Stam = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Melee = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Weight = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Speed = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Food = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Oxygen = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Craft = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Server = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Tamer = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Imprinter = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Imprint = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Cryo = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Colour1 = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Colour2 = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Colour3 = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Colour4 = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Colour5 = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Colour6 = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_MutationsFemale = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_MutationsMale = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Id = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Scale = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Rig1 = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_Rig2 = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_TribeInRange = new System.Windows.Forms.ColumnHeader();
            this.lvwTameDetail_CCC = new System.Windows.Forms.ColumnHeader();
            this.lblTameTotal = new System.Windows.Forms.Label();
            this.pnlTameStatTypes = new System.Windows.Forms.Panel();
            this.lblStats = new System.Windows.Forms.Label();
            this.optStatsTamed = new System.Windows.Forms.RadioButton();
            this.optStatsBase = new System.Windows.Forms.RadioButton();
            this.cboTameClass = new System.Windows.Forms.ComboBox();
            this.tpgStructures = new System.Windows.Forms.TabPage();
            this.pnlFilterStructures = new System.Windows.Forms.Panel();
            this.btnFindStructures = new System.Windows.Forms.Button();
            this.txtFilterStructures = new System.Windows.Forms.TextBox();
            this.lblStructureTotal = new System.Windows.Forms.Label();
            this.lblCommandStructure = new System.Windows.Forms.Label();
            this.cboConsoleCommandsStructure = new System.Windows.Forms.ComboBox();
            this.lblStructureStructure = new System.Windows.Forms.Label();
            this.cboStructureStructure = new System.Windows.Forms.ComboBox();
            this.lblStructurePlayer = new System.Windows.Forms.Label();
            this.lblStructureTribe = new System.Windows.Forms.Label();
            this.cboStructureTribe = new System.Windows.Forms.ComboBox();
            this.cboStructurePlayer = new System.Windows.Forms.ComboBox();
            this.lvwStructureLocations = new System.Windows.Forms.ListView();
            this.lvwStructureLocations_Tribe = new System.Windows.Forms.ColumnHeader();
            this.lvwStructureLocations_Structure = new System.Windows.Forms.ColumnHeader();
            this.lvwStructureLocations_Lat = new System.Windows.Forms.ColumnHeader();
            this.lvwStructureLocations_Lon = new System.Windows.Forms.ColumnHeader();
            this.lvwStructureLocations_LastTime = new System.Windows.Forms.ColumnHeader();
            this.lvwStructureLocations_DecayReset = new System.Windows.Forms.ColumnHeader();
            this.lvwStructureLocations_CCC = new System.Windows.Forms.ColumnHeader();
            this.tpgTribes = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvwTribes = new System.Windows.Forms.ListView();
            this.lvwTribes_Id = new System.Windows.Forms.ColumnHeader();
            this.lvwTribes_Name = new System.Windows.Forms.ColumnHeader();
            this.lvwTribes_Players = new System.Windows.Forms.ColumnHeader();
            this.lvwTribes_Tames = new System.Windows.Forms.ColumnHeader();
            this.lvwTribes_Structures = new System.Windows.Forms.ColumnHeader();
            this.lvwTribes_Active = new System.Windows.Forms.ColumnHeader();
            this.pnlFilterTribes = new System.Windows.Forms.Panel();
            this.btnFilterTribe = new System.Windows.Forms.Button();
            this.txtFilterTribe = new System.Windows.Forms.TextBox();
            this.btnSaveChartImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.udChartTop = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cboChartType = new System.Windows.Forms.ComboBox();
            this.chartTribes = new ArkViewer.ChartControl();
            this.chkTribeStructures = new System.Windows.Forms.CheckBox();
            this.chkTribeTames = new System.Windows.Forms.CheckBox();
            this.chkTribePlayers = new System.Windows.Forms.CheckBox();
            this.lblTribeCopyCommand = new System.Windows.Forms.Label();
            this.cboTribeCopyCommand = new System.Windows.Forms.ComboBox();
            this.tpgPlayers = new System.Windows.Forms.TabPage();
            this.pnlFilterPlayers = new System.Windows.Forms.Panel();
            this.btnFilterPlayer = new System.Windows.Forms.Button();
            this.txtFilterPlayer = new System.Windows.Forms.TextBox();
            this.lblPlayerTotal = new System.Windows.Forms.Label();
            this.lblCommandPlayer = new System.Windows.Forms.Label();
            this.cboConsoleCommandsPlayerTribe = new System.Windows.Forms.ComboBox();
            this.lblPlayersPlayer = new System.Windows.Forms.Label();
            this.lblPlayersTribe = new System.Windows.Forms.Label();
            this.cboTribes = new System.Windows.Forms.ComboBox();
            this.cboPlayers = new System.Windows.Forms.ComboBox();
            this.lvwPlayers = new System.Windows.Forms.ListView();
            this.lvwPlayers_PlayerId = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_Name = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_Tribe = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_Sex = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_Level = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_Lat = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_Lon = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_Hp = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_Stam = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_Melee = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_Weight = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_Speed = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_Food = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_Water = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_Oxygen = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_Crafting = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_Fortitude = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_LastOnline = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_SteamName = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_SteamId = new System.Windows.Forms.ColumnHeader();
            this.lvwPlayers_CCC = new System.Windows.Forms.ColumnHeader();
            this.tpgDroppedItems = new System.Windows.Forms.TabPage();
            this.pnlFilterDropped = new System.Windows.Forms.Panel();
            this.btnFindDropped = new System.Windows.Forms.Button();
            this.txtFilterDropped = new System.Windows.Forms.TextBox();
            this.chkDroppedBlueprints = new System.Windows.Forms.CheckBox();
            this.cboDroppedItem = new System.Windows.Forms.ComboBox();
            this.lblDroppedPlayer = new System.Windows.Forms.Label();
            this.cboDroppedPlayer = new System.Windows.Forms.ComboBox();
            this.lblCopyCommandDropped = new System.Windows.Forms.Label();
            this.cboCopyCommandDropped = new System.Windows.Forms.ComboBox();
            this.lblCountDropped = new System.Windows.Forms.Label();
            this.lblDroppedItem = new System.Windows.Forms.Label();
            this.lvwDroppedItems = new System.Windows.Forms.ListView();
            this.lvwDroppedItems_Item = new System.Windows.Forms.ColumnHeader();
            this.lvwDroppedItems_Bp = new System.Windows.Forms.ColumnHeader();
            this.lvwDroppedItems_DroppedBy = new System.Windows.Forms.ColumnHeader();
            this.lvwDroppedItems_Lat = new System.Windows.Forms.ColumnHeader();
            this.lvwDroppedItems_Lon = new System.Windows.Forms.ColumnHeader();
            this.lvwDroppedItems_Tribe = new System.Windows.Forms.ColumnHeader();
            this.lvwDroppedItems_Player = new System.Windows.Forms.ColumnHeader();
            this.lvwDroppedItems_CCC = new System.Windows.Forms.ColumnHeader();
            this.tpgItemList = new System.Windows.Forms.TabPage();
            this.pnlFilterSearch = new System.Windows.Forms.Panel();
            this.btnFindSearched = new System.Windows.Forms.Button();
            this.txtFilterSearch = new System.Windows.Forms.TextBox();
            this.chkItemSearchBlueprints = new System.Windows.Forms.CheckBox();
            this.cboItemListItem = new System.Windows.Forms.ComboBox();
            this.lblItemListTribe = new System.Windows.Forms.Label();
            this.cboItemListTribe = new System.Windows.Forms.ComboBox();
            this.btnItemListCommand = new System.Windows.Forms.Button();
            this.lblItemListCommand = new System.Windows.Forms.Label();
            this.cboItemListCommand = new System.Windows.Forms.ComboBox();
            this.lblItemListCount = new System.Windows.Forms.Label();
            this.lblItemListItem = new System.Windows.Forms.Label();
            this.lvwItemList = new System.Windows.Forms.ListView();
            this.lvwItemList_Tribe = new System.Windows.Forms.ColumnHeader();
            this.lvwItemList_Container = new System.Windows.Forms.ColumnHeader();
            this.lvwItemList_Item = new System.Windows.Forms.ColumnHeader();
            this.lvwItemList_Quality = new System.Windows.Forms.ColumnHeader();
            this.lvwItemList_Rating = new System.Windows.Forms.ColumnHeader();
            this.lvwItemList_BP = new System.Windows.Forms.ColumnHeader();
            this.lvwItemList_Quantity = new System.Windows.Forms.ColumnHeader();
            this.lvwItemList_Lat = new System.Windows.Forms.ColumnHeader();
            this.lvwItemList_Lon = new System.Windows.Forms.ColumnHeader();
            this.lvwItemList_CCC = new System.Windows.Forms.ColumnHeader();
            this.tpgLocalProfile = new System.Windows.Forms.TabPage();
            this.pnlUploadedStats = new System.Windows.Forms.Panel();
            this.lblUploadedStats = new System.Windows.Forms.Label();
            this.optUploadedStatsTamed = new System.Windows.Forms.RadioButton();
            this.optUploadedStatsBase = new System.Windows.Forms.RadioButton();
            this.lblUploadedCountItems = new System.Windows.Forms.Label();
            this.lblUploadedCountTames = new System.Windows.Forms.Label();
            this.lblUploadedCountCharacters = new System.Windows.Forms.Label();
            this.lblUploadedItems = new System.Windows.Forms.Label();
            this.lvwUploadedItems = new System.Windows.Forms.ListView();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader22 = new System.Windows.Forms.ColumnHeader();
            this.lblUploadedTames = new System.Windows.Forms.Label();
            this.lblUploadedCharacters = new System.Windows.Forms.Label();
            this.lvwUploadedCharacters = new System.Windows.Forms.ListView();
            this.columnHeader37 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader39 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader40 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader43 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader44 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader45 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader46 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader47 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader48 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader49 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader50 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader51 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader52 = new System.Windows.Forms.ColumnHeader();
            this.lvwUploadedTames = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader20 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader21 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader23 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader24 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader25 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader26 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader27 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader28 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader29 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader30 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader33 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader34 = new System.Windows.Forms.ColumnHeader();
            this.tpgLeaderboard = new System.Windows.Forms.TabPage();
            this.cboLeaderboardPlayer = new System.Windows.Forms.ComboBox();
            this.lblMissionPlayer = new System.Windows.Forms.Label();
            this.lvwLeaderboardSummary = new System.Windows.Forms.ListView();
            this.columnHeader32 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader35 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader36 = new System.Windows.Forms.ColumnHeader();
            this.lvwLeaderboard = new System.Windows.Forms.ListView();
            this.lvwLeaderboard_Mission = new System.Windows.Forms.ColumnHeader();
            this.lvwLeaderboard_Tribe = new System.Windows.Forms.ColumnHeader();
            this.lvwLeaderboard_Player = new System.Windows.Forms.ColumnHeader();
            this.lvwLeaderboard_Score = new System.Windows.Forms.ColumnHeader();
            this.cboLeaderboardMission = new System.Windows.Forms.ComboBox();
            this.lblLeaderboardMission = new System.Windows.Forms.Label();
            this.cboLeaderboardTribe = new System.Windows.Forms.ComboBox();
            this.lblLeaderboardTribe = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblMapTypeName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblMap = new System.Windows.Forms.Label();
            this.cboSelectedMap = new System.Windows.Forms.ComboBox();
            this.mnuContext.SuspendLayout();
            this.tabFeatures.SuspendLayout();
            this.tpgWild.SuspendLayout();
            this.pnlFilterWilds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udWildRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWildLon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWildLat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWildMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWildMax)).BeginInit();
            this.tpgTamed.SuspendLayout();
            this.pnlFilterTamed.SuspendLayout();
            this.pnlTameStatTypes.SuspendLayout();
            this.tpgStructures.SuspendLayout();
            this.pnlFilterStructures.SuspendLayout();
            this.tpgTribes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlFilterTribes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udChartTop)).BeginInit();
            this.tpgPlayers.SuspendLayout();
            this.pnlFilterPlayers.SuspendLayout();
            this.tpgDroppedItems.SuspendLayout();
            this.pnlFilterDropped.SuspendLayout();
            this.tpgItemList.SuspendLayout();
            this.pnlFilterSearch.SuspendLayout();
            this.tpgLocalProfile.SuspendLayout();
            this.pnlUploadedStats.SuspendLayout();
            this.tpgLeaderboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwWildDetail
            // 
            this.lvwWildDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwWildDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwWildDetail_Name,
            this.lvwWildDetail_Sex,
            this.lvwWildDetail_Base,
            this.lvwWildDetail_Level,
            this.lvwWildDetail_Lat,
            this.lvwWildDetail_Lon,
            this.lvwWildDetail_HP,
            this.lvwWildDetail_Stam,
            this.lvwWildDetail_Melee,
            this.lvwWildDetail_Weight,
            this.lvwWildDetail_Speed,
            this.lvwWildDetail_Food,
            this.lvwWildDetail_Oxygen,
            this.lvwWildDetail_Craft,
            this.lvwWildDetail_Colour1,
            this.lvwWildDetail_Colour2,
            this.lvwWildDetail_Colour3,
            this.lvwWildDetail_Colour4,
            this.lvwWildDetail_Colour5,
            this.lvwWildDetail_Colour6,
            this.lvwWildDetail_Id,
            this.lvwWildDetail_Scale,
            this.lvwWildDetail_Rig1,
            this.lvwWildDetail_Rig2,
            this.lvwWildDetail_DinoId,
            this.lvwWildDetail_CCC});
            this.lvwWildDetail.ContextMenuStrip = this.mnuContext;
            this.lvwWildDetail.FullRowSelect = true;
            this.lvwWildDetail.Location = new System.Drawing.Point(13, 89);
            this.lvwWildDetail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwWildDetail.MultiSelect = false;
            this.lvwWildDetail.Name = "lvwWildDetail";
            this.lvwWildDetail.Size = new System.Drawing.Size(1073, 333);
            this.lvwWildDetail.TabIndex = 14;
            this.lvwWildDetail.UseCompatibleStateImageBehavior = false;
            this.lvwWildDetail.View = System.Windows.Forms.View.Details;
            this.lvwWildDetail.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwWildDetail_ColumnClick);
            this.lvwWildDetail.SelectedIndexChanged += new System.EventHandler(this.LvwWildDetail_SelectedIndexChanged);
            this.lvwWildDetail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwWildDetail_MouseClick);
            // 
            // lvwWildDetail_Name
            // 
            this.lvwWildDetail_Name.Text = "Creature";
            this.lvwWildDetail_Name.Width = 142;
            // 
            // lvwWildDetail_Sex
            // 
            this.lvwWildDetail_Sex.Text = "Sex";
            this.lvwWildDetail_Sex.Width = 52;
            // 
            // lvwWildDetail_Base
            // 
            this.lvwWildDetail_Base.Text = "Base";
            this.lvwWildDetail_Base.Width = 0;
            // 
            // lvwWildDetail_Level
            // 
            this.lvwWildDetail_Level.Text = "Lvl";
            this.lvwWildDetail_Level.Width = 40;
            // 
            // lvwWildDetail_Lat
            // 
            this.lvwWildDetail_Lat.Text = "Lat";
            this.lvwWildDetail_Lat.Width = 51;
            // 
            // lvwWildDetail_Lon
            // 
            this.lvwWildDetail_Lon.Text = "Lon";
            this.lvwWildDetail_Lon.Width = 40;
            // 
            // lvwWildDetail_HP
            // 
            this.lvwWildDetail_HP.Text = "HP";
            this.lvwWildDetail_HP.Width = 45;
            // 
            // lvwWildDetail_Stam
            // 
            this.lvwWildDetail_Stam.Text = "Stam";
            this.lvwWildDetail_Stam.Width = 45;
            // 
            // lvwWildDetail_Melee
            // 
            this.lvwWildDetail_Melee.Text = "Melee";
            this.lvwWildDetail_Melee.Width = 48;
            // 
            // lvwWildDetail_Weight
            // 
            this.lvwWildDetail_Weight.Text = "Weight";
            this.lvwWildDetail_Weight.Width = 55;
            // 
            // lvwWildDetail_Speed
            // 
            this.lvwWildDetail_Speed.Text = "Speed";
            this.lvwWildDetail_Speed.Width = 50;
            // 
            // lvwWildDetail_Food
            // 
            this.lvwWildDetail_Food.Text = "Food";
            this.lvwWildDetail_Food.Width = 47;
            // 
            // lvwWildDetail_Oxygen
            // 
            this.lvwWildDetail_Oxygen.Text = "Oxygen";
            this.lvwWildDetail_Oxygen.Width = 53;
            // 
            // lvwWildDetail_Craft
            // 
            this.lvwWildDetail_Craft.Text = "Craft";
            this.lvwWildDetail_Craft.Width = 50;
            // 
            // lvwWildDetail_Colour1
            // 
            this.lvwWildDetail_Colour1.Text = "C0";
            this.lvwWildDetail_Colour1.Width = 35;
            // 
            // lvwWildDetail_Colour2
            // 
            this.lvwWildDetail_Colour2.Text = "C1";
            this.lvwWildDetail_Colour2.Width = 35;
            // 
            // lvwWildDetail_Colour3
            // 
            this.lvwWildDetail_Colour3.Text = "C2";
            this.lvwWildDetail_Colour3.Width = 35;
            // 
            // lvwWildDetail_Colour4
            // 
            this.lvwWildDetail_Colour4.Text = "C3";
            this.lvwWildDetail_Colour4.Width = 35;
            // 
            // lvwWildDetail_Colour5
            // 
            this.lvwWildDetail_Colour5.Text = "C4";
            this.lvwWildDetail_Colour5.Width = 35;
            // 
            // lvwWildDetail_Colour6
            // 
            this.lvwWildDetail_Colour6.Text = "C5";
            this.lvwWildDetail_Colour6.Width = 35;
            // 
            // lvwWildDetail_Id
            // 
            this.lvwWildDetail_Id.Text = "Id";
            this.lvwWildDetail_Id.Width = 0;
            // 
            // lvwWildDetail_Scale
            // 
            this.lvwWildDetail_Scale.Text = "Scale";
            // 
            // lvwWildDetail_Rig1
            // 
            this.lvwWildDetail_Rig1.Text = "Rig 1";
            this.lvwWildDetail_Rig1.Width = 100;
            // 
            // lvwWildDetail_Rig2
            // 
            this.lvwWildDetail_Rig2.Text = "Rig 2";
            this.lvwWildDetail_Rig2.Width = 100;
            // 
            // lvwWildDetail_DinoId
            // 
            this.lvwWildDetail_DinoId.Text = "DinoId";
            this.lvwWildDetail_DinoId.Width = 0;
            // 
            // lvwWildDetail_CCC
            // 
            this.lvwWildDetail_CCC.Text = "CCC";
            this.lvwWildDetail_CCC.Width = 0;
            // 
            // mnuContext
            // 
            this.mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContext_PlayerId,
            this.mnuContext_SteamId,
            this.mnuContext_TribeId,
            this.mnuContext_DinoId,
            this.mnuContext_Export,
            this.mnuContext_Structures,
            this.mnuContext_Tames,
            this.mnuContext_Players});
            this.mnuContext.Name = "mnuContext";
            this.mnuContext.Size = new System.Drawing.Size(156, 180);
            // 
            // mnuContext_PlayerId
            // 
            this.mnuContext_PlayerId.Name = "mnuContext_PlayerId";
            this.mnuContext_PlayerId.Size = new System.Drawing.Size(155, 22);
            this.mnuContext_PlayerId.Text = "Copy Player ID";
            this.mnuContext_PlayerId.Click += new System.EventHandler(this.mnuContext_PlayerId_Click);
            // 
            // mnuContext_SteamId
            // 
            this.mnuContext_SteamId.Name = "mnuContext_SteamId";
            this.mnuContext_SteamId.Size = new System.Drawing.Size(155, 22);
            this.mnuContext_SteamId.Text = "Copy Steam ID";
            this.mnuContext_SteamId.Click += new System.EventHandler(this.mnuContext_SteamId_Click);
            // 
            // mnuContext_TribeId
            // 
            this.mnuContext_TribeId.Name = "mnuContext_TribeId";
            this.mnuContext_TribeId.Size = new System.Drawing.Size(155, 22);
            this.mnuContext_TribeId.Text = "Copy Tribe ID";
            this.mnuContext_TribeId.Click += new System.EventHandler(this.mnuContext_TribeId_Click);
            // 
            // mnuContext_DinoId
            // 
            this.mnuContext_DinoId.Name = "mnuContext_DinoId";
            this.mnuContext_DinoId.Size = new System.Drawing.Size(155, 22);
            this.mnuContext_DinoId.Text = "Copy DinoId";
            this.mnuContext_DinoId.Click += new System.EventHandler(this.mnuContext_DinoId_Click);
            // 
            // mnuContext_Export
            // 
            this.mnuContext_Export.Name = "mnuContext_Export";
            this.mnuContext_Export.Size = new System.Drawing.Size(155, 22);
            this.mnuContext_Export.Text = "Export Data";
            this.mnuContext_Export.Click += new System.EventHandler(this.mnuContext_ExportData_Click);
            // 
            // mnuContext_Structures
            // 
            this.mnuContext_Structures.Name = "mnuContext_Structures";
            this.mnuContext_Structures.Size = new System.Drawing.Size(155, 22);
            this.mnuContext_Structures.Text = "View Structures";
            this.mnuContext_Structures.Visible = false;
            this.mnuContext_Structures.Click += new System.EventHandler(this.mnuContext_Structures_Click);
            // 
            // mnuContext_Tames
            // 
            this.mnuContext_Tames.Name = "mnuContext_Tames";
            this.mnuContext_Tames.Size = new System.Drawing.Size(155, 22);
            this.mnuContext_Tames.Text = "View Tames";
            this.mnuContext_Tames.Visible = false;
            this.mnuContext_Tames.Click += new System.EventHandler(this.mnuContext_Tames_Click);
            // 
            // mnuContext_Players
            // 
            this.mnuContext_Players.Name = "mnuContext_Players";
            this.mnuContext_Players.Size = new System.Drawing.Size(155, 22);
            this.mnuContext_Players.Text = "View Players";
            this.mnuContext_Players.Visible = false;
            this.mnuContext_Players.Click += new System.EventHandler(this.mnuContext_Players_Click);
            // 
            // lblWildTotal
            // 
            this.lblWildTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWildTotal.BackColor = System.Drawing.Color.AliceBlue;
            this.lblWildTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWildTotal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWildTotal.Location = new System.Drawing.Point(936, 471);
            this.lblWildTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWildTotal.Name = "lblWildTotal";
            this.lblWildTotal.Size = new System.Drawing.Size(152, 35);
            this.lblWildTotal.TabIndex = 19;
            this.lblWildTotal.Text = "Total: 0";
            this.lblWildTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMapDate
            // 
            this.lblMapDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMapDate.BackColor = System.Drawing.Color.Transparent;
            this.lblMapDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMapDate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMapDate.Location = new System.Drawing.Point(737, 6);
            this.lblMapDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMapDate.Name = "lblMapDate";
            this.lblMapDate.Size = new System.Drawing.Size(383, 21);
            this.lblMapDate.TabIndex = 3;
            this.lblMapDate.Text = "No Map Loaded";
            this.lblMapDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboWildClass
            // 
            this.cboWildClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboWildClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboWildClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWildClass.FormattingEnabled = true;
            this.cboWildClass.Location = new System.Drawing.Point(88, 57);
            this.cboWildClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboWildClass.Name = "cboWildClass";
            this.cboWildClass.Size = new System.Drawing.Size(688, 24);
            this.cboWildClass.TabIndex = 13;
            this.cboWildClass.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboSelected_DrawItem);
            this.cboWildClass.SelectedIndexChanged += new System.EventHandler(this.CboWildClass_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(931, 635);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(58, 58);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRefresh, "Refresh loaded map.");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(1062, 635);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(58, 58);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSettings, "Show available settings.");
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPlayerInventory
            // 
            this.btnPlayerInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlayerInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayerInventory.Enabled = false;
            this.btnPlayerInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayerInventory.Image")));
            this.btnPlayerInventory.Location = new System.Drawing.Point(509, 463);
            this.btnPlayerInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlayerInventory.Name = "btnPlayerInventory";
            this.btnPlayerInventory.Size = new System.Drawing.Size(47, 46);
            this.btnPlayerInventory.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnPlayerInventory, "Show player explorer.");
            this.btnPlayerInventory.UseVisualStyleBackColor = true;
            this.btnPlayerInventory.Click += new System.EventHandler(this.btnPlayerInventory_Click);
            // 
            // btnPlayerTribeLog
            // 
            this.btnPlayerTribeLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlayerTribeLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayerTribeLog.Enabled = false;
            this.btnPlayerTribeLog.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayerTribeLog.Image")));
            this.btnPlayerTribeLog.Location = new System.Drawing.Point(458, 463);
            this.btnPlayerTribeLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlayerTribeLog.Name = "btnPlayerTribeLog";
            this.btnPlayerTribeLog.Size = new System.Drawing.Size(47, 46);
            this.btnPlayerTribeLog.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnPlayerTribeLog, "View tribe log.");
            this.btnPlayerTribeLog.UseVisualStyleBackColor = true;
            this.btnPlayerTribeLog.Click += new System.EventHandler(this.btnPlayerTribeLog_Click);
            // 
            // btnStructureExclusionFilter
            // 
            this.btnStructureExclusionFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStructureExclusionFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStructureExclusionFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnStructureExclusionFilter.Image")));
            this.btnStructureExclusionFilter.Location = new System.Drawing.Point(1040, 8);
            this.btnStructureExclusionFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStructureExclusionFilter.Name = "btnStructureExclusionFilter";
            this.btnStructureExclusionFilter.Size = new System.Drawing.Size(47, 46);
            this.btnStructureExclusionFilter.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnStructureExclusionFilter, "Structure exclusion list");
            this.btnStructureExclusionFilter.UseVisualStyleBackColor = true;
            this.btnStructureExclusionFilter.Click += new System.EventHandler(this.btnStructureExclusionFilter_Click);
            // 
            // btnCopyCommandPlayer
            // 
            this.btnCopyCommandPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyCommandPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyCommandPlayer.Enabled = false;
            this.btnCopyCommandPlayer.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyCommandPlayer.Image")));
            this.btnCopyCommandPlayer.Location = new System.Drawing.Point(408, 463);
            this.btnCopyCommandPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopyCommandPlayer.Name = "btnCopyCommandPlayer";
            this.btnCopyCommandPlayer.Size = new System.Drawing.Size(47, 46);
            this.btnCopyCommandPlayer.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnCopyCommandPlayer, "Copy command to clipboard.");
            this.btnCopyCommandPlayer.UseVisualStyleBackColor = true;
            this.btnCopyCommandPlayer.Click += new System.EventHandler(this.btnCopyCommandPlayer_Click);
            // 
            // btnCopyCommandStructure
            // 
            this.btnCopyCommandStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyCommandStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyCommandStructure.Enabled = false;
            this.btnCopyCommandStructure.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyCommandStructure.Image")));
            this.btnCopyCommandStructure.Location = new System.Drawing.Point(402, 466);
            this.btnCopyCommandStructure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopyCommandStructure.Name = "btnCopyCommandStructure";
            this.btnCopyCommandStructure.Size = new System.Drawing.Size(47, 46);
            this.btnCopyCommandStructure.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnCopyCommandStructure, "Copy command to clipboard.");
            this.btnCopyCommandStructure.UseVisualStyleBackColor = true;
            this.btnCopyCommandStructure.Click += new System.EventHandler(this.btnCopyCommandStructure_Click);
            // 
            // btnDinoAncestors
            // 
            this.btnDinoAncestors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDinoAncestors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDinoAncestors.Enabled = false;
            this.btnDinoAncestors.Image = ((System.Drawing.Image)(resources.GetObject("btnDinoAncestors.Image")));
            this.btnDinoAncestors.Location = new System.Drawing.Point(656, 465);
            this.btnDinoAncestors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDinoAncestors.Name = "btnDinoAncestors";
            this.btnDinoAncestors.Size = new System.Drawing.Size(47, 46);
            this.btnDinoAncestors.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnDinoAncestors, "View breeding lines.");
            this.btnDinoAncestors.UseVisualStyleBackColor = true;
            this.btnDinoAncestors.Click += new System.EventHandler(this.btnDinoAncestors_Click);
            // 
            // btnDinoInventory
            // 
            this.btnDinoInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDinoInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDinoInventory.Enabled = false;
            this.btnDinoInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnDinoInventory.Image")));
            this.btnDinoInventory.Location = new System.Drawing.Point(707, 465);
            this.btnDinoInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDinoInventory.Name = "btnDinoInventory";
            this.btnDinoInventory.Size = new System.Drawing.Size(47, 46);
            this.btnDinoInventory.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnDinoInventory, "View inventory.");
            this.btnDinoInventory.UseVisualStyleBackColor = true;
            this.btnDinoInventory.Click += new System.EventHandler(this.btnDinoInventory_Click);
            // 
            // btnCopyCommandWild
            // 
            this.btnCopyCommandWild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyCommandWild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyCommandWild.Enabled = false;
            this.btnCopyCommandWild.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyCommandWild.Image")));
            this.btnCopyCommandWild.Location = new System.Drawing.Point(408, 465);
            this.btnCopyCommandWild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopyCommandWild.Name = "btnCopyCommandWild";
            this.btnCopyCommandWild.Size = new System.Drawing.Size(47, 46);
            this.btnCopyCommandWild.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnCopyCommandWild, "Copy command to clipboard.");
            this.btnCopyCommandWild.UseVisualStyleBackColor = true;
            this.btnCopyCommandWild.Click += new System.EventHandler(this.btnCopyCommandWild_Click);
            // 
            // btnCopyCommandTamed
            // 
            this.btnCopyCommandTamed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyCommandTamed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyCommandTamed.Enabled = false;
            this.btnCopyCommandTamed.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyCommandTamed.Image")));
            this.btnCopyCommandTamed.Location = new System.Drawing.Point(604, 465);
            this.btnCopyCommandTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopyCommandTamed.Name = "btnCopyCommandTamed";
            this.btnCopyCommandTamed.Size = new System.Drawing.Size(47, 46);
            this.btnCopyCommandTamed.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnCopyCommandTamed, "Copy command to clipboard.");
            this.btnCopyCommandTamed.UseVisualStyleBackColor = true;
            this.btnCopyCommandTamed.Click += new System.EventHandler(this.btnCopyCommandTamed_Click);
            // 
            // chkCryo
            // 
            this.chkCryo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCryo.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCryo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkCryo.BackgroundImage")));
            this.chkCryo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkCryo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCryo.Location = new System.Drawing.Point(1040, 24);
            this.chkCryo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCryo.Name = "chkCryo";
            this.chkCryo.Size = new System.Drawing.Size(47, 46);
            this.chkCryo.TabIndex = 6;
            this.toolTip1.SetToolTip(this.chkCryo, "Show / hide stored tames.");
            this.chkCryo.UseVisualStyleBackColor = true;
            this.chkCryo.CheckedChanged += new System.EventHandler(this.chkCryo_CheckedChanged);
            // 
            // btnCopyCommandDropped
            // 
            this.btnCopyCommandDropped.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyCommandDropped.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyCommandDropped.Enabled = false;
            this.btnCopyCommandDropped.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyCommandDropped.Image")));
            this.btnCopyCommandDropped.Location = new System.Drawing.Point(408, 466);
            this.btnCopyCommandDropped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopyCommandDropped.Name = "btnCopyCommandDropped";
            this.btnCopyCommandDropped.Size = new System.Drawing.Size(47, 46);
            this.btnCopyCommandDropped.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnCopyCommandDropped, "Copy command to clipboard.");
            this.btnCopyCommandDropped.UseVisualStyleBackColor = true;
            this.btnCopyCommandDropped.Click += new System.EventHandler(this.btnCopyCommandDropped_Click);
            // 
            // btnTribeCopyCommand
            // 
            this.btnTribeCopyCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTribeCopyCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTribeCopyCommand.Enabled = false;
            this.btnTribeCopyCommand.Image = ((System.Drawing.Image)(resources.GetObject("btnTribeCopyCommand.Image")));
            this.btnTribeCopyCommand.Location = new System.Drawing.Point(408, 464);
            this.btnTribeCopyCommand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTribeCopyCommand.Name = "btnTribeCopyCommand";
            this.btnTribeCopyCommand.Size = new System.Drawing.Size(47, 46);
            this.btnTribeCopyCommand.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnTribeCopyCommand, "Copy command to clipboard.");
            this.btnTribeCopyCommand.UseVisualStyleBackColor = true;
            this.btnTribeCopyCommand.Click += new System.EventHandler(this.btnTribeCopyCommand_Click);
            // 
            // btnTribeLog
            // 
            this.btnTribeLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTribeLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTribeLog.Enabled = false;
            this.btnTribeLog.Image = ((System.Drawing.Image)(resources.GetObject("btnTribeLog.Image")));
            this.btnTribeLog.Location = new System.Drawing.Point(460, 464);
            this.btnTribeLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTribeLog.Name = "btnTribeLog";
            this.btnTribeLog.Size = new System.Drawing.Size(47, 46);
            this.btnTribeLog.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnTribeLog, "View tribe log.");
            this.btnTribeLog.UseVisualStyleBackColor = true;
            this.btnTribeLog.Click += new System.EventHandler(this.btnTribeLog_Click);
            // 
            // btnStructureInventory
            // 
            this.btnStructureInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStructureInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStructureInventory.Enabled = false;
            this.btnStructureInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnStructureInventory.Image")));
            this.btnStructureInventory.Location = new System.Drawing.Point(453, 466);
            this.btnStructureInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStructureInventory.Name = "btnStructureInventory";
            this.btnStructureInventory.Size = new System.Drawing.Size(47, 46);
            this.btnStructureInventory.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnStructureInventory, "View inventory.");
            this.btnStructureInventory.UseVisualStyleBackColor = true;
            this.btnStructureInventory.Click += new System.EventHandler(this.btnStructureInventory_Click);
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeletePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePlayer.Enabled = false;
            this.btnDeletePlayer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePlayer.Image")));
            this.btnDeletePlayer.Location = new System.Drawing.Point(559, 463);
            this.btnDeletePlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(47, 46);
            this.btnDeletePlayer.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnDeletePlayer, "Remove player.");
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // btnDropInventory
            // 
            this.btnDropInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDropInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDropInventory.Enabled = false;
            this.btnDropInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnDropInventory.Image")));
            this.btnDropInventory.Location = new System.Drawing.Point(460, 466);
            this.btnDropInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDropInventory.Name = "btnDropInventory";
            this.btnDropInventory.Size = new System.Drawing.Size(47, 46);
            this.btnDropInventory.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnDropInventory, "View inventory.");
            this.btnDropInventory.UseVisualStyleBackColor = true;
            this.btnDropInventory.Click += new System.EventHandler(this.btnDropInventory_Click);
            // 
            // btnViewMap
            // 
            this.btnViewMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMap.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMap.Image")));
            this.btnViewMap.Location = new System.Drawing.Point(996, 635);
            this.btnViewMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViewMap.Name = "btnViewMap";
            this.btnViewMap.Size = new System.Drawing.Size(58, 58);
            this.btnViewMap.TabIndex = 3;
            this.btnViewMap.TabStop = false;
            this.toolTip1.SetToolTip(this.btnViewMap, "Show map image view.");
            this.btnViewMap.UseVisualStyleBackColor = true;
            this.btnViewMap.Click += new System.EventHandler(this.btnViewMap_Click);
            // 
            // tabFeatures
            // 
            this.tabFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabFeatures.Controls.Add(this.tpgWild);
            this.tabFeatures.Controls.Add(this.tpgTamed);
            this.tabFeatures.Controls.Add(this.tpgStructures);
            this.tabFeatures.Controls.Add(this.tpgTribes);
            this.tabFeatures.Controls.Add(this.tpgPlayers);
            this.tabFeatures.Controls.Add(this.tpgDroppedItems);
            this.tabFeatures.Controls.Add(this.tpgItemList);
            this.tabFeatures.Controls.Add(this.tpgLocalProfile);
            this.tabFeatures.Controls.Add(this.tpgLeaderboard);
            this.tabFeatures.HotTrack = true;
            this.tabFeatures.Location = new System.Drawing.Point(10, 80);
            this.tabFeatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabFeatures.Name = "tabFeatures";
            this.tabFeatures.SelectedIndex = 0;
            this.tabFeatures.Size = new System.Drawing.Size(1112, 548);
            this.tabFeatures.TabIndex = 0;
            this.tabFeatures.SelectedIndexChanged += new System.EventHandler(this.tabFeatures_SelectedIndexChanged);
            // 
            // tpgWild
            // 
            this.tpgWild.Controls.Add(this.pnlFilterWilds);
            this.tpgWild.Controls.Add(this.cboWildResource);
            this.tpgWild.Controls.Add(this.lblResource);
            this.tpgWild.Controls.Add(this.lblWildRadius);
            this.tpgWild.Controls.Add(this.udWildRadius);
            this.tpgWild.Controls.Add(this.lblWildLon);
            this.tpgWild.Controls.Add(this.udWildLon);
            this.tpgWild.Controls.Add(this.lblWildLat);
            this.tpgWild.Controls.Add(this.udWildLat);
            this.tpgWild.Controls.Add(this.lblWildMin);
            this.tpgWild.Controls.Add(this.lblWildMax);
            this.tpgWild.Controls.Add(this.udWildMin);
            this.tpgWild.Controls.Add(this.udWildMax);
            this.tpgWild.Controls.Add(this.btnCopyCommandWild);
            this.tpgWild.Controls.Add(this.lblWildCommand);
            this.tpgWild.Controls.Add(this.cboConsoleCommandsWild);
            this.tpgWild.Controls.Add(this.lblSelectedWildTotal);
            this.tpgWild.Controls.Add(this.lblWildClass);
            this.tpgWild.Controls.Add(this.lvwWildDetail);
            this.tpgWild.Controls.Add(this.lblWildTotal);
            this.tpgWild.Controls.Add(this.cboWildClass);
            this.tpgWild.Location = new System.Drawing.Point(4, 24);
            this.tpgWild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgWild.Name = "tpgWild";
            this.tpgWild.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgWild.Size = new System.Drawing.Size(1104, 520);
            this.tpgWild.TabIndex = 0;
            this.tpgWild.Text = "Wild Creatures";
            this.tpgWild.UseVisualStyleBackColor = true;
            // 
            // pnlFilterWilds
            // 
            this.pnlFilterWilds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilterWilds.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlFilterWilds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterWilds.Controls.Add(this.btnFindWild);
            this.pnlFilterWilds.Controls.Add(this.txtFilterWild);
            this.pnlFilterWilds.Location = new System.Drawing.Point(13, 421);
            this.pnlFilterWilds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFilterWilds.Name = "pnlFilterWilds";
            this.pnlFilterWilds.Size = new System.Drawing.Size(1073, 33);
            this.pnlFilterWilds.TabIndex = 20;
            // 
            // btnFindWild
            // 
            this.btnFindWild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindWild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindWild.Image = ((System.Drawing.Image)(resources.GetObject("btnFindWild.Image")));
            this.btnFindWild.Location = new System.Drawing.Point(1037, -1);
            this.btnFindWild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFindWild.Name = "btnFindWild";
            this.btnFindWild.Size = new System.Drawing.Size(35, 33);
            this.btnFindWild.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnFindWild, "Find next");
            this.btnFindWild.UseVisualStyleBackColor = true;
            this.btnFindWild.Click += new System.EventHandler(this.btnFindWild_Click);
            // 
            // txtFilterWild
            // 
            this.txtFilterWild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterWild.Location = new System.Drawing.Point(12, 3);
            this.txtFilterWild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilterWild.Name = "txtFilterWild";
            this.txtFilterWild.Size = new System.Drawing.Size(1013, 23);
            this.txtFilterWild.TabIndex = 6;
            this.txtFilterWild.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterWild_KeyDown);
            // 
            // cboWildResource
            // 
            this.cboWildResource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboWildResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWildResource.FormattingEnabled = true;
            this.cboWildResource.Location = new System.Drawing.Point(863, 55);
            this.cboWildResource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboWildResource.Name = "cboWildResource";
            this.cboWildResource.Size = new System.Drawing.Size(222, 23);
            this.cboWildResource.TabIndex = 11;
            this.cboWildResource.SelectedIndexChanged += new System.EventHandler(this.cboWildResource_SelectedIndexChanged);
            // 
            // lblResource
            // 
            this.lblResource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResource.AutoSize = true;
            this.lblResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResource.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblResource.Location = new System.Drawing.Point(786, 60);
            this.lblResource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResource.Name = "lblResource";
            this.lblResource.Size = new System.Drawing.Size(65, 13);
            this.lblResource.TabIndex = 10;
            this.lblResource.Text = "Resource:";
            // 
            // lblWildRadius
            // 
            this.lblWildRadius.AutoSize = true;
            this.lblWildRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWildRadius.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWildRadius.Location = new System.Drawing.Point(490, 20);
            this.lblWildRadius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWildRadius.Name = "lblWildRadius";
            this.lblWildRadius.Size = new System.Drawing.Size(50, 13);
            this.lblWildRadius.TabIndex = 8;
            this.lblWildRadius.Text = "Radius:";
            // 
            // udWildRadius
            // 
            this.udWildRadius.DecimalPlaces = 2;
            this.udWildRadius.Location = new System.Drawing.Point(553, 16);
            this.udWildRadius.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udWildRadius.Name = "udWildRadius";
            this.udWildRadius.Size = new System.Drawing.Size(75, 23);
            this.udWildRadius.TabIndex = 9;
            this.udWildRadius.Value = new decimal(new int[] {
            10000,
            0,
            0,
            131072});
            this.udWildRadius.ValueChanged += new System.EventHandler(this.udWildRadius_ValueChanged);
            this.udWildRadius.Enter += new System.EventHandler(this.udWildRadius_Enter);
            this.udWildRadius.MouseClick += new System.Windows.Forms.MouseEventHandler(this.udWildRadius_MouseClick);
            // 
            // lblWildLon
            // 
            this.lblWildLon.AutoSize = true;
            this.lblWildLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWildLon.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWildLon.Location = new System.Drawing.Point(371, 20);
            this.lblWildLon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWildLon.Name = "lblWildLon";
            this.lblWildLon.Size = new System.Drawing.Size(32, 13);
            this.lblWildLon.TabIndex = 6;
            this.lblWildLon.Text = "Lon:";
            // 
            // udWildLon
            // 
            this.udWildLon.DecimalPlaces = 2;
            this.udWildLon.Location = new System.Drawing.Point(413, 16);
            this.udWildLon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udWildLon.Name = "udWildLon";
            this.udWildLon.Size = new System.Drawing.Size(75, 23);
            this.udWildLon.TabIndex = 7;
            this.udWildLon.Value = new decimal(new int[] {
            5000,
            0,
            0,
            131072});
            this.udWildLon.ValueChanged += new System.EventHandler(this.udWildLon_ValueChanged);
            this.udWildLon.Enter += new System.EventHandler(this.udWildLon_Enter);
            this.udWildLon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.udWildLon_MouseClick);
            // 
            // lblWildLat
            // 
            this.lblWildLat.AutoSize = true;
            this.lblWildLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWildLat.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWildLat.Location = new System.Drawing.Point(251, 20);
            this.lblWildLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWildLat.Name = "lblWildLat";
            this.lblWildLat.Size = new System.Drawing.Size(29, 13);
            this.lblWildLat.TabIndex = 4;
            this.lblWildLat.Text = "Lat:";
            // 
            // udWildLat
            // 
            this.udWildLat.DecimalPlaces = 2;
            this.udWildLat.Location = new System.Drawing.Point(293, 16);
            this.udWildLat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udWildLat.Name = "udWildLat";
            this.udWildLat.Size = new System.Drawing.Size(75, 23);
            this.udWildLat.TabIndex = 5;
            this.udWildLat.Value = new decimal(new int[] {
            5000,
            0,
            0,
            131072});
            this.udWildLat.ValueChanged += new System.EventHandler(this.udWildLat_ValueChanged);
            this.udWildLat.Enter += new System.EventHandler(this.udWildLat_Enter);
            this.udWildLat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.udWildLat_MouseClick);
            // 
            // lblWildMin
            // 
            this.lblWildMin.AutoSize = true;
            this.lblWildMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWildMin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWildMin.Location = new System.Drawing.Point(49, 20);
            this.lblWildMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWildMin.Name = "lblWildMin";
            this.lblWildMin.Size = new System.Drawing.Size(31, 13);
            this.lblWildMin.TabIndex = 0;
            this.lblWildMin.Text = "Min:";
            // 
            // lblWildMax
            // 
            this.lblWildMax.AutoSize = true;
            this.lblWildMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWildMax.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWildMax.Location = new System.Drawing.Point(145, 20);
            this.lblWildMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWildMax.Name = "lblWildMax";
            this.lblWildMax.Size = new System.Drawing.Size(34, 13);
            this.lblWildMax.TabIndex = 2;
            this.lblWildMax.Text = "Max:";
            // 
            // udWildMin
            // 
            this.udWildMin.Location = new System.Drawing.Point(88, 16);
            this.udWildMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udWildMin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.udWildMin.Name = "udWildMin";
            this.udWildMin.Size = new System.Drawing.Size(44, 23);
            this.udWildMin.TabIndex = 1;
            this.udWildMin.ValueChanged += new System.EventHandler(this.udWildMin_ValueChanged);
            this.udWildMin.Enter += new System.EventHandler(this.udWildMin_Enter);
            this.udWildMin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.udWildMin_MouseClick);
            // 
            // udWildMax
            // 
            this.udWildMax.Location = new System.Drawing.Point(191, 16);
            this.udWildMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udWildMax.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.udWildMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udWildMax.Name = "udWildMax";
            this.udWildMax.Size = new System.Drawing.Size(56, 23);
            this.udWildMax.TabIndex = 3;
            this.udWildMax.Value = new decimal(new int[] {
            190,
            0,
            0,
            0});
            this.udWildMax.ValueChanged += new System.EventHandler(this.udWildMax_ValueChanged);
            this.udWildMax.Enter += new System.EventHandler(this.udWildMax_Enter);
            this.udWildMax.MouseClick += new System.Windows.Forms.MouseEventHandler(this.udWildMax_MouseClick);
            // 
            // lblWildCommand
            // 
            this.lblWildCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWildCommand.AutoSize = true;
            this.lblWildCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWildCommand.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWildCommand.Location = new System.Drawing.Point(16, 479);
            this.lblWildCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWildCommand.Name = "lblWildCommand";
            this.lblWildCommand.Size = new System.Drawing.Size(65, 13);
            this.lblWildCommand.TabIndex = 15;
            this.lblWildCommand.Text = "Command:";
            // 
            // cboConsoleCommandsWild
            // 
            this.cboConsoleCommandsWild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboConsoleCommandsWild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsoleCommandsWild.FormattingEnabled = true;
            this.cboConsoleCommandsWild.Items.AddRange(new object[] {
            "DestroyAll <ClassName>",
            "GMSummon \"<ClassName>\" <Level> ",
            "SetPlayerPos  <x> <y> <z>",
            "TeleportCreatureToMe <DinoId>",
            "TeleportToCreature <DinoId>"});
            this.cboConsoleCommandsWild.Location = new System.Drawing.Point(96, 475);
            this.cboConsoleCommandsWild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboConsoleCommandsWild.Name = "cboConsoleCommandsWild";
            this.cboConsoleCommandsWild.Size = new System.Drawing.Size(305, 23);
            this.cboConsoleCommandsWild.TabIndex = 16;
            // 
            // lblSelectedWildTotal
            // 
            this.lblSelectedWildTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedWildTotal.BackColor = System.Drawing.Color.AliceBlue;
            this.lblSelectedWildTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedWildTotal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSelectedWildTotal.Location = new System.Drawing.Point(788, 471);
            this.lblSelectedWildTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedWildTotal.Name = "lblSelectedWildTotal";
            this.lblSelectedWildTotal.Size = new System.Drawing.Size(144, 35);
            this.lblSelectedWildTotal.TabIndex = 18;
            this.lblSelectedWildTotal.Text = "Count: 0";
            this.lblSelectedWildTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWildClass
            // 
            this.lblWildClass.AutoSize = true;
            this.lblWildClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWildClass.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWildClass.Location = new System.Drawing.Point(16, 61);
            this.lblWildClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWildClass.Name = "lblWildClass";
            this.lblWildClass.Size = new System.Drawing.Size(59, 13);
            this.lblWildClass.TabIndex = 12;
            this.lblWildClass.Text = "Creature:";
            // 
            // tpgTamed
            // 
            this.tpgTamed.Controls.Add(this.pnlFilterTamed);
            this.tpgTamed.Controls.Add(this.cboTamedResource);
            this.tpgTamed.Controls.Add(this.lblTameResource);
            this.tpgTamed.Controls.Add(this.chkCryo);
            this.tpgTamed.Controls.Add(this.btnCopyCommandTamed);
            this.tpgTamed.Controls.Add(this.lblTamedCommand);
            this.tpgTamed.Controls.Add(this.cboConsoleCommandsTamed);
            this.tpgTamed.Controls.Add(this.cboTameTribes);
            this.tpgTamed.Controls.Add(this.cboTamePlayers);
            this.tpgTamed.Controls.Add(this.lblTameCreature);
            this.tpgTamed.Controls.Add(this.lblTamePlayer);
            this.tpgTamed.Controls.Add(this.lblTameTribe);
            this.tpgTamed.Controls.Add(this.btnDinoAncestors);
            this.tpgTamed.Controls.Add(this.btnDinoInventory);
            this.tpgTamed.Controls.Add(this.lvwTameDetail);
            this.tpgTamed.Controls.Add(this.lblTameTotal);
            this.tpgTamed.Controls.Add(this.pnlTameStatTypes);
            this.tpgTamed.Controls.Add(this.cboTameClass);
            this.tpgTamed.Location = new System.Drawing.Point(4, 24);
            this.tpgTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgTamed.Name = "tpgTamed";
            this.tpgTamed.Size = new System.Drawing.Size(1104, 520);
            this.tpgTamed.TabIndex = 3;
            this.tpgTamed.Text = "Tamed Creatures";
            this.tpgTamed.UseVisualStyleBackColor = true;
            // 
            // pnlFilterTamed
            // 
            this.pnlFilterTamed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilterTamed.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlFilterTamed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterTamed.Controls.Add(this.btnFindTamed);
            this.pnlFilterTamed.Controls.Add(this.txtFilterTamed);
            this.pnlFilterTamed.Location = new System.Drawing.Point(13, 423);
            this.pnlFilterTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFilterTamed.Name = "pnlFilterTamed";
            this.pnlFilterTamed.Size = new System.Drawing.Size(1073, 33);
            this.pnlFilterTamed.TabIndex = 21;
            // 
            // btnFindTamed
            // 
            this.btnFindTamed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindTamed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindTamed.Image = ((System.Drawing.Image)(resources.GetObject("btnFindTamed.Image")));
            this.btnFindTamed.Location = new System.Drawing.Point(1037, -1);
            this.btnFindTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFindTamed.Name = "btnFindTamed";
            this.btnFindTamed.Size = new System.Drawing.Size(35, 33);
            this.btnFindTamed.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnFindTamed, "Find next");
            this.btnFindTamed.UseVisualStyleBackColor = true;
            this.btnFindTamed.Click += new System.EventHandler(this.btnFindTamed_Click);
            // 
            // txtFilterTamed
            // 
            this.txtFilterTamed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterTamed.Location = new System.Drawing.Point(12, 3);
            this.txtFilterTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilterTamed.Name = "txtFilterTamed";
            this.txtFilterTamed.Size = new System.Drawing.Size(1013, 23);
            this.txtFilterTamed.TabIndex = 6;
            this.txtFilterTamed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterTamed_KeyDown);
            // 
            // cboTamedResource
            // 
            this.cboTamedResource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTamedResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTamedResource.FormattingEnabled = true;
            this.cboTamedResource.Location = new System.Drawing.Point(780, 50);
            this.cboTamedResource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTamedResource.Name = "cboTamedResource";
            this.cboTamedResource.Size = new System.Drawing.Size(251, 23);
            this.cboTamedResource.TabIndex = 16;
            this.cboTamedResource.SelectedIndexChanged += new System.EventHandler(this.cboTamedResource_SelectedIndexChanged);
            // 
            // lblTameResource
            // 
            this.lblTameResource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTameResource.AutoSize = true;
            this.lblTameResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTameResource.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTameResource.Location = new System.Drawing.Point(690, 53);
            this.lblTameResource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTameResource.Name = "lblTameResource";
            this.lblTameResource.Size = new System.Drawing.Size(65, 13);
            this.lblTameResource.TabIndex = 15;
            this.lblTameResource.Text = "Resource:";
            // 
            // lblTamedCommand
            // 
            this.lblTamedCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTamedCommand.AutoSize = true;
            this.lblTamedCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTamedCommand.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTamedCommand.Location = new System.Drawing.Point(224, 479);
            this.lblTamedCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamedCommand.Name = "lblTamedCommand";
            this.lblTamedCommand.Size = new System.Drawing.Size(65, 13);
            this.lblTamedCommand.TabIndex = 9;
            this.lblTamedCommand.Text = "Command:";
            // 
            // cboConsoleCommandsTamed
            // 
            this.cboConsoleCommandsTamed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboConsoleCommandsTamed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsoleCommandsTamed.FormattingEnabled = true;
            this.cboConsoleCommandsTamed.Items.AddRange(new object[] {
            "DestroyTribeIdDinos <TribeID>",
            "GMSummon \"<ClassName>\"  <Level> | <DoTame>",
            "GMSummon \"<ClassName>\"  <Level>",
            "TakeTribe <TribeID>",
            "SetPlayerPos  <x> <y> <z>",
            "TeleportCreatureToMe <DinoId>",
            "TeleportToCreature <DinoId>",
            "Cryo <DinoId>"});
            this.cboConsoleCommandsTamed.Location = new System.Drawing.Point(303, 475);
            this.cboConsoleCommandsTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboConsoleCommandsTamed.Name = "cboConsoleCommandsTamed";
            this.cboConsoleCommandsTamed.Size = new System.Drawing.Size(289, 23);
            this.cboConsoleCommandsTamed.TabIndex = 10;
            // 
            // cboTameTribes
            // 
            this.cboTameTribes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTameTribes.FormattingEnabled = true;
            this.cboTameTribes.Location = new System.Drawing.Point(89, 18);
            this.cboTameTribes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTameTribes.Name = "cboTameTribes";
            this.cboTameTribes.Size = new System.Drawing.Size(231, 23);
            this.cboTameTribes.TabIndex = 1;
            this.cboTameTribes.SelectedIndexChanged += new System.EventHandler(this.cboTameTribes_SelectedIndexChanged);
            // 
            // cboTamePlayers
            // 
            this.cboTamePlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTamePlayers.FormattingEnabled = true;
            this.cboTamePlayers.Location = new System.Drawing.Point(89, 50);
            this.cboTamePlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTamePlayers.Name = "cboTamePlayers";
            this.cboTamePlayers.Size = new System.Drawing.Size(231, 23);
            this.cboTamePlayers.TabIndex = 3;
            this.cboTamePlayers.SelectedIndexChanged += new System.EventHandler(this.cboTamePlayers_SelectedIndexChanged);
            // 
            // lblTameCreature
            // 
            this.lblTameCreature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTameCreature.AutoSize = true;
            this.lblTameCreature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTameCreature.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTameCreature.Location = new System.Drawing.Point(690, 21);
            this.lblTameCreature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTameCreature.Name = "lblTameCreature";
            this.lblTameCreature.Size = new System.Drawing.Size(59, 13);
            this.lblTameCreature.TabIndex = 4;
            this.lblTameCreature.Text = "Creature:";
            // 
            // lblTamePlayer
            // 
            this.lblTamePlayer.AutoSize = true;
            this.lblTamePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTamePlayer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTamePlayer.Location = new System.Drawing.Point(21, 52);
            this.lblTamePlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamePlayer.Name = "lblTamePlayer";
            this.lblTamePlayer.Size = new System.Drawing.Size(46, 13);
            this.lblTamePlayer.TabIndex = 2;
            this.lblTamePlayer.Text = "Player:";
            // 
            // lblTameTribe
            // 
            this.lblTameTribe.AutoSize = true;
            this.lblTameTribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTameTribe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTameTribe.Location = new System.Drawing.Point(21, 21);
            this.lblTameTribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTameTribe.Name = "lblTameTribe";
            this.lblTameTribe.Size = new System.Drawing.Size(40, 13);
            this.lblTameTribe.TabIndex = 0;
            this.lblTameTribe.Text = "Tribe:";
            // 
            // lvwTameDetail
            // 
            this.lvwTameDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwTameDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwTameDetail_Creature,
            this.lvwTameDetail_Name,
            this.lvwTameDetail_Wandering,
            this.lvwTameDetail_Mating,
            this.lvwTameDetail_Sex,
            this.lvwTameDetail_Base,
            this.lvwTameDetail_Level,
            this.lvwTameDetail_Lat,
            this.lvwTameDetail_Lon,
            this.lvwTameDetail_HP,
            this.lvwTameDetail_Stam,
            this.lvwTameDetail_Melee,
            this.lvwTameDetail_Weight,
            this.lvwTameDetail_Speed,
            this.lvwTameDetail_Food,
            this.lvwTameDetail_Oxygen,
            this.lvwTameDetail_Craft,
            this.lvwTameDetail_Server,
            this.lvwTameDetail_Tamer,
            this.lvwTameDetail_Imprinter,
            this.lvwTameDetail_Imprint,
            this.lvwTameDetail_Cryo,
            this.lvwTameDetail_Colour1,
            this.lvwTameDetail_Colour2,
            this.lvwTameDetail_Colour3,
            this.lvwTameDetail_Colour4,
            this.lvwTameDetail_Colour5,
            this.lvwTameDetail_Colour6,
            this.lvwTameDetail_MutationsFemale,
            this.lvwTameDetail_MutationsMale,
            this.lvwTameDetail_Id,
            this.lvwTameDetail_Scale,
            this.lvwTameDetail_Rig1,
            this.lvwTameDetail_Rig2,
            this.lvwTameDetail_TribeInRange,
            this.lvwTameDetail_CCC});
            this.lvwTameDetail.ContextMenuStrip = this.mnuContext;
            this.lvwTameDetail.FullRowSelect = true;
            this.lvwTameDetail.Location = new System.Drawing.Point(13, 91);
            this.lvwTameDetail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwTameDetail.MultiSelect = false;
            this.lvwTameDetail.Name = "lvwTameDetail";
            this.lvwTameDetail.Size = new System.Drawing.Size(1073, 333);
            this.lvwTameDetail.TabIndex = 7;
            this.lvwTameDetail.UseCompatibleStateImageBehavior = false;
            this.lvwTameDetail.View = System.Windows.Forms.View.Details;
            this.lvwTameDetail.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwTameDetail_ColumnClick);
            this.lvwTameDetail.SelectedIndexChanged += new System.EventHandler(this.lvwTameDetail_SelectedIndexChanged);
            this.lvwTameDetail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwTameDetail_MouseClick);
            // 
            // lvwTameDetail_Creature
            // 
            this.lvwTameDetail_Creature.Text = "Creature";
            this.lvwTameDetail_Creature.Width = 140;
            // 
            // lvwTameDetail_Name
            // 
            this.lvwTameDetail_Name.Text = "Name";
            this.lvwTameDetail_Name.Width = 150;
            // 
            // lvwTameDetail_Wandering
            // 
            this.lvwTameDetail_Wandering.Text = "Wandering";
            this.lvwTameDetail_Wandering.Width = 70;
            // 
            // lvwTameDetail_Mating
            // 
            this.lvwTameDetail_Mating.Text = "Mating";
            // 
            // lvwTameDetail_Sex
            // 
            this.lvwTameDetail_Sex.Text = "Sex";
            // 
            // lvwTameDetail_Base
            // 
            this.lvwTameDetail_Base.Text = "Base";
            this.lvwTameDetail_Base.Width = 50;
            // 
            // lvwTameDetail_Level
            // 
            this.lvwTameDetail_Level.Text = "Lvl";
            this.lvwTameDetail_Level.Width = 41;
            // 
            // lvwTameDetail_Lat
            // 
            this.lvwTameDetail_Lat.Text = "Lat";
            this.lvwTameDetail_Lat.Width = 58;
            // 
            // lvwTameDetail_Lon
            // 
            this.lvwTameDetail_Lon.Text = "Lon";
            this.lvwTameDetail_Lon.Width = 57;
            // 
            // lvwTameDetail_HP
            // 
            this.lvwTameDetail_HP.Text = "HP";
            this.lvwTameDetail_HP.Width = 45;
            // 
            // lvwTameDetail_Stam
            // 
            this.lvwTameDetail_Stam.Text = "Stam";
            this.lvwTameDetail_Stam.Width = 45;
            // 
            // lvwTameDetail_Melee
            // 
            this.lvwTameDetail_Melee.Text = "Melee";
            this.lvwTameDetail_Melee.Width = 48;
            // 
            // lvwTameDetail_Weight
            // 
            this.lvwTameDetail_Weight.Text = "Weight";
            this.lvwTameDetail_Weight.Width = 55;
            // 
            // lvwTameDetail_Speed
            // 
            this.lvwTameDetail_Speed.Text = "Speed";
            this.lvwTameDetail_Speed.Width = 50;
            // 
            // lvwTameDetail_Food
            // 
            this.lvwTameDetail_Food.Text = "Food";
            this.lvwTameDetail_Food.Width = 47;
            // 
            // lvwTameDetail_Oxygen
            // 
            this.lvwTameDetail_Oxygen.Text = "Oxygen";
            this.lvwTameDetail_Oxygen.Width = 53;
            // 
            // lvwTameDetail_Craft
            // 
            this.lvwTameDetail_Craft.Text = "Craft";
            this.lvwTameDetail_Craft.Width = 50;
            // 
            // lvwTameDetail_Server
            // 
            this.lvwTameDetail_Server.Text = "Server";
            this.lvwTameDetail_Server.Width = 150;
            // 
            // lvwTameDetail_Tamer
            // 
            this.lvwTameDetail_Tamer.Text = "Tamer";
            this.lvwTameDetail_Tamer.Width = 105;
            // 
            // lvwTameDetail_Imprinter
            // 
            this.lvwTameDetail_Imprinter.Text = "Imprinter";
            this.lvwTameDetail_Imprinter.Width = 105;
            // 
            // lvwTameDetail_Imprint
            // 
            this.lvwTameDetail_Imprint.Text = "Imprint";
            // 
            // lvwTameDetail_Cryo
            // 
            this.lvwTameDetail_Cryo.Text = "Stored";
            // 
            // lvwTameDetail_Colour1
            // 
            this.lvwTameDetail_Colour1.Text = "C0";
            this.lvwTameDetail_Colour1.Width = 35;
            // 
            // lvwTameDetail_Colour2
            // 
            this.lvwTameDetail_Colour2.Text = "C1";
            this.lvwTameDetail_Colour2.Width = 35;
            // 
            // lvwTameDetail_Colour3
            // 
            this.lvwTameDetail_Colour3.Text = "C2";
            this.lvwTameDetail_Colour3.Width = 35;
            // 
            // lvwTameDetail_Colour4
            // 
            this.lvwTameDetail_Colour4.Text = "C3";
            this.lvwTameDetail_Colour4.Width = 35;
            // 
            // lvwTameDetail_Colour5
            // 
            this.lvwTameDetail_Colour5.Text = "C4";
            this.lvwTameDetail_Colour5.Width = 35;
            // 
            // lvwTameDetail_Colour6
            // 
            this.lvwTameDetail_Colour6.Text = "C5";
            this.lvwTameDetail_Colour6.Width = 35;
            // 
            // lvwTameDetail_MutationsFemale
            // 
            this.lvwTameDetail_MutationsFemale.Text = "Mut (F)";
            // 
            // lvwTameDetail_MutationsMale
            // 
            this.lvwTameDetail_MutationsMale.Text = "Mut (M)";
            // 
            // lvwTameDetail_Id
            // 
            this.lvwTameDetail_Id.Text = "Id";
            this.lvwTameDetail_Id.Width = 0;
            // 
            // lvwTameDetail_Scale
            // 
            this.lvwTameDetail_Scale.Text = "Scale";
            // 
            // lvwTameDetail_Rig1
            // 
            this.lvwTameDetail_Rig1.Text = "Rig1";
            this.lvwTameDetail_Rig1.Width = 100;
            // 
            // lvwTameDetail_Rig2
            // 
            this.lvwTameDetail_Rig2.Text = "Rig2";
            this.lvwTameDetail_Rig2.Width = 100;
            // 
            // lvwTameDetail_TribeInRange
            // 
            this.lvwTameDetail_TribeInRange.Text = "Tribe In Range";
            this.lvwTameDetail_TribeInRange.Width = 120;
            // 
            // lvwTameDetail_CCC
            // 
            this.lvwTameDetail_CCC.Text = "CCC";
            this.lvwTameDetail_CCC.Width = 0;
            // 
            // lblTameTotal
            // 
            this.lblTameTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTameTotal.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTameTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTameTotal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTameTotal.Location = new System.Drawing.Point(943, 471);
            this.lblTameTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTameTotal.Name = "lblTameTotal";
            this.lblTameTotal.Size = new System.Drawing.Size(144, 35);
            this.lblTameTotal.TabIndex = 14;
            this.lblTameTotal.Text = "Count: 0";
            this.lblTameTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTameStatTypes
            // 
            this.pnlTameStatTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlTameStatTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTameStatTypes.Controls.Add(this.lblStats);
            this.pnlTameStatTypes.Controls.Add(this.optStatsTamed);
            this.pnlTameStatTypes.Controls.Add(this.optStatsBase);
            this.pnlTameStatTypes.Location = new System.Drawing.Point(13, 466);
            this.pnlTameStatTypes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTameStatTypes.Name = "pnlTameStatTypes";
            this.pnlTameStatTypes.Size = new System.Drawing.Size(204, 39);
            this.pnlTameStatTypes.TabIndex = 8;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(2, 12);
            this.lblStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(35, 15);
            this.lblStats.TabIndex = 0;
            this.lblStats.Text = "Stats:";
            // 
            // optStatsTamed
            // 
            this.optStatsTamed.AutoSize = true;
            this.optStatsTamed.Location = new System.Drawing.Point(113, 9);
            this.optStatsTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optStatsTamed.Name = "optStatsTamed";
            this.optStatsTamed.Size = new System.Drawing.Size(60, 19);
            this.optStatsTamed.TabIndex = 2;
            this.optStatsTamed.Text = "Tamed";
            this.optStatsTamed.UseVisualStyleBackColor = true;
            this.optStatsTamed.CheckedChanged += new System.EventHandler(this.optStatsTamed_CheckedChanged);
            // 
            // optStatsBase
            // 
            this.optStatsBase.AutoSize = true;
            this.optStatsBase.Checked = true;
            this.optStatsBase.Location = new System.Drawing.Point(49, 9);
            this.optStatsBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optStatsBase.Name = "optStatsBase";
            this.optStatsBase.Size = new System.Drawing.Size(49, 19);
            this.optStatsBase.TabIndex = 1;
            this.optStatsBase.TabStop = true;
            this.optStatsBase.Text = "Base";
            this.optStatsBase.UseVisualStyleBackColor = true;
            this.optStatsBase.CheckedChanged += new System.EventHandler(this.optStatsBase_CheckedChanged);
            // 
            // cboTameClass
            // 
            this.cboTameClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTameClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTameClass.FormattingEnabled = true;
            this.cboTameClass.Location = new System.Drawing.Point(780, 18);
            this.cboTameClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTameClass.Name = "cboTameClass";
            this.cboTameClass.Size = new System.Drawing.Size(251, 23);
            this.cboTameClass.TabIndex = 5;
            this.cboTameClass.SelectedIndexChanged += new System.EventHandler(this.cboTameClass_SelectedIndexChanged);
            // 
            // tpgStructures
            // 
            this.tpgStructures.Controls.Add(this.pnlFilterStructures);
            this.tpgStructures.Controls.Add(this.btnStructureInventory);
            this.tpgStructures.Controls.Add(this.lblStructureTotal);
            this.tpgStructures.Controls.Add(this.btnCopyCommandStructure);
            this.tpgStructures.Controls.Add(this.lblCommandStructure);
            this.tpgStructures.Controls.Add(this.cboConsoleCommandsStructure);
            this.tpgStructures.Controls.Add(this.btnStructureExclusionFilter);
            this.tpgStructures.Controls.Add(this.lblStructureStructure);
            this.tpgStructures.Controls.Add(this.cboStructureStructure);
            this.tpgStructures.Controls.Add(this.lblStructurePlayer);
            this.tpgStructures.Controls.Add(this.lblStructureTribe);
            this.tpgStructures.Controls.Add(this.cboStructureTribe);
            this.tpgStructures.Controls.Add(this.cboStructurePlayer);
            this.tpgStructures.Controls.Add(this.lvwStructureLocations);
            this.tpgStructures.Location = new System.Drawing.Point(4, 24);
            this.tpgStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgStructures.Name = "tpgStructures";
            this.tpgStructures.Size = new System.Drawing.Size(1104, 520);
            this.tpgStructures.TabIndex = 2;
            this.tpgStructures.Text = "Player Structures";
            this.tpgStructures.UseVisualStyleBackColor = true;
            // 
            // pnlFilterStructures
            // 
            this.pnlFilterStructures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilterStructures.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlFilterStructures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterStructures.Controls.Add(this.btnFindStructures);
            this.pnlFilterStructures.Controls.Add(this.txtFilterStructures);
            this.pnlFilterStructures.Location = new System.Drawing.Point(13, 430);
            this.pnlFilterStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFilterStructures.Name = "pnlFilterStructures";
            this.pnlFilterStructures.Size = new System.Drawing.Size(1073, 33);
            this.pnlFilterStructures.TabIndex = 22;
            // 
            // btnFindStructures
            // 
            this.btnFindStructures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindStructures.Image = ((System.Drawing.Image)(resources.GetObject("btnFindStructures.Image")));
            this.btnFindStructures.Location = new System.Drawing.Point(1037, -1);
            this.btnFindStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFindStructures.Name = "btnFindStructures";
            this.btnFindStructures.Size = new System.Drawing.Size(35, 33);
            this.btnFindStructures.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnFindStructures, "Find next");
            this.btnFindStructures.UseVisualStyleBackColor = true;
            this.btnFindStructures.Click += new System.EventHandler(this.btnFindStructures_Click);
            // 
            // txtFilterStructures
            // 
            this.txtFilterStructures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterStructures.Location = new System.Drawing.Point(12, 3);
            this.txtFilterStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilterStructures.Name = "txtFilterStructures";
            this.txtFilterStructures.Size = new System.Drawing.Size(1013, 23);
            this.txtFilterStructures.TabIndex = 6;
            this.txtFilterStructures.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterStructures_KeyDown);
            // 
            // lblStructureTotal
            // 
            this.lblStructureTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStructureTotal.BackColor = System.Drawing.Color.AliceBlue;
            this.lblStructureTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStructureTotal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStructureTotal.Location = new System.Drawing.Point(943, 474);
            this.lblStructureTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStructureTotal.Name = "lblStructureTotal";
            this.lblStructureTotal.Size = new System.Drawing.Size(144, 35);
            this.lblStructureTotal.TabIndex = 12;
            this.lblStructureTotal.Text = "Total: 0";
            this.lblStructureTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCommandStructure
            // 
            this.lblCommandStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCommandStructure.AutoSize = true;
            this.lblCommandStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCommandStructure.Location = new System.Drawing.Point(10, 479);
            this.lblCommandStructure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommandStructure.Name = "lblCommandStructure";
            this.lblCommandStructure.Size = new System.Drawing.Size(65, 13);
            this.lblCommandStructure.TabIndex = 8;
            this.lblCommandStructure.Text = "Command:";
            // 
            // cboConsoleCommandsStructure
            // 
            this.cboConsoleCommandsStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboConsoleCommandsStructure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsoleCommandsStructure.FormattingEnabled = true;
            this.cboConsoleCommandsStructure.Items.AddRange(new object[] {
            "DestroyTribeId <TribeID> ",
            "DestroyTribeIdDinos <TribeID>",
            "DestroyTribeIdPlayers <TribeID>",
            "DestroyTribeIdStructures <TribeID>",
            "TakeTribe <TribeID>",
            "SetPlayerPos  <x> <y> <z>"});
            this.cboConsoleCommandsStructure.Location = new System.Drawing.Point(90, 475);
            this.cboConsoleCommandsStructure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboConsoleCommandsStructure.Name = "cboConsoleCommandsStructure";
            this.cboConsoleCommandsStructure.Size = new System.Drawing.Size(305, 23);
            this.cboConsoleCommandsStructure.TabIndex = 9;
            this.cboConsoleCommandsStructure.SelectedIndexChanged += new System.EventHandler(this.cboConsoleCommandsStructure_SelectedIndexChanged);
            // 
            // lblStructureStructure
            // 
            this.lblStructureStructure.AutoSize = true;
            this.lblStructureStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStructureStructure.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStructureStructure.Location = new System.Drawing.Point(564, 21);
            this.lblStructureStructure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStructureStructure.Name = "lblStructureStructure";
            this.lblStructureStructure.Size = new System.Drawing.Size(63, 13);
            this.lblStructureStructure.TabIndex = 4;
            this.lblStructureStructure.Text = "Structure:";
            // 
            // cboStructureStructure
            // 
            this.cboStructureStructure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStructureStructure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStructureStructure.FormattingEnabled = true;
            this.cboStructureStructure.Location = new System.Drawing.Point(645, 18);
            this.cboStructureStructure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboStructureStructure.Name = "cboStructureStructure";
            this.cboStructureStructure.Size = new System.Drawing.Size(276, 23);
            this.cboStructureStructure.TabIndex = 5;
            this.cboStructureStructure.SelectedIndexChanged += new System.EventHandler(this.cboStructureStructure_SelectedIndexChanged);
            // 
            // lblStructurePlayer
            // 
            this.lblStructurePlayer.AutoSize = true;
            this.lblStructurePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStructurePlayer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStructurePlayer.Location = new System.Drawing.Point(267, 21);
            this.lblStructurePlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStructurePlayer.Name = "lblStructurePlayer";
            this.lblStructurePlayer.Size = new System.Drawing.Size(46, 13);
            this.lblStructurePlayer.TabIndex = 2;
            this.lblStructurePlayer.Text = "Player:";
            // 
            // lblStructureTribe
            // 
            this.lblStructureTribe.AutoSize = true;
            this.lblStructureTribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStructureTribe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStructureTribe.Location = new System.Drawing.Point(16, 21);
            this.lblStructureTribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStructureTribe.Name = "lblStructureTribe";
            this.lblStructureTribe.Size = new System.Drawing.Size(40, 13);
            this.lblStructureTribe.TabIndex = 0;
            this.lblStructureTribe.Text = "Tribe:";
            // 
            // cboStructureTribe
            // 
            this.cboStructureTribe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStructureTribe.FormattingEnabled = true;
            this.cboStructureTribe.Location = new System.Drawing.Point(66, 18);
            this.cboStructureTribe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboStructureTribe.Name = "cboStructureTribe";
            this.cboStructureTribe.Size = new System.Drawing.Size(193, 23);
            this.cboStructureTribe.TabIndex = 1;
            this.cboStructureTribe.SelectedIndexChanged += new System.EventHandler(this.cboStructureTribe_SelectedIndexChanged);
            // 
            // cboStructurePlayer
            // 
            this.cboStructurePlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStructurePlayer.FormattingEnabled = true;
            this.cboStructurePlayer.Location = new System.Drawing.Point(328, 18);
            this.cboStructurePlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboStructurePlayer.Name = "cboStructurePlayer";
            this.cboStructurePlayer.Size = new System.Drawing.Size(224, 23);
            this.cboStructurePlayer.TabIndex = 3;
            this.cboStructurePlayer.SelectedIndexChanged += new System.EventHandler(this.cboStructurePlayer_SelectedIndexChanged);
            // 
            // lvwStructureLocations
            // 
            this.lvwStructureLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwStructureLocations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwStructureLocations_Tribe,
            this.lvwStructureLocations_Structure,
            this.lvwStructureLocations_Lat,
            this.lvwStructureLocations_Lon,
            this.lvwStructureLocations_LastTime,
            this.lvwStructureLocations_DecayReset,
            this.lvwStructureLocations_CCC});
            this.lvwStructureLocations.ContextMenuStrip = this.mnuContext;
            this.lvwStructureLocations.FullRowSelect = true;
            this.lvwStructureLocations.Location = new System.Drawing.Point(13, 59);
            this.lvwStructureLocations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwStructureLocations.MultiSelect = false;
            this.lvwStructureLocations.Name = "lvwStructureLocations";
            this.lvwStructureLocations.Size = new System.Drawing.Size(1073, 372);
            this.lvwStructureLocations.TabIndex = 7;
            this.lvwStructureLocations.UseCompatibleStateImageBehavior = false;
            this.lvwStructureLocations.View = System.Windows.Forms.View.Details;
            this.lvwStructureLocations.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwStructureLocations_ColumnClick);
            this.lvwStructureLocations.SelectedIndexChanged += new System.EventHandler(this.lvwStructureLocations_SelectedIndexChanged);
            this.lvwStructureLocations.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwStructureLocations_MouseClick);
            // 
            // lvwStructureLocations_Tribe
            // 
            this.lvwStructureLocations_Tribe.Text = "Tribe";
            this.lvwStructureLocations_Tribe.Width = 200;
            // 
            // lvwStructureLocations_Structure
            // 
            this.lvwStructureLocations_Structure.Text = "Structure";
            this.lvwStructureLocations_Structure.Width = 200;
            // 
            // lvwStructureLocations_Lat
            // 
            this.lvwStructureLocations_Lat.Text = "Lat";
            this.lvwStructureLocations_Lat.Width = 79;
            // 
            // lvwStructureLocations_Lon
            // 
            this.lvwStructureLocations_Lon.Text = "Lon";
            this.lvwStructureLocations_Lon.Width = 71;
            // 
            // lvwStructureLocations_LastTime
            // 
            this.lvwStructureLocations_LastTime.Text = "Tribe In Range";
            this.lvwStructureLocations_LastTime.Width = 120;
            // 
            // lvwStructureLocations_DecayReset
            // 
            this.lvwStructureLocations_DecayReset.Text = "Decay Reset";
            this.lvwStructureLocations_DecayReset.Width = 80;
            // 
            // lvwStructureLocations_CCC
            // 
            this.lvwStructureLocations_CCC.Text = "CCC";
            this.lvwStructureLocations_CCC.Width = 0;
            // 
            // tpgTribes
            // 
            this.tpgTribes.Controls.Add(this.splitContainer1);
            this.tpgTribes.Controls.Add(this.chkTribeStructures);
            this.tpgTribes.Controls.Add(this.chkTribeTames);
            this.tpgTribes.Controls.Add(this.chkTribePlayers);
            this.tpgTribes.Controls.Add(this.btnTribeCopyCommand);
            this.tpgTribes.Controls.Add(this.lblTribeCopyCommand);
            this.tpgTribes.Controls.Add(this.cboTribeCopyCommand);
            this.tpgTribes.Controls.Add(this.btnTribeLog);
            this.tpgTribes.Location = new System.Drawing.Point(4, 24);
            this.tpgTribes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgTribes.Name = "tpgTribes";
            this.tpgTribes.Size = new System.Drawing.Size(1104, 520);
            this.tpgTribes.TabIndex = 5;
            this.tpgTribes.Text = "Tribes";
            this.tpgTribes.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(11, 20);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvwTribes);
            this.splitContainer1.Panel1.Controls.Add(this.pnlFilterTribes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSaveChartImage);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.udChartTop);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.cboChartType);
            this.splitContainer1.Panel2.Controls.Add(this.chartTribes);
            this.splitContainer1.Size = new System.Drawing.Size(1075, 438);
            this.splitContainer1.SplitterDistance = 746;
            this.splitContainer1.TabIndex = 24;
            // 
            // lvwTribes
            // 
            this.lvwTribes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwTribes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwTribes_Id,
            this.lvwTribes_Name,
            this.lvwTribes_Players,
            this.lvwTribes_Tames,
            this.lvwTribes_Structures,
            this.lvwTribes_Active});
            this.lvwTribes.ContextMenuStrip = this.mnuContext;
            this.lvwTribes.FullRowSelect = true;
            this.lvwTribes.Location = new System.Drawing.Point(5, 3);
            this.lvwTribes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwTribes.Name = "lvwTribes";
            this.lvwTribes.Size = new System.Drawing.Size(740, 395);
            this.lvwTribes.TabIndex = 0;
            this.lvwTribes.UseCompatibleStateImageBehavior = false;
            this.lvwTribes.View = System.Windows.Forms.View.Details;
            this.lvwTribes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwTribes_ColumnClick);
            this.lvwTribes.SelectedIndexChanged += new System.EventHandler(this.lvwTribes_SelectedIndexChanged);
            this.lvwTribes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwTribes_MouseClick);
            // 
            // lvwTribes_Id
            // 
            this.lvwTribes_Id.Text = "Id";
            this.lvwTribes_Id.Width = 150;
            // 
            // lvwTribes_Name
            // 
            this.lvwTribes_Name.Text = "Name";
            this.lvwTribes_Name.Width = 228;
            // 
            // lvwTribes_Players
            // 
            this.lvwTribes_Players.Text = "Players";
            this.lvwTribes_Players.Width = 75;
            // 
            // lvwTribes_Tames
            // 
            this.lvwTribes_Tames.Text = "Tames";
            this.lvwTribes_Tames.Width = 75;
            // 
            // lvwTribes_Structures
            // 
            this.lvwTribes_Structures.Text = "Structures";
            this.lvwTribes_Structures.Width = 75;
            // 
            // lvwTribes_Active
            // 
            this.lvwTribes_Active.Text = "Last Active";
            this.lvwTribes_Active.Width = 127;
            // 
            // pnlFilterTribes
            // 
            this.pnlFilterTribes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilterTribes.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlFilterTribes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterTribes.Controls.Add(this.btnFilterTribe);
            this.pnlFilterTribes.Controls.Add(this.txtFilterTribe);
            this.pnlFilterTribes.Location = new System.Drawing.Point(5, 400);
            this.pnlFilterTribes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFilterTribes.Name = "pnlFilterTribes";
            this.pnlFilterTribes.Size = new System.Drawing.Size(740, 33);
            this.pnlFilterTribes.TabIndex = 23;
            // 
            // btnFilterTribe
            // 
            this.btnFilterTribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterTribe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterTribe.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterTribe.Image")));
            this.btnFilterTribe.Location = new System.Drawing.Point(704, -1);
            this.btnFilterTribe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFilterTribe.Name = "btnFilterTribe";
            this.btnFilterTribe.Size = new System.Drawing.Size(35, 33);
            this.btnFilterTribe.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnFilterTribe, "Find next");
            this.btnFilterTribe.UseVisualStyleBackColor = true;
            this.btnFilterTribe.Click += new System.EventHandler(this.btnFilterTribe_Click);
            // 
            // txtFilterTribe
            // 
            this.txtFilterTribe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterTribe.Location = new System.Drawing.Point(12, 3);
            this.txtFilterTribe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilterTribe.Name = "txtFilterTribe";
            this.txtFilterTribe.Size = new System.Drawing.Size(680, 23);
            this.txtFilterTribe.TabIndex = 6;
            this.txtFilterTribe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterTribe_KeyDown);
            // 
            // btnSaveChartImage
            // 
            this.btnSaveChartImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChartImage.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveChartImage.Image")));
            this.btnSaveChartImage.Location = new System.Drawing.Point(269, 42);
            this.btnSaveChartImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveChartImage.Name = "btnSaveChartImage";
            this.btnSaveChartImage.Size = new System.Drawing.Size(43, 33);
            this.btnSaveChartImage.TabIndex = 52;
            this.btnSaveChartImage.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSaveChartImage, "Save chart image.");
            this.btnSaveChartImage.UseVisualStyleBackColor = true;
            this.btnSaveChartImage.Click += new System.EventHandler(this.btnSaveChart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Top:";
            // 
            // udChartTop
            // 
            this.udChartTop.Location = new System.Drawing.Point(72, 43);
            this.udChartTop.Name = "udChartTop";
            this.udChartTop.Size = new System.Drawing.Size(63, 23);
            this.udChartTop.TabIndex = 6;
            this.udChartTop.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udChartTop.ValueChanged += new System.EventHandler(this.udChartTop_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chart:";
            // 
            // cboChartType
            // 
            this.cboChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChartType.FormattingEnabled = true;
            this.cboChartType.Items.AddRange(new object[] {
            "Tribes by No. Players",
            "Tribes by No. Tames",
            "Tribes by No. Structures"});
            this.cboChartType.Location = new System.Drawing.Point(72, 13);
            this.cboChartType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboChartType.Name = "cboChartType";
            this.cboChartType.Size = new System.Drawing.Size(240, 23);
            this.cboChartType.TabIndex = 5;
            this.cboChartType.SelectedIndexChanged += new System.EventHandler(this.cboChartType_SelectedIndexChanged);
            // 
            // chartTribes
            // 
            this.chartTribes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartTribes.CausesValidation = false;
            this.chartTribes.Location = new System.Drawing.Point(10, 81);
            this.chartTribes.Name = "chartTribes";
            this.chartTribes.Size = new System.Drawing.Size(302, 306);
            this.chartTribes.SubTitle = "";
            this.chartTribes.TabIndex = 0;
            this.chartTribes.Title = "ASV Tribes";
            // 
            // chkTribeStructures
            // 
            this.chkTribeStructures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTribeStructures.BackColor = System.Drawing.Color.PaleGreen;
            this.chkTribeStructures.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkTribeStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkTribeStructures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTribeStructures.ForeColor = System.Drawing.Color.ForestGreen;
            this.chkTribeStructures.Location = new System.Drawing.Point(945, 467);
            this.chkTribeStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkTribeStructures.Name = "chkTribeStructures";
            this.chkTribeStructures.Size = new System.Drawing.Size(141, 40);
            this.chkTribeStructures.TabIndex = 7;
            this.chkTribeStructures.Text = "Structure Markers";
            this.chkTribeStructures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.chkTribeStructures, "Show structure markers.");
            this.chkTribeStructures.UseVisualStyleBackColor = false;
            this.chkTribeStructures.CheckedChanged += new System.EventHandler(this.chkTribeStructures_CheckedChanged);
            // 
            // chkTribeTames
            // 
            this.chkTribeTames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTribeTames.BackColor = System.Drawing.Color.Gold;
            this.chkTribeTames.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkTribeTames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkTribeTames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTribeTames.ForeColor = System.Drawing.Color.Chocolate;
            this.chkTribeTames.Location = new System.Drawing.Point(816, 467);
            this.chkTribeTames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkTribeTames.Name = "chkTribeTames";
            this.chkTribeTames.Size = new System.Drawing.Size(122, 40);
            this.chkTribeTames.TabIndex = 6;
            this.chkTribeTames.Text = "Tame Markers";
            this.chkTribeTames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.chkTribeTames, "Show tame markers.");
            this.chkTribeTames.UseVisualStyleBackColor = false;
            this.chkTribeTames.CheckedChanged += new System.EventHandler(this.chkTribeTames_CheckedChanged);
            // 
            // chkTribePlayers
            // 
            this.chkTribePlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTribePlayers.BackColor = System.Drawing.Color.CornflowerBlue;
            this.chkTribePlayers.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkTribePlayers.Checked = true;
            this.chkTribePlayers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTribePlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkTribePlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTribePlayers.ForeColor = System.Drawing.Color.LightCyan;
            this.chkTribePlayers.Location = new System.Drawing.Point(676, 467);
            this.chkTribePlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkTribePlayers.Name = "chkTribePlayers";
            this.chkTribePlayers.Size = new System.Drawing.Size(133, 40);
            this.chkTribePlayers.TabIndex = 5;
            this.chkTribePlayers.Text = "Player Markers";
            this.chkTribePlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.chkTribePlayers, "Show player markers.");
            this.chkTribePlayers.UseVisualStyleBackColor = false;
            this.chkTribePlayers.CheckedChanged += new System.EventHandler(this.chkTribePlayers_CheckedChanged);
            // 
            // lblTribeCopyCommand
            // 
            this.lblTribeCopyCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTribeCopyCommand.AutoSize = true;
            this.lblTribeCopyCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTribeCopyCommand.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTribeCopyCommand.Location = new System.Drawing.Point(16, 478);
            this.lblTribeCopyCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTribeCopyCommand.Name = "lblTribeCopyCommand";
            this.lblTribeCopyCommand.Size = new System.Drawing.Size(65, 13);
            this.lblTribeCopyCommand.TabIndex = 1;
            this.lblTribeCopyCommand.Text = "Command:";
            // 
            // cboTribeCopyCommand
            // 
            this.cboTribeCopyCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboTribeCopyCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTribeCopyCommand.FormattingEnabled = true;
            this.cboTribeCopyCommand.Items.AddRange(new object[] {
            "DestroyTribeId <TribeID> ",
            "DestroyTribeIdDinos <TribeID>",
            "DestroyTribeIdPlayers <TribeID>",
            "DestroyTribeIdStructures <TribeID>",
            "RenameTribe \"<TribeName>\" ",
            "TakeTribe <TribeID>",
            "TribeStructureAudit <TribeID>",
            "TribeDinoAudit  <TribeID>",
            "RM <FileCsvList>",
            "DEL <FileCsvList>"});
            this.cboTribeCopyCommand.Location = new System.Drawing.Point(96, 474);
            this.cboTribeCopyCommand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTribeCopyCommand.Name = "cboTribeCopyCommand";
            this.cboTribeCopyCommand.Size = new System.Drawing.Size(305, 23);
            this.cboTribeCopyCommand.TabIndex = 2;
            // 
            // tpgPlayers
            // 
            this.tpgPlayers.Controls.Add(this.pnlFilterPlayers);
            this.tpgPlayers.Controls.Add(this.btnDeletePlayer);
            this.tpgPlayers.Controls.Add(this.lblPlayerTotal);
            this.tpgPlayers.Controls.Add(this.btnCopyCommandPlayer);
            this.tpgPlayers.Controls.Add(this.lblCommandPlayer);
            this.tpgPlayers.Controls.Add(this.cboConsoleCommandsPlayerTribe);
            this.tpgPlayers.Controls.Add(this.btnPlayerTribeLog);
            this.tpgPlayers.Controls.Add(this.btnPlayerInventory);
            this.tpgPlayers.Controls.Add(this.lblPlayersPlayer);
            this.tpgPlayers.Controls.Add(this.lblPlayersTribe);
            this.tpgPlayers.Controls.Add(this.cboTribes);
            this.tpgPlayers.Controls.Add(this.cboPlayers);
            this.tpgPlayers.Controls.Add(this.lvwPlayers);
            this.tpgPlayers.Location = new System.Drawing.Point(4, 24);
            this.tpgPlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgPlayers.Name = "tpgPlayers";
            this.tpgPlayers.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgPlayers.Size = new System.Drawing.Size(1104, 520);
            this.tpgPlayers.TabIndex = 1;
            this.tpgPlayers.Text = "Players";
            this.tpgPlayers.UseVisualStyleBackColor = true;
            // 
            // pnlFilterPlayers
            // 
            this.pnlFilterPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilterPlayers.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlFilterPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterPlayers.Controls.Add(this.btnFilterPlayer);
            this.pnlFilterPlayers.Controls.Add(this.txtFilterPlayer);
            this.pnlFilterPlayers.Location = new System.Drawing.Point(14, 420);
            this.pnlFilterPlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFilterPlayers.Name = "pnlFilterPlayers";
            this.pnlFilterPlayers.Size = new System.Drawing.Size(1072, 33);
            this.pnlFilterPlayers.TabIndex = 23;
            // 
            // btnFilterPlayer
            // 
            this.btnFilterPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterPlayer.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterPlayer.Image")));
            this.btnFilterPlayer.Location = new System.Drawing.Point(1036, -1);
            this.btnFilterPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFilterPlayer.Name = "btnFilterPlayer";
            this.btnFilterPlayer.Size = new System.Drawing.Size(35, 33);
            this.btnFilterPlayer.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnFilterPlayer, "Find next");
            this.btnFilterPlayer.UseVisualStyleBackColor = true;
            this.btnFilterPlayer.Click += new System.EventHandler(this.btnFilterPlayer_Click);
            // 
            // txtFilterPlayer
            // 
            this.txtFilterPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterPlayer.Location = new System.Drawing.Point(12, 3);
            this.txtFilterPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilterPlayer.Name = "txtFilterPlayer";
            this.txtFilterPlayer.Size = new System.Drawing.Size(1012, 23);
            this.txtFilterPlayer.TabIndex = 6;
            this.txtFilterPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterPlayer_KeyDown);
            // 
            // lblPlayerTotal
            // 
            this.lblPlayerTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayerTotal.BackColor = System.Drawing.Color.AliceBlue;
            this.lblPlayerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerTotal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPlayerTotal.Location = new System.Drawing.Point(943, 468);
            this.lblPlayerTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerTotal.Name = "lblPlayerTotal";
            this.lblPlayerTotal.Size = new System.Drawing.Size(144, 35);
            this.lblPlayerTotal.TabIndex = 11;
            this.lblPlayerTotal.Text = "Total: 0";
            this.lblPlayerTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCommandPlayer
            // 
            this.lblCommandPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCommandPlayer.AutoSize = true;
            this.lblCommandPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCommandPlayer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCommandPlayer.Location = new System.Drawing.Point(16, 475);
            this.lblCommandPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommandPlayer.Name = "lblCommandPlayer";
            this.lblCommandPlayer.Size = new System.Drawing.Size(65, 13);
            this.lblCommandPlayer.TabIndex = 5;
            this.lblCommandPlayer.Text = "Command:";
            // 
            // cboConsoleCommandsPlayerTribe
            // 
            this.cboConsoleCommandsPlayerTribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboConsoleCommandsPlayerTribe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsoleCommandsPlayerTribe.FormattingEnabled = true;
            this.cboConsoleCommandsPlayerTribe.Items.AddRange(new object[] {
            "AllowPlayerToJoinNoCheck <SteamID>",
            "BanPlayer <SteamID>",
            "ClearPlayerInventory <PlayerID> true true true",
            "DefeatAllBosses <PlayerID> ",
            "DestroyTribeId <TribeID> ",
            "DestroyTribeIdDinos <TribeID>",
            "DestroyTribeIdPlayers <TribeID>",
            "DestroyTribeIdStructures <TribeID>",
            "DisallowPlayerToJoinNoCheck <SteamID> ",
            "GetPlayerIDForSteamID <SteamID> ",
            "GetSteamIDForPlayerID <PlayerID> ",
            "GiveCreativeModeToPlayer <PlayerID> ",
            "GiveTekengramsTo <PlayerID> tek",
            "GiveItemToPlayer <PlayerID> <BlueprintPath> <Quantity> <Quality> <ForceBlueprint>" +
                "",
            "KickPlayer <SteamID> ",
            "KillPlayer <PlayerID>",
            "MaxAscend <PlayerID>  ",
            "RenamePlayer \"<CharacterName>\" <NewName>",
            "RenameTribe \"<TribeName>\" <NewName>",
            "ServerChatToPlayer <PlayerName>",
            "SetImprintedPlayer \"<CharacterName>\" <PlayerID>",
            "SetPlayerPos  <x> <y> <z>",
            "TakeTribe <TribeID>",
            "TeleportPlayerIDToMe <PlayerID>",
            "TeleportPlayerNameToMe <CharacterName>",
            "TeleportToPlayer <PlayerID>",
            "TeleportToPlayerName <CharacterName>",
            "TribeStructureAudit <TribeID>",
            "TribeDinoAudit  <TribeID>",
            "UnbanPlayer <SteamID>",
            "RM <FileCsvList>",
            "DEL <FileCsvList>",
            "AddChibiExpToPlayer <PlayerID> <HowMuch>"});
            this.cboConsoleCommandsPlayerTribe.Location = new System.Drawing.Point(96, 472);
            this.cboConsoleCommandsPlayerTribe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboConsoleCommandsPlayerTribe.Name = "cboConsoleCommandsPlayerTribe";
            this.cboConsoleCommandsPlayerTribe.Size = new System.Drawing.Size(305, 23);
            this.cboConsoleCommandsPlayerTribe.TabIndex = 6;
            this.cboConsoleCommandsPlayerTribe.SelectedIndexChanged += new System.EventHandler(this.cboConsoleCommandsPlayerTribe_SelectedIndexChanged);
            // 
            // lblPlayersPlayer
            // 
            this.lblPlayersPlayer.AutoSize = true;
            this.lblPlayersPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayersPlayer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPlayersPlayer.Location = new System.Drawing.Point(405, 21);
            this.lblPlayersPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayersPlayer.Name = "lblPlayersPlayer";
            this.lblPlayersPlayer.Size = new System.Drawing.Size(46, 13);
            this.lblPlayersPlayer.TabIndex = 2;
            this.lblPlayersPlayer.Text = "Player:";
            // 
            // lblPlayersTribe
            // 
            this.lblPlayersTribe.AutoSize = true;
            this.lblPlayersTribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayersTribe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPlayersTribe.Location = new System.Drawing.Point(16, 21);
            this.lblPlayersTribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayersTribe.Name = "lblPlayersTribe";
            this.lblPlayersTribe.Size = new System.Drawing.Size(40, 13);
            this.lblPlayersTribe.TabIndex = 0;
            this.lblPlayersTribe.Text = "Tribe:";
            // 
            // cboTribes
            // 
            this.cboTribes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTribes.FormattingEnabled = true;
            this.cboTribes.Location = new System.Drawing.Point(70, 17);
            this.cboTribes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTribes.Name = "cboTribes";
            this.cboTribes.Size = new System.Drawing.Size(313, 23);
            this.cboTribes.TabIndex = 1;
            this.cboTribes.SelectedIndexChanged += new System.EventHandler(this.cboTribes_SelectedIndexChanged);
            // 
            // cboPlayers
            // 
            this.cboPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayers.FormattingEnabled = true;
            this.cboPlayers.Location = new System.Drawing.Point(465, 17);
            this.cboPlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboPlayers.Name = "cboPlayers";
            this.cboPlayers.Size = new System.Drawing.Size(303, 23);
            this.cboPlayers.TabIndex = 3;
            this.cboPlayers.SelectedIndexChanged += new System.EventHandler(this.cboPlayers_SelectedIndexChanged);
            // 
            // lvwPlayers
            // 
            this.lvwPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwPlayers_PlayerId,
            this.lvwPlayers_Name,
            this.lvwPlayers_Tribe,
            this.lvwPlayers_Sex,
            this.lvwPlayers_Level,
            this.lvwPlayers_Lat,
            this.lvwPlayers_Lon,
            this.lvwPlayers_Hp,
            this.lvwPlayers_Stam,
            this.lvwPlayers_Melee,
            this.lvwPlayers_Weight,
            this.lvwPlayers_Speed,
            this.lvwPlayers_Food,
            this.lvwPlayers_Water,
            this.lvwPlayers_Oxygen,
            this.lvwPlayers_Crafting,
            this.lvwPlayers_Fortitude,
            this.lvwPlayers_LastOnline,
            this.lvwPlayers_SteamName,
            this.lvwPlayers_SteamId,
            this.lvwPlayers_CCC});
            this.lvwPlayers.ContextMenuStrip = this.mnuContext;
            this.lvwPlayers.FullRowSelect = true;
            this.lvwPlayers.Location = new System.Drawing.Point(14, 60);
            this.lvwPlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwPlayers.Name = "lvwPlayers";
            this.lvwPlayers.Size = new System.Drawing.Size(1072, 361);
            this.lvwPlayers.TabIndex = 4;
            this.lvwPlayers.UseCompatibleStateImageBehavior = false;
            this.lvwPlayers.View = System.Windows.Forms.View.Details;
            this.lvwPlayers.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwPlayers_ColumnClick);
            this.lvwPlayers.SelectedIndexChanged += new System.EventHandler(this.lvwPlayers_SelectedIndexChanged);
            this.lvwPlayers.Click += new System.EventHandler(this.lvwPlayers_Click);
            this.lvwPlayers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwPlayers_MouseClick);
            // 
            // lvwPlayers_PlayerId
            // 
            this.lvwPlayers_PlayerId.Text = "Id";
            this.lvwPlayers_PlayerId.Width = 100;
            // 
            // lvwPlayers_Name
            // 
            this.lvwPlayers_Name.Text = "Name";
            this.lvwPlayers_Name.Width = 90;
            // 
            // lvwPlayers_Tribe
            // 
            this.lvwPlayers_Tribe.Text = "Tribe";
            this.lvwPlayers_Tribe.Width = 90;
            // 
            // lvwPlayers_Sex
            // 
            this.lvwPlayers_Sex.Text = "Sex";
            this.lvwPlayers_Sex.Width = 55;
            // 
            // lvwPlayers_Level
            // 
            this.lvwPlayers_Level.Text = "Lvl";
            this.lvwPlayers_Level.Width = 35;
            // 
            // lvwPlayers_Lat
            // 
            this.lvwPlayers_Lat.Text = "Lat";
            this.lvwPlayers_Lat.Width = 45;
            // 
            // lvwPlayers_Lon
            // 
            this.lvwPlayers_Lon.Text = "Lon";
            this.lvwPlayers_Lon.Width = 45;
            // 
            // lvwPlayers_Hp
            // 
            this.lvwPlayers_Hp.Text = "HP";
            this.lvwPlayers_Hp.Width = 45;
            // 
            // lvwPlayers_Stam
            // 
            this.lvwPlayers_Stam.Text = "Stam";
            this.lvwPlayers_Stam.Width = 45;
            // 
            // lvwPlayers_Melee
            // 
            this.lvwPlayers_Melee.Text = "Melee";
            this.lvwPlayers_Melee.Width = 48;
            // 
            // lvwPlayers_Weight
            // 
            this.lvwPlayers_Weight.Text = "Weight";
            this.lvwPlayers_Weight.Width = 55;
            // 
            // lvwPlayers_Speed
            // 
            this.lvwPlayers_Speed.Text = "Speed";
            this.lvwPlayers_Speed.Width = 50;
            // 
            // lvwPlayers_Food
            // 
            this.lvwPlayers_Food.Text = "Food";
            this.lvwPlayers_Food.Width = 47;
            // 
            // lvwPlayers_Water
            // 
            this.lvwPlayers_Water.Text = "Water";
            // 
            // lvwPlayers_Oxygen
            // 
            this.lvwPlayers_Oxygen.Text = "Oxygen";
            this.lvwPlayers_Oxygen.Width = 53;
            // 
            // lvwPlayers_Crafting
            // 
            this.lvwPlayers_Crafting.Text = "Crafting";
            // 
            // lvwPlayers_Fortitude
            // 
            this.lvwPlayers_Fortitude.Text = "Fortitude";
            // 
            // lvwPlayers_LastOnline
            // 
            this.lvwPlayers_LastOnline.Text = "Last Online";
            this.lvwPlayers_LastOnline.Width = 140;
            // 
            // lvwPlayers_SteamName
            // 
            this.lvwPlayers_SteamName.Text = "Steam Name";
            this.lvwPlayers_SteamName.Width = 150;
            // 
            // lvwPlayers_SteamId
            // 
            this.lvwPlayers_SteamId.Text = "Steam Id";
            this.lvwPlayers_SteamId.Width = 0;
            // 
            // lvwPlayers_CCC
            // 
            this.lvwPlayers_CCC.Text = "CCC";
            this.lvwPlayers_CCC.Width = 0;
            // 
            // tpgDroppedItems
            // 
            this.tpgDroppedItems.Controls.Add(this.pnlFilterDropped);
            this.tpgDroppedItems.Controls.Add(this.chkDroppedBlueprints);
            this.tpgDroppedItems.Controls.Add(this.btnDropInventory);
            this.tpgDroppedItems.Controls.Add(this.cboDroppedItem);
            this.tpgDroppedItems.Controls.Add(this.lblDroppedPlayer);
            this.tpgDroppedItems.Controls.Add(this.cboDroppedPlayer);
            this.tpgDroppedItems.Controls.Add(this.btnCopyCommandDropped);
            this.tpgDroppedItems.Controls.Add(this.lblCopyCommandDropped);
            this.tpgDroppedItems.Controls.Add(this.cboCopyCommandDropped);
            this.tpgDroppedItems.Controls.Add(this.lblCountDropped);
            this.tpgDroppedItems.Controls.Add(this.lblDroppedItem);
            this.tpgDroppedItems.Controls.Add(this.lvwDroppedItems);
            this.tpgDroppedItems.Location = new System.Drawing.Point(4, 24);
            this.tpgDroppedItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgDroppedItems.Name = "tpgDroppedItems";
            this.tpgDroppedItems.Size = new System.Drawing.Size(1104, 520);
            this.tpgDroppedItems.TabIndex = 4;
            this.tpgDroppedItems.Text = "Dropped Items";
            this.tpgDroppedItems.UseVisualStyleBackColor = true;
            // 
            // pnlFilterDropped
            // 
            this.pnlFilterDropped.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilterDropped.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlFilterDropped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterDropped.Controls.Add(this.btnFindDropped);
            this.pnlFilterDropped.Controls.Add(this.txtFilterDropped);
            this.pnlFilterDropped.Location = new System.Drawing.Point(13, 428);
            this.pnlFilterDropped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFilterDropped.Name = "pnlFilterDropped";
            this.pnlFilterDropped.Size = new System.Drawing.Size(1075, 33);
            this.pnlFilterDropped.TabIndex = 22;
            // 
            // btnFindDropped
            // 
            this.btnFindDropped.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindDropped.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindDropped.Image = ((System.Drawing.Image)(resources.GetObject("btnFindDropped.Image")));
            this.btnFindDropped.Location = new System.Drawing.Point(1040, -1);
            this.btnFindDropped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFindDropped.Name = "btnFindDropped";
            this.btnFindDropped.Size = new System.Drawing.Size(35, 33);
            this.btnFindDropped.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnFindDropped, "Find next");
            this.btnFindDropped.UseVisualStyleBackColor = true;
            this.btnFindDropped.Click += new System.EventHandler(this.btnFindDropped_Click);
            // 
            // txtFilterDropped
            // 
            this.txtFilterDropped.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterDropped.Location = new System.Drawing.Point(12, 3);
            this.txtFilterDropped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilterDropped.Name = "txtFilterDropped";
            this.txtFilterDropped.Size = new System.Drawing.Size(1015, 23);
            this.txtFilterDropped.TabIndex = 6;
            this.txtFilterDropped.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterDropped_KeyDown);
            // 
            // chkDroppedBlueprints
            // 
            this.chkDroppedBlueprints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDroppedBlueprints.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDroppedBlueprints.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkDroppedBlueprints.BackgroundImage")));
            this.chkDroppedBlueprints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkDroppedBlueprints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDroppedBlueprints.Location = new System.Drawing.Point(1042, 6);
            this.chkDroppedBlueprints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDroppedBlueprints.Name = "chkDroppedBlueprints";
            this.chkDroppedBlueprints.Size = new System.Drawing.Size(47, 46);
            this.chkDroppedBlueprints.TabIndex = 10;
            this.toolTip1.SetToolTip(this.chkDroppedBlueprints, "Show / hide blueprints.");
            this.chkDroppedBlueprints.UseVisualStyleBackColor = true;
            this.chkDroppedBlueprints.CheckedChanged += new System.EventHandler(this.chkDroppedBlueprints_CheckedChanged);
            // 
            // cboDroppedItem
            // 
            this.cboDroppedItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDroppedItem.FormattingEnabled = true;
            this.cboDroppedItem.Location = new System.Drawing.Point(390, 17);
            this.cboDroppedItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboDroppedItem.Name = "cboDroppedItem";
            this.cboDroppedItem.Size = new System.Drawing.Size(248, 23);
            this.cboDroppedItem.TabIndex = 3;
            this.cboDroppedItem.SelectedIndexChanged += new System.EventHandler(this.cboDroppedItem_SelectedIndexChanged);
            // 
            // lblDroppedPlayer
            // 
            this.lblDroppedPlayer.AutoSize = true;
            this.lblDroppedPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDroppedPlayer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDroppedPlayer.Location = new System.Drawing.Point(20, 21);
            this.lblDroppedPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDroppedPlayer.Name = "lblDroppedPlayer";
            this.lblDroppedPlayer.Size = new System.Drawing.Size(46, 13);
            this.lblDroppedPlayer.TabIndex = 0;
            this.lblDroppedPlayer.Text = "Player:";
            // 
            // cboDroppedPlayer
            // 
            this.cboDroppedPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDroppedPlayer.FormattingEnabled = true;
            this.cboDroppedPlayer.Location = new System.Drawing.Point(80, 18);
            this.cboDroppedPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboDroppedPlayer.Name = "cboDroppedPlayer";
            this.cboDroppedPlayer.Size = new System.Drawing.Size(254, 23);
            this.cboDroppedPlayer.TabIndex = 1;
            this.cboDroppedPlayer.SelectedIndexChanged += new System.EventHandler(this.cboDroppedPlayer_SelectedIndexChanged);
            // 
            // lblCopyCommandDropped
            // 
            this.lblCopyCommandDropped.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopyCommandDropped.AutoSize = true;
            this.lblCopyCommandDropped.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCopyCommandDropped.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCopyCommandDropped.Location = new System.Drawing.Point(16, 481);
            this.lblCopyCommandDropped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyCommandDropped.Name = "lblCopyCommandDropped";
            this.lblCopyCommandDropped.Size = new System.Drawing.Size(65, 13);
            this.lblCopyCommandDropped.TabIndex = 5;
            this.lblCopyCommandDropped.Text = "Command:";
            // 
            // cboCopyCommandDropped
            // 
            this.cboCopyCommandDropped.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboCopyCommandDropped.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCopyCommandDropped.FormattingEnabled = true;
            this.cboCopyCommandDropped.Items.AddRange(new object[] {
            "SetPlayerPos  <x> <y> <z>"});
            this.cboCopyCommandDropped.Location = new System.Drawing.Point(96, 478);
            this.cboCopyCommandDropped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCopyCommandDropped.Name = "cboCopyCommandDropped";
            this.cboCopyCommandDropped.Size = new System.Drawing.Size(305, 23);
            this.cboCopyCommandDropped.TabIndex = 6;
            // 
            // lblCountDropped
            // 
            this.lblCountDropped.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountDropped.BackColor = System.Drawing.Color.AliceBlue;
            this.lblCountDropped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCountDropped.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCountDropped.Location = new System.Drawing.Point(945, 472);
            this.lblCountDropped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountDropped.Name = "lblCountDropped";
            this.lblCountDropped.Size = new System.Drawing.Size(144, 35);
            this.lblCountDropped.TabIndex = 9;
            this.lblCountDropped.Text = "Count: 0";
            this.lblCountDropped.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDroppedItem
            // 
            this.lblDroppedItem.AutoSize = true;
            this.lblDroppedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDroppedItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDroppedItem.Location = new System.Drawing.Point(342, 22);
            this.lblDroppedItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDroppedItem.Name = "lblDroppedItem";
            this.lblDroppedItem.Size = new System.Drawing.Size(35, 13);
            this.lblDroppedItem.TabIndex = 2;
            this.lblDroppedItem.Text = "Item:";
            // 
            // lvwDroppedItems
            // 
            this.lvwDroppedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDroppedItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwDroppedItems_Item,
            this.lvwDroppedItems_Bp,
            this.lvwDroppedItems_DroppedBy,
            this.lvwDroppedItems_Lat,
            this.lvwDroppedItems_Lon,
            this.lvwDroppedItems_Tribe,
            this.lvwDroppedItems_Player,
            this.lvwDroppedItems_CCC});
            this.lvwDroppedItems.FullRowSelect = true;
            this.lvwDroppedItems.Location = new System.Drawing.Point(13, 60);
            this.lvwDroppedItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwDroppedItems.MultiSelect = false;
            this.lvwDroppedItems.Name = "lvwDroppedItems";
            this.lvwDroppedItems.Size = new System.Drawing.Size(1075, 369);
            this.lvwDroppedItems.TabIndex = 4;
            this.lvwDroppedItems.UseCompatibleStateImageBehavior = false;
            this.lvwDroppedItems.View = System.Windows.Forms.View.Details;
            this.lvwDroppedItems.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwDroppedItems_ColumnClick);
            this.lvwDroppedItems.SelectedIndexChanged += new System.EventHandler(this.lvwDroppedItems_SelectedIndexChanged);
            // 
            // lvwDroppedItems_Item
            // 
            this.lvwDroppedItems_Item.Text = "Item";
            this.lvwDroppedItems_Item.Width = 180;
            // 
            // lvwDroppedItems_Bp
            // 
            this.lvwDroppedItems_Bp.Text = "BP";
            // 
            // lvwDroppedItems_DroppedBy
            // 
            this.lvwDroppedItems_DroppedBy.Text = "Dropped By";
            this.lvwDroppedItems_DroppedBy.Width = 169;
            // 
            // lvwDroppedItems_Lat
            // 
            this.lvwDroppedItems_Lat.Text = "Lat";
            // 
            // lvwDroppedItems_Lon
            // 
            this.lvwDroppedItems_Lon.Text = "Lon";
            // 
            // lvwDroppedItems_Tribe
            // 
            this.lvwDroppedItems_Tribe.Text = "Tribe";
            this.lvwDroppedItems_Tribe.Width = 105;
            // 
            // lvwDroppedItems_Player
            // 
            this.lvwDroppedItems_Player.Text = "Player";
            this.lvwDroppedItems_Player.Width = 109;
            // 
            // lvwDroppedItems_CCC
            // 
            this.lvwDroppedItems_CCC.Text = "CCC";
            this.lvwDroppedItems_CCC.Width = 0;
            // 
            // tpgItemList
            // 
            this.tpgItemList.Controls.Add(this.pnlFilterSearch);
            this.tpgItemList.Controls.Add(this.chkItemSearchBlueprints);
            this.tpgItemList.Controls.Add(this.cboItemListItem);
            this.tpgItemList.Controls.Add(this.lblItemListTribe);
            this.tpgItemList.Controls.Add(this.cboItemListTribe);
            this.tpgItemList.Controls.Add(this.btnItemListCommand);
            this.tpgItemList.Controls.Add(this.lblItemListCommand);
            this.tpgItemList.Controls.Add(this.cboItemListCommand);
            this.tpgItemList.Controls.Add(this.lblItemListCount);
            this.tpgItemList.Controls.Add(this.lblItemListItem);
            this.tpgItemList.Controls.Add(this.lvwItemList);
            this.tpgItemList.Location = new System.Drawing.Point(4, 24);
            this.tpgItemList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgItemList.Name = "tpgItemList";
            this.tpgItemList.Size = new System.Drawing.Size(1104, 520);
            this.tpgItemList.TabIndex = 6;
            this.tpgItemList.Text = "Item Search";
            this.tpgItemList.UseVisualStyleBackColor = true;
            // 
            // pnlFilterSearch
            // 
            this.pnlFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilterSearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlFilterSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterSearch.Controls.Add(this.btnFindSearched);
            this.pnlFilterSearch.Controls.Add(this.txtFilterSearch);
            this.pnlFilterSearch.Location = new System.Drawing.Point(13, 428);
            this.pnlFilterSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFilterSearch.Name = "pnlFilterSearch";
            this.pnlFilterSearch.Size = new System.Drawing.Size(1073, 33);
            this.pnlFilterSearch.TabIndex = 22;
            // 
            // btnFindSearched
            // 
            this.btnFindSearched.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindSearched.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindSearched.Image = ((System.Drawing.Image)(resources.GetObject("btnFindSearched.Image")));
            this.btnFindSearched.Location = new System.Drawing.Point(1037, -1);
            this.btnFindSearched.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFindSearched.Name = "btnFindSearched";
            this.btnFindSearched.Size = new System.Drawing.Size(35, 33);
            this.btnFindSearched.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnFindSearched, "Find next");
            this.btnFindSearched.UseVisualStyleBackColor = true;
            this.btnFindSearched.Click += new System.EventHandler(this.btnFindSearched_Click);
            // 
            // txtFilterSearch
            // 
            this.txtFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterSearch.Location = new System.Drawing.Point(12, 3);
            this.txtFilterSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilterSearch.Name = "txtFilterSearch";
            this.txtFilterSearch.Size = new System.Drawing.Size(1013, 23);
            this.txtFilterSearch.TabIndex = 6;
            this.txtFilterSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterSearch_KeyDown);
            // 
            // chkItemSearchBlueprints
            // 
            this.chkItemSearchBlueprints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkItemSearchBlueprints.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkItemSearchBlueprints.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkItemSearchBlueprints.BackgroundImage")));
            this.chkItemSearchBlueprints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkItemSearchBlueprints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkItemSearchBlueprints.Location = new System.Drawing.Point(1040, 7);
            this.chkItemSearchBlueprints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkItemSearchBlueprints.Name = "chkItemSearchBlueprints";
            this.chkItemSearchBlueprints.Size = new System.Drawing.Size(47, 46);
            this.chkItemSearchBlueprints.TabIndex = 11;
            this.toolTip1.SetToolTip(this.chkItemSearchBlueprints, "Show / hide blueprints.");
            this.chkItemSearchBlueprints.UseVisualStyleBackColor = true;
            this.chkItemSearchBlueprints.CheckedChanged += new System.EventHandler(this.chkItemSearchBlueprints_CheckedChanged);
            // 
            // cboItemListItem
            // 
            this.cboItemListItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemListItem.FormattingEnabled = true;
            this.cboItemListItem.Location = new System.Drawing.Point(390, 17);
            this.cboItemListItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboItemListItem.Name = "cboItemListItem";
            this.cboItemListItem.Size = new System.Drawing.Size(251, 23);
            this.cboItemListItem.TabIndex = 3;
            this.cboItemListItem.SelectedIndexChanged += new System.EventHandler(this.cboItemListItem_SelectedIndexChanged);
            // 
            // lblItemListTribe
            // 
            this.lblItemListTribe.AutoSize = true;
            this.lblItemListTribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItemListTribe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblItemListTribe.Location = new System.Drawing.Point(20, 21);
            this.lblItemListTribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemListTribe.Name = "lblItemListTribe";
            this.lblItemListTribe.Size = new System.Drawing.Size(40, 13);
            this.lblItemListTribe.TabIndex = 0;
            this.lblItemListTribe.Text = "Tribe:";
            // 
            // cboItemListTribe
            // 
            this.cboItemListTribe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemListTribe.FormattingEnabled = true;
            this.cboItemListTribe.Location = new System.Drawing.Point(80, 18);
            this.cboItemListTribe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboItemListTribe.Name = "cboItemListTribe";
            this.cboItemListTribe.Size = new System.Drawing.Size(254, 23);
            this.cboItemListTribe.TabIndex = 1;
            this.cboItemListTribe.SelectedIndexChanged += new System.EventHandler(this.cboItemListTribe_SelectedIndexChanged);
            // 
            // btnItemListCommand
            // 
            this.btnItemListCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnItemListCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemListCommand.Enabled = false;
            this.btnItemListCommand.Image = ((System.Drawing.Image)(resources.GetObject("btnItemListCommand.Image")));
            this.btnItemListCommand.Location = new System.Drawing.Point(408, 466);
            this.btnItemListCommand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnItemListCommand.Name = "btnItemListCommand";
            this.btnItemListCommand.Size = new System.Drawing.Size(47, 46);
            this.btnItemListCommand.TabIndex = 7;
            this.btnItemListCommand.UseVisualStyleBackColor = true;
            this.btnItemListCommand.Click += new System.EventHandler(this.btnItemListCommand_Click);
            // 
            // lblItemListCommand
            // 
            this.lblItemListCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblItemListCommand.AutoSize = true;
            this.lblItemListCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItemListCommand.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblItemListCommand.Location = new System.Drawing.Point(16, 481);
            this.lblItemListCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemListCommand.Name = "lblItemListCommand";
            this.lblItemListCommand.Size = new System.Drawing.Size(65, 13);
            this.lblItemListCommand.TabIndex = 5;
            this.lblItemListCommand.Text = "Command:";
            // 
            // cboItemListCommand
            // 
            this.cboItemListCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboItemListCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemListCommand.FormattingEnabled = true;
            this.cboItemListCommand.Items.AddRange(new object[] {
            "SetPlayerPos  <x> <y> <z>"});
            this.cboItemListCommand.Location = new System.Drawing.Point(96, 478);
            this.cboItemListCommand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboItemListCommand.Name = "cboItemListCommand";
            this.cboItemListCommand.Size = new System.Drawing.Size(305, 23);
            this.cboItemListCommand.TabIndex = 6;
            // 
            // lblItemListCount
            // 
            this.lblItemListCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemListCount.BackColor = System.Drawing.Color.AliceBlue;
            this.lblItemListCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemListCount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblItemListCount.Location = new System.Drawing.Point(943, 472);
            this.lblItemListCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemListCount.Name = "lblItemListCount";
            this.lblItemListCount.Size = new System.Drawing.Size(144, 35);
            this.lblItemListCount.TabIndex = 8;
            this.lblItemListCount.Text = "Count: 0";
            this.lblItemListCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemListItem
            // 
            this.lblItemListItem.AutoSize = true;
            this.lblItemListItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItemListItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblItemListItem.Location = new System.Drawing.Point(342, 22);
            this.lblItemListItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemListItem.Name = "lblItemListItem";
            this.lblItemListItem.Size = new System.Drawing.Size(35, 13);
            this.lblItemListItem.TabIndex = 2;
            this.lblItemListItem.Text = "Item:";
            // 
            // lvwItemList
            // 
            this.lvwItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwItemList_Tribe,
            this.lvwItemList_Container,
            this.lvwItemList_Item,
            this.lvwItemList_Quality,
            this.lvwItemList_Rating,
            this.lvwItemList_BP,
            this.lvwItemList_Quantity,
            this.lvwItemList_Lat,
            this.lvwItemList_Lon,
            this.lvwItemList_CCC});
            this.lvwItemList.FullRowSelect = true;
            this.lvwItemList.Location = new System.Drawing.Point(13, 60);
            this.lvwItemList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwItemList.MultiSelect = false;
            this.lvwItemList.Name = "lvwItemList";
            this.lvwItemList.Size = new System.Drawing.Size(1073, 369);
            this.lvwItemList.TabIndex = 4;
            this.lvwItemList.UseCompatibleStateImageBehavior = false;
            this.lvwItemList.View = System.Windows.Forms.View.Details;
            this.lvwItemList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwItemList_ColumnClick);
            this.lvwItemList.SelectedIndexChanged += new System.EventHandler(this.lvwItemList_SelectedIndexChanged);
            // 
            // lvwItemList_Tribe
            // 
            this.lvwItemList_Tribe.Text = "Tribe";
            this.lvwItemList_Tribe.Width = 175;
            // 
            // lvwItemList_Container
            // 
            this.lvwItemList_Container.Text = "Container";
            this.lvwItemList_Container.Width = 175;
            // 
            // lvwItemList_Item
            // 
            this.lvwItemList_Item.Text = "Item";
            this.lvwItemList_Item.Width = 175;
            // 
            // lvwItemList_Quality
            // 
            this.lvwItemList_Quality.Text = "Quality";
            this.lvwItemList_Quality.Width = 80;
            // 
            // lvwItemList_Rating
            // 
            this.lvwItemList_Rating.Text = "Rating";
            // 
            // lvwItemList_BP
            // 
            this.lvwItemList_BP.Text = "BP";
            this.lvwItemList_BP.Width = 40;
            // 
            // lvwItemList_Quantity
            // 
            this.lvwItemList_Quantity.Text = "Qty";
            // 
            // lvwItemList_Lat
            // 
            this.lvwItemList_Lat.Text = "Lat";
            // 
            // lvwItemList_Lon
            // 
            this.lvwItemList_Lon.Text = "Lon";
            // 
            // lvwItemList_CCC
            // 
            this.lvwItemList_CCC.Text = "CCC";
            this.lvwItemList_CCC.Width = 0;
            // 
            // tpgLocalProfile
            // 
            this.tpgLocalProfile.Controls.Add(this.pnlUploadedStats);
            this.tpgLocalProfile.Controls.Add(this.lblUploadedCountItems);
            this.tpgLocalProfile.Controls.Add(this.lblUploadedCountTames);
            this.tpgLocalProfile.Controls.Add(this.lblUploadedCountCharacters);
            this.tpgLocalProfile.Controls.Add(this.lblUploadedItems);
            this.tpgLocalProfile.Controls.Add(this.lvwUploadedItems);
            this.tpgLocalProfile.Controls.Add(this.lblUploadedTames);
            this.tpgLocalProfile.Controls.Add(this.lblUploadedCharacters);
            this.tpgLocalProfile.Controls.Add(this.lvwUploadedCharacters);
            this.tpgLocalProfile.Controls.Add(this.lvwUploadedTames);
            this.tpgLocalProfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpgLocalProfile.Location = new System.Drawing.Point(4, 24);
            this.tpgLocalProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgLocalProfile.Name = "tpgLocalProfile";
            this.tpgLocalProfile.Size = new System.Drawing.Size(1104, 520);
            this.tpgLocalProfile.TabIndex = 7;
            this.tpgLocalProfile.Text = "Local Profile";
            this.tpgLocalProfile.UseVisualStyleBackColor = true;
            // 
            // pnlUploadedStats
            // 
            this.pnlUploadedStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUploadedStats.Controls.Add(this.lblUploadedStats);
            this.pnlUploadedStats.Controls.Add(this.optUploadedStatsTamed);
            this.pnlUploadedStats.Controls.Add(this.optUploadedStatsBase);
            this.pnlUploadedStats.Location = new System.Drawing.Point(15, 316);
            this.pnlUploadedStats.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlUploadedStats.Name = "pnlUploadedStats";
            this.pnlUploadedStats.Size = new System.Drawing.Size(204, 39);
            this.pnlUploadedStats.TabIndex = 17;
            // 
            // lblUploadedStats
            // 
            this.lblUploadedStats.AutoSize = true;
            this.lblUploadedStats.Location = new System.Drawing.Point(2, 12);
            this.lblUploadedStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUploadedStats.Name = "lblUploadedStats";
            this.lblUploadedStats.Size = new System.Drawing.Size(35, 15);
            this.lblUploadedStats.TabIndex = 0;
            this.lblUploadedStats.Text = "Stats:";
            // 
            // optUploadedStatsTamed
            // 
            this.optUploadedStatsTamed.AutoSize = true;
            this.optUploadedStatsTamed.Location = new System.Drawing.Point(113, 9);
            this.optUploadedStatsTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optUploadedStatsTamed.Name = "optUploadedStatsTamed";
            this.optUploadedStatsTamed.Size = new System.Drawing.Size(60, 19);
            this.optUploadedStatsTamed.TabIndex = 2;
            this.optUploadedStatsTamed.Text = "Tamed";
            this.optUploadedStatsTamed.UseVisualStyleBackColor = true;
            // 
            // optUploadedStatsBase
            // 
            this.optUploadedStatsBase.AutoSize = true;
            this.optUploadedStatsBase.Checked = true;
            this.optUploadedStatsBase.Location = new System.Drawing.Point(49, 9);
            this.optUploadedStatsBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optUploadedStatsBase.Name = "optUploadedStatsBase";
            this.optUploadedStatsBase.Size = new System.Drawing.Size(49, 19);
            this.optUploadedStatsBase.TabIndex = 1;
            this.optUploadedStatsBase.TabStop = true;
            this.optUploadedStatsBase.Text = "Base";
            this.optUploadedStatsBase.UseVisualStyleBackColor = true;
            this.optUploadedStatsBase.CheckedChanged += new System.EventHandler(this.optUploadedStatsBase_CheckedChanged);
            // 
            // lblUploadedCountItems
            // 
            this.lblUploadedCountItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUploadedCountItems.BackColor = System.Drawing.Color.AliceBlue;
            this.lblUploadedCountItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUploadedCountItems.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUploadedCountItems.Location = new System.Drawing.Point(961, 486);
            this.lblUploadedCountItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUploadedCountItems.Name = "lblUploadedCountItems";
            this.lblUploadedCountItems.Size = new System.Drawing.Size(126, 24);
            this.lblUploadedCountItems.TabIndex = 16;
            this.lblUploadedCountItems.Text = "Count: 0";
            this.lblUploadedCountItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUploadedCountTames
            // 
            this.lblUploadedCountTames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUploadedCountTames.BackColor = System.Drawing.Color.AliceBlue;
            this.lblUploadedCountTames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUploadedCountTames.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUploadedCountTames.Location = new System.Drawing.Point(961, 313);
            this.lblUploadedCountTames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUploadedCountTames.Name = "lblUploadedCountTames";
            this.lblUploadedCountTames.Size = new System.Drawing.Size(126, 24);
            this.lblUploadedCountTames.TabIndex = 15;
            this.lblUploadedCountTames.Text = "Count: 0";
            this.lblUploadedCountTames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUploadedCountCharacters
            // 
            this.lblUploadedCountCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUploadedCountCharacters.BackColor = System.Drawing.Color.AliceBlue;
            this.lblUploadedCountCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUploadedCountCharacters.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUploadedCountCharacters.Location = new System.Drawing.Point(961, 145);
            this.lblUploadedCountCharacters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUploadedCountCharacters.Name = "lblUploadedCountCharacters";
            this.lblUploadedCountCharacters.Size = new System.Drawing.Size(126, 24);
            this.lblUploadedCountCharacters.TabIndex = 14;
            this.lblUploadedCountCharacters.Text = "Count: 0";
            this.lblUploadedCountCharacters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUploadedItems
            // 
            this.lblUploadedItems.AutoSize = true;
            this.lblUploadedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUploadedItems.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUploadedItems.Location = new System.Drawing.Point(12, 359);
            this.lblUploadedItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUploadedItems.Name = "lblUploadedItems";
            this.lblUploadedItems.Size = new System.Drawing.Size(78, 13);
            this.lblUploadedItems.TabIndex = 13;
            this.lblUploadedItems.Text = "Stored Items";
            // 
            // lvwUploadedItems
            // 
            this.lvwUploadedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwUploadedItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader22});
            this.lvwUploadedItems.FullRowSelect = true;
            this.lvwUploadedItems.Location = new System.Drawing.Point(15, 377);
            this.lvwUploadedItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwUploadedItems.MultiSelect = false;
            this.lvwUploadedItems.Name = "lvwUploadedItems";
            this.lvwUploadedItems.Size = new System.Drawing.Size(1073, 104);
            this.lvwUploadedItems.TabIndex = 12;
            this.lvwUploadedItems.UseCompatibleStateImageBehavior = false;
            this.lvwUploadedItems.View = System.Windows.Forms.View.Details;
            this.lvwUploadedItems.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwUploadedItems_ColumnClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Item";
            this.columnHeader8.Width = 175;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Quality";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Rating";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "BP";
            this.columnHeader19.Width = 40;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Qty";
            // 
            // lblUploadedTames
            // 
            this.lblUploadedTames.AutoSize = true;
            this.lblUploadedTames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUploadedTames.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUploadedTames.Location = new System.Drawing.Point(12, 153);
            this.lblUploadedTames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUploadedTames.Name = "lblUploadedTames";
            this.lblUploadedTames.Size = new System.Drawing.Size(102, 13);
            this.lblUploadedTames.TabIndex = 11;
            this.lblUploadedTames.Text = "Uploaded Tames";
            // 
            // lblUploadedCharacters
            // 
            this.lblUploadedCharacters.AutoSize = true;
            this.lblUploadedCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUploadedCharacters.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUploadedCharacters.Location = new System.Drawing.Point(12, 18);
            this.lblUploadedCharacters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUploadedCharacters.Name = "lblUploadedCharacters";
            this.lblUploadedCharacters.Size = new System.Drawing.Size(126, 13);
            this.lblUploadedCharacters.TabIndex = 10;
            this.lblUploadedCharacters.Text = "Uploaded Characters";
            // 
            // lvwUploadedCharacters
            // 
            this.lvwUploadedCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwUploadedCharacters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader37,
            this.columnHeader39,
            this.columnHeader40,
            this.columnHeader43,
            this.columnHeader44,
            this.columnHeader45,
            this.columnHeader46,
            this.columnHeader47,
            this.columnHeader48,
            this.columnHeader49,
            this.columnHeader50,
            this.columnHeader51,
            this.columnHeader52});
            this.lvwUploadedCharacters.ContextMenuStrip = this.mnuContext;
            this.lvwUploadedCharacters.FullRowSelect = true;
            this.lvwUploadedCharacters.Location = new System.Drawing.Point(15, 42);
            this.lvwUploadedCharacters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwUploadedCharacters.Name = "lvwUploadedCharacters";
            this.lvwUploadedCharacters.Size = new System.Drawing.Size(1072, 100);
            this.lvwUploadedCharacters.TabIndex = 9;
            this.lvwUploadedCharacters.UseCompatibleStateImageBehavior = false;
            this.lvwUploadedCharacters.View = System.Windows.Forms.View.Details;
            this.lvwUploadedCharacters.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwUploadedCharacters_ColumnClick);
            // 
            // columnHeader37
            // 
            this.columnHeader37.Text = "Name";
            this.columnHeader37.Width = 90;
            // 
            // columnHeader39
            // 
            this.columnHeader39.Text = "Sex";
            this.columnHeader39.Width = 55;
            // 
            // columnHeader40
            // 
            this.columnHeader40.Text = "Lvl";
            this.columnHeader40.Width = 35;
            // 
            // columnHeader43
            // 
            this.columnHeader43.Text = "HP";
            this.columnHeader43.Width = 45;
            // 
            // columnHeader44
            // 
            this.columnHeader44.Text = "Stam";
            this.columnHeader44.Width = 45;
            // 
            // columnHeader45
            // 
            this.columnHeader45.Text = "Melee";
            this.columnHeader45.Width = 48;
            // 
            // columnHeader46
            // 
            this.columnHeader46.Text = "Weight";
            this.columnHeader46.Width = 55;
            // 
            // columnHeader47
            // 
            this.columnHeader47.Text = "Speed";
            this.columnHeader47.Width = 50;
            // 
            // columnHeader48
            // 
            this.columnHeader48.Text = "Food";
            this.columnHeader48.Width = 47;
            // 
            // columnHeader49
            // 
            this.columnHeader49.Text = "Water";
            // 
            // columnHeader50
            // 
            this.columnHeader50.Text = "Oxygen";
            this.columnHeader50.Width = 53;
            // 
            // columnHeader51
            // 
            this.columnHeader51.Text = "Crafting";
            // 
            // columnHeader52
            // 
            this.columnHeader52.Text = "Fortitude";
            // 
            // lvwUploadedTames
            // 
            this.lvwUploadedTames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwUploadedTames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30,
            this.columnHeader33,
            this.columnHeader34});
            this.lvwUploadedTames.ContextMenuStrip = this.mnuContext;
            this.lvwUploadedTames.FullRowSelect = true;
            this.lvwUploadedTames.Location = new System.Drawing.Point(15, 175);
            this.lvwUploadedTames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwUploadedTames.MultiSelect = false;
            this.lvwUploadedTames.Name = "lvwUploadedTames";
            this.lvwUploadedTames.Size = new System.Drawing.Size(1072, 133);
            this.lvwUploadedTames.TabIndex = 8;
            this.lvwUploadedTames.UseCompatibleStateImageBehavior = false;
            this.lvwUploadedTames.View = System.Windows.Forms.View.Details;
            this.lvwUploadedTames.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwUploadedTames_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Creature";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sex";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Base";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Lvl";
            this.columnHeader7.Width = 41;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "HP";
            this.columnHeader10.Width = 45;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Stam";
            this.columnHeader11.Width = 45;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Melee";
            this.columnHeader12.Width = 48;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Weight";
            this.columnHeader13.Width = 55;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Speed";
            this.columnHeader14.Width = 50;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Food";
            this.columnHeader15.Width = 47;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Oxygen";
            this.columnHeader16.Width = 53;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Craft";
            this.columnHeader17.Width = 50;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Imprinter";
            this.columnHeader20.Width = 105;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Imprint";
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "C0";
            this.columnHeader23.Width = 35;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "C1";
            this.columnHeader24.Width = 35;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "C2";
            this.columnHeader25.Width = 35;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "C3";
            this.columnHeader26.Width = 35;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "C4";
            this.columnHeader27.Width = 35;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "C5";
            this.columnHeader28.Width = 35;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Mut (F)";
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Mut (M)";
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "Rig1";
            this.columnHeader33.Width = 100;
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "Rig2";
            this.columnHeader34.Width = 100;
            // 
            // tpgLeaderboard
            // 
            this.tpgLeaderboard.Controls.Add(this.cboLeaderboardPlayer);
            this.tpgLeaderboard.Controls.Add(this.lblMissionPlayer);
            this.tpgLeaderboard.Controls.Add(this.lvwLeaderboardSummary);
            this.tpgLeaderboard.Controls.Add(this.lvwLeaderboard);
            this.tpgLeaderboard.Controls.Add(this.cboLeaderboardMission);
            this.tpgLeaderboard.Controls.Add(this.lblLeaderboardMission);
            this.tpgLeaderboard.Controls.Add(this.cboLeaderboardTribe);
            this.tpgLeaderboard.Controls.Add(this.lblLeaderboardTribe);
            this.tpgLeaderboard.Location = new System.Drawing.Point(4, 24);
            this.tpgLeaderboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgLeaderboard.Name = "tpgLeaderboard";
            this.tpgLeaderboard.Size = new System.Drawing.Size(1104, 520);
            this.tpgLeaderboard.TabIndex = 8;
            this.tpgLeaderboard.Text = "Leaderboard";
            this.tpgLeaderboard.UseVisualStyleBackColor = true;
            // 
            // cboLeaderboardPlayer
            // 
            this.cboLeaderboardPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLeaderboardPlayer.FormattingEnabled = true;
            this.cboLeaderboardPlayer.Location = new System.Drawing.Point(469, 243);
            this.cboLeaderboardPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboLeaderboardPlayer.Name = "cboLeaderboardPlayer";
            this.cboLeaderboardPlayer.Size = new System.Drawing.Size(279, 23);
            this.cboLeaderboardPlayer.TabIndex = 18;
            this.cboLeaderboardPlayer.SelectedIndexChanged += new System.EventHandler(this.cboLeaderboardPlayer_SelectedIndexChanged);
            // 
            // lblMissionPlayer
            // 
            this.lblMissionPlayer.AutoSize = true;
            this.lblMissionPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMissionPlayer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMissionPlayer.Location = new System.Drawing.Point(401, 248);
            this.lblMissionPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMissionPlayer.Name = "lblMissionPlayer";
            this.lblMissionPlayer.Size = new System.Drawing.Size(46, 13);
            this.lblMissionPlayer.TabIndex = 17;
            this.lblMissionPlayer.Text = "Player:";
            // 
            // lvwLeaderboardSummary
            // 
            this.lvwLeaderboardSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwLeaderboardSummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader32,
            this.columnHeader35,
            this.columnHeader36});
            this.lvwLeaderboardSummary.ContextMenuStrip = this.mnuContext;
            this.lvwLeaderboardSummary.FullRowSelect = true;
            this.lvwLeaderboardSummary.Location = new System.Drawing.Point(14, 67);
            this.lvwLeaderboardSummary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwLeaderboardSummary.MultiSelect = false;
            this.lvwLeaderboardSummary.Name = "lvwLeaderboardSummary";
            this.lvwLeaderboardSummary.Size = new System.Drawing.Size(1073, 164);
            this.lvwLeaderboardSummary.TabIndex = 16;
            this.lvwLeaderboardSummary.UseCompatibleStateImageBehavior = false;
            this.lvwLeaderboardSummary.View = System.Windows.Forms.View.Details;
            this.lvwLeaderboardSummary.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwLeaderboardSummary_ColumnClick);
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "Tribe";
            this.columnHeader32.Width = 170;
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "Player";
            this.columnHeader35.Width = 179;
            // 
            // columnHeader36
            // 
            this.columnHeader36.Text = "Mission Count";
            this.columnHeader36.Width = 113;
            // 
            // lvwLeaderboard
            // 
            this.lvwLeaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwLeaderboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwLeaderboard_Mission,
            this.lvwLeaderboard_Tribe,
            this.lvwLeaderboard_Player,
            this.lvwLeaderboard_Score});
            this.lvwLeaderboard.ContextMenuStrip = this.mnuContext;
            this.lvwLeaderboard.FullRowSelect = true;
            this.lvwLeaderboard.Location = new System.Drawing.Point(14, 276);
            this.lvwLeaderboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwLeaderboard.MultiSelect = false;
            this.lvwLeaderboard.Name = "lvwLeaderboard";
            this.lvwLeaderboard.Size = new System.Drawing.Size(1073, 221);
            this.lvwLeaderboard.TabIndex = 15;
            this.lvwLeaderboard.UseCompatibleStateImageBehavior = false;
            this.lvwLeaderboard.View = System.Windows.Forms.View.Details;
            this.lvwLeaderboard.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwLeaderboard_ColumnClick);
            // 
            // lvwLeaderboard_Mission
            // 
            this.lvwLeaderboard_Mission.Text = "Mission";
            this.lvwLeaderboard_Mission.Width = 350;
            // 
            // lvwLeaderboard_Tribe
            // 
            this.lvwLeaderboard_Tribe.Text = "Tribe";
            this.lvwLeaderboard_Tribe.Width = 170;
            // 
            // lvwLeaderboard_Player
            // 
            this.lvwLeaderboard_Player.Text = "Player";
            this.lvwLeaderboard_Player.Width = 179;
            // 
            // lvwLeaderboard_Score
            // 
            this.lvwLeaderboard_Score.Text = "Score";
            this.lvwLeaderboard_Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lvwLeaderboard_Score.Width = 77;
            // 
            // cboLeaderboardMission
            // 
            this.cboLeaderboardMission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLeaderboardMission.FormattingEnabled = true;
            this.cboLeaderboardMission.Location = new System.Drawing.Point(80, 243);
            this.cboLeaderboardMission.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboLeaderboardMission.Name = "cboLeaderboardMission";
            this.cboLeaderboardMission.Size = new System.Drawing.Size(279, 23);
            this.cboLeaderboardMission.TabIndex = 9;
            this.cboLeaderboardMission.SelectedIndexChanged += new System.EventHandler(this.cboLeaderboardMission_SelectedIndexChanged);
            // 
            // lblLeaderboardMission
            // 
            this.lblLeaderboardMission.AutoSize = true;
            this.lblLeaderboardMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLeaderboardMission.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblLeaderboardMission.Location = new System.Drawing.Point(13, 248);
            this.lblLeaderboardMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeaderboardMission.Name = "lblLeaderboardMission";
            this.lblLeaderboardMission.Size = new System.Drawing.Size(53, 13);
            this.lblLeaderboardMission.TabIndex = 8;
            this.lblLeaderboardMission.Text = "Mission:";
            // 
            // cboLeaderboardTribe
            // 
            this.cboLeaderboardTribe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLeaderboardTribe.FormattingEnabled = true;
            this.cboLeaderboardTribe.Location = new System.Drawing.Point(80, 31);
            this.cboLeaderboardTribe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboLeaderboardTribe.Name = "cboLeaderboardTribe";
            this.cboLeaderboardTribe.Size = new System.Drawing.Size(279, 23);
            this.cboLeaderboardTribe.TabIndex = 5;
            this.cboLeaderboardTribe.SelectedIndexChanged += new System.EventHandler(this.cboLeaderboardTribe_SelectedIndexChanged);
            // 
            // lblLeaderboardTribe
            // 
            this.lblLeaderboardTribe.AutoSize = true;
            this.lblLeaderboardTribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLeaderboardTribe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblLeaderboardTribe.Location = new System.Drawing.Point(13, 36);
            this.lblLeaderboardTribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeaderboardTribe.Name = "lblLeaderboardTribe";
            this.lblLeaderboardTribe.Size = new System.Drawing.Size(40, 13);
            this.lblLeaderboardTribe.TabIndex = 4;
            this.lblLeaderboardTribe.Text = "Tribe:";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblStatus.Location = new System.Drawing.Point(19, 635);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(908, 58);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Loading...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(15, 1);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ASV";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSubTitle.Location = new System.Drawing.Point(19, 38);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(189, 16);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "ARK Savegame Visualiser";
            // 
            // lblMapTypeName
            // 
            this.lblMapTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMapTypeName.BackColor = System.Drawing.Color.Transparent;
            this.lblMapTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMapTypeName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMapTypeName.Location = new System.Drawing.Point(532, 30);
            this.lblMapTypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMapTypeName.Name = "lblMapTypeName";
            this.lblMapTypeName.Size = new System.Drawing.Size(588, 21);
            this.lblMapTypeName.TabIndex = 4;
            this.lblMapTypeName.Text = "Unknown Data";
            this.lblMapTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblVersion.Location = new System.Drawing.Point(92, 16);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(31, 16);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "v0.0";
            // 
            // lblMap
            // 
            this.lblMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMap.AutoSize = true;
            this.lblMap.BackColor = System.Drawing.Color.Transparent;
            this.lblMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMap.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMap.Location = new System.Drawing.Point(775, 82);
            this.lblMap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(89, 13);
            this.lblMap.TabIndex = 25;
            this.lblMap.Text = "Selected Map:";
            // 
            // cboSelectedMap
            // 
            this.cboSelectedMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSelectedMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectedMap.FormattingEnabled = true;
            this.cboSelectedMap.Location = new System.Drawing.Point(878, 77);
            this.cboSelectedMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboSelectedMap.Name = "cboSelectedMap";
            this.cboSelectedMap.Size = new System.Drawing.Size(241, 23);
            this.cboSelectedMap.TabIndex = 26;
            this.cboSelectedMap.SelectedIndexChanged += new System.EventHandler(this.cboSelectedMap_SelectedIndexChanged);
            // 
            // frmViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1136, 705);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.cboSelectedMap);
            this.Controls.Add(this.lblMapTypeName);
            this.Controls.Add(this.lblMapDate);
            this.Controls.Add(this.btnViewMap);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tabFeatures);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1152, 744);
            this.Name = "frmViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARK Savegame Visualiser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmViewer_FormClosed);
            this.ResizeEnd += new System.EventHandler(this.frmViewer_ResizeEnd);
            this.LocationChanged += new System.EventHandler(this.frmViewer_LocationChanged);
            this.Enter += new System.EventHandler(this.frmViewer_Enter);
            this.Resize += new System.EventHandler(this.frmViewer_Resize);
            this.mnuContext.ResumeLayout(false);
            this.tabFeatures.ResumeLayout(false);
            this.tpgWild.ResumeLayout(false);
            this.tpgWild.PerformLayout();
            this.pnlFilterWilds.ResumeLayout(false);
            this.pnlFilterWilds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udWildRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWildLon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWildLat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWildMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWildMax)).EndInit();
            this.tpgTamed.ResumeLayout(false);
            this.tpgTamed.PerformLayout();
            this.pnlFilterTamed.ResumeLayout(false);
            this.pnlFilterTamed.PerformLayout();
            this.pnlTameStatTypes.ResumeLayout(false);
            this.pnlTameStatTypes.PerformLayout();
            this.tpgStructures.ResumeLayout(false);
            this.tpgStructures.PerformLayout();
            this.pnlFilterStructures.ResumeLayout(false);
            this.pnlFilterStructures.PerformLayout();
            this.tpgTribes.ResumeLayout(false);
            this.tpgTribes.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlFilterTribes.ResumeLayout(false);
            this.pnlFilterTribes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udChartTop)).EndInit();
            this.tpgPlayers.ResumeLayout(false);
            this.tpgPlayers.PerformLayout();
            this.pnlFilterPlayers.ResumeLayout(false);
            this.pnlFilterPlayers.PerformLayout();
            this.tpgDroppedItems.ResumeLayout(false);
            this.tpgDroppedItems.PerformLayout();
            this.pnlFilterDropped.ResumeLayout(false);
            this.pnlFilterDropped.PerformLayout();
            this.tpgItemList.ResumeLayout(false);
            this.tpgItemList.PerformLayout();
            this.pnlFilterSearch.ResumeLayout(false);
            this.pnlFilterSearch.PerformLayout();
            this.tpgLocalProfile.ResumeLayout(false);
            this.tpgLocalProfile.PerformLayout();
            this.pnlUploadedStats.ResumeLayout(false);
            this.pnlUploadedStats.PerformLayout();
            this.tpgLeaderboard.ResumeLayout(false);
            this.tpgLeaderboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvwWildDetail;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Name;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Sex;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Base;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_HP;
        private System.Windows.Forms.Label lblWildTotal;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Stam;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Melee;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Weight;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Speed;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Food;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Oxygen;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Craft;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Lat;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Lon;
        private System.Windows.Forms.Label lblMapDate;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Level;
        private System.Windows.Forms.ComboBox cboWildClass;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl tabFeatures;
        private System.Windows.Forms.TabPage tpgWild;
        private System.Windows.Forms.TabPage tpgPlayers;
        private System.Windows.Forms.Label lblPlayersPlayer;
        private System.Windows.Forms.Label lblPlayersTribe;
        private System.Windows.Forms.ComboBox cboTribes;
        private System.Windows.Forms.ComboBox cboPlayers;
        private System.Windows.Forms.ListView lvwPlayers;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Name;
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
        private System.Windows.Forms.ColumnHeader lvwPlayers_Oxygen;
        private System.Windows.Forms.ColumnHeader lvwPlayers_LastOnline;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Water;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Tribe;
        private System.Windows.Forms.Button btnPlayerInventory;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Crafting;
        private System.Windows.Forms.ColumnHeader lvwPlayers_Fortitude;
        private System.Windows.Forms.Button btnPlayerTribeLog;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabPage tpgStructures;
        private System.Windows.Forms.Label lblStructurePlayer;
        private System.Windows.Forms.Label lblStructureTribe;
        private System.Windows.Forms.ComboBox cboStructureTribe;
        private System.Windows.Forms.ComboBox cboStructurePlayer;
        private System.Windows.Forms.ListView lvwStructureLocations;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_Tribe;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_Structure;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_Lat;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_Lon;
        private System.Windows.Forms.Label lblStructureStructure;
        private System.Windows.Forms.ComboBox cboStructureStructure;
        private System.Windows.Forms.Button btnStructureExclusionFilter;
        private System.Windows.Forms.Label lblCommandPlayer;
        private System.Windows.Forms.ComboBox cboConsoleCommandsPlayerTribe;
        private System.Windows.Forms.Button btnCopyCommandPlayer;
        private System.Windows.Forms.Button btnCopyCommandStructure;
        private System.Windows.Forms.Label lblCommandStructure;
        private System.Windows.Forms.ComboBox cboConsoleCommandsStructure;
        private System.Windows.Forms.TabPage tpgTamed;
        private System.Windows.Forms.Button btnDinoAncestors;
        private System.Windows.Forms.Button btnDinoInventory;
        private System.Windows.Forms.ListView lvwTameDetail;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Name;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Sex;
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
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Tamer;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Imprinter;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Imprint;
        private System.Windows.Forms.Label lblTameTotal;
        private System.Windows.Forms.Panel pnlTameStatTypes;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.RadioButton optStatsTamed;
        private System.Windows.Forms.RadioButton optStatsBase;
        private System.Windows.Forms.ComboBox cboTameClass;
        private System.Windows.Forms.ComboBox cboTameTribes;
        private System.Windows.Forms.ComboBox cboTamePlayers;
        private System.Windows.Forms.Label lblTameCreature;
        private System.Windows.Forms.Label lblTamePlayer;
        private System.Windows.Forms.Label lblTameTribe;
        private System.Windows.Forms.Label lblStructureTotal;
        private System.Windows.Forms.Label lblPlayerTotal;
        private System.Windows.Forms.Label lblWildClass;
        private System.Windows.Forms.Label lblSelectedWildTotal;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Creature;
        private System.Windows.Forms.Button btnCopyCommandWild;
        private System.Windows.Forms.Label lblWildCommand;
        private System.Windows.Forms.ComboBox cboConsoleCommandsWild;
        private System.Windows.Forms.Button btnCopyCommandTamed;
        private System.Windows.Forms.Label lblTamedCommand;
        private System.Windows.Forms.ComboBox cboConsoleCommandsTamed;
        private System.Windows.Forms.ContextMenuStrip mnuContext;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_PlayerId;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_SteamId;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_TribeId;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Cryo;
        private System.Windows.Forms.CheckBox chkCryo;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Colour1;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Colour2;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Colour3;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Colour4;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Colour5;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Colour6;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Colour1;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Colour2;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Colour3;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Colour4;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Colour5;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Colour6;
        private System.Windows.Forms.TabPage tpgDroppedItems;
        private System.Windows.Forms.Button btnCopyCommandDropped;
        private System.Windows.Forms.Label lblCopyCommandDropped;
        private System.Windows.Forms.ComboBox cboCopyCommandDropped;
        private System.Windows.Forms.Label lblCountDropped;
        private System.Windows.Forms.Label lblDroppedItem;
        private System.Windows.Forms.ListView lvwDroppedItems;
        private System.Windows.Forms.ComboBox cboDroppedItem;
        private System.Windows.Forms.Label lblDroppedPlayer;
        private System.Windows.Forms.ComboBox cboDroppedPlayer;
        private System.Windows.Forms.ColumnHeader lvwDroppedItems_Item;
        private System.Windows.Forms.ColumnHeader lvwDroppedItems_DroppedBy;
        private System.Windows.Forms.ColumnHeader lvwDroppedItems_Lat;
        private System.Windows.Forms.ColumnHeader lvwDroppedItems_Lon;
        private System.Windows.Forms.ColumnHeader lvwDroppedItems_Tribe;
        private System.Windows.Forms.ColumnHeader lvwDroppedItems_Player;
        private System.Windows.Forms.Label lblWildMin;
        private System.Windows.Forms.Label lblWildMax;
        private System.Windows.Forms.NumericUpDown udWildMin;
        private System.Windows.Forms.NumericUpDown udWildMax;
        private System.Windows.Forms.TabPage tpgTribes;
        private System.Windows.Forms.Button btnTribeCopyCommand;
        private System.Windows.Forms.Label lblTribeCopyCommand;
        private System.Windows.Forms.ComboBox cboTribeCopyCommand;
        private System.Windows.Forms.Button btnTribeLog;
        private System.Windows.Forms.ListView lvwTribes;
        private System.Windows.Forms.ColumnHeader lvwTribes_Id;
        private System.Windows.Forms.ColumnHeader lvwTribes_Name;
        private System.Windows.Forms.ColumnHeader lvwTribes_Players;
        private System.Windows.Forms.ColumnHeader lvwTribes_Tames;
        private System.Windows.Forms.ColumnHeader lvwTribes_Structures;
        private System.Windows.Forms.ColumnHeader lvwTribes_Active;
        private System.Windows.Forms.CheckBox chkTribeStructures;
        private System.Windows.Forms.CheckBox chkTribeTames;
        private System.Windows.Forms.CheckBox chkTribePlayers;
        private System.Windows.Forms.Label lblWildRadius;
        private System.Windows.Forms.NumericUpDown udWildRadius;
        private System.Windows.Forms.Label lblWildLon;
        private System.Windows.Forms.NumericUpDown udWildLon;
        private System.Windows.Forms.Label lblWildLat;
        private System.Windows.Forms.NumericUpDown udWildLat;
        private System.Windows.Forms.Button btnStructureInventory;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_Export;
        private System.Windows.Forms.ColumnHeader lvwPlayers_SteamName;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_MutationsFemale;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_MutationsMale;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Server;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Id;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Id;
        private System.Windows.Forms.ColumnHeader lvwPlayers_SteamId;
        private System.Windows.Forms.Button btnDropInventory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Button btnViewMap;
        private System.Windows.Forms.TabPage tpgItemList;
        private System.Windows.Forms.ComboBox cboItemListItem;
        private System.Windows.Forms.Label lblItemListTribe;
        private System.Windows.Forms.ComboBox cboItemListTribe;
        private System.Windows.Forms.Button btnItemListCommand;
        private System.Windows.Forms.Label lblItemListCommand;
        private System.Windows.Forms.ComboBox cboItemListCommand;
        private System.Windows.Forms.Label lblItemListCount;
        private System.Windows.Forms.Label lblItemListItem;
        private System.Windows.Forms.ListView lvwItemList;
        private System.Windows.Forms.ColumnHeader lvwItemList_Tribe;
        private System.Windows.Forms.ColumnHeader lvwItemList_Container;
        private System.Windows.Forms.ColumnHeader lvwItemList_Item;
        private System.Windows.Forms.ColumnHeader lvwItemList_Quantity;
        private System.Windows.Forms.ColumnHeader lvwItemList_Lat;
        private System.Windows.Forms.ColumnHeader lvwItemList_Lon;
        private System.Windows.Forms.Label lblMapTypeName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ComboBox cboWildResource;
        private System.Windows.Forms.Label lblResource;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.ComboBox cboSelectedMap;
        private System.Windows.Forms.ColumnHeader lvwDroppedItems_Bp;
        private System.Windows.Forms.ColumnHeader lvwItemList_BP;
        private System.Windows.Forms.CheckBox chkDroppedBlueprints;
        private System.Windows.Forms.CheckBox chkItemSearchBlueprints;
        private System.Windows.Forms.ComboBox cboTamedResource;
        private System.Windows.Forms.Label lblTameResource;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_LastTime;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_DecayReset;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Scale;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Scale;
        private System.Windows.Forms.Panel pnlFilterWilds;
        private System.Windows.Forms.TextBox txtFilterWild;
        private System.Windows.Forms.Panel pnlFilterTamed;
        private System.Windows.Forms.TextBox txtFilterTamed;
        private System.Windows.Forms.Panel pnlFilterStructures;
        private System.Windows.Forms.TextBox txtFilterStructures;
        private System.Windows.Forms.Panel pnlFilterDropped;
        private System.Windows.Forms.TextBox txtFilterDropped;
        private System.Windows.Forms.Panel pnlFilterSearch;
        private System.Windows.Forms.TextBox txtFilterSearch;
        private System.Windows.Forms.Button btnFindWild;
        private System.Windows.Forms.Button btnFindTamed;
        private System.Windows.Forms.Button btnFindStructures;
        private System.Windows.Forms.Button btnFindDropped;
        private System.Windows.Forms.Button btnFindSearched;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Rig1;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_Rig2;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Rig1;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Rig2;
        private System.Windows.Forms.ColumnHeader lvwItemList_Quality;
        private System.Windows.Forms.ColumnHeader lvwItemList_Rating;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_TribeInRange;
        private System.Windows.Forms.ColumnHeader lvwPlayers_PlayerId;
        private System.Windows.Forms.Panel pnlFilterPlayers;
        private System.Windows.Forms.Button btnFilterPlayer;
        private System.Windows.Forms.TextBox txtFilterPlayer;
        private System.Windows.Forms.Panel pnlFilterTribes;
        private System.Windows.Forms.Button btnFilterTribe;
        private System.Windows.Forms.TextBox txtFilterTribe;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_Structures;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_Tames;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_Players;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Wandering;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_Mating;
        private System.Windows.Forms.TabPage tpgLocalProfile;
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
        private System.Windows.Forms.Label lblUploadedTames;
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
        private System.Windows.Forms.Panel pnlUploadedStats;
        private System.Windows.Forms.Label lblUploadedStats;
        private System.Windows.Forms.RadioButton optUploadedStatsTamed;
        private System.Windows.Forms.RadioButton optUploadedStatsBase;
        private System.Windows.Forms.TabPage tpgLeaderboard;
        private System.Windows.Forms.ListView lvwLeaderboard;
        private System.Windows.Forms.ComboBox cboLeaderboardMission;
        private System.Windows.Forms.Label lblLeaderboardMission;
        private System.Windows.Forms.ComboBox cboLeaderboardTribe;
        private System.Windows.Forms.Label lblLeaderboardTribe;
        private System.Windows.Forms.ColumnHeader lvwLeaderboard_Tribe;
        private System.Windows.Forms.ColumnHeader lvwLeaderboard_Player;
        private System.Windows.Forms.ColumnHeader lvwLeaderboard_Score;
        private System.Windows.Forms.ListView lvwLeaderboardSummary;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.ColumnHeader columnHeader36;
        private System.Windows.Forms.ColumnHeader lvwLeaderboard_Mission;
        private System.Windows.Forms.ComboBox cboLeaderboardPlayer;
        private System.Windows.Forms.Label lblMissionPlayer;
        private System.Windows.Forms.ToolStripMenuItem mnuContext_DinoId;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_DinoId;
        private System.Windows.Forms.ColumnHeader lvwWildDetail_CCC;
        private System.Windows.Forms.ColumnHeader lvwTameDetail_CCC;
        private System.Windows.Forms.ColumnHeader lvwStructureLocations_CCC;
        private System.Windows.Forms.ColumnHeader lvwPlayers_CCC;
        private System.Windows.Forms.ColumnHeader lvwDroppedItems_CCC;
        private System.Windows.Forms.ColumnHeader lvwItemList_CCC;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown udChartTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboChartType;
        private ArkViewer.ChartControl chartTribes;
        private System.Windows.Forms.Button btnSaveChartImage;
    }
}


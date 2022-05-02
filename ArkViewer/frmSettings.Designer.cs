namespace ARKViewer
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tpgMap = new System.Windows.Forms.TabPage();
            this.optApi = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.optContentPack = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoadContentPack = new System.Windows.Forms.Button();
            this.txtContentPackFilename = new System.Windows.Forms.TextBox();
            this.lblSelectedMapContentPack = new System.Windows.Forms.Label();
            this.optOffline = new System.Windows.Forms.RadioButton();
            this.optServer = new System.Windows.Forms.RadioButton();
            this.optSinglePlayer = new System.Windows.Forms.RadioButton();
            this.grpServer = new System.Windows.Forms.GroupBox();
            this.btnEditServer = new System.Windows.Forms.Button();
            this.lblFtpMap = new System.Windows.Forms.Label();
            this.cboFtpMap = new System.Windows.Forms.ComboBox();
            this.btnRemoveServer = new System.Windows.Forms.Button();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.lblFTPServer = new System.Windows.Forms.Label();
            this.cboFTPServer = new System.Windows.Forms.ComboBox();
            this.grpOffline = new System.Windows.Forms.GroupBox();
            this.btnEditARK = new System.Windows.Forms.Button();
            this.btnRemoveARK = new System.Windows.Forms.Button();
            this.btnAddARK = new System.Windows.Forms.Button();
            this.cboLocalARK = new System.Windows.Forms.ComboBox();
            this.lblOfflineSave = new System.Windows.Forms.Label();
            this.grpSinglePlayer = new System.Windows.Forms.GroupBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.chkUpdateNotificationSingle = new System.Windows.Forms.CheckBox();
            this.lblSelectedMapSP = new System.Windows.Forms.Label();
            this.cboMapSinglePlayer = new System.Windows.Forms.ComboBox();
            this.tpgColours = new System.Windows.Forms.TabPage();
            this.grpColoursNotMapped = new System.Windows.Forms.GroupBox();
            this.btnRefreshUnknownColours = new System.Windows.Forms.Button();
            this.lblColourNotMapped = new System.Windows.Forms.Label();
            this.lblHeaderColoursNotMatched = new System.Windows.Forms.Label();
            this.lvwColoursNotMapped = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnColoursNotMatchedAdd = new System.Windows.Forms.Button();
            this.grpColours = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkApplyFilterColours = new System.Windows.Forms.CheckBox();
            this.lblHeaderColours = new System.Windows.Forms.Label();
            this.txtFilterColour = new System.Windows.Forms.TextBox();
            this.btnEditColour = new System.Windows.Forms.Button();
            this.lvwColours = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveColour = new System.Windows.Forms.Button();
            this.btnNewColour = new System.Windows.Forms.Button();
            this.tpgCreatures = new System.Windows.Forms.TabPage();
            this.grpCreaturesNotMapped = new System.Windows.Forms.GroupBox();
            this.btnRefreshUnknownCreatures = new System.Windows.Forms.Button();
            this.btnCreaturesNotMappedAdd = new System.Windows.Forms.Button();
            this.lblCreaturesNotMapped = new System.Windows.Forms.Label();
            this.lblHeaderCreaturesNotMapped = new System.Windows.Forms.Label();
            this.lvwCreaturesNotMapped = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpCreatures = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkApplyFilterDinos = new System.Windows.Forms.CheckBox();
            this.lblHeaderCreatures = new System.Windows.Forms.Label();
            this.txtCreatureFilter = new System.Windows.Forms.TextBox();
            this.lvwDinoClasses = new System.Windows.Forms.ListView();
            this.lvwDinoClasses_ClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwDinoClasses_DisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditDinoClass = new System.Windows.Forms.Button();
            this.btnAddDinoClass = new System.Windows.Forms.Button();
            this.btnRemoveDinoClass = new System.Windows.Forms.Button();
            this.tpgStructures = new System.Windows.Forms.TabPage();
            this.grpStructuresNotMapped = new System.Windows.Forms.GroupBox();
            this.btnRefreshUnknownStructures = new System.Windows.Forms.Button();
            this.btnStructuresNotMappedAdd = new System.Windows.Forms.Button();
            this.lblStructuresNotMapped = new System.Windows.Forms.Label();
            this.lblHeaderStructuresNotMapped = new System.Windows.Forms.Label();
            this.lvwStructuresNotMapped = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpStructures = new System.Windows.Forms.GroupBox();
            this.chkApplyFilterStructures = new System.Windows.Forms.CheckBox();
            this.lblHeaderStructures = new System.Windows.Forms.Label();
            this.txtStructureFilter = new System.Windows.Forms.TextBox();
            this.lvwStructureMap = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditStructure = new System.Windows.Forms.Button();
            this.btnAddStructure = new System.Windows.Forms.Button();
            this.btnRemoveStructure = new System.Windows.Forms.Button();
            this.tpgItems = new System.Windows.Forms.TabPage();
            this.grpItemsNotMatched = new System.Windows.Forms.GroupBox();
            this.btnRefreshUnknownItems = new System.Windows.Forms.Button();
            this.btnItemsNotMatchedAdd = new System.Windows.Forms.Button();
            this.lblItemsNotMatched = new System.Windows.Forms.Label();
            this.lblHeaderItemsNotMatched = new System.Windows.Forms.Label();
            this.lvwItemsNotMatched = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.chkApplyFilterItems = new System.Windows.Forms.CheckBox();
            this.lblHeaderItems = new System.Windows.Forms.Label();
            this.txtItemFilter = new System.Windows.Forms.TextBox();
            this.lvwItemMap = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.tpgExport = new System.Windows.Forms.TabPage();
            this.grpJsonExport = new System.Windows.Forms.GroupBox();
            this.lblExportPlayerStructures = new System.Windows.Forms.Label();
            this.btnJsonExportPlayerStructures = new System.Windows.Forms.Button();
            this.lblExportTamed = new System.Windows.Forms.Label();
            this.btnJsonExportTamed = new System.Windows.Forms.Button();
            this.lblExportPlayers = new System.Windows.Forms.Label();
            this.btnJsonExportPlayers = new System.Windows.Forms.Button();
            this.lblExportTribes = new System.Windows.Forms.Label();
            this.btnJsonExportTribes = new System.Windows.Forms.Button();
            this.lblExportWild = new System.Windows.Forms.Label();
            this.btnJsonExportWild = new System.Windows.Forms.Button();
            this.lblExportAll = new System.Windows.Forms.Label();
            this.btnJsonExportAll = new System.Windows.Forms.Button();
            this.lblHeaderJsonExport = new System.Windows.Forms.Label();
            this.lblJsonFileExport = new System.Windows.Forms.Label();
            this.grpContentPack = new System.Windows.Forms.GroupBox();
            this.chkDroppedItems = new System.Windows.Forms.CheckBox();
            this.chkStructureContents = new System.Windows.Forms.CheckBox();
            this.chkStructureLocations = new System.Windows.Forms.CheckBox();
            this.btnExportContentPack = new System.Windows.Forms.Button();
            this.udExportRadius = new System.Windows.Forms.NumericUpDown();
            this.udExportLon = new System.Windows.Forms.NumericUpDown();
            this.udExportLat = new System.Windows.Forms.NumericUpDown();
            this.lblFilterRad = new System.Windows.Forms.Label();
            this.cboExportPlayer = new System.Windows.Forms.ComboBox();
            this.cboExportTribe = new System.Windows.Forms.ComboBox();
            this.lblFilterLon = new System.Windows.Forms.Label();
            this.lblFilterLat = new System.Windows.Forms.Label();
            this.lblFilterPlayer = new System.Windows.Forms.Label();
            this.lblFilterTribe = new System.Windows.Forms.Label();
            this.lblContentPackFilters = new System.Windows.Forms.Label();
            this.chkPlayerStructures = new System.Windows.Forms.CheckBox();
            this.chkTamedCreatures = new System.Windows.Forms.CheckBox();
            this.chkWildCreatures = new System.Windows.Forms.CheckBox();
            this.lblHeaderConteentPack = new System.Windows.Forms.Label();
            this.lblContentPackOptions = new System.Windows.Forms.Label();
            this.tpgRestService = new System.Windows.Forms.TabPage();
            this.grpService = new System.Windows.Forms.GroupBox();
            this.chkAutostartService = new System.Windows.Forms.CheckBox();
            this.udServicePort = new System.Windows.Forms.NumericUpDown();
            this.lblServiceStatus = new System.Windows.Forms.Label();
            this.txtServiceStatus = new System.Windows.Forms.TextBox();
            this.btnClearServiceLog = new System.Windows.Forms.Button();
            this.txtServiceLog = new System.Windows.Forms.TextBox();
            this.lblServiceActivity = new System.Windows.Forms.Label();
            this.btnStopService = new System.Windows.Forms.Button();
            this.btnStartService = new System.Windows.Forms.Button();
            this.lblService = new System.Windows.Forms.Label();
            this.lblHeaderService = new System.Windows.Forms.Label();
            this.lblServicePort = new System.Windows.Forms.Label();
            this.grpClientAccess = new System.Windows.Forms.GroupBox();
            this.lblClientAccess = new System.Windows.Forms.Label();
            this.chkFilterClient = new System.Windows.Forms.CheckBox();
            this.lblHeaderClientAccess = new System.Windows.Forms.Label();
            this.txtFilterClient = new System.Windows.Forms.TextBox();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.lvwClientAccess = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.tpgOptions = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlCommandExportOptions = new System.Windows.Forms.Panel();
            this.optExportNoSort = new System.Windows.Forms.RadioButton();
            this.optExportSort = new System.Windows.Forms.RadioButton();
            this.lblCommandExportOptionTitle = new System.Windows.Forms.Label();
            this.lblCommandExportDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlFtpSettingsCommands = new System.Windows.Forms.Panel();
            this.optFTPSync = new System.Windows.Forms.RadioButton();
            this.optFTPClean = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPlayerSettingsStuctures = new System.Windows.Forms.Panel();
            this.optPlayerStructureHide = new System.Windows.Forms.RadioButton();
            this.optPlayerStructureShow = new System.Windows.Forms.RadioButton();
            this.lblOptionHeaderStructures = new System.Windows.Forms.Label();
            this.lblOptionTextStructures = new System.Windows.Forms.Label();
            this.pnlPlayerSettingsCommands = new System.Windows.Forms.Panel();
            this.optPlayerCommandsPrefixAdmincheat = new System.Windows.Forms.RadioButton();
            this.optPlayerCommandsPrefixNone = new System.Windows.Forms.RadioButton();
            this.optPlayerCommandsPrefixCheat = new System.Windows.Forms.RadioButton();
            this.lblOptionHeaderCommand = new System.Windows.Forms.Label();
            this.lblOptionTextCommand = new System.Windows.Forms.Label();
            this.pnlPlayerSettingsTames = new System.Windows.Forms.Panel();
            this.optPlayerTameHide = new System.Windows.Forms.RadioButton();
            this.optPlayerTameShow = new System.Windows.Forms.RadioButton();
            this.lblOptionHeaderTames = new System.Windows.Forms.Label();
            this.lblOptionTextTames = new System.Windows.Forms.Label();
            this.pnlPlayerSettingsBody = new System.Windows.Forms.Panel();
            this.optPlayerBodyHide = new System.Windows.Forms.RadioButton();
            this.optPlayerBodyShow = new System.Windows.Forms.RadioButton();
            this.lblOptionHeaderBody = new System.Windows.Forms.Label();
            this.lblOptionTextBody = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pnlDownloadOption = new System.Windows.Forms.Panel();
            this.optDownloadAuto = new System.Windows.Forms.RadioButton();
            this.optDownloadManual = new System.Windows.Forms.RadioButton();
            this.tabSettings.SuspendLayout();
            this.tpgMap.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpServer.SuspendLayout();
            this.grpOffline.SuspendLayout();
            this.grpSinglePlayer.SuspendLayout();
            this.tpgColours.SuspendLayout();
            this.grpColoursNotMapped.SuspendLayout();
            this.grpColours.SuspendLayout();
            this.tpgCreatures.SuspendLayout();
            this.grpCreaturesNotMapped.SuspendLayout();
            this.grpCreatures.SuspendLayout();
            this.tpgStructures.SuspendLayout();
            this.grpStructuresNotMapped.SuspendLayout();
            this.grpStructures.SuspendLayout();
            this.tpgItems.SuspendLayout();
            this.grpItemsNotMatched.SuspendLayout();
            this.grpItems.SuspendLayout();
            this.tpgExport.SuspendLayout();
            this.grpJsonExport.SuspendLayout();
            this.grpContentPack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udExportRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udExportLon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udExportLat)).BeginInit();
            this.tpgRestService.SuspendLayout();
            this.grpService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udServicePort)).BeginInit();
            this.grpClientAccess.SuspendLayout();
            this.tpgOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlCommandExportOptions.SuspendLayout();
            this.pnlFtpSettingsCommands.SuspendLayout();
            this.pnlPlayerSettingsStuctures.SuspendLayout();
            this.pnlPlayerSettingsCommands.SuspendLayout();
            this.pnlPlayerSettingsTames.SuspendLayout();
            this.pnlPlayerSettingsBody.SuspendLayout();
            this.pnlDownloadOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(416, 670);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.Location = new System.Drawing.Point(489, 670);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.ark";
            this.openFileDialog1.Filter = "ARK SaveGame|*.ark";
            this.openFileDialog1.ReadOnlyChecked = true;
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            this.openFileDialog1.Title = "Open ARK Save Game";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tpgMap);
            this.tabSettings.Controls.Add(this.tpgColours);
            this.tabSettings.Controls.Add(this.tpgCreatures);
            this.tabSettings.Controls.Add(this.tpgStructures);
            this.tabSettings.Controls.Add(this.tpgItems);
            this.tabSettings.Controls.Add(this.tpgExport);
            this.tabSettings.Controls.Add(this.tpgRestService);
            this.tabSettings.Controls.Add(this.tpgOptions);
            this.tabSettings.Location = new System.Drawing.Point(12, 12);
            this.tabSettings.Multiline = true;
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(553, 652);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabSettings_Selecting);
            // 
            // tpgMap
            // 
            this.tpgMap.Controls.Add(this.optApi);
            this.tpgMap.Controls.Add(this.groupBox6);
            this.tpgMap.Controls.Add(this.optContentPack);
            this.tpgMap.Controls.Add(this.groupBox2);
            this.tpgMap.Controls.Add(this.optOffline);
            this.tpgMap.Controls.Add(this.optServer);
            this.tpgMap.Controls.Add(this.optSinglePlayer);
            this.tpgMap.Controls.Add(this.grpServer);
            this.tpgMap.Controls.Add(this.grpOffline);
            this.tpgMap.Controls.Add(this.grpSinglePlayer);
            this.tpgMap.Location = new System.Drawing.Point(4, 22);
            this.tpgMap.Name = "tpgMap";
            this.tpgMap.Padding = new System.Windows.Forms.Padding(3);
            this.tpgMap.Size = new System.Drawing.Size(545, 626);
            this.tpgMap.TabIndex = 0;
            this.tpgMap.Text = "Map Data";
            this.tpgMap.UseVisualStyleBackColor = true;
            // 
            // optApi
            // 
            this.optApi.AutoSize = true;
            this.optApi.Enabled = false;
            this.optApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optApi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.optApi.Location = new System.Drawing.Point(43, 475);
            this.optApi.Name = "optApi";
            this.optApi.Size = new System.Drawing.Size(140, 17);
            this.optApi.TabIndex = 8;
            this.optApi.Text = "ASV Hosted Service";
            this.optApi.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.textBox5);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(40, 491);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(471, 95);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "Access Key:";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(97, 58);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(348, 22);
            this.textBox6.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Address:";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(97, 25);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(348, 22);
            this.textBox5.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(-2, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(474, 6);
            this.label13.TabIndex = 0;
            this.label13.Text = "   ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optContentPack
            // 
            this.optContentPack.AutoSize = true;
            this.optContentPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optContentPack.Location = new System.Drawing.Point(40, 237);
            this.optContentPack.Name = "optContentPack";
            this.optContentPack.Size = new System.Drawing.Size(138, 17);
            this.optContentPack.TabIndex = 4;
            this.optContentPack.Text = "Content Pack (.asv)";
            this.optContentPack.UseVisualStyleBackColor = true;
            this.optContentPack.CheckedChanged += new System.EventHandler(this.optContentPack_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoadContentPack);
            this.groupBox2.Controls.Add(this.txtContentPackFilename);
            this.groupBox2.Controls.Add(this.lblSelectedMapContentPack);
            this.groupBox2.Location = new System.Drawing.Point(37, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 83);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnLoadContentPack
            // 
            this.btnLoadContentPack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadContentPack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadContentPack.Image = global::ARKViewer.Properties.Resources.button_folder;
            this.btnLoadContentPack.Location = new System.Drawing.Point(415, 29);
            this.btnLoadContentPack.Name = "btnLoadContentPack";
            this.btnLoadContentPack.Size = new System.Drawing.Size(35, 35);
            this.btnLoadContentPack.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnLoadContentPack, "Open ARK save file");
            this.btnLoadContentPack.UseVisualStyleBackColor = true;
            this.btnLoadContentPack.Click += new System.EventHandler(this.btnLoadContentPack_Click);
            // 
            // txtContentPackFilename
            // 
            this.txtContentPackFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContentPackFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContentPackFilename.Location = new System.Drawing.Point(18, 35);
            this.txtContentPackFilename.Name = "txtContentPackFilename";
            this.txtContentPackFilename.ReadOnly = true;
            this.txtContentPackFilename.Size = new System.Drawing.Size(391, 22);
            this.txtContentPackFilename.TabIndex = 1;
            // 
            // lblSelectedMapContentPack
            // 
            this.lblSelectedMapContentPack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedMapContentPack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSelectedMapContentPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedMapContentPack.Location = new System.Drawing.Point(-2, 6);
            this.lblSelectedMapContentPack.Name = "lblSelectedMapContentPack";
            this.lblSelectedMapContentPack.Size = new System.Drawing.Size(474, 6);
            this.lblSelectedMapContentPack.TabIndex = 0;
            this.lblSelectedMapContentPack.Text = "   ";
            this.lblSelectedMapContentPack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optOffline
            // 
            this.optOffline.AutoSize = true;
            this.optOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optOffline.Location = new System.Drawing.Point(40, 134);
            this.optOffline.Name = "optOffline";
            this.optOffline.Size = new System.Drawing.Size(142, 17);
            this.optOffline.TabIndex = 2;
            this.optOffline.Text = "Savegame File (.ark)";
            this.optOffline.UseVisualStyleBackColor = true;
            this.optOffline.CheckedChanged += new System.EventHandler(this.optOffline_CheckedChanged);
            // 
            // optServer
            // 
            this.optServer.AutoSize = true;
            this.optServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optServer.Location = new System.Drawing.Point(40, 340);
            this.optServer.Name = "optServer";
            this.optServer.Size = new System.Drawing.Size(89, 17);
            this.optServer.TabIndex = 6;
            this.optServer.Text = "FTP Server";
            this.optServer.UseVisualStyleBackColor = true;
            this.optServer.CheckedChanged += new System.EventHandler(this.optServer_CheckedChanged);
            // 
            // optSinglePlayer
            // 
            this.optSinglePlayer.AutoSize = true;
            this.optSinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSinglePlayer.Location = new System.Drawing.Point(40, 28);
            this.optSinglePlayer.Name = "optSinglePlayer";
            this.optSinglePlayer.Size = new System.Drawing.Size(146, 17);
            this.optSinglePlayer.TabIndex = 0;
            this.optSinglePlayer.Text = "Single Player (Steam)";
            this.optSinglePlayer.UseVisualStyleBackColor = true;
            this.optSinglePlayer.CheckedChanged += new System.EventHandler(this.optSinglePlayer_CheckedChanged);
            // 
            // grpServer
            // 
            this.grpServer.Controls.Add(this.btnEditServer);
            this.grpServer.Controls.Add(this.lblFtpMap);
            this.grpServer.Controls.Add(this.cboFtpMap);
            this.grpServer.Controls.Add(this.btnRemoveServer);
            this.grpServer.Controls.Add(this.btnAddServer);
            this.grpServer.Controls.Add(this.lblFTPServer);
            this.grpServer.Controls.Add(this.cboFTPServer);
            this.grpServer.Location = new System.Drawing.Point(38, 360);
            this.grpServer.Name = "grpServer";
            this.grpServer.Size = new System.Drawing.Size(471, 109);
            this.grpServer.TabIndex = 7;
            this.grpServer.TabStop = false;
            // 
            // btnEditServer
            // 
            this.btnEditServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditServer.Enabled = false;
            this.btnEditServer.Image = global::ARKViewer.Properties.Resources.button_edit;
            this.btnEditServer.Location = new System.Drawing.Point(334, 24);
            this.btnEditServer.Name = "btnEditServer";
            this.btnEditServer.Size = new System.Drawing.Size(35, 35);
            this.btnEditServer.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnEditServer, "Edit server");
            this.btnEditServer.UseVisualStyleBackColor = true;
            this.btnEditServer.Click += new System.EventHandler(this.btnEditServer_Click);
            // 
            // lblFtpMap
            // 
            this.lblFtpMap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFtpMap.BackColor = System.Drawing.SystemColors.Control;
            this.lblFtpMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFtpMap.Location = new System.Drawing.Point(21, 66);
            this.lblFtpMap.Name = "lblFtpMap";
            this.lblFtpMap.Size = new System.Drawing.Size(115, 22);
            this.lblFtpMap.TabIndex = 20;
            this.lblFtpMap.Text = "Map";
            this.lblFtpMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboFtpMap
            // 
            this.cboFtpMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFtpMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboFtpMap.Enabled = false;
            this.cboFtpMap.FormattingEnabled = true;
            this.cboFtpMap.Location = new System.Drawing.Point(137, 67);
            this.cboFtpMap.Name = "cboFtpMap";
            this.cboFtpMap.Size = new System.Drawing.Size(310, 21);
            this.cboFtpMap.TabIndex = 19;
            this.cboFtpMap.SelectedIndexChanged += new System.EventHandler(this.cboFtpMap_SelectedIndexChanged);
            // 
            // btnRemoveServer
            // 
            this.btnRemoveServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveServer.Enabled = false;
            this.btnRemoveServer.Image = global::ARKViewer.Properties.Resources.button_remove;
            this.btnRemoveServer.Location = new System.Drawing.Point(414, 24);
            this.btnRemoveServer.Name = "btnRemoveServer";
            this.btnRemoveServer.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveServer.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnRemoveServer, "Remove selected server");
            this.btnRemoveServer.UseVisualStyleBackColor = true;
            this.btnRemoveServer.Click += new System.EventHandler(this.btnRemoveServer_Click);
            // 
            // btnAddServer
            // 
            this.btnAddServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddServer.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnAddServer.Location = new System.Drawing.Point(374, 24);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(35, 35);
            this.btnAddServer.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnAddServer, "Add new server");
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // lblFTPServer
            // 
            this.lblFTPServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFTPServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFTPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFTPServer.Location = new System.Drawing.Point(-1, 0);
            this.lblFTPServer.Name = "lblFTPServer";
            this.lblFTPServer.Size = new System.Drawing.Size(474, 6);
            this.lblFTPServer.TabIndex = 0;
            this.lblFTPServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboFTPServer
            // 
            this.cboFTPServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFTPServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFTPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFTPServer.FormattingEnabled = true;
            this.cboFTPServer.Location = new System.Drawing.Point(25, 30);
            this.cboFTPServer.Name = "cboFTPServer";
            this.cboFTPServer.Size = new System.Drawing.Size(298, 24);
            this.cboFTPServer.TabIndex = 1;
            this.cboFTPServer.SelectedIndexChanged += new System.EventHandler(this.cboFTPServer_SelectedIndexChanged);
            // 
            // grpOffline
            // 
            this.grpOffline.Controls.Add(this.btnEditARK);
            this.grpOffline.Controls.Add(this.btnRemoveARK);
            this.grpOffline.Controls.Add(this.btnAddARK);
            this.grpOffline.Controls.Add(this.cboLocalARK);
            this.grpOffline.Controls.Add(this.lblOfflineSave);
            this.grpOffline.Location = new System.Drawing.Point(37, 148);
            this.grpOffline.Name = "grpOffline";
            this.grpOffline.Size = new System.Drawing.Size(471, 83);
            this.grpOffline.TabIndex = 3;
            this.grpOffline.TabStop = false;
            // 
            // btnEditARK
            // 
            this.btnEditARK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditARK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditARK.Enabled = false;
            this.btnEditARK.Image = global::ARKViewer.Properties.Resources.button_edit;
            this.btnEditARK.Location = new System.Drawing.Point(332, 28);
            this.btnEditARK.Name = "btnEditARK";
            this.btnEditARK.Size = new System.Drawing.Size(35, 35);
            this.btnEditARK.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnEditARK, "Edit details");
            this.btnEditARK.UseVisualStyleBackColor = true;
            this.btnEditARK.Click += new System.EventHandler(this.btnEditARK_Click);
            // 
            // btnRemoveARK
            // 
            this.btnRemoveARK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveARK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveARK.Enabled = false;
            this.btnRemoveARK.Image = global::ARKViewer.Properties.Resources.button_remove;
            this.btnRemoveARK.Location = new System.Drawing.Point(413, 28);
            this.btnRemoveARK.Name = "btnRemoveARK";
            this.btnRemoveARK.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveARK.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnRemoveARK, "Remove selected offline file.");
            this.btnRemoveARK.UseVisualStyleBackColor = true;
            this.btnRemoveARK.Click += new System.EventHandler(this.btnRemoveARK_Click);
            // 
            // btnAddARK
            // 
            this.btnAddARK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddARK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddARK.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnAddARK.Location = new System.Drawing.Point(373, 28);
            this.btnAddARK.Name = "btnAddARK";
            this.btnAddARK.Size = new System.Drawing.Size(35, 35);
            this.btnAddARK.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnAddARK, "Add new offline file.");
            this.btnAddARK.UseVisualStyleBackColor = true;
            this.btnAddARK.Click += new System.EventHandler(this.btnAddARK_Click);
            // 
            // cboLocalARK
            // 
            this.cboLocalARK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLocalARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocalARK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocalARK.FormattingEnabled = true;
            this.cboLocalARK.Location = new System.Drawing.Point(18, 34);
            this.cboLocalARK.Name = "cboLocalARK";
            this.cboLocalARK.Size = new System.Drawing.Size(306, 24);
            this.cboLocalARK.TabIndex = 5;
            this.cboLocalARK.SelectedIndexChanged += new System.EventHandler(this.cboLocalARK_SelectedIndexChanged);
            // 
            // lblOfflineSave
            // 
            this.lblOfflineSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOfflineSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblOfflineSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfflineSave.Location = new System.Drawing.Point(-2, 6);
            this.lblOfflineSave.Name = "lblOfflineSave";
            this.lblOfflineSave.Size = new System.Drawing.Size(474, 6);
            this.lblOfflineSave.TabIndex = 0;
            this.lblOfflineSave.Text = "   ";
            this.lblOfflineSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpSinglePlayer
            // 
            this.grpSinglePlayer.Controls.Add(this.btnSelectFolder);
            this.grpSinglePlayer.Controls.Add(this.chkUpdateNotificationSingle);
            this.grpSinglePlayer.Controls.Add(this.lblSelectedMapSP);
            this.grpSinglePlayer.Controls.Add(this.cboMapSinglePlayer);
            this.grpSinglePlayer.Location = new System.Drawing.Point(36, 42);
            this.grpSinglePlayer.Name = "grpSinglePlayer";
            this.grpSinglePlayer.Size = new System.Drawing.Size(472, 85);
            this.grpSinglePlayer.TabIndex = 1;
            this.grpSinglePlayer.TabStop = false;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectFolder.Enabled = false;
            this.btnSelectFolder.Image = global::ARKViewer.Properties.Resources.button_folder;
            this.btnSelectFolder.Location = new System.Drawing.Point(414, 26);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(35, 35);
            this.btnSelectFolder.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSelectFolder, "Select ARK save location.");
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // chkUpdateNotificationSingle
            // 
            this.chkUpdateNotificationSingle.AutoSize = true;
            this.chkUpdateNotificationSingle.Enabled = false;
            this.chkUpdateNotificationSingle.Location = new System.Drawing.Point(19, 64);
            this.chkUpdateNotificationSingle.Name = "chkUpdateNotificationSingle";
            this.chkUpdateNotificationSingle.Size = new System.Drawing.Size(120, 17);
            this.chkUpdateNotificationSingle.TabIndex = 2;
            this.chkUpdateNotificationSingle.Text = "Update notifications";
            this.chkUpdateNotificationSingle.UseVisualStyleBackColor = true;
            this.chkUpdateNotificationSingle.Visible = false;
            // 
            // lblSelectedMapSP
            // 
            this.lblSelectedMapSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedMapSP.BackColor = System.Drawing.Color.Aqua;
            this.lblSelectedMapSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedMapSP.Location = new System.Drawing.Point(-2, 6);
            this.lblSelectedMapSP.Name = "lblSelectedMapSP";
            this.lblSelectedMapSP.Size = new System.Drawing.Size(475, 6);
            this.lblSelectedMapSP.TabIndex = 0;
            this.lblSelectedMapSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboMapSinglePlayer
            // 
            this.cboMapSinglePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMapSinglePlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMapSinglePlayer.FormattingEnabled = true;
            this.cboMapSinglePlayer.Location = new System.Drawing.Point(19, 34);
            this.cboMapSinglePlayer.Name = "cboMapSinglePlayer";
            this.cboMapSinglePlayer.Size = new System.Drawing.Size(391, 21);
            this.cboMapSinglePlayer.TabIndex = 1;
            this.cboMapSinglePlayer.SelectedIndexChanged += new System.EventHandler(this.cboMapSinglePlayer_SelectedIndexChanged);
            // 
            // tpgColours
            // 
            this.tpgColours.Controls.Add(this.grpColoursNotMapped);
            this.tpgColours.Controls.Add(this.grpColours);
            this.tpgColours.Location = new System.Drawing.Point(4, 22);
            this.tpgColours.Name = "tpgColours";
            this.tpgColours.Size = new System.Drawing.Size(545, 626);
            this.tpgColours.TabIndex = 5;
            this.tpgColours.Text = "Colours";
            this.tpgColours.UseVisualStyleBackColor = true;
            // 
            // grpColoursNotMapped
            // 
            this.grpColoursNotMapped.Controls.Add(this.btnRefreshUnknownColours);
            this.grpColoursNotMapped.Controls.Add(this.lblColourNotMapped);
            this.grpColoursNotMapped.Controls.Add(this.lblHeaderColoursNotMatched);
            this.grpColoursNotMapped.Controls.Add(this.lvwColoursNotMapped);
            this.grpColoursNotMapped.Controls.Add(this.btnColoursNotMatchedAdd);
            this.grpColoursNotMapped.Location = new System.Drawing.Point(18, 348);
            this.grpColoursNotMapped.Name = "grpColoursNotMapped";
            this.grpColoursNotMapped.Size = new System.Drawing.Size(508, 256);
            this.grpColoursNotMapped.TabIndex = 1;
            this.grpColoursNotMapped.TabStop = false;
            // 
            // btnRefreshUnknownColours
            // 
            this.btnRefreshUnknownColours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshUnknownColours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshUnknownColours.Image = global::ARKViewer.Properties.Resources.button_refresh;
            this.btnRefreshUnknownColours.Location = new System.Drawing.Point(13, 212);
            this.btnRefreshUnknownColours.Name = "btnRefreshUnknownColours";
            this.btnRefreshUnknownColours.Size = new System.Drawing.Size(35, 35);
            this.btnRefreshUnknownColours.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnRefreshUnknownColours, "Add mapping");
            this.btnRefreshUnknownColours.UseVisualStyleBackColor = true;
            this.btnRefreshUnknownColours.Click += new System.EventHandler(this.btnRefreshUnknownColours_Click);
            // 
            // lblColourNotMapped
            // 
            this.lblColourNotMapped.BackColor = System.Drawing.Color.Transparent;
            this.lblColourNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourNotMapped.Location = new System.Drawing.Point(10, 16);
            this.lblColourNotMapped.Name = "lblColourNotMapped";
            this.lblColourNotMapped.Size = new System.Drawing.Size(198, 22);
            this.lblColourNotMapped.TabIndex = 1;
            this.lblColourNotMapped.Text = "Not Mapped";
            this.lblColourNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderColoursNotMatched
            // 
            this.lblHeaderColoursNotMatched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderColoursNotMatched.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHeaderColoursNotMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderColoursNotMatched.Location = new System.Drawing.Point(-2, 6);
            this.lblHeaderColoursNotMatched.Name = "lblHeaderColoursNotMatched";
            this.lblHeaderColoursNotMatched.Size = new System.Drawing.Size(511, 6);
            this.lblHeaderColoursNotMatched.TabIndex = 0;
            this.lblHeaderColoursNotMatched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwColoursNotMapped
            // 
            this.lvwColoursNotMapped.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwColoursNotMapped.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9});
            this.lvwColoursNotMapped.FullRowSelect = true;
            this.lvwColoursNotMapped.HideSelection = false;
            this.lvwColoursNotMapped.Location = new System.Drawing.Point(13, 45);
            this.lvwColoursNotMapped.Name = "lvwColoursNotMapped";
            this.lvwColoursNotMapped.Size = new System.Drawing.Size(485, 162);
            this.lvwColoursNotMapped.TabIndex = 2;
            this.lvwColoursNotMapped.UseCompatibleStateImageBehavior = false;
            this.lvwColoursNotMapped.View = System.Windows.Forms.View.Details;
            this.lvwColoursNotMapped.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwColoursNotMapped_ColumnClick);
            this.lvwColoursNotMapped.SelectedIndexChanged += new System.EventHandler(this.lvwColoursNotMapped_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Detected Colour Id";
            this.columnHeader9.Width = 400;
            // 
            // btnColoursNotMatchedAdd
            // 
            this.btnColoursNotMatchedAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColoursNotMatchedAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColoursNotMatchedAdd.Enabled = false;
            this.btnColoursNotMatchedAdd.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnColoursNotMatchedAdd.Location = new System.Drawing.Point(464, 212);
            this.btnColoursNotMatchedAdd.Name = "btnColoursNotMatchedAdd";
            this.btnColoursNotMatchedAdd.Size = new System.Drawing.Size(35, 35);
            this.btnColoursNotMatchedAdd.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnColoursNotMatchedAdd, "Add mapping");
            this.btnColoursNotMatchedAdd.UseVisualStyleBackColor = true;
            this.btnColoursNotMatchedAdd.Click += new System.EventHandler(this.btnColoursNotMatchedAdd_Click);
            // 
            // grpColours
            // 
            this.grpColours.Controls.Add(this.label1);
            this.grpColours.Controls.Add(this.chkApplyFilterColours);
            this.grpColours.Controls.Add(this.lblHeaderColours);
            this.grpColours.Controls.Add(this.txtFilterColour);
            this.grpColours.Controls.Add(this.btnEditColour);
            this.grpColours.Controls.Add(this.lvwColours);
            this.grpColours.Controls.Add(this.btnRemoveColour);
            this.grpColours.Controls.Add(this.btnNewColour);
            this.grpColours.Location = new System.Drawing.Point(18, 10);
            this.grpColours.Name = "grpColours";
            this.grpColours.Size = new System.Drawing.Size(508, 332);
            this.grpColours.TabIndex = 0;
            this.grpColours.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mapped";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkApplyFilterColours
            // 
            this.chkApplyFilterColours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkApplyFilterColours.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkApplyFilterColours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkApplyFilterColours.Image = global::ARKViewer.Properties.Resources.button_filter;
            this.chkApplyFilterColours.Location = new System.Drawing.Point(425, 287);
            this.chkApplyFilterColours.Name = "chkApplyFilterColours";
            this.chkApplyFilterColours.Size = new System.Drawing.Size(35, 35);
            this.chkApplyFilterColours.TabIndex = 5;
            this.toolTip1.SetToolTip(this.chkApplyFilterColours, "Apply filter");
            this.chkApplyFilterColours.UseVisualStyleBackColor = true;
            this.chkApplyFilterColours.CheckedChanged += new System.EventHandler(this.chkApplyFilterColours_CheckedChanged);
            // 
            // lblHeaderColours
            // 
            this.lblHeaderColours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderColours.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderColours.Location = new System.Drawing.Point(-2, 6);
            this.lblHeaderColours.Name = "lblHeaderColours";
            this.lblHeaderColours.Size = new System.Drawing.Size(511, 6);
            this.lblHeaderColours.TabIndex = 0;
            this.lblHeaderColours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFilterColour
            // 
            this.txtFilterColour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterColour.Location = new System.Drawing.Point(92, 294);
            this.txtFilterColour.Name = "txtFilterColour";
            this.txtFilterColour.Size = new System.Drawing.Size(327, 20);
            this.txtFilterColour.TabIndex = 4;
            // 
            // btnEditColour
            // 
            this.btnEditColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditColour.Enabled = false;
            this.btnEditColour.Image = ((System.Drawing.Image)(resources.GetObject("btnEditColour.Image")));
            this.btnEditColour.Location = new System.Drawing.Point(465, 287);
            this.btnEditColour.Name = "btnEditColour";
            this.btnEditColour.Size = new System.Drawing.Size(35, 35);
            this.btnEditColour.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnEditColour, "Edit display name");
            this.btnEditColour.UseVisualStyleBackColor = true;
            this.btnEditColour.Click += new System.EventHandler(this.btnEditColour_Click);
            // 
            // lvwColours
            // 
            this.lvwColours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwColours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader7,
            this.columnHeader8});
            this.lvwColours.FullRowSelect = true;
            this.lvwColours.HideSelection = false;
            this.lvwColours.Location = new System.Drawing.Point(13, 45);
            this.lvwColours.Name = "lvwColours";
            this.lvwColours.Size = new System.Drawing.Size(485, 236);
            this.lvwColours.TabIndex = 1;
            this.lvwColours.UseCompatibleStateImageBehavior = false;
            this.lvwColours.View = System.Windows.Forms.View.Details;
            this.lvwColours.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwColours_ColumnClick);
            this.lvwColours.SelectedIndexChanged += new System.EventHandler(this.lvwColours_SelectedIndexChanged);
            this.lvwColours.Click += new System.EventHandler(this.lvwColours_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Hex";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Colour";
            this.columnHeader8.Width = 297;
            // 
            // btnRemoveColour
            // 
            this.btnRemoveColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveColour.Enabled = false;
            this.btnRemoveColour.Image = global::ARKViewer.Properties.Resources.button_remove;
            this.btnRemoveColour.Location = new System.Drawing.Point(52, 287);
            this.btnRemoveColour.Name = "btnRemoveColour";
            this.btnRemoveColour.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveColour.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnRemoveColour, "Remove mapping");
            this.btnRemoveColour.UseVisualStyleBackColor = true;
            this.btnRemoveColour.Click += new System.EventHandler(this.btnRemoveColour_Click);
            // 
            // btnNewColour
            // 
            this.btnNewColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewColour.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnNewColour.Location = new System.Drawing.Point(13, 287);
            this.btnNewColour.Name = "btnNewColour";
            this.btnNewColour.Size = new System.Drawing.Size(35, 35);
            this.btnNewColour.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnNewColour, "Add new mapping");
            this.btnNewColour.UseVisualStyleBackColor = true;
            this.btnNewColour.Click += new System.EventHandler(this.btnNewColour_Click);
            // 
            // tpgCreatures
            // 
            this.tpgCreatures.Controls.Add(this.grpCreaturesNotMapped);
            this.tpgCreatures.Controls.Add(this.grpCreatures);
            this.tpgCreatures.Location = new System.Drawing.Point(4, 22);
            this.tpgCreatures.Name = "tpgCreatures";
            this.tpgCreatures.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCreatures.Size = new System.Drawing.Size(545, 626);
            this.tpgCreatures.TabIndex = 1;
            this.tpgCreatures.Text = "Creatures";
            this.tpgCreatures.UseVisualStyleBackColor = true;
            // 
            // grpCreaturesNotMapped
            // 
            this.grpCreaturesNotMapped.Controls.Add(this.btnRefreshUnknownCreatures);
            this.grpCreaturesNotMapped.Controls.Add(this.btnCreaturesNotMappedAdd);
            this.grpCreaturesNotMapped.Controls.Add(this.lblCreaturesNotMapped);
            this.grpCreaturesNotMapped.Controls.Add(this.lblHeaderCreaturesNotMapped);
            this.grpCreaturesNotMapped.Controls.Add(this.lvwCreaturesNotMapped);
            this.grpCreaturesNotMapped.Location = new System.Drawing.Point(18, 348);
            this.grpCreaturesNotMapped.Name = "grpCreaturesNotMapped";
            this.grpCreaturesNotMapped.Size = new System.Drawing.Size(508, 256);
            this.grpCreaturesNotMapped.TabIndex = 1;
            this.grpCreaturesNotMapped.TabStop = false;
            // 
            // btnRefreshUnknownCreatures
            // 
            this.btnRefreshUnknownCreatures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshUnknownCreatures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshUnknownCreatures.Image = global::ARKViewer.Properties.Resources.button_refresh;
            this.btnRefreshUnknownCreatures.Location = new System.Drawing.Point(13, 212);
            this.btnRefreshUnknownCreatures.Name = "btnRefreshUnknownCreatures";
            this.btnRefreshUnknownCreatures.Size = new System.Drawing.Size(35, 35);
            this.btnRefreshUnknownCreatures.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnRefreshUnknownCreatures, "Add mapping");
            this.btnRefreshUnknownCreatures.UseVisualStyleBackColor = true;
            this.btnRefreshUnknownCreatures.Click += new System.EventHandler(this.btnRefreshUnknownCreatures_Click);
            // 
            // btnCreaturesNotMappedAdd
            // 
            this.btnCreaturesNotMappedAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreaturesNotMappedAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreaturesNotMappedAdd.Enabled = false;
            this.btnCreaturesNotMappedAdd.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnCreaturesNotMappedAdd.Location = new System.Drawing.Point(464, 212);
            this.btnCreaturesNotMappedAdd.Name = "btnCreaturesNotMappedAdd";
            this.btnCreaturesNotMappedAdd.Size = new System.Drawing.Size(35, 35);
            this.btnCreaturesNotMappedAdd.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCreaturesNotMappedAdd, "Add mapping");
            this.btnCreaturesNotMappedAdd.UseVisualStyleBackColor = true;
            this.btnCreaturesNotMappedAdd.Click += new System.EventHandler(this.btnCreaturesNotMappedAdd_Click);
            // 
            // lblCreaturesNotMapped
            // 
            this.lblCreaturesNotMapped.BackColor = System.Drawing.Color.Transparent;
            this.lblCreaturesNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreaturesNotMapped.Location = new System.Drawing.Point(10, 16);
            this.lblCreaturesNotMapped.Name = "lblCreaturesNotMapped";
            this.lblCreaturesNotMapped.Size = new System.Drawing.Size(198, 22);
            this.lblCreaturesNotMapped.TabIndex = 1;
            this.lblCreaturesNotMapped.Text = "Not Mapped";
            this.lblCreaturesNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderCreaturesNotMapped
            // 
            this.lblHeaderCreaturesNotMapped.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderCreaturesNotMapped.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHeaderCreaturesNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderCreaturesNotMapped.Location = new System.Drawing.Point(-2, 6);
            this.lblHeaderCreaturesNotMapped.Name = "lblHeaderCreaturesNotMapped";
            this.lblHeaderCreaturesNotMapped.Size = new System.Drawing.Size(511, 6);
            this.lblHeaderCreaturesNotMapped.TabIndex = 0;
            this.lblHeaderCreaturesNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwCreaturesNotMapped
            // 
            this.lvwCreaturesNotMapped.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12});
            this.lvwCreaturesNotMapped.FullRowSelect = true;
            this.lvwCreaturesNotMapped.HideSelection = false;
            this.lvwCreaturesNotMapped.Location = new System.Drawing.Point(13, 45);
            this.lvwCreaturesNotMapped.Name = "lvwCreaturesNotMapped";
            this.lvwCreaturesNotMapped.Size = new System.Drawing.Size(485, 162);
            this.lvwCreaturesNotMapped.TabIndex = 2;
            this.lvwCreaturesNotMapped.UseCompatibleStateImageBehavior = false;
            this.lvwCreaturesNotMapped.View = System.Windows.Forms.View.Details;
            this.lvwCreaturesNotMapped.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwCreaturesNotMapped_ColumnClick);
            this.lvwCreaturesNotMapped.SelectedIndexChanged += new System.EventHandler(this.lvwCreaturesNotMapped_SelectedIndexChanged);
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Detected Class Name";
            this.columnHeader12.Width = 450;
            // 
            // grpCreatures
            // 
            this.grpCreatures.Controls.Add(this.label6);
            this.grpCreatures.Controls.Add(this.chkApplyFilterDinos);
            this.grpCreatures.Controls.Add(this.lblHeaderCreatures);
            this.grpCreatures.Controls.Add(this.txtCreatureFilter);
            this.grpCreatures.Controls.Add(this.lvwDinoClasses);
            this.grpCreatures.Controls.Add(this.btnEditDinoClass);
            this.grpCreatures.Controls.Add(this.btnAddDinoClass);
            this.grpCreatures.Controls.Add(this.btnRemoveDinoClass);
            this.grpCreatures.Location = new System.Drawing.Point(18, 10);
            this.grpCreatures.Name = "grpCreatures";
            this.grpCreatures.Size = new System.Drawing.Size(508, 332);
            this.grpCreatures.TabIndex = 0;
            this.grpCreatures.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mapped";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkApplyFilterDinos
            // 
            this.chkApplyFilterDinos.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkApplyFilterDinos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkApplyFilterDinos.Image = global::ARKViewer.Properties.Resources.button_filter;
            this.chkApplyFilterDinos.Location = new System.Drawing.Point(425, 287);
            this.chkApplyFilterDinos.Name = "chkApplyFilterDinos";
            this.chkApplyFilterDinos.Size = new System.Drawing.Size(35, 35);
            this.chkApplyFilterDinos.TabIndex = 7;
            this.chkApplyFilterDinos.UseVisualStyleBackColor = true;
            this.chkApplyFilterDinos.CheckedChanged += new System.EventHandler(this.chkApplyFilterDinos_CheckedChanged);
            // 
            // lblHeaderCreatures
            // 
            this.lblHeaderCreatures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderCreatures.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderCreatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderCreatures.Location = new System.Drawing.Point(-2, 6);
            this.lblHeaderCreatures.Name = "lblHeaderCreatures";
            this.lblHeaderCreatures.Size = new System.Drawing.Size(511, 6);
            this.lblHeaderCreatures.TabIndex = 1;
            this.lblHeaderCreatures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCreatureFilter
            // 
            this.txtCreatureFilter.Location = new System.Drawing.Point(92, 294);
            this.txtCreatureFilter.Name = "txtCreatureFilter";
            this.txtCreatureFilter.Size = new System.Drawing.Size(327, 20);
            this.txtCreatureFilter.TabIndex = 6;
            this.txtCreatureFilter.TextChanged += new System.EventHandler(this.txtCreatureFilter_TextChanged);
            this.txtCreatureFilter.Validating += new System.ComponentModel.CancelEventHandler(this.txtCreatureFilter_Validating);
            // 
            // lvwDinoClasses
            // 
            this.lvwDinoClasses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwDinoClasses_ClassName,
            this.lvwDinoClasses_DisplayName});
            this.lvwDinoClasses.FullRowSelect = true;
            this.lvwDinoClasses.HideSelection = false;
            this.lvwDinoClasses.Location = new System.Drawing.Point(13, 45);
            this.lvwDinoClasses.Name = "lvwDinoClasses";
            this.lvwDinoClasses.Size = new System.Drawing.Size(485, 236);
            this.lvwDinoClasses.TabIndex = 3;
            this.lvwDinoClasses.UseCompatibleStateImageBehavior = false;
            this.lvwDinoClasses.View = System.Windows.Forms.View.Details;
            this.lvwDinoClasses.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwDinoClasses_ColumnClick);
            this.lvwDinoClasses.SelectedIndexChanged += new System.EventHandler(this.lvwDinoClasses_SelectedIndexChanged);
            // 
            // lvwDinoClasses_ClassName
            // 
            this.lvwDinoClasses_ClassName.DisplayIndex = 1;
            this.lvwDinoClasses_ClassName.Text = "Class Name";
            this.lvwDinoClasses_ClassName.Width = 244;
            // 
            // lvwDinoClasses_DisplayName
            // 
            this.lvwDinoClasses_DisplayName.DisplayIndex = 0;
            this.lvwDinoClasses_DisplayName.Text = "Display Name";
            this.lvwDinoClasses_DisplayName.Width = 205;
            // 
            // btnEditDinoClass
            // 
            this.btnEditDinoClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDinoClass.Enabled = false;
            this.btnEditDinoClass.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDinoClass.Image")));
            this.btnEditDinoClass.Location = new System.Drawing.Point(465, 287);
            this.btnEditDinoClass.Name = "btnEditDinoClass";
            this.btnEditDinoClass.Size = new System.Drawing.Size(35, 35);
            this.btnEditDinoClass.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnEditDinoClass, "Edit display name");
            this.btnEditDinoClass.UseVisualStyleBackColor = true;
            this.btnEditDinoClass.Click += new System.EventHandler(this.btnEditDinoClass_Click);
            // 
            // btnAddDinoClass
            // 
            this.btnAddDinoClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDinoClass.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnAddDinoClass.Location = new System.Drawing.Point(13, 287);
            this.btnAddDinoClass.Name = "btnAddDinoClass";
            this.btnAddDinoClass.Size = new System.Drawing.Size(35, 35);
            this.btnAddDinoClass.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAddDinoClass, "Add new display name");
            this.btnAddDinoClass.UseVisualStyleBackColor = true;
            this.btnAddDinoClass.Click += new System.EventHandler(this.btnAddDinoClass_Click);
            // 
            // btnRemoveDinoClass
            // 
            this.btnRemoveDinoClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveDinoClass.Enabled = false;
            this.btnRemoveDinoClass.Image = global::ARKViewer.Properties.Resources.button_remove;
            this.btnRemoveDinoClass.Location = new System.Drawing.Point(52, 287);
            this.btnRemoveDinoClass.Name = "btnRemoveDinoClass";
            this.btnRemoveDinoClass.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveDinoClass.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnRemoveDinoClass, "Remove display name");
            this.btnRemoveDinoClass.UseVisualStyleBackColor = true;
            this.btnRemoveDinoClass.Click += new System.EventHandler(this.btnRemoveDinoClass_Click);
            // 
            // tpgStructures
            // 
            this.tpgStructures.Controls.Add(this.grpStructuresNotMapped);
            this.tpgStructures.Controls.Add(this.grpStructures);
            this.tpgStructures.Location = new System.Drawing.Point(4, 22);
            this.tpgStructures.Name = "tpgStructures";
            this.tpgStructures.Size = new System.Drawing.Size(545, 626);
            this.tpgStructures.TabIndex = 4;
            this.tpgStructures.Text = "Structures";
            this.tpgStructures.UseVisualStyleBackColor = true;
            // 
            // grpStructuresNotMapped
            // 
            this.grpStructuresNotMapped.Controls.Add(this.btnRefreshUnknownStructures);
            this.grpStructuresNotMapped.Controls.Add(this.btnStructuresNotMappedAdd);
            this.grpStructuresNotMapped.Controls.Add(this.lblStructuresNotMapped);
            this.grpStructuresNotMapped.Controls.Add(this.lblHeaderStructuresNotMapped);
            this.grpStructuresNotMapped.Controls.Add(this.lvwStructuresNotMapped);
            this.grpStructuresNotMapped.Location = new System.Drawing.Point(18, 348);
            this.grpStructuresNotMapped.Name = "grpStructuresNotMapped";
            this.grpStructuresNotMapped.Size = new System.Drawing.Size(508, 256);
            this.grpStructuresNotMapped.TabIndex = 1;
            this.grpStructuresNotMapped.TabStop = false;
            // 
            // btnRefreshUnknownStructures
            // 
            this.btnRefreshUnknownStructures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshUnknownStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshUnknownStructures.Image = global::ARKViewer.Properties.Resources.button_refresh;
            this.btnRefreshUnknownStructures.Location = new System.Drawing.Point(13, 212);
            this.btnRefreshUnknownStructures.Name = "btnRefreshUnknownStructures";
            this.btnRefreshUnknownStructures.Size = new System.Drawing.Size(35, 35);
            this.btnRefreshUnknownStructures.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnRefreshUnknownStructures, "Add mapping");
            this.btnRefreshUnknownStructures.UseVisualStyleBackColor = true;
            this.btnRefreshUnknownStructures.Click += new System.EventHandler(this.btnRefreshUnknownStructures_Click);
            // 
            // btnStructuresNotMappedAdd
            // 
            this.btnStructuresNotMappedAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStructuresNotMappedAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStructuresNotMappedAdd.Enabled = false;
            this.btnStructuresNotMappedAdd.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnStructuresNotMappedAdd.Location = new System.Drawing.Point(464, 212);
            this.btnStructuresNotMappedAdd.Name = "btnStructuresNotMappedAdd";
            this.btnStructuresNotMappedAdd.Size = new System.Drawing.Size(35, 35);
            this.btnStructuresNotMappedAdd.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnStructuresNotMappedAdd, "Add mapping");
            this.btnStructuresNotMappedAdd.UseVisualStyleBackColor = true;
            this.btnStructuresNotMappedAdd.Click += new System.EventHandler(this.btnStructuresNotMappedAdd_Click);
            // 
            // lblStructuresNotMapped
            // 
            this.lblStructuresNotMapped.BackColor = System.Drawing.Color.Transparent;
            this.lblStructuresNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStructuresNotMapped.Location = new System.Drawing.Point(10, 16);
            this.lblStructuresNotMapped.Name = "lblStructuresNotMapped";
            this.lblStructuresNotMapped.Size = new System.Drawing.Size(198, 22);
            this.lblStructuresNotMapped.TabIndex = 1;
            this.lblStructuresNotMapped.Text = "Not Mapped";
            this.lblStructuresNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderStructuresNotMapped
            // 
            this.lblHeaderStructuresNotMapped.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderStructuresNotMapped.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHeaderStructuresNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderStructuresNotMapped.Location = new System.Drawing.Point(-2, 6);
            this.lblHeaderStructuresNotMapped.Name = "lblHeaderStructuresNotMapped";
            this.lblHeaderStructuresNotMapped.Size = new System.Drawing.Size(511, 6);
            this.lblHeaderStructuresNotMapped.TabIndex = 0;
            this.lblHeaderStructuresNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwStructuresNotMapped
            // 
            this.lvwStructuresNotMapped.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10});
            this.lvwStructuresNotMapped.FullRowSelect = true;
            this.lvwStructuresNotMapped.HideSelection = false;
            this.lvwStructuresNotMapped.Location = new System.Drawing.Point(13, 45);
            this.lvwStructuresNotMapped.Name = "lvwStructuresNotMapped";
            this.lvwStructuresNotMapped.Size = new System.Drawing.Size(485, 162);
            this.lvwStructuresNotMapped.TabIndex = 2;
            this.lvwStructuresNotMapped.UseCompatibleStateImageBehavior = false;
            this.lvwStructuresNotMapped.View = System.Windows.Forms.View.Details;
            this.lvwStructuresNotMapped.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwStructuresNotMapped_ColumnClick);
            this.lvwStructuresNotMapped.SelectedIndexChanged += new System.EventHandler(this.lvwStructuresNotMapped_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Detected Class Name";
            this.columnHeader10.Width = 450;
            // 
            // grpStructures
            // 
            this.grpStructures.Controls.Add(this.chkApplyFilterStructures);
            this.grpStructures.Controls.Add(this.lblHeaderStructures);
            this.grpStructures.Controls.Add(this.txtStructureFilter);
            this.grpStructures.Controls.Add(this.lvwStructureMap);
            this.grpStructures.Controls.Add(this.btnEditStructure);
            this.grpStructures.Controls.Add(this.btnAddStructure);
            this.grpStructures.Controls.Add(this.btnRemoveStructure);
            this.grpStructures.Location = new System.Drawing.Point(18, 10);
            this.grpStructures.Name = "grpStructures";
            this.grpStructures.Size = new System.Drawing.Size(508, 332);
            this.grpStructures.TabIndex = 0;
            this.grpStructures.TabStop = false;
            // 
            // chkApplyFilterStructures
            // 
            this.chkApplyFilterStructures.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkApplyFilterStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkApplyFilterStructures.Image = global::ARKViewer.Properties.Resources.button_filter;
            this.chkApplyFilterStructures.Location = new System.Drawing.Point(425, 287);
            this.chkApplyFilterStructures.Name = "chkApplyFilterStructures";
            this.chkApplyFilterStructures.Size = new System.Drawing.Size(35, 35);
            this.chkApplyFilterStructures.TabIndex = 5;
            this.toolTip1.SetToolTip(this.chkApplyFilterStructures, "Apply/Remove filter");
            this.chkApplyFilterStructures.UseVisualStyleBackColor = true;
            this.chkApplyFilterStructures.CheckedChanged += new System.EventHandler(this.chkApplyFilterStructures_CheckedChanged);
            // 
            // lblHeaderStructures
            // 
            this.lblHeaderStructures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderStructures.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderStructures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderStructures.Location = new System.Drawing.Point(-2, 6);
            this.lblHeaderStructures.Name = "lblHeaderStructures";
            this.lblHeaderStructures.Size = new System.Drawing.Size(511, 6);
            this.lblHeaderStructures.TabIndex = 0;
            this.lblHeaderStructures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStructureFilter
            // 
            this.txtStructureFilter.Location = new System.Drawing.Point(92, 294);
            this.txtStructureFilter.Name = "txtStructureFilter";
            this.txtStructureFilter.Size = new System.Drawing.Size(327, 20);
            this.txtStructureFilter.TabIndex = 4;
            // 
            // lvwStructureMap
            // 
            this.lvwStructureMap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvwStructureMap.FullRowSelect = true;
            this.lvwStructureMap.HideSelection = false;
            this.lvwStructureMap.Location = new System.Drawing.Point(13, 19);
            this.lvwStructureMap.Name = "lvwStructureMap";
            this.lvwStructureMap.Size = new System.Drawing.Size(485, 262);
            this.lvwStructureMap.TabIndex = 1;
            this.lvwStructureMap.UseCompatibleStateImageBehavior = false;
            this.lvwStructureMap.View = System.Windows.Forms.View.Details;
            this.lvwStructureMap.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwStructureMap_ColumnClick);
            this.lvwStructureMap.SelectedIndexChanged += new System.EventHandler(this.lvwStructureMap_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 1;
            this.columnHeader5.Text = "Class Name";
            this.columnHeader5.Width = 262;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 0;
            this.columnHeader6.Text = "Display Name";
            this.columnHeader6.Width = 193;
            // 
            // btnEditStructure
            // 
            this.btnEditStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStructure.Enabled = false;
            this.btnEditStructure.Image = ((System.Drawing.Image)(resources.GetObject("btnEditStructure.Image")));
            this.btnEditStructure.Location = new System.Drawing.Point(465, 287);
            this.btnEditStructure.Name = "btnEditStructure";
            this.btnEditStructure.Size = new System.Drawing.Size(35, 35);
            this.btnEditStructure.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnEditStructure, "Edit display name");
            this.btnEditStructure.UseVisualStyleBackColor = true;
            this.btnEditStructure.Click += new System.EventHandler(this.btnEditStructure_Click);
            // 
            // btnAddStructure
            // 
            this.btnAddStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStructure.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnAddStructure.Location = new System.Drawing.Point(13, 287);
            this.btnAddStructure.Name = "btnAddStructure";
            this.btnAddStructure.Size = new System.Drawing.Size(35, 35);
            this.btnAddStructure.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAddStructure, "Add new display name");
            this.btnAddStructure.UseVisualStyleBackColor = true;
            this.btnAddStructure.Click += new System.EventHandler(this.btnAddStructure_Click);
            // 
            // btnRemoveStructure
            // 
            this.btnRemoveStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveStructure.Enabled = false;
            this.btnRemoveStructure.Image = global::ARKViewer.Properties.Resources.button_remove;
            this.btnRemoveStructure.Location = new System.Drawing.Point(52, 287);
            this.btnRemoveStructure.Name = "btnRemoveStructure";
            this.btnRemoveStructure.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveStructure.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnRemoveStructure, "Remove display name");
            this.btnRemoveStructure.UseVisualStyleBackColor = true;
            this.btnRemoveStructure.Click += new System.EventHandler(this.btnRemoveStructure_Click);
            // 
            // tpgItems
            // 
            this.tpgItems.Controls.Add(this.grpItemsNotMatched);
            this.tpgItems.Controls.Add(this.grpItems);
            this.tpgItems.Location = new System.Drawing.Point(4, 22);
            this.tpgItems.Name = "tpgItems";
            this.tpgItems.Size = new System.Drawing.Size(545, 626);
            this.tpgItems.TabIndex = 2;
            this.tpgItems.Text = "Items";
            this.tpgItems.UseVisualStyleBackColor = true;
            // 
            // grpItemsNotMatched
            // 
            this.grpItemsNotMatched.Controls.Add(this.btnRefreshUnknownItems);
            this.grpItemsNotMatched.Controls.Add(this.btnItemsNotMatchedAdd);
            this.grpItemsNotMatched.Controls.Add(this.lblItemsNotMatched);
            this.grpItemsNotMatched.Controls.Add(this.lblHeaderItemsNotMatched);
            this.grpItemsNotMatched.Controls.Add(this.lvwItemsNotMatched);
            this.grpItemsNotMatched.Location = new System.Drawing.Point(18, 348);
            this.grpItemsNotMatched.Name = "grpItemsNotMatched";
            this.grpItemsNotMatched.Size = new System.Drawing.Size(508, 256);
            this.grpItemsNotMatched.TabIndex = 1;
            this.grpItemsNotMatched.TabStop = false;
            // 
            // btnRefreshUnknownItems
            // 
            this.btnRefreshUnknownItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshUnknownItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshUnknownItems.Image = global::ARKViewer.Properties.Resources.button_refresh;
            this.btnRefreshUnknownItems.Location = new System.Drawing.Point(13, 212);
            this.btnRefreshUnknownItems.Name = "btnRefreshUnknownItems";
            this.btnRefreshUnknownItems.Size = new System.Drawing.Size(35, 35);
            this.btnRefreshUnknownItems.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnRefreshUnknownItems, "Add mapping");
            this.btnRefreshUnknownItems.UseVisualStyleBackColor = true;
            this.btnRefreshUnknownItems.Click += new System.EventHandler(this.btnRefreshUnknownItems_Click);
            // 
            // btnItemsNotMatchedAdd
            // 
            this.btnItemsNotMatchedAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnItemsNotMatchedAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemsNotMatchedAdd.Enabled = false;
            this.btnItemsNotMatchedAdd.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnItemsNotMatchedAdd.Location = new System.Drawing.Point(464, 212);
            this.btnItemsNotMatchedAdd.Name = "btnItemsNotMatchedAdd";
            this.btnItemsNotMatchedAdd.Size = new System.Drawing.Size(35, 35);
            this.btnItemsNotMatchedAdd.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnItemsNotMatchedAdd, "Add mapping");
            this.btnItemsNotMatchedAdd.UseVisualStyleBackColor = true;
            this.btnItemsNotMatchedAdd.Click += new System.EventHandler(this.btnItemsNotMatchedAdd_Click);
            // 
            // lblItemsNotMatched
            // 
            this.lblItemsNotMatched.BackColor = System.Drawing.Color.Transparent;
            this.lblItemsNotMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsNotMatched.Location = new System.Drawing.Point(10, 16);
            this.lblItemsNotMatched.Name = "lblItemsNotMatched";
            this.lblItemsNotMatched.Size = new System.Drawing.Size(198, 22);
            this.lblItemsNotMatched.TabIndex = 1;
            this.lblItemsNotMatched.Text = "Not Mapped";
            this.lblItemsNotMatched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderItemsNotMatched
            // 
            this.lblHeaderItemsNotMatched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderItemsNotMatched.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHeaderItemsNotMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderItemsNotMatched.Location = new System.Drawing.Point(-2, 6);
            this.lblHeaderItemsNotMatched.Name = "lblHeaderItemsNotMatched";
            this.lblHeaderItemsNotMatched.Size = new System.Drawing.Size(511, 6);
            this.lblHeaderItemsNotMatched.TabIndex = 0;
            this.lblHeaderItemsNotMatched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwItemsNotMatched
            // 
            this.lvwItemsNotMatched.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11});
            this.lvwItemsNotMatched.FullRowSelect = true;
            this.lvwItemsNotMatched.HideSelection = false;
            this.lvwItemsNotMatched.Location = new System.Drawing.Point(13, 45);
            this.lvwItemsNotMatched.Name = "lvwItemsNotMatched";
            this.lvwItemsNotMatched.Size = new System.Drawing.Size(485, 162);
            this.lvwItemsNotMatched.TabIndex = 2;
            this.lvwItemsNotMatched.UseCompatibleStateImageBehavior = false;
            this.lvwItemsNotMatched.View = System.Windows.Forms.View.Details;
            this.lvwItemsNotMatched.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwItemsNotMatched_ColumnClick);
            this.lvwItemsNotMatched.SelectedIndexChanged += new System.EventHandler(this.lvwItemsNotMatched_SelectedIndexChanged);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Detected Class Name";
            this.columnHeader11.Width = 450;
            // 
            // grpItems
            // 
            this.grpItems.Controls.Add(this.chkApplyFilterItems);
            this.grpItems.Controls.Add(this.lblHeaderItems);
            this.grpItems.Controls.Add(this.txtItemFilter);
            this.grpItems.Controls.Add(this.lvwItemMap);
            this.grpItems.Controls.Add(this.btnEditItem);
            this.grpItems.Controls.Add(this.btnAddItem);
            this.grpItems.Controls.Add(this.btnRemoveItem);
            this.grpItems.Location = new System.Drawing.Point(18, 10);
            this.grpItems.Name = "grpItems";
            this.grpItems.Size = new System.Drawing.Size(508, 332);
            this.grpItems.TabIndex = 0;
            this.grpItems.TabStop = false;
            // 
            // chkApplyFilterItems
            // 
            this.chkApplyFilterItems.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkApplyFilterItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkApplyFilterItems.Image = global::ARKViewer.Properties.Resources.button_filter;
            this.chkApplyFilterItems.Location = new System.Drawing.Point(425, 287);
            this.chkApplyFilterItems.Name = "chkApplyFilterItems";
            this.chkApplyFilterItems.Size = new System.Drawing.Size(35, 35);
            this.chkApplyFilterItems.TabIndex = 5;
            this.chkApplyFilterItems.UseVisualStyleBackColor = true;
            this.chkApplyFilterItems.CheckedChanged += new System.EventHandler(this.chkApplyFilterItems_CheckedChanged);
            // 
            // lblHeaderItems
            // 
            this.lblHeaderItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderItems.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderItems.Location = new System.Drawing.Point(-2, 6);
            this.lblHeaderItems.Name = "lblHeaderItems";
            this.lblHeaderItems.Size = new System.Drawing.Size(511, 6);
            this.lblHeaderItems.TabIndex = 0;
            this.lblHeaderItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtItemFilter
            // 
            this.txtItemFilter.Location = new System.Drawing.Point(92, 294);
            this.txtItemFilter.Name = "txtItemFilter";
            this.txtItemFilter.Size = new System.Drawing.Size(327, 20);
            this.txtItemFilter.TabIndex = 4;
            this.txtItemFilter.TextChanged += new System.EventHandler(this.txtItemFilter_TextChanged);
            this.txtItemFilter.Validating += new System.ComponentModel.CancelEventHandler(this.txtItemFilter_Validating);
            // 
            // lvwItemMap
            // 
            this.lvwItemMap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.lvwItemMap.FullRowSelect = true;
            this.lvwItemMap.HideSelection = false;
            this.lvwItemMap.Location = new System.Drawing.Point(13, 19);
            this.lvwItemMap.Name = "lvwItemMap";
            this.lvwItemMap.Size = new System.Drawing.Size(485, 262);
            this.lvwItemMap.TabIndex = 1;
            this.lvwItemMap.UseCompatibleStateImageBehavior = false;
            this.lvwItemMap.View = System.Windows.Forms.View.Details;
            this.lvwItemMap.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwItemMap_ColumnClick);
            this.lvwItemMap.SelectedIndexChanged += new System.EventHandler(this.lvwItemMap_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Category";
            this.columnHeader3.Width = 119;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 2;
            this.columnHeader1.Text = "Class Name";
            this.columnHeader1.Width = 172;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Display Name";
            this.columnHeader2.Width = 179;
            // 
            // btnEditItem
            // 
            this.btnEditItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditItem.Enabled = false;
            this.btnEditItem.Image = ((System.Drawing.Image)(resources.GetObject("btnEditItem.Image")));
            this.btnEditItem.Location = new System.Drawing.Point(465, 287);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(35, 35);
            this.btnEditItem.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnEditItem, "Edit display name");
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnAddItem.Location = new System.Drawing.Point(13, 287);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(35, 35);
            this.btnAddItem.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAddItem, "Add new display name");
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.Image = global::ARKViewer.Properties.Resources.button_remove;
            this.btnRemoveItem.Location = new System.Drawing.Point(52, 287);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveItem.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnRemoveItem, "Remove display name");
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // tpgExport
            // 
            this.tpgExport.Controls.Add(this.grpJsonExport);
            this.tpgExport.Controls.Add(this.grpContentPack);
            this.tpgExport.Location = new System.Drawing.Point(4, 22);
            this.tpgExport.Name = "tpgExport";
            this.tpgExport.Size = new System.Drawing.Size(545, 626);
            this.tpgExport.TabIndex = 6;
            this.tpgExport.Text = "Export";
            this.tpgExport.UseVisualStyleBackColor = true;
            // 
            // grpJsonExport
            // 
            this.grpJsonExport.Controls.Add(this.lblExportPlayerStructures);
            this.grpJsonExport.Controls.Add(this.btnJsonExportPlayerStructures);
            this.grpJsonExport.Controls.Add(this.lblExportTamed);
            this.grpJsonExport.Controls.Add(this.btnJsonExportTamed);
            this.grpJsonExport.Controls.Add(this.lblExportPlayers);
            this.grpJsonExport.Controls.Add(this.btnJsonExportPlayers);
            this.grpJsonExport.Controls.Add(this.lblExportTribes);
            this.grpJsonExport.Controls.Add(this.btnJsonExportTribes);
            this.grpJsonExport.Controls.Add(this.lblExportWild);
            this.grpJsonExport.Controls.Add(this.btnJsonExportWild);
            this.grpJsonExport.Controls.Add(this.lblExportAll);
            this.grpJsonExport.Controls.Add(this.btnJsonExportAll);
            this.grpJsonExport.Controls.Add(this.lblHeaderJsonExport);
            this.grpJsonExport.Controls.Add(this.lblJsonFileExport);
            this.grpJsonExport.Location = new System.Drawing.Point(22, 381);
            this.grpJsonExport.Name = "grpJsonExport";
            this.grpJsonExport.Size = new System.Drawing.Size(501, 215);
            this.grpJsonExport.TabIndex = 1;
            this.grpJsonExport.TabStop = false;
            // 
            // lblExportPlayerStructures
            // 
            this.lblExportPlayerStructures.AutoSize = true;
            this.lblExportPlayerStructures.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportPlayerStructures.Location = new System.Drawing.Point(290, 132);
            this.lblExportPlayerStructures.Name = "lblExportPlayerStructures";
            this.lblExportPlayerStructures.Size = new System.Drawing.Size(104, 13);
            this.lblExportPlayerStructures.TabIndex = 12;
            this.lblExportPlayerStructures.Text = "Player Structures";
            // 
            // btnJsonExportPlayerStructures
            // 
            this.btnJsonExportPlayerStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJsonExportPlayerStructures.Image = global::ARKViewer.Properties.Resources.button_export;
            this.btnJsonExportPlayerStructures.Location = new System.Drawing.Point(424, 127);
            this.btnJsonExportPlayerStructures.Name = "btnJsonExportPlayerStructures";
            this.btnJsonExportPlayerStructures.Size = new System.Drawing.Size(35, 35);
            this.btnJsonExportPlayerStructures.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnJsonExportPlayerStructures, "Export structure data");
            this.btnJsonExportPlayerStructures.UseVisualStyleBackColor = true;
            this.btnJsonExportPlayerStructures.Click += new System.EventHandler(this.btnJsonExportPlayerStructures_Click);
            // 
            // lblExportTamed
            // 
            this.lblExportTamed.AutoSize = true;
            this.lblExportTamed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportTamed.Location = new System.Drawing.Point(19, 132);
            this.lblExportTamed.Name = "lblExportTamed";
            this.lblExportTamed.Size = new System.Drawing.Size(121, 13);
            this.lblExportTamed.TabIndex = 6;
            this.lblExportTamed.Text = "All Tamed Creatures";
            // 
            // btnJsonExportTamed
            // 
            this.btnJsonExportTamed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJsonExportTamed.Image = global::ARKViewer.Properties.Resources.button_export;
            this.btnJsonExportTamed.Location = new System.Drawing.Point(153, 127);
            this.btnJsonExportTamed.Name = "btnJsonExportTamed";
            this.btnJsonExportTamed.Size = new System.Drawing.Size(35, 35);
            this.btnJsonExportTamed.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnJsonExportTamed, "Export tamed data");
            this.btnJsonExportTamed.UseVisualStyleBackColor = true;
            this.btnJsonExportTamed.Click += new System.EventHandler(this.btnJsonExportTamed_Click);
            // 
            // lblExportPlayers
            // 
            this.lblExportPlayers.AutoSize = true;
            this.lblExportPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportPlayers.Location = new System.Drawing.Point(290, 91);
            this.lblExportPlayers.Name = "lblExportPlayers";
            this.lblExportPlayers.Size = new System.Drawing.Size(73, 13);
            this.lblExportPlayers.TabIndex = 10;
            this.lblExportPlayers.Text = "Player Data";
            // 
            // btnJsonExportPlayers
            // 
            this.btnJsonExportPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJsonExportPlayers.Image = global::ARKViewer.Properties.Resources.button_export;
            this.btnJsonExportPlayers.Location = new System.Drawing.Point(424, 84);
            this.btnJsonExportPlayers.Name = "btnJsonExportPlayers";
            this.btnJsonExportPlayers.Size = new System.Drawing.Size(35, 35);
            this.btnJsonExportPlayers.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnJsonExportPlayers, "Export player data");
            this.btnJsonExportPlayers.UseVisualStyleBackColor = true;
            this.btnJsonExportPlayers.Click += new System.EventHandler(this.btnJsonExportPlayers_Click);
            // 
            // lblExportTribes
            // 
            this.lblExportTribes.AutoSize = true;
            this.lblExportTribes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportTribes.Location = new System.Drawing.Point(290, 52);
            this.lblExportTribes.Name = "lblExportTribes";
            this.lblExportTribes.Size = new System.Drawing.Size(67, 13);
            this.lblExportTribes.TabIndex = 8;
            this.lblExportTribes.Text = "Tribe Data";
            // 
            // btnJsonExportTribes
            // 
            this.btnJsonExportTribes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJsonExportTribes.Image = global::ARKViewer.Properties.Resources.button_export;
            this.btnJsonExportTribes.Location = new System.Drawing.Point(424, 44);
            this.btnJsonExportTribes.Name = "btnJsonExportTribes";
            this.btnJsonExportTribes.Size = new System.Drawing.Size(35, 35);
            this.btnJsonExportTribes.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnJsonExportTribes, "Export tribe data");
            this.btnJsonExportTribes.UseVisualStyleBackColor = true;
            this.btnJsonExportTribes.Click += new System.EventHandler(this.btnJsonExportTribes_Click);
            // 
            // lblExportWild
            // 
            this.lblExportWild.AutoSize = true;
            this.lblExportWild.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportWild.Location = new System.Drawing.Point(19, 91);
            this.lblExportWild.Name = "lblExportWild";
            this.lblExportWild.Size = new System.Drawing.Size(108, 13);
            this.lblExportWild.TabIndex = 4;
            this.lblExportWild.Text = "All Wild Creatures";
            // 
            // btnJsonExportWild
            // 
            this.btnJsonExportWild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJsonExportWild.Image = global::ARKViewer.Properties.Resources.button_export;
            this.btnJsonExportWild.Location = new System.Drawing.Point(153, 84);
            this.btnJsonExportWild.Name = "btnJsonExportWild";
            this.btnJsonExportWild.Size = new System.Drawing.Size(35, 35);
            this.btnJsonExportWild.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnJsonExportWild, "Export wild data");
            this.btnJsonExportWild.UseVisualStyleBackColor = true;
            this.btnJsonExportWild.Click += new System.EventHandler(this.btnJsonExportWild_Click);
            // 
            // lblExportAll
            // 
            this.lblExportAll.AutoSize = true;
            this.lblExportAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportAll.Location = new System.Drawing.Point(19, 52);
            this.lblExportAll.Name = "lblExportAll";
            this.lblExportAll.Size = new System.Drawing.Size(77, 13);
            this.lblExportAll.TabIndex = 2;
            this.lblExportAll.Text = "All Available";
            // 
            // btnJsonExportAll
            // 
            this.btnJsonExportAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJsonExportAll.Image = global::ARKViewer.Properties.Resources.button_export;
            this.btnJsonExportAll.Location = new System.Drawing.Point(153, 44);
            this.btnJsonExportAll.Name = "btnJsonExportAll";
            this.btnJsonExportAll.Size = new System.Drawing.Size(35, 35);
            this.btnJsonExportAll.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnJsonExportAll, "Export all data");
            this.btnJsonExportAll.UseVisualStyleBackColor = true;
            this.btnJsonExportAll.Click += new System.EventHandler(this.btnJsonExportAll_Click);
            // 
            // lblHeaderJsonExport
            // 
            this.lblHeaderJsonExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderJsonExport.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderJsonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderJsonExport.Location = new System.Drawing.Point(0, 6);
            this.lblHeaderJsonExport.Name = "lblHeaderJsonExport";
            this.lblHeaderJsonExport.Size = new System.Drawing.Size(503, 6);
            this.lblHeaderJsonExport.TabIndex = 0;
            this.lblHeaderJsonExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJsonFileExport
            // 
            this.lblJsonFileExport.BackColor = System.Drawing.Color.Transparent;
            this.lblJsonFileExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJsonFileExport.Location = new System.Drawing.Point(8, 14);
            this.lblJsonFileExport.Name = "lblJsonFileExport";
            this.lblJsonFileExport.Size = new System.Drawing.Size(198, 22);
            this.lblJsonFileExport.TabIndex = 1;
            this.lblJsonFileExport.Text = "JSON File Export";
            this.lblJsonFileExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpContentPack
            // 
            this.grpContentPack.Controls.Add(this.chkDroppedItems);
            this.grpContentPack.Controls.Add(this.chkStructureContents);
            this.grpContentPack.Controls.Add(this.chkStructureLocations);
            this.grpContentPack.Controls.Add(this.btnExportContentPack);
            this.grpContentPack.Controls.Add(this.udExportRadius);
            this.grpContentPack.Controls.Add(this.udExportLon);
            this.grpContentPack.Controls.Add(this.udExportLat);
            this.grpContentPack.Controls.Add(this.lblFilterRad);
            this.grpContentPack.Controls.Add(this.cboExportPlayer);
            this.grpContentPack.Controls.Add(this.cboExportTribe);
            this.grpContentPack.Controls.Add(this.lblFilterLon);
            this.grpContentPack.Controls.Add(this.lblFilterLat);
            this.grpContentPack.Controls.Add(this.lblFilterPlayer);
            this.grpContentPack.Controls.Add(this.lblFilterTribe);
            this.grpContentPack.Controls.Add(this.lblContentPackFilters);
            this.grpContentPack.Controls.Add(this.chkPlayerStructures);
            this.grpContentPack.Controls.Add(this.chkTamedCreatures);
            this.grpContentPack.Controls.Add(this.chkWildCreatures);
            this.grpContentPack.Controls.Add(this.lblHeaderConteentPack);
            this.grpContentPack.Controls.Add(this.lblContentPackOptions);
            this.grpContentPack.Location = new System.Drawing.Point(22, 11);
            this.grpContentPack.Name = "grpContentPack";
            this.grpContentPack.Size = new System.Drawing.Size(501, 364);
            this.grpContentPack.TabIndex = 0;
            this.grpContentPack.TabStop = false;
            // 
            // chkDroppedItems
            // 
            this.chkDroppedItems.AutoSize = true;
            this.chkDroppedItems.Location = new System.Drawing.Point(28, 96);
            this.chkDroppedItems.Name = "chkDroppedItems";
            this.chkDroppedItems.Size = new System.Drawing.Size(95, 17);
            this.chkDroppedItems.TabIndex = 4;
            this.chkDroppedItems.Text = "Dropped Items";
            this.chkDroppedItems.UseVisualStyleBackColor = true;
            // 
            // chkStructureContents
            // 
            this.chkStructureContents.AutoSize = true;
            this.chkStructureContents.Location = new System.Drawing.Point(28, 73);
            this.chkStructureContents.Name = "chkStructureContents";
            this.chkStructureContents.Size = new System.Drawing.Size(138, 17);
            this.chkStructureContents.TabIndex = 3;
            this.chkStructureContents.Text = "Map Structure Contents";
            this.chkStructureContents.UseVisualStyleBackColor = true;
            // 
            // chkStructureLocations
            // 
            this.chkStructureLocations.AutoSize = true;
            this.chkStructureLocations.Checked = true;
            this.chkStructureLocations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStructureLocations.Location = new System.Drawing.Point(28, 50);
            this.chkStructureLocations.Name = "chkStructureLocations";
            this.chkStructureLocations.Size = new System.Drawing.Size(142, 17);
            this.chkStructureLocations.TabIndex = 2;
            this.chkStructureLocations.Text = "Map Structure Locations";
            this.chkStructureLocations.UseVisualStyleBackColor = true;
            // 
            // btnExportContentPack
            // 
            this.btnExportContentPack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportContentPack.Image = global::ARKViewer.Properties.Resources.button_export;
            this.btnExportContentPack.Location = new System.Drawing.Point(424, 313);
            this.btnExportContentPack.Name = "btnExportContentPack";
            this.btnExportContentPack.Size = new System.Drawing.Size(35, 35);
            this.btnExportContentPack.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnExportContentPack, "Export content pack");
            this.btnExportContentPack.UseVisualStyleBackColor = true;
            this.btnExportContentPack.Click += new System.EventHandler(this.btnExportContentPack_Click);
            // 
            // udExportRadius
            // 
            this.udExportRadius.DecimalPlaces = 2;
            this.udExportRadius.Location = new System.Drawing.Point(123, 322);
            this.udExportRadius.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.udExportRadius.Name = "udExportRadius";
            this.udExportRadius.Size = new System.Drawing.Size(64, 20);
            this.udExportRadius.TabIndex = 19;
            this.udExportRadius.Value = new decimal(new int[] {
            10000,
            0,
            0,
            131072});
            // 
            // udExportLon
            // 
            this.udExportLon.DecimalPlaces = 2;
            this.udExportLon.Location = new System.Drawing.Point(123, 288);
            this.udExportLon.Name = "udExportLon";
            this.udExportLon.Size = new System.Drawing.Size(64, 20);
            this.udExportLon.TabIndex = 17;
            this.udExportLon.Value = new decimal(new int[] {
            5000,
            0,
            0,
            131072});
            // 
            // udExportLat
            // 
            this.udExportLat.DecimalPlaces = 2;
            this.udExportLat.Location = new System.Drawing.Point(123, 255);
            this.udExportLat.Name = "udExportLat";
            this.udExportLat.Size = new System.Drawing.Size(64, 20);
            this.udExportLat.TabIndex = 15;
            this.udExportLat.Value = new decimal(new int[] {
            5000,
            0,
            0,
            131072});
            // 
            // lblFilterRad
            // 
            this.lblFilterRad.AutoSize = true;
            this.lblFilterRad.Location = new System.Drawing.Point(25, 322);
            this.lblFilterRad.Name = "lblFilterRad";
            this.lblFilterRad.Size = new System.Drawing.Size(43, 13);
            this.lblFilterRad.TabIndex = 18;
            this.lblFilterRad.Text = "Radius:";
            // 
            // cboExportPlayer
            // 
            this.cboExportPlayer.FormattingEnabled = true;
            this.cboExportPlayer.Location = new System.Drawing.Point(123, 219);
            this.cboExportPlayer.Name = "cboExportPlayer";
            this.cboExportPlayer.Size = new System.Drawing.Size(335, 21);
            this.cboExportPlayer.TabIndex = 13;
            // 
            // cboExportTribe
            // 
            this.cboExportTribe.FormattingEnabled = true;
            this.cboExportTribe.Location = new System.Drawing.Point(123, 187);
            this.cboExportTribe.Name = "cboExportTribe";
            this.cboExportTribe.Size = new System.Drawing.Size(335, 21);
            this.cboExportTribe.TabIndex = 11;
            this.cboExportTribe.SelectedIndexChanged += new System.EventHandler(this.cboExportTribe_SelectedIndexChanged);
            // 
            // lblFilterLon
            // 
            this.lblFilterLon.AutoSize = true;
            this.lblFilterLon.Location = new System.Drawing.Point(25, 288);
            this.lblFilterLon.Name = "lblFilterLon";
            this.lblFilterLon.Size = new System.Drawing.Size(57, 13);
            this.lblFilterLon.TabIndex = 16;
            this.lblFilterLon.Text = "Longitude:";
            // 
            // lblFilterLat
            // 
            this.lblFilterLat.AutoSize = true;
            this.lblFilterLat.Location = new System.Drawing.Point(25, 255);
            this.lblFilterLat.Name = "lblFilterLat";
            this.lblFilterLat.Size = new System.Drawing.Size(48, 13);
            this.lblFilterLat.TabIndex = 14;
            this.lblFilterLat.Text = "Latitude:";
            // 
            // lblFilterPlayer
            // 
            this.lblFilterPlayer.AutoSize = true;
            this.lblFilterPlayer.Location = new System.Drawing.Point(25, 222);
            this.lblFilterPlayer.Name = "lblFilterPlayer";
            this.lblFilterPlayer.Size = new System.Drawing.Size(84, 13);
            this.lblFilterPlayer.TabIndex = 12;
            this.lblFilterPlayer.Text = "Selected Player:";
            // 
            // lblFilterTribe
            // 
            this.lblFilterTribe.AutoSize = true;
            this.lblFilterTribe.Location = new System.Drawing.Point(25, 187);
            this.lblFilterTribe.Name = "lblFilterTribe";
            this.lblFilterTribe.Size = new System.Drawing.Size(79, 13);
            this.lblFilterTribe.TabIndex = 10;
            this.lblFilterTribe.Text = "Selected Tribe:";
            // 
            // lblContentPackFilters
            // 
            this.lblContentPackFilters.BackColor = System.Drawing.Color.Transparent;
            this.lblContentPackFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentPackFilters.Location = new System.Drawing.Point(8, 156);
            this.lblContentPackFilters.Name = "lblContentPackFilters";
            this.lblContentPackFilters.Size = new System.Drawing.Size(198, 22);
            this.lblContentPackFilters.TabIndex = 9;
            this.lblContentPackFilters.Text = "Content Pack Filters";
            this.lblContentPackFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkPlayerStructures
            // 
            this.chkPlayerStructures.AutoSize = true;
            this.chkPlayerStructures.Checked = true;
            this.chkPlayerStructures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlayerStructures.Location = new System.Drawing.Point(298, 96);
            this.chkPlayerStructures.Name = "chkPlayerStructures";
            this.chkPlayerStructures.Size = new System.Drawing.Size(106, 17);
            this.chkPlayerStructures.TabIndex = 8;
            this.chkPlayerStructures.Text = "Player Structures";
            this.chkPlayerStructures.UseVisualStyleBackColor = true;
            // 
            // chkTamedCreatures
            // 
            this.chkTamedCreatures.AutoSize = true;
            this.chkTamedCreatures.Checked = true;
            this.chkTamedCreatures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTamedCreatures.Location = new System.Drawing.Point(298, 50);
            this.chkTamedCreatures.Name = "chkTamedCreatures";
            this.chkTamedCreatures.Size = new System.Drawing.Size(107, 17);
            this.chkTamedCreatures.TabIndex = 6;
            this.chkTamedCreatures.Text = "Tamed Creatures";
            this.chkTamedCreatures.UseVisualStyleBackColor = true;
            // 
            // chkWildCreatures
            // 
            this.chkWildCreatures.AutoSize = true;
            this.chkWildCreatures.Location = new System.Drawing.Point(298, 73);
            this.chkWildCreatures.Name = "chkWildCreatures";
            this.chkWildCreatures.Size = new System.Drawing.Size(95, 17);
            this.chkWildCreatures.TabIndex = 7;
            this.chkWildCreatures.Text = "Wild Creatures";
            this.chkWildCreatures.UseVisualStyleBackColor = true;
            // 
            // lblHeaderConteentPack
            // 
            this.lblHeaderConteentPack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderConteentPack.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderConteentPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderConteentPack.Location = new System.Drawing.Point(0, 6);
            this.lblHeaderConteentPack.Name = "lblHeaderConteentPack";
            this.lblHeaderConteentPack.Size = new System.Drawing.Size(503, 6);
            this.lblHeaderConteentPack.TabIndex = 0;
            this.lblHeaderConteentPack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContentPackOptions
            // 
            this.lblContentPackOptions.BackColor = System.Drawing.Color.Transparent;
            this.lblContentPackOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentPackOptions.Location = new System.Drawing.Point(8, 14);
            this.lblContentPackOptions.Name = "lblContentPackOptions";
            this.lblContentPackOptions.Size = new System.Drawing.Size(198, 22);
            this.lblContentPackOptions.TabIndex = 1;
            this.lblContentPackOptions.Text = "Content Pack Export Options";
            this.lblContentPackOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpgRestService
            // 
            this.tpgRestService.Controls.Add(this.grpService);
            this.tpgRestService.Controls.Add(this.grpClientAccess);
            this.tpgRestService.Location = new System.Drawing.Point(4, 22);
            this.tpgRestService.Name = "tpgRestService";
            this.tpgRestService.Size = new System.Drawing.Size(545, 626);
            this.tpgRestService.TabIndex = 7;
            this.tpgRestService.Text = "REST Service";
            this.tpgRestService.UseVisualStyleBackColor = true;
            // 
            // grpService
            // 
            this.grpService.Controls.Add(this.chkAutostartService);
            this.grpService.Controls.Add(this.udServicePort);
            this.grpService.Controls.Add(this.lblServiceStatus);
            this.grpService.Controls.Add(this.txtServiceStatus);
            this.grpService.Controls.Add(this.btnClearServiceLog);
            this.grpService.Controls.Add(this.txtServiceLog);
            this.grpService.Controls.Add(this.lblServiceActivity);
            this.grpService.Controls.Add(this.btnStopService);
            this.grpService.Controls.Add(this.btnStartService);
            this.grpService.Controls.Add(this.lblService);
            this.grpService.Controls.Add(this.lblHeaderService);
            this.grpService.Controls.Add(this.lblServicePort);
            this.grpService.Enabled = false;
            this.grpService.Location = new System.Drawing.Point(26, 16);
            this.grpService.Name = "grpService";
            this.grpService.Size = new System.Drawing.Size(496, 283);
            this.grpService.TabIndex = 0;
            this.grpService.TabStop = false;
            // 
            // chkAutostartService
            // 
            this.chkAutostartService.AutoSize = true;
            this.chkAutostartService.Location = new System.Drawing.Point(368, 67);
            this.chkAutostartService.Name = "chkAutostartService";
            this.chkAutostartService.Size = new System.Drawing.Size(119, 17);
            this.chkAutostartService.TabIndex = 7;
            this.chkAutostartService.Text = "Auto Start with ASV";
            this.chkAutostartService.UseVisualStyleBackColor = true;
            // 
            // udServicePort
            // 
            this.udServicePort.Location = new System.Drawing.Point(215, 64);
            this.udServicePort.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.udServicePort.Name = "udServicePort";
            this.udServicePort.Size = new System.Drawing.Size(60, 20);
            this.udServicePort.TabIndex = 4;
            this.udServicePort.Value = new decimal(new int[] {
            8081,
            0,
            0,
            0});
            // 
            // lblServiceStatus
            // 
            this.lblServiceStatus.AutoSize = true;
            this.lblServiceStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceStatus.Location = new System.Drawing.Point(10, 39);
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(84, 15);
            this.lblServiceStatus.TabIndex = 1;
            this.lblServiceStatus.Text = "Service Status";
            this.lblServiceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtServiceStatus
            // 
            this.txtServiceStatus.Location = new System.Drawing.Point(13, 64);
            this.txtServiceStatus.Name = "txtServiceStatus";
            this.txtServiceStatus.ReadOnly = true;
            this.txtServiceStatus.Size = new System.Drawing.Size(195, 20);
            this.txtServiceStatus.TabIndex = 2;
            this.txtServiceStatus.Text = "No Map Loaded";
            // 
            // btnClearServiceLog
            // 
            this.btnClearServiceLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearServiceLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearServiceLog.Enabled = false;
            this.btnClearServiceLog.Image = global::ARKViewer.Properties.Resources.button_remove;
            this.btnClearServiceLog.Location = new System.Drawing.Point(450, 238);
            this.btnClearServiceLog.Name = "btnClearServiceLog";
            this.btnClearServiceLog.Size = new System.Drawing.Size(35, 35);
            this.btnClearServiceLog.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnClearServiceLog, "Clear activity log");
            this.btnClearServiceLog.UseVisualStyleBackColor = true;
            // 
            // txtServiceLog
            // 
            this.txtServiceLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServiceLog.Location = new System.Drawing.Point(13, 122);
            this.txtServiceLog.Multiline = true;
            this.txtServiceLog.Name = "txtServiceLog";
            this.txtServiceLog.ReadOnly = true;
            this.txtServiceLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtServiceLog.Size = new System.Drawing.Size(472, 109);
            this.txtServiceLog.TabIndex = 9;
            // 
            // lblServiceActivity
            // 
            this.lblServiceActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblServiceActivity.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceActivity.Location = new System.Drawing.Point(10, 95);
            this.lblServiceActivity.Name = "lblServiceActivity";
            this.lblServiceActivity.Size = new System.Drawing.Size(198, 22);
            this.lblServiceActivity.TabIndex = 8;
            this.lblServiceActivity.Text = "Service Activity";
            this.lblServiceActivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStopService
            // 
            this.btnStopService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopService.Enabled = false;
            this.btnStopService.Image = ((System.Drawing.Image)(resources.GetObject("btnStopService.Image")));
            this.btnStopService.Location = new System.Drawing.Point(284, 56);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(35, 35);
            this.btnStopService.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnStopService, "Edit display name");
            this.btnStopService.UseVisualStyleBackColor = true;
            // 
            // btnStartService
            // 
            this.btnStartService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartService.Enabled = false;
            this.btnStartService.Image = global::ARKViewer.Properties.Resources.playicon;
            this.btnStartService.Location = new System.Drawing.Point(325, 56);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(35, 35);
            this.btnStartService.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnStartService, "Edit display name");
            this.btnStartService.UseVisualStyleBackColor = true;
            // 
            // lblService
            // 
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(10, 16);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(198, 22);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Service";
            this.lblService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderService
            // 
            this.lblHeaderService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderService.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHeaderService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderService.Location = new System.Drawing.Point(-2, 6);
            this.lblHeaderService.Name = "lblHeaderService";
            this.lblHeaderService.Size = new System.Drawing.Size(499, 6);
            this.lblHeaderService.TabIndex = 0;
            this.lblHeaderService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServicePort
            // 
            this.lblServicePort.AutoSize = true;
            this.lblServicePort.BackColor = System.Drawing.Color.Transparent;
            this.lblServicePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicePort.Location = new System.Drawing.Point(208, 39);
            this.lblServicePort.Name = "lblServicePort";
            this.lblServicePort.Size = new System.Drawing.Size(72, 15);
            this.lblServicePort.TabIndex = 3;
            this.lblServicePort.Text = "Service Port";
            this.lblServicePort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpClientAccess
            // 
            this.grpClientAccess.Controls.Add(this.lblClientAccess);
            this.grpClientAccess.Controls.Add(this.chkFilterClient);
            this.grpClientAccess.Controls.Add(this.lblHeaderClientAccess);
            this.grpClientAccess.Controls.Add(this.txtFilterClient);
            this.grpClientAccess.Controls.Add(this.btnEditClient);
            this.grpClientAccess.Controls.Add(this.lvwClientAccess);
            this.grpClientAccess.Controls.Add(this.btnRemoveClient);
            this.grpClientAccess.Controls.Add(this.btnNewClient);
            this.grpClientAccess.Location = new System.Drawing.Point(25, 305);
            this.grpClientAccess.Name = "grpClientAccess";
            this.grpClientAccess.Size = new System.Drawing.Size(496, 300);
            this.grpClientAccess.TabIndex = 1;
            this.grpClientAccess.TabStop = false;
            // 
            // lblClientAccess
            // 
            this.lblClientAccess.BackColor = System.Drawing.Color.Transparent;
            this.lblClientAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAccess.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblClientAccess.Location = new System.Drawing.Point(10, 16);
            this.lblClientAccess.Name = "lblClientAccess";
            this.lblClientAccess.Size = new System.Drawing.Size(198, 22);
            this.lblClientAccess.TabIndex = 1;
            this.lblClientAccess.Text = "Client Access";
            this.lblClientAccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkFilterClient
            // 
            this.chkFilterClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFilterClient.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFilterClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkFilterClient.Image = global::ARKViewer.Properties.Resources.button_filter;
            this.chkFilterClient.Location = new System.Drawing.Point(412, 249);
            this.chkFilterClient.Name = "chkFilterClient";
            this.chkFilterClient.Size = new System.Drawing.Size(35, 35);
            this.chkFilterClient.TabIndex = 6;
            this.toolTip1.SetToolTip(this.chkFilterClient, "Apply filter");
            this.chkFilterClient.UseVisualStyleBackColor = true;
            this.chkFilterClient.CheckedChanged += new System.EventHandler(this.chkFilterClient_CheckedChanged);
            // 
            // lblHeaderClientAccess
            // 
            this.lblHeaderClientAccess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderClientAccess.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHeaderClientAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderClientAccess.Location = new System.Drawing.Point(-2, 6);
            this.lblHeaderClientAccess.Name = "lblHeaderClientAccess";
            this.lblHeaderClientAccess.Size = new System.Drawing.Size(499, 6);
            this.lblHeaderClientAccess.TabIndex = 0;
            this.lblHeaderClientAccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFilterClient
            // 
            this.txtFilterClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterClient.Location = new System.Drawing.Point(92, 258);
            this.txtFilterClient.Name = "txtFilterClient";
            this.txtFilterClient.Size = new System.Drawing.Size(315, 20);
            this.txtFilterClient.TabIndex = 5;
            // 
            // btnEditClient
            // 
            this.btnEditClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditClient.Enabled = false;
            this.btnEditClient.Image = ((System.Drawing.Image)(resources.GetObject("btnEditClient.Image")));
            this.btnEditClient.Location = new System.Drawing.Point(453, 249);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(35, 35);
            this.btnEditClient.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnEditClient, "Edit client access");
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // lvwClientAccess
            // 
            this.lvwClientAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwClientAccess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.lvwClientAccess.FullRowSelect = true;
            this.lvwClientAccess.HideSelection = false;
            this.lvwClientAccess.Location = new System.Drawing.Point(13, 45);
            this.lvwClientAccess.Name = "lvwClientAccess";
            this.lvwClientAccess.Size = new System.Drawing.Size(473, 197);
            this.lvwClientAccess.TabIndex = 2;
            this.lvwClientAccess.UseCompatibleStateImageBehavior = false;
            this.lvwClientAccess.View = System.Windows.Forms.View.Details;
            this.lvwClientAccess.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwClientAccess_ColumnClick);
            this.lvwClientAccess.SelectedIndexChanged += new System.EventHandler(this.lvwClientAccess_SelectedIndexChanged);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Account Name";
            this.columnHeader13.Width = 200;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Created";
            this.columnHeader14.Width = 120;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Last Request";
            this.columnHeader15.Width = 120;
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveClient.Enabled = false;
            this.btnRemoveClient.Image = global::ARKViewer.Properties.Resources.button_remove;
            this.btnRemoveClient.Location = new System.Drawing.Point(52, 250);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveClient.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnRemoveClient, "Remove client access");
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            this.btnRemoveClient.Click += new System.EventHandler(this.btnRemoveClient_Click);
            // 
            // btnNewClient
            // 
            this.btnNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewClient.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnNewClient.Location = new System.Drawing.Point(13, 250);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(35, 35);
            this.btnNewClient.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnNewClient, "Add new client");
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // tpgOptions
            // 
            this.tpgOptions.Controls.Add(this.groupBox1);
            this.tpgOptions.Location = new System.Drawing.Point(4, 22);
            this.tpgOptions.Name = "tpgOptions";
            this.tpgOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tpgOptions.Size = new System.Drawing.Size(545, 626);
            this.tpgOptions.TabIndex = 3;
            this.tpgOptions.Text = "Options";
            this.tpgOptions.UseVisualStyleBackColor = true;
            this.tpgOptions.Click += new System.EventHandler(this.tpgPlayers_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlCommandExportOptions);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pnlFtpSettingsCommands);
            this.groupBox1.Controls.Add(this.pnlPlayerSettingsStuctures);
            this.groupBox1.Controls.Add(this.pnlPlayerSettingsCommands);
            this.groupBox1.Controls.Add(this.pnlPlayerSettingsTames);
            this.groupBox1.Controls.Add(this.pnlPlayerSettingsBody);
            this.groupBox1.Location = new System.Drawing.Point(16, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 580);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // pnlCommandExportOptions
            // 
            this.pnlCommandExportOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCommandExportOptions.BackColor = System.Drawing.Color.Transparent;
            this.pnlCommandExportOptions.Controls.Add(this.optExportNoSort);
            this.pnlCommandExportOptions.Controls.Add(this.optExportSort);
            this.pnlCommandExportOptions.Controls.Add(this.lblCommandExportOptionTitle);
            this.pnlCommandExportOptions.Controls.Add(this.lblCommandExportDescription);
            this.pnlCommandExportOptions.Location = new System.Drawing.Point(6, 374);
            this.pnlCommandExportOptions.Name = "pnlCommandExportOptions";
            this.pnlCommandExportOptions.Size = new System.Drawing.Size(497, 59);
            this.pnlCommandExportOptions.TabIndex = 0;
            // 
            // optExportNoSort
            // 
            this.optExportNoSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optExportNoSort.AutoSize = true;
            this.optExportNoSort.Checked = true;
            this.optExportNoSort.Location = new System.Drawing.Point(339, 32);
            this.optExportNoSort.Name = "optExportNoSort";
            this.optExportNoSort.Size = new System.Drawing.Size(39, 17);
            this.optExportNoSort.TabIndex = 2;
            this.optExportNoSort.TabStop = true;
            this.optExportNoSort.Text = "No";
            this.optExportNoSort.UseVisualStyleBackColor = true;
            // 
            // optExportSort
            // 
            this.optExportSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optExportSort.AutoSize = true;
            this.optExportSort.Location = new System.Drawing.Point(432, 32);
            this.optExportSort.Name = "optExportSort";
            this.optExportSort.Size = new System.Drawing.Size(43, 17);
            this.optExportSort.TabIndex = 3;
            this.optExportSort.Text = "Yes";
            this.optExportSort.UseVisualStyleBackColor = true;
            // 
            // lblCommandExportOptionTitle
            // 
            this.lblCommandExportOptionTitle.AutoSize = true;
            this.lblCommandExportOptionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommandExportOptionTitle.Location = new System.Drawing.Point(10, 9);
            this.lblCommandExportOptionTitle.Name = "lblCommandExportOptionTitle";
            this.lblCommandExportOptionTitle.Size = new System.Drawing.Size(175, 18);
            this.lblCommandExportOptionTitle.TabIndex = 0;
            this.lblCommandExportOptionTitle.Text = "Command Line Export";
            // 
            // lblCommandExportDescription
            // 
            this.lblCommandExportDescription.AutoSize = true;
            this.lblCommandExportDescription.Location = new System.Drawing.Point(10, 34);
            this.lblCommandExportDescription.Name = "lblCommandExportDescription";
            this.lblCommandExportDescription.Size = new System.Drawing.Size(175, 13);
            this.lblCommandExportDescription.TabIndex = 1;
            this.lblCommandExportDescription.Text = "Sort creature exports by class name";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Aqua;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(515, 6);
            this.label4.TabIndex = 0;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFtpSettingsCommands
            // 
            this.pnlFtpSettingsCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFtpSettingsCommands.BackColor = System.Drawing.Color.Transparent;
            this.pnlFtpSettingsCommands.Controls.Add(this.pnlDownloadOption);
            this.pnlFtpSettingsCommands.Controls.Add(this.label5);
            this.pnlFtpSettingsCommands.Controls.Add(this.optFTPSync);
            this.pnlFtpSettingsCommands.Controls.Add(this.optFTPClean);
            this.pnlFtpSettingsCommands.Controls.Add(this.label2);
            this.pnlFtpSettingsCommands.Controls.Add(this.label3);
            this.pnlFtpSettingsCommands.Location = new System.Drawing.Point(5, 270);
            this.pnlFtpSettingsCommands.Name = "pnlFtpSettingsCommands";
            this.pnlFtpSettingsCommands.Size = new System.Drawing.Size(497, 98);
            this.pnlFtpSettingsCommands.TabIndex = 5;
            // 
            // optFTPSync
            // 
            this.optFTPSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optFTPSync.AutoSize = true;
            this.optFTPSync.Checked = true;
            this.optFTPSync.Location = new System.Drawing.Point(339, 33);
            this.optFTPSync.Name = "optFTPSync";
            this.optFTPSync.Size = new System.Drawing.Size(83, 17);
            this.optFTPSync.TabIndex = 2;
            this.optFTPSync.TabStop = true;
            this.optFTPSync.Text = "Synchronise";
            this.optFTPSync.UseVisualStyleBackColor = true;
            this.optFTPSync.CheckedChanged += new System.EventHandler(this.optFTPSync_CheckedChanged);
            // 
            // optFTPClean
            // 
            this.optFTPClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optFTPClean.AutoSize = true;
            this.optFTPClean.Location = new System.Drawing.Point(432, 33);
            this.optFTPClean.Name = "optFTPClean";
            this.optFTPClean.Size = new System.Drawing.Size(52, 17);
            this.optFTPClean.TabIndex = 3;
            this.optFTPClean.Text = "Clean";
            this.optFTPClean.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "FTP Downloads";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "How to handle downloads";
            // 
            // pnlPlayerSettingsStuctures
            // 
            this.pnlPlayerSettingsStuctures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlayerSettingsStuctures.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayerSettingsStuctures.Controls.Add(this.optPlayerStructureHide);
            this.pnlPlayerSettingsStuctures.Controls.Add(this.optPlayerStructureShow);
            this.pnlPlayerSettingsStuctures.Controls.Add(this.lblOptionHeaderStructures);
            this.pnlPlayerSettingsStuctures.Controls.Add(this.lblOptionTextStructures);
            this.pnlPlayerSettingsStuctures.Location = new System.Drawing.Point(6, 23);
            this.pnlPlayerSettingsStuctures.Name = "pnlPlayerSettingsStuctures";
            this.pnlPlayerSettingsStuctures.Size = new System.Drawing.Size(497, 50);
            this.pnlPlayerSettingsStuctures.TabIndex = 0;
            // 
            // optPlayerStructureHide
            // 
            this.optPlayerStructureHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optPlayerStructureHide.AutoSize = true;
            this.optPlayerStructureHide.Checked = true;
            this.optPlayerStructureHide.Location = new System.Drawing.Point(374, 25);
            this.optPlayerStructureHide.Name = "optPlayerStructureHide";
            this.optPlayerStructureHide.Size = new System.Drawing.Size(47, 17);
            this.optPlayerStructureHide.TabIndex = 2;
            this.optPlayerStructureHide.TabStop = true;
            this.optPlayerStructureHide.Text = "Hide";
            this.optPlayerStructureHide.UseVisualStyleBackColor = true;
            this.optPlayerStructureHide.CheckedChanged += new System.EventHandler(this.optPlayerStructureHide_CheckedChanged);
            // 
            // optPlayerStructureShow
            // 
            this.optPlayerStructureShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optPlayerStructureShow.AutoSize = true;
            this.optPlayerStructureShow.Location = new System.Drawing.Point(432, 25);
            this.optPlayerStructureShow.Name = "optPlayerStructureShow";
            this.optPlayerStructureShow.Size = new System.Drawing.Size(52, 17);
            this.optPlayerStructureShow.TabIndex = 3;
            this.optPlayerStructureShow.Text = "Show";
            this.optPlayerStructureShow.UseVisualStyleBackColor = true;
            this.optPlayerStructureShow.CheckedChanged += new System.EventHandler(this.optPlayerStructureShow_CheckedChanged);
            // 
            // lblOptionHeaderStructures
            // 
            this.lblOptionHeaderStructures.AutoSize = true;
            this.lblOptionHeaderStructures.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionHeaderStructures.Location = new System.Drawing.Point(10, 5);
            this.lblOptionHeaderStructures.Name = "lblOptionHeaderStructures";
            this.lblOptionHeaderStructures.Size = new System.Drawing.Size(86, 18);
            this.lblOptionHeaderStructures.TabIndex = 0;
            this.lblOptionHeaderStructures.Text = "Structures";
            // 
            // lblOptionTextStructures
            // 
            this.lblOptionTextStructures.AutoSize = true;
            this.lblOptionTextStructures.Location = new System.Drawing.Point(10, 27);
            this.lblOptionTextStructures.Name = "lblOptionTextStructures";
            this.lblOptionTextStructures.Size = new System.Drawing.Size(261, 13);
            this.lblOptionTextStructures.TabIndex = 1;
            this.lblOptionTextStructures.Text = "Display Tribes and Players with no placed structure(s).";
            // 
            // pnlPlayerSettingsCommands
            // 
            this.pnlPlayerSettingsCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlayerSettingsCommands.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayerSettingsCommands.Controls.Add(this.optPlayerCommandsPrefixAdmincheat);
            this.pnlPlayerSettingsCommands.Controls.Add(this.optPlayerCommandsPrefixNone);
            this.pnlPlayerSettingsCommands.Controls.Add(this.optPlayerCommandsPrefixCheat);
            this.pnlPlayerSettingsCommands.Controls.Add(this.lblOptionHeaderCommand);
            this.pnlPlayerSettingsCommands.Controls.Add(this.lblOptionTextCommand);
            this.pnlPlayerSettingsCommands.Location = new System.Drawing.Point(5, 203);
            this.pnlPlayerSettingsCommands.Name = "pnlPlayerSettingsCommands";
            this.pnlPlayerSettingsCommands.Size = new System.Drawing.Size(497, 61);
            this.pnlPlayerSettingsCommands.TabIndex = 4;
            // 
            // optPlayerCommandsPrefixAdmincheat
            // 
            this.optPlayerCommandsPrefixAdmincheat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optPlayerCommandsPrefixAdmincheat.AutoSize = true;
            this.optPlayerCommandsPrefixAdmincheat.Location = new System.Drawing.Point(344, 30);
            this.optPlayerCommandsPrefixAdmincheat.Name = "optPlayerCommandsPrefixAdmincheat";
            this.optPlayerCommandsPrefixAdmincheat.Size = new System.Drawing.Size(83, 17);
            this.optPlayerCommandsPrefixAdmincheat.TabIndex = 3;
            this.optPlayerCommandsPrefixAdmincheat.Text = "admincheat ";
            this.optPlayerCommandsPrefixAdmincheat.UseVisualStyleBackColor = true;
            this.optPlayerCommandsPrefixAdmincheat.CheckedChanged += new System.EventHandler(this.optPlayerCommandsPrefixAdmincheat_CheckedChanged);
            // 
            // optPlayerCommandsPrefixNone
            // 
            this.optPlayerCommandsPrefixNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optPlayerCommandsPrefixNone.AutoSize = true;
            this.optPlayerCommandsPrefixNone.Checked = true;
            this.optPlayerCommandsPrefixNone.Location = new System.Drawing.Point(266, 30);
            this.optPlayerCommandsPrefixNone.Name = "optPlayerCommandsPrefixNone";
            this.optPlayerCommandsPrefixNone.Size = new System.Drawing.Size(57, 17);
            this.optPlayerCommandsPrefixNone.TabIndex = 2;
            this.optPlayerCommandsPrefixNone.TabStop = true;
            this.optPlayerCommandsPrefixNone.Text = "[None]";
            this.optPlayerCommandsPrefixNone.UseVisualStyleBackColor = true;
            this.optPlayerCommandsPrefixNone.CheckedChanged += new System.EventHandler(this.optPlayerCommandsPrefixNone_CheckedChanged);
            // 
            // optPlayerCommandsPrefixCheat
            // 
            this.optPlayerCommandsPrefixCheat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optPlayerCommandsPrefixCheat.AutoSize = true;
            this.optPlayerCommandsPrefixCheat.Location = new System.Drawing.Point(432, 30);
            this.optPlayerCommandsPrefixCheat.Name = "optPlayerCommandsPrefixCheat";
            this.optPlayerCommandsPrefixCheat.Size = new System.Drawing.Size(55, 17);
            this.optPlayerCommandsPrefixCheat.TabIndex = 4;
            this.optPlayerCommandsPrefixCheat.Text = "cheat ";
            this.optPlayerCommandsPrefixCheat.UseVisualStyleBackColor = true;
            this.optPlayerCommandsPrefixCheat.CheckedChanged += new System.EventHandler(this.optPlayerCommandsPrefixCheat_CheckedChanged);
            // 
            // lblOptionHeaderCommand
            // 
            this.lblOptionHeaderCommand.AutoSize = true;
            this.lblOptionHeaderCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionHeaderCommand.Location = new System.Drawing.Point(10, 8);
            this.lblOptionHeaderCommand.Name = "lblOptionHeaderCommand";
            this.lblOptionHeaderCommand.Size = new System.Drawing.Size(133, 18);
            this.lblOptionHeaderCommand.TabIndex = 0;
            this.lblOptionHeaderCommand.Text = "Command Prefix";
            // 
            // lblOptionTextCommand
            // 
            this.lblOptionTextCommand.AutoSize = true;
            this.lblOptionTextCommand.Location = new System.Drawing.Point(10, 32);
            this.lblOptionTextCommand.Name = "lblOptionTextCommand";
            this.lblOptionTextCommand.Size = new System.Drawing.Size(149, 13);
            this.lblOptionTextCommand.TabIndex = 1;
            this.lblOptionTextCommand.Text = "Add prefix to copy commands:";
            // 
            // pnlPlayerSettingsTames
            // 
            this.pnlPlayerSettingsTames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlayerSettingsTames.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayerSettingsTames.Controls.Add(this.optPlayerTameHide);
            this.pnlPlayerSettingsTames.Controls.Add(this.optPlayerTameShow);
            this.pnlPlayerSettingsTames.Controls.Add(this.lblOptionHeaderTames);
            this.pnlPlayerSettingsTames.Controls.Add(this.lblOptionTextTames);
            this.pnlPlayerSettingsTames.Location = new System.Drawing.Point(6, 79);
            this.pnlPlayerSettingsTames.Name = "pnlPlayerSettingsTames";
            this.pnlPlayerSettingsTames.Size = new System.Drawing.Size(497, 55);
            this.pnlPlayerSettingsTames.TabIndex = 2;
            // 
            // optPlayerTameHide
            // 
            this.optPlayerTameHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optPlayerTameHide.AutoSize = true;
            this.optPlayerTameHide.Checked = true;
            this.optPlayerTameHide.Location = new System.Drawing.Point(374, 28);
            this.optPlayerTameHide.Name = "optPlayerTameHide";
            this.optPlayerTameHide.Size = new System.Drawing.Size(47, 17);
            this.optPlayerTameHide.TabIndex = 2;
            this.optPlayerTameHide.TabStop = true;
            this.optPlayerTameHide.Text = "Hide";
            this.optPlayerTameHide.UseVisualStyleBackColor = true;
            this.optPlayerTameHide.CheckedChanged += new System.EventHandler(this.optPlayerTameHide_CheckedChanged);
            // 
            // optPlayerTameShow
            // 
            this.optPlayerTameShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optPlayerTameShow.AutoSize = true;
            this.optPlayerTameShow.Location = new System.Drawing.Point(432, 28);
            this.optPlayerTameShow.Name = "optPlayerTameShow";
            this.optPlayerTameShow.Size = new System.Drawing.Size(52, 17);
            this.optPlayerTameShow.TabIndex = 3;
            this.optPlayerTameShow.Text = "Show";
            this.optPlayerTameShow.UseVisualStyleBackColor = true;
            this.optPlayerTameShow.CheckedChanged += new System.EventHandler(this.optPlayerTameShow_CheckedChanged);
            // 
            // lblOptionHeaderTames
            // 
            this.lblOptionHeaderTames.AutoSize = true;
            this.lblOptionHeaderTames.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionHeaderTames.Location = new System.Drawing.Point(10, 7);
            this.lblOptionHeaderTames.Name = "lblOptionHeaderTames";
            this.lblOptionHeaderTames.Size = new System.Drawing.Size(59, 18);
            this.lblOptionHeaderTames.TabIndex = 0;
            this.lblOptionHeaderTames.Text = "Tames";
            // 
            // lblOptionTextTames
            // 
            this.lblOptionTextTames.AutoSize = true;
            this.lblOptionTextTames.Location = new System.Drawing.Point(10, 30);
            this.lblOptionTextTames.Name = "lblOptionTextTames";
            this.lblOptionTextTames.Size = new System.Drawing.Size(250, 13);
            this.lblOptionTextTames.TabIndex = 1;
            this.lblOptionTextTames.Text = "Display Tribes and Players with no tamed creatures.";
            // 
            // pnlPlayerSettingsBody
            // 
            this.pnlPlayerSettingsBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlayerSettingsBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayerSettingsBody.Controls.Add(this.optPlayerBodyHide);
            this.pnlPlayerSettingsBody.Controls.Add(this.optPlayerBodyShow);
            this.pnlPlayerSettingsBody.Controls.Add(this.lblOptionHeaderBody);
            this.pnlPlayerSettingsBody.Controls.Add(this.lblOptionTextBody);
            this.pnlPlayerSettingsBody.Location = new System.Drawing.Point(6, 140);
            this.pnlPlayerSettingsBody.Name = "pnlPlayerSettingsBody";
            this.pnlPlayerSettingsBody.Size = new System.Drawing.Size(497, 57);
            this.pnlPlayerSettingsBody.TabIndex = 3;
            // 
            // optPlayerBodyHide
            // 
            this.optPlayerBodyHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optPlayerBodyHide.AutoSize = true;
            this.optPlayerBodyHide.Checked = true;
            this.optPlayerBodyHide.Location = new System.Drawing.Point(374, 30);
            this.optPlayerBodyHide.Name = "optPlayerBodyHide";
            this.optPlayerBodyHide.Size = new System.Drawing.Size(47, 17);
            this.optPlayerBodyHide.TabIndex = 2;
            this.optPlayerBodyHide.TabStop = true;
            this.optPlayerBodyHide.Text = "Hide";
            this.optPlayerBodyHide.UseVisualStyleBackColor = true;
            this.optPlayerBodyHide.CheckedChanged += new System.EventHandler(this.optPlayerBodyHide_CheckedChanged);
            // 
            // optPlayerBodyShow
            // 
            this.optPlayerBodyShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optPlayerBodyShow.AutoSize = true;
            this.optPlayerBodyShow.Location = new System.Drawing.Point(432, 30);
            this.optPlayerBodyShow.Name = "optPlayerBodyShow";
            this.optPlayerBodyShow.Size = new System.Drawing.Size(52, 17);
            this.optPlayerBodyShow.TabIndex = 3;
            this.optPlayerBodyShow.Text = "Show";
            this.optPlayerBodyShow.UseVisualStyleBackColor = true;
            this.optPlayerBodyShow.CheckedChanged += new System.EventHandler(this.optPlayerBodyShow_CheckedChanged);
            // 
            // lblOptionHeaderBody
            // 
            this.lblOptionHeaderBody.AutoSize = true;
            this.lblOptionHeaderBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionHeaderBody.Location = new System.Drawing.Point(10, 8);
            this.lblOptionHeaderBody.Name = "lblOptionHeaderBody";
            this.lblOptionHeaderBody.Size = new System.Drawing.Size(46, 18);
            this.lblOptionHeaderBody.TabIndex = 0;
            this.lblOptionHeaderBody.Text = "Body";
            // 
            // lblOptionTextBody
            // 
            this.lblOptionTextBody.AutoSize = true;
            this.lblOptionTextBody.Location = new System.Drawing.Point(10, 32);
            this.lblOptionTextBody.Name = "lblOptionTextBody";
            this.lblOptionTextBody.Size = new System.Drawing.Size(289, 13);
            this.lblOptionTextBody.TabIndex = 1;
            this.lblOptionTextBody.Text = "Display Tribes and Players with no body. (Dead / Uploaded)";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 10;
            this.toolTip1.AutoPopDelay = 2000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.ReshowDelay = 2000;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Download before loading map?";
            // 
            // pnlDownloadOption
            // 
            this.pnlDownloadOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDownloadOption.Controls.Add(this.optDownloadAuto);
            this.pnlDownloadOption.Controls.Add(this.optDownloadManual);
            this.pnlDownloadOption.Location = new System.Drawing.Point(321, 55);
            this.pnlDownloadOption.Name = "pnlDownloadOption";
            this.pnlDownloadOption.Size = new System.Drawing.Size(173, 33);
            this.pnlDownloadOption.TabIndex = 5;
            // 
            // optDownloadAuto
            // 
            this.optDownloadAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optDownloadAuto.AutoSize = true;
            this.optDownloadAuto.Checked = true;
            this.optDownloadAuto.Location = new System.Drawing.Point(54, 8);
            this.optDownloadAuto.Name = "optDownloadAuto";
            this.optDownloadAuto.Size = new System.Drawing.Size(47, 17);
            this.optDownloadAuto.TabIndex = 4;
            this.optDownloadAuto.TabStop = true;
            this.optDownloadAuto.Text = "Auto";
            this.optDownloadAuto.UseVisualStyleBackColor = true;
            // 
            // optDownloadManual
            // 
            this.optDownloadManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optDownloadManual.AutoSize = true;
            this.optDownloadManual.Location = new System.Drawing.Point(103, 8);
            this.optDownloadManual.Name = "optDownloadManual";
            this.optDownloadManual.Size = new System.Drawing.Size(60, 17);
            this.optDownloadManual.TabIndex = 5;
            this.optDownloadManual.Text = "Manual";
            this.optDownloadManual.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(579, 704);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tabSettings.ResumeLayout(false);
            this.tpgMap.ResumeLayout(false);
            this.tpgMap.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpServer.ResumeLayout(false);
            this.grpOffline.ResumeLayout(false);
            this.grpSinglePlayer.ResumeLayout(false);
            this.grpSinglePlayer.PerformLayout();
            this.tpgColours.ResumeLayout(false);
            this.grpColoursNotMapped.ResumeLayout(false);
            this.grpColours.ResumeLayout(false);
            this.grpColours.PerformLayout();
            this.tpgCreatures.ResumeLayout(false);
            this.grpCreaturesNotMapped.ResumeLayout(false);
            this.grpCreatures.ResumeLayout(false);
            this.grpCreatures.PerformLayout();
            this.tpgStructures.ResumeLayout(false);
            this.grpStructuresNotMapped.ResumeLayout(false);
            this.grpStructures.ResumeLayout(false);
            this.grpStructures.PerformLayout();
            this.tpgItems.ResumeLayout(false);
            this.grpItemsNotMatched.ResumeLayout(false);
            this.grpItems.ResumeLayout(false);
            this.grpItems.PerformLayout();
            this.tpgExport.ResumeLayout(false);
            this.grpJsonExport.ResumeLayout(false);
            this.grpJsonExport.PerformLayout();
            this.grpContentPack.ResumeLayout(false);
            this.grpContentPack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udExportRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udExportLon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udExportLat)).EndInit();
            this.tpgRestService.ResumeLayout(false);
            this.grpService.ResumeLayout(false);
            this.grpService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udServicePort)).EndInit();
            this.grpClientAccess.ResumeLayout(false);
            this.grpClientAccess.PerformLayout();
            this.tpgOptions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlCommandExportOptions.ResumeLayout(false);
            this.pnlCommandExportOptions.PerformLayout();
            this.pnlFtpSettingsCommands.ResumeLayout(false);
            this.pnlFtpSettingsCommands.PerformLayout();
            this.pnlPlayerSettingsStuctures.ResumeLayout(false);
            this.pnlPlayerSettingsStuctures.PerformLayout();
            this.pnlPlayerSettingsCommands.ResumeLayout(false);
            this.pnlPlayerSettingsCommands.PerformLayout();
            this.pnlPlayerSettingsTames.ResumeLayout(false);
            this.pnlPlayerSettingsTames.PerformLayout();
            this.pnlPlayerSettingsBody.ResumeLayout(false);
            this.pnlPlayerSettingsBody.PerformLayout();
            this.pnlDownloadOption.ResumeLayout(false);
            this.pnlDownloadOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tpgMap;
        private System.Windows.Forms.GroupBox grpServer;
        private System.Windows.Forms.Button btnRemoveServer;
        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.Label lblFTPServer;
        private System.Windows.Forms.ComboBox cboFTPServer;
        private System.Windows.Forms.GroupBox grpOffline;
        private System.Windows.Forms.Label lblOfflineSave;
        private System.Windows.Forms.GroupBox grpSinglePlayer;
        private System.Windows.Forms.Label lblSelectedMapSP;
        private System.Windows.Forms.ComboBox cboMapSinglePlayer;
        private System.Windows.Forms.RadioButton optOffline;
        private System.Windows.Forms.RadioButton optServer;
        private System.Windows.Forms.TabPage tpgCreatures;
        private System.Windows.Forms.ListView lvwDinoClasses;
        private System.Windows.Forms.ColumnHeader lvwDinoClasses_ClassName;
        private System.Windows.Forms.ColumnHeader lvwDinoClasses_DisplayName;
        private System.Windows.Forms.Button btnEditDinoClass;
        private System.Windows.Forms.Button btnRemoveDinoClass;
        private System.Windows.Forms.Button btnAddDinoClass;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tpgItems;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListView lvwItemMap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtCreatureFilter;
        private System.Windows.Forms.TextBox txtItemFilter;
        private System.Windows.Forms.CheckBox chkApplyFilterDinos;
        private System.Windows.Forms.CheckBox chkApplyFilterItems;
        private System.Windows.Forms.TabPage tpgOptions;
        private System.Windows.Forms.Panel pnlPlayerSettingsStuctures;
        private System.Windows.Forms.RadioButton optPlayerStructureHide;
        private System.Windows.Forms.RadioButton optPlayerStructureShow;
        private System.Windows.Forms.Label lblOptionHeaderStructures;
        private System.Windows.Forms.Label lblOptionTextStructures;
        private System.Windows.Forms.Panel pnlPlayerSettingsTames;
        private System.Windows.Forms.RadioButton optPlayerTameHide;
        private System.Windows.Forms.RadioButton optPlayerTameShow;
        private System.Windows.Forms.Label lblOptionHeaderTames;
        private System.Windows.Forms.Label lblOptionTextTames;
        private System.Windows.Forms.Panel pnlPlayerSettingsBody;
        private System.Windows.Forms.RadioButton optPlayerBodyHide;
        private System.Windows.Forms.RadioButton optPlayerBodyShow;
        private System.Windows.Forms.Label lblOptionHeaderBody;
        private System.Windows.Forms.Label lblOptionTextBody;
        private System.Windows.Forms.Panel pnlPlayerSettingsCommands;
        private System.Windows.Forms.RadioButton optPlayerCommandsPrefixAdmincheat;
        private System.Windows.Forms.RadioButton optPlayerCommandsPrefixNone;
        private System.Windows.Forms.RadioButton optPlayerCommandsPrefixCheat;
        private System.Windows.Forms.Label lblOptionHeaderCommand;
        private System.Windows.Forms.Label lblOptionTextCommand;
        private System.Windows.Forms.TabPage tpgStructures;
        private System.Windows.Forms.CheckBox chkApplyFilterStructures;
        private System.Windows.Forms.TextBox txtStructureFilter;
        private System.Windows.Forms.Button btnEditStructure;
        private System.Windows.Forms.Button btnRemoveStructure;
        private System.Windows.Forms.Button btnAddStructure;
        private System.Windows.Forms.ListView lvwStructureMap;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabPage tpgColours;
        private System.Windows.Forms.CheckBox chkApplyFilterColours;
        private System.Windows.Forms.TextBox txtFilterColour;
        private System.Windows.Forms.Button btnEditColour;
        private System.Windows.Forms.Button btnRemoveColour;
        private System.Windows.Forms.Button btnNewColour;
        private System.Windows.Forms.ListView lvwColours;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox cboFtpMap;
        private System.Windows.Forms.CheckBox chkUpdateNotificationSingle;
        private System.Windows.Forms.Panel pnlFtpSettingsCommands;
        private System.Windows.Forms.RadioButton optFTPSync;
        private System.Windows.Forms.RadioButton optFTPClean;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCommandExportOptions;
        private System.Windows.Forms.RadioButton optExportNoSort;
        private System.Windows.Forms.RadioButton optExportSort;
        private System.Windows.Forms.Label lblCommandExportOptionTitle;
        private System.Windows.Forms.Label lblCommandExportDescription;
        private System.Windows.Forms.TabPage tpgExport;
        private System.Windows.Forms.RadioButton optSinglePlayer;
        private System.Windows.Forms.GroupBox grpContentPack;
        private System.Windows.Forms.Label lblContentPackOptions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoadContentPack;
        private System.Windows.Forms.TextBox txtContentPackFilename;
        private System.Windows.Forms.Label lblSelectedMapContentPack;
        private System.Windows.Forms.CheckBox chkPlayerStructures;
        private System.Windows.Forms.CheckBox chkTamedCreatures;
        private System.Windows.Forms.CheckBox chkWildCreatures;
        private System.Windows.Forms.Label lblHeaderConteentPack;
        private System.Windows.Forms.Label lblFilterRad;
        private System.Windows.Forms.ComboBox cboExportPlayer;
        private System.Windows.Forms.ComboBox cboExportTribe;
        private System.Windows.Forms.Label lblFilterLon;
        private System.Windows.Forms.Label lblFilterLat;
        private System.Windows.Forms.Label lblFilterPlayer;
        private System.Windows.Forms.Label lblFilterTribe;
        private System.Windows.Forms.Label lblContentPackFilters;
        private System.Windows.Forms.GroupBox grpJsonExport;
        private System.Windows.Forms.Label lblExportPlayerStructures;
        private System.Windows.Forms.Button btnJsonExportPlayerStructures;
        private System.Windows.Forms.Label lblExportTamed;
        private System.Windows.Forms.Button btnJsonExportTamed;
        private System.Windows.Forms.Label lblExportPlayers;
        private System.Windows.Forms.Button btnJsonExportPlayers;
        private System.Windows.Forms.Label lblExportTribes;
        private System.Windows.Forms.Button btnJsonExportTribes;
        private System.Windows.Forms.Label lblExportWild;
        private System.Windows.Forms.Button btnJsonExportWild;
        private System.Windows.Forms.Label lblExportAll;
        private System.Windows.Forms.Button btnJsonExportAll;
        private System.Windows.Forms.Label lblHeaderJsonExport;
        private System.Windows.Forms.Label lblJsonFileExport;
        private System.Windows.Forms.Button btnExportContentPack;
        private System.Windows.Forms.NumericUpDown udExportRadius;
        private System.Windows.Forms.NumericUpDown udExportLon;
        private System.Windows.Forms.NumericUpDown udExportLat;
        private System.Windows.Forms.RadioButton optContentPack;
        private System.Windows.Forms.GroupBox grpColours;
        private System.Windows.Forms.Label lblHeaderColours;
        private System.Windows.Forms.GroupBox grpCreatures;
        private System.Windows.Forms.Label lblHeaderCreatures;
        private System.Windows.Forms.GroupBox grpStructures;
        private System.Windows.Forms.Label lblHeaderStructures;
        private System.Windows.Forms.GroupBox grpItems;
        private System.Windows.Forms.Label lblHeaderItems;
        private System.Windows.Forms.CheckBox chkStructureLocations;
        private System.Windows.Forms.CheckBox chkStructureContents;
        private System.Windows.Forms.CheckBox chkDroppedItems;
        private System.Windows.Forms.Button btnEditServer;
        private System.Windows.Forms.Label lblFtpMap;
        private System.Windows.Forms.GroupBox grpColoursNotMapped;
        private System.Windows.Forms.Label lblColourNotMapped;
        private System.Windows.Forms.Label lblHeaderColoursNotMatched;
        private System.Windows.Forms.ListView lvwColoursNotMapped;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnColoursNotMatchedAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCreaturesNotMapped;
        private System.Windows.Forms.Label lblCreaturesNotMapped;
        private System.Windows.Forms.Label lblHeaderCreaturesNotMapped;
        private System.Windows.Forms.ListView lvwCreaturesNotMapped;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.GroupBox grpStructuresNotMapped;
        private System.Windows.Forms.Label lblStructuresNotMapped;
        private System.Windows.Forms.Label lblHeaderStructuresNotMapped;
        private System.Windows.Forms.ListView lvwStructuresNotMapped;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.GroupBox grpItemsNotMatched;
        private System.Windows.Forms.Label lblItemsNotMatched;
        private System.Windows.Forms.Label lblHeaderItemsNotMatched;
        private System.Windows.Forms.ListView lvwItemsNotMatched;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnCreaturesNotMappedAdd;
        private System.Windows.Forms.Button btnStructuresNotMappedAdd;
        private System.Windows.Forms.Button btnItemsNotMatchedAdd;
        private System.Windows.Forms.RadioButton optApi;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TabPage tpgRestService;
        private System.Windows.Forms.GroupBox grpClientAccess;
        private System.Windows.Forms.Label lblClientAccess;
        private System.Windows.Forms.CheckBox chkFilterClient;
        private System.Windows.Forms.Label lblHeaderClientAccess;
        private System.Windows.Forms.TextBox txtFilterClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.ListView lvwClientAccess;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.GroupBox grpService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblHeaderService;
        private System.Windows.Forms.Button btnStartService;
        private System.Windows.Forms.Button btnStopService;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Label lblServiceActivity;
        private System.Windows.Forms.TextBox txtServiceStatus;
        private System.Windows.Forms.Button btnClearServiceLog;
        private System.Windows.Forms.TextBox txtServiceLog;
        private System.Windows.Forms.Label lblServicePort;
        private System.Windows.Forms.Label lblServiceStatus;
        private System.Windows.Forms.NumericUpDown udServicePort;
        private System.Windows.Forms.CheckBox chkAutostartService;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveARK;
        private System.Windows.Forms.Button btnAddARK;
        private System.Windows.Forms.ComboBox cboLocalARK;
        private System.Windows.Forms.Button btnRefreshUnknownColours;
        private System.Windows.Forms.Button btnRefreshUnknownCreatures;
        private System.Windows.Forms.Button btnRefreshUnknownStructures;
        private System.Windows.Forms.Button btnRefreshUnknownItems;
        private System.Windows.Forms.Button btnEditARK;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Panel pnlDownloadOption;
        private System.Windows.Forms.RadioButton optDownloadAuto;
        private System.Windows.Forms.RadioButton optDownloadManual;
        private System.Windows.Forms.Label label5;
    }
}
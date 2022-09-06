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
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.btnColoursNotMatchedAdd = new System.Windows.Forms.Button();
            this.grpColours = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkApplyFilterColours = new System.Windows.Forms.CheckBox();
            this.lblHeaderColours = new System.Windows.Forms.Label();
            this.txtFilterColour = new System.Windows.Forms.TextBox();
            this.btnEditColour = new System.Windows.Forms.Button();
            this.lvwColours = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.btnRemoveColour = new System.Windows.Forms.Button();
            this.btnNewColour = new System.Windows.Forms.Button();
            this.tpgCreatures = new System.Windows.Forms.TabPage();
            this.grpCreaturesNotMapped = new System.Windows.Forms.GroupBox();
            this.btnRefreshUnknownCreatures = new System.Windows.Forms.Button();
            this.btnCreaturesNotMappedAdd = new System.Windows.Forms.Button();
            this.lblCreaturesNotMapped = new System.Windows.Forms.Label();
            this.lblHeaderCreaturesNotMapped = new System.Windows.Forms.Label();
            this.lvwCreaturesNotMapped = new System.Windows.Forms.ListView();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.grpCreatures = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkApplyFilterDinos = new System.Windows.Forms.CheckBox();
            this.lblHeaderCreatures = new System.Windows.Forms.Label();
            this.txtCreatureFilter = new System.Windows.Forms.TextBox();
            this.lvwDinoClasses = new System.Windows.Forms.ListView();
            this.lvwDinoClasses_ClassName = new System.Windows.Forms.ColumnHeader();
            this.lvwDinoClasses_DisplayName = new System.Windows.Forms.ColumnHeader();
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
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.grpStructures = new System.Windows.Forms.GroupBox();
            this.chkApplyFilterStructures = new System.Windows.Forms.CheckBox();
            this.lblHeaderStructures = new System.Windows.Forms.Label();
            this.txtStructureFilter = new System.Windows.Forms.TextBox();
            this.lvwStructureMap = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
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
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.chkApplyFilterItems = new System.Windows.Forms.CheckBox();
            this.lblHeaderItems = new System.Windows.Forms.Label();
            this.txtItemFilter = new System.Windows.Forms.TextBox();
            this.lvwItemMap = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.tpgExport = new System.Windows.Forms.TabPage();
            this.grpJsonExport = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnJsonExportMapStructures = new System.Windows.Forms.Button();
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
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
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
            this.pnlDownloadOption = new System.Windows.Forms.Panel();
            this.optDownloadAuto = new System.Windows.Forms.RadioButton();
            this.optDownloadManual = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
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
            this.pnlDownloadOption.SuspendLayout();
            this.pnlPlayerSettingsStuctures.SuspendLayout();
            this.pnlPlayerSettingsCommands.SuspendLayout();
            this.pnlPlayerSettingsTames.SuspendLayout();
            this.pnlPlayerSettingsBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(485, 773);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 27);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(570, 773);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 27);
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
            this.tabSettings.Location = new System.Drawing.Point(14, 14);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabSettings.Multiline = true;
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(645, 752);
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
            this.tpgMap.Location = new System.Drawing.Point(4, 24);
            this.tpgMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgMap.Name = "tpgMap";
            this.tpgMap.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgMap.Size = new System.Drawing.Size(637, 724);
            this.tpgMap.TabIndex = 0;
            this.tpgMap.Text = "Map Data";
            this.tpgMap.UseVisualStyleBackColor = true;
            // 
            // optApi
            // 
            this.optApi.AutoSize = true;
            this.optApi.Enabled = false;
            this.optApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optApi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.optApi.Location = new System.Drawing.Point(50, 548);
            this.optApi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.groupBox6.Location = new System.Drawing.Point(47, 567);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(550, 110);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(14, 73);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "Access Key:";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(113, 67);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(405, 22);
            this.textBox6.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(14, 35);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Address:";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(113, 29);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(405, 22);
            this.textBox5.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(-2, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(553, 7);
            this.label13.TabIndex = 0;
            this.label13.Text = "   ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optContentPack
            // 
            this.optContentPack.AutoSize = true;
            this.optContentPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optContentPack.Location = new System.Drawing.Point(47, 273);
            this.optContentPack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.groupBox2.Location = new System.Drawing.Point(43, 290);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(550, 96);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnLoadContentPack
            // 
            this.btnLoadContentPack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadContentPack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadContentPack.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadContentPack.Image")));
            this.btnLoadContentPack.Location = new System.Drawing.Point(484, 33);
            this.btnLoadContentPack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoadContentPack.Name = "btnLoadContentPack";
            this.btnLoadContentPack.Size = new System.Drawing.Size(41, 40);
            this.btnLoadContentPack.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnLoadContentPack, "Open ARK save file");
            this.btnLoadContentPack.UseVisualStyleBackColor = true;
            this.btnLoadContentPack.Click += new System.EventHandler(this.btnLoadContentPack_Click);
            // 
            // txtContentPackFilename
            // 
            this.txtContentPackFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContentPackFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContentPackFilename.Location = new System.Drawing.Point(21, 40);
            this.txtContentPackFilename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContentPackFilename.Name = "txtContentPackFilename";
            this.txtContentPackFilename.ReadOnly = true;
            this.txtContentPackFilename.Size = new System.Drawing.Size(455, 22);
            this.txtContentPackFilename.TabIndex = 1;
            // 
            // lblSelectedMapContentPack
            // 
            this.lblSelectedMapContentPack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedMapContentPack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSelectedMapContentPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedMapContentPack.Location = new System.Drawing.Point(-2, 7);
            this.lblSelectedMapContentPack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedMapContentPack.Name = "lblSelectedMapContentPack";
            this.lblSelectedMapContentPack.Size = new System.Drawing.Size(553, 7);
            this.lblSelectedMapContentPack.TabIndex = 0;
            this.lblSelectedMapContentPack.Text = "   ";
            this.lblSelectedMapContentPack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optOffline
            // 
            this.optOffline.AutoSize = true;
            this.optOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optOffline.Location = new System.Drawing.Point(47, 155);
            this.optOffline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.optServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optServer.Location = new System.Drawing.Point(47, 392);
            this.optServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.optSinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optSinglePlayer.Location = new System.Drawing.Point(47, 32);
            this.optSinglePlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.grpServer.Location = new System.Drawing.Point(44, 415);
            this.grpServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpServer.Name = "grpServer";
            this.grpServer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpServer.Size = new System.Drawing.Size(550, 126);
            this.grpServer.TabIndex = 7;
            this.grpServer.TabStop = false;
            // 
            // btnEditServer
            // 
            this.btnEditServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditServer.Enabled = false;
            this.btnEditServer.Image = ((System.Drawing.Image)(resources.GetObject("btnEditServer.Image")));
            this.btnEditServer.Location = new System.Drawing.Point(390, 28);
            this.btnEditServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditServer.Name = "btnEditServer";
            this.btnEditServer.Size = new System.Drawing.Size(41, 40);
            this.btnEditServer.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnEditServer, "Edit server");
            this.btnEditServer.UseVisualStyleBackColor = true;
            this.btnEditServer.Click += new System.EventHandler(this.btnEditServer_Click);
            // 
            // lblFtpMap
            // 
            this.lblFtpMap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFtpMap.BackColor = System.Drawing.SystemColors.Control;
            this.lblFtpMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFtpMap.Location = new System.Drawing.Point(24, 76);
            this.lblFtpMap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFtpMap.Name = "lblFtpMap";
            this.lblFtpMap.Size = new System.Drawing.Size(134, 25);
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
            this.cboFtpMap.Location = new System.Drawing.Point(160, 77);
            this.cboFtpMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboFtpMap.Name = "cboFtpMap";
            this.cboFtpMap.Size = new System.Drawing.Size(361, 24);
            this.cboFtpMap.TabIndex = 19;
            this.cboFtpMap.SelectedIndexChanged += new System.EventHandler(this.cboFtpMap_SelectedIndexChanged);
            // 
            // btnRemoveServer
            // 
            this.btnRemoveServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveServer.Enabled = false;
            this.btnRemoveServer.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveServer.Image")));
            this.btnRemoveServer.Location = new System.Drawing.Point(483, 28);
            this.btnRemoveServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemoveServer.Name = "btnRemoveServer";
            this.btnRemoveServer.Size = new System.Drawing.Size(41, 40);
            this.btnRemoveServer.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnRemoveServer, "Remove selected server");
            this.btnRemoveServer.UseVisualStyleBackColor = true;
            this.btnRemoveServer.Click += new System.EventHandler(this.btnRemoveServer_Click);
            // 
            // btnAddServer
            // 
            this.btnAddServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddServer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddServer.Image")));
            this.btnAddServer.Location = new System.Drawing.Point(436, 28);
            this.btnAddServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(41, 40);
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
            this.lblFTPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFTPServer.Location = new System.Drawing.Point(-1, 0);
            this.lblFTPServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFTPServer.Name = "lblFTPServer";
            this.lblFTPServer.Size = new System.Drawing.Size(553, 7);
            this.lblFTPServer.TabIndex = 0;
            this.lblFTPServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboFTPServer
            // 
            this.cboFTPServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFTPServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFTPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboFTPServer.FormattingEnabled = true;
            this.cboFTPServer.Location = new System.Drawing.Point(29, 35);
            this.cboFTPServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboFTPServer.Name = "cboFTPServer";
            this.cboFTPServer.Size = new System.Drawing.Size(347, 24);
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
            this.grpOffline.Location = new System.Drawing.Point(43, 171);
            this.grpOffline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpOffline.Name = "grpOffline";
            this.grpOffline.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpOffline.Size = new System.Drawing.Size(550, 96);
            this.grpOffline.TabIndex = 3;
            this.grpOffline.TabStop = false;
            // 
            // btnEditARK
            // 
            this.btnEditARK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditARK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditARK.Enabled = false;
            this.btnEditARK.Image = ((System.Drawing.Image)(resources.GetObject("btnEditARK.Image")));
            this.btnEditARK.Location = new System.Drawing.Point(387, 32);
            this.btnEditARK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditARK.Name = "btnEditARK";
            this.btnEditARK.Size = new System.Drawing.Size(41, 40);
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
            this.btnRemoveARK.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveARK.Image")));
            this.btnRemoveARK.Location = new System.Drawing.Point(482, 32);
            this.btnRemoveARK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemoveARK.Name = "btnRemoveARK";
            this.btnRemoveARK.Size = new System.Drawing.Size(41, 40);
            this.btnRemoveARK.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnRemoveARK, "Remove selected offline file.");
            this.btnRemoveARK.UseVisualStyleBackColor = true;
            this.btnRemoveARK.Click += new System.EventHandler(this.btnRemoveARK_Click);
            // 
            // btnAddARK
            // 
            this.btnAddARK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddARK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddARK.Image = ((System.Drawing.Image)(resources.GetObject("btnAddARK.Image")));
            this.btnAddARK.Location = new System.Drawing.Point(435, 32);
            this.btnAddARK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddARK.Name = "btnAddARK";
            this.btnAddARK.Size = new System.Drawing.Size(41, 40);
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
            this.cboLocalARK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboLocalARK.FormattingEnabled = true;
            this.cboLocalARK.Location = new System.Drawing.Point(21, 39);
            this.cboLocalARK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboLocalARK.Name = "cboLocalARK";
            this.cboLocalARK.Size = new System.Drawing.Size(356, 24);
            this.cboLocalARK.TabIndex = 5;
            this.cboLocalARK.SelectedIndexChanged += new System.EventHandler(this.cboLocalARK_SelectedIndexChanged);
            // 
            // lblOfflineSave
            // 
            this.lblOfflineSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOfflineSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblOfflineSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOfflineSave.Location = new System.Drawing.Point(-2, 7);
            this.lblOfflineSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOfflineSave.Name = "lblOfflineSave";
            this.lblOfflineSave.Size = new System.Drawing.Size(553, 7);
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
            this.grpSinglePlayer.Location = new System.Drawing.Point(42, 48);
            this.grpSinglePlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpSinglePlayer.Name = "grpSinglePlayer";
            this.grpSinglePlayer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpSinglePlayer.Size = new System.Drawing.Size(551, 98);
            this.grpSinglePlayer.TabIndex = 1;
            this.grpSinglePlayer.TabStop = false;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectFolder.Enabled = false;
            this.btnSelectFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFolder.Image")));
            this.btnSelectFolder.Location = new System.Drawing.Point(483, 30);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(41, 40);
            this.btnSelectFolder.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSelectFolder, "Select ARK save location.");
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // chkUpdateNotificationSingle
            // 
            this.chkUpdateNotificationSingle.AutoSize = true;
            this.chkUpdateNotificationSingle.Enabled = false;
            this.chkUpdateNotificationSingle.Location = new System.Drawing.Point(22, 74);
            this.chkUpdateNotificationSingle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkUpdateNotificationSingle.Name = "chkUpdateNotificationSingle";
            this.chkUpdateNotificationSingle.Size = new System.Drawing.Size(133, 19);
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
            this.lblSelectedMapSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedMapSP.Location = new System.Drawing.Point(-2, 7);
            this.lblSelectedMapSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedMapSP.Name = "lblSelectedMapSP";
            this.lblSelectedMapSP.Size = new System.Drawing.Size(554, 7);
            this.lblSelectedMapSP.TabIndex = 0;
            this.lblSelectedMapSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboMapSinglePlayer
            // 
            this.cboMapSinglePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMapSinglePlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMapSinglePlayer.FormattingEnabled = true;
            this.cboMapSinglePlayer.Location = new System.Drawing.Point(22, 39);
            this.cboMapSinglePlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboMapSinglePlayer.Name = "cboMapSinglePlayer";
            this.cboMapSinglePlayer.Size = new System.Drawing.Size(455, 23);
            this.cboMapSinglePlayer.TabIndex = 1;
            this.cboMapSinglePlayer.SelectedIndexChanged += new System.EventHandler(this.cboMapSinglePlayer_SelectedIndexChanged);
            // 
            // tpgColours
            // 
            this.tpgColours.Controls.Add(this.grpColoursNotMapped);
            this.tpgColours.Controls.Add(this.grpColours);
            this.tpgColours.Location = new System.Drawing.Point(4, 24);
            this.tpgColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgColours.Name = "tpgColours";
            this.tpgColours.Size = new System.Drawing.Size(637, 724);
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
            this.grpColoursNotMapped.Location = new System.Drawing.Point(21, 402);
            this.grpColoursNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpColoursNotMapped.Name = "grpColoursNotMapped";
            this.grpColoursNotMapped.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpColoursNotMapped.Size = new System.Drawing.Size(593, 295);
            this.grpColoursNotMapped.TabIndex = 1;
            this.grpColoursNotMapped.TabStop = false;
            // 
            // btnRefreshUnknownColours
            // 
            this.btnRefreshUnknownColours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshUnknownColours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshUnknownColours.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshUnknownColours.Image")));
            this.btnRefreshUnknownColours.Location = new System.Drawing.Point(15, 245);
            this.btnRefreshUnknownColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefreshUnknownColours.Name = "btnRefreshUnknownColours";
            this.btnRefreshUnknownColours.Size = new System.Drawing.Size(41, 40);
            this.btnRefreshUnknownColours.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnRefreshUnknownColours, "Add mapping");
            this.btnRefreshUnknownColours.UseVisualStyleBackColor = true;
            this.btnRefreshUnknownColours.Click += new System.EventHandler(this.btnRefreshUnknownColours_Click);
            // 
            // lblColourNotMapped
            // 
            this.lblColourNotMapped.BackColor = System.Drawing.Color.Transparent;
            this.lblColourNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColourNotMapped.Location = new System.Drawing.Point(12, 18);
            this.lblColourNotMapped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColourNotMapped.Name = "lblColourNotMapped";
            this.lblColourNotMapped.Size = new System.Drawing.Size(231, 25);
            this.lblColourNotMapped.TabIndex = 1;
            this.lblColourNotMapped.Text = "Not Mapped";
            this.lblColourNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderColoursNotMatched
            // 
            this.lblHeaderColoursNotMatched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderColoursNotMatched.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHeaderColoursNotMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderColoursNotMatched.Location = new System.Drawing.Point(-2, 7);
            this.lblHeaderColoursNotMatched.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderColoursNotMatched.Name = "lblHeaderColoursNotMatched";
            this.lblHeaderColoursNotMatched.Size = new System.Drawing.Size(596, 7);
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
            this.lvwColoursNotMapped.Location = new System.Drawing.Point(15, 52);
            this.lvwColoursNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwColoursNotMapped.Name = "lvwColoursNotMapped";
            this.lvwColoursNotMapped.Size = new System.Drawing.Size(565, 186);
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
            this.btnColoursNotMatchedAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnColoursNotMatchedAdd.Image")));
            this.btnColoursNotMatchedAdd.Location = new System.Drawing.Point(541, 245);
            this.btnColoursNotMatchedAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnColoursNotMatchedAdd.Name = "btnColoursNotMatchedAdd";
            this.btnColoursNotMatchedAdd.Size = new System.Drawing.Size(41, 40);
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
            this.grpColours.Location = new System.Drawing.Point(21, 12);
            this.grpColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpColours.Name = "grpColours";
            this.grpColours.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpColours.Size = new System.Drawing.Size(593, 383);
            this.grpColours.TabIndex = 0;
            this.grpColours.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mapped";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkApplyFilterColours
            // 
            this.chkApplyFilterColours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkApplyFilterColours.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkApplyFilterColours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkApplyFilterColours.Image = ((System.Drawing.Image)(resources.GetObject("chkApplyFilterColours.Image")));
            this.chkApplyFilterColours.Location = new System.Drawing.Point(496, 331);
            this.chkApplyFilterColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkApplyFilterColours.Name = "chkApplyFilterColours";
            this.chkApplyFilterColours.Size = new System.Drawing.Size(41, 40);
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
            this.lblHeaderColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderColours.Location = new System.Drawing.Point(-2, 7);
            this.lblHeaderColours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderColours.Name = "lblHeaderColours";
            this.lblHeaderColours.Size = new System.Drawing.Size(596, 7);
            this.lblHeaderColours.TabIndex = 0;
            this.lblHeaderColours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFilterColour
            // 
            this.txtFilterColour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterColour.Location = new System.Drawing.Point(107, 339);
            this.txtFilterColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilterColour.Name = "txtFilterColour";
            this.txtFilterColour.Size = new System.Drawing.Size(381, 23);
            this.txtFilterColour.TabIndex = 4;
            // 
            // btnEditColour
            // 
            this.btnEditColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditColour.Enabled = false;
            this.btnEditColour.Image = ((System.Drawing.Image)(resources.GetObject("btnEditColour.Image")));
            this.btnEditColour.Location = new System.Drawing.Point(542, 331);
            this.btnEditColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditColour.Name = "btnEditColour";
            this.btnEditColour.Size = new System.Drawing.Size(41, 40);
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
            this.lvwColours.Location = new System.Drawing.Point(15, 52);
            this.lvwColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwColours.Name = "lvwColours";
            this.lvwColours.Size = new System.Drawing.Size(565, 272);
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
            this.btnRemoveColour.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveColour.Image")));
            this.btnRemoveColour.Location = new System.Drawing.Point(61, 331);
            this.btnRemoveColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemoveColour.Name = "btnRemoveColour";
            this.btnRemoveColour.Size = new System.Drawing.Size(41, 40);
            this.btnRemoveColour.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnRemoveColour, "Remove mapping");
            this.btnRemoveColour.UseVisualStyleBackColor = true;
            this.btnRemoveColour.Click += new System.EventHandler(this.btnRemoveColour_Click);
            // 
            // btnNewColour
            // 
            this.btnNewColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewColour.Image = ((System.Drawing.Image)(resources.GetObject("btnNewColour.Image")));
            this.btnNewColour.Location = new System.Drawing.Point(15, 331);
            this.btnNewColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewColour.Name = "btnNewColour";
            this.btnNewColour.Size = new System.Drawing.Size(41, 40);
            this.btnNewColour.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnNewColour, "Add new mapping");
            this.btnNewColour.UseVisualStyleBackColor = true;
            this.btnNewColour.Click += new System.EventHandler(this.btnNewColour_Click);
            // 
            // tpgCreatures
            // 
            this.tpgCreatures.Controls.Add(this.grpCreaturesNotMapped);
            this.tpgCreatures.Controls.Add(this.grpCreatures);
            this.tpgCreatures.Location = new System.Drawing.Point(4, 24);
            this.tpgCreatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgCreatures.Name = "tpgCreatures";
            this.tpgCreatures.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgCreatures.Size = new System.Drawing.Size(637, 724);
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
            this.grpCreaturesNotMapped.Location = new System.Drawing.Point(21, 402);
            this.grpCreaturesNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpCreaturesNotMapped.Name = "grpCreaturesNotMapped";
            this.grpCreaturesNotMapped.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpCreaturesNotMapped.Size = new System.Drawing.Size(593, 295);
            this.grpCreaturesNotMapped.TabIndex = 1;
            this.grpCreaturesNotMapped.TabStop = false;
            // 
            // btnRefreshUnknownCreatures
            // 
            this.btnRefreshUnknownCreatures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshUnknownCreatures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshUnknownCreatures.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshUnknownCreatures.Image")));
            this.btnRefreshUnknownCreatures.Location = new System.Drawing.Point(15, 245);
            this.btnRefreshUnknownCreatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefreshUnknownCreatures.Name = "btnRefreshUnknownCreatures";
            this.btnRefreshUnknownCreatures.Size = new System.Drawing.Size(41, 40);
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
            this.btnCreaturesNotMappedAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnCreaturesNotMappedAdd.Image")));
            this.btnCreaturesNotMappedAdd.Location = new System.Drawing.Point(541, 245);
            this.btnCreaturesNotMappedAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreaturesNotMappedAdd.Name = "btnCreaturesNotMappedAdd";
            this.btnCreaturesNotMappedAdd.Size = new System.Drawing.Size(41, 40);
            this.btnCreaturesNotMappedAdd.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCreaturesNotMappedAdd, "Add mapping");
            this.btnCreaturesNotMappedAdd.UseVisualStyleBackColor = true;
            this.btnCreaturesNotMappedAdd.Click += new System.EventHandler(this.btnCreaturesNotMappedAdd_Click);
            // 
            // lblCreaturesNotMapped
            // 
            this.lblCreaturesNotMapped.BackColor = System.Drawing.Color.Transparent;
            this.lblCreaturesNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreaturesNotMapped.Location = new System.Drawing.Point(12, 18);
            this.lblCreaturesNotMapped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreaturesNotMapped.Name = "lblCreaturesNotMapped";
            this.lblCreaturesNotMapped.Size = new System.Drawing.Size(231, 25);
            this.lblCreaturesNotMapped.TabIndex = 1;
            this.lblCreaturesNotMapped.Text = "Not Mapped";
            this.lblCreaturesNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderCreaturesNotMapped
            // 
            this.lblHeaderCreaturesNotMapped.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderCreaturesNotMapped.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHeaderCreaturesNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderCreaturesNotMapped.Location = new System.Drawing.Point(-2, 7);
            this.lblHeaderCreaturesNotMapped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderCreaturesNotMapped.Name = "lblHeaderCreaturesNotMapped";
            this.lblHeaderCreaturesNotMapped.Size = new System.Drawing.Size(596, 7);
            this.lblHeaderCreaturesNotMapped.TabIndex = 0;
            this.lblHeaderCreaturesNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwCreaturesNotMapped
            // 
            this.lvwCreaturesNotMapped.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12});
            this.lvwCreaturesNotMapped.FullRowSelect = true;
            this.lvwCreaturesNotMapped.Location = new System.Drawing.Point(15, 52);
            this.lvwCreaturesNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwCreaturesNotMapped.Name = "lvwCreaturesNotMapped";
            this.lvwCreaturesNotMapped.Size = new System.Drawing.Size(565, 186);
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
            this.grpCreatures.Location = new System.Drawing.Point(21, 12);
            this.grpCreatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpCreatures.Name = "grpCreatures";
            this.grpCreatures.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpCreatures.Size = new System.Drawing.Size(593, 383);
            this.grpCreatures.TabIndex = 0;
            this.grpCreatures.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mapped";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkApplyFilterDinos
            // 
            this.chkApplyFilterDinos.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkApplyFilterDinos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkApplyFilterDinos.Image = ((System.Drawing.Image)(resources.GetObject("chkApplyFilterDinos.Image")));
            this.chkApplyFilterDinos.Location = new System.Drawing.Point(496, 331);
            this.chkApplyFilterDinos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkApplyFilterDinos.Name = "chkApplyFilterDinos";
            this.chkApplyFilterDinos.Size = new System.Drawing.Size(41, 40);
            this.chkApplyFilterDinos.TabIndex = 7;
            this.chkApplyFilterDinos.UseVisualStyleBackColor = true;
            this.chkApplyFilterDinos.CheckedChanged += new System.EventHandler(this.chkApplyFilterDinos_CheckedChanged);
            // 
            // lblHeaderCreatures
            // 
            this.lblHeaderCreatures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderCreatures.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderCreatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderCreatures.Location = new System.Drawing.Point(-2, 7);
            this.lblHeaderCreatures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderCreatures.Name = "lblHeaderCreatures";
            this.lblHeaderCreatures.Size = new System.Drawing.Size(596, 7);
            this.lblHeaderCreatures.TabIndex = 1;
            this.lblHeaderCreatures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCreatureFilter
            // 
            this.txtCreatureFilter.Location = new System.Drawing.Point(107, 339);
            this.txtCreatureFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCreatureFilter.Name = "txtCreatureFilter";
            this.txtCreatureFilter.Size = new System.Drawing.Size(381, 23);
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
            this.lvwDinoClasses.Location = new System.Drawing.Point(15, 52);
            this.lvwDinoClasses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwDinoClasses.Name = "lvwDinoClasses";
            this.lvwDinoClasses.Size = new System.Drawing.Size(565, 272);
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
            this.btnEditDinoClass.Location = new System.Drawing.Point(542, 331);
            this.btnEditDinoClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditDinoClass.Name = "btnEditDinoClass";
            this.btnEditDinoClass.Size = new System.Drawing.Size(41, 40);
            this.btnEditDinoClass.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnEditDinoClass, "Edit display name");
            this.btnEditDinoClass.UseVisualStyleBackColor = true;
            this.btnEditDinoClass.Click += new System.EventHandler(this.btnEditDinoClass_Click);
            // 
            // btnAddDinoClass
            // 
            this.btnAddDinoClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDinoClass.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDinoClass.Image")));
            this.btnAddDinoClass.Location = new System.Drawing.Point(15, 331);
            this.btnAddDinoClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddDinoClass.Name = "btnAddDinoClass";
            this.btnAddDinoClass.Size = new System.Drawing.Size(41, 40);
            this.btnAddDinoClass.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAddDinoClass, "Add new display name");
            this.btnAddDinoClass.UseVisualStyleBackColor = true;
            this.btnAddDinoClass.Click += new System.EventHandler(this.btnAddDinoClass_Click);
            // 
            // btnRemoveDinoClass
            // 
            this.btnRemoveDinoClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveDinoClass.Enabled = false;
            this.btnRemoveDinoClass.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveDinoClass.Image")));
            this.btnRemoveDinoClass.Location = new System.Drawing.Point(61, 331);
            this.btnRemoveDinoClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemoveDinoClass.Name = "btnRemoveDinoClass";
            this.btnRemoveDinoClass.Size = new System.Drawing.Size(41, 40);
            this.btnRemoveDinoClass.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnRemoveDinoClass, "Remove display name");
            this.btnRemoveDinoClass.UseVisualStyleBackColor = true;
            this.btnRemoveDinoClass.Click += new System.EventHandler(this.btnRemoveDinoClass_Click);
            // 
            // tpgStructures
            // 
            this.tpgStructures.Controls.Add(this.grpStructuresNotMapped);
            this.tpgStructures.Controls.Add(this.grpStructures);
            this.tpgStructures.Location = new System.Drawing.Point(4, 24);
            this.tpgStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgStructures.Name = "tpgStructures";
            this.tpgStructures.Size = new System.Drawing.Size(637, 724);
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
            this.grpStructuresNotMapped.Location = new System.Drawing.Point(21, 402);
            this.grpStructuresNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpStructuresNotMapped.Name = "grpStructuresNotMapped";
            this.grpStructuresNotMapped.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpStructuresNotMapped.Size = new System.Drawing.Size(593, 295);
            this.grpStructuresNotMapped.TabIndex = 1;
            this.grpStructuresNotMapped.TabStop = false;
            // 
            // btnRefreshUnknownStructures
            // 
            this.btnRefreshUnknownStructures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshUnknownStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshUnknownStructures.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshUnknownStructures.Image")));
            this.btnRefreshUnknownStructures.Location = new System.Drawing.Point(15, 245);
            this.btnRefreshUnknownStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefreshUnknownStructures.Name = "btnRefreshUnknownStructures";
            this.btnRefreshUnknownStructures.Size = new System.Drawing.Size(41, 40);
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
            this.btnStructuresNotMappedAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnStructuresNotMappedAdd.Image")));
            this.btnStructuresNotMappedAdd.Location = new System.Drawing.Point(541, 245);
            this.btnStructuresNotMappedAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStructuresNotMappedAdd.Name = "btnStructuresNotMappedAdd";
            this.btnStructuresNotMappedAdd.Size = new System.Drawing.Size(41, 40);
            this.btnStructuresNotMappedAdd.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnStructuresNotMappedAdd, "Add mapping");
            this.btnStructuresNotMappedAdd.UseVisualStyleBackColor = true;
            this.btnStructuresNotMappedAdd.Click += new System.EventHandler(this.btnStructuresNotMappedAdd_Click);
            // 
            // lblStructuresNotMapped
            // 
            this.lblStructuresNotMapped.BackColor = System.Drawing.Color.Transparent;
            this.lblStructuresNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStructuresNotMapped.Location = new System.Drawing.Point(12, 18);
            this.lblStructuresNotMapped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStructuresNotMapped.Name = "lblStructuresNotMapped";
            this.lblStructuresNotMapped.Size = new System.Drawing.Size(231, 25);
            this.lblStructuresNotMapped.TabIndex = 1;
            this.lblStructuresNotMapped.Text = "Not Mapped";
            this.lblStructuresNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderStructuresNotMapped
            // 
            this.lblHeaderStructuresNotMapped.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderStructuresNotMapped.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHeaderStructuresNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderStructuresNotMapped.Location = new System.Drawing.Point(-2, 7);
            this.lblHeaderStructuresNotMapped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderStructuresNotMapped.Name = "lblHeaderStructuresNotMapped";
            this.lblHeaderStructuresNotMapped.Size = new System.Drawing.Size(596, 7);
            this.lblHeaderStructuresNotMapped.TabIndex = 0;
            this.lblHeaderStructuresNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwStructuresNotMapped
            // 
            this.lvwStructuresNotMapped.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10});
            this.lvwStructuresNotMapped.FullRowSelect = true;
            this.lvwStructuresNotMapped.Location = new System.Drawing.Point(15, 52);
            this.lvwStructuresNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwStructuresNotMapped.Name = "lvwStructuresNotMapped";
            this.lvwStructuresNotMapped.Size = new System.Drawing.Size(565, 186);
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
            this.grpStructures.Location = new System.Drawing.Point(21, 12);
            this.grpStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpStructures.Name = "grpStructures";
            this.grpStructures.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpStructures.Size = new System.Drawing.Size(593, 383);
            this.grpStructures.TabIndex = 0;
            this.grpStructures.TabStop = false;
            // 
            // chkApplyFilterStructures
            // 
            this.chkApplyFilterStructures.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkApplyFilterStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkApplyFilterStructures.Image = ((System.Drawing.Image)(resources.GetObject("chkApplyFilterStructures.Image")));
            this.chkApplyFilterStructures.Location = new System.Drawing.Point(496, 331);
            this.chkApplyFilterStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkApplyFilterStructures.Name = "chkApplyFilterStructures";
            this.chkApplyFilterStructures.Size = new System.Drawing.Size(41, 40);
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
            this.lblHeaderStructures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderStructures.Location = new System.Drawing.Point(-2, 7);
            this.lblHeaderStructures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderStructures.Name = "lblHeaderStructures";
            this.lblHeaderStructures.Size = new System.Drawing.Size(596, 7);
            this.lblHeaderStructures.TabIndex = 0;
            this.lblHeaderStructures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStructureFilter
            // 
            this.txtStructureFilter.Location = new System.Drawing.Point(107, 339);
            this.txtStructureFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStructureFilter.Name = "txtStructureFilter";
            this.txtStructureFilter.Size = new System.Drawing.Size(381, 23);
            this.txtStructureFilter.TabIndex = 4;
            // 
            // lvwStructureMap
            // 
            this.lvwStructureMap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvwStructureMap.FullRowSelect = true;
            this.lvwStructureMap.Location = new System.Drawing.Point(15, 22);
            this.lvwStructureMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwStructureMap.Name = "lvwStructureMap";
            this.lvwStructureMap.Size = new System.Drawing.Size(565, 302);
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
            this.btnEditStructure.Location = new System.Drawing.Point(542, 331);
            this.btnEditStructure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditStructure.Name = "btnEditStructure";
            this.btnEditStructure.Size = new System.Drawing.Size(41, 40);
            this.btnEditStructure.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnEditStructure, "Edit display name");
            this.btnEditStructure.UseVisualStyleBackColor = true;
            this.btnEditStructure.Click += new System.EventHandler(this.btnEditStructure_Click);
            // 
            // btnAddStructure
            // 
            this.btnAddStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStructure.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStructure.Image")));
            this.btnAddStructure.Location = new System.Drawing.Point(15, 331);
            this.btnAddStructure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddStructure.Name = "btnAddStructure";
            this.btnAddStructure.Size = new System.Drawing.Size(41, 40);
            this.btnAddStructure.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAddStructure, "Add new display name");
            this.btnAddStructure.UseVisualStyleBackColor = true;
            this.btnAddStructure.Click += new System.EventHandler(this.btnAddStructure_Click);
            // 
            // btnRemoveStructure
            // 
            this.btnRemoveStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveStructure.Enabled = false;
            this.btnRemoveStructure.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveStructure.Image")));
            this.btnRemoveStructure.Location = new System.Drawing.Point(61, 331);
            this.btnRemoveStructure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemoveStructure.Name = "btnRemoveStructure";
            this.btnRemoveStructure.Size = new System.Drawing.Size(41, 40);
            this.btnRemoveStructure.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnRemoveStructure, "Remove display name");
            this.btnRemoveStructure.UseVisualStyleBackColor = true;
            this.btnRemoveStructure.Click += new System.EventHandler(this.btnRemoveStructure_Click);
            // 
            // tpgItems
            // 
            this.tpgItems.Controls.Add(this.grpItemsNotMatched);
            this.tpgItems.Controls.Add(this.grpItems);
            this.tpgItems.Location = new System.Drawing.Point(4, 24);
            this.tpgItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgItems.Name = "tpgItems";
            this.tpgItems.Size = new System.Drawing.Size(637, 724);
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
            this.grpItemsNotMatched.Location = new System.Drawing.Point(21, 402);
            this.grpItemsNotMatched.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpItemsNotMatched.Name = "grpItemsNotMatched";
            this.grpItemsNotMatched.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpItemsNotMatched.Size = new System.Drawing.Size(593, 295);
            this.grpItemsNotMatched.TabIndex = 1;
            this.grpItemsNotMatched.TabStop = false;
            // 
            // btnRefreshUnknownItems
            // 
            this.btnRefreshUnknownItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshUnknownItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshUnknownItems.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshUnknownItems.Image")));
            this.btnRefreshUnknownItems.Location = new System.Drawing.Point(15, 245);
            this.btnRefreshUnknownItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefreshUnknownItems.Name = "btnRefreshUnknownItems";
            this.btnRefreshUnknownItems.Size = new System.Drawing.Size(41, 40);
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
            this.btnItemsNotMatchedAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnItemsNotMatchedAdd.Image")));
            this.btnItemsNotMatchedAdd.Location = new System.Drawing.Point(541, 245);
            this.btnItemsNotMatchedAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnItemsNotMatchedAdd.Name = "btnItemsNotMatchedAdd";
            this.btnItemsNotMatchedAdd.Size = new System.Drawing.Size(41, 40);
            this.btnItemsNotMatchedAdd.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnItemsNotMatchedAdd, "Add mapping");
            this.btnItemsNotMatchedAdd.UseVisualStyleBackColor = true;
            this.btnItemsNotMatchedAdd.Click += new System.EventHandler(this.btnItemsNotMatchedAdd_Click);
            // 
            // lblItemsNotMatched
            // 
            this.lblItemsNotMatched.BackColor = System.Drawing.Color.Transparent;
            this.lblItemsNotMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItemsNotMatched.Location = new System.Drawing.Point(12, 18);
            this.lblItemsNotMatched.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsNotMatched.Name = "lblItemsNotMatched";
            this.lblItemsNotMatched.Size = new System.Drawing.Size(231, 25);
            this.lblItemsNotMatched.TabIndex = 1;
            this.lblItemsNotMatched.Text = "Not Mapped";
            this.lblItemsNotMatched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderItemsNotMatched
            // 
            this.lblHeaderItemsNotMatched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderItemsNotMatched.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHeaderItemsNotMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderItemsNotMatched.Location = new System.Drawing.Point(-2, 7);
            this.lblHeaderItemsNotMatched.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderItemsNotMatched.Name = "lblHeaderItemsNotMatched";
            this.lblHeaderItemsNotMatched.Size = new System.Drawing.Size(596, 7);
            this.lblHeaderItemsNotMatched.TabIndex = 0;
            this.lblHeaderItemsNotMatched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwItemsNotMatched
            // 
            this.lvwItemsNotMatched.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11});
            this.lvwItemsNotMatched.FullRowSelect = true;
            this.lvwItemsNotMatched.Location = new System.Drawing.Point(15, 52);
            this.lvwItemsNotMatched.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwItemsNotMatched.Name = "lvwItemsNotMatched";
            this.lvwItemsNotMatched.Size = new System.Drawing.Size(565, 186);
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
            this.grpItems.Location = new System.Drawing.Point(21, 12);
            this.grpItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpItems.Name = "grpItems";
            this.grpItems.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpItems.Size = new System.Drawing.Size(593, 383);
            this.grpItems.TabIndex = 0;
            this.grpItems.TabStop = false;
            // 
            // chkApplyFilterItems
            // 
            this.chkApplyFilterItems.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkApplyFilterItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkApplyFilterItems.Image = ((System.Drawing.Image)(resources.GetObject("chkApplyFilterItems.Image")));
            this.chkApplyFilterItems.Location = new System.Drawing.Point(496, 331);
            this.chkApplyFilterItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkApplyFilterItems.Name = "chkApplyFilterItems";
            this.chkApplyFilterItems.Size = new System.Drawing.Size(41, 40);
            this.chkApplyFilterItems.TabIndex = 5;
            this.chkApplyFilterItems.UseVisualStyleBackColor = true;
            this.chkApplyFilterItems.CheckedChanged += new System.EventHandler(this.chkApplyFilterItems_CheckedChanged);
            // 
            // lblHeaderItems
            // 
            this.lblHeaderItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderItems.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderItems.Location = new System.Drawing.Point(-2, 7);
            this.lblHeaderItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderItems.Name = "lblHeaderItems";
            this.lblHeaderItems.Size = new System.Drawing.Size(596, 7);
            this.lblHeaderItems.TabIndex = 0;
            this.lblHeaderItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtItemFilter
            // 
            this.txtItemFilter.Location = new System.Drawing.Point(107, 339);
            this.txtItemFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtItemFilter.Name = "txtItemFilter";
            this.txtItemFilter.Size = new System.Drawing.Size(381, 23);
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
            this.lvwItemMap.Location = new System.Drawing.Point(15, 22);
            this.lvwItemMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwItemMap.Name = "lvwItemMap";
            this.lvwItemMap.Size = new System.Drawing.Size(565, 302);
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
            this.btnEditItem.Location = new System.Drawing.Point(542, 331);
            this.btnEditItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(41, 40);
            this.btnEditItem.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnEditItem, "Edit display name");
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.Location = new System.Drawing.Point(15, 331);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(41, 40);
            this.btnAddItem.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAddItem, "Add new display name");
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveItem.Image")));
            this.btnRemoveItem.Location = new System.Drawing.Point(61, 331);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(41, 40);
            this.btnRemoveItem.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnRemoveItem, "Remove display name");
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // tpgExport
            // 
            this.tpgExport.Controls.Add(this.grpJsonExport);
            this.tpgExport.Controls.Add(this.grpContentPack);
            this.tpgExport.Location = new System.Drawing.Point(4, 24);
            this.tpgExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgExport.Name = "tpgExport";
            this.tpgExport.Size = new System.Drawing.Size(637, 724);
            this.tpgExport.TabIndex = 6;
            this.tpgExport.Text = "Export";
            this.tpgExport.UseVisualStyleBackColor = true;
            // 
            // grpJsonExport
            // 
            this.grpJsonExport.Controls.Add(this.label7);
            this.grpJsonExport.Controls.Add(this.btnJsonExportMapStructures);
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
            this.grpJsonExport.Location = new System.Drawing.Point(26, 440);
            this.grpJsonExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpJsonExport.Name = "grpJsonExport";
            this.grpJsonExport.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpJsonExport.Size = new System.Drawing.Size(584, 248);
            this.grpJsonExport.TabIndex = 1;
            this.grpJsonExport.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(338, 207);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Map Structures";
            // 
            // btnJsonExportMapStructures
            // 
            this.btnJsonExportMapStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJsonExportMapStructures.Image = ((System.Drawing.Image)(resources.GetObject("btnJsonExportMapStructures.Image")));
            this.btnJsonExportMapStructures.Location = new System.Drawing.Point(494, 197);
            this.btnJsonExportMapStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnJsonExportMapStructures.Name = "btnJsonExportMapStructures";
            this.btnJsonExportMapStructures.Size = new System.Drawing.Size(41, 40);
            this.btnJsonExportMapStructures.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnJsonExportMapStructures, "Export tamed data");
            this.btnJsonExportMapStructures.UseVisualStyleBackColor = true;
            this.btnJsonExportMapStructures.Click += new System.EventHandler(this.btnJsonExportMapStructures_Click);
            // 
            // lblExportPlayerStructures
            // 
            this.lblExportPlayerStructures.AutoSize = true;
            this.lblExportPlayerStructures.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExportPlayerStructures.Location = new System.Drawing.Point(338, 157);
            this.lblExportPlayerStructures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExportPlayerStructures.Name = "lblExportPlayerStructures";
            this.lblExportPlayerStructures.Size = new System.Drawing.Size(104, 13);
            this.lblExportPlayerStructures.TabIndex = 12;
            this.lblExportPlayerStructures.Text = "Player Structures";
            // 
            // btnJsonExportPlayerStructures
            // 
            this.btnJsonExportPlayerStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJsonExportPlayerStructures.Image = ((System.Drawing.Image)(resources.GetObject("btnJsonExportPlayerStructures.Image")));
            this.btnJsonExportPlayerStructures.Location = new System.Drawing.Point(495, 147);
            this.btnJsonExportPlayerStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnJsonExportPlayerStructures.Name = "btnJsonExportPlayerStructures";
            this.btnJsonExportPlayerStructures.Size = new System.Drawing.Size(41, 40);
            this.btnJsonExportPlayerStructures.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnJsonExportPlayerStructures, "Export structure data");
            this.btnJsonExportPlayerStructures.UseVisualStyleBackColor = true;
            this.btnJsonExportPlayerStructures.Click += new System.EventHandler(this.btnJsonExportPlayerStructures_Click);
            // 
            // lblExportTamed
            // 
            this.lblExportTamed.AutoSize = true;
            this.lblExportTamed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExportTamed.Location = new System.Drawing.Point(22, 157);
            this.lblExportTamed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExportTamed.Name = "lblExportTamed";
            this.lblExportTamed.Size = new System.Drawing.Size(121, 13);
            this.lblExportTamed.TabIndex = 6;
            this.lblExportTamed.Text = "All Tamed Creatures";
            // 
            // btnJsonExportTamed
            // 
            this.btnJsonExportTamed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJsonExportTamed.Image = ((System.Drawing.Image)(resources.GetObject("btnJsonExportTamed.Image")));
            this.btnJsonExportTamed.Location = new System.Drawing.Point(178, 147);
            this.btnJsonExportTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnJsonExportTamed.Name = "btnJsonExportTamed";
            this.btnJsonExportTamed.Size = new System.Drawing.Size(41, 40);
            this.btnJsonExportTamed.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnJsonExportTamed, "Export tamed data");
            this.btnJsonExportTamed.UseVisualStyleBackColor = true;
            this.btnJsonExportTamed.Click += new System.EventHandler(this.btnJsonExportTamed_Click);
            // 
            // lblExportPlayers
            // 
            this.lblExportPlayers.AutoSize = true;
            this.lblExportPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExportPlayers.Location = new System.Drawing.Point(338, 105);
            this.lblExportPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExportPlayers.Name = "lblExportPlayers";
            this.lblExportPlayers.Size = new System.Drawing.Size(73, 13);
            this.lblExportPlayers.TabIndex = 10;
            this.lblExportPlayers.Text = "Player Data";
            // 
            // btnJsonExportPlayers
            // 
            this.btnJsonExportPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJsonExportPlayers.Image = ((System.Drawing.Image)(resources.GetObject("btnJsonExportPlayers.Image")));
            this.btnJsonExportPlayers.Location = new System.Drawing.Point(495, 97);
            this.btnJsonExportPlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnJsonExportPlayers.Name = "btnJsonExportPlayers";
            this.btnJsonExportPlayers.Size = new System.Drawing.Size(41, 40);
            this.btnJsonExportPlayers.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnJsonExportPlayers, "Export player data");
            this.btnJsonExportPlayers.UseVisualStyleBackColor = true;
            this.btnJsonExportPlayers.Click += new System.EventHandler(this.btnJsonExportPlayers_Click);
            // 
            // lblExportTribes
            // 
            this.lblExportTribes.AutoSize = true;
            this.lblExportTribes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExportTribes.Location = new System.Drawing.Point(338, 60);
            this.lblExportTribes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExportTribes.Name = "lblExportTribes";
            this.lblExportTribes.Size = new System.Drawing.Size(67, 13);
            this.lblExportTribes.TabIndex = 8;
            this.lblExportTribes.Text = "Tribe Data";
            // 
            // btnJsonExportTribes
            // 
            this.btnJsonExportTribes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJsonExportTribes.Image = ((System.Drawing.Image)(resources.GetObject("btnJsonExportTribes.Image")));
            this.btnJsonExportTribes.Location = new System.Drawing.Point(495, 51);
            this.btnJsonExportTribes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnJsonExportTribes.Name = "btnJsonExportTribes";
            this.btnJsonExportTribes.Size = new System.Drawing.Size(41, 40);
            this.btnJsonExportTribes.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnJsonExportTribes, "Export tribe data");
            this.btnJsonExportTribes.UseVisualStyleBackColor = true;
            this.btnJsonExportTribes.Click += new System.EventHandler(this.btnJsonExportTribes_Click);
            // 
            // lblExportWild
            // 
            this.lblExportWild.AutoSize = true;
            this.lblExportWild.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExportWild.Location = new System.Drawing.Point(22, 105);
            this.lblExportWild.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExportWild.Name = "lblExportWild";
            this.lblExportWild.Size = new System.Drawing.Size(108, 13);
            this.lblExportWild.TabIndex = 4;
            this.lblExportWild.Text = "All Wild Creatures";
            // 
            // btnJsonExportWild
            // 
            this.btnJsonExportWild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJsonExportWild.Image = ((System.Drawing.Image)(resources.GetObject("btnJsonExportWild.Image")));
            this.btnJsonExportWild.Location = new System.Drawing.Point(178, 97);
            this.btnJsonExportWild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnJsonExportWild.Name = "btnJsonExportWild";
            this.btnJsonExportWild.Size = new System.Drawing.Size(41, 40);
            this.btnJsonExportWild.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnJsonExportWild, "Export wild data");
            this.btnJsonExportWild.UseVisualStyleBackColor = true;
            this.btnJsonExportWild.Click += new System.EventHandler(this.btnJsonExportWild_Click);
            // 
            // lblExportAll
            // 
            this.lblExportAll.AutoSize = true;
            this.lblExportAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExportAll.Location = new System.Drawing.Point(22, 60);
            this.lblExportAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExportAll.Name = "lblExportAll";
            this.lblExportAll.Size = new System.Drawing.Size(77, 13);
            this.lblExportAll.TabIndex = 2;
            this.lblExportAll.Text = "All Available";
            // 
            // btnJsonExportAll
            // 
            this.btnJsonExportAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJsonExportAll.Image = ((System.Drawing.Image)(resources.GetObject("btnJsonExportAll.Image")));
            this.btnJsonExportAll.Location = new System.Drawing.Point(178, 51);
            this.btnJsonExportAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnJsonExportAll.Name = "btnJsonExportAll";
            this.btnJsonExportAll.Size = new System.Drawing.Size(41, 40);
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
            this.lblHeaderJsonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderJsonExport.Location = new System.Drawing.Point(0, 7);
            this.lblHeaderJsonExport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderJsonExport.Name = "lblHeaderJsonExport";
            this.lblHeaderJsonExport.Size = new System.Drawing.Size(587, 7);
            this.lblHeaderJsonExport.TabIndex = 0;
            this.lblHeaderJsonExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJsonFileExport
            // 
            this.lblJsonFileExport.BackColor = System.Drawing.Color.Transparent;
            this.lblJsonFileExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJsonFileExport.Location = new System.Drawing.Point(9, 16);
            this.lblJsonFileExport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJsonFileExport.Name = "lblJsonFileExport";
            this.lblJsonFileExport.Size = new System.Drawing.Size(231, 25);
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
            this.grpContentPack.Location = new System.Drawing.Point(26, 13);
            this.grpContentPack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpContentPack.Name = "grpContentPack";
            this.grpContentPack.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpContentPack.Size = new System.Drawing.Size(584, 420);
            this.grpContentPack.TabIndex = 0;
            this.grpContentPack.TabStop = false;
            // 
            // chkDroppedItems
            // 
            this.chkDroppedItems.AutoSize = true;
            this.chkDroppedItems.Location = new System.Drawing.Point(33, 111);
            this.chkDroppedItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDroppedItems.Name = "chkDroppedItems";
            this.chkDroppedItems.Size = new System.Drawing.Size(104, 19);
            this.chkDroppedItems.TabIndex = 4;
            this.chkDroppedItems.Text = "Dropped Items";
            this.chkDroppedItems.UseVisualStyleBackColor = true;
            // 
            // chkStructureContents
            // 
            this.chkStructureContents.AutoSize = true;
            this.chkStructureContents.Location = new System.Drawing.Point(33, 84);
            this.chkStructureContents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkStructureContents.Name = "chkStructureContents";
            this.chkStructureContents.Size = new System.Drawing.Size(152, 19);
            this.chkStructureContents.TabIndex = 3;
            this.chkStructureContents.Text = "Map Structure Contents";
            this.chkStructureContents.UseVisualStyleBackColor = true;
            // 
            // chkStructureLocations
            // 
            this.chkStructureLocations.AutoSize = true;
            this.chkStructureLocations.Checked = true;
            this.chkStructureLocations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStructureLocations.Location = new System.Drawing.Point(33, 58);
            this.chkStructureLocations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkStructureLocations.Name = "chkStructureLocations";
            this.chkStructureLocations.Size = new System.Drawing.Size(155, 19);
            this.chkStructureLocations.TabIndex = 2;
            this.chkStructureLocations.Text = "Map Structure Locations";
            this.chkStructureLocations.UseVisualStyleBackColor = true;
            // 
            // btnExportContentPack
            // 
            this.btnExportContentPack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportContentPack.Image = ((System.Drawing.Image)(resources.GetObject("btnExportContentPack.Image")));
            this.btnExportContentPack.Location = new System.Drawing.Point(495, 361);
            this.btnExportContentPack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportContentPack.Name = "btnExportContentPack";
            this.btnExportContentPack.Size = new System.Drawing.Size(41, 40);
            this.btnExportContentPack.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnExportContentPack, "Export content pack");
            this.btnExportContentPack.UseVisualStyleBackColor = true;
            this.btnExportContentPack.Click += new System.EventHandler(this.btnExportContentPack_Click);
            // 
            // udExportRadius
            // 
            this.udExportRadius.DecimalPlaces = 2;
            this.udExportRadius.Location = new System.Drawing.Point(144, 372);
            this.udExportRadius.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udExportRadius.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.udExportRadius.Name = "udExportRadius";
            this.udExportRadius.Size = new System.Drawing.Size(75, 23);
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
            this.udExportLon.Location = new System.Drawing.Point(144, 332);
            this.udExportLon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udExportLon.Name = "udExportLon";
            this.udExportLon.Size = new System.Drawing.Size(75, 23);
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
            this.udExportLat.Location = new System.Drawing.Point(144, 294);
            this.udExportLat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udExportLat.Name = "udExportLat";
            this.udExportLat.Size = new System.Drawing.Size(75, 23);
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
            this.lblFilterRad.Location = new System.Drawing.Point(29, 372);
            this.lblFilterRad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterRad.Name = "lblFilterRad";
            this.lblFilterRad.Size = new System.Drawing.Size(45, 15);
            this.lblFilterRad.TabIndex = 18;
            this.lblFilterRad.Text = "Radius:";
            // 
            // cboExportPlayer
            // 
            this.cboExportPlayer.FormattingEnabled = true;
            this.cboExportPlayer.Location = new System.Drawing.Point(144, 253);
            this.cboExportPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboExportPlayer.Name = "cboExportPlayer";
            this.cboExportPlayer.Size = new System.Drawing.Size(390, 23);
            this.cboExportPlayer.TabIndex = 13;
            // 
            // cboExportTribe
            // 
            this.cboExportTribe.FormattingEnabled = true;
            this.cboExportTribe.Location = new System.Drawing.Point(144, 216);
            this.cboExportTribe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboExportTribe.Name = "cboExportTribe";
            this.cboExportTribe.Size = new System.Drawing.Size(390, 23);
            this.cboExportTribe.TabIndex = 11;
            this.cboExportTribe.SelectedIndexChanged += new System.EventHandler(this.cboExportTribe_SelectedIndexChanged);
            // 
            // lblFilterLon
            // 
            this.lblFilterLon.AutoSize = true;
            this.lblFilterLon.Location = new System.Drawing.Point(29, 332);
            this.lblFilterLon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterLon.Name = "lblFilterLon";
            this.lblFilterLon.Size = new System.Drawing.Size(64, 15);
            this.lblFilterLon.TabIndex = 16;
            this.lblFilterLon.Text = "Longitude:";
            // 
            // lblFilterLat
            // 
            this.lblFilterLat.AutoSize = true;
            this.lblFilterLat.Location = new System.Drawing.Point(29, 294);
            this.lblFilterLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterLat.Name = "lblFilterLat";
            this.lblFilterLat.Size = new System.Drawing.Size(53, 15);
            this.lblFilterLat.TabIndex = 14;
            this.lblFilterLat.Text = "Latitude:";
            // 
            // lblFilterPlayer
            // 
            this.lblFilterPlayer.AutoSize = true;
            this.lblFilterPlayer.Location = new System.Drawing.Point(29, 256);
            this.lblFilterPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterPlayer.Name = "lblFilterPlayer";
            this.lblFilterPlayer.Size = new System.Drawing.Size(89, 15);
            this.lblFilterPlayer.TabIndex = 12;
            this.lblFilterPlayer.Text = "Selected Player:";
            // 
            // lblFilterTribe
            // 
            this.lblFilterTribe.AutoSize = true;
            this.lblFilterTribe.Location = new System.Drawing.Point(29, 216);
            this.lblFilterTribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterTribe.Name = "lblFilterTribe";
            this.lblFilterTribe.Size = new System.Drawing.Size(82, 15);
            this.lblFilterTribe.TabIndex = 10;
            this.lblFilterTribe.Text = "Selected Tribe:";
            // 
            // lblContentPackFilters
            // 
            this.lblContentPackFilters.BackColor = System.Drawing.Color.Transparent;
            this.lblContentPackFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContentPackFilters.Location = new System.Drawing.Point(9, 180);
            this.lblContentPackFilters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContentPackFilters.Name = "lblContentPackFilters";
            this.lblContentPackFilters.Size = new System.Drawing.Size(231, 25);
            this.lblContentPackFilters.TabIndex = 9;
            this.lblContentPackFilters.Text = "Content Pack Filters";
            this.lblContentPackFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkPlayerStructures
            // 
            this.chkPlayerStructures.AutoSize = true;
            this.chkPlayerStructures.Checked = true;
            this.chkPlayerStructures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlayerStructures.Location = new System.Drawing.Point(348, 111);
            this.chkPlayerStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkPlayerStructures.Name = "chkPlayerStructures";
            this.chkPlayerStructures.Size = new System.Drawing.Size(114, 19);
            this.chkPlayerStructures.TabIndex = 8;
            this.chkPlayerStructures.Text = "Player Structures";
            this.chkPlayerStructures.UseVisualStyleBackColor = true;
            // 
            // chkTamedCreatures
            // 
            this.chkTamedCreatures.AutoSize = true;
            this.chkTamedCreatures.Checked = true;
            this.chkTamedCreatures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTamedCreatures.Location = new System.Drawing.Point(348, 58);
            this.chkTamedCreatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkTamedCreatures.Name = "chkTamedCreatures";
            this.chkTamedCreatures.Size = new System.Drawing.Size(114, 19);
            this.chkTamedCreatures.TabIndex = 6;
            this.chkTamedCreatures.Text = "Tamed Creatures";
            this.chkTamedCreatures.UseVisualStyleBackColor = true;
            // 
            // chkWildCreatures
            // 
            this.chkWildCreatures.AutoSize = true;
            this.chkWildCreatures.Location = new System.Drawing.Point(348, 84);
            this.chkWildCreatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkWildCreatures.Name = "chkWildCreatures";
            this.chkWildCreatures.Size = new System.Drawing.Size(103, 19);
            this.chkWildCreatures.TabIndex = 7;
            this.chkWildCreatures.Text = "Wild Creatures";
            this.chkWildCreatures.UseVisualStyleBackColor = true;
            // 
            // lblHeaderConteentPack
            // 
            this.lblHeaderConteentPack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderConteentPack.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderConteentPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderConteentPack.Location = new System.Drawing.Point(0, 7);
            this.lblHeaderConteentPack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderConteentPack.Name = "lblHeaderConteentPack";
            this.lblHeaderConteentPack.Size = new System.Drawing.Size(587, 7);
            this.lblHeaderConteentPack.TabIndex = 0;
            this.lblHeaderConteentPack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContentPackOptions
            // 
            this.lblContentPackOptions.BackColor = System.Drawing.Color.Transparent;
            this.lblContentPackOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContentPackOptions.Location = new System.Drawing.Point(9, 16);
            this.lblContentPackOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContentPackOptions.Name = "lblContentPackOptions";
            this.lblContentPackOptions.Size = new System.Drawing.Size(231, 25);
            this.lblContentPackOptions.TabIndex = 1;
            this.lblContentPackOptions.Text = "Content Pack Export Options";
            this.lblContentPackOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpgRestService
            // 
            this.tpgRestService.Controls.Add(this.grpService);
            this.tpgRestService.Controls.Add(this.grpClientAccess);
            this.tpgRestService.Location = new System.Drawing.Point(4, 24);
            this.tpgRestService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgRestService.Name = "tpgRestService";
            this.tpgRestService.Size = new System.Drawing.Size(637, 724);
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
            this.grpService.Location = new System.Drawing.Point(30, 18);
            this.grpService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpService.Name = "grpService";
            this.grpService.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpService.Size = new System.Drawing.Size(579, 327);
            this.grpService.TabIndex = 0;
            this.grpService.TabStop = false;
            // 
            // chkAutostartService
            // 
            this.chkAutostartService.AutoSize = true;
            this.chkAutostartService.Location = new System.Drawing.Point(429, 77);
            this.chkAutostartService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkAutostartService.Name = "chkAutostartService";
            this.chkAutostartService.Size = new System.Drawing.Size(129, 19);
            this.chkAutostartService.TabIndex = 7;
            this.chkAutostartService.Text = "Auto Start with ASV";
            this.chkAutostartService.UseVisualStyleBackColor = true;
            // 
            // udServicePort
            // 
            this.udServicePort.Location = new System.Drawing.Point(251, 74);
            this.udServicePort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udServicePort.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.udServicePort.Name = "udServicePort";
            this.udServicePort.Size = new System.Drawing.Size(70, 23);
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
            this.lblServiceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServiceStatus.Location = new System.Drawing.Point(12, 45);
            this.lblServiceStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(84, 15);
            this.lblServiceStatus.TabIndex = 1;
            this.lblServiceStatus.Text = "Service Status";
            this.lblServiceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtServiceStatus
            // 
            this.txtServiceStatus.Location = new System.Drawing.Point(15, 74);
            this.txtServiceStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtServiceStatus.Name = "txtServiceStatus";
            this.txtServiceStatus.ReadOnly = true;
            this.txtServiceStatus.Size = new System.Drawing.Size(227, 23);
            this.txtServiceStatus.TabIndex = 2;
            this.txtServiceStatus.Text = "No Map Loaded";
            // 
            // btnClearServiceLog
            // 
            this.btnClearServiceLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearServiceLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearServiceLog.Enabled = false;
            this.btnClearServiceLog.Image = ((System.Drawing.Image)(resources.GetObject("btnClearServiceLog.Image")));
            this.btnClearServiceLog.Location = new System.Drawing.Point(525, 275);
            this.btnClearServiceLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearServiceLog.Name = "btnClearServiceLog";
            this.btnClearServiceLog.Size = new System.Drawing.Size(41, 40);
            this.btnClearServiceLog.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnClearServiceLog, "Clear activity log");
            this.btnClearServiceLog.UseVisualStyleBackColor = true;
            // 
            // txtServiceLog
            // 
            this.txtServiceLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServiceLog.Location = new System.Drawing.Point(15, 141);
            this.txtServiceLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtServiceLog.Multiline = true;
            this.txtServiceLog.Name = "txtServiceLog";
            this.txtServiceLog.ReadOnly = true;
            this.txtServiceLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtServiceLog.Size = new System.Drawing.Size(550, 125);
            this.txtServiceLog.TabIndex = 9;
            // 
            // lblServiceActivity
            // 
            this.lblServiceActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblServiceActivity.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServiceActivity.Location = new System.Drawing.Point(12, 110);
            this.lblServiceActivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceActivity.Name = "lblServiceActivity";
            this.lblServiceActivity.Size = new System.Drawing.Size(231, 25);
            this.lblServiceActivity.TabIndex = 8;
            this.lblServiceActivity.Text = "Service Activity";
            this.lblServiceActivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStopService
            // 
            this.btnStopService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopService.Enabled = false;
            this.btnStopService.Image = ((System.Drawing.Image)(resources.GetObject("btnStopService.Image")));
            this.btnStopService.Location = new System.Drawing.Point(331, 65);
            this.btnStopService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(41, 40);
            this.btnStopService.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnStopService, "Edit display name");
            this.btnStopService.UseVisualStyleBackColor = true;
            // 
            // btnStartService
            // 
            this.btnStartService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartService.Enabled = false;
            this.btnStartService.Image = ((System.Drawing.Image)(resources.GetObject("btnStartService.Image")));
            this.btnStartService.Location = new System.Drawing.Point(379, 65);
            this.btnStartService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(41, 40);
            this.btnStartService.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnStartService, "Edit display name");
            this.btnStartService.UseVisualStyleBackColor = true;
            // 
            // lblService
            // 
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblService.Location = new System.Drawing.Point(12, 18);
            this.lblService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(231, 25);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Service";
            this.lblService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderService
            // 
            this.lblHeaderService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderService.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHeaderService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderService.Location = new System.Drawing.Point(-2, 7);
            this.lblHeaderService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderService.Name = "lblHeaderService";
            this.lblHeaderService.Size = new System.Drawing.Size(582, 7);
            this.lblHeaderService.TabIndex = 0;
            this.lblHeaderService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServicePort
            // 
            this.lblServicePort.AutoSize = true;
            this.lblServicePort.BackColor = System.Drawing.Color.Transparent;
            this.lblServicePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServicePort.Location = new System.Drawing.Point(243, 45);
            this.lblServicePort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.grpClientAccess.Location = new System.Drawing.Point(29, 352);
            this.grpClientAccess.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpClientAccess.Name = "grpClientAccess";
            this.grpClientAccess.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpClientAccess.Size = new System.Drawing.Size(579, 346);
            this.grpClientAccess.TabIndex = 1;
            this.grpClientAccess.TabStop = false;
            // 
            // lblClientAccess
            // 
            this.lblClientAccess.BackColor = System.Drawing.Color.Transparent;
            this.lblClientAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClientAccess.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblClientAccess.Location = new System.Drawing.Point(12, 18);
            this.lblClientAccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientAccess.Name = "lblClientAccess";
            this.lblClientAccess.Size = new System.Drawing.Size(231, 25);
            this.lblClientAccess.TabIndex = 1;
            this.lblClientAccess.Text = "Client Access";
            this.lblClientAccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkFilterClient
            // 
            this.chkFilterClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFilterClient.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFilterClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkFilterClient.Image = ((System.Drawing.Image)(resources.GetObject("chkFilterClient.Image")));
            this.chkFilterClient.Location = new System.Drawing.Point(481, 287);
            this.chkFilterClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkFilterClient.Name = "chkFilterClient";
            this.chkFilterClient.Size = new System.Drawing.Size(41, 40);
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
            this.lblHeaderClientAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderClientAccess.Location = new System.Drawing.Point(-2, 7);
            this.lblHeaderClientAccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderClientAccess.Name = "lblHeaderClientAccess";
            this.lblHeaderClientAccess.Size = new System.Drawing.Size(582, 7);
            this.lblHeaderClientAccess.TabIndex = 0;
            this.lblHeaderClientAccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFilterClient
            // 
            this.txtFilterClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterClient.Location = new System.Drawing.Point(107, 298);
            this.txtFilterClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilterClient.Name = "txtFilterClient";
            this.txtFilterClient.Size = new System.Drawing.Size(367, 23);
            this.txtFilterClient.TabIndex = 5;
            // 
            // btnEditClient
            // 
            this.btnEditClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditClient.Enabled = false;
            this.btnEditClient.Image = ((System.Drawing.Image)(resources.GetObject("btnEditClient.Image")));
            this.btnEditClient.Location = new System.Drawing.Point(528, 287);
            this.btnEditClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(41, 40);
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
            this.lvwClientAccess.Location = new System.Drawing.Point(15, 52);
            this.lvwClientAccess.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwClientAccess.Name = "lvwClientAccess";
            this.lvwClientAccess.Size = new System.Drawing.Size(551, 227);
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
            this.btnRemoveClient.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveClient.Image")));
            this.btnRemoveClient.Location = new System.Drawing.Point(61, 288);
            this.btnRemoveClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(41, 40);
            this.btnRemoveClient.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnRemoveClient, "Remove client access");
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            this.btnRemoveClient.Click += new System.EventHandler(this.btnRemoveClient_Click);
            // 
            // btnNewClient
            // 
            this.btnNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewClient.Image = ((System.Drawing.Image)(resources.GetObject("btnNewClient.Image")));
            this.btnNewClient.Location = new System.Drawing.Point(15, 288);
            this.btnNewClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(41, 40);
            this.btnNewClient.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnNewClient, "Add new client");
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // tpgOptions
            // 
            this.tpgOptions.Controls.Add(this.groupBox1);
            this.tpgOptions.Location = new System.Drawing.Point(4, 24);
            this.tpgOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgOptions.Name = "tpgOptions";
            this.tpgOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgOptions.Size = new System.Drawing.Size(637, 724);
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
            this.groupBox1.Location = new System.Drawing.Point(19, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(597, 669);
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
            this.pnlCommandExportOptions.Location = new System.Drawing.Point(7, 432);
            this.pnlCommandExportOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCommandExportOptions.Name = "pnlCommandExportOptions";
            this.pnlCommandExportOptions.Size = new System.Drawing.Size(580, 68);
            this.pnlCommandExportOptions.TabIndex = 0;
            // 
            // optExportNoSort
            // 
            this.optExportNoSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optExportNoSort.AutoSize = true;
            this.optExportNoSort.Checked = true;
            this.optExportNoSort.Location = new System.Drawing.Point(400, 37);
            this.optExportNoSort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optExportNoSort.Name = "optExportNoSort";
            this.optExportNoSort.Size = new System.Drawing.Size(41, 19);
            this.optExportNoSort.TabIndex = 2;
            this.optExportNoSort.TabStop = true;
            this.optExportNoSort.Text = "No";
            this.optExportNoSort.UseVisualStyleBackColor = true;
            // 
            // optExportSort
            // 
            this.optExportSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optExportSort.AutoSize = true;
            this.optExportSort.Location = new System.Drawing.Point(512, 37);
            this.optExportSort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optExportSort.Name = "optExportSort";
            this.optExportSort.Size = new System.Drawing.Size(42, 19);
            this.optExportSort.TabIndex = 3;
            this.optExportSort.Text = "Yes";
            this.optExportSort.UseVisualStyleBackColor = true;
            // 
            // lblCommandExportOptionTitle
            // 
            this.lblCommandExportOptionTitle.AutoSize = true;
            this.lblCommandExportOptionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCommandExportOptionTitle.Location = new System.Drawing.Point(12, 10);
            this.lblCommandExportOptionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommandExportOptionTitle.Name = "lblCommandExportOptionTitle";
            this.lblCommandExportOptionTitle.Size = new System.Drawing.Size(175, 18);
            this.lblCommandExportOptionTitle.TabIndex = 0;
            this.lblCommandExportOptionTitle.Text = "Command Line Export";
            // 
            // lblCommandExportDescription
            // 
            this.lblCommandExportDescription.AutoSize = true;
            this.lblCommandExportDescription.Location = new System.Drawing.Point(12, 39);
            this.lblCommandExportDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommandExportDescription.Name = "lblCommandExportDescription";
            this.lblCommandExportDescription.Size = new System.Drawing.Size(193, 15);
            this.lblCommandExportDescription.TabIndex = 1;
            this.lblCommandExportDescription.Text = "Sort creature exports by class name";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Aqua;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(-2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(601, 7);
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
            this.pnlFtpSettingsCommands.Location = new System.Drawing.Point(6, 312);
            this.pnlFtpSettingsCommands.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFtpSettingsCommands.Name = "pnlFtpSettingsCommands";
            this.pnlFtpSettingsCommands.Size = new System.Drawing.Size(580, 113);
            this.pnlFtpSettingsCommands.TabIndex = 5;
            // 
            // pnlDownloadOption
            // 
            this.pnlDownloadOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDownloadOption.Controls.Add(this.optDownloadAuto);
            this.pnlDownloadOption.Controls.Add(this.optDownloadManual);
            this.pnlDownloadOption.Location = new System.Drawing.Point(374, 63);
            this.pnlDownloadOption.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlDownloadOption.Name = "pnlDownloadOption";
            this.pnlDownloadOption.Size = new System.Drawing.Size(202, 38);
            this.pnlDownloadOption.TabIndex = 5;
            // 
            // optDownloadAuto
            // 
            this.optDownloadAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optDownloadAuto.AutoSize = true;
            this.optDownloadAuto.Checked = true;
            this.optDownloadAuto.Location = new System.Drawing.Point(66, 9);
            this.optDownloadAuto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optDownloadAuto.Name = "optDownloadAuto";
            this.optDownloadAuto.Size = new System.Drawing.Size(51, 19);
            this.optDownloadAuto.TabIndex = 4;
            this.optDownloadAuto.TabStop = true;
            this.optDownloadAuto.Text = "Auto";
            this.optDownloadAuto.UseVisualStyleBackColor = true;
            // 
            // optDownloadManual
            // 
            this.optDownloadManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optDownloadManual.AutoSize = true;
            this.optDownloadManual.Location = new System.Drawing.Point(125, 9);
            this.optDownloadManual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optDownloadManual.Name = "optDownloadManual";
            this.optDownloadManual.Size = new System.Drawing.Size(65, 19);
            this.optDownloadManual.TabIndex = 5;
            this.optDownloadManual.Text = "Manual";
            this.optDownloadManual.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Download before loading map?";
            // 
            // optFTPSync
            // 
            this.optFTPSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optFTPSync.AutoSize = true;
            this.optFTPSync.Checked = true;
            this.optFTPSync.Location = new System.Drawing.Point(403, 38);
            this.optFTPSync.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optFTPSync.Name = "optFTPSync";
            this.optFTPSync.Size = new System.Drawing.Size(89, 19);
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
            this.optFTPClean.Location = new System.Drawing.Point(509, 38);
            this.optFTPClean.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optFTPClean.Name = "optFTPClean";
            this.optFTPClean.Size = new System.Drawing.Size(55, 19);
            this.optFTPClean.TabIndex = 3;
            this.optFTPClean.Text = "Clean";
            this.optFTPClean.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "FTP Downloads";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 15);
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
            this.pnlPlayerSettingsStuctures.Location = new System.Drawing.Point(7, 27);
            this.pnlPlayerSettingsStuctures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPlayerSettingsStuctures.Name = "pnlPlayerSettingsStuctures";
            this.pnlPlayerSettingsStuctures.Size = new System.Drawing.Size(580, 58);
            this.pnlPlayerSettingsStuctures.TabIndex = 0;
            // 
            // optPlayerStructureHide
            // 
            this.optPlayerStructureHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optPlayerStructureHide.AutoSize = true;
            this.optPlayerStructureHide.Checked = true;
            this.optPlayerStructureHide.Location = new System.Drawing.Point(441, 29);
            this.optPlayerStructureHide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optPlayerStructureHide.Name = "optPlayerStructureHide";
            this.optPlayerStructureHide.Size = new System.Drawing.Size(50, 19);
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
            this.optPlayerStructureShow.Location = new System.Drawing.Point(511, 29);
            this.optPlayerStructureShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optPlayerStructureShow.Name = "optPlayerStructureShow";
            this.optPlayerStructureShow.Size = new System.Drawing.Size(54, 19);
            this.optPlayerStructureShow.TabIndex = 3;
            this.optPlayerStructureShow.Text = "Show";
            this.optPlayerStructureShow.UseVisualStyleBackColor = true;
            this.optPlayerStructureShow.CheckedChanged += new System.EventHandler(this.optPlayerStructureShow_CheckedChanged);
            // 
            // lblOptionHeaderStructures
            // 
            this.lblOptionHeaderStructures.AutoSize = true;
            this.lblOptionHeaderStructures.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOptionHeaderStructures.Location = new System.Drawing.Point(12, 6);
            this.lblOptionHeaderStructures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOptionHeaderStructures.Name = "lblOptionHeaderStructures";
            this.lblOptionHeaderStructures.Size = new System.Drawing.Size(86, 18);
            this.lblOptionHeaderStructures.TabIndex = 0;
            this.lblOptionHeaderStructures.Text = "Structures";
            // 
            // lblOptionTextStructures
            // 
            this.lblOptionTextStructures.AutoSize = true;
            this.lblOptionTextStructures.Location = new System.Drawing.Point(12, 31);
            this.lblOptionTextStructures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOptionTextStructures.Name = "lblOptionTextStructures";
            this.lblOptionTextStructures.Size = new System.Drawing.Size(288, 15);
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
            this.pnlPlayerSettingsCommands.Location = new System.Drawing.Point(6, 234);
            this.pnlPlayerSettingsCommands.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPlayerSettingsCommands.Name = "pnlPlayerSettingsCommands";
            this.pnlPlayerSettingsCommands.Size = new System.Drawing.Size(580, 70);
            this.pnlPlayerSettingsCommands.TabIndex = 4;
            // 
            // optPlayerCommandsPrefixAdmincheat
            // 
            this.optPlayerCommandsPrefixAdmincheat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optPlayerCommandsPrefixAdmincheat.AutoSize = true;
            this.optPlayerCommandsPrefixAdmincheat.Location = new System.Drawing.Point(407, 35);
            this.optPlayerCommandsPrefixAdmincheat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optPlayerCommandsPrefixAdmincheat.Name = "optPlayerCommandsPrefixAdmincheat";
            this.optPlayerCommandsPrefixAdmincheat.Size = new System.Drawing.Size(91, 19);
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
            this.optPlayerCommandsPrefixNone.Location = new System.Drawing.Point(314, 35);
            this.optPlayerCommandsPrefixNone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optPlayerCommandsPrefixNone.Name = "optPlayerCommandsPrefixNone";
            this.optPlayerCommandsPrefixNone.Size = new System.Drawing.Size(62, 19);
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
            this.optPlayerCommandsPrefixCheat.Location = new System.Drawing.Point(511, 35);
            this.optPlayerCommandsPrefixCheat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optPlayerCommandsPrefixCheat.Name = "optPlayerCommandsPrefixCheat";
            this.optPlayerCommandsPrefixCheat.Size = new System.Drawing.Size(57, 19);
            this.optPlayerCommandsPrefixCheat.TabIndex = 4;
            this.optPlayerCommandsPrefixCheat.Text = "cheat ";
            this.optPlayerCommandsPrefixCheat.UseVisualStyleBackColor = true;
            this.optPlayerCommandsPrefixCheat.CheckedChanged += new System.EventHandler(this.optPlayerCommandsPrefixCheat_CheckedChanged);
            // 
            // lblOptionHeaderCommand
            // 
            this.lblOptionHeaderCommand.AutoSize = true;
            this.lblOptionHeaderCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOptionHeaderCommand.Location = new System.Drawing.Point(12, 9);
            this.lblOptionHeaderCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOptionHeaderCommand.Name = "lblOptionHeaderCommand";
            this.lblOptionHeaderCommand.Size = new System.Drawing.Size(133, 18);
            this.lblOptionHeaderCommand.TabIndex = 0;
            this.lblOptionHeaderCommand.Text = "Command Prefix";
            // 
            // lblOptionTextCommand
            // 
            this.lblOptionTextCommand.AutoSize = true;
            this.lblOptionTextCommand.Location = new System.Drawing.Point(12, 37);
            this.lblOptionTextCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOptionTextCommand.Name = "lblOptionTextCommand";
            this.lblOptionTextCommand.Size = new System.Drawing.Size(171, 15);
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
            this.pnlPlayerSettingsTames.Location = new System.Drawing.Point(7, 91);
            this.pnlPlayerSettingsTames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPlayerSettingsTames.Name = "pnlPlayerSettingsTames";
            this.pnlPlayerSettingsTames.Size = new System.Drawing.Size(580, 63);
            this.pnlPlayerSettingsTames.TabIndex = 2;
            // 
            // optPlayerTameHide
            // 
            this.optPlayerTameHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optPlayerTameHide.AutoSize = true;
            this.optPlayerTameHide.Checked = true;
            this.optPlayerTameHide.Location = new System.Drawing.Point(441, 32);
            this.optPlayerTameHide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optPlayerTameHide.Name = "optPlayerTameHide";
            this.optPlayerTameHide.Size = new System.Drawing.Size(50, 19);
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
            this.optPlayerTameShow.Location = new System.Drawing.Point(511, 32);
            this.optPlayerTameShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optPlayerTameShow.Name = "optPlayerTameShow";
            this.optPlayerTameShow.Size = new System.Drawing.Size(54, 19);
            this.optPlayerTameShow.TabIndex = 3;
            this.optPlayerTameShow.Text = "Show";
            this.optPlayerTameShow.UseVisualStyleBackColor = true;
            this.optPlayerTameShow.CheckedChanged += new System.EventHandler(this.optPlayerTameShow_CheckedChanged);
            // 
            // lblOptionHeaderTames
            // 
            this.lblOptionHeaderTames.AutoSize = true;
            this.lblOptionHeaderTames.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOptionHeaderTames.Location = new System.Drawing.Point(12, 8);
            this.lblOptionHeaderTames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOptionHeaderTames.Name = "lblOptionHeaderTames";
            this.lblOptionHeaderTames.Size = new System.Drawing.Size(59, 18);
            this.lblOptionHeaderTames.TabIndex = 0;
            this.lblOptionHeaderTames.Text = "Tames";
            // 
            // lblOptionTextTames
            // 
            this.lblOptionTextTames.AutoSize = true;
            this.lblOptionTextTames.Location = new System.Drawing.Point(12, 35);
            this.lblOptionTextTames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOptionTextTames.Name = "lblOptionTextTames";
            this.lblOptionTextTames.Size = new System.Drawing.Size(275, 15);
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
            this.pnlPlayerSettingsBody.Location = new System.Drawing.Point(7, 162);
            this.pnlPlayerSettingsBody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPlayerSettingsBody.Name = "pnlPlayerSettingsBody";
            this.pnlPlayerSettingsBody.Size = new System.Drawing.Size(580, 66);
            this.pnlPlayerSettingsBody.TabIndex = 3;
            // 
            // optPlayerBodyHide
            // 
            this.optPlayerBodyHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optPlayerBodyHide.AutoSize = true;
            this.optPlayerBodyHide.Checked = true;
            this.optPlayerBodyHide.Location = new System.Drawing.Point(441, 35);
            this.optPlayerBodyHide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optPlayerBodyHide.Name = "optPlayerBodyHide";
            this.optPlayerBodyHide.Size = new System.Drawing.Size(50, 19);
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
            this.optPlayerBodyShow.Location = new System.Drawing.Point(511, 35);
            this.optPlayerBodyShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optPlayerBodyShow.Name = "optPlayerBodyShow";
            this.optPlayerBodyShow.Size = new System.Drawing.Size(54, 19);
            this.optPlayerBodyShow.TabIndex = 3;
            this.optPlayerBodyShow.Text = "Show";
            this.optPlayerBodyShow.UseVisualStyleBackColor = true;
            this.optPlayerBodyShow.CheckedChanged += new System.EventHandler(this.optPlayerBodyShow_CheckedChanged);
            // 
            // lblOptionHeaderBody
            // 
            this.lblOptionHeaderBody.AutoSize = true;
            this.lblOptionHeaderBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOptionHeaderBody.Location = new System.Drawing.Point(12, 9);
            this.lblOptionHeaderBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOptionHeaderBody.Name = "lblOptionHeaderBody";
            this.lblOptionHeaderBody.Size = new System.Drawing.Size(46, 18);
            this.lblOptionHeaderBody.TabIndex = 0;
            this.lblOptionHeaderBody.Text = "Body";
            // 
            // lblOptionTextBody
            // 
            this.lblOptionTextBody.AutoSize = true;
            this.lblOptionTextBody.Location = new System.Drawing.Point(12, 37);
            this.lblOptionTextBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOptionTextBody.Name = "lblOptionTextBody";
            this.lblOptionTextBody.Size = new System.Drawing.Size(317, 15);
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
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(676, 812);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.pnlDownloadOption.ResumeLayout(false);
            this.pnlDownloadOption.PerformLayout();
            this.pnlPlayerSettingsStuctures.ResumeLayout(false);
            this.pnlPlayerSettingsStuctures.PerformLayout();
            this.pnlPlayerSettingsCommands.ResumeLayout(false);
            this.pnlPlayerSettingsCommands.PerformLayout();
            this.pnlPlayerSettingsTames.ResumeLayout(false);
            this.pnlPlayerSettingsTames.PerformLayout();
            this.pnlPlayerSettingsBody.ResumeLayout(false);
            this.pnlPlayerSettingsBody.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnJsonExportMapStructures;
    }
}
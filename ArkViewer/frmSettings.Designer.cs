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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            btnSave = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            tabSettings = new System.Windows.Forms.TabControl();
            tpgMap = new System.Windows.Forms.TabPage();
            optApi = new System.Windows.Forms.RadioButton();
            groupBox6 = new System.Windows.Forms.GroupBox();
            label15 = new System.Windows.Forms.Label();
            textBox6 = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            textBox5 = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            optContentPack = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnLoadContentPack = new System.Windows.Forms.Button();
            txtContentPackFilename = new System.Windows.Forms.TextBox();
            lblSelectedMapContentPack = new System.Windows.Forms.Label();
            optOffline = new System.Windows.Forms.RadioButton();
            optServer = new System.Windows.Forms.RadioButton();
            optSinglePlayer = new System.Windows.Forms.RadioButton();
            grpServer = new System.Windows.Forms.GroupBox();
            btnEditServer = new System.Windows.Forms.Button();
            lblFtpMap = new System.Windows.Forms.Label();
            cboFtpMap = new System.Windows.Forms.ComboBox();
            btnRemoveServer = new System.Windows.Forms.Button();
            btnAddServer = new System.Windows.Forms.Button();
            lblFTPServer = new System.Windows.Forms.Label();
            cboFTPServer = new System.Windows.Forms.ComboBox();
            grpOffline = new System.Windows.Forms.GroupBox();
            btnEditARK = new System.Windows.Forms.Button();
            btnRemoveARK = new System.Windows.Forms.Button();
            btnAddARK = new System.Windows.Forms.Button();
            cboLocalARK = new System.Windows.Forms.ComboBox();
            lblOfflineSave = new System.Windows.Forms.Label();
            grpSinglePlayer = new System.Windows.Forms.GroupBox();
            btnSelectFolder = new System.Windows.Forms.Button();
            chkUpdateNotificationSingle = new System.Windows.Forms.CheckBox();
            lblSelectedMapSP = new System.Windows.Forms.Label();
            cboMapSinglePlayer = new System.Windows.Forms.ComboBox();
            tpgColours = new System.Windows.Forms.TabPage();
            grpTamedHighlights = new System.Windows.Forms.GroupBox();
            lblUploadedHighlight = new System.Windows.Forms.Label();
            lblCryopodHighlight = new System.Windows.Forms.Label();
            lblVivariumHighlight = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            lblTamedHighlight = new System.Windows.Forms.Label();
            grpColoursNotMapped = new System.Windows.Forms.GroupBox();
            btnRefreshUnknownColours = new System.Windows.Forms.Button();
            btnColoursNotMatchedAdd = new System.Windows.Forms.Button();
            lblColourNotMapped = new System.Windows.Forms.Label();
            lblHeaderColoursNotMatched = new System.Windows.Forms.Label();
            lvwColoursNotMapped = new System.Windows.Forms.ListView();
            columnHeader9 = new System.Windows.Forms.ColumnHeader();
            grpColours = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            chkApplyFilterColours = new System.Windows.Forms.CheckBox();
            lblHeaderColours = new System.Windows.Forms.Label();
            txtFilterColour = new System.Windows.Forms.TextBox();
            btnEditColour = new System.Windows.Forms.Button();
            lvwColours = new System.Windows.Forms.ListView();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            columnHeader8 = new System.Windows.Forms.ColumnHeader();
            btnRemoveColour = new System.Windows.Forms.Button();
            btnNewColour = new System.Windows.Forms.Button();
            tpgCreatures = new System.Windows.Forms.TabPage();
            grpCreaturesNotMapped = new System.Windows.Forms.GroupBox();
            btnRefreshUnknownCreatures = new System.Windows.Forms.Button();
            btnCreaturesNotMappedAdd = new System.Windows.Forms.Button();
            lblCreaturesNotMapped = new System.Windows.Forms.Label();
            lblHeaderCreaturesNotMapped = new System.Windows.Forms.Label();
            lvwCreaturesNotMapped = new System.Windows.Forms.ListView();
            columnHeader12 = new System.Windows.Forms.ColumnHeader();
            grpCreatures = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            chkApplyFilterDinos = new System.Windows.Forms.CheckBox();
            lblHeaderCreatures = new System.Windows.Forms.Label();
            txtCreatureFilter = new System.Windows.Forms.TextBox();
            lvwDinoClasses = new System.Windows.Forms.ListView();
            lvwDinoClasses_ClassName = new System.Windows.Forms.ColumnHeader();
            lvwDinoClasses_DisplayName = new System.Windows.Forms.ColumnHeader();
            btnEditDinoClass = new System.Windows.Forms.Button();
            btnAddDinoClass = new System.Windows.Forms.Button();
            btnRemoveDinoClass = new System.Windows.Forms.Button();
            tpgStructures = new System.Windows.Forms.TabPage();
            grpStructuresNotMapped = new System.Windows.Forms.GroupBox();
            btnRefreshUnknownStructures = new System.Windows.Forms.Button();
            btnStructuresNotMappedAdd = new System.Windows.Forms.Button();
            lblStructuresNotMapped = new System.Windows.Forms.Label();
            lblHeaderStructuresNotMapped = new System.Windows.Forms.Label();
            lvwStructuresNotMapped = new System.Windows.Forms.ListView();
            columnHeader10 = new System.Windows.Forms.ColumnHeader();
            grpStructures = new System.Windows.Forms.GroupBox();
            chkApplyFilterStructures = new System.Windows.Forms.CheckBox();
            lblHeaderStructures = new System.Windows.Forms.Label();
            txtStructureFilter = new System.Windows.Forms.TextBox();
            lvwStructureMap = new System.Windows.Forms.ListView();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            btnEditStructure = new System.Windows.Forms.Button();
            btnAddStructure = new System.Windows.Forms.Button();
            btnRemoveStructure = new System.Windows.Forms.Button();
            tpgItems = new System.Windows.Forms.TabPage();
            grpItemsNotMatched = new System.Windows.Forms.GroupBox();
            btnRefreshUnknownItems = new System.Windows.Forms.Button();
            btnItemsNotMatchedAdd = new System.Windows.Forms.Button();
            lblItemsNotMatched = new System.Windows.Forms.Label();
            lblHeaderItemsNotMatched = new System.Windows.Forms.Label();
            lvwItemsNotMatched = new System.Windows.Forms.ListView();
            columnHeader11 = new System.Windows.Forms.ColumnHeader();
            grpItems = new System.Windows.Forms.GroupBox();
            chkApplyFilterItems = new System.Windows.Forms.CheckBox();
            lblHeaderItems = new System.Windows.Forms.Label();
            txtItemFilter = new System.Windows.Forms.TextBox();
            lvwItemMap = new System.Windows.Forms.ListView();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            btnEditItem = new System.Windows.Forms.Button();
            btnAddItem = new System.Windows.Forms.Button();
            btnRemoveItem = new System.Windows.Forms.Button();
            tpgExport = new System.Windows.Forms.TabPage();
            grpJsonExport = new System.Windows.Forms.GroupBox();
            label7 = new System.Windows.Forms.Label();
            btnJsonExportMapStructures = new System.Windows.Forms.Button();
            lblExportPlayerStructures = new System.Windows.Forms.Label();
            btnJsonExportPlayerStructures = new System.Windows.Forms.Button();
            lblExportTamed = new System.Windows.Forms.Label();
            btnJsonExportTamed = new System.Windows.Forms.Button();
            lblExportPlayers = new System.Windows.Forms.Label();
            btnJsonExportPlayers = new System.Windows.Forms.Button();
            lblExportTribes = new System.Windows.Forms.Label();
            btnJsonExportTribes = new System.Windows.Forms.Button();
            lblExportWild = new System.Windows.Forms.Label();
            btnJsonExportWild = new System.Windows.Forms.Button();
            lblExportAll = new System.Windows.Forms.Label();
            btnJsonExportAll = new System.Windows.Forms.Button();
            lblHeaderJsonExport = new System.Windows.Forms.Label();
            lblJsonFileExport = new System.Windows.Forms.Label();
            grpContentPack = new System.Windows.Forms.GroupBox();
            chkDroppedItems = new System.Windows.Forms.CheckBox();
            chkStructureContents = new System.Windows.Forms.CheckBox();
            chkStructureLocations = new System.Windows.Forms.CheckBox();
            btnExportContentPack = new System.Windows.Forms.Button();
            udExportRadius = new System.Windows.Forms.NumericUpDown();
            udExportLon = new System.Windows.Forms.NumericUpDown();
            udExportLat = new System.Windows.Forms.NumericUpDown();
            lblFilterRad = new System.Windows.Forms.Label();
            cboExportPlayer = new System.Windows.Forms.ComboBox();
            cboExportTribe = new System.Windows.Forms.ComboBox();
            lblFilterLon = new System.Windows.Forms.Label();
            lblFilterLat = new System.Windows.Forms.Label();
            lblFilterPlayer = new System.Windows.Forms.Label();
            lblFilterTribe = new System.Windows.Forms.Label();
            lblContentPackFilters = new System.Windows.Forms.Label();
            chkPlayerStructures = new System.Windows.Forms.CheckBox();
            chkTamedCreatures = new System.Windows.Forms.CheckBox();
            chkWildCreatures = new System.Windows.Forms.CheckBox();
            lblHeaderConteentPack = new System.Windows.Forms.Label();
            lblContentPackOptions = new System.Windows.Forms.Label();
            tpgRestService = new System.Windows.Forms.TabPage();
            grpService = new System.Windows.Forms.GroupBox();
            chkAutostartService = new System.Windows.Forms.CheckBox();
            udServicePort = new System.Windows.Forms.NumericUpDown();
            lblServiceStatus = new System.Windows.Forms.Label();
            txtServiceStatus = new System.Windows.Forms.TextBox();
            btnClearServiceLog = new System.Windows.Forms.Button();
            txtServiceLog = new System.Windows.Forms.TextBox();
            lblServiceActivity = new System.Windows.Forms.Label();
            btnStopService = new System.Windows.Forms.Button();
            btnStartService = new System.Windows.Forms.Button();
            lblService = new System.Windows.Forms.Label();
            lblHeaderService = new System.Windows.Forms.Label();
            lblServicePort = new System.Windows.Forms.Label();
            grpClientAccess = new System.Windows.Forms.GroupBox();
            lblClientAccess = new System.Windows.Forms.Label();
            chkFilterClient = new System.Windows.Forms.CheckBox();
            lblHeaderClientAccess = new System.Windows.Forms.Label();
            txtFilterClient = new System.Windows.Forms.TextBox();
            btnEditClient = new System.Windows.Forms.Button();
            lvwClientAccess = new System.Windows.Forms.ListView();
            columnHeader13 = new System.Windows.Forms.ColumnHeader();
            columnHeader14 = new System.Windows.Forms.ColumnHeader();
            columnHeader15 = new System.Windows.Forms.ColumnHeader();
            btnRemoveClient = new System.Windows.Forms.Button();
            btnNewClient = new System.Windows.Forms.Button();
            tpgOptions = new System.Windows.Forms.TabPage();
            groupBox1 = new System.Windows.Forms.GroupBox();
            pnlCommandExportOptions = new System.Windows.Forms.Panel();
            optExportNoSort = new System.Windows.Forms.RadioButton();
            optExportSort = new System.Windows.Forms.RadioButton();
            lblCommandExportOptionTitle = new System.Windows.Forms.Label();
            lblCommandExportDescription = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            pnlFtpSettingsCommands = new System.Windows.Forms.Panel();
            pnlDownloadOption = new System.Windows.Forms.Panel();
            optDownloadAuto = new System.Windows.Forms.RadioButton();
            optDownloadManual = new System.Windows.Forms.RadioButton();
            label5 = new System.Windows.Forms.Label();
            optFTPSync = new System.Windows.Forms.RadioButton();
            optFTPClean = new System.Windows.Forms.RadioButton();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            pnlPlayerSettingsStuctures = new System.Windows.Forms.Panel();
            optPlayerStructureHide = new System.Windows.Forms.RadioButton();
            optPlayerStructureShow = new System.Windows.Forms.RadioButton();
            lblOptionHeaderStructures = new System.Windows.Forms.Label();
            lblOptionTextStructures = new System.Windows.Forms.Label();
            pnlPlayerSettingsCommands = new System.Windows.Forms.Panel();
            optPlayerCommandsPrefixAdmincheat = new System.Windows.Forms.RadioButton();
            optPlayerCommandsPrefixNone = new System.Windows.Forms.RadioButton();
            optPlayerCommandsPrefixCheat = new System.Windows.Forms.RadioButton();
            lblOptionHeaderCommand = new System.Windows.Forms.Label();
            lblOptionTextCommand = new System.Windows.Forms.Label();
            pnlPlayerSettingsTames = new System.Windows.Forms.Panel();
            optPlayerTameHide = new System.Windows.Forms.RadioButton();
            optPlayerTameShow = new System.Windows.Forms.RadioButton();
            lblOptionHeaderTames = new System.Windows.Forms.Label();
            lblOptionTextTames = new System.Windows.Forms.Label();
            pnlPlayerSettingsBody = new System.Windows.Forms.Panel();
            optPlayerBodyHide = new System.Windows.Forms.RadioButton();
            optPlayerBodyShow = new System.Windows.Forms.RadioButton();
            lblOptionHeaderBody = new System.Windows.Forms.Label();
            lblOptionTextBody = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            tabSettings.SuspendLayout();
            tpgMap.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox2.SuspendLayout();
            grpServer.SuspendLayout();
            grpOffline.SuspendLayout();
            grpSinglePlayer.SuspendLayout();
            tpgColours.SuspendLayout();
            grpTamedHighlights.SuspendLayout();
            grpColoursNotMapped.SuspendLayout();
            grpColours.SuspendLayout();
            tpgCreatures.SuspendLayout();
            grpCreaturesNotMapped.SuspendLayout();
            grpCreatures.SuspendLayout();
            tpgStructures.SuspendLayout();
            grpStructuresNotMapped.SuspendLayout();
            grpStructures.SuspendLayout();
            tpgItems.SuspendLayout();
            grpItemsNotMatched.SuspendLayout();
            grpItems.SuspendLayout();
            tpgExport.SuspendLayout();
            grpJsonExport.SuspendLayout();
            grpContentPack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udExportRadius).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udExportLon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udExportLat).BeginInit();
            tpgRestService.SuspendLayout();
            grpService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udServicePort).BeginInit();
            grpClientAccess.SuspendLayout();
            tpgOptions.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlCommandExportOptions.SuspendLayout();
            pnlFtpSettingsCommands.SuspendLayout();
            pnlDownloadOption.SuspendLayout();
            pnlPlayerSettingsStuctures.SuspendLayout();
            pnlPlayerSettingsCommands.SuspendLayout();
            pnlPlayerSettingsTames.SuspendLayout();
            pnlPlayerSettingsBody.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.Location = new System.Drawing.Point(485, 773);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(78, 27);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(570, 773);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(88, 27);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "*.ark";
            openFileDialog1.Filter = "ARK SaveGame|*.ark";
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.SupportMultiDottedExtensions = true;
            openFileDialog1.Title = "Open ARK Save Game";
            // 
            // tabSettings
            // 
            tabSettings.Controls.Add(tpgMap);
            tabSettings.Controls.Add(tpgColours);
            tabSettings.Controls.Add(tpgCreatures);
            tabSettings.Controls.Add(tpgStructures);
            tabSettings.Controls.Add(tpgItems);
            tabSettings.Controls.Add(tpgExport);
            tabSettings.Controls.Add(tpgRestService);
            tabSettings.Controls.Add(tpgOptions);
            tabSettings.Location = new System.Drawing.Point(14, 14);
            tabSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabSettings.Multiline = true;
            tabSettings.Name = "tabSettings";
            tabSettings.SelectedIndex = 0;
            tabSettings.Size = new System.Drawing.Size(645, 752);
            tabSettings.TabIndex = 0;
            tabSettings.Selecting += tabSettings_Selecting;
            // 
            // tpgMap
            // 
            tpgMap.Controls.Add(optApi);
            tpgMap.Controls.Add(groupBox6);
            tpgMap.Controls.Add(optContentPack);
            tpgMap.Controls.Add(groupBox2);
            tpgMap.Controls.Add(optOffline);
            tpgMap.Controls.Add(optServer);
            tpgMap.Controls.Add(optSinglePlayer);
            tpgMap.Controls.Add(grpServer);
            tpgMap.Controls.Add(grpOffline);
            tpgMap.Controls.Add(grpSinglePlayer);
            tpgMap.Location = new System.Drawing.Point(4, 24);
            tpgMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgMap.Name = "tpgMap";
            tpgMap.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgMap.Size = new System.Drawing.Size(637, 724);
            tpgMap.TabIndex = 0;
            tpgMap.Text = "Map Data";
            tpgMap.UseVisualStyleBackColor = true;
            // 
            // optApi
            // 
            optApi.AutoSize = true;
            optApi.Enabled = false;
            optApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            optApi.ForeColor = System.Drawing.SystemColors.WindowText;
            optApi.Location = new System.Drawing.Point(50, 548);
            optApi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optApi.Name = "optApi";
            optApi.Size = new System.Drawing.Size(140, 17);
            optApi.TabIndex = 8;
            optApi.Text = "ASV Hosted Service";
            optApi.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label15);
            groupBox6.Controls.Add(textBox6);
            groupBox6.Controls.Add(label14);
            groupBox6.Controls.Add(textBox5);
            groupBox6.Controls.Add(label13);
            groupBox6.Enabled = false;
            groupBox6.Location = new System.Drawing.Point(47, 567);
            groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox6.Size = new System.Drawing.Size(550, 110);
            groupBox6.TabIndex = 9;
            groupBox6.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label15.Location = new System.Drawing.Point(14, 73);
            label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(66, 13);
            label15.TabIndex = 54;
            label15.Text = "Access Key:";
            // 
            // textBox6
            // 
            textBox6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox6.Location = new System.Drawing.Point(113, 67);
            textBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new System.Drawing.Size(405, 22);
            textBox6.TabIndex = 53;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(14, 35);
            label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(48, 13);
            label14.TabIndex = 52;
            label14.Text = "Address:";
            // 
            // textBox5
            // 
            textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox5.Location = new System.Drawing.Point(113, 29);
            textBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new System.Drawing.Size(405, 22);
            textBox5.TabIndex = 1;
            // 
            // label13
            // 
            label13.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label13.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(-2, 7);
            label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(553, 7);
            label13.TabIndex = 0;
            label13.Text = "   ";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optContentPack
            // 
            optContentPack.AutoSize = true;
            optContentPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            optContentPack.Location = new System.Drawing.Point(47, 273);
            optContentPack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optContentPack.Name = "optContentPack";
            optContentPack.Size = new System.Drawing.Size(138, 17);
            optContentPack.TabIndex = 4;
            optContentPack.Text = "Content Pack (.asv)";
            optContentPack.UseVisualStyleBackColor = true;
            optContentPack.CheckedChanged += optContentPack_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLoadContentPack);
            groupBox2.Controls.Add(txtContentPackFilename);
            groupBox2.Controls.Add(lblSelectedMapContentPack);
            groupBox2.Location = new System.Drawing.Point(43, 290);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(550, 96);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // btnLoadContentPack
            // 
            btnLoadContentPack.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnLoadContentPack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLoadContentPack.Image = (System.Drawing.Image)resources.GetObject("btnLoadContentPack.Image");
            btnLoadContentPack.Location = new System.Drawing.Point(484, 33);
            btnLoadContentPack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLoadContentPack.Name = "btnLoadContentPack";
            btnLoadContentPack.Size = new System.Drawing.Size(41, 40);
            btnLoadContentPack.TabIndex = 2;
            toolTip1.SetToolTip(btnLoadContentPack, "Open ARK save file");
            btnLoadContentPack.UseVisualStyleBackColor = true;
            btnLoadContentPack.Click += btnLoadContentPack_Click;
            // 
            // txtContentPackFilename
            // 
            txtContentPackFilename.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtContentPackFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtContentPackFilename.Location = new System.Drawing.Point(21, 40);
            txtContentPackFilename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtContentPackFilename.Name = "txtContentPackFilename";
            txtContentPackFilename.ReadOnly = true;
            txtContentPackFilename.Size = new System.Drawing.Size(455, 22);
            txtContentPackFilename.TabIndex = 1;
            // 
            // lblSelectedMapContentPack
            // 
            lblSelectedMapContentPack.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblSelectedMapContentPack.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            lblSelectedMapContentPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSelectedMapContentPack.Location = new System.Drawing.Point(-2, 7);
            lblSelectedMapContentPack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSelectedMapContentPack.Name = "lblSelectedMapContentPack";
            lblSelectedMapContentPack.Size = new System.Drawing.Size(553, 7);
            lblSelectedMapContentPack.TabIndex = 0;
            lblSelectedMapContentPack.Text = "   ";
            lblSelectedMapContentPack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optOffline
            // 
            optOffline.AutoSize = true;
            optOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            optOffline.Location = new System.Drawing.Point(47, 155);
            optOffline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optOffline.Name = "optOffline";
            optOffline.Size = new System.Drawing.Size(142, 17);
            optOffline.TabIndex = 2;
            optOffline.Text = "Savegame File (.ark)";
            optOffline.UseVisualStyleBackColor = true;
            optOffline.CheckedChanged += optOffline_CheckedChanged;
            // 
            // optServer
            // 
            optServer.AutoSize = true;
            optServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            optServer.Location = new System.Drawing.Point(47, 392);
            optServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optServer.Name = "optServer";
            optServer.Size = new System.Drawing.Size(89, 17);
            optServer.TabIndex = 6;
            optServer.Text = "FTP Server";
            optServer.UseVisualStyleBackColor = true;
            optServer.CheckedChanged += optServer_CheckedChanged;
            // 
            // optSinglePlayer
            // 
            optSinglePlayer.AutoSize = true;
            optSinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            optSinglePlayer.Location = new System.Drawing.Point(47, 32);
            optSinglePlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optSinglePlayer.Name = "optSinglePlayer";
            optSinglePlayer.Size = new System.Drawing.Size(146, 17);
            optSinglePlayer.TabIndex = 0;
            optSinglePlayer.Text = "Single Player (Steam)";
            optSinglePlayer.UseVisualStyleBackColor = true;
            optSinglePlayer.CheckedChanged += optSinglePlayer_CheckedChanged;
            // 
            // grpServer
            // 
            grpServer.Controls.Add(btnEditServer);
            grpServer.Controls.Add(lblFtpMap);
            grpServer.Controls.Add(cboFtpMap);
            grpServer.Controls.Add(btnRemoveServer);
            grpServer.Controls.Add(btnAddServer);
            grpServer.Controls.Add(lblFTPServer);
            grpServer.Controls.Add(cboFTPServer);
            grpServer.Location = new System.Drawing.Point(44, 415);
            grpServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpServer.Name = "grpServer";
            grpServer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpServer.Size = new System.Drawing.Size(550, 126);
            grpServer.TabIndex = 7;
            grpServer.TabStop = false;
            // 
            // btnEditServer
            // 
            btnEditServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnEditServer.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditServer.Enabled = false;
            btnEditServer.Image = (System.Drawing.Image)resources.GetObject("btnEditServer.Image");
            btnEditServer.Location = new System.Drawing.Point(390, 28);
            btnEditServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditServer.Name = "btnEditServer";
            btnEditServer.Size = new System.Drawing.Size(41, 40);
            btnEditServer.TabIndex = 21;
            toolTip1.SetToolTip(btnEditServer, "Edit server");
            btnEditServer.UseVisualStyleBackColor = true;
            btnEditServer.Click += btnEditServer_Click;
            // 
            // lblFtpMap
            // 
            lblFtpMap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblFtpMap.BackColor = System.Drawing.SystemColors.Control;
            lblFtpMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFtpMap.Location = new System.Drawing.Point(24, 76);
            lblFtpMap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFtpMap.Name = "lblFtpMap";
            lblFtpMap.Size = new System.Drawing.Size(134, 25);
            lblFtpMap.TabIndex = 20;
            lblFtpMap.Text = "Map";
            lblFtpMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboFtpMap
            // 
            cboFtpMap.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboFtpMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            cboFtpMap.Enabled = false;
            cboFtpMap.FormattingEnabled = true;
            cboFtpMap.Location = new System.Drawing.Point(160, 77);
            cboFtpMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboFtpMap.Name = "cboFtpMap";
            cboFtpMap.Size = new System.Drawing.Size(361, 24);
            cboFtpMap.TabIndex = 19;
            cboFtpMap.SelectedIndexChanged += cboFtpMap_SelectedIndexChanged;
            // 
            // btnRemoveServer
            // 
            btnRemoveServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRemoveServer.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveServer.Enabled = false;
            btnRemoveServer.Image = (System.Drawing.Image)resources.GetObject("btnRemoveServer.Image");
            btnRemoveServer.Location = new System.Drawing.Point(483, 28);
            btnRemoveServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveServer.Name = "btnRemoveServer";
            btnRemoveServer.Size = new System.Drawing.Size(41, 40);
            btnRemoveServer.TabIndex = 4;
            toolTip1.SetToolTip(btnRemoveServer, "Remove selected server");
            btnRemoveServer.UseVisualStyleBackColor = true;
            btnRemoveServer.Click += btnRemoveServer_Click;
            // 
            // btnAddServer
            // 
            btnAddServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAddServer.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddServer.Image = (System.Drawing.Image)resources.GetObject("btnAddServer.Image");
            btnAddServer.Location = new System.Drawing.Point(436, 28);
            btnAddServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddServer.Name = "btnAddServer";
            btnAddServer.Size = new System.Drawing.Size(41, 40);
            btnAddServer.TabIndex = 3;
            toolTip1.SetToolTip(btnAddServer, "Add new server");
            btnAddServer.UseVisualStyleBackColor = true;
            btnAddServer.Click += btnAddServer_Click;
            // 
            // lblFTPServer
            // 
            lblFTPServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblFTPServer.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            lblFTPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFTPServer.Location = new System.Drawing.Point(-1, 0);
            lblFTPServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFTPServer.Name = "lblFTPServer";
            lblFTPServer.Size = new System.Drawing.Size(553, 7);
            lblFTPServer.TabIndex = 0;
            lblFTPServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboFTPServer
            // 
            cboFTPServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboFTPServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboFTPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboFTPServer.FormattingEnabled = true;
            cboFTPServer.Location = new System.Drawing.Point(29, 35);
            cboFTPServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboFTPServer.Name = "cboFTPServer";
            cboFTPServer.Size = new System.Drawing.Size(347, 24);
            cboFTPServer.TabIndex = 1;
            cboFTPServer.SelectedIndexChanged += cboFTPServer_SelectedIndexChanged;
            // 
            // grpOffline
            // 
            grpOffline.Controls.Add(btnEditARK);
            grpOffline.Controls.Add(btnRemoveARK);
            grpOffline.Controls.Add(btnAddARK);
            grpOffline.Controls.Add(cboLocalARK);
            grpOffline.Controls.Add(lblOfflineSave);
            grpOffline.Location = new System.Drawing.Point(43, 171);
            grpOffline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpOffline.Name = "grpOffline";
            grpOffline.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpOffline.Size = new System.Drawing.Size(550, 96);
            grpOffline.TabIndex = 3;
            grpOffline.TabStop = false;
            // 
            // btnEditARK
            // 
            btnEditARK.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnEditARK.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditARK.Enabled = false;
            btnEditARK.Image = (System.Drawing.Image)resources.GetObject("btnEditARK.Image");
            btnEditARK.Location = new System.Drawing.Point(387, 32);
            btnEditARK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditARK.Name = "btnEditARK";
            btnEditARK.Size = new System.Drawing.Size(41, 40);
            btnEditARK.TabIndex = 22;
            toolTip1.SetToolTip(btnEditARK, "Edit details");
            btnEditARK.UseVisualStyleBackColor = true;
            btnEditARK.Click += btnEditARK_Click;
            // 
            // btnRemoveARK
            // 
            btnRemoveARK.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRemoveARK.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveARK.Enabled = false;
            btnRemoveARK.Image = (System.Drawing.Image)resources.GetObject("btnRemoveARK.Image");
            btnRemoveARK.Location = new System.Drawing.Point(482, 32);
            btnRemoveARK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveARK.Name = "btnRemoveARK";
            btnRemoveARK.Size = new System.Drawing.Size(41, 40);
            btnRemoveARK.TabIndex = 7;
            toolTip1.SetToolTip(btnRemoveARK, "Remove selected offline file.");
            btnRemoveARK.UseVisualStyleBackColor = true;
            btnRemoveARK.Click += btnRemoveARK_Click;
            // 
            // btnAddARK
            // 
            btnAddARK.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAddARK.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddARK.Image = (System.Drawing.Image)resources.GetObject("btnAddARK.Image");
            btnAddARK.Location = new System.Drawing.Point(435, 32);
            btnAddARK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddARK.Name = "btnAddARK";
            btnAddARK.Size = new System.Drawing.Size(41, 40);
            btnAddARK.TabIndex = 6;
            toolTip1.SetToolTip(btnAddARK, "Add new offline file.");
            btnAddARK.UseVisualStyleBackColor = true;
            btnAddARK.Click += btnAddARK_Click;
            // 
            // cboLocalARK
            // 
            cboLocalARK.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboLocalARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboLocalARK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboLocalARK.FormattingEnabled = true;
            cboLocalARK.Location = new System.Drawing.Point(21, 39);
            cboLocalARK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboLocalARK.Name = "cboLocalARK";
            cboLocalARK.Size = new System.Drawing.Size(356, 24);
            cboLocalARK.TabIndex = 5;
            cboLocalARK.SelectedIndexChanged += cboLocalARK_SelectedIndexChanged;
            // 
            // lblOfflineSave
            // 
            lblOfflineSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblOfflineSave.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            lblOfflineSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblOfflineSave.Location = new System.Drawing.Point(-2, 7);
            lblOfflineSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOfflineSave.Name = "lblOfflineSave";
            lblOfflineSave.Size = new System.Drawing.Size(553, 7);
            lblOfflineSave.TabIndex = 0;
            lblOfflineSave.Text = "   ";
            lblOfflineSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpSinglePlayer
            // 
            grpSinglePlayer.Controls.Add(btnSelectFolder);
            grpSinglePlayer.Controls.Add(chkUpdateNotificationSingle);
            grpSinglePlayer.Controls.Add(lblSelectedMapSP);
            grpSinglePlayer.Controls.Add(cboMapSinglePlayer);
            grpSinglePlayer.Location = new System.Drawing.Point(42, 48);
            grpSinglePlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpSinglePlayer.Name = "grpSinglePlayer";
            grpSinglePlayer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpSinglePlayer.Size = new System.Drawing.Size(551, 98);
            grpSinglePlayer.TabIndex = 1;
            grpSinglePlayer.TabStop = false;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSelectFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSelectFolder.Enabled = false;
            btnSelectFolder.Image = (System.Drawing.Image)resources.GetObject("btnSelectFolder.Image");
            btnSelectFolder.Location = new System.Drawing.Point(483, 30);
            btnSelectFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new System.Drawing.Size(41, 40);
            btnSelectFolder.TabIndex = 3;
            toolTip1.SetToolTip(btnSelectFolder, "Select ARK save location.");
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // chkUpdateNotificationSingle
            // 
            chkUpdateNotificationSingle.AutoSize = true;
            chkUpdateNotificationSingle.Enabled = false;
            chkUpdateNotificationSingle.Location = new System.Drawing.Point(22, 74);
            chkUpdateNotificationSingle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkUpdateNotificationSingle.Name = "chkUpdateNotificationSingle";
            chkUpdateNotificationSingle.Size = new System.Drawing.Size(133, 19);
            chkUpdateNotificationSingle.TabIndex = 2;
            chkUpdateNotificationSingle.Text = "Update notifications";
            chkUpdateNotificationSingle.UseVisualStyleBackColor = true;
            chkUpdateNotificationSingle.Visible = false;
            // 
            // lblSelectedMapSP
            // 
            lblSelectedMapSP.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblSelectedMapSP.BackColor = System.Drawing.Color.Aqua;
            lblSelectedMapSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSelectedMapSP.Location = new System.Drawing.Point(-2, 7);
            lblSelectedMapSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSelectedMapSP.Name = "lblSelectedMapSP";
            lblSelectedMapSP.Size = new System.Drawing.Size(554, 7);
            lblSelectedMapSP.TabIndex = 0;
            lblSelectedMapSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboMapSinglePlayer
            // 
            cboMapSinglePlayer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboMapSinglePlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboMapSinglePlayer.FormattingEnabled = true;
            cboMapSinglePlayer.Location = new System.Drawing.Point(22, 39);
            cboMapSinglePlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboMapSinglePlayer.Name = "cboMapSinglePlayer";
            cboMapSinglePlayer.Size = new System.Drawing.Size(455, 23);
            cboMapSinglePlayer.TabIndex = 1;
            cboMapSinglePlayer.SelectedIndexChanged += cboMapSinglePlayer_SelectedIndexChanged;
            // 
            // tpgColours
            // 
            tpgColours.Controls.Add(grpTamedHighlights);
            tpgColours.Controls.Add(grpColoursNotMapped);
            tpgColours.Controls.Add(grpColours);
            tpgColours.Location = new System.Drawing.Point(4, 24);
            tpgColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgColours.Name = "tpgColours";
            tpgColours.Size = new System.Drawing.Size(637, 724);
            tpgColours.TabIndex = 5;
            tpgColours.Text = "Colours";
            tpgColours.UseVisualStyleBackColor = true;
            // 
            // grpTamedHighlights
            // 
            grpTamedHighlights.Controls.Add(lblUploadedHighlight);
            grpTamedHighlights.Controls.Add(lblCryopodHighlight);
            grpTamedHighlights.Controls.Add(lblVivariumHighlight);
            grpTamedHighlights.Controls.Add(label9);
            grpTamedHighlights.Controls.Add(lblTamedHighlight);
            grpTamedHighlights.Location = new System.Drawing.Point(23, 525);
            grpTamedHighlights.Name = "grpTamedHighlights";
            grpTamedHighlights.Size = new System.Drawing.Size(590, 158);
            grpTamedHighlights.TabIndex = 2;
            grpTamedHighlights.TabStop = false;
            // 
            // lblUploadedHighlight
            // 
            lblUploadedHighlight.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblUploadedHighlight.BackColor = System.Drawing.Color.WhiteSmoke;
            lblUploadedHighlight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblUploadedHighlight.Cursor = System.Windows.Forms.Cursors.Hand;
            lblUploadedHighlight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblUploadedHighlight.ForeColor = System.Drawing.Color.Black;
            lblUploadedHighlight.Location = new System.Drawing.Point(192, 115);
            lblUploadedHighlight.Name = "lblUploadedHighlight";
            lblUploadedHighlight.Size = new System.Drawing.Size(193, 25);
            lblUploadedHighlight.TabIndex = 6;
            lblUploadedHighlight.Text = "Uploaded";
            lblUploadedHighlight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblUploadedHighlight.Click += lblUploadedHighlight_Click;
            // 
            // lblCryopodHighlight
            // 
            lblCryopodHighlight.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCryopodHighlight.BackColor = System.Drawing.Color.LightSkyBlue;
            lblCryopodHighlight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblCryopodHighlight.Cursor = System.Windows.Forms.Cursors.Hand;
            lblCryopodHighlight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCryopodHighlight.ForeColor = System.Drawing.Color.Black;
            lblCryopodHighlight.Location = new System.Drawing.Point(192, 79);
            lblCryopodHighlight.Name = "lblCryopodHighlight";
            lblCryopodHighlight.Size = new System.Drawing.Size(193, 25);
            lblCryopodHighlight.TabIndex = 5;
            lblCryopodHighlight.Text = "Cryopod";
            lblCryopodHighlight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblCryopodHighlight.Click += lblCryopodHighlight_Click;
            // 
            // lblVivariumHighlight
            // 
            lblVivariumHighlight.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblVivariumHighlight.BackColor = System.Drawing.Color.LightGreen;
            lblVivariumHighlight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblVivariumHighlight.Cursor = System.Windows.Forms.Cursors.Hand;
            lblVivariumHighlight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblVivariumHighlight.ForeColor = System.Drawing.Color.Black;
            lblVivariumHighlight.Location = new System.Drawing.Point(192, 44);
            lblVivariumHighlight.Name = "lblVivariumHighlight";
            lblVivariumHighlight.Size = new System.Drawing.Size(193, 25);
            lblVivariumHighlight.TabIndex = 4;
            lblVivariumHighlight.Text = "Vivarium";
            lblVivariumHighlight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblVivariumHighlight.Click += lblVivariumHighlight_Click;
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label9.BackColor = System.Drawing.Color.Gainsboro;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(-3, 8);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(596, 7);
            label9.TabIndex = 2;
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTamedHighlight
            // 
            lblTamedHighlight.BackColor = System.Drawing.Color.Transparent;
            lblTamedHighlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTamedHighlight.Location = new System.Drawing.Point(10, 11);
            lblTamedHighlight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTamedHighlight.Name = "lblTamedHighlight";
            lblTamedHighlight.Size = new System.Drawing.Size(231, 25);
            lblTamedHighlight.TabIndex = 3;
            lblTamedHighlight.Text = "Tamed Highlight";
            lblTamedHighlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpColoursNotMapped
            // 
            grpColoursNotMapped.Controls.Add(btnRefreshUnknownColours);
            grpColoursNotMapped.Controls.Add(btnColoursNotMatchedAdd);
            grpColoursNotMapped.Controls.Add(lblColourNotMapped);
            grpColoursNotMapped.Controls.Add(lblHeaderColoursNotMatched);
            grpColoursNotMapped.Controls.Add(lvwColoursNotMapped);
            grpColoursNotMapped.Location = new System.Drawing.Point(22, 298);
            grpColoursNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpColoursNotMapped.Name = "grpColoursNotMapped";
            grpColoursNotMapped.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpColoursNotMapped.Size = new System.Drawing.Size(593, 221);
            grpColoursNotMapped.TabIndex = 1;
            grpColoursNotMapped.TabStop = false;
            // 
            // btnRefreshUnknownColours
            // 
            btnRefreshUnknownColours.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRefreshUnknownColours.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefreshUnknownColours.Image = (System.Drawing.Image)resources.GetObject("btnRefreshUnknownColours.Image");
            btnRefreshUnknownColours.Location = new System.Drawing.Point(13, 172);
            btnRefreshUnknownColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRefreshUnknownColours.Name = "btnRefreshUnknownColours";
            btnRefreshUnknownColours.Size = new System.Drawing.Size(41, 40);
            btnRefreshUnknownColours.TabIndex = 6;
            toolTip1.SetToolTip(btnRefreshUnknownColours, "Add mapping");
            btnRefreshUnknownColours.UseVisualStyleBackColor = true;
            // 
            // btnColoursNotMatchedAdd
            // 
            btnColoursNotMatchedAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnColoursNotMatchedAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnColoursNotMatchedAdd.Enabled = false;
            btnColoursNotMatchedAdd.Image = (System.Drawing.Image)resources.GetObject("btnColoursNotMatchedAdd.Image");
            btnColoursNotMatchedAdd.Location = new System.Drawing.Point(539, 172);
            btnColoursNotMatchedAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnColoursNotMatchedAdd.Name = "btnColoursNotMatchedAdd";
            btnColoursNotMatchedAdd.Size = new System.Drawing.Size(41, 40);
            btnColoursNotMatchedAdd.TabIndex = 5;
            toolTip1.SetToolTip(btnColoursNotMatchedAdd, "Add mapping");
            btnColoursNotMatchedAdd.UseVisualStyleBackColor = true;
            // 
            // lblColourNotMapped
            // 
            lblColourNotMapped.BackColor = System.Drawing.Color.Transparent;
            lblColourNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblColourNotMapped.Location = new System.Drawing.Point(12, 18);
            lblColourNotMapped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblColourNotMapped.Name = "lblColourNotMapped";
            lblColourNotMapped.Size = new System.Drawing.Size(231, 25);
            lblColourNotMapped.TabIndex = 1;
            lblColourNotMapped.Text = "Not Mapped";
            lblColourNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderColoursNotMatched
            // 
            lblHeaderColoursNotMatched.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderColoursNotMatched.BackColor = System.Drawing.Color.Gainsboro;
            lblHeaderColoursNotMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderColoursNotMatched.Location = new System.Drawing.Point(-2, 7);
            lblHeaderColoursNotMatched.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderColoursNotMatched.Name = "lblHeaderColoursNotMatched";
            lblHeaderColoursNotMatched.Size = new System.Drawing.Size(596, 7);
            lblHeaderColoursNotMatched.TabIndex = 0;
            lblHeaderColoursNotMatched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwColoursNotMapped
            // 
            lvwColoursNotMapped.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwColoursNotMapped.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader9 });
            lvwColoursNotMapped.FullRowSelect = true;
            lvwColoursNotMapped.Location = new System.Drawing.Point(15, 52);
            lvwColoursNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwColoursNotMapped.Name = "lvwColoursNotMapped";
            lvwColoursNotMapped.Size = new System.Drawing.Size(565, 112);
            lvwColoursNotMapped.TabIndex = 2;
            lvwColoursNotMapped.UseCompatibleStateImageBehavior = false;
            lvwColoursNotMapped.View = System.Windows.Forms.View.Details;
            lvwColoursNotMapped.ColumnClick += lvwColoursNotMapped_ColumnClick;
            lvwColoursNotMapped.SelectedIndexChanged += lvwColoursNotMapped_SelectedIndexChanged;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Detected Colour Id";
            columnHeader9.Width = 400;
            // 
            // grpColours
            // 
            grpColours.Controls.Add(label1);
            grpColours.Controls.Add(chkApplyFilterColours);
            grpColours.Controls.Add(lblHeaderColours);
            grpColours.Controls.Add(txtFilterColour);
            grpColours.Controls.Add(btnEditColour);
            grpColours.Controls.Add(lvwColours);
            grpColours.Controls.Add(btnRemoveColour);
            grpColours.Controls.Add(btnNewColour);
            grpColours.Location = new System.Drawing.Point(21, 12);
            grpColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpColours.Name = "grpColours";
            grpColours.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpColours.Size = new System.Drawing.Size(593, 280);
            grpColours.TabIndex = 0;
            grpColours.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 18);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(231, 25);
            label1.TabIndex = 0;
            label1.Text = "Mapped";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkApplyFilterColours
            // 
            chkApplyFilterColours.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            chkApplyFilterColours.Appearance = System.Windows.Forms.Appearance.Button;
            chkApplyFilterColours.Cursor = System.Windows.Forms.Cursors.Hand;
            chkApplyFilterColours.Image = (System.Drawing.Image)resources.GetObject("chkApplyFilterColours.Image");
            chkApplyFilterColours.Location = new System.Drawing.Point(496, 228);
            chkApplyFilterColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkApplyFilterColours.Name = "chkApplyFilterColours";
            chkApplyFilterColours.Size = new System.Drawing.Size(41, 40);
            chkApplyFilterColours.TabIndex = 5;
            toolTip1.SetToolTip(chkApplyFilterColours, "Apply filter");
            chkApplyFilterColours.UseVisualStyleBackColor = true;
            chkApplyFilterColours.CheckedChanged += chkApplyFilterColours_CheckedChanged;
            // 
            // lblHeaderColours
            // 
            lblHeaderColours.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderColours.BackColor = System.Drawing.Color.Aqua;
            lblHeaderColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderColours.Location = new System.Drawing.Point(-2, 7);
            lblHeaderColours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderColours.Name = "lblHeaderColours";
            lblHeaderColours.Size = new System.Drawing.Size(596, 7);
            lblHeaderColours.TabIndex = 0;
            lblHeaderColours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFilterColour
            // 
            txtFilterColour.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFilterColour.Location = new System.Drawing.Point(107, 236);
            txtFilterColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilterColour.Name = "txtFilterColour";
            txtFilterColour.Size = new System.Drawing.Size(381, 23);
            txtFilterColour.TabIndex = 4;
            // 
            // btnEditColour
            // 
            btnEditColour.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnEditColour.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditColour.Enabled = false;
            btnEditColour.Image = (System.Drawing.Image)resources.GetObject("btnEditColour.Image");
            btnEditColour.Location = new System.Drawing.Point(542, 228);
            btnEditColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditColour.Name = "btnEditColour";
            btnEditColour.Size = new System.Drawing.Size(41, 40);
            btnEditColour.TabIndex = 6;
            toolTip1.SetToolTip(btnEditColour, "Edit display name");
            btnEditColour.UseVisualStyleBackColor = true;
            btnEditColour.Click += btnEditColour_Click;
            // 
            // lvwColours
            // 
            lvwColours.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwColours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader4, columnHeader7, columnHeader8 });
            lvwColours.FullRowSelect = true;
            lvwColours.Location = new System.Drawing.Point(15, 52);
            lvwColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwColours.Name = "lvwColours";
            lvwColours.Size = new System.Drawing.Size(565, 169);
            lvwColours.TabIndex = 1;
            lvwColours.UseCompatibleStateImageBehavior = false;
            lvwColours.View = System.Windows.Forms.View.Details;
            lvwColours.ColumnClick += lvwColours_ColumnClick;
            lvwColours.SelectedIndexChanged += lvwColours_SelectedIndexChanged;
            lvwColours.Click += lvwColours_Click;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Id";
            columnHeader4.Width = 50;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Hex";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Colour";
            columnHeader8.Width = 297;
            // 
            // btnRemoveColour
            // 
            btnRemoveColour.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRemoveColour.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveColour.Enabled = false;
            btnRemoveColour.Image = (System.Drawing.Image)resources.GetObject("btnRemoveColour.Image");
            btnRemoveColour.Location = new System.Drawing.Point(61, 228);
            btnRemoveColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveColour.Name = "btnRemoveColour";
            btnRemoveColour.Size = new System.Drawing.Size(41, 40);
            btnRemoveColour.TabIndex = 3;
            toolTip1.SetToolTip(btnRemoveColour, "Remove mapping");
            btnRemoveColour.UseVisualStyleBackColor = true;
            btnRemoveColour.Click += btnRemoveColour_Click;
            // 
            // btnNewColour
            // 
            btnNewColour.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnNewColour.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNewColour.Image = (System.Drawing.Image)resources.GetObject("btnNewColour.Image");
            btnNewColour.Location = new System.Drawing.Point(15, 228);
            btnNewColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNewColour.Name = "btnNewColour";
            btnNewColour.Size = new System.Drawing.Size(41, 40);
            btnNewColour.TabIndex = 2;
            toolTip1.SetToolTip(btnNewColour, "Add new mapping");
            btnNewColour.UseVisualStyleBackColor = true;
            btnNewColour.Click += btnNewColour_Click;
            // 
            // tpgCreatures
            // 
            tpgCreatures.Controls.Add(grpCreaturesNotMapped);
            tpgCreatures.Controls.Add(grpCreatures);
            tpgCreatures.Location = new System.Drawing.Point(4, 24);
            tpgCreatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgCreatures.Name = "tpgCreatures";
            tpgCreatures.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgCreatures.Size = new System.Drawing.Size(637, 724);
            tpgCreatures.TabIndex = 1;
            tpgCreatures.Text = "Creatures";
            tpgCreatures.UseVisualStyleBackColor = true;
            // 
            // grpCreaturesNotMapped
            // 
            grpCreaturesNotMapped.Controls.Add(btnRefreshUnknownCreatures);
            grpCreaturesNotMapped.Controls.Add(btnCreaturesNotMappedAdd);
            grpCreaturesNotMapped.Controls.Add(lblCreaturesNotMapped);
            grpCreaturesNotMapped.Controls.Add(lblHeaderCreaturesNotMapped);
            grpCreaturesNotMapped.Controls.Add(lvwCreaturesNotMapped);
            grpCreaturesNotMapped.Location = new System.Drawing.Point(21, 402);
            grpCreaturesNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpCreaturesNotMapped.Name = "grpCreaturesNotMapped";
            grpCreaturesNotMapped.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpCreaturesNotMapped.Size = new System.Drawing.Size(593, 295);
            grpCreaturesNotMapped.TabIndex = 1;
            grpCreaturesNotMapped.TabStop = false;
            // 
            // btnRefreshUnknownCreatures
            // 
            btnRefreshUnknownCreatures.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRefreshUnknownCreatures.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefreshUnknownCreatures.Image = (System.Drawing.Image)resources.GetObject("btnRefreshUnknownCreatures.Image");
            btnRefreshUnknownCreatures.Location = new System.Drawing.Point(15, 245);
            btnRefreshUnknownCreatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRefreshUnknownCreatures.Name = "btnRefreshUnknownCreatures";
            btnRefreshUnknownCreatures.Size = new System.Drawing.Size(41, 40);
            btnRefreshUnknownCreatures.TabIndex = 5;
            toolTip1.SetToolTip(btnRefreshUnknownCreatures, "Add mapping");
            btnRefreshUnknownCreatures.UseVisualStyleBackColor = true;
            btnRefreshUnknownCreatures.Click += btnRefreshUnknownCreatures_Click;
            // 
            // btnCreaturesNotMappedAdd
            // 
            btnCreaturesNotMappedAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCreaturesNotMappedAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCreaturesNotMappedAdd.Enabled = false;
            btnCreaturesNotMappedAdd.Image = (System.Drawing.Image)resources.GetObject("btnCreaturesNotMappedAdd.Image");
            btnCreaturesNotMappedAdd.Location = new System.Drawing.Point(541, 245);
            btnCreaturesNotMappedAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCreaturesNotMappedAdd.Name = "btnCreaturesNotMappedAdd";
            btnCreaturesNotMappedAdd.Size = new System.Drawing.Size(41, 40);
            btnCreaturesNotMappedAdd.TabIndex = 3;
            toolTip1.SetToolTip(btnCreaturesNotMappedAdd, "Add mapping");
            btnCreaturesNotMappedAdd.UseVisualStyleBackColor = true;
            btnCreaturesNotMappedAdd.Click += btnCreaturesNotMappedAdd_Click;
            // 
            // lblCreaturesNotMapped
            // 
            lblCreaturesNotMapped.BackColor = System.Drawing.Color.Transparent;
            lblCreaturesNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCreaturesNotMapped.Location = new System.Drawing.Point(12, 18);
            lblCreaturesNotMapped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCreaturesNotMapped.Name = "lblCreaturesNotMapped";
            lblCreaturesNotMapped.Size = new System.Drawing.Size(231, 25);
            lblCreaturesNotMapped.TabIndex = 1;
            lblCreaturesNotMapped.Text = "Not Mapped";
            lblCreaturesNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderCreaturesNotMapped
            // 
            lblHeaderCreaturesNotMapped.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderCreaturesNotMapped.BackColor = System.Drawing.Color.Gainsboro;
            lblHeaderCreaturesNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderCreaturesNotMapped.Location = new System.Drawing.Point(-2, 7);
            lblHeaderCreaturesNotMapped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderCreaturesNotMapped.Name = "lblHeaderCreaturesNotMapped";
            lblHeaderCreaturesNotMapped.Size = new System.Drawing.Size(596, 7);
            lblHeaderCreaturesNotMapped.TabIndex = 0;
            lblHeaderCreaturesNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwCreaturesNotMapped
            // 
            lvwCreaturesNotMapped.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader12 });
            lvwCreaturesNotMapped.FullRowSelect = true;
            lvwCreaturesNotMapped.Location = new System.Drawing.Point(15, 52);
            lvwCreaturesNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwCreaturesNotMapped.Name = "lvwCreaturesNotMapped";
            lvwCreaturesNotMapped.Size = new System.Drawing.Size(565, 186);
            lvwCreaturesNotMapped.TabIndex = 2;
            lvwCreaturesNotMapped.UseCompatibleStateImageBehavior = false;
            lvwCreaturesNotMapped.View = System.Windows.Forms.View.Details;
            lvwCreaturesNotMapped.ColumnClick += lvwCreaturesNotMapped_ColumnClick;
            lvwCreaturesNotMapped.SelectedIndexChanged += lvwCreaturesNotMapped_SelectedIndexChanged;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Detected Class Name";
            columnHeader12.Width = 450;
            // 
            // grpCreatures
            // 
            grpCreatures.Controls.Add(label6);
            grpCreatures.Controls.Add(chkApplyFilterDinos);
            grpCreatures.Controls.Add(lblHeaderCreatures);
            grpCreatures.Controls.Add(txtCreatureFilter);
            grpCreatures.Controls.Add(lvwDinoClasses);
            grpCreatures.Controls.Add(btnEditDinoClass);
            grpCreatures.Controls.Add(btnAddDinoClass);
            grpCreatures.Controls.Add(btnRemoveDinoClass);
            grpCreatures.Location = new System.Drawing.Point(21, 12);
            grpCreatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpCreatures.Name = "grpCreatures";
            grpCreatures.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpCreatures.Size = new System.Drawing.Size(593, 383);
            grpCreatures.TabIndex = 0;
            grpCreatures.TabStop = false;
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(12, 18);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(231, 25);
            label6.TabIndex = 2;
            label6.Text = "Mapped";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkApplyFilterDinos
            // 
            chkApplyFilterDinos.Appearance = System.Windows.Forms.Appearance.Button;
            chkApplyFilterDinos.Cursor = System.Windows.Forms.Cursors.Hand;
            chkApplyFilterDinos.Image = (System.Drawing.Image)resources.GetObject("chkApplyFilterDinos.Image");
            chkApplyFilterDinos.Location = new System.Drawing.Point(496, 331);
            chkApplyFilterDinos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkApplyFilterDinos.Name = "chkApplyFilterDinos";
            chkApplyFilterDinos.Size = new System.Drawing.Size(41, 40);
            chkApplyFilterDinos.TabIndex = 7;
            chkApplyFilterDinos.UseVisualStyleBackColor = true;
            chkApplyFilterDinos.CheckedChanged += chkApplyFilterDinos_CheckedChanged;
            // 
            // lblHeaderCreatures
            // 
            lblHeaderCreatures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderCreatures.BackColor = System.Drawing.Color.Aqua;
            lblHeaderCreatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderCreatures.Location = new System.Drawing.Point(-2, 7);
            lblHeaderCreatures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderCreatures.Name = "lblHeaderCreatures";
            lblHeaderCreatures.Size = new System.Drawing.Size(596, 7);
            lblHeaderCreatures.TabIndex = 1;
            lblHeaderCreatures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCreatureFilter
            // 
            txtCreatureFilter.Location = new System.Drawing.Point(107, 339);
            txtCreatureFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCreatureFilter.Name = "txtCreatureFilter";
            txtCreatureFilter.Size = new System.Drawing.Size(381, 23);
            txtCreatureFilter.TabIndex = 6;
            txtCreatureFilter.TextChanged += txtCreatureFilter_TextChanged;
            txtCreatureFilter.Validating += txtCreatureFilter_Validating;
            // 
            // lvwDinoClasses
            // 
            lvwDinoClasses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvwDinoClasses_ClassName, lvwDinoClasses_DisplayName });
            lvwDinoClasses.FullRowSelect = true;
            lvwDinoClasses.Location = new System.Drawing.Point(15, 52);
            lvwDinoClasses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwDinoClasses.Name = "lvwDinoClasses";
            lvwDinoClasses.Size = new System.Drawing.Size(565, 272);
            lvwDinoClasses.TabIndex = 3;
            lvwDinoClasses.UseCompatibleStateImageBehavior = false;
            lvwDinoClasses.View = System.Windows.Forms.View.Details;
            lvwDinoClasses.ColumnClick += lvwDinoClasses_ColumnClick;
            lvwDinoClasses.SelectedIndexChanged += lvwDinoClasses_SelectedIndexChanged;
            // 
            // lvwDinoClasses_ClassName
            // 
            lvwDinoClasses_ClassName.DisplayIndex = 1;
            lvwDinoClasses_ClassName.Text = "Class Name";
            lvwDinoClasses_ClassName.Width = 244;
            // 
            // lvwDinoClasses_DisplayName
            // 
            lvwDinoClasses_DisplayName.DisplayIndex = 0;
            lvwDinoClasses_DisplayName.Text = "Display Name";
            lvwDinoClasses_DisplayName.Width = 205;
            // 
            // btnEditDinoClass
            // 
            btnEditDinoClass.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditDinoClass.Enabled = false;
            btnEditDinoClass.Image = (System.Drawing.Image)resources.GetObject("btnEditDinoClass.Image");
            btnEditDinoClass.Location = new System.Drawing.Point(542, 331);
            btnEditDinoClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditDinoClass.Name = "btnEditDinoClass";
            btnEditDinoClass.Size = new System.Drawing.Size(41, 40);
            btnEditDinoClass.TabIndex = 0;
            toolTip1.SetToolTip(btnEditDinoClass, "Edit display name");
            btnEditDinoClass.UseVisualStyleBackColor = true;
            btnEditDinoClass.Click += btnEditDinoClass_Click;
            // 
            // btnAddDinoClass
            // 
            btnAddDinoClass.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddDinoClass.Image = (System.Drawing.Image)resources.GetObject("btnAddDinoClass.Image");
            btnAddDinoClass.Location = new System.Drawing.Point(15, 331);
            btnAddDinoClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddDinoClass.Name = "btnAddDinoClass";
            btnAddDinoClass.Size = new System.Drawing.Size(41, 40);
            btnAddDinoClass.TabIndex = 4;
            toolTip1.SetToolTip(btnAddDinoClass, "Add new display name");
            btnAddDinoClass.UseVisualStyleBackColor = true;
            btnAddDinoClass.Click += btnAddDinoClass_Click;
            // 
            // btnRemoveDinoClass
            // 
            btnRemoveDinoClass.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveDinoClass.Enabled = false;
            btnRemoveDinoClass.Image = (System.Drawing.Image)resources.GetObject("btnRemoveDinoClass.Image");
            btnRemoveDinoClass.Location = new System.Drawing.Point(61, 331);
            btnRemoveDinoClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveDinoClass.Name = "btnRemoveDinoClass";
            btnRemoveDinoClass.Size = new System.Drawing.Size(41, 40);
            btnRemoveDinoClass.TabIndex = 5;
            toolTip1.SetToolTip(btnRemoveDinoClass, "Remove display name");
            btnRemoveDinoClass.UseVisualStyleBackColor = true;
            btnRemoveDinoClass.Click += btnRemoveDinoClass_Click;
            // 
            // tpgStructures
            // 
            tpgStructures.Controls.Add(grpStructuresNotMapped);
            tpgStructures.Controls.Add(grpStructures);
            tpgStructures.Location = new System.Drawing.Point(4, 24);
            tpgStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgStructures.Name = "tpgStructures";
            tpgStructures.Size = new System.Drawing.Size(637, 724);
            tpgStructures.TabIndex = 4;
            tpgStructures.Text = "Structures";
            tpgStructures.UseVisualStyleBackColor = true;
            // 
            // grpStructuresNotMapped
            // 
            grpStructuresNotMapped.Controls.Add(btnRefreshUnknownStructures);
            grpStructuresNotMapped.Controls.Add(btnStructuresNotMappedAdd);
            grpStructuresNotMapped.Controls.Add(lblStructuresNotMapped);
            grpStructuresNotMapped.Controls.Add(lblHeaderStructuresNotMapped);
            grpStructuresNotMapped.Controls.Add(lvwStructuresNotMapped);
            grpStructuresNotMapped.Location = new System.Drawing.Point(21, 402);
            grpStructuresNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpStructuresNotMapped.Name = "grpStructuresNotMapped";
            grpStructuresNotMapped.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpStructuresNotMapped.Size = new System.Drawing.Size(593, 295);
            grpStructuresNotMapped.TabIndex = 1;
            grpStructuresNotMapped.TabStop = false;
            // 
            // btnRefreshUnknownStructures
            // 
            btnRefreshUnknownStructures.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRefreshUnknownStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefreshUnknownStructures.Image = (System.Drawing.Image)resources.GetObject("btnRefreshUnknownStructures.Image");
            btnRefreshUnknownStructures.Location = new System.Drawing.Point(15, 245);
            btnRefreshUnknownStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRefreshUnknownStructures.Name = "btnRefreshUnknownStructures";
            btnRefreshUnknownStructures.Size = new System.Drawing.Size(41, 40);
            btnRefreshUnknownStructures.TabIndex = 5;
            toolTip1.SetToolTip(btnRefreshUnknownStructures, "Add mapping");
            btnRefreshUnknownStructures.UseVisualStyleBackColor = true;
            btnRefreshUnknownStructures.Click += btnRefreshUnknownStructures_Click;
            // 
            // btnStructuresNotMappedAdd
            // 
            btnStructuresNotMappedAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnStructuresNotMappedAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnStructuresNotMappedAdd.Enabled = false;
            btnStructuresNotMappedAdd.Image = (System.Drawing.Image)resources.GetObject("btnStructuresNotMappedAdd.Image");
            btnStructuresNotMappedAdd.Location = new System.Drawing.Point(541, 245);
            btnStructuresNotMappedAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStructuresNotMappedAdd.Name = "btnStructuresNotMappedAdd";
            btnStructuresNotMappedAdd.Size = new System.Drawing.Size(41, 40);
            btnStructuresNotMappedAdd.TabIndex = 3;
            toolTip1.SetToolTip(btnStructuresNotMappedAdd, "Add mapping");
            btnStructuresNotMappedAdd.UseVisualStyleBackColor = true;
            btnStructuresNotMappedAdd.Click += btnStructuresNotMappedAdd_Click;
            // 
            // lblStructuresNotMapped
            // 
            lblStructuresNotMapped.BackColor = System.Drawing.Color.Transparent;
            lblStructuresNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStructuresNotMapped.Location = new System.Drawing.Point(12, 18);
            lblStructuresNotMapped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStructuresNotMapped.Name = "lblStructuresNotMapped";
            lblStructuresNotMapped.Size = new System.Drawing.Size(231, 25);
            lblStructuresNotMapped.TabIndex = 1;
            lblStructuresNotMapped.Text = "Not Mapped";
            lblStructuresNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderStructuresNotMapped
            // 
            lblHeaderStructuresNotMapped.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderStructuresNotMapped.BackColor = System.Drawing.Color.Gainsboro;
            lblHeaderStructuresNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderStructuresNotMapped.Location = new System.Drawing.Point(-2, 7);
            lblHeaderStructuresNotMapped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderStructuresNotMapped.Name = "lblHeaderStructuresNotMapped";
            lblHeaderStructuresNotMapped.Size = new System.Drawing.Size(596, 7);
            lblHeaderStructuresNotMapped.TabIndex = 0;
            lblHeaderStructuresNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwStructuresNotMapped
            // 
            lvwStructuresNotMapped.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader10 });
            lvwStructuresNotMapped.FullRowSelect = true;
            lvwStructuresNotMapped.Location = new System.Drawing.Point(15, 52);
            lvwStructuresNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwStructuresNotMapped.Name = "lvwStructuresNotMapped";
            lvwStructuresNotMapped.Size = new System.Drawing.Size(565, 186);
            lvwStructuresNotMapped.TabIndex = 2;
            lvwStructuresNotMapped.UseCompatibleStateImageBehavior = false;
            lvwStructuresNotMapped.View = System.Windows.Forms.View.Details;
            lvwStructuresNotMapped.ColumnClick += lvwStructuresNotMapped_ColumnClick;
            lvwStructuresNotMapped.SelectedIndexChanged += lvwStructuresNotMapped_SelectedIndexChanged;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Detected Class Name";
            columnHeader10.Width = 450;
            // 
            // grpStructures
            // 
            grpStructures.Controls.Add(chkApplyFilterStructures);
            grpStructures.Controls.Add(lblHeaderStructures);
            grpStructures.Controls.Add(txtStructureFilter);
            grpStructures.Controls.Add(lvwStructureMap);
            grpStructures.Controls.Add(btnEditStructure);
            grpStructures.Controls.Add(btnAddStructure);
            grpStructures.Controls.Add(btnRemoveStructure);
            grpStructures.Location = new System.Drawing.Point(21, 12);
            grpStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpStructures.Name = "grpStructures";
            grpStructures.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpStructures.Size = new System.Drawing.Size(593, 383);
            grpStructures.TabIndex = 0;
            grpStructures.TabStop = false;
            // 
            // chkApplyFilterStructures
            // 
            chkApplyFilterStructures.Appearance = System.Windows.Forms.Appearance.Button;
            chkApplyFilterStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            chkApplyFilterStructures.Image = (System.Drawing.Image)resources.GetObject("chkApplyFilterStructures.Image");
            chkApplyFilterStructures.Location = new System.Drawing.Point(496, 331);
            chkApplyFilterStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkApplyFilterStructures.Name = "chkApplyFilterStructures";
            chkApplyFilterStructures.Size = new System.Drawing.Size(41, 40);
            chkApplyFilterStructures.TabIndex = 5;
            toolTip1.SetToolTip(chkApplyFilterStructures, "Apply/Remove filter");
            chkApplyFilterStructures.UseVisualStyleBackColor = true;
            chkApplyFilterStructures.CheckedChanged += chkApplyFilterStructures_CheckedChanged;
            // 
            // lblHeaderStructures
            // 
            lblHeaderStructures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderStructures.BackColor = System.Drawing.Color.Aqua;
            lblHeaderStructures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderStructures.Location = new System.Drawing.Point(-2, 7);
            lblHeaderStructures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderStructures.Name = "lblHeaderStructures";
            lblHeaderStructures.Size = new System.Drawing.Size(596, 7);
            lblHeaderStructures.TabIndex = 0;
            lblHeaderStructures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStructureFilter
            // 
            txtStructureFilter.Location = new System.Drawing.Point(107, 339);
            txtStructureFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtStructureFilter.Name = "txtStructureFilter";
            txtStructureFilter.Size = new System.Drawing.Size(381, 23);
            txtStructureFilter.TabIndex = 4;
            // 
            // lvwStructureMap
            // 
            lvwStructureMap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader5, columnHeader6 });
            lvwStructureMap.FullRowSelect = true;
            lvwStructureMap.Location = new System.Drawing.Point(15, 22);
            lvwStructureMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwStructureMap.Name = "lvwStructureMap";
            lvwStructureMap.Size = new System.Drawing.Size(565, 302);
            lvwStructureMap.TabIndex = 1;
            lvwStructureMap.UseCompatibleStateImageBehavior = false;
            lvwStructureMap.View = System.Windows.Forms.View.Details;
            lvwStructureMap.ColumnClick += lvwStructureMap_ColumnClick;
            lvwStructureMap.SelectedIndexChanged += lvwStructureMap_SelectedIndexChanged;
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 1;
            columnHeader5.Text = "Class Name";
            columnHeader5.Width = 262;
            // 
            // columnHeader6
            // 
            columnHeader6.DisplayIndex = 0;
            columnHeader6.Text = "Display Name";
            columnHeader6.Width = 193;
            // 
            // btnEditStructure
            // 
            btnEditStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditStructure.Enabled = false;
            btnEditStructure.Image = (System.Drawing.Image)resources.GetObject("btnEditStructure.Image");
            btnEditStructure.Location = new System.Drawing.Point(542, 331);
            btnEditStructure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditStructure.Name = "btnEditStructure";
            btnEditStructure.Size = new System.Drawing.Size(41, 40);
            btnEditStructure.TabIndex = 6;
            toolTip1.SetToolTip(btnEditStructure, "Edit display name");
            btnEditStructure.UseVisualStyleBackColor = true;
            btnEditStructure.Click += btnEditStructure_Click;
            // 
            // btnAddStructure
            // 
            btnAddStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddStructure.Image = (System.Drawing.Image)resources.GetObject("btnAddStructure.Image");
            btnAddStructure.Location = new System.Drawing.Point(15, 331);
            btnAddStructure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddStructure.Name = "btnAddStructure";
            btnAddStructure.Size = new System.Drawing.Size(41, 40);
            btnAddStructure.TabIndex = 2;
            toolTip1.SetToolTip(btnAddStructure, "Add new display name");
            btnAddStructure.UseVisualStyleBackColor = true;
            btnAddStructure.Click += btnAddStructure_Click;
            // 
            // btnRemoveStructure
            // 
            btnRemoveStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveStructure.Enabled = false;
            btnRemoveStructure.Image = (System.Drawing.Image)resources.GetObject("btnRemoveStructure.Image");
            btnRemoveStructure.Location = new System.Drawing.Point(61, 331);
            btnRemoveStructure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveStructure.Name = "btnRemoveStructure";
            btnRemoveStructure.Size = new System.Drawing.Size(41, 40);
            btnRemoveStructure.TabIndex = 3;
            toolTip1.SetToolTip(btnRemoveStructure, "Remove display name");
            btnRemoveStructure.UseVisualStyleBackColor = true;
            btnRemoveStructure.Click += btnRemoveStructure_Click;
            // 
            // tpgItems
            // 
            tpgItems.Controls.Add(grpItemsNotMatched);
            tpgItems.Controls.Add(grpItems);
            tpgItems.Location = new System.Drawing.Point(4, 24);
            tpgItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgItems.Name = "tpgItems";
            tpgItems.Size = new System.Drawing.Size(637, 724);
            tpgItems.TabIndex = 2;
            tpgItems.Text = "Items";
            tpgItems.UseVisualStyleBackColor = true;
            // 
            // grpItemsNotMatched
            // 
            grpItemsNotMatched.Controls.Add(btnRefreshUnknownItems);
            grpItemsNotMatched.Controls.Add(btnItemsNotMatchedAdd);
            grpItemsNotMatched.Controls.Add(lblItemsNotMatched);
            grpItemsNotMatched.Controls.Add(lblHeaderItemsNotMatched);
            grpItemsNotMatched.Controls.Add(lvwItemsNotMatched);
            grpItemsNotMatched.Location = new System.Drawing.Point(21, 402);
            grpItemsNotMatched.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpItemsNotMatched.Name = "grpItemsNotMatched";
            grpItemsNotMatched.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpItemsNotMatched.Size = new System.Drawing.Size(593, 295);
            grpItemsNotMatched.TabIndex = 1;
            grpItemsNotMatched.TabStop = false;
            // 
            // btnRefreshUnknownItems
            // 
            btnRefreshUnknownItems.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRefreshUnknownItems.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefreshUnknownItems.Image = (System.Drawing.Image)resources.GetObject("btnRefreshUnknownItems.Image");
            btnRefreshUnknownItems.Location = new System.Drawing.Point(15, 245);
            btnRefreshUnknownItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRefreshUnknownItems.Name = "btnRefreshUnknownItems";
            btnRefreshUnknownItems.Size = new System.Drawing.Size(41, 40);
            btnRefreshUnknownItems.TabIndex = 5;
            toolTip1.SetToolTip(btnRefreshUnknownItems, "Add mapping");
            btnRefreshUnknownItems.UseVisualStyleBackColor = true;
            btnRefreshUnknownItems.Click += btnRefreshUnknownItems_Click;
            // 
            // btnItemsNotMatchedAdd
            // 
            btnItemsNotMatchedAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnItemsNotMatchedAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnItemsNotMatchedAdd.Enabled = false;
            btnItemsNotMatchedAdd.Image = (System.Drawing.Image)resources.GetObject("btnItemsNotMatchedAdd.Image");
            btnItemsNotMatchedAdd.Location = new System.Drawing.Point(541, 245);
            btnItemsNotMatchedAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnItemsNotMatchedAdd.Name = "btnItemsNotMatchedAdd";
            btnItemsNotMatchedAdd.Size = new System.Drawing.Size(41, 40);
            btnItemsNotMatchedAdd.TabIndex = 3;
            toolTip1.SetToolTip(btnItemsNotMatchedAdd, "Add mapping");
            btnItemsNotMatchedAdd.UseVisualStyleBackColor = true;
            btnItemsNotMatchedAdd.Click += btnItemsNotMatchedAdd_Click;
            // 
            // lblItemsNotMatched
            // 
            lblItemsNotMatched.BackColor = System.Drawing.Color.Transparent;
            lblItemsNotMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblItemsNotMatched.Location = new System.Drawing.Point(12, 18);
            lblItemsNotMatched.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblItemsNotMatched.Name = "lblItemsNotMatched";
            lblItemsNotMatched.Size = new System.Drawing.Size(231, 25);
            lblItemsNotMatched.TabIndex = 1;
            lblItemsNotMatched.Text = "Not Mapped";
            lblItemsNotMatched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderItemsNotMatched
            // 
            lblHeaderItemsNotMatched.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderItemsNotMatched.BackColor = System.Drawing.Color.Gainsboro;
            lblHeaderItemsNotMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderItemsNotMatched.Location = new System.Drawing.Point(-2, 7);
            lblHeaderItemsNotMatched.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderItemsNotMatched.Name = "lblHeaderItemsNotMatched";
            lblHeaderItemsNotMatched.Size = new System.Drawing.Size(596, 7);
            lblHeaderItemsNotMatched.TabIndex = 0;
            lblHeaderItemsNotMatched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwItemsNotMatched
            // 
            lvwItemsNotMatched.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader11 });
            lvwItemsNotMatched.FullRowSelect = true;
            lvwItemsNotMatched.Location = new System.Drawing.Point(15, 52);
            lvwItemsNotMatched.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwItemsNotMatched.Name = "lvwItemsNotMatched";
            lvwItemsNotMatched.Size = new System.Drawing.Size(565, 186);
            lvwItemsNotMatched.TabIndex = 2;
            lvwItemsNotMatched.UseCompatibleStateImageBehavior = false;
            lvwItemsNotMatched.View = System.Windows.Forms.View.Details;
            lvwItemsNotMatched.ColumnClick += lvwItemsNotMatched_ColumnClick;
            lvwItemsNotMatched.SelectedIndexChanged += lvwItemsNotMatched_SelectedIndexChanged;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Detected Class Name";
            columnHeader11.Width = 450;
            // 
            // grpItems
            // 
            grpItems.Controls.Add(chkApplyFilterItems);
            grpItems.Controls.Add(lblHeaderItems);
            grpItems.Controls.Add(txtItemFilter);
            grpItems.Controls.Add(lvwItemMap);
            grpItems.Controls.Add(btnEditItem);
            grpItems.Controls.Add(btnAddItem);
            grpItems.Controls.Add(btnRemoveItem);
            grpItems.Location = new System.Drawing.Point(21, 12);
            grpItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpItems.Name = "grpItems";
            grpItems.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpItems.Size = new System.Drawing.Size(593, 383);
            grpItems.TabIndex = 0;
            grpItems.TabStop = false;
            // 
            // chkApplyFilterItems
            // 
            chkApplyFilterItems.Appearance = System.Windows.Forms.Appearance.Button;
            chkApplyFilterItems.Cursor = System.Windows.Forms.Cursors.Hand;
            chkApplyFilterItems.Image = (System.Drawing.Image)resources.GetObject("chkApplyFilterItems.Image");
            chkApplyFilterItems.Location = new System.Drawing.Point(496, 331);
            chkApplyFilterItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkApplyFilterItems.Name = "chkApplyFilterItems";
            chkApplyFilterItems.Size = new System.Drawing.Size(41, 40);
            chkApplyFilterItems.TabIndex = 5;
            chkApplyFilterItems.UseVisualStyleBackColor = true;
            chkApplyFilterItems.CheckedChanged += chkApplyFilterItems_CheckedChanged;
            // 
            // lblHeaderItems
            // 
            lblHeaderItems.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderItems.BackColor = System.Drawing.Color.Aqua;
            lblHeaderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderItems.Location = new System.Drawing.Point(-2, 7);
            lblHeaderItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderItems.Name = "lblHeaderItems";
            lblHeaderItems.Size = new System.Drawing.Size(596, 7);
            lblHeaderItems.TabIndex = 0;
            lblHeaderItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtItemFilter
            // 
            txtItemFilter.Location = new System.Drawing.Point(107, 339);
            txtItemFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtItemFilter.Name = "txtItemFilter";
            txtItemFilter.Size = new System.Drawing.Size(381, 23);
            txtItemFilter.TabIndex = 4;
            txtItemFilter.TextChanged += txtItemFilter_TextChanged;
            txtItemFilter.Validating += txtItemFilter_Validating;
            // 
            // lvwItemMap
            // 
            lvwItemMap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader3, columnHeader1, columnHeader2 });
            lvwItemMap.FullRowSelect = true;
            lvwItemMap.Location = new System.Drawing.Point(15, 22);
            lvwItemMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwItemMap.Name = "lvwItemMap";
            lvwItemMap.Size = new System.Drawing.Size(565, 302);
            lvwItemMap.TabIndex = 1;
            lvwItemMap.UseCompatibleStateImageBehavior = false;
            lvwItemMap.View = System.Windows.Forms.View.Details;
            lvwItemMap.ColumnClick += lvwItemMap_ColumnClick;
            lvwItemMap.SelectedIndexChanged += lvwItemMap_SelectedIndexChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Category";
            columnHeader3.Width = 119;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 2;
            columnHeader1.Text = "Class Name";
            columnHeader1.Width = 172;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 1;
            columnHeader2.Text = "Display Name";
            columnHeader2.Width = 179;
            // 
            // btnEditItem
            // 
            btnEditItem.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditItem.Enabled = false;
            btnEditItem.Image = (System.Drawing.Image)resources.GetObject("btnEditItem.Image");
            btnEditItem.Location = new System.Drawing.Point(542, 331);
            btnEditItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new System.Drawing.Size(41, 40);
            btnEditItem.TabIndex = 6;
            toolTip1.SetToolTip(btnEditItem, "Edit display name");
            btnEditItem.UseVisualStyleBackColor = true;
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddItem.Image = (System.Drawing.Image)resources.GetObject("btnAddItem.Image");
            btnAddItem.Location = new System.Drawing.Point(15, 331);
            btnAddItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new System.Drawing.Size(41, 40);
            btnAddItem.TabIndex = 2;
            toolTip1.SetToolTip(btnAddItem, "Add new display name");
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveItem.Enabled = false;
            btnRemoveItem.Image = (System.Drawing.Image)resources.GetObject("btnRemoveItem.Image");
            btnRemoveItem.Location = new System.Drawing.Point(61, 331);
            btnRemoveItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new System.Drawing.Size(41, 40);
            btnRemoveItem.TabIndex = 3;
            toolTip1.SetToolTip(btnRemoveItem, "Remove display name");
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // tpgExport
            // 
            tpgExport.Controls.Add(grpJsonExport);
            tpgExport.Controls.Add(grpContentPack);
            tpgExport.Location = new System.Drawing.Point(4, 24);
            tpgExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgExport.Name = "tpgExport";
            tpgExport.Size = new System.Drawing.Size(637, 724);
            tpgExport.TabIndex = 6;
            tpgExport.Text = "Export";
            tpgExport.UseVisualStyleBackColor = true;
            // 
            // grpJsonExport
            // 
            grpJsonExport.Controls.Add(label7);
            grpJsonExport.Controls.Add(btnJsonExportMapStructures);
            grpJsonExport.Controls.Add(lblExportPlayerStructures);
            grpJsonExport.Controls.Add(btnJsonExportPlayerStructures);
            grpJsonExport.Controls.Add(lblExportTamed);
            grpJsonExport.Controls.Add(btnJsonExportTamed);
            grpJsonExport.Controls.Add(lblExportPlayers);
            grpJsonExport.Controls.Add(btnJsonExportPlayers);
            grpJsonExport.Controls.Add(lblExportTribes);
            grpJsonExport.Controls.Add(btnJsonExportTribes);
            grpJsonExport.Controls.Add(lblExportWild);
            grpJsonExport.Controls.Add(btnJsonExportWild);
            grpJsonExport.Controls.Add(lblExportAll);
            grpJsonExport.Controls.Add(btnJsonExportAll);
            grpJsonExport.Controls.Add(lblHeaderJsonExport);
            grpJsonExport.Controls.Add(lblJsonFileExport);
            grpJsonExport.Location = new System.Drawing.Point(26, 440);
            grpJsonExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpJsonExport.Name = "grpJsonExport";
            grpJsonExport.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpJsonExport.Size = new System.Drawing.Size(584, 248);
            grpJsonExport.TabIndex = 1;
            grpJsonExport.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(338, 207);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(93, 13);
            label7.TabIndex = 14;
            label7.Text = "Map Structures";
            // 
            // btnJsonExportMapStructures
            // 
            btnJsonExportMapStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJsonExportMapStructures.Image = (System.Drawing.Image)resources.GetObject("btnJsonExportMapStructures.Image");
            btnJsonExportMapStructures.Location = new System.Drawing.Point(494, 197);
            btnJsonExportMapStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnJsonExportMapStructures.Name = "btnJsonExportMapStructures";
            btnJsonExportMapStructures.Size = new System.Drawing.Size(41, 40);
            btnJsonExportMapStructures.TabIndex = 15;
            toolTip1.SetToolTip(btnJsonExportMapStructures, "Export tamed data");
            btnJsonExportMapStructures.UseVisualStyleBackColor = true;
            btnJsonExportMapStructures.Click += btnJsonExportMapStructures_Click;
            // 
            // lblExportPlayerStructures
            // 
            lblExportPlayerStructures.AutoSize = true;
            lblExportPlayerStructures.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblExportPlayerStructures.Location = new System.Drawing.Point(338, 157);
            lblExportPlayerStructures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExportPlayerStructures.Name = "lblExportPlayerStructures";
            lblExportPlayerStructures.Size = new System.Drawing.Size(104, 13);
            lblExportPlayerStructures.TabIndex = 12;
            lblExportPlayerStructures.Text = "Player Structures";
            // 
            // btnJsonExportPlayerStructures
            // 
            btnJsonExportPlayerStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJsonExportPlayerStructures.Image = (System.Drawing.Image)resources.GetObject("btnJsonExportPlayerStructures.Image");
            btnJsonExportPlayerStructures.Location = new System.Drawing.Point(495, 147);
            btnJsonExportPlayerStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnJsonExportPlayerStructures.Name = "btnJsonExportPlayerStructures";
            btnJsonExportPlayerStructures.Size = new System.Drawing.Size(41, 40);
            btnJsonExportPlayerStructures.TabIndex = 13;
            toolTip1.SetToolTip(btnJsonExportPlayerStructures, "Export structure data");
            btnJsonExportPlayerStructures.UseVisualStyleBackColor = true;
            btnJsonExportPlayerStructures.Click += btnJsonExportPlayerStructures_Click;
            // 
            // lblExportTamed
            // 
            lblExportTamed.AutoSize = true;
            lblExportTamed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblExportTamed.Location = new System.Drawing.Point(22, 157);
            lblExportTamed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExportTamed.Name = "lblExportTamed";
            lblExportTamed.Size = new System.Drawing.Size(121, 13);
            lblExportTamed.TabIndex = 6;
            lblExportTamed.Text = "All Tamed Creatures";
            // 
            // btnJsonExportTamed
            // 
            btnJsonExportTamed.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJsonExportTamed.Image = (System.Drawing.Image)resources.GetObject("btnJsonExportTamed.Image");
            btnJsonExportTamed.Location = new System.Drawing.Point(178, 147);
            btnJsonExportTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnJsonExportTamed.Name = "btnJsonExportTamed";
            btnJsonExportTamed.Size = new System.Drawing.Size(41, 40);
            btnJsonExportTamed.TabIndex = 7;
            toolTip1.SetToolTip(btnJsonExportTamed, "Export tamed data");
            btnJsonExportTamed.UseVisualStyleBackColor = true;
            btnJsonExportTamed.Click += btnJsonExportTamed_Click;
            // 
            // lblExportPlayers
            // 
            lblExportPlayers.AutoSize = true;
            lblExportPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblExportPlayers.Location = new System.Drawing.Point(338, 105);
            lblExportPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExportPlayers.Name = "lblExportPlayers";
            lblExportPlayers.Size = new System.Drawing.Size(73, 13);
            lblExportPlayers.TabIndex = 10;
            lblExportPlayers.Text = "Player Data";
            // 
            // btnJsonExportPlayers
            // 
            btnJsonExportPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJsonExportPlayers.Image = (System.Drawing.Image)resources.GetObject("btnJsonExportPlayers.Image");
            btnJsonExportPlayers.Location = new System.Drawing.Point(495, 97);
            btnJsonExportPlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnJsonExportPlayers.Name = "btnJsonExportPlayers";
            btnJsonExportPlayers.Size = new System.Drawing.Size(41, 40);
            btnJsonExportPlayers.TabIndex = 11;
            toolTip1.SetToolTip(btnJsonExportPlayers, "Export player data");
            btnJsonExportPlayers.UseVisualStyleBackColor = true;
            btnJsonExportPlayers.Click += btnJsonExportPlayers_Click;
            // 
            // lblExportTribes
            // 
            lblExportTribes.AutoSize = true;
            lblExportTribes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblExportTribes.Location = new System.Drawing.Point(338, 60);
            lblExportTribes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExportTribes.Name = "lblExportTribes";
            lblExportTribes.Size = new System.Drawing.Size(67, 13);
            lblExportTribes.TabIndex = 8;
            lblExportTribes.Text = "Tribe Data";
            // 
            // btnJsonExportTribes
            // 
            btnJsonExportTribes.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJsonExportTribes.Image = (System.Drawing.Image)resources.GetObject("btnJsonExportTribes.Image");
            btnJsonExportTribes.Location = new System.Drawing.Point(495, 51);
            btnJsonExportTribes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnJsonExportTribes.Name = "btnJsonExportTribes";
            btnJsonExportTribes.Size = new System.Drawing.Size(41, 40);
            btnJsonExportTribes.TabIndex = 9;
            toolTip1.SetToolTip(btnJsonExportTribes, "Export tribe data");
            btnJsonExportTribes.UseVisualStyleBackColor = true;
            btnJsonExportTribes.Click += btnJsonExportTribes_Click;
            // 
            // lblExportWild
            // 
            lblExportWild.AutoSize = true;
            lblExportWild.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblExportWild.Location = new System.Drawing.Point(22, 105);
            lblExportWild.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExportWild.Name = "lblExportWild";
            lblExportWild.Size = new System.Drawing.Size(108, 13);
            lblExportWild.TabIndex = 4;
            lblExportWild.Text = "All Wild Creatures";
            // 
            // btnJsonExportWild
            // 
            btnJsonExportWild.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJsonExportWild.Image = (System.Drawing.Image)resources.GetObject("btnJsonExportWild.Image");
            btnJsonExportWild.Location = new System.Drawing.Point(178, 97);
            btnJsonExportWild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnJsonExportWild.Name = "btnJsonExportWild";
            btnJsonExportWild.Size = new System.Drawing.Size(41, 40);
            btnJsonExportWild.TabIndex = 5;
            toolTip1.SetToolTip(btnJsonExportWild, "Export wild data");
            btnJsonExportWild.UseVisualStyleBackColor = true;
            btnJsonExportWild.Click += btnJsonExportWild_Click;
            // 
            // lblExportAll
            // 
            lblExportAll.AutoSize = true;
            lblExportAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblExportAll.Location = new System.Drawing.Point(22, 60);
            lblExportAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExportAll.Name = "lblExportAll";
            lblExportAll.Size = new System.Drawing.Size(77, 13);
            lblExportAll.TabIndex = 2;
            lblExportAll.Text = "All Available";
            // 
            // btnJsonExportAll
            // 
            btnJsonExportAll.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJsonExportAll.Image = (System.Drawing.Image)resources.GetObject("btnJsonExportAll.Image");
            btnJsonExportAll.Location = new System.Drawing.Point(178, 51);
            btnJsonExportAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnJsonExportAll.Name = "btnJsonExportAll";
            btnJsonExportAll.Size = new System.Drawing.Size(41, 40);
            btnJsonExportAll.TabIndex = 3;
            toolTip1.SetToolTip(btnJsonExportAll, "Export all data");
            btnJsonExportAll.UseVisualStyleBackColor = true;
            btnJsonExportAll.Click += btnJsonExportAll_Click;
            // 
            // lblHeaderJsonExport
            // 
            lblHeaderJsonExport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderJsonExport.BackColor = System.Drawing.Color.Aqua;
            lblHeaderJsonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderJsonExport.Location = new System.Drawing.Point(0, 7);
            lblHeaderJsonExport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderJsonExport.Name = "lblHeaderJsonExport";
            lblHeaderJsonExport.Size = new System.Drawing.Size(587, 7);
            lblHeaderJsonExport.TabIndex = 0;
            lblHeaderJsonExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJsonFileExport
            // 
            lblJsonFileExport.BackColor = System.Drawing.Color.Transparent;
            lblJsonFileExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblJsonFileExport.Location = new System.Drawing.Point(9, 16);
            lblJsonFileExport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblJsonFileExport.Name = "lblJsonFileExport";
            lblJsonFileExport.Size = new System.Drawing.Size(231, 25);
            lblJsonFileExport.TabIndex = 1;
            lblJsonFileExport.Text = "JSON File Export";
            lblJsonFileExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpContentPack
            // 
            grpContentPack.Controls.Add(chkDroppedItems);
            grpContentPack.Controls.Add(chkStructureContents);
            grpContentPack.Controls.Add(chkStructureLocations);
            grpContentPack.Controls.Add(btnExportContentPack);
            grpContentPack.Controls.Add(udExportRadius);
            grpContentPack.Controls.Add(udExportLon);
            grpContentPack.Controls.Add(udExportLat);
            grpContentPack.Controls.Add(lblFilterRad);
            grpContentPack.Controls.Add(cboExportPlayer);
            grpContentPack.Controls.Add(cboExportTribe);
            grpContentPack.Controls.Add(lblFilterLon);
            grpContentPack.Controls.Add(lblFilterLat);
            grpContentPack.Controls.Add(lblFilterPlayer);
            grpContentPack.Controls.Add(lblFilterTribe);
            grpContentPack.Controls.Add(lblContentPackFilters);
            grpContentPack.Controls.Add(chkPlayerStructures);
            grpContentPack.Controls.Add(chkTamedCreatures);
            grpContentPack.Controls.Add(chkWildCreatures);
            grpContentPack.Controls.Add(lblHeaderConteentPack);
            grpContentPack.Controls.Add(lblContentPackOptions);
            grpContentPack.Location = new System.Drawing.Point(26, 13);
            grpContentPack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpContentPack.Name = "grpContentPack";
            grpContentPack.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpContentPack.Size = new System.Drawing.Size(584, 420);
            grpContentPack.TabIndex = 0;
            grpContentPack.TabStop = false;
            // 
            // chkDroppedItems
            // 
            chkDroppedItems.AutoSize = true;
            chkDroppedItems.Location = new System.Drawing.Point(33, 111);
            chkDroppedItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkDroppedItems.Name = "chkDroppedItems";
            chkDroppedItems.Size = new System.Drawing.Size(104, 19);
            chkDroppedItems.TabIndex = 4;
            chkDroppedItems.Text = "Dropped Items";
            chkDroppedItems.UseVisualStyleBackColor = true;
            // 
            // chkStructureContents
            // 
            chkStructureContents.AutoSize = true;
            chkStructureContents.Location = new System.Drawing.Point(33, 84);
            chkStructureContents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkStructureContents.Name = "chkStructureContents";
            chkStructureContents.Size = new System.Drawing.Size(152, 19);
            chkStructureContents.TabIndex = 3;
            chkStructureContents.Text = "Map Structure Contents";
            chkStructureContents.UseVisualStyleBackColor = true;
            // 
            // chkStructureLocations
            // 
            chkStructureLocations.AutoSize = true;
            chkStructureLocations.Checked = true;
            chkStructureLocations.CheckState = System.Windows.Forms.CheckState.Checked;
            chkStructureLocations.Location = new System.Drawing.Point(33, 58);
            chkStructureLocations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkStructureLocations.Name = "chkStructureLocations";
            chkStructureLocations.Size = new System.Drawing.Size(155, 19);
            chkStructureLocations.TabIndex = 2;
            chkStructureLocations.Text = "Map Structure Locations";
            chkStructureLocations.UseVisualStyleBackColor = true;
            // 
            // btnExportContentPack
            // 
            btnExportContentPack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExportContentPack.Image = (System.Drawing.Image)resources.GetObject("btnExportContentPack.Image");
            btnExportContentPack.Location = new System.Drawing.Point(495, 361);
            btnExportContentPack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExportContentPack.Name = "btnExportContentPack";
            btnExportContentPack.Size = new System.Drawing.Size(41, 40);
            btnExportContentPack.TabIndex = 20;
            toolTip1.SetToolTip(btnExportContentPack, "Export content pack");
            btnExportContentPack.UseVisualStyleBackColor = true;
            btnExportContentPack.Click += btnExportContentPack_Click;
            // 
            // udExportRadius
            // 
            udExportRadius.DecimalPlaces = 2;
            udExportRadius.Location = new System.Drawing.Point(144, 372);
            udExportRadius.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udExportRadius.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            udExportRadius.Name = "udExportRadius";
            udExportRadius.Size = new System.Drawing.Size(75, 23);
            udExportRadius.TabIndex = 19;
            udExportRadius.Value = new decimal(new int[] { 10000, 0, 0, 131072 });
            // 
            // udExportLon
            // 
            udExportLon.DecimalPlaces = 2;
            udExportLon.Location = new System.Drawing.Point(144, 332);
            udExportLon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udExportLon.Name = "udExportLon";
            udExportLon.Size = new System.Drawing.Size(75, 23);
            udExportLon.TabIndex = 17;
            udExportLon.Value = new decimal(new int[] { 5000, 0, 0, 131072 });
            // 
            // udExportLat
            // 
            udExportLat.DecimalPlaces = 2;
            udExportLat.Location = new System.Drawing.Point(144, 294);
            udExportLat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udExportLat.Name = "udExportLat";
            udExportLat.Size = new System.Drawing.Size(75, 23);
            udExportLat.TabIndex = 15;
            udExportLat.Value = new decimal(new int[] { 5000, 0, 0, 131072 });
            // 
            // lblFilterRad
            // 
            lblFilterRad.AutoSize = true;
            lblFilterRad.Location = new System.Drawing.Point(29, 372);
            lblFilterRad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFilterRad.Name = "lblFilterRad";
            lblFilterRad.Size = new System.Drawing.Size(45, 15);
            lblFilterRad.TabIndex = 18;
            lblFilterRad.Text = "Radius:";
            // 
            // cboExportPlayer
            // 
            cboExportPlayer.FormattingEnabled = true;
            cboExportPlayer.Location = new System.Drawing.Point(144, 253);
            cboExportPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboExportPlayer.Name = "cboExportPlayer";
            cboExportPlayer.Size = new System.Drawing.Size(390, 23);
            cboExportPlayer.TabIndex = 13;
            // 
            // cboExportTribe
            // 
            cboExportTribe.FormattingEnabled = true;
            cboExportTribe.Location = new System.Drawing.Point(144, 216);
            cboExportTribe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboExportTribe.Name = "cboExportTribe";
            cboExportTribe.Size = new System.Drawing.Size(390, 23);
            cboExportTribe.TabIndex = 11;
            cboExportTribe.SelectedIndexChanged += cboExportTribe_SelectedIndexChanged;
            // 
            // lblFilterLon
            // 
            lblFilterLon.AutoSize = true;
            lblFilterLon.Location = new System.Drawing.Point(29, 332);
            lblFilterLon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFilterLon.Name = "lblFilterLon";
            lblFilterLon.Size = new System.Drawing.Size(64, 15);
            lblFilterLon.TabIndex = 16;
            lblFilterLon.Text = "Longitude:";
            // 
            // lblFilterLat
            // 
            lblFilterLat.AutoSize = true;
            lblFilterLat.Location = new System.Drawing.Point(29, 294);
            lblFilterLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFilterLat.Name = "lblFilterLat";
            lblFilterLat.Size = new System.Drawing.Size(53, 15);
            lblFilterLat.TabIndex = 14;
            lblFilterLat.Text = "Latitude:";
            // 
            // lblFilterPlayer
            // 
            lblFilterPlayer.AutoSize = true;
            lblFilterPlayer.Location = new System.Drawing.Point(29, 256);
            lblFilterPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFilterPlayer.Name = "lblFilterPlayer";
            lblFilterPlayer.Size = new System.Drawing.Size(89, 15);
            lblFilterPlayer.TabIndex = 12;
            lblFilterPlayer.Text = "Selected Player:";
            // 
            // lblFilterTribe
            // 
            lblFilterTribe.AutoSize = true;
            lblFilterTribe.Location = new System.Drawing.Point(29, 216);
            lblFilterTribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFilterTribe.Name = "lblFilterTribe";
            lblFilterTribe.Size = new System.Drawing.Size(82, 15);
            lblFilterTribe.TabIndex = 10;
            lblFilterTribe.Text = "Selected Tribe:";
            // 
            // lblContentPackFilters
            // 
            lblContentPackFilters.BackColor = System.Drawing.Color.Transparent;
            lblContentPackFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblContentPackFilters.Location = new System.Drawing.Point(9, 180);
            lblContentPackFilters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblContentPackFilters.Name = "lblContentPackFilters";
            lblContentPackFilters.Size = new System.Drawing.Size(231, 25);
            lblContentPackFilters.TabIndex = 9;
            lblContentPackFilters.Text = "Content Pack Filters";
            lblContentPackFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkPlayerStructures
            // 
            chkPlayerStructures.AutoSize = true;
            chkPlayerStructures.Checked = true;
            chkPlayerStructures.CheckState = System.Windows.Forms.CheckState.Checked;
            chkPlayerStructures.Location = new System.Drawing.Point(348, 111);
            chkPlayerStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkPlayerStructures.Name = "chkPlayerStructures";
            chkPlayerStructures.Size = new System.Drawing.Size(114, 19);
            chkPlayerStructures.TabIndex = 8;
            chkPlayerStructures.Text = "Player Structures";
            chkPlayerStructures.UseVisualStyleBackColor = true;
            // 
            // chkTamedCreatures
            // 
            chkTamedCreatures.AutoSize = true;
            chkTamedCreatures.Checked = true;
            chkTamedCreatures.CheckState = System.Windows.Forms.CheckState.Checked;
            chkTamedCreatures.Location = new System.Drawing.Point(348, 58);
            chkTamedCreatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkTamedCreatures.Name = "chkTamedCreatures";
            chkTamedCreatures.Size = new System.Drawing.Size(114, 19);
            chkTamedCreatures.TabIndex = 6;
            chkTamedCreatures.Text = "Tamed Creatures";
            chkTamedCreatures.UseVisualStyleBackColor = true;
            // 
            // chkWildCreatures
            // 
            chkWildCreatures.AutoSize = true;
            chkWildCreatures.Location = new System.Drawing.Point(348, 84);
            chkWildCreatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkWildCreatures.Name = "chkWildCreatures";
            chkWildCreatures.Size = new System.Drawing.Size(103, 19);
            chkWildCreatures.TabIndex = 7;
            chkWildCreatures.Text = "Wild Creatures";
            chkWildCreatures.UseVisualStyleBackColor = true;
            // 
            // lblHeaderConteentPack
            // 
            lblHeaderConteentPack.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderConteentPack.BackColor = System.Drawing.Color.Aqua;
            lblHeaderConteentPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderConteentPack.Location = new System.Drawing.Point(0, 7);
            lblHeaderConteentPack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderConteentPack.Name = "lblHeaderConteentPack";
            lblHeaderConteentPack.Size = new System.Drawing.Size(587, 7);
            lblHeaderConteentPack.TabIndex = 0;
            lblHeaderConteentPack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContentPackOptions
            // 
            lblContentPackOptions.BackColor = System.Drawing.Color.Transparent;
            lblContentPackOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblContentPackOptions.Location = new System.Drawing.Point(9, 16);
            lblContentPackOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblContentPackOptions.Name = "lblContentPackOptions";
            lblContentPackOptions.Size = new System.Drawing.Size(231, 25);
            lblContentPackOptions.TabIndex = 1;
            lblContentPackOptions.Text = "Content Pack Export Options";
            lblContentPackOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpgRestService
            // 
            tpgRestService.Controls.Add(grpService);
            tpgRestService.Controls.Add(grpClientAccess);
            tpgRestService.Location = new System.Drawing.Point(4, 24);
            tpgRestService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgRestService.Name = "tpgRestService";
            tpgRestService.Size = new System.Drawing.Size(637, 724);
            tpgRestService.TabIndex = 7;
            tpgRestService.Text = "REST Service";
            tpgRestService.UseVisualStyleBackColor = true;
            // 
            // grpService
            // 
            grpService.Controls.Add(chkAutostartService);
            grpService.Controls.Add(udServicePort);
            grpService.Controls.Add(lblServiceStatus);
            grpService.Controls.Add(txtServiceStatus);
            grpService.Controls.Add(btnClearServiceLog);
            grpService.Controls.Add(txtServiceLog);
            grpService.Controls.Add(lblServiceActivity);
            grpService.Controls.Add(btnStopService);
            grpService.Controls.Add(btnStartService);
            grpService.Controls.Add(lblService);
            grpService.Controls.Add(lblHeaderService);
            grpService.Controls.Add(lblServicePort);
            grpService.Enabled = false;
            grpService.Location = new System.Drawing.Point(30, 18);
            grpService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpService.Name = "grpService";
            grpService.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpService.Size = new System.Drawing.Size(579, 327);
            grpService.TabIndex = 0;
            grpService.TabStop = false;
            // 
            // chkAutostartService
            // 
            chkAutostartService.AutoSize = true;
            chkAutostartService.Location = new System.Drawing.Point(429, 77);
            chkAutostartService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkAutostartService.Name = "chkAutostartService";
            chkAutostartService.Size = new System.Drawing.Size(129, 19);
            chkAutostartService.TabIndex = 7;
            chkAutostartService.Text = "Auto Start with ASV";
            chkAutostartService.UseVisualStyleBackColor = true;
            // 
            // udServicePort
            // 
            udServicePort.Location = new System.Drawing.Point(251, 74);
            udServicePort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udServicePort.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            udServicePort.Name = "udServicePort";
            udServicePort.Size = new System.Drawing.Size(70, 23);
            udServicePort.TabIndex = 4;
            udServicePort.Value = new decimal(new int[] { 8081, 0, 0, 0 });
            // 
            // lblServiceStatus
            // 
            lblServiceStatus.AutoSize = true;
            lblServiceStatus.BackColor = System.Drawing.Color.Transparent;
            lblServiceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblServiceStatus.Location = new System.Drawing.Point(12, 45);
            lblServiceStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblServiceStatus.Name = "lblServiceStatus";
            lblServiceStatus.Size = new System.Drawing.Size(84, 15);
            lblServiceStatus.TabIndex = 1;
            lblServiceStatus.Text = "Service Status";
            lblServiceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtServiceStatus
            // 
            txtServiceStatus.Location = new System.Drawing.Point(15, 74);
            txtServiceStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtServiceStatus.Name = "txtServiceStatus";
            txtServiceStatus.ReadOnly = true;
            txtServiceStatus.Size = new System.Drawing.Size(227, 23);
            txtServiceStatus.TabIndex = 2;
            txtServiceStatus.Text = "No Map Loaded";
            // 
            // btnClearServiceLog
            // 
            btnClearServiceLog.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClearServiceLog.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClearServiceLog.Enabled = false;
            btnClearServiceLog.Image = (System.Drawing.Image)resources.GetObject("btnClearServiceLog.Image");
            btnClearServiceLog.Location = new System.Drawing.Point(525, 275);
            btnClearServiceLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClearServiceLog.Name = "btnClearServiceLog";
            btnClearServiceLog.Size = new System.Drawing.Size(41, 40);
            btnClearServiceLog.TabIndex = 10;
            toolTip1.SetToolTip(btnClearServiceLog, "Clear activity log");
            btnClearServiceLog.UseVisualStyleBackColor = true;
            // 
            // txtServiceLog
            // 
            txtServiceLog.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtServiceLog.Location = new System.Drawing.Point(15, 141);
            txtServiceLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtServiceLog.Multiline = true;
            txtServiceLog.Name = "txtServiceLog";
            txtServiceLog.ReadOnly = true;
            txtServiceLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtServiceLog.Size = new System.Drawing.Size(550, 125);
            txtServiceLog.TabIndex = 9;
            // 
            // lblServiceActivity
            // 
            lblServiceActivity.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblServiceActivity.BackColor = System.Drawing.Color.Transparent;
            lblServiceActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblServiceActivity.Location = new System.Drawing.Point(12, 110);
            lblServiceActivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblServiceActivity.Name = "lblServiceActivity";
            lblServiceActivity.Size = new System.Drawing.Size(231, 25);
            lblServiceActivity.TabIndex = 8;
            lblServiceActivity.Text = "Service Activity";
            lblServiceActivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStopService
            // 
            btnStopService.Cursor = System.Windows.Forms.Cursors.Hand;
            btnStopService.Enabled = false;
            btnStopService.Image = (System.Drawing.Image)resources.GetObject("btnStopService.Image");
            btnStopService.Location = new System.Drawing.Point(331, 65);
            btnStopService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStopService.Name = "btnStopService";
            btnStopService.Size = new System.Drawing.Size(41, 40);
            btnStopService.TabIndex = 5;
            toolTip1.SetToolTip(btnStopService, "Edit display name");
            btnStopService.UseVisualStyleBackColor = true;
            // 
            // btnStartService
            // 
            btnStartService.Cursor = System.Windows.Forms.Cursors.Hand;
            btnStartService.Enabled = false;
            btnStartService.Image = (System.Drawing.Image)resources.GetObject("btnStartService.Image");
            btnStartService.Location = new System.Drawing.Point(379, 65);
            btnStartService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStartService.Name = "btnStartService";
            btnStartService.Size = new System.Drawing.Size(41, 40);
            btnStartService.TabIndex = 6;
            toolTip1.SetToolTip(btnStartService, "Edit display name");
            btnStartService.UseVisualStyleBackColor = true;
            // 
            // lblService
            // 
            lblService.BackColor = System.Drawing.Color.Transparent;
            lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblService.Location = new System.Drawing.Point(12, 18);
            lblService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblService.Name = "lblService";
            lblService.Size = new System.Drawing.Size(231, 25);
            lblService.TabIndex = 0;
            lblService.Text = "Service";
            lblService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeaderService
            // 
            lblHeaderService.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderService.BackColor = System.Drawing.Color.Gainsboro;
            lblHeaderService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderService.Location = new System.Drawing.Point(-2, 7);
            lblHeaderService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderService.Name = "lblHeaderService";
            lblHeaderService.Size = new System.Drawing.Size(582, 7);
            lblHeaderService.TabIndex = 0;
            lblHeaderService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServicePort
            // 
            lblServicePort.AutoSize = true;
            lblServicePort.BackColor = System.Drawing.Color.Transparent;
            lblServicePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblServicePort.Location = new System.Drawing.Point(243, 45);
            lblServicePort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblServicePort.Name = "lblServicePort";
            lblServicePort.Size = new System.Drawing.Size(72, 15);
            lblServicePort.TabIndex = 3;
            lblServicePort.Text = "Service Port";
            lblServicePort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpClientAccess
            // 
            grpClientAccess.Controls.Add(lblClientAccess);
            grpClientAccess.Controls.Add(chkFilterClient);
            grpClientAccess.Controls.Add(lblHeaderClientAccess);
            grpClientAccess.Controls.Add(txtFilterClient);
            grpClientAccess.Controls.Add(btnEditClient);
            grpClientAccess.Controls.Add(lvwClientAccess);
            grpClientAccess.Controls.Add(btnRemoveClient);
            grpClientAccess.Controls.Add(btnNewClient);
            grpClientAccess.Location = new System.Drawing.Point(29, 352);
            grpClientAccess.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpClientAccess.Name = "grpClientAccess";
            grpClientAccess.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpClientAccess.Size = new System.Drawing.Size(579, 346);
            grpClientAccess.TabIndex = 1;
            grpClientAccess.TabStop = false;
            // 
            // lblClientAccess
            // 
            lblClientAccess.BackColor = System.Drawing.Color.Transparent;
            lblClientAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblClientAccess.ForeColor = System.Drawing.SystemColors.WindowText;
            lblClientAccess.Location = new System.Drawing.Point(12, 18);
            lblClientAccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblClientAccess.Name = "lblClientAccess";
            lblClientAccess.Size = new System.Drawing.Size(231, 25);
            lblClientAccess.TabIndex = 1;
            lblClientAccess.Text = "Client Access";
            lblClientAccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkFilterClient
            // 
            chkFilterClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            chkFilterClient.Appearance = System.Windows.Forms.Appearance.Button;
            chkFilterClient.Cursor = System.Windows.Forms.Cursors.Hand;
            chkFilterClient.Image = (System.Drawing.Image)resources.GetObject("chkFilterClient.Image");
            chkFilterClient.Location = new System.Drawing.Point(481, 287);
            chkFilterClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkFilterClient.Name = "chkFilterClient";
            chkFilterClient.Size = new System.Drawing.Size(41, 40);
            chkFilterClient.TabIndex = 6;
            toolTip1.SetToolTip(chkFilterClient, "Apply filter");
            chkFilterClient.UseVisualStyleBackColor = true;
            chkFilterClient.CheckedChanged += chkFilterClient_CheckedChanged;
            // 
            // lblHeaderClientAccess
            // 
            lblHeaderClientAccess.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderClientAccess.BackColor = System.Drawing.Color.Gainsboro;
            lblHeaderClientAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeaderClientAccess.Location = new System.Drawing.Point(-2, 7);
            lblHeaderClientAccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderClientAccess.Name = "lblHeaderClientAccess";
            lblHeaderClientAccess.Size = new System.Drawing.Size(582, 7);
            lblHeaderClientAccess.TabIndex = 0;
            lblHeaderClientAccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFilterClient
            // 
            txtFilterClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFilterClient.Location = new System.Drawing.Point(107, 298);
            txtFilterClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilterClient.Name = "txtFilterClient";
            txtFilterClient.Size = new System.Drawing.Size(367, 23);
            txtFilterClient.TabIndex = 5;
            // 
            // btnEditClient
            // 
            btnEditClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnEditClient.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditClient.Enabled = false;
            btnEditClient.Image = (System.Drawing.Image)resources.GetObject("btnEditClient.Image");
            btnEditClient.Location = new System.Drawing.Point(528, 287);
            btnEditClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new System.Drawing.Size(41, 40);
            btnEditClient.TabIndex = 7;
            toolTip1.SetToolTip(btnEditClient, "Edit client access");
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // lvwClientAccess
            // 
            lvwClientAccess.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwClientAccess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader13, columnHeader14, columnHeader15 });
            lvwClientAccess.FullRowSelect = true;
            lvwClientAccess.Location = new System.Drawing.Point(15, 52);
            lvwClientAccess.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwClientAccess.Name = "lvwClientAccess";
            lvwClientAccess.Size = new System.Drawing.Size(551, 227);
            lvwClientAccess.TabIndex = 2;
            lvwClientAccess.UseCompatibleStateImageBehavior = false;
            lvwClientAccess.View = System.Windows.Forms.View.Details;
            lvwClientAccess.ColumnClick += lvwClientAccess_ColumnClick;
            lvwClientAccess.SelectedIndexChanged += lvwClientAccess_SelectedIndexChanged;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Account Name";
            columnHeader13.Width = 200;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Created";
            columnHeader14.Width = 120;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Last Request";
            columnHeader15.Width = 120;
            // 
            // btnRemoveClient
            // 
            btnRemoveClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRemoveClient.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveClient.Enabled = false;
            btnRemoveClient.Image = (System.Drawing.Image)resources.GetObject("btnRemoveClient.Image");
            btnRemoveClient.Location = new System.Drawing.Point(61, 288);
            btnRemoveClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveClient.Name = "btnRemoveClient";
            btnRemoveClient.Size = new System.Drawing.Size(41, 40);
            btnRemoveClient.TabIndex = 4;
            toolTip1.SetToolTip(btnRemoveClient, "Remove client access");
            btnRemoveClient.UseVisualStyleBackColor = true;
            btnRemoveClient.Click += btnRemoveClient_Click;
            // 
            // btnNewClient
            // 
            btnNewClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNewClient.Image = (System.Drawing.Image)resources.GetObject("btnNewClient.Image");
            btnNewClient.Location = new System.Drawing.Point(15, 288);
            btnNewClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNewClient.Name = "btnNewClient";
            btnNewClient.Size = new System.Drawing.Size(41, 40);
            btnNewClient.TabIndex = 3;
            toolTip1.SetToolTip(btnNewClient, "Add new client");
            btnNewClient.UseVisualStyleBackColor = true;
            btnNewClient.Click += btnNewClient_Click;
            // 
            // tpgOptions
            // 
            tpgOptions.Controls.Add(groupBox1);
            tpgOptions.Location = new System.Drawing.Point(4, 24);
            tpgOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgOptions.Name = "tpgOptions";
            tpgOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgOptions.Size = new System.Drawing.Size(637, 724);
            tpgOptions.TabIndex = 3;
            tpgOptions.Text = "Options";
            tpgOptions.UseVisualStyleBackColor = true;
            tpgOptions.Click += tpgPlayers_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pnlCommandExportOptions);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pnlFtpSettingsCommands);
            groupBox1.Controls.Add(pnlPlayerSettingsStuctures);
            groupBox1.Controls.Add(pnlPlayerSettingsCommands);
            groupBox1.Controls.Add(pnlPlayerSettingsTames);
            groupBox1.Controls.Add(pnlPlayerSettingsBody);
            groupBox1.Location = new System.Drawing.Point(19, 21);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(597, 669);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // pnlCommandExportOptions
            // 
            pnlCommandExportOptions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlCommandExportOptions.BackColor = System.Drawing.Color.Transparent;
            pnlCommandExportOptions.Controls.Add(optExportNoSort);
            pnlCommandExportOptions.Controls.Add(optExportSort);
            pnlCommandExportOptions.Controls.Add(lblCommandExportOptionTitle);
            pnlCommandExportOptions.Controls.Add(lblCommandExportDescription);
            pnlCommandExportOptions.Location = new System.Drawing.Point(7, 432);
            pnlCommandExportOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlCommandExportOptions.Name = "pnlCommandExportOptions";
            pnlCommandExportOptions.Size = new System.Drawing.Size(580, 68);
            pnlCommandExportOptions.TabIndex = 0;
            // 
            // optExportNoSort
            // 
            optExportNoSort.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optExportNoSort.AutoSize = true;
            optExportNoSort.Checked = true;
            optExportNoSort.Location = new System.Drawing.Point(400, 37);
            optExportNoSort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optExportNoSort.Name = "optExportNoSort";
            optExportNoSort.Size = new System.Drawing.Size(41, 19);
            optExportNoSort.TabIndex = 2;
            optExportNoSort.TabStop = true;
            optExportNoSort.Text = "No";
            optExportNoSort.UseVisualStyleBackColor = true;
            // 
            // optExportSort
            // 
            optExportSort.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optExportSort.AutoSize = true;
            optExportSort.Location = new System.Drawing.Point(512, 37);
            optExportSort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optExportSort.Name = "optExportSort";
            optExportSort.Size = new System.Drawing.Size(42, 19);
            optExportSort.TabIndex = 3;
            optExportSort.Text = "Yes";
            optExportSort.UseVisualStyleBackColor = true;
            // 
            // lblCommandExportOptionTitle
            // 
            lblCommandExportOptionTitle.AutoSize = true;
            lblCommandExportOptionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCommandExportOptionTitle.Location = new System.Drawing.Point(12, 10);
            lblCommandExportOptionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCommandExportOptionTitle.Name = "lblCommandExportOptionTitle";
            lblCommandExportOptionTitle.Size = new System.Drawing.Size(175, 18);
            lblCommandExportOptionTitle.TabIndex = 0;
            lblCommandExportOptionTitle.Text = "Command Line Export";
            // 
            // lblCommandExportDescription
            // 
            lblCommandExportDescription.AutoSize = true;
            lblCommandExportDescription.Location = new System.Drawing.Point(12, 39);
            lblCommandExportDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCommandExportDescription.Name = "lblCommandExportDescription";
            lblCommandExportDescription.Size = new System.Drawing.Size(193, 15);
            lblCommandExportDescription.TabIndex = 1;
            lblCommandExportDescription.Text = "Sort creature exports by class name";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.BackColor = System.Drawing.Color.Aqua;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(-2, 0);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(601, 7);
            label4.TabIndex = 0;
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFtpSettingsCommands
            // 
            pnlFtpSettingsCommands.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlFtpSettingsCommands.BackColor = System.Drawing.Color.Transparent;
            pnlFtpSettingsCommands.Controls.Add(pnlDownloadOption);
            pnlFtpSettingsCommands.Controls.Add(label5);
            pnlFtpSettingsCommands.Controls.Add(optFTPSync);
            pnlFtpSettingsCommands.Controls.Add(optFTPClean);
            pnlFtpSettingsCommands.Controls.Add(label2);
            pnlFtpSettingsCommands.Controls.Add(label3);
            pnlFtpSettingsCommands.Location = new System.Drawing.Point(6, 312);
            pnlFtpSettingsCommands.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlFtpSettingsCommands.Name = "pnlFtpSettingsCommands";
            pnlFtpSettingsCommands.Size = new System.Drawing.Size(580, 113);
            pnlFtpSettingsCommands.TabIndex = 5;
            // 
            // pnlDownloadOption
            // 
            pnlDownloadOption.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pnlDownloadOption.Controls.Add(optDownloadAuto);
            pnlDownloadOption.Controls.Add(optDownloadManual);
            pnlDownloadOption.Location = new System.Drawing.Point(374, 63);
            pnlDownloadOption.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlDownloadOption.Name = "pnlDownloadOption";
            pnlDownloadOption.Size = new System.Drawing.Size(202, 38);
            pnlDownloadOption.TabIndex = 5;
            // 
            // optDownloadAuto
            // 
            optDownloadAuto.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optDownloadAuto.AutoSize = true;
            optDownloadAuto.Checked = true;
            optDownloadAuto.Location = new System.Drawing.Point(66, 9);
            optDownloadAuto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optDownloadAuto.Name = "optDownloadAuto";
            optDownloadAuto.Size = new System.Drawing.Size(51, 19);
            optDownloadAuto.TabIndex = 4;
            optDownloadAuto.TabStop = true;
            optDownloadAuto.Text = "Auto";
            optDownloadAuto.UseVisualStyleBackColor = true;
            // 
            // optDownloadManual
            // 
            optDownloadManual.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optDownloadManual.AutoSize = true;
            optDownloadManual.Location = new System.Drawing.Point(125, 9);
            optDownloadManual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optDownloadManual.Name = "optDownloadManual";
            optDownloadManual.Size = new System.Drawing.Size(65, 19);
            optDownloadManual.TabIndex = 5;
            optDownloadManual.Text = "Manual";
            optDownloadManual.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(13, 75);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(173, 15);
            label5.TabIndex = 4;
            label5.Text = "Download before loading map?";
            // 
            // optFTPSync
            // 
            optFTPSync.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optFTPSync.AutoSize = true;
            optFTPSync.Checked = true;
            optFTPSync.Location = new System.Drawing.Point(403, 38);
            optFTPSync.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optFTPSync.Name = "optFTPSync";
            optFTPSync.Size = new System.Drawing.Size(89, 19);
            optFTPSync.TabIndex = 2;
            optFTPSync.TabStop = true;
            optFTPSync.Text = "Synchronise";
            optFTPSync.UseVisualStyleBackColor = true;
            optFTPSync.CheckedChanged += optFTPSync_CheckedChanged;
            // 
            // optFTPClean
            // 
            optFTPClean.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optFTPClean.AutoSize = true;
            optFTPClean.Location = new System.Drawing.Point(509, 38);
            optFTPClean.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optFTPClean.Name = "optFTPClean";
            optFTPClean.Size = new System.Drawing.Size(55, 19);
            optFTPClean.TabIndex = 3;
            optFTPClean.Text = "Clean";
            optFTPClean.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 12);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(128, 18);
            label2.TabIndex = 0;
            label2.Text = "FTP Downloads";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 43);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(146, 15);
            label3.TabIndex = 1;
            label3.Text = "How to handle downloads";
            // 
            // pnlPlayerSettingsStuctures
            // 
            pnlPlayerSettingsStuctures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlPlayerSettingsStuctures.BackColor = System.Drawing.Color.Transparent;
            pnlPlayerSettingsStuctures.Controls.Add(optPlayerStructureHide);
            pnlPlayerSettingsStuctures.Controls.Add(optPlayerStructureShow);
            pnlPlayerSettingsStuctures.Controls.Add(lblOptionHeaderStructures);
            pnlPlayerSettingsStuctures.Controls.Add(lblOptionTextStructures);
            pnlPlayerSettingsStuctures.Location = new System.Drawing.Point(7, 27);
            pnlPlayerSettingsStuctures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlPlayerSettingsStuctures.Name = "pnlPlayerSettingsStuctures";
            pnlPlayerSettingsStuctures.Size = new System.Drawing.Size(580, 58);
            pnlPlayerSettingsStuctures.TabIndex = 0;
            // 
            // optPlayerStructureHide
            // 
            optPlayerStructureHide.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optPlayerStructureHide.AutoSize = true;
            optPlayerStructureHide.Checked = true;
            optPlayerStructureHide.Location = new System.Drawing.Point(441, 29);
            optPlayerStructureHide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optPlayerStructureHide.Name = "optPlayerStructureHide";
            optPlayerStructureHide.Size = new System.Drawing.Size(50, 19);
            optPlayerStructureHide.TabIndex = 2;
            optPlayerStructureHide.TabStop = true;
            optPlayerStructureHide.Text = "Hide";
            optPlayerStructureHide.UseVisualStyleBackColor = true;
            optPlayerStructureHide.CheckedChanged += optPlayerStructureHide_CheckedChanged;
            // 
            // optPlayerStructureShow
            // 
            optPlayerStructureShow.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optPlayerStructureShow.AutoSize = true;
            optPlayerStructureShow.Location = new System.Drawing.Point(511, 29);
            optPlayerStructureShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optPlayerStructureShow.Name = "optPlayerStructureShow";
            optPlayerStructureShow.Size = new System.Drawing.Size(54, 19);
            optPlayerStructureShow.TabIndex = 3;
            optPlayerStructureShow.Text = "Show";
            optPlayerStructureShow.UseVisualStyleBackColor = true;
            optPlayerStructureShow.CheckedChanged += optPlayerStructureShow_CheckedChanged;
            // 
            // lblOptionHeaderStructures
            // 
            lblOptionHeaderStructures.AutoSize = true;
            lblOptionHeaderStructures.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblOptionHeaderStructures.Location = new System.Drawing.Point(12, 6);
            lblOptionHeaderStructures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOptionHeaderStructures.Name = "lblOptionHeaderStructures";
            lblOptionHeaderStructures.Size = new System.Drawing.Size(86, 18);
            lblOptionHeaderStructures.TabIndex = 0;
            lblOptionHeaderStructures.Text = "Structures";
            // 
            // lblOptionTextStructures
            // 
            lblOptionTextStructures.AutoSize = true;
            lblOptionTextStructures.Location = new System.Drawing.Point(12, 31);
            lblOptionTextStructures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOptionTextStructures.Name = "lblOptionTextStructures";
            lblOptionTextStructures.Size = new System.Drawing.Size(288, 15);
            lblOptionTextStructures.TabIndex = 1;
            lblOptionTextStructures.Text = "Display Tribes and Players with no placed structure(s).";
            // 
            // pnlPlayerSettingsCommands
            // 
            pnlPlayerSettingsCommands.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlPlayerSettingsCommands.BackColor = System.Drawing.Color.Transparent;
            pnlPlayerSettingsCommands.Controls.Add(optPlayerCommandsPrefixAdmincheat);
            pnlPlayerSettingsCommands.Controls.Add(optPlayerCommandsPrefixNone);
            pnlPlayerSettingsCommands.Controls.Add(optPlayerCommandsPrefixCheat);
            pnlPlayerSettingsCommands.Controls.Add(lblOptionHeaderCommand);
            pnlPlayerSettingsCommands.Controls.Add(lblOptionTextCommand);
            pnlPlayerSettingsCommands.Location = new System.Drawing.Point(6, 234);
            pnlPlayerSettingsCommands.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlPlayerSettingsCommands.Name = "pnlPlayerSettingsCommands";
            pnlPlayerSettingsCommands.Size = new System.Drawing.Size(580, 70);
            pnlPlayerSettingsCommands.TabIndex = 4;
            // 
            // optPlayerCommandsPrefixAdmincheat
            // 
            optPlayerCommandsPrefixAdmincheat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optPlayerCommandsPrefixAdmincheat.AutoSize = true;
            optPlayerCommandsPrefixAdmincheat.Location = new System.Drawing.Point(407, 35);
            optPlayerCommandsPrefixAdmincheat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optPlayerCommandsPrefixAdmincheat.Name = "optPlayerCommandsPrefixAdmincheat";
            optPlayerCommandsPrefixAdmincheat.Size = new System.Drawing.Size(91, 19);
            optPlayerCommandsPrefixAdmincheat.TabIndex = 3;
            optPlayerCommandsPrefixAdmincheat.Text = "admincheat ";
            optPlayerCommandsPrefixAdmincheat.UseVisualStyleBackColor = true;
            optPlayerCommandsPrefixAdmincheat.CheckedChanged += optPlayerCommandsPrefixAdmincheat_CheckedChanged;
            // 
            // optPlayerCommandsPrefixNone
            // 
            optPlayerCommandsPrefixNone.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optPlayerCommandsPrefixNone.AutoSize = true;
            optPlayerCommandsPrefixNone.Checked = true;
            optPlayerCommandsPrefixNone.Location = new System.Drawing.Point(314, 35);
            optPlayerCommandsPrefixNone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optPlayerCommandsPrefixNone.Name = "optPlayerCommandsPrefixNone";
            optPlayerCommandsPrefixNone.Size = new System.Drawing.Size(62, 19);
            optPlayerCommandsPrefixNone.TabIndex = 2;
            optPlayerCommandsPrefixNone.TabStop = true;
            optPlayerCommandsPrefixNone.Text = "[None]";
            optPlayerCommandsPrefixNone.UseVisualStyleBackColor = true;
            optPlayerCommandsPrefixNone.CheckedChanged += optPlayerCommandsPrefixNone_CheckedChanged;
            // 
            // optPlayerCommandsPrefixCheat
            // 
            optPlayerCommandsPrefixCheat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optPlayerCommandsPrefixCheat.AutoSize = true;
            optPlayerCommandsPrefixCheat.Location = new System.Drawing.Point(511, 35);
            optPlayerCommandsPrefixCheat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optPlayerCommandsPrefixCheat.Name = "optPlayerCommandsPrefixCheat";
            optPlayerCommandsPrefixCheat.Size = new System.Drawing.Size(57, 19);
            optPlayerCommandsPrefixCheat.TabIndex = 4;
            optPlayerCommandsPrefixCheat.Text = "cheat ";
            optPlayerCommandsPrefixCheat.UseVisualStyleBackColor = true;
            optPlayerCommandsPrefixCheat.CheckedChanged += optPlayerCommandsPrefixCheat_CheckedChanged;
            // 
            // lblOptionHeaderCommand
            // 
            lblOptionHeaderCommand.AutoSize = true;
            lblOptionHeaderCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblOptionHeaderCommand.Location = new System.Drawing.Point(12, 9);
            lblOptionHeaderCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOptionHeaderCommand.Name = "lblOptionHeaderCommand";
            lblOptionHeaderCommand.Size = new System.Drawing.Size(133, 18);
            lblOptionHeaderCommand.TabIndex = 0;
            lblOptionHeaderCommand.Text = "Command Prefix";
            // 
            // lblOptionTextCommand
            // 
            lblOptionTextCommand.AutoSize = true;
            lblOptionTextCommand.Location = new System.Drawing.Point(12, 37);
            lblOptionTextCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOptionTextCommand.Name = "lblOptionTextCommand";
            lblOptionTextCommand.Size = new System.Drawing.Size(171, 15);
            lblOptionTextCommand.TabIndex = 1;
            lblOptionTextCommand.Text = "Add prefix to copy commands:";
            // 
            // pnlPlayerSettingsTames
            // 
            pnlPlayerSettingsTames.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlPlayerSettingsTames.BackColor = System.Drawing.Color.Transparent;
            pnlPlayerSettingsTames.Controls.Add(optPlayerTameHide);
            pnlPlayerSettingsTames.Controls.Add(optPlayerTameShow);
            pnlPlayerSettingsTames.Controls.Add(lblOptionHeaderTames);
            pnlPlayerSettingsTames.Controls.Add(lblOptionTextTames);
            pnlPlayerSettingsTames.Location = new System.Drawing.Point(7, 91);
            pnlPlayerSettingsTames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlPlayerSettingsTames.Name = "pnlPlayerSettingsTames";
            pnlPlayerSettingsTames.Size = new System.Drawing.Size(580, 63);
            pnlPlayerSettingsTames.TabIndex = 2;
            // 
            // optPlayerTameHide
            // 
            optPlayerTameHide.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optPlayerTameHide.AutoSize = true;
            optPlayerTameHide.Checked = true;
            optPlayerTameHide.Location = new System.Drawing.Point(441, 32);
            optPlayerTameHide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optPlayerTameHide.Name = "optPlayerTameHide";
            optPlayerTameHide.Size = new System.Drawing.Size(50, 19);
            optPlayerTameHide.TabIndex = 2;
            optPlayerTameHide.TabStop = true;
            optPlayerTameHide.Text = "Hide";
            optPlayerTameHide.UseVisualStyleBackColor = true;
            optPlayerTameHide.CheckedChanged += optPlayerTameHide_CheckedChanged;
            // 
            // optPlayerTameShow
            // 
            optPlayerTameShow.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optPlayerTameShow.AutoSize = true;
            optPlayerTameShow.Location = new System.Drawing.Point(511, 32);
            optPlayerTameShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optPlayerTameShow.Name = "optPlayerTameShow";
            optPlayerTameShow.Size = new System.Drawing.Size(54, 19);
            optPlayerTameShow.TabIndex = 3;
            optPlayerTameShow.Text = "Show";
            optPlayerTameShow.UseVisualStyleBackColor = true;
            optPlayerTameShow.CheckedChanged += optPlayerTameShow_CheckedChanged;
            // 
            // lblOptionHeaderTames
            // 
            lblOptionHeaderTames.AutoSize = true;
            lblOptionHeaderTames.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblOptionHeaderTames.Location = new System.Drawing.Point(12, 8);
            lblOptionHeaderTames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOptionHeaderTames.Name = "lblOptionHeaderTames";
            lblOptionHeaderTames.Size = new System.Drawing.Size(59, 18);
            lblOptionHeaderTames.TabIndex = 0;
            lblOptionHeaderTames.Text = "Tames";
            // 
            // lblOptionTextTames
            // 
            lblOptionTextTames.AutoSize = true;
            lblOptionTextTames.Location = new System.Drawing.Point(12, 35);
            lblOptionTextTames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOptionTextTames.Name = "lblOptionTextTames";
            lblOptionTextTames.Size = new System.Drawing.Size(275, 15);
            lblOptionTextTames.TabIndex = 1;
            lblOptionTextTames.Text = "Display Tribes and Players with no tamed creatures.";
            // 
            // pnlPlayerSettingsBody
            // 
            pnlPlayerSettingsBody.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlPlayerSettingsBody.BackColor = System.Drawing.Color.Transparent;
            pnlPlayerSettingsBody.Controls.Add(optPlayerBodyHide);
            pnlPlayerSettingsBody.Controls.Add(optPlayerBodyShow);
            pnlPlayerSettingsBody.Controls.Add(lblOptionHeaderBody);
            pnlPlayerSettingsBody.Controls.Add(lblOptionTextBody);
            pnlPlayerSettingsBody.Location = new System.Drawing.Point(7, 162);
            pnlPlayerSettingsBody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlPlayerSettingsBody.Name = "pnlPlayerSettingsBody";
            pnlPlayerSettingsBody.Size = new System.Drawing.Size(580, 66);
            pnlPlayerSettingsBody.TabIndex = 3;
            // 
            // optPlayerBodyHide
            // 
            optPlayerBodyHide.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optPlayerBodyHide.AutoSize = true;
            optPlayerBodyHide.Checked = true;
            optPlayerBodyHide.Location = new System.Drawing.Point(441, 35);
            optPlayerBodyHide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optPlayerBodyHide.Name = "optPlayerBodyHide";
            optPlayerBodyHide.Size = new System.Drawing.Size(50, 19);
            optPlayerBodyHide.TabIndex = 2;
            optPlayerBodyHide.TabStop = true;
            optPlayerBodyHide.Text = "Hide";
            optPlayerBodyHide.UseVisualStyleBackColor = true;
            optPlayerBodyHide.CheckedChanged += optPlayerBodyHide_CheckedChanged;
            // 
            // optPlayerBodyShow
            // 
            optPlayerBodyShow.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optPlayerBodyShow.AutoSize = true;
            optPlayerBodyShow.Location = new System.Drawing.Point(511, 35);
            optPlayerBodyShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optPlayerBodyShow.Name = "optPlayerBodyShow";
            optPlayerBodyShow.Size = new System.Drawing.Size(54, 19);
            optPlayerBodyShow.TabIndex = 3;
            optPlayerBodyShow.Text = "Show";
            optPlayerBodyShow.UseVisualStyleBackColor = true;
            optPlayerBodyShow.CheckedChanged += optPlayerBodyShow_CheckedChanged;
            // 
            // lblOptionHeaderBody
            // 
            lblOptionHeaderBody.AutoSize = true;
            lblOptionHeaderBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblOptionHeaderBody.Location = new System.Drawing.Point(12, 9);
            lblOptionHeaderBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOptionHeaderBody.Name = "lblOptionHeaderBody";
            lblOptionHeaderBody.Size = new System.Drawing.Size(46, 18);
            lblOptionHeaderBody.TabIndex = 0;
            lblOptionHeaderBody.Text = "Body";
            // 
            // lblOptionTextBody
            // 
            lblOptionTextBody.AutoSize = true;
            lblOptionTextBody.Location = new System.Drawing.Point(12, 37);
            lblOptionTextBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOptionTextBody.Name = "lblOptionTextBody";
            lblOptionTextBody.Size = new System.Drawing.Size(317, 15);
            lblOptionTextBody.TabIndex = 1;
            lblOptionTextBody.Text = "Display Tribes and Players with no body. (Dead / Uploaded)";
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 10;
            toolTip1.AutoPopDelay = 2000;
            toolTip1.InitialDelay = 10;
            toolTip1.ReshowDelay = 2000;
            toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Information";
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(676, 812);
            Controls.Add(tabSettings);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSettings";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += frmSettings_Load;
            tabSettings.ResumeLayout(false);
            tpgMap.ResumeLayout(false);
            tpgMap.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpServer.ResumeLayout(false);
            grpOffline.ResumeLayout(false);
            grpSinglePlayer.ResumeLayout(false);
            grpSinglePlayer.PerformLayout();
            tpgColours.ResumeLayout(false);
            grpTamedHighlights.ResumeLayout(false);
            grpColoursNotMapped.ResumeLayout(false);
            grpColours.ResumeLayout(false);
            grpColours.PerformLayout();
            tpgCreatures.ResumeLayout(false);
            grpCreaturesNotMapped.ResumeLayout(false);
            grpCreatures.ResumeLayout(false);
            grpCreatures.PerformLayout();
            tpgStructures.ResumeLayout(false);
            grpStructuresNotMapped.ResumeLayout(false);
            grpStructures.ResumeLayout(false);
            grpStructures.PerformLayout();
            tpgItems.ResumeLayout(false);
            grpItemsNotMatched.ResumeLayout(false);
            grpItems.ResumeLayout(false);
            grpItems.PerformLayout();
            tpgExport.ResumeLayout(false);
            grpJsonExport.ResumeLayout(false);
            grpJsonExport.PerformLayout();
            grpContentPack.ResumeLayout(false);
            grpContentPack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)udExportRadius).EndInit();
            ((System.ComponentModel.ISupportInitialize)udExportLon).EndInit();
            ((System.ComponentModel.ISupportInitialize)udExportLat).EndInit();
            tpgRestService.ResumeLayout(false);
            grpService.ResumeLayout(false);
            grpService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)udServicePort).EndInit();
            grpClientAccess.ResumeLayout(false);
            grpClientAccess.PerformLayout();
            tpgOptions.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            pnlCommandExportOptions.ResumeLayout(false);
            pnlCommandExportOptions.PerformLayout();
            pnlFtpSettingsCommands.ResumeLayout(false);
            pnlFtpSettingsCommands.PerformLayout();
            pnlDownloadOption.ResumeLayout(false);
            pnlDownloadOption.PerformLayout();
            pnlPlayerSettingsStuctures.ResumeLayout(false);
            pnlPlayerSettingsStuctures.PerformLayout();
            pnlPlayerSettingsCommands.ResumeLayout(false);
            pnlPlayerSettingsCommands.PerformLayout();
            pnlPlayerSettingsTames.ResumeLayout(false);
            pnlPlayerSettingsTames.PerformLayout();
            pnlPlayerSettingsBody.ResumeLayout(false);
            pnlPlayerSettingsBody.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpTamedHighlights;
        private System.Windows.Forms.Button btnRefreshUnknownColours;
        private System.Windows.Forms.Button btnColoursNotMatchedAdd;
        private System.Windows.Forms.Label lblTamedHighlight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblVivariumHighlight;
        private System.Windows.Forms.Label lblUploadedHighlight;
        private System.Windows.Forms.Label lblCryopodHighlight;
    }
}
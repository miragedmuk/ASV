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
            optContentPack = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnLoadContentPack = new System.Windows.Forms.Button();
            txtContentPackFilename = new System.Windows.Forms.TextBox();
            lblSelectedMapContentPack = new System.Windows.Forms.Label();
            optOffline = new System.Windows.Forms.RadioButton();
            optServer = new System.Windows.Forms.RadioButton();
            optSinglePlayer = new System.Windows.Forms.RadioButton();
            grpServer = new System.Windows.Forms.GroupBox();
            lblFTPServer = new System.Windows.Forms.Label();
            btnEditServer = new System.Windows.Forms.Button();
            lblFtpMap = new System.Windows.Forms.Label();
            btnRemoveServer = new System.Windows.Forms.Button();
            btnAddServer = new System.Windows.Forms.Button();
            cboFTPServer = new ArkViewer.UI.BorderlessComboBox();
            cboFtpMap = new ArkViewer.UI.BorderlessComboBox();
            grpOffline = new System.Windows.Forms.GroupBox();
            btnEditARK = new System.Windows.Forms.Button();
            btnRemoveARK = new System.Windows.Forms.Button();
            btnAddARK = new System.Windows.Forms.Button();
            cboLocalARK = new ArkViewer.UI.BorderlessComboBox();
            lblOfflineSave = new System.Windows.Forms.Label();
            grpSinglePlayer = new System.Windows.Forms.GroupBox();
            btnSelectFolder = new System.Windows.Forms.Button();
            chkUpdateNotificationSingle = new System.Windows.Forms.CheckBox();
            lblSelectedMapSP = new System.Windows.Forms.Label();
            cboMapSinglePlayer = new ArkViewer.UI.BorderlessComboBox();
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
            cboExportPlayer = new ArkViewer.UI.BorderlessComboBox();
            cboExportTribe = new ArkViewer.UI.BorderlessComboBox();
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
            tpgOptions = new System.Windows.Forms.TabPage();
            groupBox1 = new System.Windows.Forms.GroupBox();
            panel1 = new System.Windows.Forms.Panel();
            udMaxCores = new System.Windows.Forms.NumericUpDown();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton4 = new System.Windows.Forms.RadioButton();
            radioButton5 = new System.Windows.Forms.RadioButton();
            radioButton6 = new System.Windows.Forms.RadioButton();
            label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            pnlOptionsStartup = new System.Windows.Forms.Panel();
            optStartupManual = new System.Windows.Forms.RadioButton();
            optStartupAuto = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            lblStartup = new System.Windows.Forms.Label();
            lblStartupInfo = new System.Windows.Forms.Label();
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
            tpgOptions.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udMaxCores).BeginInit();
            pnlOptionsStartup.SuspendLayout();
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
            btnSave.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            btnSave.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnSave.Location = new System.Drawing.Point(370, 602);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(78, 27);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnClose.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnClose.Location = new System.Drawing.Point(459, 602);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(88, 27);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
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
            tabSettings.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabSettings.Controls.Add(tpgMap);
            tabSettings.Controls.Add(tpgColours);
            tabSettings.Controls.Add(tpgCreatures);
            tabSettings.Controls.Add(tpgStructures);
            tabSettings.Controls.Add(tpgItems);
            tabSettings.Controls.Add(tpgExport);
            tabSettings.Controls.Add(tpgOptions);
            tabSettings.Location = new System.Drawing.Point(14, 14);
            tabSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabSettings.Multiline = true;
            tabSettings.Name = "tabSettings";
            tabSettings.SelectedIndex = 0;
            tabSettings.Size = new System.Drawing.Size(537, 582);
            tabSettings.TabIndex = 0;
            tabSettings.Selecting += tabSettings_Selecting;
            // 
            // tpgMap
            // 
            tpgMap.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
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
            tpgMap.Size = new System.Drawing.Size(529, 554);
            tpgMap.TabIndex = 0;
            tpgMap.Text = "Map Data";
            // 
            // optContentPack
            // 
            optContentPack.AutoSize = true;
            optContentPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            optContentPack.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            optContentPack.Location = new System.Drawing.Point(27, 275);
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
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            groupBox2.Controls.Add(btnLoadContentPack);
            groupBox2.Controls.Add(txtContentPackFilename);
            groupBox2.Controls.Add(lblSelectedMapContentPack);
            groupBox2.Location = new System.Drawing.Point(23, 297);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(483, 85);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // btnLoadContentPack
            // 
            btnLoadContentPack.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnLoadContentPack.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnLoadContentPack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLoadContentPack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLoadContentPack.Image = (System.Drawing.Image)resources.GetObject("btnLoadContentPack.Image");
            btnLoadContentPack.Location = new System.Drawing.Point(417, 29);
            btnLoadContentPack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLoadContentPack.Name = "btnLoadContentPack";
            btnLoadContentPack.Size = new System.Drawing.Size(41, 40);
            btnLoadContentPack.TabIndex = 2;
            toolTip1.SetToolTip(btnLoadContentPack, "Open ARK save file");
            btnLoadContentPack.UseVisualStyleBackColor = false;
            btnLoadContentPack.Click += btnLoadContentPack_Click;
            // 
            // txtContentPackFilename
            // 
            txtContentPackFilename.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtContentPackFilename.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtContentPackFilename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtContentPackFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            txtContentPackFilename.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtContentPackFilename.Location = new System.Drawing.Point(21, 40);
            txtContentPackFilename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtContentPackFilename.Name = "txtContentPackFilename";
            txtContentPackFilename.ReadOnly = true;
            txtContentPackFilename.Size = new System.Drawing.Size(388, 17);
            txtContentPackFilename.TabIndex = 1;
            // 
            // lblSelectedMapContentPack
            // 
            lblSelectedMapContentPack.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblSelectedMapContentPack.BackColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblSelectedMapContentPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblSelectedMapContentPack.Location = new System.Drawing.Point(-2, 1);
            lblSelectedMapContentPack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSelectedMapContentPack.Name = "lblSelectedMapContentPack";
            lblSelectedMapContentPack.Size = new System.Drawing.Size(486, 8);
            lblSelectedMapContentPack.TabIndex = 0;
            lblSelectedMapContentPack.Text = "   ";
            lblSelectedMapContentPack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optOffline
            // 
            optOffline.AutoSize = true;
            optOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            optOffline.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            optOffline.Location = new System.Drawing.Point(27, 151);
            optOffline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optOffline.Name = "optOffline";
            optOffline.Size = new System.Drawing.Size(173, 17);
            optOffline.TabIndex = 2;
            optOffline.Text = "Savegame File (.ark / .gz)";
            optOffline.UseVisualStyleBackColor = true;
            optOffline.CheckedChanged += optOffline_CheckedChanged;
            // 
            // optServer
            // 
            optServer.AutoSize = true;
            optServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            optServer.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            optServer.Location = new System.Drawing.Point(27, 387);
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
            optSinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            optSinglePlayer.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            optSinglePlayer.Location = new System.Drawing.Point(27, 26);
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
            grpServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpServer.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpServer.Controls.Add(lblFTPServer);
            grpServer.Controls.Add(btnEditServer);
            grpServer.Controls.Add(lblFtpMap);
            grpServer.Controls.Add(btnRemoveServer);
            grpServer.Controls.Add(btnAddServer);
            grpServer.Controls.Add(cboFTPServer);
            grpServer.Controls.Add(cboFtpMap);
            grpServer.Location = new System.Drawing.Point(24, 410);
            grpServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpServer.Name = "grpServer";
            grpServer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpServer.Size = new System.Drawing.Size(483, 126);
            grpServer.TabIndex = 7;
            grpServer.TabStop = false;
            // 
            // lblFTPServer
            // 
            lblFTPServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblFTPServer.BackColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblFTPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblFTPServer.Location = new System.Drawing.Point(-1, 1);
            lblFTPServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFTPServer.Name = "lblFTPServer";
            lblFTPServer.Size = new System.Drawing.Size(486, 8);
            lblFTPServer.TabIndex = 0;
            lblFTPServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditServer
            // 
            btnEditServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnEditServer.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnEditServer.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditServer.Enabled = false;
            btnEditServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditServer.Image = (System.Drawing.Image)resources.GetObject("btnEditServer.Image");
            btnEditServer.Location = new System.Drawing.Point(323, 28);
            btnEditServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditServer.Name = "btnEditServer";
            btnEditServer.Size = new System.Drawing.Size(41, 40);
            btnEditServer.TabIndex = 21;
            toolTip1.SetToolTip(btnEditServer, "Edit server");
            btnEditServer.UseVisualStyleBackColor = false;
            btnEditServer.Click += btnEditServer_Click;
            // 
            // lblFtpMap
            // 
            lblFtpMap.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            lblFtpMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            lblFtpMap.Location = new System.Drawing.Point(24, 76);
            lblFtpMap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFtpMap.Name = "lblFtpMap";
            lblFtpMap.Size = new System.Drawing.Size(134, 25);
            lblFtpMap.TabIndex = 20;
            lblFtpMap.Text = "Map";
            lblFtpMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRemoveServer
            // 
            btnRemoveServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRemoveServer.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRemoveServer.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveServer.Enabled = false;
            btnRemoveServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveServer.Image = (System.Drawing.Image)resources.GetObject("btnRemoveServer.Image");
            btnRemoveServer.Location = new System.Drawing.Point(416, 28);
            btnRemoveServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveServer.Name = "btnRemoveServer";
            btnRemoveServer.Size = new System.Drawing.Size(41, 40);
            btnRemoveServer.TabIndex = 4;
            toolTip1.SetToolTip(btnRemoveServer, "Remove selected server");
            btnRemoveServer.UseVisualStyleBackColor = false;
            btnRemoveServer.Click += btnRemoveServer_Click;
            // 
            // btnAddServer
            // 
            btnAddServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAddServer.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnAddServer.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddServer.Image = (System.Drawing.Image)resources.GetObject("btnAddServer.Image");
            btnAddServer.Location = new System.Drawing.Point(369, 28);
            btnAddServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddServer.Name = "btnAddServer";
            btnAddServer.Size = new System.Drawing.Size(41, 40);
            btnAddServer.TabIndex = 3;
            toolTip1.SetToolTip(btnAddServer, "Add new server");
            btnAddServer.UseVisualStyleBackColor = false;
            btnAddServer.Click += btnAddServer_Click;
            // 
            // cboFTPServer
            // 
            cboFTPServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboFTPServer.BorderColor = System.Drawing.Color.Transparent;
            cboFTPServer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboFTPServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboFTPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            cboFTPServer.FormattingEnabled = true;
            cboFTPServer.Location = new System.Drawing.Point(29, 35);
            cboFTPServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboFTPServer.Name = "cboFTPServer";
            cboFTPServer.Size = new System.Drawing.Size(280, 23);
            cboFTPServer.TabIndex = 1;
            cboFTPServer.SelectedIndexChanged += cboFTPServer_SelectedIndexChanged;
            // 
            // cboFtpMap
            // 
            cboFtpMap.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboFtpMap.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboFtpMap.BorderColor = System.Drawing.Color.FromArgb(125, 125, 125);
            cboFtpMap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboFtpMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboFtpMap.Enabled = false;
            cboFtpMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboFtpMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            cboFtpMap.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboFtpMap.FormattingEnabled = true;
            cboFtpMap.Location = new System.Drawing.Point(160, 76);
            cboFtpMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboFtpMap.Name = "cboFtpMap";
            cboFtpMap.Size = new System.Drawing.Size(297, 25);
            cboFtpMap.TabIndex = 19;
            cboFtpMap.DrawItem += ownerDrawCombo_DrawItem;
            cboFtpMap.SelectedIndexChanged += cboFtpMap_SelectedIndexChanged;
            // 
            // grpOffline
            // 
            grpOffline.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpOffline.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpOffline.Controls.Add(btnEditARK);
            grpOffline.Controls.Add(btnRemoveARK);
            grpOffline.Controls.Add(btnAddARK);
            grpOffline.Controls.Add(cboLocalARK);
            grpOffline.Controls.Add(lblOfflineSave);
            grpOffline.Location = new System.Drawing.Point(23, 173);
            grpOffline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpOffline.Name = "grpOffline";
            grpOffline.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpOffline.Size = new System.Drawing.Size(483, 96);
            grpOffline.TabIndex = 3;
            grpOffline.TabStop = false;
            // 
            // btnEditARK
            // 
            btnEditARK.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnEditARK.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnEditARK.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditARK.Enabled = false;
            btnEditARK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditARK.Image = (System.Drawing.Image)resources.GetObject("btnEditARK.Image");
            btnEditARK.Location = new System.Drawing.Point(320, 32);
            btnEditARK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditARK.Name = "btnEditARK";
            btnEditARK.Size = new System.Drawing.Size(41, 40);
            btnEditARK.TabIndex = 22;
            toolTip1.SetToolTip(btnEditARK, "Edit details");
            btnEditARK.UseVisualStyleBackColor = false;
            btnEditARK.Click += btnEditARK_Click;
            // 
            // btnRemoveARK
            // 
            btnRemoveARK.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRemoveARK.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRemoveARK.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveARK.Enabled = false;
            btnRemoveARK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveARK.Image = (System.Drawing.Image)resources.GetObject("btnRemoveARK.Image");
            btnRemoveARK.Location = new System.Drawing.Point(415, 32);
            btnRemoveARK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveARK.Name = "btnRemoveARK";
            btnRemoveARK.Size = new System.Drawing.Size(41, 40);
            btnRemoveARK.TabIndex = 7;
            toolTip1.SetToolTip(btnRemoveARK, "Remove selected offline file.");
            btnRemoveARK.UseVisualStyleBackColor = false;
            btnRemoveARK.Click += btnRemoveARK_Click;
            // 
            // btnAddARK
            // 
            btnAddARK.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAddARK.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnAddARK.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddARK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddARK.Image = (System.Drawing.Image)resources.GetObject("btnAddARK.Image");
            btnAddARK.Location = new System.Drawing.Point(368, 32);
            btnAddARK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddARK.Name = "btnAddARK";
            btnAddARK.Size = new System.Drawing.Size(41, 40);
            btnAddARK.TabIndex = 6;
            toolTip1.SetToolTip(btnAddARK, "Add new offline file.");
            btnAddARK.UseVisualStyleBackColor = false;
            btnAddARK.Click += btnAddARK_Click;
            // 
            // cboLocalARK
            // 
            cboLocalARK.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboLocalARK.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboLocalARK.BorderColor = System.Drawing.Color.FromArgb(125, 125, 125);
            cboLocalARK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboLocalARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboLocalARK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboLocalARK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            cboLocalARK.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboLocalARK.FormattingEnabled = true;
            cboLocalARK.Location = new System.Drawing.Point(21, 39);
            cboLocalARK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboLocalARK.Name = "cboLocalARK";
            cboLocalARK.Size = new System.Drawing.Size(289, 23);
            cboLocalARK.TabIndex = 5;
            cboLocalARK.DrawItem += ownerDrawCombo_DrawItem;
            cboLocalARK.SelectedIndexChanged += cboLocalARK_SelectedIndexChanged;
            // 
            // lblOfflineSave
            // 
            lblOfflineSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblOfflineSave.BackColor = System.Drawing.Color.FromArgb(125, 125, 125);
            lblOfflineSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblOfflineSave.Location = new System.Drawing.Point(-2, 1);
            lblOfflineSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOfflineSave.Name = "lblOfflineSave";
            lblOfflineSave.Size = new System.Drawing.Size(486, 8);
            lblOfflineSave.TabIndex = 0;
            lblOfflineSave.Text = "   ";
            lblOfflineSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpSinglePlayer
            // 
            grpSinglePlayer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpSinglePlayer.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpSinglePlayer.Controls.Add(btnSelectFolder);
            grpSinglePlayer.Controls.Add(chkUpdateNotificationSingle);
            grpSinglePlayer.Controls.Add(lblSelectedMapSP);
            grpSinglePlayer.Controls.Add(cboMapSinglePlayer);
            grpSinglePlayer.Location = new System.Drawing.Point(22, 48);
            grpSinglePlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpSinglePlayer.Name = "grpSinglePlayer";
            grpSinglePlayer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpSinglePlayer.Size = new System.Drawing.Size(484, 98);
            grpSinglePlayer.TabIndex = 1;
            grpSinglePlayer.TabStop = false;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSelectFolder.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnSelectFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSelectFolder.Enabled = false;
            btnSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSelectFolder.Image = (System.Drawing.Image)resources.GetObject("btnSelectFolder.Image");
            btnSelectFolder.Location = new System.Drawing.Point(416, 30);
            btnSelectFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new System.Drawing.Size(41, 40);
            btnSelectFolder.TabIndex = 3;
            toolTip1.SetToolTip(btnSelectFolder, "Select ARK save location.");
            btnSelectFolder.UseVisualStyleBackColor = false;
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
            lblSelectedMapSP.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblSelectedMapSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblSelectedMapSP.Location = new System.Drawing.Point(-2, 2);
            lblSelectedMapSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSelectedMapSP.Name = "lblSelectedMapSP";
            lblSelectedMapSP.Size = new System.Drawing.Size(487, 8);
            lblSelectedMapSP.TabIndex = 0;
            lblSelectedMapSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboMapSinglePlayer
            // 
            cboMapSinglePlayer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboMapSinglePlayer.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboMapSinglePlayer.BorderColor = System.Drawing.Color.FromArgb(125, 125, 125);
            cboMapSinglePlayer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboMapSinglePlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboMapSinglePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboMapSinglePlayer.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboMapSinglePlayer.FormattingEnabled = true;
            cboMapSinglePlayer.Location = new System.Drawing.Point(22, 39);
            cboMapSinglePlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboMapSinglePlayer.Name = "cboMapSinglePlayer";
            cboMapSinglePlayer.Size = new System.Drawing.Size(388, 24);
            cboMapSinglePlayer.TabIndex = 1;
            cboMapSinglePlayer.DrawItem += ownerDrawCombo_DrawItem;
            cboMapSinglePlayer.SelectedIndexChanged += cboMapSinglePlayer_SelectedIndexChanged;
            // 
            // tpgColours
            // 
            tpgColours.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgColours.Controls.Add(grpTamedHighlights);
            tpgColours.Controls.Add(grpColoursNotMapped);
            tpgColours.Controls.Add(grpColours);
            tpgColours.Location = new System.Drawing.Point(4, 24);
            tpgColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgColours.Name = "tpgColours";
            tpgColours.Size = new System.Drawing.Size(529, 554);
            tpgColours.TabIndex = 5;
            tpgColours.Text = "Colours";
            // 
            // grpTamedHighlights
            // 
            grpTamedHighlights.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpTamedHighlights.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpTamedHighlights.Controls.Add(lblUploadedHighlight);
            grpTamedHighlights.Controls.Add(lblCryopodHighlight);
            grpTamedHighlights.Controls.Add(lblVivariumHighlight);
            grpTamedHighlights.Controls.Add(label9);
            grpTamedHighlights.Controls.Add(lblTamedHighlight);
            grpTamedHighlights.Location = new System.Drawing.Point(23, 453);
            grpTamedHighlights.Name = "grpTamedHighlights";
            grpTamedHighlights.Size = new System.Drawing.Size(491, 97);
            grpTamedHighlights.TabIndex = 2;
            grpTamedHighlights.TabStop = false;
            // 
            // lblUploadedHighlight
            // 
            lblUploadedHighlight.BackColor = System.Drawing.Color.WhiteSmoke;
            lblUploadedHighlight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblUploadedHighlight.Cursor = System.Windows.Forms.Cursors.Hand;
            lblUploadedHighlight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblUploadedHighlight.ForeColor = System.Drawing.Color.Black;
            lblUploadedHighlight.Location = new System.Drawing.Point(185, 48);
            lblUploadedHighlight.Name = "lblUploadedHighlight";
            lblUploadedHighlight.Size = new System.Drawing.Size(74, 35);
            lblUploadedHighlight.TabIndex = 6;
            lblUploadedHighlight.Text = "Uploaded";
            lblUploadedHighlight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblUploadedHighlight.Click += lblUploadedHighlight_Click;
            // 
            // lblCryopodHighlight
            // 
            lblCryopodHighlight.BackColor = System.Drawing.Color.LightSkyBlue;
            lblCryopodHighlight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblCryopodHighlight.Cursor = System.Windows.Forms.Cursors.Hand;
            lblCryopodHighlight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblCryopodHighlight.ForeColor = System.Drawing.Color.Black;
            lblCryopodHighlight.Location = new System.Drawing.Point(105, 48);
            lblCryopodHighlight.Name = "lblCryopodHighlight";
            lblCryopodHighlight.Size = new System.Drawing.Size(74, 35);
            lblCryopodHighlight.TabIndex = 5;
            lblCryopodHighlight.Text = "Cryo";
            lblCryopodHighlight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblCryopodHighlight.Click += lblCryopodHighlight_Click;
            // 
            // lblVivariumHighlight
            // 
            lblVivariumHighlight.BackColor = System.Drawing.Color.LightGreen;
            lblVivariumHighlight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblVivariumHighlight.Cursor = System.Windows.Forms.Cursors.Hand;
            lblVivariumHighlight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblVivariumHighlight.ForeColor = System.Drawing.Color.Black;
            lblVivariumHighlight.Location = new System.Drawing.Point(15, 48);
            lblVivariumHighlight.Name = "lblVivariumHighlight";
            lblVivariumHighlight.Size = new System.Drawing.Size(74, 35);
            lblVivariumHighlight.TabIndex = 4;
            lblVivariumHighlight.Text = "Vivarium";
            lblVivariumHighlight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblVivariumHighlight.Click += lblVivariumHighlight_Click;
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label9.BackColor = System.Drawing.Color.Gainsboro;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            label9.Location = new System.Drawing.Point(-3, 1);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(497, 8);
            label9.TabIndex = 2;
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTamedHighlight
            // 
            lblTamedHighlight.BackColor = System.Drawing.Color.Transparent;
            lblTamedHighlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblTamedHighlight.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblTamedHighlight.Location = new System.Drawing.Point(10, 16);
            lblTamedHighlight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTamedHighlight.Name = "lblTamedHighlight";
            lblTamedHighlight.Size = new System.Drawing.Size(231, 21);
            lblTamedHighlight.TabIndex = 3;
            lblTamedHighlight.Text = "Tamed Highlight";
            lblTamedHighlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpColoursNotMapped
            // 
            grpColoursNotMapped.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpColoursNotMapped.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpColoursNotMapped.Controls.Add(btnRefreshUnknownColours);
            grpColoursNotMapped.Controls.Add(btnColoursNotMatchedAdd);
            grpColoursNotMapped.Controls.Add(lblColourNotMapped);
            grpColoursNotMapped.Controls.Add(lblHeaderColoursNotMatched);
            grpColoursNotMapped.Controls.Add(lvwColoursNotMapped);
            grpColoursNotMapped.Location = new System.Drawing.Point(22, 246);
            grpColoursNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpColoursNotMapped.Name = "grpColoursNotMapped";
            grpColoursNotMapped.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpColoursNotMapped.Size = new System.Drawing.Size(494, 201);
            grpColoursNotMapped.TabIndex = 1;
            grpColoursNotMapped.TabStop = false;
            // 
            // btnRefreshUnknownColours
            // 
            btnRefreshUnknownColours.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRefreshUnknownColours.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRefreshUnknownColours.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefreshUnknownColours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefreshUnknownColours.Image = (System.Drawing.Image)resources.GetObject("btnRefreshUnknownColours.Image");
            btnRefreshUnknownColours.Location = new System.Drawing.Point(13, 152);
            btnRefreshUnknownColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRefreshUnknownColours.Name = "btnRefreshUnknownColours";
            btnRefreshUnknownColours.Size = new System.Drawing.Size(41, 40);
            btnRefreshUnknownColours.TabIndex = 6;
            toolTip1.SetToolTip(btnRefreshUnknownColours, "Add mapping");
            btnRefreshUnknownColours.UseVisualStyleBackColor = false;
            // 
            // btnColoursNotMatchedAdd
            // 
            btnColoursNotMatchedAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnColoursNotMatchedAdd.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnColoursNotMatchedAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnColoursNotMatchedAdd.Enabled = false;
            btnColoursNotMatchedAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnColoursNotMatchedAdd.Image = (System.Drawing.Image)resources.GetObject("btnColoursNotMatchedAdd.Image");
            btnColoursNotMatchedAdd.Location = new System.Drawing.Point(539, 152);
            btnColoursNotMatchedAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnColoursNotMatchedAdd.Name = "btnColoursNotMatchedAdd";
            btnColoursNotMatchedAdd.Size = new System.Drawing.Size(41, 40);
            btnColoursNotMatchedAdd.TabIndex = 5;
            toolTip1.SetToolTip(btnColoursNotMatchedAdd, "Add mapping");
            btnColoursNotMatchedAdd.UseVisualStyleBackColor = false;
            // 
            // lblColourNotMapped
            // 
            lblColourNotMapped.BackColor = System.Drawing.Color.Transparent;
            lblColourNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblColourNotMapped.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
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
            lblHeaderColoursNotMatched.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderColoursNotMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblHeaderColoursNotMatched.Location = new System.Drawing.Point(-2, 1);
            lblHeaderColoursNotMatched.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderColoursNotMatched.Name = "lblHeaderColoursNotMatched";
            lblHeaderColoursNotMatched.Size = new System.Drawing.Size(497, 8);
            lblHeaderColoursNotMatched.TabIndex = 0;
            lblHeaderColoursNotMatched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwColoursNotMapped
            // 
            lvwColoursNotMapped.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwColoursNotMapped.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwColoursNotMapped.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader9 });
            lvwColoursNotMapped.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwColoursNotMapped.FullRowSelect = true;
            lvwColoursNotMapped.Location = new System.Drawing.Point(15, 52);
            lvwColoursNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwColoursNotMapped.Name = "lvwColoursNotMapped";
            lvwColoursNotMapped.Size = new System.Drawing.Size(466, 92);
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
            grpColours.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpColours.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
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
            grpColours.Size = new System.Drawing.Size(494, 228);
            grpColours.TabIndex = 0;
            grpColours.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
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
            chkApplyFilterColours.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            chkApplyFilterColours.Cursor = System.Windows.Forms.Cursors.Hand;
            chkApplyFilterColours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkApplyFilterColours.Image = (System.Drawing.Image)resources.GetObject("chkApplyFilterColours.Image");
            chkApplyFilterColours.Location = new System.Drawing.Point(397, 176);
            chkApplyFilterColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkApplyFilterColours.Name = "chkApplyFilterColours";
            chkApplyFilterColours.Size = new System.Drawing.Size(41, 40);
            chkApplyFilterColours.TabIndex = 5;
            toolTip1.SetToolTip(chkApplyFilterColours, "Apply filter");
            chkApplyFilterColours.UseVisualStyleBackColor = false;
            chkApplyFilterColours.CheckedChanged += chkApplyFilterColours_CheckedChanged;
            // 
            // lblHeaderColours
            // 
            lblHeaderColours.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderColours.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblHeaderColours.Location = new System.Drawing.Point(-2, 1);
            lblHeaderColours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderColours.Name = "lblHeaderColours";
            lblHeaderColours.Size = new System.Drawing.Size(497, 8);
            lblHeaderColours.TabIndex = 0;
            lblHeaderColours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFilterColour
            // 
            txtFilterColour.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFilterColour.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtFilterColour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFilterColour.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            txtFilterColour.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtFilterColour.Location = new System.Drawing.Point(107, 184);
            txtFilterColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilterColour.Name = "txtFilterColour";
            txtFilterColour.Size = new System.Drawing.Size(282, 20);
            txtFilterColour.TabIndex = 4;
            // 
            // btnEditColour
            // 
            btnEditColour.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnEditColour.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnEditColour.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditColour.Enabled = false;
            btnEditColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditColour.Image = (System.Drawing.Image)resources.GetObject("btnEditColour.Image");
            btnEditColour.Location = new System.Drawing.Point(443, 176);
            btnEditColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditColour.Name = "btnEditColour";
            btnEditColour.Size = new System.Drawing.Size(41, 40);
            btnEditColour.TabIndex = 6;
            toolTip1.SetToolTip(btnEditColour, "Edit display name");
            btnEditColour.UseVisualStyleBackColor = false;
            btnEditColour.Click += btnEditColour_Click;
            // 
            // lvwColours
            // 
            lvwColours.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwColours.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwColours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader4, columnHeader7, columnHeader8 });
            lvwColours.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwColours.FullRowSelect = true;
            lvwColours.Location = new System.Drawing.Point(15, 52);
            lvwColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwColours.Name = "lvwColours";
            lvwColours.Size = new System.Drawing.Size(466, 117);
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
            btnRemoveColour.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRemoveColour.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveColour.Enabled = false;
            btnRemoveColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveColour.Image = (System.Drawing.Image)resources.GetObject("btnRemoveColour.Image");
            btnRemoveColour.Location = new System.Drawing.Point(61, 176);
            btnRemoveColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveColour.Name = "btnRemoveColour";
            btnRemoveColour.Size = new System.Drawing.Size(41, 40);
            btnRemoveColour.TabIndex = 3;
            toolTip1.SetToolTip(btnRemoveColour, "Remove mapping");
            btnRemoveColour.UseVisualStyleBackColor = false;
            btnRemoveColour.Click += btnRemoveColour_Click;
            // 
            // btnNewColour
            // 
            btnNewColour.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnNewColour.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnNewColour.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNewColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNewColour.Image = (System.Drawing.Image)resources.GetObject("btnNewColour.Image");
            btnNewColour.Location = new System.Drawing.Point(15, 176);
            btnNewColour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNewColour.Name = "btnNewColour";
            btnNewColour.Size = new System.Drawing.Size(41, 40);
            btnNewColour.TabIndex = 2;
            toolTip1.SetToolTip(btnNewColour, "Add new mapping");
            btnNewColour.UseVisualStyleBackColor = false;
            btnNewColour.Click += btnNewColour_Click;
            // 
            // tpgCreatures
            // 
            tpgCreatures.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgCreatures.Controls.Add(grpCreaturesNotMapped);
            tpgCreatures.Controls.Add(grpCreatures);
            tpgCreatures.Location = new System.Drawing.Point(4, 24);
            tpgCreatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgCreatures.Name = "tpgCreatures";
            tpgCreatures.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgCreatures.Size = new System.Drawing.Size(529, 554);
            tpgCreatures.TabIndex = 1;
            tpgCreatures.Text = "Creatures";
            // 
            // grpCreaturesNotMapped
            // 
            grpCreaturesNotMapped.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpCreaturesNotMapped.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpCreaturesNotMapped.Controls.Add(btnRefreshUnknownCreatures);
            grpCreaturesNotMapped.Controls.Add(btnCreaturesNotMappedAdd);
            grpCreaturesNotMapped.Controls.Add(lblCreaturesNotMapped);
            grpCreaturesNotMapped.Controls.Add(lblHeaderCreaturesNotMapped);
            grpCreaturesNotMapped.Controls.Add(lvwCreaturesNotMapped);
            grpCreaturesNotMapped.Location = new System.Drawing.Point(21, 301);
            grpCreaturesNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpCreaturesNotMapped.Name = "grpCreaturesNotMapped";
            grpCreaturesNotMapped.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpCreaturesNotMapped.Size = new System.Drawing.Size(492, 249);
            grpCreaturesNotMapped.TabIndex = 1;
            grpCreaturesNotMapped.TabStop = false;
            // 
            // btnRefreshUnknownCreatures
            // 
            btnRefreshUnknownCreatures.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRefreshUnknownCreatures.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRefreshUnknownCreatures.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefreshUnknownCreatures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefreshUnknownCreatures.Image = (System.Drawing.Image)resources.GetObject("btnRefreshUnknownCreatures.Image");
            btnRefreshUnknownCreatures.Location = new System.Drawing.Point(15, 199);
            btnRefreshUnknownCreatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRefreshUnknownCreatures.Name = "btnRefreshUnknownCreatures";
            btnRefreshUnknownCreatures.Size = new System.Drawing.Size(41, 40);
            btnRefreshUnknownCreatures.TabIndex = 5;
            toolTip1.SetToolTip(btnRefreshUnknownCreatures, "Add mapping");
            btnRefreshUnknownCreatures.UseVisualStyleBackColor = false;
            btnRefreshUnknownCreatures.Click += btnRefreshUnknownCreatures_Click;
            // 
            // btnCreaturesNotMappedAdd
            // 
            btnCreaturesNotMappedAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCreaturesNotMappedAdd.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnCreaturesNotMappedAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCreaturesNotMappedAdd.Enabled = false;
            btnCreaturesNotMappedAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreaturesNotMappedAdd.Image = (System.Drawing.Image)resources.GetObject("btnCreaturesNotMappedAdd.Image");
            btnCreaturesNotMappedAdd.Location = new System.Drawing.Point(440, 199);
            btnCreaturesNotMappedAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCreaturesNotMappedAdd.Name = "btnCreaturesNotMappedAdd";
            btnCreaturesNotMappedAdd.Size = new System.Drawing.Size(41, 40);
            btnCreaturesNotMappedAdd.TabIndex = 3;
            toolTip1.SetToolTip(btnCreaturesNotMappedAdd, "Add mapping");
            btnCreaturesNotMappedAdd.UseVisualStyleBackColor = false;
            btnCreaturesNotMappedAdd.Click += btnCreaturesNotMappedAdd_Click;
            // 
            // lblCreaturesNotMapped
            // 
            lblCreaturesNotMapped.BackColor = System.Drawing.Color.Transparent;
            lblCreaturesNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblCreaturesNotMapped.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
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
            lblHeaderCreaturesNotMapped.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderCreaturesNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblHeaderCreaturesNotMapped.Location = new System.Drawing.Point(-2, 1);
            lblHeaderCreaturesNotMapped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderCreaturesNotMapped.Name = "lblHeaderCreaturesNotMapped";
            lblHeaderCreaturesNotMapped.Size = new System.Drawing.Size(495, 8);
            lblHeaderCreaturesNotMapped.TabIndex = 0;
            lblHeaderCreaturesNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwCreaturesNotMapped
            // 
            lvwCreaturesNotMapped.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwCreaturesNotMapped.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwCreaturesNotMapped.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader12 });
            lvwCreaturesNotMapped.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwCreaturesNotMapped.FullRowSelect = true;
            lvwCreaturesNotMapped.Location = new System.Drawing.Point(15, 52);
            lvwCreaturesNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwCreaturesNotMapped.Name = "lvwCreaturesNotMapped";
            lvwCreaturesNotMapped.Size = new System.Drawing.Size(464, 140);
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
            grpCreatures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpCreatures.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
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
            grpCreatures.Size = new System.Drawing.Size(492, 283);
            grpCreatures.TabIndex = 0;
            grpCreatures.TabStop = false;
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            label6.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
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
            chkApplyFilterDinos.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            chkApplyFilterDinos.Appearance = System.Windows.Forms.Appearance.Button;
            chkApplyFilterDinos.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            chkApplyFilterDinos.Cursor = System.Windows.Forms.Cursors.Hand;
            chkApplyFilterDinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkApplyFilterDinos.Image = (System.Drawing.Image)resources.GetObject("chkApplyFilterDinos.Image");
            chkApplyFilterDinos.Location = new System.Drawing.Point(395, 231);
            chkApplyFilterDinos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkApplyFilterDinos.Name = "chkApplyFilterDinos";
            chkApplyFilterDinos.Size = new System.Drawing.Size(41, 40);
            chkApplyFilterDinos.TabIndex = 7;
            chkApplyFilterDinos.UseVisualStyleBackColor = false;
            chkApplyFilterDinos.CheckedChanged += chkApplyFilterDinos_CheckedChanged;
            // 
            // lblHeaderCreatures
            // 
            lblHeaderCreatures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderCreatures.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderCreatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblHeaderCreatures.Location = new System.Drawing.Point(-2, 1);
            lblHeaderCreatures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderCreatures.Name = "lblHeaderCreatures";
            lblHeaderCreatures.Size = new System.Drawing.Size(495, 8);
            lblHeaderCreatures.TabIndex = 1;
            lblHeaderCreatures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCreatureFilter
            // 
            txtCreatureFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCreatureFilter.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtCreatureFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtCreatureFilter.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            txtCreatureFilter.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtCreatureFilter.Location = new System.Drawing.Point(107, 339);
            txtCreatureFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCreatureFilter.Name = "txtCreatureFilter";
            txtCreatureFilter.Size = new System.Drawing.Size(280, 20);
            txtCreatureFilter.TabIndex = 6;
            txtCreatureFilter.TextChanged += txtCreatureFilter_TextChanged;
            txtCreatureFilter.Validating += txtCreatureFilter_Validating;
            // 
            // lvwDinoClasses
            // 
            lvwDinoClasses.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwDinoClasses.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwDinoClasses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvwDinoClasses_ClassName, lvwDinoClasses_DisplayName });
            lvwDinoClasses.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwDinoClasses.FullRowSelect = true;
            lvwDinoClasses.Location = new System.Drawing.Point(15, 52);
            lvwDinoClasses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwDinoClasses.Name = "lvwDinoClasses";
            lvwDinoClasses.Size = new System.Drawing.Size(464, 172);
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
            btnEditDinoClass.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnEditDinoClass.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnEditDinoClass.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditDinoClass.Enabled = false;
            btnEditDinoClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditDinoClass.Image = (System.Drawing.Image)resources.GetObject("btnEditDinoClass.Image");
            btnEditDinoClass.Location = new System.Drawing.Point(441, 231);
            btnEditDinoClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditDinoClass.Name = "btnEditDinoClass";
            btnEditDinoClass.Size = new System.Drawing.Size(41, 40);
            btnEditDinoClass.TabIndex = 0;
            toolTip1.SetToolTip(btnEditDinoClass, "Edit display name");
            btnEditDinoClass.UseVisualStyleBackColor = false;
            btnEditDinoClass.Click += btnEditDinoClass_Click;
            // 
            // btnAddDinoClass
            // 
            btnAddDinoClass.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAddDinoClass.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnAddDinoClass.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddDinoClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddDinoClass.Image = (System.Drawing.Image)resources.GetObject("btnAddDinoClass.Image");
            btnAddDinoClass.Location = new System.Drawing.Point(15, 230);
            btnAddDinoClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddDinoClass.Name = "btnAddDinoClass";
            btnAddDinoClass.Size = new System.Drawing.Size(41, 40);
            btnAddDinoClass.TabIndex = 4;
            toolTip1.SetToolTip(btnAddDinoClass, "Add new display name");
            btnAddDinoClass.UseVisualStyleBackColor = false;
            btnAddDinoClass.Click += btnAddDinoClass_Click;
            // 
            // btnRemoveDinoClass
            // 
            btnRemoveDinoClass.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRemoveDinoClass.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRemoveDinoClass.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveDinoClass.Enabled = false;
            btnRemoveDinoClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveDinoClass.Image = (System.Drawing.Image)resources.GetObject("btnRemoveDinoClass.Image");
            btnRemoveDinoClass.Location = new System.Drawing.Point(61, 230);
            btnRemoveDinoClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveDinoClass.Name = "btnRemoveDinoClass";
            btnRemoveDinoClass.Size = new System.Drawing.Size(41, 40);
            btnRemoveDinoClass.TabIndex = 5;
            toolTip1.SetToolTip(btnRemoveDinoClass, "Remove display name");
            btnRemoveDinoClass.UseVisualStyleBackColor = false;
            btnRemoveDinoClass.Click += btnRemoveDinoClass_Click;
            // 
            // tpgStructures
            // 
            tpgStructures.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgStructures.Controls.Add(grpStructuresNotMapped);
            tpgStructures.Controls.Add(grpStructures);
            tpgStructures.Location = new System.Drawing.Point(4, 24);
            tpgStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgStructures.Name = "tpgStructures";
            tpgStructures.Size = new System.Drawing.Size(529, 554);
            tpgStructures.TabIndex = 4;
            tpgStructures.Text = "Structures";
            // 
            // grpStructuresNotMapped
            // 
            grpStructuresNotMapped.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpStructuresNotMapped.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpStructuresNotMapped.Controls.Add(btnRefreshUnknownStructures);
            grpStructuresNotMapped.Controls.Add(btnStructuresNotMappedAdd);
            grpStructuresNotMapped.Controls.Add(lblStructuresNotMapped);
            grpStructuresNotMapped.Controls.Add(lblHeaderStructuresNotMapped);
            grpStructuresNotMapped.Controls.Add(lvwStructuresNotMapped);
            grpStructuresNotMapped.Location = new System.Drawing.Point(21, 268);
            grpStructuresNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpStructuresNotMapped.Name = "grpStructuresNotMapped";
            grpStructuresNotMapped.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpStructuresNotMapped.Size = new System.Drawing.Size(490, 282);
            grpStructuresNotMapped.TabIndex = 1;
            grpStructuresNotMapped.TabStop = false;
            // 
            // btnRefreshUnknownStructures
            // 
            btnRefreshUnknownStructures.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRefreshUnknownStructures.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRefreshUnknownStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefreshUnknownStructures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefreshUnknownStructures.Image = (System.Drawing.Image)resources.GetObject("btnRefreshUnknownStructures.Image");
            btnRefreshUnknownStructures.Location = new System.Drawing.Point(15, 232);
            btnRefreshUnknownStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRefreshUnknownStructures.Name = "btnRefreshUnknownStructures";
            btnRefreshUnknownStructures.Size = new System.Drawing.Size(41, 40);
            btnRefreshUnknownStructures.TabIndex = 5;
            toolTip1.SetToolTip(btnRefreshUnknownStructures, "Add mapping");
            btnRefreshUnknownStructures.UseVisualStyleBackColor = false;
            btnRefreshUnknownStructures.Click += btnRefreshUnknownStructures_Click;
            // 
            // btnStructuresNotMappedAdd
            // 
            btnStructuresNotMappedAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnStructuresNotMappedAdd.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnStructuresNotMappedAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnStructuresNotMappedAdd.Enabled = false;
            btnStructuresNotMappedAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStructuresNotMappedAdd.Image = (System.Drawing.Image)resources.GetObject("btnStructuresNotMappedAdd.Image");
            btnStructuresNotMappedAdd.Location = new System.Drawing.Point(438, 232);
            btnStructuresNotMappedAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStructuresNotMappedAdd.Name = "btnStructuresNotMappedAdd";
            btnStructuresNotMappedAdd.Size = new System.Drawing.Size(41, 40);
            btnStructuresNotMappedAdd.TabIndex = 3;
            toolTip1.SetToolTip(btnStructuresNotMappedAdd, "Add mapping");
            btnStructuresNotMappedAdd.UseVisualStyleBackColor = false;
            btnStructuresNotMappedAdd.Click += btnStructuresNotMappedAdd_Click;
            // 
            // lblStructuresNotMapped
            // 
            lblStructuresNotMapped.BackColor = System.Drawing.Color.Transparent;
            lblStructuresNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblStructuresNotMapped.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
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
            lblHeaderStructuresNotMapped.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderStructuresNotMapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblHeaderStructuresNotMapped.Location = new System.Drawing.Point(-2, 1);
            lblHeaderStructuresNotMapped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderStructuresNotMapped.Name = "lblHeaderStructuresNotMapped";
            lblHeaderStructuresNotMapped.Size = new System.Drawing.Size(493, 8);
            lblHeaderStructuresNotMapped.TabIndex = 0;
            lblHeaderStructuresNotMapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwStructuresNotMapped
            // 
            lvwStructuresNotMapped.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwStructuresNotMapped.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwStructuresNotMapped.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader10 });
            lvwStructuresNotMapped.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwStructuresNotMapped.FullRowSelect = true;
            lvwStructuresNotMapped.Location = new System.Drawing.Point(15, 52);
            lvwStructuresNotMapped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwStructuresNotMapped.Name = "lvwStructuresNotMapped";
            lvwStructuresNotMapped.Size = new System.Drawing.Size(462, 173);
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
            grpStructures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpStructures.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
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
            grpStructures.Size = new System.Drawing.Size(490, 250);
            grpStructures.TabIndex = 0;
            grpStructures.TabStop = false;
            // 
            // chkApplyFilterStructures
            // 
            chkApplyFilterStructures.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            chkApplyFilterStructures.Appearance = System.Windows.Forms.Appearance.Button;
            chkApplyFilterStructures.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            chkApplyFilterStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            chkApplyFilterStructures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkApplyFilterStructures.Image = (System.Drawing.Image)resources.GetObject("chkApplyFilterStructures.Image");
            chkApplyFilterStructures.Location = new System.Drawing.Point(393, 198);
            chkApplyFilterStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkApplyFilterStructures.Name = "chkApplyFilterStructures";
            chkApplyFilterStructures.Size = new System.Drawing.Size(41, 40);
            chkApplyFilterStructures.TabIndex = 5;
            toolTip1.SetToolTip(chkApplyFilterStructures, "Apply/Remove filter");
            chkApplyFilterStructures.UseVisualStyleBackColor = false;
            chkApplyFilterStructures.CheckedChanged += chkApplyFilterStructures_CheckedChanged;
            // 
            // lblHeaderStructures
            // 
            lblHeaderStructures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderStructures.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderStructures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblHeaderStructures.Location = new System.Drawing.Point(-2, 1);
            lblHeaderStructures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderStructures.Name = "lblHeaderStructures";
            lblHeaderStructures.Size = new System.Drawing.Size(493, 8);
            lblHeaderStructures.TabIndex = 0;
            lblHeaderStructures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStructureFilter
            // 
            txtStructureFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtStructureFilter.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtStructureFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtStructureFilter.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            txtStructureFilter.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtStructureFilter.Location = new System.Drawing.Point(107, 206);
            txtStructureFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtStructureFilter.Name = "txtStructureFilter";
            txtStructureFilter.Size = new System.Drawing.Size(278, 20);
            txtStructureFilter.TabIndex = 4;
            // 
            // lvwStructureMap
            // 
            lvwStructureMap.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwStructureMap.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwStructureMap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader5, columnHeader6 });
            lvwStructureMap.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwStructureMap.FullRowSelect = true;
            lvwStructureMap.Location = new System.Drawing.Point(15, 22);
            lvwStructureMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwStructureMap.Name = "lvwStructureMap";
            lvwStructureMap.Size = new System.Drawing.Size(462, 169);
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
            btnEditStructure.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnEditStructure.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnEditStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditStructure.Enabled = false;
            btnEditStructure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditStructure.Image = (System.Drawing.Image)resources.GetObject("btnEditStructure.Image");
            btnEditStructure.Location = new System.Drawing.Point(439, 198);
            btnEditStructure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditStructure.Name = "btnEditStructure";
            btnEditStructure.Size = new System.Drawing.Size(41, 40);
            btnEditStructure.TabIndex = 6;
            toolTip1.SetToolTip(btnEditStructure, "Edit display name");
            btnEditStructure.UseVisualStyleBackColor = false;
            btnEditStructure.Click += btnEditStructure_Click;
            // 
            // btnAddStructure
            // 
            btnAddStructure.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAddStructure.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnAddStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddStructure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddStructure.Image = (System.Drawing.Image)resources.GetObject("btnAddStructure.Image");
            btnAddStructure.Location = new System.Drawing.Point(15, 198);
            btnAddStructure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddStructure.Name = "btnAddStructure";
            btnAddStructure.Size = new System.Drawing.Size(41, 40);
            btnAddStructure.TabIndex = 2;
            toolTip1.SetToolTip(btnAddStructure, "Add new display name");
            btnAddStructure.UseVisualStyleBackColor = false;
            btnAddStructure.Click += btnAddStructure_Click;
            // 
            // btnRemoveStructure
            // 
            btnRemoveStructure.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRemoveStructure.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRemoveStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveStructure.Enabled = false;
            btnRemoveStructure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveStructure.Image = (System.Drawing.Image)resources.GetObject("btnRemoveStructure.Image");
            btnRemoveStructure.Location = new System.Drawing.Point(61, 198);
            btnRemoveStructure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveStructure.Name = "btnRemoveStructure";
            btnRemoveStructure.Size = new System.Drawing.Size(41, 40);
            btnRemoveStructure.TabIndex = 3;
            toolTip1.SetToolTip(btnRemoveStructure, "Remove display name");
            btnRemoveStructure.UseVisualStyleBackColor = false;
            btnRemoveStructure.Click += btnRemoveStructure_Click;
            // 
            // tpgItems
            // 
            tpgItems.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgItems.Controls.Add(grpItemsNotMatched);
            tpgItems.Controls.Add(grpItems);
            tpgItems.Location = new System.Drawing.Point(4, 24);
            tpgItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgItems.Name = "tpgItems";
            tpgItems.Size = new System.Drawing.Size(529, 554);
            tpgItems.TabIndex = 2;
            tpgItems.Text = "Items";
            // 
            // grpItemsNotMatched
            // 
            grpItemsNotMatched.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpItemsNotMatched.Controls.Add(btnRefreshUnknownItems);
            grpItemsNotMatched.Controls.Add(btnItemsNotMatchedAdd);
            grpItemsNotMatched.Controls.Add(lblItemsNotMatched);
            grpItemsNotMatched.Controls.Add(lblHeaderItemsNotMatched);
            grpItemsNotMatched.Controls.Add(lvwItemsNotMatched);
            grpItemsNotMatched.Location = new System.Drawing.Point(21, 284);
            grpItemsNotMatched.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpItemsNotMatched.Name = "grpItemsNotMatched";
            grpItemsNotMatched.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpItemsNotMatched.Size = new System.Drawing.Size(517, 266);
            grpItemsNotMatched.TabIndex = 1;
            grpItemsNotMatched.TabStop = false;
            // 
            // btnRefreshUnknownItems
            // 
            btnRefreshUnknownItems.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRefreshUnknownItems.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRefreshUnknownItems.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefreshUnknownItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefreshUnknownItems.Image = (System.Drawing.Image)resources.GetObject("btnRefreshUnknownItems.Image");
            btnRefreshUnknownItems.Location = new System.Drawing.Point(15, 216);
            btnRefreshUnknownItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRefreshUnknownItems.Name = "btnRefreshUnknownItems";
            btnRefreshUnknownItems.Size = new System.Drawing.Size(41, 40);
            btnRefreshUnknownItems.TabIndex = 5;
            toolTip1.SetToolTip(btnRefreshUnknownItems, "Add mapping");
            btnRefreshUnknownItems.UseVisualStyleBackColor = false;
            btnRefreshUnknownItems.Click += btnRefreshUnknownItems_Click;
            // 
            // btnItemsNotMatchedAdd
            // 
            btnItemsNotMatchedAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnItemsNotMatchedAdd.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnItemsNotMatchedAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnItemsNotMatchedAdd.Enabled = false;
            btnItemsNotMatchedAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnItemsNotMatchedAdd.Image = (System.Drawing.Image)resources.GetObject("btnItemsNotMatchedAdd.Image");
            btnItemsNotMatchedAdd.Location = new System.Drawing.Point(465, 216);
            btnItemsNotMatchedAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnItemsNotMatchedAdd.Name = "btnItemsNotMatchedAdd";
            btnItemsNotMatchedAdd.Size = new System.Drawing.Size(41, 40);
            btnItemsNotMatchedAdd.TabIndex = 3;
            toolTip1.SetToolTip(btnItemsNotMatchedAdd, "Add mapping");
            btnItemsNotMatchedAdd.UseVisualStyleBackColor = false;
            btnItemsNotMatchedAdd.Click += btnItemsNotMatchedAdd_Click;
            // 
            // lblItemsNotMatched
            // 
            lblItemsNotMatched.BackColor = System.Drawing.Color.Transparent;
            lblItemsNotMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblItemsNotMatched.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
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
            lblHeaderItemsNotMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblHeaderItemsNotMatched.Location = new System.Drawing.Point(-2, 2);
            lblHeaderItemsNotMatched.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderItemsNotMatched.Name = "lblHeaderItemsNotMatched";
            lblHeaderItemsNotMatched.Size = new System.Drawing.Size(520, 8);
            lblHeaderItemsNotMatched.TabIndex = 0;
            lblHeaderItemsNotMatched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwItemsNotMatched
            // 
            lvwItemsNotMatched.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwItemsNotMatched.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwItemsNotMatched.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader11 });
            lvwItemsNotMatched.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwItemsNotMatched.FullRowSelect = true;
            lvwItemsNotMatched.Location = new System.Drawing.Point(15, 52);
            lvwItemsNotMatched.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwItemsNotMatched.Name = "lvwItemsNotMatched";
            lvwItemsNotMatched.Size = new System.Drawing.Size(489, 157);
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
            grpItems.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpItems.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
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
            grpItems.Size = new System.Drawing.Size(517, 266);
            grpItems.TabIndex = 0;
            grpItems.TabStop = false;
            // 
            // chkApplyFilterItems
            // 
            chkApplyFilterItems.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            chkApplyFilterItems.Appearance = System.Windows.Forms.Appearance.Button;
            chkApplyFilterItems.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            chkApplyFilterItems.Cursor = System.Windows.Forms.Cursors.Hand;
            chkApplyFilterItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkApplyFilterItems.Image = (System.Drawing.Image)resources.GetObject("chkApplyFilterItems.Image");
            chkApplyFilterItems.Location = new System.Drawing.Point(420, 214);
            chkApplyFilterItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkApplyFilterItems.Name = "chkApplyFilterItems";
            chkApplyFilterItems.Size = new System.Drawing.Size(41, 40);
            chkApplyFilterItems.TabIndex = 5;
            chkApplyFilterItems.UseVisualStyleBackColor = false;
            chkApplyFilterItems.CheckedChanged += chkApplyFilterItems_CheckedChanged;
            // 
            // lblHeaderItems
            // 
            lblHeaderItems.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderItems.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblHeaderItems.Location = new System.Drawing.Point(-2, 1);
            lblHeaderItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderItems.Name = "lblHeaderItems";
            lblHeaderItems.Size = new System.Drawing.Size(520, 8);
            lblHeaderItems.TabIndex = 0;
            lblHeaderItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtItemFilter
            // 
            txtItemFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtItemFilter.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtItemFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtItemFilter.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtItemFilter.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            txtItemFilter.Location = new System.Drawing.Point(107, 222);
            txtItemFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtItemFilter.Name = "txtItemFilter";
            txtItemFilter.Size = new System.Drawing.Size(305, 20);
            txtItemFilter.TabIndex = 4;
            txtItemFilter.TextChanged += txtItemFilter_TextChanged;
            txtItemFilter.Validating += txtItemFilter_Validating;
            // 
            // lvwItemMap
            // 
            lvwItemMap.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvwItemMap.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lvwItemMap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader3, columnHeader1, columnHeader2 });
            lvwItemMap.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lvwItemMap.FullRowSelect = true;
            lvwItemMap.Location = new System.Drawing.Point(15, 22);
            lvwItemMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwItemMap.Name = "lvwItemMap";
            lvwItemMap.Size = new System.Drawing.Size(489, 185);
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
            btnEditItem.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnEditItem.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnEditItem.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditItem.Enabled = false;
            btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditItem.Image = (System.Drawing.Image)resources.GetObject("btnEditItem.Image");
            btnEditItem.Location = new System.Drawing.Point(466, 214);
            btnEditItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new System.Drawing.Size(41, 40);
            btnEditItem.TabIndex = 6;
            toolTip1.SetToolTip(btnEditItem, "Edit display name");
            btnEditItem.UseVisualStyleBackColor = false;
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAddItem.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddItem.Image = (System.Drawing.Image)resources.GetObject("btnAddItem.Image");
            btnAddItem.Location = new System.Drawing.Point(15, 214);
            btnAddItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new System.Drawing.Size(41, 40);
            btnAddItem.TabIndex = 2;
            toolTip1.SetToolTip(btnAddItem, "Add new display name");
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveItem.Enabled = false;
            btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveItem.Image = (System.Drawing.Image)resources.GetObject("btnRemoveItem.Image");
            btnRemoveItem.Location = new System.Drawing.Point(61, 214);
            btnRemoveItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new System.Drawing.Size(41, 40);
            btnRemoveItem.TabIndex = 3;
            toolTip1.SetToolTip(btnRemoveItem, "Remove display name");
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // tpgExport
            // 
            tpgExport.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgExport.Controls.Add(grpJsonExport);
            tpgExport.Controls.Add(grpContentPack);
            tpgExport.Location = new System.Drawing.Point(4, 24);
            tpgExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgExport.Name = "tpgExport";
            tpgExport.Size = new System.Drawing.Size(529, 554);
            tpgExport.TabIndex = 6;
            tpgExport.Text = "Export";
            // 
            // grpJsonExport
            // 
            grpJsonExport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpJsonExport.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
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
            grpJsonExport.Location = new System.Drawing.Point(26, 340);
            grpJsonExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpJsonExport.Name = "grpJsonExport";
            grpJsonExport.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpJsonExport.Size = new System.Drawing.Size(482, 210);
            grpJsonExport.TabIndex = 1;
            grpJsonExport.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            label7.Location = new System.Drawing.Point(248, 170);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(93, 13);
            label7.TabIndex = 14;
            label7.Text = "Map Structures";
            // 
            // btnJsonExportMapStructures
            // 
            btnJsonExportMapStructures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnJsonExportMapStructures.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnJsonExportMapStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJsonExportMapStructures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnJsonExportMapStructures.Image = (System.Drawing.Image)resources.GetObject("btnJsonExportMapStructures.Image");
            btnJsonExportMapStructures.Location = new System.Drawing.Point(405, 160);
            btnJsonExportMapStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnJsonExportMapStructures.Name = "btnJsonExportMapStructures";
            btnJsonExportMapStructures.Size = new System.Drawing.Size(32, 30);
            btnJsonExportMapStructures.TabIndex = 15;
            toolTip1.SetToolTip(btnJsonExportMapStructures, "Export tamed data");
            btnJsonExportMapStructures.UseVisualStyleBackColor = false;
            btnJsonExportMapStructures.Click += btnJsonExportMapStructures_Click;
            // 
            // lblExportPlayerStructures
            // 
            lblExportPlayerStructures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblExportPlayerStructures.AutoSize = true;
            lblExportPlayerStructures.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            lblExportPlayerStructures.Location = new System.Drawing.Point(248, 133);
            lblExportPlayerStructures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExportPlayerStructures.Name = "lblExportPlayerStructures";
            lblExportPlayerStructures.Size = new System.Drawing.Size(104, 13);
            lblExportPlayerStructures.TabIndex = 12;
            lblExportPlayerStructures.Text = "Player Structures";
            // 
            // btnJsonExportPlayerStructures
            // 
            btnJsonExportPlayerStructures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnJsonExportPlayerStructures.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnJsonExportPlayerStructures.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJsonExportPlayerStructures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnJsonExportPlayerStructures.Image = (System.Drawing.Image)resources.GetObject("btnJsonExportPlayerStructures.Image");
            btnJsonExportPlayerStructures.Location = new System.Drawing.Point(405, 123);
            btnJsonExportPlayerStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnJsonExportPlayerStructures.Name = "btnJsonExportPlayerStructures";
            btnJsonExportPlayerStructures.Size = new System.Drawing.Size(32, 30);
            btnJsonExportPlayerStructures.TabIndex = 13;
            toolTip1.SetToolTip(btnJsonExportPlayerStructures, "Export structure data");
            btnJsonExportPlayerStructures.UseVisualStyleBackColor = false;
            btnJsonExportPlayerStructures.Click += btnJsonExportPlayerStructures_Click;
            // 
            // lblExportTamed
            // 
            lblExportTamed.AutoSize = true;
            lblExportTamed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            lblExportTamed.Location = new System.Drawing.Point(22, 133);
            lblExportTamed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExportTamed.Name = "lblExportTamed";
            lblExportTamed.Size = new System.Drawing.Size(121, 13);
            lblExportTamed.TabIndex = 6;
            lblExportTamed.Text = "All Tamed Creatures";
            // 
            // btnJsonExportTamed
            // 
            btnJsonExportTamed.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnJsonExportTamed.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJsonExportTamed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnJsonExportTamed.Image = (System.Drawing.Image)resources.GetObject("btnJsonExportTamed.Image");
            btnJsonExportTamed.Location = new System.Drawing.Point(156, 123);
            btnJsonExportTamed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnJsonExportTamed.Name = "btnJsonExportTamed";
            btnJsonExportTamed.Size = new System.Drawing.Size(32, 30);
            btnJsonExportTamed.TabIndex = 7;
            toolTip1.SetToolTip(btnJsonExportTamed, "Export tamed data");
            btnJsonExportTamed.UseVisualStyleBackColor = false;
            btnJsonExportTamed.Click += btnJsonExportTamed_Click;
            // 
            // lblExportPlayers
            // 
            lblExportPlayers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblExportPlayers.AutoSize = true;
            lblExportPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            lblExportPlayers.Location = new System.Drawing.Point(248, 95);
            lblExportPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExportPlayers.Name = "lblExportPlayers";
            lblExportPlayers.Size = new System.Drawing.Size(73, 13);
            lblExportPlayers.TabIndex = 10;
            lblExportPlayers.Text = "Player Data";
            // 
            // btnJsonExportPlayers
            // 
            btnJsonExportPlayers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnJsonExportPlayers.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnJsonExportPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJsonExportPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnJsonExportPlayers.Image = (System.Drawing.Image)resources.GetObject("btnJsonExportPlayers.Image");
            btnJsonExportPlayers.Location = new System.Drawing.Point(405, 87);
            btnJsonExportPlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnJsonExportPlayers.Name = "btnJsonExportPlayers";
            btnJsonExportPlayers.Size = new System.Drawing.Size(32, 30);
            btnJsonExportPlayers.TabIndex = 11;
            toolTip1.SetToolTip(btnJsonExportPlayers, "Export player data");
            btnJsonExportPlayers.UseVisualStyleBackColor = false;
            btnJsonExportPlayers.Click += btnJsonExportPlayers_Click;
            // 
            // lblExportTribes
            // 
            lblExportTribes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblExportTribes.AutoSize = true;
            lblExportTribes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            lblExportTribes.Location = new System.Drawing.Point(248, 60);
            lblExportTribes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExportTribes.Name = "lblExportTribes";
            lblExportTribes.Size = new System.Drawing.Size(67, 13);
            lblExportTribes.TabIndex = 8;
            lblExportTribes.Text = "Tribe Data";
            // 
            // btnJsonExportTribes
            // 
            btnJsonExportTribes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnJsonExportTribes.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnJsonExportTribes.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJsonExportTribes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnJsonExportTribes.Image = (System.Drawing.Image)resources.GetObject("btnJsonExportTribes.Image");
            btnJsonExportTribes.Location = new System.Drawing.Point(405, 51);
            btnJsonExportTribes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnJsonExportTribes.Name = "btnJsonExportTribes";
            btnJsonExportTribes.Size = new System.Drawing.Size(32, 30);
            btnJsonExportTribes.TabIndex = 9;
            toolTip1.SetToolTip(btnJsonExportTribes, "Export tribe data");
            btnJsonExportTribes.UseVisualStyleBackColor = false;
            btnJsonExportTribes.Click += btnJsonExportTribes_Click;
            // 
            // lblExportWild
            // 
            lblExportWild.AutoSize = true;
            lblExportWild.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            lblExportWild.Location = new System.Drawing.Point(22, 95);
            lblExportWild.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExportWild.Name = "lblExportWild";
            lblExportWild.Size = new System.Drawing.Size(108, 13);
            lblExportWild.TabIndex = 4;
            lblExportWild.Text = "All Wild Creatures";
            // 
            // btnJsonExportWild
            // 
            btnJsonExportWild.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnJsonExportWild.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJsonExportWild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnJsonExportWild.Image = (System.Drawing.Image)resources.GetObject("btnJsonExportWild.Image");
            btnJsonExportWild.Location = new System.Drawing.Point(156, 87);
            btnJsonExportWild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnJsonExportWild.Name = "btnJsonExportWild";
            btnJsonExportWild.Size = new System.Drawing.Size(32, 30);
            btnJsonExportWild.TabIndex = 5;
            toolTip1.SetToolTip(btnJsonExportWild, "Export wild data");
            btnJsonExportWild.UseVisualStyleBackColor = false;
            btnJsonExportWild.Click += btnJsonExportWild_Click;
            // 
            // lblExportAll
            // 
            lblExportAll.AutoSize = true;
            lblExportAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            lblExportAll.Location = new System.Drawing.Point(22, 60);
            lblExportAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExportAll.Name = "lblExportAll";
            lblExportAll.Size = new System.Drawing.Size(77, 13);
            lblExportAll.TabIndex = 2;
            lblExportAll.Text = "All Available";
            // 
            // btnJsonExportAll
            // 
            btnJsonExportAll.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnJsonExportAll.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJsonExportAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnJsonExportAll.Image = (System.Drawing.Image)resources.GetObject("btnJsonExportAll.Image");
            btnJsonExportAll.Location = new System.Drawing.Point(156, 51);
            btnJsonExportAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnJsonExportAll.Name = "btnJsonExportAll";
            btnJsonExportAll.Size = new System.Drawing.Size(32, 30);
            btnJsonExportAll.TabIndex = 3;
            toolTip1.SetToolTip(btnJsonExportAll, "Export all data");
            btnJsonExportAll.UseVisualStyleBackColor = false;
            btnJsonExportAll.Click += btnJsonExportAll_Click;
            // 
            // lblHeaderJsonExport
            // 
            lblHeaderJsonExport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderJsonExport.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderJsonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblHeaderJsonExport.Location = new System.Drawing.Point(0, 2);
            lblHeaderJsonExport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderJsonExport.Name = "lblHeaderJsonExport";
            lblHeaderJsonExport.Size = new System.Drawing.Size(485, 7);
            lblHeaderJsonExport.TabIndex = 0;
            lblHeaderJsonExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJsonFileExport
            // 
            lblJsonFileExport.BackColor = System.Drawing.Color.Transparent;
            lblJsonFileExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblJsonFileExport.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
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
            grpContentPack.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpContentPack.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
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
            grpContentPack.Size = new System.Drawing.Size(482, 321);
            grpContentPack.TabIndex = 0;
            grpContentPack.TabStop = false;
            // 
            // chkDroppedItems
            // 
            chkDroppedItems.AutoSize = true;
            chkDroppedItems.Location = new System.Drawing.Point(33, 98);
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
            chkStructureContents.Location = new System.Drawing.Point(33, 71);
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
            chkStructureLocations.Location = new System.Drawing.Point(33, 45);
            chkStructureLocations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkStructureLocations.Name = "chkStructureLocations";
            chkStructureLocations.Size = new System.Drawing.Size(155, 19);
            chkStructureLocations.TabIndex = 2;
            chkStructureLocations.Text = "Map Structure Locations";
            chkStructureLocations.UseVisualStyleBackColor = true;
            // 
            // btnExportContentPack
            // 
            btnExportContentPack.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnExportContentPack.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnExportContentPack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExportContentPack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExportContentPack.Image = (System.Drawing.Image)resources.GetObject("btnExportContentPack.Image");
            btnExportContentPack.Location = new System.Drawing.Point(405, 264);
            btnExportContentPack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExportContentPack.Name = "btnExportContentPack";
            btnExportContentPack.Size = new System.Drawing.Size(32, 30);
            btnExportContentPack.TabIndex = 20;
            toolTip1.SetToolTip(btnExportContentPack, "Export content pack");
            btnExportContentPack.UseVisualStyleBackColor = false;
            btnExportContentPack.Click += btnExportContentPack_Click;
            // 
            // udExportRadius
            // 
            udExportRadius.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udExportRadius.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udExportRadius.DecimalPlaces = 2;
            udExportRadius.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udExportRadius.Location = new System.Drawing.Point(144, 285);
            udExportRadius.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udExportRadius.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            udExportRadius.Name = "udExportRadius";
            udExportRadius.Size = new System.Drawing.Size(75, 19);
            udExportRadius.TabIndex = 19;
            udExportRadius.Value = new decimal(new int[] { 10000, 0, 0, 131072 });
            // 
            // udExportLon
            // 
            udExportLon.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udExportLon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udExportLon.DecimalPlaces = 2;
            udExportLon.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udExportLon.Location = new System.Drawing.Point(144, 259);
            udExportLon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udExportLon.Name = "udExportLon";
            udExportLon.Size = new System.Drawing.Size(75, 19);
            udExportLon.TabIndex = 17;
            udExportLon.Value = new decimal(new int[] { 5000, 0, 0, 131072 });
            // 
            // udExportLat
            // 
            udExportLat.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udExportLat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udExportLat.DecimalPlaces = 2;
            udExportLat.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udExportLat.Location = new System.Drawing.Point(144, 233);
            udExportLat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udExportLat.Name = "udExportLat";
            udExportLat.Size = new System.Drawing.Size(75, 19);
            udExportLat.TabIndex = 15;
            udExportLat.Value = new decimal(new int[] { 5000, 0, 0, 131072 });
            // 
            // lblFilterRad
            // 
            lblFilterRad.AutoSize = true;
            lblFilterRad.Location = new System.Drawing.Point(29, 285);
            lblFilterRad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFilterRad.Name = "lblFilterRad";
            lblFilterRad.Size = new System.Drawing.Size(45, 15);
            lblFilterRad.TabIndex = 18;
            lblFilterRad.Text = "Radius:";
            // 
            // cboExportPlayer
            // 
            cboExportPlayer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboExportPlayer.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboExportPlayer.BorderColor = System.Drawing.Color.FromArgb(125, 125, 125);
            cboExportPlayer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboExportPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboExportPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboExportPlayer.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboExportPlayer.FormattingEnabled = true;
            cboExportPlayer.Location = new System.Drawing.Point(144, 201);
            cboExportPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboExportPlayer.Name = "cboExportPlayer";
            cboExportPlayer.Size = new System.Drawing.Size(293, 24);
            cboExportPlayer.TabIndex = 13;
            cboExportPlayer.DrawItem += ownerDrawCombo_DrawItem;
            // 
            // cboExportTribe
            // 
            cboExportTribe.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboExportTribe.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboExportTribe.BorderColor = System.Drawing.Color.FromArgb(125, 125, 125);
            cboExportTribe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboExportTribe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboExportTribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboExportTribe.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboExportTribe.FormattingEnabled = true;
            cboExportTribe.Location = new System.Drawing.Point(144, 171);
            cboExportTribe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboExportTribe.Name = "cboExportTribe";
            cboExportTribe.Size = new System.Drawing.Size(293, 24);
            cboExportTribe.TabIndex = 11;
            cboExportTribe.DrawItem += ownerDrawCombo_DrawItem;
            cboExportTribe.SelectedIndexChanged += cboExportTribe_SelectedIndexChanged;
            // 
            // lblFilterLon
            // 
            lblFilterLon.AutoSize = true;
            lblFilterLon.Location = new System.Drawing.Point(29, 259);
            lblFilterLon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFilterLon.Name = "lblFilterLon";
            lblFilterLon.Size = new System.Drawing.Size(64, 15);
            lblFilterLon.TabIndex = 16;
            lblFilterLon.Text = "Longitude:";
            // 
            // lblFilterLat
            // 
            lblFilterLat.AutoSize = true;
            lblFilterLat.Location = new System.Drawing.Point(29, 233);
            lblFilterLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFilterLat.Name = "lblFilterLat";
            lblFilterLat.Size = new System.Drawing.Size(53, 15);
            lblFilterLat.TabIndex = 14;
            lblFilterLat.Text = "Latitude:";
            // 
            // lblFilterPlayer
            // 
            lblFilterPlayer.AutoSize = true;
            lblFilterPlayer.Location = new System.Drawing.Point(29, 204);
            lblFilterPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFilterPlayer.Name = "lblFilterPlayer";
            lblFilterPlayer.Size = new System.Drawing.Size(89, 15);
            lblFilterPlayer.TabIndex = 12;
            lblFilterPlayer.Text = "Selected Player:";
            // 
            // lblFilterTribe
            // 
            lblFilterTribe.AutoSize = true;
            lblFilterTribe.Location = new System.Drawing.Point(29, 171);
            lblFilterTribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFilterTribe.Name = "lblFilterTribe";
            lblFilterTribe.Size = new System.Drawing.Size(82, 15);
            lblFilterTribe.TabIndex = 10;
            lblFilterTribe.Text = "Selected Tribe:";
            // 
            // lblContentPackFilters
            // 
            lblContentPackFilters.BackColor = System.Drawing.Color.Transparent;
            lblContentPackFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblContentPackFilters.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblContentPackFilters.Location = new System.Drawing.Point(9, 135);
            lblContentPackFilters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblContentPackFilters.Name = "lblContentPackFilters";
            lblContentPackFilters.Size = new System.Drawing.Size(231, 25);
            lblContentPackFilters.TabIndex = 9;
            lblContentPackFilters.Text = "Content Pack Filters";
            lblContentPackFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkPlayerStructures
            // 
            chkPlayerStructures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            chkPlayerStructures.AutoSize = true;
            chkPlayerStructures.Checked = true;
            chkPlayerStructures.CheckState = System.Windows.Forms.CheckState.Checked;
            chkPlayerStructures.Location = new System.Drawing.Point(285, 98);
            chkPlayerStructures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkPlayerStructures.Name = "chkPlayerStructures";
            chkPlayerStructures.Size = new System.Drawing.Size(114, 19);
            chkPlayerStructures.TabIndex = 8;
            chkPlayerStructures.Text = "Player Structures";
            chkPlayerStructures.UseVisualStyleBackColor = true;
            // 
            // chkTamedCreatures
            // 
            chkTamedCreatures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            chkTamedCreatures.AutoSize = true;
            chkTamedCreatures.Checked = true;
            chkTamedCreatures.CheckState = System.Windows.Forms.CheckState.Checked;
            chkTamedCreatures.Location = new System.Drawing.Point(286, 45);
            chkTamedCreatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkTamedCreatures.Name = "chkTamedCreatures";
            chkTamedCreatures.Size = new System.Drawing.Size(114, 19);
            chkTamedCreatures.TabIndex = 6;
            chkTamedCreatures.Text = "Tamed Creatures";
            chkTamedCreatures.UseVisualStyleBackColor = true;
            // 
            // chkWildCreatures
            // 
            chkWildCreatures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            chkWildCreatures.AutoSize = true;
            chkWildCreatures.Location = new System.Drawing.Point(285, 71);
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
            lblHeaderConteentPack.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderConteentPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblHeaderConteentPack.Location = new System.Drawing.Point(0, 2);
            lblHeaderConteentPack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderConteentPack.Name = "lblHeaderConteentPack";
            lblHeaderConteentPack.Size = new System.Drawing.Size(485, 7);
            lblHeaderConteentPack.TabIndex = 0;
            lblHeaderConteentPack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContentPackOptions
            // 
            lblContentPackOptions.BackColor = System.Drawing.Color.Transparent;
            lblContentPackOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            lblContentPackOptions.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblContentPackOptions.Location = new System.Drawing.Point(9, 16);
            lblContentPackOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblContentPackOptions.Name = "lblContentPackOptions";
            lblContentPackOptions.Size = new System.Drawing.Size(231, 25);
            lblContentPackOptions.TabIndex = 1;
            lblContentPackOptions.Text = "Content Pack Export Options";
            lblContentPackOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpgOptions
            // 
            tpgOptions.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            tpgOptions.Controls.Add(groupBox1);
            tpgOptions.Location = new System.Drawing.Point(4, 24);
            tpgOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgOptions.Name = "tpgOptions";
            tpgOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpgOptions.Size = new System.Drawing.Size(529, 554);
            tpgOptions.TabIndex = 3;
            tpgOptions.Text = "Options";
            tpgOptions.Click += tpgPlayers_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(pnlOptionsStartup);
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
            groupBox1.Size = new System.Drawing.Size(515, 522);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(udMaxCores);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(radioButton6);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label10);
            panel1.Location = new System.Drawing.Point(8, 434);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(498, 50);
            panel1.TabIndex = 7;
            // 
            // udMaxCores
            // 
            udMaxCores.Location = new System.Drawing.Point(425, 19);
            udMaxCores.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            udMaxCores.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            udMaxCores.Name = "udMaxCores";
            udMaxCores.Size = new System.Drawing.Size(59, 23);
            udMaxCores.TabIndex = 6;
            udMaxCores.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // radioButton3
            // 
            radioButton3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Location = new System.Drawing.Point(614, 22);
            radioButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(41, 19);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "No";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            radioButton4.AutoSize = true;
            radioButton4.Location = new System.Drawing.Point(726, 22);
            radioButton4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new System.Drawing.Size(42, 19);
            radioButton4.TabIndex = 5;
            radioButton4.Text = "Yes";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            radioButton5.AutoSize = true;
            radioButton5.Checked = true;
            radioButton5.Location = new System.Drawing.Point(996, 37);
            radioButton5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new System.Drawing.Size(41, 19);
            radioButton5.TabIndex = 2;
            radioButton5.TabStop = true;
            radioButton5.Text = "No";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            radioButton6.AutoSize = true;
            radioButton6.Location = new System.Drawing.Point(1108, 37);
            radioButton6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new System.Drawing.Size(42, 19);
            radioButton6.TabIndex = 3;
            radioButton6.Text = "Yes";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label8.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            label8.Location = new System.Drawing.Point(12, 5);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(78, 16);
            label8.TabIndex = 0;
            label8.Text = "Processor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(12, 23);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(315, 15);
            label10.TabIndex = 1;
            label10.Text = "Maximum number of cores to use when parsing ARK data:";
            // 
            // pnlOptionsStartup
            // 
            pnlOptionsStartup.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlOptionsStartup.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            pnlOptionsStartup.Controls.Add(optStartupManual);
            pnlOptionsStartup.Controls.Add(optStartupAuto);
            pnlOptionsStartup.Controls.Add(radioButton1);
            pnlOptionsStartup.Controls.Add(radioButton2);
            pnlOptionsStartup.Controls.Add(lblStartup);
            pnlOptionsStartup.Controls.Add(lblStartupInfo);
            pnlOptionsStartup.Location = new System.Drawing.Point(9, 378);
            pnlOptionsStartup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlOptionsStartup.Name = "pnlOptionsStartup";
            pnlOptionsStartup.Size = new System.Drawing.Size(498, 50);
            pnlOptionsStartup.TabIndex = 6;
            // 
            // optStartupManual
            // 
            optStartupManual.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optStartupManual.AutoSize = true;
            optStartupManual.Checked = true;
            optStartupManual.Location = new System.Drawing.Point(316, 22);
            optStartupManual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optStartupManual.Name = "optStartupManual";
            optStartupManual.Size = new System.Drawing.Size(41, 19);
            optStartupManual.TabIndex = 4;
            optStartupManual.TabStop = true;
            optStartupManual.Text = "No";
            optStartupManual.UseVisualStyleBackColor = true;
            // 
            // optStartupAuto
            // 
            optStartupAuto.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optStartupAuto.AutoSize = true;
            optStartupAuto.Location = new System.Drawing.Point(428, 22);
            optStartupAuto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            optStartupAuto.Name = "optStartupAuto";
            optStartupAuto.Size = new System.Drawing.Size(42, 19);
            optStartupAuto.TabIndex = 5;
            optStartupAuto.Text = "Yes";
            optStartupAuto.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(698, 37);
            radioButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(41, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "No";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(810, 37);
            radioButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(42, 19);
            radioButton2.TabIndex = 3;
            radioButton2.Text = "Yes";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // lblStartup
            // 
            lblStartup.AutoSize = true;
            lblStartup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblStartup.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblStartup.Location = new System.Drawing.Point(12, 5);
            lblStartup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStartup.Name = "lblStartup";
            lblStartup.Size = new System.Drawing.Size(56, 16);
            lblStartup.TabIndex = 0;
            lblStartup.Text = "Startup";
            // 
            // lblStartupInfo
            // 
            lblStartupInfo.AutoSize = true;
            lblStartupInfo.Location = new System.Drawing.Point(12, 25);
            lblStartupInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStartupInfo.Name = "lblStartupInfo";
            lblStartupInfo.Size = new System.Drawing.Size(202, 15);
            lblStartupInfo.TabIndex = 1;
            lblStartupInfo.Text = "Auto load last saved map on startup?";
            // 
            // pnlCommandExportOptions
            // 
            pnlCommandExportOptions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlCommandExportOptions.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            pnlCommandExportOptions.Controls.Add(optExportNoSort);
            pnlCommandExportOptions.Controls.Add(optExportSort);
            pnlCommandExportOptions.Controls.Add(lblCommandExportOptionTitle);
            pnlCommandExportOptions.Controls.Add(lblCommandExportDescription);
            pnlCommandExportOptions.Location = new System.Drawing.Point(7, 323);
            pnlCommandExportOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlCommandExportOptions.Name = "pnlCommandExportOptions";
            pnlCommandExportOptions.Size = new System.Drawing.Size(498, 49);
            pnlCommandExportOptions.TabIndex = 0;
            // 
            // optExportNoSort
            // 
            optExportNoSort.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optExportNoSort.AutoSize = true;
            optExportNoSort.Checked = true;
            optExportNoSort.Location = new System.Drawing.Point(318, 22);
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
            optExportSort.Location = new System.Drawing.Point(430, 22);
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
            lblCommandExportOptionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblCommandExportOptionTitle.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblCommandExportOptionTitle.Location = new System.Drawing.Point(12, 5);
            lblCommandExportOptionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCommandExportOptionTitle.Name = "lblCommandExportOptionTitle";
            lblCommandExportOptionTitle.Size = new System.Drawing.Size(157, 16);
            lblCommandExportOptionTitle.TabIndex = 0;
            lblCommandExportOptionTitle.Text = "Command Line Export";
            // 
            // lblCommandExportDescription
            // 
            lblCommandExportDescription.AutoSize = true;
            lblCommandExportDescription.Location = new System.Drawing.Point(12, 24);
            lblCommandExportDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCommandExportDescription.Name = "lblCommandExportDescription";
            lblCommandExportDescription.Size = new System.Drawing.Size(193, 15);
            lblCommandExportDescription.TabIndex = 1;
            lblCommandExportDescription.Text = "Sort creature exports by class name";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(-2, 0);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(519, 7);
            label4.TabIndex = 0;
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFtpSettingsCommands
            // 
            pnlFtpSettingsCommands.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlFtpSettingsCommands.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            pnlFtpSettingsCommands.Controls.Add(pnlDownloadOption);
            pnlFtpSettingsCommands.Controls.Add(label5);
            pnlFtpSettingsCommands.Controls.Add(optFTPSync);
            pnlFtpSettingsCommands.Controls.Add(optFTPClean);
            pnlFtpSettingsCommands.Controls.Add(label2);
            pnlFtpSettingsCommands.Controls.Add(label3);
            pnlFtpSettingsCommands.Location = new System.Drawing.Point(6, 232);
            pnlFtpSettingsCommands.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlFtpSettingsCommands.Name = "pnlFtpSettingsCommands";
            pnlFtpSettingsCommands.Size = new System.Drawing.Size(498, 85);
            pnlFtpSettingsCommands.TabIndex = 5;
            // 
            // pnlDownloadOption
            // 
            pnlDownloadOption.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pnlDownloadOption.Controls.Add(optDownloadAuto);
            pnlDownloadOption.Controls.Add(optDownloadManual);
            pnlDownloadOption.Location = new System.Drawing.Point(292, 45);
            pnlDownloadOption.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlDownloadOption.Name = "pnlDownloadOption";
            pnlDownloadOption.Size = new System.Drawing.Size(202, 30);
            pnlDownloadOption.TabIndex = 5;
            // 
            // optDownloadAuto
            // 
            optDownloadAuto.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optDownloadAuto.AutoSize = true;
            optDownloadAuto.Checked = true;
            optDownloadAuto.Location = new System.Drawing.Point(66, 4);
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
            optDownloadManual.Location = new System.Drawing.Point(125, 4);
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
            label5.Location = new System.Drawing.Point(13, 53);
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
            optFTPSync.Location = new System.Drawing.Point(321, 20);
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
            optFTPClean.Location = new System.Drawing.Point(427, 20);
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
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            label2.Location = new System.Drawing.Point(12, 7);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 16);
            label2.TabIndex = 0;
            label2.Text = "FTP Downloads";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 25);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(146, 15);
            label3.TabIndex = 1;
            label3.Text = "How to handle downloads";
            // 
            // pnlPlayerSettingsStuctures
            // 
            pnlPlayerSettingsStuctures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlPlayerSettingsStuctures.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            pnlPlayerSettingsStuctures.Controls.Add(optPlayerStructureHide);
            pnlPlayerSettingsStuctures.Controls.Add(optPlayerStructureShow);
            pnlPlayerSettingsStuctures.Controls.Add(lblOptionHeaderStructures);
            pnlPlayerSettingsStuctures.Controls.Add(lblOptionTextStructures);
            pnlPlayerSettingsStuctures.Location = new System.Drawing.Point(7, 17);
            pnlPlayerSettingsStuctures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlPlayerSettingsStuctures.Name = "pnlPlayerSettingsStuctures";
            pnlPlayerSettingsStuctures.Size = new System.Drawing.Size(498, 44);
            pnlPlayerSettingsStuctures.TabIndex = 0;
            // 
            // optPlayerStructureHide
            // 
            optPlayerStructureHide.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optPlayerStructureHide.AutoSize = true;
            optPlayerStructureHide.Checked = true;
            optPlayerStructureHide.Location = new System.Drawing.Point(359, 18);
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
            optPlayerStructureShow.Location = new System.Drawing.Point(429, 18);
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
            lblOptionHeaderStructures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblOptionHeaderStructures.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblOptionHeaderStructures.Location = new System.Drawing.Point(12, 3);
            lblOptionHeaderStructures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOptionHeaderStructures.Name = "lblOptionHeaderStructures";
            lblOptionHeaderStructures.Size = new System.Drawing.Size(76, 16);
            lblOptionHeaderStructures.TabIndex = 0;
            lblOptionHeaderStructures.Text = "Structures";
            // 
            // lblOptionTextStructures
            // 
            lblOptionTextStructures.AutoSize = true;
            lblOptionTextStructures.Location = new System.Drawing.Point(12, 20);
            lblOptionTextStructures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOptionTextStructures.Name = "lblOptionTextStructures";
            lblOptionTextStructures.Size = new System.Drawing.Size(288, 15);
            lblOptionTextStructures.TabIndex = 1;
            lblOptionTextStructures.Text = "Display Tribes and Players with no placed structure(s).";
            // 
            // pnlPlayerSettingsCommands
            // 
            pnlPlayerSettingsCommands.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlPlayerSettingsCommands.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            pnlPlayerSettingsCommands.Controls.Add(optPlayerCommandsPrefixAdmincheat);
            pnlPlayerSettingsCommands.Controls.Add(optPlayerCommandsPrefixNone);
            pnlPlayerSettingsCommands.Controls.Add(optPlayerCommandsPrefixCheat);
            pnlPlayerSettingsCommands.Controls.Add(lblOptionHeaderCommand);
            pnlPlayerSettingsCommands.Controls.Add(lblOptionTextCommand);
            pnlPlayerSettingsCommands.Location = new System.Drawing.Point(6, 176);
            pnlPlayerSettingsCommands.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlPlayerSettingsCommands.Name = "pnlPlayerSettingsCommands";
            pnlPlayerSettingsCommands.Size = new System.Drawing.Size(498, 50);
            pnlPlayerSettingsCommands.TabIndex = 4;
            // 
            // optPlayerCommandsPrefixAdmincheat
            // 
            optPlayerCommandsPrefixAdmincheat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optPlayerCommandsPrefixAdmincheat.AutoSize = true;
            optPlayerCommandsPrefixAdmincheat.Location = new System.Drawing.Point(325, 19);
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
            optPlayerCommandsPrefixNone.Location = new System.Drawing.Point(232, 19);
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
            optPlayerCommandsPrefixCheat.Location = new System.Drawing.Point(429, 19);
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
            lblOptionHeaderCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblOptionHeaderCommand.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblOptionHeaderCommand.Location = new System.Drawing.Point(12, 4);
            lblOptionHeaderCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOptionHeaderCommand.Name = "lblOptionHeaderCommand";
            lblOptionHeaderCommand.Size = new System.Drawing.Size(119, 16);
            lblOptionHeaderCommand.TabIndex = 0;
            lblOptionHeaderCommand.Text = "Command Prefix";
            // 
            // lblOptionTextCommand
            // 
            lblOptionTextCommand.AutoSize = true;
            lblOptionTextCommand.Location = new System.Drawing.Point(12, 21);
            lblOptionTextCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOptionTextCommand.Name = "lblOptionTextCommand";
            lblOptionTextCommand.Size = new System.Drawing.Size(171, 15);
            lblOptionTextCommand.TabIndex = 1;
            lblOptionTextCommand.Text = "Add prefix to copy commands:";
            // 
            // pnlPlayerSettingsTames
            // 
            pnlPlayerSettingsTames.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlPlayerSettingsTames.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            pnlPlayerSettingsTames.Controls.Add(optPlayerTameHide);
            pnlPlayerSettingsTames.Controls.Add(optPlayerTameShow);
            pnlPlayerSettingsTames.Controls.Add(lblOptionHeaderTames);
            pnlPlayerSettingsTames.Controls.Add(lblOptionTextTames);
            pnlPlayerSettingsTames.Location = new System.Drawing.Point(7, 67);
            pnlPlayerSettingsTames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlPlayerSettingsTames.Name = "pnlPlayerSettingsTames";
            pnlPlayerSettingsTames.Size = new System.Drawing.Size(498, 48);
            pnlPlayerSettingsTames.TabIndex = 2;
            // 
            // optPlayerTameHide
            // 
            optPlayerTameHide.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optPlayerTameHide.AutoSize = true;
            optPlayerTameHide.Checked = true;
            optPlayerTameHide.Location = new System.Drawing.Point(359, 18);
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
            optPlayerTameShow.Location = new System.Drawing.Point(429, 18);
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
            lblOptionHeaderTames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblOptionHeaderTames.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblOptionHeaderTames.Location = new System.Drawing.Point(12, 3);
            lblOptionHeaderTames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOptionHeaderTames.Name = "lblOptionHeaderTames";
            lblOptionHeaderTames.Size = new System.Drawing.Size(55, 16);
            lblOptionHeaderTames.TabIndex = 0;
            lblOptionHeaderTames.Text = "Tames";
            // 
            // lblOptionTextTames
            // 
            lblOptionTextTames.AutoSize = true;
            lblOptionTextTames.Location = new System.Drawing.Point(12, 21);
            lblOptionTextTames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOptionTextTames.Name = "lblOptionTextTames";
            lblOptionTextTames.Size = new System.Drawing.Size(275, 15);
            lblOptionTextTames.TabIndex = 1;
            lblOptionTextTames.Text = "Display Tribes and Players with no tamed creatures.";
            // 
            // pnlPlayerSettingsBody
            // 
            pnlPlayerSettingsBody.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlPlayerSettingsBody.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            pnlPlayerSettingsBody.Controls.Add(optPlayerBodyHide);
            pnlPlayerSettingsBody.Controls.Add(optPlayerBodyShow);
            pnlPlayerSettingsBody.Controls.Add(lblOptionHeaderBody);
            pnlPlayerSettingsBody.Controls.Add(lblOptionTextBody);
            pnlPlayerSettingsBody.Location = new System.Drawing.Point(7, 121);
            pnlPlayerSettingsBody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlPlayerSettingsBody.Name = "pnlPlayerSettingsBody";
            pnlPlayerSettingsBody.Size = new System.Drawing.Size(498, 49);
            pnlPlayerSettingsBody.TabIndex = 3;
            // 
            // optPlayerBodyHide
            // 
            optPlayerBodyHide.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            optPlayerBodyHide.AutoSize = true;
            optPlayerBodyHide.Checked = true;
            optPlayerBodyHide.Location = new System.Drawing.Point(359, 19);
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
            optPlayerBodyShow.Location = new System.Drawing.Point(429, 19);
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
            lblOptionHeaderBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblOptionHeaderBody.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblOptionHeaderBody.Location = new System.Drawing.Point(12, 4);
            lblOptionHeaderBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOptionHeaderBody.Name = "lblOptionHeaderBody";
            lblOptionHeaderBody.Size = new System.Drawing.Size(43, 16);
            lblOptionHeaderBody.TabIndex = 0;
            lblOptionHeaderBody.Text = "Body";
            // 
            // lblOptionTextBody
            // 
            lblOptionTextBody.AutoSize = true;
            lblOptionTextBody.Location = new System.Drawing.Point(12, 21);
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
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(564, 641);
            Controls.Add(tabSettings);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            ForeColor = System.Drawing.Color.FromArgb(125, 125, 125);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(580, 680);
            Name = "frmSettings";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Settings";
            Load += frmSettings_Load;
            tabSettings.ResumeLayout(false);
            tpgMap.ResumeLayout(false);
            tpgMap.PerformLayout();
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
            tpgOptions.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)udMaxCores).EndInit();
            pnlOptionsStartup.ResumeLayout(false);
            pnlOptionsStartup.PerformLayout();
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
        private ArkViewer.UI.BorderlessComboBox cboFTPServer;
        private System.Windows.Forms.GroupBox grpOffline;
        private System.Windows.Forms.Label lblOfflineSave;
        private System.Windows.Forms.GroupBox grpSinglePlayer;
        private System.Windows.Forms.Label lblSelectedMapSP;
        private ArkViewer.UI.BorderlessComboBox cboMapSinglePlayer;
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
        private ArkViewer.UI.BorderlessComboBox cboFtpMap;
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
        private ArkViewer.UI.BorderlessComboBox cboExportPlayer;
        private ArkViewer.UI.BorderlessComboBox cboExportTribe;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveARK;
        private System.Windows.Forms.Button btnAddARK;
        private ArkViewer.UI.BorderlessComboBox cboLocalARK;
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
        private System.Windows.Forms.Panel pnlOptionsStartup;
        private System.Windows.Forms.RadioButton optStartupManual;
        private System.Windows.Forms.RadioButton optStartupAuto;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lblStartup;
        private System.Windows.Forms.Label lblStartupInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown udMaxCores;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}

namespace ARKViewer
{
    partial class frmBreedingFindOptions
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
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.udMaxCrafting = new System.Windows.Forms.NumericUpDown();
            this.lblCrafting = new System.Windows.Forms.Label();
            this.udMaxOxygen = new System.Windows.Forms.NumericUpDown();
            this.lblOxygen = new System.Windows.Forms.Label();
            this.udMaxFood = new System.Windows.Forms.NumericUpDown();
            this.lblFood = new System.Windows.Forms.Label();
            this.udMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.udMaxWeight = new System.Windows.Forms.NumericUpDown();
            this.lblWeight = new System.Windows.Forms.Label();
            this.udMaxMelee = new System.Windows.Forms.NumericUpDown();
            this.lblMelee = new System.Windows.Forms.Label();
            this.udMaxStamina = new System.Windows.Forms.NumericUpDown();
            this.lblStamina = new System.Windows.Forms.Label();
            this.udMaxHp = new System.Windows.Forms.NumericUpDown();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblStatsMax = new System.Windows.Forms.Label();
            this.lblBaseStats = new System.Windows.Forms.Label();
            this.lblHeaderStats = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.grpColours = new System.Windows.Forms.GroupBox();
            this.btnRemoveColour5 = new System.Windows.Forms.Button();
            this.btnAddColour5 = new System.Windows.Forms.Button();
            this.btnRemoveColour4 = new System.Windows.Forms.Button();
            this.btnAddColour4 = new System.Windows.Forms.Button();
            this.btnRemoveColour3 = new System.Windows.Forms.Button();
            this.btnAddColour3 = new System.Windows.Forms.Button();
            this.btnRemoveColour2 = new System.Windows.Forms.Button();
            this.btnAddColour2 = new System.Windows.Forms.Button();
            this.btnRemoveColour1 = new System.Windows.Forms.Button();
            this.btnAddColour1 = new System.Windows.Forms.Button();
            this.btnRemoveColour0 = new System.Windows.Forms.Button();
            this.btnAddColour0 = new System.Windows.Forms.Button();
            this.cboColours5 = new System.Windows.Forms.ComboBox();
            this.cboColours4 = new System.Windows.Forms.ComboBox();
            this.cboColours3 = new System.Windows.Forms.ComboBox();
            this.cboColours2 = new System.Windows.Forms.ComboBox();
            this.cboColours1 = new System.Windows.Forms.ComboBox();
            this.cboColours0 = new System.Windows.Forms.ComboBox();
            this.lblColours5 = new System.Windows.Forms.Label();
            this.lblColours4 = new System.Windows.Forms.Label();
            this.lblColours3 = new System.Windows.Forms.Label();
            this.lblColours2 = new System.Windows.Forms.Label();
            this.lblColours1 = new System.Windows.Forms.Label();
            this.lblColours0 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeaderColours = new System.Windows.Forms.Label();
            this.grpStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxCrafting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxOxygen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxMelee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxStamina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxHp)).BeginInit();
            this.grpColours.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.udMaxCrafting);
            this.grpStats.Controls.Add(this.lblCrafting);
            this.grpStats.Controls.Add(this.udMaxOxygen);
            this.grpStats.Controls.Add(this.lblOxygen);
            this.grpStats.Controls.Add(this.udMaxFood);
            this.grpStats.Controls.Add(this.lblFood);
            this.grpStats.Controls.Add(this.udMaxSpeed);
            this.grpStats.Controls.Add(this.lblSpeed);
            this.grpStats.Controls.Add(this.udMaxWeight);
            this.grpStats.Controls.Add(this.lblWeight);
            this.grpStats.Controls.Add(this.udMaxMelee);
            this.grpStats.Controls.Add(this.lblMelee);
            this.grpStats.Controls.Add(this.udMaxStamina);
            this.grpStats.Controls.Add(this.lblStamina);
            this.grpStats.Controls.Add(this.udMaxHp);
            this.grpStats.Controls.Add(this.lblHp);
            this.grpStats.Controls.Add(this.lblStatsMax);
            this.grpStats.Controls.Add(this.lblBaseStats);
            this.grpStats.Controls.Add(this.lblHeaderStats);
            this.grpStats.Location = new System.Drawing.Point(10, 11);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(225, 247);
            this.grpStats.TabIndex = 1;
            this.grpStats.TabStop = false;
            // 
            // udMaxCrafting
            // 
            this.udMaxCrafting.Location = new System.Drawing.Point(158, 217);
            this.udMaxCrafting.Name = "udMaxCrafting";
            this.udMaxCrafting.Size = new System.Drawing.Size(50, 20);
            this.udMaxCrafting.TabIndex = 27;
            this.udMaxCrafting.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udMaxCrafting.Click += new System.EventHandler(this.RangeEnter);
            this.udMaxCrafting.Enter += new System.EventHandler(this.RangeEnter);
            // 
            // lblCrafting
            // 
            this.lblCrafting.AutoSize = true;
            this.lblCrafting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrafting.Location = new System.Drawing.Point(19, 221);
            this.lblCrafting.Name = "lblCrafting";
            this.lblCrafting.Size = new System.Drawing.Size(43, 13);
            this.lblCrafting.TabIndex = 25;
            this.lblCrafting.Text = "Crafting";
            // 
            // udMaxOxygen
            // 
            this.udMaxOxygen.Location = new System.Drawing.Point(158, 191);
            this.udMaxOxygen.Name = "udMaxOxygen";
            this.udMaxOxygen.Size = new System.Drawing.Size(50, 20);
            this.udMaxOxygen.TabIndex = 24;
            this.udMaxOxygen.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udMaxOxygen.Click += new System.EventHandler(this.RangeEnter);
            this.udMaxOxygen.Enter += new System.EventHandler(this.RangeEnter);
            // 
            // lblOxygen
            // 
            this.lblOxygen.AutoSize = true;
            this.lblOxygen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOxygen.Location = new System.Drawing.Point(19, 195);
            this.lblOxygen.Name = "lblOxygen";
            this.lblOxygen.Size = new System.Drawing.Size(43, 13);
            this.lblOxygen.TabIndex = 22;
            this.lblOxygen.Text = "Oxygen";
            // 
            // udMaxFood
            // 
            this.udMaxFood.Location = new System.Drawing.Point(158, 165);
            this.udMaxFood.Name = "udMaxFood";
            this.udMaxFood.Size = new System.Drawing.Size(50, 20);
            this.udMaxFood.TabIndex = 21;
            this.udMaxFood.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udMaxFood.Click += new System.EventHandler(this.RangeEnter);
            this.udMaxFood.Enter += new System.EventHandler(this.RangeEnter);
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.Location = new System.Drawing.Point(19, 169);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(31, 13);
            this.lblFood.TabIndex = 19;
            this.lblFood.Text = "Food";
            // 
            // udMaxSpeed
            // 
            this.udMaxSpeed.Location = new System.Drawing.Point(158, 139);
            this.udMaxSpeed.Name = "udMaxSpeed";
            this.udMaxSpeed.Size = new System.Drawing.Size(50, 20);
            this.udMaxSpeed.TabIndex = 18;
            this.udMaxSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udMaxSpeed.Click += new System.EventHandler(this.RangeEnter);
            this.udMaxSpeed.Enter += new System.EventHandler(this.RangeEnter);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(19, 143);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblSpeed.TabIndex = 16;
            this.lblSpeed.Text = "Speed";
            // 
            // udMaxWeight
            // 
            this.udMaxWeight.Location = new System.Drawing.Point(158, 113);
            this.udMaxWeight.Name = "udMaxWeight";
            this.udMaxWeight.Size = new System.Drawing.Size(50, 20);
            this.udMaxWeight.TabIndex = 15;
            this.udMaxWeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udMaxWeight.Click += new System.EventHandler(this.RangeEnter);
            this.udMaxWeight.Enter += new System.EventHandler(this.RangeEnter);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(19, 117);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 13;
            this.lblWeight.Text = "Weight";
            // 
            // udMaxMelee
            // 
            this.udMaxMelee.Location = new System.Drawing.Point(158, 87);
            this.udMaxMelee.Name = "udMaxMelee";
            this.udMaxMelee.Size = new System.Drawing.Size(50, 20);
            this.udMaxMelee.TabIndex = 12;
            this.udMaxMelee.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udMaxMelee.Click += new System.EventHandler(this.RangeEnter);
            this.udMaxMelee.Enter += new System.EventHandler(this.RangeEnter);
            // 
            // lblMelee
            // 
            this.lblMelee.AutoSize = true;
            this.lblMelee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMelee.Location = new System.Drawing.Point(19, 91);
            this.lblMelee.Name = "lblMelee";
            this.lblMelee.Size = new System.Drawing.Size(36, 13);
            this.lblMelee.TabIndex = 10;
            this.lblMelee.Text = "Melee";
            // 
            // udMaxStamina
            // 
            this.udMaxStamina.Location = new System.Drawing.Point(158, 61);
            this.udMaxStamina.Name = "udMaxStamina";
            this.udMaxStamina.Size = new System.Drawing.Size(50, 20);
            this.udMaxStamina.TabIndex = 9;
            this.udMaxStamina.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udMaxStamina.Click += new System.EventHandler(this.RangeEnter);
            this.udMaxStamina.Enter += new System.EventHandler(this.RangeEnter);
            // 
            // lblStamina
            // 
            this.lblStamina.AutoSize = true;
            this.lblStamina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStamina.Location = new System.Drawing.Point(19, 65);
            this.lblStamina.Name = "lblStamina";
            this.lblStamina.Size = new System.Drawing.Size(45, 13);
            this.lblStamina.TabIndex = 7;
            this.lblStamina.Text = "Stamina";
            // 
            // udMaxHp
            // 
            this.udMaxHp.Location = new System.Drawing.Point(158, 35);
            this.udMaxHp.Name = "udMaxHp";
            this.udMaxHp.Size = new System.Drawing.Size(50, 20);
            this.udMaxHp.TabIndex = 6;
            this.udMaxHp.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udMaxHp.Click += new System.EventHandler(this.RangeEnter);
            this.udMaxHp.Enter += new System.EventHandler(this.RangeEnter);
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHp.Location = new System.Drawing.Point(19, 39);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(22, 13);
            this.lblHp.TabIndex = 4;
            this.lblHp.Text = "HP";
            // 
            // lblStatsMax
            // 
            this.lblStatsMax.AutoSize = true;
            this.lblStatsMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatsMax.Location = new System.Drawing.Point(152, 13);
            this.lblStatsMax.Name = "lblStatsMax";
            this.lblStatsMax.Size = new System.Drawing.Size(34, 13);
            this.lblStatsMax.TabIndex = 3;
            this.lblStatsMax.Text = "Max.";
            // 
            // lblBaseStats
            // 
            this.lblBaseStats.AutoSize = true;
            this.lblBaseStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseStats.Location = new System.Drawing.Point(7, 11);
            this.lblBaseStats.Name = "lblBaseStats";
            this.lblBaseStats.Size = new System.Drawing.Size(103, 13);
            this.lblBaseStats.TabIndex = 1;
            this.lblBaseStats.Text = "Base Stat Range";
            // 
            // lblHeaderStats
            // 
            this.lblHeaderStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderStats.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderStats.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderStats.Name = "lblHeaderStats";
            this.lblHeaderStats.Size = new System.Drawing.Size(227, 6);
            this.lblHeaderStats.TabIndex = 0;
            this.lblHeaderStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(481, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(400, 266);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // grpColours
            // 
            this.grpColours.Controls.Add(this.btnRemoveColour5);
            this.grpColours.Controls.Add(this.btnAddColour5);
            this.grpColours.Controls.Add(this.btnRemoveColour4);
            this.grpColours.Controls.Add(this.btnAddColour4);
            this.grpColours.Controls.Add(this.btnRemoveColour3);
            this.grpColours.Controls.Add(this.btnAddColour3);
            this.grpColours.Controls.Add(this.btnRemoveColour2);
            this.grpColours.Controls.Add(this.btnAddColour2);
            this.grpColours.Controls.Add(this.btnRemoveColour1);
            this.grpColours.Controls.Add(this.btnAddColour1);
            this.grpColours.Controls.Add(this.btnRemoveColour0);
            this.grpColours.Controls.Add(this.btnAddColour0);
            this.grpColours.Controls.Add(this.cboColours5);
            this.grpColours.Controls.Add(this.cboColours4);
            this.grpColours.Controls.Add(this.cboColours3);
            this.grpColours.Controls.Add(this.cboColours2);
            this.grpColours.Controls.Add(this.cboColours1);
            this.grpColours.Controls.Add(this.cboColours0);
            this.grpColours.Controls.Add(this.lblColours5);
            this.grpColours.Controls.Add(this.lblColours4);
            this.grpColours.Controls.Add(this.lblColours3);
            this.grpColours.Controls.Add(this.lblColours2);
            this.grpColours.Controls.Add(this.lblColours1);
            this.grpColours.Controls.Add(this.lblColours0);
            this.grpColours.Controls.Add(this.label2);
            this.grpColours.Controls.Add(this.lblHeaderColours);
            this.grpColours.Location = new System.Drawing.Point(243, 12);
            this.grpColours.Name = "grpColours";
            this.grpColours.Size = new System.Drawing.Size(314, 246);
            this.grpColours.TabIndex = 5;
            this.grpColours.TabStop = false;
            // 
            // btnRemoveColour5
            // 
            this.btnRemoveColour5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveColour5.Enabled = false;
            this.btnRemoveColour5.Image = global::ARKViewer.Properties.Resources.button_remove;
            this.btnRemoveColour5.Location = new System.Drawing.Point(264, 202);
            this.btnRemoveColour5.Name = "btnRemoveColour5";
            this.btnRemoveColour5.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveColour5.TabIndex = 29;
            this.btnRemoveColour5.UseVisualStyleBackColor = true;
            this.btnRemoveColour5.Click += new System.EventHandler(this.btnRemoveColour5_Click);
            // 
            // btnAddColour5
            // 
            this.btnAddColour5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddColour5.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnAddColour5.Location = new System.Drawing.Point(224, 202);
            this.btnAddColour5.Name = "btnAddColour5";
            this.btnAddColour5.Size = new System.Drawing.Size(35, 35);
            this.btnAddColour5.TabIndex = 28;
            this.btnAddColour5.UseVisualStyleBackColor = true;
            this.btnAddColour5.Click += new System.EventHandler(this.btnAddColour5_Click);
            // 
            // btnRemoveColour4
            // 
            this.btnRemoveColour4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveColour4.Enabled = false;
            this.btnRemoveColour4.Image = global::ARKViewer.Properties.Resources.button_remove;
            this.btnRemoveColour4.Location = new System.Drawing.Point(264, 167);
            this.btnRemoveColour4.Name = "btnRemoveColour4";
            this.btnRemoveColour4.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveColour4.TabIndex = 27;
            this.btnRemoveColour4.UseVisualStyleBackColor = true;
            this.btnRemoveColour4.Click += new System.EventHandler(this.btnRemoveColour4_Click);
            // 
            // btnAddColour4
            // 
            this.btnAddColour4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddColour4.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnAddColour4.Location = new System.Drawing.Point(224, 167);
            this.btnAddColour4.Name = "btnAddColour4";
            this.btnAddColour4.Size = new System.Drawing.Size(35, 35);
            this.btnAddColour4.TabIndex = 26;
            this.btnAddColour4.UseVisualStyleBackColor = true;
            this.btnAddColour4.Click += new System.EventHandler(this.btnAddColour4_Click);
            // 
            // btnRemoveColour3
            // 
            this.btnRemoveColour3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveColour3.Enabled = false;
            this.btnRemoveColour3.Image = global::ARKViewer.Properties.Resources.button_remove;
            this.btnRemoveColour3.Location = new System.Drawing.Point(264, 132);
            this.btnRemoveColour3.Name = "btnRemoveColour3";
            this.btnRemoveColour3.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveColour3.TabIndex = 25;
            this.btnRemoveColour3.UseVisualStyleBackColor = true;
            this.btnRemoveColour3.Click += new System.EventHandler(this.btnRemoveColour3_Click);
            // 
            // btnAddColour3
            // 
            this.btnAddColour3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddColour3.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnAddColour3.Location = new System.Drawing.Point(224, 132);
            this.btnAddColour3.Name = "btnAddColour3";
            this.btnAddColour3.Size = new System.Drawing.Size(35, 35);
            this.btnAddColour3.TabIndex = 24;
            this.btnAddColour3.UseVisualStyleBackColor = true;
            this.btnAddColour3.Click += new System.EventHandler(this.btnAddColour3_Click);
            // 
            // btnRemoveColour2
            // 
            this.btnRemoveColour2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveColour2.Enabled = false;
            this.btnRemoveColour2.Image = global::ARKViewer.Properties.Resources.button_remove;
            this.btnRemoveColour2.Location = new System.Drawing.Point(264, 97);
            this.btnRemoveColour2.Name = "btnRemoveColour2";
            this.btnRemoveColour2.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveColour2.TabIndex = 23;
            this.btnRemoveColour2.UseVisualStyleBackColor = true;
            this.btnRemoveColour2.Click += new System.EventHandler(this.btnRemoveColour2_Click);
            // 
            // btnAddColour2
            // 
            this.btnAddColour2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddColour2.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnAddColour2.Location = new System.Drawing.Point(224, 97);
            this.btnAddColour2.Name = "btnAddColour2";
            this.btnAddColour2.Size = new System.Drawing.Size(35, 35);
            this.btnAddColour2.TabIndex = 22;
            this.btnAddColour2.UseVisualStyleBackColor = true;
            this.btnAddColour2.Click += new System.EventHandler(this.btnAddColour2_Click);
            // 
            // btnRemoveColour1
            // 
            this.btnRemoveColour1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveColour1.Enabled = false;
            this.btnRemoveColour1.Image = global::ARKViewer.Properties.Resources.button_remove;
            this.btnRemoveColour1.Location = new System.Drawing.Point(264, 62);
            this.btnRemoveColour1.Name = "btnRemoveColour1";
            this.btnRemoveColour1.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveColour1.TabIndex = 21;
            this.btnRemoveColour1.UseVisualStyleBackColor = true;
            this.btnRemoveColour1.Click += new System.EventHandler(this.btnRemoveColour1_Click);
            // 
            // btnAddColour1
            // 
            this.btnAddColour1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddColour1.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnAddColour1.Location = new System.Drawing.Point(224, 62);
            this.btnAddColour1.Name = "btnAddColour1";
            this.btnAddColour1.Size = new System.Drawing.Size(35, 35);
            this.btnAddColour1.TabIndex = 20;
            this.btnAddColour1.UseVisualStyleBackColor = true;
            this.btnAddColour1.Click += new System.EventHandler(this.btnAddColour1_Click);
            // 
            // btnRemoveColour0
            // 
            this.btnRemoveColour0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveColour0.Enabled = false;
            this.btnRemoveColour0.Image = global::ARKViewer.Properties.Resources.button_remove;
            this.btnRemoveColour0.Location = new System.Drawing.Point(264, 27);
            this.btnRemoveColour0.Name = "btnRemoveColour0";
            this.btnRemoveColour0.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveColour0.TabIndex = 19;
            this.btnRemoveColour0.UseVisualStyleBackColor = true;
            this.btnRemoveColour0.Click += new System.EventHandler(this.btnRemoveColour0_Click);
            // 
            // btnAddColour0
            // 
            this.btnAddColour0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddColour0.Image = global::ARKViewer.Properties.Resources.button_add;
            this.btnAddColour0.Location = new System.Drawing.Point(224, 27);
            this.btnAddColour0.Name = "btnAddColour0";
            this.btnAddColour0.Size = new System.Drawing.Size(35, 35);
            this.btnAddColour0.TabIndex = 18;
            this.btnAddColour0.UseVisualStyleBackColor = true;
            this.btnAddColour0.Click += new System.EventHandler(this.btnAddColour0_Click);
            // 
            // cboColours5
            // 
            this.cboColours5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboColours5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColours5.FormattingEnabled = true;
            this.cboColours5.Location = new System.Drawing.Point(86, 210);
            this.cboColours5.Name = "cboColours5";
            this.cboColours5.Size = new System.Drawing.Size(123, 21);
            this.cboColours5.TabIndex = 17;
            this.cboColours5.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboColourItem);
            this.cboColours5.SelectedIndexChanged += new System.EventHandler(this.cboColours5_SelectedIndexChanged);
            // 
            // cboColours4
            // 
            this.cboColours4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboColours4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColours4.FormattingEnabled = true;
            this.cboColours4.Location = new System.Drawing.Point(86, 175);
            this.cboColours4.Name = "cboColours4";
            this.cboColours4.Size = new System.Drawing.Size(123, 21);
            this.cboColours4.TabIndex = 16;
            this.cboColours4.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboColourItem);
            this.cboColours4.SelectedIndexChanged += new System.EventHandler(this.cboColours4_SelectedIndexChanged);
            // 
            // cboColours3
            // 
            this.cboColours3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboColours3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColours3.FormattingEnabled = true;
            this.cboColours3.Location = new System.Drawing.Point(86, 140);
            this.cboColours3.Name = "cboColours3";
            this.cboColours3.Size = new System.Drawing.Size(123, 21);
            this.cboColours3.TabIndex = 15;
            this.cboColours3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboColourItem);
            this.cboColours3.SelectedIndexChanged += new System.EventHandler(this.cboColours3_SelectedIndexChanged);
            // 
            // cboColours2
            // 
            this.cboColours2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboColours2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColours2.FormattingEnabled = true;
            this.cboColours2.Location = new System.Drawing.Point(86, 105);
            this.cboColours2.Name = "cboColours2";
            this.cboColours2.Size = new System.Drawing.Size(123, 21);
            this.cboColours2.TabIndex = 14;
            this.cboColours2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboColourItem);
            this.cboColours2.SelectedIndexChanged += new System.EventHandler(this.cboColours2_SelectedIndexChanged);
            // 
            // cboColours1
            // 
            this.cboColours1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboColours1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColours1.FormattingEnabled = true;
            this.cboColours1.Location = new System.Drawing.Point(86, 70);
            this.cboColours1.Name = "cboColours1";
            this.cboColours1.Size = new System.Drawing.Size(123, 21);
            this.cboColours1.TabIndex = 13;
            this.cboColours1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboColourItem);
            this.cboColours1.SelectedIndexChanged += new System.EventHandler(this.cboColours1_SelectedIndexChanged);
            // 
            // cboColours0
            // 
            this.cboColours0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboColours0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColours0.FormattingEnabled = true;
            this.cboColours0.Items.AddRange(new object[] {
            "1"});
            this.cboColours0.Location = new System.Drawing.Point(86, 35);
            this.cboColours0.Name = "cboColours0";
            this.cboColours0.Size = new System.Drawing.Size(123, 21);
            this.cboColours0.TabIndex = 12;
            this.cboColours0.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawComboColourItem);
            this.cboColours0.SelectedIndexChanged += new System.EventHandler(this.cboColours0_SelectedIndexChanged);
            // 
            // lblColours5
            // 
            this.lblColours5.AutoSize = true;
            this.lblColours5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColours5.Location = new System.Drawing.Point(19, 213);
            this.lblColours5.Name = "lblColours5";
            this.lblColours5.Size = new System.Drawing.Size(50, 13);
            this.lblColours5.TabIndex = 10;
            this.lblColours5.Text = "Region 6";
            // 
            // lblColours4
            // 
            this.lblColours4.AutoSize = true;
            this.lblColours4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColours4.Location = new System.Drawing.Point(19, 178);
            this.lblColours4.Name = "lblColours4";
            this.lblColours4.Size = new System.Drawing.Size(50, 13);
            this.lblColours4.TabIndex = 9;
            this.lblColours4.Text = "Region 5";
            // 
            // lblColours3
            // 
            this.lblColours3.AutoSize = true;
            this.lblColours3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColours3.Location = new System.Drawing.Point(19, 143);
            this.lblColours3.Name = "lblColours3";
            this.lblColours3.Size = new System.Drawing.Size(50, 13);
            this.lblColours3.TabIndex = 8;
            this.lblColours3.Text = "Region 4";
            // 
            // lblColours2
            // 
            this.lblColours2.AutoSize = true;
            this.lblColours2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColours2.Location = new System.Drawing.Point(19, 108);
            this.lblColours2.Name = "lblColours2";
            this.lblColours2.Size = new System.Drawing.Size(50, 13);
            this.lblColours2.TabIndex = 7;
            this.lblColours2.Text = "Region 3";
            // 
            // lblColours1
            // 
            this.lblColours1.AutoSize = true;
            this.lblColours1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColours1.Location = new System.Drawing.Point(19, 73);
            this.lblColours1.Name = "lblColours1";
            this.lblColours1.Size = new System.Drawing.Size(50, 13);
            this.lblColours1.TabIndex = 6;
            this.lblColours1.Text = "Region 2";
            // 
            // lblColours0
            // 
            this.lblColours0.AutoSize = true;
            this.lblColours0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColours0.Location = new System.Drawing.Point(19, 38);
            this.lblColours0.Name = "lblColours0";
            this.lblColours0.Size = new System.Drawing.Size(50, 13);
            this.lblColours0.TabIndex = 5;
            this.lblColours0.Text = "Region 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Colour Options";
            // 
            // lblHeaderColours
            // 
            this.lblHeaderColours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderColours.BackColor = System.Drawing.Color.Aqua;
            this.lblHeaderColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderColours.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderColours.Name = "lblHeaderColours";
            this.lblHeaderColours.Size = new System.Drawing.Size(316, 6);
            this.lblHeaderColours.TabIndex = 0;
            this.lblHeaderColours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmBreedingFindOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(564, 301);
            this.Controls.Add(this.grpColours);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(580, 340);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(580, 340);
            this.Name = "frmBreedingFindOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Breeding Rank Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBreedingFindOptions_FormClosed);
            this.Load += new System.EventHandler(this.frmBreedingFindOptions_Load);
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxCrafting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxOxygen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxMelee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxStamina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxHp)).EndInit();
            this.grpColours.ResumeLayout(false);
            this.grpColours.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblHeaderStats;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblBaseStats;
        private System.Windows.Forms.GroupBox grpColours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeaderColours;
        private System.Windows.Forms.NumericUpDown udMaxHp;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Label lblStatsMax;
        private System.Windows.Forms.Label lblColours5;
        private System.Windows.Forms.Label lblColours4;
        private System.Windows.Forms.Label lblColours3;
        private System.Windows.Forms.Label lblColours2;
        private System.Windows.Forms.Label lblColours1;
        private System.Windows.Forms.Label lblColours0;
        private System.Windows.Forms.ComboBox cboColours5;
        private System.Windows.Forms.ComboBox cboColours4;
        private System.Windows.Forms.ComboBox cboColours3;
        private System.Windows.Forms.ComboBox cboColours2;
        private System.Windows.Forms.ComboBox cboColours1;
        private System.Windows.Forms.ComboBox cboColours0;
        private System.Windows.Forms.Button btnRemoveColour5;
        private System.Windows.Forms.Button btnAddColour5;
        private System.Windows.Forms.Button btnRemoveColour4;
        private System.Windows.Forms.Button btnAddColour4;
        private System.Windows.Forms.Button btnRemoveColour3;
        private System.Windows.Forms.Button btnAddColour3;
        private System.Windows.Forms.Button btnRemoveColour2;
        private System.Windows.Forms.Button btnAddColour2;
        private System.Windows.Forms.Button btnRemoveColour1;
        private System.Windows.Forms.Button btnAddColour1;
        private System.Windows.Forms.Button btnRemoveColour0;
        private System.Windows.Forms.Button btnAddColour0;
        private System.Windows.Forms.NumericUpDown udMaxSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.NumericUpDown udMaxWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.NumericUpDown udMaxMelee;
        private System.Windows.Forms.Label lblMelee;
        private System.Windows.Forms.NumericUpDown udMaxStamina;
        private System.Windows.Forms.Label lblStamina;
        private System.Windows.Forms.NumericUpDown udMaxCrafting;
        private System.Windows.Forms.Label lblCrafting;
        private System.Windows.Forms.NumericUpDown udMaxOxygen;
        private System.Windows.Forms.Label lblOxygen;
        private System.Windows.Forms.NumericUpDown udMaxFood;
        private System.Windows.Forms.Label lblFood;
    }
}
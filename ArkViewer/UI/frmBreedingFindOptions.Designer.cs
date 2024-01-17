
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBreedingFindOptions));
            grpStats = new System.Windows.Forms.GroupBox();
            udMaxCrafting = new System.Windows.Forms.NumericUpDown();
            lblCrafting = new System.Windows.Forms.Label();
            udMaxOxygen = new System.Windows.Forms.NumericUpDown();
            lblOxygen = new System.Windows.Forms.Label();
            udMaxFood = new System.Windows.Forms.NumericUpDown();
            lblFood = new System.Windows.Forms.Label();
            udMaxSpeed = new System.Windows.Forms.NumericUpDown();
            lblSpeed = new System.Windows.Forms.Label();
            udMaxWeight = new System.Windows.Forms.NumericUpDown();
            lblWeight = new System.Windows.Forms.Label();
            udMaxMelee = new System.Windows.Forms.NumericUpDown();
            lblMelee = new System.Windows.Forms.Label();
            udMaxStamina = new System.Windows.Forms.NumericUpDown();
            lblStamina = new System.Windows.Forms.Label();
            udMaxHp = new System.Windows.Forms.NumericUpDown();
            lblHp = new System.Windows.Forms.Label();
            lblStatsMax = new System.Windows.Forms.Label();
            lblBaseStats = new System.Windows.Forms.Label();
            lblHeaderStats = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnApply = new System.Windows.Forms.Button();
            grpColours = new System.Windows.Forms.GroupBox();
            btnRemoveColour5 = new System.Windows.Forms.Button();
            btnAddColour5 = new System.Windows.Forms.Button();
            btnRemoveColour4 = new System.Windows.Forms.Button();
            btnAddColour4 = new System.Windows.Forms.Button();
            btnRemoveColour3 = new System.Windows.Forms.Button();
            btnAddColour3 = new System.Windows.Forms.Button();
            btnRemoveColour2 = new System.Windows.Forms.Button();
            btnAddColour2 = new System.Windows.Forms.Button();
            btnRemoveColour1 = new System.Windows.Forms.Button();
            btnAddColour1 = new System.Windows.Forms.Button();
            btnRemoveColour0 = new System.Windows.Forms.Button();
            btnAddColour0 = new System.Windows.Forms.Button();
            cboColours5 = new System.Windows.Forms.ComboBox();
            cboColours4 = new System.Windows.Forms.ComboBox();
            cboColours3 = new System.Windows.Forms.ComboBox();
            cboColours2 = new System.Windows.Forms.ComboBox();
            cboColours1 = new System.Windows.Forms.ComboBox();
            cboColours0 = new System.Windows.Forms.ComboBox();
            lblColours5 = new System.Windows.Forms.Label();
            lblColours4 = new System.Windows.Forms.Label();
            lblColours3 = new System.Windows.Forms.Label();
            lblColours2 = new System.Windows.Forms.Label();
            lblColours1 = new System.Windows.Forms.Label();
            lblColours0 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblHeaderColours = new System.Windows.Forms.Label();
            grpStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udMaxCrafting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udMaxOxygen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udMaxFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udMaxSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udMaxWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udMaxMelee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udMaxStamina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udMaxHp).BeginInit();
            grpColours.SuspendLayout();
            SuspendLayout();
            // 
            // grpStats
            // 
            grpStats.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpStats.Controls.Add(udMaxCrafting);
            grpStats.Controls.Add(lblCrafting);
            grpStats.Controls.Add(udMaxOxygen);
            grpStats.Controls.Add(lblOxygen);
            grpStats.Controls.Add(udMaxFood);
            grpStats.Controls.Add(lblFood);
            grpStats.Controls.Add(udMaxSpeed);
            grpStats.Controls.Add(lblSpeed);
            grpStats.Controls.Add(udMaxWeight);
            grpStats.Controls.Add(lblWeight);
            grpStats.Controls.Add(udMaxMelee);
            grpStats.Controls.Add(lblMelee);
            grpStats.Controls.Add(udMaxStamina);
            grpStats.Controls.Add(lblStamina);
            grpStats.Controls.Add(udMaxHp);
            grpStats.Controls.Add(lblHp);
            grpStats.Controls.Add(lblStatsMax);
            grpStats.Controls.Add(lblBaseStats);
            grpStats.Controls.Add(lblHeaderStats);
            grpStats.Location = new System.Drawing.Point(12, 13);
            grpStats.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpStats.Name = "grpStats";
            grpStats.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpStats.Size = new System.Drawing.Size(262, 285);
            grpStats.TabIndex = 1;
            grpStats.TabStop = false;
            // 
            // udMaxCrafting
            // 
            udMaxCrafting.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udMaxCrafting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udMaxCrafting.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udMaxCrafting.Location = new System.Drawing.Point(184, 250);
            udMaxCrafting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udMaxCrafting.Name = "udMaxCrafting";
            udMaxCrafting.Size = new System.Drawing.Size(58, 19);
            udMaxCrafting.TabIndex = 27;
            udMaxCrafting.Value = new decimal(new int[] { 10, 0, 0, 0 });
            udMaxCrafting.Click += RangeEnter;
            udMaxCrafting.Enter += RangeEnter;
            // 
            // lblCrafting
            // 
            lblCrafting.AutoSize = true;
            lblCrafting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCrafting.Location = new System.Drawing.Point(22, 255);
            lblCrafting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCrafting.Name = "lblCrafting";
            lblCrafting.Size = new System.Drawing.Size(43, 13);
            lblCrafting.TabIndex = 25;
            lblCrafting.Text = "Crafting";
            // 
            // udMaxOxygen
            // 
            udMaxOxygen.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udMaxOxygen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udMaxOxygen.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udMaxOxygen.Location = new System.Drawing.Point(184, 220);
            udMaxOxygen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udMaxOxygen.Name = "udMaxOxygen";
            udMaxOxygen.Size = new System.Drawing.Size(58, 19);
            udMaxOxygen.TabIndex = 24;
            udMaxOxygen.Value = new decimal(new int[] { 10, 0, 0, 0 });
            udMaxOxygen.Click += RangeEnter;
            udMaxOxygen.Enter += RangeEnter;
            // 
            // lblOxygen
            // 
            lblOxygen.AutoSize = true;
            lblOxygen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblOxygen.Location = new System.Drawing.Point(22, 225);
            lblOxygen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOxygen.Name = "lblOxygen";
            lblOxygen.Size = new System.Drawing.Size(43, 13);
            lblOxygen.TabIndex = 22;
            lblOxygen.Text = "Oxygen";
            // 
            // udMaxFood
            // 
            udMaxFood.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udMaxFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udMaxFood.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udMaxFood.Location = new System.Drawing.Point(184, 190);
            udMaxFood.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udMaxFood.Name = "udMaxFood";
            udMaxFood.Size = new System.Drawing.Size(58, 19);
            udMaxFood.TabIndex = 21;
            udMaxFood.Value = new decimal(new int[] { 10, 0, 0, 0 });
            udMaxFood.Click += RangeEnter;
            udMaxFood.Enter += RangeEnter;
            // 
            // lblFood
            // 
            lblFood.AutoSize = true;
            lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblFood.Location = new System.Drawing.Point(22, 195);
            lblFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFood.Name = "lblFood";
            lblFood.Size = new System.Drawing.Size(31, 13);
            lblFood.TabIndex = 19;
            lblFood.Text = "Food";
            // 
            // udMaxSpeed
            // 
            udMaxSpeed.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udMaxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udMaxSpeed.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udMaxSpeed.Location = new System.Drawing.Point(184, 160);
            udMaxSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udMaxSpeed.Name = "udMaxSpeed";
            udMaxSpeed.Size = new System.Drawing.Size(58, 19);
            udMaxSpeed.TabIndex = 18;
            udMaxSpeed.Value = new decimal(new int[] { 10, 0, 0, 0 });
            udMaxSpeed.Click += RangeEnter;
            udMaxSpeed.Enter += RangeEnter;
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSpeed.Location = new System.Drawing.Point(22, 165);
            lblSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new System.Drawing.Size(38, 13);
            lblSpeed.TabIndex = 16;
            lblSpeed.Text = "Speed";
            // 
            // udMaxWeight
            // 
            udMaxWeight.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udMaxWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udMaxWeight.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udMaxWeight.Location = new System.Drawing.Point(184, 130);
            udMaxWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udMaxWeight.Name = "udMaxWeight";
            udMaxWeight.Size = new System.Drawing.Size(58, 19);
            udMaxWeight.TabIndex = 15;
            udMaxWeight.Value = new decimal(new int[] { 10, 0, 0, 0 });
            udMaxWeight.Click += RangeEnter;
            udMaxWeight.Enter += RangeEnter;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblWeight.Location = new System.Drawing.Point(22, 135);
            lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new System.Drawing.Size(41, 13);
            lblWeight.TabIndex = 13;
            lblWeight.Text = "Weight";
            // 
            // udMaxMelee
            // 
            udMaxMelee.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udMaxMelee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udMaxMelee.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udMaxMelee.Location = new System.Drawing.Point(184, 100);
            udMaxMelee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udMaxMelee.Name = "udMaxMelee";
            udMaxMelee.Size = new System.Drawing.Size(58, 19);
            udMaxMelee.TabIndex = 12;
            udMaxMelee.Value = new decimal(new int[] { 10, 0, 0, 0 });
            udMaxMelee.Click += RangeEnter;
            udMaxMelee.Enter += RangeEnter;
            // 
            // lblMelee
            // 
            lblMelee.AutoSize = true;
            lblMelee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblMelee.Location = new System.Drawing.Point(22, 105);
            lblMelee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMelee.Name = "lblMelee";
            lblMelee.Size = new System.Drawing.Size(36, 13);
            lblMelee.TabIndex = 10;
            lblMelee.Text = "Melee";
            // 
            // udMaxStamina
            // 
            udMaxStamina.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udMaxStamina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udMaxStamina.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udMaxStamina.Location = new System.Drawing.Point(184, 70);
            udMaxStamina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udMaxStamina.Name = "udMaxStamina";
            udMaxStamina.Size = new System.Drawing.Size(58, 19);
            udMaxStamina.TabIndex = 9;
            udMaxStamina.Value = new decimal(new int[] { 10, 0, 0, 0 });
            udMaxStamina.Click += RangeEnter;
            udMaxStamina.Enter += RangeEnter;
            // 
            // lblStamina
            // 
            lblStamina.AutoSize = true;
            lblStamina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblStamina.Location = new System.Drawing.Point(22, 75);
            lblStamina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStamina.Name = "lblStamina";
            lblStamina.Size = new System.Drawing.Size(45, 13);
            lblStamina.TabIndex = 7;
            lblStamina.Text = "Stamina";
            // 
            // udMaxHp
            // 
            udMaxHp.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            udMaxHp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            udMaxHp.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            udMaxHp.Location = new System.Drawing.Point(184, 40);
            udMaxHp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            udMaxHp.Name = "udMaxHp";
            udMaxHp.Size = new System.Drawing.Size(58, 19);
            udMaxHp.TabIndex = 6;
            udMaxHp.Value = new decimal(new int[] { 10, 0, 0, 0 });
            udMaxHp.Click += RangeEnter;
            udMaxHp.Enter += RangeEnter;
            // 
            // lblHp
            // 
            lblHp.AutoSize = true;
            lblHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHp.Location = new System.Drawing.Point(22, 45);
            lblHp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHp.Name = "lblHp";
            lblHp.Size = new System.Drawing.Size(22, 13);
            lblHp.TabIndex = 4;
            lblHp.Text = "HP";
            // 
            // lblStatsMax
            // 
            lblStatsMax.AutoSize = true;
            lblStatsMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblStatsMax.Location = new System.Drawing.Point(177, 15);
            lblStatsMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStatsMax.Name = "lblStatsMax";
            lblStatsMax.Size = new System.Drawing.Size(34, 13);
            lblStatsMax.TabIndex = 3;
            lblStatsMax.Text = "Max.";
            // 
            // lblBaseStats
            // 
            lblBaseStats.AutoSize = true;
            lblBaseStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblBaseStats.Location = new System.Drawing.Point(8, 13);
            lblBaseStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBaseStats.Name = "lblBaseStats";
            lblBaseStats.Size = new System.Drawing.Size(103, 13);
            lblBaseStats.TabIndex = 1;
            lblBaseStats.Text = "Base Stat Range";
            // 
            // lblHeaderStats
            // 
            lblHeaderStats.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderStats.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblHeaderStats.Location = new System.Drawing.Point(0, 0);
            lblHeaderStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderStats.Name = "lblHeaderStats";
            lblHeaderStats.Size = new System.Drawing.Size(265, 7);
            lblHeaderStats.TabIndex = 0;
            lblHeaderStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCancel.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnCancel.Location = new System.Drawing.Point(561, 307);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(88, 27);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Close";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnApply
            // 
            btnApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnApply.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnApply.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnApply.Location = new System.Drawing.Point(467, 307);
            btnApply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnApply.Name = "btnApply";
            btnApply.Size = new System.Drawing.Size(88, 27);
            btnApply.TabIndex = 3;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // grpColours
            // 
            grpColours.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            grpColours.Controls.Add(btnRemoveColour5);
            grpColours.Controls.Add(btnAddColour5);
            grpColours.Controls.Add(btnRemoveColour4);
            grpColours.Controls.Add(btnAddColour4);
            grpColours.Controls.Add(btnRemoveColour3);
            grpColours.Controls.Add(btnAddColour3);
            grpColours.Controls.Add(btnRemoveColour2);
            grpColours.Controls.Add(btnAddColour2);
            grpColours.Controls.Add(btnRemoveColour1);
            grpColours.Controls.Add(btnAddColour1);
            grpColours.Controls.Add(btnRemoveColour0);
            grpColours.Controls.Add(btnAddColour0);
            grpColours.Controls.Add(cboColours5);
            grpColours.Controls.Add(cboColours4);
            grpColours.Controls.Add(cboColours3);
            grpColours.Controls.Add(cboColours2);
            grpColours.Controls.Add(cboColours1);
            grpColours.Controls.Add(cboColours0);
            grpColours.Controls.Add(lblColours5);
            grpColours.Controls.Add(lblColours4);
            grpColours.Controls.Add(lblColours3);
            grpColours.Controls.Add(lblColours2);
            grpColours.Controls.Add(lblColours1);
            grpColours.Controls.Add(lblColours0);
            grpColours.Controls.Add(label2);
            grpColours.Controls.Add(lblHeaderColours);
            grpColours.Location = new System.Drawing.Point(284, 14);
            grpColours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpColours.Name = "grpColours";
            grpColours.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grpColours.Size = new System.Drawing.Size(366, 284);
            grpColours.TabIndex = 5;
            grpColours.TabStop = false;
            // 
            // btnRemoveColour5
            // 
            btnRemoveColour5.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRemoveColour5.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveColour5.Enabled = false;
            btnRemoveColour5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveColour5.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnRemoveColour5.Image = (System.Drawing.Image)resources.GetObject("btnRemoveColour5.Image");
            btnRemoveColour5.Location = new System.Drawing.Point(308, 233);
            btnRemoveColour5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveColour5.Name = "btnRemoveColour5";
            btnRemoveColour5.Size = new System.Drawing.Size(41, 40);
            btnRemoveColour5.TabIndex = 29;
            btnRemoveColour5.UseVisualStyleBackColor = false;
            btnRemoveColour5.Click += btnRemoveColour5_Click;
            // 
            // btnAddColour5
            // 
            btnAddColour5.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnAddColour5.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddColour5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddColour5.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnAddColour5.Image = (System.Drawing.Image)resources.GetObject("btnAddColour5.Image");
            btnAddColour5.Location = new System.Drawing.Point(261, 233);
            btnAddColour5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddColour5.Name = "btnAddColour5";
            btnAddColour5.Size = new System.Drawing.Size(41, 40);
            btnAddColour5.TabIndex = 28;
            btnAddColour5.UseVisualStyleBackColor = false;
            btnAddColour5.Click += btnAddColour5_Click;
            // 
            // btnRemoveColour4
            // 
            btnRemoveColour4.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRemoveColour4.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveColour4.Enabled = false;
            btnRemoveColour4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveColour4.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnRemoveColour4.Image = (System.Drawing.Image)resources.GetObject("btnRemoveColour4.Image");
            btnRemoveColour4.Location = new System.Drawing.Point(308, 193);
            btnRemoveColour4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveColour4.Name = "btnRemoveColour4";
            btnRemoveColour4.Size = new System.Drawing.Size(41, 40);
            btnRemoveColour4.TabIndex = 27;
            btnRemoveColour4.UseVisualStyleBackColor = false;
            btnRemoveColour4.Click += btnRemoveColour4_Click;
            // 
            // btnAddColour4
            // 
            btnAddColour4.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnAddColour4.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddColour4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddColour4.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnAddColour4.Image = (System.Drawing.Image)resources.GetObject("btnAddColour4.Image");
            btnAddColour4.Location = new System.Drawing.Point(261, 193);
            btnAddColour4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddColour4.Name = "btnAddColour4";
            btnAddColour4.Size = new System.Drawing.Size(41, 40);
            btnAddColour4.TabIndex = 26;
            btnAddColour4.UseVisualStyleBackColor = false;
            btnAddColour4.Click += btnAddColour4_Click;
            // 
            // btnRemoveColour3
            // 
            btnRemoveColour3.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRemoveColour3.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveColour3.Enabled = false;
            btnRemoveColour3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveColour3.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnRemoveColour3.Image = (System.Drawing.Image)resources.GetObject("btnRemoveColour3.Image");
            btnRemoveColour3.Location = new System.Drawing.Point(308, 152);
            btnRemoveColour3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveColour3.Name = "btnRemoveColour3";
            btnRemoveColour3.Size = new System.Drawing.Size(41, 40);
            btnRemoveColour3.TabIndex = 25;
            btnRemoveColour3.UseVisualStyleBackColor = false;
            btnRemoveColour3.Click += btnRemoveColour3_Click;
            // 
            // btnAddColour3
            // 
            btnAddColour3.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnAddColour3.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddColour3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddColour3.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnAddColour3.Image = (System.Drawing.Image)resources.GetObject("btnAddColour3.Image");
            btnAddColour3.Location = new System.Drawing.Point(261, 152);
            btnAddColour3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddColour3.Name = "btnAddColour3";
            btnAddColour3.Size = new System.Drawing.Size(41, 40);
            btnAddColour3.TabIndex = 24;
            btnAddColour3.UseVisualStyleBackColor = false;
            btnAddColour3.Click += btnAddColour3_Click;
            // 
            // btnRemoveColour2
            // 
            btnRemoveColour2.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRemoveColour2.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveColour2.Enabled = false;
            btnRemoveColour2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveColour2.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnRemoveColour2.Image = (System.Drawing.Image)resources.GetObject("btnRemoveColour2.Image");
            btnRemoveColour2.Location = new System.Drawing.Point(308, 112);
            btnRemoveColour2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveColour2.Name = "btnRemoveColour2";
            btnRemoveColour2.Size = new System.Drawing.Size(41, 40);
            btnRemoveColour2.TabIndex = 23;
            btnRemoveColour2.UseVisualStyleBackColor = false;
            btnRemoveColour2.Click += btnRemoveColour2_Click;
            // 
            // btnAddColour2
            // 
            btnAddColour2.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnAddColour2.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddColour2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddColour2.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnAddColour2.Image = (System.Drawing.Image)resources.GetObject("btnAddColour2.Image");
            btnAddColour2.Location = new System.Drawing.Point(261, 112);
            btnAddColour2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddColour2.Name = "btnAddColour2";
            btnAddColour2.Size = new System.Drawing.Size(41, 40);
            btnAddColour2.TabIndex = 22;
            btnAddColour2.UseVisualStyleBackColor = false;
            btnAddColour2.Click += btnAddColour2_Click;
            // 
            // btnRemoveColour1
            // 
            btnRemoveColour1.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRemoveColour1.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveColour1.Enabled = false;
            btnRemoveColour1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveColour1.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnRemoveColour1.Image = (System.Drawing.Image)resources.GetObject("btnRemoveColour1.Image");
            btnRemoveColour1.Location = new System.Drawing.Point(308, 72);
            btnRemoveColour1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveColour1.Name = "btnRemoveColour1";
            btnRemoveColour1.Size = new System.Drawing.Size(41, 40);
            btnRemoveColour1.TabIndex = 21;
            btnRemoveColour1.UseVisualStyleBackColor = false;
            btnRemoveColour1.Click += btnRemoveColour1_Click;
            // 
            // btnAddColour1
            // 
            btnAddColour1.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnAddColour1.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddColour1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddColour1.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnAddColour1.Image = (System.Drawing.Image)resources.GetObject("btnAddColour1.Image");
            btnAddColour1.Location = new System.Drawing.Point(261, 72);
            btnAddColour1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddColour1.Name = "btnAddColour1";
            btnAddColour1.Size = new System.Drawing.Size(41, 40);
            btnAddColour1.TabIndex = 20;
            btnAddColour1.UseVisualStyleBackColor = false;
            btnAddColour1.Click += btnAddColour1_Click;
            // 
            // btnRemoveColour0
            // 
            btnRemoveColour0.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnRemoveColour0.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemoveColour0.Enabled = false;
            btnRemoveColour0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveColour0.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnRemoveColour0.Image = (System.Drawing.Image)resources.GetObject("btnRemoveColour0.Image");
            btnRemoveColour0.Location = new System.Drawing.Point(308, 31);
            btnRemoveColour0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRemoveColour0.Name = "btnRemoveColour0";
            btnRemoveColour0.Size = new System.Drawing.Size(41, 40);
            btnRemoveColour0.TabIndex = 19;
            btnRemoveColour0.UseVisualStyleBackColor = false;
            btnRemoveColour0.Click += btnRemoveColour0_Click;
            // 
            // btnAddColour0
            // 
            btnAddColour0.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            btnAddColour0.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddColour0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddColour0.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnAddColour0.Image = (System.Drawing.Image)resources.GetObject("btnAddColour0.Image");
            btnAddColour0.Location = new System.Drawing.Point(261, 31);
            btnAddColour0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddColour0.Name = "btnAddColour0";
            btnAddColour0.Size = new System.Drawing.Size(41, 40);
            btnAddColour0.TabIndex = 18;
            btnAddColour0.UseVisualStyleBackColor = false;
            btnAddColour0.Click += btnAddColour0_Click;
            // 
            // cboColours5
            // 
            cboColours5.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboColours5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboColours5.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboColours5.FormattingEnabled = true;
            cboColours5.Location = new System.Drawing.Point(100, 242);
            cboColours5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboColours5.Name = "cboColours5";
            cboColours5.Size = new System.Drawing.Size(143, 23);
            cboColours5.TabIndex = 17;
            cboColours5.DrawItem += DrawComboColourItem;
            cboColours5.SelectedIndexChanged += cboColours5_SelectedIndexChanged;
            // 
            // cboColours4
            // 
            cboColours4.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboColours4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboColours4.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboColours4.FormattingEnabled = true;
            cboColours4.Location = new System.Drawing.Point(100, 202);
            cboColours4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboColours4.Name = "cboColours4";
            cboColours4.Size = new System.Drawing.Size(143, 23);
            cboColours4.TabIndex = 16;
            cboColours4.DrawItem += DrawComboColourItem;
            cboColours4.SelectedIndexChanged += cboColours4_SelectedIndexChanged;
            // 
            // cboColours3
            // 
            cboColours3.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboColours3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboColours3.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboColours3.FormattingEnabled = true;
            cboColours3.Location = new System.Drawing.Point(100, 162);
            cboColours3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboColours3.Name = "cboColours3";
            cboColours3.Size = new System.Drawing.Size(143, 23);
            cboColours3.TabIndex = 15;
            cboColours3.DrawItem += DrawComboColourItem;
            cboColours3.SelectedIndexChanged += cboColours3_SelectedIndexChanged;
            // 
            // cboColours2
            // 
            cboColours2.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboColours2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboColours2.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboColours2.FormattingEnabled = true;
            cboColours2.Location = new System.Drawing.Point(100, 121);
            cboColours2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboColours2.Name = "cboColours2";
            cboColours2.Size = new System.Drawing.Size(143, 23);
            cboColours2.TabIndex = 14;
            cboColours2.DrawItem += DrawComboColourItem;
            cboColours2.SelectedIndexChanged += cboColours2_SelectedIndexChanged;
            // 
            // cboColours1
            // 
            cboColours1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboColours1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboColours1.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboColours1.FormattingEnabled = true;
            cboColours1.Location = new System.Drawing.Point(100, 81);
            cboColours1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboColours1.Name = "cboColours1";
            cboColours1.Size = new System.Drawing.Size(143, 23);
            cboColours1.TabIndex = 13;
            cboColours1.DrawItem += DrawComboColourItem;
            cboColours1.SelectedIndexChanged += cboColours1_SelectedIndexChanged;
            // 
            // cboColours0
            // 
            cboColours0.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cboColours0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboColours0.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            cboColours0.FormattingEnabled = true;
            cboColours0.Items.AddRange(new object[] { "1" });
            cboColours0.Location = new System.Drawing.Point(100, 40);
            cboColours0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboColours0.Name = "cboColours0";
            cboColours0.Size = new System.Drawing.Size(143, 23);
            cboColours0.TabIndex = 12;
            cboColours0.DrawItem += DrawComboColourItem;
            cboColours0.SelectedIndexChanged += cboColours0_SelectedIndexChanged;
            // 
            // lblColours5
            // 
            lblColours5.AutoSize = true;
            lblColours5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblColours5.Location = new System.Drawing.Point(22, 246);
            lblColours5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblColours5.Name = "lblColours5";
            lblColours5.Size = new System.Drawing.Size(50, 13);
            lblColours5.TabIndex = 10;
            lblColours5.Text = "Region 6";
            // 
            // lblColours4
            // 
            lblColours4.AutoSize = true;
            lblColours4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblColours4.Location = new System.Drawing.Point(22, 205);
            lblColours4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblColours4.Name = "lblColours4";
            lblColours4.Size = new System.Drawing.Size(50, 13);
            lblColours4.TabIndex = 9;
            lblColours4.Text = "Region 5";
            // 
            // lblColours3
            // 
            lblColours3.AutoSize = true;
            lblColours3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblColours3.Location = new System.Drawing.Point(22, 165);
            lblColours3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblColours3.Name = "lblColours3";
            lblColours3.Size = new System.Drawing.Size(50, 13);
            lblColours3.TabIndex = 8;
            lblColours3.Text = "Region 4";
            // 
            // lblColours2
            // 
            lblColours2.AutoSize = true;
            lblColours2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblColours2.Location = new System.Drawing.Point(22, 125);
            lblColours2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblColours2.Name = "lblColours2";
            lblColours2.Size = new System.Drawing.Size(50, 13);
            lblColours2.TabIndex = 7;
            lblColours2.Text = "Region 3";
            // 
            // lblColours1
            // 
            lblColours1.AutoSize = true;
            lblColours1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblColours1.Location = new System.Drawing.Point(22, 84);
            lblColours1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblColours1.Name = "lblColours1";
            lblColours1.Size = new System.Drawing.Size(50, 13);
            lblColours1.TabIndex = 6;
            lblColours1.Text = "Region 2";
            // 
            // lblColours0
            // 
            lblColours0.AutoSize = true;
            lblColours0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblColours0.Location = new System.Drawing.Point(22, 44);
            lblColours0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblColours0.Name = "lblColours0";
            lblColours0.Size = new System.Drawing.Size(50, 13);
            lblColours0.TabIndex = 5;
            lblColours0.Text = "Region 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(8, 12);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 13);
            label2.TabIndex = 1;
            label2.Text = "Colour Options";
            // 
            // lblHeaderColours
            // 
            lblHeaderColours.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblHeaderColours.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            lblHeaderColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblHeaderColours.Location = new System.Drawing.Point(0, 0);
            lblHeaderColours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderColours.Name = "lblHeaderColours";
            lblHeaderColours.Size = new System.Drawing.Size(369, 7);
            lblHeaderColours.TabIndex = 0;
            lblHeaderColours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmBreedingFindOptions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(658, 347);
            Controls.Add(grpColours);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(grpStats);
            ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(674, 386);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(674, 386);
            Name = "frmBreedingFindOptions";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Breeding Rank Options";
            FormClosed += frmBreedingFindOptions_FormClosed;
            Load += frmBreedingFindOptions_Load;
            grpStats.ResumeLayout(false);
            grpStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)udMaxCrafting).EndInit();
            ((System.ComponentModel.ISupportInitialize)udMaxOxygen).EndInit();
            ((System.ComponentModel.ISupportInitialize)udMaxFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)udMaxSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)udMaxWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)udMaxMelee).EndInit();
            ((System.ComponentModel.ISupportInitialize)udMaxStamina).EndInit();
            ((System.ComponentModel.ISupportInitialize)udMaxHp).EndInit();
            grpColours.ResumeLayout(false);
            grpColours.PerformLayout();
            ResumeLayout(false);
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
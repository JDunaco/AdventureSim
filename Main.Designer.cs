namespace AdventureSim
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ArmySimTITLE = new System.Windows.Forms.Label();
            this.BossName = new System.Windows.Forms.Label();
            this.BossWarriorLabel = new System.Windows.Forms.Label();
            this.BossArchersLabel = new System.Windows.Forms.Label();
            this.BossMagesLabel = new System.Windows.Forms.Label();
            this.BossWarriorNum = new System.Windows.Forms.Label();
            this.BossArcherNum = new System.Windows.Forms.Label();
            this.BossMageNum = new System.Windows.Forms.Label();
            this.PlayerMageNum = new System.Windows.Forms.Label();
            this.PlayerArcherNum = new System.Windows.Forms.Label();
            this.PlayerWarriorNum = new System.Windows.Forms.Label();
            this.PlayerMageLabel = new System.Windows.Forms.Label();
            this.PlayerArcherLabel = new System.Windows.Forms.Label();
            this.PlayerWarriorLabel = new System.Windows.Forms.Label();
            this.GoldNum = new System.Windows.Forms.Label();
            this.ChoiceAskLabel = new System.Windows.Forms.Label();
            this.ShopButton = new System.Windows.Forms.Button();
            this.RecruitButton = new System.Windows.Forms.Button();
            this.TrainButton = new System.Windows.Forms.Button();
            this.RoundsLeftLabel = new System.Windows.Forms.Label();
            this.RoundsLeftNum = new System.Windows.Forms.Label();
            this.SelectShop1Button = new System.Windows.Forms.Button();
            this.SelectShop2Button = new System.Windows.Forms.Button();
            this.SelectShop3Button = new System.Windows.Forms.Button();
            this.DoneShoppingButton = new System.Windows.Forms.Button();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.TrainMagesButton = new System.Windows.Forms.Button();
            this.TrainArchersButton = new System.Windows.Forms.Button();
            this.TrainWarriorsButton = new System.Windows.Forms.Button();
            this.StrLabel = new System.Windows.Forms.Label();
            this.WarriorStrDisplay = new System.Windows.Forms.Label();
            this.ArcherStrDisplay = new System.Windows.Forms.Label();
            this.MageStrDisplay = new System.Windows.Forms.Label();
            this.RecruitWarriorButton = new System.Windows.Forms.Button();
            this.RecruitMagesButton = new System.Windows.Forms.Button();
            this.RecruitArchersButton = new System.Windows.Forms.Button();
            this.CombatQuestion = new System.Windows.Forms.Label();
            this.CombatQuestionMageButton = new System.Windows.Forms.Button();
            this.CombatQuestionArcherButton = new System.Windows.Forms.Button();
            this.CombatQuestionWarriorButton = new System.Windows.Forms.Button();
            this.RecruitWarriorPicture = new System.Windows.Forms.PictureBox();
            this.RecruitArcherPicture = new System.Windows.Forms.PictureBox();
            this.RecruitMagePicture = new System.Windows.Forms.PictureBox();
            this.GoldLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RecruitWarriorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecruitArcherPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecruitMagePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ArmySimTITLE
            // 
            this.ArmySimTITLE.Location = new System.Drawing.Point(609, 9);
            this.ArmySimTITLE.Name = "ArmySimTITLE";
            this.ArmySimTITLE.Size = new System.Drawing.Size(205, 59);
            this.ArmySimTITLE.TabIndex = 0;
            this.ArmySimTITLE.Tag = "Base";
            this.ArmySimTITLE.Text = "Jordan\'s Army Simulation";
            this.ArmySimTITLE.Click += new System.EventHandler(this.label1_Click);
            // 
            // BossName
            // 
            this.BossName.AutoSize = true;
            this.BossName.Location = new System.Drawing.Point(985, 9);
            this.BossName.Name = "BossName";
            this.BossName.Size = new System.Drawing.Size(64, 13);
            this.BossName.TabIndex = 1;
            this.BossName.Tag = "Base";
            this.BossName.Text = "=BossName";
            this.BossName.Click += new System.EventHandler(this.BossName_Click);
            // 
            // BossWarriorLabel
            // 
            this.BossWarriorLabel.AutoSize = true;
            this.BossWarriorLabel.Location = new System.Drawing.Point(928, 50);
            this.BossWarriorLabel.Name = "BossWarriorLabel";
            this.BossWarriorLabel.Size = new System.Drawing.Size(79, 13);
            this.BossWarriorLabel.TabIndex = 2;
            this.BossWarriorLabel.Tag = "Base";
            this.BossWarriorLabel.Text = "Boss\'s Warriors";
            this.BossWarriorLabel.Click += new System.EventHandler(this.BossWarriorLabel_Click);
            // 
            // BossArchersLabel
            // 
            this.BossArchersLabel.AutoSize = true;
            this.BossArchersLabel.Location = new System.Drawing.Point(1013, 50);
            this.BossArchersLabel.Name = "BossArchersLabel";
            this.BossArchersLabel.Size = new System.Drawing.Size(76, 13);
            this.BossArchersLabel.TabIndex = 3;
            this.BossArchersLabel.Tag = "Base";
            this.BossArchersLabel.Text = "Boss\'s Archers";
            this.BossArchersLabel.Click += new System.EventHandler(this.BossArchersLabel_Click);
            // 
            // BossMagesLabel
            // 
            this.BossMagesLabel.AutoSize = true;
            this.BossMagesLabel.Location = new System.Drawing.Point(1095, 50);
            this.BossMagesLabel.Name = "BossMagesLabel";
            this.BossMagesLabel.Size = new System.Drawing.Size(72, 13);
            this.BossMagesLabel.TabIndex = 4;
            this.BossMagesLabel.Tag = "Base";
            this.BossMagesLabel.Text = "Boss\'s Mages";
            this.BossMagesLabel.Click += new System.EventHandler(this.BossMagesLabel_Click);
            // 
            // BossWarriorNum
            // 
            this.BossWarriorNum.AutoSize = true;
            this.BossWarriorNum.Location = new System.Drawing.Point(957, 67);
            this.BossWarriorNum.Name = "BossWarriorNum";
            this.BossWarriorNum.Size = new System.Drawing.Size(13, 13);
            this.BossWarriorNum.TabIndex = 5;
            this.BossWarriorNum.Tag = "Base";
            this.BossWarriorNum.Text = "0";
            this.BossWarriorNum.Click += new System.EventHandler(this.BossWarriorNum_Click);
            // 
            // BossArcherNum
            // 
            this.BossArcherNum.AutoSize = true;
            this.BossArcherNum.Location = new System.Drawing.Point(1036, 67);
            this.BossArcherNum.Name = "BossArcherNum";
            this.BossArcherNum.Size = new System.Drawing.Size(13, 13);
            this.BossArcherNum.TabIndex = 6;
            this.BossArcherNum.Tag = "Base";
            this.BossArcherNum.Text = "0";
            this.BossArcherNum.Click += new System.EventHandler(this.BossArcherNum_Click);
            // 
            // BossMageNum
            // 
            this.BossMageNum.AutoSize = true;
            this.BossMageNum.Location = new System.Drawing.Point(1123, 67);
            this.BossMageNum.Name = "BossMageNum";
            this.BossMageNum.Size = new System.Drawing.Size(13, 13);
            this.BossMageNum.TabIndex = 7;
            this.BossMageNum.Tag = "Base";
            this.BossMageNum.Text = "0";
            this.BossMageNum.Click += new System.EventHandler(this.BossMageNum_Click);
            // 
            // PlayerMageNum
            // 
            this.PlayerMageNum.AutoSize = true;
            this.PlayerMageNum.Location = new System.Drawing.Point(305, 71);
            this.PlayerMageNum.Name = "PlayerMageNum";
            this.PlayerMageNum.Size = new System.Drawing.Size(13, 13);
            this.PlayerMageNum.TabIndex = 14;
            this.PlayerMageNum.Tag = "Base";
            this.PlayerMageNum.Text = "0";
            this.PlayerMageNum.Click += new System.EventHandler(this.PlayerMageNum_Click);
            // 
            // PlayerArcherNum
            // 
            this.PlayerArcherNum.AutoSize = true;
            this.PlayerArcherNum.Location = new System.Drawing.Point(218, 71);
            this.PlayerArcherNum.Name = "PlayerArcherNum";
            this.PlayerArcherNum.Size = new System.Drawing.Size(13, 13);
            this.PlayerArcherNum.TabIndex = 13;
            this.PlayerArcherNum.Tag = "Base";
            this.PlayerArcherNum.Text = "0";
            this.PlayerArcherNum.Click += new System.EventHandler(this.PlayerArcherNum_Click);
            // 
            // PlayerWarriorNum
            // 
            this.PlayerWarriorNum.AutoSize = true;
            this.PlayerWarriorNum.Location = new System.Drawing.Point(139, 71);
            this.PlayerWarriorNum.Name = "PlayerWarriorNum";
            this.PlayerWarriorNum.Size = new System.Drawing.Size(13, 13);
            this.PlayerWarriorNum.TabIndex = 12;
            this.PlayerWarriorNum.Tag = "Base";
            this.PlayerWarriorNum.Text = "0";
            this.PlayerWarriorNum.Click += new System.EventHandler(this.PlayerWarriorNum_Click);
            // 
            // PlayerMageLabel
            // 
            this.PlayerMageLabel.AutoSize = true;
            this.PlayerMageLabel.Location = new System.Drawing.Point(277, 54);
            this.PlayerMageLabel.Name = "PlayerMageLabel";
            this.PlayerMageLabel.Size = new System.Drawing.Size(78, 13);
            this.PlayerMageLabel.TabIndex = 11;
            this.PlayerMageLabel.Tag = "Base";
            this.PlayerMageLabel.Text = "Player\'s Mages";
            this.PlayerMageLabel.Click += new System.EventHandler(this.PlayerMageLabel_Click);
            // 
            // PlayerArcherLabel
            // 
            this.PlayerArcherLabel.AutoSize = true;
            this.PlayerArcherLabel.Location = new System.Drawing.Point(195, 54);
            this.PlayerArcherLabel.Name = "PlayerArcherLabel";
            this.PlayerArcherLabel.Size = new System.Drawing.Size(82, 13);
            this.PlayerArcherLabel.TabIndex = 10;
            this.PlayerArcherLabel.Tag = "Base";
            this.PlayerArcherLabel.Text = "Player\'s Archers";
            this.PlayerArcherLabel.Click += new System.EventHandler(this.PlayerArcherLabel_Click);
            // 
            // PlayerWarriorLabel
            // 
            this.PlayerWarriorLabel.AutoSize = true;
            this.PlayerWarriorLabel.Location = new System.Drawing.Point(110, 54);
            this.PlayerWarriorLabel.Name = "PlayerWarriorLabel";
            this.PlayerWarriorLabel.Size = new System.Drawing.Size(85, 13);
            this.PlayerWarriorLabel.TabIndex = 9;
            this.PlayerWarriorLabel.Tag = "Base";
            this.PlayerWarriorLabel.Text = "Player\'s Warriors";
            this.PlayerWarriorLabel.Click += new System.EventHandler(this.PlayerWarriorLabel_Click);
            // 
            // GoldNum
            // 
            this.GoldNum.AutoSize = true;
            this.GoldNum.Location = new System.Drawing.Point(473, 55);
            this.GoldNum.Name = "GoldNum";
            this.GoldNum.Size = new System.Drawing.Size(13, 13);
            this.GoldNum.TabIndex = 16;
            this.GoldNum.Tag = "Base";
            this.GoldNum.Text = "0";
            this.GoldNum.Click += new System.EventHandler(this.GoldNum_Click);
            // 
            // ChoiceAskLabel
            // 
            this.ChoiceAskLabel.AutoSize = true;
            this.ChoiceAskLabel.Location = new System.Drawing.Point(626, 124);
            this.ChoiceAskLabel.Name = "ChoiceAskLabel";
            this.ChoiceAskLabel.Size = new System.Drawing.Size(136, 13);
            this.ChoiceAskLabel.TabIndex = 17;
            this.ChoiceAskLabel.Tag = "Main";
            this.ChoiceAskLabel.Text = "What would you like to do?";
            this.ChoiceAskLabel.Click += new System.EventHandler(this.ChoiceAskLabel_Click);
            // 
            // ShopButton
            // 
            this.ShopButton.Location = new System.Drawing.Point(212, 483);
            this.ShopButton.Name = "ShopButton";
            this.ShopButton.Size = new System.Drawing.Size(92, 23);
            this.ShopButton.TabIndex = 19;
            this.ShopButton.Tag = "Main";
            this.ShopButton.Text = "Shop";
            this.ShopButton.UseVisualStyleBackColor = true;
            this.ShopButton.Click += new System.EventHandler(this.ShopButton_Click);
            // 
            // RecruitButton
            // 
            this.RecruitButton.Location = new System.Drawing.Point(640, 483);
            this.RecruitButton.Name = "RecruitButton";
            this.RecruitButton.Size = new System.Drawing.Size(90, 23);
            this.RecruitButton.TabIndex = 20;
            this.RecruitButton.Tag = "Main";
            this.RecruitButton.Text = "Recruitement";
            this.RecruitButton.UseVisualStyleBackColor = true;
            this.RecruitButton.Click += new System.EventHandler(this.RecruitButton_Click);
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(1016, 483);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(99, 23);
            this.TrainButton.TabIndex = 21;
            this.TrainButton.Tag = "Main";
            this.TrainButton.Text = "Fight";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // RoundsLeftLabel
            // 
            this.RoundsLeftLabel.AutoSize = true;
            this.RoundsLeftLabel.Location = new System.Drawing.Point(637, 58);
            this.RoundsLeftLabel.Name = "RoundsLeftLabel";
            this.RoundsLeftLabel.Size = new System.Drawing.Size(65, 13);
            this.RoundsLeftLabel.TabIndex = 22;
            this.RoundsLeftLabel.Tag = "Base";
            this.RoundsLeftLabel.Text = "Rounds Left";
            this.RoundsLeftLabel.Click += new System.EventHandler(this.RoundsLeftLabel_Click);
            // 
            // RoundsLeftNum
            // 
            this.RoundsLeftNum.AutoSize = true;
            this.RoundsLeftNum.Location = new System.Drawing.Point(663, 81);
            this.RoundsLeftNum.Name = "RoundsLeftNum";
            this.RoundsLeftNum.Size = new System.Drawing.Size(13, 13);
            this.RoundsLeftNum.TabIndex = 23;
            this.RoundsLeftNum.Tag = "Base";
            this.RoundsLeftNum.Text = "0";
            this.RoundsLeftNum.Click += new System.EventHandler(this.RoundsLeftNum_Click);
            // 
            // SelectShop1Button
            // 
            this.SelectShop1Button.Location = new System.Drawing.Point(212, 437);
            this.SelectShop1Button.Name = "SelectShop1Button";
            this.SelectShop1Button.Size = new System.Drawing.Size(92, 23);
            this.SelectShop1Button.TabIndex = 24;
            this.SelectShop1Button.Tag = "Shop";
            this.SelectShop1Button.Text = "Buy";
            this.SelectShop1Button.UseVisualStyleBackColor = true;
            this.SelectShop1Button.Click += new System.EventHandler(this.SelectShop1Button_Click);
            // 
            // SelectShop2Button
            // 
            this.SelectShop2Button.Location = new System.Drawing.Point(640, 437);
            this.SelectShop2Button.Name = "SelectShop2Button";
            this.SelectShop2Button.Size = new System.Drawing.Size(90, 23);
            this.SelectShop2Button.TabIndex = 25;
            this.SelectShop2Button.Tag = "Shop";
            this.SelectShop2Button.Text = "Buy";
            this.SelectShop2Button.UseVisualStyleBackColor = true;
            this.SelectShop2Button.Click += new System.EventHandler(this.SelectShop2Button_Click);
            // 
            // SelectShop3Button
            // 
            this.SelectShop3Button.Location = new System.Drawing.Point(1016, 437);
            this.SelectShop3Button.Name = "SelectShop3Button";
            this.SelectShop3Button.Size = new System.Drawing.Size(99, 23);
            this.SelectShop3Button.TabIndex = 26;
            this.SelectShop3Button.Tag = "Shop";
            this.SelectShop3Button.Text = "Buy";
            this.SelectShop3Button.UseVisualStyleBackColor = true;
            this.SelectShop3Button.Click += new System.EventHandler(this.SelectShop3Button_Click);
            // 
            // DoneShoppingButton
            // 
            this.DoneShoppingButton.Location = new System.Drawing.Point(640, 483);
            this.DoneShoppingButton.Name = "DoneShoppingButton";
            this.DoneShoppingButton.Size = new System.Drawing.Size(90, 23);
            this.DoneShoppingButton.TabIndex = 27;
            this.DoneShoppingButton.Tag = "Shop";
            this.DoneShoppingButton.Text = "Finished";
            this.DoneShoppingButton.UseVisualStyleBackColor = true;
            this.DoneShoppingButton.Click += new System.EventHandler(this.DoneShoppingButton_Click);
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Location = new System.Drawing.Point(167, 13);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(70, 13);
            this.PlayerNameLabel.TabIndex = 8;
            this.PlayerNameLabel.Tag = "Base";
            this.PlayerNameLabel.Text = "=PlayerName";
            this.PlayerNameLabel.Click += new System.EventHandler(this.PlayerNameLabel_Click);
            // 
            // TrainMagesButton
            // 
            this.TrainMagesButton.Location = new System.Drawing.Point(1016, 437);
            this.TrainMagesButton.Name = "TrainMagesButton";
            this.TrainMagesButton.Size = new System.Drawing.Size(99, 23);
            this.TrainMagesButton.TabIndex = 30;
            this.TrainMagesButton.Tag = "Training";
            this.TrainMagesButton.Text = "Fight Mages";
            this.TrainMagesButton.UseVisualStyleBackColor = true;
            this.TrainMagesButton.Click += new System.EventHandler(this.TrainMagesButton_Click);
            // 
            // TrainArchersButton
            // 
            this.TrainArchersButton.Location = new System.Drawing.Point(640, 437);
            this.TrainArchersButton.Name = "TrainArchersButton";
            this.TrainArchersButton.Size = new System.Drawing.Size(90, 23);
            this.TrainArchersButton.TabIndex = 29;
            this.TrainArchersButton.Tag = "Training";
            this.TrainArchersButton.Text = "Fight Archers";
            this.TrainArchersButton.UseVisualStyleBackColor = true;
            this.TrainArchersButton.Click += new System.EventHandler(this.TrainArchersButton_Click);
            // 
            // TrainWarriorsButton
            // 
            this.TrainWarriorsButton.Location = new System.Drawing.Point(212, 437);
            this.TrainWarriorsButton.Name = "TrainWarriorsButton";
            this.TrainWarriorsButton.Size = new System.Drawing.Size(92, 23);
            this.TrainWarriorsButton.TabIndex = 28;
            this.TrainWarriorsButton.Tag = "Training";
            this.TrainWarriorsButton.Text = "Fight Warriors";
            this.TrainWarriorsButton.UseVisualStyleBackColor = true;
            this.TrainWarriorsButton.Click += new System.EventHandler(this.TrainWarriorsButton_Click);
            // 
            // StrLabel
            // 
            this.StrLabel.AutoSize = true;
            this.StrLabel.Location = new System.Drawing.Point(52, 92);
            this.StrLabel.Name = "StrLabel";
            this.StrLabel.Size = new System.Drawing.Size(47, 13);
            this.StrLabel.TabIndex = 31;
            this.StrLabel.Text = "Strength";
            // 
            // WarriorStrDisplay
            // 
            this.WarriorStrDisplay.AutoSize = true;
            this.WarriorStrDisplay.Location = new System.Drawing.Point(139, 92);
            this.WarriorStrDisplay.Name = "WarriorStrDisplay";
            this.WarriorStrDisplay.Size = new System.Drawing.Size(13, 13);
            this.WarriorStrDisplay.TabIndex = 32;
            this.WarriorStrDisplay.Text = "0";
            // 
            // ArcherStrDisplay
            // 
            this.ArcherStrDisplay.AutoSize = true;
            this.ArcherStrDisplay.Location = new System.Drawing.Point(218, 92);
            this.ArcherStrDisplay.Name = "ArcherStrDisplay";
            this.ArcherStrDisplay.Size = new System.Drawing.Size(13, 13);
            this.ArcherStrDisplay.TabIndex = 33;
            this.ArcherStrDisplay.Text = "0";
            // 
            // MageStrDisplay
            // 
            this.MageStrDisplay.AutoSize = true;
            this.MageStrDisplay.Location = new System.Drawing.Point(305, 92);
            this.MageStrDisplay.Name = "MageStrDisplay";
            this.MageStrDisplay.Size = new System.Drawing.Size(13, 13);
            this.MageStrDisplay.TabIndex = 34;
            this.MageStrDisplay.Text = "0";
            // 
            // RecruitWarriorButton
            // 
            this.RecruitWarriorButton.Location = new System.Drawing.Point(212, 437);
            this.RecruitWarriorButton.Name = "RecruitWarriorButton";
            this.RecruitWarriorButton.Size = new System.Drawing.Size(92, 23);
            this.RecruitWarriorButton.TabIndex = 35;
            this.RecruitWarriorButton.Tag = "Training";
            this.RecruitWarriorButton.Text = "Recruit Warriors";
            this.RecruitWarriorButton.UseVisualStyleBackColor = true;
            this.RecruitWarriorButton.Click += new System.EventHandler(this.RecruitWarriorButton_Click);
            // 
            // RecruitMagesButton
            // 
            this.RecruitMagesButton.Location = new System.Drawing.Point(1016, 437);
            this.RecruitMagesButton.Name = "RecruitMagesButton";
            this.RecruitMagesButton.Size = new System.Drawing.Size(99, 23);
            this.RecruitMagesButton.TabIndex = 36;
            this.RecruitMagesButton.Tag = "Recruit";
            this.RecruitMagesButton.Text = "Recruit Mages";
            this.RecruitMagesButton.UseVisualStyleBackColor = true;
            this.RecruitMagesButton.Click += new System.EventHandler(this.RecruitMagesButton_Click);
            // 
            // RecruitArchersButton
            // 
            this.RecruitArchersButton.Location = new System.Drawing.Point(640, 437);
            this.RecruitArchersButton.Name = "RecruitArchersButton";
            this.RecruitArchersButton.Size = new System.Drawing.Size(90, 23);
            this.RecruitArchersButton.TabIndex = 37;
            this.RecruitArchersButton.Tag = "Training";
            this.RecruitArchersButton.Text = "Recruit Archers";
            this.RecruitArchersButton.UseVisualStyleBackColor = true;
            this.RecruitArchersButton.Click += new System.EventHandler(this.RecruitArchersButton_Click);
            // 
            // CombatQuestion
            // 
            this.CombatQuestion.AutoSize = true;
            this.CombatQuestion.Location = new System.Drawing.Point(561, 124);
            this.CombatQuestion.Name = "CombatQuestion";
            this.CombatQuestion.Size = new System.Drawing.Size(201, 13);
            this.CombatQuestion.TabIndex = 38;
            this.CombatQuestion.Tag = "Main";
            this.CombatQuestion.Text = "Who would you like to start combat with?";
            // 
            // CombatQuestionMageButton
            // 
            this.CombatQuestionMageButton.Location = new System.Drawing.Point(1016, 437);
            this.CombatQuestionMageButton.Name = "CombatQuestionMageButton";
            this.CombatQuestionMageButton.Size = new System.Drawing.Size(99, 23);
            this.CombatQuestionMageButton.TabIndex = 39;
            this.CombatQuestionMageButton.Tag = "Recruit";
            this.CombatQuestionMageButton.Text = "Mages";
            this.CombatQuestionMageButton.UseVisualStyleBackColor = true;
            this.CombatQuestionMageButton.Click += new System.EventHandler(this.CombatQuestionMageButton_Click);
            // 
            // CombatQuestionArcherButton
            // 
            this.CombatQuestionArcherButton.Location = new System.Drawing.Point(640, 437);
            this.CombatQuestionArcherButton.Name = "CombatQuestionArcherButton";
            this.CombatQuestionArcherButton.Size = new System.Drawing.Size(90, 23);
            this.CombatQuestionArcherButton.TabIndex = 40;
            this.CombatQuestionArcherButton.Tag = "Recruit";
            this.CombatQuestionArcherButton.Text = "Archers";
            this.CombatQuestionArcherButton.UseVisualStyleBackColor = true;
            this.CombatQuestionArcherButton.Click += new System.EventHandler(this.CombatQuestionArcherButton_Click);
            // 
            // CombatQuestionWarriorButton
            // 
            this.CombatQuestionWarriorButton.Location = new System.Drawing.Point(212, 437);
            this.CombatQuestionWarriorButton.Name = "CombatQuestionWarriorButton";
            this.CombatQuestionWarriorButton.Size = new System.Drawing.Size(92, 23);
            this.CombatQuestionWarriorButton.TabIndex = 41;
            this.CombatQuestionWarriorButton.Tag = "Recruit";
            this.CombatQuestionWarriorButton.Text = "Warriors";
            this.CombatQuestionWarriorButton.UseVisualStyleBackColor = true;
            this.CombatQuestionWarriorButton.Click += new System.EventHandler(this.CombatQuestionWarriorButton_Click);
            // 
            // RecruitWarriorPicture
            // 
            this.RecruitWarriorPicture.Image = ((System.Drawing.Image)(resources.GetObject("RecruitWarriorPicture.Image")));
            this.RecruitWarriorPicture.Location = new System.Drawing.Point(142, 169);
            this.RecruitWarriorPicture.Name = "RecruitWarriorPicture";
            this.RecruitWarriorPicture.Size = new System.Drawing.Size(224, 226);
            this.RecruitWarriorPicture.TabIndex = 42;
            this.RecruitWarriorPicture.TabStop = false;
            this.RecruitWarriorPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RecruitArcherPicture
            // 
            this.RecruitArcherPicture.Image = ((System.Drawing.Image)(resources.GetObject("RecruitArcherPicture.Image")));
            this.RecruitArcherPicture.Location = new System.Drawing.Point(564, 169);
            this.RecruitArcherPicture.Name = "RecruitArcherPicture";
            this.RecruitArcherPicture.Size = new System.Drawing.Size(224, 226);
            this.RecruitArcherPicture.TabIndex = 43;
            this.RecruitArcherPicture.TabStop = false;
            // 
            // RecruitMagePicture
            // 
            this.RecruitMagePicture.Image = ((System.Drawing.Image)(resources.GetObject("RecruitMagePicture.Image")));
            this.RecruitMagePicture.Location = new System.Drawing.Point(943, 169);
            this.RecruitMagePicture.Name = "RecruitMagePicture";
            this.RecruitMagePicture.Size = new System.Drawing.Size(224, 226);
            this.RecruitMagePicture.TabIndex = 44;
            this.RecruitMagePicture.TabStop = false;
            // 
            // GoldLabel
            // 
            this.GoldLabel.AutoSize = true;
            this.GoldLabel.Location = new System.Drawing.Point(457, 25);
            this.GoldLabel.Name = "GoldLabel";
            this.GoldLabel.Size = new System.Drawing.Size(29, 13);
            this.GoldLabel.TabIndex = 15;
            this.GoldLabel.Tag = "Base";
            this.GoldLabel.Text = "Gold";
            this.GoldLabel.Click += new System.EventHandler(this.GoldLabel_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 559);
            this.Controls.Add(this.RecruitMagePicture);
            this.Controls.Add(this.RecruitArcherPicture);
            this.Controls.Add(this.RecruitWarriorPicture);
            this.Controls.Add(this.CombatQuestionWarriorButton);
            this.Controls.Add(this.CombatQuestionArcherButton);
            this.Controls.Add(this.CombatQuestionMageButton);
            this.Controls.Add(this.CombatQuestion);
            this.Controls.Add(this.RecruitArchersButton);
            this.Controls.Add(this.RecruitMagesButton);
            this.Controls.Add(this.RecruitWarriorButton);
            this.Controls.Add(this.MageStrDisplay);
            this.Controls.Add(this.ArcherStrDisplay);
            this.Controls.Add(this.WarriorStrDisplay);
            this.Controls.Add(this.StrLabel);
            this.Controls.Add(this.TrainMagesButton);
            this.Controls.Add(this.TrainArchersButton);
            this.Controls.Add(this.TrainWarriorsButton);
            this.Controls.Add(this.DoneShoppingButton);
            this.Controls.Add(this.SelectShop3Button);
            this.Controls.Add(this.SelectShop2Button);
            this.Controls.Add(this.SelectShop1Button);
            this.Controls.Add(this.RoundsLeftNum);
            this.Controls.Add(this.RoundsLeftLabel);
            this.Controls.Add(this.TrainButton);
            this.Controls.Add(this.RecruitButton);
            this.Controls.Add(this.ShopButton);
            this.Controls.Add(this.ChoiceAskLabel);
            this.Controls.Add(this.GoldNum);
            this.Controls.Add(this.GoldLabel);
            this.Controls.Add(this.PlayerMageNum);
            this.Controls.Add(this.PlayerArcherNum);
            this.Controls.Add(this.PlayerWarriorNum);
            this.Controls.Add(this.PlayerMageLabel);
            this.Controls.Add(this.PlayerArcherLabel);
            this.Controls.Add(this.PlayerWarriorLabel);
            this.Controls.Add(this.PlayerNameLabel);
            this.Controls.Add(this.BossMageNum);
            this.Controls.Add(this.BossArcherNum);
            this.Controls.Add(this.BossWarriorNum);
            this.Controls.Add(this.BossMagesLabel);
            this.Controls.Add(this.BossArchersLabel);
            this.Controls.Add(this.BossWarriorLabel);
            this.Controls.Add(this.BossName);
            this.Controls.Add(this.ArmySimTITLE);
            this.Name = "Main";
            this.Text = "Combat Triangle Sim";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecruitWarriorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecruitArcherPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecruitMagePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArmySimTITLE;
        private System.Windows.Forms.Label BossName;
        private System.Windows.Forms.Label BossWarriorLabel;
        private System.Windows.Forms.Label BossArchersLabel;
        private System.Windows.Forms.Label BossMagesLabel;
        private System.Windows.Forms.Label BossWarriorNum;
        private System.Windows.Forms.Label BossArcherNum;
        private System.Windows.Forms.Label BossMageNum;
        private System.Windows.Forms.Label PlayerMageNum;
        private System.Windows.Forms.Label PlayerArcherNum;
        private System.Windows.Forms.Label PlayerWarriorNum;
        private System.Windows.Forms.Label PlayerMageLabel;
        private System.Windows.Forms.Label PlayerArcherLabel;
        private System.Windows.Forms.Label PlayerWarriorLabel;
        private System.Windows.Forms.Label GoldNum;
        private System.Windows.Forms.Label ChoiceAskLabel;
        private System.Windows.Forms.Button ShopButton;
        private System.Windows.Forms.Button RecruitButton;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.Label RoundsLeftLabel;
        private System.Windows.Forms.Label RoundsLeftNum;
        private System.Windows.Forms.Button SelectShop1Button;
        private System.Windows.Forms.Button SelectShop2Button;
        private System.Windows.Forms.Button SelectShop3Button;
        private System.Windows.Forms.Button DoneShoppingButton;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Button TrainMagesButton;
        private System.Windows.Forms.Button TrainArchersButton;
        private System.Windows.Forms.Button TrainWarriorsButton;
        private System.Windows.Forms.Label StrLabel;
        private System.Windows.Forms.Label WarriorStrDisplay;
        private System.Windows.Forms.Label ArcherStrDisplay;
        private System.Windows.Forms.Label MageStrDisplay;
        private System.Windows.Forms.Button RecruitWarriorButton;
        private System.Windows.Forms.Button RecruitMagesButton;
        private System.Windows.Forms.Button RecruitArchersButton;
        private System.Windows.Forms.Label CombatQuestion;
        private System.Windows.Forms.Button CombatQuestionMageButton;
        private System.Windows.Forms.Button CombatQuestionArcherButton;
        private System.Windows.Forms.Button CombatQuestionWarriorButton;
        private System.Windows.Forms.PictureBox RecruitWarriorPicture;
        private System.Windows.Forms.PictureBox RecruitArcherPicture;
        private System.Windows.Forms.PictureBox RecruitMagePicture;
        private System.Windows.Forms.Label GoldLabel;
    }
}


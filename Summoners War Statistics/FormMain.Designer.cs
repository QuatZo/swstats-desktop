namespace Summoners_War_Statistics
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelRunesInfo = new System.Windows.Forms.Label();
            this.labelMonsters = new System.Windows.Forms.Label();
            this.labelDimensionalHoleInfo = new System.Windows.Forms.Label();
            this.labelArenaInfo = new System.Windows.Forms.Label();
            this.labelBuildingsInfo = new System.Windows.Forms.Label();
            this.labelTowersCalculator = new System.Windows.Forms.Label();
            this.labelSomething = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxSelectJson = new System.Windows.Forms.PictureBox();
            this.introduction1 = new Summoners_War_Statistics.Summary();
            this.menu1 = new Summoners_War_Statistics.Menu();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectJson)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRunesInfo
            // 
            this.labelRunesInfo.AutoSize = true;
            this.labelRunesInfo.Location = new System.Drawing.Point(463, 78);
            this.labelRunesInfo.Name = "labelRunesInfo";
            this.labelRunesInfo.Size = new System.Drawing.Size(309, 39);
            this.labelRunesInfo.TabIndex = 1;
            this.labelRunesInfo.Text = "Your runes - worst, best, median, mean, standard deviation, \r\nGaussian distributi" +
    "on (if exist, some plot - Pytong + REACT here)\r\nBest HP% slot 6 rune, in terms o" +
    "f efficiency etc, some fancy stuff";
            // 
            // labelMonsters
            // 
            this.labelMonsters.AutoSize = true;
            this.labelMonsters.Location = new System.Drawing.Point(9, 336);
            this.labelMonsters.Name = "labelMonsters";
            this.labelMonsters.Size = new System.Drawing.Size(188, 13);
            this.labelMonsters.TabIndex = 2;
            this.labelMonsters.Text = "Amount of monsters, 6*, 5*, locked etc";
            // 
            // labelDimensionalHoleInfo
            // 
            this.labelDimensionalHoleInfo.AutoSize = true;
            this.labelDimensionalHoleInfo.Location = new System.Drawing.Point(449, 336);
            this.labelDimensionalHoleInfo.Name = "labelDimensionalHoleInfo";
            this.labelDimensionalHoleInfo.Size = new System.Drawing.Size(323, 13);
            this.labelDimensionalHoleInfo.TabIndex = 3;
            this.labelDimensionalHoleInfo.Text = "Dimensional Hole info - how much energy, how long till you max out";
            // 
            // labelArenaInfo
            // 
            this.labelArenaInfo.AutoSize = true;
            this.labelArenaInfo.Location = new System.Drawing.Point(9, 427);
            this.labelArenaInfo.Name = "labelArenaInfo";
            this.labelArenaInfo.Size = new System.Drawing.Size(323, 13);
            this.labelArenaInfo.TabIndex = 4;
            this.labelArenaInfo.Text = "Dimensional Hole info - how much energy, how long till you max out";
            // 
            // labelBuildingsInfo
            // 
            this.labelBuildingsInfo.AutoSize = true;
            this.labelBuildingsInfo.Location = new System.Drawing.Point(544, 427);
            this.labelBuildingsInfo.Name = "labelBuildingsInfo";
            this.labelBuildingsInfo.Size = new System.Drawing.Size(228, 13);
            this.labelBuildingsInfo.TabIndex = 5;
            this.labelBuildingsInfo.Text = "Some obstacles, decorations and buildings info\r\n";
            // 
            // labelTowersCalculator
            // 
            this.labelTowersCalculator.AutoSize = true;
            this.labelTowersCalculator.Location = new System.Drawing.Point(13, 585);
            this.labelTowersCalculator.Name = "labelTowersCalculator";
            this.labelTowersCalculator.Size = new System.Drawing.Size(279, 13);
            this.labelTowersCalculator.TabIndex = 6;
            this.labelTowersCalculator.Text = "How much Guild Points / Glory Points to max towers/flags";
            // 
            // labelSomething
            // 
            this.labelSomething.AutoSize = true;
            this.labelSomething.Location = new System.Drawing.Point(603, 585);
            this.labelSomething.Name = "labelSomething";
            this.labelSomething.Size = new System.Drawing.Size(112, 13);
            this.labelSomething.TabIndex = 7;
            this.labelSomething.Text = "Something else to add";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // pictureBoxSelectJson
            // 
            this.pictureBoxSelectJson.Image = global::Summoners_War_Statistics.Properties.Resources.banner_selectjsonfile;
            this.pictureBoxSelectJson.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxSelectJson.Name = "pictureBoxSelectJson";
            this.pictureBoxSelectJson.Size = new System.Drawing.Size(760, 50);
            this.pictureBoxSelectJson.TabIndex = 10;
            this.pictureBoxSelectJson.TabStop = false;
            this.pictureBoxSelectJson.Click += new System.EventHandler(this.pictureBoxSelectJson_Click);
            // 
            // introduction1
            // 
            this.introduction1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.introduction1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.introduction1.JsonModifcationDate = "Json file creation date";
            this.introduction1.Location = new System.Drawing.Point(0, 150);
            this.introduction1.Name = "introduction1";
            this.introduction1.Size = new System.Drawing.Size(784, 411);
            this.introduction1.SummonerAncientCoins = ((ushort)(0));
            this.introduction1.SummonerArenaEnergy = ((byte)(0));
            this.introduction1.SummonerArenaEnergyMax = ((byte)(0));
            this.introduction1.SummonerLastCountry = ((System.Drawing.Image)(resources.GetObject("introduction1.SummonerCountry")));
            this.introduction1.SummonerCrystals = ((uint)(0u));
            this.introduction1.SummonerDimensionalCrystals = ((byte)(0));
            this.introduction1.SummonerDimensionalCrystalsMax = ((byte)(0));
            this.introduction1.SummonerDimensionalHoleEnergy = ((byte)(0));
            this.introduction1.SummonerDimensionalHoleEnergyMax = ((byte)(0));
            this.introduction1.SummonerEnergy = ((byte)(0));
            this.introduction1.SummonerEnergyMax = ((byte)(0));
            this.introduction1.SummonerGloryPoints = ((uint)(0u));
            this.introduction1.SummonerGuildPoints = ((uint)(0u));
            this.introduction1.SummonerLastLanguage = ((System.Drawing.Image)(resources.GetObject("introduction1.SummonerLanguage")));
            this.introduction1.SummonerLevel = ((byte)(0));
            this.introduction1.SummonerMana = ((ulong)(0ul));
            this.introduction1.SummonerMonstersAmount = ((ushort)(0));
            this.introduction1.SummonerMonstersLocked = ((ushort)(0));
            this.introduction1.SummonerName = "QuatZo";
            this.introduction1.SummonerRTAMedals = ((uint)(0u));
            this.introduction1.SummonerRunes = ((ushort)(0));
            this.introduction1.SummonerRunesLocked = ((ushort)(0));
            this.introduction1.SummonerShapeshiftingStones = ((ushort)(0));
            this.introduction1.SummonerSocialPoints = ((ushort)(0));
            this.introduction1.TabIndex = 13;
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.menu1.Location = new System.Drawing.Point(0, 70);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(800, 80);
            this.menu1.TabIndex = 12;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.introduction1);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.pictureBoxSelectJson);
            this.Controls.Add(this.labelSomething);
            this.Controls.Add(this.labelTowersCalculator);
            this.Controls.Add(this.labelBuildingsInfo);
            this.Controls.Add(this.labelArenaInfo);
            this.Controls.Add(this.labelDimensionalHoleInfo);
            this.Controls.Add(this.labelMonsters);
            this.Controls.Add(this.labelRunesInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Summoners War Statistics";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectJson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRunesInfo;
        private System.Windows.Forms.Label labelMonsters;
        private System.Windows.Forms.Label labelDimensionalHoleInfo;
        private System.Windows.Forms.Label labelArenaInfo;
        private System.Windows.Forms.Label labelBuildingsInfo;
        private System.Windows.Forms.Label labelTowersCalculator;
        private System.Windows.Forms.Label labelSomething;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pictureBoxSelectJson;
        private Menu menu1;
        private Summary introduction1;
    }
}


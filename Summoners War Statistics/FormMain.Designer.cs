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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxTestJson = new System.Windows.Forms.PictureBox();
            this.pictureBoxSelectJson = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.summary1 = new Summoners_War_Statistics.Summary();
            this.menu1 = new Summoners_War_Statistics.Menu();
            this.dimHole1 = new Summoners_War_Statistics.DimHole();
            this.other1 = new Summoners_War_Statistics.Other();
            this.runes1 = new Summoners_War_Statistics.Runes();
            this.monsters1 = new Summoners_War_Statistics.Monsters();
            this.guild1 = new Summoners_War_Statistics.Guild();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTestJson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectJson)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Help";
            // 
            // pictureBoxTestJson
            // 
            this.pictureBoxTestJson.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxTestJson.Image = global::Summoners_War_Statistics.Properties.Resources.banner_testjsonfile;
            this.pictureBoxTestJson.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxTestJson.Location = new System.Drawing.Point(782, 0);
            this.pictureBoxTestJson.Name = "pictureBoxTestJson";
            this.pictureBoxTestJson.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.pictureBoxTestJson.Size = new System.Drawing.Size(226, 69);
            this.pictureBoxTestJson.TabIndex = 11;
            this.pictureBoxTestJson.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxTestJson, "Click here to use the TEST JSON File");
            this.pictureBoxTestJson.Click += new System.EventHandler(this.PictureBoxTestJson_Click);
            // 
            // pictureBoxSelectJson
            // 
            this.pictureBoxSelectJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSelectJson.Image = global::Summoners_War_Statistics.Properties.Resources.banner_selectjsonfile;
            this.pictureBoxSelectJson.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxSelectJson.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSelectJson.Name = "pictureBoxSelectJson";
            this.pictureBoxSelectJson.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.pictureBoxSelectJson.Size = new System.Drawing.Size(782, 69);
            this.pictureBoxSelectJson.TabIndex = 10;
            this.pictureBoxSelectJson.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxSelectJson, "Click here to select JSON File");
            this.pictureBoxSelectJson.Click += new System.EventHandler(this.pictureBoxSelectJson_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.pictureBoxSelectJson);
            this.panelHeader.Controls.Add(this.pictureBoxTestJson);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1008, 69);
            this.panelHeader.TabIndex = 19;
            // 
            // summary1
            // 
            this.summary1.AutoScroll = true;
            this.summary1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.summary1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summary1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.summary1.JsonModifcationDate = "Json file creation date";
            this.summary1.Location = new System.Drawing.Point(0, 149);
            this.summary1.Name = "summary1";
            this.summary1.Size = new System.Drawing.Size(1008, 580);
            this.summary1.SummonerAncientCoins = ((ushort)(0));
            this.summary1.SummonerArenaEnergy = ((byte)(0));
            this.summary1.SummonerArenaEnergyMax = ((byte)(0));
            this.summary1.SummonerCountry = ((System.Drawing.Image)(resources.GetObject("summary1.SummonerCountry")));
            this.summary1.SummonerCrystals = ((uint)(0u));
            this.summary1.SummonerDimensionalCrystals = ((byte)(0));
            this.summary1.SummonerDimensionalCrystalsMax = ((byte)(0));
            this.summary1.SummonerDimensionalHoleEnergy = ((byte)(0));
            this.summary1.SummonerDimensionalHoleEnergyMax = ((byte)(0));
            this.summary1.SummonerEnergy = ((byte)(0));
            this.summary1.SummonerEnergyMax = ((byte)(0));
            this.summary1.SummonerGloryPoints = ((uint)(0u));
            this.summary1.SummonerGuildPoints = ((uint)(0u));
            this.summary1.SummonerLevel = ((byte)(0));
            this.summary1.SummonerMana = ((ulong)(0ul));
            this.summary1.SummonerMonstersAmount = ((ushort)(0));
            this.summary1.SummonerMonstersLocked = ((ushort)(0));
            this.summary1.SummonerName = "QuatZo";
            this.summary1.SummonerRTAMedals = ((uint)(0u));
            this.summary1.SummonerRunes = ((ushort)(0));
            this.summary1.SummonerRunesLocked = ((ushort)(0));
            this.summary1.SummonerShapeshiftingStones = ((ushort)(0));
            this.summary1.SummonerSocialPoints = ((ushort)(0));
            this.summary1.TabIndex = 13;
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.menu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu1.IsMouseDown = false;
            this.menu1.Location = new System.Drawing.Point(0, 69);
            this.menu1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(1008, 80);
            this.menu1.TabIndex = 12;
            this.menu1.WindowWidth = 0;
            // 
            // dimHole1
            // 
            this.dimHole1.AutoScroll = true;
            this.dimHole1.AutoSize = true;
            this.dimHole1.AxpPerLevel = ((ushort)(0));
            this.dimHole1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dimHole1.DimensionalEnergyGainStart = new System.DateTime(((long)(0)));
            this.dimHole1.DimHoleMonsters = null;
            this.dimHole1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dimHole1.Location = new System.Drawing.Point(0, 0);
            this.dimHole1.Name = "dimHole1";
            this.dimHole1.Size = new System.Drawing.Size(1008, 729);
            this.dimHole1.SizeWindow = new System.Drawing.Size(1008, 729);
            this.dimHole1.SummonerDimensionalHoleEnergy = ((byte)(0));
            this.dimHole1.SummonerDimensionalHoleEnergyMax = ((byte)(100));
            this.dimHole1.SummonerDimensionalHoleEnergyMaxInfo = "";
            this.dimHole1.TabIndex = 17;
            this.dimHole1.Visible = false;
            // 
            // other1
            // 
            this.other1.AutoScroll = true;
            this.other1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.other1.DaysToMaxFlags = "Never";
            this.other1.DaysToMaxTowers = "Never";
            this.other1.Decorations = null;
            this.other1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.other1.Location = new System.Drawing.Point(0, 0);
            this.other1.Name = "other1";
            this.other1.Size = new System.Drawing.Size(1008, 729);
            this.other1.TabIndex = 16;
            this.other1.TabSize = new System.Drawing.Size(1008, 729);
            this.other1.Visible = false;
            // 
            // runes1
            // 
            this.runes1.AutoScroll = true;
            this.runes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.runes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runes1.Location = new System.Drawing.Point(0, 0);
            this.runes1.MonstersMasterId = null;
            this.runes1.Name = "runes1";
            this.runes1.RunesAmount = ((ushort)(0));
            this.runes1.RunesEfficiencyMax = 0D;
            this.runes1.RunesEfficiencyMean = 0D;
            this.runes1.RunesEfficiencyMedian = 0D;
            this.runes1.RunesEfficiencyMin = 0D;
            this.runes1.RunesEfficiencyStandardDeviation = 0D;
            this.runes1.RunesInventory = ((ushort)(0));
            this.runes1.RunesList = null;
            this.runes1.RunesMaxed = ((ushort)(0));
            this.runes1.Size = new System.Drawing.Size(1008, 729);
            this.runes1.TabIndex = 15;
            this.runes1.Visible = false;
            // 
            // monsters1
            // 
            this.monsters1.AutoScroll = true;
            this.monsters1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.monsters1.DaysSinceLastLDLightning = ((ushort)(0));
            this.monsters1.DaysSinceNat5 = ((ushort)(0));
            this.monsters1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monsters1.Location = new System.Drawing.Point(0, 0);
            this.monsters1.MonsterAttributeDark = ((ushort)(0));
            this.monsters1.MonsterAttributeFire = ((ushort)(0));
            this.monsters1.MonsterAttributeLight = ((ushort)(0));
            this.monsters1.MonsterAttributeWater = ((ushort)(0));
            this.monsters1.MonsterAttributeWind = ((ushort)(0));
            this.monsters1.MonstersCollectionSummoner = 0;
            this.monsters1.MonstersCollectionWhole = 0;
            this.monsters1.MonstersLDNat4PlusAmount = ((ushort)(0));
            this.monsters1.MonstersLocked = ((System.Collections.Generic.List<long>)(resources.GetObject("monsters1.MonstersLocked")));
            this.monsters1.MonstersNat5Amount = ((ushort)(0));
            this.monsters1.MonsterStarsFive = ((ushort)(0));
            this.monsters1.MonsterStarsFour = ((ushort)(0));
            this.monsters1.MonsterStarsOne = ((ushort)(0));
            this.monsters1.MonsterStarsSix = ((ushort)(0));
            this.monsters1.MonsterStarsThree = ((ushort)(0));
            this.monsters1.MonsterStarsTwo = ((ushort)(0));
            this.monsters1.Name = "monsters1";
            this.monsters1.Size = new System.Drawing.Size(1008, 729);
            this.monsters1.TabIndex = 14;
            this.monsters1.Visible = false;
            // 
            // guild1
            // 
            this.guild1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.guild1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guild1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.guild1.GuildActualRanking = "Actual ranking";
            this.guild1.GuildBestRanking = "Best ranking";
            this.guild1.GuildLeaderName = "Leader\'s name";
            this.guild1.GuildMembers = ((byte)(0));
            this.guild1.GuildMembersDefenses = ((byte)(0));
            this.guild1.GuildMembersDefensesMax = ((byte)(0));
            this.guild1.GuildMembersMax = ((byte)(0));
            this.guild1.GuildName = "Guild\'s name";
            this.guild1.Location = new System.Drawing.Point(0, 0);
            this.guild1.Name = "guild1";
            this.guild1.Size = new System.Drawing.Size(1008, 729);
            this.guild1.TabIndex = 18;
            this.guild1.TabSize = new System.Drawing.Size(1008, 729);
            this.guild1.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.summary1);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dimHole1);
            this.Controls.Add(this.other1);
            this.Controls.Add(this.runes1);
            this.Controls.Add(this.monsters1);
            this.Controls.Add(this.guild1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FormMain";
            this.Text = "Summoners War Statistics";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResizeBegin += new System.EventHandler(this.FormMain_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.FormMain_SizeChanged);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTestJson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectJson)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pictureBoxSelectJson;
        private Menu menu1;
        private Summary summary1;
        private Monsters monsters1;
        private Runes runes1;
        private Other other1;
        private DimHole dimHole1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guild guild1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxTestJson;
    }
}


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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxSelectJson = new System.Windows.Forms.PictureBox();
            this.menu1 = new Summoners_War_Statistics.Menu();
            this.summary1 = new Summoners_War_Statistics.Summary();
            this.dimHole1 = new Summoners_War_Statistics.DimHole();
            this.other1 = new Summoners_War_Statistics.Other();
            this.runes1 = new Summoners_War_Statistics.Runes();
            this.monsters1 = new Summoners_War_Statistics.Monsters();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectJson)).BeginInit();
            this.SuspendLayout();
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
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.menu1.Location = new System.Drawing.Point(0, 78);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(784, 76);
            this.menu1.TabIndex = 12;
            // 
            // summary1
            // 
            this.summary1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.summary1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.summary1.JsonModifcationDate = "Json file creation date";
            this.summary1.Location = new System.Drawing.Point(0, 150);
            this.summary1.Name = "summary1";
            this.summary1.Size = new System.Drawing.Size(784, 411);
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
            this.summary1.SummonerLastCountry = ((System.Drawing.Image)(resources.GetObject("summary1.SummonerLastCountry")));
            this.summary1.SummonerLastLanguage = ((System.Drawing.Image)(resources.GetObject("summary1.SummonerLastLanguage")));
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
            // dimHole1
            // 
            this.dimHole1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dimHole1.Location = new System.Drawing.Point(0, 150);
            this.dimHole1.Name = "dimHole1";
            this.dimHole1.Size = new System.Drawing.Size(784, 411);
            this.dimHole1.TabIndex = 17;
            // 
            // other1
            // 
            this.other1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.other1.Location = new System.Drawing.Point(0, 150);
            this.other1.Name = "other1";
            this.other1.Size = new System.Drawing.Size(784, 411);
            this.other1.TabIndex = 16;
            // 
            // runes1
            // 
            this.runes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.runes1.Location = new System.Drawing.Point(0, 150);
            this.runes1.Name = "runes1";
            this.runes1.Size = new System.Drawing.Size(784, 411);
            this.runes1.TabIndex = 15;
            // 
            // monsters1
            // 
            this.monsters1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.monsters1.Location = new System.Drawing.Point(0, 150);
            this.monsters1.Name = "monsters1";
            this.monsters1.Size = new System.Drawing.Size(784, 411);
            this.monsters1.TabIndex = 14;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.summary1);
            this.Controls.Add(this.pictureBoxSelectJson);
            this.Controls.Add(this.dimHole1);
            this.Controls.Add(this.other1);
            this.Controls.Add(this.runes1);
            this.Controls.Add(this.monsters1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.Text = "Summoners War Statistics";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectJson)).EndInit();
            this.ResumeLayout(false);

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
    }
}


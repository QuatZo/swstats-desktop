namespace Summoners_War_Statistics
{
    partial class Menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxSummary = new System.Windows.Forms.PictureBox();
            this.pictureBoxMonsters = new System.Windows.Forms.PictureBox();
            this.pictureBoxRunes = new System.Windows.Forms.PictureBox();
            this.pictureBoxDimHole = new System.Windows.Forms.PictureBox();
            this.pictureBoxOther = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonsters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRunes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDimHole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOther)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSummary
            // 
            this.pictureBoxSummary.Image = global::Summoners_War_Statistics.Properties.Resources.menu_summary_on;
            this.pictureBoxSummary.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSummary.Name = "pictureBoxSummary";
            this.pictureBoxSummary.Size = new System.Drawing.Size(160, 80);
            this.pictureBoxSummary.TabIndex = 0;
            this.pictureBoxSummary.TabStop = false;
            this.pictureBoxSummary.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBoxMonsters
            // 
            this.pictureBoxMonsters.Image = global::Summoners_War_Statistics.Properties.Resources.menu_monsters_off;
            this.pictureBoxMonsters.Location = new System.Drawing.Point(160, 0);
            this.pictureBoxMonsters.Name = "pictureBoxMonsters";
            this.pictureBoxMonsters.Size = new System.Drawing.Size(160, 80);
            this.pictureBoxMonsters.TabIndex = 1;
            this.pictureBoxMonsters.TabStop = false;
            this.pictureBoxMonsters.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBoxRunes
            // 
            this.pictureBoxRunes.Image = global::Summoners_War_Statistics.Properties.Resources.menu_runes_off;
            this.pictureBoxRunes.Location = new System.Drawing.Point(320, 0);
            this.pictureBoxRunes.Name = "pictureBoxRunes";
            this.pictureBoxRunes.Size = new System.Drawing.Size(160, 80);
            this.pictureBoxRunes.TabIndex = 2;
            this.pictureBoxRunes.TabStop = false;
            this.pictureBoxRunes.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBoxDimHole
            // 
            this.pictureBoxDimHole.Image = global::Summoners_War_Statistics.Properties.Resources.menu_dimhole_off;
            this.pictureBoxDimHole.Location = new System.Drawing.Point(480, 0);
            this.pictureBoxDimHole.Name = "pictureBoxDimHole";
            this.pictureBoxDimHole.Size = new System.Drawing.Size(160, 80);
            this.pictureBoxDimHole.TabIndex = 3;
            this.pictureBoxDimHole.TabStop = false;
            this.pictureBoxDimHole.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBoxOther
            // 
            this.pictureBoxOther.Image = global::Summoners_War_Statistics.Properties.Resources.menu_other_off;
            this.pictureBoxOther.Location = new System.Drawing.Point(640, 0);
            this.pictureBoxOther.Name = "pictureBoxOther";
            this.pictureBoxOther.Size = new System.Drawing.Size(160, 80);
            this.pictureBoxOther.TabIndex = 4;
            this.pictureBoxOther.TabStop = false;
            this.pictureBoxOther.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.pictureBoxOther);
            this.Controls.Add(this.pictureBoxDimHole);
            this.Controls.Add(this.pictureBoxRunes);
            this.Controls.Add(this.pictureBoxMonsters);
            this.Controls.Add(this.pictureBoxSummary);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(780, 80);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonsters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRunes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDimHole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOther)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSummary;
        private System.Windows.Forms.PictureBox pictureBoxMonsters;
        private System.Windows.Forms.PictureBox pictureBoxRunes;
        private System.Windows.Forms.PictureBox pictureBoxDimHole;
        private System.Windows.Forms.PictureBox pictureBoxOther;
    }
}

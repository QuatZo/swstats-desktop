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
            this.labelAccountInfo = new System.Windows.Forms.Label();
            this.labelRunesInfo = new System.Windows.Forms.Label();
            this.labelMonsters = new System.Windows.Forms.Label();
            this.labelDimensionalHoleInfo = new System.Windows.Forms.Label();
            this.labelArenaInfo = new System.Windows.Forms.Label();
            this.labelBuildingsInfo = new System.Windows.Forms.Label();
            this.labelTowersCalculator = new System.Windows.Forms.Label();
            this.labelSomething = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAccountInfo
            // 
            this.labelAccountInfo.AutoSize = true;
            this.labelAccountInfo.Location = new System.Drawing.Point(13, 81);
            this.labelAccountInfo.Name = "labelAccountInfo";
            this.labelAccountInfo.Size = new System.Drawing.Size(272, 39);
            this.labelAccountInfo.TabIndex = 0;
            this.labelAccountInfo.Text = "Your account - how old, country,\r\nGuild points, glory points etc\r\nWorld boss, are" +
    "na best ranking; basically profil info page";
            // 
            // labelRunesInfo
            // 
            this.labelRunesInfo.AutoSize = true;
            this.labelRunesInfo.Location = new System.Drawing.Point(444, 81);
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
            this.labelMonsters.Location = new System.Drawing.Point(13, 224);
            this.labelMonsters.Name = "labelMonsters";
            this.labelMonsters.Size = new System.Drawing.Size(188, 13);
            this.labelMonsters.TabIndex = 2;
            this.labelMonsters.Text = "Amount of monsters, 6*, 5*, locked etc";
            // 
            // labelDimensionalHoleInfo
            // 
            this.labelDimensionalHoleInfo.AutoSize = true;
            this.labelDimensionalHoleInfo.Location = new System.Drawing.Point(444, 224);
            this.labelDimensionalHoleInfo.Name = "labelDimensionalHoleInfo";
            this.labelDimensionalHoleInfo.Size = new System.Drawing.Size(323, 13);
            this.labelDimensionalHoleInfo.TabIndex = 3;
            this.labelDimensionalHoleInfo.Text = "Dimensional Hole info - how much energy, how long till you max out";
            // 
            // labelArenaInfo
            // 
            this.labelArenaInfo.AutoSize = true;
            this.labelArenaInfo.Location = new System.Drawing.Point(13, 427);
            this.labelArenaInfo.Name = "labelArenaInfo";
            this.labelArenaInfo.Size = new System.Drawing.Size(323, 13);
            this.labelArenaInfo.TabIndex = 4;
            this.labelArenaInfo.Text = "Dimensional Hole info - how much energy, how long till you max out";
            // 
            // labelBuildingsInfo
            // 
            this.labelBuildingsInfo.AutoSize = true;
            this.labelBuildingsInfo.Location = new System.Drawing.Point(444, 427);
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
            this.labelSomething.Location = new System.Drawing.Point(444, 585);
            this.labelSomething.Name = "labelSomething";
            this.labelSomething.Size = new System.Drawing.Size(112, 13);
            this.labelSomething.TabIndex = 7;
            this.labelSomething.Text = "Something else to add";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(13, 13);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(188, 23);
            this.buttonSelectFile.TabIndex = 8;
            this.buttonSelectFile.Text = "Select JSON file";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 607);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.labelSomething);
            this.Controls.Add(this.labelTowersCalculator);
            this.Controls.Add(this.labelBuildingsInfo);
            this.Controls.Add(this.labelArenaInfo);
            this.Controls.Add(this.labelDimensionalHoleInfo);
            this.Controls.Add(this.labelMonsters);
            this.Controls.Add(this.labelRunesInfo);
            this.Controls.Add(this.labelAccountInfo);
            this.Name = "FormMain";
            this.Text = "Summoners War Statistics";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAccountInfo;
        private System.Windows.Forms.Label labelRunesInfo;
        private System.Windows.Forms.Label labelMonsters;
        private System.Windows.Forms.Label labelDimensionalHoleInfo;
        private System.Windows.Forms.Label labelArenaInfo;
        private System.Windows.Forms.Label labelBuildingsInfo;
        private System.Windows.Forms.Label labelTowersCalculator;
        private System.Windows.Forms.Label labelSomething;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSelectFile;
    }
}


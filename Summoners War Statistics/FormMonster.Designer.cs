namespace Summoners_War_Statistics
{
    partial class FormMonster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonster));
            this.labelName = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelSpeedRank = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(109, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "label1";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(109, 36);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(38, 13);
            this.labelSpeed.TabIndex = 1;
            this.labelSpeed.Text = "Speed";
            // 
            // labelSpeedRank
            // 
            this.labelSpeedRank.AutoSize = true;
            this.labelSpeedRank.Location = new System.Drawing.Point(153, 36);
            this.labelSpeedRank.Name = "labelSpeedRank";
            this.labelSpeedRank.Size = new System.Drawing.Size(13, 13);
            this.labelSpeedRank.TabIndex = 2;
            this.labelSpeedRank.Text = "0";
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Image = global::Summoners_War_Statistics.Properties.Resources.monster_unknown;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(102, 102);
            this.pictureBoxAvatar.TabIndex = 3;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // FormMonster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(184, 361);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Controls.Add(this.labelSpeedRank);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelName);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(200, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 400);
            this.Name = "FormMonster";
            this.Text = "FormMonster";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelSpeedRank;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
    }
}
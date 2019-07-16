namespace Summoners_War_Statistics
{
    partial class Monsters
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
            this.labelMonsters = new System.Windows.Forms.Label();
            this.listViewMonstersToLock = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelMonsterStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMonsters
            // 
            this.labelMonsters.AutoSize = true;
            this.labelMonsters.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonsters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.labelMonsters.Location = new System.Drawing.Point(3, 240);
            this.labelMonsters.Name = "labelMonsters";
            this.labelMonsters.Size = new System.Drawing.Size(198, 42);
            this.labelMonsters.TabIndex = 1;
            this.labelMonsters.Text = "Monsters To Lock";
            // 
            // listViewMonstersToLock
            // 
            this.listViewMonstersToLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.listViewMonstersToLock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewMonstersToLock.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMonstersToLock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.listViewMonstersToLock.HideSelection = false;
            this.listViewMonstersToLock.Location = new System.Drawing.Point(10, 285);
            this.listViewMonstersToLock.Name = "listViewMonstersToLock";
            this.listViewMonstersToLock.Size = new System.Drawing.Size(692, 113);
            this.listViewMonstersToLock.TabIndex = 2;
            this.listViewMonstersToLock.UseCompatibleStateImageBehavior = false;
            this.listViewMonstersToLock.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 226;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stars";
            this.columnHeader2.Width = 53;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Level";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Runes";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Rune sets";
            this.columnHeader5.Width = 209;
            // 
            // labelMonsterStats
            // 
            this.labelMonsterStats.AutoSize = true;
            this.labelMonsterStats.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonsterStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.labelMonsterStats.Location = new System.Drawing.Point(3, 11);
            this.labelMonsterStats.Name = "labelMonsterStats";
            this.labelMonsterStats.Size = new System.Drawing.Size(185, 42);
            this.labelMonsterStats.TabIndex = 3;
            this.labelMonsterStats.Text = "Monsters Stats";
            // 
            // Monsters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.labelMonsterStats);
            this.Controls.Add(this.listViewMonstersToLock);
            this.Controls.Add(this.labelMonsters);
            this.Name = "Monsters";
            this.Size = new System.Drawing.Size(780, 411);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMonsters;
        private System.Windows.Forms.ListView listViewMonstersToLock;
        private System.Windows.Forms.Label labelMonsterStats;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

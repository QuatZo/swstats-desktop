namespace Summoners_War_Statistics
{
    partial class Other
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
            this.labelOtherActiveFriends = new System.Windows.Forms.Label();
            this.listViewFriendsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelOtherGuild = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOtherActiveFriends
            // 
            this.labelOtherActiveFriends.AutoSize = true;
            this.labelOtherActiveFriends.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherActiveFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.labelOtherActiveFriends.Location = new System.Drawing.Point(3, 9);
            this.labelOtherActiveFriends.Name = "labelOtherActiveFriends";
            this.labelOtherActiveFriends.Size = new System.Drawing.Size(136, 42);
            this.labelOtherActiveFriends.TabIndex = 0;
            this.labelOtherActiveFriends.Text = "Friends List";
            // 
            // listViewFriendsList
            // 
            this.listViewFriendsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.listViewFriendsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewFriendsList.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewFriendsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.listViewFriendsList.FullRowSelect = true;
            this.listViewFriendsList.HideSelection = false;
            this.listViewFriendsList.Location = new System.Drawing.Point(10, 55);
            this.listViewFriendsList.Name = "listViewFriendsList";
            this.listViewFriendsList.Size = new System.Drawing.Size(721, 142);
            this.listViewFriendsList.TabIndex = 1;
            this.listViewFriendsList.UseCompatibleStateImageBehavior = false;
            this.listViewFriendsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 275;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Offline since";
            this.columnHeader2.Width = 179;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rep monster";
            this.columnHeader3.Width = 138;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rep level";
            this.columnHeader4.Width = 75;
            // 
            // labelOtherGuild
            // 
            this.labelOtherGuild.AutoSize = true;
            this.labelOtherGuild.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherGuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.labelOtherGuild.Location = new System.Drawing.Point(3, 211);
            this.labelOtherGuild.Name = "labelOtherGuild";
            this.labelOtherGuild.Size = new System.Drawing.Size(110, 42);
            this.labelOtherGuild.TabIndex = 2;
            this.labelOtherGuild.Text = "Guild Info";
            // 
            // Other
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.labelOtherGuild);
            this.Controls.Add(this.listViewFriendsList);
            this.Controls.Add(this.labelOtherActiveFriends);
            this.Name = "Other";
            this.Size = new System.Drawing.Size(780, 411);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOtherActiveFriends;
        private System.Windows.Forms.ListView listViewFriendsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label labelOtherGuild;
    }
}

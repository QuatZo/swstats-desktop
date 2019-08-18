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
            this.components = new System.ComponentModel.Container();
            this.labelOtherActiveFriends = new System.Windows.Forms.Label();
            this.panelFriends = new System.Windows.Forms.Panel();
            this.objectListViewFriends = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn10 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTowersFlags = new System.Windows.Forms.Panel();
            this.objectListViewTowersFlags = new BrightIdeasSoftware.ObjectListView();
            this.labelOtherTowerFlags = new System.Windows.Forms.Label();
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn12 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn13 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn14 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn15 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn16 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panelFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewFriends)).BeginInit();
            this.panelTowersFlags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewTowersFlags)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOtherActiveFriends
            // 
            this.labelOtherActiveFriends.AutoSize = true;
            this.labelOtherActiveFriends.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOtherActiveFriends.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherActiveFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.labelOtherActiveFriends.Location = new System.Drawing.Point(0, 0);
            this.labelOtherActiveFriends.Name = "labelOtherActiveFriends";
            this.labelOtherActiveFriends.Size = new System.Drawing.Size(136, 42);
            this.labelOtherActiveFriends.TabIndex = 0;
            this.labelOtherActiveFriends.Text = "Friends List";
            this.toolTip1.SetToolTip(this.labelOtherActiveFriends, "This is the section when you can see list of your friends list, incl. their reps " +
        "and last log-in time");
            // 
            // panelFriends
            // 
            this.panelFriends.Controls.Add(this.objectListViewFriends);
            this.panelFriends.Controls.Add(this.labelOtherActiveFriends);
            this.panelFriends.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFriends.Location = new System.Drawing.Point(0, 0);
            this.panelFriends.Name = "panelFriends";
            this.panelFriends.Size = new System.Drawing.Size(780, 185);
            this.panelFriends.TabIndex = 49;
            // 
            // objectListViewFriends
            // 
            this.objectListViewFriends.AllColumns.Add(this.olvColumn6);
            this.objectListViewFriends.AllColumns.Add(this.olvColumn8);
            this.objectListViewFriends.AllColumns.Add(this.olvColumn9);
            this.objectListViewFriends.AllColumns.Add(this.olvColumn10);
            this.objectListViewFriends.AllColumns.Add(this.olvColumn11);
            this.objectListViewFriends.AllowColumnReorder = true;
            this.objectListViewFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.objectListViewFriends.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn6,
            this.olvColumn8,
            this.olvColumn9,
            this.olvColumn10,
            this.olvColumn11});
            this.objectListViewFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListViewFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.objectListViewFriends.FullRowSelect = true;
            this.objectListViewFriends.HideSelection = false;
            this.objectListViewFriends.Location = new System.Drawing.Point(0, 42);
            this.objectListViewFriends.Name = "objectListViewFriends";
            this.objectListViewFriends.ShowGroups = false;
            this.objectListViewFriends.Size = new System.Drawing.Size(780, 143);
            this.objectListViewFriends.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.objectListViewFriends.TabIndex = 60;
            this.objectListViewFriends.UseCompatibleStateImageBehavior = false;
            this.objectListViewFriends.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Name";
            this.olvColumn6.CellPadding = null;
            this.olvColumn6.Text = "Name";
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "OfflineSince";
            this.olvColumn8.CellPadding = null;
            this.olvColumn8.Text = "Offline Since";
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "RepMonster";
            this.olvColumn9.CellPadding = null;
            this.olvColumn9.Text = "Rep monster";
            // 
            // olvColumn10
            // 
            this.olvColumn10.AspectName = "RepStars";
            this.olvColumn10.CellPadding = null;
            this.olvColumn10.Text = "Rep stars";
            // 
            // olvColumn11
            // 
            this.olvColumn11.AspectName = "RepLevel";
            this.olvColumn11.CellPadding = null;
            this.olvColumn11.Text = "Rep level";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Help";
            // 
            // panelTowersFlags
            // 
            this.panelTowersFlags.Controls.Add(this.objectListViewTowersFlags);
            this.panelTowersFlags.Controls.Add(this.labelOtherTowerFlags);
            this.panelTowersFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTowersFlags.Location = new System.Drawing.Point(0, 185);
            this.panelTowersFlags.Name = "panelTowersFlags";
            this.panelTowersFlags.Size = new System.Drawing.Size(780, 226);
            this.panelTowersFlags.TabIndex = 61;
            // 
            // objectListViewTowersFlags
            // 
            this.objectListViewTowersFlags.AllColumns.Add(this.olvColumn7);
            this.objectListViewTowersFlags.AllColumns.Add(this.olvColumn12);
            this.objectListViewTowersFlags.AllColumns.Add(this.olvColumn13);
            this.objectListViewTowersFlags.AllColumns.Add(this.olvColumn14);
            this.objectListViewTowersFlags.AllColumns.Add(this.olvColumn15);
            this.objectListViewTowersFlags.AllColumns.Add(this.olvColumn16);
            this.objectListViewTowersFlags.AllowColumnReorder = true;
            this.objectListViewTowersFlags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.objectListViewTowersFlags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn7,
            this.olvColumn12,
            this.olvColumn13,
            this.olvColumn14,
            this.olvColumn15,
            this.olvColumn16});
            this.objectListViewTowersFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListViewTowersFlags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.objectListViewTowersFlags.FullRowSelect = true;
            this.objectListViewTowersFlags.HideSelection = false;
            this.objectListViewTowersFlags.Location = new System.Drawing.Point(0, 42);
            this.objectListViewTowersFlags.Name = "objectListViewTowersFlags";
            this.objectListViewTowersFlags.ShowGroups = false;
            this.objectListViewTowersFlags.Size = new System.Drawing.Size(780, 184);
            this.objectListViewTowersFlags.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.objectListViewTowersFlags.TabIndex = 60;
            this.objectListViewTowersFlags.UseCompatibleStateImageBehavior = false;
            this.objectListViewTowersFlags.View = System.Windows.Forms.View.Details;
            // 
            // labelOtherTowerFlags
            // 
            this.labelOtherTowerFlags.AutoSize = true;
            this.labelOtherTowerFlags.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOtherTowerFlags.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherTowerFlags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.labelOtherTowerFlags.Location = new System.Drawing.Point(0, 0);
            this.labelOtherTowerFlags.Name = "labelOtherTowerFlags";
            this.labelOtherTowerFlags.Size = new System.Drawing.Size(151, 42);
            this.labelOtherTowerFlags.TabIndex = 0;
            this.labelOtherTowerFlags.Text = "Towers, Flags";
            this.toolTip1.SetToolTip(this.labelOtherTowerFlags, "This is the section when you can see list of your friends list, incl. their reps " +
        "and last log-in time");
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "Area";
            this.olvColumn7.CellPadding = null;
            this.olvColumn7.Text = "Area";
            this.olvColumn7.Width = 102;
            // 
            // olvColumn12
            // 
            this.olvColumn12.AspectName = "Name";
            this.olvColumn12.CellPadding = null;
            this.olvColumn12.Text = "Name";
            this.olvColumn12.Width = 87;
            // 
            // olvColumn13
            // 
            this.olvColumn13.AspectName = "Bonus";
            this.olvColumn13.CellPadding = null;
            this.olvColumn13.Text = "Bonus";
            this.olvColumn13.Width = 87;
            // 
            // olvColumn14
            // 
            this.olvColumn14.AspectName = "Level";
            this.olvColumn14.CellPadding = null;
            this.olvColumn14.Text = "Level";
            this.olvColumn14.Width = 85;
            // 
            // olvColumn15
            // 
            this.olvColumn15.AspectName = "NextUpgrade";
            this.olvColumn15.CellPadding = null;
            this.olvColumn15.Text = "Next Upgrade";
            this.olvColumn15.Width = 86;
            // 
            // olvColumn16
            // 
            this.olvColumn16.AspectName = "RemainingUpgrade";
            this.olvColumn16.CellPadding = null;
            this.olvColumn16.Text = "Remaining Upgrade";
            this.olvColumn16.Width = 88;
            // 
            // Other
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.panelTowersFlags);
            this.Controls.Add(this.panelFriends);
            this.Name = "Other";
            this.Size = new System.Drawing.Size(780, 411);
            this.Resize += new System.EventHandler(this.Other_Resize);
            this.panelFriends.ResumeLayout(false);
            this.panelFriends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewFriends)).EndInit();
            this.panelTowersFlags.ResumeLayout(false);
            this.panelTowersFlags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewTowersFlags)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelOtherActiveFriends;
        private System.Windows.Forms.Panel panelFriends;
        private BrightIdeasSoftware.ObjectListView objectListViewFriends;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private BrightIdeasSoftware.OLVColumn olvColumn10;
        private BrightIdeasSoftware.OLVColumn olvColumn11;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelTowersFlags;
        private BrightIdeasSoftware.ObjectListView objectListViewTowersFlags;
        private System.Windows.Forms.Label labelOtherTowerFlags;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn12;
        private BrightIdeasSoftware.OLVColumn olvColumn13;
        private BrightIdeasSoftware.OLVColumn olvColumn14;
        private BrightIdeasSoftware.OLVColumn olvColumn15;
        private BrightIdeasSoftware.OLVColumn olvColumn16;
    }
}

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
            this.label2 = new System.Windows.Forms.Label();
            this.panelFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewFriends)).BeginInit();
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
            this.panelFriends.Size = new System.Drawing.Size(780, 210);
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
            this.objectListViewFriends.Size = new System.Drawing.Size(780, 168);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(171, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 84);
            this.label2.TabIndex = 61;
            this.label2.Text = "There will be some other info.\r\nI will try to add Towers/Flags stuff here.";
            this.toolTip1.SetToolTip(this.label2, "This is the section when you can see list of your friends list, incl. their reps " +
        "and last log-in time");
            // 
            // Other
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelFriends);
            this.Name = "Other";
            this.Size = new System.Drawing.Size(780, 411);
            this.SizeChanged += new System.EventHandler(this.Other_Resize);
            this.Resize += new System.EventHandler(this.Other_Resize);
            this.panelFriends.ResumeLayout(false);
            this.panelFriends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewFriends)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label2;
    }
}

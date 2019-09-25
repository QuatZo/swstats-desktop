using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    class OtherPresenter
    {
        IOtherView view;
        Model model;

        public OtherPresenter(IOtherView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.InitOther += View_InitOther;

            this.view.SummonerFriendsList.ColumnClick += SummonerFriendsList_ColumnClick;
            this.view.SummonerFriendsList.BeforeSorting += SummonerFriendsList_BeforeSorting;

            this.view.SummonerTowersFlagsList.ColumnClick += SummonerTowersFlagsList_ColumnClick;
            this.view.SummonerTowersFlagsList.BeforeSorting += SummonerTowersFlagsList_BeforeSorting;

            this.view.Resized += View_Resized;

            this.view.InitTowersFlags += InitTowersFlags;
        }

        /// <summary>
        /// Double-colum sorting
        /// </summary>
        private void SummonerTowersFlagsList_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            if (view.SummonerTowersFlagsList.PrimarySortColumn != view.SummonerTowersFlagsList.SecondarySortColumn) { view.SummonerTowersFlagsList.SecondarySortColumn = view.SummonerTowersFlagsList.PrimarySortColumn; }
        }

        /// <summary>
        /// Double-colum sorting
        /// </summary>
        private void SummonerTowersFlagsList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (view.SummonerTowersFlagsList.SecondarySortColumn != null)
            {
                view.SummonerTowersFlagsList.ListViewItemSorter = new ListViewItemComparer(e.Column, view.SummonerTowersFlagsList.SecondarySortColumn.Index);
            }
            else
            {
                view.SummonerTowersFlagsList.ListViewItemSorter = new ListViewItemComparer(e.Column, -1);
            }
            Logger.log.Info($"[Towers&Flags] Sorting");
        }

        /// <summary>
        /// Double-colum sorting
        /// </summary>
        private void SummonerFriendsList_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            if (view.SummonerFriendsList.PrimarySortColumn != view.SummonerFriendsList.SecondarySortColumn) { view.SummonerFriendsList.SecondarySortColumn = view.SummonerFriendsList.PrimarySortColumn; }
        }

        /// <summary>
        /// Double-colum sorting
        /// </summary>
        private void SummonerFriendsList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (view.SummonerFriendsList.SecondarySortColumn != null)
            {
                view.SummonerFriendsList.ListViewItemSorter = new ListViewItemComparer(e.Column, view.SummonerFriendsList.SecondarySortColumn.Index);
            }
            else
            {
                view.SummonerFriendsList.ListViewItemSorter = new ListViewItemComparer(e.Column, -1);
            }
            Logger.log.Info($"[Friends] Sorting");
        }

        /// <summary>
        /// Method used to resize the window (Dynamic UI)
        /// </summary>
        private void View_Resized()
        {
            //labelOtherActiveFriends   - 0
            //objectListViewFriends     - 1
            //panelFriends              - 2
            //objectListViewTowersFlags - 3
            //panelTowersFlags          - 4
            //labelMaxedFlags           - 5
            //labelMaxedFlagsText       - 6
            //labelMaxedTowers          - 7
            //labelMaxedTowersText      - 8

            view.SummonerFriendsList.BeginUpdate();

            view.Cntrls[2].Size = new Size(view.Cntrls[1].Size.Width, view.TabSize.Height * 40 / 100);
            view.Cntrls[4].Location = new Point(0, view.Cntrls[1].Size.Height);
            view.Cntrls[4].Size = new Size(view.Cntrls[4].Size.Width, view.TabSize.Height - view.Cntrls[2].Size.Height);

            int columnWidth = view.SummonerFriendsList.Size.Width / view.SummonerFriendsList.Columns.Count;
            foreach (ColumnHeader column in view.SummonerFriendsList.Columns)
            {
                column.Width = columnWidth - 5;
            }
            view.SummonerFriendsList.EndUpdate();

            view.SummonerTowersFlagsList.BeginUpdate();
            columnWidth = view.SummonerTowersFlagsList.Size.Width / view.SummonerTowersFlagsList.Columns.Count;
            foreach (ColumnHeader column in view.SummonerTowersFlagsList.Columns)
            {
                column.Width = columnWidth - 5;
            }
            view.SummonerTowersFlagsList.EndUpdate();

            view.Cntrls[8].Location = new Point(5, 0);
            view.Cntrls[7].Location = new Point(view.Cntrls[8].Location.X + view.Cntrls[8].Size.Width + 5, 0);

            view.Cntrls[5].Location = new Point(view.TabSize.Width - view.Cntrls[5].Size.Width - 5, 0);
            view.Cntrls[6].Location = new Point(view.Cntrls[5].Location.X - view.Cntrls[6].Size.Width - 0);
        }

        /// <summary>
        /// Initialize the Other tab
        /// </summary>
        private void View_InitOther(List<Friend> friendsList, List<Decoration> decorations)
        {
            view.Decorations = decorations;
            view.SummonerFriendsList.AddObjects(model.FriendsList(friendsList));
            Logger.log.Info($"[Friends] Friends to list done");

            InitTowersFlags();
        }

        /// <summary>
        /// Initialize the Towers & Flags calculator (w/ table)
        /// </summary>
        private void InitTowersFlags()
        {
            view.SummonerTowersFlagsList.Items.Clear();
            view.SummonerTowersFlagsList.AddObjects(model.TowersFlags(view.Decorations, Mapping.Instance.GetBuildings(), view.ChosenArenaRanking, view.ChosenArenaWingsPerDay, view.ChosenGuildRanking, view.ChosenGuildBattlesWon, view.ChosenSiegeRanking, view.ChosenSiegeFirstBattleResult, view.ChosenSiegeSecondBattleResult));
            Logger.log.Info($"[Towers&Flags] Towers & Flags to list done");

            double towersDays = 0;
            double flagsDays = 0;
            foreach (OLVListItem rowObject in view.SummonerTowersFlagsList.Items)
            {
                BuildingRow row = (BuildingRow)rowObject.RowObject;

                if (row.Area == Mapping.BuildingArea.Arena) { towersDays += double.Parse(row.RemainingDays); }
                else { flagsDays += double.Parse(row.RemainingDays); }
            }
            view.DaysToMaxTowers = towersDays.ToString();
            view.DaysToMaxFlags = flagsDays.ToString();

            Logger.log.Info($"[Towers&Flags] Towers & Flags Maxed done");
        }
    }
}

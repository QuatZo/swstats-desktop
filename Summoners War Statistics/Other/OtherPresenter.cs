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
        }

        private void SummonerTowersFlagsList_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            if (view.SummonerTowersFlagsList.PrimarySortColumn != view.SummonerTowersFlagsList.SecondarySortColumn) { view.SummonerTowersFlagsList.SecondarySortColumn = view.SummonerTowersFlagsList.PrimarySortColumn; }
        }

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

        private void SummonerFriendsList_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            if (view.SummonerFriendsList.PrimarySortColumn != view.SummonerFriendsList.SecondarySortColumn) { view.SummonerFriendsList.SecondarySortColumn = view.SummonerFriendsList.PrimarySortColumn; }
        }

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

        private void View_Resized()
        {
            //labelOtherActiveFriends   - 0
            //objectListViewFriends     - 1
            //panelFriends              - 2
            //objectListViewTowersFlags - 3
            //panelTowersFlags          - 4

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
        }

        private void View_InitOther(List<Friend> friendsList, List<Decoration> decorations)
        {
            view.SummonerFriendsList.AddObjects(model.FriendsList(friendsList));
            Logger.log.Info($"[Friends] Friends to list done");

            view.SummonerTowersFlagsList.AddObjects(model.TowersFlags(decorations, Mapping.Instance.GetBuildings()));
            Logger.log.Info($"[Towers&Flags] Towers & Flags to list done");
        }
    }
}

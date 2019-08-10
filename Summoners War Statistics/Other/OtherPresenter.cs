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

            this.view.Resized += View_Resized;
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
            // NEED TO CHANGE (REPAIR)

            view.SummonerFriendsList.BeginUpdate();

            //view.Cntrls[13].Size = new Size(view.Cntrls[13].Size.Width, view.TabSize.Height * 50 / 100);
            //view.Cntrls[14].Location = new Point(0, view.Cntrls[13].Size.Height);
            //view.Cntrls[14].Size = new Size(view.Cntrls[14].Size.Width, view.TabSize.Height - view.Cntrls[13].Size.Height);

            int columnWidth = view.SummonerFriendsList.Size.Width / view.SummonerFriendsList.Columns.Count;
            foreach (ColumnHeader column in view.SummonerFriendsList.Columns)
            {
                column.Width = columnWidth - 5;
            }
            view.SummonerFriendsList.EndUpdate();
        }

        private void View_InitOther(List<Friend> friendsList)
        {
            view.SummonerFriendsList.AddObjects(model.FriendsList(friendsList));
            Logger.log.Info($"[Friends] Friends to list done");
        }
    }
}

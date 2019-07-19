using System;
using System.Collections.Generic;
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
        }

        private void SummonerFriendsList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            view.SummonerFriendsList.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void View_InitOther(List<FriendListElement> friendsList)
        {
            foreach(string[] friend in model.FriendsList(friendsList))
            {
                view.SummonerFriendsList.Items.Add(new ListViewItem(friend));
            }
        }
    }
}

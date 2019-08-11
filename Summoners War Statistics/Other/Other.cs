using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace Summoners_War_Statistics
{
    public partial class Other : UserControl, IOtherView
    {
        #region Properties
        public Size TabSize
        {
            get => Size;
            set => Size = new Size(value.Width, value.Height);
        }

        public List<Control> Cntrls => new List<Control>()
        {
            labelOtherActiveFriends,
            objectListViewFriends,
            panelFriends
        };

        public ObjectListView SummonerFriendsList
        {
            get => objectListViewFriends;
            set => objectListViewFriends = value;
        }
        #endregion

        #region Events
        public event Action<List<Friend>> InitOther;
        public event Action Resized;
        #endregion

        public Other()
        {
            InitializeComponent();
            objectListViewFriends.DoubleBuffering(true);
        }

        #region Methods
        public void Init(List<Friend> friendsList)
        {
            InitOther?.Invoke(friendsList);
        }

        public void Front()
        {
            BringToFront();
        }

        public void ResetOnFail()
        {
            SummonerFriendsList.Items.Clear();
        }
        private void Other_Resize(object sender, EventArgs e)
        {
            Resized?.Invoke();
        }
        #endregion


    }
}

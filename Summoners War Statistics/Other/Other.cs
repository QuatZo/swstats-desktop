using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public partial class Other : UserControl, IOtherView
    {
        #region Properties
        public ListView SummonerFriendsList
        {
            get => listViewFriendsList;
            set => listViewFriendsList = value;
        }
        #endregion

        #region Events
        public event Action<List<FriendListElement>> InitOther;
        #endregion

        public Other()
        {
            InitializeComponent();
        }

        #region Methods
        public void Init(List<FriendListElement> friendsList)
        {
            InitOther?.Invoke(friendsList);
        }
        #endregion
    }
}

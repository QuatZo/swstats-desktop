using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public interface IOtherView
    {
        #region Properties
        ListView SummonerFriendsList { get; set; }
        #endregion

        #region Events
        event Action<List<FriendListElement>> InitOther;
        #endregion

        #region Methods
        void Init(List<FriendListElement> friendsList);
        #endregion

    }
}

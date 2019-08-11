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
    public interface IOtherView
    {
        #region Properties
        Size TabSize { get; set; }
        List<Control> Cntrls { get; }
        ObjectListView SummonerFriendsList { get; set; }
        #endregion

        #region Events
        event Action<List<Friend>> InitOther;
        event Action Resized;
        #endregion

        #region Methods
        void Init(List<Friend> friendsList);
        void Front();
        void ResetOnFail();
        #endregion

    }
}

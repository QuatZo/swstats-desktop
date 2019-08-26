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
        ObjectListView SummonerTowersFlagsList { get; set; }

        ushort ChosenArenaRanking { get; }
        byte ChosenArenaWingsPerDay { get; }
        ushort ChosenGuildRanking { get; }
        byte ChosenGuildBattlesWon { get;}
        ushort ChosenSiegeRanking { get; }
        byte ChosenSiegeFirstBattleResult { get; }
        byte ChosenSiegeSecondBattleResult { get; }

        List<Decoration> Decorations { get; set; }

        string DaysToMaxTowers { get; set; }
        string DaysToMaxFlags { get; set; }
        #endregion

        #region Events
        event Action<List<Friend>, List<Decoration>> InitOther;
        event Action Resized;
        event Action InitTowersFlags;
        #endregion

        #region Methods
        void Init(List<Friend> friendsList, List<Decoration> decorations, GuildWarRankingStat guildWarRankingStat, long arenaRatingId);
        void Front();
        void ResetOnFail();
        void Other_Resize(object sender, EventArgs e);
        #endregion

    }
}

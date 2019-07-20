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

        ListView GuildMembersList { get; set; }
        string GuildName { get; set; }
        string GuildLeaderName { get; set; }
        string GuildBestRanking { get; set; }
        byte GuildMembers { get; set; }
        byte GuildMembersMax { get; set; }
        byte GuildMembersDefenses { get; set; }
        byte GuildMembersDefensesMax { get; set; }
        #endregion

        #region Events
        event Action<List<FriendListElement>, Guild, GuildwarParticipationInfo, List<GuildwarMemberList>, List<GuildMemberDefenseList>, GuildwarRankingStat> InitOther;
        #endregion

        #region Methods
        void Init(List<FriendListElement> friendsList, Guild guild, GuildwarParticipationInfo guildwarParticipationInfo, List<GuildwarMemberList> guildwarMemberList, List<GuildMemberDefenseList> guildMemberDefenseList, GuildwarRankingStat guildwarRanking);
        #endregion

    }
}

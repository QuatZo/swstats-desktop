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
    public interface IGuildView
    {
        #region Properties
        Size TabSize { get; set; }
        List<Control> Cntrls { get; }

        ObjectListView GuildMembersList { get; set; }
        string GuildName { get; set; }
        string GuildLeaderName { get; set; }
        string GuildBestRanking { get; set; }
        byte GuildMembers { get; set; }
        byte GuildMembersMax { get; set; }
        byte GuildMembersDefenses { get; set; }
        byte GuildMembersDefensesMax { get; set; }
        #endregion

        #region Events
        event Action<GuildMap, GuildWarParticipationInfo, List<GuildWarMember>, List<GuildMemberDefense>, GuildWarRankingStat> InitGuild;
        event Action Resized;
        #endregion

        #region Methods
        void Init(GuildMap guild, GuildWarParticipationInfo guildwarParticipationInfo, List<GuildWarMember> guildwarMemberList, List<GuildMemberDefense> guildMemberDefenseList, GuildWarRankingStat guildwarRanking);
        void Front();
        #endregion
    }
}

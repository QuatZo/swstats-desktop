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

        public ListView GuildMembersList
        {
            get => listViewGuildMembersList;
            set => listViewGuildMembersList = value;
        }
        public string GuildName
        {
            get => labelGuildName.Text;
            set => labelGuildName.Text = value;
        }
        public string GuildLeaderName
        {
            get => labelLeaderName.Text;
            set => labelLeaderName.Text = value;
        }
        public string GuildBestRanking
        {
            get => labelRanking.Text;
            set => labelRanking.Text = value;
        }
        public byte GuildMembers
        {
            get => byte.Parse(labelMembers.Text);
            set => labelMembers.Text = value.ToString();
        }
        public byte GuildMembersMax
        {
            get => byte.Parse(labelMembersMax.Text);
            set => labelMembersMax.Text = value.ToString();
        }
        public byte GuildMembersDefenses
        {
            get => byte.Parse(labelDefenseUnits.Text);
            set => labelDefenseUnits.Text = value.ToString();
        }
        public byte GuildMembersDefensesMax
        {
            get => byte.Parse(labelDefenseUnitsMax.Text);
            set => labelDefenseUnitsMax.Text = value.ToString();
        }
        #endregion

        #region Events
        public event Action<List<FriendListElement>, Guild, GuildwarParticipationInfo, List<GuildwarMemberList>, List<GuildMemberDefenseList>, GuildwarRankingStat> InitOther;
        #endregion

        public Other()
        {
            InitializeComponent();
        }

        #region Methods
        public void Init(List<FriendListElement> friendsList, Guild guild, GuildwarParticipationInfo guildwarParticipationInfo, List<GuildwarMemberList> guildwarMemberList, List<GuildMemberDefenseList> guildMemberDefenseList, GuildwarRankingStat guildwarRanking)
        {
            InitOther?.Invoke(friendsList, guild, guildwarParticipationInfo, guildwarMemberList, guildMemberDefenseList, guildwarRanking);
        }
        #endregion
    }
}

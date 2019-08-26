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
    public partial class Guild : UserControl, IGuildView
    {
        #region Properties
        public Size TabSize
        {
            get => Size;
            set => Size = new Size(value.Width, value.Height);
        }

        public List<Control> Cntrls => new List<Control>()
        {
            pictureBoxDefenseUnits,
            labelDefenseUnits,
            labelDefenseUnitsMax,
            labelDefenseUnitsSlash,
            pictureBoxName,
            labelName,
            pictureBoxLeader,
            labelLeaderName,
            pictureBoxMembers,
            labelMembers,
            labelMembersMax,
            labelMembersSlash,
            pictureBoxActualRanking,
            labelActualRanking,
            pictureBoxBestRanking,
            labelBestRanking,
            objectListViewGuildSiegeDefenses,
            objectListViewGuildMembers,
            panelGuildMembers,
            panelGuildText,
            panelGuildSiegeDefenses,
            labelGuildSiegeDefenses,
            labelGuildMembers,
            labelGuildInfo
        };

        public ObjectListView GuildSiegeDefensesList
        {
            get => objectListViewGuildSiegeDefenses;
            set => objectListViewGuildSiegeDefenses = value;
        }
        public ObjectListView GuildMembersList
        {
            get => objectListViewGuildMembers;
            set => objectListViewGuildMembers = value;
        }

        public string GuildName
        {
            get => labelName.Text;
            set => labelName.Text = value;
        }
        public string GuildLeaderName
        {
            get => labelLeaderName.Text;
            set => labelLeaderName.Text = value;
        }
        public string GuildActualRanking
        {
            get => labelActualRanking.Text;
            set => labelActualRanking.Text = value;
        }
        public string GuildBestRanking
        {
            get => labelBestRanking.Text;
            set => labelBestRanking.Text = value;
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
        public event Action<GuildMap, GuildWarParticipationInfo, List<GuildWarMember>, List<GuildMemberDefense>, GuildWarRankingStat, List<long>, List<Monster>> InitGuild;
        public event Action Resized;
        #endregion

        public Guild()
        {
            InitializeComponent();
            objectListViewGuildMembers.DoubleBuffering(true);
        }

        #region Methods
        public void Init(GuildMap guild, GuildWarParticipationInfo guildWarParticipationInfo, List<GuildWarMember> guildWarMembers, List<GuildMemberDefense> guildWarDefenses, GuildWarRankingStat guildWarRanking, List<long> siegeDefenses, List<Monster> monsters)
        {
            InitGuild?.Invoke(guild, guildWarParticipationInfo, guildWarMembers, guildWarDefenses, guildWarRanking, siegeDefenses, monsters);
        }

        public void Front()
        {
            BringToFront();
        }

        public void ResetOnFail()
        {
            GuildSiegeDefensesList.Items.Clear();
            GuildMembersList.Items.Clear();
            GuildName = GuildLeaderName = GuildActualRanking = GuildBestRanking = "Initializaion failed.";
            GuildMembers = GuildMembersMax = GuildMembersDefenses = GuildMembersDefensesMax = 0;
        }

        public void Guild_Resize(object sender, EventArgs e)
        { 
            Resized?.Invoke();
        }
        #endregion
    }
}

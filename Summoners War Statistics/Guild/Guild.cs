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
            labelDefenseUnits,
            labelDefenseUnitsMax,
            labelDefenseUnitsSlash,
            labelGuildName,
            labelLeaderName,
            labelMembers,
            labelMembersMax,
            labelMembersSlash,
            labelRanking,
            objectListViewGuild,
            panelGuild,
            panelGuildText
        };

        public ObjectListView GuildMembersList
        {
            get => objectListViewGuild;
            set => objectListViewGuild = value;
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
        public event Action<GuildMap, GuildWarParticipationInfo, List<GuildWarMember>, List<GuildMemberDefense>, GuildWarRankingStat> InitGuild;
        public event Action Resized;
        #endregion

        public Guild()
        {
            InitializeComponent();
            objectListViewGuild.DoubleBuffering(true);
        }

        #region Methods
        public void Init(GuildMap guild, GuildWarParticipationInfo guildWarParticipationInfo, List<GuildWarMember> guildWarMembers, List<GuildMemberDefense> guildWarDefenses, GuildWarRankingStat guildWarRanking)
        {
            InitGuild?.Invoke(guild, guildWarParticipationInfo, guildWarMembers, guildWarDefenses, guildWarRanking);
        }

        public void Front()
        {
            BringToFront();
        }

        private void Guild_Resize(object sender, EventArgs e)
        {
            Resized?.Invoke();
        }
        #endregion
    }
}

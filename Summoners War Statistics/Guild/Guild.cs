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
        /// <summary>
        /// Size of the control
        /// </summary>
        public Size TabSize
        {
            get => Size;
            set => Size = new Size(value.Width, value.Height);
        }

        /// <summary>
        /// List of the controls used in Dynamic UI
        /// </summary>
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

        /// <summary>
        /// Siege defenses table
        /// </summary>
        public ObjectListView GuildSiegeDefensesList
        {
            get => objectListViewGuildSiegeDefenses;
            set => objectListViewGuildSiegeDefenses = value;
        }
        /// <summary>
        /// Guild members list table
        /// </summary>
        public ObjectListView GuildMembersList
        {
            get => objectListViewGuildMembers;
            set => objectListViewGuildMembers = value;
        }

        /// <summary>
        /// Name of the guild
        /// </summary>
        public string GuildName
        {
            get => labelName.Text;
            set => labelName.Text = value;
        }
        /// <summary>
        /// Name of the guild's leader
        /// </summary>
        public string GuildLeaderName
        {
            get => labelLeaderName.Text;
            set => labelLeaderName.Text = value;
        }
        /// <summary>
        /// Actual ranking of the guild
        /// </summary>
        public string GuildActualRanking
        {
            get => labelActualRanking.Text;
            set => labelActualRanking.Text = value;
        }
        /// <summary>
        /// Best ranking of the guild
        /// </summary>
        public string GuildBestRanking
        {
            get => labelBestRanking.Text;
            set => labelBestRanking.Text = value;
        }
        /// <summary>
        /// Amount of members in guild
        /// </summary>
        public byte GuildMembers
        {
            get => byte.Parse(labelMembers.Text);
            set => labelMembers.Text = value.ToString();
        }
        /// <summary>
        /// Amount of max members in guild
        /// </summary>
        public byte GuildMembersMax
        {
            get => byte.Parse(labelMembersMax.Text);
            set => labelMembersMax.Text = value.ToString();
        }
        /// <summary>
        /// Amount of members set defenses in guild
        /// </summary>
        public byte GuildMembersDefenses
        {
            get => byte.Parse(labelDefenseUnits.Text);
            set => labelDefenseUnits.Text = value.ToString();
        }
        /// <summary>
        /// Amount of members max set defenses in guild
        /// </summary>
        public byte GuildMembersDefensesMax
        {
            get => byte.Parse(labelDefenseUnitsMax.Text);
            set => labelDefenseUnitsMax.Text = value.ToString();
        }
        #endregion

        #region Events
        /// <summary>
        /// Initialize Guild tab
        /// </summary>
        public event Action<GuildMap, GuildWarParticipationInfo, List<GuildWarMember>, List<GuildMemberDefense>, GuildWarRankingStat, List<long>, List<Monster>> InitGuild;
        /// <summary>
        /// Resizing window
        /// </summary>
        public event Action Resized;
        #endregion

        public Guild()
        {
            InitializeComponent();
            objectListViewGuildMembers.DoubleBuffering(true);
        }

        #region Methods
        /// <summary>
        /// Initialize guild tab
        /// </summary>
        public void Init(GuildMap guild, GuildWarParticipationInfo guildWarParticipationInfo, List<GuildWarMember> guildWarMembers, List<GuildMemberDefense> guildWarDefenses, GuildWarRankingStat guildWarRanking, List<long> siegeDefenses, List<Monster> monsters)
        {
            InitGuild?.Invoke(guild, guildWarParticipationInfo, guildWarMembers, guildWarDefenses, guildWarRanking, siegeDefenses, monsters);
        }

        /// <summary>
        /// Move guild tab to the front of the app
        /// </summary>
        public void Front()
        {
            BringToFront();
        }

        /// <summary>
        /// Reset everything, if json file was invalid/incorrect
        /// </summary>
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

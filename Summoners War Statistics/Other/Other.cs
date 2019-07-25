﻿using System;
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
    public partial class Other : UserControl, IOtherView
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
            labelOtherActiveFriends,
            labelOtherGuild,
            labelRanking,
            objectListViewFriends,
            objectListViewGuild,
            panelFriends,
            panelGuild,
            panelGuildText
        };
        public ObjectListView SummonerFriendsList
        {
            get => objectListViewFriends;
            set => objectListViewFriends = value;
        }

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
        public event Action<List<Friend>, Guild, GuildWarParticipationInfo, List<GuildWarMember>, List<GuildMemberDefense>, GuildWarRankingStat> InitOther;
        public event Action Resized;
        #endregion

        public Other()
        {
            InitializeComponent();
            objectListViewFriends.DoubleBuffering(true);
            objectListViewGuild.DoubleBuffering(true);
        }

        #region Methods
        public void Init(List<Friend> friendsList, Guild guild, GuildWarParticipationInfo guildwarParticipationInfo, List<GuildWarMember> guildwarMemberList, List<GuildMemberDefense> guildMemberDefenseList, GuildWarRankingStat guildwarRanking)
        {
            InitOther?.Invoke(friendsList, guild, guildwarParticipationInfo, guildwarMemberList, guildMemberDefenseList, guildwarRanking);
        }
        public void Front()
        {
            BringToFront();
        }
        #endregion

        private void Other_Resize(object sender, EventArgs e)
        {
            Resized?.Invoke();
        }
    }
}

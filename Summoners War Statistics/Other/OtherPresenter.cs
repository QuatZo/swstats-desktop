using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    class OtherPresenter
    {
        IOtherView view;
        Model model;

        public OtherPresenter(IOtherView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.InitOther += View_InitOther;

            this.view.SummonerFriendsList.ColumnClick += SummonerFriendsList_ColumnClick;
            this.view.GuildMembersList.ColumnClick += GuildMembersList_ColumnClick;

            this.view.Resized += View_Resized;
        }

        private void View_Resized()
        {
            //labelDefenseUnits                 - 0
            //labelDefenseUnitsMax              - 1
            //labelDefenseUnitsSlash            - 2
            //labelGuildName                    - 3
            //labelLeaderName                   - 4
            //labelMembers                      - 5
            //labelMembersMax                   - 6
            //labelMembersSlash                 - 7
            //labelOtherActiveFriends           - 8
            //labelOtherGuild                   - 9
            //labelRanking                      - 10
            //listViewFriendsList               - 11
            //listViewGuildMembersList          - 12
            //panelFriends                      - 13
            //panelGuild                        - 14
            //panelGuildText                    - 15

            view.GuildMembersList.BeginUpdate();
            view.SummonerFriendsList.BeginUpdate();
            view.ControlsOther[13].Size = new Size(view.ControlsOther[13].Size.Width, view.TabSize.Height * 50 / 100);
            view.ControlsOther[14].Location = new Point(0, view.ControlsOther[13].Size.Height);
            view.ControlsOther[14].Size = new Size(view.ControlsOther[14].Size.Width, view.TabSize.Height - view.ControlsOther[13].Size.Height);
            var columnWidth = view.GuildMembersList.Size.Width / view.GuildMembersList.Columns.Count;


            foreach (ColumnHeader column in view.GuildMembersList.Columns)
            {
                column.Width = columnWidth - 5;
            }


            columnWidth = view.SummonerFriendsList.Size.Width / view.SummonerFriendsList.Columns.Count;


            foreach (ColumnHeader column in view.SummonerFriendsList.Columns)
            {
                column.Width = columnWidth - 5;
            }
            view.GuildMembersList.EndUpdate();
            view.SummonerFriendsList.EndUpdate();
        }

        private void GuildMembersList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            view.GuildMembersList.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void SummonerFriendsList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            view.SummonerFriendsList.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void View_InitOther(List<Friend> friendsList, Guild guild, GuildWarParticipationInfo guildwarParticipationInfo, List<GuildWarMember> guildwarMemberList, List<GuildMemberDefense> guildMemberDefenseList, GuildWarRankingStat guildwarRanking)
        {
            foreach(string[] friend in model.FriendsList(friendsList))
            {
                view.SummonerFriendsList.Items.Add(new ListViewItem(friend));
            }
            
            foreach(string[] member in model.GuildMembersList(guild, guildwarParticipationInfo, guildwarMemberList, guildMemberDefenseList))
            {
                view.GuildMembersList.Items.Add(new ListViewItem(member));
            }

            view.GuildName = guild.GuildInfo.Name;
            view.GuildLeaderName = guild.GuildInfo.MasterWizardName;
            view.GuildBestRanking = Mapping.Instance.GetGuildRanking((int)guildwarRanking.Best["rating_id"]);
            view.GuildMembers = (byte)guild.GuildInfo.MemberNow;
            view.GuildMembersMax = (byte)guild.GuildInfo.MemberMax;

            List<long> membersInGuildwar = new List<long>();
            byte defenses = 0;

            foreach(var guildwarMember in guildwarMemberList)
            {
                membersInGuildwar.Add((long)guildwarMember.WizardId);
            }

            foreach(var guildMemberDefense in guildMemberDefenseList)
            {
                if (membersInGuildwar.Contains((long)guildMemberDefense.WizardId))
                {
                    foreach(var defense in guildMemberDefense.UnitList)
                    {
                        defenses += (byte)defense.Count;
                    }
                }
            }

            view.GuildMembersDefenses = defenses;
            view.GuildMembersDefensesMax = (byte)(guildwarParticipationInfo.MemberCount * 6);
        }
    }
}

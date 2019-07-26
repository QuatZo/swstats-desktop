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
            this.view.SummonerFriendsList.BeforeSorting += SummonerFriendsList_BeforeSorting;

            this.view.GuildMembersList.ColumnClick += GuildMembersList_ColumnClick;
            this.view.GuildMembersList.BeforeSorting += GuildMembersList_BeforeSorting;

            this.view.Resized += View_Resized;
        }

        private void GuildMembersList_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            if (view.GuildMembersList.PrimarySortColumn != view.GuildMembersList.SecondarySortColumn) { view.GuildMembersList.SecondarySortColumn = view.GuildMembersList.PrimarySortColumn; }
        }

        private void SummonerFriendsList_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            if (view.SummonerFriendsList.PrimarySortColumn != view.SummonerFriendsList.SecondarySortColumn) { view.SummonerFriendsList.SecondarySortColumn = view.SummonerFriendsList.PrimarySortColumn; }
        }

        private void GuildMembersList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (view.GuildMembersList.SecondarySortColumn != null)
            {
                view.GuildMembersList.ListViewItemSorter = new ListViewItemComparer(e.Column, view.GuildMembersList.SecondarySortColumn.Index);
            }
            else
            {
                view.GuildMembersList.ListViewItemSorter = new ListViewItemComparer(e.Column, -1);
            }
            Logger.log.Info($"[Guild] Sorting");
        }

        private void SummonerFriendsList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (view.SummonerFriendsList.SecondarySortColumn != null)
            {
                view.SummonerFriendsList.ListViewItemSorter = new ListViewItemComparer(e.Column, view.SummonerFriendsList.SecondarySortColumn.Index);
            }
            else
            {
                view.SummonerFriendsList.ListViewItemSorter = new ListViewItemComparer(e.Column, -1);
            }
            Logger.log.Info($"[Friends] Sorting");
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
            //ObjectListViewFriends             - 11
            //ObjectListViewGuild               - 12
            //panelFriends                      - 13
            //panelGuild                        - 14
            //panelGuildText                    - 15

            view.GuildMembersList.BeginUpdate();
            view.SummonerFriendsList.BeginUpdate();
            view.Cntrls[13].Size = new Size(view.Cntrls[13].Size.Width, view.TabSize.Height * 50 / 100);
            view.Cntrls[14].Location = new Point(0, view.Cntrls[13].Size.Height);
            view.Cntrls[14].Size = new Size(view.Cntrls[14].Size.Width, view.TabSize.Height - view.Cntrls[13].Size.Height);
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

        private void View_InitOther(List<Friend> friendsList, Guild guild, GuildWarParticipationInfo guildwarParticipationInfo, List<GuildWarMember> guildwarMemberList, List<GuildMemberDefense> guildMemberDefenseList, GuildWarRankingStat guildwarRanking)
        {
            view.SummonerFriendsList.AddObjects(model.FriendsList(friendsList));
            Logger.log.Info($"[Friends] Friends to list done");

            view.GuildMembersList.AddObjects(model.GuildMembersList(guild, guildwarParticipationInfo, guildwarMemberList, guildMemberDefenseList));
            Logger.log.Info($"[Guild] Guild members to list done");

            view.GuildName = guild.GuildInfo.Name;
            Logger.log.Info($"[Guild] Guild name done");
            view.GuildLeaderName = guild.GuildInfo.MasterWizardName;
            Logger.log.Info($"[Guild] Guild leader name done");
            view.GuildBestRanking = Mapping.Instance.GetGuildRanking((int)guildwarRanking.Best["rating_id"]);
            Logger.log.Info($"[Guild] Guild best ranking done");
            view.GuildMembers = (byte)guild.GuildInfo.MemberNow;
            Logger.log.Info($"[Guild] Guild members amount done");
            view.GuildMembersMax = (byte)guild.GuildInfo.MemberMax;
            Logger.log.Info($"[Guild] Guild members max done");

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
            Logger.log.Info($"[Guild] Guild defenses amount done");
            view.GuildMembersDefensesMax = (byte)(guildwarParticipationInfo.MemberCount * 6);
            Logger.log.Info($"[Guild] Guild defenses max done");
        }
    }
}

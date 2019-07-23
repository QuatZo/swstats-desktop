using System;
using System.Collections.Generic;
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
        }

        private void GuildMembersList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            view.GuildMembersList.ListViewItemSorter = new ListViewItemComparer(e.Column);
            Logger.log.Info($"[Guild] Sorting");
        }

        private void SummonerFriendsList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            view.SummonerFriendsList.ListViewItemSorter = new ListViewItemComparer(e.Column);
            Logger.log.Info($"[Friends] Sorting");
        }

        private void View_InitOther(List<Friend> friendsList, Guild guild, GuildWarParticipationInfo guildwarParticipationInfo, List<GuildWarMember> guildwarMemberList, List<GuildMemberDefense> guildMemberDefenseList, GuildWarRankingStat guildwarRanking)
        {
            foreach(string[] friend in model.FriendsList(friendsList))
            {
                view.SummonerFriendsList.Items.Add(new ListViewItem(friend));
            }
            Logger.log.Info($"[Friends] Friends to list done");

            foreach (string[] member in model.GuildMembersList(guild, guildwarParticipationInfo, guildwarMemberList, guildMemberDefenseList))
            {
                view.GuildMembersList.Items.Add(new ListViewItem(member));
            }
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

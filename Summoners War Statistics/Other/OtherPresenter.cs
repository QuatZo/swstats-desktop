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
        }

        private void SummonerFriendsList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            view.SummonerFriendsList.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void View_InitOther(List<FriendListElement> friendsList, Guild guild, GuildwarParticipationInfo guildwarParticipationInfo, List<GuildwarMemberList> guildwarMemberList, List<GuildMemberDefenseList> guildMemberDefenseList, GuildwarRankingStat guildwarRanking)
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
            Console.WriteLine($"{(int)guildwarRanking.Best["rating_id"]} => {Mapping.Instance.GetGuildRanking((int)guildwarRanking.Best["rating_id"])}");
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

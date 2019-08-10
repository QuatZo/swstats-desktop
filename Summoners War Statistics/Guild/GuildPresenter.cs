using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    class GuildPresenter
    {
        private readonly IGuildView view;
        private readonly Model model;

        public GuildPresenter(IGuildView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.InitGuild += View_InitGuild;

            this.view.GuildMembersList.ColumnClick += GuildMembersList_ColumnClick;
            this.view.GuildMembersList.BeforeSorting += GuildMembersList_BeforeSorting;
        }
        private void GuildMembersList_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            if (view.GuildMembersList.PrimarySortColumn != view.GuildMembersList.SecondarySortColumn) { view.GuildMembersList.SecondarySortColumn = view.GuildMembersList.PrimarySortColumn; }
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

        private void View_InitGuild(GuildMap guild, GuildWarParticipationInfo guildwarParticipationInfo, List<GuildWarMember> guildwarMemberList, List<GuildMemberDefense> guildMemberDefenseList, GuildWarRankingStat guildwarRanking)
        {
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
            foreach (var guildwarMember in guildwarMemberList)
            {
                membersInGuildwar.Add((long)guildwarMember.WizardId);
            }
            foreach (var guildMemberDefense in guildMemberDefenseList)
            {
                if (membersInGuildwar.Contains((long)guildMemberDefense.WizardId))
                {
                    foreach (var defense in guildMemberDefense.UnitList)
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

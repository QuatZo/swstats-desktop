using System;
using System.Collections.Generic;
using System.Drawing;
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

            this.view.GuildSiegeDefensesList.ColumnClick += GuildSiegeDefensesList_ColumnClick;
            this.view.GuildSiegeDefensesList.BeforeSorting += GuildSiegeDefensesList_BeforeSorting;

            this.view.Resized += View_Resized;
        }

        private void GuildSiegeDefensesList_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            if (view.GuildSiegeDefensesList.PrimarySortColumn != view.GuildSiegeDefensesList.SecondarySortColumn) { view.GuildSiegeDefensesList.SecondarySortColumn = view.GuildSiegeDefensesList.PrimarySortColumn; }
        }

        private void GuildSiegeDefensesList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (view.GuildSiegeDefensesList.SecondarySortColumn != null)
            {
                view.GuildSiegeDefensesList.ListViewItemSorter = new ListViewItemComparer(e.Column, view.GuildSiegeDefensesList.SecondarySortColumn.Index);
            }
            else
            {
                view.GuildSiegeDefensesList.ListViewItemSorter = new ListViewItemComparer(e.Column, -1);
            }
            Logger.log.Info($"[Guild] Sorting Siege Defenses");
        }

        private void View_Resized()
        {
            //pictureBoxDefenseUnits            - 0
            //labelDefenseUnits                 - 1
            //labelDefenseUnitsMax              - 2
            //labelDefenseUnitsSlash            - 3
            //pictureBoxName                    - 4
            //labelName                         - 5
            //pictureBoxLeader                  - 6
            //labelLeaderName                   - 7
            //pictureBoxMembers                 - 8
            //labelMembers                      - 9
            //labelMembersMax                   - 10
            //labelMembersSlash                 - 11
            //pictureBoxActualRanking           - 12
            //labelActualRanking                - 13
            //pictureBoxBestRanking             - 14
            //labelBestRanking                  - 15
            //objectListViewGuildSiegeDefenses  - 16
            //objectListViewGuildMembers        - 17
            //panelGuildMembers                 - 18
            //panelGuildText                    - 19
            //panelGuildSiegeDefenses           - 20
            //labelGuildSiegeDefenses           - 21
            //labelGuildMembers                 - 22
            //labelGuildInfo                    - 23

            view.GuildSiegeDefensesList.BeginUpdate();
            view.GuildMembersList.BeginUpdate();

            Size pictureBoxSize = new Size(view.Cntrls[0].Size.Width, view.Cntrls[0].Size.Height);
            int widthFirstLevel = 10;
            int widthFirstHalfLevel = widthFirstLevel + pictureBoxSize.Width;
            int widthSecondLevel = view.TabSize.Width - view.Cntrls[13].Size.Width - pictureBoxSize.Width;
            int widthSecondHalfLevel = widthSecondLevel + pictureBoxSize.Width;
            int heightFirstLevel = 5 + view.Cntrls[23].Size.Height;
            int heightSecondLevel = heightFirstLevel + pictureBoxSize.Height;
            int heightThirdLevel = heightSecondLevel + pictureBoxSize.Height;

            // left side
            view.Cntrls[4].Location = new Point(widthFirstLevel, heightFirstLevel);
            view.Cntrls[5].Location = new Point(widthFirstHalfLevel, heightFirstLevel);

            view.Cntrls[6].Location = new Point(widthFirstLevel, heightSecondLevel);
            view.Cntrls[7].Location = new Point(widthFirstHalfLevel, heightSecondLevel);

            view.Cntrls[14].Location = new Point(widthFirstLevel, heightThirdLevel);
            view.Cntrls[15].Location = new Point(widthFirstHalfLevel, heightThirdLevel);

            // right side
            view.Cntrls[8].Location = new Point(widthSecondLevel, heightFirstLevel);
            view.Cntrls[9].Location = new Point(widthSecondHalfLevel, heightFirstLevel);
            view.Cntrls[11].Location = new Point(widthSecondHalfLevel + view.Cntrls[9].Size.Width, heightFirstLevel);
            view.Cntrls[10].Location = new Point(view.Cntrls[11].Location.X + view.Cntrls[11].Size.Width, heightFirstLevel);

            view.Cntrls[0].Location = new Point(widthSecondLevel, heightSecondLevel);
            view.Cntrls[1].Location = new Point(widthSecondHalfLevel, heightSecondLevel);
            view.Cntrls[3].Location = new Point(widthSecondHalfLevel + view.Cntrls[1].Size.Width, heightSecondLevel);
            view.Cntrls[2].Location = new Point(view.Cntrls[3].Location.X + view.Cntrls[3].Size.Width, heightSecondLevel);

            view.Cntrls[12].Location = new Point(widthSecondLevel, heightThirdLevel);
            view.Cntrls[13].Location = new Point(widthSecondHalfLevel, heightThirdLevel);

            view.Cntrls[16].Size = new Size(view.Cntrls[16].Size.Width, view.Cntrls[20].Size.Height - view.Cntrls[21].Size.Height);
            int columnWidth = view.GuildSiegeDefensesList.Size.Width / view.GuildSiegeDefensesList.Columns.Count;
            foreach (ColumnHeader column in view.GuildSiegeDefensesList.Columns)
            {
                column.Width = columnWidth - 5;
            }

            columnWidth = view.GuildMembersList.Size.Width / view.GuildMembersList.Columns.Count;
            foreach (ColumnHeader column in view.GuildMembersList.Columns)
            {
                column.Width = columnWidth - 5;
            }

            view.GuildSiegeDefensesList.EndUpdate();
            view.GuildMembersList.EndUpdate();
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
            Logger.log.Info($"[Guild] Sorting Members");
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
            view.GuildActualRanking = Mapping.Instance.GetGuildRanking((int)guildwarRanking.Current["rating_id"]);
            Logger.log.Info($"[Guild] Guild actual ranking done");
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

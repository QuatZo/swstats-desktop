using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace Summoners_War_Statistics
{
    class RunesPresenter
    {
        IRunesView view;
        Model model;

        public RunesPresenter(IRunesView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.InitRunes += View_InitRunes;
            this.view.CanSeeRunesTab += View_CanSeeRunesTab;

            this.view.RunesListView.BeforeSorting += RunesListView_BeforeSorting;
            this.view.RunesListView.ColumnClick += RunesList_ColumnClick;
            this.view.Resized += View_Resized;
        }

        private void View_CanSeeRunesTab()
        {
            SetUI();
        }

        private void RunesListView_BeforeSorting(object sender, BeforeSortingEventArgs e)
        {
            if (view.RunesListView.PrimarySortColumn != view.RunesListView.SecondarySortColumn) { view.RunesListView.SecondarySortColumn = view.RunesListView.PrimarySortColumn; }
        }

        private void View_Resized()
        {
            //labelRunes                        - 0
            //labelRuneEfficiency               - 1
            //labelRuneMainstat                 - 2
            //labelRuneQuality                  - 3
            //labelRunesAmount                  - 4
            //labelRunesEfficiencyHigh          - 5
            //labelRunesEfficiencyLow           - 6
            //labelRunesEfficiencyMean          - 7
            //labelRunesEfficiencyMedian        - 8
            //labelRuneSet                      - 9
            //labelRunesInventory               - 10
            //labelRuneSlot                     - 11
            //labelRunesMaxed                   - 12
            //labelRunesStandardDeviation       - 13
            //labelTextAmount                   - 14
            //labelTextEfficiencyLow            - 15
            //labelTextEfficiencyHigh           - 16
            //labelTextInventory                - 17
            //labelTextMaxed                    - 18
            //labelTextEfficiencyMean           - 19
            //labelTextEfficiencyMedian         - 20
            //labelTextStandardDeviation        - 21
            //labelUpgrade                      - 22
            //listViewRunesList                 - 23
            //comboBoxRuneEfficiency            - 24
            //comboBoxRuneEfficiencyIf          - 25
            //comboBoxRuneMainstat              - 26
            //comboBoxRuneQuality               - 27
            //comboBoxRuneSet                   - 28
            //comboBoxRuneSlot                  - 29
            //comboBoxRuneUpgrade               - 30
            //comboBoxRuneUpgradeIf             - 31
            //panelHeader                       - 32
            //panelTable                        - 33   
            //panelFooter                       - 34
            //labelRuneOriginalQuality          - 35
            //comboBoxRuneOriginalQuality       - 36
            //flowLayoutPanelFilters            - 37
            //labelRuneInnate                   - 38
            //comboBoxRuneInnate                - 39
            //labelRuneSubstat1                 - 40
            //comboBoxRuneSubstat1              - 41
            //comboBoxRuneSubstat1YesNo         - 42
            //labelRuneSubstat2                 - 43
            //comboBoxRuneSubstat2              - 44
            //comboBoxRuneSubstat2YesNo         - 45
            //labelRuneSubstat3                 - 46
            //comboBoxRuneSubstat3              - 47
            //comboBoxRuneSubstat3YesNo         - 48
            //labelRuneSubstat4                 - 49
            //comboBoxRuneSubstat4              - 50
            //comboBoxRuneSubstat4YesNo         - 51

            FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)view.Cntrls[37];
            if(flowLayoutPanel.Controls[0].Location.Y != flowLayoutPanel.Controls[flowLayoutPanel.Controls.Count - 1].Location.Y)
            {
                view.Cntrls[32].Height = (flowLayoutPanel.Controls[0].Height * 2) + 20 + view.Cntrls[0].Height;
            }
            else { view.Cntrls[32].Height = flowLayoutPanel.Controls[0].Height + view.Cntrls[0].Height + 20; }
            

            view.Cntrls[33].Location = new Point(flowLayoutPanel.Location.X + flowLayoutPanel.Size.Width, flowLayoutPanel.Location.Y + flowLayoutPanel.Size.Height);
            view.Cntrls[23].Location = new Point(0, 0);

            // panelFooter
            int footerHeightFirstLevel = 10;
            int footerHeightSecondLevel = footerHeightFirstLevel + 20;
            int footerWidthSecondLevel = view.Cntrls[34].Width / 4;

            view.Cntrls[15].Location = new Point(footerWidthSecondLevel, footerHeightFirstLevel);
            view.Cntrls[6].Location = new Point(footerWidthSecondLevel + view.Cntrls[15].Size.Width + 5, footerHeightFirstLevel);
            view.Cntrls[16].Location = new Point(footerWidthSecondLevel + view.Cntrls[15].Size.Width - view.Cntrls[16].Size.Width, footerHeightSecondLevel);
            view.Cntrls[5].Location = new Point(view.Cntrls[6].Location.X, footerHeightSecondLevel);

            int footerWidthThirdLevel = view.Cntrls[34].Width * 3 / 5;

            view.Cntrls[19].Location = new Point(footerWidthThirdLevel, footerHeightFirstLevel);
            view.Cntrls[7].Location = new Point(footerWidthThirdLevel + view.Cntrls[19].Size.Width + 5, footerHeightFirstLevel);
            view.Cntrls[20].Location = new Point(footerWidthThirdLevel + view.Cntrls[19].Size.Width - view.Cntrls[20].Size.Width, footerHeightSecondLevel);
            view.Cntrls[8].Location = new Point(view.Cntrls[7].Location.X, footerHeightSecondLevel);

            int footerWidthFourthLevel = view.Cntrls[34].Width - 50;

            view.Cntrls[13].Location = new Point(footerWidthFourthLevel, footerHeightFirstLevel);
            view.Cntrls[21].Location = new Point(footerWidthFourthLevel - 5 - view.Cntrls[21].Size.Width, footerHeightFirstLevel);
            view.Cntrls[12].Location = new Point(footerWidthFourthLevel, footerHeightSecondLevel);
            view.Cntrls[18].Location = new Point(footerWidthFourthLevel - 5 - view.Cntrls[18].Size.Width, footerHeightSecondLevel);

            // panelTable
            view.RunesListView.BeginUpdate();
            var columnWidth = view.RunesListView.Size.Width / view.RunesListView.Columns.Count;

            foreach(ColumnHeader column in view.RunesListView.Columns)
            {
                column.Width = columnWidth - 5;
            }
            view.RunesListView.EndUpdate();
        }

        private void RunesList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if(view.RunesListView.SecondarySortColumn != null)
            {
                view.RunesListView.ListViewItemSorter = new ListViewItemComparer(e.Column, view.RunesListView.SecondarySortColumn.Index);
            }
            else
            {
                view.RunesListView.ListViewItemSorter = new ListViewItemComparer(e.Column, -1);
            }
            Logger.log.Info($"[Runes] Sorting by {e.Column}");
        }

        private void SetUI()
        {
            int headerHeightNullLevel = 5;
            int headerWidthFirstLevel = 5;
            int headerHeightFirstLevel = 0;
            int headerHeightSecondLevel = view.Cntrls[9].Size.Height + view.Cntrls[9].Location.Y + 5;

            view.Cntrls[0].Location = new Point(headerWidthFirstLevel, headerHeightNullLevel);

            view.Cntrls[9].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.Cntrls[28].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);

            view.Cntrls[2].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.Cntrls[26].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);

            view.Cntrls[38].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.Cntrls[39].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);

            view.Cntrls[3].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.Cntrls[27].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);

            view.Cntrls[35].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.Cntrls[36].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);

            view.Cntrls[11].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.Cntrls[29].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);

            view.Cntrls[22].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.Cntrls[30].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);
            view.Cntrls[31].Location = new Point(headerWidthFirstLevel + view.Cntrls[30].Size.Width + 2, headerHeightSecondLevel);

            view.Cntrls[1].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.Cntrls[24].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);
            view.Cntrls[25].Location = new Point(headerWidthFirstLevel + view.Cntrls[24].Size.Width + 2, headerHeightSecondLevel);

            view.Cntrls[40].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.Cntrls[41].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);
            view.Cntrls[42].Location = new Point(headerWidthFirstLevel + view.Cntrls[41].Size.Width + 2, headerHeightSecondLevel);

            view.Cntrls[43].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.Cntrls[44].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);
            view.Cntrls[45].Location = new Point(headerWidthFirstLevel + view.Cntrls[41].Size.Width + 2, headerHeightSecondLevel);

            view.Cntrls[46].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.Cntrls[47].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);
            view.Cntrls[48].Location = new Point(headerWidthFirstLevel + view.Cntrls[41].Size.Width + 2, headerHeightSecondLevel);

            view.Cntrls[49].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.Cntrls[50].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);
            view.Cntrls[51].Location = new Point(headerWidthFirstLevel + view.Cntrls[41].Size.Width + 2, headerHeightSecondLevel);

            int footerHeightFirstLevel = 10;
            int footerHeightSecondLevel = footerHeightFirstLevel + 20;

            view.Cntrls[14].Location = new Point(20, footerHeightFirstLevel);
            view.Cntrls[4].Location = new Point(view.Cntrls[14].Location.X + view.Cntrls[14].Size.Width + 5, footerHeightFirstLevel);
            view.Cntrls[17].Location = new Point(view.Cntrls[14].Location.X + view.Cntrls[14].Size.Width - view.Cntrls[17].Size.Width, footerHeightSecondLevel);
            view.Cntrls[10].Location = new Point(view.Cntrls[4].Location.X, footerHeightSecondLevel);
        }

        private void View_InitRunes()
        {
            view.RunesListView.Items.Clear();
            Logger.log.Info($"[Runes] Reading filters");
            List<byte> filters = new List<byte>()
            {
                view.ChosenRuneSet, // ID 0
                view.ChosenRuneStars,
                view.ChosenRuneStarsStatement,
                view.ChosenRuneMainstat,
                view.ChosenRuneInnate,
                view.ChosenRuneQuality, // ID 5
                view.ChosenRuneOriginQuality,
                view.ChosenRuneSlot,
                view.ChosenRuneUpgrade,
                view.ChosenRuneUpgradeStatement,
                view.ChosenRuneEfficiency, // ID 10
                view.ChosenRuneEfficiencyStatement,
                view.ChosenRuneSubstat1,
                view.ChosenRuneSubstat1Statement,
                view.ChosenRuneSubstat2,
                view.ChosenRuneSubstat2Statement, // ID 15
                view.ChosenRuneSubstat3,
                view.ChosenRuneSubstat3Statement, 
                view.ChosenRuneSubstat4,
                view.ChosenRuneSubstat4Statement,
            };

            Logger.log.Info($"[Runes] Correct");

            ushort runesInInventory = 0;
            ushort runesMaxed = 0;
            List<double> efficiencies = new List<double>();
            view.RunesListView.BeginUpdate();
            List<RuneRow> runes = model.RunesList(view.RunesList, view.MonstersMasterId, filters);
            foreach (RuneRow rune in runes)
            {
                if(rune.Level == 15) { runesMaxed++; }
                if(rune.Origin.ToLower() == "inventory") { runesInInventory++; }

                efficiencies.Add(double.Parse(rune.Eff));
            }

            view.RunesListView.AddObjects(runes);

            view.RunesListView.EndUpdate();
            Logger.log.Info($"[Runes] Runes in list view done");
            view.RunesAmount = (ushort)view.RunesListView.Items.Count;
            Logger.log.Info($"[Runes] Runes amount done");
            view.RunesMaxed = runesMaxed;
            Logger.log.Info($"[Runes] Runes maxed done");
            view.RunesInventory = runesInInventory;
            Logger.log.Info($"[Runes] Runes in inventory done");

            efficiencies.Sort();
            if (efficiencies.Count > 0)
            {
                view.RunesEfficiencyMin = efficiencies.Min();
                Logger.log.Info($"[Runes] Runes efficiency min done");
                view.RunesEfficiencyMax = efficiencies.Max();
                Logger.log.Info($"[Runes] Runes efficiency max done");
                view.RunesEfficiencyMean = Math.Round(efficiencies.Sum() / efficiencies.Count, 2);
                Logger.log.Info($"[Runes] Runes efficiency mean done");
                if (efficiencies.Count >= 2)
                {
                    int mid = efficiencies.Count / 2;

                    view.RunesEfficiencyMedian = Math.Round(mid % 2 == 0 ? efficiencies[mid] : (efficiencies[mid] + efficiencies[mid - 1]) / 2, 2);
                    Logger.log.Info($"[Runes] Runes efficiency median done");

                    double sum = 0;
                    foreach(var efficiency in efficiencies)
                    {
                        sum += Math.Pow(efficiency - view.RunesEfficiencyMean, 2);
                    }
                    view.RunesEfficiencyStandardDeviation = Math.Round(Math.Sqrt(sum / (efficiencies.Count - 1)), 2);
                    Logger.log.Info($"[Runes] Runes efficiency standard deviation done");
                }
                else if(efficiencies.Count == 1)
                {
                    view.RunesEfficiencyMedian = efficiencies[0];
                    view.RunesEfficiencyStandardDeviation = 0;
                }
                else
                {
                    view.RunesEfficiencyMedian = view.RunesEfficiencyStandardDeviation = 0;
                }
            }
        }
    }
}

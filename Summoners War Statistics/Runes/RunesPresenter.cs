using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            this.view.RunesListView.ColumnClick += RunesList_ColumnClick;
            this.view.Resized += View_Resized;
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

            // panelHeader
            int headerHeightNullLevel = 5;
            int headerWidthFirstLevel = 5;
            int headerHeightFirstLevel = view.Cntrls[32].Size.Height - 60;
            int headerHeightSecondLevel = view.Cntrls[32].Size.Height - 35;

            view.Cntrls[0].Location = new Point(headerWidthFirstLevel, headerHeightNullLevel);
            view.Cntrls[9].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.Cntrls[28].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);

            int headerWidthSecondLevel = view.Cntrls[32].Size.Width * 14 /100;
            view.Cntrls[2].Location = new Point(headerWidthSecondLevel, headerHeightFirstLevel);
            view.Cntrls[26].Location = new Point(headerWidthSecondLevel, headerHeightSecondLevel);

            int headerWidthThirdLevel = view.Cntrls[32].Size.Width * 28 / 100;
            view.Cntrls[3].Location = new Point(headerWidthThirdLevel, headerHeightFirstLevel);
            view.Cntrls[27].Location = new Point(headerWidthThirdLevel, headerHeightSecondLevel);

            int headerWidthFourthLevel = view.Cntrls[32].Size.Width * 42 / 100;
            view.Cntrls[11].Location = new Point(headerWidthFourthLevel, headerHeightFirstLevel);
            view.Cntrls[29].Location = new Point(headerWidthFourthLevel, headerHeightSecondLevel);

            int headerWidthFifthLevel = view.Cntrls[32].Size.Width * 56 / 100;
            view.Cntrls[22].Location = new Point(headerWidthFifthLevel, headerHeightFirstLevel);
            view.Cntrls[30].Location = new Point(headerWidthFifthLevel, headerHeightSecondLevel);

            int headerWidthFifthHalfLevel = headerWidthFifthLevel + view.Cntrls[30].Size.Width + 2;
            view.Cntrls[31].Location = new Point(headerWidthFifthHalfLevel, headerHeightSecondLevel);

            int headerWidthSixthLevel = view.Cntrls[32].Size.Width * 76 / 100; // + 14 (comboBox) +6 (mini comboBox)
            view.Cntrls[1].Location = new Point(headerWidthSixthLevel, headerHeightFirstLevel);
            view.Cntrls[24].Location = new Point(headerWidthSixthLevel, headerHeightSecondLevel);

            int headerWidthSixthHalfLevel = headerWidthSixthLevel + view.Cntrls[24].Size.Width + 2;
            view.Cntrls[25].Location = new Point(headerWidthSixthHalfLevel, headerHeightSecondLevel);

            // panelFooter
            int footerHeightFirstLevel = 10;
            int footerHeightSecondLevel = footerHeightFirstLevel + 35;

            view.Cntrls[14].Location = new Point(20, footerHeightFirstLevel);
            view.Cntrls[4].Location = new Point(view.Cntrls[14].Location.X + view.Cntrls[14].Size.Width + 5, footerHeightFirstLevel);
            view.Cntrls[17].Location = new Point(view.Cntrls[14].Location.X + view.Cntrls[14].Size.Width - view.Cntrls[17].Size.Width, footerHeightSecondLevel);
            view.Cntrls[10].Location = new Point(view.Cntrls[4].Location.X, footerHeightSecondLevel);

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
            view.RunesListView.ListViewItemSorter = new ListViewItemComparer(e.Column);
            Logger.log.Info($"[Runes] Sorting");
        }

        private List<string> GetColumns()
        {
            List<string> columns = new List<string>();

            foreach(ColumnHeader column in view.RunesListView.Columns)
            {
                columns.Add(column.Text);
            }

            return columns;
        }

        private void View_InitRunes()
        {
            view.RunesListView.Items.Clear();

            Logger.log.Info($"[Runes] Reading filters");
            List<byte> filters = new List<byte>()
            {
                view.ChosenRuneSet,
                view.ChosenRuneMainstat,
                view.ChosenRuneQuality,
                view.ChosenRuneSlot,
                view.ChosenRuneUpgrade,
                view.ChosenRuneUpgradeStatement,
                view.ChosenRuneEfficiency,
                view.ChosenRuneEfficiencyStatement
            };

            Logger.log.Info($"[Runes] Correct");

            ushort runesInInventory = 0;
            ushort runesMaxed = 0;
            List<double> efficiencies = new List<double>();
            view.RunesListView.BeginUpdate();
            List<RuneRow> runes = model.RunesList(view.RunesList, view.MonstersMasterId, GetColumns(), filters);
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
                if (efficiencies.Count > 2)
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
            }
        }
    }
}

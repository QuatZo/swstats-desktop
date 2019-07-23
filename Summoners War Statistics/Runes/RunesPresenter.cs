using System;
using System.Collections.Generic;
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
            int headerHeightFirstLevel = view.ControlsRunes[32].Size.Height - 60;
            int headerHeightSecondLevel = view.ControlsRunes[32].Size.Height - 35;

            view.ControlsRunes[0].Location = new Point(headerWidthFirstLevel, headerHeightNullLevel);
            view.ControlsRunes[9].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.ControlsRunes[28].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);

            int headerWidthSecondLevel = view.ControlsRunes[32].Size.Width * 14 /100;
            view.ControlsRunes[2].Location = new Point(headerWidthSecondLevel, headerHeightFirstLevel);
            view.ControlsRunes[26].Location = new Point(headerWidthSecondLevel, headerHeightSecondLevel);

            int headerWidthThirdLevel = view.ControlsRunes[32].Size.Width * 28 / 100;
            view.ControlsRunes[3].Location = new Point(headerWidthThirdLevel, headerHeightFirstLevel);
            view.ControlsRunes[27].Location = new Point(headerWidthThirdLevel, headerHeightSecondLevel);

            int headerWidthFourthLevel = view.ControlsRunes[32].Size.Width * 42 / 100;
            view.ControlsRunes[11].Location = new Point(headerWidthFourthLevel, headerHeightFirstLevel);
            view.ControlsRunes[29].Location = new Point(headerWidthFourthLevel, headerHeightSecondLevel);

            int headerWidthFifthLevel = view.ControlsRunes[32].Size.Width * 56 / 100;
            view.ControlsRunes[22].Location = new Point(headerWidthFifthLevel, headerHeightFirstLevel);
            view.ControlsRunes[30].Location = new Point(headerWidthFifthLevel, headerHeightSecondLevel);

            int headerWidthFifthHalfLevel = headerWidthFifthLevel + view.ControlsRunes[30].Size.Width + 2;
            view.ControlsRunes[31].Location = new Point(headerWidthFifthHalfLevel, headerHeightSecondLevel);

            int headerWidthSixthLevel = view.ControlsRunes[32].Size.Width * 76 / 100; // + 14 (comboBox) +6 (mini comboBox)
            view.ControlsRunes[1].Location = new Point(headerWidthSixthLevel, headerHeightFirstLevel);
            view.ControlsRunes[24].Location = new Point(headerWidthSixthLevel, headerHeightSecondLevel);

            int headerWidthSixthHalfLevel = headerWidthSixthLevel + view.ControlsRunes[24].Size.Width + 2;
            view.ControlsRunes[25].Location = new Point(headerWidthSixthHalfLevel, headerHeightSecondLevel);

            // panelFooter
            int footerHeightFirstLevel = 10;
            int footerHeightSecondLevel = footerHeightFirstLevel + 35;

            view.ControlsRunes[14].Location = new Point(20, footerHeightFirstLevel);
            view.ControlsRunes[4].Location = new Point(view.ControlsRunes[14].Location.X + view.ControlsRunes[14].Size.Width + 5, footerHeightFirstLevel);
            view.ControlsRunes[17].Location = new Point(view.ControlsRunes[14].Location.X + view.ControlsRunes[14].Size.Width - view.ControlsRunes[17].Size.Width, footerHeightSecondLevel);
            view.ControlsRunes[10].Location = new Point(view.ControlsRunes[4].Location.X, footerHeightSecondLevel);

            int footerWidthSecondLevel = view.ControlsRunes[34].Width / 4;

            view.ControlsRunes[15].Location = new Point(footerWidthSecondLevel, footerHeightFirstLevel);
            view.ControlsRunes[6].Location = new Point(footerWidthSecondLevel + view.ControlsRunes[15].Size.Width + 5, footerHeightFirstLevel);
            view.ControlsRunes[16].Location = new Point(footerWidthSecondLevel + view.ControlsRunes[15].Size.Width - view.ControlsRunes[16].Size.Width, footerHeightSecondLevel);
            view.ControlsRunes[5].Location = new Point(view.ControlsRunes[6].Location.X, footerHeightSecondLevel);

            int footerWidthThirdLevel = view.ControlsRunes[34].Width * 3 / 5;

            view.ControlsRunes[19].Location = new Point(footerWidthThirdLevel, footerHeightFirstLevel);
            view.ControlsRunes[7].Location = new Point(footerWidthThirdLevel + view.ControlsRunes[19].Size.Width + 5, footerHeightFirstLevel);
            view.ControlsRunes[20].Location = new Point(footerWidthThirdLevel + view.ControlsRunes[19].Size.Width - view.ControlsRunes[20].Size.Width, footerHeightSecondLevel);
            view.ControlsRunes[8].Location = new Point(view.ControlsRunes[7].Location.X, footerHeightSecondLevel);

            int footerWidthFourthLevel = view.ControlsRunes[34].Width - 50;

            view.ControlsRunes[13].Location = new Point(footerWidthFourthLevel, footerHeightFirstLevel);
            view.ControlsRunes[21].Location = new Point(footerWidthFourthLevel - 5 - view.ControlsRunes[21].Size.Width, footerHeightFirstLevel);
            view.ControlsRunes[12].Location = new Point(footerWidthFourthLevel, footerHeightSecondLevel);
            view.ControlsRunes[18].Location = new Point(footerWidthFourthLevel - 5 - view.ControlsRunes[18].Size.Width, footerHeightSecondLevel);

        }

        private void RunesList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            view.RunesListView.ListViewItemSorter = new ListViewItemComparer(e.Column);
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

            ushort runesInInventory = 0;
            ushort runesMaxed = 0;
            List<double> efficiencies = new List<double>();

            foreach(string[] rune in model.RunesList(view.RunesList, view.MonstersMasterId, GetColumns(), filters))
            {
                if(rune[2] == "15") { runesMaxed++; }
                if(rune[3].ToLower() == "inventory") { runesInInventory++; }

                efficiencies.Add(double.Parse(rune[rune.Length - 1]));

                view.RunesListView.Items.Add(new ListViewItem(rune));
            }
            view.RunesAmount = (ushort)view.RunesListView.Items.Count;
            view.RunesMaxed = runesMaxed;
            view.RunesInventory = runesInInventory;

            efficiencies.Sort();
            if (efficiencies.Count > 0)
            {
                view.RunesEfficiencyMin = efficiencies.Min();
                view.RunesEfficiencyMax = efficiencies.Max();
                view.RunesEfficiencyMean = Math.Round(efficiencies.Sum() / efficiencies.Count, 2);
                if(efficiencies.Count > 2)
                {
                    int mid = efficiencies.Count / 2;

                    view.RunesEfficiencyMedian = Math.Round(mid % 2 == 0 ? efficiencies[mid] : (efficiencies[mid] + efficiencies[mid - 1]) / 2, 2);

                    double sum = 0;
                    foreach(var efficiency in efficiencies)
                    {
                        sum += Math.Pow(efficiency - view.RunesEfficiencyMean, 2);
                    }
                    view.RunesEfficiencyStandardDeviation = Math.Round(Math.Sqrt(sum / (efficiencies.Count - 1)), 2);
                }
            }
        }
    }
}

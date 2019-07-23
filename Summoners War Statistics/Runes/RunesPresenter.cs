using System;
using System.Collections.Generic;
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

            foreach(string[] rune in model.RunesList(view.RunesList, view.MonstersMasterId, GetColumns(), filters))
            {
                if(rune[2] == "15") { runesMaxed++; }
                if(rune[3].ToLower() == "inventory") { runesInInventory++; }

                efficiencies.Add(double.Parse(rune[rune.Length - 1]));

                view.RunesListView.Items.Add(new ListViewItem(rune));
            }
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

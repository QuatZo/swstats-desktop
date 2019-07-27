using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Summoners_War_Statistics
{
    class DimHolePresenter
    {
        IDimHoleView view;
        Model model;

        public DimHolePresenter(IDimHoleView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.DimHoleLevelChanged += View_DimHoleLevelChanged;
            this.view.InitDimHole += View_InitDimHole;

            this.view.DimHoleMonstersListView.ColumnClick += DimHoleMonstersListView_ColumnClick;
            this.view.DimHoleMonstersListView.BeforeSorting += DimHoleMonstersListView_BeforeSorting;

            this.view.Resized += View_Resized;

            this.view.FloorTextChanged += View_FloorTextChanged;
        }

        private void View_FloorTextChanged()
        {
            List<(int Floor, TimeSpan Time, double SuccessRate, double Ratio)> inputs = new List<(int Floor, TimeSpan Time, double SuccessRate, double Ratio)>()
            {
                (1, view.DimHoleFloorTimes[0], view.DimHoleFloorSuccessRates[0], (double)Mapping.Instance.GetAxpByFloor(1) / (double)Mapping.Instance.GetAxpByFloor(5)),
                (2, view.DimHoleFloorTimes[1], view.DimHoleFloorSuccessRates[1], (double)Mapping.Instance.GetAxpByFloor(2) / (double)Mapping.Instance.GetAxpByFloor(5)),
                (3, view.DimHoleFloorTimes[2], view.DimHoleFloorSuccessRates[2], (double)Mapping.Instance.GetAxpByFloor(3) / (double)Mapping.Instance.GetAxpByFloor(5)),
                (4, view.DimHoleFloorTimes[3], view.DimHoleFloorSuccessRates[3], (double)Mapping.Instance.GetAxpByFloor(4) / (double)Mapping.Instance.GetAxpByFloor(5)),
                (5, view.DimHoleFloorTimes[4], view.DimHoleFloorSuccessRates[4], (double)Mapping.Instance.GetAxpByFloor(5) / (double)Mapping.Instance.GetAxpByFloor(5))
            };

            Dictionary<int, double> floors = new Dictionary<int, double>() { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 } };
            foreach(var item in inputs)
            {
                if (item.SuccessRate > 1 || item.Time.TotalSeconds == 0) { continue; }
                floors[item.Floor] = item.SuccessRate * item.Ratio / (item.Time.TotalSeconds + 1);
                Console.WriteLine(floors[item.Floor]);
            }
            view.DimHoleFloor = "B" + floors.Aggregate((l, r) => l.Value > r.Value ? l : r).Key.ToString();
        }

        private void DimHoleMonstersListView_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            if (view.DimHoleMonstersListView.PrimarySortColumn != view.DimHoleMonstersListView.SecondarySortColumn) { view.DimHoleMonstersListView.SecondarySortColumn = view.DimHoleMonstersListView.PrimarySortColumn; }
        }

        private void DimHoleMonstersListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (view.DimHoleMonstersListView.SecondarySortColumn != null)
            {
                view.DimHoleMonstersListView.ListViewItemSorter = new ListViewItemComparer(e.Column, view.DimHoleMonstersListView.SecondarySortColumn.Index);
            }
            else
            {
                view.DimHoleMonstersListView.ListViewItemSorter = new ListViewItemComparer(e.Column, -1);
            }
            Logger.log.Info($"[Dimension Hole] Sorting");
        }
        private void View_Resized()
        {
            //labelDimHoleMonsters                  - 0
            //labelDimensionalHoleEnergy            - 1
            //labelDimensionalHoleEnergyMax         - 2
            //labelDimensionalHoleEnergyMaxInfo     - 3
            //labelDimensionalHoleEnergySlash       - 4
            //labelDimHoleEnergy                    - 5 
            //objectListViewDimHole                 - 6
            //radioButton1                          - 7
            //radioButton2                          - 8
            //radioButton3                          - 9
            //radioButton4                          - 10
            //radioButton5                          - 11
            //panelHeader                           - 12
            //panelContent                          - 13
            //panelButtons                          - 14

            view.Cntrls[3].Location = new Point(view.SizeWindow.Width - 5 - view.Cntrls[3].Size.Width, view.Cntrls[1].Location.Y);

            view.DimHoleMonstersListView.BeginUpdate();
            int columnWidth = view.DimHoleMonstersListView.Size.Width / view.DimHoleMonstersListView.Columns.Count;
            foreach(ColumnHeader column in view.DimHoleMonstersListView.Columns)
            {
                column.Width = columnWidth - 5;
            }
            view.DimHoleMonstersListView.EndUpdate();
        }

        private void View_InitDimHole(DimensionHoleInfo dimensionHoleInfo, List<Monster> unitList)
        {
            view.SummonerDimensionalHoleEnergy = dimensionHoleInfo.Energy;
            Logger.log.Info($"[Dimension Hole] Dim Hole energy done");
            view.SummonerDimensionalHoleEnergyMax = dimensionHoleInfo.EnergyMax;
            Logger.log.Info($"[Dimension Hole] Dim Hole energy max done");
            view.DimensionalEnergyGainStart = DateTimeOffset.FromUnixTimeSeconds((long)dimensionHoleInfo.EnergyGainStartTimestamp).ToLocalTime().DateTime;
            Logger.log.Info($"[Dimension Hole] Dim Hole energy gain start done");
            view.DimHoleMonsters = new List<Awakening>();

            view.SummonerDimensionalHoleEnergyMaxInfo = model.DimHoleCalculateTime(view.SummonerDimensionalHoleEnergyMax, view.SummonerDimensionalHoleEnergy, view.DimensionalEnergyGainStart, false);
            Logger.log.Info($"[Dimension Hole] Dim Hole energy max INFO done");


            foreach (Monster unit in unitList)
            {
                try
                {
                    int temp = unit.AwakeningInfo.Value.AnythingArray.Count;
                }
                catch (NullReferenceException)
                {
                    view.DimHoleMonsters.Add(unit.AwakeningInfo.Value.AwakeningInfoClass);
                }
                catch (InvalidOperationException)
                {
                    throw new InvalidJSONException();
                }
            }
            Logger.log.Info($"[Dimension Hole] Dim Hole init monsters done");

            List<DimHoleRow> dimHoleRows = new List<DimHoleRow>();
            foreach (Awakening mon in view.DimHoleMonsters)
            {
                foreach (KeyValuePair<RadioButton, ushort> dimHoleLevel in view.DimHoleLevelAXP)
                {
                    if (dimHoleLevel.Key.Checked == true) { view.AxpPerLevel = dimHoleLevel.Value; break; }
                }
                ushort energyNeeded = (ushort)Math.Ceiling((decimal)(mon.MaxExp - mon.Exp) / view.AxpPerLevel);
                string dateWhen2A = model.DimHoleCalculateTime(energyNeeded, view.SummonerDimensionalHoleEnergy, view.DimensionalEnergyGainStart, true);
                dimHoleRows.Add(new DimHoleRow(Mapping.Instance.GetMonsterName((int)mon.UnitMasterId), (uint)(mon.MaxExp - mon.Exp), energyNeeded, dateWhen2A ));
            }
            view.DimHoleMonstersListView.AddObjects(dimHoleRows);
            Logger.log.Info($"[Dimension Hole] Dim Hole calculator done");
        }

        private void View_DimHoleLevelChanged(RadioButton obj)
        {
            Logger.log.Info($"[Dimension Hole] Dim Hole level changed to {obj.Name.Remove(0, 11)}");
            view.AxpPerLevel = view.DimHoleLevelAXP[obj];
            Logger.log.Info($"[Dimension Hole] Dim Hole AXP per level change done");
            List<DimHoleRow> rows = new List<DimHoleRow>();

            for (int i=0; i < view.DimHoleMonstersListView.Items.Count; i++)
            {
                List<string> item = new List<string>();
                for(int j = 0; j < view.DimHoleMonstersListView.Items[i].SubItems.Count; j++)
                {
                    if (j == 2)
                    {
                        item.Add(Math.Ceiling(decimal.Parse(item[1]) / view.AxpPerLevel).ToString());
                        continue;
                    }
                    if(j == 3)
                    {
                        item.Add(model.DimHoleCalculateTime(ushort.Parse(item[2]), view.SummonerDimensionalHoleEnergy, view.DimensionalEnergyGainStart, true));
                        continue;
                    }
                    item.Add(view.DimHoleMonstersListView.Items[i].SubItems[j].Text);
                }
                rows.Add(new DimHoleRow(item[0], uint.Parse(item[1]), ushort.Parse(item[2]), item[3]));
            }
            view.DimHoleMonstersListView.SetObjects(rows);
            Logger.log.Info($"[Dimension Hole] Dim Hole calculator done");
        }
    }
}

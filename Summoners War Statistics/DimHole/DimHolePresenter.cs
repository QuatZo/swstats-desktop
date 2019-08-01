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
        private readonly IDimHoleView view;
        private readonly Model model;

        public DimHolePresenter(IDimHoleView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.InitDimHole += View_InitDimHole;
            this.view.CanSeeDimHoleTab += View_CanSeeDimHoleTab;
            this.view.Resized += View_Resized;

            this.view.DimHoleMonstersListView.ColumnClick += DimHoleMonstersListView_ColumnClick;
            this.view.DimHoleMonstersListView.BeforeSorting += DimHoleMonstersListView_BeforeSorting;
            this.view.DimHoleLevelChanged += View_DimHoleLevelChanged;

            this.view.FloorTextChanged += View_FloorTextChanged;
        }

        private void View_CanSeeDimHoleTab()
        {
            int heightFarmFirstLevel = 40;
            int heightFarmSecondLevel = heightFarmFirstLevel + view.Cntrls[15].Size.Height + 5;
            int heightFarmThirdLevel = heightFarmSecondLevel + view.Cntrls[15].Size.Height + 5;

            int widthFarmFirstLevel = 5;

            view.Cntrls[31].Location = new Point(widthFarmFirstLevel, heightFarmThirdLevel);
            view.Cntrls[30].Location = new Point(widthFarmFirstLevel, heightFarmSecondLevel);
        }

        private void View_FloorTextChanged()
        {
            List<(int Floor, TimeSpan Time, double SuccessRate, double Ratio)> inputs = new List<(int Floor, TimeSpan Time, double SuccessRate, double Ratio)>();

            for (int i = 1; i <= 5; i++)
            {
                inputs.Add((i, view.DimHoleFloorTimes[i - 1], view.DimHoleFloorSuccessRates[i - 1], (double)Mapping.Instance.GetAxpByFloor(i) / (double)Mapping.Instance.GetAxpByFloor(5)));
            }

            Dictionary<int, double> floorsTime = new Dictionary<int, double>() { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 } };
            Dictionary<int, double> floorsSuccess = new Dictionary<int, double>() { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 } };
            foreach (var item in inputs)
            {
                if (item.SuccessRate > 1 || item.SuccessRate < 0 || item.Time.TotalSeconds == 0) { continue; }
                floorsTime[item.Floor] = item.SuccessRate * item.Ratio * item.Floor / item.Time.TotalMinutes;
                floorsSuccess[item.Floor] = item.SuccessRate * item.Ratio;
            }
            view.DimHoleFloorTime = "B" + floorsTime.Aggregate((l, r) => l.Value > r.Value ? l : r).Key.ToString();
            view.DimHoleFloorSuccess = "B" + floorsSuccess.Aggregate((l, r) => l.Value > r.Value ? l : r).Key.ToString();

        }

        private void DimHoleMonstersListView_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            if (view.DimHoleMonstersListView.PrimarySortColumn != view.DimHoleMonstersListView.SecondarySortColumn)
            {
                view.DimHoleMonstersListView.SecondarySortColumn = view.DimHoleMonstersListView.PrimarySortColumn;
            }
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
            //labelTextB1                           - 15
            //maskedTextBoxTimeB1                   - 16
            //maskedTextBoxSuccessRateB1            - 17
            //labelTextB2                           - 18
            //maskedTextBoxTimeB2                   - 19
            //maskedTextBoxSuccessRateB2            - 20
            //labelTextB3                           - 21
            //maskedTextBoxTimeB3                   - 22
            //maskedTextBoxSuccessRateB3            - 23
            //labelTextB4                           - 24
            //maskedTextBoxTimeB4                   - 25
            //maskedTextBoxSuccessRateB4            - 26
            //labelTextB5                           - 27
            //maskedTextBoxTimeB5                   - 28
            //maskedTextBoxSuccessRateB5            - 29
            //labelTextTime                         - 30
            //labelTextSuccessRate                  - 31
            //labelTextFarm                         - 32
            //labelDimHoleFarmTime                  - 33
            //labelDimHoleFarmSuccess               - 34
            //panelFarm                             - 35
            //panelFarmRight                        - 36
            try
            {
                view.Cntrls[3].Location = new Point(view.SizeWindow.Width - 5 - view.Cntrls[3].Size.Width, view.Cntrls[1].Location.Y);

                int heightFarmFirstLevel = 40;
                int heightFarmSecondLevel = heightFarmFirstLevel + view.Cntrls[15].Size.Height + 5;
                int heightFarmThirdLevel = heightFarmSecondLevel + view.Cntrls[15].Size.Height + 5;

                int widthFarmSEcondLevel = (view.SizeWindow.Width - view.Cntrls[36].Size.Width) * 1 / 6;
                int widthFarmThirdLevel = (view.SizeWindow.Width - view.Cntrls[36].Size.Width) * 2 / 6;
                int widthFarmFourthLevel = (view.SizeWindow.Width - view.Cntrls[36].Size.Width) * 3 / 6;
                int widthFarmFifthLevel = (view.SizeWindow.Width - view.Cntrls[36].Size.Width) * 4 / 6;
                int widthFarmSixthLevel = (view.SizeWindow.Width - view.Cntrls[36].Size.Width) * 5 / 6;

                int mid = view.Cntrls[16].Size.Width / 2 - view.Cntrls[15].Size.Width / 2;
                view.Cntrls[15].Location = new Point(widthFarmSEcondLevel + mid, heightFarmFirstLevel);
                view.Cntrls[16].Location = new Point(widthFarmSEcondLevel, heightFarmSecondLevel);
                view.Cntrls[17].Location = new Point(widthFarmSEcondLevel, heightFarmThirdLevel);

                view.Cntrls[18].Location = new Point(widthFarmThirdLevel + mid, heightFarmFirstLevel);
                view.Cntrls[19].Location = new Point(widthFarmThirdLevel, heightFarmSecondLevel);
                view.Cntrls[20].Location = new Point(widthFarmThirdLevel, heightFarmThirdLevel);

                view.Cntrls[21].Location = new Point(widthFarmFourthLevel + mid, heightFarmFirstLevel);
                view.Cntrls[22].Location = new Point(widthFarmFourthLevel, heightFarmSecondLevel);
                view.Cntrls[23].Location = new Point(widthFarmFourthLevel, heightFarmThirdLevel);

                view.Cntrls[24].Location = new Point(widthFarmFifthLevel + mid, heightFarmFirstLevel);
                view.Cntrls[25].Location = new Point(widthFarmFifthLevel, heightFarmSecondLevel);
                view.Cntrls[26].Location = new Point(widthFarmFifthLevel, heightFarmThirdLevel);

                view.Cntrls[27].Location = new Point(widthFarmSixthLevel + mid, heightFarmFirstLevel);
                view.Cntrls[28].Location = new Point(widthFarmSixthLevel, heightFarmSecondLevel);
                view.Cntrls[29].Location = new Point(widthFarmSixthLevel, heightFarmThirdLevel);

                Size maskedTextBoxSize = new Size(view.Cntrls[22].Location.X - view.Cntrls[19].Location.X - 15, view.Cntrls[19].Size.Height);

                foreach (var i in new int[16, 17, 19, 20, 22, 23, 25, 26, 28, 29])
                {
                    view.Cntrls[i].Size = maskedTextBoxSize;
                }

                view.DimHoleMonstersListView.BeginUpdate();
                int columnWidth = view.DimHoleMonstersListView.Size.Width / view.DimHoleMonstersListView.Columns.Count;
                foreach (ColumnHeader column in view.DimHoleMonstersListView.Columns)
                {
                    column.Width = columnWidth - 5;
                }
                view.DimHoleMonstersListView.EndUpdate();
            }
            catch (OutOfMemoryException)
            {
                Logger.log.Error("[Dimension Hole] Out of memory exception!");
            }
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
            view.Cntrls[3].Location = new Point(view.SizeWindow.Width - 5 - view.Cntrls[3].Size.Width, view.Cntrls[1].Location.Y);

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

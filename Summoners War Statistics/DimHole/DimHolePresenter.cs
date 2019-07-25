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

            this.view.Resized += View_Resized;
        }

        private void View_Resized()
        {
            //labelDimHoleMonsters                  - 0
            //labelDimensionalHoleEnergy            - 1
            //labelDimensionalHoleEnergyMax         - 2
            //labelDimensionalHoleEnergyMaxInfo     - 3
            //labelDimensionalHoleEnergySlash       - 4
            //labelDimHoleEnergy                    - 5 
            //listView1                             - 6
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

        private void DimHoleMonstersListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            view.DimHoleMonstersListView.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void View_InitDimHole(DimensionHoleInfo dimensionHoleInfo, List<Monster> unitList)
        {
            view.SummonerDimensionalHoleEnergy = dimensionHoleInfo.Energy;
            view.SummonerDimensionalHoleEnergyMax = dimensionHoleInfo.EnergyMax;
            view.DimensionalEnergyGainStart = DateTimeOffset.FromUnixTimeSeconds((long)dimensionHoleInfo.EnergyGainStartTimestamp).ToLocalTime().DateTime;
            view.DimHoleMonsters = new List<Awakening>();

            view.SummonerDimensionalHoleEnergyMaxInfo = model.DimHoleCalculateTime(view.SummonerDimensionalHoleEnergyMax, view.SummonerDimensionalHoleEnergy, view.DimensionalEnergyGainStart, false);


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


            foreach (Awakening mon in view.DimHoleMonsters)
            {
                foreach (KeyValuePair<RadioButton, ushort> dimHoleLevel in view.DimHoleLevelAXP)
                {
                    if (dimHoleLevel.Key.Checked == true) { view.AxpPerLevel = dimHoleLevel.Value; break; }
                }
                ushort energyNeeded = (ushort)Math.Ceiling((decimal)(mon.MaxExp - mon.Exp) / view.AxpPerLevel);
                string dateWhen2A = model.DimHoleCalculateTime(energyNeeded, view.SummonerDimensionalHoleEnergy, view.DimensionalEnergyGainStart, true);
                string[] str = { Mapping.Instance.GetMonsterName((int)mon.UnitMasterId), (mon.MaxExp - mon.Exp).ToString(), energyNeeded.ToString(), dateWhen2A };
                view.DimHoleMonstersListView.Items.Add(new ListViewItem(str));
            }
        }

        private void View_DimHoleLevelChanged(RadioButton obj)
        {
            view.AxpPerLevel = view.DimHoleLevelAXP[obj];

            for(int i=0; i < view.DimHoleMonstersListView.Items.Count; i++)
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
                view.DimHoleMonstersListView.Items[i] = new ListViewItem(item.ToArray());
            }
        }
    }
}

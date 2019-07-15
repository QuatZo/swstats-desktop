using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void View_DimHoleLevelChanged(RadioButton obj)
        {
            view.AxpPerLevel = view.DimHoleLevelAXP[obj];

            for(int i=0; i < view.DimHoleList.Items.Count; i++)
            {
                List<string> item = new List<string>();
                for(int j = 0; j < view.DimHoleList.Items[i].SubItems.Count; j++)
                {
                    if (j == 2)
                    {
                        item.Add(Math.Ceiling(decimal.Parse(item[1]) / view.AxpPerLevel).ToString());
                        continue;
                    }
                    if(j == 3)
                    {
                        item.Add(model.DimHoleCalculateTimeNeededFor2A(ushort.Parse(item[2]), view.SummonerDimensionalHoleEnergy, view.DimensionalEnergyGainStart));
                        continue;
                    }
                    item.Add(view.DimHoleList.Items[i].SubItems[j].Text);
                }
                view.DimHoleList.Items[i] = new ListViewItem(item.ToArray());
            }
        }
    }
}

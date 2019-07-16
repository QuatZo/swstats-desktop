using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public interface IDimHoleView
    {
        #region Properties
        ushort AxpPerLevel { get; set; }
        byte SummonerDimensionalHoleEnergy { get; set; }
        byte SummonerDimensionalHoleEnergyMax { get; set; }
        string SummonerDimensionalHoleEnergyMaxInfo { get; set; }
        Dictionary<RadioButton, ushort> DimHoleLevelAXP { get; }
        ListView DimHoleMonstersListView { get; set; }
        DateTime DimensionalEnergyGainStart { get; set; }
        List<AwakeningInfoClass> DimHoleMonsters { get; set; }
        #endregion

        #region Events
        event Action<DimensionHoleInfo, List<PurpleUnitList>> InitDimHole;
        event Action<RadioButton> DimHoleLevelChanged;
        #endregion

        #region Methods
        void Init(DimensionHoleInfo dimensionHoleInfo, List<PurpleUnitList> unitList);
        #endregion
    }
}

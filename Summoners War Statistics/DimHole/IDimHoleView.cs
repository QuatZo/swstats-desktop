using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public interface IDimHoleView
    {
        #region Properties
        Size SizeWindow { get; set; }
        List<Control> Cntrls { get; }
        ushort AxpPerLevel { get; set; }
        byte SummonerDimensionalHoleEnergy { get; set; }
        byte SummonerDimensionalHoleEnergyMax { get; set; }
        string SummonerDimensionalHoleEnergyMaxInfo { get; set; }
        Dictionary<RadioButton, ushort> DimHoleLevelAXP { get; }
        ObjectListView DimHoleMonstersListView { get; set; }
        DateTime DimensionalEnergyGainStart { get; set; }
        List<Awakening> DimHoleMonsters { get; set; }
        List<TimeSpan> DimHoleFloorTimes { get; }
        List<double> DimHoleFloorSuccessRates { get; }
        string DimHoleFloorTime { set; }
        string DimHoleFloorSuccess { set; }

        #endregion

        #region Events
        event Action<DimensionHoleInfo, List<Monster>> InitDimHole;
        event Action<RadioButton> DimHoleLevelChanged;
        event Action Resized;
        event Action FloorTextChanged;
        #endregion

        #region Methods
        void Init(DimensionHoleInfo dimensionHoleInfo, List<Monster> unitList);
        void Front();
        #endregion
    }
}

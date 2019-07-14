using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public interface IDimHoleView
    {
        #region Properties
        byte SummonerDimensionalHoleEnergy { get; set; }
        byte SummonerDimensionalHoleEnergyMax { get; set; }
        #endregion

        #region Methods
        void Init(DimensionHoleInfo dimensionHoleInfo, List<PurpleUnitList> unitList);
        #endregion
    }
}

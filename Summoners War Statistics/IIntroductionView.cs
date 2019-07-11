using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public interface IIntroductionView
    {
        #region Properties
        string SummonerName { get; set; }
        byte SummonerLevel { get; set; }
        ulong SummonerMana { get; set; }
        uint SummonerCrystals { get; set; }
        byte SummonerEnergy { get; set; }
        byte SummonerEnergyMax { get; set; }
        byte SummonerArenaEnergy { get; set; }
        byte SummonerArenaEnergyMax { get; set; }
        uint SummonerGloryPoints { get; set; }
        uint SummonerGuildPoints { get; set; }
        byte SummonerDimensionalCrystals { get; set; }
        byte SummonerDimensionalCrystalsMax { get; set; }
        ushort SummonerShapeshiftingStones { get; set; }
        uint SummonerRTAMedals { get; set; }
        byte SummonerDimensionalHoleEnergy { get; set; }
        byte SummonerDimensionalHoleEnergyMax { get; set; }
        #endregion

        #region Events
        #endregion

        #region Methods
        #endregion
    }
}

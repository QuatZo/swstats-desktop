using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public interface ISummaryView
    {
        #region Properties
        Image SummonerCountry { get; set; }
        Image SummonerLanguage { get; set; }

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
        ushort SummonerMonstersAmount { get; set; }
        ushort SummonerMonstersLocked { get; set; }

        ushort SummonerRunes { get; set; }
        ushort SummonerRunesLocked { get; set; }
        #endregion

        #region Events
        #endregion

        #region Methods
        void Init(WizardInfo wizardInfo, DimensionHoleInfo dimensionHoleInfo, List<PurpleUnitList> monstersList, List<long> monstersLockedList, List<Rune> runes);
        #endregion
    }
}

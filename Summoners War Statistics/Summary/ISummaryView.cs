using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public interface ISummaryView
    {
        #region Properties
        List<Control> ControlsSummary { get; }

        Image SummonerCountry { get; set; }
        Image SummonerLastCountry { get; set; }
        Image SummonerLastLanguage { get; set; }

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

        ushort SummonerSocialPoints { get; set; }
        ushort SummonerAncientCoins { get; set; }

        string JsonModifcationDate { get; set; }
        #endregion

        #region Events
        event Action<Summoner, DimensionHoleInfo, List<Monster>, List<long>, List<Rune>, DateTime, string> InitSummary;
        event Action Resized;
        #endregion

        #region Methods
        void Init(Summoner wizardInfo, DimensionHoleInfo dimensionHoleInfo, List<Monster> monstersList, List<long> monstersLockedList, List<Rune> runes, DateTime jsonModificationTime, string country);
        void Front();
        #endregion
    }
}

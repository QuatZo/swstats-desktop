using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public interface IRunesView
    {
        #region Properties
        List<Control> Cntrls { get; }
        byte ChosenRuneSet { get; }
        byte ChosenRuneMainstat { get; }
        byte ChosenRuneQuality { get; }
        byte ChosenRuneSlot { get; }
        byte ChosenRuneUpgrade { get; }
        byte ChosenRuneUpgradeStatement { get; }
        byte ChosenRuneEfficiency { get; }
        byte ChosenRuneEfficiencyStatement { get; }


        ushort RunesAmount { get; set; }
        ushort RunesMaxed { get; set; }
        ushort RunesInventory { get; set; }
        double RunesEfficiencyMin { get; set; }
        double RunesEfficiencyMax { get; set; }
        double RunesEfficiencyMean { get; set; }
        double RunesEfficiencyMedian { get; set; }
        double RunesEfficiencyStandardDeviation { get; set; }


        ObjectListView RunesListView { get; set; }

        List<Rune> RunesList { get; set; }
        Dictionary<long, int> MonstersMasterId { get; set; }
        #endregion

        #region Events
        event Action InitRunes;
        event Action Resized;
        #endregion

        #region Methods
        void Init(List<Rune> runes, Dictionary<long, int> monstersMasterId);
        void Front();
        #endregion
    }
}

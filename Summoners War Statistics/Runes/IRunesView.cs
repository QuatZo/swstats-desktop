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
    public interface IRunesView
    {
        #region Properties
        Size SizeWindow { get; }

        List<Control> Cntrls { get; }
        byte ChosenRuneSet { get; }
        byte ChosenRuneStars { get; }
        byte ChosenRuneStarsStatement { get; }
        byte ChosenRuneMainstat { get; }
        byte ChosenRuneInnate { get; }
        byte ChosenRuneQuality { get; }
        byte ChosenRuneOriginQuality { get; }
        byte ChosenRuneSlot { get; }
        byte ChosenRuneAncient { get; }
        byte ChosenRuneUpgrade { get; }
        byte ChosenRuneUpgradeStatement { get; }
        byte ChosenRuneEfficiency { get; }
        byte ChosenRuneEfficiencyStatement { get; }
        byte ChosenRuneSubstat1 { get; }
        byte ChosenRuneSubstat1Statement { get; }
        byte ChosenRuneSubstat2 { get; }
        byte ChosenRuneSubstat2Statement { get; }
        byte ChosenRuneSubstat3 { get; }
        byte ChosenRuneSubstat3Statement { get; }
        byte ChosenRuneSubstat4 { get; }
        byte ChosenRuneSubstat4Statement { get; }


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
        event Action CanSeeRunesTab;
        #endregion

        #region Methods
        void Init(List<Rune> runes, Dictionary<long, int> monstersMasterId);
        void Front();
        void ResetOnFail();
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public interface IMonstersView
    {

        #region Properties
        int MonsterStarsChecked { get; }

        ushort MonsterAttributeWater { get; set; }
        ushort MonsterAttributeFire { get; set; }
        ushort MonsterAttributeWind { get; set; }
        ushort MonsterAttributeLight { get; set; }
        ushort MonsterAttributeDark { get; set; }

        ushort MonsterStarsSix { get; set; }
        ushort MonsterStarsFive { get; set; }
        ushort MonsterStarsFour { get; set; }
        ushort MonsterStarsThree { get; set; }
        ushort MonsterStarsTwo { get; set; }
        ushort MonsterStarsOne { get; set; }

        ushort MonstersNat5Amount { get; set; }
        ushort MonstersLDNat4PlusAmount { get; set; }
        ushort DaysSinceNat5 { get; set; }
        ushort DaysSinceLastLDLightning { get; set; }

        List<Monster> MonstersList { get; set; }
        List<long> MonstersLocked { get; set; }

        ListView MonstersListView { get; set; }
        #endregion

        #region Events
        event Action<List<Monster>, List<long>> InitMonsters;
        event Action<RadioButton> MonstersStarsChanged;
        #endregion

        #region Methods
        void Init(List<Monster> monsters, List<long> monstersLocked);
        void ResetMonstersStats();
        #endregion
    }
}

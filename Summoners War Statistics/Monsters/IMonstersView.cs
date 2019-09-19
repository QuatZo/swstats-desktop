using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using BrightIdeasSoftware;

namespace Summoners_War_Statistics
{
    public interface IMonstersView
    {
        #region Properties
        Size SizeWindow { get; }
        List<Control> Cntrls { get; }

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
        List<Monster> MonstersListAffectedByCollection { get; set; }
        List<long> MonstersLocked { get; set; }

        FlowLayoutPanel MonstersListView { get; set; }

        List<int> MonstersCollectionCheckedStars { get;}
        List<string> MonstersCollectionCheckedAttributes { get; }
        int MonstersCollectionSummoner { get; set; }
        int MonstersCollectionWhole { get; set; }

        string MonstersListHeader { set; }
        #endregion

        #region Events
        event Action<List<long>> InitMonsters;
        event Action Resized;
        event Action CanSeeMonstersTab;
        event Action MonstersCollectionItemChecked;
        #endregion

        #region Methods
        void Init(List<Monster> monsters, List<long> monstersLocked);
        void ResetMonstersStats();
        void Front();
        void ResetOnFail();
        void Monsters_Resize(object sender, EventArgs e);
        void SetInfoOnHover(Control control, string info);
        #endregion
    }
}

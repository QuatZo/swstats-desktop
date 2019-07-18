﻿using System;
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

        List<PurpleUnitList> MonstersList { get; set; }
        List<long> MonstersLocked { get; set; }

        ListView MonstersListView { get; set; }
        #endregion

        #region Events
        event Action<List<PurpleUnitList>, List<long>> InitMonsters;
        event Action<RadioButton> MonstersStarsChanged;
        #endregion

        #region Methods
        void Init(List<PurpleUnitList> monsters, List<long> monstersLocked);
        void ResetMonstersStats();
        #endregion
    }
}

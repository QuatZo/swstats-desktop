using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public partial class Monsters : UserControl, IMonstersView
    {
        #region Properties
        public ushort MonsterAttributeWater
        {
            get => ushort.Parse(labelWater.Text);
            set => labelWater.Text = value.ToString();
        }
        public ushort MonsterAttributeFire
        {
            get => ushort.Parse(labelFire.Text);
            set => labelFire.Text = value.ToString();
        }
        public ushort MonsterAttributeWind
        {
            get => ushort.Parse(labelWind.Text);
            set => labelWind.Text = value.ToString();
        }
        public ushort MonsterAttributeLight
        {
            get => ushort.Parse(labelLight.Text);
            set => labelLight.Text = value.ToString();
        }
        public ushort MonsterAttributeDark
        {
            get => ushort.Parse(labelDark.Text);
            set => labelDark.Text = value.ToString();
        }

        public ushort MonsterStarsSix
        {
            get => ushort.Parse(labelStarsSixAmount.Text);
            set => labelStarsSixAmount.Text = value.ToString();
        }
        public ushort MonsterStarsFive
        {
            get => ushort.Parse(labelStarsFiveAmount.Text);
            set => labelStarsFiveAmount.Text = value.ToString();
        }
        public ushort MonsterStarsFour
        {
            get => ushort.Parse(labelStarsFourAmount.Text);
            set => labelStarsFourAmount.Text = value.ToString();
        }
        public ushort MonsterStarsThree
        {
            get => ushort.Parse(labelStarsThreeAmount.Text);
            set => labelStarsThreeAmount.Text = value.ToString();
        }
        public ushort MonsterStarsTwo
        {
            get => ushort.Parse(labelStarsTwoAmount.Text);
            set => labelStarsTwoAmount.Text = value.ToString();
        }
        public ushort MonsterStarsOne
        {
            get => ushort.Parse(labelStarsOneAmount.Text);
            set => labelStarsOneAmount.Text = value.ToString();
        }

        public ListView MonstersListView
        {
            get => listViewMonstersToLock;
            set => listViewMonstersToLock = value;
        }
        #endregion

        #region Events
        public event Action<List<PurpleUnitList>, List<long>> InitMonsters;
        #endregion

        public Monsters()
        {
            InitializeComponent();
        }

        #region Methods
        public void Init(List<PurpleUnitList> monsters, List<long> monstersLocked)
        {
            InitMonsters?.Invoke(monsters, monstersLocked);
        }

        public void ResetMonstersStats()
        {
            MonsterAttributeWater = 0;
            MonsterAttributeFire = 0;
            MonsterAttributeWind = 0;
            MonsterAttributeLight = 0;
            MonsterAttributeDark = 0;

            MonsterStarsSix = 0;
            MonsterStarsFive = 0;
            MonsterStarsFour = 0;
            MonsterStarsThree = 0;
            MonsterStarsTwo = 0;
            MonsterStarsOne = 0;
        }
        #endregion
    }
}

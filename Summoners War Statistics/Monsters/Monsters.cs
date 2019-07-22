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
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Control> ControlsMonster => new List<Control>()
                {
                    label1,
                    label2,
                    labelDark,
                    labelDaysLDLightning,
                    labelDaysNat5,
                    labelFire,
                    labelLDNat4Plus,
                    labelLight,
                    labelMonsters,
                    labelMonsterStats,
                    labelNat5,
                    labelStarsFiveAmount,
                    labelStarsFourAmount,
                    labelStarsOneAmount,
                    labelStarsSixAmount,
                    labelStarsThreeAmount,
                    labelStarsTwoAmount,
                    labelWater,
                    labelWind,
                    listViewMonstersToLock,
                    radioButton5,
                    radioButton6
                };

        public int MonsterStarsChecked
        {
            get
            {
                if (radioButton5.Checked) { return 5; }
                else { return 6; }
            }
        }

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

        public ushort MonstersNat5Amount
        {
            get => ushort.Parse(labelNat5.Text);
            set => labelNat5.Text = value.ToString();
        }
        public ushort MonstersLDNat4PlusAmount
        {
            get => ushort.Parse(labelLDNat4Plus.Text);
            set => labelLDNat4Plus.Text = value.ToString();
        }
        public ushort DaysSinceNat5
        {
            get
            {
                try
                {
                    return ushort.Parse(labelDaysNat5.Text.Remove(labelDaysNat5.Text.Length - 6));
                }
                catch (FormatException) { return 0; }
            }
            set => labelDaysNat5.Text = value.ToString() + " days";
        }
        public ushort DaysSinceLastLDLightning
        {
            get
            {
                try
                {
                    return ushort.Parse(labelDaysLDLightning.Text.Remove(labelDaysLDLightning.Text.Length - 6));
                }
                catch (FormatException) { return 0; }
            }
            set => labelDaysLDLightning.Text = value.ToString() + " days";
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Monster> MonstersList { get; set; } = new List<Monster>();
        public List<long> MonstersLocked { get; set; } = new List<long>();

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ListView MonstersListView
        {
            get => listViewMonstersToLock;
            set => listViewMonstersToLock = value;
        }
        #endregion

        #region Events
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public event Action<List<Monster>, List<long>> InitMonsters;
        public event Action<RadioButton> MonstersStarsChanged;
        #endregion

        public Monsters()
        {
            InitializeComponent();
        }

        #region Methods
        public void Init(List<Monster> monsters, List<long> monstersLocked)
        {
            InitMonsters?.Invoke(monsters, monstersLocked);
        }
        private void radioButton_Click(object sender, EventArgs e)
        {
            MonstersStarsChanged?.Invoke((RadioButton)sender);
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

            MonstersNat5Amount = 0;
            MonstersLDNat4PlusAmount = 0;
            DaysSinceNat5 = 0;
            DaysSinceLastLDLightning = 0;
        }
        public void Front()
        {
            BringToFront();
        }
        #endregion
    }
}

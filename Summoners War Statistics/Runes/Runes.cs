using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace Summoners_War_Statistics
{
    public partial class Runes : UserControl, IRunesView
    {
        #region Properties
        public Size SizeWindow => Size;
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Control> Cntrls => new List<Control>()
        {
            labelRunes,
            labelRuneEfficiency,
            labelRuneMainstat,
            labelRuneQuality,
            labelRunesAmount,
            labelRunesEfficiencyHigh,
            labelRunesEfficiencyLow,
            labelRunesEfficiencyMean,
            labelRunesEfficiencyMedian,
            labelRuneSet,
            labelRunesInventory,
            labelRuneSlot,
            labelRunesMaxed,
            labelRunesStandardDeviation,
            labelTextAmount,
            labelTextEfficiencyLow,
            labelTextEfficiencyHigh,
            labelTextInventory,
            labelTextMaxed,
            labelTextEfficiencyMean,
            labelTextEfficiencyMedian,
            labelTextStandardDeviation,
            labelUpgrade,
            objectListViewRunes,
            comboBoxRuneEfficiency,
            comboBoxRuneEfficiencyIf,
            comboBoxRuneMainstat,
            comboBoxRuneQuality,
            comboBoxRuneSet,
            comboBoxRuneSlot,
            comboBoxRuneUpgrade,
            comboBoxRuneUpgradeIf,
            panelHeader,
            panelTable,
            panelFooter,
            labelRuneOriginalQuality,
            comboBoxRuneOriginalQuality,
            flowLayoutPanelFilters,
            labelRuneInnate,
            comboBoxRuneInnate,
            labelRuneSubstat1,
            comboBoxRuneSubstat1,
            comboBoxRuneSubstat1YesNo,
            labelRuneSubstat2,
            comboBoxRuneSubstat2,
            comboBoxRuneSubstat2YesNo,
            labelRuneSubstat3,
            comboBoxRuneSubstat3,
            comboBoxRuneSubstat3YesNo,
            labelRuneSubstat4,
            comboBoxRuneSubstat4,
            comboBoxRuneSubstat4YesNo
        };

        public byte ChosenRuneSet
        {
            get
            {
                try
                {
                    return byte.Parse(comboBoxRuneSet.SelectedValue.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }
        public byte ChosenRuneStars
        {
            get
            {
                try
                {
                    if (int.Parse(comboBoxRuneStars.SelectedItem.ToString()) < 0) { return 0; }
                    return byte.Parse(comboBoxRuneStars.SelectedItem.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }
        public byte ChosenRuneStarsStatement
        {
            get
            {
                if (comboBoxRuneStarsIf.SelectedIndex < 0) { return 2; } // >=
                return (byte)comboBoxRuneStarsIf.SelectedIndex;
            }
        }
        public byte ChosenRuneMainstat
        {
            get
            {
                try
                {
                    return byte.Parse(comboBoxRuneMainstat.SelectedValue.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }
        public byte ChosenRuneInnate
        {
            get
            {
                try
                {
                    return byte.Parse(comboBoxRuneInnate.SelectedValue.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }
        public byte ChosenRuneQuality
        {
            get
            {
                try
                {
                    return byte.Parse(comboBoxRuneQuality.SelectedValue.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }
        public byte ChosenRuneOriginQuality
        {
            get
            {
                try
                {
                    return byte.Parse(comboBoxRuneOriginalQuality.SelectedValue.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }
        
        public byte ChosenRuneSlot
        {
            get
            {
                if(comboBoxRuneSlot.SelectedIndex < 0) { return 0; }
                return (byte)comboBoxRuneSlot.SelectedIndex;
            }
        }
        public byte ChosenRuneUpgrade
        {
            get
            {
                try
                {
                    if (int.Parse(comboBoxRuneUpgrade.SelectedItem.ToString()) < 0) { return 0; }
                    return byte.Parse(comboBoxRuneUpgrade.SelectedItem.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }
        public byte ChosenRuneUpgradeStatement
        {
            get
            {
                if (comboBoxRuneUpgradeIf.SelectedIndex < 0) { return 2; } // >=
                return (byte)comboBoxRuneUpgradeIf.SelectedIndex;
            }
        }
        public byte ChosenRuneEfficiency
        {
            get
            {
                try
                {
                    if (int.Parse(comboBoxRuneEfficiency.SelectedItem.ToString()) < 0) { return 0; }
                    return byte.Parse(comboBoxRuneEfficiency.SelectedItem.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }
        public byte ChosenRuneEfficiencyStatement
        {
            get
            {
                if (comboBoxRuneEfficiencyIf.SelectedIndex < 0) { return 2; } // >=
                return (byte)comboBoxRuneEfficiencyIf.SelectedIndex;
            }
        }

        public byte ChosenRuneSubstat1
        {
            get
            {
                try
                {
                    return byte.Parse(comboBoxRuneSubstat1.SelectedValue.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }
        public byte ChosenRuneSubstat1Statement
        {
            get
            {
                if (comboBoxRuneSubstat1YesNo.SelectedIndex != 0) { return 1; } // Yes
                return 0;
            }
        }
        public byte ChosenRuneSubstat2
        {
            get
            {
                try
                {
                    return byte.Parse(comboBoxRuneSubstat2.SelectedValue.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }
        public byte ChosenRuneSubstat2Statement
        {
            get
            {
                if (comboBoxRuneSubstat2YesNo.SelectedIndex != 0) { return 1; } // Yes
                return 0;
            }
        }
        public byte ChosenRuneSubstat3
        {
            get
            {
                try
                {
                    return byte.Parse(comboBoxRuneSubstat3.SelectedValue.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }
        public byte ChosenRuneSubstat3Statement
        {
            get
            {
                if (comboBoxRuneSubstat3YesNo.SelectedIndex != 0) { return 1; } // Yes
                return 0;
            }
        }
        public byte ChosenRuneSubstat4
        {
            get
            {
                try
                {
                    return byte.Parse(comboBoxRuneSubstat4.SelectedValue.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }
        public byte ChosenRuneSubstat4Statement
        {
            get
            {
                if (comboBoxRuneSubstat4YesNo.SelectedIndex != 0) { return 1; } // Yes
                return 0;
            }
        }

        public ushort RunesAmount
        {
            get => ushort.Parse(labelRunesAmount.Text);
            set => labelRunesAmount.Text = value.ToString();
        }
        public ushort RunesMaxed
        {
            get => ushort.Parse(labelRunesMaxed.Text);
            set => labelRunesMaxed.Text = value.ToString();
        }
        public ushort RunesInventory
        {
            get => ushort.Parse(labelRunesInventory.Text);
            set => labelRunesInventory.Text = value.ToString();
        }
        public double RunesEfficiencyMin
        {
            get
            {
                if (labelRunesEfficiencyLow.Text.Contains("%"))
                {
                    return double.Parse(labelRunesEfficiencyLow.Text.Remove(labelRunesEfficiencyLow.Text.Length - 1));
                }
                return double.Parse(labelRunesEfficiencyLow.Text);
            }
            set => labelRunesEfficiencyLow.Text = value.ToString() + "%";
        }
        public double RunesEfficiencyMax
        {
            get
            {
                if (labelRunesEfficiencyHigh.Text.Contains("%"))
                {
                    return double.Parse(labelRunesEfficiencyHigh.Text.Remove(labelRunesEfficiencyHigh.Text.Length - 1));
                }
                return double.Parse(labelRunesEfficiencyHigh.Text);
            }
            set => labelRunesEfficiencyHigh.Text = value.ToString() + "%";
        }
        public double RunesEfficiencyMean
        {
            get
            {
                if (labelRunesEfficiencyMean.Text.Contains("%"))
                {
                    return double.Parse(labelRunesEfficiencyMean.Text.Remove(labelRunesEfficiencyMean.Text.Length - 1));
                }
                return double.Parse(labelRunesEfficiencyMean.Text);
            }
            set => labelRunesEfficiencyMean.Text = value.ToString() + "%";
        }
        public double RunesEfficiencyMedian
        {
            get
            {
                if (labelRunesEfficiencyMedian.Text.Contains("%"))
                {
                    return double.Parse(labelRunesEfficiencyMedian.Text.Remove(labelRunesEfficiencyMedian.Text.Length - 1));
                }
                return double.Parse(labelRunesEfficiencyMedian.Text);
            }
            set => labelRunesEfficiencyMedian.Text = value.ToString() + "%";
        }
        public double RunesEfficiencyStandardDeviation
        {
            get
            {
                if (labelRunesStandardDeviation.Text.Contains("%"))
                {
                    return double.Parse(labelRunesStandardDeviation.Text.Remove(labelRunesStandardDeviation.Text.Length - 1));
                }
                return double.Parse(labelRunesStandardDeviation.Text);
            }
            set => labelRunesStandardDeviation.Text = value.ToString() + "%";
        }

        public ObjectListView RunesListView
        {
            get => objectListViewRunes;
            set => objectListViewRunes = value;
        }

        #region RunesList & MonstersMasterId (no physical field in designer)
        public List<Rune> RunesList { get; set; }
        public Dictionary<long, int> MonstersMasterId { get; set; }
        #endregion
        #endregion

        #region Events
        public event Action InitRunes;
        public event Action Resized;
        public event Action CanSeeRunesTab;
        #endregion
        
        public Runes()
        {
            InitializeComponent();

            objectListViewRunes.DoubleBuffering(true);
        }

        #region Methods
        private void InitComboBoxes()
        {
            Dictionary<int, string> runeSets = Mapping.Instance.GetAllRuneSets(); // rune sets
            if (!runeSets.ContainsKey(0)) { runeSets.Add(0, "All"); }
            runeSets = runeSets.OrderBy(x => x.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            comboBoxRuneSet.DataSource = new BindingSource(runeSets, null);
            comboBoxRuneSet.DisplayMember = "Value";
            comboBoxRuneSet.ValueMember = "Key";

            Dictionary<int, string> runeEffectTypes = Mapping.Instance.GetAllRuneEffectTypes(); // rune mainstats
            if (!runeEffectTypes.ContainsKey(0)) { runeEffectTypes.Add(0, "All"); }
            runeEffectTypes = runeEffectTypes.OrderBy(x => x.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            comboBoxRuneMainstat.DataSource = new BindingSource(runeEffectTypes, null);
            comboBoxRuneMainstat.DisplayMember = "Value";
            comboBoxRuneMainstat.ValueMember = "Key";
            comboBoxRuneSubstat1.DataSource = new BindingSource(runeEffectTypes, null); // rune substats
            comboBoxRuneSubstat1.DisplayMember = "Value";
            comboBoxRuneSubstat1.ValueMember = "Key";
            comboBoxRuneSubstat2.DataSource = new BindingSource(runeEffectTypes, null); // rune substats
            comboBoxRuneSubstat2.DisplayMember = "Value";
            comboBoxRuneSubstat2.ValueMember = "Key";
            comboBoxRuneSubstat3.DataSource = new BindingSource(runeEffectTypes, null); // rune substats
            comboBoxRuneSubstat3.DisplayMember = "Value";
            comboBoxRuneSubstat3.ValueMember = "Key";
            comboBoxRuneSubstat4.DataSource = new BindingSource(runeEffectTypes, null); // rune substats
            comboBoxRuneSubstat4.DisplayMember = "Value";
            comboBoxRuneSubstat4.ValueMember = "Key";
            if (!runeEffectTypes.ContainsKey(98)) { runeEffectTypes.Add(98, "Any"); } // rune innate
            if (!runeEffectTypes.ContainsKey(99)) { runeEffectTypes.Add(99, "None"); }
            runeEffectTypes = runeEffectTypes.OrderBy(x => x.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            comboBoxRuneInnate.DataSource = new BindingSource(runeEffectTypes, null); 
            comboBoxRuneInnate.DisplayMember = "Value";
            comboBoxRuneInnate.ValueMember = "Key";

            Dictionary<int, string> runeQualities = Mapping.Instance.GetAllRuneQuailities(); // rune quality (with ancient)
            if (!runeQualities.ContainsKey(0)) { runeQualities.Add(0, "All"); }
            runeQualities = runeQualities.OrderBy(x => x.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            comboBoxRuneQuality.DataSource = new BindingSource(runeQualities, null);
            comboBoxRuneQuality.DisplayMember = "Value";
            comboBoxRuneQuality.ValueMember = "Key";
            comboBoxRuneOriginalQuality.DataSource = new BindingSource(runeQualities, null);
            comboBoxRuneOriginalQuality.DisplayMember = "Value";
            comboBoxRuneOriginalQuality.ValueMember = "Key";

            comboBoxRuneSlot.SelectedIndex = 0;
            comboBoxRuneStars.SelectedIndex = 0;
            comboBoxRuneStarsIf.SelectedIndex = 2;
            comboBoxRuneUpgrade.SelectedIndex = 0;
            comboBoxRuneUpgradeIf.SelectedIndex = 2;
            comboBoxRuneEfficiency.SelectedIndex = 0;
            comboBoxRuneEfficiencyIf.SelectedIndex = 2;

            comboBoxRuneSubstat1YesNo.SelectedIndex = 1;
            comboBoxRuneSubstat2YesNo.SelectedIndex = 1;
            comboBoxRuneSubstat3YesNo.SelectedIndex = 1;
            comboBoxRuneSubstat4YesNo.SelectedIndex = 1;
        }
        public void Init(List<Rune> runes, Dictionary<long, int> monstersMasterId)
        {
            RunesList = runes;
            MonstersMasterId = monstersMasterId;
            InitComboBoxes();
            InitRunes?.Invoke();
        }
        public void Front()
        {
            BringToFront();
        }
        public void ResetOnFail()
        {
            objectListViewRunes.Items.Clear();
            RunesEfficiencyMax = RunesEfficiencyMean = RunesEfficiencyMedian = RunesEfficiencyMin = RunesEfficiencyStandardDeviation = RunesAmount = RunesMaxed = RunesInventory = 0;
        }
        #endregion

        private void comboBox_SelectionChangeCommited(object sender, EventArgs e)
        {
            InitRunes?.Invoke();
        }

        private void Runes_Resize(object sender, EventArgs e)
        {
            Resized?.Invoke();
        }

        private void Runes_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible == true)
            {
                CanSeeRunesTab?.Invoke();
            }
        }
    }
}

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
        /// <summary>
        /// Size of the window
        /// </summary>
        public Size SizeWindow => Size;
        /// <summary>
        /// List of the controls used in Dynamic UI
        /// </summary>
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
            comboBoxRuneSubstat4YesNo,
            labelStars,
            comboBoxRuneStars,
            comboBoxRuneStarsIf,
            labelRuneAncient,
            comboBoxRuneAncient
        };

        /// <summary>
        /// Chosen rune set (filters)
        /// </summary>
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
        /// <summary>
        /// Chosen rune stars (filters)
        /// </summary>
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
        /// <summary>
        /// Chosen rune stars statement (filters)
        /// </summary>
        public byte ChosenRuneStarsStatement
        {
            get
            {
                if (comboBoxRuneStarsIf.SelectedIndex < 0) { return 2; } // >=
                return (byte)comboBoxRuneStarsIf.SelectedIndex;
            }
        }
        /// <summary>
        /// Chosen rune mainstat (filters)
        /// </summary>
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
        /// <summary>
        /// Chosen rune innate stat (filters)
        /// </summary>
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
        /// <summary>
        /// Chosen rune quality (filters)
        /// </summary>
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
        /// <summary>
        /// Chosen rune original quality (filters)
        /// </summary>
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

        /// <summary>
        /// Chosen rune slot (filters)
        /// </summary>
        public byte ChosenRuneSlot
        {
            get
            {
                if(comboBoxRuneSlot.SelectedIndex < 0) { return 0; }
                return (byte)comboBoxRuneSlot.SelectedIndex;
            }
        }
        /// <summary>
        /// Chosen if rune should be ancient (filters)
        /// </summary>
        public byte ChosenRuneAncient
        {
            get
            {
                if (comboBoxRuneAncient.SelectedIndex < 0) { return 0; } // All
                return (byte)comboBoxRuneAncient.SelectedIndex;
            }
        }
        /// <summary>
        /// Chosen rune level (filters)
        /// </summary>
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
        /// <summary>
        /// Chosen rune level statement (filters)
        /// </summary>
        public byte ChosenRuneUpgradeStatement
        {
            get
            {
                if (comboBoxRuneUpgradeIf.SelectedIndex < 0) { return 2; } // >=
                return (byte)comboBoxRuneUpgradeIf.SelectedIndex;
            }
        }
        /// <summary>
        /// Chosen rune efficiency (filters)
        /// </summary>
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
        /// <summary>
        /// Chosen rune efficiency statement (filters)
        /// </summary>
        public byte ChosenRuneEfficiencyStatement
        {
            get
            {
                if (comboBoxRuneEfficiencyIf.SelectedIndex < 0) { return 2; } // >=
                return (byte)comboBoxRuneEfficiencyIf.SelectedIndex;
            }
        }

        /// <summary>
        /// Chosen rune 1st substat (filters)
        /// </summary>
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
        /// <summary>
        /// Chosen rune 1st substat statement (filters)
        /// </summary>
        public byte ChosenRuneSubstat1Statement
        {
            get
            {
                if (comboBoxRuneSubstat1YesNo.SelectedIndex != 0) { return 1; } // Yes
                return 0;
            }
        }
        /// <summary>
        /// Chosen rune 2nd substat (filters)
        /// </summary>
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
        /// <summary>
        /// Chosen rune 2nd substat statement (filters)
        /// </summary>
        public byte ChosenRuneSubstat2Statement
        {
            get
            {
                if (comboBoxRuneSubstat2YesNo.SelectedIndex != 0) { return 1; } // Yes
                return 0;
            }
        }
        /// <summary>
        /// Chosen rune 3rd substat (filters)
        /// </summary>
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
        /// <summary>
        /// Chosen rune 3rd substat statement (filters)
        /// </summary>
        public byte ChosenRuneSubstat3Statement
        {
            get
            {
                if (comboBoxRuneSubstat3YesNo.SelectedIndex != 0) { return 1; } // Yes
                return 0;
            }
        }
        /// <summary>
        /// Chosen rune 4th substat (filters)
        /// </summary>
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
        /// <summary>
        /// Chosen rune 4th substat statement (filters)
        /// </summary>
        public byte ChosenRuneSubstat4Statement
        {
            get
            {
                if (comboBoxRuneSubstat4YesNo.SelectedIndex != 0) { return 1; } // Yes
                return 0;
            }
        }

        /// <summary>
        /// The amount of runes (under table)
        /// </summary>
        public ushort RunesAmount
        {
            get => ushort.Parse(labelRunesAmount.Text);
            set => labelRunesAmount.Text = value.ToString();
        }
        /// <summary>
        /// The amount of maxed runes (under table)
        /// </summary>
        public ushort RunesMaxed
        {
            get => ushort.Parse(labelRunesMaxed.Text);
            set => labelRunesMaxed.Text = value.ToString();
        }
        /// <summary>
        /// The amount of runes in inventory (under table)
        /// </summary>
        public ushort RunesInventory
        {
            get => ushort.Parse(labelRunesInventory.Text);
            set => labelRunesInventory.Text = value.ToString();
        }
        /// <summary>
        /// Lowest efficiency (under table)
        /// </summary>
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
        /// <summary>
        /// Highest efficieny (under table)
        /// </summary>
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
        /// <summary>
        /// Mean efficiency (under table)
        /// </summary>
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
        /// <summary>
        /// Median efficiency (under table)
        /// </summary>
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
        /// <summary>
        /// Standard deviation of the efficiency (under table)
        /// </summary>
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

        /// <summary>
        /// Runes table
        /// </summary>
        public ObjectListView RunesListView
        {
            get => objectListViewRunes;
            set => objectListViewRunes = value;
        }

        #region RunesList & MonstersMasterId (no physical field in designer)
        /// <summary>
        /// List of runes
        /// </summary>
        public List<Rune> RunesList { get; set; }
        /// <summary>
        /// Monster ID that is connected with Monster Master ID
        /// </summary>
        public Dictionary<long, int> MonstersMasterId { get; set; }
        #endregion

        /// <summary>
        /// Flow panel used for filters
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public FlowLayoutPanel FlowPanel
        {
            get => flowLayoutPanelFilters;
            set => flowLayoutPanelFilters = value;
        }
        #endregion

        #region Events
        /// <summary>
        /// Initialize Runes tab
        /// </summary>
        public event Action InitRunes;
        /// <summary>
        /// Resize window
        /// </summary>
        public event Action Resized;
        /// <summary>
        /// Makes sure user sees what he should see
        /// </summary>
        public event Action CanSeeRunesTab;
        #endregion
        
        public Runes()
        {
            InitializeComponent();

            objectListViewRunes.DoubleBuffering(true);
        }

        #region Methods
        /// <summary>
        /// Initialize comboboxes
        /// </summary>
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
            comboBoxRuneAncient.SelectedIndex = 0;

            comboBoxRuneSubstat1YesNo.SelectedIndex = 1;
            comboBoxRuneSubstat2YesNo.SelectedIndex = 1;
            comboBoxRuneSubstat3YesNo.SelectedIndex = 1;
            comboBoxRuneSubstat4YesNo.SelectedIndex = 1;
        }
        /// <summary>
        /// Initialize whole Runes tab
        /// </summary>
        public void Init(List<Rune> runes, Dictionary<long, int> monstersMasterId)
        {
            RunesList = runes;
            MonstersMasterId = monstersMasterId;
            InitComboBoxes();
            InitRunes?.Invoke();
        }
        /// <summary>
        /// Bring Runes tab to front
        /// </summary>
        public void Front()
        {
            BringToFront();
        }
        /// <summary>
        /// Reset everything to the default state, if provided JSON file was invalid
        /// </summary>
        public void ResetOnFail()
        {
            objectListViewRunes.Items.Clear();
            RunesEfficiencyMax = RunesEfficiencyMean = RunesEfficiencyMedian = RunesEfficiencyMin = RunesEfficiencyStandardDeviation = RunesAmount = RunesMaxed = RunesInventory = 0;
        }
        private void comboBox_SelectionChangeCommited(object sender, EventArgs e)
        {
            InitRunes?.Invoke();
        }
        public void Runes_Resize(object sender, EventArgs e)
        {
            Resized?.Invoke();
        }
        private void Runes_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible == true)
            {
                Resized?.Invoke();
                CanSeeRunesTab?.Invoke();
            }
        }
        #endregion
    }
}

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
    public partial class Runes : UserControl, IRunesView
    {
        #region Properties
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Control> ControlsRunes => new List<Control>()
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
            listViewRunesList,
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
            panelFooter
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

        public ListView RunesListView
        {
            get => listViewRunesList;
            set => listViewRunesList = value;
        }

        public List<Rune> RunesList { get; set; }
        public Dictionary<long, int> MonstersMasterId { get; set; }
        #endregion

        #region Events
        public event Action InitRunes;
        public event Action Resized;
        #endregion
        
        public Runes()
        {
            InitializeComponent();

            listViewRunesList.DoubleBuffering(true);
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

            Dictionary<int, string> runeEffectTypes = Mapping.Instance.GetAllRuneEffectTypes(); // rune mainstats (and probably in future substats)
            if (!runeEffectTypes.ContainsKey(0)) { runeEffectTypes.Add(0, "All"); }
            runeEffectTypes = runeEffectTypes.OrderBy(x => x.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            comboBoxRuneMainstat.DataSource = new BindingSource(runeEffectTypes, null);
            comboBoxRuneMainstat.DisplayMember = "Value";
            comboBoxRuneMainstat.ValueMember = "Key";


            Dictionary<int, string> runeQualities = Mapping.Instance.GetAllRuneQuailities(); // rune quality (with ancient)
            if (!runeQualities.ContainsKey(0)) { runeQualities.Add(0, "All"); }
            runeQualities = runeQualities.OrderBy(x => x.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            comboBoxRuneQuality.DataSource = new BindingSource(runeQualities, null);
            comboBoxRuneQuality.DisplayMember = "Value";
            comboBoxRuneQuality.ValueMember = "Key";

            comboBoxRuneSlot.SelectedIndex = 0;
            comboBoxRuneUpgrade.SelectedIndex = 0;
            comboBoxRuneUpgradeIf.SelectedIndex = 2;
            comboBoxRuneEfficiency.SelectedIndex = 0;
            comboBoxRuneEfficiencyIf.SelectedIndex = 2;
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
        #endregion

        private void comboBox_SelectionChangeCommited(object sender, EventArgs e)
        {
            InitRunes?.Invoke();
        }

        private void Runes_Resize(object sender, EventArgs e)
        {
            Resized?.Invoke();
        }
    }
}

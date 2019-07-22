using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public partial class DimHole : UserControl, IDimHoleView
    {
        #region Properties
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Control> ControlsDimHole => new List<Control>()
        {
            labelDimHoleMonsters,
            labelDimensionalHoleEnergy,
            labelDimensionalHoleEnergyMax,
            labelDimensionalHoleEnergyMaxInfo,
            labelDimensionalHoleEnergySlash,
            labelDimHoleEnergy,
            listView1,
            radioButton1,
            radioButton2,
            radioButton3,
            radioButton4,
            radioButton5
        };
        public ushort AxpPerLevel { get; set; }
        public byte SummonerDimensionalHoleEnergy
        {
            get => byte.Parse(labelDimensionalHoleEnergy.Text);
            set => labelDimensionalHoleEnergy.Text = value.ToString();
        }
        public byte SummonerDimensionalHoleEnergyMax
        {
            get => byte.Parse(labelDimensionalHoleEnergyMax.Text);
            set => labelDimensionalHoleEnergyMax.Text = value.ToString();
        }
        public string SummonerDimensionalHoleEnergyMaxInfo
        {
            get => labelDimensionalHoleEnergyMaxInfo.Text;
            set => labelDimensionalHoleEnergyMaxInfo.Text = value;
        }
        public DateTime DimensionalEnergyGainStart { get; set; }
        public List<Awakening> DimHoleMonsters { get; set; }

        public ListView DimHoleMonstersListView
        {
            get => listView1;
            set => listView1 = value;
        }

        public Dictionary<RadioButton, ushort> DimHoleLevelAXP => new Dictionary<RadioButton, ushort>()
            {
                { radioButton1, 320 },
                { radioButton2, 420 },
                { radioButton3, 560 },
                { radioButton4, 740 },
                { radioButton5, 960 }
            };
        #endregion

        #region Events
        public event Action<DimensionHoleInfo, List<Monster>> InitDimHole;
        public event Action<RadioButton> DimHoleLevelChanged;
        #endregion

        public DimHole()
        {
            InitializeComponent();
        }

        #region Methods
        public void Init(DimensionHoleInfo dimensionHoleInfo, List<Monster> unitList)
        {
            InitDimHole?.Invoke(dimensionHoleInfo, unitList);
        }
        public void Front()
        {
            BringToFront();
        }
        #endregion

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            DimHoleLevelChanged?.Invoke((RadioButton)sender);
        }
    }
}

using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public partial class DimHole : UserControl, IDimHoleView
    {
        #region Properties
        public Size SizeWindow
        {
            get => Size;
            set => Size = value;
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Control> Cntrls => new List<Control>()
        {
            labelDimHoleMonsters,
            labelDimensionalHoleEnergy,
            labelDimensionalHoleEnergyMax,
            labelDimensionalHoleEnergyMaxInfo,
            labelDimensionalHoleEnergySlash,
            labelDimHoleEnergy,
            objectListViewDimHole,
            radioButton1,
            radioButton2,
            radioButton3,
            radioButton4,
            radioButton5,
            panelHeader,
            panelContent,
            panelButtons
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

        public ObjectListView DimHoleMonstersListView
        {
            get => objectListViewDimHole;
            set => objectListViewDimHole = value;
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<RadioButton, ushort> DimHoleLevelAXP => new Dictionary<RadioButton, ushort>()
            {
                { radioButton1, 320 },
                { radioButton2, 420 },
                { radioButton3, 560 },
                { radioButton4, 740 },
                { radioButton5, 960 }
            };

        public List<TimeSpan> DimHoleFloorTimes
        {
            get
            {
                int.TryParse(maskedTextBoxTimeB1.Text.Substring(0, maskedTextBoxTimeB1.Text.IndexOf(":")), out int int1);
                int.TryParse(maskedTextBoxTimeB1.Text.Substring(maskedTextBoxTimeB1.Text.IndexOf(":") + 1, maskedTextBoxTimeB1.Text.Length - maskedTextBoxTimeB1.Text.IndexOf(":") - 1), out int int1half);

                int.TryParse(maskedTextBoxTimeB2.Text.Substring(0, maskedTextBoxTimeB2.Text.IndexOf(":")), out int int2);
                int.TryParse(maskedTextBoxTimeB2.Text.Substring(maskedTextBoxTimeB2.Text.IndexOf(":") + 1, maskedTextBoxTimeB2.Text.Length - maskedTextBoxTimeB2.Text.IndexOf(":") - 1), out int int2half);

                int.TryParse(maskedTextBoxTimeB3.Text.Substring(0, maskedTextBoxTimeB3.Text.IndexOf(":")), out int int3);
                int.TryParse(maskedTextBoxTimeB3.Text.Substring(maskedTextBoxTimeB3.Text.IndexOf(":") + 1, maskedTextBoxTimeB3.Text.Length - maskedTextBoxTimeB3.Text.IndexOf(":") - 1), out int int3half);

                int.TryParse(maskedTextBoxTimeB4.Text.Substring(0, maskedTextBoxTimeB4.Text.IndexOf(":")), out int int4);
                int.TryParse(maskedTextBoxTimeB4.Text.Substring(maskedTextBoxTimeB4.Text.IndexOf(":") + 1, maskedTextBoxTimeB4.Text.Length - maskedTextBoxTimeB4.Text.IndexOf(":") - 1), out int int4half);

                int.TryParse(maskedTextBoxTimeB5.Text.Substring(0, maskedTextBoxTimeB5.Text.IndexOf(":")), out int int5);
                int.TryParse(maskedTextBoxTimeB5.Text.Substring(maskedTextBoxTimeB5.Text.IndexOf(":") + 1, maskedTextBoxTimeB5.Text.Length - maskedTextBoxTimeB5.Text.IndexOf(":") - 1), out int int5half);
                List <TimeSpan> list = new List<TimeSpan>()
                {
                    new TimeSpan(0, int1, int1half),
                    new TimeSpan(0, int2, int2half),
                    new TimeSpan(0, int3, int3half),
                    new TimeSpan(0, int4, int4half),
                    new TimeSpan(0, int5, int5half)
                };
                return list;
            }
        }

        public List<double> DimHoleFloorSuccessRates
        {
            get
            {
                List<double> list = new List<double>()
                {
                    double.Parse(maskedTextBoxSuccessRateB1.Text.Remove(maskedTextBoxSuccessRateB1.Text.Length - 1)) / 100,
                    double.Parse(maskedTextBoxSuccessRateB2.Text.Remove(maskedTextBoxSuccessRateB2.Text.Length - 1)) / 100,
                    double.Parse(maskedTextBoxSuccessRateB3.Text.Remove(maskedTextBoxSuccessRateB3.Text.Length - 1)) / 100,
                    double.Parse(maskedTextBoxSuccessRateB4.Text.Remove(maskedTextBoxSuccessRateB4.Text.Length - 1)) / 100,
                    double.Parse(maskedTextBoxSuccessRateB5.Text.Remove(maskedTextBoxSuccessRateB5.Text.Length - 1)) / 100
                };
                return list;
            }
        }

        public string DimHoleFloor { set => labelDimHoleFarm.Text = value; }
        #endregion

        #region Events
        public event Action<DimensionHoleInfo, List<Monster>> InitDimHole;
        public event Action<RadioButton> DimHoleLevelChanged;
        public event Action Resized;
        public event Action FloorTextChanged;
        #endregion

        public DimHole()
        {
            InitializeComponent();
            objectListViewDimHole.DoubleBuffering(true);
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

        private void DimHole_Resize(object sender, EventArgs e)
        {
            Resized?.Invoke();
        }

        private void DimHoleFloor_TextChanged(object sender, EventArgs e)
        {
            FloorTextChanged?.Invoke();
        }
    }
}

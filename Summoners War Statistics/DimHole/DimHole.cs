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

        /// <summary>
        /// List of controls used in Dynamic UI
        /// </summary>
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
            panelButtons,
            labelTextB1,
            maskedTextBoxTimeB1,
            maskedTextBoxSuccessRateB1,
            labelTextB2,
            maskedTextBoxTimeB2,
            maskedTextBoxSuccessRateB2,
            labelTextB3,
            maskedTextBoxTimeB3,
            maskedTextBoxSuccessRateB3,
            labelTextB4,
            maskedTextBoxTimeB4,
            maskedTextBoxSuccessRateB4,
            labelTextB5,
            maskedTextBoxTimeB5,
            maskedTextBoxSuccessRateB5,
            labelTextTime,
            labelTextSuccessRate,
            labelTextFarm,
            labelFarmTime,
            labelFarmSuccess,
            panelFarm,
            panelFarmRight
        };
        /// <summary>
        /// AXP needed for the chosen Dim Hole floor level (B1-B5)
        /// </summary>
        public ushort AxpPerLevel { get; set; }
        /// <summary>
        /// Actual amount of Dim Hole energy Summoner has
        /// </summary>
        public byte SummonerDimensionalHoleEnergy
        {
            get => byte.Parse(labelDimensionalHoleEnergy.Text);
            set => labelDimensionalHoleEnergy.Text = value.ToString();
        }
        /// <summary>
        /// Maximum amount of Dim Hole energy Summoner can have
        /// </summary>
        public byte SummonerDimensionalHoleEnergyMax
        {
            get => byte.Parse(labelDimensionalHoleEnergyMax.Text);
            set => labelDimensionalHoleEnergyMax.Text = value.ToString();
        }
        /// <summary>
        /// Info when or if summoner has maxed out Dim Hole energy
        /// </summary>
        public string SummonerDimensionalHoleEnergyMaxInfo
        {
            get => labelDimensionalHoleEnergyMaxInfo.Text;
            set => labelDimensionalHoleEnergyMaxInfo.Text = value;
        }
        /// <summary>
        /// Date of last Dim Hole energy gain (one per 2h)
        /// </summary>
        public DateTime DimensionalEnergyGainStart { get; set; }
        /// <summary>
        /// List of monsters available to 2A
        /// </summary>
        public List<Awakening> DimHoleMonsters { get; set; }
        /// <summary>
        /// Dimension Hole Table
        /// </summary>
        public ObjectListView DimHoleMonstersListView
        {
            get => objectListViewDimHole;
            set => objectListViewDimHole = value;
        }

        #region Dictionary<RadioButton, ushort> DimHoleLevelAXP
        /// <summary>
        /// Radio buttons matching specific AXP (depending on floor, B1-B5)
        /// </summary>
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
        #endregion

        /// <summary>
        /// Times of doing Dim Hole floors
        /// </summary>
        public List<TimeSpan> DimHoleFloorTimes
        {
            get
            {
                _ = int.TryParse(maskedTextBoxTimeB1.Text.Substring(0, maskedTextBoxTimeB1.Text.IndexOf(":")), out int int1);
                _ = int.TryParse(maskedTextBoxTimeB1.Text.Substring(maskedTextBoxTimeB1.Text.IndexOf(":") + 1, maskedTextBoxTimeB1.Text.Length - maskedTextBoxTimeB1.Text.IndexOf(":") - 1), out int int1half);

                _ = int.TryParse(maskedTextBoxTimeB2.Text.Substring(0, maskedTextBoxTimeB2.Text.IndexOf(":")), out int int2);
                _ = int.TryParse(maskedTextBoxTimeB2.Text.Substring(maskedTextBoxTimeB2.Text.IndexOf(":") + 1, maskedTextBoxTimeB2.Text.Length - maskedTextBoxTimeB2.Text.IndexOf(":") - 1), out int int2half);

                _ = int.TryParse(maskedTextBoxTimeB3.Text.Substring(0, maskedTextBoxTimeB3.Text.IndexOf(":")), out int int3);
                _ = int.TryParse(maskedTextBoxTimeB3.Text.Substring(maskedTextBoxTimeB3.Text.IndexOf(":") + 1, maskedTextBoxTimeB3.Text.Length - maskedTextBoxTimeB3.Text.IndexOf(":") - 1), out int int3half);

                _ = int.TryParse(maskedTextBoxTimeB4.Text.Substring(0, maskedTextBoxTimeB4.Text.IndexOf(":")), out int int4);
                _ = int.TryParse(maskedTextBoxTimeB4.Text.Substring(maskedTextBoxTimeB4.Text.IndexOf(":") + 1, maskedTextBoxTimeB4.Text.Length - maskedTextBoxTimeB4.Text.IndexOf(":") - 1), out int int4half);

                _ = int.TryParse(maskedTextBoxTimeB5.Text.Substring(0, maskedTextBoxTimeB5.Text.IndexOf(":")), out int int5);
                _ = int.TryParse(maskedTextBoxTimeB5.Text.Substring(maskedTextBoxTimeB5.Text.IndexOf(":") + 1, maskedTextBoxTimeB5.Text.Length - maskedTextBoxTimeB5.Text.IndexOf(":") - 1), out int int5half);

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
        /// <summary>
        /// Success rate of doing Dim Hole floors
        /// </summary>
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

        /// <summary>
        /// Which floor should be farmed, depending on Clearing Time (output of Dim Hole calculator)
        /// </summary>
        public string DimHoleFloorTime { set => labelFarmTime.Text = value; }
        /// <summary>
        /// Which floor should be farmed, depending on Success Rate (output of Dim Hole calculator)
        /// </summary>
        public string DimHoleFloorSuccess { set => labelFarmSuccess.Text = value; }
        #endregion

        #region Events
        /// <summary>
        /// Initialization of Dim Hole tab
        /// </summary>
        public event Action<DimensionHoleInfo, List<Monster>> InitDimHole;
        /// <summary>
        /// Event of changing Dim Hole level (next to table)
        /// </summary>
        public event Action<RadioButton> DimHoleLevelChanged;
        /// <summary>
        /// Event of resizing window
        /// </summary>
        public event Action Resized;
        /// <summary>
        /// Event of Dim Hole Calculator
        /// </summary>
        public event Action FloorTextChanged;
        /// <summary>
        /// Native UI
        /// </summary>
        public event Action CanSeeDimHoleTab;
        #endregion
        /// <summary>
        /// Constructor of DimHole class
        /// </summary>
        public DimHole()
        {
            InitializeComponent();
            objectListViewDimHole.DoubleBuffering(true);
        }

        #region Methods
        /// <summary>
        /// Method initializing whole Dim Hole tab
        /// </summary>
        /// <param name="dimensionHoleInfo">Summoner's Dim Hole Info/param>
        /// <param name="unitList">List of all Summoner's monsters</param>
        public void Init(DimensionHoleInfo dimensionHoleInfo, List<Monster> unitList)
        {
            InitDimHole?.Invoke(dimensionHoleInfo, unitList);
        }

        /// <summary>
        /// Bring Dim Hole tab to front
        /// </summary>
        public void Front()
        {
            BringToFront();
        }

        /// <summary>
        /// Reset everything, if app failed to init given json file
        /// </summary>
        public void ResetOnFail()
        {
            SummonerDimensionalHoleEnergy = SummonerDimensionalHoleEnergyMax = 0;
            SummonerDimensionalHoleEnergyMaxInfo = DimHoleFloorTime = DimHoleFloorSuccess = "Initialization failed.";
            DimHoleMonstersListView.Items.Clear();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            DimHoleLevelChanged?.Invoke((RadioButton)sender);
        }

        public void DimHole_Resize(object sender, EventArgs e)
        {
            Resized?.Invoke();
        }

        private void DimHoleFloor_TextChanged(object sender, EventArgs e)
        {
            FloorTextChanged?.Invoke();
        }

        /// <summary>
        /// Method invoking the Resized & CanSeeDimHoleTab events only when Tab changed its visibility to visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DimHole_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                Resized?.Invoke();
                CanSeeDimHoleTab?.Invoke();
            }
        }
        #endregion
    }
}

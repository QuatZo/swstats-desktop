using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public partial class DimHole : UserControl, IDimHoleView
    {
        #region Properties
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
        public List<AwakeningInfoClass> DimHoleMonsters { get; set; }

        public ListView DimHoleList
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
        public event Action<RadioButton> DimHoleLevelChanged;
        #endregion

        public DimHole()
        {
            InitializeComponent();
        }

        #region Methods
        public void Init(DimensionHoleInfo dimensionHoleInfo, List<PurpleUnitList> unitList)
        {
            SummonerDimensionalHoleEnergy = dimensionHoleInfo.Energy;
            SummonerDimensionalHoleEnergyMax = dimensionHoleInfo.EnergyMax;
            if (SummonerDimensionalHoleEnergyMax - SummonerDimensionalHoleEnergy > 0)
            {
                byte tempEnergy = SummonerDimensionalHoleEnergy;
                DateTime energyGain = DateTimeOffset.FromUnixTimeSeconds((long)dimensionHoleInfo.EnergyGainStartTimestamp).ToLocalTime().DateTime;
                while (SummonerDimensionalHoleEnergyMax - tempEnergy > 0)
                {
                    energyGain = energyGain.AddHours(2);
                    tempEnergy++;
                }
                SummonerDimensionalHoleEnergyMaxInfo = $"{energyGain.ToString("dddd, dd-MMMM-yyyy HH:mm:ss")} you'll have {tempEnergy} dimensional energy if you don't use any.";
            }
            else
            {
                SummonerDimensionalHoleEnergyMaxInfo = "Your dimensional energy has reached out the limit. You are wasting potential dimensional energy!";
            }

            DimHoleMonsters = new List<AwakeningInfoClass>();

            foreach (PurpleUnitList unit in unitList)
            {
                try
                {
                    int temp = unit.AwakeningInfo.Value.AnythingArray.Count;
                }
                catch (NullReferenceException)
                {
                    DimHoleMonsters.Add(unit.AwakeningInfo.Value.AwakeningInfoClass);
                }
                catch (InvalidOperationException)
                {
                    throw new InvalidJSONException();
                }
            }

            DimensionalEnergyGainStart = DateTimeOffset.FromUnixTimeSeconds((long)dimensionHoleInfo.EnergyGainStartTimestamp).ToLocalTime().DateTime;

            foreach (AwakeningInfoClass mon in DimHoleMonsters)
            {
                foreach(KeyValuePair<RadioButton, ushort> dimHoleLevel in DimHoleLevelAXP)
                {
                    if(dimHoleLevel.Key.Checked == true) { AxpPerLevel = dimHoleLevel.Value; break; }
                }
                ushort energyNeeded = (ushort)Math.Ceiling((decimal)(mon.MaxExp - mon.Exp) / AxpPerLevel);
                string dateWhen2A = "You have enough dimensional energy to 2A this unit.";
                if (energyNeeded - SummonerDimensionalHoleEnergy > 0)
                {
                    byte tempEnergy = (byte)(energyNeeded - SummonerDimensionalHoleEnergy);
                    DateTime energyGain = DimensionalEnergyGainStart;
                    while (tempEnergy != 0)
                    {
                        energyGain = energyGain.AddHours(2);
                        tempEnergy--;
                    }
                    dateWhen2A = energyGain.ToString("dddd, dd-MMMM-yyyy HH:mm:ss");
                }
                string[] str = { Mapping.Instance.GetMonsterName((int)mon.UnitMasterId), (mon.MaxExp - mon.Exp).ToString(), energyNeeded.ToString(), dateWhen2A };
                DimHoleList.Items.Add(new ListViewItem(str));
            }
        }
        #endregion

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            DimHoleLevelChanged?.Invoke((RadioButton)sender);
        }
    }
}

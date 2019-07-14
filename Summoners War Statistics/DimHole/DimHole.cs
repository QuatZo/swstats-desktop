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
    public partial class DimHole : UserControl, IDimHoleView
    {
        #region Properties
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




            List<AwakeningInfoClass> dimHoleMonsters = new List<AwakeningInfoClass>();

            foreach (var unit in unitList)
            {
                try
                {
                    var temp = unit.AwakeningInfo.Value.AnythingArray.Count;
                    
                    
                }
                catch (NullReferenceException)
                {
                    dimHoleMonsters.Add(unit.AwakeningInfo.Value.AwakeningInfoClass);
                }
            }
            
            foreach(var mon in dimHoleMonsters)
            {
                byte energyNeeded = (byte)Math.Ceiling((decimal)(mon.MaxExp - mon.Exp) / 960);
                string dateWhen2A = "You have enough dimensional energy to 2A this unit.";
                if(energyNeeded - SummonerDimensionalHoleEnergy > 0)
                {
                    byte tempEnergy = (byte)(energyNeeded - SummonerDimensionalHoleEnergy);
                    Console.WriteLine($"{energyNeeded} - {SummonerDimensionalHoleEnergy} = {energyNeeded - SummonerDimensionalHoleEnergy}");
                    DateTime energyGain = DateTimeOffset.FromUnixTimeSeconds((long)dimensionHoleInfo.EnergyGainStartTimestamp).ToLocalTime().DateTime;
                    while (tempEnergy != 0)
                    {
                        energyGain = energyGain.AddHours(2);
                        tempEnergy--;
                        Console.WriteLine(tempEnergy);
                    }
                    dateWhen2A = energyGain.ToString("dddd, dd-MMMM-yyyy HH:mm:ss");
                }
                string[] str = { mon.UnitMasterId.ToString(), (mon.MaxExp-mon.Exp).ToString(), energyNeeded.ToString(), dateWhen2A };
                listView1.Items.Add(new ListViewItem(str));
                Console.WriteLine($"Monster {mon.UnitMasterId}[here will be used Xzandro's mapping] can be 2A, it'll take {Math.Ceiling((decimal)(mon.MaxExp - mon.Exp) / 960)} dimensional hole energy more, doing B5.");
            }
        }
        #endregion

        private void pictureBoxDimensionalHoleEnergy_Click(object sender, EventArgs e)
        {

        }

        private void DimHole_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

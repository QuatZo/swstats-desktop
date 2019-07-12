using System;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public partial class Summary : UserControl, ISummaryView
    {
        #region Properties
        public string SummonerName
        {
            get => labelSummonerName.Text;
            set => labelSummonerName.Text = value;
        }
        public byte SummonerLevel
        {
            get => byte.Parse(labelLevel.Text);
            set => labelLevel.Text = value.ToString();
        }
        public ulong SummonerMana
        {
            get => ulong.Parse(labelLevel.Text);
            set => labelMana.Text = value.ToString();
        }
        public uint SummonerCrystals
        {
            get => uint.Parse(labelLevel.Text);
            set => labelCrystals.Text = value.ToString();
        }
        public byte SummonerEnergy
        {
            get => byte.Parse(labelLevel.Text);
            set => labelEnergy.Text = value.ToString();
        }
        public byte SummonerEnergyMax
        {
            get => byte.Parse(labelLevel.Text);
            set => labelEnergyMax.Text = value.ToString();
        }
        public byte SummonerArenaEnergy
        {
            get => byte.Parse(labelLevel.Text);
            set => labelArenaWings.Text = value.ToString();
        }
        public byte SummonerArenaEnergyMax
        {
            get => byte.Parse(labelLevel.Text);
            set => labelArenaWingsMax.Text = value.ToString();
        }
        public uint SummonerGloryPoints
        {
            get => uint.Parse(labelLevel.Text);
            set => labelGloryPoints.Text = value.ToString();
        }
        public uint SummonerGuildPoints
        {
            get => uint.Parse(labelLevel.Text);
            set => labelGuildPoints.Text = value.ToString();
        }
        public byte SummonerDimensionalCrystals
        {
            get => byte.Parse(labelLevel.Text);
            set => labelDimensionalCrystals.Text = value.ToString();
        }
        public byte SummonerDimensionalCrystalsMax
        {
            get => byte.Parse(labelLevel.Text);
            set => labelDimensionalCrystalsMax.Text = value.ToString();
        }
        public ushort SummonerShapeshiftingStones
        {
            get => ushort.Parse(labelLevel.Text);
            set => labelShapeshiftingStones.Text = value.ToString();
        }
        public uint SummonerRTAMedals
        {
            get => uint.Parse(labelLevel.Text);
            set => labelRTAMedals.Text = value.ToString();
        }
        public byte SummonerDimensionalHoleEnergy
        {
            get => byte.Parse(labelLevel.Text);
            set => labelDimensionalHoleEnergy.Text = value.ToString();
        }
        public byte SummonerDimensionalHoleEnergyMax
        {
            get => byte.Parse(labelLevel.Text);
            set => labelDimensionalHoleEnergyMax.Text = value.ToString();
        }
        #endregion

        public Summary()
        {
            InitializeComponent();
        }
    }
}

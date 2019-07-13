using Summoners_War_Statistics.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public partial class Summary : UserControl, ISummaryView
    {
        #region Properties
        public Image SummonerCountry
        {
            get => pictureBoxCountry.Image;
            set => pictureBoxCountry.Image = value;
        }
        public Image SummonerLanguage
        {
            get => pictureBoxLanguage.Image;
            set => pictureBoxLanguage.Image = value;
        }

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
        public ushort SummonerMonstersAmount
        {
            get => ushort.Parse(labelMonsters.Text);
            set => labelMonsters.Text = value.ToString();
        }
        public ushort SummonerMonstersLocked
        {
            get => ushort.Parse(labelMonstersLocked.Text);
            set => labelMonstersLocked.Text = value.ToString();
        }

        public ushort SummonerRunes
        {
            get => ushort.Parse(labelRunes.Text);
            set => labelRunes.Text = value.ToString();
        }
        public ushort SummonerRunesLocked
        {
            get => ushort.Parse(labelRunesLocked.Text);
            set => labelRunesLocked.Text = value.ToString();
        }
        #endregion

        public Summary()
        {
            InitializeComponent();
        }

        #region Methods

        #endregion
        public void Init(WizardInfo wizardInfo, DimensionHoleInfo dimensionHoleInfo, List<PurpleUnitList> monsters, List<long> monstersLocked, List<Rune> runes)
        {
            SummonerRunes = 0;
            SummonerRunesLocked = 0;

            ResourceManager rm = Resources.ResourceManager;
            SummonerCountry = (Image)rm.GetObject(wizardInfo.WizardLastCountry.ToUpper());
            if(wizardInfo.WizardLastLang.ToUpper() == "EN") { SummonerLanguage = (Image)rm.GetObject("US"); }
            else { SummonerLanguage = (Image)rm.GetObject(wizardInfo.WizardLastLang.ToUpper()); }

            SummonerName = wizardInfo.WizardName;
            SummonerLevel = wizardInfo.WizardLevel;
            SummonerMana = wizardInfo.WizardMana;
            SummonerCrystals = wizardInfo.WizardCrystal;

            SummonerArenaEnergy = wizardInfo.ArenaEnergy;
            SummonerArenaEnergyMax = wizardInfo.ArenaEnergyMax;

            SummonerDimensionalCrystals = wizardInfo.DarkportalEnergy;
            SummonerDimensionalCrystalsMax = wizardInfo.DarkportalEnergyMax;

            SummonerDimensionalHoleEnergy = dimensionHoleInfo.Energy;
            SummonerDimensionalHoleEnergyMax = dimensionHoleInfo.EnergyMax;

            SummonerEnergy = wizardInfo.WizardEnergy;
            SummonerEnergyMax = wizardInfo.EnergyMax;

            SummonerGloryPoints = wizardInfo.HonorPoint;
            SummonerGuildPoints = wizardInfo.GuildPoint;
            SummonerRTAMedals = wizardInfo.HonorMedal;

            SummonerShapeshiftingStones = wizardInfo.CostumePoint;

            SummonerMonstersAmount = (ushort)monsters.Count;
            SummonerMonstersLocked = (ushort)monstersLocked.Count;

            foreach (var monster in monsters)
            {
                if(monster.UnitId == null) { continue; }
                SummonerRunesLocked += (ushort)monster.Runes.Count;
            }

            SummonerRunes = (ushort)(runes.Count + SummonerRunesLocked);
            // This should be in Monsters view
            //List<long> monstersToLock = new List<long>();
            //foreach(var monster in monsters)
            //{
            //    if(monster.UnitId == null) { continue; }

            //    if(monster.Class == 6 && !monstersLocked.Contains((long)monster.UnitId)) { monstersToLock.Add((long)monster.UnitMasterId); }
            //}
            //Console.WriteLine($"Monsters to lock: {monstersToLock.Count}");
            //foreach(var monsterToLock in monstersToLock) { Console.WriteLine($"Unit Master ID [use Xzandro's mapping]: {monsterToLock}"); }

        }
    }
}

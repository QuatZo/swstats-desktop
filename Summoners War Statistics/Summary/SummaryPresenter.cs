using Summoners_War_Statistics.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class SummaryPresenter
    {
        ISummaryView view;
        Model model;

        public SummaryPresenter(ISummaryView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.InitSummary += View_InitSummary;
        }

        private void View_InitSummary(WizardInfo wizardInfo, DimensionHoleInfo dimensionHoleInfo, List<PurpleUnitList> monsters, List<long> monstersLocked, List<Rune> runes, DateTime jsonModificationTime, string country)
        {
            view.SummonerRunes = 0;
            view.SummonerRunesLocked = 0;

            ResourceManager rm = Resources.ResourceManager;
            view.SummonerCountry = (Image)rm.GetObject(country.ToUpper());
            view.SummonerLastCountry = (Image)rm.GetObject(wizardInfo.WizardLastCountry.ToUpper());
            if (wizardInfo.WizardLastLang.ToUpper() == "EN") { view.SummonerLastLanguage = (Image)rm.GetObject("US"); }
            else { view.SummonerLastLanguage = (Image)rm.GetObject(wizardInfo.WizardLastLang.ToUpper()); }

            view.SummonerName = wizardInfo.WizardName;
            view.SummonerLevel = wizardInfo.WizardLevel;
            view.SummonerMana = wizardInfo.WizardMana;
            view.SummonerCrystals = wizardInfo.WizardCrystal;

            view.SummonerArenaEnergy = wizardInfo.ArenaEnergy;
            view.SummonerArenaEnergyMax = wizardInfo.ArenaEnergyMax;

            view.SummonerDimensionalCrystals = wizardInfo.DarkportalEnergy;
            view.SummonerDimensionalCrystalsMax = wizardInfo.DarkportalEnergyMax;

            view.SummonerDimensionalHoleEnergy = dimensionHoleInfo.Energy;
            view.SummonerDimensionalHoleEnergyMax = dimensionHoleInfo.EnergyMax;

            view.SummonerEnergy = wizardInfo.WizardEnergy;
            view.SummonerEnergyMax = wizardInfo.EnergyMax;

            view.SummonerGloryPoints = wizardInfo.HonorPoint;
            view.SummonerGuildPoints = wizardInfo.GuildPoint;
            view.SummonerRTAMedals = wizardInfo.HonorMedal;

            view.SummonerShapeshiftingStones = wizardInfo.CostumePoint;

            view.SummonerMonstersAmount = (ushort)monsters.Count;
            view.SummonerMonstersLocked = (ushort)monstersLocked.Count;

            foreach (var monster in monsters)
            {
                if (monster.UnitId == null) { continue; }
                view.SummonerRunesLocked += (ushort)monster.Runes.Count;
            }

            view.SummonerRunes = (ushort)(runes.Count + view.SummonerRunesLocked);

            view.SummonerSocialPoints = (ushort)wizardInfo.SocialPointCurrent;
            view.SummonerAncientCoins = (ushort)wizardInfo.EventCoin;
            // This should be in Monsters view
            //List<long> monstersToLock = new List<long>();
            //foreach(var monster in monsters)
            //{
            //    if(monster.UnitId == null) { continue; }

            //    if(monster.Class == 6 && !monstersLocked.Contains((long)monster.UnitId)) { monstersToLock.Add((long)monster.UnitMasterId); }
            //}
            //Console.WriteLine($"Monsters to lock: {monstersToLock.Count}");
            //foreach(var monsterToLock in monstersToLock) { Console.WriteLine($"Unit Master ID [use Xzandro's mapping]: {monsterToLock}"); }

            view.JsonModifcationDate = jsonModificationTime.ToString("dddd, dd-MMMM-yyyy HH:mm:ss");
        }
    }
}

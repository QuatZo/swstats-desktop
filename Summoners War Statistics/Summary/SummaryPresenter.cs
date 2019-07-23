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

        private void View_InitSummary(Summoner wizardInfo, DimensionHoleInfo dimensionHoleInfo, List<Monster> monsters, List<long> monstersLocked, List<Rune> runes, DateTime jsonModificationTime, string country)
        {
            view.SummonerRunes = 0;
            view.SummonerRunesLocked = 0;

            ResourceManager rm = Resources.ResourceManager;
            view.SummonerCountry = (Image)rm.GetObject(country.ToUpper());
            Logger.log.Info("[Summary] Summoner country done");

            view.SummonerLastCountry = (Image)rm.GetObject(wizardInfo.WizardLastCountry.ToUpper());
            Logger.log.Info("[Summary] Summoner last country done");
            if (wizardInfo.WizardLastLang.ToUpper() == "EN") { view.SummonerLastLanguage = (Image)rm.GetObject("US"); }
            else { view.SummonerLastLanguage = (Image)rm.GetObject(wizardInfo.WizardLastLang.ToUpper()); }
            Logger.log.Info("[Summary] Summoenr last language done");

            view.SummonerName = wizardInfo.WizardName;
            Logger.log.Info("[Summary] Summoner name done");
            view.SummonerLevel = wizardInfo.WizardLevel;
            Logger.log.Info("[Summary] Summoner level done");

            view.SummonerMana = wizardInfo.WizardMana;
            Logger.log.Info("[Summary] Summoner mana done");
            view.SummonerCrystals = wizardInfo.WizardCrystal;
            Logger.log.Info("[Summary] Summoner crystals done");
            view.SummonerGloryPoints = wizardInfo.HonorPoint;
            Logger.log.Info("[Summary] Summoner glory points done");
            view.SummonerGuildPoints = wizardInfo.GuildPoint;
            Logger.log.Info("[Summary] Summoner guild points done");

            view.SummonerRTAMedals = wizardInfo.HonorMedal;
            Logger.log.Info("[Summary] Summoner rta medals done");
            view.SummonerShapeshiftingStones = wizardInfo.CostumePoint;
            Logger.log.Info("[Summary] Summoner shapeshifting stones done");
            view.SummonerSocialPoints = (ushort)wizardInfo.SocialPointCurrent;
            Logger.log.Info("[Summary] Summoner social points done");
            view.SummonerAncientCoins = (ushort)wizardInfo.EventCoin;
            Logger.log.Info("[Summary] Summoner ancient coins done");

            view.SummonerEnergy = wizardInfo.WizardEnergy;
            Logger.log.Info("[Summary] Summoner energy done");
            view.SummonerEnergyMax = wizardInfo.EnergyMax;
            Logger.log.Info("[Summary] Summoner energy max done");
            view.SummonerDimensionalHoleEnergy = dimensionHoleInfo.Energy;
            Logger.log.Info("[Summary] Summoner dimension hole energy done");
            view.SummonerDimensionalHoleEnergyMax = dimensionHoleInfo.EnergyMax;
            Logger.log.Info("[Summary] Summoner dimension hole energy max done");
            view.SummonerArenaEnergy = wizardInfo.ArenaEnergy;
            Logger.log.Info("[Summary] Summoner arena wings done");
            view.SummonerArenaEnergyMax = wizardInfo.ArenaEnergyMax;
            Logger.log.Info("[Summary] Summoner arena wings max done");
            view.SummonerDimensionalCrystals = wizardInfo.DarkportalEnergy;
            Logger.log.Info("[Summary] Summoner dimensional crystals done");
            view.SummonerDimensionalCrystalsMax = wizardInfo.DarkportalEnergyMax;
            Logger.log.Info("[Summary] Summoner dimensional crystals max done");

            view.SummonerMonstersAmount = (ushort)monsters.Count;
            Logger.log.Info("[Summary] Summoner monsters done");
            view.SummonerMonstersLocked = (ushort)monstersLocked.Count;
            Logger.log.Info("[Summary] Summoner monsters locked done");

            foreach (var monster in monsters)
            {
                if (monster.UnitId == null) { continue; }
                view.SummonerRunesLocked += (ushort)monster.Runes.Count;
            }
            Logger.log.Info("[Summary] Summoner locked runes done");

            view.SummonerRunes = (ushort)(runes.Count + view.SummonerRunesLocked);
            Logger.log.Info("[Summary] Summoner runes done");

            view.JsonModifcationDate = jsonModificationTime.ToString("dddd, dd-MMMM-yyyy HH:mm:ss");
            Logger.log.Info("[Summary] Summoner json done");
        }
    }
}

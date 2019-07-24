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
            this.view.Resized += View_Resized;
        }

        private void View_Resized()
        {
            //labelAncientCoins                 - 0
            //labelArenaWings                   - 1
            //labelArenaWingsMax                - 2
            //labelArenaWingsSlash              - 3
            //labelCountry                      - 4
            //labelCrystals                     - 5
            //labelDimensionalCrystals          - 6
            //labelDimensionalCrystalsMax       - 7
            //labelDimensionalCrystalsSlash     - 8
            //labelDimensionalHoleEnergy        - 9
            //labelDimensionalHoleEnergyMax     - 10
            //labelDimensionalHoleEnergySlash   - 11
            //labelEnergy                       - 12
            //labelEnergyMax                    - 13
            //labelEnergySlash                  - 14    
            //labelGloryPoints                  - 15
            //labelGuildPoints                  - 16
            //labelJsonCreatedText              - 17
            //labelJsonModified                 - 18
            //labelLastCountry                  - 19
            //labelLastLanguage                 - 20
            //labelLevel                        - 21
            //labelMana                         - 22
            //labelMonsters                     - 23
            //labelMonstersLocked               - 24
            //labelRTAMedals                    - 25
            //labelRunes                        - 26
            //labelRunesLocked                  - 27
            //labelShapeshiftingStones          - 28
            //labelSocialPoints                 - 29
            //labelSummonerName                 - 30        
            //pictureBoxAncientCoins            - 31    
            //pictureBoxArenaWings              - 32
            //pictureBoxCountry                 - 33    
            //pictureBoxCrystals                - 34
            //pictureBoxDimensionalCrystals     - 35
            //pictureBoxDimensionalHoleEnergy   - 36
            //pictureBoxEnergy                  - 37
            //pictureBoxGloryPoints             - 38
            //pictureBoxGuildPoints             - 39
            //pictureBoxLastCountry             - 40
            //pictureBoxLastLanguage            - 41
            //pictureBoxMana                    - 42
            //pictureBoxMonsters                - 43
            //pictureBoxMonstersLocked          - 44
            //pictureBoxRTAMedals               - 45
            //pictureBoxRunes                   - 46
            //pictureBoxRunesLocked             - 47
            //pictureBoxShapeshiftingStones     - 48
            //pictureBoxSocialPoints            - 49
            //panelContent                      - 50
            //panelContentLeft                  - 51
            //panelContentMid                   - 52
            //panelContentRight                 - 53
            //panelFlags                        - 54
            //panelFlagsLeft                    - 55
            //panelFlagsMi                      - 56
            //panelFlagsRight                   - 57
            //panelFooter                       - 58
            //panelHeader                       - 59
        }

        private void View_InitSummary(Summoner wizardInfo, DimensionHoleInfo dimensionHoleInfo, List<Monster> monsters, List<long> monstersLocked, List<Rune> runes, DateTime jsonModificationTime, string country)
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

            view.JsonModifcationDate = jsonModificationTime.ToString("dddd, dd-MMMM-yyyy HH:mm:ss");
        }
    }
}

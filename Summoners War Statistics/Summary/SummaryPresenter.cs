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
            this.view.Loaded += View_Resized;
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


            // panelFlags
            int widthFlagsFirstLevel = 10;

            int widthFlagsSecondLevel = view.SizeWindow.Width / 2 - view.Cntrls[4].Size.Width - view.Cntrls[56].Location.X;
            view.Cntrls[4].Location = new Point(widthFlagsFirstLevel, view.Cntrls[4].Location.Y);
            view.Cntrls[33].Location = new Point(widthFlagsFirstLevel + view.Cntrls[4].Size.Width, view.Cntrls[33].Location.Y);

            view.Cntrls[19].Location = new Point(widthFlagsSecondLevel, view.Cntrls[19].Location.Y);
            view.Cntrls[40].Location = new Point(widthFlagsSecondLevel + view.Cntrls[19].Size.Width, view.Cntrls[40].Location.Y);

            // panelContent
            int pictureBoxWidth = view.Cntrls[42].Size.Width;
            int widthContentFirstLevel = 10;
            int heightDifference = view.Cntrls[50].Size.Height / 5;
            int heightContentFirstLevel = 10;
            int heightContentSecondLevel = heightContentFirstLevel + heightDifference;
            int heightContentThirdLevel = heightContentSecondLevel + heightDifference;
            int heightContentFourthLevel = heightContentThirdLevel + heightDifference;
            view.Cntrls[42].Location = new Point(widthContentFirstLevel, heightContentFirstLevel);
            view.Cntrls[22].Location = new Point(widthContentFirstLevel + pictureBoxWidth, heightContentFirstLevel);

            view.Cntrls[34].Location = new Point(widthContentFirstLevel, heightContentSecondLevel);
            view.Cntrls[5].Location = new Point(widthContentFirstLevel + pictureBoxWidth, heightContentSecondLevel);

            view.Cntrls[38].Location = new Point(widthContentFirstLevel, heightContentThirdLevel);
            view.Cntrls[15].Location = new Point(widthContentFirstLevel + pictureBoxWidth, heightContentThirdLevel);

            view.Cntrls[39].Location = new Point(widthContentFirstLevel, heightContentFourthLevel);
            view.Cntrls[16].Location = new Point(widthContentFirstLevel + pictureBoxWidth, heightContentFourthLevel);

            int widthContentSecondLevel = view.SizeWindow.Width / 3 - pictureBoxWidth - view.Cntrls[52].Location.X;

            view.Cntrls[45].Location = new Point(widthContentSecondLevel, heightContentFirstLevel);
            view.Cntrls[25].Location = new Point(widthContentSecondLevel + pictureBoxWidth, heightContentFirstLevel);

            view.Cntrls[48].Location = new Point(widthContentSecondLevel, heightContentSecondLevel);
            view.Cntrls[28].Location = new Point(widthContentSecondLevel + pictureBoxWidth, heightContentSecondLevel);

            view.Cntrls[49].Location = new Point(widthContentSecondLevel, heightContentThirdLevel);
            view.Cntrls[29].Location = new Point(widthContentSecondLevel + pictureBoxWidth, heightContentThirdLevel);

            view.Cntrls[31].Location = new Point(widthContentSecondLevel, heightContentFourthLevel);
            view.Cntrls[0].Location = new Point(widthContentSecondLevel + pictureBoxWidth, heightContentFourthLevel);

            int widthContentThirdLevel = view.SizeWindow.Width * 2 / 3 - pictureBoxWidth - view.Cntrls[52].Location.X;

            view.Cntrls[37].Location = new Point(widthContentThirdLevel, heightContentFirstLevel);
            view.Cntrls[12].Location = new Point(widthContentThirdLevel + pictureBoxWidth, heightContentFirstLevel);
            view.Cntrls[14].Location = new Point(view.Cntrls[12].Location.X + view.Cntrls[12].Width, heightContentFirstLevel);
            view.Cntrls[13].Location = new Point(view.Cntrls[14].Location.X + view.Cntrls[14].Width, heightContentFirstLevel);

            view.Cntrls[36].Location = new Point(widthContentThirdLevel, heightContentSecondLevel);
            view.Cntrls[9].Location = new Point(widthContentThirdLevel + pictureBoxWidth, heightContentSecondLevel);
            view.Cntrls[11].Location = new Point(view.Cntrls[9].Location.X + view.Cntrls[9].Width, heightContentSecondLevel);
            view.Cntrls[10].Location = new Point(view.Cntrls[11].Location.X + view.Cntrls[11].Width, heightContentSecondLevel);

            view.Cntrls[32].Location = new Point(widthContentThirdLevel, heightContentThirdLevel);
            view.Cntrls[1].Location = new Point(widthContentThirdLevel + pictureBoxWidth, heightContentThirdLevel);
            view.Cntrls[3].Location = new Point(view.Cntrls[1].Location.X + view.Cntrls[1].Width, heightContentThirdLevel);
            view.Cntrls[2].Location = new Point(view.Cntrls[3].Location.X + view.Cntrls[3].Width, heightContentThirdLevel);

            view.Cntrls[35].Location = new Point(widthContentThirdLevel, heightContentFourthLevel);
            view.Cntrls[6].Location = new Point(widthContentThirdLevel + pictureBoxWidth, heightContentFourthLevel);
            view.Cntrls[8].Location = new Point(view.Cntrls[6].Location.X + view.Cntrls[6].Width, heightContentFourthLevel);
            view.Cntrls[7].Location = new Point(view.Cntrls[8].Location.X + view.Cntrls[8].Width, heightContentFourthLevel);

            view.Cntrls[43].Location = new Point(view.Cntrls[43].Location.X, heightContentFirstLevel);
            view.Cntrls[23].Location = new Point(view.Cntrls[43].Location.X + pictureBoxWidth, heightContentFirstLevel);

            view.Cntrls[44].Location = new Point(view.Cntrls[44].Location.X, heightContentSecondLevel);
            view.Cntrls[24].Location = new Point(view.Cntrls[44].Location.X + pictureBoxWidth, heightContentSecondLevel);

            view.Cntrls[46].Location = new Point(view.Cntrls[46].Location.X, heightContentThirdLevel);
            view.Cntrls[26].Location = new Point(view.Cntrls[46].Location.X + pictureBoxWidth, heightContentThirdLevel);

            view.Cntrls[47].Location = new Point(view.Cntrls[47].Location.X, heightContentFourthLevel);
            view.Cntrls[27].Location = new Point(view.Cntrls[47].Location.X + pictureBoxWidth, heightContentFourthLevel);

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

            View_Resized();
        }
    }
}

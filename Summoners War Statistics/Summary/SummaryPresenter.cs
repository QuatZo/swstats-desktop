using Summoners_War_Statistics.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            this.view.SummaryDecksListView.ColumnClick += SummaryDecksListView_ColumnClick;
            this.view.SummaryDecksListView.BeforeSorting += SummaryDecksListView_BeforeSorting;
        }

        /// <summary>
        /// Double-colum sorting
        /// </summary>
        private void SummaryDecksListView_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            if (view.SummaryDecksListView.PrimarySortColumn != view.SummaryDecksListView.SecondarySortColumn) { view.SummaryDecksListView.SecondarySortColumn = view.SummaryDecksListView.PrimarySortColumn; }
        }

        /// <summary>
        /// Double-colum sorting
        /// </summary>
        private void SummaryDecksListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (view.SummaryDecksListView.SecondarySortColumn != null)
            {
                view.SummaryDecksListView.ListViewItemSorter = new ListViewItemComparer(e.Column, view.SummaryDecksListView.SecondarySortColumn.Index);
            }
            else
            {
                view.SummaryDecksListView.ListViewItemSorter = new ListViewItemComparer(e.Column, -1);
            }
            Logger.log.Info($"[Summary] Sorting");
        }

        /// <summary>
        /// Dynamic UI
        /// </summary>
        private void View_Resized()
        {
            //labelAncientCoins                 - 0
            //labelArenaWings                   - 1
            //labelArenaWingsMax                - 2
            //labelArenaWingsSlash              - 3
            //labelCrystals                     - 4
            //labelDimensionalCrystals          - 5
            //labelDimensionalCrystalsMax       - 6
            //labelDimensionalCrystalsSlash     - 7
            //labelDimensionalHoleEnergy        - 8
            //labelDimensionalHoleEnergyMax     - 9
            //labelDimensionalHoleEnergySlash   - 10
            //labelEnergy                       - 11
            //labelEnergyMax                    - 12
            //labelEnergySlash                  - 13
            //labelGloryPoints                  - 14
            //labelGuildPoints                  - 15
            //labelJsonCreatedText              - 16
            //labelJsonModified                 - 17
            //labelLevel                        - 18
            //labelMana                         - 19
            //labelMons                         - 20
            //labelMonsLocked                   - 21
            //labelRTAMedals                    - 22
            //labelRnes                         - 23
            //labelRnesLocked                   - 24
            //labelShapeshiftingStones          - 25
            //labelSocialPoints                 - 26
            //labelSummonerName                 - 27        
            //pictureBoxAncientCoins            - 28   
            //pictureBoxArenaWings              - 29
            //pictureBoxCountry                 - 30    
            //pictureBoxCrystals                - 31
            //pictureBoxDimensionalCrystals     - 32
            //pictureBoxDimensionalHoleEnergy   - 33
            //pictureBoxEnergy                  - 34
            //pictureBoxGloryPoints             - 35
            //pictureBoxGuildPoints             - 36
            //pictureBoxMana                    - 37
            //pictureBoxMonsters                - 38
            //pictureBoxMonstersLocked          - 39
            //pictureBoxRTAMedals               - 40
            //pictureBoxRunes                   - 41
            //pictureBoxRunesLocked             - 42
            //pictureBoxShapeshiftingStones     - 43
            //pictureBoxSocialPoints            - 44
            //panelContent                      - 45
            //panelContentLeft                  - 46
            //panelContentMid                   - 47
            //panelContentRight                 - 48
            //panelDecks                        - 49
            //panelFooter                       - 50
            //panelHeader                       - 51
            //objectListViewDecks               - 52

            // panelContent
            int pictureBoxWidth = view.Cntrls[37].Size.Width;
            int widthContentFirstLevel = 10;
            int heightDifference = view.Cntrls[37].Size.Height + 5;
            int heightContentFirstLevel = 10;
            int heightContentSecondLevel = heightContentFirstLevel + heightDifference;
            int heightContentThirdLevel = heightContentSecondLevel + heightDifference;
            int heightContentFourthLevel = heightContentThirdLevel + heightDifference;
            view.Cntrls[37].Location = new Point(widthContentFirstLevel, heightContentFirstLevel);
            view.Cntrls[19].Location = new Point(widthContentFirstLevel + pictureBoxWidth, heightContentFirstLevel);

            view.Cntrls[31].Location = new Point(widthContentFirstLevel, heightContentSecondLevel);
            view.Cntrls[4].Location = new Point(widthContentFirstLevel + pictureBoxWidth, heightContentSecondLevel);

            view.Cntrls[35].Location = new Point(widthContentFirstLevel, heightContentThirdLevel);
            view.Cntrls[14].Location = new Point(widthContentFirstLevel + pictureBoxWidth, heightContentThirdLevel);

            view.Cntrls[36].Location = new Point(widthContentFirstLevel, heightContentFourthLevel);
            view.Cntrls[15].Location = new Point(widthContentFirstLevel + pictureBoxWidth, heightContentFourthLevel);

            int widthContentSecondLevel = view.SizeWindow.Width / 3 - pictureBoxWidth - view.Cntrls[47].Location.X;

            view.Cntrls[40].Location = new Point(widthContentSecondLevel, heightContentFirstLevel);
            view.Cntrls[22].Location = new Point(widthContentSecondLevel + pictureBoxWidth, heightContentFirstLevel);

            view.Cntrls[43].Location = new Point(widthContentSecondLevel, heightContentSecondLevel);
            view.Cntrls[25].Location = new Point(widthContentSecondLevel + pictureBoxWidth, heightContentSecondLevel);

            view.Cntrls[44].Location = new Point(widthContentSecondLevel, heightContentThirdLevel);
            view.Cntrls[26].Location = new Point(widthContentSecondLevel + pictureBoxWidth, heightContentThirdLevel);

            view.Cntrls[28].Location = new Point(widthContentSecondLevel, heightContentFourthLevel);
            view.Cntrls[0].Location = new Point(widthContentSecondLevel + pictureBoxWidth, heightContentFourthLevel);

            int widthContentThirdLevel = view.SizeWindow.Width * 2 / 3 - pictureBoxWidth - view.Cntrls[47].Location.X;

            view.Cntrls[34].Location = new Point(widthContentThirdLevel, heightContentFirstLevel);
            view.Cntrls[11].Location = new Point(widthContentThirdLevel + pictureBoxWidth, heightContentFirstLevel);
            view.Cntrls[13].Location = new Point(view.Cntrls[11].Location.X + view.Cntrls[11].Width, heightContentFirstLevel);
            view.Cntrls[12].Location = new Point(view.Cntrls[13].Location.X + view.Cntrls[13].Width, heightContentFirstLevel);

            view.Cntrls[33].Location = new Point(widthContentThirdLevel, heightContentSecondLevel);
            view.Cntrls[8].Location = new Point(widthContentThirdLevel + pictureBoxWidth, heightContentSecondLevel);
            view.Cntrls[10].Location = new Point(view.Cntrls[8].Location.X + view.Cntrls[8].Width, heightContentSecondLevel);
            view.Cntrls[9].Location = new Point(view.Cntrls[10].Location.X + view.Cntrls[10].Width, heightContentSecondLevel);

            view.Cntrls[29].Location = new Point(widthContentThirdLevel, heightContentThirdLevel);
            view.Cntrls[1].Location = new Point(widthContentThirdLevel + pictureBoxWidth, heightContentThirdLevel);
            view.Cntrls[3].Location = new Point(view.Cntrls[1].Location.X + view.Cntrls[1].Width, heightContentThirdLevel);
            view.Cntrls[2].Location = new Point(view.Cntrls[3].Location.X + view.Cntrls[3].Width, heightContentThirdLevel);

            view.Cntrls[32].Location = new Point(widthContentThirdLevel, heightContentFourthLevel);
            view.Cntrls[5].Location = new Point(widthContentThirdLevel + pictureBoxWidth, heightContentFourthLevel);
            view.Cntrls[7].Location = new Point(view.Cntrls[5].Location.X + view.Cntrls[5].Width, heightContentFourthLevel);
            view.Cntrls[6].Location = new Point(view.Cntrls[7].Location.X + view.Cntrls[7].Width, heightContentFourthLevel);

            view.Cntrls[38].Location = new Point(view.Cntrls[38].Location.X, heightContentFirstLevel);
            view.Cntrls[20].Location = new Point(view.Cntrls[38].Location.X + pictureBoxWidth, heightContentFirstLevel);

            view.Cntrls[39].Location = new Point(view.Cntrls[39].Location.X, heightContentSecondLevel);
            view.Cntrls[21].Location = new Point(view.Cntrls[39].Location.X + pictureBoxWidth, heightContentSecondLevel);

            view.Cntrls[41].Location = new Point(view.Cntrls[41].Location.X, heightContentThirdLevel);
            view.Cntrls[23].Location = new Point(view.Cntrls[41].Location.X + pictureBoxWidth, heightContentThirdLevel);

            view.Cntrls[42].Location = new Point(view.Cntrls[42].Location.X, heightContentFourthLevel);
            view.Cntrls[24].Location = new Point(view.Cntrls[42].Location.X + pictureBoxWidth, heightContentFourthLevel);

            view.SummaryDecksListView.BeginUpdate();
            int columnWidth = view.SummaryDecksListView.Size.Width / view.SummaryDecksListView.Columns.Count;
            foreach (ColumnHeader column in view.SummaryDecksListView.Columns)
            {
                column.Width = columnWidth - 5;
            }
            view.SummaryDecksListView.EndUpdate();
        }

        /// <summary>
        /// Initialize whole Summary tab
        /// </summary>
        private void View_InitSummary(Summoner wizardInfo, DimensionHoleInfo dimensionHoleInfo, List<Monster> monsters, List<long> monstersLocked, List<Rune> runes,
            DateTime jsonModificationTime, string country, List<Deck> decks)
        {
            view.SummonerRunes = 0;
            view.SummonerRunesLocked = 0;

            ResourceManager rm = Resources.ResourceManager;
            view.SummonerCountry = (Image)rm.GetObject(country.ToUpper());
            Logger.log.Info("[Summary] Summoner country done");

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

            view.SummaryDecksListView.SetObjects(model.SummaryDecks(monsters, decks));
            Logger.log.Info("[Summary] Summoner decks done");



            view.JsonModifcationDate = jsonModificationTime.ToString("dddd, dd-MMMM-yyyy HH:mm:ss");
            Logger.log.Info("[Summary] Summoner json done");
            View_Resized();
        }
    }
}

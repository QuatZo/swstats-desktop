using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Summoners_War_Statistics
{
    class MonstersPresenter
    {
        IMonstersView view;
        Model model;

        public MonstersPresenter(IMonstersView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.InitMonsters += View_InitMonsters;
            this.view.MonstersStarsChanged += View_MonstersStarsChanged;

            this.view.CanSeeMonstersTab += View_CanSeeMonstersTab;

            this.view.MonstersListView.ColumnClick += MonstersListView_ColumnClick;
            this.view.MonstersListView.BeforeSorting += MonstersListView_BeforeSorting;

            this.view.Resized += View_Resized;

        }

        private void View_CanSeeMonstersTab()
        {
            // panelHeader
            int headerHeightFirstLevel = 10;
            // left
            int height = view.Cntrls[28].Size.Height + 2;
            int headerWidthFirstLevel = 10;
            view.Cntrls[28].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.Cntrls[17].Location = new Point(headerWidthFirstLevel + view.Cntrls[28].Size.Width, headerHeightFirstLevel);

            int headerHeightSecondLevel = headerHeightFirstLevel + height;
            view.Cntrls[29].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);
            view.Cntrls[5].Location = new Point(headerWidthFirstLevel + view.Cntrls[29].Size.Width, headerHeightSecondLevel);

            int headerHeightThirdLevel = headerHeightSecondLevel + height;
            view.Cntrls[30].Location = new Point(headerWidthFirstLevel, headerHeightThirdLevel);
            view.Cntrls[18].Location = new Point(headerWidthFirstLevel + view.Cntrls[30].Size.Width, headerHeightThirdLevel);

            int headerHeightFourthLevel = headerHeightThirdLevel + height;
            view.Cntrls[31].Location = new Point(headerWidthFirstLevel, headerHeightFourthLevel);
            view.Cntrls[7].Location = new Point(headerWidthFirstLevel + view.Cntrls[31].Size.Width, headerHeightFourthLevel);

            int headerHeightFifthLevel = headerHeightFourthLevel + height;
            view.Cntrls[32].Location = new Point(headerWidthFirstLevel, headerHeightFifthLevel);
            view.Cntrls[2].Location = new Point(headerWidthFirstLevel + view.Cntrls[32].Size.Width, headerHeightFifthLevel);

            // right
            view.Cntrls[0].Location = new Point(view.Cntrls[0].Location.X, headerHeightFirstLevel);
            view.Cntrls[22].Location = new Point(view.Cntrls[22].Location.X, headerHeightFirstLevel);
            view.Cntrls[23].Location = new Point(view.Cntrls[23].Location.X, headerHeightFirstLevel);
            view.Cntrls[10].Location = new Point(view.Cntrls[10].Location.X, headerHeightFirstLevel);

            view.Cntrls[24].Location = new Point(view.Cntrls[24].Location.X, headerHeightSecondLevel);
            view.Cntrls[4].Location = new Point(view.Cntrls[4].Location.X, headerHeightSecondLevel);

            view.Cntrls[1].Location = new Point(view.Cntrls[1].Location.X, headerHeightThirdLevel);
            view.Cntrls[25].Location = new Point(view.Cntrls[25].Location.X, headerHeightThirdLevel);
            view.Cntrls[26].Location = new Point(view.Cntrls[26].Location.X, headerHeightThirdLevel);
            view.Cntrls[6].Location = new Point(view.Cntrls[6].Location.X, headerHeightThirdLevel);

            view.Cntrls[27].Location = new Point(view.Cntrls[27].Location.X, headerHeightFourthLevel);
            view.Cntrls[3].Location = new Point(view.Cntrls[3].Location.X, headerHeightFourthLevel);
        }

        private void MonstersListView_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            if (view.MonstersListView.PrimarySortColumn != view.MonstersListView.SecondarySortColumn) { view.MonstersListView.SecondarySortColumn = view.MonstersListView.PrimarySortColumn; }
        }

        private void MonstersListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (view.MonstersListView.SecondarySortColumn != null)
            {
                view.MonstersListView.ListViewItemSorter = new ListViewItemComparer(e.Column, view.MonstersListView.SecondarySortColumn.Index);
            }
            else
            {
                view.MonstersListView.ListViewItemSorter = new ListViewItemComparer(e.Column, -1);
            }
            Logger.log.Info($"[Monsters] Sorting");
        }

        private void View_Resized()
        {
            //labelNat5s                    - 0
            //labelLDNat4sPlus              - 1
            //labelDark                     - 2
            //labelDaysLDLightning          - 3
            //labelDaysNat5                 - 4
            //labelFire                     - 5
            //labelLDNat4Plus               - 6
            //labelLight                    - 7
            //labelMonsters                 - 8
            //labelMonsterStats             - 9
            //labelNat5                     - 10
            //labelStarsFiveAmount          - 11
            //labelStarsFourAmount          - 12
            //labelStarsOneAmount           - 13
            //labelStarsSixAmount           - 14
            //labelStarsThreeAmount         - 15
            //labelStarsTwoAmount           - 16
            //labelWater                    - 17
            //labelWind                     - 18
            //listViewMonstersToLock        - 19
            //radioButton5                  - 20
            //radioButton6                  - 21
            //pictureBoxStarFives           - 22
            //pictureBoxElementalNat5       - 23
            //pictureBoxElementalNat5Clock  - 24
            //pictureBoxStarsFourPlus       - 25
            //pictureBoxLDNat4Plus          - 26
            //pictureBoxLDNat4PlusClock     - 27
            //pictureBoxWater               - 28
            //pictureBoxFire                - 29
            //pictureBoxWind                - 30
            //pictureBoxLight               - 31
            //pictureBoxDark                - 32
            //pictureBoxStars6              - 33
            //pictureBoxStars5              - 34
            //pictureBoxStars4              - 35
            //pictureBoxStars3              - 36
            //pictureBoxStars2              - 37
            //pictureBoxStars1              - 38
            //panelHeader                   - 39
            //panelHeaderLeft               - 40
            //panelHeaderMid                - 41
            //panelHeaderRight              - 42
            //panelFooter                   - 43
            //panelFooterRight              - 44

            // panelHeader
            int headerHeightFirstLevel = 10;
            // left
            int height = view.Cntrls[28].Size.Height + 2;
            int headerHeightSecondLevel = headerHeightFirstLevel + height;
            int headerHeightThirdLevel = headerHeightSecondLevel + height;
            int headerHeightFourthLevel = headerHeightThirdLevel + height;
            int headerHeightFifthLevel = headerHeightFourthLevel + height;

            // mid
            int headerWidthSecondLevel = (view.SizeWindow.Width / 2) - view.Cntrls[33].Size.Width * 2;
            int headerWidthSecondHalfLevel = headerWidthSecondLevel + view.Cntrls[33].Size.Width;
            view.Cntrls[33].Location = new Point(headerWidthSecondLevel, headerHeightFirstLevel);
            view.Cntrls[14].Location = new Point(headerWidthSecondHalfLevel, headerHeightFirstLevel);

            view.Cntrls[34].Location = new Point(headerWidthSecondLevel, headerHeightSecondLevel);
            view.Cntrls[11].Location = new Point(headerWidthSecondHalfLevel, headerHeightSecondLevel);

            view.Cntrls[35].Location = new Point(headerWidthSecondLevel, headerHeightThirdLevel);
            view.Cntrls[12].Location = new Point(headerWidthSecondHalfLevel, headerHeightThirdLevel);

            view.Cntrls[36].Location = new Point(headerWidthSecondLevel, headerHeightFourthLevel);
            view.Cntrls[15].Location = new Point(headerWidthSecondHalfLevel, headerHeightFourthLevel);

            view.Cntrls[37].Location = new Point(headerWidthSecondLevel, headerHeightFifthLevel);
            view.Cntrls[16].Location = new Point(headerWidthSecondHalfLevel, headerHeightFifthLevel);

            int headerHeightSixthLevel = headerHeightFifthLevel + height;
            view.Cntrls[38].Location = new Point(headerWidthSecondLevel, headerHeightSixthLevel);
            view.Cntrls[13].Location = new Point(headerWidthSecondHalfLevel, headerHeightSixthLevel);

            view.MonstersListView.BeginUpdate();
            int columnWidth = view.MonstersListView.Size.Width / view.MonstersListView.Columns.Count;
            foreach(ColumnHeader column in view.MonstersListView.Columns)
            {
                column.Width = columnWidth - 5;
            }
            view.MonstersListView.EndUpdate();
        }

        private void View_MonstersStarsChanged(RadioButton obj)
        {
            Logger.log.Info("[Monsters] MonstersToLock star changing");
            view.MonstersListView.Items.Clear();
            view.MonstersListView.AddObjects(model.MonstersToLock(view.MonstersList, view.MonstersLocked, int.Parse(obj.Name.Remove(0, 11))));
            Logger.log.Info("[Monsters] MonstersToLock star changed");
        }

        private void View_InitMonsters(List<Monster> monsters, List<long> monstersLocked)
        {
            view.MonstersList = monsters;
            Logger.log.Info($"[Monsters] Monsters list done");
            view.MonstersLocked = monstersLocked;
            Logger.log.Info($"[Monsters] Monsters locked done");

            view.ResetMonstersStats();
            Logger.log.Info($"[Monsters] Stats reseted");

            Dictionary<string, ushort> monsterAttributes = new Dictionary<string, ushort>();
            Dictionary<byte, ushort> monsterStars = new Dictionary<byte, ushort>();

            int daysSinceNat5 = 18250; // ~50 years
            int daysSinceLDLightning = 18250; // ~50 years
            DateTime now = DateTime.UtcNow;

            foreach (var monster in view.MonstersList)
            {
                int monsterBaseClass = Mapping.Instance.GetMonsterBaseClass((int)monster.UnitMasterId);
                bool isHoH = Mapping.Instance.GetMonsterHoHStatus((int)monster.UnitMasterId) || Mapping.Instance.GetMonsterHoHStatus((int)monster.UnitMasterId + 10);
                bool isFusion = Mapping.Instance.GetMonsterFusionStatus((int)monster.UnitMasterId) || Mapping.Instance.GetMonsterFusionStatus((int)monster.UnitMasterId + 10);
                string monsterName = Mapping.Instance.GetMonsterName((int)monster.UnitMasterId);
                
                if (monsterBaseClass >= 4 && !isHoH && !isFusion)
                {
                    int daysSinceSummon = (now - monster.CreateTime.Value.UtcDateTime).Days;
                    if (monster.Attribute == 4 || monster.Attribute == 5) {
                        view.MonstersLDNat4PlusAmount++;
                        if(daysSinceSummon < daysSinceLDLightning) { daysSinceLDLightning = daysSinceSummon; }
                        Logger.log.Info($"[Monsters] Monster {monsterName} (Master ID: {monster.UnitMasterId}) added to L&D nat4+ monsters");
                    }
                    else if(monsterBaseClass == 5)
                    {
                        view.MonstersNat5Amount++;
                        if (daysSinceSummon < daysSinceNat5) { daysSinceNat5 = daysSinceSummon; }
                        Logger.log.Info($"[Monsters] Monster {monsterName} (Master ID: {monster.UnitMasterId}) added to elemental nat5 monsters");
                    }
                }
                string monsterAttribute = Mapping.Instance.GetMonsterAttribute((int)monster.Attribute);
                byte monsterClass = (byte)monster.Class;
                if (monsterAttributes.Keys.Contains(monsterAttribute)){ monsterAttributes[monsterAttribute]++; }
                else { monsterAttributes.Add(monsterAttribute, 1); }

                if (monsterStars.Keys.Contains(monsterClass)) { monsterStars[monsterClass]++; }
                else { monsterStars.Add(monsterClass, 1); }
            }

            view.DaysSinceLastLDLightning = (ushort)daysSinceLDLightning;
            Logger.log.Info($"[Monsters] Days since last L&D lightning done");
            view.DaysSinceNat5 = (ushort)daysSinceNat5;
            Logger.log.Info($"[Monsters] Days since last nat5 done");

            if (monsterAttributes.Keys.Contains("Water")) { view.MonsterAttributeWater = monsterAttributes["Water"]; }
            if (monsterAttributes.Keys.Contains("Fire")) { view.MonsterAttributeFire = monsterAttributes["Fire"]; }
            if (monsterAttributes.Keys.Contains("Wind")) { view.MonsterAttributeWind = monsterAttributes["Wind"]; }
            if (monsterAttributes.Keys.Contains("Light")) { view.MonsterAttributeLight = monsterAttributes["Light"]; }
            if (monsterAttributes.Keys.Contains("Dark")) { view.MonsterAttributeDark = monsterAttributes["Dark"]; }
            Logger.log.Info($"[Monsters] Attributes done");

            if (monsterStars.Keys.Contains((byte)6)) { view.MonsterStarsSix = monsterStars[6]; }
            if (monsterStars.Keys.Contains((byte)5)) { view.MonsterStarsFive = monsterStars[5]; }
            if (monsterStars.Keys.Contains((byte)4)) { view.MonsterStarsFour = monsterStars[4]; }
            if (monsterStars.Keys.Contains((byte)3)) { view.MonsterStarsThree = monsterStars[3]; }
            if (monsterStars.Keys.Contains((byte)2)) { view.MonsterStarsTwo = monsterStars[2]; }
            if (monsterStars.Keys.Contains((byte)1)) { view.MonsterStarsOne = monsterStars[1]; }
            Logger.log.Info($"[Monsters] Stars done");

            view.MonstersListView.AddObjects(model.MonstersToLock(view.MonstersList, view.MonstersLocked, view.MonsterStarsChecked));
            Logger.log.Info($"[Monsters] Monsters To Lock list done");

            foreach(var type in model.GetSummonersMonstersCollection(monsters))
            {
                Console.WriteLine($"{type.Key}: {type.Value}");
            }
        }
    }
}

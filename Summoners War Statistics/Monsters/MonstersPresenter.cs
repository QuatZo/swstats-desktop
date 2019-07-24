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
            this.view.MonstersListView.ColumnClick += MonstersListView_ColumnClick;
            this.view.MonstersStarsChanged += View_MonstersStarsChanged;

            this.view.Resized += View_Resized;

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
            int height = view.ControlsMonster[28].Size.Height + 2;
            int headerWidthFirstLevel = 10;
            view.ControlsMonster[28].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.ControlsMonster[17].Location = new Point(headerWidthFirstLevel + view.ControlsMonster[28].Size.Width, headerHeightFirstLevel);

            int headerHeightSecondLevel = headerHeightFirstLevel + height;
            view.ControlsMonster[29].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);
            view.ControlsMonster[5].Location = new Point(headerWidthFirstLevel + view.ControlsMonster[29].Size.Width, headerHeightSecondLevel);

            int headerHeightThirdLevel = headerHeightSecondLevel + height;
            view.ControlsMonster[30].Location = new Point(headerWidthFirstLevel, headerHeightThirdLevel);
            view.ControlsMonster[18].Location = new Point(headerWidthFirstLevel + view.ControlsMonster[30].Size.Width, headerHeightThirdLevel);

            int headerHeightFourthLevel = headerHeightThirdLevel + height;
            view.ControlsMonster[31].Location = new Point(headerWidthFirstLevel, headerHeightFourthLevel);
            view.ControlsMonster[7].Location = new Point(headerWidthFirstLevel + view.ControlsMonster[31].Size.Width, headerHeightFourthLevel);

            int headerHeightFifthLevel = headerHeightFourthLevel + height;
            view.ControlsMonster[32].Location = new Point(headerWidthFirstLevel, headerHeightFifthLevel);
            view.ControlsMonster[2].Location = new Point(headerWidthFirstLevel + view.ControlsMonster[32].Size.Width, headerHeightFifthLevel);

            // mid
            int headerWidthSecondLevel = (view.SizeWindow.Width / 2) - view.ControlsMonster[33].Size.Width * 2;
            int headerWidthSecondHalfLevel = headerWidthSecondLevel + view.ControlsMonster[33].Size.Width;
            view.ControlsMonster[33].Location = new Point(headerWidthSecondLevel, headerHeightFirstLevel);
            view.ControlsMonster[14].Location = new Point(headerWidthSecondHalfLevel, headerHeightFirstLevel);

            view.ControlsMonster[34].Location = new Point(headerWidthSecondLevel, headerHeightSecondLevel);
            view.ControlsMonster[11].Location = new Point(headerWidthSecondHalfLevel, headerHeightSecondLevel);

            view.ControlsMonster[35].Location = new Point(headerWidthSecondLevel, headerHeightThirdLevel);
            view.ControlsMonster[12].Location = new Point(headerWidthSecondHalfLevel, headerHeightThirdLevel);

            view.ControlsMonster[36].Location = new Point(headerWidthSecondLevel, headerHeightFourthLevel);
            view.ControlsMonster[15].Location = new Point(headerWidthSecondHalfLevel, headerHeightFourthLevel);

            view.ControlsMonster[37].Location = new Point(headerWidthSecondLevel, headerHeightFifthLevel);
            view.ControlsMonster[16].Location = new Point(headerWidthSecondHalfLevel, headerHeightFifthLevel);

            int headerHeightSixthLevel = headerHeightFifthLevel + height;
            view.ControlsMonster[38].Location = new Point(headerWidthSecondLevel, headerHeightSixthLevel);
            view.ControlsMonster[13].Location = new Point(headerWidthSecondHalfLevel, headerHeightSixthLevel);

            // right
            view.ControlsMonster[0].Location = new Point(view.ControlsMonster[0].Location.X, headerHeightFirstLevel);
            view.ControlsMonster[22].Location = new Point(view.ControlsMonster[22].Location.X, headerHeightFirstLevel);
            view.ControlsMonster[23].Location = new Point(view.ControlsMonster[23].Location.X, headerHeightFirstLevel);
            view.ControlsMonster[10].Location = new Point(view.ControlsMonster[10].Location.X, headerHeightFirstLevel);

            view.ControlsMonster[24].Location = new Point(view.ControlsMonster[24].Location.X, headerHeightSecondLevel);
            view.ControlsMonster[4].Location = new Point(view.ControlsMonster[4].Location.X, headerHeightSecondLevel);

            view.ControlsMonster[1].Location = new Point(view.ControlsMonster[1].Location.X, headerHeightThirdLevel);
            view.ControlsMonster[25].Location = new Point(view.ControlsMonster[25].Location.X, headerHeightThirdLevel);
            view.ControlsMonster[26].Location = new Point(view.ControlsMonster[26].Location.X, headerHeightThirdLevel);
            view.ControlsMonster[6].Location = new Point(view.ControlsMonster[6].Location.X, headerHeightThirdLevel);

            view.ControlsMonster[27].Location = new Point(view.ControlsMonster[27].Location.X, headerHeightFourthLevel);
            view.ControlsMonster[3].Location = new Point(view.ControlsMonster[3].Location.X, headerHeightFourthLevel);


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
            view.MonstersListView.Items.Clear();
            foreach (string[] monsterToLock in model.MonstersToLock(view.MonstersList, view.MonstersLocked, int.Parse(obj.Name.Remove(0, 11))))
            {
                view.MonstersListView.Items.Add(new ListViewItem(monsterToLock));
            }
        }

        private void MonstersListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            view.MonstersListView.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void View_InitMonsters(List<Monster> monsters, List<long> monstersLocked)
        {
            view.MonstersList = monsters;
            view.MonstersLocked = monstersLocked;

            view.ResetMonstersStats();

            Dictionary<string, ushort> monsterAttributes = new Dictionary<string, ushort>();
            Dictionary<byte, ushort> monsterStars = new Dictionary<byte, ushort>();

            int daysSinceNat5 = 18250; // ~50 years
            int daysSinceLDLightning = 18250; // ~50 years

            foreach (var monster in view.MonstersList)
            {
                int monsterBaseClass = Mapping.Instance.GetMonsterBaseClass((int)monster.UnitMasterId);
                DateTime now = DateTime.UtcNow;
                

                if (monsterBaseClass == 4 || monsterBaseClass == 5)
                {
                    int daysSinceSummon = (now - monster.CreateTime.Value.UtcDateTime).Days;
                    if (monster.Attribute == 4 || monster.Attribute == 5) {
                        view.MonstersLDNat4PlusAmount++;
                        if(daysSinceSummon < daysSinceLDLightning) { daysSinceLDLightning = daysSinceSummon; }
                    }
                    else if(monsterBaseClass == 5)
                    {
                        view.MonstersNat5Amount++;
                        if (daysSinceSummon < daysSinceNat5) { daysSinceNat5 = daysSinceSummon; }
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
            view.DaysSinceNat5 = (ushort)daysSinceNat5;

            if (monsterAttributes.Keys.Contains("Water")) { view.MonsterAttributeWater = monsterAttributes["Water"]; }
            if (monsterAttributes.Keys.Contains("Fire")) { view.MonsterAttributeFire = monsterAttributes["Fire"]; }
            if (monsterAttributes.Keys.Contains("Wind")) { view.MonsterAttributeWind = monsterAttributes["Wind"]; }
            if (monsterAttributes.Keys.Contains("Light")) { view.MonsterAttributeLight = monsterAttributes["Light"]; }
            if (monsterAttributes.Keys.Contains("Dark")) { view.MonsterAttributeDark = monsterAttributes["Dark"]; }

            if (monsterStars.Keys.Contains((byte)6)) { view.MonsterStarsSix = monsterStars[6]; }
            if (monsterStars.Keys.Contains((byte)5)) { view.MonsterStarsFive = monsterStars[5]; }
            if (monsterStars.Keys.Contains((byte)4)) { view.MonsterStarsFour = monsterStars[4]; }
            if (monsterStars.Keys.Contains((byte)3)) { view.MonsterStarsThree = monsterStars[3]; }
            if (monsterStars.Keys.Contains((byte)2)) { view.MonsterStarsTwo = monsterStars[2]; }
            if (monsterStars.Keys.Contains((byte)1)) { view.MonsterStarsOne = monsterStars[1]; }

            foreach (string[] monsterToLock in model.MonstersToLock(view.MonstersList, view.MonstersLocked, view.MonsterStarsChecked))
            {
                view.MonstersListView.Items.Add(new ListViewItem(monsterToLock));
            }
        }
    }
}

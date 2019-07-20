using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void View_InitMonsters(List<PurpleUnitList> monsters, List<long> monstersLocked)
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

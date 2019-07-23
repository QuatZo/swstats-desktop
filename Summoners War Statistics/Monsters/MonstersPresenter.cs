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
            Logger.log.Info("[Monsters] MonstersToLock star changing");
            view.MonstersListView.Items.Clear();
            foreach (string[] monsterToLock in model.MonstersToLock(view.MonstersList, view.MonstersLocked, int.Parse(obj.Name.Remove(0, 11))))
            {
                view.MonstersListView.Items.Add(new ListViewItem(monsterToLock));
            }
            Logger.log.Info("[Monsters] MonstersToLock star changed");
        }

        private void MonstersListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            view.MonstersListView.ListViewItemSorter = new ListViewItemComparer(e.Column);
            Logger.log.Info($"[Monsters] Sorting");
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
                        Logger.log.Info($"[Monsters] Monster (Master ID: {monster.UnitMasterId}) added to L&D nat4+ monsters");
                    }
                    else if(monsterBaseClass == 5)
                    {
                        view.MonstersNat5Amount++;
                        if (daysSinceSummon < daysSinceNat5) { daysSinceNat5 = daysSinceSummon; }
                        Logger.log.Info($"[Monsters] Monster (Master ID: {monster.UnitMasterId}) added to nat5 monsters");
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
            Logger.log.Info($"[Monsters] Water attribute monsters done");
            if (monsterAttributes.Keys.Contains("Fire")) { view.MonsterAttributeFire = monsterAttributes["Fire"]; }
            Logger.log.Info($"[Monsters] Fire attribute monsters done");
            if (monsterAttributes.Keys.Contains("Wind")) { view.MonsterAttributeWind = monsterAttributes["Wind"]; }
            Logger.log.Info($"[Monsters] Wind attribute monsters done");
            if (monsterAttributes.Keys.Contains("Light")) { view.MonsterAttributeLight = monsterAttributes["Light"]; }
            Logger.log.Info($"[Monsters] Light attribute monsters done");
            if (monsterAttributes.Keys.Contains("Dark")) { view.MonsterAttributeDark = monsterAttributes["Dark"]; }
            Logger.log.Info($"[Monsters] Dark attribute monsters done");

            if (monsterStars.Keys.Contains((byte)6)) { view.MonsterStarsSix = monsterStars[6]; }
            Logger.log.Info($"[Monsters] 6* monsters done");
            if (monsterStars.Keys.Contains((byte)5)) { view.MonsterStarsFive = monsterStars[5]; }
            Logger.log.Info($"[Monsters] 5* monsters done");
            if (monsterStars.Keys.Contains((byte)4)) { view.MonsterStarsFour = monsterStars[4]; }
            Logger.log.Info($"[Monsters] 4* monsters done");
            if (monsterStars.Keys.Contains((byte)3)) { view.MonsterStarsThree = monsterStars[3]; }
            Logger.log.Info($"[Monsters] 3* monsters done");
            if (monsterStars.Keys.Contains((byte)2)) { view.MonsterStarsTwo = monsterStars[2]; }
            Logger.log.Info($"[Monsters] 2* monsters done");
            if (monsterStars.Keys.Contains((byte)1)) { view.MonsterStarsOne = monsterStars[1]; }
            Logger.log.Info($"[Monsters] 1* monsters done");

            foreach (string[] monsterToLock in model.MonstersToLock(view.MonstersList, view.MonstersLocked, view.MonsterStarsChecked))
            {
                view.MonstersListView.Items.Add(new ListViewItem(monsterToLock));
            }
            Logger.log.Info($"[Monsters] MonstersToLock list done");
        }
    }
}

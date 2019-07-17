using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    class MonsterPresenter
    {
        IMonstersView view;
        Model model;

        public MonsterPresenter(IMonstersView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.InitMonsters += View_InitMonsters;
            this.view.MonstersListView.ColumnClick += MonstersListView_ColumnClick;

        }

        private void MonstersListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            view.MonstersListView.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void View_InitMonsters(List<PurpleUnitList> monsters, List<long> monstersLocked)
        {
            view.ResetMonstersStats();

            Dictionary<string, ushort> monsterAttributes = new Dictionary<string, ushort>();
            Dictionary<byte, ushort> monsterStars = new Dictionary<byte, ushort>();

            foreach(var monster in monsters)
            {
                string monsterAttribute = Mapping.Instance.GetMonsterAttribute((int)monster.Attribute);
                byte monsterClass = (byte)monster.Class;
                if (monsterAttributes.Keys.Contains(monsterAttribute)){ monsterAttributes[monsterAttribute]++; }
                else { monsterAttributes.Add(monsterAttribute, 1); }

                if (monsterStars.Keys.Contains(monsterClass)) { monsterStars[monsterClass]++; }
                else { monsterStars.Add(monsterClass, 1); }
            }

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

            foreach (string[] monsterToLock in model.MonstersToLock(monsters, monstersLocked))
            {
                view.MonstersListView.Items.Add(new ListViewItem(monsterToLock));
            }
        }
    }
}

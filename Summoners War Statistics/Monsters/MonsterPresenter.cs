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
        }

        private void View_InitMonsters(List<PurpleUnitList> monsters, List<long> monstersLocked)
        {
            foreach (string[] monsterToLock in model.MonstersToLock(monsters, monstersLocked)){ view.MonstersListView.Items.Add(new ListViewItem(monsterToLock)); }
        }
    }
}

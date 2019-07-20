using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    class RunesPresenter
    {
        IRunesView view;
        Model model;

        public RunesPresenter(IRunesView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.InitRunes += View_InitRunes;

            this.view.RunesList.ColumnClick += RunesList_ColumnClick;
        }

        private void RunesList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            view.RunesList.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private List<string> GetColumns()
        {
            List<string> columns = new List<string>();

            foreach(ColumnHeader column in view.RunesList.Columns)
            {
                columns.Add(column.Text);
            }

            return columns;
        }

        private void View_InitRunes(List<Rune> runes, Dictionary<long, int> monstersMasterId)
        {
            foreach(string[] rune in model.RunesList(runes, monstersMasterId, GetColumns()))
            {
                view.RunesList.Items.Add(new ListViewItem(rune));
            }
        }
    }
}

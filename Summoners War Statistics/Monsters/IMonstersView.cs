using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public interface IMonstersView
    {

        #region Properties
        ListView MonstersListView { get; set; }
        #endregion

        #region Events
        event Action<List<PurpleUnitList>, List<long>> InitMonsters;
        #endregion

        #region Methods
        void Init(List<PurpleUnitList> monsters, List<long> monstersLocked);
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public partial class Monsters : UserControl, IMonstersView
    {
        #region Properties
        public ListView MonstersListView
        {
            get => listViewMonstersToLock;
            set => listViewMonstersToLock = value;
        }
        #endregion

        #region Events
        public event Action<List<PurpleUnitList>, List<long>> InitMonsters;
        #endregion

        public Monsters()
        {
            InitializeComponent();
        }

        #region Methods
        public void Init(List<PurpleUnitList> monsters, List<long> monstersLocked)
        {
            InitMonsters?.Invoke(monsters, monstersLocked);
        }
        #endregion
    }
}

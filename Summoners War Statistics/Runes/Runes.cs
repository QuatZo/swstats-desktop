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
    public partial class Runes : UserControl, IRunesView
    {
        #region Properties

        public ListView RunesList
        {
            get => listViewRunesList;
            set => listViewRunesList = value;
        }
        #endregion

        #region Events
        public event Action<List<Rune>, Dictionary<long, int>> InitRunes;
        #endregion
        
        public Runes()
        {
            InitializeComponent();
        }

        #region Methods
        public void Init(List<Rune> runes, Dictionary<long, int> monstersMasterId)
        {
            InitRunes?.Invoke(runes, monstersMasterId);
        }
        #endregion
    }
}

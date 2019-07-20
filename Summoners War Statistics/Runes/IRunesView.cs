using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public interface IRunesView
    {
        #region Properties
        ListView RunesList { get; set; }
        #endregion

        #region Events
        event Action<List<Rune>, Dictionary<long, int>> InitRunes;
        #endregion

        #region Methods
        void Init(List<Rune> runes, Dictionary<long, int> monstersMasterId);
        #endregion
    }
}

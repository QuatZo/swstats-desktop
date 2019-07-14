using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public interface IMenuView
    {
        #region Properties
        List<PictureBox> Buttons { get; set; }
        #endregion

        #region Events
        event Action<object> ButtonClicked;
        #endregion

    }
}

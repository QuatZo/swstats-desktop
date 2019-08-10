using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Summoners_War_Statistics
{
    public interface IMenuView
    {
        #region Properties
        List<PictureBox> Buttons { get; set; }

        List<Control> ControlList { get; }

        bool IsMouseDown { get; set; }

        Point MouseLocation { get; set; }
        int WindowWidth { get; set; }
        #endregion

        #region Events
        event Action<object> ButtonClicked;
        event Action MousePressed;
        event Action MouseUnpressed;
        event Action<Point> MouseMoved;
        #endregion

    }
}

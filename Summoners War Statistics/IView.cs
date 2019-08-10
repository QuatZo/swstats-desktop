using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Summoners_War_Statistics
{
    interface IView
    {
        #region Properties
        IMenuView MenuView { get; }
        ISummaryView SummaryView { get; }
        IMonstersView MonstersView { get; }
        IRunesView RunesView { get; }
        IDimHoleView DimHoleView { get; }
        IGuildView GuildView { get; }
        IOtherView OtherView { get; }

        bool SummaryViewVisibility { get; set; }
        bool MonstersViewVisibility { get; set; }
        bool RunesViewVisibility { get; set; }
        bool DimHoleViewVisibility { get; set; }
        bool GuildViewVisibility { get; set; }
        bool OtherViewVisibility { get; set; }

        OpenFileDialog OpenFile { get; set; }
        FontFamily FF { get; set; }
        Font Fnt { get; set; }

        #endregion

        #region Events
        event Action SelectFileButtonClicked;
        event Action Loaded;
        #endregion

        #region Methods
        void ShowMessage(string message, MessageBoxIcon messageBoxIcon, Exception e = null);
        void HideViews();
        #endregion
    }
}

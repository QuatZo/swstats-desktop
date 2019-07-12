using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    interface IView
    {
        #region Properties
        ISummaryView IntroductionView { get; }

        OpenFileDialog OpenFile { get; set; }
        #endregion

        #region Events
        event Action SelectFileButtonClicked;
        event Action FormOnLoad;
        #endregion

        #region Methods
        void ShowMessage(string message, MessageBoxIcon messageBoxIcon);
        #endregion
    }
}

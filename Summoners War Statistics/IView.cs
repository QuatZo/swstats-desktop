using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    interface IView
    {

        #region Properties
        string Test { get; set; }
        #endregion

        #region Events
        event Action FormOnLoad;
        #endregion

        #region Methods

        #endregion
    }
}

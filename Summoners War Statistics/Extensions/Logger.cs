using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    /// <summary>
    /// Class that contains the method used for logging
    /// </summary>
    public static class Logger
    {
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    /// <summary>
    /// Saved guild defense class
    /// </summary>
    class GuildSiegeDefensesRow
    {
        /// <summary>
        /// First unit in Siege defense
        /// </summary>
        public string FirstUnit { get; set; }
        /// <summary>
        /// Second unit in Siege defense
        /// </summary>
        public string SecondUnit { get; set; }
        /// <summary>
        /// Third unit in Siege defense
        /// </summary>
        public string ThirdUnit { get; set; }

        public GuildSiegeDefensesRow(string firstUnit, string secondUnit, string thirdUnit)
        {
            FirstUnit = firstUnit;
            SecondUnit = secondUnit;
            ThirdUnit = thirdUnit;
        }
    }
}

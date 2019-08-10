using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class GuildSiegeDefensesRow
    {
        public string FirstUnit { get; set; }
        public string SecondUnit { get; set; }
        public string ThirdUnit { get; set; }

        public GuildSiegeDefensesRow(string firstUnit, string secondUnit, string thirdUnit)
        {
            FirstUnit = firstUnit;
            SecondUnit = secondUnit;
            ThirdUnit = thirdUnit;
        }
    }
}

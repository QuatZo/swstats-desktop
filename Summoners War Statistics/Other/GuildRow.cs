using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class GuildRow
    {
        public string Name { get; set; }
        public string Joined { get; set; }
        public string OfflineSince { get; set; }
        public string FirstDefense { get; set; }
        public string SecondDefense { get; set; }

        public GuildRow(string name, string joined, string offlinesince, string firstdefense, string seconddefense)
        {
            Name = name;
            Joined = joined;
            OfflineSince = offlinesince;
            FirstDefense = firstdefense;
            SecondDefense = seconddefense;
        }
    }
}

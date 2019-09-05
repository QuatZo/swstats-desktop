using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    /// <summary>
    /// Class that stores information about guild members
    /// </summary>
    class GuildMembersRow
    {
        /// <summary>
        /// Name of the guild member
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// When the member joined the guild
        /// </summary>
        public string Joined { get; set; }
        /// <summary>
        /// Since when the member is offline (last activity)
        /// </summary>
        public string OfflineSince { get; set; }
        /// <summary>
        /// Amount of units in first defense (GW)
        /// </summary>
        public string FirstDefense { get; set; }
        /// <summary>
        /// Amount of units in second defense (GW)
        /// </summary>
        public string SecondDefense { get; set; }

        public GuildMembersRow(string name, string joined, string offlinesince, string firstdefense, string seconddefense)
        {
            Name = name;
            Joined = joined;
            OfflineSince = offlinesince;
            FirstDefense = firstdefense;
            SecondDefense = seconddefense;
        }
    }
}

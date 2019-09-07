using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    /// <summary>
    /// Class, which represents the row in Friends List table
    /// </summary>
    class FriendsRow
    {
        /// <summary>
        /// Name of the friend
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Since when friend is offline
        /// </summary>
        public string OfflineSince { get; set; }
        /// <summary>
        /// What's the rep monster of the friend
        /// </summary>
        public string RepMonster { get; set; }
        /// <summary>
        /// Amount of stars of the friend's rep monster
        /// </summary>
        public byte RepStars { get; set; }
        /// <summary>
        /// Actual level of the friend's rep monster
        /// </summary>
        public byte RepLevel { get; set; }

        public FriendsRow(string name, string offlinesince, string repmonster, byte repstars, byte replevel)
        {
            Name = name;
            OfflineSince = offlinesince;
            RepMonster = repmonster;
            RepStars = repstars;
            RepLevel = replevel;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    /// <summary>
    /// Class, which represents the row in the Decks table
    /// </summary>
    class DecksRow
    {
        /// <summary>
        /// Place, where the deck is saved (f.e. GW,  ToA)
        /// </summary>
        public string Place { get; set; }
        /// <summary>
        /// 1st monster
        /// </summary>
        public string Monster1 { get; set; }
        /// <summary>
        /// 2nd monster
        /// </summary>
        public string Monster2 { get; set; }
        /// <summary>
        /// 3rd monster
        /// </summary>
        public string Monster3 { get; set; }
        /// <summary>
        /// 4th monster
        /// </summary>
        public string Monster4 { get; set; }
        /// <summary>
        /// 5th monster
        /// </summary>
        public string Monster5 { get; set; }
        /// <summary>
        /// 6th monster
        /// </summary>
        public string Monster6 { get; set; }
        /// <summary>
        /// 7th monster
        /// </summary>
        public string Monster7 { get; set; }
        /// <summary>
        /// 8th monster
        /// </summary>
        public string Monster8 { get; set; }
        /// <summary>
        /// Which monster is used as a leader
        /// </summary>
        public string Leader { get; set; }

        public DecksRow(string place, List<string> monsters, string leader)
        {
            Place = place;
            Monster1 = monsters[0];
            Monster2 = monsters[1];
            Monster3 = monsters[2];
            Monster4 = monsters[3];
            Monster5 = monsters[4];
            Monster6 = monsters[5];
            Monster7 = monsters[6];
            Monster8 = monsters[7];
            Leader = leader;
        }
    }
}

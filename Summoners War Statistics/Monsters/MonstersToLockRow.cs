using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    /// <summary>
    /// Class, which represents the row of a Monsters To Lock table
    /// </summary>
    class MonstersToLockRow
    {
        /// <summary>
        /// Name of the monster (awakaned and unawakened)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Amount of stars of the monster
        /// </summary>
        public byte Stars { get; set; }
        /// <summary>
        /// Actual level of the monster
        /// </summary>
        public byte Level { get; set; }
        /// <summary>
        /// Amount of equipped runes on the monster (0 - 6)
        /// </summary>
        public byte Runes { get; set; }
        /// <summary>
        /// Actual runesets equipped on the monster
        /// </summary>
        public string RuneSets { get; set; }

        public MonstersToLockRow(string name, byte stars, byte level, byte runes, string runesets)
        {
            Name = name;
            Stars = stars;
            Level = level;
            Runes = runes;
            RuneSets = runesets;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class MonstersToLockRow
    {
        public string Name { get; set; }
        public byte Stars { get; set; }
        public byte Level { get; set; }
        public byte Runes { get; set; }
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

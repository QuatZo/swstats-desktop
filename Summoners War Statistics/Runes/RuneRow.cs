using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    /// <summary>
    /// Class, which represents the row in a Runes table
    /// </summary>
    class RuneRow
    {
        /// <summary>
        /// From which set the rune is (f.e. Violent)
        /// </summary>
        public string Set { get; set; }
        /// <summary>
        /// Amount of stars the rune has
        /// </summary>
        public byte Stars { get; set; }
        /// <summary>
        /// Which slot the rune occupies
        /// </summary>
        public byte Slot { get; set; }
        /// <summary>
        /// Actual level of the rune
        /// </summary>
        public byte Level { get; set; }
        /// <summary>
        /// Which monster occupies the rune (may be Inventory, if not equipped by any monster)
        /// </summary>
        public string Origin { get; set; }
        /// <summary>
        /// Main stat value with bonus
        /// </summary>
        public string Mainstat { get; set; }
        /// <summary>
        /// Innate stat value with bonus
        /// </summary>
        public string Innate { get; set; }
        /// <summary>
        /// Amount of HP+ the rune has in substats
        /// </summary>
        public string HPFlat { get; set; }
        /// <summary>
        /// Amount of HP% the rune has in substats
        /// </summary>
        public string HPPercentage { get; set; }
        /// <summary>
        /// Amount of ATK+ the rune has in substats
        /// </summary>
        public string ATKFlat { get; set; }
        /// <summary>
        /// Amount of ATK% the rune has in substats
        /// </summary>
        public string ATKPercentage { get; set; }
        /// <summary>
        /// Amount of DEF+ the rune has in substats
        /// </summary>
        public string DEFFlat { get; set; }
        /// <summary>
        /// Amount of DEF% the rune has in substats
        /// </summary>
        public string DEFPercentage { get; set; }
        /// <summary>
        /// Amount of SPD the rune has in substats
        /// </summary>
        public string SPD { get; set; }
        /// <summary>
        /// Amount of Crit rate the rune has in substats
        /// </summary>
        public string CRate { get; set; }
        /// <summary>
        /// Amount of Crit damage the rune has in substats
        /// </summary>
        public string CDmg { get; set; }
        /// <summary>
        /// Amount of Resistance the rune has in substats
        /// </summary>
        public string Res { get; set; }
        /// <summary>
        /// Amount of Accuracy the rune has in substats
        /// </summary>
        public string Acc { get; set; }
        /// <summary>
        /// Amount of Efficiency the rune has in substats
        /// </summary>
        public string Eff { get; set; }
        /// <summary>
        /// If the rune is Ancient rune or not
        /// </summary>
        public bool Ancient { get; set; }

        public RuneRow(string set, byte stars, byte slot, byte level, string origin, string mainstat, string innate, string hpflat, string hppercentage, string atkflat, string atkpercentage, string defflat, string defpercentage, string spd, string crate, string cdmg, string res, string acc, string eff, bool ancient)
        {
            Set = set;
            Stars = stars;
            Slot = slot;
            Level = level;
            Origin = origin;
            Mainstat = mainstat;
            Innate = innate;
            HPFlat = hpflat;
            HPPercentage = hppercentage;
            ATKFlat = atkflat;
            ATKPercentage = atkpercentage;
            DEFFlat = defflat;
            DEFPercentage = defpercentage;
            SPD = spd;
            CRate = crate;
            CDmg = cdmg;
            Res = res;
            Acc = acc;
            Eff = eff;
            Ancient = ancient;
        }
    }
}

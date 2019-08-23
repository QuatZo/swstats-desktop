using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class RuneRow
    {
        public string Set { get; set; }
        public byte Stars { get; set; }
        public byte Slot { get; set; }
        public byte Level { get; set; }
        public string Origin { get; set; }
        public string Mainstat { get; set; }
        public string Innate { get; set; }
        public string HPFlat { get; set; }
        public string HPPercentage { get; set; }
        public string ATKFlat { get; set; }
        public string ATKPercentage { get; set; }
        public string DEFFlat { get; set; }
        public string DEFPercentage { get; set; }
        public string SPD { get; set; }
        public string CRate { get; set; }
        public string CDmg { get; set; }
        public string Res { get; set; }
        public string Acc { get; set; }
        public string Eff { get; set; }
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

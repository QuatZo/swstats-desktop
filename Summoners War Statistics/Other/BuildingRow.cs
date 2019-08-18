using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class BuildingRow
    {
        public Mapping.BuildingArea Area { get; set; }
        public string Name{ get; set; }
        public string Bonus { get; set; }
        public byte Level { get; set; }
        public ushort NextUpgrade { get; set; }
        public ushort RemainingUpgrade { get; set; }

        public BuildingRow(Mapping.BuildingArea area, string name, string bonus, byte level, ushort nextUpgrade, ushort remainingUpgrade)
        {
            Area = area;
            Name = name;
            Bonus = bonus;
            Level = level;
            NextUpgrade = nextUpgrade;
            RemainingUpgrade = remainingUpgrade;
        }
    }
}

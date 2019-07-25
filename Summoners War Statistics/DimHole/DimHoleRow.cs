using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class DimHoleRow
    {
        public string Name { get; set; }
        public uint AXPNeeded { get; set; }
        public ushort EnergyNeeded { get; set; }
        public string When2A { get; set; }

        public DimHoleRow(string name, uint axpneeded, ushort energyneeded, string when2a)
        {
            Name = name;
            AXPNeeded = axpneeded;
            EnergyNeeded = energyneeded;
            When2A = when2a;
        }
    }
}

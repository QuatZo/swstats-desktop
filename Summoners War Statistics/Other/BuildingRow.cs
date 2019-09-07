using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    /// <summary>
    /// Class, which represent the row in the Building (Flags / Towers) table
    /// </summary>
    class BuildingRow
    {
        /// <summary>
        /// Area of the building (Arena, Guild)
        /// </summary>
        public Mapping.BuildingArea Area { get; set; }
        /// <summary>
        /// Name of the building
        /// </summary>
        public string Name{ get; set; }
        /// <summary>
        /// Bonus of the building (f.e. 13 HP%)
        /// </summary>
        public string Bonus { get; set; }
        /// <summary>
        /// Actual level of the building
        /// </summary>
        public byte Level { get; set; }
        /// <summary>
        /// Cost for the next upgrade
        /// </summary>
        public ushort NextUpgrade { get; set; }
        /// <summary>
        /// Amount of points needed to max the building from current level
        /// </summary>
        public ushort RemainingUpgrade { get; set; }
        /// <summary>
        /// Days till the building will be maxed
        /// </summary>
        public string RemainingDays { get; set; }

        public BuildingRow(Mapping.BuildingArea area, string name, string bonus, byte level, ushort nextUpgrade, ushort remainingUpgrade, string remainingDays)
        {
            Area = area;
            Name = name;
            Bonus = bonus;
            Level = level;
            NextUpgrade = nextUpgrade;
            RemainingUpgrade = remainingUpgrade;
            RemainingDays = remainingDays;
        }
    }
}

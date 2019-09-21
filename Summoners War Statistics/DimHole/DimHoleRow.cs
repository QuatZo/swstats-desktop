using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    /// <summary>
    /// Class, which is a row in the Dim Hole table
    /// </summary>
    class DimHoleRow
    {
        /// <summary>
        /// Monster's name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Monster's AXP needed
        /// </summary>
        public uint AXPNeeded { get; set; }
        /// <summary>
        /// Energy needed to 2A specific monster
        /// </summary>
        public ushort EnergyNeeded { get; set; }
        /// <summary>
        /// Days needed to 2A specific monster
        /// </summary>
        public ushort DaysNeeded { get; set; }
        /// <summary>
        /// When specific monster will get 2A. String, because of infinity
        /// </summary>
        public string When2A { get; set; }

        /// <summary>
        /// Constructor of DimHoleRow class
        /// </summary>
        public DimHoleRow(string name, uint axpNeeded, ushort energyNeeded, ushort daysNeeded, string when2A)
        {
            Name = name;
            AXPNeeded = axpNeeded;
            EnergyNeeded = energyNeeded;
            DaysNeeded = daysNeeded;
            When2A = when2A;
        }
    }
}

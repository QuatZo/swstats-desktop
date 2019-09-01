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
        /// When specific monster will get 2A. String, because of infinity
        /// </summary>
        public string When2A { get; set; }

        /// <summary>
        /// Constructor of DimHoleRow class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="axpneeded"></param>
        /// <param name="energyneeded"></param>
        /// <param name="when2a"></param>
        public DimHoleRow(string name, uint axpneeded, ushort energyneeded, string when2a)
        {
            Name = name;
            AXPNeeded = axpneeded;
            EnergyNeeded = energyneeded;
            When2A = when2a;
        }
    }
}

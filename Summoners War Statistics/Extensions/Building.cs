using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    /// <summary>
    /// Class that contains info about buildings
    /// </summary>
    class Building
    {
        /// <summary>
        /// ID of the building
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Area of effect of the building (Arena, Guild)
        /// </summary>
        public Mapping.BuildingArea Area { get; set; }
        /// <summary>
        /// Name of the building
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Type of the building
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Bonus of the building for every level
        /// </summary>
        public Dictionary<int, int> Bonus { get; set; }

        /// <summary>
        /// Upgrade cost of the building for every level
        /// </summary>
        public Dictionary<int, int> UpgradeCost { get; set; }
        /// <summary>
        /// Full upgrade cost of the building (from 0 to 10)
        /// </summary>
        public int FullUpgradeCost { get; set; }

        /// <summary>
        /// Actual upgrade level of the building
        /// </summary>
        public int ActualLevel { get; set; } = 0;

        public Building(int id, Mapping.BuildingArea area, string name, string type, Dictionary<int, int> bonus, Dictionary<int, int> upgradeCost)
        {
            Id = id;
            Area = area;
            Name = name;
            Type = type;
            Bonus = bonus;
            UpgradeCost = upgradeCost;
            FullUpgradeCost = upgradeCost.Values.Sum();
        }

        /// <summary>
        /// It calculates the amount of Glory Points / Guild Points (depends on the area) needed to max the building.
        /// </summary>
        public int CalcRemainingUpgradeCost()
        {
            if (ActualLevel == 10) { return 0; }

            int upgradeCost = 0;
            for(int i = ActualLevel; i > 0; i--)
            {
                upgradeCost += UpgradeCost[i];
            }

            return FullUpgradeCost - upgradeCost;
        }
    }
}

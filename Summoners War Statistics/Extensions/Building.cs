using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{

    class Building
    {
        public int Id { get; set; }
        public Mapping.BuildingArea Area { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Dictionary<int, int> Bonus { get; set; }

        public Dictionary<int, int> UpgradeCost { get; set; }
        public int FullUpgradeCost { get; set; }

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

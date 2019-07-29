using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class FriendsRow
    {
        public string Name { get; set; }
        public string OfflineSince { get; set; }
        public string RepMonster { get; set; }
        public byte RepStars { get; set; }
        public byte RepLevel { get; set; }

        public FriendsRow(string name, string offlinesince, string repmonster, byte repstars, byte replevel)
        {
            Name = name;
            OfflineSince = offlinesince;
            RepMonster = repmonster;
            RepStars = repstars;
            RepLevel = replevel;
        }
    }
}

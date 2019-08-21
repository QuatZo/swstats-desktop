using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class SiegeRewards
    {
        public int Id { get; set; }
        public (int Crystals, int GuildPoints) FirstPlace { get; set; }
        public (int Crystals, int GuildPoints) SecondPlace { get; set; }
        public (int Crystals, int GuildPoints) ThirdPlace { get; set; }

        public SiegeRewards(int id, (int, int) firstPlace, (int, int) secondPlace, (int, int) thirdPlace)
        {
            Id = id;
            FirstPlace = firstPlace;
            SecondPlace = secondPlace;
            ThirdPlace = thirdPlace;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    /// <summary>
    /// Class that contains info of Siege Rewards
    /// </summary>
    class SiegeRewards
    {
        /// <summary>
        /// ID of reward
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Crystals and Guild Points for 1st place
        /// </summary>
        public (int Crystals, int GuildPoints) FirstPlace { get; set; }
        /// <summary>
        /// Crystals and Guild Points for 2nd place
        /// </summary>
        public (int Crystals, int GuildPoints) SecondPlace { get; set; }
        /// <summary>
        /// Crystals and Guild Points for 3rd place
        /// </summary>
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

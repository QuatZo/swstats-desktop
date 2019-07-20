using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class GuildWarReward
    {
        [JsonProperty("rating_id")]
        public long? RatingId { get; set; }

        [JsonProperty("reward")]
        public List<List<long>> Reward { get; set; }
    }
}

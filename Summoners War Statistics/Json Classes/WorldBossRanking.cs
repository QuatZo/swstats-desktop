using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class WorldBossRanking
    {
        [JsonProperty("ranking")]
        public long? Ranking { get; set; }

        [JsonProperty("accumulate_damage")]
        public long? AccumulateDamage { get; set; }

        [JsonProperty("rating_id")]
        public long? RatingId { get; set; }

        [JsonProperty("ranking_rate")]
        public double? RankingRate { get; set; }

        [JsonProperty("is_reward")]
        public long? IsReward { get; set; }
    }
}

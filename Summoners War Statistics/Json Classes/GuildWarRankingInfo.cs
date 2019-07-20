using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class GuildWarRankingInfo
    {
        [JsonProperty("league_type")]
        public long? LeagueType { get; set; }

        [JsonProperty("rank")]
        public long? Rank { get; set; }

        [JsonProperty("match_score")]
        public long? MatchScore { get; set; }

        [JsonProperty("rating_id")]
        public long? RatingId { get; set; }

        [JsonProperty("total_guild_count")]
        public long? TotalGuildCount { get; set; }
    }
}

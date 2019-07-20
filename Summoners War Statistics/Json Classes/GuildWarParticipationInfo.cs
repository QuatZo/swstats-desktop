using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class GuildWarParticipationInfo
    {
        [JsonProperty("guild_id")]
        public long? GuildId { get; set; }

        [JsonProperty("league_type")]
        public long? LeagueType { get; set; }

        [JsonProperty("member_count")]
        public long? MemberCount { get; set; }

        [JsonProperty("match_score")]
        public long? MatchScore { get; set; }

        [JsonProperty("match_win")]
        public long? MatchWin { get; set; }

        [JsonProperty("match_lose")]
        public long? MatchLose { get; set; }

        [JsonProperty("participated")]
        public long? Participated { get; set; }

        [JsonProperty("energy")]
        public long? Energy { get; set; }

        [JsonProperty("energy_regen_remained")]
        public long? EnergyRegenRemained { get; set; }

        [JsonProperty("energy_max")]
        public long? EnergyMax { get; set; }
    }
}

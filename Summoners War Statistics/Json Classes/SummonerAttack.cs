using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class SummonerAttack
    {
        [JsonProperty("match_id")]
        public long? MatchId { get; set; }

        [JsonProperty("wizard_id")]
        public long? WizardId { get; set; }

        [JsonProperty("guild_id")]
        public long? GuildId { get; set; }

        [JsonProperty("guild_point_var")]
        public long? GuildPointVar { get; set; }

        [JsonProperty("energy")]
        public long? Energy { get; set; }
    }
}

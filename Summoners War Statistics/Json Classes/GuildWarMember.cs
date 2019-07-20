using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class GuildWarMember
    {
        [JsonProperty("guild_id")]
        public long? GuildId { get; set; }

        [JsonProperty("wizard_id")]
        public long? WizardId { get; set; }

        [JsonProperty("grade")]
        public long? Grade { get; set; }

        [JsonProperty("channel_uid")]
        public long? ChannelUid { get; set; }

        [JsonProperty("wizard_name")]
        public string WizardName { get; set; }

        [JsonProperty("wizard_level")]
        public long? WizardLevel { get; set; }

        [JsonProperty("rating_id")]
        public long? RatingId { get; set; }

        [JsonProperty("arena_score")]
        public long? ArenaScore { get; set; }

        [JsonProperty("last_login_timestamp")]
        public long? LastLoginTimestamp { get; set; }

        [JsonProperty("join_timestamp")]
        public long? JoinTimestamp { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class Friend
    {
        [JsonProperty("channel_uid")]
        public long? ChannelUid { get; set; }

        [JsonProperty("wizard_id")]
        public long? WizardId { get; set; }

        [JsonProperty("wizard_level")]
        public long? WizardLevel { get; set; }

        [JsonProperty("wizard_name")]
        public string WizardName { get; set; }

        [JsonProperty("arena_score")]
        public long? ArenaScore { get; set; }

        [JsonProperty("rating_id")]
        public long? RatingId { get; set; }

        [JsonProperty("next_gift_time")]
        public long? NextGiftTime { get; set; }

        [JsonProperty("next_assist_time")]
        public long? NextAssistTime { get; set; }

        [JsonProperty("last_login_timestamp")]
        public long? LastLoginTimestamp { get; set; }

        [JsonProperty("rep_unit_id")]
        public long? RepUnitId { get; set; }

        [JsonProperty("rep_unit_master_id")]
        public long? RepUnitMasterId { get; set; }

        [JsonProperty("rep_unit_class")]
        public long? RepUnitClass { get; set; }

        [JsonProperty("rep_unit_level")]
        public long? RepUnitLevel { get; set; }
    }
}

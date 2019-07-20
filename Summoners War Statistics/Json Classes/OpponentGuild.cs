using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class OpponentGuild
    {
        [JsonProperty("guild_id")]
        public long? GuildId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("master_wizard_id")]
        public long? MasterWizardId { get; set; }

        [JsonProperty("member_now")]
        public long? MemberNow { get; set; }

        [JsonProperty("member_max")]
        public long? MemberMax { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }

        [JsonProperty("level")]
        public long? Level { get; set; }

        [JsonProperty("experience")]
        public long? Experience { get; set; }

        [JsonProperty("recruit_status")]
        public long? RecruitStatus { get; set; }

        [JsonProperty("arena_rating_id")]
        public long? ArenaRatingId { get; set; }

        [JsonProperty("last_market_refresh_auto")]
        public DateTimeOffset? LastMarketRefreshAuto { get; set; }

        [JsonProperty("last_market_refresh_manual")]
        public DateTimeOffset? LastMarketRefreshManual { get; set; }

        [JsonProperty("master_wizard_name")]
        public string MasterWizardName { get; set; }

        [JsonProperty("master_wizard_level")]
        public long? MasterWizardLevel { get; set; }

        [JsonProperty("skill_info")]
        public Dictionary<string, SkillInfo> SkillInfo { get; set; }

        [JsonProperty("market_refresh_ts")]
        public long? MarketRefreshTs { get; set; }

        [JsonProperty("next_market_refresh_auto_ts")]
        public long? NextMarketRefreshAutoTs { get; set; }

        [JsonProperty("next_market_refresh_manual_ts")]
        public long? NextMarketRefreshManualTs { get; set; }
    }
}

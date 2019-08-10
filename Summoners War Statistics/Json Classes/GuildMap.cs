using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class GuildMap
    {
        [JsonProperty("price")]
        public long? Price { get; set; }

        [JsonProperty("dc_rate")]
        public long? DcRate { get; set; }

        [JsonProperty("popup_msgs")]
        public List<object> PopupMsgs { get; set; }

        [JsonProperty("guild_info")]
        public OpponentGuild GuildInfo { get; set; }

        [JsonProperty("guild_members")]
        public Dictionary<string, GuildWarMember> GuildMembers { get; set; }

        [JsonProperty("guild_skills")]
        public List<object> GuildSkills { get; set; }
    }
}

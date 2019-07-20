using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class GuildWarMatchReserve
    {
        [JsonProperty("guild_id")]
        public long? GuildId { get; set; }

        [JsonProperty("status")]
        public long? Status { get; set; }

        [JsonProperty("date_mod")]
        public DateTimeOffset? DateMod { get; set; }
    }
}

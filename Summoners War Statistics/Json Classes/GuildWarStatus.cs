using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class GuildWarStatus
    {
        [JsonProperty("status")]
        public long? Status { get; set; }

        [JsonProperty("prepare_remained")]
        public long? PrepareRemained { get; set; }

        [JsonProperty("match_remained")]
        public long? MatchRemained { get; set; }

        [JsonProperty("reset_remained")]
        public long? ResetRemained { get; set; }
    }
}

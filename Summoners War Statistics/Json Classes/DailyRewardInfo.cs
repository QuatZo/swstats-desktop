using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class DailyRewardInfo
    {
        [JsonProperty("month")]
        public DateTimeOffset? Month { get; set; }

        [JsonProperty("is_checked")]
        public long? IsChecked { get; set; }

        [JsonProperty("check_count")]
        public long? CheckCount { get; set; }

        [JsonProperty("prev_last_check")]
        public DateTimeOffset? PrevLastCheck { get; set; }

        [JsonProperty("enable")]
        public long? Enable { get; set; }
    }
}

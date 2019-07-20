using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class RTASeason
    {
        [JsonProperty("current_season")]
        public long? CurrentSeason { get; set; }

        [JsonProperty("current_season_end")]
        public long? CurrentSeasonEnd { get; set; }

        [JsonProperty("next_season")]
        public long? NextSeason { get; set; }

        [JsonProperty("next_season_begin")]
        public long? NextSeasonBegin { get; set; }

        [JsonProperty("display_end_time")]
        public long? DisplayEndTime { get; set; }

        [JsonProperty("display_begin_time")]
        public long? DisplayBeginTime { get; set; }
    }
}

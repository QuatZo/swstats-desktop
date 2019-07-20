using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class GuildWarRankingStat
    {
        [JsonProperty("current")]
        public Dictionary<string, double> Current { get; set; }

        [JsonProperty("prev")]
        public Dictionary<string, double> Prev { get; set; }

        [JsonProperty("best")]
        public Dictionary<string, double> Best { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class ArenaReward
    {
        [JsonProperty("rating_id")]
        public long? RatingId { get; set; }

        [JsonProperty("crystals")]
        public long? Crystals { get; set; }

        [JsonProperty("unit_master_id")]
        public long? UnitMasterId { get; set; }

        [JsonProperty("unit_class")]
        public long? UnitClass { get; set; }
    }
}

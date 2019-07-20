using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class Raid
    {
        [JsonProperty("raid_id")]
        public long? RaidId { get; set; }

        [JsonProperty("available_stage_id")]
        public long? AvailableStageId { get; set; }
    }
}

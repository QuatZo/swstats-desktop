using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class SummonerDefenseUnit
    {
        [JsonProperty("unit_id")]
        public long? UnitId { get; set; }

        [JsonProperty("pos_id")]
        public long? PosId { get; set; }
    }
}

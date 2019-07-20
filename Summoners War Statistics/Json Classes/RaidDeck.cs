using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class RaidDeck
    {
        [JsonProperty("unit_id_list")]
        public List<long> UnitIdList { get; set; }

        [JsonProperty("leader_index")]
        public long? LeaderIndex { get; set; }
    }
}

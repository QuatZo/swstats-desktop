using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class Deck
    {
        [JsonProperty("deck_type")]
        public long DeckType { get; set; }

        [JsonProperty("deck_seq")]
        public long DeckSeq { get; set; }

        [JsonProperty("unit_id_list")]
        public List<long> UnitIdList { get; set; }

        [JsonProperty("leader_unit_id")]
        public long LeaderUnitId { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class GuildWarDefenseUnit
    {
        [JsonProperty("wizard_id")]
        public long? WizardId { get; set; }

        [JsonProperty("battle_round")]
        public long? BattleRound { get; set; }

        [JsonProperty("pos_id")]
        public long? PosId { get; set; }

        [JsonProperty("unit_id")]
        public long? UnitId { get; set; }
    }
}

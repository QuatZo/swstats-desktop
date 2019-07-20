using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class SummonerAtkDef
    {
        [JsonProperty("match_id")]
        public long? MatchId { get; set; }

        [JsonProperty("atk_wizard_id")]
        public long? AtkWizardId { get; set; }

        [JsonProperty("def_wizard_id")]
        public long? DefWizardId { get; set; }
    }
}

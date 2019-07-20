using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class DimensionHoleInfo
    {
        [JsonProperty("rid")]
        public long? Rid { get; set; }

        [JsonProperty("wizard_id")]
        public long? WizardId { get; set; }

        [JsonProperty("energy")]
        public byte Energy { get; set; }

        [JsonProperty("date_energy_gain_start")]
        public DateTimeOffset? DateEnergyGainStart { get; set; }

        [JsonProperty("date_add")]
        public DateTimeOffset? DateAdd { get; set; }

        [JsonProperty("energy_max")]
        public byte EnergyMax { get; set; }

        [JsonProperty("energy_gain_term_sec")]
        public long? EnergyGainTermSec { get; set; }

        [JsonProperty("energy_gain_start_timestamp")]
        public long? EnergyGainStartTimestamp { get; set; }
    }
}

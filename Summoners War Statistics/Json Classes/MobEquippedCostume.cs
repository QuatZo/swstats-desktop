using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class MobEquippedCostume
    {
        [JsonProperty("wizard_id")]
        public long? WizardId { get; set; }

        [JsonProperty("mob_id")]
        public long? MobId { get; set; }

        [JsonProperty("costume_id")]
        public long? CostumeId { get; set; }
    }
}

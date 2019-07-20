using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class MobCostumePart
    {
        [JsonProperty("wizard_id")]
        public long? WizardId { get; set; }

        [JsonProperty("part_id")]
        public long? PartId { get; set; }
    }
}

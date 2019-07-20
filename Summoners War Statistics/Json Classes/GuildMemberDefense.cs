using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class GuildMemberDefense
    {
        [JsonProperty("wizard_id")]
        public long? WizardId { get; set; }

        [JsonProperty("unit_list")]
        public List<List<GuildWarDefenseUnit>> UnitList { get; set; }
    }
}

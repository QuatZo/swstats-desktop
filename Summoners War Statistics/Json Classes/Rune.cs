using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class Rune
    {
        [JsonProperty("rune_id")]
        public long? RuneId { get; set; }

        [JsonProperty("wizard_id")]
        public long? WizardId { get; set; }

        [JsonProperty("occupied_type")]
        public long? OccupiedType { get; set; }

        [JsonProperty("occupied_id")]
        public long? OccupiedId { get; set; }

        [JsonProperty("slot_no")]
        public long? SlotNo { get; set; }

        [JsonProperty("rank")]
        public long? Rank { get; set; }

        [JsonProperty("class")]
        public long? Class { get; set; }

        [JsonProperty("set_id")]
        public long? SetId { get; set; }

        [JsonProperty("upgrade_limit")]
        public long? UpgradeLimit { get; set; }

        [JsonProperty("upgrade_curr")]
        public long? UpgradeCurr { get; set; }

        [JsonProperty("base_value")]
        public long? BaseValue { get; set; }

        [JsonProperty("sell_value")]
        public long? SellValue { get; set; }

        [JsonProperty("pri_eff")]
        public List<long> PriEff { get; set; }

        [JsonProperty("prefix_eff")]
        public List<long> PrefixEff { get; set; }

        [JsonProperty("sec_eff")]
        public List<List<long>> SecEff { get; set; }

        [JsonProperty("extra")]
        public long? Extra { get; set; }
    }
}

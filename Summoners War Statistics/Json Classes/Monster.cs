using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class Monster
    {
        [JsonProperty("unit_id")]
        public long? UnitId { get; set; }

        [JsonProperty("wizard_id")]
        public long? WizardId { get; set; }

        [JsonProperty("island_id")]
        public long? IslandId { get; set; }

        [JsonProperty("pos_x")]
        public long? PosX { get; set; }

        [JsonProperty("pos_y")]
        public long? PosY { get; set; }

        [JsonProperty("building_id")]
        public long? BuildingId { get; set; }

        [JsonProperty("unit_master_id")]
        public long? UnitMasterId { get; set; }

        [JsonProperty("unit_level")]
        public long? UnitLevel { get; set; }

        [JsonProperty("class")]
        public long? Class { get; set; }

        [JsonProperty("con")]
        public long? Con { get; set; }

        [JsonProperty("atk")]
        public long? Atk { get; set; }

        [JsonProperty("def")]
        public long? Def { get; set; }

        [JsonProperty("spd")]
        public long? Spd { get; set; }

        [JsonProperty("resist")]
        public long? Resist { get; set; }

        [JsonProperty("accuracy")]
        public long? Accuracy { get; set; }

        [JsonProperty("critical_rate")]
        public long? CriticalRate { get; set; }

        [JsonProperty("critical_damage")]
        public long? CriticalDamage { get; set; }

        [JsonProperty("experience")]
        public long? Experience { get; set; }

        [JsonProperty("exp_gained")]
        public long? ExpGained { get; set; }

        [JsonProperty("exp_gain_rate")]
        public long? ExpGainRate { get; set; }

        [JsonProperty("skills")]
        public List<List<long>> Skills { get; set; }

        [JsonProperty("runes")]
        public List<Rune> Runes { get; set; }

        [JsonProperty("costume_master_id")]
        public long? CostumeMasterId { get; set; }

        // NEEDS BETTER JSON FILE, PROBABLY WITH AURAS AND WINGS
        [JsonProperty("trans_items")]
        public TransItems TransItems { get; set; }

        [JsonProperty("attribute")]
        public long? Attribute { get; set; }

        [JsonProperty("create_time")]
        public DateTimeOffset? CreateTime { get; set; }

        [JsonProperty("source")]
        public long? Source { get; set; }

        [JsonProperty("awakening_info")]
        public AwakeningUnion? AwakeningInfo { get; set; }
    }
}

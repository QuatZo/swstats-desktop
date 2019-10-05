using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class Summoner
    {
        [JsonProperty("wizard_id")]
        public long? WizardId { get; set; }

        [JsonProperty("wizard_name")]
        public string WizardName { get; set; }

        [JsonProperty("wizard_mana")]
        public ulong WizardMana { get; set; }

        [JsonProperty("wizard_crystal")]
        public uint WizardCrystal { get; set; }

        [JsonProperty("wizard_crystal_paid")]
        public long? WizardCrystalPaid { get; set; }

        [JsonProperty("wizard_last_login")]
        public DateTimeOffset? WizardLastLogin { get; set; }

        [JsonProperty("wizard_last_country")]
        public string WizardLastCountry { get; set; }

        [JsonProperty("wizard_last_lang")]
        public string WizardLastLang { get; set; }

        [JsonProperty("wizard_level")]
        public byte WizardLevel { get; set; }

        [JsonProperty("experience")]
        public long? Experience { get; set; }

        [JsonProperty("wizard_energy")]
        public int WizardEnergy { get; set; }

        [JsonProperty("energy_max")]
        public byte EnergyMax { get; set; }

        [JsonProperty("energy_per_min")]
        public double? EnergyPerMin { get; set; }

        [JsonProperty("next_energy_gain")]
        public long? NextEnergyGain { get; set; }

        [JsonProperty("arena_energy")]
        public byte ArenaEnergy { get; set; }

        [JsonProperty("arena_energy_max")]
        public byte ArenaEnergyMax { get; set; }

        [JsonProperty("arena_energy_next_gain")]
        public long? ArenaEnergyNextGain { get; set; }

        [JsonProperty("unit_slots")]
        public Slots UnitSlots { get; set; }

        [JsonProperty("rep_unit_id")]
        public long? RepUnitId { get; set; }

        [JsonProperty("rep_assigned")]
        public long? RepAssigned { get; set; }

        [JsonProperty("pvp_event")]
        public long? PvpEvent { get; set; }

        [JsonProperty("mail_box_event")]
        public long? MailBoxEvent { get; set; }

        [JsonProperty("social_point_current")]
        public long? SocialPointCurrent { get; set; }

        [JsonProperty("social_point_max")]
        public long? SocialPointMax { get; set; }

        [JsonProperty("honor_point")]
        public uint HonorPoint { get; set; }

        [JsonProperty("guild_point")]
        public uint GuildPoint { get; set; }

        [JsonProperty("darkportal_energy")]
        public byte DarkportalEnergy { get; set; }

        [JsonProperty("darkportal_energy_max")]
        public byte DarkportalEnergyMax { get; set; }

        [JsonProperty("costume_point")]
        public ushort CostumePoint { get; set; }

        [JsonProperty("costume_point_max")]
        public long? CostumePointMax { get; set; }

        [JsonProperty("honor_medal")]
        public uint HonorMedal { get; set; }

        [JsonProperty("honor_mark")]
        public long? HonorMark { get; set; }

        [JsonProperty("event_coin")]
        public long? EventCoin { get; set; }

        [JsonProperty("lobby_master_id")]
        public long? LobbyMasterId { get; set; }

        [JsonProperty("emblem_master_id")]
        public long? EmblemMasterId { get; set; }

        [JsonProperty("period_energy_max")]
        public long? PeriodEnergyMax { get; set; }
    }
}

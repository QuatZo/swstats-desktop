using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Summoners_War_Statistics
{
    public partial class JsonSwex
    {
        [JsonProperty("command")]
        public string Command { get; set; }

        [JsonProperty("ret_code")]
        public long? RetCode { get; set; }

        [JsonProperty("wizard_info")]
        public Summoner Summoner { get; set; }

        [JsonProperty("defense_unit_list")]
        public List<SummonerDefenseUnit> SummonerDefenseUnitList { get; set; }

        [JsonProperty("quest_rewarded")]
        public List<long> QuestRewarded { get; set; }

        [JsonProperty("event_id_list")]
        public List<long> EventIdList { get; set; }

        [JsonProperty("building_list")]
        public List<Dictionary<string, double>> BuildingList { get; set; }

        [JsonProperty("deco_list")]
        public List<Decoration> DecorationList { get; set; }

        [JsonProperty("mob_list")]
        public List<Mob> MobList { get; set; } // Ellia, ride

        [JsonProperty("mob_costume_equip_list")]
        public List<MobEquippedCostume> MobEquippedCostumeList { get; set; }

        [JsonProperty("mob_costume_part_list")]
        public List<MobCostumePart> MobCostumePartList { get; set; }

        [JsonProperty("unit_list")]
        public List<Monster> MonsterList { get; set; }

        [JsonProperty("runes")]
        public List<Rune> Runes { get; set; }

        [JsonProperty("push_noti_status")]
        public long? PushNotificationStatus { get; set; }

        [JsonProperty("guild")]
        public GuildMap GuildMap { get; set; }

        [JsonProperty("guildwar_defense_unit_list")]
        public List<List<GuildWarDefenseUnit>> GuildWarDefenseUnitList { get; set; }

        [JsonProperty("guildwar_status")]
        public GuildWarStatus GuildWarStatus { get; set; }

        [JsonProperty("guildwar_participation_info")]
        public GuildWarParticipationInfo GuildWarParticipationInfo {get;set;}

        [JsonProperty("guildwar_member_list")]
        public List<GuildWarMember> GuildWarMemberList { get; set; }

        [JsonProperty("guild_member_defense_list")]
        public List<GuildMemberDefense> GuildMemberDefenseList { get; set; }

        [JsonProperty("guildwar_ranking_info")]
        public GuildWarRankingInfo GuildWarRankingInfo { get; set; }

        [JsonProperty("guildwar_ranking_stat")]
        public GuildWarRankingStat GuildWarRankingStat { get; set; }

        [JsonProperty("guildwar_match_reserve")]
        public GuildWarMatchReserve GuildWarMatchReserve { get; set; }

        [JsonProperty("guildwar_my_dead_unit_id_list")]
        public List<object> GuildwarMyDeadUnitIdList { get; set; }

        [JsonProperty("my_atkdef_list")]
        public List<SummonerAtkDef> MyAtkdefList { get; set; }

        [JsonProperty("my_attack_list")]
        public List<SummonerAttack> MyAttackList { get; set; }

        [JsonProperty("opp_guild_info")]
        public OpponentGuild OpponentGuild { get; set; }

        [JsonProperty("opp_guild_member_list")]
        public List<GuildWarMember> OpponentGuildWarMemberList { get; set; }

        [JsonProperty("guildsiege_defense_unit_list")]
        public List<long> GuildSiegeDefenseUnitList { get; set; }

        [JsonProperty("guildwar_reward_list")]
        public List<GuildWarReward> GuildwarRewardList { get; set; }

        [JsonProperty("unit_lock_list")]
        public List<long> LockedMonstersList { get; set; }

        // No info what's inside
        //[JsonProperty("rune_lock_list")]
        //public List<object> LockedRunesList { get; set; }

        //[JsonProperty("shop_daily_bonus_list")]
        //public List<object> ShopDailyBonusList { get; set; }

        [JsonProperty("raid_deck")]
        public RaidDeck RaidDeck { get; set; }

        [JsonProperty("deck_list")]
        public List<Deck> Decks { get; set; }

        [JsonProperty("rtpvp_season_info")]
        public RTASeason RTASeason { get; set; }

        [JsonProperty("rtpvp_contest_info")]
        public Dictionary<string, long> RTAContest { get; set; }

        [JsonProperty("object_storage_slots")]
        public Slots ObjectStorageSlots { get; set; }

        [JsonProperty("lobby_proud_unit_id_list")]
        public List<SummonerDefenseUnit> ProfileMonstersList { get; set; }

        [JsonProperty("summon_choices")]
        public List<object> SummonChoices { get; set; }

        [JsonProperty("item_cart_next_reset_timestamp")]
        public long? ItemCartNextResetTimestamp { get; set; }

        [JsonProperty("friend_list")]
        public List<Friend> FriendList { get; set; }

        [JsonProperty("helper_list")]
        public List<Friend> HelperList { get; set; }

        [JsonProperty("helper_remained")]
        public long? HelperRemained { get; set; } // time till midnight (probably in seconds)

        [JsonProperty("daily_reward_inactive_status")]
        public long? DailyRewardInactiveStatus { get; set; }

        [JsonProperty("daily_reward_new_user_status")]
        public long? DailyRewardNewUserStatus { get; set; }

        [JsonProperty("daily_reward_special_status")]
        public long? DailyRewardSpecialStatus { get; set; }

        [JsonProperty("daily_reward_info")]
        public DailyRewardInfo DailyRewardInfo { get; set; }

        [JsonProperty("pvp_info")]
        public Dictionary<string, long> ArenaStats { get; set; }

        [JsonProperty("pvp_reward_list")]
        public List<ArenaReward> ArenaRewardList { get; set; }

        [JsonProperty("worldboss_used_unit")]
        public List<long> WorldbossUsedUnitList { get; set; }

        [JsonProperty("my_worldboss_ranking")]
        public WorldBossRanking SummonerWorldBossRanking { get; set; }

        [JsonProperty("my_worldboss_prev_ranking")]
        public WorldBossRanking SummonerWorldBossPreviousRanking { get; set; }

        [JsonProperty("my_worldboss_best_ranking")]
        public WorldBossRanking SummonerWorldBossBestRanking { get; set; }

        [JsonProperty("my_worldboss_daily_battle_count")]
        public long? SummonerWorldbossDailyBattleCount { get; set; }

        [JsonProperty("costume_ticket_purchased_list")]
        public List<object> CostumeTicketPurchasedList { get; set; }

        [JsonProperty("session_key")]
        public string SessionKey { get; set; }

        [JsonProperty("raid_info_list")]
        public List<Raid> RaidInfoList { get; set; }

        [JsonProperty("trans_item_list")]
        public TransItems TransItemList { get; set; }

        // No info what's inside.
        //[JsonProperty("rtpvp_reward_info")]
        //public List<object> RtpvpRewardInfo { get; set; }

        //[JsonProperty("rtpvp_contest_reward")]
        //public List<object> RtpvpContestReward { get; set; }

        [JsonProperty("dimension_hole_info")]
        public DimensionHoleInfo DimensionHoleInfo { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("tvaluelocal_next_monday")]
        public long? NextMonday { get; set; }

        [JsonProperty("wizard_id")]
        public long? SummonerId { get; set; }

        [JsonProperty("ts_val")]
        public long? TsVal { get; set; }

        [JsonProperty("tvalue")]
        public long? Tvalue { get; set; }

        [JsonProperty("tvaluelocal")]
        public long? Tvaluelocal { get; set; }

        [JsonProperty("tzone")]
        public string Tzone { get; set; }
    }
    
    // structures and internal classes
    public partial struct SkillInfo
    {
        public List<long> IntegerArray;
        public Dictionary<string, long> IntegerMap;

        public static implicit operator SkillInfo(List<long> IntegerArray) => new SkillInfo { IntegerArray = IntegerArray };
        public static implicit operator SkillInfo(Dictionary<string, long> IntegerMap) => new SkillInfo { IntegerMap = IntegerMap };
    }

    public partial struct ItemUnion
    {
        public long? Integer;
        public List<long> IntegerArray;

        public static implicit operator ItemUnion(long Integer) => new ItemUnion { Integer = Integer };
        public static implicit operator ItemUnion(List<long> IntegerArray) => new ItemUnion { IntegerArray = IntegerArray };
    }

    public partial class JsonSwex
    {
        public static JsonSwex FromJson(string json) => JsonConvert.DeserializeObject<JsonSwex>(json, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                SkillInfoConverter.Singleton,
                ItemUnionConverter.Singleton,
                AwakeningUnionConverter.Singleton,
                TransItemsConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class SkillInfoConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SkillInfo) || t == typeof(SkillInfo?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Dictionary<string, long>>(reader);
                    return new SkillInfo { IntegerMap = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<long>>(reader);
                    return new SkillInfo { IntegerArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type SkillInfo");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (SkillInfo)untypedValue;
            if (value.IntegerArray != null)
            {
                serializer.Serialize(writer, value.IntegerArray);
                return;
            }
            if (value.IntegerMap != null)
            {
                serializer.Serialize(writer, value.IntegerMap);
                return;
            }
            throw new Exception("Cannot marshal type SkillInfo");
        }

        public static readonly SkillInfoConverter Singleton = new SkillInfoConverter();
    }

    internal class ItemUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ItemUnion) || t == typeof(ItemUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new ItemUnion { Integer = integerValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<long>>(reader);
                    return new ItemUnion { IntegerArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ItemUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ItemUnion)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.IntegerArray != null)
            {
                serializer.Serialize(writer, value.IntegerArray);
                return;
            }
            throw new Exception("Cannot marshal type ItemUnion");
        }

        public static readonly ItemUnionConverter Singleton = new ItemUnionConverter();
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    // probably 2A
    public partial class Awakening
    {
        [JsonProperty("rid")]
        public long? Rid { get; set; }

        [JsonProperty("wizard_id")]
        public long? WizardId { get; set; }

        [JsonProperty("unit_id")]
        public long? UnitId { get; set; }

        [JsonProperty("unit_master_id")]
        public long? UnitMasterId { get; set; }

        [JsonProperty("awaken_master_id")]
        public long? AwakenMasterId { get; set; }

        [JsonProperty("exp")]
        public long? Exp { get; set; }

        [JsonProperty("is_awakened")]
        public long? IsAwakened { get; set; }

        [JsonProperty("date_mod")]
        public DateTimeOffset? DateMod { get; set; }

        [JsonProperty("date_add")]
        public DateTimeOffset? DateAdd { get; set; }

        [JsonProperty("max_exp")]
        public long? MaxExp { get; set; }
    }

    public partial struct AwakeningUnion
    {
        public List<object> AnythingArray;
        public Awakening AwakeningInfoClass;

        public static implicit operator AwakeningUnion(List<object> AnythingArray) => new AwakeningUnion { AnythingArray = AnythingArray };
        public static implicit operator AwakeningUnion(Awakening AwakeningInfoClass) => new AwakeningUnion { AwakeningInfoClass = AwakeningInfoClass };
    }

    internal class AwakeningUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AwakeningUnion) || t == typeof(AwakeningUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Awakening>(reader);
                    return new AwakeningUnion { AwakeningInfoClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new AwakeningUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type AwakeningInfoUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (AwakeningUnion)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.AwakeningInfoClass != null)
            {
                serializer.Serialize(writer, value.AwakeningInfoClass);
                return;
            }
            throw new Exception("Cannot marshal type AwakeningInfoUnion");
        }

        public static readonly AwakeningUnionConverter Singleton = new AwakeningUnionConverter();
    }
}

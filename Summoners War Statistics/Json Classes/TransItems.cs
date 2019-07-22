using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class TransItem
    {
        [JsonProperty("wizard_id")]
        public long WizardId { get; set; }

        [JsonProperty("trans_item_id")]
        public long TransItemId { get; set; }

        [JsonProperty("item_master_id")]
        public long ItemMasterId { get; set; }

        [JsonProperty("occupied_id")]
        public long OccupiedId { get; set; }

        [JsonProperty("source")]
        public long Source { get; set; }
    }

    public partial struct TransItems
    {
        public List<object> AnythingArray;
        public Dictionary<string, TransItem> TransItemMap;

        public static implicit operator TransItems(List<object> AnythingArray) => new TransItems { AnythingArray = AnythingArray };
        public static implicit operator TransItems(Dictionary<string, TransItem> TransItemMap) => new TransItems { TransItemMap = TransItemMap };
    }

    internal class TransItemsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TransItems) || t == typeof(TransItems?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Dictionary<string, TransItem>>(reader);
                    return new TransItems { TransItemMap = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new TransItems { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type TransItems");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TransItems)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.TransItemMap != null)
            {
                serializer.Serialize(writer, value.TransItemMap);
                return;
            }
            throw new Exception("Cannot marshal type TransItems");
        }

        public static readonly TransItemsConverter Singleton = new TransItemsConverter();
    }
}

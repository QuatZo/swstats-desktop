using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    public partial class Slots
    {
        [JsonProperty("number")]
        public long? Number { get; set; }
    }
}

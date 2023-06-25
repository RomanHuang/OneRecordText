using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRecordText.Model.OneRecord
{
    public class ActivitySequence
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { "https://onerecord.iata.org/ns/cargo#ActivitySequence" };

        [JsonProperty("https://onerecord.iata.org/ns/cargo#activitySequences")]
        public LogisticsActivity activity { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#sequenceNumber")]
        public string sequenceNumber { get; set; }
    }
}

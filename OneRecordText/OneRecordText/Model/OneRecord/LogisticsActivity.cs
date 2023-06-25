using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRecordText.Model.OneRecord
{
    public class LogisticsActivity
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { "https://onerecord.iata.org/ns/cargo#LogisticsActivity" };

        /// <summary>
        /// Events对象
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#events")]
        public List<LogisticsEvent> events { get; set; }

        /// <summary>
        ///  { "active" "cancelled" "complete" "pending" }
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#executionStatus")]
        public string executionStatus { get; set; }

        /// <summary>
        /// servedServices
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#servedServices")]
        public List<LogisticsService> servedServices { get; set; }
    }
}

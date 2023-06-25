using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRecordText.Model.OneRecord
{
    public class Actor: LogisticsAgent
    {
        public Actor()
        {
            types = new List<string>() { "https://onerecord.iata.org/ns/cargo#Actor" };
        }

        /// <summary>
        /// Events对象
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#events")]
        public List<LogisticsEvent> events { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#externalReferences")]
        public List<ExternalReference> externalReferences { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#skeletonIndicator")]
        public booleanType? skeletonIndicator { get; set; }

        ///// <summary>
        ///// 活动执行方
        ///// </summary>
        //[JsonProperty("https://onerecord.iata.org/ns/cargo#associatedOrganization")]
        //public Organization associatedOrganization { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#documents")]
        public List<ExternalReference> documents { get; set; }
    }
}

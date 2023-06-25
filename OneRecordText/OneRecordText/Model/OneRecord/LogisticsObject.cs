using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{

    public  class LogisticsObject
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { "https://onerecord.iata.org/ns/cargo#logisticsObject" };

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#checks")]
        public string checks { get; set; }
        /// <summary>
        /// 物流对象所在实体的物流互联网中的公司标识符
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#companyIdentifier")]
        public string companyIdentifier { get; set; }

        /// <summary>
        /// Events对象
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#events")]
        public List<LogisticsEvent> events { get; set; }

        ///// <summary>
        ///// 允许将物流对象与物联网设备链接
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_iotDevice)]
        //public List<IotDevice> iotDevice { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#externalReferences")]
        public ExternalReference externalReferences { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#skeletonIndicator")]
        public booleanType? skeletonIndicator { get; set; }
    }
}

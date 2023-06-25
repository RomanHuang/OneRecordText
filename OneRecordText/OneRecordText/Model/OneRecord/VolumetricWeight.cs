using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 计量单位详细信息
    /// </summary>
    public class VolumetricWeight
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { "https://onerecord.iata.org/ns/cargo#VolumetricWeight" };

        /// <summary>
        /// 计费重量
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#chargeableWeight")]
        public Value chargeableWeight { get; set; }

        /// <summary>
        /// 体积重量换算系数
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#conversionFactor")]
        public Value conversionFactor { get; set; }
    }
}

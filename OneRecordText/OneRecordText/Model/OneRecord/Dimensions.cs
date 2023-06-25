using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 维度详细信息
    /// </summary>
    public class Dimensions
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { "https://onerecord.iata.org/ns/cargo#Dimensions" };

        /// <summary>
        /// 身高
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#height")]
        public Value height { get; set; }

        /// <summary>
        /// 长
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#length") ]
        public Value length { get; set; }

        /// <summary>
        /// 体积
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#volume")]
        public Value volume { get; set; }

        /// <summary>
        /// 宽度
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#width")]
        public Value width { get; set; }

    }
}

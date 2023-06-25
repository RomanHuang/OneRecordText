using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    public class Value
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { "https://onerecord.iata.org/ns/cargo#Value" };

        /// <summary>
        /// 计量单位 记账单位，例如CMT - 厘米、LTR - 升 （1 DM3）、KGM - 千克、瑞士法郎 - 瑞士法郎
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#unit")]
        public string unit { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#value")]
        public string value { get; set; }
    }
}

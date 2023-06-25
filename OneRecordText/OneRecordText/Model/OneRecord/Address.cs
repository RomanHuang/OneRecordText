using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 地址详细信息
    /// </summary>
    public class Address
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { "https://onerecord.iata.org/ns/cargo#Address" };
        /// <summary>
        /// 使用特殊编码系统的地址标识符，例如美国CBP公司代码
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#addressCode")]
        public string addressCode { get; set; }
        /// <summary>
        /// UNLOCODE 城市代码（5 个字母）或 IATA 城市代码（3 个字母）
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#cityCode")]
        public string cityCode { get; set; }
        /// <summary>
        /// 如果未提供城市代码，则提供城市的全名
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#cityName")]
        public string cityName { get; set; }
        /// <summary>
        /// 邮政信箱号码代码
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#poBox")]
        public string poBox { get; set; }
        /// <summary>
        /// 邮政编码
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#postalCode")]
        public string postalCode { get; set; }
        /// <summary>
        /// 地区国务院。参考 ISO 3166-2
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#regionCode")]
        public string regionCode { get; set; }
        /// <summary>
        /// 如果未提供州代码，则为州省的全称
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#regionName")]
        public string regionName { get; set; }
        /// <summary>
        /// 街道地址，包括街道名称，街道号码，建筑物编号，公寓等
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#street")]
        public List<string> street { get; set; }

    }
}

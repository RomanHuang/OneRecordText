using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 加载位置详细信息
    /// </summary>
    public class Location
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { "https://onerecord.iata.org/ns/cargo#Location" };
        /// <summary>
        /// 地址详细信息
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#address")]
        public Address address { get; set; }
        /// <summary>
        /// 地理位置详细信息
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#geolocation")]
        public Geolocation geolocation { get; set; }
        /// <summary>
        /// 机场、货运站、海港、火车站的位置代码。UNLOCODE 城市代码（5 个字母）或 IATA 机场代码（3 个字母）
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#code")]
        public string code { get; set; }
        /// <summary>
        /// 位置的全名
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#locationName")]
        public string locationName { get; set; }
        /// <summary>
        /// 位置类型 - 例如机场、货运站、火车站、海港等 Airport, Freight terminal, Rail station, Seaport, etc
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#locationType")]
        public string locationType { get; set; }
    }
}

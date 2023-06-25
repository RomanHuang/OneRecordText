using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 地理位置详细信息 - 例如无人机、自动驾驶汽车...
    /// </summary>
    public class Geolocation
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { "https://onerecord.iata.org/ns/cargo#Geolocation" };
        /// <summary>
        /// 从海平面升高 - 从本体 v1.1 开始将数据类型更改为值
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#elevation")]
        public Value elevation { get; set; }
        /// <summary>
        /// 地理位置坐标，标准为度
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#geolocationUnit")]
        public string geolocationUnit { get; set; }
        /// <summary>
        /// 位置纬度 - 从版本 1.2 开始将数据类型更改为字符串
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#latitude")]
        public string latitude { get; set; }
        /// <summary>
        /// 位置经度 - 从版本 1.2 开始将数据类型更改为字符串
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#longitude")]
        public string longitude { get; set; }
    }
}

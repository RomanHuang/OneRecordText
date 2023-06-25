using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    public class LogisticsEvent
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { "https://onerecord.iata.org/ns/cargo#LogisticsEvent" };

        /// <summary>
        /// 物流对象
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#linkedObject")]
        public LogisticsObject linkedObject { get; set; } = null;

        /// <summary>
        /// 事件发生地址
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#recordedAtLocation")]
        public Location recordedAtLocation { get; set; }
        /// <summary>
        /// 活动执行方
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#country")]
        public Country country { get; set; }

        ///// <summary>
        ///// 活动执行方
        ///// </summary>
        //[JsonProperty("https://onerecord.iata.org/ns/cargo#recordedBy")]
        //public Organization recordedBy { get; set; }

        /// <summary>
        /// 活动执行方
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#recordedBy")]
        public Actor recordedByActor { get; set; }

        /// <summary>
        /// 事件执行时间
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#creationDate")]
        public long? creationDate { get; set; }

        /// <summary>
        /// 事件代码
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#eventCode")]
        public string eventCode { get; set; }
        /// <summary>
        /// 事件执行时间
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#eventDate")]
        public string eventDate { get; set; }
        /// <summary>
        /// 如果未提供事件代码，则事件名称-例如安全许可
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#eventName")]
        public string eventName { get; set; }
        /// <summary>
        /// { "Actual" "Expected" "Planned" "Requested" }
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#eventTimeType")]
        public string eventTimeType { get; set; }
    }
}

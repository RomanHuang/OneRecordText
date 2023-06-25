using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 时间是指运输活动，用于描述特定时间，如实际出发时间等。
    /// </summary>
    public class MovementTimes
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { "https://onerecord.iata.org/ns/cargo#MovementTimes" };

        /// <summary>
        /// 指示是入站还是出站的方向Direction to indicate {"Inbound" , "Outbound" , "UnplannedStop"
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#direction")]
        public string direction { get; set; }

        /// <summary>
        /// 里程碑列表仍然需要定义，它包括CXML代码列表1.92中的元素，但不限于这些值，例如，可以添加挡块开启和挡块关闭时间，作为与车轮关闭和着陆的比较。
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#movementMilestone")]
        public string movementMilestone { get; set; }

        /// <summary>
        /// 移动时间的时间戳（日期和时间）。如果移动时间是异步记录的，则时间戳应该反映实际时间，而不是创建数据的时间。
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#movementTimestamp")]
        public string movementTimestamp { get; set; }

        /// <summary>
        /// 时间类型可以是“实际”、“估计”或“计划”  Actual, Estimated ot Scheduled{"Actual" , "Departed", "Scheduled" }
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#timeType")]
        public string timeType { get; set; }
    }
}

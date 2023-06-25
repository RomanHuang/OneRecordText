using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 日程安排详细信息
    /// </summary>
    public class Schedule : LogisticsObject
    {
        public Schedule()
        {
            types = new List<string>() { Vocabulary.s_c_Schedule };
        }

        /// <summary>
        /// 最早验收日期时间（要求或提议）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_earliestAcceptanceTime_A)]
        public string earliestAcceptanceTime { get; set; }

        /// <summary>
        /// 根据货讯通定义的最晚验收时间（要求的、提议的或实际的）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_latestAcceptanceTime_A)]
        public string latestAcceptanceTime { get; set; }

        /// <summary>
        /// 货讯通定义的装运可用时间
        /// </summary>
        [JsonProperty(Vocabulary.s_p_timeOfAvailability_A)]
        public string timeOfAvailability { get; set; }

        /// <summary>
        /// 根据CargoIQ定义的总运输时间
        /// </summary>
        [JsonProperty(Vocabulary.s_p_totalTransitTime_A)]
        public string totalTransitTime { get; set; }
    }
}

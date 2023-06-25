using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 普雷维索利称之为时间表。此对象是指用于预订选项请求（请求的首选项部分）或预订选项的时间（承运人承诺的LAT时间）
    /// </summary>
    public class BookingTimes : LogisticsObject
    {
        public BookingTimes()
        {
            types = new List<string>() { Vocabulary.s_c_BookingTimes };
        }

        /// <summary>
        /// 参考使用预订时间的预订选项
        /// </summary>
        [JsonProperty(Vocabulary.s_p_bookingOption)]
        public BookingOption bookingOption { get; set; }

        /// <summary>
        /// 参考使用预订时间的BookingOptionRequest
        /// </summary>
        [JsonProperty(Vocabulary.s_p_bookingOptionRequest)]
        public BookingOptionRequest bookingOptionRequest { get; set; }

        /// <summary>
        /// 最早验收日期时间（要求或提议）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_earliestAcceptanceTime)]
        public long? earliestAcceptanceTime { get; set; }

        /// <summary>
        /// 根据货讯通定义的最晚验收时间（要求的、提议的或实际的）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_latestAcceptanceTime)]
        public long? latestAcceptanceTime { get; set; }

        /// <summary>
        /// 货讯通定义的装运可用时间
        /// </summary>
        [JsonProperty(Vocabulary.s_p_timeOfAvailability)]
        public long? timeOfAvailability { get; set; }

        /// <summary>
        /// 根据货讯通定义，以持续时间表示的总运输时间
        /// </summary>
        [JsonProperty(Vocabulary.s_p_totalTransitTime)]
        public string totalTransitTime { get; set; }

    }
}

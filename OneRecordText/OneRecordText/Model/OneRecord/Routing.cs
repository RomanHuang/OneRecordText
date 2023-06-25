using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 路由详细信息
    /// </summary>
    public class Routing : LogisticsObject
    {
        public Routing()
        {
            types = new List<string>() { Vocabulary.s_c_Routing };
        }

        /// <summary>
        /// 对使用路由的BookingOption的引用
        /// </summary>
        [JsonProperty(Vocabulary.s_p_bookingOption_A_A_A)]
        public BookingOption bookingOption { get; set; }

        /// <summary>
        /// 用于识别腿的Scheduled Legs类。可与预订选项请求一起使用，作为首选路线的指示符，或在承运人提出特定路线时与预订选项一起使用。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_scheduledLegs)]
        public List<ScheduledLegs> scheduledLegs { get; set; }

        /// <summary>
        /// 飞机可能性代码
        /// </summary>
        [JsonProperty(Vocabulary.s_p_aircraftPossibilityCode)]
        public string aircraftPossibilityCode { get; set; }

        /// <summary>
        /// 最晚到达日期时间（要求或建议）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_latestArrivalDateTime)]
        public long? latestArrivalDateTime { get; set; }

        /// <summary>
        /// 运输运动的最大连接数（请求或提议）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_maxConnections)]
        public int maxConnections { get; set; }

        /// <summary>
        /// 表示衬行（请求或提议）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_onlineInd)]
        public bool onlineInd { get; set; }

        /// <summary>
        /// 指示是否包括RFS（道路接驳服务）（请求或提议）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_rfsInd)]
        public bool rfsInd { get; set; }
    }
}

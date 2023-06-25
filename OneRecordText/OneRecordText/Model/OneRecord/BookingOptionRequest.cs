using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// Request对象，指报价请求或预订请求
    /// </summary>
    public class BookingOptionRequest: LogisticsObject
    {
        public BookingOptionRequest()
        {
            types = new List<string>() { Vocabulary.s_c_BookingOptionRequest };
        }

        /// <summary>
        /// 与预订Optio请求链接的预订细分市场
        /// </summary>
        [JsonProperty(Vocabulary.s_p_bookingSegment_A)]
        public BookingSegment bookingSegment { get; set; }

        /// <summary>
        /// 相关方（如已知）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_parties_A)]
        public List<Party> parties { get; set; }

        /// <summary>
        /// 请求的分级首选项
        /// </summary>
        [JsonProperty(Vocabulary.s_p_ratingsPreference)]
        public Ratings ratingsPreference { get; set; }

        /// <summary>
        /// 作为请求一部分的路由详细信息，这些详细信息将用于确定报价是否完全匹配
        /// </summary>
        [JsonProperty(Vocabulary.s_p_routingPreferences)]
        public Routing routingPreferences { get; set; }

        /// <summary>
        /// 安排请求的首选项
        /// </summary>
        [JsonProperty(Vocabulary.s_p_schedulePreferences)]
        public List<Schedule> schedulePreferences { get; set; }

        /// <summary>
        /// 待装运货物的详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_shipmentDetails_A_A)]
        public Shipment shipmentDetails { get; set; }

        /// <summary>
        /// 安排请求的首选项
        /// </summary>
        [JsonProperty(Vocabulary.s_p_timePreferences)]
        public BookingTimes timePreferences { get; set; }

        /// <summary>
        /// 与请求链接的运输段，包括请求的出发和到达地点
        /// </summary>
        [JsonProperty(Vocabulary.s_p_transportMovement_A_A)]
        public List<TransportSegment> transportMovement { get; set; }

        /// <summary>
        /// 请求的单位偏好（例如kg或cm）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_unitsPreference)]
        public Value unitsPreference { get; set; }

        /// <summary>
        /// 参照货代和承运人之间的合同分配
        /// </summary>
        [JsonProperty(Vocabulary.s_p_allotment)]
        public string allotment { get; set; }

        /// <summary>
        /// 预期商品仅用于询价目的。由MCD定义
        /// </summary>
        [JsonProperty(Vocabulary.s_p_expectedCommodities)]
        public List<string> expectedCommodities { get; set; }

        /// <summary>
        /// 请求类型的标识：报价或预订（待确认）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_requestType)]
        public string requestType { get; set; }

        /// <summary>
        /// 请求的处理信息仅用于报价请求
        /// </summary>
        [JsonProperty(Vocabulary.s_p_requestedHandling)]
        public List<string> requestedHandling { get; set; }

        /// <summary>
        /// 指明货物的安全状态，无论是否经过筛选
        /// </summary>
        [JsonProperty(Vocabulary.s_p_shipmentSecurityStatus_A)]
        public string shipmentSecurityStatus { get; set; }

    }
}

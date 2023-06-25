using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 预订分段是指预订选项请求或预订选项（报价或实际预订）的到达和位置详细信息
    /// </summary>
    public class BookingSegment
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { Vocabulary.s_c_BookingSegment };

        /// <summary>
        /// 预订分段的到达位置
        /// </summary>
        [JsonProperty(Vocabulary.s_p_arrivalLocation)]
        public Location arrivalLocation { get; set; }

        /// <summary>
        /// 链接到预订细分市场的预订选项
        /// </summary>
        [JsonProperty(Vocabulary.s_p_bookingOptions)]
        public List<BookingOption> bookingOptions { get; set; }

        /// <summary>
        /// 预订段的出发地点
        /// </summary>
        [JsonProperty(Vocabulary.s_p_departureLocation)]
        public Location departureLocation { get; set; }

        /// <summary>
        /// 链接到预订细分市场的BookingOptionRequest
        /// </summary>
        [JsonProperty(Vocabulary.s_p_requests)]
        public List<BookingOptionRequest> requests { get; set; }

        /// <summary>
        /// 当它是请求的一部分时，它指的是来自客户的首选运输ID。当作为预订选项（优惠或实际预订）的一部分时，它指的是预期的运输ID或航班
        /// </summary>
        [JsonProperty(Vocabulary.s_p_preferredTransportId)]
        public string preferredTransportId { get; set; }


    }
}

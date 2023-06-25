using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 与优惠/预订相关的价格
    /// </summary>
    public class Price : LogisticsObject
    {
        public Price()
        {
            types = new List<string>() { Vocabulary.s_c_Price };
        }

        /// <summary>
        /// 预订或报价参考
        /// </summary>
        [JsonProperty(Vocabulary.s_p_bookingOption_A_A)]
        public BookingOption bookingOption { get; set; }

        /// <summary>
        /// 预订或报价参考
        /// </summary>
        [JsonProperty(Vocabulary.s_p_bookingRef)]
        public List<Booking> bookingRef { get; set; }

        /// <summary>
        /// 用于定价的评级
        /// </summary>
        [JsonProperty(Vocabulary.s_p_ratings)]
        public List<Ratings> ratings { get; set; }

        /// <summary>
        /// 承运人的收费代码，例如CA、CB等
        /// </summary>
        [JsonProperty(Vocabulary.s_p_carrierChargeCode)]
        public string carrierChargeCode { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        [JsonProperty(Vocabulary.s_p_grandTotal)]
        public double grandTotal { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [JsonProperty(Vocabulary.s_p_validTo)]
        public long? validTo { get; set; }

    }
}

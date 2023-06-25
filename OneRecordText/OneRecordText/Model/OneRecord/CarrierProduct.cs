using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 运营商产品详细信息
    /// </summary>
    public class CarrierProduct : LogisticsObject
    {
        public CarrierProduct()
        {
            types = new List<string>() { Vocabulary.s_c_CarrierProduct };
        }

        /// <summary>
        /// 参考使用承运商产品的预订选项
        /// </summary>
        [JsonProperty(Vocabulary.s_p_bookingOption_A)]
        public BookingOption bookingOption { get; set; }

        /// <summary>
        /// 承运人的产品代码
        /// </summary>
        [JsonProperty(Vocabulary.s_p_productCode)]
        public string productCode { get; set; }

        /// <summary>
        /// 承运人的产品说明
        /// </summary>
        [JsonProperty(Vocabulary.s_p_productDescription)]
        public string productDescription { get; set; }



    }
}

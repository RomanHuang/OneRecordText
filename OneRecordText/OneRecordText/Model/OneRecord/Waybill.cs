using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    public class Waybill: LogisticsObject
    {
        public Waybill()
        {
            types = new List<string>() { "https://onerecord.iata.org/ns/cargo#Waybill" };
        }
        /// <summary>
        /// 表示会计信息的详细信息。免费文本，例如通过认证支票付款等。
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#accountingInformation")]
        public string accountingInformation { get; set; }

        //[JsonProperty("https://onerecord.iata.org/ns/cargo#billingDetails")]
        //public BillingDetails billingDetails { get; set; }

        /// <summary>
        /// 指预订选项
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#referredBookingOption")]
        public Booking referredBookingOption { get; set; }

        /// <summary>
        /// 分单集合
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#houseWaybills")]
        public List<Waybill> houseWaybills { get; set; }

        /// <summary>
        /// 主单
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#masterWaybill")]
        public Waybill masterWaybill { get; set; }
        /// <summary>
        /// 房屋或主运单唯一标识符
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#waybillNumber")]
        public string waybillNumber { get; set; }

        /// <summary>
        /// 用于运单编号的前缀。参考IATA航空公司代码
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#waybillPrefix")]
        public string waybillPrefix { get; set; }

        /// <summary>
        /// 运单类型：房屋、直接或主运单 House, Direct or Master { "Direct" "House" "Master" }
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#waybillType")]
        public string waybillType { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#shipment")]
        public Shipment shipment { get; set; }


    }
}

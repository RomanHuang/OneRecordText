using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 预订详细信息
    /// </summary>
    public class BookingOption : LogisticsObject
    {
        public BookingOption()
        {
            types = new List<string>() { "https://onerecord.iata.org/ns/cargo#BookingOption" };
        }


        /// <summary>
        /// 开始日期预订选项的可用时间
        /// </summary>
        [JsonProperty(Vocabulary.s_p_offerValidFrom)]
        public long? offerValidFrom { get; set; }

        /// <summary>
        /// 预订选项可用性的结束日期时间
        /// </summary>
        [JsonProperty(Vocabulary.s_p_offerValidTo)]
        public long? offerValidTo { get; set; }


        ///// <summary>
        ///// 
        ///// </summary>
        //[JsonProperty("https://onerecord.iata.org/ns/cargo#forBookingRequest")]
        //public BookingRequest forBookingRequest { get; set; }

        ///// <summary>
        ///// 预订选项的预订部分
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_bookingSegment)]
        //public BookingSegment bookingSegment { get; set; }

        ///// <summary>
        ///// 预订选项的预订时间详细信息（建议或实际）
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_bookingTimes)]
        //public BookingTimes bookingTimes { get; set; }

        ///// <summary>
        ///// 运营商详细信息
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_carrier_A)]
        //public Company carrier { get; set; }

        ///// <summary>
        ///// 报价中包含的承运人产品参考
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_carrierProductInfo_A)]
        //public CarrierProduct carrierProductInfo { get; set; }

        ///// <summary>
        ///// 收货人详细信息
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_consignee_A)]
        //public List<Company> consignee { get; set; }

        ///// <summary>
        ///// 货运代理详细信息
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_freightForwarder_A)]
        //public List<Company> freightForwarder { get; set; }

        ///// <summary>
        ///// 将预订进展通知其他各方
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_notifyParty_A)]
        //public List<Company> notifyParty { get; set; }

        ///// <summary>
        ///// 参与预订选项的各方（例如发货人、货运代理等）
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_parties)]
        //public List<Party> parties { get; set; }

        ///// <summary>
        ///// 预订价格（如果与报价不同）
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_price_A)]
        //public Price price { get; set; }

        ///// <summary>
        ///// 预订选项请求参考
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_requestRef_A)]
        //public BookingOptionRequest requestRef { get; set; }

        ///// <summary>
        ///// 报价的路由详细信息，将与报价请求的路由首选项进行比较
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_routing_A)]
        //public Routing routing { get; set; }

        ///// <summary>
        ///// 预订选项的时间表详细信息（建议或实际）
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_schedule)]
        //public Schedule schedule { get; set; }

        ///// <summary>
        ///// 待装运货物的详细信息
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_shipmentDetails_A)]
        //public Shipment shipmentDetails { get; set; }

        ///// <summary>
        ///// 发货人详细信息
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_shipper_A)]
        //public List<Company> shipper { get; set; }

        ///// <summary>
        ///// 与报价相关的运输部门，包括出发地和到达地
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_transportMovement_A)]
        //public List<TransportSegment> transportMovement { get; set; }

        ///// <summary>
        ///// 房屋或主运单唯一标识符
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_waybillNumber_A)]
        //public Waybill waybillNumber { get; set; }

        ///// <summary>
        ///// 与销售和预订流程中的步骤相关的预订状态：报价、预订（待确认）
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_bookingStatus)]
        //public string bookingStatus { get; set; }



        ///// <summary>
        ///// 指示报价是否与报价请求完全匹配（布尔值）
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_requestMatchInd)]
        //public bool requestMatchInd { get; set; }

        ///// <summary>
        ///// 指明货物的安全状态，无论是否经过筛选
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_shipmentSecurityStatus)]
        //public string shipmentSecurityStatus { get; set; }

    }
}

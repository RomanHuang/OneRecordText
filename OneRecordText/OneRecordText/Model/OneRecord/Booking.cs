using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 预订详细信息
    /// </summary>
    public class Booking : LogisticsService
    {
        public Booking()
        {
            types = new List<string>() { "https://onerecord.iata.org/ns/cargo#Booking" };
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#forBookingRequest")]
        public BookingRequest forBookingRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#detailedWaybill")]
        public Waybill detailedWaybill { get; set; }




    }
}

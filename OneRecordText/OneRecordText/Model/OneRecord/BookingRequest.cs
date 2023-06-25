using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRecordText.Model.OneRecord
{
    public class BookingRequest: LogisticsObject
    {
        public BookingRequest()
        {
            types = new List<string>() { "https://onerecord.iata.org/ns/cargo#BookingRequest" };
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#booking")]
        public Booking booking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#bookingOption")]
        public BookingOption bookingOption { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 运输移动详细信息，取代v1.1及更高版本中的TransportSegment
    /// </summary>
    public class TransportMovement : LogisticsActivity
    {
        public TransportMovement()
        {
            types = new List<string>() { "https://onerecord.iata.org/ns/cargo#TransportMovement" };
        }

        /// <summary>
        /// 航班号
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#transportIdentifier")]
        public string transportIdentifier { get; set; }

        /// <summary>
        /// 到达地点详细信息
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#arrivalLocation")]
        public Location arrivalLocation { get; set; }

        /// <summary>
        /// 出发地点详细信息
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#departureLocation")]
        public Location departureLocation { get; set; }

        /// <summary>
        /// 参考所有移动时间，如出发、到达等。
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#movementTimes")]
        public List<MovementTimes> movementTimes { get; set; }


        /// <summary>
        /// modeCode: { "0" "1" "2" "3" "4" "5" "6" "7" "8" "9" }
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#modeCode")]
        public string modeCode { get; set; }

        /// <summary>
        /// 预载、主载或车载 { "Main-Carriage" "On-Carriage" "Pre-Carriage" }
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#modeQualifier")]
        public string modeQualifier { get; set; }


    }
}

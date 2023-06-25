using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 用于识别腿的Scheduled Legs类。可与预订选项请求一起使用，作为首选路线的指示符，或在承运人提出特定路线时与预订选项一起使用。
    /// </summary>
    public class ScheduledLegs
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { Vocabulary.s_c_ScheduledLegs };

        /// <summary>
        /// 支腿到达位置
        /// </summary>
        [JsonProperty(Vocabulary.s_p_arrivalLocation_A)]
        public Location arrivalLocation { get; set; }

        /// <summary>
        /// 腿的离开位置
        /// </summary>
        [JsonProperty(Vocabulary.s_p_departureLocation_A)]
        public Location departureLocation { get; set; }

        /// <summary>
        /// 腿的到达日期和时间
        /// </summary>
        [JsonProperty(Vocabulary.s_p_arrivalDate)]
        public List<long?> arrivalDate { get; set; }

        /// <summary>
        /// 航段出发日期和时间
        /// </summary>
        [JsonProperty(Vocabulary.s_p_departureDate)]
        public List<long?> departureDate { get; set; }

        /// <summary>
        /// 支腿的序列号
        /// </summary>
        [JsonProperty(Vocabulary.s_p_sequenceNumber)]
        public int sequenceNumber { get; set; }

        /// <summary>
        /// 支路的运输Id。例如航班号、卡车路线标识符等。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_transportId)]
        public List<string> transportId { get; set; }

    }
}

using Newtonsoft.Json;
using OneRecordText.Model.OneRecord;

namespace OneRecordApiNew.Data.Model
{
    public class BookingOptionModel
    {
        /// <summary>
        /// 运营商详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_carrier_A)]
        public Company carrier { get; set; } = new Company();
        /// <summary>
        /// 开始日期预订选项的可用时间
        /// </summary>
        [JsonProperty(Vocabulary.s_p_offerValidFrom)]
        public long? offerValidFrom { get; set; }

        /// <summary>
        /// 预订选项可用性的结束日期时间
        /// </summary>
        [JsonProperty(Vocabulary.s_p_offerValidTo)]
        public long offerValidTo { get; set; }


    }
}

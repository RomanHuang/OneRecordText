using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 国家详情
    /// </summary>
    public class Country
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { Vocabulary.s_c_Country };
        /// <summary>
        /// 国家 ISO 代码。参考 ISO 3166-2
        /// </summary>
        [JsonProperty(Vocabulary.s_p_countryCode)]
        public string countryCode { get; set; }
        /// <summary>
        /// 国家/地区名称，请参阅 ISO 3166-2
        /// </summary>
        [JsonProperty(Vocabulary.s_p_countryName)]
        public string countryName { get; set; }
    }
}

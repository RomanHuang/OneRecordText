using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 其他标识符
    /// </summary>
    public class OtherIdentifier
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { Vocabulary.s_c_OtherIdentifier };

        /// <summary>
        /// 项目标识符
        /// </summary>
        [JsonProperty(Vocabulary.s_p_identifier)]
        public string identifier { get; set; }
        /// <summary>
        /// 标识符类型或说明
        /// </summary>
        [JsonProperty(Vocabulary.s_p_otherIdentifierType)]
        public string otherIdentifierType { get; set; }
    }
}

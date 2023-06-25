using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 受监管实体
    /// </summary>
    public class RegulatedEntity
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { Vocabulary.s_c_RegulatedEntity };

        /// <summary>
        /// 分支机构/公司
        /// </summary>
        [JsonProperty(Vocabulary.s_p_entity)]
        public CompanyBranch entity { get; set; }

        /// <summary>
        /// 受监管实体标识符（如受监管代理人标识符）是强制性的
        /// </summary>
        [JsonProperty(Vocabulary.s_p_regulatedEntityIdentifier)]
        public Company regulatedEntityIdentifier { get; set; }

        /// <summary>
        /// 到期日期4位数字月/年
        /// </summary>
        [JsonProperty(Vocabulary.s_p_expiryDate_A)]
        public long? expiryDate { get; set; }

        /// <summary>
        /// 当事人类型——例如RA——受监管代理人，KC——已知托运人，AO——飞机运营商，RC——受监管承运人
        /// </summary>
        [JsonProperty(Vocabulary.s_p_regulatedEntityCategory)]
        public string regulatedEntityCategory { get; set; }

    }
}

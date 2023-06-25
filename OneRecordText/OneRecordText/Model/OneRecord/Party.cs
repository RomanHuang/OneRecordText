using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 指公司及其在特定情况下的角色，例如公司a作为发货人。货物XML代码列表1.15可作为添加“通知方”的参考
    /// </summary>
    public class Party
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { Vocabulary.s_c_Party };

        /// <summary>
        /// 对各方的其他标识符的引用。在AWB的上下文中，otherIdentifier对象可以与类型“PrimaryID”（内部ID）、“Additional ID”（标准ID）或“AccountID”（帐号）一起使用。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_otherIdentifiers_A_A)]
        public List<OtherIdentifier> otherIdentifiers { get; set; }

        /// <summary>
        ///对公司的引用
        /// </summary>
        [JsonProperty(Vocabulary.s_p_partyDetails)]
        public Company partyDetails { get; set; }

        /// <summary>
        /// 公司在上下文中的角色。可以参考CXML工具包中的代码列表1.36
        /// </summary>
        [JsonProperty(Vocabulary.s_p_partyRole)]
        public string partyRole { get; set; }
    }
}

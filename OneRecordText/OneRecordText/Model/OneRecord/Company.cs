using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 企业信息实体
    /// </summary>
    public class Company
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; }= new List<string>() { Vocabulary.s_c_Company };

        /// <summary>
        /// 公司分支机构
        /// </summary>
        [JsonProperty(Vocabulary.s_p_branch)]
        public CompanyBranch branch { get; set; }

        /// <summary>
        /// 公司或组织名称
        /// </summary>
        [JsonProperty(Vocabulary.s_p_companyName)]
        public string companyName { get; set; }

        /// <summary>
        /// 国际航空运输协会认可的货运代理7位数字
        /// </summary>
        [JsonProperty(Vocabulary.s_p_iataCargoAgentCode)]
        public string iataCargoAgentCode { get; set; }
    }
}

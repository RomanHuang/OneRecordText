using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{

    public class CompanyBranch
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { Vocabulary.s_c_CompanyBranch };
        /// <summary>
        /// 指分公司的母公司
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/CompanyBranch#company")]
        public Company company { get; set; }
        /// <summary>
        /// 联系人详细信息
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/CompanyBranch#contactPersons")]
        public List<Person> contactPersons { get; set; }
        /// <summary>
        /// 位置和地址详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_location_A)]
        public Location location { get; set; }
        /// <summary>
        /// 其他识别编码（例如 LEI（法人机构识别编码）、TIN（交易商识别码）、PIMA 地址、帐号、增值税 ID、法定注册 ID、DUNS 编号等）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_otherIdentifiers)]
        public List<OtherIdentifier> otherIdentifiers { get; set; }
        /// <summary>
        /// 公司分支机构名称
        /// </summary>
        [JsonProperty(Vocabulary.s_p_branchName)]
        public string branchName { get; set; }
        /// <summary>
        /// 国际航空运输协会 CASS 货运代理 4 位分行编号位置标识符
        /// </summary>
        [JsonProperty(Vocabulary.s_p_iataCargoAgentLocationIdentifier)]
        public string iataCargoAgentLocationIdentifier { get; set; }
    }
}

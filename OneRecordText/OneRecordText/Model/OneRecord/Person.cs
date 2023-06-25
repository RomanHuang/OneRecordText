using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 人员
    /// </summary>
    public class Person
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { Vocabulary.s_c_Person };
        /// <summary>
        /// 公司信息
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/Person#associatedBranch")]
        public CompanyBranch associatedBranch { get; set; }
        /// <summary>
        /// 联系信息
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/Person#contact")]
        public List<Contact> contact { get; set; }
        /// <summary>
        /// 联系人类型-例如紧急联系人、海关联系人、客户联系人
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/Contact#contactType")]
        public string contactType { get; set; }
        /// <summary>
        /// 部门/部门/单位
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/Contact#department")]
        public string department { get; set; }
        /// <summary>
        /// 员工ID
        /// </summary>
        [JsonProperty(Vocabulary.s_p_employeeId)]
        public string employeeId { get; set; }
        /// <summary>
        /// 名字/名字
        /// </summary>
        [JsonProperty(Vocabulary.s_p_firstName)]
        public string firstName { get; set; }
        /// <summary>
        /// 职务/职位
        /// </summary>
        [JsonProperty(Vocabulary.s_p_jobTitle)]
        public string jobTitle { get; set; }
        /// <summary>
        /// 姓氏
        /// </summary>
        [JsonProperty(Vocabulary.s_p_lastName)]
        public string lastName { get; set; }
        /// <summary>
        /// 中间名 其他名称
        /// </summary>
        [JsonProperty(Vocabulary.s_p_middleName)]
        public string middleName { get; set; }
        /// <summary>
        /// 称呼
        /// </summary>
        [JsonProperty(Vocabulary.s_p_salutation)]
        public string salutation { get; set; }

    }
}

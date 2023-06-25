using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 联系方式
    /// </summary>
    public class Contact
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { Vocabulary.s_c_Contact };

        [JsonProperty("https://onerecord.iata.org/Contact#otherIdentifiers")]
        public ContactOther other { get; set; }
        /// <summary>
        /// 联系方式的类型，例如电话号码、邮件地址
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/Contact#contactType")]
        public string contactType { get; set; }
        /// <summary>
        /// 联系人详细信息的值，例如电话号码
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/Contact#contactValue")]
        public string contactValue { get; set; }
    }
}

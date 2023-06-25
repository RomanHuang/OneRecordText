using Newtonsoft.Json;
using OneRecordText.Model.OneRecord;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecordAPI
{
    /// <summary>
    /// 物流互联网中的公司信息
    /// </summary>
    public class CompanyInformation
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { Vocabulary.s_c_CompanyInformation };
        /// <summary>
        /// 公司详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_company)]
        public Company company { get; set; }

        /// <summary>
        /// 公司Id，例如航空公司代码。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_companyId_A)]
        public string companyId { get; set; }
        /// <summary>
        /// 公司在物流互联网中的终点
        /// </summary>
        [JsonProperty(Vocabulary.s_p_serverEndpoint)]
        public string serverEndpoint { get; set; }
        /// <summary>
        /// 服务器支持的内容类型
        /// </summary>
        [JsonProperty(Vocabulary.s_p_supportedContentTypes)]
        public List<string> supportedContentTypes { get; set; }
        /// <summary>
        /// 服务器上支持的物流对象类型
        /// </summary>
        [JsonProperty(Vocabulary.s_p_supportedLogisticsObjects)]
        public List<string> supportedLogisticsObjects { get; set; }
    }
}

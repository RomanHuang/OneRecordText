using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 服务请求详细信息
    /// </summary>
    public class ServiceRequest: LogisticsObject
    {
        public ServiceRequest()
        {
            types = new List<string>() { Vocabulary.s_c_ServiceRequest };
        }

        /// <summary>
        /// 服务请求代码
        /// </summary>
        [JsonProperty(Vocabulary.s_p_code_A)]
        public string code { get; set; }

        /// <summary>
        /// 服务请求描述
        /// </summary>
        [JsonProperty(Vocabulary.s_p_serviceRequestDescription)]
        public string serviceRequestDescription { get; set; }

        /// <summary>
        /// 服务请求语句文本
        /// </summary>
        [JsonProperty(Vocabulary.s_p_statementText)]
        public string statementText { get; set; }

        /// <summary>
        /// 服务请求声明类型-例如危险品、锂离子电池、活体动物证书
        /// </summary>
        [JsonProperty(Vocabulary.s_p_statementType)]
        public string statementType { get; set; }
    }
}

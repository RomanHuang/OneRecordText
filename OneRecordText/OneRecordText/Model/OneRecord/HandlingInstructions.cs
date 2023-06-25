using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 用于提供处理指令，如特殊服务请求（SSR）、特殊处理代码（SPH）或其他服务信息（OSI）
    /// </summary>
    public class HandlingInstructions
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { Vocabulary.s_c_HandlingInstructions };

        /// <summary>
        /// 指请求处理/服务的人员
        /// </summary>
        [JsonProperty(Vocabulary.s_p_requestedBy)]
        public Person requestedBy { get; set; }

        /// <summary>
        /// 操作说明的自由文本说明
        /// </summary>
        [JsonProperty(Vocabulary.s_p_serviceDescription)]
        public string serviceDescription { get; set; }

        /// <summary>
        /// 指提供的处理信息类型：特殊服务请求（SSR）、特殊处理代码（SPH）或其他服务信息（OSI）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_serviceType)]
        public string serviceType { get; set; }

        /// <summary>
        /// 链接到服务类型顶部的服务类型代码。
        /// 如果服务类型为特殊处理，请参阅代码列表1.14或1.16。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_serviceTypeCode)]
        public string serviceTypeCode { get; set; }


    }
}

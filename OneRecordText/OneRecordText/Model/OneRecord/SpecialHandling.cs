using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 特殊处理细节
    /// </summary>
    public class SpecialHandling : LogisticsObject
    {
        public SpecialHandling()
        {
            types = new List<string>() { Vocabulary.s_c_SpecialHandling };
        }

        /// <summary>
        /// 符合IATA标准的特殊处理代码。参考CXML1.16，例如PEP——水果和蔬菜
        /// </summary>
        [JsonProperty(Vocabulary.s_p_code_A_A)]
        public string code { get; set; }

        /// <summary>
        /// 特殊处理文本
        /// </summary>
        [JsonProperty(Vocabulary.s_p_handlingText)]
        public string handlingText { get; set; }
    }
}

using Newtonsoft.Json;
using OneRecordText.Model.OneRecord;

namespace OneRecordApiNew.Data.Model
{
    public class SpecialHandlingModel
    {
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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 产品附加详细信息
    /// </summary>
    public class Characteristics: LogisticsObject
    {
        public Characteristics()
        {
            types = new List<string>() { Vocabulary.s_c_Characteristics };
        }

        /// <summary>
        /// 产品参考
        /// </summary>
        [JsonProperty(Vocabulary.s_p_product)]
        public Product product { get; set; }

        /// <summary>
        /// 产品特性代码-例如CLR-颜色。不限于列表。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_characteristicsType)]
        public string characteristicsType { get; set; }

        /// <summary>
        /// 产品特征值/属性-例如蓝色。。。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_value)]
        public string value { get; set; }
    }
}

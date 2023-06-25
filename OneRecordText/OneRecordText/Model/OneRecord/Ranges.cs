using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 范围详细信息
    /// </summary>
    public class Ranges : LogisticsObject
    {
        public Ranges()
        {
            types = new List<string>() { Vocabulary.s_c_Ranges };
        }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty(Vocabulary.s_p_amount)]
        public double amount { get; set; }

        /// <summary>
        /// 最大数量
        /// </summary>
        [JsonProperty(Vocabulary.s_p_maximumQuantity)]
        public double maximumQuantity { get; set; }

        /// <summary>
        /// 最低数量
        /// </summary>
        [JsonProperty(Vocabulary.s_p_minimumQuantity)]
        public double minimumQuantity { get; set; }

        /// <summary>
        /// 费率类别代码，例如Q。请参阅CXML代码列表1.4费率类别代码
        /// </summary>
        [JsonProperty(Vocabulary.s_p_rateClassCode)]
        public string rateClassCode { get; set; }

        /// <summary>
        /// 额定值类型-参考CXML代码列表1.44 ULD收费代码
        /// </summary>
        [JsonProperty(Vocabulary.s_p_ratingType)]
        public string ratingType { get; set; }

        /// <summary>
        /// 与商品挂钩的特定商品价格
        /// </summary>
        [JsonProperty(Vocabulary.s_p_scr)]
        public string scr { get; set; }

        /// <summary>
        /// 链接到商品的特定商品代码
        /// </summary>
        [JsonProperty(Vocabulary.s_p_unitBasis)]
        public string unitBasis { get; set; }



    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 包装详细信息
    /// </summary>
    public class PackagingType: LogisticsObject
    {
        public PackagingType()
        {
            types = new List<string>() { Vocabulary.s_c_PackagingType };
        }

        /// <summary>
        /// 自由文本。描述包类型。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_packagingTypeDescription)]
        public string packagingTypeDescription { get; set; }

        /// <summary>
        /// 符合UNECE Rec 21附录V和VI的包装类型标识符，例如1A-钢筒-包装材料代码。标识物流单元包装类型。联合国关于危险货物运输的建议书，示范条例
        /// </summary>
        [JsonProperty(Vocabulary.s_p_typeCode)]
        public string typeCode { get; set; }

    }
}

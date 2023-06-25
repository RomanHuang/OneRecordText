using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 海关信息详细信息
    /// </summary>
    public class CustomsInfo: LogisticsObject
    {
        public CustomsInfo()
        {
            types = new List<string>() { Vocabulary.s_c_CustomsInfo };
        }

        /// <summary>
        /// 适用海关信息的单品
        /// </summary>
        [JsonProperty(Vocabulary.s_p_piece)]
        public Piece piece { get; set; }

        /// <summary>
        /// 海关、安全和监管控制信息标识符。符合海关相关信息的编码指标：物品编号“I”、豁免图例“L”、系统停机参考“S”、唯一托运参考编号“U”、移动参考编号“M”。
        /// 参考代码列表1.100
        /// 条件：必须至少完成三个要素中的一个（国家代码、信息标识符或海关、安全和监管控制信息标识符）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_customsInfoContentCode)]
        public string customsInfoContentCode { get; set; }

        /// <summary>
        /// 海关国家代码。参考ISO 3166-2
        /// 条件：必须至少完成三个要素中的一个（国家代码、信息标识符或海关、安全和监管控制信息标识符）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_customsInfoCountryCode)]
        public string customsInfoCountryCode { get; set; }

        /// <summary>
        /// 海关备注的自由文本，未在OCI组成规则表中使用
        /// </summary>
        [JsonProperty(Vocabulary.s_p_customsInfoNote)]
        public string customsInfoNote { get; set; }

        /// <summary>
        /// 信息标识符。识别信息/实体的代码，例如“IMP”代表进口，“EXP”代表出口，“AGT”代表代理人，“ISS”代表签发寄售安全状态的受监管代理人等。
        /// 条件：必须至少完成三个要素中的一个（国家代码、信息标识符或海关、安全和监管控制信息标识符）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_customsInfoSubjectCode)]
        public string customsInfoSubjectCode { get; set; }

        /// <summary>
        /// 补充海关、安全和监管信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_customsInformation)]
        public string customsInformation { get; set; }

    }
}

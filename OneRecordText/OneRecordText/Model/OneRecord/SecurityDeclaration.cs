using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 安全声明详细信息
    /// </summary>
    public class SecurityDeclaration: LogisticsObject
    {
        public SecurityDeclaration()
        {
            types = new List<string>() { Vocabulary.s_c_SecurityDeclaration };
        }

        /// <summary>
        /// 发布安全状态的人员（或员工ID）的姓名
        /// </summary>
        [JsonProperty(Vocabulary.s_p_issuedBy)]
        public Person issuedBy { get; set; }

        /// <summary>
        /// 接受货物保管并接受最初签发的安全状态的任何其他受监管实体
        /// </summary>
        [JsonProperty(Vocabulary.s_p_otherRegulatedEntity)]
        public List<RegulatedEntity> otherRegulatedEntity { get; set; }

        /// <summary>
        /// 与安全声明链接的片段
        /// </summary>
        [JsonProperty(Vocabulary.s_p_piece_A_A)]
        public Piece piece { get; set; }

        /// <summary>
        /// 提供委托的受监管实体
        /// </summary>
        [JsonProperty(Vocabulary.s_p_receivedFrom)]
        public RegulatedEntity receivedFrom { get; set; }

        /// <summary>
        /// 发布安全声明的受监管实体
        /// </summary>
        [JsonProperty(Vocabulary.s_p_regulatedEntityIssuer)]
        public RegulatedEntity regulatedEntityIssuer { get; set; }

        /// <summary>
        /// 国际民航组织成员国可能要求的任何额外信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_additionalSecurityInformation)]
        public string additionalSecurityInformation { get; set; }

        /// <summary>
        /// 豁免代码-例如BIOM-生物医药样品
        /// SMUS-小尺寸货物MAIL-邮件
        /// 生物医药样品
        /// 外交邮袋或外交邮件
        /// LFSM-救生材料NUCL-核材料
        /// TRNS-转运或转运
        /// </summary>
        [JsonProperty(Vocabulary.s_p_groundsForExemption)]
        public List<string> groundsForExemption { get; set; }

        /// <summary>
        /// 发布安全状态的日期和时间
        /// </summary>
        [JsonProperty(Vocabulary.s_p_issuedOn)]
        public long? issuedOn { get; set; }

        /// <summary>
        /// 用于固定货物的其他方法
        /// </summary>
        [JsonProperty(Vocabulary.s_p_otherScreeningMethods)]
        public List<string> otherScreeningMethods { get; set; }

        /// <summary>
        /// 用于固定货物的安检方法
        /// PHS\u2013物理检查和/或手动搜索
        /// VCK-目视检查
        /// XRY-X射线设备
        /// EDS-爆炸物探测系统
        /// EDD-爆炸物探测犬
        /// ETD-爆炸痕迹检测设备-颗粒或蒸汽
        /// CMD-货物金属检测
        /// AOM-受制于任何其他方式：此条目后面应为自由文本，说明用于保护货物的其他方式
        /// </summary>
        [JsonProperty(Vocabulary.s_p_screeningMethod)]
        public List<string> screeningMethod { get; set; }

        /// <summary>
        /// 安全状态指示器（CXML 1.103）-例如SPX-乘客和所有货运飞机的货物安全
        /// </summary>
        [JsonProperty(Vocabulary.s_p_securityStatus_A)]
        public string securityStatus { get; set; }

    }
}

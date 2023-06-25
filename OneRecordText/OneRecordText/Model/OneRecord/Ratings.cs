using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 评级详细信息
    /// </summary>
    public class Ratings : LogisticsObject
    {
        public Ratings()
        {
            types = new List<string>() { Vocabulary.s_c_Ratings };
        }

        /// <summary>
        /// 范围参考
        /// </summary>
        [JsonProperty(Vocabulary.s_p_ranges)]
        public List<Ranges> ranges { get; set; }

        /// <summary>
        /// 用于CASS的计费费用标识符。请参阅CargoXML代码列表1.33
        /// </summary>
        [JsonProperty(Vocabulary.s_p_billingChargeIdentifier)]
        public string billingChargeIdentifier { get; set; }

        /// <summary>
        /// 费用代码，请参阅CargoXML代码列表1.1
        /// </summary>
        [JsonProperty(Vocabulary.s_p_chargeCode)]
        public string chargeCode { get; set; }

        /// <summary>
        /// 费用说明，例如空运、燃料等。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_chargeDescription)]
        public string chargeDescription { get; set; }

        /// <summary>
        /// 指示是预付费还是收款（P、C）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_chargePaymentType)]
        public List<string> chargePaymentType { get; set; }

        /// <summary>
        /// 应与chargeCode、otherChargeCode或billingChargeIdentifier数据属性中表示的代码相匹配的费用类型。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_chargeType)]
        public string chargeType { get; set; }

        /// <summary>
        /// 权利代码，用于定义费用是到期承运人（C）还是到期代理人（A）。请参阅CXML代码列表1.3
        /// </summary>
        [JsonProperty(Vocabulary.s_p_entitlement)]
        public string entitlement { get; set; }

        /// <summary>
        /// 其他费用请参阅CargoXML代码列表1.2
        /// </summary>
        [JsonProperty(Vocabulary.s_p_otherChargeCode)]
        public string otherChargeCode { get; set; }

        /// <summary>
        /// 价格说明，例如街道、集团、现货等。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_priceSpecification)]
        public string priceSpecification { get; set; }

        /// <summary>
        /// 价格规范参考
        /// </summary>
        [JsonProperty(Vocabulary.s_p_priceSpecificationRef)]
        public string priceSpecificationRef { get; set; }

        /// <summary>
        /// 如果费率有适用的数量（通常为时间或数字），则使用
        /// </summary>
        [JsonProperty(Vocabulary.s_p_quantity_A)]
        public string quantity { get; set; }

        /// <summary>
        /// 用于识别评级是正面评级、已发布评级还是实际评级。期望值为F、A、C。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_ratingsType)]
        public string ratingsType { get; set; }

        /// <summary>
        /// IATA费率组合点的3位代码
        /// </summary>
        [JsonProperty(Vocabulary.s_p_rcp)]
        public List<string> rcp { get; set; }

        /// <summary>
        /// 费用小计
        /// </summary>
        [JsonProperty(Vocabulary.s_p_subTotal)]
        public double subTotal { get; set; }

    }
}

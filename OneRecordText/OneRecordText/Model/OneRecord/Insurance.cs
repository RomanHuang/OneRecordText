using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    public class Insurance: LogisticsObject
    {
        public Insurance()
        {
            types = new List<string>() { Vocabulary.s_c_Insurance };
        }

        /// <summary>
        /// 投保方
        /// </summary>
        [JsonProperty(Vocabulary.s_p_coveringParty)]
        public Company coveringParty { get; set; }

        /// <summary>
        /// 保险金额-保险单涵盖的金额
        /// </summary>
        [JsonProperty(Vocabulary.s_p_insuranceAmount)]
        public Value insuranceAmount { get; set; }

        /// <summary>
        /// 被保险货物的参考
        /// </summary>
        [JsonProperty(Vocabulary.s_p_insuranceShipment)]
        public Shipment insuranceShipment { get; set; }

        /// <summary>
        /// 当没有为保险声明值时，此字段应填写值TRUE，否则为FALSE
        /// </summary>
        [JsonProperty(Vocabulary.s_p_nvdIndicator)]
        public bool nvdIndicator { get; set; }
    }
}

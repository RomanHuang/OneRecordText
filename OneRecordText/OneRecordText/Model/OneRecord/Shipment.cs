using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    public class Shipment : PhysicalLogisticsObject
    {
        public Shipment()
        {
            types = new List<string>() { "https://onerecord.iata.org/ns/cargo#Shipment" };
        }

        /// <summary>
        /// 包含部件的详细信息
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#shipmentOfPieces")]
        public List<Piece> shipmentOfPieces { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#deliveryLocation")]
        public Location deliveryLocation { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#totalGrossWeight")]
        public Value totalGrossWeight { get; set; }

        /// <summary>
        /// 体积重量详细信息
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#totalVolumetricWeight")]
        public VolumetricWeight totalVolumetricWeight { get; set; }

        /// <summary>
        /// 尺寸详细信息
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#totalDimensions")]
        public Dimensions totalDimensions { get; set; }

        /// <summary>
        /// 保险详细信息
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#insurance")]
        public Insurance insurance { get; set; }

        /// <summary>
        /// 缔约方详细信息
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#involvedParties")]
        public List<Party> involvedParties { get; set; }




        /// <summary>
        /// 运单唯一标识符（AWB或HWB）
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#waybill")]
        public Waybill waybill { get; set; }


        /// <summary>
        /// 一般货物描述
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#goodsDescription")]
        public string goodsDescription { get; set; }

        /// <summary>
        /// UNCEFACT和ICC定义的标准代码，与不同国家解释最常用贸易术语的国际规则相对应。联合国欧洲经济委员会建议5《2000年国际贸易术语解释通则》。
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#incoterms")]
        public List<string> incoterms { get; set; }

        /// <summary>
        /// 其他费用将在始发地（预付）或目的地（收款）支付{ "C" "P" }
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#otherChargesIndicator")]
        public string otherChargesIndicator { get; set; }



        /// <summary>
        /// 重量/估价的付款将在原产地（预付）或目的地（收款）支付{ "C" "P" }
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#weightValuationIndicator")]
        public string weightValuationIndicator { get; set; }

    }
}

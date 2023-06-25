using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 项目详细信息
    /// </summary>
    public class Item: LogisticsObject
    {
        public Item()
        {
            types = new List<string>() { Vocabulary.s_c_Item };
        }

        /// <summary>
        /// 物品的尺寸
        /// </summary>
        [JsonProperty(Vocabulary.s_p_dimensions)]
        public Dimensions dimensions { get; set; }

        /// <summary>
        /// 包含项的PIECE的URI
        /// </summary>
        [JsonProperty(Vocabulary.s_p_isInPiece)]
        public Piece isInPiece { get; set; }

        /// <summary>
        /// 其他标识符详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_otherIdentifiers_A)]
        public List<OtherIdentifier> otherIdentifiers { get; set; }

        /// <summary>
        /// 产品的URI
        /// </summary>
        [JsonProperty(Vocabulary.s_p_product_A)]
        public Product product { get; set; }

        /// <summary>
        /// 生产国详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_productionCountry)]
        public Country productionCountry { get; set; }

        /// <summary>
        /// 适用时的项目数量，以及相关计量单位
        /// </summary>
        [JsonProperty(Vocabulary.s_p_quantity)]
        public Value quantity { get; set; }

        /// <summary>
        /// 项目目标国家
        /// </summary>
        [JsonProperty(Vocabulary.s_p_targetCountry)]
        public Country targetCountry { get; set; }

        /// <summary>
        /// 基地单位产品价格
        /// </summary>
        [JsonProperty(Vocabulary.s_p_unitPrice)]
        public Value unitPrice { get; set; }

        /// <summary>
        /// 物品的重量
        /// </summary>
        [JsonProperty(Vocabulary.s_p_weight)]
        public Value weight { get; set; }

        /// <summary>
        /// 生产批号/参考号
        /// </summary>
        [JsonProperty(Vocabulary.s_p_batchNumber)]
        public string batchNumber { get; set; }

        /// <summary>
        /// 生产批号/参考号
        /// </summary>
        [JsonProperty(Vocabulary.s_p_lotNumber)]
        public string lotNumber { get; set; }

        /// <summary>
        /// 产品有效期-例如易腐商品或程序性过时商品
        /// </summary>
        [JsonProperty(Vocabulary.s_p_productExpiryDate)]
        public long? productExpiryDate { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        [JsonProperty(Vocabulary.s_p_productionDate)]
        public long? productionDate { get; set; }

        /// <summary>
        /// 单价的产品数量-例如12个（一个鸡蛋1美元）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_quantityForUnitPrice)]
        public double quantityForUnitPrice { get; set; }
    }
}
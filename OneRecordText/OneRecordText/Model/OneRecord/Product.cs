using Newtonsoft.Json;
using System.Collections.Generic;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 产品详细信息
    /// </summary>
    public class Product: LogisticsObject
    {
        public Product()
        {
            types = new List<string>() { Vocabulary.s_c_Item };
        }

        /// <summary>
        /// 产品特性
        /// </summary>
        [JsonProperty(Vocabulary.s_p_characteristics)]
        public List<Characteristics> characteristics { get; set; }

        /// <summary>
        /// 可在其中找到产品的项目的引用。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_isInItems)]
        public List<Item> isInItems { get; set; }

        /// <summary>
        /// 可以找到产品的零件的参考。如果没有项目，则需要填写此项
        /// </summary>
        [JsonProperty(Vocabulary.s_p_isInPieces)]
        public List<Piece> isInPieces { get; set; }

        /// <summary>
        /// 制造公司详细信息和联系方式
        /// </summary>
        [JsonProperty(Vocabulary.s_p_manufacturer)]
        public Company manufacturer { get; set; }

        /// <summary>
        /// 其他产品标识符（例如条形码、UPC、EAN、亚马逊）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_otherIdentifier_A)]
        public List<OtherIdentifier> otherIdentifier { get; set; }

        /// <summary>
        /// 指示应用费率类别代码的特定商品
        /// </summary>
        [JsonProperty(Vocabulary.s_p_commodityItemNumber)]
        public string commodityItemNumber { get; set; }

        /// <summary>
        /// 协调商品代码，参见所用hsType。最少需要6位数字。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_hsCode)]
        public string hsCode { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonProperty(Vocabulary.s_p_hsCommodityDescription)]
        public string hsCommodityDescription { get; set; }

        /// <summary>
        /// 如果未提供代码，商品名称
        /// </summary>
        [JsonProperty(Vocabulary.s_p_hsCommodityName)]
        public List<string> hsCommodityName { get; set; }

        /// <summary>
        /// 识别商品分类所用标准代码类型的参考（布鲁塞尔关税术语、欧盟协调制度代码、联合国标准国际贸易分类）。如果商品代码超过6位，则为必填项
        /// </summary>
        [JsonProperty(Vocabulary.s_p_hsType)]
        public string hsType { get; set; }

        /// <summary>
        /// 产品描述
        /// </summary>
        [JsonProperty(Vocabulary.s_p_productDescription_A)]
        public string productDescription { get; set; }

        /// <summary>
        /// 制造商的唯一产品标识符
        /// </summary>
        [JsonProperty(Vocabulary.s_p_productIdentifier)]
        public string productIdentifier { get; set; }


    }
}
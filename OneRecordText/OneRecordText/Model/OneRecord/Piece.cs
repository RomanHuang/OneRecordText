using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    public class Piece : PhysicalLogisticsObject
    {
        public Piece()
        {
            types = new List<string>() { "https://onerecord.iata.org/ns/cargo#Piece" };
        }

     
        ///// <summary>
        ///// 对工件中包含的项目的引用
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_containedItems)]
        //public List<Item> containedItems { get; set; }

        ///// <summary>
        ///// 包含部件的详细信息
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_containedPieces)]
        //public List<Piece> containedPieces { get; set; }

        ///// <summary>
        ///// 海关详细信息
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_customsInfo)]
        //public List<CustomsInfo> customsInfo { get; set; }

        ///// <summary>
        ///// 尺寸详细信息
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_dimensions_A)]
        //public Dimensions dimensions { get; set; }

        ///// <summary>
        ///// 参考文件详细信息
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_externalReferences)]
        //public List<ExternalReference> externalReferences { get; set; }

        ///// <summary>
        ///// 重量详细信息
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_grossWeight)]
        //public Value grossWeight { get; set; }

        ///// <summary>
        ///// 工件的处理说明/服务请求链接
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_handlingInstructions)]
        //public List<HandlingInstructions> handlingInstructions { get; set; }

        ///// <summary>
        ///// 其他零件标识（例如运输标记、印章）
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_otherIdentifiers_A_A_A)]
        //public List<OtherIdentifier> otherIdentifiers { get; set; }

        ///// <summary>
        ///// 其他第三方公司详细信息，例如需要通知的一方
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_otherParty)]
        //public List<Company> otherParty { get; set; }

        ///// <summary>
        ///// 包装详细信息
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_packagingType)]
        //public PackagingType packagingType { get; set; }

        ///// <summary>
        ///// 指公司及其在特定情况下的角色，例如公司a作为发货人。货物XML代码列表1.15可作为添加“通知方”的参考
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_parties_A_A)]
        //public List<Party> parties { get; set; }

        ///// <summary>
        ///// 工件的产品，当没有项目时是强制性的
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_product_A_A)]
        //public List<Product> product { get; set; }

        ///// <summary>
        ///// 货物生产国，无项目时强制执行
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_productionCountry_A)]
        //public Country productionCountry { get; set; }

        ///// <summary>
        ///// 工件的安全细节
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_securityDeclaration)]
        //public SecurityDeclaration securityDeclaration { get; set; }

        ///// <summary>
        ///// 安全详细信息
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_securityStatus)]
        //public SecurityDeclaration securityStatus { get; set; }

        ///// <summary>
        ///// 安全请求
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_serviceRequest)]
        //public List<ServiceRequest> serviceRequest { get; set; }

        ///// <summary>
        ///// 工件分配到的装运
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_shipment)]
        //public Shipment shipment { get; set; }

        ///// <summary>
        ///// 发货人公司详细信息，例如发货方
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_shipper_A_A)]
        //public Company shipper { get; set; }

        ///// <summary>
        ///// 特殊处理细节
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_specialHandling)]
        //public List<SpecialHandling> specialHandling { get; set; }

        ///// <summary>
        ///// 运输工件的移动
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_transportMovements)]
        //public List<TransportMovement> transportMovements { get; set; }

        ///// <summary>
        ///// 与运输状态相关的分段
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_transportSegments)]
        //public List<TransportSegment> transportSegments { get; set; }

        ///// <summary>
        ///// 将（虚拟）件装载到其上的ULD——ULD的URI
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_uldReference)]
        //public ULD uldReference { get; set; }

        ///// <summary>
        ///// 体积重量详细信息
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_volumetricWeight)]
        //public VolumetricWeight volumetricWeight { get; set; }

        ///// <summary>
        ///// 工件的颜色指示器（布尔值）
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_coload)]
        //public bool coload { get; set; }

        ///// <summary>
        ///// 为运输目的申报的货物价值，如果没有申报价值，则为NVD
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_declaredValueForCarriage)]
        //public List<string> declaredValueForCarriage { get; set; }

        ///// <summary>
        ///// 为海关目的申报的货物价值，如果没有申报价值，则为NVD
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_declaredValueForCustoms)]
        //public List<string> declaredValueForCustoms { get; set; }

        /// <summary>
        /// 一般货物描述
        /// </summary>
        [JsonProperty(Vocabulary.s_p_goodsDescription)]
        public string goodsDescription { get; set; }

        ///// <summary>
        ///// 指定工件的交付方式（散装或ULD）
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_loadType)]
        //public string loadType { get; set; }

        ///// <summary>
        ///// 当没有为Carriage声明值时，此字段可以用TRUE值完成，否则为FALSE
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_nvdForCarriage)]
        //public bool nvdForCarriage { get; set; }

        ///// <summary>
        ///// 当没有向海关申报价值时，此字段可以填写值TRUE，否则为FALSE
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_nvdForCustoms)]
        //public bool nvdForCustoms { get; set; }

        ///// <summary>
        ///// 标识包装标记方式的参考。字段硬编码为“SSCC-18”、“UPC”或“其他”
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_packageMarkCoded)]
        //public string packageMarkCoded { get; set; }

        ///// <summary>
        ///// SSCC-18代码用于包装标记、公司或条形码、自由文本、托盘代码等的价值。
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_packagedeIdentifier)]
        //public string packagedeIdentifier { get; set; }

        ///// <summary>
        ///// 运输标志
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_shippingMarks)]
        //public List<string> shippingMarks { get; set; }

        ///// <summary>
        ///// 托运人的装载和计数（托运人提供的总件数）
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_slac)]
        //public int? slac { get; set; }

        ///// <summary>
        ///// 工件的可堆叠指示符（布尔值）
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_stackable)]
        //public bool stackable { get; set; }

        ///// <summary>
        ///// 工件的可转动指示器（布尔值）
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_turnable)]
        //public bool turnable { get; set; }

        ///// <summary>
        ///// 工件的唯一工件标识符（UPID）。参考国际航空运输协会推荐做法1689
        ///// </summary>
        //[JsonProperty(Vocabulary.s_p_upid_A)]
        //public string upid { get; set; }

    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    public class ULD : LogisticsObject
    {
        public ULD()
        {
            types = new List<string>() { Vocabulary.s_c_ULD };
        }

        /// <summary>
        /// 参考文件详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_externalReference)]
        public List<ExternalReference> externalReference { get; set; }

        /// <summary>
        /// 空集装集装箱的皮重
        /// </summary>
        [JsonProperty(Vocabulary.s_p_tareWeight)]
        public Value tareWeight { get; set; }

        /// <summary>
        /// 运输 ULD 的运输机芯
        /// </summary>
        [JsonProperty(Vocabulary.s_p_transportMovements_A)]
        public List<TransportMovement> transportMovements { get; set; }

        /// <summary>
        /// 与ULD机芯相关的细分市场
        /// </summary>
        [JsonProperty(Vocabulary.s_p_transportSegments_A)]
        public List<TransportSegment> transportSegments { get; set; }

        /// <summary>
        /// 包含（虚拟）作品的详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_upid)]
        public List<Piece> upid { get; set; }

        /// <summary>
        /// 美国 ATA 单位负载设备类型代码，例如 M2
        /// </summary>
        [JsonProperty(Vocabulary.s_p_ataDesignator)]
        public string ataDesignator { get; set; }

        /// <summary>
        /// 指示 ULD 是否损坏
        /// </summary>
        [JsonProperty(Vocabulary.s_p_damageFlag)]
        public bool damageFlag { get; set; }

        /// <summary>
        /// 包含三个滞期代码指示符，请参阅 RP 1654 （BCC， HHH， XXX， ZZZ）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_demurrageCode)]
        public string demurrageCode { get; set; }

        /// <summary>
        /// ULD高度或装载限制代码。请参阅 CXML 代码列表 1.47，例如 R - ULD 高度超过 244 厘米
        /// </summary>
        [JsonProperty(Vocabulary.s_p_loadingIndicator)]
        public string loadingIndicator { get; set; }

        /// <summary>
        /// 门数
        /// </summary>
        [JsonProperty(Vocabulary.s_p_nbDoor)]
        public int nbDoor { get; set; }

        /// <summary>
        /// 配件数量
        /// </summary>
        [JsonProperty(Vocabulary.s_p_nbFittings)]
        public int nbFittings { get; set; }

        /// <summary>
        /// 网数量
        /// </summary>
        [JsonProperty(Vocabulary.s_p_nbNets)]
        public int nbNets { get; set; }

        /// <summary>
        /// 表带数量
        /// </summary>
        [JsonProperty(Vocabulary.s_p_nbStraps)]
        public int nbStraps { get; set; }

        /// <summary>
        /// 包含 ODLN 或操作损坏限制通知的两个指示符代码。ODLN 代码用于在目视检查 ULD 第 7 节、标准规范 403 或 404 的可维护性后定义损坏类型
        /// </summary>
        [JsonProperty(Vocabulary.s_p_odlnCode)]
        public string odlnCode { get; set; }

        /// <summary>
        /// aa、a 或 na 格式的 ULD 所有者代码 - 所有者可以是航空公司或租赁公司
        /// </summary>
        [JsonProperty(Vocabulary.s_p_ownerCode)]
        public string ownerCode { get; set; }

        /// <summary>
        /// 集装序列号
        /// </summary>
        [JsonProperty(Vocabulary.s_p_serialNumber)]
        public string serialNumber { get; set; }

        /// <summary>
        /// 服务条件的指示符，例如 SER 或 DAM
        /// </summary>
        [JsonProperty(Vocabulary.s_p_serviceabilityCode)]
        public string serviceabilityCode { get; set; }

        /// <summary>
        /// 备注或补充信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_uldRemarks)]
        public string uldRemarks { get; set; }

        /// <summary>
        /// ULD 密封编号（如适用）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_uldSealNumber)]
        public string uldSealNumber { get; set; }

        /// <summary>
        /// 标准单位负载设备类型代码，例如 AKE - 认证容器 - 轮廓。请参阅国际航空运输协会（IATA）集装箱技术手册
        /// </summary>
        [JsonProperty(Vocabulary.s_p_uldTypeCode)]
        public string uldTypeCode { get; set; }

    }
}

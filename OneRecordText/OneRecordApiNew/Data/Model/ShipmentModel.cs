using Newtonsoft.Json;
using OneRecordText.Model.OneRecord;

namespace OneRecordApiNew.Data.Model
{
    public class ShipmentModel
    {
        /// <summary>
        /// 包含部件的详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_containedPieces_A)]
        public List<PieceModel> containedPieces { get; set; } = new List<PieceModel>();
        /// <summary>
        /// 适用交货条款要求的出发点或港口、装运地或目的地的名称和UN/LOCODE代码
        /// </summary>
        [JsonProperty(Vocabulary.s_p_deliveryLocation)]
        public List<Location> deliveryLocation { get; set; }

        /// <summary>
        /// 尺寸详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_dimensions_A_A)]
        public List<Dimensions> dimensions { get; set; }

        /// <summary>
        /// 重量详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_totalGrossWeight)]
        public Value totalGrossWeight { get; set; }

        /// <summary>
        /// 体积重量详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_volumetricWeight_A)]
        public VolumetricWeight volumetricWeight { get; set; }

        /// <summary>
        /// 运单唯一标识符（AWB或HWB）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_waybillNumber_A_A)]
        public WaybillModel waybillNumber { get; set; } = new WaybillModel();

        /// <summary>
        /// 交货日期。格式为YYYYMMDD。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_deliveryDate)]
        public long? deliveryDate { get; set; }

        /// <summary>
        /// 一般货物描述
        /// </summary>
        [JsonProperty(Vocabulary.s_p_goodsDescription_A)]
        public string goodsDescription { get; set; }

        /// <summary>
        /// 总件数
        /// </summary>
        [JsonProperty(Vocabulary.s_p_totalPieceCount)]
        public int totalPieceCount { get; set; }

        /// <summary>
        /// 所有工件组的总SLAC
        /// </summary>
        [JsonProperty(Vocabulary.s_p_totalSLAC)]
        public int totalSLAC { get; set; }
    }
}

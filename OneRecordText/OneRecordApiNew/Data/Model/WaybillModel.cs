using Newtonsoft.Json;
using OneRecordText.Model.OneRecord;

namespace OneRecordApiNew.Data.Model
{
    public class WaybillModel
    {
        /// <summary>
        /// 房屋或主运单唯一标识符
        /// </summary>

        public string waybillNumber { get; set; }

        /// <summary>
        /// 用于运单编号的前缀。参考IATA航空公司代码
        /// </summary>

        public string waybillPrefix { get; set; }

        /// <summary>
        /// 运单类型：房屋、直接或主运单 House, Direct or Master
        /// </summary>

        public string waybillType { get; set; }

        /// <summary>
        /// 件数集合
        /// </summary>
        public List<Piece>? shipmentOfPieces { get; set; }
        /// <summary>
        /// 交货地点
        /// </summary>
        public Location? deliveryLocation { get; set; }
        /// <summary>
        /// 总尺寸
        /// </summary>
        public Dimensions? totalDimensions { get; set; }
        /// <summary>
        /// 总重量
        /// </summary>
        public Value totalGrossWeight { get; set; }
        /// <summary>
        /// 总体积重量
        /// </summary>
        public VolumetricWeight? totalVolumetricWeight { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string? goodsDescription { get; set; }
    }
}

using Newtonsoft.Json;
using OneRecordText.Model.OneRecord;
using System.Diagnostics.Metrics;

namespace OneRecordApiNew.Data.Model
{
    public class MWaybillModel
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

        public string waybillType { get; set; } = "Master";
        /// <summary>
        /// 描述
        /// </summary>
        public string goodsDescription { get; set; }

        public string Air { get; set; }
        public string AirNo { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }

        public string loId { get; set; }
    }
}

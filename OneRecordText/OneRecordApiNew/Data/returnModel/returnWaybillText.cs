using Newtonsoft.Json;

namespace OneRecordApiNew.Data.returnModel
{
    public class returnWaybillText
    {
        public string waybillPrefix { get; set; }
        public string waybillType { get; set; }
        public string waybillNumber { get; set; }
        /// <summary>
        /// 国际航空运输协会认可的货运代理7位数字
        /// </summary>
        public string iataCargoAgentCode { get; set; }
        public long? offerValidFrom { get; set; }
        public long? offerValidTo { get; set; }
    }
}

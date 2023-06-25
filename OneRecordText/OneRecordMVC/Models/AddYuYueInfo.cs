using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneRecordMVC.Models
{
    /// <summary>
    /// 预约实体
    /// </summary>
    public class AddYuYueInfo
    {
        /// <summary>
        /// 主运单唯一标识符
        /// </summary>
        public string waybillNumber { get; set; }
        /// <summary>
        /// 用于运单编号的前缀
        /// </summary>
        public string waybillPrefix { get; set; }
        /// <summary>
        /// 运单类型：房屋、直接或主运单 House, Direct or Master
        /// </summary>
        public string waybillType { get; set; }

        /// <summary>
        /// 特殊标记
        /// </summary>
        public string SHC { get; set; }
        /// <summary>
        /// 特殊处理文本
        /// </summary>
        public string handlingText { get; set; }

        /// <summary>
        /// 库位
        /// </summary>
        public string Location { get; set; }
    }
}

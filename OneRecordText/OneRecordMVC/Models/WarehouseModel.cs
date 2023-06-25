using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneRecordMVC.Models
{
    public class WarehouseModel
    {
        /// <summary>
        /// 仓库数
        /// </summary>
        public string number { get; set; }
        /// <summary>
        /// 仓库编码
        /// </summary>
        public string WarehouseLocation { get; set; }
        /// <summary>
        /// 货物Id
        /// </summary>
        public string LoIds { get; set; }
    }

    public class WarehouseInfo {
        /// <summary>
        /// 货物数
        /// </summary>
        public int sum { get; set; }
        /// <summary>
        /// 对象ID
        /// </summary>
        public string Loids { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        public string WarehouseLocation { get; set; }
    }
}

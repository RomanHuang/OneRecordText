using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    public class WareHouse : LogisticsObject
    {
        public WareHouse()
        {
            types = new List<string>() { "https://onerecord.iata.org/WareHouse" };
        }
        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/WareHouse#WarehouseCode")]
        public string WarehouseCode { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/WareHouse#WarehouseName")]
        public string WarehouseName { get; set; }

        /// <summary>
        /// 容量
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/WareHouse#Warehousevolume")]
        public string Warehousevolume { get; set; }

        /// <summary>
        /// 仓库位置
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/WareHouse#WarehouseLocation")]
        public Location WarehouseLocation { get; set; }
    }
}

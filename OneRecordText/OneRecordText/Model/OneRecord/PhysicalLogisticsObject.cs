using Newtonsoft.Json;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRecordText.Model.OneRecord
{
    public class PhysicalLogisticsObject
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonConverter(typeof(UniqueListStringConverter))]
        [JsonProperty("@type")]
        public List<string> types { get; set; } = new List<string>() { "https://onerecord.iata.org/ns/cargo#PhysicalLogisticsObject" };

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#checks")]
        public string? checks { get; set; }
        /// <summary>
        /// 物流对象所在实体的物流互联网中的公司标识符
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#companyIdentifier")]
        public string? companyIdentifier { get; set; }

        /// <summary>
        /// Events对象
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#events")]
        public List<LogisticsEvent>? events { get; set; }

        /// <summary>
        /// 允许将物流对象与物联网设备链接
        /// </summary>
        [JsonProperty("https://onerecord.iata.org/ns/cargo#attachedIotDevices")]
        public List<IotDevice>? attachedIotDevices { get; set; }

        ///// <summary>
        ///// 允许将物流对象与物联网设备链接
        ///// </summary>
        //[JsonProperty("https://onerecord.iata.org/ns/cargo#LogisticsAction")]
        //public List<involvedInActions> LogisticsAction { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#externalReferences")]
        public ExternalReference? externalReferences { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#skeletonIndicator")]
        public booleanType? skeletonIndicator { get; set; }
    }
}

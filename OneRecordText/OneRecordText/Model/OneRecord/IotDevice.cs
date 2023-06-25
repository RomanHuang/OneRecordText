using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 物联网设备详细信息
    /// </summary>
    public class IotDevice : LogisticsObject
    {
        public IotDevice() {
            types = new List<string>() { Vocabulary.s_c_IotDevice };
        }
        /// <summary>
        /// 设备制造商
        /// </summary>
        [JsonProperty(Vocabulary.s_p_deviceManufacturer)]
        public Company deviceManufacturer { get; set; }
        /// <summary>
        /// 与设备相连的传感器参考
        /// </summary>
        [JsonProperty(Vocabulary.s_p_sensors)]
        public List<Sensor> sensors { get; set; }
        /// <summary>
        /// 连接设备链接到的物流对象的引用（URI）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_associatedObject)]
        public string associatedObject { get; set; }
        /// <summary>
        /// 设备的自然语言描述。它可以描述设备的连接方式和位置。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_deviceDescription)]
        public string deviceDescription { get; set; }
        /// <summary>
        /// 设备的商业面额
        /// </summary>
        [JsonProperty(Vocabulary.s_p_deviceModel)]
        public string deviceModel { get; set; }
        /// <summary>
        /// 设备所有者定义的设备名称
        /// </summary>
        [JsonProperty(Vocabulary.s_p_deviceName)]
        public string deviceName { get; set; }
        /// <summary>
        /// 允许唯一标识设备的序列号
        /// </summary>
        [JsonProperty(Vocabulary.s_p_deviceSerialNumber)]
        public string deviceSerialNumber { get; set; }
    }
}

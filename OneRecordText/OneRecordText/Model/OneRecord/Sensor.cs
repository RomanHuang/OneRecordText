using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 传感器详细信息和测量值，链接到连接的设备
    /// </summary>
    public class Sensor: LogisticsObject
    {
        public Sensor()
        {
            types = new List<string>() { Vocabulary.s_c_Sensor };
        }
        /// <summary>
        /// 传感器链接到的物联网设备的参考
        /// </summary>
        [JsonProperty(Vocabulary.s_p_iotDevice)]
        public List<IotDevice> iotDevice { get; set; }
        /// <summary>
        /// 传感器的自然语言描述
        /// </summary>
        [JsonProperty(Vocabulary.s_p_sensorDescription)]
        public string sensorDescription { get; set; }
        /// <summary>
        /// 传感器制造商定义的传感器名称
        /// </summary>
        [JsonProperty(Vocabulary.s_p_sensorName)]
        public string sensorName { get; set; }
        /// <summary>
        /// 允许唯一识别传感器的序列号
        /// </summary>
        [JsonProperty(Vocabulary.s_p_sensorSerialNumber)]
        public string sensorSerialNumber { get; set; }

        /// <summary>
        /// 交互式货物推荐规程中描述的传感器类型
        /// </summary>
        [JsonProperty(Vocabulary.s_p_sensorType)]
        public string sensorType { get; set; }
        /// <summary>
        /// 连接设备链接到的物流对象的引用（URI）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_associatedObject)]
        public string associatedObject { get; set; }
    }
}

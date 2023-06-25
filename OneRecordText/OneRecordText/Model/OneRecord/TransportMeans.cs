using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 交通工具详细信息
    /// </summary>
    public class TransportMeans : LogisticsObject
    {
        public TransportMeans()
        {
            types = new List<string>() { Vocabulary.s_c_TransportMeans };
        }

        /// <summary>
        /// 运输工具运营公司
        /// </summary>
        [JsonProperty(Vocabulary.s_p_transportCompany)]
        public Company transportCompany { get; set; }

        /// <summary>
        /// 使用运输工具的运输运动
        /// </summary>
        [JsonProperty(Vocabulary.s_p_transportMovement_A_A_A_A_A)]
        public TransportMovement transportMovement { get; set; }

        /// <summary>
        /// 相关运输部门
        /// </summary>
        [JsonProperty(Vocabulary.s_p_transportSegment)]
        public List<TransportSegment> transportSegment { get; set; }

        /// <summary>
        /// 某些CO2计算需要
        /// </summary>
        [JsonProperty(Vocabulary.s_p_typicalCO2Coefficient)]
        public Value typicalCO2Coefficient { get; set; }

        /// <summary>
        /// 典型的燃料消耗量（例如20 000L/1 000nm）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_typicalFuelConsumption)]
        public Value typicalFuelConsumption { get; set; }

        /// <summary>
        /// 车辆型号或品牌（例如A330-300）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_vehicleModel)]
        public string vehicleModel { get; set; }

        /// <summary>
        /// 车辆识别-例如飞机注册号
        /// </summary>
        [JsonProperty(Vocabulary.s_p_vehicleRegistration)]
        public string vehicleRegistration { get; set; }

        /// <summary>
        /// 车辆尺寸-免费文本
        /// </summary>
        [JsonProperty(Vocabulary.s_p_vehicleSize)]
        public string vehicleSize { get; set; }

        /// <summary>
        /// 车辆或集装箱类型。参考UNECE28，例如4.00.0-飞机，类型未知。对于航空，请参考ATA/ITA飞机类型一节中的IATA标准时间表信息手册
        /// </summary>
        [JsonProperty(Vocabulary.s_p_vehicleType)]
        public string vehicleType { get; set; }
    }
}

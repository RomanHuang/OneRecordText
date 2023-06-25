using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// 运输段详细信息
    /// </summary>
    public class TransportSegment : LogisticsObject
    {
        public TransportSegment()
        {
            types = new List<string>() { Vocabulary.s_c_TransportSegment };
        }

        /// <summary>
        /// 到达地点详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_arrivalLocation_A_A)]
        public Location arrivalLocation { get; set; }

        /// <summary>
        /// 二氧化碳排放量的计算方法
        /// </summary>
        [JsonProperty(Vocabulary.s_p_co2CalculationMethod)]
        public CO2CalcMethod co2CalculationMethod { get; set; }

        /// <summary>
        /// 二氧化碳排放量（例如34千克/公里）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_co2Emissions)]
        public List<CO2Emissions> co2Emissions { get; set; }

        /// <summary>
        /// 出发地点详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_departureLocation_A_A)]
        public Location departureLocation { get; set; }

        /// <summary>
        /// 如果测量的距离不可用，则计算的距离
        /// </summary>
        [JsonProperty(Vocabulary.s_p_distanceCalculated)]
        public Value distanceCalculated { get; set; }

        /// <summary>
        /// 测量的距离
        /// </summary>
        [JsonProperty(Vocabulary.s_p_distanceMeasured)]
        public Value distanceMeasured { get; set; }

        /// <summary>
        /// 对文档或物流对象（URI）的引用
        /// </summary>
        [JsonProperty(Vocabulary.s_p_externalReferences_A_A)]
        public ExternalReference externalReferences { get; set; }

        /// <summary>
        /// 计算的燃油消耗量，如果测量不可用
        /// </summary>
        [JsonProperty(Vocabulary.s_p_fuelAmountCalculated)]
        public Value fuelAmountCalculated { get; set; }

        /// <summary>
        /// 实测油耗
        /// </summary>
        [JsonProperty(Vocabulary.s_p_fuelAmountMeasured)]
        public Value fuelAmountMeasured { get; set; }

        /// <summary>
        /// 运输的实际有效载荷
        /// </summary>
        [JsonProperty(Vocabulary.s_p_payload)]
        public List<Value> payload { get; set; }

        /// <summary>
        /// 交通工具详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_transportMeans)]
        public TransportMeans transportMeans { get; set; }

        /// <summary>
        /// 运输工具操作人员的姓名（如机长、卡车司机）
        /// </summary>
        [JsonProperty(Vocabulary.s_p_transportMeansOperators)]
        public List<Person> transportMeansOperators { get; set; }

        /// <summary>
        /// 分配给运输段的工件
        /// </summary>
        [JsonProperty(Vocabulary.s_p_transportedPieces)]
        public List<Piece> transportedPieces { get; set; }

        /// <summary>
        /// 分配给运输段的ULD
        /// </summary>
        [JsonProperty(Vocabulary.s_p_transportedPieces)]
        public List<ULD> transportedUlds { get; set; }

        /// <summary>
        /// 例如煤油、柴油、SAF、电力[可再生]、电力[不可再生]
        /// </summary>
        [JsonProperty(Vocabulary.s_p_fuelType)]
        public string fuelType { get; set; }

        /// <summary>
        /// 运输方式代码，参见UNECE Rec.19
        /// </summary>
        [JsonProperty(Vocabulary.s_p_modeCode)]
        public string modeCode { get; set; }

        /// <summary>
        /// 预载、主载或车载
        /// </summary>
        [JsonProperty(Vocabulary.s_p_modeQualifier)]
        public string modeQualifier { get; set; }

        /// <summary>
        /// 印章标识符
        /// </summary>
        [JsonProperty(Vocabulary.s_p_seal)]
        public string seal { get; set; }

        /// <summary>
        /// 航空公司航班号或铁路/卡车/海运线路id
        /// </summary>
        [JsonProperty(Vocabulary.s_p_transportIdentifier)]
        public string transportIdentifier { get; set; }

    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// CO2计算
    /// </summary>
    public class CO2Emissions : LogisticsObject
    {
        public CO2Emissions()
        {
            types = new List<string>() { Vocabulary.s_c_CO2Emissions };
        }

        /// <summary>
        /// 计算的二氧化碳排放量
        /// </summary>
        [JsonProperty(Vocabulary.s_p_calculatedEmissions)]
        public Value calculatedEmissions { get; set; }

        /// <summary>
        /// 与二氧化碳排放目标相关的运输运动
        /// </summary>
        [JsonProperty(Vocabulary.s_p_transportMovement_A_A_A)]
        public TransportMovement transportMovement { get; set; }

        /// <summary>
        /// CO2计算方法名称
        /// </summary>
        [JsonProperty(Vocabulary.s_p_methodName)]
        public string methodName { get; set; }

        /// <summary>
        /// 用于计算的版本
        /// </summary>
        [JsonProperty(Vocabulary.s_p_methodVersion)]
        public string methodVersion { get; set; }

    }
}

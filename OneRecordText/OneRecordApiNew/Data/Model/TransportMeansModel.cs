using Newtonsoft.Json;
using OneRecordText.Model.OneRecord;
using System.ComponentModel.DataAnnotations;

namespace OneRecordApiNew.Data.Model
{
    /// <summary>
    /// 航班器信息
    /// </summary>
    public class TransportMeansModel
    {
        /// <summary>
        /// 车辆型号或品牌（例如A330-300）飞机型号
        /// </summary>
        [JsonProperty(Vocabulary.s_p_vehicleModel)]
        public string vehicleModel { get; set; }

        /// <summary>
        /// 车辆识别-例如飞机注册号 航班号
        /// </summary>
        [Required(ErrorMessage = "航班号必填")]
        [JsonProperty(Vocabulary.s_p_vehicleRegistration)]
        public string vehicleRegistration { get; set; }

        /// <summary>
        /// 到达地点详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_arrivalLocation_A_A)]
        public Location? arrivalLocation { get; set; }

        /// <summary>
        /// 出发地点详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_departureLocation_A_A)]
        public Location? departureLocation { get; set; }

        /// <summary>
        /// 参考所有移动时间，如出发、到达等。
        /// </summary>
        [JsonProperty(Vocabulary.s_p_movementTimes)]
        public List<MovementTimes> movementTimes { get; set; }
    }
}

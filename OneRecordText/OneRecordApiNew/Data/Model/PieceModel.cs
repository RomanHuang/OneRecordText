using Newtonsoft.Json;
using OneRecordText.Model.OneRecord;

namespace OneRecordApiNew.Data.Model
{
    public class PieceModel
    {
        /// <summary>
        /// 尺寸详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_dimensions_A)]
        public Dimensions dimensions { get; set; }

        /// <summary>
        /// 重量详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_grossWeight)]
        public Value grossWeight { get; set; }

        /// <summary>
        /// 特殊处理细节
        /// </summary>
        [JsonProperty(Vocabulary.s_p_specialHandling)]
        public List<SpecialHandlingModel> specialHandling { get; set; }

        /// <summary>
        /// 体积重量详细信息
        /// </summary>
        [JsonProperty(Vocabulary.s_p_volumetricWeight)]
        public VolumetricWeight volumetricWeight { get; set; }

        /// <summary>
        /// 运输工件的移动
        /// </summary>
        [JsonProperty(Vocabulary.s_p_transportMovements)]
        public List<TransportMeansModel> transportMovements { get; set; }=new List<TransportMeansModel>();
    }
}

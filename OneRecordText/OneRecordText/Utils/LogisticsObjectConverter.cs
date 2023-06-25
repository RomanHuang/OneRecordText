
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OneRecordText.Model.OneRecord;
using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace OneRecordText.Utils
{
    public class LogisticsObjectConverter : JsonConverter<LogisticsObject>
    {
        public override bool CanRead => true;
        public override bool CanWrite => false;


        public override LogisticsObject ReadJson(JsonReader reader, Type objectType, LogisticsObject existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            // 解析 JSON 数据
            var jsonObject = JObject.Load(reader);

            // 获取 @type 属性的值
            if (jsonObject.TryGetValue("@type", out var typeToken) && typeToken.Type == JTokenType.Array)
            {
                var typeArray = typeToken.Value<JArray>();
                var typeName = typeArray.FirstOrDefault()?.Value<string>();

                // 根据 @type 属性的值创建对应的子类实例
                var instance = CreateInstanceByTypeName(typeName);

                // 使用 Newtonsoft.Json 将 JSON 数据反序列化为子类实例
                if (instance != null)
                {
                    serializer.Populate(jsonObject.CreateReader(), instance);
                    return instance;
                }
            }

            return null;
        }

        public override void WriteJson(JsonWriter writer, LogisticsObject value, JsonSerializer serializer)
        {
            // 使用 Newtonsoft.Json 将子类实例序列化为 JSON 数据
            serializer.Serialize(writer, value);
        }

        private LogisticsObject CreateInstanceByTypeName(string typeName)
        {
            switch (typeName)
            {

                case "https://onerecord.iata.org/SpecialHandling":
                    return new SpecialHandling(); 
                case "https://onerecord.iata.org/Piece":
                    //return new Piece();
                case "https://onerecord.iata.org/WareHouse":
                    return new WareHouse();
                case "https://onerecord.iata.org/Shipment":
                    //return new Shipment();
                case "https://onerecord.iata.org/Waybill":
                    return new Waybill();
                case "https://onerecord.iata.org/BookingOption":
                    return new BookingOption();
                case "https://onerecord.iata.org/TransportMeans":
                    return new TransportMeans();
                case "https://onerecord.iata.org/TransportMovement":
                    //return new TransportMovement();
                default:
                    return new LogisticsObject();
            }
        }
    }
}




using OneRecordText.Model.OneRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OneRecordText.Utils
{
    public class LinkedObjectConverter :JsonConverter<LogisticsObject>
    {
        public override LogisticsObject Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartObject)
            {
                using (JsonDocument document = JsonDocument.ParseValue(ref reader))
                {
                    if (document.RootElement.TryGetProperty("@type", out JsonElement typeElement) && typeElement.ValueKind == JsonValueKind.Array)
                    {
                        var typeNames = typeElement.EnumerateArray().Select(t => t.GetString()).ToArray();
                        switch (typeNames[0])
                        {

                            case "https://onerecord.iata.org/SpecialHandling":
                                return JsonSerializer.Deserialize<SpecialHandling>(document.RootElement.GetRawText(), options);
                            case "https://onerecord.iata.org/Piece":
                                //return JsonSerializer.Deserialize<Piece>(document.RootElement.GetRawText(), options);
                            case "https://onerecord.iata.org/WareHouse":
                                return JsonSerializer.Deserialize<WareHouse>(document.RootElement.GetRawText(), options);
                            case "https://onerecord.iata.org/Shipment":
                                //return JsonSerializer.Deserialize<Shipment>(document.RootElement.GetRawText(), options);
                            case "https://onerecord.iata.org/Waybill":
                                return JsonSerializer.Deserialize<Waybill>(document.RootElement.GetRawText(), options);
                            case "https://onerecord.iata.org/BookingOption":
                                return JsonSerializer.Deserialize<BookingOption>(document.RootElement.GetRawText(), options);
                            case "https://onerecord.iata.org/TransportMeans":
                                return JsonSerializer.Deserialize<TransportMeans>(document.RootElement.GetRawText(), options);
                            case "https://onerecord.iata.org/TransportMovement":
                                //return JsonSerializer.Deserialize<TransportMovement>(document.RootElement.GetRawText(), options);
                                return null;
                        }
                        
                    }
                }
            }

            // 默认情况下返回基类实例
            return JsonSerializer.Deserialize<LogisticsObject>(ref reader, options);
        }

        public override void Write(Utf8JsonWriter writer, LogisticsObject value, JsonSerializerOptions options)
        {
            // 将 LogisticsObject 对象序列化为 JSON 字符串
            var json = JsonSerializer.Serialize(value, value.GetType());

            // 将 JSON 字符串写入 Utf8JsonWriter
            writer.WriteStringValue(json);
        }
    }



}

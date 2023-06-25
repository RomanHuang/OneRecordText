using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model
{
    public class JsonLdConverter: JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true; // 指示此转换器适用于所有类型
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException(); // 这里需要实现针对特定类型的反序列化逻辑
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var jsonObject = JObject.FromObject(value, serializer);
            jsonObject["@type"] = GetJsonLdType(value.GetType()); // 设置 @type 属性
            jsonObject.WriteTo(writer);
        }

        private string GetJsonLdType(Type objectType)
        {
            // 根据对象类型返回对应的 IRI
            // 这里可以根据需要自定义逻辑来获取对应的 IRI
            // 例如使用映射表、命名约定等
            // 下面是一个示例返回固定的 IRI 的逻辑
            return "http://schema.org/" + objectType.Name;
        }

    }
}

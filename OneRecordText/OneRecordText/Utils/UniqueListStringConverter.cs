using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Utils
{
    public class UniqueListStringConverter : JsonConverter<List<string>>
    {
        public override List<string> ReadJson(JsonReader reader, Type objectType, List<string> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (existingValue == null)
            {
                existingValue = new List<string>();
            }
            else
            {
                existingValue.Clear();
            }

            var token = JToken.Load(reader);
            if (token.Type == JTokenType.Array)
            {
                var array = (JArray)token;
                foreach (var item in array)
                {
                    var value = item.Value<string>();
                    if (!existingValue.Contains(value))
                    {
                        existingValue.Add(value);
                    }
                }
            }

            return existingValue;
        }

        public override void WriteJson(JsonWriter writer, List<string> value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }

}

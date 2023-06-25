using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using OneRecordText.Model;
using OneRecordText.Model.OneRecord;
using OneRecordText.Model.OneRecordAPI;
using System;
using System.Collections.Generic;

namespace OneRecordText.Utils
{
    /// <summary>
    /// 转json-ld公共类
    /// </summary>
    public class JsonLdHelp
    {

        /// <summary>
        /// 将POCO类序列化成JSON-LD
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public string POCOToJSONLD<T>(T t)
        {
            try
            {
                //字段为空的不转换成json-ld
                var jsonSettings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };
                var jsonLds = JsonConvert.SerializeObject(t, Formatting.Indented, jsonSettings);
                return jsonLds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 将JSON-LD反序列化成POCO类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonld"></param>
        /// <returns></returns>
        public T JSONLDToPOCO<T>(string jsonld)
        {
            try
            {
              
                //JSON-LD反序列化
                T poco = JsonConvert.DeserializeObject<T>(jsonld);
                return poco;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 将JSON-LD反序列化成POCO集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonld"></param>
        /// <returns></returns>
        public List<T> JSONLDToPOCOList<T>(string jsonld) 
        {
            try
            {
               
                //JSON-LD反序列化
                List<T> poco = JsonConvert.DeserializeObject<List<T>>(jsonld);
                return poco;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

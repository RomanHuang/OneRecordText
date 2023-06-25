using Newtonsoft.Json;
using OneRecordText.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OneRecordApiNew.Data
{
    public class ResultToJson
    {
        /// <summary>
        /// 用于返回Json类型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string toJson(Object obj)
        {

            String str;
            if (obj is String || obj is Char)
            {
                str = obj.ToString();
            }
            else
            {
                str = JsonConvert.SerializeObject(obj);
            }
            
            return str;
        }

        /// <summary>
        /// 用于返回文件流类型
        /// </summary>
        /// <param name="stream">文件流</param>
        /// <param name="fileName">文件名</param>
        /// <returns></returns>
        public static HttpResponseMessage toFile(MemoryStream stream, string fileName)
        {
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage(HttpStatusCode.OK);
            httpResponseMessage.Content = new StreamContent(stream);
            httpResponseMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            //httpResponseMessage.Content.Headers.Add("Content-Disposition", $"attachment;filename*=UTF-8''{HttpUtility.UrlEncode(fileName)}");
            //httpResponseMessage.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
            //{
            //    FileName =$"{HttpUtility.UrlEncode(fileName)}"
            //};

            httpResponseMessage.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
            {
                FileName = fileName
            };
            return httpResponseMessage;
        }
    }
}

using Newtonsoft.Json;
using OneRecordText.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Web;
using static System.Formats.Asn1.AsnWriter;

namespace OneRecordText.Utils
{
    /// <summary>
    /// 接口调用
    /// </summary>
    public class OneRecordAPIHelp
    {
        
        public string GetToken()
        {
            try
            {

                returnData retdata = new returnData();
                string tokenUrl = "https://auth.one-record.lhind.dev/b8a746a6-c540-43f4-92f3-6150ad057215/b2c_1a_hackathon/oauth2/v2.0/token";
                HttpWebRequest request = HttpWebRequest.CreateHttp(tokenUrl);

                request.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
                Dictionary<string, string> parameters = new Dictionary<string, string>();    //参数列表
                parameters.Add("grant_type", "client_credentials");
                parameters.Add("scope", "https://auth.one-record.lhind.dev/ad0d4442-fcb2-4d98-9f8c-b18d3abdf249/.default");
                parameters.Add("client_id", "ad0d4442-fcb2-4d98-9f8c-b18d3abdf249");
                parameters.Add("client_secret", "DU88Q~Hbxt~0J62d7jiECdQl4kXzSJ5HqfGOjdxk");
                //var data = new {
                //    grant_type = "client_credentials", 
                //    scope = "https://auth.one-record.lhind.dev/ad0d4442-fcb2-4d98-9f8c-b18d3abdf249/.default", 
                //    client_id = "ad0d4442-fcb2-4d98-9f8c-b18d3abdf249",
                //    client_secret = "DU88Q~Hbxt~0J62d7jiECdQl4kXzSJ5HqfGOjdxk" };
                //request.Headers.Add("x-authorization", token);
                request.Method = "POST";

                byte[] postData = Encoding.UTF8.GetBytes(BuildQuery(parameters, "utf8"));   //使用utf-8格式组装post参数
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(postData, 0, postData.Length);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();


                var resuleJson = string.Empty;//返回的json数据
                retdata.code = (int)response.StatusCode;
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream, Encoding.GetEncoding("UTF-8")))
                    {
                        resuleJson = reader.ReadToEnd();
                    }
                }
                TokenModel tokenmodel = JsonConvert.DeserializeObject<TokenModel>(resuleJson);

                return tokenmodel.access_token;
            }
            catch (Exception EX)
            {

                throw;
            }
        }
        /// <summary>
        /// post请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <param name="method"></param>
        /// <param name="ContentType"></param>
        /// <returns></returns>
        public returnData MyWebRequest(string url, string data, string method = "POST", string ContentType = "application/ld+json",string bearerToken="")
        {
            try
            {
                if (string.IsNullOrWhiteSpace(bearerToken)) bearerToken = GetToken();
                returnData retdata = new returnData();
                HttpWebRequest request = HttpWebRequest.CreateHttp(url);
                request.ContentType = ContentType;//body数据类型
                //request.Headers.Add("x-authorization", token);
                request.Headers.Add("Authorization", $"Bearer {bearerToken}");
                request.Method = method;
                if (!method.Equals("GET"))
                {
                    using (var postStream = new StreamWriter(request.GetRequestStream()))
                    {
                        postStream.Write(data);
                    }
                }

                var response = (HttpWebResponse)request.GetResponse();
                var resuleJson = string.Empty;//返回的json数据
                retdata.code = (int)response.StatusCode;
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream, Encoding.GetEncoding("UTF-8")))
                    {
                        resuleJson = reader.ReadToEnd();
                    }
                }

                // 获取头部信息
                WebHeaderCollection headers = response.Headers;
                foreach (string header in headers.AllKeys)
                {
                    if (header.Contains("Location"))
                    {
                        retdata.headerUrl = headers[header];
                    }

                }
                return retdata;
            }
            catch (Exception EX)
            {

                throw;
            }
        }

        /// <summary>
        /// get请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <param name="method"></param>
        /// <param name="ContentType"></param>
        /// <returns></returns>
        public string MyGetWebRequest(string url, string bearerToken = "")
        {
            WebRequest request = WebRequest.Create(url);
            if (string.IsNullOrWhiteSpace(bearerToken)) bearerToken = GetToken();
            request.Method = "GET";
            request.Headers.Add("Authorization", $"Bearer {bearerToken}");
            var response = (HttpWebResponse)request.GetResponse();
            var resuleJson = string.Empty;//返回的json数据
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.GetEncoding("UTF-8")))
                {
                    resuleJson = reader.ReadToEnd();
                }
            }
            return resuleJson;
        }

        //组装请求参数
        private string BuildQuery(IDictionary<string, string> parameters, string encode)
        {
            StringBuilder postData = new StringBuilder();
            bool hasParam = false;
            IEnumerator<KeyValuePair<string, string>> dem = parameters.GetEnumerator();
            while (dem.MoveNext())
            {
                string name = dem.Current.Key;
                string value = dem.Current.Value;
                // 忽略参数名或参数值为空的参数
                if (!string.IsNullOrEmpty(name))
                {
                    if (hasParam)
                    {
                        postData.Append("&");
                    }
                    postData.Append(name);
                    postData.Append("=");
                    if (encode == "gb2312")
                    {
                        postData.Append(HttpUtility.UrlEncode(value, Encoding.GetEncoding("gb2312")));
                    }
                    else if (encode == "utf8")
                    {
                        postData.Append(HttpUtility.UrlEncode(value, Encoding.UTF8));
                    }
                    else
                    {
                        postData.Append(value);
                    }
                    hasParam = true;
                }
            }
            return postData.ToString();
        }

    }
}

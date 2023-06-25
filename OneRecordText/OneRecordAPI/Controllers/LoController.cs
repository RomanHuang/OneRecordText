using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OneRecordAPI.Data;
using OneRecordText;
using OneRecordText.Model;
using OneRecordText.Model.OneRecord;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OneRecordAPI.Controllers
{
    /// <summary>
    /// 物流对象控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoController : ControllerBase
    {
        JsonLdHelp LdHelp = new JsonLdHelp();
        OneRecordAPIHelp oRAPIHelp = new OneRecordAPIHelp();
        string URL = "http://172.19.111.117:8080/companies/";


        /// <summary>
        /// 新增Piece物流对象
        /// </summary>
        /// <param name="piece"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        [HttpPost]
        public returnData PostPiece([FromBody] Piece piece, string companyId)
        {
            try
            {
                var jsonld = LdHelp.POCOToJSONLD<Piece>(piece);
                string url = URL + companyId + "/los";
                var ret = oRAPIHelp.MyWebRequest(url, jsonld);
                return ret;
            }
            catch (Exception ex)
            {
                return new returnData() { code = (int)HttpStatusCode.InternalServerError, headerUrl = ex.Message };
            }
        }

        /// <summary>
        /// 新增ULD物流对象
        /// </summary>
        /// <param name="uld"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        [HttpPost]
        public returnData PostULD([FromBody] ULD uld, string companyId)
        {
            try
            {
                var jsonld = LdHelp.POCOToJSONLD<ULD>(uld);
                string url = URL + companyId + "/los";
                var ret = oRAPIHelp.MyWebRequest(url, jsonld);
                //return ResultToJson.toJson(new { code = HttpStatusCode.OK, data = ret, msg = "" });
                return ret;
            }
            catch (Exception ex)
            {
                return new returnData() { code = (int)HttpStatusCode.InternalServerError, headerUrl = ex.Message };
            }
        }

        /// <summary>
        /// 新增Shipment物流对象
        /// </summary>
        /// <param name="shipment"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        [HttpPost]
        public returnData PostShipment([FromBody] Shipment shipment, string companyId)
        {
            try
            {
                var jsonld = LdHelp.POCOToJSONLD<Shipment>(shipment);
                string url = URL + companyId + "/los";
                var ret = oRAPIHelp.MyWebRequest(url, jsonld);
                //return ResultToJson.toJson(new { code = HttpStatusCode.OK, data = ret, msg = "" });
                return ret;
            }
            catch (Exception ex)
            {
                return new returnData() { code = (int)HttpStatusCode.InternalServerError, headerUrl = ex.Message };
            }
        }

        /// <summary>
        /// 新增Waybill物流对象,并将booking信息添加enent
        /// </summary>
        /// <param name="waybill"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        [HttpPost]
        public returnData PostWaybill([FromBody] Waybill waybill, string companyId)
        {
            try
            {
                var jsonld = LdHelp.POCOToJSONLD<Waybill>(waybill);
                BookingOption Booking = new BookingOption();
                Booking = waybill.booking;
                string url = URL + companyId + "/los";
                var ret = oRAPIHelp.MyWebRequest(url, jsonld);
                if (ret != null && !string.IsNullOrWhiteSpace(ret.headerUrl) && Booking != null)
                {
                    string loId = ret.headerUrl;
                    Event ent = new Event()
                    {
                        dateTime = (long)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds,
                        eventCode = "KAYY",
                        eventName = "口岸预约",
                        eventTypeIndicator = "计划Scheduled",
                        linkedObject = Booking
                    };
                    var entjsonld = LdHelp.POCOToJSONLD<Event>(ent);
                    string enturl = loId + "/events";
                    var entret = oRAPIHelp.MyWebRequest(enturl, entjsonld);

                }
                return ret;
            }
            catch (Exception ex)
            {
                return new returnData() { code = (int)HttpStatusCode.InternalServerError, headerUrl = ex.Message };
            }
        }

        /// <summary>
        /// 新增BookingOption物流对象
        /// </summary>
        /// <param name="booking"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        [HttpPost]
        public returnData PostBookingOption([FromBody] BookingOption booking, string companyId)
        {
            try
            {
                var jsonld = LdHelp.POCOToJSONLD<BookingOption>(booking);
                string url = URL + companyId + "/los";
                var ret = oRAPIHelp.MyWebRequest(url, jsonld);
                //return ResultToJson.toJson(new { code = HttpStatusCode.OK, data = ret, msg = "" });
                return ret;
            }
            catch (Exception ex)
            {
                return new returnData() { code = (int)HttpStatusCode.InternalServerError, headerUrl = ex.Message };
            }
        }
        //[HttpPost]
        //public returnData PostAllLo([FromBody] LogisticsObject logistics, string companyId)
        //{
        //    try
        //    {
        //        var jsonld = LdHelp.POCOToJSONLD<LogisticsObject>(logistics);
        //        string url = URL + companyId + "/los";
        //        var ret = oRAPIHelp.MyWebRequest(url, jsonld);
        //        //return ResultToJson.toJson(new { code = HttpStatusCode.OK, data = ret, msg = "" });
        //        return ret;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}

        /// <summary>
        /// 新增事件
        /// </summary>
        /// <param name="ent">事件</param>
        /// <param name="loId">对象id</param>
        /// <returns></returns>
        [HttpPost]
        public returnData PostEvent([FromBody][JsonConverter(typeof(LogisticsObjectConverter))] Event ent, string loId)
        {
            try
            {

                //string typeName = loId.Split('/')[loId.Split('/').Length - 1].Split('_')[0];
                var jsonld = LdHelp.POCOToJSONLD<Event>(ent);
                string url = loId + "/events";
                var ret = oRAPIHelp.MyWebRequest(url, jsonld);
                //return ResultToJson.toJson(new { code = HttpStatusCode.OK, data = ret, msg = "" });
                return ret;
            }
            catch (Exception ex)
            {
                return new returnData() { code = (int)HttpStatusCode.InternalServerError, headerUrl = ex.Message };
            }
        }

        /// <summary>
        /// 获取LO的Event集合信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<ApiResponse> GetLoEvent(string LoId)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                string url = LoId + "/events";

                var ret = oRAPIHelp.MyGetWebRequest(url);
                var dt = LdHelp.JSONLDToPOCOList<Event>(ret);
                response.Success = HttpStatusCode.OK;
                response.Data = dt;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = HttpStatusCode.InternalServerError;
                response.Data = ex.Message;
                return response;
            }
        }


        /// <summary>
        /// 获取所有LO的基本信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<ApiResponse> GetLoAllInfo(string companyId)
        {
            ApiResponse response = new ApiResponse();
            try
            {

                string url = "http://172.19.111.117:8080/companies/" + companyId + "/los";
                var ret = oRAPIHelp.MyGetWebRequest(url);
                var dt = LdHelp.JSONLDToPOCOList<LogisticsObject>(ret);
                response.Success = HttpStatusCode.OK;
                response.Data = dt;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = HttpStatusCode.InternalServerError;
                response.Data = ex.Message;
                return response;
            }
        }

        /// <summary>
        /// 获取LO的信息
        /// </summary>
        /// <param name="LoId">ID</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<ApiResponse> GetLoInfo(string LoId)
        {
            ApiResponse response = new ApiResponse();
            try
            {

                string typeName = LoId.Split('/')[LoId.Split('/').Length - 1].Split('_')[0];
                string url = LoId;// "http://172.19.111.117:8080/companies/QR/los/" + LoId;
                var ret = oRAPIHelp.MyGetWebRequest(url);
                switch (typeName)
                {
                    case "Waybill":
                        response.Data = LdHelp.JSONLDToPOCO<Waybill>(ret);
                        response.Success = HttpStatusCode.OK;
                        break;
                    case "ULD":
                        response.Data = LdHelp.JSONLDToPOCO<ULD>(ret);
                        response.Success = HttpStatusCode.OK;
                        break;
                    case "Shipment":
                        response.Data = LdHelp.JSONLDToPOCO<Shipment>(ret);
                        response.Success = HttpStatusCode.OK;
                        break;
                    case "Piece":
                        response.Data = LdHelp.JSONLDToPOCO<Piece>(ret);
                        response.Success = HttpStatusCode.OK;
                        break;
                    case "BookingOption":
                        response.Data = LdHelp.JSONLDToPOCO<BookingOption>(ret);
                        response.Success = HttpStatusCode.OK;
                        break;

                }
                return response;
            }
            catch (Exception ex)
            {
                response.Success = HttpStatusCode.InternalServerError;
                response.Data = ex.Message;
                return response;
            }
        }

        /// <summary>
        /// 获取jsonld
        /// </summary>
        /// <param name="loId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<ApiResponse> GetJsonLd(string loId)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                
                string url = loId;
                var ret = oRAPIHelp.MyGetWebRequest(url);
                response.Data = ret;
                response.Success = HttpStatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = HttpStatusCode.InternalServerError;
                response.Data = ex.Message;
                return response;
            }

        }

    }
}

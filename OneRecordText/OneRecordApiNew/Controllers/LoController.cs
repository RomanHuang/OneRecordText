using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OneRecordApiNew.Data;
using OneRecordApiNew.Data.returnModel;
using OneRecordText.Model;
using OneRecordText.Model.OneRecord;
using OneRecordText.Utils;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;


namespace OneRecordApiNew.Controllers
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
        string URL = ConfigurationHelper.GetConfigValue("ORURL");//"http://172.19.111.117:8080/companies/";


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
                piece.companyIdentifier = URL + companyId;
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
                uld.companyIdentifier = URL + companyId;
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
                shipment.companyIdentifier = URL + companyId;
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
                waybill.companyIdentifier = URL + companyId;
                var jsonld = LdHelp.POCOToJSONLD<Waybill>(waybill);
                Booking booking = new Booking();
                booking = waybill.referredBookingOption;
                string url = URL + companyId + "/los";
                //查询是否有重复
                var awbs = oRAPIHelp.MyGetWebRequest(url);
                var settings = new JsonSerializerSettings
                {
                    Converters = new List<JsonConverter> { new LogisticsObjectConverter() }
                };
                // 使用 JsonSerializerSettings 反序列化 JSON 字符串为 LogisticsObject 对象
                var logisticsObject = JsonConvert.DeserializeObject<List<LogisticsObject>>(awbs, settings);

                List<Waybill> waybills = new List<Waybill>();
                foreach (var item in logisticsObject)
                {
                    if (item is Waybill wayb)
                    {
                        waybills.Add(wayb);
                    }
                }
                if (waybills.Where(v => v.waybillNumber.Equals(waybill.waybillNumber) && v.waybillPrefix.Equals(waybill.waybillPrefix)).ToList().Count > 0) {
                    return new returnData() { code = 204, headerUrl = "已有重复运单！" };
                }

                var ret = oRAPIHelp.MyWebRequest(url, jsonld);
                if (ret != null && !string.IsNullOrWhiteSpace(ret.headerUrl) && booking != null)
                {
                    string loId = ret.headerUrl;
                    LogisticsEvent ent = new LogisticsEvent()
                    {
                        eventDate = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                        eventCode = "KAYY",
                        eventName = "portDeclaration",
                        eventTimeType = "计划Scheduled"
                        //linkedObject = booking
                    };
                    var entjsonld = LdHelp.POCOToJSONLD<LogisticsEvent>(ent);
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
                booking.companyIdentifier = URL + companyId;
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
        //public returnData PostAllLo([FromBody]LogisticsObject logistics, string companyId)
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
        public returnData PostEvent([FromBody][JsonConverter(typeof(LinkedObjectConverter))] LogisticsEvent ent, string loId)
        {
            try
            {

                //string typeName = loId.Split('/')[loId.Split('/').Length - 1].Split('_')[0];
                var jsonld = LdHelp.POCOToJSONLD<LogisticsEvent>(ent);
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
        /// 根据运单获取Lo
        /// </summary>
        /// <param name="companyId"></param>
        /// <param name="awb"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<ApiResponse> GetLoByAwb([FromQuery]string companyId,string? awb) {
            ApiResponse response = new ApiResponse();
            try
            {
                string url = URL + companyId + "/los";
                var ret = oRAPIHelp.MyGetWebRequest(url);
                var settings = new JsonSerializerSettings
                {
                    Converters = new List<JsonConverter> { new LogisticsObjectConverter() }
                };

                // 使用 JsonSerializerSettings 反序列化 JSON 字符串为 LogisticsObject 对象
                var logisticsObject = JsonConvert.DeserializeObject<List<LogisticsObject>>(ret, settings);

                //var dt = LdHelp.JSONLDToPOCOList<LogisticsObject>(ret);

                List<Waybill> waybills = new List<Waybill>();
                foreach (var item in logisticsObject)
                {
                    if (item is Waybill waybill) {
                        waybills.Add(waybill);
                    }
                }
                var Data = waybills.Where(v => v.waybillNumber.Contains(awb==null?"":awb) || v.waybillPrefix.Contains(awb == null ? "" : awb)).ToList();
                response.Data = Data.Select(v => new returnWaybillText()
                {
                    waybillPrefix = v.waybillPrefix,
                    waybillNumber = v.waybillNumber,
                    //offerValidFrom = v.booking.offerValidFrom,
                    //offerValidTo = v.booking.offerValidTo,
                    waybillType = v.waybillType
                    //iataCargoAgentCode=v.booking.carrier.iataCargoAgentCode
                }).ToList();
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
                var dt = LdHelp.JSONLDToPOCOList<LogisticsEvent>(ret);
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

                string url = URL + companyId + "/los";
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
                string url = LoId;
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

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneRecordApiNew.Data.Model;
using OneRecordText.Model.OneRecord;
using OneRecordText.Model;
using OneRecordText.Utils;
using System.Net;
using OneRecordApiNew.Data;
using OneRecordMySql.Models;
using OneRecordMySql.IRepository;
using OneRecordMySql.Repository;
using OneRecordApiNew.Data.returnModel;
using Newtonsoft.Json;
using System.Diagnostics;

namespace OneRecordApiNew.Controllers
{
    /// <summary>
    /// waybill控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WaybillController : ControllerBase
    {

        private IwaybillRepository Repository;
        public WaybillController(IwaybillRepository _repository)
        {
            Repository = _repository;
        }

        JsonLdHelp LdHelp = new JsonLdHelp();
        OneRecordAPIHelp oRAPIHelp = new OneRecordAPIHelp();
        string URL = ConfigurationHelper.GetConfigValue("ICCSURL");

        /// <summary>
        /// 新增Watbill对象
        /// </summary>
        /// <param name="wb"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<returnData> PostWaybillMeans([FromBody] WaybillModel wb)
        {
            try
            {
                Waybill way = new Waybill()
                {
                    waybillNumber = wb.waybillNumber,
                    waybillPrefix = wb.waybillPrefix,
                    waybillType = wb.waybillType,
                    shipment = new Shipment()
                    {
                        shipmentOfPieces = wb.shipmentOfPieces,
                        totalVolumetricWeight = wb.totalVolumetricWeight,
                        goodsDescription = wb.goodsDescription,
                        deliveryLocation = wb.deliveryLocation,
                        totalDimensions = wb.totalDimensions,
                        totalGrossWeight = wb.totalGrossWeight
                    }
                };
                if (await Repository.queryWaybill(wb.waybillPrefix, wb.waybillNumber))
                {
                    return new returnData() { code = 300, headerUrl = "已有相同运单！" };
                }
                var jsonld = LdHelp.POCOToJSONLD<Waybill>(way);
                string url = URL + "/logistics-objects";
                var ret = oRAPIHelp.MyWebRequest(url, jsonld);
                if (ret.code == 201)
                {

                    LogisticsEvent ent = new LogisticsEvent()
                    {
                        eventCode = "PUP",
                        eventDate = DateTime.UtcNow.AddHours(2).ToString("yyyy-MM-ddTHH:mm:ssZ"),
                        eventName = "PUP"
                    };
                    var entjsonld = LdHelp.POCOToJSONLD<LogisticsEvent>(ent);
                    string enturl = ret.headerUrl + "/logistics-events";
                    var entret = oRAPIHelp.MyWebRequest(enturl, entjsonld);

                    waybill waysql = new waybill()
                    {
                        waybillNumber = wb.waybillNumber,
                        waybillPrefix = wb.waybillPrefix,
                        waybillType = wb.waybillType,
                        totalGrossWeight = wb.totalGrossWeight.value,
                        IdUrl = ret.headerUrl,
                        PiecesCount = wb.shipmentOfPieces != null ? wb.shipmentOfPieces.Count : 0,
                        goodsDescription = wb.goodsDescription,
                        totalVolumetricWeight = wb.totalVolumetricWeight?.chargeableWeight?.value,
                        Event="PUP"
                    };
                    await Repository.Insert(waysql);
                }
                return ret;
            }
            catch (Exception ex)
            {
                return new returnData() { code = (int)HttpStatusCode.InternalServerError, headerUrl = ex.Message };
            }
        }

        /// <summary>
        /// 查询运单列表
        /// </summary>
        /// <param name="awb"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<retData> query(string? awb = "", string? goodsDescription = "",string? AirNo="",string? flyStartTime = "", string? flyEndTime = "",string? downStartTime = "", string? downEndTime = "")
        {
            try
            {
                var data = await Repository.query(awb, goodsDescription, AirNo, flyStartTime, flyEndTime, downStartTime, downEndTime);
                return new retData { Code = 200, data = data };
            }
            catch (Exception ex)
            {
                return new retData { Code = 500, data = ex.ToString() };
            }

        }

        /// <summary>
        /// 获取Waybill的详情信息 jsonld
        /// </summary>
        /// <param name="LoId">ID</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<ApiResponse> GetLoInfo(string LoId)
        {
            ApiResponse response = new ApiResponse();
            try
            {

                //string typeName = LoId.Split('/')[LoId.Split('/').Length - 1].Split('_')[0];
                //string url = LoId;
                var ret = oRAPIHelp.MyGetWebRequest(LoId);
                switch ("Waybill")
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
        /// 获取Waybill的详情信息
        /// </summary>
        /// <param name="LoId">ID</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ApiResponse> GetLoInfoByLoid(string LoId)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var ret = await Repository.queryByLo(LoId);
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
                string url = loId + "/logistics-events";
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
        /// 绑定主运单信息
        /// </summary>
        /// <param name="wb"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<returnData> PostMWaybillModel([FromBody] MWaybillModel wb)
        {
            try
            {
                Waybill way = new Waybill()
                {
                    waybillNumber = wb.waybillNumber,
                    waybillPrefix = wb.waybillPrefix,
                    waybillType = "Master",
                    referredBookingOption = new Booking()
                    {
                        activitySequences = new List<ActivitySequence>()
                        {
                            new ActivitySequence() {
                                activity=new TransportMovement(){
                                    transportIdentifier=wb.Air+wb.AirNo,
                                    movementTimes=new List<MovementTimes>(){
                                        new MovementTimes(){
                                            movementTimestamp=wb.startTime,
                                            timeType="Actual"
                                        },
                                        new MovementTimes(){
                                             movementTimestamp=wb.endTime,
                                            timeType="Actual"
                                        }
                                    }
                                }
                            }
                        }
                    }

                };
                if (await Repository.queryWaybill(wb.waybillPrefix, wb.waybillNumber))
                {
                    return new returnData() { code = 300, headerUrl = "已有相同运单！" };
                }
                LogisticsEvent logistics = new LogisticsEvent()
                {
                    eventCode = "FWB",
                    eventDate = DateTime.UtcNow.AddHours(2).ToString("yyyy-MM-ddTHH:mm:ssZ"),
                    eventName = "FWB",
                    linkedObject = way
                };
                var jsonld = LdHelp.POCOToJSONLD<LogisticsEvent>(logistics);
                string url = wb.loId + "/logistics-events";
                var ret = oRAPIHelp.MyWebRequest(url, jsonld);
                if (ret.code == 201)
                {
                    waybill waysql = new waybill()
                    {
                        MasterWab = wb.waybillPrefix + "-" + wb.waybillNumber,
                        IdUrl = wb.loId,
                        Air = wb.Air,
                        AirNo = wb.AirNo,
                        startTime = wb.startTime,
                        endTime = wb.endTime,
                        Event = "FWB"
                    };
                    await Repository.Update(waysql);
                }

                return ret;
            }
            catch (Exception ex)
            {
                return new returnData() { code = (int)HttpStatusCode.InternalServerError, headerUrl = ex.Message };
            }
        }

        /// <summary>
        /// RIW事件新增手机号
        /// </summary>
        /// <param name="phoneModel">事件</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<returnData> PostRIWEvent([FromBody] PhoneModel phoneModel)
        {
            try
            {
                waybill way = new waybill()
                {
                    IdUrl = phoneModel.IdUrl,
                    Phone = phoneModel.Phone,
                    Event= "RIW"
                };
                LogisticsEvent logisticsEvent = new LogisticsEvent()
                {
                    eventCode = "RIW",
                    eventDate = DateTime.UtcNow.AddHours(2).ToString("yyyy-MM-ddTHH:mm:ssZ"),
                    eventName = "RIW"
                };
                //string typeName = loId.Split('/')[loId.Split('/').Length - 1].Split('_')[0];
                var jsonld = LdHelp.POCOToJSONLD<LogisticsEvent>(logisticsEvent);
                string url = phoneModel.IdUrl + "/logistics-events";
                var ret = oRAPIHelp.MyWebRequest(url, jsonld);
                if (ret.code == 201)
                {
                    await Repository.UpdatePhone(way);
                }
                //return ResultToJson.toJson(new { code = HttpStatusCode.OK, data = ret, msg = "" });
                return ret;
            }
            catch (Exception ex)
            {
                return new returnData() { code = (int)HttpStatusCode.InternalServerError, headerUrl = ex.Message };
            }
        }

        /// <summary>
        /// TPN事件新增手机号
        /// </summary>
        /// <param name="phoneModel">事件</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<returnData> PostTPNEvent([FromBody] PostEventModel entModel)
        {
            try
            {
                waybill way = new waybill()
                {
                    IdUrl = entModel.IdUrl,
                    Event="TPN"
                };
                LogisticsEvent logisticsEvent = new LogisticsEvent()
                {
                    eventCode = "TPN",
                    eventDate = DateTime.UtcNow.AddHours(2).ToString("yyyy-MM-ddTHH:mm:ssZ"),
                    eventName = "TPN"
                };
                //string typeName = loId.Split('/')[loId.Split('/').Length - 1].Split('_')[0];
                var jsonld = LdHelp.POCOToJSONLD<LogisticsEvent>(logisticsEvent);
                string url = entModel.IdUrl + "/logistics-events";
                var ret = oRAPIHelp.MyWebRequest(url, jsonld);
                if (ret.code == 201)
                {
                    await Repository.UpdateEvent(way);
                }
                //return ResultToJson.toJson(new { code = HttpStatusCode.OK, data = ret, msg = "" });
                return ret;
            }
            catch (Exception ex)
            {
                return new returnData() { code = (int)HttpStatusCode.InternalServerError, headerUrl = ex.Message };
            }
        }

        /// <summary>
        /// TPN事件新增手机号
        /// </summary>
        /// <param name="phoneModel">事件</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<returnData> PostPODEvent([FromBody] PostEventModel entModel)
        {
            try
            {
                waybill way = new waybill()
                {
                    IdUrl = entModel.IdUrl,
                    Event = "POD"
                };
                LogisticsEvent logisticsEvent = new LogisticsEvent()
                {
                    eventCode = "POD",
                    eventDate = DateTime.UtcNow.AddHours(2).ToString("yyyy-MM-ddTHH:mm:ssZ"),
                    eventName = "POD"
                };
                //string typeName = loId.Split('/')[loId.Split('/').Length - 1].Split('_')[0];
                var jsonld = LdHelp.POCOToJSONLD<LogisticsEvent>(logisticsEvent);
                string url = entModel.IdUrl + "/logistics-events";
                var ret = oRAPIHelp.MyWebRequest(url, jsonld);
                if (ret.code == 201)
                {
                    await Repository.UpdateEvent(way);
                }
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
        public async Task<ApiResponse> GetLoEvent(string LoId)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                string url = LoId + "/logistics-events";

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
    }
}

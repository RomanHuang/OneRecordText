using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneRecordText.Model.OneRecord;
using OneRecordText.Model;
using OneRecordText.Utils;
using System.Net;
using OneRecordApiNew.Data.Model;
using OneRecordApiNew.Data;

namespace OneRecordApiNew.Controllers
{
    /// <summary>
    /// 航空器api
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TransportController : ControllerBase
    {
        JsonLdHelp LdHelp = new JsonLdHelp();
        OneRecordAPIHelp oRAPIHelp = new OneRecordAPIHelp();
        string URL = ConfigurationHelper.GetConfigValue("ORURL");//"http://172.19.111.117:8080/companies/";

        /// <summary>
        /// 新增TransportMeans对象
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        [HttpPost]
        public returnData PostTransportMeans([FromBody] TransportMeansModel ts, string companyId)
        {
            try
            {
                TransportMeans means = new TransportMeans()
                {
                    companyIdentifier = URL + companyId,
                    vehicleModel=ts.vehicleModel,
                    vehicleRegistration=ts.vehicleRegistration,
                    transportMovement = new TransportMovement() { 
                        arrivalLocation=ts.arrivalLocation,
                        //companyIdentifier=URL+companyId,
                        departureLocation=ts.departureLocation,
                        movementTimes=ts.movementTimes
                    }
                };

                var jsonld = LdHelp.POCOToJSONLD<TransportMeans>(means);
                string url = URL + companyId + "/los";
                var ret = oRAPIHelp.MyWebRequest(url, jsonld);
                return ret;
            }
            catch (Exception ex)
            {
                return new returnData() { code = (int)HttpStatusCode.InternalServerError, headerUrl = ex.Message };
            }
        }


    }
}

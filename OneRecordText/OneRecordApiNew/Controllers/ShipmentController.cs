using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneRecordApiNew.Data;
using OneRecordApiNew.Data.Model;
using OneRecordText.Model.OneRecord;
using OneRecordText.Model;
using OneRecordText.Utils;
using System.Net;

namespace OneRecordApiNew.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        JsonLdHelp LdHelp = new JsonLdHelp();
        OneRecordAPIHelp oRAPIHelp = new OneRecordAPIHelp();
        string URL = ConfigurationHelper.GetConfigValue("ORURL");

        /// <summary>
        /// 新增Shipment对象
        /// </summary>
        /// <param name="sm"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        [HttpPost]
        public returnData PostShipment([FromBody] ShipmentModel sm, string companyId)
        {
            try
            {
                Shipment shipment = new Shipment()
                {
                    companyIdentifier = URL + companyId,
                    
                    waybill = new Waybill() {
                        companyIdentifier = URL + companyId,
                        referredBookingOption = new Booking()
                        {
                            //companyIdentifier = URL + companyId,
                            //offerValidFrom = sm.waybillNumber.booking.offerValidFrom,
                            //carrier = sm.waybillNumber.booking.carrier,
                            //offerValidTo = sm.waybillNumber.booking.offerValidTo

                        },
                        waybillNumber = sm.waybillNumber.waybillNumber,
                        waybillPrefix = sm.waybillNumber.waybillPrefix,
                        waybillType = sm.waybillNumber.waybillType
                    },
                    //deliveryDate=sm.deliveryDate,
                   // deliveryLocation=sm.deliveryLocation,
                    //dimensions = sm.dimensions,
                    goodsDescription = sm.goodsDescription,
                    totalGrossWeight = sm.totalGrossWeight,
                    //volumetricWeight = sm.volumetricWeight,
                    //totalSLAC = sm.totalSLAC,
                    //totalPieceCount = sm.totalPieceCount
                    totalVolumetricWeight = sm.volumetricWeight
                };

                var jsonld = LdHelp.POCOToJSONLD<Shipment>(shipment);
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

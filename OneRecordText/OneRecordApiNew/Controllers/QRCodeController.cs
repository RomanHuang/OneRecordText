using Microsoft.AspNetCore.Mvc;
using OneRecordApiNew.Data;
using OneRecordMySql.IRepository;
using OneRecordText.Model;
using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace OneRecordApiNew.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QRCodeController : ControllerBase
    {
        private IwaybillRepository Repository;
        public QRCodeController(IwaybillRepository _repository)
        {
            Repository = _repository;
        }
        string URL = ConfigurationHelper.GetConfigValue("ORH5URL");

        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="loId"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GenerateQRCode(string loId)
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(URL+"?LoId="+loId, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(20);

            // 添加过期时间文本到二维码图像上
            var expirationText = "Expires: " + DateTime.UtcNow.AddMinutes(5).ToString("yyyy-MM-dd HH:mm:ss");
            using (var graphics = Graphics.FromImage(qrCodeImage))
            using (var font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular))
            using (var brush = new SolidBrush(Color.Black))
            {
                var textSize = graphics.MeasureString(expirationText, font);
                var textX = (qrCodeImage.Width - textSize.Width) / 2;
                var textY = qrCodeImage.Height - textSize.Height - 10;
                graphics.DrawString(expirationText, font, brush, textX, textY);
            }

            var stream = new MemoryStream();
            qrCodeImage.Save(stream, ImageFormat.Png);
            stream.Position = 0;

            return File(stream, "image/png");
        }

        /// <summary>
        /// 校验手机号接口
        /// </summary>
        /// <param name="loId">IDURL</param>
        /// <param name="phone">手机号</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<returnData> VisPhone(string loId, string phone) {
            try
            {
                if (await Repository.queryWaybillPhone(loId, phone))
                {
                    return new returnData() { code = 200, headerUrl = "校验成功！" };
                }
                else {
                    return new returnData() { code = 300, headerUrl = "校验失败！" };
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

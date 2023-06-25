using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneRecordApiNew.Data.Model;
using OneRecordMySql.IRepository;
using OneRecordMySql.Models;
using OneRecordText.Model.OneRecord;
using OneRecordText.Utils;
using System.IO;
using UnityEngine;

namespace OneRecordApiNew.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FileController : ControllerBase
    {

        private IwaybillRepository Repository;
        public FileController(IwaybillRepository _repository)
        {
            Repository = _repository;
        }

        JsonLdHelp LdHelp = new JsonLdHelp();
        OneRecordAPIHelp oRAPIHelp = new OneRecordAPIHelp();

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            // 获取文件名和文件路径
            var fileName = file.FileName;
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", fileName);

            // 将文件保存到指定路径
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok("File uploaded successfully.");
        }

        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UploadImage(string loId,IFormFile file)
        {
            // 检查文件是否为空
            if (file == null || file.Length == 0)
            {
                return BadRequest("未选择文件或文件为空");
            }

            // 检查文件是否为图片
            if (!IsImageFile(file))
            {
                return BadRequest("请选择有效的图片文件");
            }
            string fileSave = "StaticFiles\\upload\\" + DateTime.Now.ToString("yyyyMMdd");
            // 创建存储图片的文件夹（如果不存在）
            string uploadPath = AppDomain.CurrentDomain.BaseDirectory+ fileSave; // 指定上传文件的文件夹路径
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            // 生成唯一的文件名
            string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

            // 图片保存路径
            string filePath = Path.Combine(uploadPath, uniqueFileName);

            // 将文件保存到服务器
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            

            LogisticsEvent logisticsEvent = new LogisticsEvent()
            {
                eventCode = "POD",
                eventDate = DateTime.UtcNow.AddHours(2).ToString("yyyy-MM-ddTHH:mm:ssZ"),
                eventName = "POD"
            };
            //string typeName = loId.Split('/')[loId.Split('/').Length - 1].Split('_')[0];
            var jsonld = LdHelp.POCOToJSONLD<LogisticsEvent>(logisticsEvent);
            string url = loId + "/logistics-events";
            var ret = oRAPIHelp.MyWebRequest(url, jsonld);
            if (ret.code == 201) {
                waybill way = new waybill()
                {
                    IdUrl = loId,
                    ImgPath = Path.Combine(fileSave, uniqueFileName),
                    Event="POD"
                };

                await Repository.UpdateImgPath(way);
            }
            // 返回上传成功的信息或其他需要的数据
            return Ok(Path.Combine(fileSave, uniqueFileName));
        }

        /// <summary>
        /// 获取图片访问路径
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAwbImage(string loId) {
            try
            {
                var path = await Repository.queryPhoto(loId);
                return Ok(path); 
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 判断是否为图片
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private bool IsImageFile(IFormFile file)
        {
            // 检查文件的扩展名是否为图片类型
            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif" };
            string fileExtension = Path.GetExtension(file.FileName).ToLower();
            return allowedExtensions.Contains(fileExtension);
        }
    }
}

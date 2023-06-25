using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneRecordMVC.Autoh;
using OneRecordMVC.Models;
using OneRecordText.Model.OneRecord;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneRecordMVC.Controllers
{
    public class LoController : Controller
    {
        JsonLdHelp LdHelp = new JsonLdHelp();
        OneRecordAPIHelp oRAPIHelp = new OneRecordAPIHelp();
        public string user { get; set; }

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <returns></returns>
        public IActionResult Exit() {
            // 清空 Session
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Home");
        }
        /// <summary>
        /// 前端展示页
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        [LoginCheckFilter]
        public IActionResult Index(int page = 1)
        {
            
            ViewBag.user = HttpContext.Session.GetString("UserName");
            int pageSize = 10; // 每页显示的数据量
            string url = "http://172.19.111.117:8080/companies/QR/los";
            var ret = oRAPIHelp.MyGetWebRequest(url);
            var data = LdHelp.JSONLDToPOCOList<LogisticsObject>(ret);

            // 计算总页数
            int totalPages = (int)Math.Ceiling(data.Count / (double)pageSize);

            // 获取当前页的数据
            List<LogisticsObject> currentPageData = data.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            // 将数据列表和分页信息传递给视图
            ViewBag.Data = currentPageData;
            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;
            ViewBag.jsonld = ret;
            return View();
        }

        /// <summary>
        /// 物流对象详情页Piece
        /// </summary>
        /// <param name="LoId"></param>
        /// <returns></returns>
        [LoginCheckFilter]
        public IActionResult Piece(string LoId = "")
        {
            ViewBag.user = HttpContext.Session.GetString("UserName");
            Piece dt = new Piece();
            if (string.IsNullOrWhiteSpace(LoId))
            {
                dt.handlingInstructions = new List<HandlingInstructions>();
                return View(dt);
            }
            //string typeName = LoId.Split('/')[LoId.Split('/').Length - 1].Split('_')[0];
            string url = LoId;// "http://172.19.111.117:8080/companies/QR/los/" + LoId;
            var ret = oRAPIHelp.MyGetWebRequest(url);
            dt = LdHelp.JSONLDToPOCO<Piece>(ret);
            ViewBag.Data = dt;
            return View(dt);
        }

        /// <summary>
        /// 新增或修改打开窗体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [LoginCheckFilter]
        public ActionResult AddPiece(Piece piece)
        {
            ViewBag.user = HttpContext.Session.GetString("UserName");
            var jsonld = LdHelp.POCOToJSONLD<Piece>(piece);
            string url = "http://172.19.111.117:8080/companies/QR/los";
            var ret = oRAPIHelp.MyWebRequest(url, jsonld);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// 物流对象详情页Waybill
        /// </summary>
        /// <param name="LoId"></param>
        /// <returns></returns>
        [LoginCheckFilter]
        public IActionResult Waybill(string LoId = "")
        {
            ViewBag.user = HttpContext.Session.GetString("UserName");
            Waybill dt = new Waybill();
            if (string.IsNullOrWhiteSpace(LoId))
            {
                dt.containedWaybills = new List<Waybill>();
                dt.carrierDeclarationDate = (long)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
                return View(dt);
            }
            //string typeName = LoId.Split('/')[LoId.Split('/').Length - 1].Split('_')[0];
            string url = LoId;// "http://172.19.111.117:8080/companies/QR/los/" + LoId;
            var ret = oRAPIHelp.MyGetWebRequest(url);
            dt = LdHelp.JSONLDToPOCO<Waybill>(ret);
            //ViewBag.Data = dt;
            return View(dt);
        }

        /// <summary>
        /// 新增或修改打开窗体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [LoginCheckFilter]
        public ActionResult Add(Waybill waybill)
        {
            ViewBag.user = HttpContext.Session.GetString("UserName");
            var jsonld = LdHelp.POCOToJSONLD<Waybill>(waybill);
            string url = "http://172.19.111.117:8080/companies/QR/los";
            var ret = oRAPIHelp.MyWebRequest(url, jsonld);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 事件展示
        /// </summary>
        /// <returns></returns>
        [LoginCheckFilter]
        public ActionResult EventIndex(string loId)
        {
            ViewBag.user = HttpContext.Session.GetString("UserName");
            string url = loId + "/events";
            var ret = oRAPIHelp.MyGetWebRequest(url);
            var data = LdHelp.JSONLDToPOCOList<LogisticsEvent>(ret);
            ViewBag.Id = loId;
            return View(data);
        }

        /// <summary>
        /// Event详情
        /// </summary>
        /// <param name="loId"></param>
        /// <returns></returns>
        [LoginCheckFilter]
        public IActionResult Event(string loId, string EventId)
        {
            ViewBag.user = HttpContext.Session.GetString("UserName");
            string url = loId + "/events";
            var ret = oRAPIHelp.MyGetWebRequest(url);
            var data = LdHelp.JSONLDToPOCOList<LogisticsEvent>(ret);
            LogisticsEvent ent = data.Where(v => v.id.Equals(EventId)).ToList().FirstOrDefault();
            ViewBag.types = "";
            ViewBag.textareas = null;

            if (ent == null)
            {
                ent = new LogisticsEvent();
                ent.dateTime = (long)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
            }

            if (ent != null && ent.linkedObject != null && ent.linkedObject.id != null)
            {
                ViewBag.types = ent.linkedObject.types.FirstOrDefault().Split('/').Last();
                ViewBag.textareas = LdHelp.POCOToJSONLD<LogisticsObject>(ent.linkedObject);
            }

            ViewBag.Id = loId;
            return View(ent);
        }

        /// <summary>
        /// 新增或修改打开窗体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [LoginCheckFilter]
        public ActionResult EventAdd(LogisticsEvent ent, string loId, string jsonlinkedObject, string ldObject)
        {
            ViewBag.user = HttpContext.Session.GetString("UserName");
            //var pic11 = LdHelp.JSONLDToPOCO<LogisticsObject>(jsonlinkedObject);
            switch (ldObject)
            {
                case "Piece":
                    var pic = LdHelp.JSONLDToPOCO<Piece>(jsonlinkedObject);
                    pic.types = pic.types.Distinct().ToList();
                    ent.linkedObject = pic;
                    break;
                case "Waybill":
                    var way = LdHelp.JSONLDToPOCO<Waybill>(jsonlinkedObject);
                    ent.linkedObject = way;
                    break;
                case "SpecialHandling":
                    var sh = LdHelp.JSONLDToPOCO<SpecialHandling>(jsonlinkedObject);
                    ent.linkedObject = sh;
                    break;
            }
            if (ent.eventCode.Equals("WXP3")) {
                var WarehouseModelS = getWarehouseModelS();
                var wxp3 = WarehouseModelS.Where(v => v.WarehouseLocation== "WXP3").ToList().Count();
                if (wxp3 > 0) {
                    string errorMessage = "已经预约满，添加失败"; // 自定义错误信息
                    return BadRequest(errorMessage);
                }
            }
            

            var jsonld = LdHelp.POCOToJSONLD<LogisticsEvent>(ent);
            string url = loId + "/events";
            var ret = oRAPIHelp.MyWebRequest(url, jsonld);
            ViewBag.Id = loId;
            return RedirectToAction("EventIndex", new { loId = loId });
        }



        /// <summary>
        /// 查看jsonld
        /// </summary>
        /// <param name="loId"></param>
        /// <returns></returns>
        [LoginCheckFilter]
        public IActionResult ShowLD(string loId)
        {
            ViewBag.user = HttpContext.Session.GetString("UserName");
            string url = loId;
            var ret = oRAPIHelp.MyGetWebRequest(url);
            ViewBag.jsonld = ret;
            return View();
        }

        /// <summary>
        /// 查看仓库位置
        /// </summary>
        /// <param name="loId"></param>
        /// <returns></returns>
        [LoginCheckFilter]
        [LoginCheckFilter]
        public IActionResult Warehouse()
        {
            ViewBag.user = HttpContext.Session.GetString("UserName");
            var warehouseList = getWarehouseModelS();
            var groupedData = from item in warehouseList
                              group item by item.WarehouseLocation into g
                              select new { Category = g.Key, Items = g.ToList() };
            List<WarehouseInfo> wareList = new List<WarehouseInfo>();

            foreach (var group in groupedData)
            {
                if (group.Category == null) continue;
                WarehouseInfo info = new WarehouseInfo();
                string names = string.Join(", ", group.Items.Select(item => item.LoIds).ToList());

                wareList.Add(new WarehouseInfo()
                {
                    Loids = names,
                    WarehouseLocation = group.Category,
                    sum = group.Items.Count
                });
            }
            ViewBag.data = wareList;
            return View(wareList);
        }

        public List<WarehouseModel> getWarehouseModelS()
        {
            List<WarehouseModel> warehouseList = new List<WarehouseModel>();

            string LCLD = "COL;COI;FRI;FRO;ICE;FRZ;RCL;RDS;CRT;";//冷藏冷冻
            string XHYF = "PER;AVI;PES;PEP;PEM;PEF;ONS;FRU;VEG;";//鲜活易腐
            string WXP = "REX;RCX;RGX;RXB;RXC;RXD;RXE;RXG;RXS;RFG;RNG;RPG;RFL;RFS;RSC;RFW;ROX;ROP;RPB;RIS;RRW;RRY;RRE;RCM;RMD;RSB;DGR;MAG;RBI;";//危险品
            string url = "http://172.19.111.117:8080/companies/QR/los";
            var ret = oRAPIHelp.MyGetWebRequest(url);
            var data = LdHelp.JSONLDToPOCOList<LogisticsObject>(ret);

            foreach (var item in data)
            {
                WarehouseModel warehouse = new WarehouseModel();
                string loId = item.id;
                string lourl = loId + "/events";
                var loret = oRAPIHelp.MyGetWebRequest(lourl);
                var lodata = LdHelp.JSONLDToPOCOList<LogisticsEvent>(loret).OrderBy(v => v.dateTime);
                foreach (var etv in lodata)
                {
                    if (etv.eventCode.Equals("RCF"))
                    { //理货	
                        if (etv.linkedObject is SpecialHandling specialHandling)
                        {
                            if (LCLD.Contains(specialHandling.code))
                            { //冷藏冷冻
                                warehouse.LoIds = loId;
                            }
                            else if (XHYF.Contains(specialHandling.code))
                            { //鲜活易腐
                                warehouse.LoIds = loId;
                            }
                            else if (WXP.Contains(specialHandling.code))
                            { //危险品
                                warehouse.LoIds = loId;
                            }
                        }
                    }
                    else if (("LK1;LK2;LK3;SX1;SX2;SX3;WXP1;WXP2;WXP3").Contains(etv.eventCode))
                    {
                        warehouse.WarehouseLocation = etv.eventCode;
                    }
                    else if (etv.eventCode.Equals("DLV"))
                    { //出库
                        warehouse = null;
                    }

                }
                if (warehouse != null) {
                    warehouseList.Add(warehouse);
                }
                   
            }


            return warehouseList;
        }

        /// <summary>
        /// 打开添加预约信息页面
        /// </summary>
        /// <param name="addYuYue"></param>
        /// <returns></returns>
        [LoginCheckFilter]
        public IActionResult AddYuYue(AddYuYueInfo addYuYue)
        {
            if (addYuYue != null) {
                Waybill wb = new Waybill();
                wb.waybillNumber = addYuYue.waybillNumber;
                wb.waybillPrefix = addYuYue.waybillPrefix;
                wb.waybillType = addYuYue.waybillType;
                wb.companyIdentifier = "http://172.19.111.117:8080/companies/QR";
                var jsonld = LdHelp.POCOToJSONLD<Waybill>(wb);
                string url = "http://172.19.111.117:8080/companies/QR/los";
                var ret = oRAPIHelp.MyWebRequest(url, jsonld);
                string loId = ret.headerUrl;
                LogisticsEvent ent1 = new LogisticsEvent()
                {
                    dateTime = (long)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds,
                    eventCode = "RCF",
                    eventName = "检查货物",
                    linkedObject=new SpecialHandling() {
                    code=addYuYue.SHC,
                    handlingText= addYuYue.handlingText
                    }
                };
                var entjsonld = LdHelp.POCOToJSONLD<LogisticsEvent>(ent1);
                string enturl = loId + "/events";
                var entret = oRAPIHelp.MyWebRequest(enturl, entjsonld);

                LogisticsEvent ent = new LogisticsEvent()
                {
                    dateTime = (long)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds,
                    eventCode = addYuYue.Location,
                    eventName = "入库"
                };

                if (ent.eventCode.Equals("WXP3"))
                {
                    var WarehouseModelS = getWarehouseModelS();
                    var wxp3 = WarehouseModelS.Where(v => v.WarehouseLocation == "WXP3").ToList().Count();
                    if (wxp3 > 0)
                    {
                        string errorMessage = "已经预约满，添加失败"; // 自定义错误信息
                        return BadRequest(errorMessage);
                    }
                }
                 entjsonld = LdHelp.POCOToJSONLD<LogisticsEvent>(ent);
                 entret = oRAPIHelp.MyWebRequest(enturl, entjsonld);
            }

            return RedirectToAction("Warehouse");
        }

        [LoginCheckFilter]
        public IActionResult YuYue(string Location)
        {
            if (Location.Contains("WXP")) {
               
                string WXP = "REX;RCX;RGX;RXB;RXC;RXD;RXE;RXG;RXS;RFG;RNG;RPG;RFL;RFS;RSC;RFW;ROX;ROP;RPB;RIS;RRW;RRY;RRE;RCM;RMD;RSB;DGR;MAG;RBI;";//危险品
                ViewBag.SHClIST = WXP.Split(";").Where(s => !string.IsNullOrEmpty(s))
                      .ToArray();
            }
            else if(Location.Contains("LK"))
            {
                string LCLD = "COL;COI;FRI;FRO;ICE;FRZ;RCL;RDS;CRT;";//冷藏冷冻
                ViewBag.SHClIST = LCLD.Split(";").Where(s => !string.IsNullOrEmpty(s))
                      .ToArray();

            }
            else if (Location.Contains("SX"))
            {
                string XHYF = "PER;AVI;PES;PEP;PEM;PEF;ONS;FRU;VEG;";//鲜活易腐
                ViewBag.SHClIST = XHYF.Split(";").Where(s => !string.IsNullOrEmpty(s))
                      .ToArray(); 
            }
            ViewBag.user = HttpContext.Session.GetString("UserName");
            AddYuYueInfo ayy = new AddYuYueInfo();
            ayy.Location = Location;
            return View(ayy);
        }
    }
}

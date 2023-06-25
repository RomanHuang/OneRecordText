using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OneRecordMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OneRecordMVC.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // 在这里编写验证逻辑
            if (username == "admin" && password == "123456")
            {
                // 登录成功，保存 Name 信息到会话
                HttpContext.Session.SetString("UserName", "管理员");
                // 验证成功，重定向到其他页面或返回其他响应
                return RedirectToAction("Index", "Lo", new { userId = "管理员" });
            }
            else if (username == "agent" && password == "123456") 
            {
                // 登录成功，保存 Name 信息到会话
                HttpContext.Session.SetString("UserName", "代理");
                // 验证成功，重定向到其他页面或返回其他响应
                return RedirectToAction("Index", "Lo", new { userId = "代理" });
            }
            else
            {// 登录成功，保存 Name 信息到会话
                HttpContext.Session.SetString("UserName", "游客");
                return RedirectToAction("Index", "Lo", new { userId = "游客" });
            }
        }

    }
}

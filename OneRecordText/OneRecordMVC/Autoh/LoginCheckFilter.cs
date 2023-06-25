
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OneRecordMVC.Autoh
{
    public class LoginCheckFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // 检查会话中的 Name 信息
            var userName = context.HttpContext.Session.GetString("UserName");
            if (string.IsNullOrEmpty(userName))
            {
                // 未登录，重定向到登录页
                context.Result = new RedirectToActionResult("Login", "Home", null);
            }

            base.OnActionExecuting(context);
        }
    }
}

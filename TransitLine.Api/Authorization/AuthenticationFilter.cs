using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransitLine.Common.Authorization;
using TransitLine.Common.Entity;
using TransitLine.Common.Enum;
using TransitLine.Common.EX;

namespace TransitLine.Api.Authorization
{
    public class AuthenticationFilter : IActionFilter, IResultFilter
    {
        string action = string.Empty, controller = string.Empty, area = string.Empty;


        public void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            action = filterContext.ActionDescriptor.ActionName;
            controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            if (filterContext.Controller.ControllerContext.RouteData.DataTokens.ContainsKey("area"))
                area = filterContext.Controller.ControllerContext.RouteData.DataTokens["area"].ToString();

            if (!string.Equals(area.ToUpper(), "QUERY"))
            {
                RequestHander requestHander = new RequestHander { action = action, area = area, controller = controller };
                BaseAccount account = GetBaseAccount(filterContext.HttpContext.Request.Cookies);
                try
                {
                    OpenValidate.IdentityValidate(requestHander, account);
                }
                catch (CustomException ex)
                {
                    ResponeEntity respone = new ResponeEntity { ErrorCode = ex.code, Reason = ex.message };
                    JsonResult result = new JsonResult() { Data = respone, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
                    filterContext.Result = result;
                    return;
                }

            }

        }
        //获取账户基本信息
        private BaseAccount GetBaseAccount(HttpCookieCollection cookies)
        {
            for (int i = 0; i < cookies.Count; i++)
            {
                if (string.Equals(cookies[i].Name.ToUpper(), "ACCOUNT"))
                {
                    string[] accountInfo = cookies[i].Value.Split('_');
                    BaseAccount account = new BaseAccount { Name = accountInfo[0], Passworld = accountInfo[1] };
                    return account;
                }
            }
            throw new CustomException("没有登录", (int)ErrorEnum.没有登录);
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {

        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {

        }
    }
}
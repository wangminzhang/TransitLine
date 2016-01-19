using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace TransitLine.Common.Entity
{
    public class BaseController : Controller
    {
        public JsonResult AjaxResult(object data = null, bool success = true, string error = "请求失败")
        {
            ResponeEntity respone = new ResponeEntity();
            respone.Reason = "请求成功";
            respone.ErrorCode = 0;
            respone.Result = data;
            if (!success)
            {
                respone.Reason = error;
                respone.ErrorCode = 1;
                respone.Result = null;
            }

            return Json(respone, JsonRequestBehavior.AllowGet);
        }
    }
}

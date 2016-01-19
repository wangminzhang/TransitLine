using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TransitLine.Api.Areas.Query.Controllers
{
    public class BusController : Controller
    {
        /// <summary>
        ///可根据具体公交线路名称获取该公交线路的信息列表，
        ///包括有其所有途径站点，所属公司，首末班车时间等信息
        /// GET: /Query/Bus/
        /// </summary>
        /// <param name="bus">线路号</param>
        /// <returns></returns>
        public string Busline(string bus)
        {
            return "公交线路";
        }

        /// <summary>
        /// 根据具体公交站名获取所有路过该站点的公交线路。
        /// </summary>
        /// <param name="station">站台名称</param>
        /// <returns></returns>
        public string Station(string station)
        {
            return "站台";
        }
    }
}
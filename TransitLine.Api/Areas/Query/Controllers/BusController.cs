using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransitLine.Common.Entity;

namespace TransitLine.Api.Areas.Query.Controllers
{
    public class BusController : BaseController
    {
        public JsonResult Busline(string bus)
        {
            var stats = new List<TransitLine.Common.Entity.Line.Stats>();
            stats.Add(new TransitLine.Common.Entity.Line.Stats { Id = "星塘公交中心", lat = 31.320503, lng = 120.746819 });
            List<TransitLine.Common.Entity.Line.LineEntity> lines = new List<TransitLine.Common.Entity.Line.LineEntity>();
            lines.Add(new TransitLine.Common.Entity.Line.LineEntity
            {
                Id = "110路(星塘公交中心-星塘公交中心)",
                Info = "首末车:06:00-21:30; 票价1元（空调车加价1元，每年3、4、10、11月免收空调费） IC卡六折优惠",
                Stats = stats
            });
            lines.Add(new TransitLine.Common.Entity.Line.LineEntity { Id = "110路下行(星塘公交中心-星塘公交中心)", Info = "首末车:06:00-21:30;" });
            return AjaxResult(lines);
        }

        public string Station(string station)
        {
            return "站台";
        }
    }
}
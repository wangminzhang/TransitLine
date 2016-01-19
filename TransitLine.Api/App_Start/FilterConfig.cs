using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TransitLine.Api
{
    public class FilterConfig
    {
        public static void RegitserGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new TransitLine.Api.Authorization.AuthenticationFilter());
        }
    }
}
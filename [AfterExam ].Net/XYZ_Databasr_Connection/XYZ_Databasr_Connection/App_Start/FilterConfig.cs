﻿using System.Web;
using System.Web.Mvc;

namespace XYZ_Databasr_Connection
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

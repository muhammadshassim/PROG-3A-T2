﻿using System.Web;
using System.Web.Mvc;

namespace PROG_3A_T2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

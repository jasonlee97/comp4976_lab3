﻿using System.Web;
using System.Web.Mvc;

namespace comp4976_lab3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

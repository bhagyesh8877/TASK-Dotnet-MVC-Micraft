﻿using System.Web;
using System.Web.Mvc;

namespace TASK_Dotnet_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

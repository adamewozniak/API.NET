﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WozWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            Response.Redirect("/Swagger/ui/index");
        }
    }
}

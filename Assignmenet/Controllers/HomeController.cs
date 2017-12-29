using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignmenet.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index(int? id)
        {
            TempData["Id"] = id;
            TempData.Keep("Id");
            return View();
        }

        public ActionResult Lastpage()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignmenet.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? id)
        {
            TempData["Id"] = id;
            return View();
        }

        public ActionResult Lastpage()
        {

            TempData["A"] = TempData["Id"];
            return View();
        }
    }
}
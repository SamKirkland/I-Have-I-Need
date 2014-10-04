using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Main.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "I Have/I Need";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "I Have/ I Need";

            return View();
        }
    }
}
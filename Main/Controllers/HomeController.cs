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
            ViewBag.Message = "Have/Need";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Have/Need";

            return View();
        }
    }
}
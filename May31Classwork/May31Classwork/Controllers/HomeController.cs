using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace May31Classwork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Donate()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Personal()
        {
            return View();
        }
    }
}
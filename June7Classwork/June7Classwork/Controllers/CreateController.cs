using June7Classwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace June7Classwork.Controllers
{
    public class CreateController : Controller
    {
        // GET: Create
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            Person p = new Person();
            return View(p);
        }
        public ActionResult ShowResult(Person p)
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using June2Classwork.Models;

namespace June2Classwork.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            ViewBag.status = "200";
            Person p = new Person();
            p.type = "Student";
            p.name = "Abtahi Tajwar";
            return View(p);
        }
    }
}
using June14ClassPerformance.Models;
using June14ClassPerformance.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace June14ClassPerformance.Controllers
{
    public class AdminController : Controller
    {
        Database db = new Database();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            Admin admin = new Admin();
            return View(admin);
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        { 
            if (db.verifyAdmin(admin)) {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login");
            
        }
    }
}
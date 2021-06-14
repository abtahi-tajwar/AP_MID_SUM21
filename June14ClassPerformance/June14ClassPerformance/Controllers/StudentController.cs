using June14ClassPerformance.Models;
using June14ClassPerformance.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace June14ClassPerformance.Controllers
{
    public class StudentController : Controller
    {
        Database db = new Database();
        // GET: Student
        public ActionResult Index()
        {
            List<Student> students = db.getAllStudents();
            return View(students);
        }
        public ActionResult Add()
        {
            Student student = new Student();
            return View(student);
        }
        [HttpPost]
        public ActionResult Add(Student student)
        {
            db.addStudent(student);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            Student student = db.getStudent(id);
            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            db.editStudent(student);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            db.deleteStudent(id);
            return RedirectToAction("Index");
        }
    }
}
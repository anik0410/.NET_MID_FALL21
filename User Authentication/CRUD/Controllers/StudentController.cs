
using CRUD.Auth;
using CRUD.Models;
using CRUD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    [AdminAccess]
    public class StudentController : Controller
    {
        // GET: Student
        [AllowAnonymous]
        //[AllowAnonymous] It is used when we have authorized 95/100 actions but we don't want to authorize 5 actions
        public ActionResult Index()
        {
            /*var logged = Session["Logged"];
            if(logged == null)
            {
                return RedirectToAction("Login", "Home");
            }*/

            Database db = new Database();
            var students = db.Students.Get();
           
            return View(students);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Student s = new Student();
            return View(s);
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Students.Create(s);
                return RedirectToAction("Index");
            }
            return View(s);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Database db = new Database();
           var s = db.Students.Get(id);
            return View(s);
        }
    }
}
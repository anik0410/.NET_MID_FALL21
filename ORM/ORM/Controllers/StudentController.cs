using ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORM.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var db = new UMS_1Entities();// Database db = new Database()
            var data = db.students.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(student s)
        {
            var db = new UMS_1Entities();
            db.students.Add(s);
            db.SaveChanges();// If SaveChanges() function not implemented then it will not reflect in database
            return RedirectToAction("Index");
            
        }
        public ActionResult Edit(int Id)
        {
            /*int[] numbers = { 90, 80, 120, 88, 70, 0 };
            var data = (from s in numbers
                       where s >= 80
                       select s).ToList();
            List<student> students = new List<student>();
            for(int i = 0; i < 100; i++)
            {
                var s = new student()
                {
                    Id = i + 1,
                    Name = "Student " +(i+1)
                };
                students.Add(s);
            }
            var data_1 = (from s in students
                         where s.Id >= 50
                         select new {s.Id,s.Name}).ToList();*/
            var db = new UMS_1Entities();
            var student = (from s in db.students
                          where s.Id == Id
                          select s).FirstOrDefault();

            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(student st)
        {
            var db = new UMS_1Entities();
            var student = (from s in db.students
                           where st.Id == st.Id
                           select s).FirstOrDefault();
            /*student.Name = st.Name;
            student.Dob = st.Dob;
            student.Gender = st.Gender;
            student.Cgpa = st.Cgpa;
            db.SaveChanges();*/
            db.Entry(student).CurrentValues.SetValues(st);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(student st)
        {
            var db = new UMS_1Entities();
            var student = (from s in db.students
                           where st.Id == st.Id
                           select s).FirstOrDefault();
            db.students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
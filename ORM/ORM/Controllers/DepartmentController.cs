using ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORM.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            var db = new UMS_1Entities();
            var data = db.departments.ToList();
            return View(data);
        }
        public ActionResult Details(int Id)
        {
            var db = new UMS_1Entities();
            var data = (from d in db.departments
                        where d.Id == Id
                        select d).FirstOrDefault();
            return View(data);
        }
    }
}
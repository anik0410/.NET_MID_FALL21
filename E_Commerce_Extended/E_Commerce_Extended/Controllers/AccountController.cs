using E_Commerce_Extended.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce_Extended.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            User u = new User();
            return View(u);
        }
        [HttpPost]
        public ActionResult Register(User u)
        {
            if (ModelState.IsValid)
            {
                var db = new PMSEntities();
                db.Users.Add(u);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(u);
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}
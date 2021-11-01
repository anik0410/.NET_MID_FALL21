﻿using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CRUD.Controllers
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
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Username,string Password)
        {
            var db = new Database();
            var user = db.Users.Authenticate(Username, Password);
            if(user != null)
            {
                //Session["Logged"] = "Tanvir";
                FormsAuthentication.SetAuthCookie(user.Name,true);
                return RedirectToAction("Index", "Student");
            }
            return View();
        }
    }
}
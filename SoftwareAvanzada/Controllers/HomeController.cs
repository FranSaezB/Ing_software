﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwareAvanzada.Controllers
{
    public class HomeController : Controller
    {
        public object ViewBag { get; private set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registro()
        {
  
            
            return View();
        }
        public ActionResult RegistroTurista()
        {
            return View();
        }

        public ActionResult Login()
        {

            return View();
        }
    }
}
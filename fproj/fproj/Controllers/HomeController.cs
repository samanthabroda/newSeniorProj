﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fproj.Controllers
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

        public ActionResult FAQ()
        {
            ViewBag.Message = "Frequently asked questions about TRIO.";
            return View();
        }

        public ActionResult Events()
        {
            ViewBag.Message = "This is a test";
            return View();
        }

        public ActionResult Appointments()
        {
            ViewBag.Message = "This is a test";
            return View();
        }
        public ActionResult MProfile()
        {
            ViewBag.Message = "This is a test";
            return View();
        }

        public ActionResult Calendar()
        {
            ViewBag.Message = "This is a test";
            return View();
        }

        public ActionResult Dashboard()
        {
            ViewBag.Message = "This is a test";
            return View();
        }

        public ActionResult Messages()
        {
            ViewBag.Message = "This is a test";
            return View();
        }

        public ActionResult MFiles()
        {
            ViewBag.Message = "This is a test";
            return View();
        }

        public ActionResult AdminEntry()
        {
            return View();
        }

        public ActionResult CounselorEditProfile()
        {
            return View();
        }

        public ActionResult CounselorProfile()
        {
            return View();
        }

        public ActionResult StudentProfile()
        {
            return View();
        }


        public ActionResult StudentEditProfile()
        {
            return View();
        }

        public ActionResult TLCProfile()
        {
            return View();
        }

        public ActionResult TLCEditProfile()
        {
            return View();
        }

        public ActionResult AdminProfile()
        {
            return View();
        }

        public ActionResult AdminEditProfile()
        {
            return View();
        }
    }
}
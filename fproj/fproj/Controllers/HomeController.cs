using System;
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
            return Redirect("~/ASPX_Files/AdminEntry.aspx");
        }

        public ActionResult CounselorEditProfile()
        {
            return Redirect("~/ASPX_Files/CounselorEditProfile.aspx");
        }

        public ActionResult CounselorProfile()
        {
            return Redirect("~/ASPX_Files/CounselorProfile.aspx");
        }

        public ActionResult StudentProfile()
        {
            return Redirect("~/ASPX_Files/StudentProfile.aspx");
        }


        public ActionResult StudentEditProfile()
        {
            return Redirect("~/ASPX_Files/StudentEditProfile.aspx");
        }

        public ActionResult TLCProfile()
        {
            return Redirect("~/ASPX_Files/TLCProfile.aspx");
        }

        public ActionResult TLCEditProfile()
        {
            return Redirect("~/ASPX_Files/TLCEditProfile.aspx");
        }

        public ActionResult AdminProfile()
        {
            return Redirect("~/ASPX_Files/AdminProfile.aspx"); ;
        }

        public ActionResult AdminEditProfile()
        {
            return Redirect("~/ASPX_Files/AdminEditProfile.aspx");
        }

        public ActionResult StudentEntry()
        {
            return Redirect("~/ASPX_Files/StudentEntry.aspx");
        }

        public ActionResult TLCEntry()
        {
            return Redirect("~/ASPX_Files/TLCEntry.aspx");
        }

        public ActionResult CounselorEntry()
        {
            return Redirect("~/ASPX_Files/CounselorEntry.aspx");
        }
    }
}
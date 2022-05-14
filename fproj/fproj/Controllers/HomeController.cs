using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using Humanizer;
using Humanizer.Localisation;
using Humanizer.Localisation.NumberToWords;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            SqlConnection b = new SqlConnection(@"Data Source=DESKTOP-DOT3O9P,1434; Initial Catalog=master; User Id=maliksimrah; Password=@Farmingdale123");
            SqlCommand cmd = new SqlCommand("SELECT * FROM FAQ", b);
            var model = new List<Models.FAQEntry>();
            b.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                var faqent = new Models.FAQEntry();
                faqent.QuestionID1 = (int)rdr["QuestionID"];
                var value = faqent.QuestionID1.ToWords();
                var sval = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());
                faqent.QuestionIDWord = sval;
                faqent.QuestionValue = (string)rdr["Question"];
                faqent.AnswerValue = (string)rdr["Answer"];
                model.Add(faqent);
            }
            b.Close();
            return View(model);
        }

        public ActionResult FAQEdit()
        {
            SqlConnection b = new SqlConnection(@"Data Source=DESKTOP-DOT3O9P,1434; Initial Catalog=master; User Id=maliksimrah; Password=@Farmingdale123");
            SqlCommand cmd = new SqlCommand("SELECT * FROM FAQ", b);
            var model = new List<Models.FAQEntry>();
            b.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                var faqent = new Models.FAQEntry();
                faqent.QuestionID1 = (int)rdr["QuestionID"];
                faqent.QuestionValue = (string)rdr["Question"];
                faqent.AnswerValue = (string)rdr["Answer"];
                model.Add(faqent);
            }
            b.Close();
            return View(model);
        }

        public ActionResult FAQAdd()
        {
            SqlConnection b = new SqlConnection(@"Data Source=DESKTOP-DOT3O9P,1434; Initial Catalog=master; User Id=maliksimrah; Password=@Farmingdale123");
            b.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO FAQ VALUES ('insert question here', 'insert answer here')", b);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM FAQ", b);
            var model = new List<Models.FAQEntry>();
            SqlDataReader rdr = cmd2.ExecuteReader();
            while (rdr.Read())
            {
                var faqent = new Models.FAQEntry();
                faqent.QuestionID1 = (int)rdr["QuestionID"];
                faqent.QuestionValue = (string)rdr["Question"];
                faqent.AnswerValue = (string)rdr["Answer"];
                model.Add(faqent);
            }
            b.Close();
            return View(model);
        }

        public ActionResult FAQDelete(int value)
        {
            SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-DOT3O9P,1434; Initial Catalog=master; User Id=maliksimrah; Password=@Farmingdale123");
            c.Open();
            SqlCommand quest = new SqlCommand($"DELETE FROM FAQ WHERE QuestionID={value}", c);
            quest.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM FAQ", c);
            var model = new List<Models.FAQEntry>();
            SqlDataReader rdr = cmd2.ExecuteReader();
            while (rdr.Read())
            {
                var faqent = new Models.FAQEntry();
                faqent.QuestionID1 = (int)rdr["QuestionID"];
                faqent.QuestionValue = (string)rdr["Question"];
                faqent.AnswerValue = (string)rdr["Answer"];
                model.Add(faqent);
            }
            c.Close();
            return View(model);
        }

        public ActionResult FAQSaveEdit(int value)
        {
            SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-DOT3O9P,1434; Initial Catalog=master; User Id=maliksimrah; Password=@Farmingdale123");
            c.Open();
            string gr = Request.Form[$"questfor{value}"].ToString();
            string gre = Request.Form[$"ansfor{value}"].ToString();

            SqlCommand cmd = new SqlCommand($"UPDATE FAQ SET Question={gr}, Answer={gre} WHERE QuestionID={value}", c);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM FAQ", c);
            var model = new List<Models.FAQEntry>();
            SqlDataReader rdr = cmd2.ExecuteReader();
            while (rdr.Read())
            {
                var faqent = new Models.FAQEntry();
                faqent.QuestionID1 = (int)rdr["QuestionID"];
                faqent.QuestionValue = (string)rdr["Question"];
                faqent.AnswerValue = (string)rdr["Answer"];
                model.Add(faqent);
            }
            c.Close();
            return View(model);
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

        public ActionResult StudentEntry()
        {
            return View();
        }

    }
}